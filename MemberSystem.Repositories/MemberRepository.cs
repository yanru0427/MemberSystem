using MemberSystem.Data;
using MemberSystem.Models;
using MemberSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSystem.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _db;

        public MemberRepository(AppDbContext db) => _db = db;


        public bool Exists(string username) =>
             _db.Members.Any(x => x.Username == username);

        public void Create(Member member)
        {
            Console.WriteLine($"[DEBUG] 儲存會員：{member.Username}");
            _db.Members.Add(member);
            _db.SaveChanges();
        }
    }
}
