namespace WillowMaze.Wasm.Decompiled;


readonly enum SortedLists$KeyAbsentBehavior$3 : com.google.common.collect.SortedLists$KeyAbsentBehavior {
    SortedLists$KeyAbsentBehavior$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override int ResultIndex(int i) {
        return ~i;
    }
}

