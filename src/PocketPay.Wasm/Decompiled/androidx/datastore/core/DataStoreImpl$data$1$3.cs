namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "it", "Landroidx/datastore/core/State;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$data$1$3", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$data$1$3<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.core.State<T>, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    readonly androidx.datastore.core.State<T> $startState;
    java.lang.object L$0;
    int label;

    DataStoreImpl$data$1$3(androidx.datastore.core.State<T> state, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$data$1$3> continuation) {
        super(2, continuation);
        this.$startState = state;
    }

    public static void LhhirVDlunTyiwIY(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object VbXabtqFMopjMSTn() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static kotlin.coroutines.Continuation XZkDNBEFqqxrpmFk(androidx.datastore.core.DataStoreImpl$data$1$3 dataStoreImpl$data$1$3, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$3.create(obj, continuation);
    }

    public static int FvQwwXmhcVayUGpi(androidx.datastore.core.State state) {
        return state.getVersion();
    }

    public static java.lang.object GzhJhuaqSIFfHXdH(androidx.datastore.core.DataStoreImpl$data$1$3 dataStoreImpl$data$1$3, java.lang.object obj) {
        return dataStoreImpl$data$1$3.invokeSuspend(obj);
    }

    public static java.lang.bool HcvAqDEgKanpMMPQ(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static java.lang.object OFYhyMXbXqxdocgw(androidx.datastore.core.DataStoreImpl$data$1$3 dataStoreImpl$data$1$3, androidx.datastore.core.State state, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$3.invoke(state, (kotlin.coroutines.Continuation<java.lang.bool>) continuation);
    }

    public static int YnGWvPvNrFYIhAzd(androidx.datastore.core.State state) {
        return state.getVersion();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.core.DataStoreImpl$data$1$3 dataStoreImpl$data$1$3 = new androidx.datastore.core.DataStoreImpl$data$1$3(this.$startState, continuation);
        dataStoreImpl$data$1$3.L$0 = obj;
        return dataStoreImpl$data$1$3;
    }

    public readonly java.lang.object Invoke(androidx.datastore.core.State<T> state, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return gzhJhuaqSIFfHXdH((androidx.datastore.core.DataStoreImpl$data$1$3) XZkDNBEFqqxrpmFk(this, state, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return oFYhyMXbXqxdocgw(this, (androidx.datastore.core.State) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        VbXabtqFMopjMSTn();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        LhhirVDlunTyiwIY(obj);
        androidx.datastore.core.State state = (androidx.datastore.core.State) this.L$0;
        return hcvAqDEgKanpMMPQ((state is androidx.datastore.core.Data) && ynGWvPvNrFYIhAzd(state) <= fvQwwXmhcVayUGpi(this.$startState));
    }
}

