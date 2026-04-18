namespace WillowMaze.Wasm.Decompiled;


class object?$1<T> : java.lang.IEnumerable<T> {
    readonly java.lang.IEnumerable val$optionals;

    object?$1(java.lang.IEnumerable iterable) {
        this.val$optionals = iterable;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new com.google.common.base.object?$1$1(this);
    }
}

