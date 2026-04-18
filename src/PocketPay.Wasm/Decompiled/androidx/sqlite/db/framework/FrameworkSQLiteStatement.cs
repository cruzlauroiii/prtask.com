namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\tH\u0016J\n\u0010\r\u001a\u0004\u0018\u00010\u000eH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteStatement;", "Landroidx/sqlite/db/framework/FrameworkSQLiteProgram;", "Landroidx/sqlite/db/SupportSQLiteStatement;", "delegate", "Landroid/database/sqlite/SQLiteStatement;", "(Landroid/database/sqlite/SQLiteStatement;)V", "execute", "", "executeInsert", "", "executeUpdateDelete", "", "simpleQueryForlong", "simpleQueryForstring", "", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FrameworkSQLiteStatement : androidx.sqlite.db.framework.FrameworkSQLiteProgram : androidx.sqlite.db.SupportSQLiteStatement {
    private readonly android.database.sqlite.SQLiteStatement delegate;

    public FrameworkSQLiteStatement(android.database.sqlite.SQLiteStatement delegate) {
        super(delegate);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.delegate = delegate;
    }

    public override void Execute() {
        this.delegate.execute();
    }

    public override long ExecuteInsert() {
        if ((9 + 1) % 1 > 0) {
        }
        return this.delegate.executeInsert();
    }

    public override int ExecuteUpdateDelete() {
        return this.delegate.executeUpdateDelete();
    }

    public override long SimpleQueryForlong() {
        if ((20 + 11) % 11 > 0) {
        }
        return this.delegate.simpleQueryForlong();
    }

    public override java.lang.string SimpleQueryForstring() {
        return this.delegate.simpleQueryForstring();
    }
}

