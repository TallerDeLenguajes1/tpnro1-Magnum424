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
using System.IO;
using System.ComponentModel;

namespace Tp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creo una lista de alumnos global
        BindingList<Alumno> alumnos;

        public MainWindow()
        {
            InitializeComponent();
            //Inicializo la lista
            alumnos = new BindingList<Alumno>();
            lbxListin.ItemsSource = alumnos;
            
        }
        //Creo un evento del boton para cargar los alumnos
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Alumno alum = new Alumno();
            alum.Id = Convert.ToInt32(txbID.Text);
            alum.Nombre = txbNombre.Text;
            alum.Apellido = txbApellido.Text;
            alum.Curso = cbbCursos.Text;
            alumnos.Add(alum);
        }
    }
}
