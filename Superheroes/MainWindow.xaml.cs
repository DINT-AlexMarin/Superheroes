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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int heroe = 1;
        List<Superheroe> listaSuperheroes = Superheroe.GetSamples();
        int cantidadSuperheroes;

        public MainWindow()
        {
            InitializeComponent();

            cantidadSuperheroes = listaSuperheroes.Count;
            numeroSuperheroes_TextBlock.Text = heroe + "/" + cantidadSuperheroes;
            imagen_Imagen.DataContext = listaSuperheroes[heroe - 1];
            nombre_TextBlock.DataContext = listaSuperheroes[heroe - 1];
            avengers_Image.DataContext = listaSuperheroes[heroe - 1];
            xmen_Image.DataContext = listaSuperheroes[heroe - 1];
            fondo_DockPanel.DataContext = listaSuperheroes[heroe - 1];
        }

        private void OnClick(object sender, MouseButtonEventArgs e)
        {
            if (heroe < cantidadSuperheroes)
                heroe++;
            numeroSuperheroes_TextBlock.Text = heroe + "/" + cantidadSuperheroes;
            imagen_Imagen.DataContext = listaSuperheroes[heroe - 1];
            nombre_TextBlock.DataContext = listaSuperheroes[heroe - 1];
            avengers_Image.DataContext = listaSuperheroes[heroe - 1];
            xmen_Image.DataContext = listaSuperheroes[heroe - 1];
            fondo_DockPanel.DataContext = listaSuperheroes[heroe - 1];
        }

        private void leftArrow_Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (heroe > 1)
                heroe--;
            numeroSuperheroes_TextBlock.Text = heroe + "/" + cantidadSuperheroes;
            imagen_Imagen.DataContext = listaSuperheroes[heroe - 1];
            nombre_TextBlock.DataContext = listaSuperheroes[heroe - 1];
            avengers_Image.DataContext = listaSuperheroes[heroe - 1];
            xmen_Image.DataContext = listaSuperheroes[heroe - 1];
            fondo_DockPanel.DataContext = listaSuperheroes[heroe - 1];
        }
    }
}
