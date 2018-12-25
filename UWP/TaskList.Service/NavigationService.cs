using System;
using TaskList.Interface;
using Windows.UI.Xaml.Controls;

namespace TaskList.Service
{
    public class NavigationService : INavigationService
    {
        private Frame frame;

        public NavigationService(Frame frame)
        {
            this.frame = frame;
        }

        /// <summary> 
        /// Постраничная навигация 
        /// </summary> 
        /// <param name="pageKeys">Страница</param> 
        /// <param name="vm">ViewModel страницы</param> 
        /// <returns>Результат перехода</returns> 
        public bool Navigate(PageKeys pageKeys, IViewModel vm)
        {
            // TODO Реализовать метод навигации 
                //return frame.Navigate(typeof(MainPage));

            return false;
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