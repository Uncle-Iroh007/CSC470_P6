using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeFeatureRepository : IFeatureRepository
    {

        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        public const string EMPTY_TITLE_ERROR = "Title must have a value.";
        public const string NOT_FOUND_ERROR = "Feature not found.";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature.";

        private static List<Feature> _features = new List<Feature>();

        public FakeFeatureRepository()
        {

            if(_features.Count == 0)
            {

                _features.Add(new Feature { id = getNextFeatureId(), ProjectId = 1, Title = "This is a new Feature" });
                _features.Add(new Feature { id = getNextFeatureId(), ProjectId = 1, Title = "This is 2nd new Feature" });
                _features.Add(new Feature { id = getNextFeatureId(), ProjectId = 2, Title = "This is 3rd new Feature" });
                _features.Add(new Feature { id = getNextFeatureId(), ProjectId = 3, Title = "This is 4th new Feature" });
            }
        }

        public string Add(Feature feature)
        {

            feature.id = getNextFeatureId();
            string result = validateFeature(feature);
            if(result.Equals(NO_ERROR))
            {
                _features.Add(feature);
                return NO_ERROR;
               
            }
            else
            {
                return result;
            }

          
        }

        public string validateFeature(Feature feature)
        {

            if (string.IsNullOrEmpty(feature.Title))
            {
                    return EMPTY_TITLE_ERROR;
                  
            }else if (isDuplicate(feature.Title,feature.ProjectId) == true)
            {
                return DUPLICATE_TITLE_ERROR;
            }
            else
            {

                return NO_ERROR;
            }

            
        }

        public List<Feature> GetAll(int projectId)
        {
            List<Feature> myFeatures = new List<Feature>();
            foreach(Feature f in _features)
            {
                if(f.ProjectId == projectId)
                {
                    myFeatures.Add(f);
                }
            }
            return myFeatures;
        }


        public string Remove(Feature feature)
        {

            int index = 0;
            bool success = false;
            foreach (Feature f in _features)
            {
                if (f.id == feature.id)
                {

                    /*FakeRequirementRepository myReqs = new FakeRequirementRepository();
                    myReqs.RemoveByFeatureId(feature.id);*/
                    _features.RemoveAt(index);
                    success = true;
                    break;
                }

                index++;
            }

            if(success == true)
            {

                return NO_ERROR;
            }
            else
            {

                return NOT_FOUND_ERROR;
            }

            
        }

        public string Modify(Feature feature)
        {
            string validation = validateFeature(feature);
            bool errorFlag = false;

            if (!string.IsNullOrEmpty(validation))
            {
                if (validation.Equals(DUPLICATE_TITLE_ERROR))
                {
                    foreach (Feature f in _features)
                    {
                        if (f.Title.Equals(feature.Title) && f.ProjectId == feature.ProjectId && f.id != feature.id)
                        {
                            errorFlag = true;
                        }
                    }

                    if (errorFlag == true)
                    {
                        return DUPLICATE_TITLE_ERROR;
                    }
                    else
                    {

                        Feature myFeature = _features.Where(Feature => Feature.id == feature.id).First();
                        int index = _features.IndexOf(myFeature);

                        _features.ElementAt(index).Title = feature.Title;
                        return NO_ERROR;
                    }

                }
                else
                {
                    return validation;
                }
            }
            else
            {
                Feature myFeature = _features.Where(Feature => Feature.id == feature.id).First();
                int index = _features.IndexOf(myFeature);

                _features.ElementAt(index).Title = feature.Title;
                return NO_ERROR;
            }

            /*if(validation.Equals(NO_ERROR) && errorFlag == false)
            {
               ;
            }
            else
            {


                return validation;
            }*/


            
         
           
        }

        public Feature GetFeatureById(int featureId)
        {

            Feature myFeature = new Feature();
            myFeature.id = -1;
            foreach(Feature f in _features)
            {

                if(f.id == featureId)
                {
                    myFeature = f;
                    break;
                }
            }

            return myFeature;

        }


        public Feature GetFeatureByTitle(string title)
        {

            Feature myFeature = new Feature();
            myFeature.id = -1;
            myFeature.Title = "";

            foreach(Feature f in _features)
            {
                if (f.Title.Equals(title))
                {
                    myFeature = f;
                    break;
                }
            }

            return myFeature;

        }


        private bool isDuplicate(string title, int pId)
        {

            bool retFalg = false;
            foreach(Feature f in _features)
            {

                if (f.Title.Equals(title) && f.ProjectId == pId){
                    retFalg = true;
                    break;
                }
            }

            return retFalg;
        }

        public int getNextFeatureId()
        {
            int biggest = 0;
            foreach(Feature f in _features)
            {

                if(f.id > biggest)
                {
                    biggest = f.id;
                }
            }

            return (biggest + 1);
        }

    }
}
