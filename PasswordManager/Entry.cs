
// entry - A row of data containing a service, username, and password.
// service - The website, app, etc. that the entry is for. Acts as the id so no duplicates.
// username - The email or other identifier used for the service.
// password - The password.
public class Entry 
{
    public string service { get; }
    public string username { get; }
    public string password { get; }

    public Entry(string service, string username, string password)
    {
        this.service = service;
        this.username = username;
        this.password = password;
    }
}
