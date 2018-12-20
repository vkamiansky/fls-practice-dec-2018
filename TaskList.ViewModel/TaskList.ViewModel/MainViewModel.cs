using System;
using TaskList.Interface;
using TaskList.Service;

namespace TaskList.ViewModel
{
    public class MainViewModel : IMainViewModel
    {
        NavigationService NavigationService { set; get; }        
    }
}
