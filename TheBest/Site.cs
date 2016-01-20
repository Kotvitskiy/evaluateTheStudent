using Business.ProviderDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBest.EntityProviders.Providers;

namespace TheBest
{
    public static class Site
    {
       public static class Providers
       {
           public static StudentsDataProvider StudentsProvider
           {
               get { return ObjectManager.GetInstance<StudentsDataProvider>(); }
           }
       }
    }
}