using System;
using System.Windows;
using BindingTest.Model;

namespace BindingTest.App
{
    public partial class MainWindow : Window
    {
        public Person Person { set; get; }
        public MainWindow()
        {
            Person = new Person();
            
            InitializeComponent();
        }
    }
}