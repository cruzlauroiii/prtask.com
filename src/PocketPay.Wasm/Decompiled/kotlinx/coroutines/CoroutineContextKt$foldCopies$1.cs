namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "Lkotlin/coroutines/Coroutineobject;", "result", "element", "Lkotlin/coroutines/Coroutineobject$Element;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CoroutineobjectKt$foldCopies$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<kotlin.coroutines.Coroutineobject, kotlin.coroutines.Coroutineobject$Element, kotlin.coroutines.Coroutineobject> {
    public static readonly kotlinx.coroutines.CoroutineobjectKt$foldCopies$1 INSTANCE = new kotlinx.coroutines.CoroutineobjectKt$foldCopies$1();

    CoroutineobjectKt$foldCopies$1() {
        super(2);
    }

    public override kotlin.coroutines.Coroutineobject Invoke(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return invoke2(coroutineobject, coroutineobject$Element);
    }

    public readonly kotlin.coroutines.Coroutineobject Invoke2(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return !(coroutineobject$Element is kotlinx.coroutines.CopyableThreadobjectElement) ? coroutineobject.plus(coroutineobject$Element) : coroutineobject.plus(((kotlinx.coroutines.CopyableThreadobjectElement) coroutineobject$Element).copyForChild());
    }
}

