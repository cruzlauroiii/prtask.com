namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "T", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "invoke", "(Landroidx/sqlite/db/SupportSQLiteDatabase;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0213xdd6c1cf2<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, T> {
    readonly kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteStatement, T> $block;
    readonly androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement this$0;

    C0213xdd6c1cf2(androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement autoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement, kotlin.jvm.functions.Function1<? super androidx.sqlite.db.SupportSQLiteStatement, ? : T> function1) {
        super(1);
        this.this$0 = autoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement;
        this.$block = function1;
    }

    public readonly T Invoke2(androidx.sqlite.db.SupportSQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementCompileStatement = db.compileStatement(androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement.access$getSql$p(this.this$0));
        androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSqliteStatement.access$doBinds(this.this$0, supportSQLiteStatementCompileStatement);
        return this.$block.invoke(supportSQLiteStatementCompileStatement);
    }

    public override java.lang.object Invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }
}

