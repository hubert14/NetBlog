using Autofac;

namespace NetBlog.Utils.DI
{
    public static class AutofacContainerBuilderExtensions
    {
        public static void RegisterDependencies(this ContainerBuilder builder)
        {
            //builder.RegisterType<{type}>().As<{interface}>();
        }
    }
}