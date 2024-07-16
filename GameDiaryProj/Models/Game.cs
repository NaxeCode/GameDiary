using System.ComponentModel.DataAnnotations;

namespace GameDiaryProj.Models;

public class Game
{
    public int ID { get; set; }

    public string? Title { get; set; }

    public int Rating { get; set; }

    [Required(ErrorMessage = "Please select a status")]
    public string? Status { get; set; }

}