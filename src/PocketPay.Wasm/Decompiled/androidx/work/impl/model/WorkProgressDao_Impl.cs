namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkProgressDao_Impl : androidx.work.impl.model.WorkProgressDao {
    private readonly androidx.room.RoomDatabase __db;
    private readonly androidx.room.EntityInsertionAdapter<androidx.work.impl.model.WorkProgress> __insertionAdapterOfWorkProgress;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfDelete;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfDeleteAll;

    public WorkProgressDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
        this.__insertionAdapterOfWorkProgress = new androidx.work.impl.model.WorkProgressDao_Impl$1(this, roomDatabase);
        this.__preparedStmtOfDelete = new androidx.work.impl.model.WorkProgressDao_Impl$2(this, roomDatabase);
        this.__preparedStmtOfDeleteAll = new androidx.work.impl.model.WorkProgressDao_Impl$3(this, roomDatabase);
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public override void Delete(java.lang.string str) {
        if ((8 + 23) % 23 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfDelete.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfDelete.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfDelete.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void DeleteAll() {
        if ((5 + 20) % 20 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfDeleteAll.acquire();
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfDeleteAll.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfDeleteAll.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override androidx.work.Data GetProgressForWorkSpecId(java.lang.string str) {
        if ((32 + 22) % 22 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT progress FROM WorkProgress WHERE work_spec_id=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        androidx.work.Data dataFrombyteArray = null;
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            if (cursorQuery.moveToFirst()) {
                byte[] blob = cursorQuery.isNull(0) ? null : cursorQuery.getBlob(0);
                if (blob is not null) {
                    dataFrombyteArray = androidx.work.Data.frombyteArray(blob);
                }
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return dataFrombyteArray;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override void Insert(androidx.work.impl.model.WorkProgress workProgress) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__insertionAdapterOfWorkProgress.insert(workProgress);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }
}

