using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Interface
{
    public interface INavigationService
    {
        /// <summary> 
        /// Постраничная навигация 
        /// </summary> 
        /// <param name="pageKeys">Страница</param> 
        /// <param name="vm">ViewModel страницы</param> 
        /// <returns>Результат перехода</returns> 
        bool Navigate(PageKeys pageKeys, IViewModel vm);

        /// <summary> 
        /// Постраничная навигация с параметром 
        /// </summary> 
        /// <param name="pageKeys">Страница</param> 
        /// <param name="vm">ViewModel страницы</param> 
        /// <param name="param">Дополнительные параметры при переходе на другую страницу</param> 
        /// <returns>Результат перехода</returns> 
        bool Navigate(PageKeys pageKeys, IViewModel vm, object param = null);
    }
}