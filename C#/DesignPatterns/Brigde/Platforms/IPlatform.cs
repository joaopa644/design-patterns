using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brigde.Platforms
{
    public interface IPlatform
    {

        void ConfigureRMTP();
        void AuthToken();

    }
}
