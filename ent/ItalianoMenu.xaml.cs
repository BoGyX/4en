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

namespace ent
{
    public partial class ItalianoMenu : Page
    {
        private EL_PATIOEntities el = new EL_PATIOEntities();

        public ItalianoMenu()
        {
            InitializeComponent();
            ColourDataGrid.ItemsSource = el.ITALIAN_MENU_PATIO.ToList();
            Menu.ItemsSource = el.ITALIAN_MENU_PATIO.ToList();
            Menu.DisplayMemberPath = "ITALIAN_FOOD_PATIO_PRICE";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ColourDataGrid.ItemsSource = el.ITALIAN_MENU_PATIO.ToList().Where(item => item.ITALIAN_FOOD_PATIO_PRICE.Contains(SearchTxt.Text));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Menu.SelectedItem = null;
            SearchTxt.Text = string.Empty;
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Menu.SelectedItem != null)
            {
                var selected = Menu.SelectedItem as ITALIAN_MENU_PATIO;
                ColourDataGrid.ItemsSource = el.ITALIAN_MENU_PATIO.ToList().Where(item => item.ITALIAN_FOOD_PATIO_PRICE == selected.ITALIAN_FOOD_PATIO_PRICE);
            }
        }


    }
}
