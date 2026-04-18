namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "obj", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0200x4ec8cd3b : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.string> {
    public static readonly androidx.room.C0200x4ec8cd3b INSTANCE = new androidx.room.C0200x4ec8cd3b();

    C0200x4ec8cd3b() {
        super(1);
    }

    public override java.lang.string Invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }

    public readonly java.lang.string Invoke2(androidx.sqlite.db.SupportSQLiteDatabase obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, "obj");
        return obj.getPath();
    }
}

