using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Manage.DAL;
using Manage.Model;

namespace Manage
{
    /// <summary>
    /// StudentAdd.xaml 的交互逻辑
    /// </summary>
    public partial class StudentAdd : Window
    {
        public StudentAdd()
        {
            WindowStartupLocation = WindowStartupLocation.CenterOwner;//在父窗口中居中
            InitializeComponent();
        }
        //取消新增
        private void Addout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //新增学生信息
        private void AddNewStu_Click(object sender, RoutedEventArgs e)
        {
            //学生写姓名
            string Name = StuName.Text;
            //学生性别
            if (Name != "")
            {
                Blog student = new Blog();
                student.Url = Name;
                StuDal.InsertStu(student);
                Close();//关闭当前窗口
            }
            else
            {
                MessageBoxResult dr = MessageBox.Show("数据填写不完整", "提示", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }
    }
}

