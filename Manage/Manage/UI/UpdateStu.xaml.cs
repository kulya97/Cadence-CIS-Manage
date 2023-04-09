
using System;
using System.Windows;
using Manage.DAL;
using Manage.Model;

namespace Manage.UI
{
    /// <summary>
    /// UpdateStu.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateStu : Window
    {
        public static int ids;

        public UpdateStu(int id)
        {
            ids = id;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;//在父窗口中居中
            //InitializeComponent();
            Blog student = StuDal.SetIdStudent(ids);
            if (student != null)
            {
               // StuName.Text = student.Url;
            }
        }

        //修改数据
        private void UpdateNewStu_Click(object sender, RoutedEventArgs e)
        {
            //学生写姓名
           // string Name = StuName.Text;
            if (Name != "")
            {
                Blog student = new Blog();
                student.Id = ids;
                student.Url = Name;

                StuDal.UpdateStu(student);
                Close();//关闭当前窗口
            }
            else
            {
                MessageBoxResult dr = MessageBox.Show("数据填写不完整", "提示", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }
        //取消修改
        private void Updateout_Click(object sender, RoutedEventArgs e)
        {
            Close();//关闭页面
        }
    }
}

