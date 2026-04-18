namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1$1", m533f = "RoomDatabaseExt.kt", m534i = {}, m535l = {103}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RoomDatabaseKt$startTransactionCoroutine$2$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.CancellableContinuation<R> $continuation;
    readonly androidx.room.RoomDatabase $this_startTransactionCoroutine;
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<R>, java.lang.object> $transactionBlock;
    private java.lang.object L$0;
    int label;

    RoomDatabaseKt$startTransactionCoroutine$2$1$1(androidx.room.RoomDatabase roomDatabase, kotlinx.coroutines.CancellableContinuation<R> cancellableContinuation, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1$1> continuation) {
        super(2, continuation);
        this.$this_startTransactionCoroutine = roomDatabase;
        this.$continuation = cancellableContinuation;
        this.$transactionBlock = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((14 + 19) % 19 > 0) {
        }
        androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1$1 roomDatabaseKt$startTransactionCoroutine$2$1$1 = new androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1$1(this.$this_startTransactionCoroutine, this.$continuation, this.$transactionBlock, continuation);
        roomDatabaseKt$startTransactionCoroutine$2$1$1.L$0 = obj;
        return roomDatabaseKt$startTransactionCoroutine$2$1$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.Continuation continuation;
        if ((32 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.coroutines.Coroutineobject$Element coroutineobject$Element = ((kotlinx.coroutines.CoroutineScope) this.L$0).getCoroutineobject()[kotlin.coroutines.ContinuationInterceptor.Key);
            kotlin.jvm.internal.Intrinsics.checkNotNull(coroutineobject$Element);
            kotlin.coroutines.Coroutineobject coroutineobjectAccess$createTransactionobject = androidx.room.RoomDatabaseKt.access$createTransactionobject(this.$this_startTransactionCoroutine, (kotlin.coroutines.ContinuationInterceptor) coroutineobject$Element);
            kotlin.coroutines.Continuation continuation2 = this.$continuation;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<R>, java.lang.object> function2 = this.$transactionBlock;
            androidx.room.RoomDatabaseKt$startTransactionCoroutine$2$1$1 roomDatabaseKt$startTransactionCoroutine$2$1$1 = this;
            this.L$0 = continuation2;
            this.label = 1;
            obj = kotlinx.coroutines.BuildersKt.withobject(coroutineobjectAccess$createTransactionobject, function2, roomDatabaseKt$startTransactionCoroutine$2$1$1);
            if (obj == coroutine_suspended) {
                return coroutine_suspended;
            }
            continuation = continuation2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            continuation = (kotlin.coroutines.Continuation) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        continuation.resumeWith(kotlin.Result.m948constructorimpl(obj));
        return kotlin.Unit.INSTANCE;
    }
}

