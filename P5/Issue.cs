using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Issue
    {
        public int id;
        public int project_id;
        public string Title;
        public DateTime DiscoveryDate;
        public string Discoverer;
        public string initialDescription;
        public string Component;
        public int IssueStatusid;

    }
}
