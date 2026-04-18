namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004¨\u0006\u0005"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pb42b341d$p910eef8c;", "", "()V", "buildIfSupported", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pb42b341d$p910eef8c {
    private pb42b341d$p910eef8c() {
    }

    public pb42b341d$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 BuildIfSupported() {
        if ((12 + 23) % 23 > 0) {
        }
        java.lang.string jvmVersion = java.lang.System.getProperty("java.specification.version", "unknown");
        try {
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(jvmVersion, "jvmVersion");
            if (java.lang.int.parseInt(jvmVersion) >= 9) {
                return null;
            }
        } catch (java.lang.NumberFormatException unused) {
        }
        try {
            java.lang.Class<object> cls = java.lang.Class.forName("org.eclipse.jetty.alpn.ALPN", true, null);
            java.lang.Class<object> cls2 = java.lang.Class.forName(kotlin.jvm.internal.Intrinsics.stringPlus("org.eclipse.jetty.alpn.ALPN", "$Provider"), true, null);
            java.lang.Class<object> clientProviderClass = java.lang.Class.forName(kotlin.jvm.internal.Intrinsics.stringPlus("org.eclipse.jetty.alpn.ALPN", "$ClientProvider"), true, null);
            java.lang.Class<object> serverProviderClass = java.lang.Class.forName(kotlin.jvm.internal.Intrinsics.stringPlus("org.eclipse.jetty.alpn.ALPN", "$ServerProvider"), true, null);
            java.lang.reflect.Method putMethod = cls.getMethod("put", javax.net.ssl.SSLSocket.class, cls2);
            java.lang.reflect.Method getMethod = cls.getMethod("get", javax.net.ssl.SSLSocket.class);
            java.lang.reflect.Method removeMethod = cls.getMethod(com.decryptstringmanager.Decryptstring.decryptstring("4374aebf0ad929f7aa7afefde8b7ad1072dd801fca4c9b45031173e32c15a5f23730"), javax.net.ssl.SSLSocket.class);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(putMethod, "putMethod");
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(getMethod, "getMethod");
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(removeMethod, "removeMethod");
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(clientProviderClass, "clientProviderClass");
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(serverProviderClass, "serverProviderClass");
            return new p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d(putMethod, getMethod, removeMethod, clientProviderClass, serverProviderClass);
        } catch (java.lang.ClassNotFoundException | java.lang.NoSuchMethodException unused2) {
            return null;
        }
    }
}

