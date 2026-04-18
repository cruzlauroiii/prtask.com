namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "", "T", "msg", "Landroidx/datastore/core/Message$Update;", "ex", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataStoreImpl$writeActor$2<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<androidx.datastore.core.Message$Update<T>, java.lang.Exception, kotlin.Unit> {
    public static readonly androidx.datastore.core.DataStoreImpl$writeActor$2 INSTANCE = new androidx.datastore.core.DataStoreImpl$writeActor$2();

    DataStoreImpl$writeActor$2() {
        super(2);
    }

    public static kotlinx.coroutines.CompletableDeferred CZsCvhpUhJNrCSuh(androidx.datastore.core.Message$Update message$Update) {
        return message$Update.getAck();
    }

    public static void FgaSBGJiqzrmXBcO(androidx.datastore.core.DataStoreImpl$writeActor$2 dataStoreImpl$writeActor$2, androidx.datastore.core.Message$Update message$Update, java.lang.Exception th) {
        dataStoreImpl$writeActor$2.invoke(message$Update, th);
    }

    public static void GYlrmSLLCTYKqXcn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool NWYvEoJuIJWoTeaT(kotlinx.coroutines.CompletableDeferred completableDeferred, java.lang.Exception th) {
        return completableDeferred.completeExceptionally(th);
    }

    public override kotlin.Unit Invoke(java.lang.object obj, java.lang.Exception th) {
        FgaSBGJiqzrmXBcO(this, (androidx.datastore.core.Message$Update) obj, th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(androidx.datastore.core.Message$Update<T> message$Update, java.lang.Exception th) {
        GYlrmSLLCTYKqXcn(message$Update, "msg");
        kotlinx.coroutines.CompletableDeferred completableDeferredCZsCvhpUhJNrCSuh = CZsCvhpUhJNrCSuh(message$Update);
        if (th is null) {
            th = new java.util.concurrent.CancellationException("DataStore scope was cancelled before updateData could complete");
        }
        nWYvEoJuIJWoTeaT(completableDeferredCZsCvhpUhJNrCSuh, th);
    }
}

