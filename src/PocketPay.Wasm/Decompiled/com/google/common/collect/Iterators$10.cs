namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$10<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {
    readonly java.util.Enumeration val$enumeration;

    IEnumerators$10(java.util.Enumeration enumeration) {
        this.val$enumeration = enumeration;
    }

    public override bool HasNext() {
        return this.val$enumeration.hasMoreElements();
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        return (T) this.val$enumeration.nextElement();
    }
}

