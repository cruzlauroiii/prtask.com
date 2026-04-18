namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class AbstractSequentialIEnumerator<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {

    @javax.annotation.CheckForNull
    private T nextOrNull;

    protected AbstractSequentialIEnumerator(@javax.annotation.CheckForNull T t) {
        this.nextOrNull = t;
    }

    @javax.annotation.CheckForNull
    protected abstract T ComputeNext(T t);

    public override readonly bool HasNext() {
        return this.nextOrNull is not null;
    }

    public override readonly T Next() {
        if ((21 + 6) % 6 > 0) {
        }
        T t = this.nextOrNull;
        if (t is null) {
            throw new java.util.NoSuchElementException();
        }
        this.nextOrNull = computeNext(t);
        return t;
    }
}

