namespace Literature.View
{
    partial class Book
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
            this.labelPublishing = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelEditionNumber = new System.Windows.Forms.Label();
            this.labelEditionTown = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublishing = new System.Windows.Forms.TextBox();
            this.textBoxEditionYear = new System.Windows.Forms.TextBox();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.textBoxEditionNumber = new System.Windows.Forms.TextBox();
            this.lableEditionYear = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPublishing
            // 
            this.labelPublishing.AutoSize = true;
            this.labelPublishing.Location = new System.Drawing.Point(-2, 186);
            this.labelPublishing.Name = "labelPublishing";
            this.labelPublishing.Size = new System.Drawing.Size(142, 13);
            this.labelPublishing.TabIndex = 0;
            this.labelPublishing.Text = "5. Название издательства";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(-2, 48);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(101, 13);
            this.labelBookTitle.TabIndex = 1;
            this.labelBookTitle.Text = "2. Название книги";
            // 
            // labelEditionNumber
            // 
            this.labelEditionNumber.AutoSize = true;
            this.labelEditionNumber.Location = new System.Drawing.Point(-2, 87);
            this.labelEditionNumber.Name = "labelEditionNumber";
            this.labelEditionNumber.Size = new System.Drawing.Size(154, 13);
            this.labelEditionNumber.TabIndex = 2;
            this.labelEditionNumber.Text = "3. Номер издания, если есть";
            // 
            // labelEditionTown
            // 
            this.labelEditionTown.Location = new System.Drawing.Point(-2, 126);
            this.labelEditionTown.Name = "labelEditionTown";
            this.labelEditionTown.Size = new System.Drawing.Size(295, 34);
            this.labelEditionTown.TabIndex = 3;
            this.labelEditionTown.Text = "4. Город издательства (М. СПб. - сокращенно с точкой, другие города пишутся полно" +
    "стью без точки)";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(-2, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(282, 13);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "1. Фамилия, инициалы автра/авторов, через запятую";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(12, 25);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(261, 20);
            this.textBoxAuthor.TabIndex = 5;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(12, 64);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(261, 20);
            this.textBoxBookTitle.TabIndex = 6;
            // 
            // textBoxPublishing
            // 
            this.textBoxPublishing.Location = new System.Drawing.Point(12, 202);
            this.textBoxPublishing.Name = "textBoxPublishing";
            this.textBoxPublishing.Size = new System.Drawing.Size(261, 20);
            this.textBoxPublishing.TabIndex = 7;
            // 
            // textBoxEditionYear
            // 
            this.textBoxEditionYear.Location = new System.Drawing.Point(12, 241);
            this.textBoxEditionYear.Name = "textBoxEditionYear";
            this.textBoxEditionYear.Size = new System.Drawing.Size(261, 20);
            this.textBoxEditionYear.TabIndex = 8;
            // 
            // textBoxTown
            // 
            this.textBoxTown.Location = new System.Drawing.Point(12, 163);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(261, 20);
            this.textBoxTown.TabIndex = 9;
            // 
            // textBoxEditionNumber
            // 
            this.textBoxEditionNumber.Location = new System.Drawing.Point(12, 103);
            this.textBoxEditionNumber.Name = "textBoxEditionNumber";
            this.textBoxEditionNumber.Size = new System.Drawing.Size(261, 20);
            this.textBoxEditionNumber.TabIndex = 10;
            // 
            // lableEditionYear
            // 
            this.lableEditionYear.AutoSize = true;
            this.lableEditionYear.Location = new System.Drawing.Point(-2, 225);
            this.lableEditionYear.Name = "lableEditionYear";
            this.lableEditionYear.Size = new System.Drawing.Size(82, 13);
            this.lableEditionYear.TabIndex = 11;
            this.lableEditionYear.Text = "6. Год издания";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(198, 267);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 22);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 292);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.lableEditionYear);
            this.Controls.Add(this.textBoxEditionNumber);
            this.Controls.Add(this.textBoxTown);
            this.Controls.Add(this.textBoxEditionYear);
            this.Controls.Add(this.textBoxPublishing);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelEditionTown);
            this.Controls.Add(this.labelEditionNumber);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.labelPublishing);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPublishing;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelEditionNumber;
        private System.Windows.Forms.Label labelEditionTown;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.TextBox textBoxPublishing;
        private System.Windows.Forms.TextBox textBoxEditionYear;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.TextBox textBoxEditionNumber;
        private System.Windows.Forms.Label lableEditionYear;
        private System.Windows.Forms.Button buttonOK;
    }
}