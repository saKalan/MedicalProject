using AppCore.Dto;

namespace AppCore.AppService.Doctor.Command
{
    public interface IRegister
    {
        void Execute(DoctorRegisterDto dto , CancellationToken cancellationToken);
    }



}
