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

namespace PracticaCasita
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for(float c=0; c < 360; c++)
            {
                plnSol.Points.Add(new Point(Math.Cos(c) * 50 + 100,Math.Sin(c)*50 + 100));
            }

            plnPasto1.Points.Add(new Point(25.00,370.00));
            plnPasto1.Points.Add(new Point(45.00,405.00));
            plnPasto1.Points.Add(new Point(65.00,370.00));

            plnPasto2.Points.Add(new Point(85.00, 370.00));
            plnPasto2.Points.Add(new Point(105.00, 405.00));
            plnPasto2.Points.Add(new Point(125.00, 370.00));

            plnPasto3.Points.Add(new Point(145.00, 370.00));
            plnPasto3.Points.Add(new Point(165.00, 405.00));
            plnPasto3.Points.Add(new Point(185.00, 370.00));

            plnPasto4.Points.Add(new Point(205.00, 370.00));
            plnPasto4.Points.Add(new Point(225.00, 405.00));
            plnPasto4.Points.Add(new Point(245.00, 370.00));

            plnPasto5.Points.Add(new Point(265.00, 370.00));
            plnPasto5.Points.Add(new Point(285.00, 405.00));
            plnPasto5.Points.Add(new Point(305.00, 370.00));

            plnSuelo.Points.Add(new Point(0.00, 410.00));
            plnSuelo.Points.Add(new Point(800.00, 410.00));

            plnCasa.Points.Add(new Point(320.00, 405.00));
            plnCasa.Points.Add(new Point(570.00, 405.00));
            plnCasa.Points.Add(new Point(570.00, 205.00));
            plnCasa.Points.Add(new Point(320.00, 205.00));
            plnCasa.Points.Add(new Point(320.00, 407.00));

            plnTecho.Points.Add(new Point(320.00, 205.00));
            plnTecho.Points.Add(new Point(570.00, 205.00));
            plnTecho.Points.Add(new Point(445.00, 100.00));
            plnTecho.Points.Add(new Point(320.00, 205.00));

            plnPuerta.Points.Add(new Point(425.00, 405.00));
            plnPuerta.Points.Add(new Point(425.00, 335.00));
            plnPuerta.Points.Add(new Point(465.00, 335.00));
            plnPuerta.Points.Add(new Point(465.00, 405.00));

            plnVentana.Points.Add(new Point(465.00,255.00));
            plnVentana.Points.Add(new Point(520.00, 255.00));
            plnVentana.Points.Add(new Point(520.00, 285.00));
            plnVentana.Points.Add(new Point(465.00, 285.00));
            plnVentana.Points.Add(new Point(465.00, 255.00));

            plnProteccion.Points.Add(new Point(492.00, 255.00));
            plnProteccion.Points.Add(new Point(492.00, 285.00));

            plnProteccion2.Points.Add(new Point(465.00, 270.00));
            plnProteccion2.Points.Add(new Point(520.00, 270.00));

            plnTronco.Points.Add(new Point(630.00, 405.00));
            plnTronco.Points.Add(new Point(630.00, 250.00));
            plnTronco2.Points.Add(new Point(700.00, 405.00));
            plnTronco2.Points.Add(new Point(700.00, 250.00));

            plnHojas.Points.Add(new Point(630.00, 250.00));
            plnHojas.Points.Add(new Point(600.00, 200.00));
            plnHojas.Points.Add(new Point(660.00, 150.00));
            plnHojas.Points.Add(new Point(730.00, 200.00));
            plnHojas.Points.Add(new Point(700.00, 250.00));


        }
    }
}
