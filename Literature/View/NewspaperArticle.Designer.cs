namespace Literature.View
{
    partial class NewspaperArticle
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
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxArticleTitle = new System.Windows.Forms.TextBox();
            this.textBoxNewspaperTitle = new System.Windows.Forms.TextBox();
            this.textBoxEditionYear = new System.Windows.Forms.TextBox();
            this.textBoxRelease = new System.Windows.Forms.TextBox();
            this.textBoxArticleNumber = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelArticleTitle = new System.Windows.Forms.Label();
            this.labelNewspaperTitle = new System.Windows.Forms.Label();
            this.labelEditionYear = new System.Windows.Forms.Label();
            this.labelRelease = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelArticleNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(12, 25);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(268, 20);
            this.textBoxAuthor.TabIndex = 0;
            // 
            // textBoxArticleTitle
            // 
            this.textBoxArticleTitle.Location = new System.Drawing.Point(12, 64);
            this.textBoxArticleTitle.Name = "textBoxArticleTitle";
            this.textBoxArticleTitle.Size = new System.Drawing.Size(268, 20);
            this.textBoxArticleTitle.TabIndex = 1;
            // 
            // textBoxNewspaperTitle
            // 
            this.textBoxNewspaperTitle.Location = new System.Drawing.Point(12, 103);
            this.textBoxNewspaperTitle.Name = "textBoxNewspaperTitle";
            this.textBoxNewspaperTitle.Size = new System.Drawing.Size(268, 20);
            this.textBoxNewspaperTitle.TabIndex = 2;
            // 
            // textBoxEditionYear
            // 
            this.textBoxEditionYear.Location = new System.Drawing.Point(12, 142);
            this.textBoxEditionYear.Name = "textBoxEditionYear";
            this.textBoxEditionYear.Size = new System.Drawing.Size(268, 20);
            this.textBoxEditionYear.TabIndex = 3;
            // 
            // textBoxRelease
            // 
            this.textBoxRelease.Location = new System.Drawing.Point(12, 181);
            this.textBoxRelease.Name = "textBoxRelease";
            this.textBoxRelease.Size = new System.Drawing.Size(268, 20);
            this.textBoxRelease.TabIndex = 4;
            // 
            // textBoxArticleNumber
            // 
            this.textBoxArticleNumber.Location = new System.Drawing.Point(12, 220);
            this.textBoxArticleNumber.Name = "textBoxArticleNumber";
            this.textBoxArticleNumber.Size = new System.Drawing.Size(268, 20);
            this.textBoxArticleNumber.TabIndex = 5;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(-3, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(282, 13);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "1. Фамилия, инициалы автра/авторов, через запятую";
            // 
            // labelArticleTitle
            // 
            this.labelArticleTitle.AutoSize = true;
            this.labelArticleTitle.Location = new System.Drawing.Point(-3, 48);
            this.labelArticleTitle.Name = "labelArticleTitle";
            this.labelArticleTitle.Size = new System.Drawing.Size(106, 13);
            this.labelArticleTitle.TabIndex = 7;
            this.labelArticleTitle.Text = "2. Название статьи";
            // 
            // labelNewspaperTitle
            // 
            this.labelNewspaperTitle.AutoSize = true;
            this.labelNewspaperTitle.Location = new System.Drawing.Point(-3, 87);
            this.labelNewspaperTitle.Name = "labelNewspaperTitle";
            this.labelNewspaperTitle.Size = new System.Drawing.Size(108, 13);
            this.labelNewspaperTitle.TabIndex = 8;
            this.labelNewspaperTitle.Text = "3. Название газеты";
            // 
            // labelEditionYear
            // 
            this.labelEditionYear.AutoSize = true;
            this.labelEditionYear.Location = new System.Drawing.Point(-3, 126);
            this.labelEditionYear.Name = "labelEditionYear";
            this.labelEditionYear.Size = new System.Drawing.Size(82, 13);
            this.labelEditionYear.TabIndex = 9;
            this.labelEditionYear.Text = "4. Год издания";
            // 
            // labelRelease
            // 
            this.labelRelease.AutoSize = true;
            this.labelRelease.Location = new System.Drawing.Point(-3, 165);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(200, 13);
            this.labelRelease.TabIndex = 10;
            this.labelRelease.Text = "5. Дата выхода газеты (число, месяц)";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(205, 255);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelArticleNumber
            // 
            this.labelArticleNumber.AutoSize = true;
            this.labelArticleNumber.Location = new System.Drawing.Point(-3, 204);
            this.labelArticleNumber.Name = "labelArticleNumber";
            this.labelArticleNumber.Size = new System.Drawing.Size(90, 13);
            this.labelArticleNumber.TabIndex = 12;
            this.labelArticleNumber.Text = "6. Номер статьи";
            // 
            // NewspaperArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 283);
            this.Controls.Add(this.labelArticleNumber);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelRelease);
            this.Controls.Add(this.labelEditionYear);
            this.Controls.Add(this.labelNewspaperTitle);
            this.Controls.Add(this.labelArticleTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxArticleNumber);
            this.Controls.Add(this.textBoxRelease);
            this.Controls.Add(this.textBoxEditionYear);
            this.Controls.Add(this.textBoxNewspaperTitle);
            this.Controls.Add(this.textBoxArticleTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Name = "NewspaperArticle";
            this.Text = "NewspaperArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxArticleTitle;
        private System.Windows.Forms.TextBox textBoxNewspaperTitle;
        private System.Windows.Forms.TextBox textBoxEditionYear;
        private System.Windows.Forms.TextBox textBoxRelease;
        private System.Windows.Forms.TextBox textBoxArticleNumber;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelArticleTitle;
        private System.Windows.Forms.Label labelNewspaperTitle;
        private System.Windows.Forms.Label labelEditionYear;
        private System.Windows.Forms.Label labelRelease;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelArticleNumber;
    }
}