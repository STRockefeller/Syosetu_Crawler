using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syosetu_Crawler
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            lblNovelName.Text = "";
        }

        private void tbxChStart_TextChanged(object sender, EventArgs e)
        {
            tbxChEnd.Text = tbxChStart.Text;
            btnExportDb.Visible = false;
        }

        private void btnUrlConfirm_Click(object sender, EventArgs e)
        {
            if (!btnConfirmCheck())
                return;
            try
            {
                delayTimeMilliSeconds = Convert.ToInt32(tbxDelayTime.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if(chbxAllCh.Checked)
            {
                int i = 1;
                while(!cannotGetArticle)
                {
                    startCrawlerAsync($"{tbxUrl.Text}{i}/");
                    delay();
                    i++;
                }
                cannotGetArticle = false;
                MessageBox.Show("Finished");
            }
            else
            {
                try
                {
                    int startCh = Convert.ToInt32(tbxChStart.Text);
                    int endCh = Convert.ToInt32(tbxChEnd.Text);
                    for(int i = startCh;i<=endCh;i++)
                    {
                        startCrawlerAsync($"{tbxUrl.Text}{i}/");
                        delay();
                    }
                    MessageBox.Show("Finished");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            exportTxt();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbxROPreview.Text = "";
            cannotGetArticle = false;
            novels.Clear();
        }
    }
}
