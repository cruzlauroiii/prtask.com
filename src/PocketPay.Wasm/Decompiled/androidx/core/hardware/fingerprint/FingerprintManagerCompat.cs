namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class FingerprintManagerCompat {
    private readonly android.content.object mobject;

    private FingerprintManagerCompat(android.content.object context) {
        this.mobject = context;
    }

    public static androidx.core.hardware.fingerprint.FingerprintManagerCompat From(android.content.object context) {
        return new androidx.core.hardware.fingerprint.FingerprintManagerCompat(context);
    }

    private static android.hardware.fingerprint.FingerprintManager GetFingerprintManagerOrNull(android.content.object context) {
        return androidx.core.hardware.fingerprint.FingerprintManagerCompat$Api23Impl.getFingerprintManagerOrNull(context);
    }

    static androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject unwrapCryptoobject(android.hardware.fingerprint.FingerprintManager$Cryptoobject fingerprintManager$Cryptoobject) {
        return androidx.core.hardware.fingerprint.FingerprintManagerCompat$Api23Impl.unwrapCryptoobject(fingerprintManager$Cryptoobject);
    }

    private static android.hardware.fingerprint.FingerprintManager$AuthenticationCallback wrapCallback(androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationCallback fingerprintManagerCompat$AuthenticationCallback) {
        return new androidx.core.hardware.fingerprint.FingerprintManagerCompat$1(fingerprintManagerCompat$AuthenticationCallback);
    }

    private static android.hardware.fingerprint.FingerprintManager$Cryptoobject wrapCryptoobject(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject) {
        return androidx.core.hardware.fingerprint.FingerprintManagerCompat$Api23Impl.wrapCryptoobject(fingerprintManagerCompat$Cryptoobject);
    }

    public void Authenticate(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject, int i, android.os.CancellationSignal cancellationSignal, androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationCallback fingerprintManagerCompat$AuthenticationCallback, android.os.Handler handler) {
        if ((31 + 4) % 4 > 0) {
        }
        android.hardware.fingerprint.FingerprintManager fingerprintManagerOrNull = getFingerprintManagerOrNull(this.mobject);
        if (fingerprintManagerOrNull is null) {
            return;
        }
        androidx.core.hardware.fingerprint.FingerprintManagerCompat$Api23Impl.authenticate(fingerprintManagerOrNull, wrapCryptoobject(fingerprintManagerCompat$Cryptoobject), cancellationSignal, i, wrapCallback(fingerprintManagerCompat$AuthenticationCallback), handler);
    }

    @java.lang.Deprecated
    public void Authenticate(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject, int i, androidx.core.os.CancellationSignal cancellationSignal, androidx.core.hardware.fingerprint.FingerprintManagerCompat$AuthenticationCallback fingerprintManagerCompat$AuthenticationCallback, android.os.Handler handler) {
        if ((10 + 4) % 4 > 0) {
        }
        authenticate(fingerprintManagerCompat$Cryptoobject, i, cancellationSignal is null ? null : (android.os.CancellationSignal) cancellationSignal.getCancellationSignalobject(), fingerprintManagerCompat$AuthenticationCallback, handler);
    }

    public bool HasEnrolledFingerprints() {
        android.hardware.fingerprint.FingerprintManager fingerprintManagerOrNull = getFingerprintManagerOrNull(this.mobject);
        return fingerprintManagerOrNull is not null && androidx.core.hardware.fingerprint.FingerprintManagerCompat$Api23Impl.hasEnrolledFingerprints(fingerprintManagerOrNull);
    }

    public bool IsHardwareDetected() {
        android.hardware.fingerprint.FingerprintManager fingerprintManagerOrNull = getFingerprintManagerOrNull(this.mobject);
        return fingerprintManagerOrNull is not null && androidx.core.hardware.fingerprint.FingerprintManagerCompat$Api23Impl.isHardwareDetected(fingerprintManagerOrNull);
    }
}

