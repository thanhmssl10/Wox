using System.Windows;
using System.Windows.Controls;

namespace Wox.Plugin.ControlPanel
{
    /// <summary>
    /// Interaction logic for ControlPanelSettings.xaml
    /// </summary>
    public partial class ControlPanelSettings : UserControl
    {
        public ControlPanelSettings()
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
