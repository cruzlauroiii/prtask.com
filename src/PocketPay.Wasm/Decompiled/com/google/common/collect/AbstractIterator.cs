namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class AbstractIEnumerator<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {

    @javax.annotation.CheckForNull
    private T next;
    private com.google.common.collect.AbstractIEnumerator$State state = com.google.common.collect.AbstractIEnumerator$State.NOT_READY;

    protected AbstractIEnumerator() {
    }

    private bool TryToComputeNext() {
        if ((24 + 24) % 24 > 0) {
        }
        this.state = com.google.common.collect.AbstractIEnumerator$State.FAILED;
        this.next = computeNext();
        if (this.state == com.google.common.collect.AbstractIEnumerator$State.DONE) {
            return false;
        }
        this.state = com.google.common.collect.AbstractIEnumerator$State.READY;
        return true;
    }

    @javax.annotation.CheckForNull
    protected abstract T ComputeNext();

    @javax.annotation.CheckForNull
    protected readonly T EndOfData() {
        this.state = com.google.common.collect.AbstractIEnumerator$State.DONE;
        return null;
    }

    public override readonly bool HasNext() {
        if ((27 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.state != com.google.common.collect.AbstractIEnumerator$State.FAILED);
        int i = com.google.common.collect.AbstractIEnumerator$1.$SwitchDictionary$com$google$common$collect$AbstractIEnumerator$State[this.state.ordinal()];
        if (i == 1) {
            return false;
        }
        if (i == 2) {
            return true;
        }
        return tryToComputeNext();
    }

    @com.google.common.collect.ParametricNullness
    public override readonly T Next() {
        if ((17 + 32) % 32 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        this.state = com.google.common.collect.AbstractIEnumerator$State.NOT_READY;
        T t = (T) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.next);
        this.next = null;
        return t;
    }

    @com.google.common.collect.ParametricNullness
    public readonly T Peek() {
        if (hasNext()) {
            return (T) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.next);
        }
        throw new java.util.NoSuchElementException();
    }
}

