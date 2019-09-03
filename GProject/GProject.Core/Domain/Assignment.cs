using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Core.Domain
{
    public class Assignment : Project
    {
        public bool IsActive { get; set; }

        public DateTime AssignedDate { get; set; }
    }
}
