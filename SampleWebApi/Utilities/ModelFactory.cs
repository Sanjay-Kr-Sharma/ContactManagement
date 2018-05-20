using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ModelFactory<T>
    {
        private static T _dbContext;
        public static T GetContext()
        {
            if (_dbContext == null)
                _dbContext = (T)Activator.CreateInstance(typeof(T));
            return _dbContext;
        }
    }
}
