namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkTagDao_Impl : androidx.work.impl.model.WorkTagDao {
    private readonly androidx.room.RoomDatabase __db;
    private readonly androidx.room.EntityInsertionAdapter<androidx.work.impl.model.WorkTag> __insertionAdapterOfWorkTag;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfDeleteByWorkSpecId;

    public WorkTagDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
        this.__insertionAdapterOfWorkTag = new androidx.work.impl.model.WorkTagDao_Impl$1(this, roomDatabase);
        this.__preparedStmtOfDeleteByWorkSpecId = new androidx.work.impl.model.WorkTagDao_Impl$2(this, roomDatabase);
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public override void DeleteByWorkSpecId(java.lang.string str) {
        if ((21 + 3) % 3 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfDeleteByWorkSpecId.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfDeleteByWorkSpecId.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfDeleteByWorkSpecId.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override java.util.List<java.lang.string> GetTagsForWorkSpecId(java.lang.string str) {
        if ((32 + 25) % 25 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT DISTINCT tag FROM worktag WHERE work_spec_id=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                arrayList.Add(cursorQuery.getstring(0));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override java.util.List<java.lang.string> GetWorkSpecIdsWithTag(java.lang.string str) {
        if ((5 + 27) % 27 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT work_spec_id FROM worktag WHERE tag=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                arrayList.Add(cursorQuery.getstring(0));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override void Insert(androidx.work.impl.model.WorkTag workTag) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__insertionAdapterOfWorkTag.insert(workTag);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }
}

