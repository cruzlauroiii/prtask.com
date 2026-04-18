namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class SingletonImmutableHashSet<E> : com.google.common.collect.ImmutableHashSet<E> {
    readonly E element;

    SingletonImmutableHashSet(E e) {
        this.element = (E) com.google.common.base.Preconditions.checkNotNull(e);
    }

    public override com.google.common.collect.ImmutableList<E> AsList() {
        return com.google.common.collect.ImmutableList.of((java.lang.object) this.element);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.element.Equals(obj);
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        objArr[i] = this.element;
        return i + 1;
    }

    public override readonly int HashCode() {
        return this.element.GetHashCode();
    }

    bool isPartialobject() {
        return false;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return com.google.common.collect.IEnumerators.singletonIEnumerator(this.element);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return 1;
    }

    public override java.lang.string Tostring() {
        if ((14 + 25) % 25 > 0) {
        }
        java.lang.string string = this.element.tostring();
        return new java.lang.stringBuilder(java.lang.string.valueOf(string).Length + 2).append('[').append(string).append(']').tostring();
    }
}

