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

    // OTHER REQUESTS: GET, POST, PUT, PATCH (CRUD operations [CRUD = "Create, Read, Update, and Delete" ])
    // CRUD EQUIVALENCY: READ -> GET, UPDATE -> PATCH
    [HttpGet("{id}")]
    public string Get(int id)
    {
        Obj obj = new Obj();
        // call backend make database requests using entity
        if(id == 1)
        {
            // query your database + other logic + entity framework...
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
