using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class RequiredMember
    {
       
    }
    public class RequiredMemberNew
    {
        public required int age { get; set; }
    }
    public class RequiredMemberOld
    {
        public int age { get; set; }
    }
    public class RequiredMemberNew1
    {
        public required int age { get; set; }

        [SetsRequiredMembers]
        public RequiredMemberNew1(int age)
        {
            this.age = age;
        }
    }
}
