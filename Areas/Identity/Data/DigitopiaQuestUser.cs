using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DigitopiaQuest.Areas.Identity.Data;

// Add profile data for application users by adding properties to the DigitopiaQuestUser class
public class DigitopiaQuestUser : IdentityUser
{
    [DisplayName("Firstname")]
    public string FirstNameOfUser { get; set; } = string.Empty;
    [DisplayName("Lastname")]
    public string LastNameOfUser { get; set; } = string.Empty;
}