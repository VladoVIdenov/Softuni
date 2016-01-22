using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Characters;

namespace ConsoleApplication1.Interfaces
{
    public interface IAttack
    {
        void Attack(Character target);
    }
}
