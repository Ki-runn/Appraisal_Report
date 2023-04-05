using Employee.Data;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;


using System.Linq;
using Employee.Views.Home;


namespace Employee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        EmployeeContext _employeeContext;
        private static int _empid;
        private static string _empdesign;
        private static string _empname;


        public HomeController(ILogger<HomeController> logger, EmployeeContext employeeContext )
        {
            _logger = logger;
            _employeeContext = employeeContext;
             

        }

        

       

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Register register)
        {            
            var test = _employeeContext.EmpTable.SingleOrDefault(x => x.Email == register.Email && x.Pass == register.Password );
           




            if (test != null)
            {
                ViewData["Designation"] = test.Designation;
                ViewData["email"] = test.Email;
                ViewData["pno"] = test.Phone;
                ViewData["password"] = test.Pass;
                ViewData["MID"] = test.MID;
                ViewData["Name"] = test.Name;
                ViewData["ID"] = test.EmpId;
                _empid = test.EmpId;
                _empdesign = test.Designation;
                _empname = test.Name;
                var data = _employeeContext.AppraisalModel.FirstOrDefault(x => x.EmpId == _empid);
                if (data != null)
                {
                    TempData["mcomment"] = data.M_Comment1;
                     
                }
                return View("Welcome_Emp");

            }
 
            else
            {
                ViewBag.ErrorMessage = "invalid username or password";
                return View();
            }


        }

       public IActionResult AddEmp1()
        {
            return View();
        }
        [HttpPost]

       public IActionResult AddEmp1(Emp emp)
        {
            ViewData["AddedEmpDesignation"] = emp.Designation;
            ViewData["AddedEmpName"] = emp.Name;

            if(ModelState.IsValid)
            {
                Emp e = new Emp()
                {
                    EmpId =emp.EmpId,

                    Name = emp.Name,
                    
                    Designation = emp.Designation,

                    Email=emp.Email,

                    Pass=emp.Pass,

                    Phone=emp.Phone,

                    MID=emp.MID


                };

                _employeeContext.EmpTable.Add(e);
                _employeeContext.SaveChanges();
                return View("addedemp");


            }

            return View();
        

            
        }

        public IActionResult AppraisalCreate()
        {
            
            ViewData["Designation"] = _empdesign;
            ViewData["Design"] = _empdesign;
            List<Emp> empIds = _employeeContext.EmpTable.Where(m => m.MID == _empid).ToList();
            ViewBag.data = empIds;
            ViewBag.empid = _empid;
            var data = _employeeContext.AppraisalModel.FirstOrDefault(x => x.EmpId == _empid);
            if (data != null) 
            {
                ViewBag.obj = data.Obj1;
                ViewBag.tcomp = data.TechCompetency;
                ViewBag.bcomp = data.BehaviouralCompetency;
               
            }

            return View();
        }
        [HttpPost]
        public IActionResult AppraisalCreate(AppraisalModel model)
        {
            ViewData["Designation"] = _empdesign;
            var data = _employeeContext.AppraisalModel.FirstOrDefault(x => x.EmpId == model.EmpId);
            var status = _employeeContext.Status.FirstOrDefault(s => s.EID == model.EmpId);
           
            if(data == null)
            {
                ViewData["Designation"] = _empdesign;
                var k = model.EmpId;
            
                if (k!=0)
                {
                 
                    if (!_employeeContext.Status.Any(x => x.EID == k))
                    {
                        AppraisalStatus A = new AppraisalStatus()
                        {
                            Status = "New",
                            EID = k,
                            MID = _empid
                            
                        };
                        _employeeContext.Status.Add(A);
                        _employeeContext.SaveChanges();


                        _employeeContext.AppraisalModel.Add(model);
                        _employeeContext.SaveChanges();

                        ViewBag.success = "Created Successfully";
 


                        return View("Welcome_Emp", ViewBag.success);
                    }
                    else
                        return Content("Already Exist!");



                }
                return Content("Failed");
            }
            else 
            {
                if (ViewData["Designation"].Equals("Employee"))
                {
                    data.E_Comment1 = model.E_Comment1;
                }
                if (ViewData["Designation"].Equals("Manager"))
                {
                    data.M_Comment1 = model.M_Comment1;
                    data.Rating1 = model.Rating1;
                    
                }
                
                _employeeContext.SaveChanges();
                if (model.M_Comment1 != null)
                {
                    status.Status = "Completed";
                    _employeeContext.SaveChanges();

                }
                else
                {
                    status.Status = "Created";
                    _employeeContext.SaveChanges();

                }
                ViewBag.success = "Update Successfully";
                return View("Welcome_Emp", ViewBag.success);
            }



            
          
        }



       
        

        public IActionResult ViewAppraisal()
        {
            ViewBag.name = _empname;
            var v = _employeeContext.AppraisalModel.Where(m=>m.EmpId == _empid).ToList();
            ViewBag.data = v;
            return View();
        }

        public IActionResult ViewPreviousApp()
        {
            List<AppraisalModel> appraisal = _employeeContext.AppraisalModel.Where(p=>p.EmpId==_empid).ToList();
         
            return View(appraisal);
        }

       /* public ActionResult GetEmpInfo(int empid)
        {
            var data = _employeeContext.AppraisalModel.FirstOrDefault(x => x.EmpId == empid);
            return Json(data, JsonRequestBehavior.AllowGet);
        }*/

        public IActionResult Logout()
        {
            return RedirectToAction("Register");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
