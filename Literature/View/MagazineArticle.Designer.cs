namespace Literature.View
{
    partial class MagazineArticle
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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelArticleTitle = new System.Windows.Forms.Label();
            this.labelMagazineTitle = new System.Windows.Forms.Label();
            this.labelEditionYear = new System.Windows.Forms.Label();
            this.labelMagazineNumber = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxMagazineTitle = new System.Windows.Forms.TextBox();
            this.textBoxArticleTitle = new System.Windows.Forms.TextBox();
            this.textBoxEditionYear = new System.Windows.Forms.TextBox();
            this.textBoxMagazineNumber = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(0, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(282, 13);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "1. Фамилия, инициалы автра/авторов, через запятую";
            // 
            // labelArticleTitle
            // 
            this.labelArticleTitle.AutoSize = true;
            this.labelArticleTitle.Location = new System.Drawing.Point(0, 48);
            this.labelArticleTitle.Name = "labelArticleTitle";
            this.labelArticleTitle.Size = new System.Drawing.Size(106, 13);
            this.labelArticleTitle.TabIndex = 1;
            this.labelArticleTitle.Text = "2. Название статьи";
            // 
            // labelMagazineTitle
            // 
            this.labelMagazineTitle.AutoSize = true;
            this.labelMagazineTitle.Location = new System.Drawing.Point(0, 87);
            this.labelMagazineTitle.Name = "labelMagazineTitle";
            this.labelMagazineTitle.Size = new System.Drawing.Size(115, 13);
            this.labelMagazineTitle.TabIndex = 2;
            this.labelMagazineTitle.Text = "3. Название журнала";
            // 
            // labelEditionYear
            // 
            this.labelEditionYear.AutoSize = true;
            this.labelEditionYear.Location = new System.Drawing.Point(0, 126);
            this.labelEditionYear.Name = "labelEditionYear";
            this.labelEditionYear.Size = new System.Drawing.Size(82, 13);
            this.labelEditionYear.TabIndex = 3;
            this.labelEditionYear.Text = "4. Год издания";
            // 
            // labelMagazineNumber
            // 
            this.labelMagazineNumber.AutoSize = true;
            this.labelMagazineNumber.Location = new System.Drawing.Point(0, 165);
            this.labelMagazineNumber.Name = "labelMagazineNumber";
            this.labelMagazineNumber.Size = new System.Drawing.Size(99, 13);
            this.labelMagazineNumber.TabIndex = 4;
            this.labelMagazineNumber.Text = "5. Номер журнала";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(3, 25);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(279, 20);
            this.textBoxAuthor.TabIndex = 5;
            // 
            // textBoxMagazineTitle
            // 
            this.textBoxMagazineTitle.Location = new System.Drawing.Point(3, 103);
            this.textBoxMagazineTitle.Name = "textBoxMagazineTitle";
            this.textBoxMagazineTitle.Size = new System.Drawing.Size(277, 20);
            this.textBoxMagazineTitle.TabIndex = 6;
            // 
            // textBoxArticleTitle
            // 
            this.textBoxArticleTitle.Location = new System.Drawing.Point(3, 64);
            this.textBoxArticleTitle.Name = "textBoxArticleTitle";
            this.textBoxArticleTitle.Size = new System.Drawing.Size(277, 20);
            this.textBoxArticleTitle.TabIndex = 7;
            // 
            // textBoxEditionYear
            // 
            this.textBoxEditionYear.Location = new System.Drawing.Point(3, 142);
            this.textBoxEditionYear.Name = "textBoxEditionYear";
            this.textBoxEditionYear.Size = new System.Drawing.Size(277, 20);
            this.textBoxEditionYear.TabIndex = 8;
            // 
            // textBoxMagazineNumber
            // 
            this.textBoxMagazineNumber.Location = new System.Drawing.Point(3, 181);
            this.textBoxMagazineNumber.Name = "textBoxMagazineNumber";
            this.textBoxMagazineNumber.Size = new System.Drawing.Size(277, 20);
            this.textBoxMagazineNumber.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(205, 212);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // MagazineArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 247);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxMagazineNumber);
            this.Controls.Add(this.textBoxEditionYear);
            this.Controls.Add(this.textBoxArticleTitle);
            this.Controls.Add(this.textBoxMagazineTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelMagazineNumber);
            this.Controls.Add(this.labelEditionYear);
            this.Controls.Add(this.labelMagazineTitle);
            this.Controls.Add(this.labelArticleTitle);
            this.Controls.Add(this.labelAuthor);
            this.Name = "MagazineArticle";
            this.Text = "MagazineArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelArticleTitle;
        private System.Windows.Forms.Label labelMagazineTitle;
        private System.Windows.Forms.Label labelEditionYear;
        private System.Windows.Forms.Label labelMagazineNumber;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxMagazineTitle;
        private System.Windows.Forms.TextBox textBoxArticleTitle;
        private System.Windows.Forms.TextBox textBoxEditionYear;
        private System.Windows.Forms.TextBox textBoxMagazineNumber;
        private System.Windows.Forms.Button buttonOK;
    }
}