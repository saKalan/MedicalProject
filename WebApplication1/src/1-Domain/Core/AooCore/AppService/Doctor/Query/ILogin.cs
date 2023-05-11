using AppCore.Dto;

namespace AppCore.AppService.Doctor.Query
{
    public interface ILogin
    {
        Task <bool> Execute(DoctorLoginDto dto , CancellationToken cancellationToken);
    }



}
