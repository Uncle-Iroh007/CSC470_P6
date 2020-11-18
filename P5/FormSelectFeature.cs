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
    public partial class FormSelectFeature : Form
    {

        int currentProject;
        public FormSelectFeature(int pId)
        {

            currentProject = pId;
            InitializeComponent();
        }

        private void FormSelectFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            List<Feature> myList = new List<Feature>();
            FakeFeatureRepository myFeatures = new FakeFeatureRepository();
            myList = myFeatures.GetAll(currentProject);

            foreach(Feature f in myList)
            {
                this.featList.Rows.Add(f.id.ToString(),f.Title);
            }

        }

        private void selFeat_Click(object sender, EventArgs e)
        {
            if(this.featList.SelectedRows.Count == 0)
            {

                MessageBox.Show("A feature must be selected", "ERROR !");

            }
            else
            {

                Feature myFeature = new Feature();
                int selectedIndex = this.featList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.featList.Rows[selectedIndex];

                myFeature.id = Convert.ToInt32(selectedRow.Cells["featId"].Value);
                myFeature.ProjectId = currentProject;
                myFeature.Title =  selectedRow.Cells["feat"].Value.ToString().Trim();

                FormModifyFeature modify = new FormModifyFeature(myFeature);
                modify.ShowDialog();

                if(modify.DialogResult == DialogResult.OK || modify.DialogResult == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.OK ;
                    this.Close();
                }
                modify.Dispose();

            }
        }
    }
}
