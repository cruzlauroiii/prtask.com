namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RoomDatabase$beginTransaction$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.object> {
    readonly androidx.room.RoomDatabase this$0;

    RoomDatabase$beginTransaction$1(androidx.room.RoomDatabase roomDatabase) {
        super(1);
        this.this$0 = roomDatabase;
    }

    public readonly java.lang.object Invoke2(androidx.sqlite.db.SupportSQLiteDatabase it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        androidx.room.RoomDatabase.access$internalBeginTransaction(this.this$0);
        return null;
    }

    public override java.lang.object Invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }
}

