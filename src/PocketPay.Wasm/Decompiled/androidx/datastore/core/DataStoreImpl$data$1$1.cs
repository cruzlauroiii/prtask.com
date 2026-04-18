namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00040\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/flow/FlowCollector;", "Landroidx/datastore/core/State;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$data$1$1", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {102}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$data$1$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<? super androidx.datastore.core.State<T>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$data$1$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$data$1$1> continuation) {
        super(2, continuation);
        this.this$0 = dataStoreImpl;
    }

    public static java.lang.object FRlCagGOgRJHFCqN(androidx.datastore.core.DataStoreImpl dataStoreImpl, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$incrementCollector(dataStoreImpl, continuation);
    }

    public static java.lang.object LcwaVXXMpIIltcbL(androidx.datastore.core.DataStoreImpl$data$1$1 dataStoreImpl$data$1$1, java.lang.object obj) {
        return dataStoreImpl$data$1$1.invokeSuspend(obj);
    }

    public static void OduZknRXvyvoUBxR(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation DhUpQlvuGyecNjLu(androidx.datastore.core.DataStoreImpl$data$1$1 dataStoreImpl$data$1$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$1.create(obj, continuation);
    }

    public static java.lang.object FUZxcXhOInftjHFw(androidx.datastore.core.DataStoreImpl$data$1$1 dataStoreImpl$data$1$1, kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$1.invoke(flowCollector, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void WWReTGKefCkyiMtd(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object YaIzhPjinmiIpGqu() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.DataStoreImpl$data$1$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return fUZxcXhOInftjHFw(this, (kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.datastore.core.State<T>> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return LcwaVXXMpIIltcbL((androidx.datastore.core.DataStoreImpl$data$1$1) dhUpQlvuGyecNjLu(this, flowCollector, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 30) % 30 > 0) {
        }
        java.lang.object objYaIzhPjinmiIpGqu = yaIzhPjinmiIpGqu();
        int i = this.label;
        if (i == 0) {
            wWReTGKefCkyiMtd(obj);
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
            androidx.datastore.core.DataStoreImpl$data$1$1<T> dataStoreImpl$data$1$1 = this;
            this.label = 1;
            if (FRlCagGOgRJHFCqN(dataStoreImpl, dataStoreImpl$data$1$1) == objYaIzhPjinmiIpGqu) {
                return objYaIzhPjinmiIpGqu;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            OduZknRXvyvoUBxR(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

