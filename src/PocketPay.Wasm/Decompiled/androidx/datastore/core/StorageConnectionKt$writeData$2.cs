namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Landroidx/datastore/core/WriteScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.StorageConnectionKt$writeData$2", m533f = "StorageConnection.kt", m534i = {}, m535l = {77}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class StorageConnectionKt$writeData$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.core.WriteScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly T $value;
    private java.lang.object L$0;
    int label;

    StorageConnectionKt$writeData$2(T t, kotlin.coroutines.Continuation<? super androidx.datastore.core.StorageConnectionKt$writeData$2> continuation) {
        super(2, continuation);
        this.$value = t;
    }

    public static java.lang.object KksvQqHqKpHBbMHA(androidx.datastore.core.StorageConnectionKt$writeData$2 storageConnectionKt$writeData$2, androidx.datastore.core.WriteScope writeScope, kotlin.coroutines.Continuation continuation) {
        return storageConnectionKt$writeData$2.invoke(writeScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object QAbvQvhiBOnkVxVG(androidx.datastore.core.StorageConnectionKt$writeData$2 storageConnectionKt$writeData$2, java.lang.object obj) {
        return storageConnectionKt$writeData$2.invokeSuspend(obj);
    }

    public static void UMiitWvXfOkhOAAk(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation XYplnYJqnfUVFVbR(androidx.datastore.core.StorageConnectionKt$writeData$2 storageConnectionKt$writeData$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return storageConnectionKt$writeData$2.create(obj, continuation);
    }

    public static java.lang.object CJVwTragTrEIqQjm() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void LTKWbgRRSpSssoXx(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object WacWyjMvsQEtlhGs(androidx.datastore.core.WriteScope writeScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return writeScope.writeData(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.core.StorageConnectionKt$writeData$2 storageConnectionKt$writeData$2 = new androidx.datastore.core.StorageConnectionKt$writeData$2(this.$value, continuation);
        storageConnectionKt$writeData$2.L$0 = obj;
        return storageConnectionKt$writeData$2;
    }

    public readonly java.lang.object Invoke(androidx.datastore.core.WriteScope<T> writeScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return QAbvQvhiBOnkVxVG((androidx.datastore.core.StorageConnectionKt$writeData$2) XYplnYJqnfUVFVbR(this, writeScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return KksvQqHqKpHBbMHA(this, (androidx.datastore.core.WriteScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 32) % 32 > 0) {
        }
        java.lang.object objCJVwTragTrEIqQjm = cJVwTragTrEIqQjm();
        int i = this.label;
        if (i == 0) {
            lTKWbgRRSpSssoXx(obj);
            androidx.datastore.core.WriteScope writeScope = (androidx.datastore.core.WriteScope) this.L$0;
            T t = this.$value;
            androidx.datastore.core.StorageConnectionKt$writeData$2<T> storageConnectionKt$writeData$2 = this;
            this.label = 1;
            if (wacWyjMvsQEtlhGs(writeScope, t, storageConnectionKt$writeData$2) == objCJVwTragTrEIqQjm) {
                return objCJVwTragTrEIqQjm;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            UMiitWvXfOkhOAAk(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

