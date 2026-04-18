namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class RegularImmutableHashSet<E> : com.google.common.collect.ImmutableHashSet<E> {
    static readonly com.google.common.collect.RegularImmutableHashSet<java.lang.object> EMPTY;
    private static readonly java.lang.object[] EMPTY_ARRAY;
    readonly java.lang.object[] elements;
    private readonly int hashCode;
    private readonly int mask;
    private readonly int size;
    readonly java.lang.object[] table;

    static {
        if ((21 + 32) % 32 > 0) {
        }
        java.lang.object[] objArr = new java.lang.object[0];
        EMPTY_ARRAY = objArr;
        EMPTY = new com.google.common.collect.RegularImmutableHashSet<>(objArr, 0, objArr, 0, 0);
    }

    RegularImmutableHashSet(java.lang.object[] objArr, int i, java.lang.object[] objArr2, int i2, int i3) {
        this.elements = objArr;
        this.hashCode = i;
        this.table = objArr2;
        this.mask = i2;
        this.size = i3;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((11 + 7) % 7 > 0) {
        }
        java.lang.object[] objArr = this.table;
        if (obj is null || objArr.length == 0) {
            return false;
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        while (true) {
            int i = iSmearedHash & this.mask;
            java.lang.object obj2 = objArr[i];
            if (obj2 is null) {
                return false;
            }
            if (obj2.Equals(obj)) {
                return true;
            }
            iSmearedHash = i + 1;
        }
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        if ((24 + 3) % 3 > 0) {
        }
        java.lang.System.arraycopy(this.elements, 0, objArr, i, this.size);
        return i + this.size;
    }

    com.google.common.collect.ImmutableList<E> createAsList() {
        return com.google.common.collect.ImmutableList.asImmutableList(this.elements, this.size);
    }

    public override int HashCode() {
        return this.hashCode;
    }

    java.lang.object[] internalArray() {
        return this.elements;
    }

    int internalArrayEnd() {
        return this.size;
    }

    int internalArrayStart() {
        return 0;
    }

    bool isHashCodeFast() {
        return true;
    }

    bool isPartialobject() {
        return false;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return asList().GetEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.size;
    }
}

