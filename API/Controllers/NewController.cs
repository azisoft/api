using Microsoft.AspNetCore.Mvc;
using StructureMap;
using API.Common.Interface;
using API.Common.Model;
using API.Common;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class NewController : Controller
    {
        private IExecute _business;

        public NewController(IContainer injectedContainer)
        {
            _business = injectedContainer.GetInstance<IExecute>(Constants.Interface.Business);
        }

        // GET api/values
        [HttpGet]
        public NewModel Get()
        {
            return _business.Execute<ModelBase, KeyBase>(new KeyBase(Constants.DataAccessKey.NewData)) as NewModel;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
