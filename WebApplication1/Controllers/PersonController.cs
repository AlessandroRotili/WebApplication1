using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        public static List<Person> people { get; set; } = new List<Person>();


        [HttpPost]
        public void AddPersonToList([FromBody] Person person)
        {
            people.Add(person);
        }

        [HttpGet("getlist")]
        public List<Person> GetPeople()
        {
            Response.StatusCode = 999;
            return people;
        }

        [HttpDelete("deleteFromList/{index}")]
        public void deleteFromList(int index)
        {
            people.Remove(people.ElementAt(index));
        }

        [HttpGet("getPerson/{index}")]
        public Person GetPersonFromList(int index)
        {
            return people.ElementAt(index);
        }

        [HttpGet("getOdds/{name}")]
        public List<Person> GetListByName(string name)
        {
            return people.Where(person => person.Name.Equals(name)).ToList();
        }


    }
}
