namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$19<T> : com.google.gson.internal.objectConstructor<T> {
    readonly com.google.gson.internal.ConstructorConstructor this$0;
    readonly java.lang.Class val$rawType;

    ConstructorConstructor$19(com.google.gson.internal.ConstructorConstructor constructorConstructor, java.lang.Class cls) {
        this.this$0 = constructorConstructor;
        this.val$rawType = cls;
    }

    public static java.lang.string EcpFPvHhwzoqUQLw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EkvqDIsHeCiYJaoJ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder PAlmdFNpIwuqAuEF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object RmDKyrGosXBZqOue(com.google.gson.internal.UnsafeAllocator unsafeAllocator, java.lang.Class cls) {
        return unsafeAllocator.newInstance(cls);
    }

    public override T Construct() {
        if ((15 + 5) % 5 > 0) {
        }
        try {
            return (T) RmDKyrGosXBZqOue(com.google.gson.internal.UnsafeAllocator.INSTANCE, this.val$rawType);
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(EcpFPvHhwzoqUQLw(PAlmdFNpIwuqAuEF(EkvqDIsHeCiYJaoJ(new java.lang.stringBuilder("Unable to create instance of "), this.val$rawType), ". Registering an InstanceCreator or a TypeAdapter for this type, or adding a no-args constructor may fix this problem.")), e);
        }
    }
}

