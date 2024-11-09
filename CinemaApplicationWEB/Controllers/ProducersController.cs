using CinemaApplicationWEB.Data;
using CinemaApplicationWEB.Data.Base;
using CinemaApplicationWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplicationWEB.Controllers
{
    public class ProducersController : Controller
    {

        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //Get: producers/details/1

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) 
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }
        //Get: Producers/create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Create([Bind("ProfilePictureURL, FullName,Bio")]Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));

        }

        //Get: prodcuers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null)
            {
                return View("NotFound");
            }
            return View(producersDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL, FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            if(id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);

        }

        //Get: producers/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null)
            {
                return View("NotFound");
            }
            return View(producersDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }




    }
}
