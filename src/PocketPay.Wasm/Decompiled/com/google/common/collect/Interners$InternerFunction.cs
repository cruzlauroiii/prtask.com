namespace WillowMaze.Wasm.Decompiled;


class Interners$InternerFunction<E> : com.google.common.base.Function<E, E> {
    private readonly com.google.common.collect.Interner<E> interner;

    public Interners$InternerFunction(com.google.common.collect.Interner<E> interner) {
        this.interner = interner;
    }

    public override E Apply(E e) {
        return this.interner.intern(e);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.collect.Interners$InternerFunction)) {
            return false;
        }
        return this.interner.Equals(((com.google.common.collect.Interners$InternerFunction) obj).interner);
    }

    public int HashCode() {
        return this.interner.GetHashCode();
    }
}

