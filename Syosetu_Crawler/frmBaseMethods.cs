using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using HtmlAgilityPack;
using System.IO;
using System.Threading;

namespace Syosetu_Crawler
{
    public partial class frmBase
    {
        /// <summary>
        /// 延遲時間(毫秒)
        /// </summary>
        private int delayTimeMilliSeconds = 0;
        /// <summary>
        /// 無法再次獲取資料判定，用於終止執行
        /// </summary>
        private bool cannotGetArticle = false;
        /// <summary>
        /// 文章list
        /// </summary>
        private static List<Novels> novels = new List<Novels>();
        /// <summary>
        /// 檢查資料是否填妥
        /// </summary>
        /// <returns></returns>
        private bool btnConfirmCheck()
        {
            if (tbxUrl.Text == "" || tbxUrl.Text == null)
                return false;
            if (tbxChStart.Text == "" && !chbxAllCh.Checked)
                return false;
            return true;
        }
        /// <summary>
        /// 開始獲取文章
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task startCrawlerAsync(string url)
        {
            #region httpClient (fail)
            //HttpClient httpClient = new HttpClient();
            //httpClient.Timeout = TimeSpan.FromSeconds(2);
            //string html = await httpClient.GetStringAsync(url);
            //HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            //htmlDocument.LoadHtml(html);
            #endregion

            #region webclient instead
            HtmlWeb webClient = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDocument = webClient.Load(url);
            #endregion
            Novels novel = new Novels();
            try
            {
                novel.Name = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("contents1")).FirstOrDefault().Descendants("a").FirstOrDefault().InnerText;
            }
            catch
            {
                cannotGetArticle = true;
                return;
            }
            lblNovelName.Text = novel.Name;
            novel.ChapterTitle = htmlDocument.DocumentNode.Descendants("p").Where(node => node.GetAttributeValue("class", "").Equals("novel_subtitle")).FirstOrDefault().InnerText;
            //內文格式較複雜，分段處理
            HtmlAgilityPack.HtmlNode originalArticle;
            originalArticle = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("novel_view")).FirstOrDefault();
            List<HtmlNode> articleList = new List<HtmlNode>();
            articleList = originalArticle.Descendants("p").ToList();
            foreach(HtmlNode article in articleList)
            {
                if (article.InnerText == "<br />")
                    novel.ChapterContext += "\r\n";
                else if(article.InnerText == "")
                    novel.ChapterContext += "\r\n";
                else
                    novel.ChapterContext += article.InnerText;
            }
            previewUpdate($"{novel.ChapterTitle}\r\n{novel.ChapterContext}");
            novels.Add(novel);
        }
        /// <summary>
        /// 刷新Preview欄位資料
        /// </summary>
        /// <param name="str"></param>
        private void previewUpdate(string str)
        {
            tbxROPreview.Text += str;
        }
        /// <summary>
        /// 匯出成txt檔案
        /// </summary>
        private void exportTxt()
        {
            if (novels.Count < 1)
                return;
            foreach(Novels novel in novels)
            {
                string folderPath = $".\\Novels_txt\\{novel.Name}\\";
                string fileName = $"{folderPath}{novel.ChapterTitle}.txt";
                string folderPathC = fileNameCorrect(folderPath);
                string fileNameC = fileNameCorrect(fileName);

                if (!Directory.Exists(folderPathC))
                    Directory.CreateDirectory(folderPathC);
                if (!File.Exists(fileNameC))
                {
                    FileStream fileStream = new FileStream(fileNameC, FileMode.Create);
                    fileStream.Close();
                }
               
                StreamWriter streamWriter = new StreamWriter(fileNameC);
                streamWriter.WriteLine(novel.ChapterContext);
                streamWriter.Close();
            }
        }
        /// <summary>
        /// 移除路徑中的非法字元
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string fileNameCorrect(string fileName)
        {
            fileName = fileName.Replace(" ", "");
            fileName = fileName.Replace("〜", "");
            fileName = fileName.Replace("、", "");
            fileName = fileName.Replace("《", "");
            fileName = fileName.Replace("》", "");
            fileName = fileName.Replace("。", "");
            fileName = fileName.Replace("\"", "");
            fileName = fileName.Replace("　", "");
            fileName = fileName.Replace("-", "");

            return fileName;
        }
        /// <summary>
        /// 時間延遲
        /// </summary>
        private void delay()
        {
            SpinWait.SpinUntil(()=> { return false; },delayTimeMilliSeconds);
        }
    }
}
