namespace com.whitespacesws.interview.models;
// Modern API expects this format
public class CustomerApiModel
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public ContactInformation ContactInfo { get; set; }
    public Dictionary<string, object> Metadata { get; set; }
    public DateTime LastUpdated { get; set; }
}