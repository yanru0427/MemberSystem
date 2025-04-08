using MemberSystem.Models.ViewModels;
using MemberSystem.Models;
using MemberSystem.Repositories.Interfaces;
using MemberSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSystem.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repo;

        public MemberService(IMemberRepository repo)
        {
            _repo = repo;
        }

        public Result Register(MemberViewModel model)
        {
            if (_repo.Exists(model.Username))
                return Result.Fail("帳號已存在");

            var member = new Member
            {
                Username = model.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password),
                Email = model.Email,
                AddTime = DateTime.UtcNow
            };

            _repo.Create(member);
            return Result.Ok();
        }
    }
}
