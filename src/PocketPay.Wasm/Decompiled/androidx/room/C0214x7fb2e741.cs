namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "obj", "Landroidx/sqlite/db/SupportSQLiteStatement;", "invoke", "(Landroidx/sqlite/db/SupportSQLiteStatement;)Ljava/lang/int;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0214x7fb2e741 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteStatement, java.lang.int> {
    public static readonly androidx.room.C0214x7fb2e741 INSTANCE = new androidx.room.C0214x7fb2e741();

    C0214x7fb2e741() {
        super(1);
    }

    public readonly java.lang.int Invoke2(androidx.sqlite.db.SupportSQLiteStatement obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, "obj");
        return java.lang.int.valueOf(obj.executeUpdateDelete());
    }

    public override java.lang.int Invoke(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return invoke2(supportSQLiteStatement);
    }
}

