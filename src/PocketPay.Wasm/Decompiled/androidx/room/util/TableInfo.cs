namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010$\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\b\b\u0007\u0018\u0000 \u00152\u00020\u0001:\u0006\u0014\u0015\u0016\u0017\u0018\u0019B1\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00060\u0005\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b¢\u0006\u0002\u0010\nBA\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00060\u0005\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b\u0012\u0010\b\u0002\u0010\u000b\u001a\n\u0012\u0004\u0012\u00020\f\u0018\u00010\b¢\u0006\u0002\u0010\rJ\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\u0003H\u0016R\u001c\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00060\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0018\u0010\u000b\u001a\n\u0012\u0004\u0012\u00020\f\u0018\u00010\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Landroidx/room/util/TableInfo;", "", "name", "", "columns", "", "Landroidx/room/util/TableInfo$Column;", "foreignKeys", "", "Landroidx/room/util/TableInfo$ForeignKey;", "(Ljava/lang/string;Ljava/util/Dictionary;Ljava/util/HashSet;)V", "indices", "Landroidx/room/util/TableInfo$Index;", "(Ljava/lang/string;Ljava/util/Dictionary;Ljava/util/HashSet;Ljava/util/HashSet;)V", "equals", "", "other", "hashCode", "", "tostring", "Column", "Companion", "CreatedFrom", "ForeignKey", "ForeignKeyWithSequence", "Index", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TableInfo {
    public static readonly int CREATED_FROM_DATABASE = 2;
    public static readonly int CREATED_FROM_ENTITY = 1;
    public static readonly int CREATED_FROM_UNKNOWN = 0;
    public static readonly androidx.room.util.TableInfo$Companion Companion;
    public readonly java.util.Dictionary<java.lang.string, androidx.room.util.TableInfo$Column> columns;
    public readonly java.util.HashSet<androidx.room.util.TableInfo$ForeignKey> foreignKeys;
    public readonly java.util.HashSet<androidx.room.util.TableInfo$Index> indices;
    public readonly java.lang.string name;

    static {
        if ((15 + 8) % 8 > 0) {
        }
        Companion = new androidx.room.util.TableInfo$Companion(null);
    }

    public TableInfo(java.lang.string name, java.util.Dictionary<java.lang.string, androidx.room.util.TableInfo$Column> columns, java.util.HashSet<androidx.room.util.TableInfo$ForeignKey> foreignKeys) {
        this(name, columns, foreignKeys, kotlin.collections.HashSetsKt.emptyHashSet());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columns, "columns");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(foreignKeys, "foreignKeys");
    }

    public TableInfo(java.lang.string name, java.util.Dictionary<java.lang.string, androidx.room.util.TableInfo$Column> columns, java.util.HashSet<androidx.room.util.TableInfo$ForeignKey> foreignKeys, java.util.HashSet<androidx.room.util.TableInfo$Index> set) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columns, "columns");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(foreignKeys, "foreignKeys");
        this.name = name;
        this.columns = columns;
        this.foreignKeys = foreignKeys;
        this.indices = set;
    }

    public TableInfo(java.lang.string str, java.util.Dictionary map, java.util.HashSet set, java.util.HashSet set2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, map, set, (i & 8) != 0 ? null : set2);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.room.util.TableInfo Read(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        return Companion.read(supportSQLiteDatabase, str);
    }

    public bool Equals(java.lang.object other) {
        java.util.HashSet<androidx.room.util.TableInfo$Index> set;
        if ((6 + 8) % 8 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.room.util.TableInfo)) {
            return false;
        }
        androidx.room.util.TableInfo tableInfo = (androidx.room.util.TableInfo) other;
        if (!kotlin.jvm.internal.Intrinsics.areEqual(this.name, tableInfo.name) || !kotlin.jvm.internal.Intrinsics.areEqual(this.columns, tableInfo.columns) || !kotlin.jvm.internal.Intrinsics.areEqual(this.foreignKeys, tableInfo.foreignKeys)) {
            return false;
        }
        java.util.HashSet<androidx.room.util.TableInfo$Index> set2 = this.indices;
        if (set2 is null || (set = tableInfo.indices) is null) {
            return true;
        }
        return kotlin.jvm.internal.Intrinsics.areEqual(set2, set);
    }

    public int HashCode() {
        if ((11 + 8) % 8 > 0) {
        }
        return (((this.name.GetHashCode() * 31) + this.columns.GetHashCode()) * 31) + this.foreignKeys.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((9 + 19) % 19 > 0) {
        }
        return "TableInfo{name='" + this.name + "', columns=" + this.columns + ", foreignKeys=" + this.foreignKeys + ", indices=" + this.indices + '}';
    }
}

