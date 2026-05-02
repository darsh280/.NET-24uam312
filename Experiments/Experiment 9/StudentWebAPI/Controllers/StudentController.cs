using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models;

namespace StudentWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Shivani", Course = "CSE" },
            new Student { Id = 2, Name = "Rahul", Course = "IT" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            student.Name = updatedStudent.Name;
            student.Course = updatedStudent.Course;

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            students.Remove(student);
            return Ok();
        }
    }
}

//What is Web API
//Communication between frontend and backend.
//eg. swiggy, instagram

//REST API
//uses HTTP method , works with JSON 
//HTTP methods- get: fetch data ex. getStudent
//Post : ex. add student


//Activity
//What is Web API and REST API with example deep study
//Learn HTTP methods with proper example

//understand the flow of webAPI with Swagger

//WebAPI - communication
//controller - handlers
//swagger - testing tool
//http method - Action

//-----------Experiment 10 --------------
//
