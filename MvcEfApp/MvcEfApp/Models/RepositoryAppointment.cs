namespace MvcEfApp.Models
{
    public class RepositoryAppointment
    {
        public static List<Appointment> GetAppoinments()
        {
            HospitalDbContext context = new HospitalDbContext();
            var list = context.Appointments.ToList();
            return list;
        }
        public static Appointment GetAppointmentById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var appointment = ctx.Appointments.Find(id);
            return appointment;
        }
        public static void AddNewAppointment(Appointment appointment)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Appointments.Add(appointment);
            ctx.SaveChanges();
        }
        public static void ModifyAppointment(Appointment appointment)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveAppointment(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Appointment appointment = ctx.Appointments.Find(id);
            ctx.Appointments.Remove(appointment);
            ctx.SaveChanges();
        }
    }
}
