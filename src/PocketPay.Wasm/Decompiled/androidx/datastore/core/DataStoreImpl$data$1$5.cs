namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/flow/FlowCollector;", "it", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$data$1$5", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {116}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$data$1$5<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<T>, java.lang.Exception, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$data$1$5(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$data$1$5> continuation) {
        super(3, continuation);
        this.this$0 = dataStoreImpl;
    }

    public static void BjhjkuHmCHvqYvyN(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object DDAuxBQgMyHyAlhc(androidx.datastore.core.DataStoreImpl dataStoreImpl, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$decrementCollector(dataStoreImpl, continuation);
    }

    public static void FIrIKezzjGniweLw(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object QOXUnQGzBbkCKUJW(androidx.datastore.core.DataStoreImpl$data$1$5 dataStoreImpl$data$1$5, kotlinx.coroutines.flow.FlowCollector flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$5.invoke(flowCollector, th, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object NtKzmCnvxfGhBMax(androidx.datastore.core.DataStoreImpl$data$1$5 dataStoreImpl$data$1$5, java.lang.object obj) {
        return dataStoreImpl$data$1$5.invokeSuspend(obj);
    }

    public static java.lang.object VApOquUvISQlXIqw() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return QOXUnQGzBbkCKUJW(this, (kotlinx.coroutines.flow.FlowCollector) obj, th, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ntKzmCnvxfGhBMax(new androidx.datastore.core.DataStoreImpl$data$1$5(this.this$0, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((27 + 26) % 26 > 0) {
        }
        java.lang.object objVApOquUvISQlXIqw = vApOquUvISQlXIqw();
        int i = this.label;
        if (i == 0) {
            BjhjkuHmCHvqYvyN(obj);
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
            androidx.datastore.core.DataStoreImpl$data$1$5<T> dataStoreImpl$data$1$5 = this;
            this.label = 1;
            if (DDAuxBQgMyHyAlhc(dataStoreImpl, dataStoreImpl$data$1$5) == objVApOquUvISQlXIqw) {
                return objVApOquUvISQlXIqw;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            FIrIKezzjGniweLw(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

