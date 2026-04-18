namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00003\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0019\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0096\u0001J\u0019\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\tH\u0096\u0001J\u0019\u0010\n\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u000bH\u0096\u0001J\u0011\u0010\f\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0096\u0001J\u0019\u0010\r\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u000eH\u0096\u0001J\t\u0010\u000f\u001a\u00020\u0003H\u0096\u0001J\t\u0010\u0010\u001a\u00020\u0003H\u0096\u0001¨\u0006\u0011"}, d2 = {"androidx/room/RoomSQLiteQuery$Companion$copyFrom$1", "Landroidx/sqlite/db/SupportSQLiteProgram;", "bindBlob", "", "index", "", "value", "", "binddouble", "", "bindlong", "", "bindNull", "bindstring", "", "clearBindings", "close", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomSQLiteQuery$Companion$copyFrom$1 : androidx.sqlite.db.SupportSQLiteProgram {
    private readonly androidx.room.RoomSQLiteQuery $$delegate_0;

    RoomSQLiteQuery$Companion$copyFrom$1(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.$$delegate_0 = roomSQLiteQuery;
    }

    public override void BindBlob(int index, byte[] value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.$$delegate_0.bindBlob(index, value);
    }

    public override void Binddouble(int index, double value) {
        this.$$delegate_0.binddouble(index, value);
    }

    public override void Bindlong(int index, long value) {
        this.$$delegate_0.bindlong(index, value);
    }

    public override void BindNull(int index) {
        this.$$delegate_0.bindNull(index);
    }

    public override void Bindstring(int index, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.$$delegate_0.bindstring(index, value);
    }

    public override void ClearBindings() {
        this.$$delegate_0.clearBindings();
    }

    public override void Close() {
        this.$$delegate_0.Dispose();
    }
}

