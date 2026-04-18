namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "obj", "Landroidx/sqlite/db/SupportSQLiteStatement;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0216xa8feac86 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteStatement, java.lang.string> {
    public static readonly androidx.room.C0216xa8feac86 INSTANCE = new androidx.room.C0216xa8feac86();

    C0216xa8feac86() {
        super(1);
    }

    public override java.lang.string Invoke(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return invoke2(supportSQLiteStatement);
    }

    public readonly java.lang.string Invoke2(androidx.sqlite.db.SupportSQLiteStatement obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, "obj");
        return obj.simpleQueryForstring();
    }
}

