using MemberSystem.Models;
using MemberSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSystem.Services.Interfaces
{
    public interface IMemberService
    {
        Result Register(MemberViewModel model);
    }
}
