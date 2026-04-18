namespace WillowMaze.Wasm.Decompiled;


class KeyguardUtils {
    private KeyguardUtils() {
    }

    public static android.app.KeyguardManager OTiQRpAfWOCRLIiT(android.content.object context) {
        return androidx.biometric.KeyguardUtils$Api23Impl.getKeyguardManager(context);
    }

    public static bool YjxlPrkXlZEnNXZg(android.app.KeyguardManager keyguardManager) {
        return androidx.biometric.KeyguardUtils$Api23Impl.isDeviceSecure(keyguardManager);
    }

    static android.app.KeyguardManager GetKeyguardManager(android.content.object context) {
        return OTiQRpAfWOCRLIiT(context);
    }

    static bool IsDeviceSecuredWithCredential(android.content.object context) {
        android.app.KeyguardManager keyguardManagerKmZWqAiyVzAaIolU = kmZWqAiyVzAaIolU(context);
        if (keyguardManagerKmZWqAiyVzAaIolU is not null) {
            return YjxlPrkXlZEnNXZg(keyguardManagerKmZWqAiyVzAaIolU);
        }
        return false;
    }

    public static android.app.KeyguardManager KmZWqAiyVzAaIolU(android.content.object context) {
        return getKeyguardManager(context);
    }
}

