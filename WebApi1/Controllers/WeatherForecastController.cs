using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace WebApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        public static List<Student> student = new List<Student>();
        public static List<Department> department = new List<Department>();



        [HttpPost]
        [Route("AddDep")]

        public IActionResult Post(int depID, string depName)
        {
            // Add new record
            department.Add(new Department
            {
                DepID = depID,
                DepName = depName
            });
            return Ok("Added Department");
        }

        [HttpPost]
        [Route("AddStudent")]
        public IActionResult Post(string stID, string stName,int depID)
        {
            // Add new record
            student.Add(new Student
            {
                StID = stID,
                StName = stName,
                DepID= depID

            });
            return Ok("Added Student");
        }
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return department;
        }

        [HttpGet]
        [Route("Getstudents")]

        public IEnumerable<Student> Get()
        {
            return student;
        }

        [HttpPut]
        [Route("Modify")]

        public IActionResult Put(int stID, string stName)
        {
            try
               {
                   if (student.Contains(student.Find(st => st.StID.Equals(stID)).StName = stName)))
                   {
                    student.Find(st => st.StID.Equals(stID)).StName = stName;

                      return Ok("Modified");

        }



        //    public static List<Employee> employees = new List<Employee>();

        //    [HttpPost]
        //    [Route("AddEmp1")]

        //    public IActionResult  Post(int empNo, string empName)
        //    {
        //        // Add new record
        //        employees.Add(new Employee
        //        {
        //            EmpNo = empNo,
        //            EmpName = empName
        //        });
        //        return Ok("Added");
        //    }

        //    [HttpPost]
        //    [Route("AddEmp")]
        //    public IActionResult Post([FromBody] Employee emp)
        //    {
        //        // Add new record
        //        employees.Add(emp);
        //        return Ok("Added");
        //    }

        //    [HttpPut]
        //    [Route("Modify")]

        //    public IActionResult Put(int empNo, string empName)
        //    {
        //        employees.Find(emp => emp.EmpNo.Equals(empNo)).EmpName = empName;

        //        return Ok("Modified");

        //    }

        //    [HttpDelete]
        //    [Route("DeleteEmp")]

        //    public IActionResult Delete(int empNo, string empName)
        //    {
        //        try
        //        {
        //            if (employees.Contains(employees.Find(emp => emp.EmpNo.Equals(empNo))))
        //            {
        //                employees.Remove(employees.Find(emp => emp.EmpNo.Equals(empNo)));
        //            }
        //        }
        //        catch(Exception e)
        //        {
        //            return BadRequest("ID not found");            
        //        }

        //        return Ok("Removed");
        //    }


        //    [HttpGet]
        //    public IEnumerable<Employee> Get()
        //    {
        //        return employees;
        //    }

        //    //[HttpGet]
        //    //public string Gettime()
        //    //{
        //    //    return DateTime.Now.ToString();
        //    //}
        //    [HttpGet]
        //    [Route("Addnumbers")]
        //    public string Add(int a,int b)
        //    {
        //        return (a + b).ToString();
        //    }

        //    [HttpGet]
        //    [Route("Subtractnumbers")]
        //    public string Sub(int a, int b)
        //    {
        //        return (a - b).ToString();
        //    }

        //    [HttpGet]
        //    [Route("Multiplynumbers")]
        //    public string Mul(int a, int b)
        //    {
        //        return (a * b).ToString();
        //    }

        //    [HttpGet]
        //    [Route("Dividenumber")]
        //    public string div(int a, int b)
        //    {
        //        return (a/b).ToString();
        //    }

        //    //private static readonly string[] Summaries = new[]
        //    //{
        //    //"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //}

        //    //private readonly ILogger<WeatherForecastController> _logger;

        //    //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //    //{
        //    //    _logger = logger;
        //    //}

        //    //[HttpGet(Name = "GetWeatherForecast")]
        //    //public IEnumerable<WeatherForecast> Get()
        //    //{
        //    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    //    {
        //    //        Date = DateTime.Now.AddDays(index),
        //    //        TemperatureC = Random.Shared.Next(-20, 55),
        //    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    //    })
        //    .ToArray();
        //    //}
        //}
    }
}