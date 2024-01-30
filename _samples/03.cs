string stringPermissions = "Read_and_Write";

var permissions = Enum.Parse<Permissions>(stringPermissions);

Console.WriteLine(permissions.ToString());
Console.WriteLine((int)permissions);

public enum Permissions
{
    No_access = 0,
    Read = 1,
    Write = 2,
    Read_and_Write = 3,
}