using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContractController : ControllerBase
    {
        public ActionResult Post([FromBody] AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity)
        {
            try
            {

                AddRemoveRequestService addRemoveRequestService = new AddRemoveRequestService();
                addRemoveRequestService.SubmitAddRemoveRequest(addRemoveRequestCompositeEntity);
                return Ok("Challenge Accepted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        
    }
}
    

