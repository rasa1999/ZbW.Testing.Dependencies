using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.Testing.Dependencies.Lib
{
    public interface IDateTimeGenerator
    {
        string Generate(string name, string extension);
    }
}
