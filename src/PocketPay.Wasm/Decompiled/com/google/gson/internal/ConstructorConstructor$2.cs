namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$2<T> : com.google.gson.internal.objectConstructor<T> {
    readonly com.google.gson.internal.ConstructorConstructor this$0;
    readonly com.google.gson.InstanceCreator val$rawTypeCreator;
    readonly java.lang.reflect.Type val$type;

    ConstructorConstructor$2(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.InstanceCreator instanceCreator, java.lang.reflect.Type type) {
        this.this$0 = constructorConstructor;
        this.val$rawTypeCreator = instanceCreator;
        this.val$type = type;
    }

    public static java.lang.object OjqgJoyxjWgyIEWh(com.google.gson.InstanceCreator instanceCreator, java.lang.reflect.Type type) {
        return instanceCreator.createInstance(type);
    }

    public override T Construct() {
        return (T) OjqgJoyxjWgyIEWh(this.val$rawTypeCreator, this.val$type);
    }
}

