using Castle.Core.Internal;
using P5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Builder
{
    public class FakeIssueRepository : IIssueRepository
    {


        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must Select A Discovery Date/TIme.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";

        private static List<Issue> _Issues = new List<Issue>();

        public FakeIssueRepository()
        {

           
            if (_Issues.Count == 0)
            {
                string added = Add(new Issue
                {
                    id = getNextIssueId(),
                    project_id = 1,
                    Title = "Hello there",
                    DiscoveryDate = DateTime.Today,
                    Discoverer = "Sharma, Sandesh",
                    initialDescription = "This is my first one",
                    Component = "This is some random stuff",
                    IssueStatusid = 2

                });
                added = Add(new Issue
                {
                    id = getNextIssueId(),
                    project_id = 1,
                    Title = "How are you my friend",
                    DiscoveryDate = DateTime.Today,
                    Discoverer = "Sharma, Sandesh",
                    initialDescription = "This is my first one",
                    Component = "This is some random stuff",
                    IssueStatusid = 2

                });

                added = Add(new Issue
                {
                    id = getNextIssueId(),
                    project_id = 1,
                    Title = "How are you",
                    DiscoveryDate = DateTime.Today,
                    Discoverer = "Bishop, Dave",
                    initialDescription = "This is my first one",
                    Component = "This is some random stuff",
                    IssueStatusid = 2

                });

                if (string.IsNullOrEmpty(added) == false)
                {
                    MessageBox.Show(added, "Error!");
                }
            }

      

        }
        public string Add(Issue issue)
        {

            string validation = this.ValidateIssue(issue);

            if (string.IsNullOrEmpty(validation) == false)
            {
                return validation;
            }
            else
            {
                

                issue.id = getNextIssueId();
                _Issues.Add(issue);
                
                return NO_ERROR;
            }

        }
        public List<Issue> GetAll(int ProjectId) { 

            List<Issue> allIssues = new List<Issue>();
            FormSelectProject myProject = new FormSelectProject();

            int pId = myProject._SelectedProjectId;



            foreach (Issue a in _Issues)
            {
                if (a.project_id == pId)
                {
                    allIssues.Append(a);

                }
            }
            return allIssues;
        }

        public bool Remove(Issue issue) {

            int index = 0;
            bool success = false;
            foreach(Issue iss  in _Issues)
            {
                if(iss.id == issue.id)
                {
                    _Issues.RemoveAt(index);
                    success = true;
                }

                index++;
            }

            return success;
            

        }

        public string Modify(Issue issue) {

            string validation = this.ValidateIssue(issue);
         
            if(string.IsNullOrEmpty(validation) == false)
            {
                return validation;
            }
            else
            {
                int index = 0;
                foreach (Issue iss in _Issues)
                {
                    if (iss.project_id == issue.project_id)
                    {

                        _Issues[index] = issue;
                    }

                    index++;
                }

                return NO_ERROR;
            }
        
        }

        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int a = 0;
            foreach(Issue iss in _Issues)
            {
                if(iss.project_id == ProjectId)
                {
                    a++;
                }
            }
            return a;


        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {

            List<string> monthlyIssues = new List<string>();
            string key;
            Dictionary<string, int> mnIssues = new Dictionary<String, int>();

            foreach(Issue iss in _Issues)
            {
                if(iss.project_id == ProjectId)
                {
                    key = iss.DiscoveryDate.Year.ToString() + " - " + iss.DiscoveryDate.Month.ToString();
                    if (mnIssues.ContainsKey(key))
                    {

                        mnIssues[key]++;
                        
                    }
                    else
                    {
                        mnIssues.Add(key, 1);
                    }
                    
                }

            }

            foreach(KeyValuePair<string, int> mnIss in mnIssues)
            {
                key = (mnIss.Key + " : " + mnIss.Value.ToString()+'\n');
                monthlyIssues.Add(key);
            }

            return monthlyIssues;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            List<string> mylist = new List<string>();
            Dictionary<string, int> issByDisc = new Dictionary<string, int>();
            

            foreach(Issue iss in _Issues)
            {

                if(iss.project_id == ProjectId)
                {

                    if (issByDisc.ContainsKey(iss.Discoverer))
                    {
                        issByDisc[iss.Discoverer]++;
                    }
                    else
                    {
                        issByDisc.Add(iss.Discoverer,1);
                    }
                }
            }

            string key;

            foreach(KeyValuePair<string,int> dict in issByDisc)
            {
                key = dict.Key + " : " + dict.Value.ToString()+'\n';
                mylist.Add(key);
            }


            return mylist;

        }

        public Issue GetIssueById(int Id)
        {
            Issue myIssue = new Issue();
            foreach(Issue a in _Issues)
            {
                if (a.id == Id){

                    myIssue = a;
                   
                }
            }

            return myIssue;

        }


        private string ValidateIssue(Issue issue)
        {

            string datetime = issue.DiscoveryDate.ToString();

            if (issue.Title.Trim() == string.Empty)
            {
                return EMPTY_TITLE_ERROR;

            }
            else if (issue.DiscoveryDate > DateTime.Now)
            {

                return FUTURE_DISCOVERY_DATETIME_ERROR;

            }
            else if (issue.Discoverer == string.Empty)
            {

                return EMPTY_DISCOVERER_ERROR;

            }
            else if (string.IsNullOrEmpty(datetime))
            {

                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            else
            {
                bool res = IsDupllicate(issue.Title.Trim());

                
                
                if (res == true){

                    return "Title Already Exists.";
                }
                else {
                    return NO_ERROR;
                }

                
            }
        }


        private bool IsDupllicate(string title)
        {
            bool result = false;
         
            foreach (Issue iss in _Issues)
            {

                if(iss.Title == title)
                {
                    result = true;
                }
            }

            return result;
        }

        public int getNextIssueId()
        {

            int biggest = 0;
            foreach(Issue iss in _Issues)
            {
                if(iss.id > biggest)
                {
                    biggest = iss.id;
                    
                }
            }

            return biggest + 1;
               
        }
    }
}
