using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcEfApp.Models;
using System.Numerics;

namespace MvcEfApp.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientController
        public ActionResult Index()
        {
            List<Patient> patients = RepositoryPatient.GetPatients();
            if (patients != null && patients.Count > 0)
            {
                return View(patients);
            }
            else
                return RedirectToAction("Create");
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Patient ppatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.AddNewPatient(ppatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception err)
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Patient ppatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.ModifyPatient(ppatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.RemovePatient(id);
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
