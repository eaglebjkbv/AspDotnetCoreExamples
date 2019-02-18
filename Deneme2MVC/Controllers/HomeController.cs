using Microsoft.AspNetCore.Mvc;
using Deneme2MVC.Models;



namespace Deneme2MVC.Controllers
{
    public class HomeController:Controller
    {
     
        public ViewResult Index(){
            var kisi=new Kisiler();
                 return View(kisi.KisileriGetir());
        }
        
    }
}