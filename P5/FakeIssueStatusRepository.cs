using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();

        


        public FakeIssueStatusRepository(){

            if (_IssueStatuses.Count == 0)
            {
                Add(getNextIsStatusId(), "Open");
                Add(getNextIsStatusId(), "Assigned");
                Add(getNextIsStatusId(), "Fixed");
                Add(getNextIsStatusId(), "Closed - Won't fix");
                Add(getNextIsStatusId(), "Closed - Fixed");
                Add(getNextIsStatusId(), "Closed - By design");
            }
        }


        public void Add(int Id, string value)
        {


            _IssueStatuses.Add(new IssueStatus { Id = Id, Value = value});
            

        }

        public List<IssueStatus> GetAll()
        {

            return _IssueStatuses;

        }

        public int GetIdByStatus(string value)
        {

            int retId = -1;

           foreach(IssueStatus isSt in _IssueStatuses)
           {
               
                if(isSt.Value == value.Trim())
                {
                    retId = isSt.Id;
                }
           }

            return retId;

        }

        public string GetValueById(int Id)
        {
            string a = string.Empty;

            foreach (IssueStatus isSt in _IssueStatuses)
            {

                if (isSt.Id == Id)
                {
                    a = isSt.Value;
                }
            }

            return a;

        }

        private int getNextIsStatusId()
        {
            int biggest =1;
            foreach(IssueStatus isSt in _IssueStatuses)
            {
                if(isSt.Id > biggest)
                {
                    biggest = isSt.Id;
                }
            }

            return biggest + 1;
        }

    }
}
