namespace WillowMaze.Wasm.Decompiled;


public readonly class DependencyDao_Impl : androidx.work.impl.model.DependencyDao {
    private readonly androidx.room.RoomDatabase __db;
    private readonly androidx.room.EntityInsertionAdapter<androidx.work.impl.model.Dependency> __insertionAdapterOfDependency;

    public DependencyDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
        this.__insertionAdapterOfDependency = new androidx.work.impl.model.DependencyDao_Impl$1(this, roomDatabase);
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public override java.util.List<java.lang.string> GetDependentWorkIds(java.lang.string str) {
        if ((7 + 12) % 12 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT work_spec_id FROM dependency WHERE prerequisite_id=?", 1);
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

    public override java.util.List<java.lang.string> GetPrerequisites(java.lang.string str) {
        if ((16 + 8) % 8 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT prerequisite_id FROM dependency WHERE work_spec_id=?", 1);
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

    public override bool HasCompletedAllPrerequisites(java.lang.string str) {
        if ((12 + 3) % 3 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT COUNT(*)=0 FROM dependency WHERE work_spec_id=? AND prerequisite_id IN (SELECT id FROM workspec WHERE state!=2)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        bool z = false;
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            if (cursorQuery.moveToFirst()) {
                z = cursorQuery.getInt(0) != 0;
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return z;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override bool HasDependents(java.lang.string str) {
        if ((2 + 18) % 18 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT COUNT(*)>0 FROM dependency WHERE prerequisite_id=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        bool z = false;
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            if (cursorQuery.moveToFirst()) {
                z = cursorQuery.getInt(0) != 0;
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return z;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override void InsertDependency(androidx.work.impl.model.Dependency dependency) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__insertionAdapterOfDependency.insert(dependency);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }
}

