using System;
using StructureMap;
using Microsoft.Extensions.DependencyInjection;
using eTracking.Model;
using eTracking.Interface.Repositories;
using eTracking.DAL.Repositories;
using eTracking.Interface.BusinessLogics;
using eTracking.BusinessLogic;
using eTracking.Interface.Services;
using eTracking.Service;
using eTracking.EmailServices;

namespace eTracking.Ioc
{
    public static class ConfigureStructureMap
    {
        public static IServiceProvider ConfigureIoC(IServiceCollection services)
        {
            var container = new Container();

            container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs...
                config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Startup));
                    _.WithDefaultConventions();
                });

                //Models
                //config.For<IMajor>().Use<Major>();
                //config.For<IProject>().Use<Project>();
                //config.For<IProjectStatus>().Use<ProjectStatus>();
                //config.For<IPosition>().Use<Position>();
                //config.For<IStaff>().Use<Staff>();

                //Repositories
                config.For<IMajorRepository>().Use<MajorRepository>();
                config.For<IProjectRepository>().Use<ProjectRepository>();
                config.For<IProjectStatusRepository>().Use<ProjectStatusRepository>();
                config.For<IPositionRepository>().Use<PositionRepository>();
                config.For<IStaffRepository>().Use<StaffRepository>();

                //BusinessLogics
                config.For<IMajorBusinessLogic>().Use<MajorBusinessLogic>();
                config.For<IProjectBusinessLogic>().Use<ProjectBusinessLogic>();
                config.For<IProjectStatusBusinessLogic>().Use<ProjectStatusBusinessLogic>();
                config.For<IPositionBusinessLogic>().Use<PositionBusinessLogic>();
                config.For<IStaffBusinessLogic>().Use<StaffBusinessLogic>();

                //Services
                config.For<IMajorService>().Use<MajorService>();
                config.For<IProjectService>().Use<ProjectService>();
                config.For<IProjectStatusService>().Use<ProjectStatusService>();
                config.For<IPositionService>().Use<PositionService>();
                config.For<IStaffService>().Use<StaffService>();

                //Populate the container using the service collection
                config.Populate(services);
            });

            return container.GetInstance<IServiceProvider>();

        }
    }
}
