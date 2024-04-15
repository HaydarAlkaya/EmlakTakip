using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFreamwork;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().SingleInstance();

            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();

            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();
            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();

            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();

            builder.RegisterType<EfNeighbourhoodDal>().As<INeighbourhoodDal>().SingleInstance();
            builder.RegisterType<NeighbourhoodManager>().As<INeighbourhoodService>().SingleInstance();

            builder.RegisterType<EfOwnerShipDal>().As<IOwnerShipDal>().SingleInstance();
            builder.RegisterType<OwnerShipManager>().As<IOwnerShipService>().SingleInstance();

            builder.RegisterType<EfParselQueryDal>().As<IParselQueryDal>().SingleInstance();
            builder.RegisterType<ParselQueryManager>().As<IParselQueryService>().SingleInstance();

            builder.RegisterType<EfTownDal>().As<ITownDal>().SingleInstance();
            builder.RegisterType<TownManager>().As<ITownService>().SingleInstance();

            builder.RegisterType<EmlakTakipContext>().AsSelf().InstancePerLifetimeScope();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }

    }
}
