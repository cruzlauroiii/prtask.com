namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Landroidx/sqlite/db/SupportSQLiteStatement;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class SharedSQLiteStatement$stmt$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.sqlite.db.SupportSQLiteStatement> {
    readonly androidx.room.SharedSQLiteStatement this$0;

    SharedSQLiteStatement$stmt$2(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        super(0);
        this.this$0 = sharedSQLiteStatement;
    }

    public override readonly androidx.sqlite.db.SupportSQLiteStatement Invoke() {
        return androidx.room.SharedSQLiteStatement.access$createNewStatement(this.this$0);
    }

    public override androidx.sqlite.db.SupportSQLiteStatement Invoke() {
        return invoke();
    }
}

