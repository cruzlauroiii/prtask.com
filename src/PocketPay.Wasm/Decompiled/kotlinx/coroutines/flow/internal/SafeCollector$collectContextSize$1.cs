namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u0005H\n¢\u0006\u0004\b\u0006\u0010\u0007"}, d2 = {"<anonymous>", "", "T", "count", "<anonymous parameter 1>", "Lkotlin/coroutines/Coroutineobject$Element;", "invoke", "(ILkotlin/coroutines/Coroutineobject$Element;)Ljava/lang/int;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class SafeCollector$collectobjectSize$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<java.lang.int, kotlin.coroutines.Coroutineobject$Element, java.lang.int> {
    public static readonly kotlinx.coroutines.flow.internal.SafeCollector$collectobjectSize$1 INSTANCE = new kotlinx.coroutines.flow.internal.SafeCollector$collectobjectSize$1();

    SafeCollector$collectobjectSize$1() {
        super(2);
    }

    public readonly java.lang.int Invoke(int i, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return java.lang.int.valueOf(i + 1);
    }

    public override java.lang.int Invoke(java.lang.int num, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return invoke(num.intValue(), coroutineobject$Element);
    }
}

