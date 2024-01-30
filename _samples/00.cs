var permissions = 2;
string stringPermissions;

switch(permissions)
{
    case 1:
        stringPermissions = "Read";
        break;
    case 2:
        stringPermissions = "Write";
        break;
    case 3:
        stringPermissions = "Read and Write";
        break;
    default:
        stringPermissions = "No Access";
        break;
}

Console.WriteLine(stringPermissions);
