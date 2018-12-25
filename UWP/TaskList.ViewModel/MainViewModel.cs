using System;
using System.Collections.Generic;
using System.Text;
using TaskList.Interface;

namespace TaskList.ViewModel
{
    public class MainViewModel : IMainViewModel
    {
        INavigationService IMainViewModel.NavigationService { set; get; }
    }
}
