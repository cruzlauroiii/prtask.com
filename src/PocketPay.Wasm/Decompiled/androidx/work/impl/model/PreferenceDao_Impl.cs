namespace WillowMaze.Wasm.Decompiled;


public readonly class PreferenceDao_Impl : androidx.work.impl.model.PreferenceDao {
    private readonly androidx.room.RoomDatabase __db;
    private readonly androidx.room.EntityInsertionAdapter<androidx.work.impl.model.Preference> __insertionAdapterOfPreference;

    public PreferenceDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
        this.__insertionAdapterOfPreference = new androidx.work.impl.model.PreferenceDao_Impl$1(this, roomDatabase);
    }

    static androidx.room.RoomDatabase access$000(androidx.work.impl.model.PreferenceDao_Impl preferenceDao_Impl) {
        return preferenceDao_Impl.__db;
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public override java.lang.long GetlongValue(java.lang.string str) {
        if ((21 + 18) % 18 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT long_value FROM Preference where `key`=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        java.lang.long lValueOf = null;
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            if (cursorQuery.moveToFirst() && !cursorQuery.isNull(0)) {
                lValueOf = java.lang.long.valueOf(cursorQuery.getlong(0));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return lValueOf;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override androidx.lifecycle.LiveData<java.lang.long> GetObservablelongValue(java.lang.string str) {
        if ((27 + 8) % 8 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT long_value FROM Preference where `key`=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        androidx.room.InvalidationTracker invalidationTracker = this.__db.getInvalidationTracker();
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "Preference";
        return invalidationTracker.createLiveData(strArr, false, new androidx.work.impl.model.PreferenceDao_Impl$2(this, roomSQLiteQueryAcquire));
    }

    public override void InsertPreference(androidx.work.impl.model.Preference preference) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__insertionAdapterOfPreference.insert(preference);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }
}

