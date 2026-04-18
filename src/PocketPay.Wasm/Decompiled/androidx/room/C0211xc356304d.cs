namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "statement", "Landroidx/sqlite/db/SupportSQLiteStatement;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0211xc356304d : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteStatement, java.lang.object> {
    public static readonly androidx.room.C0211xc356304d INSTANCE = new androidx.room.C0211xc356304d();

    C0211xc356304d() {
        super(1);
    }

    public readonly java.lang.object Invoke2(androidx.sqlite.db.SupportSQLiteStatement statement) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statement, "statement");
        statement.execute();
        return null;
    }

    public override java.lang.object Invoke(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return invoke2(supportSQLiteStatement);
    }
}

