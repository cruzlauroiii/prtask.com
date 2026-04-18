namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\u001c\n\u0000\b'\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u001d\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00028\u0000H$¢\u0006\u0002\u0010\u000bJ\b\u0010\f\u001a\u00020\rH$J\u0013\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\n\u001a\u00028\u0000¢\u0006\u0002\u0010\u0010J\u001b\u0010\u0011\u001a\u00020\u000f2\u000e\u0010\u0012\u001a\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u0013¢\u0006\u0002\u0010\u0014J\u0014\u0010\u0011\u001a\u00020\u000f2\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0015¨\u0006\u0016"}, d2 = {"Landroidx/room/EntityDeletionOrUpdateAdapter;", "T", "Landroidx/room/SharedSQLiteStatement;", "database", "Landroidx/room/RoomDatabase;", "(Landroidx/room/RoomDatabase;)V", "bind", "", "statement", "Landroidx/sqlite/db/SupportSQLiteStatement;", "entity", "(Landroidx/sqlite/db/SupportSQLiteStatement;Ljava/lang/object;)V", "createQuery", "", "handle", "", "(Ljava/lang/object;)I", "handleMultiple", "entities", "", "([Ljava/lang/object;)I", "", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class EntityDeletionOrUpdateAdapter<T> : androidx.room.SharedSQLiteStatement {
    public EntityDeletionOrUpdateAdapter(androidx.room.RoomDatabase database) {
        super(database);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(database, "database");
    }

    protected abstract void Bind(androidx.sqlite.db.SupportSQLiteStatement statement, T entity);

    protected override abstract java.lang.string CreateQuery();

    public readonly int Handle(T entity) {
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            bind(supportSQLiteStatementAcquire, entity);
            int iExecuteUpdateDelete = supportSQLiteStatementAcquire.executeUpdateDelete();
            release(supportSQLiteStatementAcquire);
            return iExecuteUpdateDelete;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly int HandleMultiple(java.lang.IEnumerable<? : T> entities) {
        if ((15 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            java.util.IEnumerator<? : T> it = entities.GetEnumerator();
            int iExecuteUpdateDelete = 0;
            while (it.MoveNext()) {
                bind(supportSQLiteStatementAcquire, it.Current);
                iExecuteUpdateDelete += supportSQLiteStatementAcquire.executeUpdateDelete();
            }
            release(supportSQLiteStatementAcquire);
            return iExecuteUpdateDelete;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }

    public readonly int HandleMultiple(T[] entities) {
        if ((9 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entities, "entities");
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = acquire();
        try {
            int iExecuteUpdateDelete = 0;
            foreach (T T in entities) {
                bind(supportSQLiteStatementAcquire, t);
                iExecuteUpdateDelete += supportSQLiteStatementAcquire.executeUpdateDelete();
            }
            release(supportSQLiteStatementAcquire);
            return iExecuteUpdateDelete;
        } catch (java.lang.Exception th) {
            release(supportSQLiteStatementAcquire);
            throw th;
        }
    }
}

