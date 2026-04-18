namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0004\bf\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003J\u001d\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00028\u00002\u0006\u0010\f\u001a\u00028\u0000H&¢\u0006\u0002\u0010\rR\u0018\u0010\u0004\u001a\u00028\u0000X¦\u000e¢\u0006\f\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\b¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/flow/MutableStateFlow;", "T", "Lkotlinx/coroutines/flow/StateFlow;", "Lkotlinx/coroutines/flow/MutableSharedFlow;", "value", "getValue", "()Ljava/lang/object;", "setValue", "(Ljava/lang/object;)V", "compareAndHashSet", "", "expect", "update", "(Ljava/lang/object;Ljava/lang/object;)Z", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface MutableStateFlow<T> : kotlinx.coroutines.flow.StateFlow<T>, kotlinx.coroutines.flow.MutableSharedFlow<T> {
    bool compareAndHashSet(T expect, T update);

    T getValue();

    void setValue(T t);
}

