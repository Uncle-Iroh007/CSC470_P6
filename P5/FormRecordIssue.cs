using P5;
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
    public partial class FormRecordIssue : Form
    {
        public int currentProjectId = -1;
        public FormRecordIssue(int curprj)
        {
            InitializeComponent();
            currentProjectId = curprj;
        }

        private void Iss_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRecordIssue_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeAppUserRepository users = new FakeAppUserRepository();
            List<AppUser> usrs = users.GetAll();

            FakeIssueStatusRepository issues = new FakeIssueStatusRepository();
            List<IssueStatus> myissues = new List<IssueStatus>();

            myissues = issues.GetAll();

            foreach (AppUser usr in usrs)
            {
                string name = usr.LastName + ", " + usr.FirstName;
                discoverers.Items.Add(name);                
            }

            foreach(IssueStatus isSt in myissues)
            {
                statuses.Items.Add(isSt.Value);   
            }

            FakeIssueRepository isss = new FakeIssueRepository();

            this.Iss_Id.Text = isss.getNextIssueId().ToString();
        }

        private void discoverers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void statuses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crtIssue_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(this.discoverers.Text))
            {
                MessageBox.Show("A Discoverer must be selected.","Error!");
            }
            else if (string.IsNullOrEmpty(this.statuses.Text))
            {
                MessageBox.Show("A Status has to  be assigned.","Error!");
            }
            else
            {

                Issue newIssue = new Issue();
                FakeIssueStatusRepository iss = new FakeIssueStatusRepository();
                FakeIssueRepository new_Iss = new FakeIssueRepository();

                newIssue.id = Int32.Parse(this.Iss_Id.Text);
                newIssue.project_id = currentProjectId;
                newIssue.Discoverer = this.discoverers.Text;
                newIssue.Component = this.comp.Text;
                newIssue.initialDescription = this.initDesc.Text;
                newIssue.IssueStatusid = iss.GetIdByStatus(this.statuses.Text);
                newIssue.DiscoveryDate = DateTime.ParseExact(this.disc_dateTime.Text, "hh:mm:ss tt d MMM yyyy", null);
                newIssue.Title = this.titleBox.Text.Trim();

                string res = new_Iss.Add(newIssue);

                if (string.IsNullOrEmpty(res) == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show(res, "Error !");

                    //this.DialogResult = DialogResult.Cancel;
                    //this.DialogResult = DialogResult.Abort;
                    //this.Close();

                }

            }
        }

        private void cnclCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
