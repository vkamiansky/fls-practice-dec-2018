using System;
using Autofac;
using TaskList.Interface;
using TaskList.Service;
using TaskList.View;
using TaskList.ViewModel;
using Windows.UI.Xaml.Controls;

namespace TaskList.Integration
{
    public class CompositionRoot
    {
        private static IContainer container;

        public static IMainViewModel GetMainViewModel(Frame frame)
        {
            if (container == null)
                container = BuildContainer();

            var mainViewModel = container.Resolve<IMainViewModel>();
            mainViewModel.NavigationService = container.
                Resolve<INavigationService>(
                new NamedParameter("frame", frame));

            return mainViewModel;
        }

        private static IContainer BuildContainer()
        {
            var containerBuilder = new ContainerBuilder();

            // Место для добавления сервисов
            containerBuilder.
                RegisterType<NavigationService>().
                As<INavigationService>();

            // Добавление страниц
            containerBuilder.
                RegisterType<MainPage>().
                Keyed<Page>(PageKeys.MainPage);

            // Добавление MainViewModel
            containerBuilder.
                 RegisterType<MainViewModel>().
                 As<IMainViewModel>();

            return containerBuilder.Build();
        }
    }
}
