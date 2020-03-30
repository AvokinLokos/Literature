namespace Literature.View
{
    partial class InternetResource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxHeadline = new System.Windows.Forms.TextBox();
            this.textBoxSiteTitle = new System.Windows.Forms.TextBox();
            this.textBoxHyperlink = new System.Windows.Forms.TextBox();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.labelSiteTitle = new System.Windows.Forms.Label();
            this.labelHyperlink = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(192, 301);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxHeadline
            // 
            this.textBoxHeadline.Location = new System.Drawing.Point(12, 38);
            this.textBoxHeadline.Name = "textBoxHeadline";
            this.textBoxHeadline.Size = new System.Drawing.Size(255, 20);
            this.textBoxHeadline.TabIndex = 1;
            // 
            // textBoxSiteTitle
            // 
            this.textBoxSiteTitle.Location = new System.Drawing.Point(12, 77);
            this.textBoxSiteTitle.Name = "textBoxSiteTitle";
            this.textBoxSiteTitle.Size = new System.Drawing.Size(255, 20);
            this.textBoxSiteTitle.TabIndex = 2;
            // 
            // textBoxHyperlink
            // 
            this.textBoxHyperlink.Location = new System.Drawing.Point(12, 116);
            this.textBoxHyperlink.Name = "textBoxHyperlink";
            this.textBoxHyperlink.Size = new System.Drawing.Size(255, 20);
            this.textBoxHyperlink.TabIndex = 3;
            // 
            // labelHeadline
            // 
            this.labelHeadline.Location = new System.Drawing.Point(-1, 9);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(268, 26);
            this.labelHeadline.TabIndex = 5;
            this.labelHeadline.Text = "1. Заголовок статьи или другого документа. Если заголовок отсутствует - не указыв" +
    "ать";
            // 
            // labelSiteTitle
            // 
            this.labelSiteTitle.AutoSize = true;
            this.labelSiteTitle.Location = new System.Drawing.Point(-1, 61);
            this.labelSiteTitle.Name = "labelSiteTitle";
            this.labelSiteTitle.Size = new System.Drawing.Size(101, 13);
            this.labelSiteTitle.TabIndex = 6;
            this.labelSiteTitle.Text = "2. Название сайта";
            // 
            // labelHyperlink
            // 
            this.labelHyperlink.AutoSize = true;
            this.labelHyperlink.Location = new System.Drawing.Point(-1, 100);
            this.labelHyperlink.Name = "labelHyperlink";
            this.labelHyperlink.Size = new System.Drawing.Size(153, 13);
            this.labelHyperlink.TabIndex = 7;
            this.labelHyperlink.Text = "3. Гиперссылка на документ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(-1, 139);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(146, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "4. Дата обращения на сайт";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(12, 161);
            this.Date.Name = "Date";
            this.Date.TabIndex = 9;
            // 
            // InternetResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 330);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelHyperlink);
            this.Controls.Add(this.labelSiteTitle);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.textBoxHyperlink);
            this.Controls.Add(this.textBoxSiteTitle);
            this.Controls.Add(this.textBoxHeadline);
            this.Controls.Add(this.buttonOK);
            this.Name = "InternetResource";
            this.Text = "InternetResource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxHeadline;
        private System.Windows.Forms.TextBox textBoxSiteTitle;
        private System.Windows.Forms.TextBox textBoxHyperlink;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.Label labelSiteTitle;
        private System.Windows.Forms.Label labelHyperlink;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.MonthCalendar Date;
    }
}