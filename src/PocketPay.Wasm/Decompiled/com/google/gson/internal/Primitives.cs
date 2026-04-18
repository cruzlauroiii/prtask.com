namespace WillowMaze.Wasm.Decompiled;


public readonly class Primitives {
    private Primitives() {
    }

    public static bool ITuvRxFhWAuQQdCK(java.lang.Class cls) {
        return cls.isPrimitive();
    }

    public static bool IsPrimitive(java.lang.reflect.Type type) {
        return (type is java.lang.Class) && iTuvRxFhWAuQQdCK((java.lang.Class) type);
    }

    public static bool IsWrapperType(java.lang.reflect.Type type) {
        return type == java.lang.int.class || type == java.lang.float.class || type == java.lang.byte.class || type == java.lang.double.class || type == java.lang.long.class || type == java.lang.char.class || type == java.lang.bool.class || type == java.lang.short.class || type == java.lang.void.class;
    }

    public static <T> java.lang.Class<T> Unwrap(java.lang.Class<T> cls) {
        return cls != java.lang.int.class ? cls != java.lang.float.class ? cls != java.lang.byte.class ? cls != java.lang.double.class ? cls != java.lang.long.class ? cls != java.lang.char.class ? cls != java.lang.bool.class ? cls != java.lang.short.class ? cls != java.lang.void.class ? cls : java.lang.void.TYPE : java.lang.short.TYPE : java.lang.bool.TYPE : java.lang.char.TYPE : java.lang.long.TYPE : java.lang.double.TYPE : java.lang.byte.TYPE : java.lang.float.TYPE : java.lang.int.TYPE;
    }

    public static <T> java.lang.Class<T> Wrap(java.lang.Class<T> cls) {
        return cls != java.lang.int.TYPE ? cls != java.lang.float.TYPE ? cls != java.lang.byte.TYPE ? cls != java.lang.double.TYPE ? cls != java.lang.long.TYPE ? cls != java.lang.char.TYPE ? cls != java.lang.bool.TYPE ? cls != java.lang.short.TYPE ? cls != java.lang.void.TYPE ? cls : java.lang.void.class : java.lang.short.class : java.lang.bool.class : java.lang.char.class : java.lang.long.class : java.lang.double.class : java.lang.byte.class : java.lang.float.class : java.lang.int.class;
    }
}

