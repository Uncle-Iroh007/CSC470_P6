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
    public partial class FormModifyRequirement : Form
    {

        Requirement selectedRequirement;
        FakeFeatureRepository F = new FakeFeatureRepository();
        FakeRequirementRepository R = new FakeRequirementRepository();
        public FormModifyRequirement(Requirement myRequirement)
        {
            selectedRequirement = myRequirement;
            InitializeComponent();
        }

        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            List<Feature> myF = F.GetAll(selectedRequirement.ProjectId);
            this.featsList.Text = F.GetFeatureById(selectedRequirement.FeatureId).Title;
            this.statBox.Text = R.GetRequirementById(selectedRequirement.id).Statement;

            this.featsList.Text = F.GetFeatureById(selectedRequirement.FeatureId).Title;

            foreach(Feature f in myF)
            {
                this.featsList.Items.Add(f.Title);
            }
            
        }

        private void cncl_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mdfyReq_Click(object sender, EventArgs e)
        {
            Requirement modifiedRequirement = new Requirement();
            modifiedRequirement.id = selectedRequirement.id;
            modifiedRequirement.ProjectId = selectedRequirement.ProjectId;
            modifiedRequirement.FeatureId = F.GetFeatureByTitle(this.featsList.Text.ToString()).id;
            modifiedRequirement.Statement = this.statBox.Text.ToString();

            string modify = R.Modify(modifiedRequirement);

            if (string.IsNullOrEmpty(modify))
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                MessageBox.Show(modify,"Error !");
            }
        }
    }
}
