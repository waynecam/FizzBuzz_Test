using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class NullFBService : BaseFBService
    {
        public override string CalculateFizzBuzzResult(int input)
        {
            throw new NotImplementedException();
        }
    }
}
