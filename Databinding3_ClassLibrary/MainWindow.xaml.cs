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
using System.ComponentModel;

namespace Databinding3_ClassLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public static double SliderMinValue { get; set; } = Const.MinLabelFontSizeValue;
        public double SliderMaxValue { get; set; } = Const.MaxLabelFontSizeValue;

        public MainWindow()
        {
            InitializeComponent();
            SetStartValuesForTwoWayDatabindingComponents();
            DataContext = this;
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

        private void btnChangeSliderMaxValuePositive_Click(object sender, RoutedEventArgs e)
        {
            SliderMaxValue += Const.SliderChangeValue;
            Const.CurrentMaxLabelFontSizeValue = SliderMaxValue;
            sldBind1.Value = sldBind1.Value + 1;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SliderMaxValue)));
        }

        private void btnChangeSliderMaxValueNegative_Click(object sender, RoutedEventArgs e)
        {
            if (SliderMaxValue > Const.SliderChangeValue)
            {
                SliderMaxValue -= Const.SliderChangeValue;
            }
        
            Const.CurrentMaxLabelFontSizeValue = SliderMaxValue;
            sldBind1.Value = sldBind1.Value + 1;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SliderMaxValue)));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}