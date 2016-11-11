using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ExtendControl.MyUserControl
{
    public sealed partial class ExtensionUserControl : UserControl
    {
        public ExtensionUserControl()
        {
            this.InitializeComponent();
        }



        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Header.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(ExtensionUserControl), new PropertyMetadata(null));




        public object ContentPosition
        {
            get { return (object)GetValue(ContentPositionProperty); }
            set { SetValue(ContentPositionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentPosition.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentPositionProperty =
            DependencyProperty.Register("ContentPosition", typeof(object), typeof(ExtensionUserControl), new PropertyMetadata(null));

        public bool IsExpand
        {
            get { return (bool)GetValue(IsExpandProperty); }
            set { SetValue(IsExpandProperty, value); }
        }

        public static readonly DependencyProperty IsExpandProperty = 
            DependencyProperty.Register("IsExpand", typeof(bool), typeof(ExtensionUserControl), new PropertyMetadata(true));

        private void ShowAndHide_Click(object sender, RoutedEventArgs e)
        {
            IsExpand = !IsExpand;
            if (IsExpand)
            {
                //using change content
                ShowAndHide.Content = "";
                //RotateBack.Begin();//using animation
            }
            else
            {
                //using change content
                ShowAndHide.Content = "";
                //Rotate.Begin();//using animation
            }
        }
    }
}
