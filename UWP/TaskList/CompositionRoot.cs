using System;
using Autofac;
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

            containerBuilder.RegisterType<MainPage>().Keyed<Page>("MainPage");

            // Место для добавления сервисов
            containerBuilder.
                RegisterType<NavigationService>().
                As<INavigationService>().WithParameter("frame", frame);


            // Добавление MainViewModel
            containerBuilder.
                 RegisterType<MainViewModel>().
                 As<IMainViewModel>().PropertiesAutowired();

            return containerBuilder.Build();
        }
    }
}
