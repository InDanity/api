using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace wpib.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CityController : ControllerBase
{
    class Obj 
    {
        public int[] a;
    }

    [HttpGet]
    public IEnumerable<int> Get()
    {
        return [5, 6];
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        Obj obj = new Obj();
        // call backend make database requests using entity
        if(id == 1)
        {
            obj.a = [1, 2];
            return JsonConvert.SerializeObject(obj);
        }
        else
        {
            obj.a = [0];
            return JsonConvert.SerializeObject(obj);
        }
    }
}
