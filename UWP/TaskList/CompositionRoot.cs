using System;
using System.Reflection;
using Autofac;
using TaskList.Data;
using TaskList.Interface;
using TaskList.Service;
using TaskList.ViewModel;
using Windows.UI.Xaml.Controls;

namespace TaskList.Integration
{
    public class CompositionRoot
    {
        public static IMainViewModel GetMainViewModel(Frame frame)
        {
            IContainer container = BuildContainer(frame);

            var mainViewModel = container.Resolve<IMainViewModel>();
            /*mainViewModel.NavigationService = container.
                Resolve<INavigationService>(
                new NamedParameter("frame", frame));
            */
            return mainViewModel;
        }

        private static IContainer BuildContainer(Frame frame)
        {
            var containerBuilder = new ContainerBuilder();
            var taskListAssembly = Assembly.GetExecutingAssembly();
            var serviceAssembly = Assembly.GetAssembly(typeof(NavigationService));
            var repositoryAssembly = Assembly.GetAssembly(typeof(TaskRepository));
            var viewModelAssembly = Assembly.GetAssembly(typeof(MainViewModel));

            //Место для добавления Page
            containerBuilder.RegisterAssemblyTypes(taskListAssembly).Where(t => t.Name.EndsWith("Page", 
                     StringComparison.CurrentCultureIgnoreCase)).Keyed<Page>(x => x.Name);




            // Место для добавления сервисов
            containerBuilder.RegisterAssemblyTypes(serviceAssembly).Where(t => t.Name.EndsWith("Service",
                    StringComparison.CurrentCultureIgnoreCase)).AsImplementedInterfaces().WithParameter("frame",frame);


            //containerBuilder.
            //    RegisterType<NavigationService>().
            //    As<INavigationService>().WithParameter("frame", frame);


            // Добавление MainViewModel
            containerBuilder.RegisterAssemblyTypes(viewModelAssembly).Where(t => t.Name.EndsWith("ViewModel",
                    StringComparison.CurrentCultureIgnoreCase)).PropertiesAutowired();

            //containerBuilder.
            //     RegisterType<MainViewModel>().
            //     As<IMainViewModel>().PropertiesAutowired();

            //добавление Repository
            containerBuilder.RegisterAssemblyTypes(repositoryAssembly).Where(t => t.Name.EndsWith("Repository",
                    StringComparison.CurrentCultureIgnoreCase)).AsImplementedInterfaces();


            return containerBuilder.Build();
        }
    }
}
