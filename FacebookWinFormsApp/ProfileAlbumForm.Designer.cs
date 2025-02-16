namespace BasicFacebookFeatures
{
    partial class ProfileAlbumForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.zoomInEffectButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fadeInEffectButton = new System.Windows.Forms.Button();
            this.slideInEffectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 213);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // zoomInEffectButton
            // 
            this.zoomInEffectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.zoomInEffectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.zoomInEffectButton.Location = new System.Drawing.Point(-2, 0);
            this.zoomInEffectButton.Margin = new System.Windows.Forms.Padding(2);
            this.zoomInEffectButton.Name = "zoomInEffectButton";
            this.zoomInEffectButton.Size = new System.Drawing.Size(133, 33);
            this.zoomInEffectButton.TabIndex = 0;
            this.zoomInEffectButton.Text = "Zoom In Effect ";
            this.zoomInEffectButton.UseVisualStyleBackColor = false;
            this.zoomInEffectButton.Click += new System.EventHandler(this.zoomInEffectButton_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.defaultButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.defaultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultButton.ForeColor = System.Drawing.SystemColors.Control;
            this.defaultButton.Location = new System.Drawing.Point(0, 283);
            this.defaultButton.Margin = new System.Windows.Forms.Padding(1);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(455, 34);
            this.defaultButton.TabIndex = 1;
            this.defaultButton.Text = "No Effect";
            this.defaultButton.UseVisualStyleBackColor = false;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fadeInEffectButton);
            this.panel1.Controls.Add(this.slideInEffectButton);
            this.panel1.Controls.Add(this.zoomInEffectButton);
            this.panel1.Location = new System.Drawing.Point(2, 216);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 32);
            this.panel1.TabIndex = 2;
            // 
            // fadeInEffectButton
            // 
            this.fadeInEffectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.fadeInEffectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.fadeInEffectButton.Location = new System.Drawing.Point(316, 1);
            this.fadeInEffectButton.Margin = new System.Windows.Forms.Padding(2);
            this.fadeInEffectButton.Name = "fadeInEffectButton";
            this.fadeInEffectButton.Size = new System.Drawing.Size(134, 32);
            this.fadeInEffectButton.TabIndex = 2;
            this.fadeInEffectButton.Text = "Fade In Effect";
            this.fadeInEffectButton.UseVisualStyleBackColor = false;
            this.fadeInEffectButton.Click += new System.EventHandler(this.fadeInEffectButton_Click);
            // 
            // slideInEffectButton
            // 
            this.slideInEffectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.slideInEffectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.slideInEffectButton.Location = new System.Drawing.Point(156, 1);
            this.slideInEffectButton.Margin = new System.Windows.Forms.Padding(2);
            this.slideInEffectButton.Name = "slideInEffectButton";
            this.slideInEffectButton.Size = new System.Drawing.Size(133, 32);
            this.slideInEffectButton.TabIndex = 1;
            this.slideInEffectButton.Text = "Slide In Effect";
            this.slideInEffectButton.UseVisualStyleBackColor = false;
            this.slideInEffectButton.Click += new System.EventHandler(this.slideInEffectButton_Click);
            // 
            // ProfileAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 317);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ProfileAlbumForm";
            this.Text = "ProfileAlbumForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Button zoomInEffectButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fadeInEffectButton;
        private System.Windows.Forms.Button slideInEffectButton;
    }
}