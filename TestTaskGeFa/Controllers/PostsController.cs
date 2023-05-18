using Microsoft.AspNetCore.Mvc;

namespace TestTaskGeFa.Controllers;

public class PostsController : Controller
{
    private readonly DBContext _context;

    public PostsController(DBContext context)
    {
        _context = context;
    }

    public IActionResult Index(int? startId, int? count)
    {
        var query = _context.posts.AsQueryable();

        if (startId.HasValue) query = query.Where(p => p.id >= startId.Value);

        if (count.HasValue)
        {
            query = query.OrderBy(p => p.id).Take(count.Value);
        }

        var titles = query.OrderBy(p => p.id).Select(p => p.title).ToList();

        ViewBag.StartId = startId;
        ViewBag.Count = count;


        return View(titles);
    }
}