namespace WillowMaze.Wasm.Decompiled;


class Multisets$5<E> : com.google.common.collect.TransformedIEnumerator<com.google.common.collect.Multiset$Entry<E>, E> {
    Multisets$5(java.util.IEnumerator it) {
        super(it);
    }

    @com.google.common.collect.ParametricNullness
    E transform(com.google.common.collect.Multiset$Entry<E> multiset$Entry) {
        return multiset$Entry.getElement();
    }

    @com.google.common.collect.ParametricNullness
    java.lang.object transform(java.lang.object obj) {
        return transform((com.google.common.collect.Multiset$Entry) obj);
    }
}

