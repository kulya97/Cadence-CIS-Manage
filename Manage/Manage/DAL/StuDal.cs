using Manage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage.DAL
{
    public class StuDal
    {
        public static BlogContext BlogContext = new BlogContext();
        //查询所有学生数据
        public static List<Blog> GetStudent()
        {
            return BlogContext.Blog.ToList();
        }
        //添加新的学生信息
        public static void InsertStu(Blog students)
        {
            BlogContext.Blog.Add(students);
            BlogContext.SaveChanges();
        }
        //修改学生信息
        public static void UpdateStu(Blog students)
        {
            var id = BlogContext.Blog.Find(students.Id);
            var entry = BlogContext.Entry(id);
            entry.CurrentValues.SetValues(students);
            entry.Property(p => p.Id).IsModified = false;
            BlogContext.SaveChanges();
        }
        //删除学生信息
        public static void DeleteStu(int ids)
        {
            Blog student = BlogContext.Blog.FirstOrDefault(p => p.Id == ids);
            BlogContext.Blog.Remove(student);
            BlogContext.SaveChanges();
        }
        //学生信息关键字查询
        public static List<Blog> SetKeyStudent(string StuName)
        {
            // return BlogContext.Blog.Where(p => p.Blog.Contains(StuName)).ToList();
            return null;
        }
        //学生信息ID查询
        public static Blog SetIdStudent(int ids)
        {
            return BlogContext.Blog.FirstOrDefault(p => p.Id == ids);
        }
    }



}
