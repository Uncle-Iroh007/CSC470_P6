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
    public partial class FormCreateFeature : Form
    {

        int currentProject;
        public FormCreateFeature(int curProject)
        {
            currentProject = curProject;
            InitializeComponent();
        }

        private void FormCreateFeature_Load(object sender,EventArgs e)
        {
            this.CenterToParent();

        }

        private void CreateFeat_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository myFeatures = new FakeFeatureRepository();
            Feature newFeature = new Feature();
            //newFeature.id = myFeatures.getNextFeatureId();
            newFeature.ProjectId = currentProject;
            newFeature.Title = this.newFeatTitle.Text.Trim();

            string addition = myFeatures.Add(newFeature);
            if (!string.IsNullOrEmpty(addition))
            {
                MessageBox.Show(addition, "ERROR !");

            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void cnclFeat_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
