using System.Web.Mvc;

namespace TheBest.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {           
            context.MapRoute(
                "admin_student_list",
                "admin/students/list",
                new { action = "List", controller = "Students"}
            );

            context.MapRoute(
                "admin_student_create",
                "admin/students/new",
                new { action = "Create", controller = "Students" }
            );

            context.MapRoute(
               "admin_student_edit",
               "admin/students/edit",
               new { action = "Update", controller = "Students" }
           );

            context.MapRoute(
               "admin_student_delete",
               "admin/students/delete",
               new { action = "Delete", controller = "Students" }
           );

            context.MapRoute(
                "Admin_default",
                "admin",
                new { action = "List", controller = "Students", id = UrlParameter.Optional }
            );            
        }
    }
}