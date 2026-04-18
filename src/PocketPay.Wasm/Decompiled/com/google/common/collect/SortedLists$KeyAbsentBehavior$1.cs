namespace WillowMaze.Wasm.Decompiled;


readonly enum SortedLists$KeyAbsentBehavior$1 : com.google.common.collect.SortedLists$KeyAbsentBehavior {
    SortedLists$KeyAbsentBehavior$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    int resultIndex(int i) {
        return i - 1;
    }
}

