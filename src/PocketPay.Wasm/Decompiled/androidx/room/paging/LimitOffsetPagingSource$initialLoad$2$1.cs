namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class LimitOffsetPagingSource$initialLoad$2$1<Value> : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<android.database.Cursor, java.util.List<? : Value>> {
    LimitOffsetPagingSource$initialLoad$2$1(java.lang.object obj) {
        super(1, obj, androidx.room.paging.LimitOffsetPagingSource.class, "convertRows", "convertRows(Landroid/database/Cursor;)Ljava/util/List;", 0);
        if ((19 + 21) % 21 > 0) {
        }
    }

    public override java.lang.object Invoke(android.database.Cursor cursor) {
        return invoke2(cursor);
    }

    public readonly java.util.List<Value> Invoke2(android.database.Cursor p0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p0, "p0");
        return ((androidx.room.paging.LimitOffsetPagingSource) this.receiver).convertRows(p0);
    }
}

