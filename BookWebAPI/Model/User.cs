using System.ComponentModel.DataAnnotations;
namespace BookWebAPI.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string AuthorPseudoName { get; set; } // Hemingway
    }
}
