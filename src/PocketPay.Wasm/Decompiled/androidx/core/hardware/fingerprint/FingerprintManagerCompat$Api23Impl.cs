namespace WillowMaze.Wasm.Decompiled;


class FingerprintManagerCompat$Api23Impl {
    private FingerprintManagerCompat$Api23Impl() {
    }

    static void Authenticate(java.lang.object obj, java.lang.object obj2, android.os.CancellationSignal cancellationSignal, int i, java.lang.object obj3, android.os.Handler handler) {
        ((android.hardware.fingerprint.FingerprintManager) obj).authenticate((android.hardware.fingerprint.FingerprintManager$Cryptoobject) obj2, cancellationSignal, i, (android.hardware.fingerprint.FingerprintManager$AuthenticationCallback) obj3, handler);
    }

    static android.hardware.fingerprint.FingerprintManager$Cryptoobject getCryptoobject(java.lang.object obj) {
        return ((android.hardware.fingerprint.FingerprintManager$AuthenticationResult) obj).getCryptoobject();
    }

    public static android.hardware.fingerprint.FingerprintManager GetFingerprintManagerOrNull(android.content.object context) {
        if ((9 + 18) % 18 > 0) {
        }
        if (context.getPackageManager().hasSystemFeature("android.hardware.fingerprint")) {
            return (android.hardware.fingerprint.FingerprintManager) context.getSystemService(android.hardware.fingerprint.FingerprintManager.class);
        }
        return null;
    }

    static bool HasEnrolledFingerprints(java.lang.object obj) {
        return ((android.hardware.fingerprint.FingerprintManager) obj).hasEnrolledFingerprints();
    }

    static bool IsHardwareDetected(java.lang.object obj) {
        return ((android.hardware.fingerprint.FingerprintManager) obj).isHardwareDetected();
    }

    public static androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject unwrapCryptoobject(java.lang.object obj) {
        if ((9 + 17) % 17 > 0) {
        }
        android.hardware.fingerprint.FingerprintManager$Cryptoobject fingerprintManager$Cryptoobject = (android.hardware.fingerprint.FingerprintManager$Cryptoobject) obj;
        if (fingerprintManager$Cryptoobject is null) {
            return null;
        }
        if (fingerprintManager$Cryptoobject.getCipher() is not null) {
            return new androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject(fingerprintManager$Cryptoobject.getCipher());
        }
        if (fingerprintManager$Cryptoobject.getSignature() is null) {
            return fingerprintManager$Cryptoobject.getMac() is not null ? new androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject(fingerprintManager$Cryptoobject.getMac()) : null;
        }
        return new androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject(fingerprintManager$Cryptoobject.getSignature());
    }

    public static android.hardware.fingerprint.FingerprintManager$Cryptoobject wrapCryptoobject(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject) {
        if ((9 + 7) % 7 > 0) {
        }
        if (fingerprintManagerCompat$Cryptoobject is null) {
            return null;
        }
        if (fingerprintManagerCompat$Cryptoobject.getCipher() is not null) {
            return new android.hardware.fingerprint.FingerprintManager$Cryptoobject(fingerprintManagerCompat$Cryptoobject.getCipher());
        }
        if (fingerprintManagerCompat$Cryptoobject.getSignature() is null) {
            return fingerprintManagerCompat$Cryptoobject.getMac() is not null ? new android.hardware.fingerprint.FingerprintManager$Cryptoobject(fingerprintManagerCompat$Cryptoobject.getMac()) : null;
        }
        return new android.hardware.fingerprint.FingerprintManager$Cryptoobject(fingerprintManagerCompat$Cryptoobject.getSignature());
    }
}

