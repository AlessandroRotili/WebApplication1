using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InteriController : Controller
    {
        public static List<int > Interi { get; set; } = new List<int>();    


        [HttpPost]
        public void AddToIntList([FromBody] int value)
        {
            Interi.Add(value);
        }

        [HttpGet("getlist")]
        public List<int> GetIntegerList()
        {
            return Interi;
        }

        [HttpDelete("deleteFromList/{index}")]
        public void deleteFromList([FromBody]int index)
        {
            Interi.Remove(index);
        }

        [HttpGet("getint/{index}")]
        public int GetIntegerFromList(int index)
        {
            return Interi.ElementAt(index);
        }

        [HttpGet("getOdds")]
        public List<int> GetOddsInt()
        {
            return Interi.Where(intero => intero % 2 == 0).ToList();
        }


    }
}
