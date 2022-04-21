using System.Collections.Generic;
using JCS2.CoreWebApi.Dtos;

namespace JCS2.CoreWebApi.Services.Interfaces
{
    public interface IUsersService
    {
        UserDto GetUser(int id);

        List<UserBasicDto> GetAllUsers(int? maxCount);

        void CreateUser(CreateUserDto dto);
    }
}
