﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContractController : ControllerBase
    {
        private readonly ILogger<ContractController> _logger;
        public ContractController(ILogger<ContractController> logger)
        {
            _logger = logger;
        }
        public ActionResult Post([FromBody] AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity)
        {
            try
            {

                AddRemoveRequestService addRemoveRequestService = new AddRemoveRequestService();
                addRemoveRequestService.SubmitAddRemoveRequest(addRemoveRequestCompositeEntity);
                _logger.LogInformation("Logging from Contract controller try block");
                return Ok("Challenge Accepted");
                //return new JsonResult("Here");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex);
            }
        }
        
    }
}
    

