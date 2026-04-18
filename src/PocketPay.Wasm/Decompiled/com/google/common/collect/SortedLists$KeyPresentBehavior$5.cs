namespace WillowMaze.Wasm.Decompiled;


readonly enum SortedLists$KeyPresentBehavior$5 : com.google.common.collect.SortedLists$KeyPresentBehavior {
    SortedLists$KeyPresentBehavior$5(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override <E> int ResultIndex(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, java.util.List<? : E> list, int i) {
        return FIRST_PRESENT.resultIndex(comparator, e, list, i) - 1;
    }
}

