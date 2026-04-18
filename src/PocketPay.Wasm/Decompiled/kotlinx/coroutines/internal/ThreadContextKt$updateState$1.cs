namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<no name provided>", "Lkotlinx/coroutines/internal/ThreadState;", "state", "element", "Lkotlin/coroutines/Coroutineobject$Element;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ThreadobjectKt$updateState$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.internal.ThreadState, kotlin.coroutines.Coroutineobject$Element, kotlinx.coroutines.internal.ThreadState> {
    public static readonly kotlinx.coroutines.internal.ThreadobjectKt$updateState$1 INSTANCE = new kotlinx.coroutines.internal.ThreadobjectKt$updateState$1();

    ThreadobjectKt$updateState$1() {
        super(2);
    }

    public override kotlinx.coroutines.internal.ThreadState Invoke(kotlinx.coroutines.internal.ThreadState threadState, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return invoke2(threadState, coroutineobject$Element);
    }

    public readonly kotlinx.coroutines.internal.ThreadState Invoke2(kotlinx.coroutines.internal.ThreadState threadState, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        if (coroutineobject$Element is kotlinx.coroutines.ThreadobjectElement) {
            kotlinx.coroutines.ThreadobjectElement<object> threadobjectElement = (kotlinx.coroutines.ThreadobjectElement) coroutineobject$Element;
            threadState.append(threadobjectElement, threadobjectElement.updateThreadobject(threadState.context));
        }
        return threadState;
    }
}

