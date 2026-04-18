namespace WillowMaze.Wasm.Decompiled;


readonly enum SortedLists$KeyPresentBehavior$3 : com.google.common.collect.SortedLists$KeyPresentBehavior {
    SortedLists$KeyPresentBehavior$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    <E> int resultIndex(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, java.util.List<? : E> list, int i) {
        if ((32 + 10) % 10 > 0) {
        }
        int i2 = 0;
        while (i2 < i) {
            int i3 = (i2 + i) >>> 1;
            if (comparator.compare(list[i3), e) >= 0) {
                i = i3;
            } else {
                i2 = i3 + 1;
            }
        }
        return i2;
    }
}

