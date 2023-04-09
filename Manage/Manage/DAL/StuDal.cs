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
        public StuDal()
        {
            // BlogContext = new BlogContext();

        }

        //查询所有学生数据
        public static List<Resistance> GetStudent()
        {
            return BlogContext.Resistance.ToList();
        }
        //添加新的学生信息
        public static void InsertStu(Resistance students)
        {
            BlogContext.Resistance.Add(students);
            BlogContext.SaveChanges();
        }
        //修改学生信息
        public static void UpdateStu(Resistance students)
        {
            var id = BlogContext.Resistance.Find(students.Schematic_Part);
            var entry = BlogContext.Entry(id);
            entry.CurrentValues.SetValues(students);
            // entry.Property(p => p.Schematic_Part.IsModified = false;
            BlogContext.SaveChanges();
        }
        //删除学生信息
        public static void DeleteStu(int ids)
        {
            // Resistance student = BlogContext.Resistance.FirstOrDefault(p => p.Schematic_Part = "xxxx");
            // BlogContext.Resistance.Remove(student);
            BlogContext.SaveChanges();
        }
        //学生信息关键字查询
        public static List<Resistance> SetKeyStudent(string StuName)
        {
            // return BlogContext.Blog.Where(p => p.Blog.Contains(StuName)).ToList();
            return null;
        }
        //学生信息ID查询
        public static Resistance SetIdStudent(int ids)
        {
            return null;
            // return BlogContext.Resistance.FirstOrDefault(p => p.Id == ids);
        }
    }



}
