namespace Question2
{
    partial class DisplayTitle
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
            this.components = new System.ComponentModel.Container();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTitleSort = new System.Windows.Forms.Button();
            this.btnAuthorSort = new System.Windows.Forms.Button();
            this.btnGroupAuthors = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(BooksExample.Title);
            // 
            // btnTitleSort
            // 
            this.btnTitleSort.Location = new System.Drawing.Point(47, 338);
            this.btnTitleSort.Name = "btnTitleSort";
            this.btnTitleSort.Size = new System.Drawing.Size(124, 23);
            this.btnTitleSort.TabIndex = 2;
            this.btnTitleSort.Text = "Sort Titles";
            this.btnTitleSort.UseVisualStyleBackColor = true;
            this.btnTitleSort.Click += new System.EventHandler(this.btnTitleSort_Click);
            // 
            // btnAuthorSort
            // 
            this.btnAuthorSort.Location = new System.Drawing.Point(177, 338);
            this.btnAuthorSort.Name = "btnAuthorSort";
            this.btnAuthorSort.Size = new System.Drawing.Size(124, 23);
            this.btnAuthorSort.TabIndex = 3;
            this.btnAuthorSort.Text = "Sort Authors";
            this.btnAuthorSort.UseVisualStyleBackColor = true;
            this.btnAuthorSort.Click += new System.EventHandler(this.btnAuthorSort_Click);
            // 
            // btnGroupAuthors
            // 
            this.btnGroupAuthors.Location = new System.Drawing.Point(307, 338);
            this.btnGroupAuthors.Name = "btnGroupAuthors";
            this.btnGroupAuthors.Size = new System.Drawing.Size(124, 23);
            this.btnGroupAuthors.TabIndex = 4;
            this.btnGroupAuthors.Text = "Group Authors by Title";
            this.btnGroupAuthors.UseVisualStyleBackColor = true;
            this.btnGroupAuthors.Click += new System.EventHandler(this.btnGroupAuthors_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(47, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(384, 306);
            this.txtOutput.TabIndex = 5;
            // 
            // DisplayTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 381);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGroupAuthors);
            this.Controls.Add(this.btnAuthorSort);
            this.Controls.Add(this.btnTitleSort);
            this.Name = "DisplayTitle";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.DisplayTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.Button btnTitleSort;
        private System.Windows.Forms.Button btnAuthorSort;
        private System.Windows.Forms.Button btnGroupAuthors;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

