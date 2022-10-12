using Microsoft.AspNetCore.Mvc;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PippoController : ControllerBase
    {
        // GET: raggiungibile tramite verbo e percorso principale (/pippo)
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            var request = Request;
            return new string[] { "value1", "value2" };
        }

        // GET: raggiungibile tramite verbo e percorso pricinipale al quale vanno aggiunti 2 route params obbligatori
        [HttpGet("{id}/{id2}")]
        public int GetById(int id, int id2, int id3)
        {
            var request = Request;
            return id + id2 + id3;
        }

        // GET: raggiungibile tramite verbo e percorso pricinipale + aggiunta di path al quale va aggiunto 1 route param obbligatorio
        [HttpGet("path/{id}")]
        public int GetByIdWithPath(int id)
        {
            return id;
        }

        // GET <PippoController>/5
        [HttpGet("path/path2/path3/{id}")]
        public int GetByIdWithPath23(int id)
        {
            return id;
        }



        // POST api/<PippoController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            var req = Request.Body;
            return "Body inserito correttamente";
        }
    }
}
