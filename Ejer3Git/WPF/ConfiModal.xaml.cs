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
    /// Lógica de interacción para ConfiModal.xaml
    /// </summary>
    public partial class ConfiModal : Window
    {
        public List<ColorNavidad> xtmasColorList;
        public Color colorAns;
        public Boolean ballVisivility;
        public ConfiModal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Añadimos elementos a la lista
        /// </summary>
        private void addColorNavidad()
        {
            xtmasColorList = new List<ColorNavidad>(){
                new ColorNavidad(Colors.Red, "Rojo","Navidades calurosas"),
            new ColorNavidad(Colors.Olive, "Olive","Navidades mediterraneas"),
            new ColorNavidad(Colors.Peru,"Peru","Navidades finlandesas"),
            new ColorNavidad(Colors.DarkCyan,"Cyan","Navidad cercana al mar")
            };
        }
        /// <summary>
        /// Cada vez que cargamos la ventanaModal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.addColorNavidad();
            this.changeColorBall.ItemsSource = xtmasColorList;
            this.changeColorBall.SelectedItem = xtmasColorList.ElementAt(0);
        }
        /// <summary>
        /// Aceptamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.colorAns = ((ColorNavidad)this.changeColorBall.SelectedItem).Color;
            this.ballVisivility = (bool)showBalls.IsChecked;
            base.Close();
        }
        /// <summary>
        /// Cancelamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            base.Close();
        }
    }
    /// <summary>
    /// Clase que representa los elementos que introduciremos en el ComboBox
    /// </summary>
    public class ColorNavidad
    {
        public Color Color{get;set;}
        public String Nombre{get;set;}
        public String Estado{get;set;}
        public ColorNavidad(Color c, String n, String e)
        {
            this.Color=c;
            this.Nombre=n;
            this.Estado=e;
        }
    }
}
