using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using nguyenQuangPhuoc_5951071080.Models;

namespace nguyenQuangPhuoc_5951071080.Controllers
{
    public class StudentController : ApiController
    {
        
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            
            var studentInfList = new List<StudentInfo>();
            for(int i = 0; i<10; i++)
            {
                
                var StudentInfo = new StudentInfo
                {

                    Name = $"Nguyen Quang Phuoc",
                    MSV = 5951071080,
                    Age = 21

                };
                studentInfList.Add(StudentInfo);
            }
            return studentInfList;
        }
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Name = $"Nguyen Quang Phuoc",
                MSV = 5951071080,
                Age = 21
            };
        }
        // GET: api/Student/5
       

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
