using Castle.Components.DictionaryAdapter.Xml;
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
    public partial class FormModifyIssue : Form
    {
        int currentProject;
        public FormModifyIssue(int curProjectID)
        {
            InitializeComponent();
            currentProject = curProjectID;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            FakeIssueRepository iss = new FakeIssueRepository();
            List<Issue> myIssue = iss.GetAll(currentProject);

            foreach(Issue i in myIssue)
            {

            }

        }
    }
}
