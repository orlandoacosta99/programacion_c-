[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CompraloTo.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CompraloTo.NinjectWebCommon), "Stop")]

namespace CompraloTo
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using DB;
    using ViewModels;
    using WebPortal;
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            ServiceInjector.Kernel = kernel;

            kernel.Bind<IDbContext>().To<GlobalDbContext>().InRequestScope();
            kernel.Bind<IEmailService>().To<EmailService>().InRequestScope();
            kernel.Bind<IEmailRenderer>().To<EmailRenderer>().InRequestScope();

            ILogService logService = new LogService();
            kernel.Bind<ILogService>().ToConstant(logService);


            kernel.Bind<IProductQueryService>().To<ProductQueryService>().InRequestScope();
            kernel.Bind<IProductCommandService>().To<ProductCommandService>().InRequestScope();

            kernel.Bind<ICustomerQueryService>().To<CustomerQueryService>().InRequestScope();
            kernel.Bind<ICustomerCommandService>().To<CustomerCommandService>().InRequestScope();

            kernel.Bind<IUserCommandService>().To<UserCommandService>().InRequestScope();
            kernel.Bind<IUserQueryService>().To<UserQueryService>().InRequestScope();

            kernel.Bind<IAccountService>().To<AccountService>().InRequestScope();
            kernel.Bind<ICartService>().To<CartService>().InRequestScope();
        }
    }


    public static class ServiceInjector
    {
        public static IKernel Kernel { get; set; }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }

}
