using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnClickable_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UnClickable_Click(object sender, RoutedEventArgs e)
        {
            Random Rand = new Random();
            int x, y;
            Point MousePos; //point variable is needed to store coordinate positions of objects
            bool WithinBox = true;  //sets all variables
            do
            {
                MousePos = Mouse.GetPosition(Window);  //fetches coordinate position of cursor
                x = Rand.Next(0, Convert.ToInt32(Window.ActualWidth) - Convert.ToInt32(UnClickable.Width + 1));     //sets x and y as a new random number between 0 and the size of the current window - size of button
                y = Rand.Next(0, Convert.ToInt32(Window.ActualHeight) - Convert.ToInt32(UnClickable.Height + 1));
                if (MousePos.X < x || MousePos.X > x + UnClickable.ActualWidth || MousePos.Y < y || MousePos.Y > y + UnClickable.ActualHeight)  //checks if the current mouse position is inside where the button will be places, if so it tries again
                {
                    WithinBox = false;
                }
            } while (WithinBox == true);
            UnClickable.Margin = new Thickness(x,y,0,0); //sets where the new button position is
        }
        
    }
}
