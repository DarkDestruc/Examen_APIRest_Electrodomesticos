using Examen_APIRest_Electrodomesticos.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Reflection;


namespace Examen_APIRest_Electrodomesticos.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    
    public class ElectrodomesticosControllers: ControllerBase
    {
        private static List<AlmacenElectrodomesticos> _Electrodomesticos = new List<AlmacenElectrodomesticos>
        {
            new AlmacenElectrodomesticos
            {
                IdProduct = 1,
                NameProductElectrod = "Cocinas",
            },

            new AlmacenElectrodomesticos
            {
                IdProduct = 2,
                NameProductElectrod = "Neveras",
            },

            new AlmacenElectrodomesticos
            {
                IdProduct = 3,
                NameProductElectrod = "Lavadoras",
            },

            new AlmacenElectrodomesticos
            {
                IdProduct = 4,
                NameProductElectrod = "Televisores",
            },


        };
        // Consultar todos los Electrodomestics
        [HttpGet]
        public IEnumerable<AlmacenElectrodomesticos> GetAllElectrodomesticos()
        { 
        return _Electrodomesticos;
        }

     }
}
