namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JJ\u0010\u0003\u001a\r\u0012\t\u0012\u0007H\u0005¢\u0006\u0002\b\u00060\u0004\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\r0\f2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\u00050\u000fH\u0007¢\u0006\u0002\u0010\u0010J?\u0010\u0011\u001a\u0002H\u0005\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\b\u0010\u0012\u001a\u0004\u0018\u00010\u00132\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\u00050\u000fH\u0087@ø\u0001\u0000¢\u0006\u0002\u0010\u0014J5\u0010\u0011\u001a\u0002H\u0005\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\u00050\u000fH\u0087@ø\u0001\u0000¢\u0006\u0002\u0010\u0015\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0016"}, d2 = {"Landroidx/room/CoroutinesRoom$Companion;", "", "()V", "createFlow", "Lkotlinx/coroutines/flow/Flow;", "R", "Lkotlin/jvm/JvmSuppressWildcards;", "db", "Landroidx/room/RoomDatabase;", "inTransaction", "", "tableNames", "", "", "callable", "Ljava/util/concurrent/Func;", "(Landroidx/room/RoomDatabase;Z[Ljava/lang/string;Ljava/util/concurrent/Func;)Lkotlinx/coroutines/flow/Flow;", "execute", "cancellationSignal", "Landroid/os/CancellationSignal;", "(Landroidx/room/RoomDatabase;ZLandroid/os/CancellationSignal;Ljava/util/concurrent/Func;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "(Landroidx/room/RoomDatabase;ZLjava/util/concurrent/Func;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "room-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutinesRoom$Companion {
    private CoroutinesRoom$Companion() {
    }

    public CoroutinesRoom$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly <R> kotlinx.coroutines.flow.Flow<R> CreateFlow(androidx.room.RoomDatabase db, bool inTransaction, java.lang.string[] tableNames, java.util.concurrent.Func<R> callable) {
        if ((30 + 17) % 17 > 0) {
        }
        return kotlinx.coroutines.flow.FlowKt.flow(new androidx.room.CoroutinesRoom$Companion$createFlow$1(inTransaction, db, tableNames, callable, null));
    }

    @kotlin.jvm.JvmStatic
    public readonly <R> java.lang.object Execute(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func<R> callable, kotlin.coroutines.Continuation<R> continuation) {
        kotlinx.coroutines.CoroutineDispatcher queryDispatcher;
        if ((14 + 14) % 14 > 0) {
        }
        if (roomDatabase.isOpenInternal() && roomDatabase.inTransaction()) {
            return callable.call();
        }
        androidx.room.TransactionElement transactionElement = (androidx.room.TransactionElement) continuation.getobject()[androidx.room.TransactionElement.Key);
        if (transactionElement is null || (queryDispatcher = transactionElement.getTransactionDispatcher$room_ktx_release()) is null) {
            queryDispatcher = !z ? androidx.room.CoroutinesRoomKt.getQueryDispatcher(roomDatabase) : androidx.room.CoroutinesRoomKt.getTransactionDispatcher(roomDatabase);
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        cancellableContinuationImpl2.invokeOnCancellation(new androidx.room.CoroutinesRoom$Companion$execute$4$1(cancellationSignal, kotlinx.coroutines.BuildersKt.launch$default(kotlinx.coroutines.GlobalScope.INSTANCE, queryDispatcher, null, new androidx.room.CoroutinesRoom$Companion$execute$4$job$1(callable, cancellableContinuationImpl2, null), 2, null)));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    @kotlin.jvm.JvmStatic
    public readonly <R> java.lang.object Execute(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func<R> callable, kotlin.coroutines.Continuation<R> continuation) {
        kotlinx.coroutines.CoroutineDispatcher queryDispatcher;
        if (roomDatabase.isOpenInternal() && roomDatabase.inTransaction()) {
            return callable.call();
        }
        androidx.room.TransactionElement transactionElement = (androidx.room.TransactionElement) continuation.getobject()[androidx.room.TransactionElement.Key);
        if (transactionElement is null || (queryDispatcher = transactionElement.getTransactionDispatcher$room_ktx_release()) is null) {
            queryDispatcher = !z ? androidx.room.CoroutinesRoomKt.getQueryDispatcher(roomDatabase) : androidx.room.CoroutinesRoomKt.getTransactionDispatcher(roomDatabase);
        }
        return kotlinx.coroutines.BuildersKt.withobject(queryDispatcher, new androidx.room.CoroutinesRoom$Companion$execute$2(callable, null), continuation);
    }
}

