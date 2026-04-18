namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$updateData$2", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {169}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$updateData$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<T>, java.lang.object> $transform;
    private java.lang.object L$0;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$updateData$2(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$updateData$2> continuation) {
        super(2, continuation);
        this.this$0 = dataStoreImpl;
        this.$transform = function2;
    }

    public static void ERpaGZuykEOeozqf(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static androidx.datastore.core.State GIHvrmQTDVOlGlAD(androidx.datastore.core.DataStoreInMemoryCache dataStoreInMemoryCache) {
        return dataStoreInMemoryCache.getCurrentState();
    }

    public static kotlinx.coroutines.CompletableDeferred JApuHcJAtkDPNjgy(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.CompletableDeferredKt.CompletableDeferred$default(job, i, obj);
    }

    public static java.lang.object MtXlKXZCimJxKKaZ(androidx.datastore.core.DataStoreImpl$updateData$2 dataStoreImpl$updateData$2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$updateData$2.invoke(coroutineScope, continuation);
    }

    public static java.lang.object NNGdSbtFjoINjGyS(androidx.datastore.core.DataStoreImpl$updateData$2 dataStoreImpl$updateData$2, java.lang.object obj) {
        return dataStoreImpl$updateData$2.invokeSuspend(obj);
    }

    public static androidx.datastore.core.DataStoreInMemoryCache OdIiVrHzfxukhYUz(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getInMemoryCache$p(dataStoreImpl);
    }

    public static java.lang.object QHPdAmaNfSyTjQPN(kotlinx.coroutines.CompletableDeferred completableDeferred, kotlin.coroutines.Continuation continuation) {
        return completableDeferred.await(continuation);
    }

    public static kotlin.coroutines.Continuation AnArSHspKXeZGOlc(androidx.datastore.core.DataStoreImpl$updateData$2 dataStoreImpl$updateData$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$updateData$2.create(obj, continuation);
    }

    public static void IXXWiSDoCxHWGerh(androidx.datastore.core.SimpleActor simpleActor, java.lang.object obj) throws java.lang.Exception {
        simpleActor.offer(obj);
    }

    public static java.lang.object IqVIeshkWOKFivCS() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static kotlin.coroutines.Coroutineobject OElPlYitddBMxPUU(kotlinx.coroutines.CoroutineScope coroutineScope) {
        return coroutineScope.getCoroutineobject();
    }

    public static androidx.datastore.core.SimpleActor OnHBLxtxgJqfdLRN(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getWriteActor$p(dataStoreImpl);
    }

    public static void TVBXdSyPYvcoeFax(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((23 + 23) % 23 > 0) {
        }
        androidx.datastore.core.DataStoreImpl$updateData$2 dataStoreImpl$updateData$2 = new androidx.datastore.core.DataStoreImpl$updateData$2(this.this$0, this.$transform, continuation);
        dataStoreImpl$updateData$2.L$0 = obj;
        return dataStoreImpl$updateData$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return MtXlKXZCimJxKKaZ(this, coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<T> continuation) {
        return NNGdSbtFjoINjGyS((androidx.datastore.core.DataStoreImpl$updateData$2) anArSHspKXeZGOlc(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 18) % 18 > 0) {
        }
        java.lang.object objIqVIeshkWOKFivCS = iqVIeshkWOKFivCS();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            tVBXdSyPYvcoeFax(obj);
            return obj;
        }
        ERpaGZuykEOeozqf(obj);
        kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
        kotlinx.coroutines.CompletableDeferred completableDeferredJApuHcJAtkDPNjgy = JApuHcJAtkDPNjgy(null, 1, null);
        iXXWiSDoCxHWGerh(onHBLxtxgJqfdLRN(this.this$0), new androidx.datastore.core.Message$Update(this.$transform, completableDeferredJApuHcJAtkDPNjgy, GIHvrmQTDVOlGlAD(OdIiVrHzfxukhYUz(this.this$0)), oElPlYitddBMxPUU(coroutineScope)));
        androidx.datastore.core.DataStoreImpl$updateData$2<T> dataStoreImpl$updateData$2 = this;
        this.label = 1;
        java.lang.object objQHPdAmaNfSyTjQPN = QHPdAmaNfSyTjQPN(completableDeferredJApuHcJAtkDPNjgy, dataStoreImpl$updateData$2);
        return objQHPdAmaNfSyTjQPN != objIqVIeshkWOKFivCS ? objQHPdAmaNfSyTjQPN : objIqVIeshkWOKFivCS;
    }
}

