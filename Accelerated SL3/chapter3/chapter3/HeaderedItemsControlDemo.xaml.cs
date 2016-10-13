﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace chapter3
{
    public partial class HeaderedItemsControlDemo : UserControl
    {
        public HeaderedItemsControlDemo()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(HeaderedItemsControlDemo_Loaded);
        }

        void HeaderedItemsControlDemo_Loaded(object sender, RoutedEventArgs e)
        {
            string[] colors = { "Red", "Green", "Blue", "Cyan" };
            headeredItems.ItemsSource = colors;
        }
    }
}
