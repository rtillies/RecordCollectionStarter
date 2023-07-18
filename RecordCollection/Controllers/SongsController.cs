using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordCollection.DataAccess;

namespace RecordCollection.Controllers
{
    public class SongsController : Controller
    {
        private readonly RecordCollectionContext _context;

        public SongsController(RecordCollectionContext context)
        {
            _context = context;
        }

        // GET: /albums/:albumId/songs
        [Route("Albums/{albumId:int}/Songs")]
        public IActionResult Index(int albumId)
        {
            var album = _context.Albums
                .Where(a => a.Id == albumId)
                .Include(a => a.Songs)
                .First();

            return View(album);
        }
    }
}
