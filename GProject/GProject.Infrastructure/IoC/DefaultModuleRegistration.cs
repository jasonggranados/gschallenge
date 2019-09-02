using GProject.Core;
using GProject.Core.Storage;
using GProject.Infrastructure.DataStore;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Infrastructure.IoC
{
    public static class DefaultModuleRegistration
    {
        public static void RegisterAll(this ConfigurationExpression cfg)
        {
            cfg.For<IUserRepository>().Use<UserRepository>();
        }
    }
}
