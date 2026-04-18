namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "it", "Landroidx/datastore/core/State;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$data$1$2", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$data$1$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.core.State<T>, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    java.lang.object L$0;
    int label;

    DataStoreImpl$data$1$2(kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$data$1$2> continuation) {
        super(2, continuation);
    }

    public static java.lang.object PupvsEpiSJTdHGsG(androidx.datastore.core.DataStoreImpl$data$1$2 dataStoreImpl$data$1$2, androidx.datastore.core.State state, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$2.invoke(state, (kotlin.coroutines.Continuation<java.lang.bool>) continuation);
    }

    public static void VfhclhuMwRBqvAWj(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.bool CVGGIDPwatWrbwGU(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static kotlin.coroutines.Continuation MruFZywZpUWWiWWp(androidx.datastore.core.DataStoreImpl$data$1$2 dataStoreImpl$data$1$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$2.create(obj, continuation);
    }

    public static java.lang.object NGUWzxGqBOptUuPK() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object ScjnSSiiJHHBPXve(androidx.datastore.core.DataStoreImpl$data$1$2 dataStoreImpl$data$1$2, java.lang.object obj) {
        return dataStoreImpl$data$1$2.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.core.DataStoreImpl$data$1$2 dataStoreImpl$data$1$2 = new androidx.datastore.core.DataStoreImpl$data$1$2(continuation);
        dataStoreImpl$data$1$2.L$0 = obj;
        return dataStoreImpl$data$1$2;
    }

    public readonly java.lang.object Invoke(androidx.datastore.core.State<T> state, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return scjnSSiiJHHBPXve((androidx.datastore.core.DataStoreImpl$data$1$2) mruFZywZpUWWiWWp(this, state, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return PupvsEpiSJTdHGsG(this, (androidx.datastore.core.State) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        nGUWzxGqBOptUuPK();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        VfhclhuMwRBqvAWj(obj);
        return cVGGIDPwatWrbwGU(!(((androidx.datastore.core.State) this.L$0) instanceof androidx.datastore.core.Final));
    }
}

