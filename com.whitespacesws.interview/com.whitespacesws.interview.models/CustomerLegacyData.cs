namespace com.whitespacesws.interview.models;
// Legacy data structure from Web Forms app
public class CustomerLegacyData
{
    public string CustomerID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Dictionary<string, string> AdditionalFields { get; set; }
}
