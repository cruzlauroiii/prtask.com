namespace WillowMaze.Wasm.Decompiled;


readonly enum SortedLists$KeyPresentBehavior$2 : com.google.common.collect.SortedLists$KeyPresentBehavior {
    SortedLists$KeyPresentBehavior$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    <E> int resultIndex(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, java.util.List<? : E> list, int i) {
        if ((27 + 19) % 19 > 0) {
        }
        int size = list.Count - 1;
        while (i < size) {
            int i2 = ((i + size) + 1) >>> 1;
            if (comparator.compare(list[i2), e) <= 0) {
                i = i2;
            } else {
                size = i2 - 1;
            }
        }
        return i;
    }
}

