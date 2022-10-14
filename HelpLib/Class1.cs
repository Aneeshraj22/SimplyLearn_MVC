using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalLib;
using BalLib;

namespace HelpLib
{
    public class Classmethod
    {
        public void AddClass(Classdata s)
        {
            SchoolEntities context = new SchoolEntities();
            Class s1 = new Class();
            s1.Clsid = s.Classid;
            s1.StudId = s.Studentid;
            s1.Subid = s.subjectid;
            context.Classes.Add(s1);
            context.SaveChanges();


        }
        public bool RemoveClass(int id)
        {
            SchoolEntities context = new SchoolEntities();
            List<Class> m1 = context.Classes.ToList();
            Class s2 = m1.Find(m => m.Clsid == id);
            if (s2 != null)
            {
                context.Classes.Remove(s2);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void updateClass(Classdata s)
        {
            SchoolEntities context = new SchoolEntities();
            List<Class> m1 = context.Classes.ToList();
            Class s2 = m1.Find(m => m.Clsid == s.Classid);
            s2.Clsid = s.Classid;
            s2.StudId= s.Studentid;
            s2.Subid = s.subjectid;
            context.SaveChanges();
        }
        public List<Classdata> classdatas()
        {
            SchoolEntities context = new SchoolEntities();
            List<Classdata> s = new List<Classdata>();
            List<Class> m1 = context.Classes.ToList();
            foreach (var item in m1)
            {
                s.Add(new Classdata
                {
                   Classid= item.Clsid,
                   Studentid= (int)item.StudId,
                   subjectid= (int)item.Subid
                });
            }
            return s;
        }

    }
    public class Studentmethod
    {
        public void AddStudent(Studentdata s)
        {
            SchoolEntities context = new SchoolEntities();
            Student s1 = new Student();
            s1.StudId = s.Studentid;
            s1.StudName = s.Studentname;
            s1.Age = s.Studentage;
            context.Students.Add(s1);
            context.SaveChanges();

        }
        public void RemoveStudent(int id)
        {
            SchoolEntities context = new SchoolEntities();
            List<Student> s = context.Students.ToList();
            Student s1 = s.Find(m => m.StudId == id);
            context.Students.Remove(s1);
            context.SaveChanges();
        }
        public void updateStudent(Studentdata s2)
        {
            SchoolEntities context = new SchoolEntities();
            List<Student> s = context.Students.ToList();
            Student s1 = s.Find(m => m.StudId == s2.Studentid);
            s1.StudId = s2.Studentid;
            s1.StudName = s2.Studentname;
            s1.Age = s2.Studentage;
            context.SaveChanges();
        }
        public List<Studentdata> studentdatas()
        {
            SchoolEntities context = new SchoolEntities();
            List<Studentdata> s = new List<Studentdata>();
            List<Student> s1 = context.Students.ToList();
            foreach (var item in s1)
            {
                s.Add(
                    new Studentdata
                    {
                        Studentid = item.StudId,
                        Studentname = item.StudName,
                        Studentage = (int)item.Age
                    }

                     );
            }      
                
                
                
            
            return s;
        }
    }
    public class SubjectMethods
    {
        public void AddSubject(Subjectdata s)
        {
            SchoolEntities context = new SchoolEntities();
            Subject s1 = new Subject();
            s1.Subid = s.subjectid;
            s1.subname = s.subjectname;
            context.Subjects.Add(s1);
            context.SaveChanges();

        }
        public void RemoveSubject(int id)
        {
            SchoolEntities context = new SchoolEntities();
            List<Subject> s1 = context.Subjects.ToList();
            Subject s2 = s1.Find(m => m.Subid == id);
            context.Subjects.Remove(s2);
            context.SaveChanges();
        }
        public void updatesubject(Subjectdata s)
        {
            SchoolEntities context = new SchoolEntities();
            List<Subject> s1 = context.Subjects.ToList();
            Subject s2 = s1.Find(m => m.Subid == s.subjectid);
            s2.Subid = s.subjectid;
            s2.subname = s.subjectname;
            
            context.SaveChanges();

        }
        public List<Subjectdata> Subjlist()
        {
            List<Subjectdata> s1 = new List<Subjectdata>();
            SchoolEntities context = new SchoolEntities();
            List<Subject> s = context.Subjects.ToList();
            foreach (var item in s)
            {
                s1.Add(
                    new Subjectdata
                    {
                        subjectid=item.Subid,
                        subjectname=item.subname
                    });
            }
            return s1;
        }
    }
}
