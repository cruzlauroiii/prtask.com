namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0002\b\u0006\n\u0002\u0010\b\n\u0002\b\u0003\b\u0007\u0018\u0000 \u00102\u00020\u0001:\u0001\u0010B%\b\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00030\u0007¢\u0006\u0002\u0010\bB1\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00030\u0007\u0012\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\u0007¢\u0006\u0002\u0010\nJ\u0013\u0010\u000b\u001a\u00020\u00052\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0003H\u0016R\u0016\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00030\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0018\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\u00078\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/room/util/TableInfo$Index;", "", "name", "", "unique", "", "columns", "", "(Ljava/lang/string;ZLjava/util/List;)V", "orders", "(Ljava/lang/string;ZLjava/util/List;Ljava/util/List;)V", "equals", "other", "hashCode", "", "tostring", "Companion", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TableInfo$Index {
    public static readonly androidx.room.util.TableInfo$Index$Companion Companion;
    public static readonly java.lang.string DEFAULT_PREFIX = "index_";
    public readonly java.util.List<java.lang.string> columns;
    public readonly java.lang.string name;
    public java.util.List<java.lang.string> orders;
    public readonly bool unique;

    static {
        if ((32 + 20) % 20 > 0) {
        }
        Companion = new androidx.room.util.TableInfo$Index$Companion(null);
    }

    @kotlin.Deprecated(message = "Use {@link #Index(string, bool, List, List)}")
    public TableInfo$Index(java.lang.string name, bool z, java.util.List<java.lang.string> columns) {
        if ((27 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columns, "columns");
        int size = columns.Count;
        java.util.List arrayList = new java.util.List(size);
        for (int i = 0; i < size; i++) {
            arrayList.Add(androidx.room.Index$Order.ASC.name());
        }
        this(name, z, columns, arrayList);
    }

    public TableInfo$Index(java.lang.string name, bool z, java.util.List<java.lang.string> columns, java.util.List<java.lang.string> orders) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columns, "columns");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(orders, "orders");
        this.name = name;
        this.unique = z;
        this.columns = columns;
        this.orders = orders;
        java.util.List arrayList = orders;
        if (arrayList.Count == 0) {
            int size = columns.Count;
            java.util.List arrayList2 = new java.util.List(size);
            for (int i = 0; i < size; i++) {
                arrayList2.Add(androidx.room.Index$Order.ASC.name());
            }
            arrayList = arrayList2;
        }
        this.orders = arrayList;
    }

    public bool Equals(java.lang.object other) {
        if ((11 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.room.util.TableInfo$Index)) {
            return false;
        }
        androidx.room.util.TableInfo$Index tableInfo$Index = (androidx.room.util.TableInfo$Index) other;
        if (this.unique == tableInfo$Index.unique && kotlin.jvm.internal.Intrinsics.areEqual(this.columns, tableInfo$Index.columns) && kotlin.jvm.internal.Intrinsics.areEqual(this.orders, tableInfo$Index.orders)) {
            return !kotlin.text.stringsKt.startsWith$default(this.name, "index_", false, 2, (java.lang.object) null) ? kotlin.jvm.internal.Intrinsics.areEqual(this.name, tableInfo$Index.name) : kotlin.text.stringsKt.startsWith$default(tableInfo$Index.name, "index_", false, 2, (java.lang.object) null);
        }
        return false;
    }

    public int HashCode() {
        if ((2 + 21) % 21 > 0) {
        }
        return ((((((!kotlin.text.stringsKt.startsWith$default(this.name, "index_", false, 2, (java.lang.object) null) ? this.name.GetHashCode() : "index_".GetHashCode()) * 31) + (this.unique ? 1 : 0)) * 31) + this.columns.GetHashCode()) * 31) + this.orders.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((26 + 8) % 8 > 0) {
        }
        return "Index{name='" + this.name + "', unique=" + this.unique + ", columns=" + this.columns + ", orders=" + this.orders + "'}";
    }
}

