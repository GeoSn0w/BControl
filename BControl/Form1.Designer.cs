namespace BControl
{
    partial class VisualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualForm));
            this.BrightnessController = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetVideoCardInfo = new System.Windows.Forms.Button();
            this.CloseAppX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessController)).BeginInit();
            this.SuspendLayout();
            // 
            // BrightnessController
            // 
            this.BrightnessController.Location = new System.Drawing.Point(12, 35);
            this.BrightnessController.Maximum = 100;
            this.BrightnessController.Name = "BrightnessController";
            this.BrightnessController.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BrightnessController.Size = new System.Drawing.Size(45, 376);
            this.BrightnessController.TabIndex = 0;
            this.BrightnessController.Scroll += new System.EventHandler(this.BrightnessController_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum";
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.White;
            this.LogoLabel.Location = new System.Drawing.Point(0, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(86, 25);
            this.LogoLabel.TabIndex = 3;
            this.LogoLabel.Text = "BControl";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "by GeoSn0w";
            // 
            // GetVideoCardInfo
            // 
            this.GetVideoCardInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GetVideoCardInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetVideoCardInfo.ForeColor = System.Drawing.Color.White;
            this.GetVideoCardInfo.Location = new System.Drawing.Point(11, 425);
            this.GetVideoCardInfo.Name = "GetVideoCardInfo";
            this.GetVideoCardInfo.Size = new System.Drawing.Size(107, 23);
            this.GetVideoCardInfo.TabIndex = 5;
            this.GetVideoCardInfo.Text = "Video Card Info";
            this.GetVideoCardInfo.UseVisualStyleBackColor = true;
            this.GetVideoCardInfo.Click += new System.EventHandler(this.GetVideoCardInfo_Click);
            // 
            // CloseAppX
            // 
            this.CloseAppX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppX.AutoSize = true;
            this.CloseAppX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAppX.ForeColor = System.Drawing.Color.RosyBrown;
            this.CloseAppX.Location = new System.Drawing.Point(87, -1);
            this.CloseAppX.Name = "CloseAppX";
            this.CloseAppX.Size = new System.Drawing.Size(45, 25);
            this.CloseAppX.TabIndex = 6;
            this.CloseAppX.Text = "[ X ]";
            this.CloseAppX.Click += new System.EventHandler(this.CloseAppX_Click);
            // 
            // VisualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(129, 498);
            this.Controls.Add(this.CloseAppX);
            this.Controls.Add(this.GetVideoCardInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrightnessController);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BControl";
            this.Load += new System.EventHandler(this.VisualForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar BrightnessController;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetVideoCardInfo;
        private System.Windows.Forms.Label CloseAppX;
    }
}

