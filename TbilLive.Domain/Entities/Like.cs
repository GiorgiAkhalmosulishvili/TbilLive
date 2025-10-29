namespace TbilLive.Domain.Entities;

public class Like
{
    public Guid Id { get; set; }
    public Guid PostId { get; set; }
    public Guid UserId { get; set; }
    public bool IsPositive { get; set; }
    public DateTime CreatedAt { get; set; }
}
