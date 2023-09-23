using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        //template--list
        public ActionResult Index()
        {
            List<Emp> emplist = EmpDbRespository.GetEmpList();
            return View(emplist);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp = EmpDbRespository.GetEmpById(id);
            return View(emp);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            Emp emp = new Emp();
            return View(emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Emp pEmp)
        {//if there are validations it will be checked in "ModelState.IsValid" only if true it gets added
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRespository.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp = EmpDbRespository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Emp pEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRespository.UpdateEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Emp emp = EmpDbRespository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRespository.DeleteEmp(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
