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
        //Creo una lista de alumnos global y tres writers para cargar los archivos
        ///Utilizo una bindinglist por recomendacion 
        BindingList<Alumno> alumnos;
        StreamWriter sw;
        StreamWriter sw1;
        StreamWriter sw2;

        public MainWindow()
        {
            InitializeComponent();
            //Inicializo la lista
            alumnos = new BindingList<Alumno>();
            //sw = new StreamWriter(File.Open("Futbol.csv",FileMode.OpenOrCreate));
            //sw1 = new StreamWriter(File.Open("Voley.csv", FileMode.OpenOrCreate));
            //sw2 = new StreamWriter(File.Open("Atletismo.csv", FileMode.OpenOrCreate));
            //Vinculo los elementos de la lbx a los elementos de mi lista alumnos, que se crean y modifican en la lista y se muestran en la lbx
            lbxListin.ItemsSource = alumnos;
            
        }
        //Creo un evento del boton para cargar los alumnos
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Creo una instancia de un alumno con los datos ingresados en las txb
            Alumno alum = new Alumno(Convert.ToInt32(txbID.Text), txbNombre.Text, txbApellido.Text, cbbCursos.Text);
            //Agrego el alumno creado en la lista
            alumnos.Add(alum);
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            sw = new StreamWriter(File.Open("Futbol.csv", FileMode.OpenOrCreate));
            sw1 = new StreamWriter(File.Open("Voley.csv", FileMode.OpenOrCreate));
            sw2 = new StreamWriter(File.Open("Atletismo.csv", FileMode.OpenOrCreate));
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Curso == "Futbol")
                {
                    sw.Write($"{alumno.Id};");
                    sw.Write($"{alumno.Nombre};");
                    sw.Write($"{alumno.Apellido};\n");
                    sw.Close();
                }
                if(alumno.Curso == "Voley")
                {
                    sw1.Write($"{alumno.Id};");
                    sw1.Write($"{alumno.Nombre};");
                    sw1.Write($"{alumno.Apellido};\n");
                    sw1.Close();
                }
                if(alumno.Curso == "Atletismo")
                {
                    sw2.Write($"{alumno.Id};");
                    sw2.Write($"{alumno.Nombre};");
                    sw2.Write($"{alumno.Apellido};\n");
                    sw2.Close();
                }
            }
            MessageBox.Show("Archivos cargados");
        }
    }
}
