using System;
using System.Collections.Generic;
using System.Text;
using TaskList.Interface;
using TaskList.Service;

namespace TaskList.ViewModel
{
    class MainViewModel : IMainViewModel
    {
        NavigationService NavigationService { set; get; }
    }
}
