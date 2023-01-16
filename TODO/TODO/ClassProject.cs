using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    public class ClassProject
    {
        public enum Weeks
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        
        public ClassProject(Weeks weeks_, String content_)
        {
            week = weeks_;
            contents.Add(content_);
        }
        public ClassProject(Weeks week_, List<String>contents_)
        {
            week= week_;
            contents = contents_;
        }

        public ClassProject.Weeks week;
        public List<String> contents = new List<String>();
    }

    public class ProjectGlobal
    {
        public static List<ClassProject> ToDoList = new List<ClassProject>();

        public static bool SaveFlag = false;
    }
}
