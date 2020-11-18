using P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder

{
    public partial class FormModifyIssue : Form
    {

        Issue issToModify = new Issue();
        public FormModifyIssue(Issue iss)
        {
            InitializeComponent();
            issToModify = iss;

        }

        private void FormModifyIssue_Load(object sender, EventArgs e){

            //FakeIssueStatusRepository myStatus = new FakeIssueStatusRepository();

           
            P5.FakeAppUserRepository users = new P5.FakeAppUserRepository();
            List<P5.AppUser> usrs = users.GetAll();

            FakeIssueStatusRepository issues = new FakeIssueStatusRepository();
            List<IssueStatus> myissues = new List<IssueStatus>();

            myissues = issues.GetAll();

            foreach (P5.AppUser usr in usrs)
            {
                string name = usr.LastName + ", " + usr.FirstName;
                this.disc.Items.Add(name);
            }

            foreach (IssueStatus isSt in myissues)
            {
                this.issStatus.Items.Add(isSt.Value);
            }
            this.issueID.Text = issToModify.id.ToString();
            this.issueTitle.Text = issToModify.Title;
            this.discDate.Text = issToModify.DiscoveryDate.ToString();
            this.disc.Text = issToModify.Discoverer;
            this.issComp.Text = issToModify.Component;
            this.issStatus.Text = issues.GetValueById(issToModify.IssueStatusid);
            this.initDesc.Text = issToModify.Component;
        }

        private void cnclMdfy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mdfyIssue_Click(object sender, EventArgs e)
        {

            FakeIssueStatusRepository iss = new FakeIssueStatusRepository();
            FakeIssueRepository modify = new FakeIssueRepository();

            Issue modifiedIssue = new Issue();
            modifiedIssue.id = Int32.Parse(this.issueID.Text);
            modifiedIssue.project_id = issToModify.project_id;
            modifiedIssue.Discoverer = this.disc.Text;
            modifiedIssue.Component = this.issComp.Text;
            modifiedIssue.initialDescription = this.initDesc.Text;
            modifiedIssue.IssueStatusid = iss.GetIdByStatus(this.issStatus.Text);
            modifiedIssue.DiscoveryDate = DateTime.ParseExact(this.discDate.Text, "hh:mm:ss tt d MMM yyyy", null);
            modifiedIssue.Title = this.issueTitle.Text.Trim();

            string modifyResult = modify.Modify(modifiedIssue);

            if(string.IsNullOrEmpty(modifyResult))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(modifyResult,"Error!");
                //this.DialogResult = DialogResult.Cancel;
                //this.Close();

            }

        }
    }
}
