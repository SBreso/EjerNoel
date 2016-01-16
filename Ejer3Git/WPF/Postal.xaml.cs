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

namespace Ejer3Git
{
    /// <summary>
    /// Lógica de interacción para Postal.xaml
    /// </summary>
    public partial class Postal : Window
    {
        StarsNoModal StarsWin;
        public Postal()
        {
            InitializeComponent();
            base.Closing += new System.ComponentModel.CancelEventHandler(Exit);
            this.StarsWin = new StarsNoModal();
        }
        /// <summary>
        /// Manejador del evento que se produce al cerra la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!this.StarsWin.IsActive)
            {
                this.StarsWin.Close();
            }
            base.Visibility = Visibility.Hidden;
            MessageBox.Show("Y FELIZ NAVIAD!!");
        }
        /// <summary>
        /// Al presionar en 'OK' salimos de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            base.Close();
        }

        private void animacionButton_Click(object sender, RoutedEventArgs e)
        {
            this.StarsWin.Show();
        }

        private void confiButton_Click(object sender, RoutedEventArgs e)
        {
            ConfiModal confiWin = new ConfiModal();
            confiWin.Owner = this;
            confiWin.ShowDialog();
            if (confiWin.DialogResult == true)
            {
                
            }
            else
            {

            }
        }
    }
}
