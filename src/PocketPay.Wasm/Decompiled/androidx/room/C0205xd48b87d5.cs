namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "invoke", "(Landroidx/sqlite/db/SupportSQLiteDatabase;)Ljava/lang/long;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0205xd48b87d5 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.long> {
    readonly long $numbytes;

    C0205xd48b87d5(long j) {
        super(1);
        this.$numbytes = j;
    }

    public readonly java.lang.long Invoke2(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((31 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        return java.lang.long.valueOf(db.setMaximumSize(this.$numbytes));
    }

    public override java.lang.long Invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }
}

