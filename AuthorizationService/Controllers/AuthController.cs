using DTO.Models;
using EntitiesRepositories;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private ILogger logger;
        private AuthEntityRepository repository;

        public AuthController(ILogger logger, IConfiguration servicesConfiguration)
        {
            this.logger = logger;
            repository = new(servicesConfiguration.GetConnectionString(Constants.dbName)!);
        }

        [HttpGet("getUser")]
        public async Task<ActionResult> GetUserAsync([FromBody] UserModel userModel)
        {
            try
            {
                logger.LogInformation($"Request getUser");
                
                var userEntity = await repository.GetUserAsync(userModel.Login, userModel.Password);

                return Ok(value: userEntity);
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);

                return Problem(ex.Message, statusCode: 500);
            }
        }
    }
}
