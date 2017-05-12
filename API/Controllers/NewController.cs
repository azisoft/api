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

        // GET api/get
        [HttpGet]
        public NewModel Get()
        {
            var ret = _business.Execute<ModelBase, KeyBase>(new KeyBase(Constants.DataAccessKey.NewData)) as NewModel;
            return ret;
        }

        // GET api/get/5
        [HttpGet("{id}")]
        public NewModel Get(int id)
        {
            var ret = _business.Execute<ModelBase, KeyBase>(new KeyBase(Constants.DataAccessKey.NewData)) as NewModel;
            return ret;
        }

        // POST api/create
        [HttpPost]
        public void Create([FromBody]string value)
        {
        }

        // PUT api/update/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody]string value)
        {
        }

        // DELETE api/delete/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
