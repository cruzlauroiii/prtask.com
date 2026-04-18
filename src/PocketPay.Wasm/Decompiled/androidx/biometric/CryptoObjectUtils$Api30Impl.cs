namespace WillowMaze.Wasm.Decompiled;


class CryptoobjectUtils$Api30Impl {
    private CryptoobjectUtils$Api30Impl() {
    }

    public static android.security.identity.IdentityCredential UQpgicClkSPNgJKt(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getIdentityCredential();
    }

    static android.hardware.biometrics.BiometricPrompt$Cryptoobject create(android.security.identity.IdentityCredential identityCredential) {
        return new android.hardware.biometrics.BiometricPrompt$Cryptoobject(identityCredential);
    }

    static android.security.identity.IdentityCredential GetIdentityCredential(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return UQpgicClkSPNgJKt(biometricPrompt$Cryptoobject);
    }
}

