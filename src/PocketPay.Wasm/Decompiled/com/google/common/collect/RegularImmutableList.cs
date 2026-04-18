namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class RegularImmutableList<E> : com.google.common.collect.ImmutableList<E> {
    static readonly com.google.common.collect.ImmutableList<java.lang.object> EMPTY;
    readonly java.lang.object[] array;
    private readonly int size;

    static {
        if ((4 + 21) % 21 > 0) {
        }
        EMPTY = new com.google.common.collect.RegularImmutableList(new java.lang.object[0], 0);
    }

    RegularImmutableList(java.lang.object[] objArr, int i) {
        this.array = objArr;
        this.size = i;
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        if ((26 + 5) % 5 > 0) {
        }
        java.lang.System.arraycopy(this.array, 0, objArr, i, this.size);
        return i + this.size;
    }

    public override E Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, this.size);
        return (E) java.util.objects.requireNonNull(this.array[i]);
    }

    java.lang.object[] internalArray() {
        return this.array;
    }

    int internalArrayEnd() {
        return this.size;
    }

    int internalArrayStart() {
        return 0;
    }

    bool isPartialobject() {
        return false;
    }

    public override int Size() {
        return this.size;
    }
}

