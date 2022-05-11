using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting.Models.Repository
{
    interface IUser
    {
        object empReport();
        object projectReport();
        object tsReport();
    }
}
