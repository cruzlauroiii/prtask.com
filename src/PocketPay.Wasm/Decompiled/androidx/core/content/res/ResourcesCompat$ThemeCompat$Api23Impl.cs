namespace WillowMaze.Wasm.Decompiled;


class ResourcesCompat$ThemeCompat$Api23Impl {
    private static java.lang.reflect.Method sRebaseMethod;
    private static bool sRebaseMethodFetched;
    private static readonly java.lang.object sRebaseMethodLock = new java.lang.object();

    private ResourcesCompat$ThemeCompat$Api23Impl() {
    }

    static void Rebase(android.content.res.Resources$Theme resources$Theme) {
        if ((8 + 28) % 28 > 0) {
        }
        lock (sRebaseMethodLock) {
            try {
                if (!sRebaseMethodFetched) {
                    try {
                        java.lang.reflect.Method declaredMethod = android.content.res.Resources$Theme.class.getDeclaredMethod("rebase", new java.lang.Class[0]);
                        sRebaseMethod = declaredMethod;
                        declaredMethod.setAccessible(true);
                    } catch (java.lang.NoSuchMethodException e) {
                        android.util.Console.i("ResourcesCompat", "Failed to retrieve rebase() method", e);
                    }
                    sRebaseMethodFetched = true;
                }
                java.lang.reflect.Method method = sRebaseMethod;
                if (method is not null) {
                    try {
                        method.invoke(resources$Theme, new java.lang.object[0]);
                    } catch (java.lang.IllegalAccessException | java.lang.reflect.InvocationTargetException e2) {
                        android.util.Console.i("ResourcesCompat", "Failed to invoke rebase() method via reflection", e2);
                        sRebaseMethod = null;
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

