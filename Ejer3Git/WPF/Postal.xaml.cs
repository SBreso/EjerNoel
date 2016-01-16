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
using System.Windows.Threading;

namespace Ejer3Git
{
    /// <summary>
    /// Lógica de interacción para Postal.xaml
    /// </summary>
    public partial class Postal : Window
    {
        //ventana no modal
        StarsNoModal StarsWin;
        //Lista de star
        List<Star> starList;
        //num de estrellas
        int countStars;
        //color de las bolas
        Color colorBall;
        //visibilidad de las bolas
        Boolean ballVisivility;
        //para controlar el movimiento del label y las estrellas
        DispatcherTimer timer = new DispatcherTimer();
        /// <summary>
        /// Constructor
        /// </summary>
        public Postal()
        {
            InitializeComponent();
            base.Closing += new System.ComponentModel.CancelEventHandler(Exit);
            //ventana no modal
            this.StarsWin = new StarsNoModal();
            //numero de estrellas de inicio
            this.countStars = 20;
            //color de inicio de bolas
            this.colorBall = Colors.Red;
            //de inicio las bolas se ven
            this.ballVisivility = true;
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
        /// al presionar en 'OK' salimos de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            base.Close();
        }
        /// <summary>
        /// Mostrar la ventana para escoger el numero de estrellas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animacionButton_Click(object sender, RoutedEventArgs e)
        {
            this.StarsWin.Show();
        }
        /// <summary>
        /// Mostrar la ventana de configuracion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cargar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.starList = new List<Star>();
            for (int i = 0; i < 40; i++)
            {
                this.starList.Add(new Star(this.gridCenter));
            }
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        /// <summary>
        /// Que hacer cada tick. Mover el labelNoel. Mostrar estrellas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.labelNoel.ActualWidth + this.labelNoel.Margin.Left <= 0)
            {
                this.labelNoel.Margin = new Thickness(base.Width, 0, 0, 0);
            }
            else
            {
                this.labelNoel.Margin = new Thickness(this.labelNoel.Margin.Left-15,0,0,0);
            }
            //Tengo todos los labels, solo que segun lo que diga el usuario muestro unos u otros
            for (int i = 0; i < 40; i++)
            {
                if (i < this.countStars)
                {
                    ((Star)this.starList.ElementAt(i)).PrintLabel();
                }
                else
                {
                    ((Star)this.starList.ElementAt(i)).HideLabel();
                }
            }
        }
    }
}
