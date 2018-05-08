using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CarsControl
{
    /// <summary>
    /// Interaction logic for Cards.xaml
    /// </summary>
    public partial class Cards : UserControl
    {
        private bool IsExpanded;
        public Cards()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
             ///add codes here for the tick button
        }

        private void arrow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (IsExpanded)
            {
                IsExpanded = false;
                this.Height = 48;
                arrow.RenderTransform = new RotateTransform(90);
            }
            else
            {
                IsExpanded = true;
                Height = 426;
                arrow.RenderTransform = new RotateTransform(-90);
            }
           }
    }
}
