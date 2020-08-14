namespace Syosetu_Crawler
{
    partial class frmBase
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.btnUrlConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxChStart = new System.Windows.Forms.TextBox();
            this.tbxChEnd = new System.Windows.Forms.TextBox();
            this.chbxAllCh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxROPreview = new System.Windows.Forms.TextBox();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnExportDb = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblNovelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDelayTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(53, 18);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(388, 25);
            this.tbxUrl.TabIndex = 1;
            // 
            // btnUrlConfirm
            // 
            this.btnUrlConfirm.Location = new System.Drawing.Point(458, 60);
            this.btnUrlConfirm.Name = "btnUrlConfirm";
            this.btnUrlConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnUrlConfirm.TabIndex = 2;
            this.btnUrlConfirm.Text = "Confirm";
            this.btnUrlConfirm.UseVisualStyleBackColor = true;
            this.btnUrlConfirm.Click += new System.EventHandler(this.btnUrlConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chapter Select From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "to";
            // 
            // tbxChStart
            // 
            this.tbxChStart.Location = new System.Drawing.Point(151, 59);
            this.tbxChStart.Name = "tbxChStart";
            this.tbxChStart.Size = new System.Drawing.Size(61, 25);
            this.tbxChStart.TabIndex = 7;
            this.tbxChStart.TextChanged += new System.EventHandler(this.tbxChStart_TextChanged);
            // 
            // tbxChEnd
            // 
            this.tbxChEnd.Location = new System.Drawing.Point(242, 59);
            this.tbxChEnd.Name = "tbxChEnd";
            this.tbxChEnd.Size = new System.Drawing.Size(61, 25);
            this.tbxChEnd.TabIndex = 8;
            // 
            // chbxAllCh
            // 
            this.chbxAllCh.AutoSize = true;
            this.chbxAllCh.Location = new System.Drawing.Point(341, 62);
            this.chbxAllCh.Name = "chbxAllCh";
            this.chbxAllCh.Size = new System.Drawing.Size(100, 19);
            this.chbxAllCh.TabIndex = 9;
            this.chbxAllCh.Text = "All Chapters";
            this.chbxAllCh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preview";
            // 
            // tbxROPreview
            // 
            this.tbxROPreview.Location = new System.Drawing.Point(12, 184);
            this.tbxROPreview.Multiline = true;
            this.tbxROPreview.Name = "tbxROPreview";
            this.tbxROPreview.ReadOnly = true;
            this.tbxROPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxROPreview.Size = new System.Drawing.Size(521, 225);
            this.tbxROPreview.TabIndex = 11;
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(12, 415);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(112, 23);
            this.btnExportTxt.TabIndex = 12;
            this.btnExportTxt.Text = "Export as Txt";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // btnExportDb
            // 
            this.btnExportDb.Location = new System.Drawing.Point(133, 415);
            this.btnExportDb.Name = "btnExportDb";
            this.btnExportDb.Size = new System.Drawing.Size(139, 23);
            this.btnExportDb.TabIndex = 13;
            this.btnExportDb.Text = "Export to database";
            this.btnExportDb.UseVisualStyleBackColor = true;
            this.btnExportDb.Visible = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(434, 415);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(99, 23);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "Clear all data";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblNovelName
            // 
            this.lblNovelName.AutoSize = true;
            this.lblNovelName.Location = new System.Drawing.Point(12, 151);
            this.lblNovelName.Name = "lblNovelName";
            this.lblNovelName.Size = new System.Drawing.Size(89, 15);
            this.lblNovelName.TabIndex = 15;
            this.lblNovelName.Text = "lblNovelName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Delay";
            // 
            // tbxDelayTime
            // 
            this.tbxDelayTime.Location = new System.Drawing.Point(493, 18);
            this.tbxDelayTime.Name = "tbxDelayTime";
            this.tbxDelayTime.Size = new System.Drawing.Size(40, 25);
            this.tbxDelayTime.TabIndex = 17;
            this.tbxDelayTime.Text = "1000";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.tbxDelayTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNovelName);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnExportDb);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.tbxROPreview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbxAllCh);
            this.Controls.Add(this.tbxChEnd);
            this.Controls.Add(this.tbxChStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUrlConfirm);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.label1);
            this.Name = "frmBase";
            this.Text = "小説家になろう Crawler";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Button btnUrlConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxChStart;
        private System.Windows.Forms.TextBox tbxChEnd;
        private System.Windows.Forms.CheckBox chbxAllCh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxROPreview;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnExportDb;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblNovelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDelayTime;
    }
}

