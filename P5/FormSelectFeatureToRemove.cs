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
    public partial class FormSelectFeatureToRemove : Form
    {

        int curProjectId;
        public FormSelectFeatureToRemove(int pId)
        {

            curProjectId = pId;
            InitializeComponent();
            
        }

        private void FormSelectFeatureToRemove_Load(object sender, EventArgs e)
        {

            this.CenterToParent();
            FakeFeatureRepository myFeatures = new FakeFeatureRepository();
            List<Feature> myList = myFeatures.GetAll(curProjectId);

            foreach(Feature f in myList)
            {

                this.dataGridView1.Rows.Add(f.id.ToString(), f.Title);
            }
        }

        private void selFeatToRem_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("A feature must be selected", "Error !");
            }
            else
            {

                int selectedIndex = this.dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dataGridView1.Rows[selectedIndex];

                int selectedFeatureId = Convert.ToInt32(selectedRow.Cells["featureId"].Value);
                string selectedFeatureTitle = selectedRow.Cells["featTitle"].Value.ToString();

                Feature featureToRemove = new Feature();
                featureToRemove.id = selectedFeatureId;
                featureToRemove.ProjectId = curProjectId;
                featureToRemove.Title = selectedFeatureTitle;

                FakeRequirementRepository myReqs = new FakeRequirementRepository();
                FakeFeatureRepository myFeats = new FakeFeatureRepository();
                
                if(myReqs.CountByFeatureId(selectedFeatureId) > 0)
                {
                    DialogResult confirmation = MessageBox.Show(String.Format("There are one or more requirements associateed with this feature" +
                        "These requirements will be destroyed if you remove this feature.Are you sure you want to remove : {0}", selectedFeatureTitle), "Confirmation", MessageBoxButtons.YesNo);

                    if(confirmation == DialogResult.Yes)
                    {
                        string success = myFeats.Remove(featureToRemove);


                        myReqs.RemoveByFeatureId(selectedFeatureId);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    /*else
                    {
                        this.DialogResult = DialogResult.Cancel;

                    }*/
                }
                else
                {

                    DialogResult confirmation = MessageBox.Show(String.Format("Are you sure you want to remove : {0}", selectedFeatureTitle), "Confirmation", MessageBoxButtons.YesNo);
                    if(confirmation == DialogResult.Yes)
                    {
                        myFeats.Remove(featureToRemove);
                        this.Close();
                    }
                }
            }
        }

        private void cnclRem_Click(object sender, EventArgs e)
        {

        }
    }
}
