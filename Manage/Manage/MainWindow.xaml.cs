using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Manage.DAL;
using Manage.Model;
using Manage.UI;

namespace Manage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Blog> ds;
        public MainWindow()
        {
            InitializeComponent();
            ds = StuDal.GetStudent().ToList();
            StudentShow.ItemsSource = ds;
        }
        //查询数据
        private void SetStudent_Click(object sender, RoutedEventArgs e)
        {
            string key = StuKey.Text;
            //  List<Blog> ds = StuDal.Blog(key).ToList();
            StudentShow.ItemsSource = ds;
        }
        //新增弹窗
        private void AddStu_Click(object sender, RoutedEventArgs e)
        {
            StudentAdd isw = new StudentAdd();
            isw.Title = "添加";
            isw.Owner = this;//设置父窗口，这样可以在父窗口中居中
            isw.ShowDialog();//模式，弹出！
        }
        //删除详情
        private void DeleteDetail_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dr = MessageBox.Show("确定要删除吗 ?，删除后不可恢复", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (dr == MessageBoxResult.OK)
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    int id = Convert.ToInt32(btn.Tag);
                    StuDal.DeleteStu(id);
                }
            }
            List<Blog> ds = StuDal.GetStudent().ToList();
            StudentShow.ItemsSource = ds;
        }
        //刷新页面数据
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            List<Blog> ds = StuDal.GetStudent().ToList();
            StudentShow.ItemsSource = ds;
        }
        //编辑信息
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int id = Convert.ToInt32(btn.Tag);
                UpdateStu isw = new UpdateStu(id);
                isw.Title = "编辑";
                isw.Owner = this;//设置父窗口，这样可以在父窗口中居中
                isw.ShowDialog();//模式，弹出！
            }
        }
    }
}
