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
    public partial class FormRemoveIssue : Form
    {

        int currentProject;
        public FormRemoveIssue(int curPrj)
        {
            InitializeComponent();
            currentProject = curPrj;
        }
        
        private void FormRemoveIssue_Load(Object sender, EventArgs e)
        {
            //this.CenterToParent();
            FakeIssueRepository i = new FakeIssueRepository();
            List<Issue> myIssues = i.GetAll(currentProject);

            int id;
            string title, discoverer, initialDesc, comp, status;
            DateTime discD;
            FakeIssueStatusRepository isStatus = new FakeIssueStatusRepository();
            foreach(Issue a in myIssues)
            { 
                id = a.id;
                title = a.Title;
                discoverer = a.Discoverer;
                discD = a.DiscoveryDate;
                initialDesc = a.initialDescription;
                comp = a.Component;
                status = isStatus.GetValueById(a.IssueStatusid);
                List<string> row = new List<string> { id.ToString(), title, discD.ToString(), discoverer, initialDesc, comp, status};
                this.issuesList.Rows.Add(row);
            }

        }
    }
}
