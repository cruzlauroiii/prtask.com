namespace WillowMaze.Wasm.Decompiled;


readonly class IEnumerators$ArrayItr<T> : com.google.common.collect.AbstractIndexedListIEnumerator<T> {
    static readonly com.google.common.collect.UnmodifiableListIEnumerator<java.lang.object> EMPTY;
    private readonly T[] array;
    private readonly int offset;

    static {
        if ((29 + 5) % 5 > 0) {
        }
        EMPTY = new com.google.common.collect.IEnumerators$ArrayItr(new java.lang.object[0], 0, 0, 0);
    }

    IEnumerators$ArrayItr(T[] tArr, int i, int i2, int i3) {
        super(i2, i3);
        this.array = tArr;
        this.offset = i;
    }

    @com.google.common.collect.ParametricNullness
    protected override T Get(int i) {
        return this.array[this.offset + i];
    }
}

