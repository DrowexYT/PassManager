public class Service
{
    public string ServiceName { get; set; }
    public string ServiceUsername { get; set; }
    public string ServicePassword { get; set; }

    public Service(string name, string username, string password)
    {
        ServiceName = name;
        ServiceUsername = username;
        ServicePassword = password;
    }
}
