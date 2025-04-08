using MemberSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSystem.Repositories.Interfaces
{
    public interface IMemberRepository
    {
        bool Exists(string username);
        void Create(Member member);
    }
}
