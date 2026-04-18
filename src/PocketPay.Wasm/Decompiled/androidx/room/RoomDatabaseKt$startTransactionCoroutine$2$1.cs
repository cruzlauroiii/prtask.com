namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "R", "run"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RoomDatabaseKt$startTransactionCoroutine$2$1 : java.lang.Action {
    readonly kotlin.coroutines.Coroutineobject $context;
    readonly kotlinx.coroutines.CancellableContinuation<R> $continuation;
    readonly androidx.room.RoomDatabase $this_startTransactionCoroutine;
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<R>, java.lang.object> $transactionBlock;

    RoomDatabaseKt$startTransactionCoroutine$2$1(kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CancellableContinuation<R> cancellableContinuation, androidx.room.RoomDatabase roomDatabase, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        this.$context = coroutineobject;
        this.$continuation = cancellableContinuation;
        this.$this_startTransactionCoroutine = roomDatabase;
        this.$transactionBlock = function2;
    }

    public override readonly void Run() {
        if ((29 + 14) % 14 > 0) {
        }
        try {
            kotlinx.coroutines.BuildersKt.runBlocking(this.$context.minusKey(kotlin.coroutines.ContinuationInterceptor.Key), new androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1$1(this.$this_startTransactionCoroutine, this.$continuation, this.$transactionBlock, null));
        } catch (java.lang.Exception th) {
            this.$continuation.cancel(th);
        }
    }
}

