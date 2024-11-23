
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;


namespace Manage.ViewModels
{
    //一个枚举类，表示了文件的类型 是目录还是文件
    public enum FileSystemInfoNodeType
    {
        File,
        Directory
    }
    //创建一个ViewModel类作为View和Model的中介，将Model中的数据和方法转换为View中可用的形式，同时继承Observable类方便通知
    public abstract partial class FileSystemInfoNodeViewModel : ObservableObject
    {
        public FileSystemInfoNodeViewModel(FileSystemInfo fsi)
        {
            _wrapper = fsi;
        }
        //定义了一个类型为FileSystemInfo的属性，这个属性是受保护的，它只能在当前类和派生类里面可以使用
        protected FileSystemInfo _wrapper;
        //定义了一个字符串属性（名字）把对象的名字赋值给它
        public string Name => _wrapper.Name;
        //定义一个字符串属性（图标资源）
        private string _IconSource;
        //图标资源的获取与设置
        public string IconSource
        {
            get { return _IconSource; }
            set
            {

                SetProperty(ref _IconSource, value);
            }

        }
        //定义一个抽象的属性，必须在抽象类或者重写一下才行
        public abstract FileSystemInfoNodeType NodeType { get; }
        //定义一个属性表示是否需要扩展
        [ObservableProperty]
        bool _isExpanded = false;
        //定义一个属性表示是否选择了
        [ObservableProperty]
        bool _isSelected = false;

    }

    //定义了一个FileNodeViewModel类继承FileSystemInfoNodeViewModel类，这个类是跟文件有关的，跟文件有关的操作就写在这里面
    public class FileNodeViewModel : FileSystemInfoNodeViewModel
    {
        public FileNodeViewModel(FileInfo fi) : base(fi)
        {

        }
        //因为使用到了抽象类，所以要重写一下 
        public override FileSystemInfoNodeType NodeType => FileSystemInfoNodeType.File;


    }


    //定义了一个DirectoryNodeViewModel类继承FileSystemInfoNodeViewModel类，这个类是跟文件目录有关的，跟文件目录有关的操作就写在这里面
    public class DirectoryNodeViewModel : FileSystemInfoNodeViewModel
    {
        public DirectoryNodeViewModel(DirectoryInfo di) : base(di)
        {

        }
        //因为使用到了抽象类，所以要重写一下 
        public override FileSystemInfoNodeType NodeType => FileSystemInfoNodeType.Directory;


        //集合类的基础接口，它定义了一个用于遍历集合的枚举器，一般在foreach循环中要访问的集合和数组都实现了IEnumerable这个接口
        //这个接口内实现了对文件目录子节点的操作，获取子节点的信息，设置子节点的图片
        public IEnumerable<FileSystemInfoNodeViewModel> Children
        {
            get
            {
                //定义一个变量并将获取到的文件目录信息赋值给这个变量
                var di = _wrapper as DirectoryInfo;
                //使用GetFileSystemInfos()方法返回文件系统信息集合，然后从集合中选择符合的数据，同时将这些数据转换成FileSystemInfoNodeViewModel类型
                return di.GetFileSystemInfos().Select<FileSystemInfo, FileSystemInfoNodeViewModel>(fsi =>
                {
                    //对查询到的数据进行判断，如果查询到的结果是文件信息
                    if (fsi is FileInfo fi)
                    {
                        //就返回一个实例化对象，同时给对象的IconSource属性设置一个值
                        return new FileNodeViewModel(fi) { IconSource = "/Images/file_word.png" };
                    }
                    //如果查询到的结果是文件目录信息
                    else if (fsi is DirectoryInfo dii)
                    {
                        //就返回一个实例化对象，同时给对象的IconSource属性设置一个值
                        return new DirectoryNodeViewModel(dii) { IconSource = "/Images/folder.png" };
                    }
                    //如果查询的是其他的类型
                    else
                    {
                        //就抛出异常（不知道文件系统信息的类型）
                        throw new Exception("Unknown FileSystemInfo type");
                    }
                });
            }
        }
    }

}
