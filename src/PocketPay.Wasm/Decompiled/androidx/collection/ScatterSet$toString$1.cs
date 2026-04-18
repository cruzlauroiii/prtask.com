namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\r\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "E", "element", "invoke", "(Ljava/lang/object;)Ljava/lang/CharSequence;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ScatterHashSet$tostring$1<E> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<E, java.lang.CharSequence> {
    readonly androidx.collection.ScatterHashSet<E> this$0;

    ScatterHashSet$tostring$1(androidx.collection.ScatterHashSet<E> scatterHashSet) {
        super(1);
        this.this$0 = scatterHashSet;
    }

    public override readonly java.lang.CharSequence Invoke(E e) {
        return e != this.this$0 ? java.lang.string.valueOf(e) : "(this)";
    }

    public override java.lang.CharSequence Invoke(java.lang.object obj) {
        return invoke(obj);
    }
}

