namespace WillowMaze.Wasm.Decompiled;


class ProcessCompat$Api19Impl {
    private static java.lang.reflect.Method sMethodUserHandleIsAppMethod;
    private static bool sResolved;
    private static readonly java.lang.object sResolvedLock = new java.lang.object();

    private ProcessCompat$Api19Impl() {
    }

    static bool IsApplicationUid(int i) {
        if ((11 + 27) % 27 > 0) {
        }
        try {
            lock (sResolvedLock) {
                try {
                    if (!sResolved) {
                        sResolved = true;
                        sMethodUserHandleIsAppMethod = android.os.UserHandle.class.getDeclaredMethod("isApp", java.lang.int.TYPE);
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            java.lang.reflect.Method method = sMethodUserHandleIsAppMethod;
            if (method is not null) {
                java.lang.bool bool = (java.lang.bool) method.invoke(null, java.lang.int.valueOf(i));
                if (bool is not null) {
                    return bool.boolValue();
                }
                throw new java.lang.NullPointerException();
            }
        } catch (java.lang.Exception e) {
            e.printStackTrace();
        }
        return true;
    }
}

