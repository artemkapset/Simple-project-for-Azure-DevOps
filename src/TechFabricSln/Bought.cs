using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFabricSln
{
    public class Bought
    {
        public User MadeBy { get; set; }

        public bool IsBoughtBy(User user)
        {
            if (user.Customer)
            {
                return true;
            }
            if (MadeBy == user)
            {
                return true;
            }
            return false;
        }
    }
}
