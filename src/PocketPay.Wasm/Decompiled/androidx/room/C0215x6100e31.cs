namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "obj", "Landroidx/sqlite/db/SupportSQLiteStatement;", "invoke", "(Landroidx/sqlite/db/SupportSQLiteStatement;)Ljava/lang/long;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0215x6100e31 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteStatement, java.lang.long> {
    public static readonly androidx.room.C0215x6100e31 INSTANCE = new androidx.room.C0215x6100e31();

    C0215x6100e31() {
        super(1);
    }

    public readonly java.lang.long Invoke2(androidx.sqlite.db.SupportSQLiteStatement obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, "obj");
        return java.lang.long.valueOf(obj.simpleQueryForlong());
    }

    public override java.lang.long Invoke(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return invoke2(supportSQLiteStatement);
    }
}

