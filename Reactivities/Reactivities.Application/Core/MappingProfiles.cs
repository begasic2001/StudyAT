

using AutoMapper;
using Reactivities.Application.Activities;
using Reactivities.Application.Comments;
using Reactivities.Domain;

namespace Reactivities.Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //CreateMap<Activity, Activity>();
            CreateMap<Activity, ActivityDto>()
                    .ForMember(d => d.HostUserName, 
                    o => o.MapFrom(s => s.Attendees.FirstOrDefault(x => x.IsHost).AppUser.UserName));
            CreateMap<ActivityAttendee,AttendeeDto>()
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.AppUser.UserName))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.AppUser.Bio))
                .ForMember(d => d.Image, o => o.MapFrom(s => s.AppUser.Photos.FirstOrDefault(x => x.IsMain).ImageUrl));
            CreateMap<AppUser, Profiles.Profile>()
                .ForMember(d => d.Image, o => o.MapFrom(s => s.Photos.FirstOrDefault(x=>x.IsMain).ImageUrl));
            CreateMap<Comment,CommentDto>()
                .ForMember(d => d.DisplayName, o=>o.MapFrom(s => s.Author.DisplayName))
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.Author.UserName))
                .ForMember(d => d.Image, o => o.MapFrom(s => s.Author.Photos.FirstOrDefault(x => x.IsMain).ImageUrl));


        }
    }
}
