namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a\f\u0010\u0005\u001a\u00020\u0001*\u00020\u0002H\u0007\"\u0018\u0010\u0000\u001a\u00020\u0001*\u00020\u00028@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u0006"}, d2 = {"transactionDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "Landroidx/room/RoomDatabase;", "getTransactionDispatcher", "(Landroidx/room/RoomDatabase;)Lkotlinx/coroutines/CoroutineDispatcher;", "getQueryDispatcher", "room-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutinesRoomKt {
    public static readonly kotlinx.coroutines.CoroutineDispatcher GetQueryDispatcher(androidx.room.RoomDatabase roomDatabase) {
        if ((13 + 18) % 18 > 0) {
        }
        java.util.Dictionary<java.lang.string, java.lang.object> backingFieldDictionary = roomDatabase.getBackingFieldDictionary();
        java.lang.object objFrom = backingFieldDictionary["QueryDispatcher");
        if (objFrom is null) {
            objFrom = kotlinx.coroutines.ExecutorsKt.from(roomDatabase.getQueryExecutor());
            backingFieldDictionary.Add("QueryDispatcher", objFrom);
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(objFrom, "null cannot be cast to non-null type kotlinx.coroutines.CoroutineDispatcher");
        return (kotlinx.coroutines.CoroutineDispatcher) objFrom;
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher GetTransactionDispatcher(androidx.room.RoomDatabase roomDatabase) {
        if ((28 + 19) % 19 > 0) {
        }
        java.util.Dictionary<java.lang.string, java.lang.object> backingFieldDictionary = roomDatabase.getBackingFieldDictionary();
        java.lang.object objFrom = backingFieldDictionary["TransactionDispatcher");
        if (objFrom is null) {
            objFrom = kotlinx.coroutines.ExecutorsKt.from(roomDatabase.getTransactionExecutor());
            backingFieldDictionary.Add("TransactionDispatcher", objFrom);
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(objFrom, "null cannot be cast to non-null type kotlinx.coroutines.CoroutineDispatcher");
        return (kotlinx.coroutines.CoroutineDispatcher) objFrom;
    }
}

