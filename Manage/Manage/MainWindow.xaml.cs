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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Manage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var context = new BlogContext())
            {

                //User user = new User() { Name = "Herry", CreateTime = DateTime.Now };
                //context.User.Add(user);
                Blog blog = new Blog() { Url = "http://mysite.com" };
                context.Blog.Add(blog);
                //context.Configuration.ValidateOnSaveEnabled = false;
                context.SaveChanges();
                List<Blog> list= context.Blog.ToList();
                for(int i = 0; i < list.Count; i++)
                {
                   String str= list[i].Url;
                    System.Console.WriteLine(str);
                }
            }
        }
    }
}
