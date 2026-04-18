namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "result", "it", "Lkotlin/coroutines/Coroutineobject$Element;", "invoke", "(ZLkotlin/coroutines/Coroutineobject$Element;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CoroutineobjectKt$hasCopyableElements$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<java.lang.bool, kotlin.coroutines.Coroutineobject$Element, java.lang.bool> {
    public static readonly kotlinx.coroutines.CoroutineobjectKt$hasCopyableElements$1 INSTANCE = new kotlinx.coroutines.CoroutineobjectKt$hasCopyableElements$1();

    CoroutineobjectKt$hasCopyableElements$1() {
        super(2);
    }

    public readonly java.lang.bool Invoke(bool z, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return java.lang.bool.valueOf(z || (coroutineobject$Element is kotlinx.coroutines.CopyableThreadobjectElement));
    }

    public override java.lang.bool Invoke(java.lang.bool bool, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return invoke(bool.boolValue(), coroutineobject$Element);
    }
}

