using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Interface
{
    public interface IMainViewModel : IViewModel
    {
        INavigationService NavigationService { set; get; }
    }
}
