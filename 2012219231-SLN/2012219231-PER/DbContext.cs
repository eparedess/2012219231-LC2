using System;
using System.Runtime.Remoting.Contexts;

namespace _2012219231_PER
{
    public class DbContext
    {
        public static implicit operator DbContext(Context v)
        {
            throw new NotImplementedException();
        }
    }
}