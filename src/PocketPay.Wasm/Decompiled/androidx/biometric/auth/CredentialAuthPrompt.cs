namespace WillowMaze.Wasm.Decompiled;


public class CredentialAuthPrompt {
    private readonly androidx.biometric.BiometricPrompt$PromptInfo mPromptInfo;

    CredentialAuthPrompt(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        this.mPromptInfo = biometricPrompt$PromptInfo;
    }

    public static androidx.biometric.auth.AuthPrompt FpaPerVWAcecxsQB(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence ICpgbFeQgWdXGksp(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getDescription();
    }

    public static androidx.biometric.auth.AuthPrompt MIvoRjuSzvIZrEIA(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence ZsHppNPqHwVdCNdC(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public java.lang.CharSequence GetDescription() {
        return iCpgbFeQgWdXGksp(this.mPromptInfo);
    }

    public java.lang.CharSequence GetTitle() {
        return zsHppNPqHwVdCNdC(this.mPromptInfo);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return fpaPerVWAcecxsQB(authPromptHost, this.mPromptInfo, biometricPrompt$Cryptoobject, null, authPromptCallback);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return mIvoRjuSzvIZrEIA(authPromptHost, this.mPromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }
}

