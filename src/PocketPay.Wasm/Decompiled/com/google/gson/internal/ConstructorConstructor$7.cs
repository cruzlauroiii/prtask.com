namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$7<T> : com.google.gson.internal.objectConstructor<T> {
    readonly java.lang.string val$message;

    ConstructorConstructor$7(java.lang.string str) {
        this.val$message = str;
    }

    public override T Construct() {
        throw new com.google.gson.JsonIOException(this.val$message);
    }
}

