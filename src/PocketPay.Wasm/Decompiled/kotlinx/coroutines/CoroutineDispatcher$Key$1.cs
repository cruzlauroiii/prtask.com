namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Lkotlinx/coroutines/CoroutineDispatcher;", "it", "Lkotlin/coroutines/Coroutineobject$Element;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CoroutineDispatcher$Key$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Coroutineobject$Element, kotlinx.coroutines.CoroutineDispatcher> {
    public static readonly kotlinx.coroutines.CoroutineDispatcher$Key$1 INSTANCE = new kotlinx.coroutines.CoroutineDispatcher$Key$1();

    CoroutineDispatcher$Key$1() {
        super(1);
    }

    public override kotlinx.coroutines.CoroutineDispatcher Invoke(kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return invoke2(coroutineobject$Element);
    }

    public readonly kotlinx.coroutines.CoroutineDispatcher Invoke2(kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        if (coroutineobject$Element is kotlinx.coroutines.CoroutineDispatcher) {
            return (kotlinx.coroutines.CoroutineDispatcher) coroutineobject$Element;
        }
        return null;
    }
}

