﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SmartInkLaboratory.Views.Helpers
{
    public static class FlyoutHelpers
    {

        public static readonly DependencyProperty ParentProperty =
            DependencyProperty.RegisterAttached("Parent", typeof(Button),
            typeof(FlyoutHelpers), new PropertyMetadata(null, OnParentPropertyChanged));

        public static void SetParent(DependencyObject d, Button value)
        {
            d.SetValue(ParentProperty, value);
        }

        public static Button GetParent(DependencyObject d)
        {
            return (Button)d.GetValue(ParentProperty);
        }

        private static void OnParentPropertyChanged(DependencyObject d,
         DependencyPropertyChangedEventArgs e)
        {
            var flyout = d as Flyout;
            if (flyout != null)
            {
                flyout.Opening += (s, args) =>
                {
                    Debug.WriteLine($"Flyout openning");
                    flyout.SetValue(IsOpenProperty, true);
                };

                flyout.Closed += (s, args) =>
                {
                    Debug.WriteLine($"flyout closed");
                    flyout.SetValue(IsOpenProperty, false);
                };
            }
        }


 


        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.RegisterAttached("IsOpen", typeof(bool),
            typeof(FlyoutHelpers), new PropertyMetadata(false, OnIsOpenChanged));

      

        public static void SetIsOpen(DependencyObject d, bool value)
        {
            Debug.WriteLine($"Setting: {value}");
            d.SetValue(IsOpenProperty, value);
        }

        public static bool GetIsOpen(DependencyObject d)
        {
            Debug.WriteLine($"Getting: ");
            return (bool)d.GetValue(IsOpenProperty);
        }

        private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine($"IsOpenChanged: {e.NewValue}");
            var flyout = d as Flyout;
            var parent = (Button)d.GetValue(ParentProperty);

            if (flyout != null && parent != null)
            {
                Debug.WriteLine($"here");
                var newValue = (bool)e.NewValue;

                if (!newValue)
                {
                    Debug.WriteLine($"hide");
                    flyout.Hide();
                }
            }
        }

    }
}
