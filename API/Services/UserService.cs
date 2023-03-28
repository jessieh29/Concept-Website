// using SpaceFlightApp.Models.UserDetails;
// using SpaceFlightApp.Services;

// namespace WebApiSpaceFlight.Services
// {
//   public class NewBaseType
//   {
//     public Task<Userr> ChangeUserDeets(Userr newUserDeets)
//     {
//       throw new NotImplementedException();
//     }
//   }
//   public class UserService : NewBaseType, IUserService
//   {
//     private static List<Userr> Userrs = new List<Userr> {
//             new Userr(),
//             new Userr { Id = 1, Name = "nicolas"}
//         };

//     private readonly DataContext _context;

//     public UserService(DataContext context)
//     {
//       _context = context;
//     }
//     public async Task<Userr> ChangeUserDeets(Userr newUserDeets)
//     {
//         Userr userdetails = await _context.UserDetailsList.FirstOrDefaultAsync(c => c.Id == newUserDeets.Id);

//         userdetails.Id = newUserDeets.Id;
//         userdetails.Username = newUserDeets.Username;
//         userdetails.Name = newUserDeets.Name;
//         userdetails.Email = newUserDeets.Email;
//         userdetails.Gender = newUserDeets.Gender;

        
//         await _context.SaveChangesAsync();

//       return userdetails;
//     }
//   }
// }