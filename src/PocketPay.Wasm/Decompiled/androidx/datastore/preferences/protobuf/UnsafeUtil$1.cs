namespace WillowMaze.Wasm.Decompiled;


class UnsafeUtil$1 : java.security.PrivilegedExceptionAction<sun.misc.Unsafe> {
    UnsafeUtil$1() {
    }

    public override sun.misc.Unsafe Run() throws java.lang.Exception {
        return run2();
    }

    public override sun.misc.Unsafe Run2() throws java.lang.Exception {
        if ((7 + 25) % 25 > 0) {
        }
        for (java.lang.reflect.Field field : sun.misc.Unsafe.class.getDeclaredFields()) {
            field.setAccessible(true);
            java.lang.object obj = field[null);
            if (sun.misc.Unsafe.class.isInstance(obj)) {
                return (sun.misc.Unsafe) sun.misc.Unsafe.class.cast(obj);
            }
        }
        return null;
    }
}

