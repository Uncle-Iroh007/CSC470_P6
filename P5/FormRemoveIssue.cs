using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormRemoveIssue : Form
    {

        public int currentProject,selectedIssueId;
        public FormRemoveIssue(int curPrj)
        {
            InitializeComponent();
            
            currentProject = curPrj;
        }
        
        private void FormRemoveIssue_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueRepository i = new FakeIssueRepository();
            List<Issue> myIssues = i.GetAll(currentProject);

            FakeIssueStatusRepository isStatus = new FakeIssueStatusRepository();
            string issue;
            foreach(Issue a in myIssues)
            {
                issue = isStatus.GetValueById(a.IssueStatusid);
                //List<string> newRow = new List<string>() { a.id.ToString(), a.Title, a.DiscoveryDate.ToString(), a.Discoverer, a.initialDescription, a.Component, issue };
                this.issuesList.Rows.Add(a.id.ToString(), a.Title, a.DiscoveryDate.ToString(), a.Discoverer, a.initialDescription, a.Component, issue);
            
            }

        }

        private void cnclSel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void selIss_Click(object sender, EventArgs e)
        {
            if(this.issuesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("An Issue must be Selected","Error!");
            }
            else
            {
                int selectedIndex = this.issuesList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.issuesList.Rows[selectedIndex];
                string title = selectedRow.Cells["issTitle"].Value.ToString();
                selectedIssueId = Convert.ToInt32(selectedRow.Cells["isId"].Value);
                DialogResult confirmation = MessageBox.Show(String.Format("Are you sure you want to remove \"{0}\"?",title),"Confirmation",MessageBoxButtons.YesNo);
                FakeIssueStatusRepository isStat = new FakeIssueStatusRepository();
                if(confirmation == DialogResult.Yes)
                {
                    Issue issToRemove = new Issue();
                    issToRemove.id = Convert.ToInt32(selectedRow.Cells["isId"].Value);
                    issToRemove.project_id = currentProject;
                    issToRemove.Discoverer = selectedRow.Cells["disc"].Value.ToString();
                    issToRemove.DiscoveryDate = Convert.ToDateTime(selectedRow.Cells["discDate"].Value);
                    issToRemove.Title = selectedRow.Cells["issTitle"].Value.ToString();
                    issToRemove.IssueStatusid = isStat.GetIdByStatus(selectedRow.Cells["stat"].Value.ToString());
                    issToRemove.initialDescription = selectedRow.Cells["intiDesc"].Value.ToString();
                    issToRemove.Component = selectedRow.Cells["comp"].Value.ToString();
                    FakeIssueRepository rmvIssue = new FakeIssueRepository();
                    bool rmvSuccess = rmvIssue.Remove(issToRemove);
                    
                    if(rmvSuccess == true)
                    {
                        this.issuesList.Rows.RemoveAt(selectedIndex);
                        //this.DialogResult = DialogResult.OK;
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("This Issue could not be removed","Error!");
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                       
                    }

                }
                else
                {
                    //MessageBox.Show("Remove Cancelled!","Attention");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }
    }
}
