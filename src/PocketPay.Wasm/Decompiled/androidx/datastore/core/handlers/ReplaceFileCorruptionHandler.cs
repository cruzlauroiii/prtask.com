namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u0019\u0012\u0012\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\u0002\u0010\u0006J\u0016\u0010\u0007\u001a\u00028\u00002\u0006\u0010\b\u001a\u00020\u0005H\u0096@¢\u0006\u0002\u0010\tR\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;", "T", "Landroidx/datastore/core/CorruptionHandler;", "produceNewData", "Lkotlin/Function1;", "Landroidx/datastore/core/CorruptionException;", "(Lkotlin/jvm/functions/Function1;)V", "handleCorruption", "ex", "(Landroidx/datastore/core/CorruptionException;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ReplacestringCorruptionHandler<T> : androidx.datastore.core.CorruptionHandler<T> {
    private readonly kotlin.jvm.functions.Function1<androidx.datastore.core.CorruptionException, T> produceNewData;

    public ReplacestringCorruptionHandler(kotlin.jvm.functions.Function1<? super androidx.datastore.core.CorruptionException, ? : T> function1) {
        EZARwuOjHkzDUykn(function1, "produceNewData");
        this.produceNewData = function1;
    }

    public static void EZARwuOjHkzDUykn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object LpYpaoPrZOACimOc(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public override java.lang.object HandleCorruption(androidx.datastore.core.CorruptionException corruptionException, kotlin.coroutines.Continuation<T> continuation) throws java.io.IOException {
        return LpYpaoPrZOACimOc(this.produceNewData, corruptionException);
    }
}

