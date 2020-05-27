using System.ComponentModel.DataAnnotations;

namespace ABPVue.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}