namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0016\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00030\u0002\u0018\u00010\u00012\u0006\u0010\u0004\u001a\u00020\u0005H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "Landroid/util/ValueTuple;", "", "obj", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0186x882a29d5 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.util.List<? : android.util.ValueTuple<java.lang.string, java.lang.string>>> {
    public static readonly androidx.room.C0186x882a29d5 INSTANCE = new androidx.room.C0186x882a29d5();

    C0186x882a29d5() {
        super(1);
    }

    public java.util.List<? : android.util.ValueTuple<java.lang.string, java.lang.string>> invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }

    public override readonly java.util.List<android.util.ValueTuple<java.lang.string, java.lang.string>> Invoke2(androidx.sqlite.db.SupportSQLiteDatabase obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, "obj");
        return obj.getAttachedDbs();
    }
}

