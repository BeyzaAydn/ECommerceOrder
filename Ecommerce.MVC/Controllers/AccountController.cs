using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.Common.CartHelpers;
using ECommerce.DAL.Context;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IProductService _productService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly EcommerceContext _context;



        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IProductService productService, EcommerceContext context)
            
        {
            _productService = productService;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> Order(Cart cart,AppUser user) 
        {
           var gelenUser= _userManager.GetUserAsync(User);
         
            if(gelenUser!=null)
            {
              if(user.Address==null)
                {

                    RedirectToAction("Index");
                }

              else 
                {
                    return View();
                
                }
            }

            return View();
            
        
        }

        [HttpPost]
        public IActionResult Order()
        {
            return View();


        }
    }
}
