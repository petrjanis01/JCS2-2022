using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using JCS2.CoreWebApi.Dtos;
using JCS2.CoreWebApi.Entities;
using JCS2.CoreWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JCS2.CoreWebApi.Services
{
    public class UsersService : IUsersService
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public UsersService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public UserDto GetUser(int id)
        {
            var user = _context.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.Id == id);

            var dto = _mapper.Map<UserDto>(user);
            return dto;
        }

        public List<UserBasicDto> GetAllUsers(int? maxCount)
        {
            var query = _context.Users
                .AsNoTracking()
                .OrderBy(u => u.Name)
                .ProjectTo<UserBasicDto>(_mapper.ConfigurationProvider);

            // maxCount != null
            if (maxCount.HasValue)
            {
                query = query.Take(maxCount.Value);
            }

            var users = query
                .ToList();

            return users;
        }

        public void CreateUser(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
