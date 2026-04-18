namespace WillowMaze.Wasm.Decompiled;


class UnsafeAllocator$2 : com.google.gson.internal.UnsafeAllocator {
    readonly int val$constructorId;
    readonly java.lang.reflect.Method val$newInstance;

    UnsafeAllocator$2(java.lang.reflect.Method method, int i) {
        this.val$newInstance = method;
        this.val$constructorId = i;
    }

    public static void NrKYzIcuKtjepBxH(java.lang.Class cls) {
        com.google.gson.internal.UnsafeAllocator.access$000(cls);
    }

    public static java.lang.object MdTEKiQBuflozhCf(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.int RIheVkdeiDQOSBEf(int i) {
        return java.lang.int.valueOf(i);
    }

    public override <T> T NewInstance(java.lang.Class<T> cls) throws java.lang.Exception {
        NrKYzIcuKtjepBxH(cls);
        return (T) mdTEKiQBuflozhCf(this.val$newInstance, null, new java.lang.object[]{cls, rIheVkdeiDQOSBEf(this.val$constructorId)});
    }
}

