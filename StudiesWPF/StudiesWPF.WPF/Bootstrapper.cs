using System.Windows;
using Prism.Unity;
using StudiesWPF.WPF.Views;
using Microsoft.Practices.Unity;

namespace StudiesWPF.WPF
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Test>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //Container.RegisterType(typeof(object), typeof(ViewA), "ViewA");
            //Container.RegisterType(typeof(object), typeof(ViewB), "ViewB");

            //Container.RegisterTypeForNavigation<ViewA>("ViewA");
            //Container.RegisterTypeForNavigation<ViewB>("ViewB");
        }
    }

    public static class UnityExtensions
    {
        public static void RegisterTypeForNavigation<T>(this IUnityContainer container, string name)
        {
            container.RegisterType(typeof(object), typeof(T), name);
        }
    }
}
