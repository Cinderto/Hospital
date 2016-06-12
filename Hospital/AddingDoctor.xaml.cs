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

namespace Hospital
{
    public partial class AddingDoctor : Window
    {
        public List<string> ListOfSpecialization;

        public AddingDoctor()
        {
            InitializeComponent();
            var list = GetEnumList<TypeOfSpecialization>();
        }

        private List<string> GetEnumList<TypeOfSpecialization>()
        {
            if (!typeof(TypeOfSpecialization).IsEnum)
            {
                throw new InvalidOperationException();
            }

            return Enum.GetNames(typeof(TypeOfSpecialization)).ToList();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            ListOfSpecialization = GetEnumList<TypeOfSpecialization>();

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = ListOfSpecialization;
            comboBox.SelectedIndex = 0;
        }
    }
}
