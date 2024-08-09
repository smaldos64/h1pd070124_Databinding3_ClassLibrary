using System.Media;
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

using ToolsLibrary;
using Databinding3_ClassLibrary.Constants;

namespace Databinding3_ClassLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double SliderMinValue { get; } = Const.MinLabelFontSizeValue;
        public static double SliderMaxValue { get; } = Const.MaxLabelFontSizeValue;

        public MainWindow()
        {
            InitializeComponent();
            SetStartValuesForTwoWayDatabindingComponents();
        }

        private void SetStartValuesForTwoWayDatabindingComponents()
        {
            sldBind1.Value = 30;
        }

        private void txtCheckForValidKeyPressedPositiveInteger(object sender, KeyEventArgs e)
        {
            if (!KeyHelper.IsKeyPressedValidPositiveInteger(e.Key))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }
    }
}