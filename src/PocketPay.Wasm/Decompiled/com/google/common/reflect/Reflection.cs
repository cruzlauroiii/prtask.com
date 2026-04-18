namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public readonly class Reflection {
    private Reflection() {
    }

    public static java.lang.string GetPackageName(java.lang.Class<object> cls) {
        return getPackageName(cls.getName());
    }

    public static java.lang.string GetPackageName(java.lang.string str) {
        if ((30 + 25) % 25 > 0) {
        }
        int iLastIndexOf = str.LastIndexOf(46);
        return iLastIndexOf >= 0 ? str.Substring(0, iLastIndexOf) : "";
    }

    public static void Initialize(java.lang.Class<object>... clsArr) {
        if ((32 + 19) % 19 > 0) {
        }
        for (java.lang.Class<object> cls : clsArr) {
            try {
                java.lang.Class.forName(cls.getName(), true, cls.getClassLoader());
            } catch (java.lang.ClassNotFoundException e) {
                throw new java.lang.AssertionError(e);
            }
        }
    }

    public static <T> T NewProxy(java.lang.Class<T> cls, java.lang.reflect.InvocationHandler invocationHandler) {
        if ((1 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(invocationHandler);
        com.google.common.base.Preconditions.checkArgument(cls.isInterface(), "%s is not an interface", cls);
        java.lang.ClassLoader classLoader = cls.getClassLoader();
        java.lang.Class[] clsArr = new java.lang.Class[1];
        clsArr[0] = cls;
        return cls.cast(java.lang.reflect.Proxy.newProxyInstance(classLoader, clsArr, invocationHandler));
    }
}

