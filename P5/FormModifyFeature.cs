using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormModifyFeature : Form
    {

        public Feature selectedFeature = new Feature();
        public FormModifyFeature(Feature myFeat)
        {

            selectedFeature.id = myFeat.id;
            selectedFeature.ProjectId = myFeat.ProjectId;
            selectedFeature.Title = myFeat.Title;
    
            InitializeComponent();
            
        }

        private void FormModifyFeature_Load(object sender, EventArgs e)
        {

            this.CenterToParent();
            this.featureToModify.Text = selectedFeature.Title;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedFeature.Title = this.featureToModify.Text.ToString().Trim();
            FakeFeatureRepository modifiedFeature = new FakeFeatureRepository();
            string mdfy = modifiedFeature.Modify(selectedFeature);

            if (string.IsNullOrEmpty(mdfy))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                MessageBox.Show(mdfy, "Error !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
