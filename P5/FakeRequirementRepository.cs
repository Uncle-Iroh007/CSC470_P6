using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeRequirementRepository : IRequirementRepository
    {

        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique.";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist.";
        public const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement.";
        public const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";

        private static List<Requirement> _requirements = new List<Requirement>();


        public FakeRequirementRepository()
        {

            if (_requirements.Count == 0)
            {
                _requirements.Add(new Requirement
                {
                    id = 1,
                    ProjectId = 1,
                    FeatureId = 1,
                    Statement = "This is a new statement"
                });

                _requirements.Add(new Requirement
                {
                    id = 2,
                    ProjectId = 1,
                    FeatureId = 1,
                    Statement = "This is an entirely new statement"
                });
            }
        }


        public string Add(Requirement requirement)
        {

            requirement.id = getNextRequirementId();

            if (string.IsNullOrEmpty(requirement.Statement))
            {

                return "Statement must have a value.";
            }
            foreach(Requirement r in _requirements)
            {

                if (r.Statement.Equals(requirement.Statement.Trim()) && r.ProjectId == requirement.ProjectId)
                {

                    return DUPLICATE_STATEMENT_ERROR;
                }
            }

            _requirements.Add(requirement);
            return NO_ERROR;


        
        }

        public List<Requirement> GetAll(int ProjectId)
        {
            List<Requirement> myList = new List<Requirement>();
            foreach(Requirement r in _requirements)
            {
                if(r.ProjectId == ProjectId)
                {
                    myList.Add(r);
                }
            }

            return myList;

        }


        public string Remove(Requirement requirement)
        {

            int reqIndex = 0;
           
            foreach(Requirement r in _requirements)
            {
                if(r.id == requirement.id)
                {
                    
                    _requirements.RemoveAt(reqIndex);
                    return NO_ERROR;
                   
                }

                reqIndex++;
            }
            return REQUIREMENT_NOT_FOUND_ERROR;
        }


        public string Modify(Requirement requirement)
        {

            bool errorFlag = false;
            foreach(Requirement r in _requirements)
            {
                if(r.ProjectId == requirement.ProjectId && r.FeatureId == requirement.FeatureId && r.Statement.Equals(requirement.Statement) && r.id != requirement.id)
                {
                    errorFlag = true;
                }
            }

            if (errorFlag)
            {
                return DUPLICATE_STATEMENT_ERROR;
            }
            else
            {
                GetRequirementById(requirement.id).FeatureId = requirement.FeatureId;
                GetRequirementById(requirement.id).Statement = requirement.Statement;
                return NO_ERROR;
            }


          
        }


        public Requirement GetRequirementById(int requirementId)
        {

            Requirement myReq = new Requirement();
            myReq = _requirements.Find(Requirement => Requirement.id == requirementId);

            return myReq;
        }


        public int CountByFeatureId(int featureId)
        {

            int count = 0;
            foreach(Requirement r in _requirements)
            {
                if (r.FeatureId == featureId)
                {
                    count++;   
                }
            }
            return count;
        }

        public void RemoveByFeatureId(int featureId)
        {
            int count = CountByFeatureId(featureId), i, indexCount = 0; ;

            for (i = 0; i < count; i++)
            {
                indexCount = 0;

                foreach (Requirement r in _requirements)
                {

                    if (r.FeatureId == featureId)
                    {
                        _requirements.RemoveAt(indexCount);
                        break;
                    }

                    indexCount++;
                }

            }
       

        }

        public int getNextRequirementId()
        {
            int biggest = 0;
            foreach (Requirement r in _requirements)
            {

                if (r.id > biggest)
                {
                    biggest = r.id;
                }
            }

            return (biggest + 1);
        }


    }
}
