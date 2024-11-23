using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Manage.ViewModels
{
    //继承ObservableObject类可以在数据改变的时候进行通知
    internal class MainWinowViewModel : ObservableObject
    {

        MainWinowViewModel()
        {

        }


        public static MainWinowViewModel Instance { get; } = new MainWinowViewModel();

        //窗口的标题
        string _title = "批量录入报告";
        //定义标题属性
        public string Title => _title;
        //根目录
        DirectoryNodeViewModel _root;
        //集合类的基础接口，它定义了一个用于遍历集合的枚举器，一般在foreach循环中要访问的集合和数组都实现了IEnumerable这个接口
        public IEnumerable<DirectoryNodeViewModel> Roots => new DirectoryNodeViewModel[] { _root };

        #region commands
        //定义一个文件夹路径属性并给它赋值
        string _folderPath = null;
        //选择文件的命令
        RelayCommand _selectFolderCommand;
        public RelayCommand SelectFolderCommand => _selectFolderCommand ?? new RelayCommand(() =>
        {
            //实例化一个用于选择文件夹的类
            var dialog = new FolderBrowserDialog();
            //如果选择了文件夹 DialogResult.OK就等于TRUE 则进行到下一步
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //把选择文件夹的路径赋值给定义好的文件夹路径
                _folderPath = dialog.SelectedPath;
                //根目录等于实例化一个ViewModel,所有的操作都在ViewModel里别人是看不见的。传入一个文件目录信息（文件夹路径）{以及根目录的IconSource绑定的图片}
                _root = new DirectoryNodeViewModel(new DirectoryInfo(_folderPath)) { IconSource = "/Images/folder.png" };
                //触发事件通知UI层
                OnPropertyChanged(nameof(Roots));
            }
        });

        #endregion commands

    }

}
