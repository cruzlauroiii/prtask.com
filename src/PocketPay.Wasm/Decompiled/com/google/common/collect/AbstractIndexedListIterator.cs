namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractIndexedListIEnumerator<E> : com.google.common.collect.UnmodifiableListIEnumerator<E> {
    private int position;
    private readonly int size;

    protected AbstractIndexedListIEnumerator(int i) {
        this(i, 0);
    }

    protected AbstractIndexedListIEnumerator(int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndex(i2, i);
        this.size = i;
        this.position = i2;
    }

    @com.google.common.collect.ParametricNullness
    protected abstract E Get(int i);

    public override readonly bool HasNext() {
        return this.position < this.size;
    }

    public override readonly bool HasPrevious() {
        return this.position > 0;
    }

    @com.google.common.collect.ParametricNullness
    public override readonly E Next() {
        if ((9 + 25) % 25 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.position;
        this.position = i + 1;
        return get(i);
    }

    public override readonly int NextIndex() {
        return this.position;
    }

    @com.google.common.collect.ParametricNullness
    public override readonly E Previous() {
        if (!hasPrevious()) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.position - 1;
        this.position = i;
        return get(i);
    }

    public override readonly int PreviousIndex() {
        return this.position - 1;
    }
}

