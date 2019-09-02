using AutoMapper;
using GProject.Core.Features.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Core.Features.User
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.User, UserModel>();

            CreateMap<Domain.Assignment, AssignmentModel>()
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.Id))
                .AfterMap((src, des, context) => des.UserId = (int) context.Items[nameof(AssignmentModel.UserId)]);
        }
    }
}
