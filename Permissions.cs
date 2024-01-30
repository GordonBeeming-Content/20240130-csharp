[Flags]
public enum Permissions : byte
{
    NoAccess = 0,
    Read = 1,
    Write = 2,
    Read_and_Write = 3,
    Full_manage = 7,
}