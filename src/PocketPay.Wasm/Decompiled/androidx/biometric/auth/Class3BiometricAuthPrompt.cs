namespace WillowMaze.Wasm.Decompiled;


public class Class3BiometricAuthPrompt {
    private readonly androidx.biometric.BiometricPrompt$PromptInfo mPromptInfo;

    Class3BiometricAuthPrompt(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        this.mPromptInfo = biometricPrompt$PromptInfo;
    }

    public static androidx.biometric.auth.AuthPrompt DotClgmbjhDRjwzr(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence HOYIjzsSSfigJZQZ(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getSubtitle();
    }

    public static java.lang.CharSequence TVcqUsUBvSdccAJI(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public static bool VxtWFFsEtWoggzdC(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.isConfirmationRequired();
    }

    public static java.lang.CharSequence KDSyTjmegCiHmvPV(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public static androidx.biometric.auth.AuthPrompt QLbHeKeOUSyKAvwI(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence VvadxOkgnSFAvoKV(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getDescription();
    }

    public java.lang.CharSequence GetDescription() {
        return vvadxOkgnSFAvoKV(this.mPromptInfo);
    }

    public java.lang.CharSequence GetNegativeButtonText() {
        return TVcqUsUBvSdccAJI(this.mPromptInfo);
    }

    public java.lang.CharSequence GetSubtitle() {
        return HOYIjzsSSfigJZQZ(this.mPromptInfo);
    }

    public java.lang.CharSequence GetTitle() {
        return kDSyTjmegCiHmvPV(this.mPromptInfo);
    }

    public bool IsConfirmationRequired() {
        return VxtWFFsEtWoggzdC(this.mPromptInfo);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return qLbHeKeOUSyKAvwI(authPromptHost, this.mPromptInfo, biometricPrompt$Cryptoobject, null, authPromptCallback);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return DotClgmbjhDRjwzr(authPromptHost, this.mPromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }
}

