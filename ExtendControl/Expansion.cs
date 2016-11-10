using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace ExtendControl
{
    [ContentProperty(Name = "Content")]
    public sealed class Expansion : Control
    {
        public Expansion()
        {
            this.DefaultStyleKey = typeof(Expansion);
        }



        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(Expansion), new PropertyMetadata(null));




        public object Header
        {
            get { return (object)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Header.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(Expansion), new PropertyMetadata(null));



        public bool IsExpand
        {
            get { return (bool)GetValue(IsExpandProperty); }
            set { SetValue(IsExpandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsExpand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsExpandProperty =
            DependencyProperty.Register("IsExpand", typeof(bool), typeof(Expansion), new PropertyMetadata(true));

        private ToggleButton button;
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            button = GetTemplateChild("toggleButton") as ToggleButton;
            button.Loaded += (s, e) => { ChangeControlState(false); };
            button.Checked += (s, e) => { ChangeControlState(); };
            button.Unchecked += (s, e) => { ChangeControlState(); };

        }

        /// <summary>
        /// 改变控件的 VisualState
        /// </summary>
        /// <param name="useTransition">是否使用 VisualTransition，默认使用</param>
        private void ChangeControlState(bool useTransition = true)
        {
            if (button.IsChecked.Value)
            {
                button.Content =  "";
            }
            else
            {
                button.Content = "";
            }
        }



    }
}
