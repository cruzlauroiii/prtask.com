namespace WillowMaze.Wasm.Decompiled;


public class Class2BiometricOrCredentialAuthPrompt {
    private readonly androidx.biometric.BiometricPrompt$PromptInfo mPromptInfo;

    Class2BiometricOrCredentialAuthPrompt(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        this.mPromptInfo = biometricPrompt$PromptInfo;
    }

    public static bool PGLSkBptnZeixpej(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.isConfirmationRequired();
    }

    public static androidx.biometric.auth.AuthPrompt HAyPuWiaqiGBJohE(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence MFguSkadigWjMBGJ(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getSubtitle();
    }

    public static java.lang.CharSequence MtLCokCGTIoChnyd(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getDescription();
    }

    public static java.lang.CharSequence SSgNOMfkzbVreMGm(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public static androidx.biometric.auth.AuthPrompt UHcLPXVcHqmsAFaO(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public java.lang.CharSequence GetDescription() {
        return mtLCokCGTIoChnyd(this.mPromptInfo);
    }

    public java.lang.CharSequence GetSubtitle() {
        return mFguSkadigWjMBGJ(this.mPromptInfo);
    }

    public java.lang.CharSequence GetTitle() {
        return sSgNOMfkzbVreMGm(this.mPromptInfo);
    }

    public bool IsConfirmationRequired() {
        return PGLSkBptnZeixpej(this.mPromptInfo);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return hAyPuWiaqiGBJohE(authPromptHost, this.mPromptInfo, null, null, authPromptCallback);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return uHcLPXVcHqmsAFaO(authPromptHost, this.mPromptInfo, null, executor, authPromptCallback);
    }
}

