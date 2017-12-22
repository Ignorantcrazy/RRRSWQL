using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace QL.WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //friend
            CreateMap<Core.Models.Friend, Models.Friend>(MemberList.Destination)
                .ForMember(dest => dest.DroidId, opt => opt.MapFrom(src => src.Droid.Id))
                .ForMember(dest => dest.DroidName, opt => opt.MapFrom(src => src.Droid.Name));

            CreateMap<Core.Models.Droid, Models.Droid>(MemberList.Destination)
                .ForMember(dest => dest.Friends,opt => opt.Ignore());
        }
    }
}
