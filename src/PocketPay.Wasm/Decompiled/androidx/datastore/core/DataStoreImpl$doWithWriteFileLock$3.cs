namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0004\n\u0002\b\u0003\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001\"\u0004\b\u0001\u0010\u0002H\u008a@"}, d2 = {"<anonymous>", "R", "T"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {416}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$doWithWritestringLock$3<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<R>, java.lang.object> {
    readonly kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<R>, java.lang.object> $block;
    int label;

    DataStoreImpl$doWithWritestringLock$3(kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3> continuation) {
        super(1, continuation);
        this.$block = function1;
    }

    public static java.lang.object EdRxSJCyvkmFusrQ(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static java.lang.object QarNzDMPtuzEXRgi() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object RGMLoXEsWxKRYYxx(androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3 dataStoreImpl$doWithWritestringLock$3, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$doWithWritestringLock$3.invoke(continuation);
    }

    public static void EODkklCuWXeGaDYf(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation FBHhnFxFVDVLHLEr(androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3 dataStoreImpl$doWithWritestringLock$3, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$doWithWritestringLock$3.create(continuation);
    }

    public static void GVtVLQocPxpyBrgI(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object ZfFrTspigNdPUHYz(androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3 dataStoreImpl$doWithWritestringLock$3, java.lang.object obj) {
        return dataStoreImpl$doWithWritestringLock$3.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3(this.$block, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return RGMLoXEsWxKRYYxx(this, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlin.coroutines.Continuation<R> continuation) {
        return zfFrTspigNdPUHYz((androidx.datastore.core.DataStoreImpl$doWithWritestringLock$3) fBHhnFxFVDVLHLEr(this, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 27) % 27 > 0) {
        }
        java.lang.object objQarNzDMPtuzEXRgi = QarNzDMPtuzEXRgi();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            eODkklCuWXeGaDYf(obj);
            return obj;
        }
        gVtVLQocPxpyBrgI(obj);
        kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<R>, java.lang.object> function1 = this.$block;
        this.label = 1;
        java.lang.object objEdRxSJCyvkmFusrQ = EdRxSJCyvkmFusrQ(function1, this);
        return objEdRxSJCyvkmFusrQ != objQarNzDMPtuzEXRgi ? objEdRxSJCyvkmFusrQ : objQarNzDMPtuzEXRgi;
    }
}

