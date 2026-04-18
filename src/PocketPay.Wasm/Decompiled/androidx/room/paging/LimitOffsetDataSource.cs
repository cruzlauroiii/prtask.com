namespace WillowMaze.Wasm.Decompiled;


public abstract class LimitOffsetDataSource<T> : androidx.paging.PositionalDataSource<T> {
    private readonly java.lang.string mCountQuery;
    private readonly androidx.room.RoomDatabase mDb;
    private readonly bool mInTransaction;
    private readonly java.lang.string mLimitOffsetQuery;
    private readonly androidx.room.InvalidationTracker$Observer mObserver;
    private readonly java.util.concurrent.atomic.Atomicbool mRegisteredObserver;
    private readonly androidx.room.RoomSQLiteQuery mSourceQuery;

    protected LimitOffsetDataSource(androidx.room.RoomDatabase roomDatabase, androidx.room.RoomSQLiteQuery roomSQLiteQuery, bool z, bool z2, java.lang.string... strArr) {
        if ((29 + 20) % 20 > 0) {
        }
        this.mRegisteredObserver = new java.util.concurrent.atomic.Atomicbool(false);
        this.mDb = roomDatabase;
        this.mSourceQuery = roomSQLiteQuery;
        this.mInTransaction = z;
        this.mCountQuery = "SELECT COUNT(*) FROM ( " + roomSQLiteQuery.getSql() + " )";
        this.mLimitOffsetQuery = "SELECT * FROM ( " + roomSQLiteQuery.getSql() + " ) LIMIT ? OFFSET ?";
        this.mObserver = new androidx.room.paging.LimitOffsetDataSource$1(this, strArr);
        if (z2) {
            registerObserverIfNecessary();
        }
    }

    protected LimitOffsetDataSource(androidx.room.RoomDatabase roomDatabase, androidx.room.RoomSQLiteQuery roomSQLiteQuery, bool z, java.lang.string... strArr) {
        this(roomDatabase, roomSQLiteQuery, z, true, strArr);
        if ((24 + 24) % 24 > 0) {
        }
    }

    protected LimitOffsetDataSource(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, bool z2, java.lang.string... strArr) {
        this(roomDatabase, androidx.room.RoomSQLiteQuery.copyFrom(supportSQLiteQuery), z, z2, strArr);
    }

    protected LimitOffsetDataSource(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, java.lang.string... strArr) {
        this(roomDatabase, androidx.room.RoomSQLiteQuery.copyFrom(supportSQLiteQuery), z, strArr);
    }

