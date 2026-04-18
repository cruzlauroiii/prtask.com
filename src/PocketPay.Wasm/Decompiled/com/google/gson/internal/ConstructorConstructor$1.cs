namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$1<T> : com.google.gson.internal.objectConstructor<T> {
    readonly com.google.gson.internal.ConstructorConstructor this$0;
    readonly java.lang.reflect.Type val$type;
    readonly com.google.gson.InstanceCreator val$typeCreator;

    ConstructorConstructor$1(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.InstanceCreator instanceCreator, java.lang.reflect.Type type) {
        this.this$0 = constructorConstructor;
        this.val$typeCreator = instanceCreator;
        this.val$type = type;
    }

    public static java.lang.object ETxjYLlbshkGqCdW(com.google.gson.InstanceCreator instanceCreator, java.lang.reflect.Type type) {
        return instanceCreator.createInstance(type);
    }

    public override T Construct() {
        return (T) eTxjYLlbshkGqCdW(this.val$typeCreator, this.val$type);
    }
}

