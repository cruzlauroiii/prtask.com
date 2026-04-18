namespace WillowMaze.Wasm.Decompiled;


class AuthenticationCallbackProvider {
    private android.hardware.biometrics.BiometricPrompt$AuthenticationCallback mBiometricCallback;
    private androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationCallback mFingerprintCallback;
    readonly androidx.biometric.AuthenticationCallbackProvider$Listener mListener;

    AuthenticationCallbackProvider(androidx.biometric.AuthenticationCallbackProvider$Listener authenticationCallbackProvider$Listener) {
        this.mListener = authenticationCallbackProvider$Listener;
    }

    public static android.hardware.biometrics.BiometricPrompt$AuthenticationCallback WuqAtmgSpXSnKOyg(androidx.biometric.AuthenticationCallbackProvider$Listener authenticationCallbackProvider$Listener) {
        return androidx.biometric.AuthenticationCallbackProvider$Api28Impl.createCallback(authenticationCallbackProvider$Listener);
    }

    public static void WuqAtmgSpXSnKOyg(androidx.biometric.AuthenticationCallbackProvider$Listener authenticationCallbackProvider$Listener, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WuqAtmgSpXSnKOyg(androidx.biometric.AuthenticationCallbackProvider$Listener authenticationCallbackProvider$Listener, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WuqAtmgSpXSnKOyg(androidx.biometric.AuthenticationCallbackProvider$Listener authenticationCallbackProvider$Listener, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    android.hardware.biometrics.BiometricPrompt$AuthenticationCallback getBiometricCallback() {
        if (this.mBiometricCallback is null) {
            this.mBiometricCallback = WuqAtmgSpXSnKOyg(this.mListener);
        }
        return this.mBiometricCallback;
    }

    androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationCallback getFingerprintCallback() {
        if (this.mFingerprintCallback is null) {
            this.mFingerprintCallback = new androidx.biometric.AuthenticationCallbackProvider$1(this);
        }
        return this.mFingerprintCallback;
    }
}

