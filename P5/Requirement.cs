using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Requirement
    {

        public int id{ get; set; }
        public int ProjectId { get; set; }
        public int FeatureId { get; set; }
        public string Statement { get; set; }
    }
}
