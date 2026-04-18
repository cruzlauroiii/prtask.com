namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0014\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0002\u001a9\u0010\u0005\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u00070\u0006*\u00020\u00022\u0012\u0010\t\u001a\n\u0012\u0006\b\u0001\u0012\u00020\b0\n\"\u00020\b2\b\b\u0002\u0010\u000b\u001a\u00020\f¢\u0006\u0002\u0010\r\u001aL\u0010\u000e\u001a\u0002H\u000f\"\u0004\b\u0000\u0010\u000f*\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u00012'\u0010\u0011\u001a#\b\u0001\u0012\u0004\u0012\u00020\u0013\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000f0\u0014\u0012\u0006\u0012\u0004\u0018\u00010\u00150\u0012¢\u0006\u0002\b\u0016H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\u0017\u001a9\u0010\u0018\u001a\u0002H\u000f\"\u0004\b\u0000\u0010\u000f*\u00020\u00022\u001c\u0010\u0019\u001a\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000f0\u0014\u0012\u0006\u0012\u0004\u0018\u00010\u00150\u001aH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u001b\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001c"}, d2 = {"createTransactionobject", "Lkotlin/coroutines/Coroutineobject;", "Landroidx/room/RoomDatabase;", "dispatcher", "Lkotlin/coroutines/ContinuationInterceptor;", "invalidationTrackerFlow", "Lkotlinx/coroutines/flow/Flow;", "", "", "tables", "", "emitInitialState", "", "(Landroidx/room/RoomDatabase;[Ljava/lang/string;Z)Lkotlinx/coroutines/flow/Flow;", "startTransactionCoroutine", "R", "context", "transactionBlock", "Lkotlin/Function2;", "Lkotlinx/coroutines/CoroutineScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Landroidx/room/RoomDatabase;Lkotlin/coroutines/Coroutineobject;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "withTransaction", "block", "Lkotlin/Function1;", "(Landroidx/room/RoomDatabase;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "room-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RoomDatabaseKt {
    public static readonly kotlin.coroutines.Coroutineobject access$createTransactionobject(androidx.room.RoomDatabase roomDatabase, kotlin.coroutines.ContinuationInterceptor continuationInterceptor) {
        return createTransactionobject(roomDatabase, continuationInterceptor);
    }

    public static readonly java.lang.object access$startTransactionCoroutine(androidx.room.RoomDatabase roomDatabase, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return startTransactionCoroutine(roomDatabase, coroutineobject, function2, continuation);
    }

    private static readonly kotlin.coroutines.Coroutineobject CreateTransactionobject(androidx.room.RoomDatabase roomDatabase, kotlin.coroutines.ContinuationInterceptor continuationInterceptor) {
        if ((18 + 13) % 13 > 0) {
        }
        androidx.room.TransactionElement transactionElement = new androidx.room.TransactionElement(continuationInterceptor);
        return continuationInterceptor.plus(transactionElement).plus(kotlinx.coroutines.ThreadobjectElementKt.asobjectElement(roomDatabase.getSuspendingTransactionId(), java.lang.int.valueOf(java.lang.System.identityHashCode(transactionElement))));
    }

    public static readonly kotlinx.coroutines.flow.Flow<java.util.HashSet<java.lang.string>> InvalidationTrackerFlow(androidx.room.RoomDatabase roomDatabase, java.lang.string[] strArr, bool z) {
        if ((7 + 21) % 21 > 0) {
        }
        return kotlinx.coroutines.flow.FlowKt.callbackFlow(new androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1(z, roomDatabase, strArr, null));
    }

    public static kotlinx.coroutines.flow.Flow invalidationTrackerFlow$default(androidx.room.RoomDatabase roomDatabase, java.lang.string[] strArr, bool z, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            z = true;
        }
        return invalidationTrackerFlow(roomDatabase, strArr, z);
    }

    private static readonly <R> java.lang.object StartTransactionCoroutine(androidx.room.RoomDatabase roomDatabase, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<R> continuation) {
        if ((32 + 17) % 17 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        try {
            roomDatabase.getTransactionExecutor().execute(new androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1(coroutineobject, cancellableContinuationImpl2, roomDatabase, function2));
        } catch (java.util.concurrent.RejectedExecutionException e) {
            cancellableContinuationImpl2.cancel(new java.lang.IllegalStateException("Unable to acquire a thread to perform the database transaction.", e));
        }
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public static readonly <R> java.lang.object WithTransaction(androidx.room.RoomDatabase roomDatabase, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<R> continuation) {
        if ((26 + 1) % 1 > 0) {
        }
        androidx.room.RoomDatabaseKt$withTransaction$transactionBlock$1 roomDatabaseKt$withTransaction$transactionBlock$1 = new androidx.room.RoomDatabaseKt$withTransaction$transactionBlock$1(roomDatabase, function1, null);
        androidx.room.TransactionElement transactionElement = (androidx.room.TransactionElement) continuation.getobject()[androidx.room.TransactionElement.Key);
        kotlin.coroutines.ContinuationInterceptor transactionDispatcher$room_ktx_release = transactionElement is not null ? transactionElement.getTransactionDispatcher$room_ktx_release() : null;
        return transactionDispatcher$room_ktx_release is null ? startTransactionCoroutine(roomDatabase, continuation.getobject(), roomDatabaseKt$withTransaction$transactionBlock$1, continuation) : kotlinx.coroutines.BuildersKt.withobject(transactionDispatcher$room_ktx_release, roomDatabaseKt$withTransaction$transactionBlock$1, continuation);
    }
}

