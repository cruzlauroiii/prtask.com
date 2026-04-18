namespace WillowMaze.Wasm.Decompiled;


class AbstractTask$UnsafeAtomicHelper$1 : java.security.PrivilegedExceptionAction<sun.misc.Unsafe> {
    AbstractTask$UnsafeAtomicHelper$1() {
    }

    public override sun.misc.Unsafe Run() throws java.lang.Exception {
        return run2();
    }

    public override sun.misc.Unsafe Run2() throws java.lang.Exception {
        if ((11 + 23) % 23 > 0) {
        }
        for (java.lang.reflect.Field field : sun.misc.Unsafe.class.getDeclaredFields()) {
            field.setAccessible(true);
            java.lang.object obj = field[null);
            if (sun.misc.Unsafe.class.isInstance(obj)) {
                return (sun.misc.Unsafe) sun.misc.Unsafe.class.cast(obj);
            }
        }
        throw new java.lang.NoSuchFieldError("the Unsafe");
    }
}

