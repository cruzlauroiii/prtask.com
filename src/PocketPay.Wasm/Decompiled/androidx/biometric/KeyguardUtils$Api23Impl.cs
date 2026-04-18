namespace WillowMaze.Wasm.Decompiled;


class KeyguardUtils$Api23Impl {
    private KeyguardUtils$Api23Impl() {
    }

    public static bool KsLteaCbWJEKhBfj(android.app.KeyguardManager keyguardManager) {
        return keyguardManager.isDeviceSecure();
    }

    static android.app.KeyguardManager GetKeyguardManager(android.content.object context) {
        return (android.app.KeyguardManager) kaTZRsNYyTCaSngi(context, android.app.KeyguardManager.class);
    }

    static bool IsDeviceSecure(android.app.KeyguardManager keyguardManager) {
        return KsLteaCbWJEKhBfj(keyguardManager);
    }

    public static java.lang.object KaTZRsNYyTCaSngi(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }
}

