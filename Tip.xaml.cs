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

namespace ADHD_To_Do_Program_Game_Interaction_Yarnick_Haandrikman
{
    /// <summary>
    /// Interaction logic for Tip.xaml
    /// </summary>
  
    public partial class App : Application
    {
        [STAThread]

        public static void Tip()
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }

        // Dit is een gedeeltelijke klasse "App" met een "Tip" methode. De "Tip" methode initialiseert en voert de toepassing uit.





    }

    public partial class Tip : Window
    {
        public Tip()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();

            // Dit is een vensterklasse genaamd "Tip". Het initialiseert het venster en heeft een methode Continue_Click die een nieuwe MainWindow opent en het huidige venster sluit.
        }
    }
}

