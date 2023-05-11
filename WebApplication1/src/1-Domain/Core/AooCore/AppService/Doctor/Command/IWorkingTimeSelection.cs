namespace AppCore.AppService.Doctor.Command
{
    public interface IWorkingTimeSelection
    {
        void WorkingTimeSelect(int DoctorId, DateTime timeFrom, DateTime timeTo);
    }
}
