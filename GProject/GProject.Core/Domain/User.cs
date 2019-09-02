using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public IList<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}
