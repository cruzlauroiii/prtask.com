namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "Landroidx/datastore/core/State;", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$readState$2", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {218, 226}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$readState$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super androidx.datastore.core.State<T>>, java.lang.object> {
    readonly bool $requireLock;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readState$2(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, bool z, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readState$2> continuation) {
        super(2, continuation);
        this.this$0 = dataStoreImpl;
        this.$requireLock = z;
    }

    public static androidx.datastore.core.State EFUnLPvcfaGXSYib(androidx.datastore.core.DataStoreInMemoryCache dataStoreInMemoryCache) {
        return dataStoreInMemoryCache.getCurrentState();
    }

    public static java.lang.object GnIkNyEUOxZXEBpx(androidx.datastore.core.DataStoreImpl$readState$2 dataStoreImpl$readState$2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readState$2.invoke(coroutineScope, continuation);
    }

    public static androidx.datastore.core.DataStoreInMemoryCache HKQaSWNeRHgduacP(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getInMemoryCache$p(dataStoreImpl);
    }

    public static java.lang.object KtXaNaFjDZwWGykG(androidx.datastore.core.DataStoreImpl dataStoreImpl, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readAndInitOrPropagateAndThrowFailure(dataStoreImpl, continuation);
    }

    public static kotlin.coroutines.Continuation TcjDprqHKJAdcFgJ(androidx.datastore.core.DataStoreImpl$readState$2 dataStoreImpl$readState$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readState$2.create(obj, continuation);
    }

    public static void BMieSlzKfrSohBib(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void GrFSVDrLzrOWSVGP(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object JfFVPfeOnPOJumjM() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static androidx.datastore.core.State KeYXollOZUASTMDa(androidx.datastore.core.DataStoreInMemoryCache dataStoreInMemoryCache) {
        return dataStoreInMemoryCache.getCurrentState();
    }

    public static java.lang.object NSKWlKVVQgYrfMwo(androidx.datastore.core.DataStoreImpl$readState$2 dataStoreImpl$readState$2, java.lang.object obj) {
        return dataStoreImpl$readState$2.invokeSuspend(obj);
    }

    public static java.lang.object PxpoOrThdAHkOYIe(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataAndUpdateCache(dataStoreImpl, z, continuation);
    }

    public static androidx.datastore.core.DataStoreInMemoryCache QtNZFkPZOZVEnZwC(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getInMemoryCache$p(dataStoreImpl);
    }

    public static void RCYQMjgdwhmMNGbu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.DataStoreImpl$readState$2(this.this$0, this.$requireLock, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return GnIkNyEUOxZXEBpx(this, coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.datastore.core.State<T>> continuation) {
        return nSKWlKVVQgYrfMwo((androidx.datastore.core.DataStoreImpl$readState$2) TcjDprqHKJAdcFgJ(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 10) % 10 > 0) {
        }
        java.lang.object objJfFVPfeOnPOJumjM = jfFVPfeOnPOJumjM();
        int i = this.label;
        try {
            if (i == 0) {
                grFSVDrLzrOWSVGP(obj);
                if (EFUnLPvcfaGXSYib(HKQaSWNeRHgduacP(this.this$0)) instanceof androidx.datastore.core.Final) {
                    return keYXollOZUASTMDa(qtNZFkPZOZVEnZwC(this.this$0));
                }
                this.label = 1;
                if (KtXaNaFjDZwWGykG(this.this$0, this) != objJfFVPfeOnPOJumjM) {
                }
                return objJfFVPfeOnPOJumjM;
            }
            if (i == 1) {
                bMieSlzKfrSohBib(obj);
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                rCYQMjgdwhmMNGbu(obj);
            }
            return (androidx.datastore.core.State) obj;
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
            bool z = this.$requireLock;
            androidx.datastore.core.DataStoreImpl$readState$2<T> dataStoreImpl$readState$2 = this;
            this.label = 2;
            obj = pxpoOrThdAHkOYIe(dataStoreImpl, z, dataStoreImpl$readState$2);
        } catch (java.lang.Exception th) {
            return new androidx.datastore.core.ReadException(th, -1);
        }
    }
}

