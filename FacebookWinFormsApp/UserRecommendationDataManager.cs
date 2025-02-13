using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class UserRecommendationDataManager
    {
        private const string k_XmlFilePath = "usersData.xml";

        // savin user data
        public void SaveUserDataToFile(string i_UserId, TextBox i_TextBox1, TextBox i_TextBox2, TextBox i_TextBox3, TextBox i_TextBox4, TextBox i_TextBox5, TextBox i_TextBox6,
            TrackBar i_TrackBar1, TrackBar i_TrackBar2, TrackBar i_TrackBar3, TrackBar i_TrackBar4, TrackBar i_TrackBar5, TrackBar i_TrackBar6)
        {
            // create xml file if not exists
            if (!File.Exists(k_XmlFilePath))
            {
                var newDoc = new XDocument(new XElement("Users"));
                newDoc.Save(k_XmlFilePath);
            }

            // load file
            var doc = XDocument.Load(k_XmlFilePath);
            // searching by id
            var userElement = doc.Root.Elements("User").FirstOrDefault(currentUser => currentUser.Attribute("id")?.Value == i_UserId);
            if (userElement == null)
            {
                // adding new user
                userElement = new XElement("User", new XAttribute("id", i_UserId));
                doc.Root.Add(userElement);
            }

            // updating user data
            userElement.SetElementValue("TextBox1", i_TextBox1.Text);
            userElement.SetElementValue("TextBox2", i_TextBox2.Text);
            userElement.SetElementValue("TextBox3", i_TextBox3.Text);
            userElement.SetElementValue("TextBox4", i_TextBox4.Text);
            userElement.SetElementValue("TextBox5", i_TextBox5.Text);
            userElement.SetElementValue("TextBox6", i_TextBox6.Text);
            userElement.SetElementValue("TrackBar1", i_TrackBar1.Value);
            userElement.SetElementValue("TrackBar2", i_TrackBar2.Value);
            userElement.SetElementValue("TrackBar3", i_TrackBar3.Value);
            userElement.SetElementValue("TrackBar4", i_TrackBar4.Value);
            userElement.SetElementValue("TrackBar5", i_TrackBar5.Value);
            userElement.SetElementValue("TrackBar6", i_TrackBar6.Value);
            // save changes
            doc.Save(k_XmlFilePath);
        }

        // loading user data
        public void LoadUserDatafromFile(string i_UserId, TextBox i_TextBox1, TextBox i_TextBox2, TextBox i_TextBox3, TextBox i_TextBox4, TextBox i_TextBox5, TextBox i_TextBox6,
            TrackBar i_TrackBar1, TrackBar i_TrackBar2, TrackBar i_TrackBar3, TrackBar i_TrackBar4, TrackBar i_TrackBar5, TrackBar i_TrackBar6)
        {
            // check if file exists
            if (!File.Exists(k_XmlFilePath))
            {
                return;
            }

            // load file
            var doc = XDocument.Load(k_XmlFilePath);
            // searching by id
            var userElement = doc.Root.Elements("User").FirstOrDefault(currentUser => currentUser.Attribute("id")?.Value == i_UserId);

            if (userElement != null)
            {
                // Load user data
                i_TextBox1.Text = userElement.Element("TextBox1")?.Value ?? string.Empty;
                i_TextBox2.Text = userElement.Element("TextBox2")?.Value ?? string.Empty;
                i_TextBox3.Text = userElement.Element("TextBox3")?.Value ?? string.Empty;
                i_TextBox4.Text = userElement.Element("TextBox4")?.Value ?? string.Empty;
                i_TextBox5.Text = userElement.Element("TextBox5")?.Value ?? string.Empty;
                i_TextBox6.Text = userElement.Element("TextBox6")?.Value ?? string.Empty;
                i_TrackBar1.Value = int.TryParse(userElement.Element("TrackBar1")?.Value, out int value1) ? value1 : i_TrackBar1.Minimum;
                i_TrackBar2.Value = int.TryParse(userElement.Element("TrackBar2")?.Value, out int value2) ? value2 : i_TrackBar2.Minimum;
                i_TrackBar3.Value = int.TryParse(userElement.Element("TrackBar3")?.Value, out int value3) ? value3 : i_TrackBar3.Minimum;
                i_TrackBar4.Value = int.TryParse(userElement.Element("TrackBar4")?.Value, out int value4) ? value4 : i_TrackBar4.Minimum;
                i_TrackBar5.Value = int.TryParse(userElement.Element("TrackBar5")?.Value, out int value5) ? value5 : i_TrackBar5.Minimum;
                i_TrackBar6.Value = int.TryParse(userElement.Element("TrackBar6")?.Value, out int value6) ? value6 : i_TrackBar6.Minimum;
            }
        }
    }
}



