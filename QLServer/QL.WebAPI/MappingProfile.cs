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
            CreateMap<Core.Models.Droid, Models.Droid>(MemberList.Destination)
                .ForMember(dest => dest.Friends, opt => opt.Ignore());

            CreateMap<Core.Models.Classification, Models.Classification>(MemberList.Destination);

            CreateMap<Core.Models.User, Models.User>(MemberList.Destination);

            //friend
            CreateMap<Core.Models.Friend, Models.Friend>(MemberList.Destination)
                .ForMember(dest => dest.DroidId, opt => opt.MapFrom(src => src.Droid.Id))
                .ForMember(dest => dest.DroidName, opt => opt.MapFrom(src => src.Droid.Name));

            //articale
            CreateMap<Core.Models.Articale, Models.Articale>(MemberList.Destination)
                .ForMember(dest => dest.ClassificationId, opt => opt.MapFrom(src => src.Classification.Id))
                .ForMember(dest => dest.Classification, opt => opt.MapFrom(src => src.Classification.Name))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.NickName));
        }
    }
}
