using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Hospital
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Visit> visitList;
        static public List
    <Doctor> doctorList;
        public MainWindow()
        {
            InitializeComponent();
            visitList = new ObservableCollection
        <Visit>();
            doctorList = new List
            <Doctor>();
            this.visitListView.ItemsSource = visitList;
        }
        private void CreateAddingProcessDoctor(object sender, RoutedEventArgs e)
        {
            var process = new AddingDoctor();
            process.ShowDialog();

            if (process.firstnameTextBox.Text.Length != 0 && process.surnameTextBox.Text.Length != 0 &&
                process.addressTextBox.Text.Length != 0 && process.phoneNumberTextBox.Text.Length != 0)
            {
                var addingDoctor = new Doctor(process.firstnameTextBox.Text, process.surnameTextBox.Text,
                    process.addressTextBox.Text, process.phoneNumberTextBox.Text, process.specializationComboBox.SelectedIndex);
                doctorList.Add(addingDoctor);
            }
            else
            {
                DisplayWindow("Nie można dodać lekarza, ponieważ nie uzupełniono wszystkich pól!");
            }
        }

        private void CreateAddingProcessVisit(object sender, RoutedEventArgs e)
        {
            var process = new AddingVisit();
            process.ShowDialog();

            if (process.firstnameTextBox.Text.Length != 0 && process.surnameTextBox.Text.Length != 0 &&
                process.addressTextBox.Text.Length != 0 && process.phoneNumberTextBox.Text.Length != 0 &&
                process.hourTextBox.Text.Length != 0 && process.dateTextBox.Text.Length != 0)
            {
                var addingPatient = new Person(process.firstnameTextBox.Text, process.surnameTextBox.Text,
                    process.addressTextBox.Text, process.phoneNumberTextBox.Text);

                Doctor selectedDoctor;

                try
                {
                    selectedDoctor = doctorList.Find(x => x.Name == process.doctorNameComboBox.Text);
                    var addingVisit = new Visit(addingPatient, process.hourTextBox.Text, process.dateTextBox.Text, selectedDoctor);
                    visitList.Add(addingVisit);
                }
                catch
                {
                    DisplayWindow("Nie można dodać wizyty, ponieważ nie wybrano lekarza!");
                }
            }
            else
            {
                DisplayWindow("Nie można dodać wizyty, ponieważ nie uzupełniono wszystkich pól!");
            }
        }

        private void ShowDoctors(object sender, RoutedEventArgs e)
        {
            var process = new DoctorsData();
            process.ShowDialog();
        }

        private static void DisplayWindow(string message)
        {
            string caption = "Błąd";
            MessageBox.Show(message, caption, MessageBoxButton.OK);
        }

    }
}

