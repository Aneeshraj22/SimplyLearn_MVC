using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BalLib;
using HelpLib;
using SimplyLearnPH3_2.Models;

namespace SimplyLearnPH3_2.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        Classmethod cs = null;
        public ClassController()
        {
            cs = new Classmethod();
        }
        public List<Classmodel> list1()
        {
            List<Classmodel> c1 = new List<Classmodel>();
            List<Classdata> ds = cs.classdatas();
            foreach (var item in ds)
            {
                Classmodel c = new Classmodel();
                c.Classid = item.Classid;
                c.Studentid = item.Studentid;
                c.subjectid= item.subjectid;
                c1.Add(c);
            }
            return c1;
        }
        public ActionResult Index()
        {
            List<Classmodel> s1 = list1();
            return View(s1);
        }
        public ActionResult AddClass()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClass(FormCollection c)
        {
            try
            {
                Classdata c1 = new Classdata();
                c1.Classid = Convert.ToInt32(Request["classId"]);
                c1.Studentid = Convert.ToInt32(Request["Studentid"]);
                c1.subjectid = Convert.ToInt32(Request["subjectid"]);
                cs.AddClass(c1);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }

        }
        public ActionResult EditDetails(int id)
        {
            List<Classmodel> m = list1();
            Classmodel m2 = m.Find(m3 => m3.Classid == id);
            return View(m2);
        }
        [HttpPost]
        public ActionResult EditDetails(int id, FormCollection m3)
        {
            try
            {
                Classdata c2 = new Classdata();
                c2.Classid = Convert.ToInt32(Request["classId"]);
                c2.Studentid = Convert.ToInt32(Request["Studentid"]);
                c2.subjectid = Convert.ToInt32(Request["subjectid"]);
                cs.updateClass(c2);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            List<Classmodel> m = list1();
            Classmodel m2 = m.Find(m3 => m3.Classid == id);
            return View(m2);

        }
        public ActionResult Delete(int id)
        {
            try
            {
                cs.RemoveClass(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }

        }
    }
}