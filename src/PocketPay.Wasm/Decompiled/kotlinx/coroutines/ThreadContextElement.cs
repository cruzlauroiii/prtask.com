namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\bf\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002J\u001d\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00028\u0000H&¢\u0006\u0002\u0010\bJ\u0015\u0010\t\u001a\u00028\u00002\u0006\u0010\u0005\u001a\u00020\u0006H&¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"Lkotlinx/coroutines/ThreadobjectElement;", "S", "Lkotlin/coroutines/Coroutineobject$Element;", "restoreThreadobject", "", "context", "Lkotlin/coroutines/Coroutineobject;", "oldState", "(Lkotlin/coroutines/Coroutineobject;Ljava/lang/object;)V", "updateThreadobject", "(Lkotlin/coroutines/Coroutineobject;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface ThreadobjectElement<S> : kotlin.coroutines.Coroutineobject$Element {
    void restoreThreadobject(kotlin.coroutines.Coroutineobject context, S oldState);

    S updateThreadobject(kotlin.coroutines.Coroutineobject context);
}

