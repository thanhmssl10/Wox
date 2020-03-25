using System.Collections.Generic;
using System.Windows.Controls;

namespace Wox.Plugin.Sys
{
    public partial class SysSettings : UserControl
    {
        public SysSettings(List<Result> Results)
        {
            InitializeComponent();

            HighlightResultsEnabled.IsChecked = Main._settings.EnableHighlightData;

            foreach (var Result in Results)
            {
                lbxCommands.Items.Add(Result);
            }
        }

        private void HighlightResults_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Main._settings.EnableHighlightData = HighlightResultsEnabled.IsChecked ?? false;
        }
    }
}
