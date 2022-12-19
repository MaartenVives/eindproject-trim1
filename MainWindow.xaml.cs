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
using System.IO.Ports;
using eindproject;
using Leds;
using Cube;
using System.Threading;

namespace eindproject
{
    public partial class MainWindow : Window
    {
        SerialPort MijnPoort = new SerialPort("com5");
        LightCube MijnLightCube = new LightCube();
        public MainWindow()
        {
            InitializeComponent();
            // Doe de instelling van de poort.
            MijnPoort.BaudRate = 250000;
            MijnPoort.StopBits = StopBits.One;
            MijnPoort.DataBits = 8;
            MijnPoort.Parity = Parity.None;
            MijnPoort.Open();
            // fig aanroepen
            Figuren();
        }
        // het verstuuren van de leds op de seriele poort
        public void Stuur()
        {
            MijnLightCube.Senddata(MijnPoort);
        }
        // figuren aanmaken voor window
        public void Figuren()
        {
                                    // x vorm
            Line xline = new Line();
            xline.X1 = 300;
            xline.Y1 = 20;
            xline.X2 = 375;
            xline.Y2 = 80;
            xline.Stroke = Brushes.Black;
            xline.StrokeThickness = 5;
            cvnone.Children.Add(xline);

            Line xlinetwo = new Line();
            xlinetwo.X1 = 375;
            xlinetwo.Y1 = 20;
            xlinetwo.X2 = 300;
            xlinetwo.Y2 = 80;
            xlinetwo.Stroke = Brushes.Black;
            xlinetwo.StrokeThickness = 5;
            cvnone.Children.Add(xlinetwo);
                                         // circel vorm
            Ellipse circ = new Ellipse();
            circ.Margin = new Thickness(450, 0, 0, 0);
            circ.Width = 100;
            circ.Height = 100;
            circ.Stroke = Brushes.Black;
            circ.StrokeThickness = 5;
            cvnone.Children.Add(circ);
                                         // rechthoek vorm
            Rectangle rect = new Rectangle();
            rect.Margin = new Thickness(10, 0, 0, 0);
            rect.Width = 100;
            rect.Height = 100;
            rect.Stroke = Brushes.Black;
            rect.StrokeThickness = 5;
            cvnone.Children.Add(rect);
                                         // driehoek vorm
            Line lineone = new Line();
            lineone.X1 = 150;
            lineone.Y1 = 10;
            lineone.X2 = 200;
            lineone.Y2 = 100;
            lineone.Stroke = Brushes.Black;
            lineone.StrokeThickness = 5;
            cvnone.Children.Add(lineone);

            Line linetwo = new Line();
            linetwo.X1 = 150;
            linetwo.Y1 = 10;
            linetwo.X2 = 150;
            linetwo.Y2 = 100;
            linetwo.Stroke = Brushes.Black;
            linetwo.StrokeThickness = 5;
            cvnone.Children.Add(linetwo);

            Line linethree = new Line();
            linethree.X1 = 150;
            linethree.Y1 = 100;
            linethree.X2 = 200;
            linethree.Y2 = 100;
            linethree.Stroke = Brushes.Black;
            linethree.StrokeThickness = 5;
            cvnone.Children.Add(linethree);
        }

        private void Cube_Click(object sender, RoutedEventArgs e)
        {
            MijnLightCube.Reset();
            MijnLightCube.Cube();
            Stuur();
        }

        private void Driehoek_Click(object sender, RoutedEventArgs e)
        {
            MijnLightCube.Reset();
            MijnLightCube.Driehoek();
            Stuur();
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            MijnLightCube.Reset();
            MijnLightCube.Kruis();
            Stuur();
        }

        private void Circel_Click(object sender, RoutedEventArgs e)
        {
            MijnLightCube.Reset();
            MijnLightCube.Circel();
            Stuur();
        }
    }
}
