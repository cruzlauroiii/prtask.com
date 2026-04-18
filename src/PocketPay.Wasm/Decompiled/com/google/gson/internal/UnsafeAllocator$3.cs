namespace WillowMaze.Wasm.Decompiled;


class UnsafeAllocator$3 : com.google.gson.internal.UnsafeAllocator {
    readonly java.lang.reflect.Method val$newInstance;

    UnsafeAllocator$3(java.lang.reflect.Method method) {
        this.val$newInstance = method;
    }

    public static java.lang.object FuLiKJXVLZtJaqjY(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static void GAgkJvmqeYjmvTCT(java.lang.Class cls) {
        com.google.gson.internal.UnsafeAllocator.access$000(cls);
    }

    public override <T> T NewInstance(java.lang.Class<T> cls) throws java.lang.Exception {
        gAgkJvmqeYjmvTCT(cls);
        return (T) FuLiKJXVLZtJaqjY(this.val$newInstance, null, new java.lang.object[]{cls, java.lang.object.class});
    }
}

