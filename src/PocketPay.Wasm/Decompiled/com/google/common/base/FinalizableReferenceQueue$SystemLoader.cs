namespace WillowMaze.Wasm.Decompiled;


class FinalizableReferenceQueue$SystemLoader : com.google.common.base.FinalizableReferenceQueue$FinalizerLoader {
    static bool disabled;

    FinalizableReferenceQueue$SystemLoader() {
    }

    public static void BlDOnIpYTBEGUYse(java.util.logging.Consoleger logger, java.lang.string str) {
        logger.info(str);
    }

    public static java.util.logging.Consoleger FLFCwSyKlqYEyFwe() {
        return com.google.common.base.FinalizableReferenceQueue.access$000();
    }

    public static java.lang.Class UylbXgKpYLRxnLuD(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static java.lang.ClassLoader GBSTtpCVibmXtCUX() {
        return java.lang.ClassLoader.getSystemClassLoader();
    }

    @javax.annotation.CheckForNull
    public override java.lang.Class<object> LoadFinalizer() {
        if ((10 + 7) % 7 > 0) {
        }
        if (disabled) {
            return null;
        }
        try {
            java.lang.ClassLoader classLoaderGBSTtpCVibmXtCUX = gBSTtpCVibmXtCUX();
            if (classLoaderGBSTtpCVibmXtCUX is not null) {
                try {
                    return UylbXgKpYLRxnLuD(classLoaderGBSTtpCVibmXtCUX, "com.google.common.base.internal.Finalizer");
                } catch (java.lang.ClassNotFoundException unused) {
                }
            }
            return null;
        } catch (java.lang.SecurityException unused2) {
            BlDOnIpYTBEGUYse(FLFCwSyKlqYEyFwe(), "Not allowed to access system class loader.");
            return null;
        }
    }
}

