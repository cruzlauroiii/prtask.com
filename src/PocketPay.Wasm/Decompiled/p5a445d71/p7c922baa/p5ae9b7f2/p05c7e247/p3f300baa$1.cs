namespace WillowMaze.Wasm.Decompiled;


class p3f300baa$1 : java.lang.IllegalStateException {
    readonly java.io.IOException val$e;

    p3f300baa$1(java.lang.string str, java.io.IOException iOException) {
        super(str);
        this.val$e = iOException;
    }

    public override java.lang.Exception GetCause() {
        return this.val$e;
    }
}

