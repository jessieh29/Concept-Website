// using Microsoft.AspNetCore.Mvc;
// using WebApiSpaceFlight.UserDetails;
// using SpaceFlightApp.Models.UserDetails;
// using SpaceFlightApp.Services;

// namespace WebApiSpaceFlight.Controllers
// {
//   [ApiController]
//     [Route("[controller]")]
//     public class UserDetailsController : ControllerBase
//     {
        

//         private readonly IUserService _userService;

//         public UserDetailsController(IUserService userService)
//         {
//             _userService = userService;
//         }

//         [HttpGet("GetAllUsers")]
//         public async Task<ActionResult<List<SpaceFlightApp.Models.UserDetails.Userr>>> Get(){
//             return Ok(await _userService.GetAllUsers());
//         }
        
//         [HttpGet("GetByID")]
//        // public async Task<ActionResult<Userr>> GetSingle(int id){
//          //   return Ok(await _userService.GetUserById(id));
//         //}

//         [HttpPut]
//         //public async Task<ActionResult<Userr>> ChangeUserDetails(Userr newUserDeets){
//         //    return Ok( await _userService.ChangeUserDeets(newUserDeets));
//         //}
        
//     ///}
// }