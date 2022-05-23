using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Models.Services;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProyectsRepository _proyectsRepository;
        //private readonly IConfiguration _configuration;

        //private readonly UniqueService _uniqueService;
        //private readonly DelimitedService _delimitedService;
        //private readonly TransientService _transientService;
        //private readonly UniqueService _uniqueService2;
        //private readonly DelimitedService _delimitedService2;
        //private readonly TransientService _transientService2;

        public HomeController(
            ILogger<HomeController> logger, 
            IProyectsRepository proyectsRepository
            //IConfiguration configuration
            //UniqueService uniqueService,
            //DelimitedService delimitedService,
            //TransientService transientService
            //UniqueService uniqueService2,
            //DelimitedService delimitedService2,
            //TransientService transientService2
            )
        {
            _logger = logger;
            _proyectsRepository = proyectsRepository;
            //_configuration = configuration;
            //_uniqueService = uniqueService;
            //_delimitedService = delimitedService;
            //_transientService = transientService;
            //_uniqueService2 = uniqueService2;
            //_delimitedService2 = delimitedService2;
            //_transientService2 = transientService2;
        }

        public IActionResult Index()
        {
            //var apellido = _configuration.GetValue<string>("Apellido");
            //_logger.LogTrace("LogTrace");
            //_logger.LogDebug("LogDebug");
            //_logger.LogInformation("LogInformation");
            //_logger.LogWarning("LogWarning");
            //_logger.LogError("LogError");
            //_logger.LogCritical("LogCritical" + apellido);
            //var guidViewModel = new GuidExampleViewModel()
            //{
            //    Unique = _uniqueService.GetGuid,
            //    Delimited = _delimitedService.GetGuid,
            //    Transient = _transientService.GetGuid,
            //};
            //var guidViewModel2 = new GuidExampleViewModel()
            //{
            //    Unique = _uniqueService2.GetGuid,
            //    Delimited = _delimitedService2.GetGuid,
            //    Transient = _transientService2.GetGuid,
            //};
            var proyects = _proyectsRepository.GetProyects().Take(3);
            var model = new HomeIndexViewModel() 
            { 
                Proyects = proyects,
                //ExampleGuid_1 = guidViewModel,
                //ExampleGuid_2 = guidViewModel2,
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Proyects()
        {
            var proyects = _proyectsRepository.GetProyects();
            return View(proyects);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}