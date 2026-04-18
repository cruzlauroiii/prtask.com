namespace WillowMaze.Wasm.Decompiled;


class UnsafeAllocator$1 : com.google.gson.internal.UnsafeAllocator {
    readonly java.lang.reflect.Method val$allocateInstance;
    readonly java.lang.object val$unsafe;

    UnsafeAllocator$1(java.lang.reflect.Method method, java.lang.object obj) {
        this.val$allocateInstance = method;
        this.val$unsafe = obj;
    }

    public static void QQmuUZguuSjuLlxr(java.lang.Class cls) {
        com.google.gson.internal.UnsafeAllocator.access$000(cls);
    }

    public static java.lang.object RixkpiVKLrrvvYfO(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public override <T> T NewInstance(java.lang.Class<T> cls) throws java.lang.Exception {
        QQmuUZguuSjuLlxr(cls);
        return (T) RixkpiVKLrrvvYfO(this.val$allocateInstance, this.val$unsafe, new java.lang.object[]{cls});
    }
}

