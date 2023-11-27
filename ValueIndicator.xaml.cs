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

namespace WpfApp3
{
    public partial class ValueIndicator: UserControl
    {
        public MyValues? Values
        {
            get => GetValue(ValuesProperty) as MyValues;
            set => SetValue(ValuesProperty, value);
        }
        public static readonly DependencyProperty ValuesProperty =
              DependencyProperty.Register(
                  nameof(Values),
                  typeof(MyValues),
                  typeof(ValueIndicator),
                  new PropertyMetadata(new MyValues())
                  );

        public string? DisplayName
        {
            get => GetValue(DisplayNameProperty) as string;
            set => SetValue(DisplayNameProperty, value);
        }
        public static readonly DependencyProperty DisplayNameProperty =
              DependencyProperty.Register(
                  nameof(DisplayName),
                  typeof(string),
                  typeof(ValueIndicator),
                  new PropertyMetadata("X")
                  );
        
        public bool IsGuidelineVisible
        {
            get => GetValue(IsGuidelineVisibleProperty) as bool? ?? false;
            set => SetValue(IsGuidelineVisibleProperty, value);
        }
        public static readonly DependencyProperty IsGuidelineVisibleProperty =
              DependencyProperty.Register(
                  nameof(IsGuidelineVisible),
                  typeof(bool),
                  typeof(ValueIndicator),
                  new PropertyMetadata(false)
                  );

        public ValueIndicator()
        {
            InitializeComponent();
            Values = new();
        }
    }
}
