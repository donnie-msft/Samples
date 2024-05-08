// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Windows;

namespace ItemsControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MyViewModel vm = new MyViewModel();
            vm.Name = "Items Heading";
            vm.Group = new List<MyModel>
            {
                new MyModel { Name = "Item 1", AutomationName = "Group 1 Item 1" },
                new MyModel { Name = "Item 2", AutomationName = "Group 1 Item 2" },
                new MyModel { Name = "Item 3", AutomationName = "Group 1 Item 3" },
                new MyModel { Name = "Item 4", AutomationName = "Group 2 Item 1" },
                new MyModel { Name = "Item 5", AutomationName = "Group 2 Item 2" },
                new MyModel { Name = "Item 6", AutomationName = "Group 2 Item 3" },
            };
            DataContext = vm;

            InitializeComponent();
        }
    }
}
