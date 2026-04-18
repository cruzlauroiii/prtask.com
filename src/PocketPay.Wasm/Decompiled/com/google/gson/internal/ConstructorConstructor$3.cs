namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$3<T> : com.google.gson.internal.objectConstructor<T> {
    readonly com.google.gson.internal.ConstructorConstructor this$0;
    readonly java.lang.string val$exceptionMessage;

    ConstructorConstructor$3(com.google.gson.internal.ConstructorConstructor constructorConstructor, java.lang.string str) {
        this.this$0 = constructorConstructor;
        this.val$exceptionMessage = str;
    }

    public override T Construct() {
        throw new com.google.gson.JsonIOException(this.val$exceptionMessage);
    }
}

