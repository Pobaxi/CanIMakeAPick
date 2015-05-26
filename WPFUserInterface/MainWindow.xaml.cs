using System;
using System.Collections.Generic;
using System.Linq;
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
using BusinessLogic;

namespace WPFUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ChampionCollection _championCollection;
        public MainWindow()
        {
            InitializeComponent();
            _championCollection = new ChampionCollection();
            ChampSelectComboBox.ItemsSource = _championCollection.Champions;
            ChampSelectComboBox.SelectedIndex = 0;
        }

        private void ChampSelectComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 1)
            {
                if (e.AddedItems[0] is IChampion)
                {
                    // TODO!
                }
            }
        }
    }
}
