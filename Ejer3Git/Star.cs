using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Ejer3Git
{
    class Star
    {
        //contenido del label
        char content = '*';
        //posicion en el canvas
        int x;
        int y;
        //variacion de opacidad
        int vari;
        int difOp;
        Label labelStar;
        Grid panel;
        static Random rnd = new Random();
        public Star(Grid g)
        {
            this.panel = g;
            //valores para todos los labels
            this.labelStar = new Label();
            this.labelStar.Content = this.content;
            this.labelStar.VerticalAlignment = VerticalAlignment.Bottom;
            this.labelStar.Foreground = new SolidColorBrush(Colors.White);
            this.labelStar.SetValue(Panel.ZIndexProperty,-2);
            this.labelStar.FontSize = Star.Rnd(10, 20);
            //para cada label es diferente
            LabelConfiguration();
            //lo añadimos al grid
            this.panel.Children.Add(this.labelStar);
            //lo mostramos
            this.PrintLabel();
        }
        /// <summary>
        /// Configuracion del labelStar
        /// </summary>
        private void LabelConfiguration()
        {
            //posicion aleatoria dentro del gridCenter
            this.x = Star.Rnd(0, (int)panel.ActualWidth);
            this.y = Star.Rnd(118, (int)panel.ActualHeight);//el 118 es la altura del primer arbol, asi las estrellas quedan por encima suyo
            //variables para cambiar la opacidad
            this.vari = Star.Rnd(1,10);
            this.difOp = 1;
        }
        /// <summary>
        /// Dibujar el label
        /// </summary>
        public void PrintLabel()
        {
            this.labelStar.Visibility = Visibility.Visible;
            this.labelStar.Margin = new Thickness(this.x,0,0,this.y);
            this.difOp += this.vari;
            //la opacidad va a %
            this.labelStar.Foreground.Opacity =(double)(1 / (float)this.difOp);
            //cuando llegue un momento que sea tan transparente que no se vea, cambiamos
            //su posicion
            if (this.difOp > 50)
            {
                this.LabelConfiguration();
            }
        }
        /// <summary>
        /// Ocultar label
        /// </summary>
        public void HideLabel()
        {
            this.labelStar.Visibility = Visibility.Hidden;
        }
        //obtener un valor aleatorio entre a y b
        private static int Rnd(int a, int b)
        {
            try { return Star.rnd.Next(a,b);}
            catch (Exception ex) { return 0; }
        }
        

    }
}
