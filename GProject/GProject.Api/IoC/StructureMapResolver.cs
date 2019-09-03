﻿using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace GProject.Api.IoC
{
    public class StructureMapScope : IDependencyScope
    {
        private readonly IContainer container;

        public StructureMapScope(IContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == null)
            {
                return null;
            }

            if (serviceType.IsAbstract || serviceType.IsInterface)
            {
                return this.container.TryGetInstance(serviceType);
            }

            return this.container.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.container.GetAllInstances(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            this.container.Dispose();
        }
    }

    public class StructureMapResolver : StructureMapScope, IDependencyResolver
    {
        private readonly IContainer container;

        public StructureMapResolver(IContainer container) : base(container)
        {
            this.container = container;
        }

        public IDependencyScope BeginScope()
        {
            var childContainer = this.container.GetNestedContainer();
            return new StructureMapScope(childContainer);
        }
    }
    
}