using System.ComponentModel.DataAnnotations;

namespace Something.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}