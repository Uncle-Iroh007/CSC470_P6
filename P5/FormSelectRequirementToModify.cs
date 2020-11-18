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
    public partial class FormSelectRequirementToModify : Form
    {

        int currentProject;

        FakeFeatureRepository F = new FakeFeatureRepository();
        FakeRequirementRepository R = new FakeRequirementRepository();
        public FormSelectRequirementToModify(int pId)
        {
            currentProject = pId;

            InitializeComponent();
        }

        private void FormSelectRequirementToModify_Load(object sender, EventArgs e)
        {

            this.CenterToParent();
            this.label2.Enabled = false;
            this.reqList.Enabled = false;
            this.selReq.Enabled = false;
            this.reqList.ColumnHeadersVisible = false;

            this.featureList.Items.Add("< Make Selection >");
            List<Feature> myList = F.GetAll(currentProject);

            foreach(Feature f in myList)
            {

                this.featureList.Items.Add(f.Title);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            Feature myFeature = F.GetFeatureByTitle(this.featureList.SelectedItem.ToString());
            this.reqList.Rows.Clear();

            if (myFeature.id == -1)
            {
                this.reqList.Rows.Clear();
                //this.reqList.Rows.Clear();
                this.label2.Enabled = false;
                this.reqList.Enabled = false;
                this.selReq.Enabled = false;
                this.reqList.ColumnHeadersVisible = false ;
            }
            else
            { 
      
                List<Requirement> Rs = new List<Requirement>();
                Rs = R.GetAll(currentProject);

                foreach (Requirement r in Rs)
                {

                    if(r.FeatureId == myFeature.id)
                    {
                        this.reqList.Rows.Add(r.id.ToString(),r.Statement);
                    }
                }

                this.reqList.ColumnHeadersVisible = true;
                this.label2.Enabled = true;

                if (this.reqList.Rows.Count > 0)
                {
                    
                    this.reqList.Enabled = true;
                    this.selReq.Enabled = true;

                }
                else
                {

                    this.reqList.Enabled = false;
                    this.selReq.Enabled = false;
                }


            }

        }

        private void selReq_Click(object sender, EventArgs e)
        {


            int selectedIdex = this.reqList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = this.reqList.Rows[selectedIdex];

            Requirement selectedRequirement = new Requirement();
            selectedRequirement = R.GetRequirementById(Convert.ToInt32(selectedRow.Cells["reqId"].Value));

            FormModifyRequirement modifyReq = new FormModifyRequirement(selectedRequirement);
            modifyReq.ShowDialog();
            modifyReq.Dispose();

            if(modifyReq.DialogResult == DialogResult.OK || modifyReq.DialogResult == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
            
        }

        private void cncl_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
