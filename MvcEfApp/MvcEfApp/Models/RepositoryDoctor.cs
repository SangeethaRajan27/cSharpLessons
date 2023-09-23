namespace MvcEfApp.Models
{
    //First we created Database HospitalDb, then we added tables to it all done by code 
    public class RepositoryDoctor
    {
        public static List<Doctor> GetDoctors()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Doctors.ToList();
            return list;
        }
        public static Doctor GetDoctorById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var doctor = ctx.Doctors.Find(id);
            return doctor;
        }
        public static void AddNewDoctor(Doctor doctor)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Doctors.Add(doctor);
            ctx.SaveChanges();
        }
        public static void ModifyDoctor(Doctor doctor)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(doctor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveDoctor(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Doctor doctor = ctx.Doctors.Find(id);
            ctx.Doctors.Remove(doctor);
            ctx.SaveChanges();
        }
    }
}
