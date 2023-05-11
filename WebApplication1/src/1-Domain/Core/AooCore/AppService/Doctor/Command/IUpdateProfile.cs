using AppCore.Dto;
using System.Threading;

namespace AppCore.AppService.Doctor.Command
{
    public interface IUpdateProfile
    {
        Task PostExecute(DoctorEditProfileDto dto, CancellationToken cancellationToken);

        Task<DoctorEditProfileDto> GetExecute(int id, CancellationToken cancellationToken);

        Task PostExecute(DoctorEditProfileDto dto, CancellationToken cancellationToken);


    }



}
