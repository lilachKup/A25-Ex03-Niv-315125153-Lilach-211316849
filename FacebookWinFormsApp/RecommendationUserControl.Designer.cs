namespace BasicFacebookFeatures
{
    partial class RecommendationUserControl
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
            this.recommendationTitle = new System.Windows.Forms.Label();
            this.recommendationTextBox1 = new System.Windows.Forms.TextBox();
            this.recommendationTextBox2 = new System.Windows.Forms.TextBox();
            this.recommendationRate1 = new System.Windows.Forms.TrackBar();
            this.recommendationRate2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationRate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationRate2)).BeginInit();
            this.SuspendLayout();
            // 
            // recommendationTitle
            // 
            this.recommendationTitle.AutoSize = true;
            this.recommendationTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.recommendationTitle.Location = new System.Drawing.Point(0, 0);
            this.recommendationTitle.Name = "recommendationTitle";
            this.recommendationTitle.Size = new System.Drawing.Size(44, 16);
            this.recommendationTitle.TabIndex = 0;
            this.recommendationTitle.Text = "label1";
            // 
            // recommendationTextBox1
            // 
            this.recommendationTextBox1.Location = new System.Drawing.Point(0, 24);
            this.recommendationTextBox1.Multiline = true;
            this.recommendationTextBox1.Name = "recommendationTextBox1";
            this.recommendationTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recommendationTextBox1.Size = new System.Drawing.Size(159, 44);
            this.recommendationTextBox1.TabIndex = 1;
            this.recommendationTextBox1.TextChanged += new System.EventHandler(this.recommendationTextBox1_TextChanged);
            // 
            // recommendationTextBox2
            // 
            this.recommendationTextBox2.Location = new System.Drawing.Point(0, 75);
            this.recommendationTextBox2.Multiline = true;
            this.recommendationTextBox2.Name = "recommendationTextBox2";
            this.recommendationTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recommendationTextBox2.Size = new System.Drawing.Size(159, 44);
            this.recommendationTextBox2.TabIndex = 2;
            this.recommendationTextBox2.TextChanged += new System.EventHandler(this.recommendationTextBox2_TextChanged);
            // 
            // recommendationRate1
            // 
            this.recommendationRate1.Location = new System.Drawing.Point(167, 24);
            this.recommendationRate1.Name = "recommendationRate1";
            this.recommendationRate1.Size = new System.Drawing.Size(95, 56);
            this.recommendationRate1.TabIndex = 3;
            this.recommendationRate1.Visible = false;
            // 
            // recommendationRate2
            // 
            this.recommendationRate2.Location = new System.Drawing.Point(167, 75);
            this.recommendationRate2.Name = "recommendationRate2";
            this.recommendationRate2.Size = new System.Drawing.Size(95, 56);
            this.recommendationRate2.TabIndex = 4;
            this.recommendationRate2.Visible = false;
            // 
            // RecommendationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.recommendationRate2);
            this.Controls.Add(this.recommendationRate1);
            this.Controls.Add(this.recommendationTextBox2);
            this.Controls.Add(this.recommendationTextBox1);
            this.Controls.Add(this.recommendationTitle);
            this.Name = "RecommendationUserControl";
            this.Size = new System.Drawing.Size(280, 139);
            ((System.ComponentModel.ISupportInitialize)(this.recommendationRate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationRate2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recommendationTitle;
        private System.Windows.Forms.TextBox recommendationTextBox1;
        private System.Windows.Forms.TextBox recommendationTextBox2;
        private System.Windows.Forms.TrackBar recommendationRate1;
        private System.Windows.Forms.TrackBar recommendationRate2;
    }
}
