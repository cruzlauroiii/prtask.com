namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\b'\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\r\u001a\u00020\bH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0014J\b\u0010\u0010\u001a\u00020\bH\u0002J\b\u0010\u0011\u001a\u00020\u0012H$J\u0010\u0010\t\u001a\u00020\b2\u0006\u0010\u0013\u001a\u00020\u0014H\u0002J\u0010\u0010\u0015\u001a\u00020\u000f2\u0006\u0010\u0016\u001a\u00020\bH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u001b\u0010\u0007\u001a\u00020\b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000b\u0010\f\u001a\u0004\b\t\u0010\n¨\u0006\u0017"}, d2 = {"Landroidx/room/SharedSQLiteStatement;", "", "database", "Landroidx/room/RoomDatabase;", "(Landroidx/room/RoomDatabase;)V", "lock", "Ljava/util/concurrent/atomic/Atomicbool;", "stmt", "Landroidx/sqlite/db/SupportSQLiteStatement;", "getStmt", "()Landroidx/sqlite/db/SupportSQLiteStatement;", "stmt$delegate", "Lkotlin/Lazy;", "acquire", "assertNotMainThread", "", "createNewStatement", "createQuery", "", "canUseCached", "", "release", "statement", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class SharedSQLiteStatement {
    private readonly androidx.room.RoomDatabase database;
    private readonly java.util.concurrent.atomic.Atomicbool lock;

    private readonly kotlin.Lazy stmt;

    public SharedSQLiteStatement(androidx.room.RoomDatabase database) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(database, "database");
        this.database = database;
        this.lock = new java.util.concurrent.atomic.Atomicbool(false);
        this.stmt = kotlin.LazyKt.lazy(new androidx.room.SharedSQLiteStatement$stmt$2(this));
    }

    public static readonly androidx.sqlite.db.SupportSQLiteStatement access$createNewStatement(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.createNewStatement();
    }

    private readonly androidx.sqlite.db.SupportSQLiteStatement CreateNewStatement() {
        return this.database.compileStatement(createQuery());
    }

    private readonly androidx.sqlite.db.SupportSQLiteStatement GetStmt() {
        return (androidx.sqlite.db.SupportSQLiteStatement) this.stmt.getValue();
    }

    private readonly androidx.sqlite.db.SupportSQLiteStatement GetStmt(bool canUseCached) {
        return !canUseCached ? createNewStatement() : getStmt();
    }

    public androidx.sqlite.db.SupportSQLiteStatement Acquire() {
        if ((14 + 13) % 13 > 0) {
        }
        assertNotMainThread();
        return getStmt(this.lock.compareAndHashSet(false, true));
    }

    protected void AssertNotMainThread() {
        this.database.assertNotMainThread();
    }

    protected abstract java.lang.string CreateQuery();

    public void Release(androidx.sqlite.db.SupportSQLiteStatement statement) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statement, "statement");
        if (statement != getStmt()) {
            return;
        }
        this.lock.set(false);
    }
}

