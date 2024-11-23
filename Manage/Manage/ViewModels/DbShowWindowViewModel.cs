using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Manage.Models;
using Manage.Models.Table;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Manage.ViewModels
{
    public class TreeNode
    {
        public string Name { get; set; }
        public ObservableCollection<TreeNode> Children { get; set; }

        public TreeNode(string name)
        {
            Name = name;
            Children = new ObservableCollection<TreeNode>();
        }
    }

    internal class DbShowWindowViewModel
    {
        public ObservableCollection<RES> People { get; set; }
        public ObservableCollection<TreeNode> Roots { get; set; }

        public DbShowWindowViewModel()
        {
            Roots = new ObservableCollection<TreeNode>
        {
            new TreeNode("Root 1")
            {
                Children = new ObservableCollection<TreeNode>
                {
                    new TreeNode("Child 1.1"),
                    new TreeNode("Child 1.2")
                }
            },
            new TreeNode("Root 2")
            {
                Children = new ObservableCollection<TreeNode>
                {
                    new TreeNode("Child 2.1"),
                    new TreeNode("Child 2.2")
                }
            }
        };
            // 从数据库获取数据
            using (var context = new AppDbContext())
            {
                var products = context.res_db.ToList();
                var resList = products.ToList();

                People = new ObservableCollection<RES>(resList);
            }
        }
    }
    //继承ObservableObject类可以在数据改变的时候进行通知


}
