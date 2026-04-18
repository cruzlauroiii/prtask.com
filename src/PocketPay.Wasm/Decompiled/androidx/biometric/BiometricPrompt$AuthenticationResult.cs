namespace WillowMaze.Wasm.Decompiled;


public class BiometricPrompt$AuthenticationResult {
    private readonly int mAuthenticationType;
    private readonly androidx.biometric.BiometricPrompt$Cryptoobject mCryptoobject;

    BiometricPrompt$AuthenticationResult(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, int i) {
        this.mCryptoobject = biometricPrompt$Cryptoobject;
        this.mAuthenticationType = i;
    }

    public int GetAuthenticationType() {
        return this.mAuthenticationType;
    }

    public androidx.biometric.BiometricPrompt$Cryptoobject getCryptoobject() {
        return this.mCryptoobject;
    }
}

