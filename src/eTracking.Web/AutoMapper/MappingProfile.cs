using AutoMapper;
using eTracking.Identity;
using eTracking.Model;
using eTracking.Web.ViewModels;

namespace eTracking.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
    : this("MyProfile")
        {
        }
        protected MappingProfile(string profileName)
    : base(profileName)
        {
            CreateMap<Staff, StaffViewModel>();
            //.ForMember(x => x.abc, m => m.MapFrom(x => x.MajorID + x.Phone));
            CreateMap<StaffViewModel, Staff>();

            CreateMap<WorkFlowViewModel, WorkFlow>()
            .ForMember(x => x.Created, opt => opt.Ignore());

            CreateMap<WorkFlow, WorkFlowViewModel>();

            CreateMap<Project_StaffViewModel, Project_Staff>();
            CreateMap<Project_Staff, Project_StaffViewModel>();

            CreateMap<ProjectViewModel, Project>();
            CreateMap<Project, ProjectViewModel>();
            //.ForMember(x => x.ProjectStaffs, m => m.MapFrom(x => x.ProjectStaffs.Select(s => s.Staff)));

            CreateMap<ActivityViewModel, Activity>();
            CreateMap<Activity, ActivityViewModel>();

            CreateMap<Activity_WorkFlowViewModel, Activity_WorkFlow>();
            CreateMap<Activity_WorkFlow, Activity_WorkFlowViewModel>();

            CreateMap<ApplicationUser, RegisterViewModel>();
            CreateMap<RegisterViewModel, ApplicationUser>();
        }

    }
}
