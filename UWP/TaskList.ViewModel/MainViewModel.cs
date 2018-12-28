using System;
using System.Collections.Generic;
using System.Text;
using TaskList.Interface;

namespace TaskList.ViewModel
{
    public class MainViewModel : IMainViewModel
    {
        public INavigationService NavigationService { set; get; }

        public void StartNavigation()
        {
            NavigationService.Navigate(PageKeys.NewTaskPage, this);
        }
    }
}
