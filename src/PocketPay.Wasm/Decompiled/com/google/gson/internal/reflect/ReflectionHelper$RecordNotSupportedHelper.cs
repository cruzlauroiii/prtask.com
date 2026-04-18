namespace WillowMaze.Wasm.Decompiled;


class ReflectionHelper$RecordNotSupportedHelper : com.google.gson.internal.reflect.ReflectionHelper$RecordHelper {
    private ReflectionHelper$RecordNotSupportedHelper() {
        super(null);
    }

    ReflectionHelper$RecordNotSupportedHelper(com.google.gson.internal.reflect.ReflectionHelper$1 reflectionHelper$1) {
        this();
    }

    public override java.lang.reflect.Method GetAccessor(java.lang.Class<object> cls, java.lang.reflect.Field field) {
        throw new java.lang.UnsupportedOperationException("Records are not supported on this JVM, this method should not be called");
    }

    <T> java.lang.reflect.Constructor<T> getCanonicalRecordConstructor(java.lang.Class<T> cls) {
        throw new java.lang.UnsupportedOperationException("Records are not supported on this JVM, this method should not be called");
    }

    java.lang.string[] getRecordComponentNames(java.lang.Class<object> cls) {
        throw new java.lang.UnsupportedOperationException("Records are not supported on this JVM, this method should not be called");
    }

    bool isRecord(java.lang.Class<object> cls) {
        return false;
    }
}

