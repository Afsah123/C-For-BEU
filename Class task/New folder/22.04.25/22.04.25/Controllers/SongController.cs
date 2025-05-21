using _22._04._25.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _22._04._25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private static List<music>? _musiclist;
        public SongController()
        {
            if (_musiclist == null)
            { 
                _musiclist = new List<music>()
                    {
                        new music{Id= 1,  Name="my world", Artist= "omar" },
                        new music{Id= 2,  Name="sdhbhj", Artist= "afsah" },
                        new music{Id= 3,  Name="dkjbhdsb", Artist= "ilham"},
                    };

            }

        }

        [HttpGet]

        public ActionResult<IEnumerable<music>> Retrievemusic()
        {
            return _musiclist;
        }

        [HttpGet("{id}")]
        public ActionResult<music> Getmusic(int id)
        {
            var music = _musiclist.Find(p => p.Id == id);
            if (music == null) return NotFound();
            return music;

        }
        [HttpPost]
        public ActionResult<music> CreateProduct(music music)
        {
            Console.WriteLine($"Received POST for: {music.Name}, {music.Artist}");
            _musiclist.Add(music);
            return CreatedAtAction(nameof(Getmusic), new { id = music.Id }, music);
        }

    
    }
}
