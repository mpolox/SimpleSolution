namespace SimpleAPI.Dtos;

public class ResponseDto{
  public bool IsSuccess { get; set; } = true;
  public string ReponseMessage { get; set; } ="";
  public object? Data { get; set; } 
  public string? ErrorDetails { get; set; }

}