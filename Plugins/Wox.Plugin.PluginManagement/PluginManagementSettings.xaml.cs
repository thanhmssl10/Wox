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

namespace Wox.Plugin.PluginManagement
{
    /// <summary>
    /// Interaction logic for PluginManagementSettings.xaml
    /// </summary>
    public partial class PluginManagementSettings : UserControl
    {
        public PluginManagementSettings()
        {
            InitializeComponent();

            HighlightResultsEnabled.IsChecked = Main._settings.EnableHighlightData;
        }

        private void HighlightResults_Click(object sender, RoutedEventArgs e)
        {
            Main._settings.EnableHighlightData = HighlightResultsEnabled.IsChecked ?? false;
        }
    }
}
