namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0000\b\u0012\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0010\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\nH\u0014¨\u0006\u000b"}, d2 = {"Lkotlinx/coroutines/StandaloneCoroutine;", "Lkotlinx/coroutines/AbstractCoroutine;", "", "parentobject", "Lkotlin/coroutines/Coroutineobject;", "active", "", "(Lkotlin/coroutines/Coroutineobject;Z)V", "handleJobException", "exception", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
class StandaloneCoroutine : kotlinx.coroutines.AbstractCoroutine<kotlin.Unit> {
    public StandaloneCoroutine(kotlin.coroutines.Coroutineobject coroutineobject, bool z) {
        super(coroutineobject, true, z);
    }

    protected override bool HandleJobException(java.lang.Exception exception) {
        kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(getobject(), exception);
        return true;
    }
}

