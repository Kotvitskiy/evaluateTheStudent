using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBest
{
    public static class ObjectManager
    {
        public static T GetInstance<T>()
            where T : new()
        {
            return new T();
        }
    }
}