namespace WillowMaze.Wasm.Decompiled;


public readonly class FingerprintManagerCompat$AuthenticationResult {
    private readonly androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject mCryptoobject;

    public FingerprintManagerCompat$AuthenticationResult(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject) {
        this.mCryptoobject = fingerprintManagerCompat$Cryptoobject;
    }

    public androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject getCryptoobject() {
        return this.mCryptoobject;
    }
}

