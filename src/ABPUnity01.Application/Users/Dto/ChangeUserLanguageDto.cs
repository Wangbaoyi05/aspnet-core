using System.ComponentModel.DataAnnotations;

namespace ABPUnity01.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}