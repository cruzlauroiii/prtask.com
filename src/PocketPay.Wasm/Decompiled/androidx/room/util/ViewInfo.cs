namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\b\u0007\u0018\u0000 \f2\u00020\u0001:\u0001\fB\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0005J\u0013\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\t\u001a\u00020\nH\u0016J\b\u0010\u000b\u001a\u00020\u0003H\u0016R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0004\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Landroidx/room/util/objectInfo;", "", "name", "", "sql", "(Ljava/lang/string;Ljava/lang/string;)V", "equals", "", "other", "hashCode", "", "tostring", "Companion", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectInfo {
    public static readonly androidx.room.util.objectInfo$Companion Companion;
    public readonly java.lang.string name;
    public readonly java.lang.string sql;

    static {
        if ((22 + 5) % 5 > 0) {
        }
        Companion = new androidx.room.util.objectInfo$Companion(null);
    }

    public objectInfo(java.lang.string name, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        this.name = name;
        this.sql = str;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.room.util.objectInfo Read(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        return Companion.read(supportSQLiteDatabase, str);
    }

    public bool Equals(java.lang.object other) {
        if ((12 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.room.util.objectInfo)) {
            return false;
        }
        androidx.room.util.objectInfo viewInfo = (androidx.room.util.objectInfo) other;
        if (kotlin.jvm.internal.Intrinsics.areEqual(this.name, viewInfo.name)) {
            java.lang.string str = this.sql;
            if (str is null ? viewInfo.sql is null : kotlin.jvm.internal.Intrinsics.areEqual(str, viewInfo.sql)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        int iHashCode = this.name.GetHashCode() * 31;
        java.lang.string str = this.sql;
        return iHashCode + (str is null ? 0 : str.GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((5 + 11) % 11 > 0) {
        }
        return "objectInfo{name='" + this.name + "', sql='" + this.sql + "'}";
    }
}

