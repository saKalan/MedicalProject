using AppCore.Dto;

namespace AppCore.DataAccess
{
    public interface IDoctorRepository
    {
        Task Register(DoctorRegisterDto dto, CancellationToken cancellationToken);
       
        Task<DoctorOutputDto>? GetDoctorBy(string userName, string password, CancellationToken cancellationToken);
        Task<DoctorEditProfileDto>? GetDoctorBy(int id, CancellationToken cancellationToken)

        Task Edit(DoctorEditProfileDto dto, CancellationToken cancellationToken);
    }
}