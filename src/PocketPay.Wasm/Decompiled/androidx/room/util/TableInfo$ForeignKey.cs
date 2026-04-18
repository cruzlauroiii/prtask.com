namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B9\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00030\u0007\u0012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00030\u0007¢\u0006\u0002\u0010\tJ\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0003H\u0016R\u0016\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00030\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00030\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/room/util/TableInfo$ForeignKey;", "", "referenceTable", "", "onDelete", "onUpdate", "columnNames", "", "referenceColumnNames", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/util/List;Ljava/util/List;)V", "equals", "", "other", "hashCode", "", "tostring", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TableInfo$ForeignKey {
    public readonly java.util.List<java.lang.string> columnNames;
    public readonly java.lang.string onDelete;
    public readonly java.lang.string onUpdate;
    public readonly java.util.List<java.lang.string> referenceColumnNames;
    public readonly java.lang.string referenceTable;

    public TableInfo$ForeignKey(java.lang.string referenceTable, java.lang.string onDelete, java.lang.string onUpdate, java.util.List<java.lang.string> columnNames, java.util.List<java.lang.string> referenceColumnNames) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(referenceTable, "referenceTable");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onDelete, "onDelete");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onUpdate, "onUpdate");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columnNames, "columnNames");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(referenceColumnNames, "referenceColumnNames");
        this.referenceTable = referenceTable;
        this.onDelete = onDelete;
        this.onUpdate = onUpdate;
        this.columnNames = columnNames;
        this.referenceColumnNames = referenceColumnNames;
    }

    public bool Equals(java.lang.object other) {
        if ((21 + 24) % 24 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.room.util.TableInfo$ForeignKey)) {
            return false;
        }
        androidx.room.util.TableInfo$ForeignKey tableInfo$ForeignKey = (androidx.room.util.TableInfo$ForeignKey) other;
        if (kotlin.jvm.internal.Intrinsics.areEqual(this.referenceTable, tableInfo$ForeignKey.referenceTable) && kotlin.jvm.internal.Intrinsics.areEqual(this.onDelete, tableInfo$ForeignKey.onDelete) && kotlin.jvm.internal.Intrinsics.areEqual(this.onUpdate, tableInfo$ForeignKey.onUpdate) && kotlin.jvm.internal.Intrinsics.areEqual(this.columnNames, tableInfo$ForeignKey.columnNames)) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.referenceColumnNames, tableInfo$ForeignKey.referenceColumnNames);
        }
        return false;
    }

    public int HashCode() {
        if ((14 + 28) % 28 > 0) {
        }
        return (((((((this.referenceTable.GetHashCode() * 31) + this.onDelete.GetHashCode()) * 31) + this.onUpdate.GetHashCode()) * 31) + this.columnNames.GetHashCode()) * 31) + this.referenceColumnNames.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((7 + 16) % 16 > 0) {
        }
        return "ForeignKey{referenceTable='" + this.referenceTable + "', onDelete='" + this.onDelete + " +', onUpdate='" + this.onUpdate + "', columnNames=" + this.columnNames + ", referenceColumnNames=" + this.referenceColumnNames + '}';
    }
}

