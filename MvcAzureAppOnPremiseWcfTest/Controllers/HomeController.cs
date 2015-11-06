using MvcAzureAppOnPremiseWcfTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAzureAppOnPremiseWcfTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetStudentById()
        {
            Student stu = new Student();
            try
            {
                StudentService.StudentServiceClient client = new StudentService.StudentServiceClient();
                
                StudentService.StudentContract contract = client.GetStudentById(1);
                stu.StudentId = contract.StudentId;
                stu.StudentName = contract.StudentName;
                return View(stu);
            }
            catch (Exception ex)
            {
                stu.StudentId = 0;
                stu.StudentName = "Student name not found... "+ex.Message;
                return View();
            }
            

            
        }
    }
}