using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class RecommendationUserControl : UserControl
    {
        const bool v_HideControls = false;
        
        public RecommendationUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return recommendationTitle.Text; }
            set { recommendationTitle.Text = value; }
        }

        public TextBox RecommendationTextBox1
        {
            get { return recommendationTextBox1; }
        }

        public TextBox RecommendationTextBox2
        {
            get { return recommendationTextBox2; }
        }

        public TrackBar RecommendationRate1
        {
            get { return recommendationRate1; }
        }

        public TrackBar RecommendationRate2
        {
            get { return recommendationRate2; }
        }

        private void recommendationTextBox1_TextChanged(object sender, EventArgs e)
        {
            handleRecommendationRateVisibility(sender, RecommendationRate1);
        }

        private void recommendationTextBox2_TextChanged(object sender, EventArgs e)
        {
            handleRecommendationRateVisibility(sender, RecommendationRate2);
        }

        private void handleRecommendationRateVisibility(object sender, TrackBar i_Reta)
        {
            if (sender is TextBox recommendationTextBox)
            {
                makeRateVisible(i_Reta, recommendationTextBox.Text);
            }
            else
            {
                // Handle the case where sender is not a TextBox
                MessageBox.Show("Unexpected sender type");
            }
        }

        private void makeRateVisible(TrackBar i_Rate, string i_TextInTextBox)
        {
            if(string.IsNullOrEmpty(i_TextInTextBox))
            {
                i_Rate.Value = i_Rate.Minimum;
                i_Rate.Visible = false; 
            }
            else
            {
                i_Rate.Visible = true;
            }
        }

        internal void ClearText()
        {
            recommendationTextBox1.Text = string.Empty;
            recommendationTextBox2.Text = string.Empty;
            recommendationRate1.Value = recommendationRate1.Minimum;
            recommendationRate2.Value = recommendationRate2.Minimum;
            SetupUI.ShowOrHideControls(v_HideControls, new List<Control> { recommendationRate1, recommendationRate2 });
        }
    }
}
