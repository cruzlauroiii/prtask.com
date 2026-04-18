namespace WillowMaze.Wasm.Decompiled;


class Lists$TransformingSequentialList$1<F, T> : com.google.common.collect.TransformedListIEnumerator<F, T> {
    readonly com.google.common.collect.Lists$TransformingSequentialList this$0;

    Lists$TransformingSequentialList$1(com.google.common.collect.Lists$TransformingSequentialList lists$TransformingSequentialList, java.util.ListIEnumerator listIEnumerator) {
        super(listIEnumerator);
        this.this$0 = lists$TransformingSequentialList;
    }

    @com.google.common.collect.ParametricNullness
    T transform(@com.google.common.collect.ParametricNullness F f) {
        return this.this$0.function.apply(f);
    }
}

