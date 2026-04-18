namespace WillowMaze.Wasm.Decompiled;


class CryptoobjectUtils$Api33Impl {
    private CryptoobjectUtils$Api33Impl() {
    }

    static android.hardware.biometrics.BiometricPrompt$Cryptoobject create(android.security.identity.PresentationSession presentationSession) {
        return new android.hardware.biometrics.BiometricPrompt$Cryptoobject(presentationSession);
    }

    static android.security.identity.PresentationSession GetPresentationSession(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return qdqANdeqUlzIaLPs(biometricPrompt$Cryptoobject);
    }

    public static android.security.identity.PresentationSession QdqANdeqUlzIaLPs(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getPresentationSession();
    }
}

