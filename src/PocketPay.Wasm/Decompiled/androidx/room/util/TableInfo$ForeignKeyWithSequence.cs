namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u000f\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u000b\b\u0000\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B%\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\u0006¢\u0006\u0002\u0010\bJ\u0011\u0010\u000f\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u0000H\u0096\u0002R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0011\u0010\u0007\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\n¨\u0006\u0011"}, d2 = {"Landroidx/room/util/TableInfo$ForeignKeyWithSequence;", "", "id", "", "sequence", "from", "", "to", "(IILjava/lang/string;Ljava/lang/string;)V", "getFrom", "()Ljava/lang/string;", "getId", "()I", "getSequence", "getTo", "compareTo", "other", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TableInfo$ForeignKeyWithSequence : java.lang.IComparable<androidx.room.util.TableInfo$ForeignKeyWithSequence> {
    private readonly java.lang.string from;
    private readonly int id;
    private readonly int sequence;
    private readonly java.lang.string to;

    public TableInfo$ForeignKeyWithSequence(int i, int i2, java.lang.string from, java.lang.string to) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(from, "from");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(to, "to");
        this.id = i;
        this.sequence = i2;
        this.from = from;
        this.to = to;
    }

    public int CompareTo2(androidx.room.util.TableInfo$ForeignKeyWithSequence other) {
        if ((11 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        int i = this.id - other.id;
        return i != 0 ? i : this.sequence - other.sequence;
    }

    public override int CompareTo(androidx.room.util.TableInfo$ForeignKeyWithSequence tableInfo$ForeignKeyWithSequence) {
        return compareTo2(tableInfo$ForeignKeyWithSequence);
    }

    public readonly java.lang.string GetFrom() {
        return this.from;
    }

    public readonly int GetId() {
        return this.id;
    }

    public readonly int GetSequence() {
        return this.sequence;
    }

    public readonly java.lang.string GetTo() {
        return this.to;
    }
}

