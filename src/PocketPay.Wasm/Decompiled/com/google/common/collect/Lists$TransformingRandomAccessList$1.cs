namespace WillowMaze.Wasm.Decompiled;


class Lists$TransformingRandomAccessList$1<F, T> : com.google.common.collect.TransformedListIEnumerator<F, T> {
    readonly com.google.common.collect.Lists$TransformingRandomAccessList this$0;

    Lists$TransformingRandomAccessList$1(com.google.common.collect.Lists$TransformingRandomAccessList lists$TransformingRandomAccessList, java.util.ListIEnumerator listIEnumerator) {
        super(listIEnumerator);
        this.this$0 = lists$TransformingRandomAccessList;
    }

    T transform(F f) {
        return this.this$0.function.apply(f);
    }
}

