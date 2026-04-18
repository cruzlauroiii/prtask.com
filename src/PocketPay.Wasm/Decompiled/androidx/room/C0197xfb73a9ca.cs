namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "invoke", "(Landroidx/sqlite/db/SupportSQLiteDatabase;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0197xfb73a9ca : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.bool> {
    readonly int $newVersion;

    C0197xfb73a9ca(int i) {
        super(1);
        this.$newVersion = i;
    }

    public readonly java.lang.bool Invoke2(androidx.sqlite.db.SupportSQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        return java.lang.bool.valueOf(db.needUpgrade(this.$newVersion));
    }

    public override java.lang.bool Invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }
}

