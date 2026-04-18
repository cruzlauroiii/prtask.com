namespace PrTask.Automerge;

public enum AMobjType
{
    Default = 0,
    List = 1,
    Map = 2,
    Text = 3,
}

public enum AMmarkExpand
{
    Default = 0,
    None = 1,
    Before = 2,
    After = 3,
    Both = 4,
}

public enum AMidxType
{
    Default = 0,
    Key = 1,
    Pos = 2,
}

#pragma warning disable CA1028
[Flags]
public enum AMvalType : uint
{
    None = 0,
    Void = 1 << 0,
    ActorId = 1 << 1,
    Bool = 1 << 2,
    Bytes = 1 << 3,
    Change = 1 << 4,
    ChangeHash = 1 << 5,
    Counter = 1 << 6,
    Cursor = 1 << 7,
    Doc = 1 << 8,
    F64 = 1 << 9,
    SignedInt = 1 << 10,
    Mark = 1 << 11,
    Null = 1 << 12,
    ObjType = 1 << 13,
    Str = 1 << 14,
    SyncHave = 1 << 15,
    SyncMessage = 1 << 16,
    SyncState = 1 << 17,
    Timestamp = 1 << 18,
    UnsignedInt = 1 << 19,
    Unknown = 1 << 20,
}
#pragma warning restore CA1028

public enum AMstatus
{
    Ok = 0,
    Error = 1,
    InvalidResult = 2,
}
