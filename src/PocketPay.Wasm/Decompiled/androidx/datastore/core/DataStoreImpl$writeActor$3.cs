namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "msg", "Landroidx/datastore/core/Message$Update;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$writeActor$3", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {207}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$writeActor$3<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.core.Message$Update<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$writeActor$3(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$writeActor$3> continuation) {
        super(2, continuation);
        this.this$0 = dataStoreImpl;
    }

    public static kotlin.coroutines.Continuation TzmUtTAmBglSHHnn(androidx.datastore.core.DataStoreImpl$writeActor$3 dataStoreImpl$writeActor$3, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$writeActor$3.create(obj, continuation);
    }

    public static void XPDtxiTxnlZtlqTq(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object YhaFQyosbPCVTazO(androidx.datastore.core.DataStoreImpl dataStoreImpl, androidx.datastore.core.Message$Update message$Update, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$handleUpdate(dataStoreImpl, message$Update, continuation);
    }

    public static java.lang.object JCHptcNQFdyAVUrs(androidx.datastore.core.DataStoreImpl$writeActor$3 dataStoreImpl$writeActor$3, androidx.datastore.core.Message$Update message$Update, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$writeActor$3.invoke(message$Update, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void LyFmEHYLDyalQfOK(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object QJrIaGSipVTyJYvk(androidx.datastore.core.DataStoreImpl$writeActor$3 dataStoreImpl$writeActor$3, java.lang.object obj) {
        return dataStoreImpl$writeActor$3.invokeSuspend(obj);
    }

    public static java.lang.object SAvKLcqhMEZWPDTI() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.core.DataStoreImpl$writeActor$3 dataStoreImpl$writeActor$3 = new androidx.datastore.core.DataStoreImpl$writeActor$3(this.this$0, continuation);
        dataStoreImpl$writeActor$3.L$0 = obj;
        return dataStoreImpl$writeActor$3;
    }

    public readonly java.lang.object Invoke(androidx.datastore.core.Message$Update<T> message$Update, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return qJrIaGSipVTyJYvk((androidx.datastore.core.DataStoreImpl$writeActor$3) TzmUtTAmBglSHHnn(this, message$Update, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return jCHptcNQFdyAVUrs(this, (androidx.datastore.core.Message$Update) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 26) % 26 > 0) {
        }
        java.lang.object objSAvKLcqhMEZWPDTI = sAvKLcqhMEZWPDTI();
        int i = this.label;
        if (i == 0) {
            XPDtxiTxnlZtlqTq(obj);
            androidx.datastore.core.Message$Update message$Update = (androidx.datastore.core.Message$Update) this.L$0;
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
            androidx.datastore.core.DataStoreImpl$writeActor$3<T> dataStoreImpl$writeActor$3 = this;
            this.label = 1;
            if (YhaFQyosbPCVTazO(dataStoreImpl, message$Update, dataStoreImpl$writeActor$3) == objSAvKLcqhMEZWPDTI) {
                return objSAvKLcqhMEZWPDTI;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            lyFmEHYLDyalQfOK(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

