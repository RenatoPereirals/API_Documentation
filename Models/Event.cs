namespace EventMaster.Models;

/// <summary>
/// Model class
/// </summary>
public class Event
{
    /// <summary>
    /// The unique identifier for the event.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The name of the event. The event name must be unique and must not contain special characters 
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The date of the event.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The location of the event.
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// The list of speakers for the event.
    /// </summary>
    public List<string> Speakers { get; set; } = new();
}