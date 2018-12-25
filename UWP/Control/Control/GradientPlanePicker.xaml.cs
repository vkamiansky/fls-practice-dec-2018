using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пользовательский элемент управления" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234236

namespace Control
{
    public sealed partial class GradientPlanePicker : UserControl
    {
        public GradientPlanePicker()
        {
            this.InitializeComponent();
        }
        private Point mousePosition;
        private bool check=false;

        public static readonly DependencyProperty XProperty;
        public static readonly DependencyProperty YProperty;
        public static readonly DependencyProperty X_TitleProperty;
        public static readonly DependencyProperty Y_TitleProperty;
        static GradientPlanePicker()
        {
            XProperty = DependencyProperty.Register("X", typeof(double),typeof(GradientPlanePicker),new PropertyMetadata(null) );
            YProperty = DependencyProperty.Register("Y", typeof(double), typeof(GradientPlanePicker), new PropertyMetadata(null));
            Y_TitleProperty = DependencyProperty.Register("Y_Title", typeof(string), typeof(GradientPlanePicker), new PropertyMetadata(null));
            X_TitleProperty = DependencyProperty.Register("X_Title", typeof(string), typeof(GradientPlanePicker), new PropertyMetadata(null));
        }

        
        public double X {
            get
            {
                return (double)GetValue(XProperty);
            }
            set
            {
                SetValue(XProperty, value);
            }
        }
        public double Y
        {
            get
            {
                return (double)GetValue(YProperty);
            }
            set
            {
                SetValue(YProperty, value);
            }
        }
        public string X_Title
        {
            get
            {
                return (string)GetValue(X_TitleProperty);
            }
            set
            {
                SetValue(X_TitleProperty, value);
            }
        }
        public string Y_Title
        {
            get
            {
                return (string)GetValue(Y_TitleProperty);
            }
            set
            {
                SetValue(Y_TitleProperty, value);
            }
        }


        private void grid_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if(!check)
            {
                mousePosition = GetCoordinates(sender, e);
                round.DataContext = mousePosition;
            }
        }

        private void grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

            Point point= GetCoordinates(sender, e);
            X = point.X;
            Y = point.Y;
            check = !check;
        }


        private Point GetCoordinates(object sender, PointerRoutedEventArgs e)
        {
            var gr = (Grid)sender;
            Point position = e.GetCurrentPoint(gr).Position;

            if (position.X > gr.Width - round.Width)
            {
                position.X -= round.Width;

                if (position.Y > gr.Height - round.Height)
                {
                    position.Y -= round.Height;
                }

            }
            else if (position.Y > gr.Height - round.Height)
            {
                position.Y -= round.Height;
            }
            return position;
        }
    }
}
