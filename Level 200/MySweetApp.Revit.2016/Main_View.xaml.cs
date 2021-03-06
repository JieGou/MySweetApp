﻿using Autodesk.Revit.DB;
using MySweetApp.Revit.ViewModels;
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

namespace MySweetApp.Revit
{
    /// <summary>
    /// Interaction logic for Main_View.xaml
    /// </summary>
    public partial class Main_View : UserControl
    {
        public Main_View(Document document)
        {
            InitializeComponent();

            var dc = new Main_ViewModel(document);
            DataContext = dc;
        }
    }
}
