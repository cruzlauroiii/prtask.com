namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$4<T> : com.google.gson.internal.objectConstructor<T> {
    readonly com.google.gson.internal.ConstructorConstructor this$0;
    readonly java.lang.string val$message;

    ConstructorConstructor$4(com.google.gson.internal.ConstructorConstructor constructorConstructor, java.lang.string str) {
        this.this$0 = constructorConstructor;
        this.val$message = str;
    }

    public override T Construct() {
        throw new com.google.gson.JsonIOException(this.val$message);
    }
}

