namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$8<T> : com.google.gson.internal.objectConstructor<T> {
    readonly java.lang.string val$exceptionMessage;

    ConstructorConstructor$8(java.lang.string str) {
        this.val$exceptionMessage = str;
    }

    public override T Construct() {
        throw new com.google.gson.JsonIOException(this.val$exceptionMessage);
    }
}

