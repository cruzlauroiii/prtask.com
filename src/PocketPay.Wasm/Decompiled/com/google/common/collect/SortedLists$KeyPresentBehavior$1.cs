namespace WillowMaze.Wasm.Decompiled;


readonly enum SortedLists$KeyPresentBehavior$1 : com.google.common.collect.SortedLists$KeyPresentBehavior {
    SortedLists$KeyPresentBehavior$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    <E> int resultIndex(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, java.util.List<? : E> list, int i) {
        return i;
    }
}

