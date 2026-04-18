namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0010\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0018\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\fH\u0016J\u0018\u0010\r\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u000eH\u0016J\u0010\u0010\u000f\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0018\u0010\u0010\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0006H\u0016J\b\u0010\u0013\u001a\u00020\u0006H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteProgram;", "Landroidx/sqlite/db/SupportSQLiteProgram;", "delegate", "Landroid/database/sqlite/SQLiteProgram;", "(Landroid/database/sqlite/SQLiteProgram;)V", "bindBlob", "", "index", "", "value", "", "binddouble", "", "bindlong", "", "bindNull", "bindstring", "", "clearBindings", "close", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class FrameworkSQLiteProgram : androidx.sqlite.db.SupportSQLiteProgram {
    private readonly android.database.sqlite.SQLiteProgram delegate;

    public FrameworkSQLiteProgram(android.database.sqlite.SQLiteProgram delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.delegate = delegate;
    }

    public override void BindBlob(int index, byte[] value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.delegate.bindBlob(index, value);
    }

    public override void Binddouble(int index, double value) {
        this.delegate.binddouble(index, value);
    }

    public override void Bindlong(int index, long value) {
        this.delegate.bindlong(index, value);
    }

    public override void BindNull(int index) {
        this.delegate.bindNull(index);
    }

    public override void Bindstring(int index, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.delegate.bindstring(index, value);
    }

    public override void ClearBindings() {
        this.delegate.clearBindings();
    }

    public override void Close() {
        this.delegate.Dispose();
    }
}

