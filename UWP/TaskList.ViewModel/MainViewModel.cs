using System;
using System.Collections.Generic;
using System.Text;
using TaskList.Interface;
using TaskList.Model;

namespace TaskList.ViewModel
{
    public class MainViewModel : IMainViewModel
    {
        INavigationService NavigationService { set; get; }
    }
}
