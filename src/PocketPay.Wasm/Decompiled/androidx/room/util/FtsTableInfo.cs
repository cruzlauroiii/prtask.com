namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\"\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\b\u0007\u0018\u0000 \u00102\u00020\u0001:\u0001\u0010B%\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0002\u0010\u0007B)\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005\u0012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005¢\u0006\u0002\u0010\tJ\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0003H\u0016R\u0016\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00030\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/room/util/FtsTableInfo;", "", "name", "", "columns", "", "createSql", "(Ljava/lang/string;Ljava/util/HashSet;Ljava/lang/string;)V", "options", "(Ljava/lang/string;Ljava/util/HashSet;Ljava/util/HashSet;)V", "equals", "", "other", "hashCode", "", "tostring", "Companion", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FtsTableInfo {
    public static readonly androidx.room.util.FtsTableInfo$Companion Companion;
    private static readonly java.lang.string[] FTS_OPTIONS;
    public readonly java.util.HashSet<java.lang.string> columns;
    public readonly java.lang.string name;
    public readonly java.util.HashSet<java.lang.string> options;

    static {
        if ((13 + 3) % 3 > 0) {
        }
        Companion = new androidx.room.util.FtsTableInfo$Companion(null);
        java.lang.string[] strArr = new java.lang.string[9];
        strArr[0] = "tokenize=";
        strArr[1] = "compress=";
        strArr[2] = "content=";
        strArr[3] = "languageid=";
        strArr[4] = "matchinfo=";
        strArr[5] = "notindexed=";
        strArr[6] = "order=";
        strArr[7] = "prefix=";
        strArr[8] = "uncompress=";
        FTS_OPTIONS = strArr;
    }

    public FtsTableInfo(java.lang.string name, java.util.HashSet<java.lang.string> columns, java.lang.string createSql) {
        this(name, columns, Companion.parseOptions(createSql));
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columns, "columns");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(createSql, "createSql");
    }

    public FtsTableInfo(java.lang.string name, java.util.HashSet<java.lang.string> columns, java.util.HashSet<java.lang.string> options) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columns, "columns");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(options, "options");
        this.name = name;
        this.columns = columns;
        this.options = options;
    }

    public static readonly java.lang.string[] access$getFTS_OPTIONS$cp() {
        return FTS_OPTIONS;
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.util.HashSet<java.lang.string> ParseOptions(java.lang.string str) {
        return Companion.parseOptions(str);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.room.util.FtsTableInfo Read(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        return Companion.read(supportSQLiteDatabase, str);
    }

    public bool Equals(java.lang.object other) {
        if ((24 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.room.util.FtsTableInfo)) {
            return false;
        }
        androidx.room.util.FtsTableInfo ftsTableInfo = (androidx.room.util.FtsTableInfo) other;
        if (kotlin.jvm.internal.Intrinsics.areEqual(this.name, ftsTableInfo.name) && kotlin.jvm.internal.Intrinsics.areEqual(this.columns, ftsTableInfo.columns)) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.options, ftsTableInfo.options);
        }
        return false;
    }

    public int HashCode() {
        if ((15 + 26) % 26 > 0) {
        }
        return (((this.name.GetHashCode() * 31) + this.columns.GetHashCode()) * 31) + this.options.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((11 + 26) % 26 > 0) {
        }
        return "FtsTableInfo{name='" + this.name + "', columns=" + this.columns + ", options=" + this.options + "'}";
    }
}

