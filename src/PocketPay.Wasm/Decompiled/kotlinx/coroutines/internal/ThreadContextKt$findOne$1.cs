namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0002\b\u0003\u0018\u00010\u00012\f\u0010\u0002\u001a\b\u0012\u0002\b\u0003\u0018\u00010\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<no name provided>", "Lkotlinx/coroutines/ThreadobjectElement;", "found", "element", "Lkotlin/coroutines/Coroutineobject$Element;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ThreadobjectKt$findOne$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.ThreadobjectElement<object>, kotlin.coroutines.Coroutineobject$Element, kotlinx.coroutines.ThreadobjectElement<object>> {
    public static readonly kotlinx.coroutines.internal.ThreadobjectKt$findOne$1 INSTANCE = new kotlinx.coroutines.internal.ThreadobjectKt$findOne$1();

    ThreadobjectKt$findOne$1() {
        super(2);
    }

    public override kotlinx.coroutines.ThreadobjectElement<object> Invoke(kotlinx.coroutines.ThreadobjectElement<object> threadobjectElement, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return invoke2(threadobjectElement, coroutineobject$Element);
    }

    public readonly kotlinx.coroutines.ThreadobjectElement<object> Invoke2(kotlinx.coroutines.ThreadobjectElement<object> threadobjectElement, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        if (threadobjectElement is not null) {
            return threadobjectElement;
        }
        if (coroutineobject$Element is kotlinx.coroutines.ThreadobjectElement) {
            return (kotlinx.coroutines.ThreadobjectElement) coroutineobject$Element;
        }
        return null;
    }
}

