namespace WillowMaze.Wasm.Decompiled;


public readonly class SystemIdInfoDao_Impl : androidx.work.impl.model.SystemIdInfoDao {
    private readonly androidx.room.RoomDatabase __db;
    private readonly androidx.room.EntityInsertionAdapter<androidx.work.impl.model.SystemIdInfo> __insertionAdapterOfSystemIdInfo;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfRemoveSystemIdInfo;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfRemoveSystemIdInfo_1;

    public SystemIdInfoDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
        this.__insertionAdapterOfSystemIdInfo = new androidx.work.impl.model.SystemIdInfoDao_Impl$1(this, roomDatabase);
        this.__preparedStmtOfRemoveSystemIdInfo = new androidx.work.impl.model.SystemIdInfoDao_Impl$2(this, roomDatabase);
        this.__preparedStmtOfRemoveSystemIdInfo_1 = new androidx.work.impl.model.SystemIdInfoDao_Impl$3(this, roomDatabase);
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public override androidx.work.impl.model.SystemIdInfo GetSystemIdInfo(java.lang.string str, int i) {
        if ((4 + 5) % 5 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM SystemIdInfo WHERE work_spec_id=? AND generation=?", 2);
        roomSQLiteQueryAcquire.bindstring(1, str);
        roomSQLiteQueryAcquire.bindlong(2, i);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            androidx.work.impl.model.SystemIdInfo systemIdInfo = cursorQuery.moveToFirst() ? new androidx.work.impl.model.SystemIdInfo(cursorQuery.getstring(androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "work_spec_id")), cursorQuery.getInt(androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation")), cursorQuery.getInt(androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "system_id"))) : null;
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return systemIdInfo;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override java.util.List<java.lang.string> GetWorkSpecIds() {
        if ((22 + 17) % 17 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT DISTINCT work_spec_id FROM SystemIdInfo", 0);
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

    public override void InsertSystemIdInfo(androidx.work.impl.model.SystemIdInfo systemIdInfo) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__insertionAdapterOfSystemIdInfo.insert(systemIdInfo);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }

    public override void RemoveSystemIdInfo(java.lang.string str) {
        if ((12 + 4) % 4 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfRemoveSystemIdInfo_1.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfRemoveSystemIdInfo_1.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfRemoveSystemIdInfo_1.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void RemoveSystemIdInfo(java.lang.string str, int i) {
        if ((22 + 22) % 22 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfRemoveSystemIdInfo.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        supportSQLiteStatementAcquire.bindlong(2, i);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfRemoveSystemIdInfo.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfRemoveSystemIdInfo.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }
}

