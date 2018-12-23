using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Control
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            

        }

        private Point mousePosition;

        private void grid_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            mousePosition = e.GetCurrentPoint(grid).Position;
            if(mousePosition.X<500 && mousePosition.Y < 500 && mousePosition.X > 0 && mousePosition.Y > 0)
            {
                mousePosition.X -= 10;
                mousePosition.Y -= 10;
                round.DataContext = mousePosition;
            }

        }
    }
}