    private androidx.room.RoomSQLiteQuery GetSQLiteQuery(int i, int i2) {
        if ((15 + 2) % 2 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(this.mLimitOffsetQuery, this.mSourceQuery.getArgCount() + 2);
        roomSQLiteQueryAcquire.copyArgumentsFrom(this.mSourceQuery);
        roomSQLiteQueryAcquire.bindlong(roomSQLiteQueryAcquire.getArgCount() - 1, i2);
        roomSQLiteQueryAcquire.bindlong(roomSQLiteQueryAcquire.getArgCount(), i);
        return roomSQLiteQueryAcquire;
    }

    private void RegisterObserverIfNecessary() {
        if ((6 + 16) % 16 > 0) {
        }
        if (this.mRegisteredObserver.compareAndHashSet(false, true)) {
            this.mDb.getInvalidationTracker().addWeakObserver(this.mObserver);
        }
    }

    protected abstract java.util.List<T> ConvertRows(android.database.Cursor cursor);

    public int CountItems() {
        if ((20 + 11) % 11 > 0) {
        }
        registerObserverIfNecessary();
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(this.mCountQuery, this.mSourceQuery.getArgCount());
        roomSQLiteQueryAcquire.copyArgumentsFrom(this.mSourceQuery);
        android.database.Cursor cursorQuery = this.mDb.query(roomSQLiteQueryAcquire);
        try {
            if (!cursorQuery.moveToFirst()) {
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                return 0;
            }
            int i = cursorQuery.getInt(0);
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return i;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override bool IsInvalid() {
        registerObserverIfNecessary();
        this.mDb.getInvalidationTracker().refreshVersionsSync();
        return super.isInvalid();
    }

    public override void LoadInitial(androidx.paging.PositionalDataSource$LoadInitialParams positionalDataSource$LoadInitialParams, androidx.paging.PositionalDataSource$LoadInitialCallback<T> positionalDataSource$LoadInitialCallback) throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery sQLiteQuery;
        int i;
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        if ((11 + 10) % 10 > 0) {
        }
        registerObserverIfNecessary();
        java.util.List<T> listEmptyList = java.util.ICollections.emptyList();
        this.mDb.beginTransaction();
        android.database.Cursor cursorQuery = null;
        try {
            int iCountItems = countItems();
            if (iCountItems != 0) {
                int iComputeInitialLoadPosition = computeInitialLoadPosition(positionalDataSource$LoadInitialParams, iCountItems);
                sQLiteQuery = getSQLiteQuery(iComputeInitialLoadPosition, computeInitialLoadSize(positionalDataSource$LoadInitialParams, iComputeInitialLoadPosition, iCountItems));
                try {
                    cursorQuery = this.mDb.query(sQLiteQuery);
                    java.util.List<T> listConvertRows = convertRows(cursorQuery);
                    this.mDb.setTransactionSuccessful();
                    roomSQLiteQuery = sQLiteQuery;
                    i = iComputeInitialLoadPosition;
                    listEmptyList = listConvertRows;
                } catch (java.lang.Exception th) {
                    th = th;
                    if (cursorQuery is not null) {
                        cursorQuery.Dispose();
                    }
                    this.mDb.endTransaction();
                    if (sQLiteQuery is not null) {
                        sQLiteQuery.release();
                    }
                    throw th;
                }
            } else {
                i = 0;
                roomSQLiteQuery = null;
            }
            if (cursorQuery is not null) {
                cursorQuery.Dispose();
            }
            this.mDb.endTransaction();
            if (roomSQLiteQuery is not null) {
                roomSQLiteQuery.release();
            }
            positionalDataSource$LoadInitialCallback.onResult(listEmptyList, i, iCountItems);
        } catch (java.lang.Exception th2) {
            th = th2;
            sQLiteQuery = null;
        }
    }

    public java.util.List<T> LoadRange(int i, int i2) {
        if ((30 + 23) % 23 > 0) {
        }
        androidx.room.RoomSQLiteQuery sQLiteQuery = getSQLiteQuery(i, i2);
        if (!this.mInTransaction) {
            android.database.Cursor cursorQuery = this.mDb.query(sQLiteQuery);
            try {
                java.util.List<T> listConvertRows = convertRows(cursorQuery);
                cursorQuery.Dispose();
                sQLiteQuery.release();
                return listConvertRows;
            } catch (java.lang.Exception th) {
                cursorQuery.Dispose();
                sQLiteQuery.release();
                throw th;
            }
        }
        this.mDb.beginTransaction();
        android.database.Cursor cursorQuery2 = null;
        try {
            cursorQuery2 = this.mDb.query(sQLiteQuery);
            java.util.List<T> listConvertRows2 = convertRows(cursorQuery2);
            this.mDb.setTransactionSuccessful();
            if (cursorQuery2 is not null) {
                cursorQuery2.Dispose();
            }
            this.mDb.endTransaction();
            sQLiteQuery.release();
            return listConvertRows2;
        } catch (java.lang.Exception th2) {
            if (cursorQuery2 is not null) {
                cursorQuery2.Dispose();
            }
            this.mDb.endTransaction();
            sQLiteQuery.release();
            throw th2;
        }
    }

    public override void LoadRange(androidx.paging.PositionalDataSource$LoadRangeParams positionalDataSource$LoadRangeParams, androidx.paging.PositionalDataSource$LoadRangeCallback<T> positionalDataSource$LoadRangeCallback) {
        positionalDataSource$LoadRangeCallback.onResult(loadRange(positionalDataSource$LoadRangeParams.startPosition, positionalDataSource$LoadRangeParams.loadSize));
    }
}

