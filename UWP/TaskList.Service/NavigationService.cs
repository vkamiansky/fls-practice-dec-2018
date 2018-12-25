using System;
using TaskList.Interface;
using Windows.UI.Xaml.Controls;
using Autofac.Features.Indexed;

namespace TaskList.Service
{
    public class NavigationService : INavigationService
    {
        private Frame frame;
        private IIndex<string,Page> index;

        public NavigationService(Frame frame, IIndex<string, Page> index)
        {
            this.frame = frame;
            this.index = index;
        }

        /// <summary> 
        /// Постраничная навигация 
        /// </summary> 
        /// <param name="pageKeys">Страница</param> 
        /// <param name="vm">ViewModel страницы</param> 
        /// <returns>Результат перехода</returns> 
        public bool Navigate(PageKeys pageKeys, IViewModel vm)
        {
            Page page = index[pageKeys.ToString()];
            page.DataContext = vm;
            Type type = page.GetType();
            return frame.Navigate(type);
        }

        /// <summary> 
        /// Постраничная навигация с параметром 
        /// </summary> 
        /// <param name="pageKeys">Страница</param> 
        /// <param name="vm">ViewModel страницы</param> 
        /// <param name="param">Дополнительные параметры при переходе на другую страницу</param> 
        /// <returns>Результат перехода</returns> 
        public bool Navigate(PageKeys pageKeys, IViewModel vm, object param = null)
        {
            // TODO Реализовать метод навигации с параметрами 
            throw new NotImplementedException();
        }
    }
}