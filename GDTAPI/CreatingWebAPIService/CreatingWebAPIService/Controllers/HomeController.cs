using System;
using System.Web.Http;

namespace DevetchAPI
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public string AddEmpDetails()
        {
            string Name = GetEmpDetail();
            return Name;
        }
       
        [HttpGet]
        public string GetEmpDetail()
        {
            return "Nikhil Raut";
        }

        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;

        }
        [HttpPut]
        public string UpdateEmpDetails(string Name)
        {
            return "Employee details Updated with Name " + Name;

        }
    }

}

