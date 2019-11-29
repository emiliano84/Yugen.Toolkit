﻿using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Yugen.Toolkit.Uwp.Controls.Validation
{
    public sealed class ValidatingButton : Button
    {
        #region DependencyProperties

        public bool IsEnterEnabled
        {
            get { return (bool)GetValue(IsEnterEnabledProperty); }
            set { SetValue(IsEnterEnabledProperty, value); }
        }

        public static readonly DependencyProperty IsEnterEnabledProperty = DependencyProperty.Register(
            nameof(IsEnterEnabled),
            typeof(bool),
            typeof(ValidatingComboBox),
            new PropertyMetadata(false));

        #endregion

        public new event TappedEventHandler Tapped;
        public ValidatingForm ValidatingFormControl { get; set; }

        public ValidatingButton()
        {
            this.Loaded += ValidatingButtonControl_Loaded;
            base.Tapped += ValidatingButtonControl_Tapped;
        }

        private void ValidatingButtonControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (!IsEnterEnabled) return;
            var keyboardAccelerator = new KeyboardAccelerator { Key = VirtualKey.Enter };
            keyboardAccelerator.Invoked += KeyboardAccelerator_Invoked;
            this.KeyboardAccelerators.Add(keyboardAccelerator);
        }

        private void KeyboardAccelerator_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            if (ValidatingFormControl.FormIsValid())
                Tapped?.Invoke(args.Element, null);
        }

        private void ValidatingButtonControl_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (ValidatingFormControl.FormIsValid())
                Tapped?.Invoke(sender, e);
        }
    }
}