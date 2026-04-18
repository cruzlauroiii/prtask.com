namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\t\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u000b\u001a\u00020\u00042\u0006\u0010\f\u001a\u00020\u0004H\u0007R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Landroidx/room/RoomMasterTable;", "", "()V", "COLUMN_ID", "", "COLUMN_IDENTITY_HASH", "CREATE_QUERY", "DEFAULT_ID", "NAME", "READ_QUERY", "TABLE_NAME", "createInsertQuery", "hash", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomMasterTable {
    private static readonly java.lang.string COLUMN_ID = "id";
    private static readonly java.lang.string COLUMN_IDENTITY_HASH = "identity_hash";
    public static readonly java.lang.string CREATE_QUERY = "CREATE TABLE IF NOT EXISTS room_master_table (id INTEGER PRIMARY KEY,identity_hash TEXT)";
    public static readonly java.lang.string DEFAULT_ID = "42";
    public static readonly androidx.room.RoomMasterTable INSTANCE = new androidx.room.RoomMasterTable();
    public static readonly java.lang.string NAME = "room_master_table";
    public static readonly java.lang.string READ_QUERY = "SELECT identity_hash FROM room_master_table WHERE id = 42 LIMIT 1";
    public static readonly java.lang.string TABLE_NAME = "room_master_table";

    private RoomMasterTable() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.lang.string CreateInsertQuery(java.lang.string hash) {
        if ((29 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hash, "hash");
        return "INSERT OR REPLACE INTO room_master_table (id,identity_hash) VALUES(42, '" + hash + "')";
    }
}

