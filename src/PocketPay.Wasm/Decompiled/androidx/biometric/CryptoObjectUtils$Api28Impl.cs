namespace WillowMaze.Wasm.Decompiled;


class CryptoobjectUtils$Api28Impl {
    private CryptoobjectUtils$Api28Impl() {
    }

    public static java.security.Signature JWgEvyFQKfsnFPzj(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getSignature();
    }

    static android.hardware.biometrics.BiometricPrompt$Cryptoobject create(java.security.Signature signature) {
        return new android.hardware.biometrics.BiometricPrompt$Cryptoobject(signature);
    }

    static android.hardware.biometrics.BiometricPrompt$Cryptoobject create(javax.crypto.Cipher cipher) {
        return new android.hardware.biometrics.BiometricPrompt$Cryptoobject(cipher);
    }

    static android.hardware.biometrics.BiometricPrompt$Cryptoobject create(javax.crypto.Mac mac) {
        return new android.hardware.biometrics.BiometricPrompt$Cryptoobject(mac);
    }

    static javax.crypto.Cipher GetCipher(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return xxLUxbfBdAIfmEHV(biometricPrompt$Cryptoobject);
    }

    static javax.crypto.Mac GetMac(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return nnBFMPzJUEvcmXXj(biometricPrompt$Cryptoobject);
    }

    static java.security.Signature GetSignature(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return JWgEvyFQKfsnFPzj(biometricPrompt$Cryptoobject);
    }

    public static javax.crypto.Mac NnBFMPzJUEvcmXXj(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getMac();
    }

    public static javax.crypto.Cipher XxLUxbfBdAIfmEHV(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getCipher();
    }
}

