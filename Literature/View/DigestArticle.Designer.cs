namespace Literature.View
{
    partial class DigestArticle
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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelArticleTitle = new System.Windows.Forms.Label();
            this.labelDigestTitle = new System.Windows.Forms.Label();
            this.labelEditionTown = new System.Windows.Forms.Label();
            this.labelEditionTitle = new System.Windows.Forms.Label();
            this.labelEditionYear = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxArticleTitle = new System.Windows.Forms.TextBox();
            this.textBoxDigestTitle = new System.Windows.Forms.TextBox();
            this.textBoxEditionTown = new System.Windows.Forms.TextBox();
            this.textBoxEditionTitle = new System.Windows.Forms.TextBox();
            this.textBoxEditionYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(193, 272);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(-3, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(282, 13);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "1. Фамилия, инициалы автра/авторов, через запятую";
            // 
            // labelArticleTitle
            // 
            this.labelArticleTitle.AutoSize = true;
            this.labelArticleTitle.Location = new System.Drawing.Point(-3, 48);
            this.labelArticleTitle.Name = "labelArticleTitle";
            this.labelArticleTitle.Size = new System.Drawing.Size(280, 13);
            this.labelArticleTitle.TabIndex = 2;
            this.labelArticleTitle.Text = "2. Название статьи из книги / составной части книги";
            // 
            // labelDigestTitle
            // 
            this.labelDigestTitle.AutoSize = true;
            this.labelDigestTitle.Location = new System.Drawing.Point(-3, 87);
            this.labelDigestTitle.Name = "labelDigestTitle";
            this.labelDigestTitle.Size = new System.Drawing.Size(212, 13);
            this.labelDigestTitle.TabIndex = 3;
            this.labelDigestTitle.Text = "3. Название сборника (автор, название)";
            // 
            // labelEditionTown
            // 
            this.labelEditionTown.Location = new System.Drawing.Point(-3, 126);
            this.labelEditionTown.Name = "labelEditionTown";
            this.labelEditionTown.Size = new System.Drawing.Size(294, 29);
            this.labelEditionTown.TabIndex = 4;
            this.labelEditionTown.Text = "4. Город издательства (М. СПб. - сокращенно с точкой, другие города пишутся полно" +
    "стью без точки)";
            // 
            // labelEditionTitle
            // 
            this.labelEditionTitle.AutoSize = true;
            this.labelEditionTitle.Location = new System.Drawing.Point(-3, 183);
            this.labelEditionTitle.Name = "labelEditionTitle";
            this.labelEditionTitle.Size = new System.Drawing.Size(114, 13);
            this.labelEditionTitle.TabIndex = 5;
            this.labelEditionTitle.Text = "5. Название издания";
            // 
            // labelEditionYear
            // 
            this.labelEditionYear.AutoSize = true;
            this.labelEditionYear.Location = new System.Drawing.Point(-3, 225);
            this.labelEditionYear.Name = "labelEditionYear";
            this.labelEditionYear.Size = new System.Drawing.Size(82, 13);
            this.labelEditionYear.TabIndex = 6;
            this.labelEditionYear.Text = "6. Год издания";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(11, 25);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(257, 20);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // textBoxArticleTitle
            // 
            this.textBoxArticleTitle.Location = new System.Drawing.Point(12, 64);
            this.textBoxArticleTitle.Name = "textBoxArticleTitle";
            this.textBoxArticleTitle.Size = new System.Drawing.Size(256, 20);
            this.textBoxArticleTitle.TabIndex = 8;
            // 
            // textBoxDigestTitle
            // 
            this.textBoxDigestTitle.Location = new System.Drawing.Point(12, 103);
            this.textBoxDigestTitle.Name = "textBoxDigestTitle";
            this.textBoxDigestTitle.Size = new System.Drawing.Size(256, 20);
            this.textBoxDigestTitle.TabIndex = 9;
            // 
            // textBoxEditionTown
            // 
            this.textBoxEditionTown.Location = new System.Drawing.Point(12, 158);
            this.textBoxEditionTown.Name = "textBoxEditionTown";
            this.textBoxEditionTown.Size = new System.Drawing.Size(256, 20);
            this.textBoxEditionTown.TabIndex = 10;
            // 
            // textBoxEditionTitle
            // 
            this.textBoxEditionTitle.Location = new System.Drawing.Point(11, 199);
            this.textBoxEditionTitle.Name = "textBoxEditionTitle";
            this.textBoxEditionTitle.Size = new System.Drawing.Size(257, 20);
            this.textBoxEditionTitle.TabIndex = 11;
            // 
            // textBoxEditionYear
            // 
            this.textBoxEditionYear.Location = new System.Drawing.Point(11, 241);
            this.textBoxEditionYear.Name = "textBoxEditionYear";
            this.textBoxEditionYear.Size = new System.Drawing.Size(257, 20);
            this.textBoxEditionYear.TabIndex = 12;
            // 
            // DigestArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 307);
            this.Controls.Add(this.textBoxEditionYear);
            this.Controls.Add(this.textBoxEditionTitle);
            this.Controls.Add(this.textBoxEditionTown);
            this.Controls.Add(this.textBoxDigestTitle);
            this.Controls.Add(this.textBoxArticleTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelEditionYear);
            this.Controls.Add(this.labelEditionTitle);
            this.Controls.Add(this.labelEditionTown);
            this.Controls.Add(this.labelDigestTitle);
            this.Controls.Add(this.labelArticleTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonOK);
            this.Name = "DigestArticle";
            this.Text = "DigestArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelArticleTitle;
        private System.Windows.Forms.Label labelDigestTitle;
        private System.Windows.Forms.Label labelEditionTown;
        private System.Windows.Forms.Label labelEditionTitle;
        private System.Windows.Forms.Label labelEditionYear;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxArticleTitle;
        private System.Windows.Forms.TextBox textBoxDigestTitle;
        private System.Windows.Forms.TextBox textBoxEditionTown;
        private System.Windows.Forms.TextBox textBoxEditionTitle;
        private System.Windows.Forms.TextBox textBoxEditionYear;
    }
}