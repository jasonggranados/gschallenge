using System;

namespace GProject.Core.Features.User.Models
{
    public class AssignmentModel
    {
        public int ProjectId { get; set; }

        public int UserId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Credits { get; set; }

        public bool IsActive { get; set; }

        public DateTime AssignedDate { get; set; }
    }
}
