namespace WillowMaze.Wasm.Decompiled;


class FingerprintManagerCompat$1 : android.hardware.fingerprint.FingerprintManager$AuthenticationCallback {
    readonly androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationCallback val$callback;

    FingerprintManagerCompat$1(androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationCallback fingerprintManagerCompat$AuthenticationCallback) {
        this.val$callback = fingerprintManagerCompat$AuthenticationCallback;
    }

    public override void OnAuthenticationError(int i, java.lang.CharSequence charSequence) {
        this.val$callback.onAuthenticationError(i, charSequence);
    }

    public override void OnAuthenticationFailed() {
        this.val$callback.onAuthenticationFailed();
    }

    public override void OnAuthenticationHelp(int i, java.lang.CharSequence charSequence) {
        this.val$callback.onAuthenticationHelp(i, charSequence);
    }

    public override void OnAuthenticationSucceeded(android.hardware.fingerprint.FingerprintManager$AuthenticationResult fingerprintManager$AuthenticationResult) {
        this.val$callback.onAuthenticationSucceeded(new androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationResult(androidx.core.hardware.fingerprint.FingerprintManagerCompat.unwrapCryptoobject(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Api23Impl.getCryptoobject(fingerprintManager$AuthenticationResult))));
    }
}

