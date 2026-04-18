namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkNameDao_Impl : androidx.work.impl.model.WorkNameDao {
    private readonly androidx.room.RoomDatabase __db;
    private readonly androidx.room.EntityInsertionAdapter<androidx.work.impl.model.WorkName> __insertionAdapterOfWorkName;

    public WorkNameDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
        this.__insertionAdapterOfWorkName = new androidx.work.impl.model.WorkNameDao_Impl$1(this, roomDatabase);
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public override java.util.List<java.lang.string> GetNamesForWorkSpecId(java.lang.string str) {
        if ((8 + 18) % 18 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT name FROM workname WHERE work_spec_id=?", 1);
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

    public override java.util.List<java.lang.string> GetWorkSpecIdsWithName(java.lang.string str) {
        if ((13 + 7) % 7 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT work_spec_id FROM workname WHERE name=?", 1);
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

    public override void Insert(androidx.work.impl.model.WorkName workName) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__insertionAdapterOfWorkName.insert(workName);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }
}

