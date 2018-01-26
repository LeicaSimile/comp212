namespace assignment01
{
    partial class frmMain
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
            this.btnManageSub = new System.Windows.Forms.Button();
            this.btnPublishNotification = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageSub
            // 
            this.btnManageSub.Location = new System.Drawing.Point(21, 25);
            this.btnManageSub.Name = "btnManageSub";
            this.btnManageSub.Size = new System.Drawing.Size(136, 23);
            this.btnManageSub.TabIndex = 0;
            this.btnManageSub.Text = "Manage Subscription";
            this.btnManageSub.UseVisualStyleBackColor = true;
            // 
            // btnPublishNotification
            // 
            this.btnPublishNotification.Location = new System.Drawing.Point(163, 25);
            this.btnPublishNotification.Name = "btnPublishNotification";
            this.btnPublishNotification.Size = new System.Drawing.Size(136, 23);
            this.btnPublishNotification.TabIndex = 1;
            this.btnPublishNotification.Text = "Publish Notification";
            this.btnPublishNotification.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 84);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublishNotification);
            this.Controls.Add(this.btnManageSub);
            this.Name = "frmMain";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageSub;
        private System.Windows.Forms.Button btnPublishNotification;
        private System.Windows.Forms.Button btnExit;
    }
}

