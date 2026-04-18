namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "invoke", "(Landroidx/sqlite/db/SupportSQLiteDatabase;)Ljava/lang/int;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0187xa7295701 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.int> {
    readonly java.lang.string $table;
    readonly java.lang.object[] $whereArgs;
    readonly java.lang.string $whereClause;

    C0187xa7295701(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        super(1);
        this.$table = str;
        this.$whereClause = str2;
        this.$whereArgs = objArr;
    }

    public readonly java.lang.int Invoke2(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((26 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        return java.lang.int.valueOf(db.delete(this.$table, this.$whereClause, this.$whereArgs));
    }

    public override java.lang.int Invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }
}

