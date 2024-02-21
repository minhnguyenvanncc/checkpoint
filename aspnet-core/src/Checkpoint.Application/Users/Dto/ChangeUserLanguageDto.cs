using System.ComponentModel.DataAnnotations;

namespace Checkpoint.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}