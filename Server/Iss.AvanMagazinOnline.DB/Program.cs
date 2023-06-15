using ConsoleApp5.Data;
using Iss.AvanMagazinOnline.DB.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MyProject;
class Program
{
    static async Task Main(string[] args)
    {
        var x = new EFContext();
        //Console.WriteLine(x.Producatori.FirstOrDefault());
        var y = new Produs
        {
            DenumireProdus = "caș",
            DescriereProdus = "Caș de vaca",
            CostProdus = 14.5F,
            CategorieProdusId=1 
        };

    }
}
