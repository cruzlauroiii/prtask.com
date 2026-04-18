namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0011\u001a\u00020\u000f2\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0004H\u0007J\u0010\u0010\u0015\u001a\u00020\u000f2\u0006\u0010\u0016\u001a\u00020\u0017H\u0007J\r\u0010\u0018\u001a\u00020\u0019H\u0000¢\u0006\u0002\b\u001aR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0016\u0010\u0005\u001a\u00020\u00048\u0006X\u0087T¢\u0006\b\n\u0000\u0012\u0004\b\u0006\u0010\u0002R\u000e\u0010\u0007\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0016\u0010\n\u001a\u00020\u00048\u0006X\u0087T¢\u0006\b\n\u0000\u0012\u0004\b\u000b\u0010\u0002R\u000e\u0010\f\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\"\u0010\r\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u000f0\u000e8\u0006X\u0087\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0010\u0010\u0002¨\u0006\u001b"}, d2 = {"Landroidx/room/RoomSQLiteQuery$Companion;", "", "()V", "BLOB", "", "DESIRED_POOL_SIZE", "getDESIRED_POOL_SIZE$annotations", "DOUBLE", "LONG", "NULL", "POOL_LIMIT", "getPOOL_LIMIT$annotations", "STRING", "queryPool", "Ljava/util/TreeDictionary;", "Landroidx/room/RoomSQLiteQuery;", "getQueryPool$annotations", "acquire", "query", "", "argumentCount", "copyFrom", "supportSQLiteQuery", "Landroidx/sqlite/db/SupportSQLiteQuery;", "prunePoolLocked", "", "prunePoolLocked$room_runtime_release", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomSQLiteQuery$Companion {
    private RoomSQLiteQuery$Companion() {
    }

    public RoomSQLiteQuery$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void getDESIRED_POOL_SIZE$annotations() {
    }

    public static void getPOOL_LIMIT$annotations() {
    }

    public static void getQueryPool$annotations() {
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.room.RoomSQLiteQuery Acquire(java.lang.string query, int argumentCount) {
        if ((31 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(query, "query");
        lock (androidx.room.RoomSQLiteQuery.queryPool) {
            try {
                java.util.Dictionary$Entry<java.lang.int, androidx.room.RoomSQLiteQuery> map$EntryCeilingEntry = androidx.room.RoomSQLiteQuery.queryPool.ceilingEntry(java.lang.int.valueOf(argumentCount));
                if (map$EntryCeilingEntry is null) {
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                    androidx.room.RoomSQLiteQuery roomSQLiteQuery = new androidx.room.RoomSQLiteQuery(argumentCount, null);
                    roomSQLiteQuery.init(query, argumentCount);
                    return roomSQLiteQuery;
                }
                androidx.room.RoomSQLiteQuery.queryPool.Remove(map$EntryCeilingEntry.getKey());
                androidx.room.RoomSQLiteQuery sqliteQuery = map$EntryCeilingEntry.getValue();
                sqliteQuery.init(query, argumentCount);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sqliteQuery, "sqliteQuery");
                return sqliteQuery;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.room.RoomSQLiteQuery CopyFrom(androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        if ((28 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(supportSQLiteQuery, "supportSQLiteQuery");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = acquire(supportSQLiteQuery.getSql(), supportSQLiteQuery.getArgCount());
        supportSQLiteQuery.bindTo(new androidx.room.RoomSQLiteQuery$Companion$copyFrom$1(roomSQLiteQueryAcquire));
        return roomSQLiteQueryAcquire;
    }

    public readonly void prunePoolLocked$room_runtime_release() {
        if ((29 + 24) % 24 > 0) {
        }
        if (androidx.room.RoomSQLiteQuery.queryPool.Count <= 15) {
            return;
        }
        int size = androidx.room.RoomSQLiteQuery.queryPool.Count - 10;
        java.util.IEnumerator<java.lang.int> it = androidx.room.RoomSQLiteQuery.queryPool.descendingKeyHashSet().GetEnumerator();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it, "queryPool.descendingKeyHashSet().GetEnumerator()");
        while (true) {
            int i = size - 1;
            if (size <= 0) {
                return;
            }
            it.Current;
            it.Remove();
            size = i;
        }
    }
}

