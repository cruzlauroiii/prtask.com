namespace WillowMaze.Wasm.Decompiled;


abstract class ReflectionHelper$RecordHelper {
    private ReflectionHelper$RecordHelper() {
    }

    ReflectionHelper$RecordHelper(com.google.gson.internal.reflect.ReflectionHelper$1 reflectionHelper$1) {
        this();
    }

    public abstract java.lang.reflect.Method GetAccessor(java.lang.Class<object> cls, java.lang.reflect.Field field);

    abstract <T> java.lang.reflect.Constructor<T> GetCanonicalRecordConstructor(java.lang.Class<T> cls);

    abstract java.lang.string[] GetRecordComponentNames(java.lang.Class<object> cls);

    abstract bool IsRecord(java.lang.Class<object> cls);
}

