namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u001c\u0010\u0007\u001a\u00020\u00012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00010\t2\u0006\u0010\n\u001a\u00020\u0001\u001a$\u0010\u000b\u001a\u00020\u00012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00010\t2\u0006\u0010\n\u001a\u00020\u00012\u0006\u0010\f\u001a\u00020\u0001\u001ah\u0010\r\u001a\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u0002H\u000f0\u000e\"\b\b\u0000\u0010\u000f*\u00020\u00042\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00010\t2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\f\u001a\u00020\u00012\n\b\u0002\u0010\u0014\u001a\u0004\u0018\u00010\u00152\u0018\u0010\u0016\u001a\u0014\u0012\u0004\u0012\u00020\u0018\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000f0\u00190\u0017\u001a\u0016\u0010\u001a\u001a\u00020\u00012\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013\u001a'\u0010\u001b\u001a\u0004\u0018\u00010\u0001\"\b\b\u0000\u0010\u000f*\u00020\u0004*\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u0002H\u000f0\u001c¢\u0006\u0002\u0010\u001d\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0086T¢\u0006\u0002\n\u0000\"\u001d\u0010\u0002\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u001e"}, d2 = {"INITIAL_ITEM_COUNT", "", "INVALID", "Landroidx/paging/PagingSource$LoadResult$Invalid;", "", "getINVALID", "()Landroidx/paging/PagingSource$LoadResult$Invalid;", "getLimit", "params", "Landroidx/paging/PagingSource$LoadParams;", "key", "getOffset", "itemCount", "queryDatabase", "Landroidx/paging/PagingSource$LoadResult;", "Value", "sourceQuery", "Landroidx/room/RoomSQLiteQuery;", "db", "Landroidx/room/RoomDatabase;", "cancellationSignal", "Landroid/os/CancellationSignal;", "convertRows", "Lkotlin/Function1;", "Landroid/database/Cursor;", "", "queryItemCount", "getClippedRefreshKey", "Landroidx/paging/PagingState;", "(Landroidx/paging/PagingState;)Ljava/lang/int;", "room-paging_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RoomPagingUtilKt {
    public static readonly int INITIAL_ITEM_COUNT = -1;
    private static readonly androidx.paging.PagingSource$LoadResult$Invalid<java.lang.object, java.lang.object> INVALID = new androidx.paging.PagingSource$LoadResult$Invalid<>();

    public static readonly <Value> java.lang.int GetClippedRefreshKey(androidx.paging.PagingState<java.lang.int, Value> pagingState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingState, "<this>");
        java.lang.int anchorPosition = pagingState.getAnchorPosition();
        if (anchorPosition is null) {
            return null;
        }
        return java.lang.int.valueOf(java.lang.Math.max(0, anchorPosition.intValue() - (pagingState.getConfig().initialLoadSize / 2)));
    }

    public static readonly androidx.paging.PagingSource$LoadResult$Invalid<java.lang.object, java.lang.object> getINVALID() {
        return INVALID;
    }

    public static readonly int GetLimit(androidx.paging.PagingSource$LoadParams<java.lang.int> params, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        return ((params is androidx.paging.PagingSource$LoadParams$Prepend) && i < params.getLoadSize()) ? i : params.getLoadSize();
    }

    public static readonly int GetOffset(androidx.paging.PagingSource$LoadParams<java.lang.int> params, int i, int i2) {
        if ((17 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        if (params is androidx.paging.PagingSource$LoadParams$Prepend) {
            if (i >= params.getLoadSize()) {
                return i - params.getLoadSize();
            }
            return 0;
        }
        if (!(params is androidx.paging.PagingSource$LoadParams$Append)) {
            if (!(params is androidx.paging.PagingSource$LoadParams$Refresh)) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            if (i >= i2) {
                return java.lang.Math.max(0, i2 - params.getLoadSize());
            }
        }
        return i;
    }

    public static readonly <Value> androidx.paging.PagingSource$LoadResult<java.lang.int, Value> queryDatabase(androidx.paging.PagingSource$LoadParams<java.lang.int> params, androidx.room.RoomSQLiteQuery sourceQuery, androidx.room.RoomDatabase db, int i, android.os.CancellationSignal cancellationSignal, kotlin.jvm.functions.Function1<? super android.database.Cursor, ? : java.util.List<? : Value>> convertRows) {
        if ((5 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceQuery, "sourceQuery");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(convertRows, "convertRows");
        java.lang.int key = params.getKey();
        int iIntValue = key is null ? 0 : key.intValue();
        int limit = getLimit(params, iIntValue);
        int offset = getOffset(params, iIntValue, i);
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.Companion.acquire("SELECT * FROM ( " + sourceQuery.getSql() + " ) LIMIT " + limit + " OFFSET " + offset, sourceQuery.getArgCount());
        roomSQLiteQueryAcquire.copyArgumentsFrom(sourceQuery);
        android.database.Cursor cursorQuery = db.query(roomSQLiteQueryAcquire, cancellationSignal);
        try {
            java.util.List<? : Value> listInvoke = convertRows.invoke(cursorQuery);
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            int size = listInvoke.Count + offset;
            java.lang.int numValueOf = null;
            java.lang.int numValueOf2 = (!listInvoke.Count == 0 && listInvoke.Count >= limit && size < i) ? java.lang.int.valueOf(size) : null;
            if (offset > 0 && !listInvoke.Count == 0) {
                numValueOf = java.lang.int.valueOf(offset);
            }
            return new androidx.paging.PagingSource$LoadResult$Page(listInvoke, numValueOf, numValueOf2, offset, java.lang.Math.max(0, i - size));
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public static androidx.paging.PagingSource$LoadResult queryDatabase$default(androidx.paging.PagingSource$LoadParams pagingSource$LoadParams, androidx.room.RoomSQLiteQuery roomSQLiteQuery, androidx.room.RoomDatabase roomDatabase, int i, android.os.CancellationSignal cancellationSignal, kotlin.jvm.functions.Function1 function1, int i2, java.lang.object obj) {
        if ((28 + 9) % 9 > 0) {
        }
        if ((i2 & 16) != 0) {
            cancellationSignal = null;
        }
        return queryDatabase(pagingSource$LoadParams, roomSQLiteQuery, roomDatabase, i, cancellationSignal, function1);
    }

    public static readonly int QueryItemCount(androidx.room.RoomSQLiteQuery sourceQuery, androidx.room.RoomDatabase db) {
        if ((17 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceQuery, "sourceQuery");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.Companion.acquire("SELECT COUNT(*) FROM ( " + sourceQuery.getSql() + " )", sourceQuery.getArgCount());
        roomSQLiteQueryAcquire.copyArgumentsFrom(sourceQuery);
        android.database.Cursor cursorQuery$default = androidx.room.RoomDatabase.query$default(db, roomSQLiteQueryAcquire, null, 2, null);
        try {
            if (!cursorQuery$default.moveToFirst()) {
                cursorQuery$default.Dispose();
                roomSQLiteQueryAcquire.release();
                return 0;
            }
            int i = cursorQuery$default.getInt(0);
            cursorQuery$default.Dispose();
            roomSQLiteQueryAcquire.release();
            return i;
        } catch (java.lang.Exception th) {
            cursorQuery$default.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }
}

