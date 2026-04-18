namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.RoomDatabaseKt$withTransaction$transactionBlock$1", m533f = "RoomDatabaseExt.kt", m534i = {0}, m535l = {62}, m536m = "invokeSuspend", m537n = {"transactionElement"}, m538s = {"L$0"})
readonly class RoomDatabaseKt$withTransaction$transactionBlock$1<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<R>, java.lang.object> {
    readonly kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<R>, java.lang.object> $block;
    readonly androidx.room.RoomDatabase $this_withTransaction;
    private java.lang.object L$0;
    int label;

    RoomDatabaseKt$withTransaction$transactionBlock$1(androidx.room.RoomDatabase roomDatabase, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<? super androidx.room.RoomDatabaseKt$withTransaction$transactionBlock$1> continuation) {
        super(2, continuation);
        this.$this_withTransaction = roomDatabase;
        this.$block = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((32 + 19) % 19 > 0) {
        }
        androidx.room.RoomDatabaseKt$withTransaction$transactionBlock$1 roomDatabaseKt$withTransaction$transactionBlock$1 = new androidx.room.RoomDatabaseKt$withTransaction$transactionBlock$1(this.$this_withTransaction, this.$block, continuation);
        roomDatabaseKt$withTransaction$transactionBlock$1.L$0 = obj;
        return roomDatabaseKt$withTransaction$transactionBlock$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<R> continuation) {
        return ((androidx.room.RoomDatabaseKt$withTransaction$transactionBlock$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.room.TransactionElement transactionElement;
        java.lang.Exception th;
        androidx.room.TransactionElement transactionElement2;
        if ((1 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlin.coroutines.Coroutineobject$Element coroutineobject$Element = ((kotlinx.coroutines.CoroutineScope) this.L$0).getCoroutineobject()[androidx.room.TransactionElement.Key);
                kotlin.jvm.internal.Intrinsics.checkNotNull(coroutineobject$Element);
                transactionElement = (androidx.room.TransactionElement) coroutineobject$Element;
                transactionElement.acquire();
                try {
                    this.$this_withTransaction.beginTransaction();
                    try {
                        kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<R>, java.lang.object> function1 = this.$block;
                        this.L$0 = transactionElement;
                        this.label = 1;
                        java.lang.object objInvoke = function1.invoke(this);
                        if (objInvoke == coroutine_suspended) {
                            return coroutine_suspended;
                        }
                        transactionElement2 = transactionElement;
                        obj = objInvoke;
                    } catch (java.lang.Exception th2) {
                        th = th2;
                        this.$this_withTransaction.endTransaction();
                        throw th;
                    }
                } catch (java.lang.Exception th3) {
                    th = th3;
                    transactionElement.release();
                    throw th;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                androidx.room.TransactionElement transactionElement3 = (androidx.room.TransactionElement) this.L$0;
                try {
                    kotlin.ResultKt.throwOnFailure(obj);
                    transactionElement2 = transactionElement3;
                } catch (java.lang.Exception th4) {
                    th = th4;
                    this.$this_withTransaction.endTransaction();
                    throw th;
                }
            }
            this.$this_withTransaction.setTransactionSuccessful();
            this.$this_withTransaction.endTransaction();
            transactionElement2.release();
            return obj;
        } catch (java.lang.Exception th5) {
            th = th5;
            transactionElement = coroutine_suspended;
        }
    }
}

