using CodeFirst.Models;
using CodeFirst.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {
        private readonly TestDbContextcs _Context;
        public TestAPIController(TestDbContextcs Context) 
        {
            _Context = Context;
        }

        [HttpGet]
        [Route("GetUser/rawdata")]
        public List<string> Get()
        {
            var role = _Context.Users.Include(x=>x.Roles).ThenInclude(x=>x.Auths).ThenInclude(x=>x.Features).First(x => x.id == 1).Roles.SelectMany(x => x.Auths.SelectMany(z => z.Features)).Select(x => x.Name).Distinct().ToList();

            //var authList = new List<Auth>();
            //foreach (var item in role)
            //{
            //    authList.AddRange(item.Auths.ToList());
            //}
            //var strList = new List<string>();
            //foreach (var item in authList)
            //{
            //    strList.AddRange(item.Features.Select(x => x.Name));
            //}
            //strList.Distinct();
            return role;
        }
        [HttpGet]
        [Route("GetAccount/rawdata")]
        public IQueryable<string> GetAccount()
        {
            var aaa = _Context.Users.Include(x => x.Roles).ThenInclude(x => x.Auths).ThenInclude(x => x.Features).OrderBy(x => x.Roles.SelectMany(x => x.Auths.SelectMany(x => x.Features)).Distinct().Count()).Select(x => x.Account);
            return aaa;
        }
    }
}
