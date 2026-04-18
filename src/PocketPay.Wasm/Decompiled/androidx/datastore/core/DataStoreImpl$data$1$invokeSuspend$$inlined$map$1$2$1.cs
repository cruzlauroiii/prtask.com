namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2 this$0;

    public DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1(androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2 dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2;
    }

    public static java.lang.object ZqErhxQluhzxpxUc(androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2 dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2.emit(obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return zqErhxQluhzxpxUc(this.this$0, null, this);
    }
}

