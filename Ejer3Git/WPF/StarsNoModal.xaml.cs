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
using System.Windows.Shapes;

namespace Ejer3Git
{
    /// <summary>
    /// Lógica de interacción para StarsNoModal.xaml
    /// </summary>
    public partial class StarsNoModal : Window
    {
        public delegate void countStarsDel(int n);
        public event countStarsDel countStarsEvent;
        public StarsNoModal()
        {
            InitializeComponent();
        }
        private void countSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                this.countLabel.Content = (int)this.countSlider.Value;
                countStarsEvent((int)this.countSlider.Value);
            }
            catch (Exception ex) { }
        }
    }
}
