var permissions = 2;
string stringPermissions;

switch(permissions)
{
    case Permissions.Read:
        stringPermissions = "Read";
        break;
    case Permissions.Write:
        stringPermissions = "Write";
        break;
    case Permissions.Read_and_Write:
        stringPermissions = "Read and Write";
        break;
    default:
        stringPermissions = "No Access";
        break;
}

Console.WriteLine(stringPermissions);

public static class Permissions
{
    public const int NoAccess = 0;
    public const int Read = 1;
    public const int Write = 2;
    public const int Read_and_Write = 3;
}