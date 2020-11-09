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
    public partial class selectIssueToModify : Form
    {

        public int projectId,selectedIssueId;
        public selectIssueToModify(int curProject)
        {
            InitializeComponent();
            projectId = curProject;
        }

        private void FormSelectIssueToModidy_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueRepository i = new FakeIssueRepository();
            List<Issue> myIssues = i.GetAll(projectId);

            FakeIssueStatusRepository isStatus = new FakeIssueStatusRepository();
            string issue;
            foreach (Issue a in myIssues)
            {
                issue = isStatus.GetValueById(a.IssueStatusid);
                //List<string> newRow = new List<string>() { a.id.ToString(), a.Title, a.DiscoveryDate.ToString(), a.Discoverer, a.initialDescription, a.Component, issue };
                this.listOfIssues.Rows.Add(a.id.ToString(), a.Title, a.DiscoveryDate.ToString(), a.Discoverer, a.initialDescription, a.Component, issue);

            }

        }

        private void SelIssue_Click(object sender, EventArgs e)
        {
            if (this.listOfIssues.SelectedRows.Count == 0)
            {

                MessageBox.Show("An Issue must be Selected","Error!");
            }
            else
            {


                int selectedIndex = this.listOfIssues.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.listOfIssues.Rows[selectedIndex];
                string title = selectedRow.Cells["issTitle"].Value.ToString();
                selectedIssueId = Convert.ToInt32(selectedRow.Cells["issueId"].Value);

                Issue issueToModify = new Issue();
                FakeIssueStatusRepository isStat = new FakeIssueStatusRepository();

                issueToModify.id = Convert.ToInt32(selectedRow.Cells["issueId"].Value);
                issueToModify.project_id = projectId;
                issueToModify.Discoverer = selectedRow.Cells["disc"].Value.ToString();
                issueToModify.DiscoveryDate = Convert.ToDateTime(selectedRow.Cells["discDate"].Value);
                issueToModify.Title = selectedRow.Cells["issTitle"].Value.ToString();
                issueToModify.IssueStatusid = isStat.GetIdByStatus(selectedRow.Cells["stat"].Value.ToString());
                issueToModify.initialDescription = selectedRow.Cells["intiDesc"].Value.ToString();
                issueToModify.Component = selectedRow.Cells["comp"].Value.ToString();

                FormModifyIssue modify = new FormModifyIssue(issueToModify);
                modify.ShowDialog();
                if(modify.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Modification Cancelled ! .","Attention");
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }


        }

        private void MdfyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
