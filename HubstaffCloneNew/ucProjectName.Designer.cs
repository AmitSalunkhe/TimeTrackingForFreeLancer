namespace HubstaffCloneNew
{
    partial class ucProjectName
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProjectName));
            this.picPlayStop = new System.Windows.Forms.PictureBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblUCTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayStop)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayStop
            // 
            this.picPlayStop.Image = ((System.Drawing.Image)(resources.GetObject("picPlayStop.Image")));
            this.picPlayStop.Location = new System.Drawing.Point(3, 3);
            this.picPlayStop.Name = "picPlayStop";
            this.picPlayStop.Size = new System.Drawing.Size(43, 41);
            this.picPlayStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPlayStop.TabIndex = 0;
            this.picPlayStop.TabStop = false;
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProjectName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(52, 15);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(104, 19);
            this.lblProjectName.TabIndex = 7;
            this.lblProjectName.Text = "Project Name";
            // 
            // lblUCTime
            // 
            this.lblUCTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUCTime.AutoSize = true;
            this.lblUCTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUCTime.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCTime.ForeColor = System.Drawing.Color.Black;
            this.lblUCTime.Location = new System.Drawing.Point(273, 16);
            this.lblUCTime.Name = "lblUCTime";
            this.lblUCTime.Size = new System.Drawing.Size(41, 18);
            this.lblUCTime.TabIndex = 8;
            this.lblUCTime.Text = "Time";
            // 
            // ucProjectName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(186)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.lblUCTime);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.picPlayStop);
            this.Name = "ucProjectName";
            this.Size = new System.Drawing.Size(348, 47);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayStop;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblUCTime;
    }
}
