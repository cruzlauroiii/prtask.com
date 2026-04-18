namespace WillowMaze.Wasm.Decompiled;


public class Class3BiometricOrCredentialAuthPrompt {
    private readonly androidx.biometric.BiometricPrompt$PromptInfo mPromptInfo;

    Class3BiometricOrCredentialAuthPrompt(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        this.mPromptInfo = biometricPrompt$PromptInfo;
    }

    public static androidx.biometric.auth.AuthPrompt KyfHwGtOLMsCgufT(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence LpBvmwqODIBPfYYO(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public static bool ObAeimtGUHfwWuQM(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.isConfirmationRequired();
    }

    public static androidx.biometric.auth.AuthPrompt BmDzrVmvqMLOGpMg(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence IiMqEvibhNGCaquI(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getDescription();
    }

    public static java.lang.CharSequence QPCVoXlrkAmBMhvl(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getSubtitle();
    }

    public java.lang.CharSequence GetDescription() {
        return iiMqEvibhNGCaquI(this.mPromptInfo);
    }

    public java.lang.CharSequence GetSubtitle() {
        return qPCVoXlrkAmBMhvl(this.mPromptInfo);
    }

    public java.lang.CharSequence GetTitle() {
        return LpBvmwqODIBPfYYO(this.mPromptInfo);
    }

    public bool IsConfirmationRequired() {
        return ObAeimtGUHfwWuQM(this.mPromptInfo);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return bmDzrVmvqMLOGpMg(authPromptHost, this.mPromptInfo, biometricPrompt$Cryptoobject, null, authPromptCallback);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return KyfHwGtOLMsCgufT(authPromptHost, this.mPromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }
}

