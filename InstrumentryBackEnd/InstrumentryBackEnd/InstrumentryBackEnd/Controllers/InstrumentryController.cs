using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using InstrumentryBackEnd;

namespace InstrumentryBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstrumentryController : ControllerBase
    {
        private static readonly List<InstrumentDTO> instruments = new List<InstrumentDTO>()
        {
            new InstrumentDTO(){
                Image = "https://thumbs.static-thomann.de/thumb/padthumb600x600/pics/bdb/_45/455983/13890351_800.jpg",
                Model = "JS22",
                Brand = "Jackson"
            },
            new InstrumentDTO(){
                Image = "https://thumbs.static-thomann.de/thumb/padthumb600x600/pics/bdb/_46/462509/18203706_800.jpg",
                Model = "Les Paul Standard 60s",
                Brand = "Gibson"
            },
            new InstrumentDTO(){
                Image = "https://www.stars-music.es/medias/fender/strat-player-mex-sss-pf-hd-146087.webp",
                Model = "Stratocaster MEX",
                Brand = "Fender"
            },
            new InstrumentDTO(){
                Image = "https://www.stars-music.fr/medias/ibanez/grgr131ex-bkf-gio-hh-ht-pur-600-175182.jpg",
                Model = "BKF GIO",
                Brand = "Ibanez"
            },
            new InstrumentDTO(){
                Image = "https://sc1.musik-produktiv.com/pic-010145303xxl/esp-ltd-ec-fr-black-metal-black-satin.jpg",
                Model = "EC-FR",
                Brand = "ESP"
            },
            new InstrumentDTO(){
                Image = "https://thumbs.static-thomann.de/thumb/padthumb600x600/pics/bdb/_51/513697/16854575_800.jpg",
                Model = "Arrow BKM",
                Brand = "LTD"
            },
            new InstrumentDTO(){
                Image = "https://www.stars-music.fr/medias/prs/se-custom-24-08-2021-hh-trem-rw-housse-600-175565.jpg",
                Model = "Paul Reed Sith SE Custom",
                Brand = "PRS"
            },
            new InstrumentDTO(){
                Image = "https://ik.imagekit.io/w4c/microfusacom/catalog/product/cache/fbdcd70aa71e91d7b4e382afdd9a2c2e/a/a/aa.jpg",
                Model = "MLX Classic",
                Brand = "DEAN"
            },
            new InstrumentDTO(){
                Image = "https://sc1.musik-produktiv.com/pic-100054291l/schecter-hellraiser-c-1-fr-bch.jpg",
                Model = "Hellraiser C-1 FR BCH",
                Brand = "Schecter"
            },
            new InstrumentDTO(){
                Image = "https://d1aeri3ty3izns.cloudfront.net/media/100/1002065/1200/preview.jpg",
                Model = "JP15",
                Brand = "Music Man"
            }
        };

        private readonly ILogger<InstrumentryController> _logger;

        public InstrumentryController(ILogger<InstrumentryController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetInstrumentry")]
        public IEnumerable<InstrumentDTO> Get()
        {
            return instruments;
        }
    }
}
