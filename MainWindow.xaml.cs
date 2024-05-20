using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// MainWindow.xaml.cs
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Ribbon;


namespace ADHD_To_Do_Program_Game_Interaction_Yarnick_Haandrikman
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _newTask;
        public string NewTask
        {
            get { return _newTask; }
            set
            {
                _newTask = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NewTask"));
            }
        }
        // Dit voorbeeld definieert een klasse MainWindow met een eigenschap NewTask.
        // Het implementeert INotifyPropertyChanged om wijzigingen in deze eigenschap door te geven aan UI-elementen.


        private ObservableCollection<string> _tasks;
        public ObservableCollection<string> Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tasks"));
            }
        }
        // De code hierboven heeft een eigenschap genaamd "Tasks" die een observable ObservableCollection<string> bevat.
        // Wanneer deze eigenschap wordt ingesteld, wordt de PropertyChanged-gebeurtenis aangeroepen om wijzigingen door te geven aan UI-elementen.

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Tasks = new ObservableCollection<string>();
        }
        // MainWindow constructor initialiseert het venster, stelt DataContext in op zichzelf, en initialiseert de Tasks eigenschap.


        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewTask) && Tasks.Count < 10)
            {
                Tasks.Add(NewTask);
                NewTask = string.Empty;
            }
            else if (Tasks.Count >= 10)
            {
                MessageBox.Show("Je hebt je dagelijkse limiet bereikt!");
            }       // Deze code voegt een nieuwe taak toe aan de takenlijst als de "NewTask" niet leeg is en er minder dan 10 taken zijn.
        }
    }
}