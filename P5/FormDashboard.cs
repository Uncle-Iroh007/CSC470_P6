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
    public partial class FormDashboard : Form
    {
        int currentPrjId = -1;
        public FormDashboard(int prjId)
        {
            InitializeComponent();
            currentPrjId = prjId;
             

        }


        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueRepository fakeIssues = new FakeIssueRepository();
            this.numIssue.Text = fakeIssues.GetTotalNumberOfIssues(currentPrjId).ToString();

            List<string> monthlyIssue = new List<string>();
            List<string> issByDisc = new List<string>(0);
            monthlyIssue = fakeIssues.GetIssuesByMonth(currentPrjId);
            issByDisc = fakeIssues.GetIssuesByDiscoverer(currentPrjId);
            this.issueByMonth_List.Lines = monthlyIssue.ToArray();
            this.IssueByDisc_list.Lines = issByDisc.ToArray(); 
        

        }

        private void numIssue_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IbM_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  
        private void clsButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
