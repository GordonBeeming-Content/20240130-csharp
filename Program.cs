var permissions = Permissions.Full_manage;
var checkFor = Permissions.Read_and_Write;

Console.WriteLine($"checkFor: {checkFor}, has {permissions} = {permissions.HasFlag(checkFor)}");
