using Microsoft.AspNetCore.Mvc;
using NetCore_Class1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Class1.Controllers
{
    public class HomeDIController : Controller
    {
        //Create a reference variable of IStudentRepository
        private readonly IStudentRepository _repository = null;
        //Initialize the variable through constructor
        public HomeDIController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public JsonResult Index()
        {
            List<Student> allStudentDetails = _repository.GetAllStudent();
            return Json(allStudentDetails);
        }
        public JsonResult GetStudentDetails(int Id)
        {
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
