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
    public partial class FormCreateRequirement : Form
    {

        int curProj;
        public FormCreateRequirement(int cPrj)
        {
            InitializeComponent();
            curProj = cPrj;


        }

        private void FormCreateRequirement_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            FakeFeatureRepository Features = new FakeFeatureRepository();
            List<Feature> myFeatures = new List<Feature>();

            myFeatures = Features.GetAll(curProj);
            this.selFeat.Items.Add("< Make Selection >");
            foreach(Feature f in myFeatures)
            {
                this.selFeat.Items.Add(f.Title);
            }


            this.statMentBox.Enabled = false;
            this.CrtReq.Enabled = false;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statMentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selFeat_SelectedIndexChanged(object sender, EventArgs e)
        {

            FakeRequirementRepository myReqs = new FakeRequirementRepository();
            FakeFeatureRepository myFeats = new FakeFeatureRepository();
            Feature newFeature = new Feature();
            newFeature = myFeats.GetFeatureByTitle(this.selFeat.SelectedItem.ToString());
            if(newFeature.id != -1)
            {
                this.statMentBox.Enabled = true;
                this.CrtReq.Enabled = true;

            }
            else
            {

                this.statMentBox.Enabled = false;
                this.CrtReq.Enabled = false;
            }

        }

        private void CrtReq_Click(object sender, EventArgs e)
        {


            FakeRequirementRepository myReqs = new FakeRequirementRepository();
            FakeFeatureRepository myFs = new FakeFeatureRepository();
            Feature newF = new Feature();
            newF = myFs.GetFeatureByTitle(this.selFeat.SelectedItem.ToString());
            Requirement newR = new Requirement();
            newR.ProjectId = curProj;
            newR.FeatureId = newF.id;
            newR.Statement = this.statMentBox.Text.Trim();


            string addReq = myReqs.Add(newR);
            if (string.IsNullOrEmpty(addReq))
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                MessageBox.Show(addReq,"Error !");
            }
        }

        private void cnclReqCrt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
