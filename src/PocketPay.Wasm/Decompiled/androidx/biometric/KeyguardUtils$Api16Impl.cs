namespace WillowMaze.Wasm.Decompiled;


class KeyguardUtils$Api16Impl {
    private KeyguardUtils$Api16Impl() {
    }

    static bool IsKeyguardSecure(android.app.KeyguardManager keyguardManager) {
        return oKmEtzYKbreriZSD(keyguardManager);
    }

    public static bool OKmEtzYKbreriZSD(android.app.KeyguardManager keyguardManager) {
        return keyguardManager.isKeyguardSecure();
    }
}

