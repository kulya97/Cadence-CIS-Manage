
using System;
using System.Windows;
using Manage.Models;
using Manage.ViewModels;
using System.Linq;
using System.Diagnostics;
namespace Manage.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = MainWinowViewModel.Instance;
            Console.Write("dadasfnafdsaifnsdighiasgsfdgasdfsdfds");

            //using (var context = new AppDbContext())
            //{
                
            //    var products = context.res_db.ToList();
            //    foreach (var product in products)
            //    {
            //        Debug.WriteLine($"Id: {product.Part_Number}, Name: {product.PCB_Footprint}, Price: {product.Part_Type}");
            //    }
            //}

        }

    }


}
