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

namespace ControlesDeUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridParametrosFigura.Children.Clear();
            switch(cbFigura.SelectedIndex)
            {
                case 0: //Circulo
                    gridParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;

                case 1://Triangulo
                    gridParametrosFigura.Children.Add(new ParametrosTriangulo());
                    break;
                case 2://Rectangulo
                    gridParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;
                case 3://Cuadrado
                    gridParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;
                case 4://Pentagono
                    gridParametrosFigura.Children.Add(new ParametrosPentagono());
                    break;
                case 5://Trapecio
                    gridParametrosFigura.Children.Add(new ParametrosTrapecio());
                    break;

                default:
                    break;
            }
        }

        private void BtnCalcularArea_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;

            switch (cbFigura.SelectedIndex)
            {
                case 0: //circulo
                    double radio =
                        double.Parse(
                    ((ParametrosCirculo)
                        (gridParametrosFigura.Children[0])).txtRadio.Text);

                    area = Math.PI * radio * radio;
                    break;

                case 1: //Triangulo
                    double AlturaT =
                        double.Parse(
                    ((ParametrosTriangulo)
                        (gridParametrosFigura.Children[0])).txtAlturaTriangulo.Text);
                    double BaseT =
                        double.Parse(
                    ((ParametrosTriangulo)
                        (gridParametrosFigura.Children[0])).txtBaseTriangulo.Text);

                    area = (AlturaT * BaseT) / 2;
                    break;

                case 2: //Rectangulo
                    double AlturaR =
                        double.Parse(
                    ((ParametrosRectangulo)
                        (gridParametrosFigura.Children[0])).txtAlturaRectangulo.Text);
                    double BaseR =
                        double.Parse(
                    ((ParametrosRectangulo)
                        (gridParametrosFigura.Children[0])).txtBaseRectangulo.Text);

                    area = AlturaR * BaseR;
                    break;

                case 3: //Cuadrado
                    double AlturaC =
                        double.Parse(
                    ((ParametrosCuadrado)
                        (gridParametrosFigura.Children[0])).txtAlturaC.Text);
                    double BaseC =
                    double.Parse(
                ((ParametrosCuadrado)
                    (gridParametrosFigura.Children[0])).txtBaseC.Text);

                    area = AlturaC * BaseC;
                    break;

               case 4: //Pentagono
                    double Perimetro =
                        double.Parse(
                    ((ParametrosPentagono)
                        (gridParametrosFigura.Children[0])).txtPerimetro.Text);
                    double Apotema =
                      double.Parse(
                  ((ParametrosPentagono)
                      (gridParametrosFigura.Children[0])).txtApotema.Text);

                    area = (Perimetro * Apotema) / 2;

                    break;

                    
                 case 5: //Trapecio
                    double BaseMen =
                        double.Parse(
                    ((ParametrosTrapecio)
                        (gridParametrosFigura.Children[0])).txtBaseMenor.Text);
                    double BaseMay =
                       double.Parse(
                   ((ParametrosTrapecio)
                       (gridParametrosFigura.Children[0])).txtBaseMayor.Text);
                    double AlturaTR =
                       double.Parse(
                   ((ParametrosTrapecio)
                       (gridParametrosFigura.Children[0])).txtAlturaTrapecio.Text);

                    area= ((BaseMay+BaseMen)*AlturaTR) / 2;

                    break;





                default:
                    break;
            }
            txtAreaGeneral.Text = area.ToString();
        }
    }
}
