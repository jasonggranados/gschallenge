using MediatR;
using MediatR.Pipeline;
using StructureMap;
using StructureMap.Pipeline;
using System.Web.Http.Dependencies;
using GProject.Infrastructure.IoC;
using GProject.Core.Domain;

namespace GProject.Api.IoC
{
    public static class Bootstraper
    {
        public static IDependencyResolver Bootstrap()
        {
            var container = new Container(cfg =>
            {
                cfg.Scan(scanner =>
                {
                    scanner.AssemblyContainingType<User>();
                    scanner.ConnectImplementationsToTypesClosing(typeof(IRequestHandler<,>));
                    scanner.ConnectImplementationsToTypesClosing(typeof(INotificationHandler<>));
                });

                // Pipeline
                cfg.For(typeof(IPipelineBehavior<,>)).Add(typeof(RequestPreProcessorBehavior<,>));
                cfg.For(typeof(IPipelineBehavior<,>)).Add(typeof(RequestPostProcessorBehavior<,>));
                
                // Constrained notification handlers
                //cfg.For(typeof(INotificationHandler<>)).Add(typeof(ConstrainedPingedHandler<>));

                // This is the default but let's be explicit. At most we should be container scoped.
                cfg.For<IMediator>().LifecycleIs<TransientLifecycle>().Use<Mediator>();

                cfg.For<ServiceFactory>().Use<ServiceFactory>(ctx => ctx.GetInstance);
                cfg.RegisterAll();
            });


            var mediator = container.GetInstance<IMediator>();

            return new StructureMapResolver(container);

        }
    }
}