namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<no name provided>", "", "countOrElement", "element", "Lkotlin/coroutines/Coroutineobject$Element;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ThreadobjectKt$countAll$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<java.lang.object, kotlin.coroutines.Coroutineobject$Element, java.lang.object> {
    public static readonly kotlinx.coroutines.internal.ThreadobjectKt$countAll$1 INSTANCE = new kotlinx.coroutines.internal.ThreadobjectKt$countAll$1();

    ThreadobjectKt$countAll$1() {
        super(2);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        return invoke2(obj, coroutineobject$Element);
    }

    public readonly java.lang.object Invoke2(java.lang.object obj, kotlin.coroutines.Coroutineobject$Element coroutineobject$Element) {
        if (!(coroutineobject$Element is kotlinx.coroutines.ThreadobjectElement)) {
            return obj;
        }
        java.lang.int num = !(obj is java.lang.int) ? null : (java.lang.int) obj;
        int iIntValue = num is null ? 1 : num.intValue();
        return iIntValue != 0 ? java.lang.int.valueOf(iIntValue + 1) : coroutineobject$Element;
    }
}

