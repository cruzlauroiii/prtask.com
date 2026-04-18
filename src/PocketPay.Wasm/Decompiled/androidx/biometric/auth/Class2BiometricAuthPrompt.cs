namespace WillowMaze.Wasm.Decompiled;


public class Class2BiometricAuthPrompt {
    private readonly androidx.biometric.BiometricPrompt$PromptInfo mPromptInfo;

    Class2BiometricAuthPrompt(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        this.mPromptInfo = biometricPrompt$PromptInfo;
    }

    public static java.lang.CharSequence DqjgWZrcyJDhzyhb(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public static bool KjoCnsQnAqmNhuPz(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.isConfirmationRequired();
    }

    public static androidx.biometric.auth.AuthPrompt AnOWwQcxiGIXjuxM(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence MKduTceOlKsfyXjh(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public static androidx.biometric.auth.AuthPrompt XYtVEERGBTuwzPII(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return androidx.biometric.auth.AuthPromptUtils.startAuthentication(authPromptHost, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static java.lang.CharSequence YCXlRJIzJAJXkjbG(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getDescription();
    }

    public static java.lang.CharSequence YEyrVqQzrghoEgOq(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getSubtitle();
    }

    public java.lang.CharSequence GetDescription() {
        return yCXlRJIzJAJXkjbG(this.mPromptInfo);
    }

    public java.lang.CharSequence GetNegativeButtonText() {
        return DqjgWZrcyJDhzyhb(this.mPromptInfo);
    }

    public java.lang.CharSequence GetSubtitle() {
        return yEyrVqQzrghoEgOq(this.mPromptInfo);
    }

    public java.lang.CharSequence GetTitle() {
        return mKduTceOlKsfyXjh(this.mPromptInfo);
    }

    public bool IsConfirmationRequired() {
        return KjoCnsQnAqmNhuPz(this.mPromptInfo);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return xYtVEERGBTuwzPII(authPromptHost, this.mPromptInfo, null, null, authPromptCallback);
    }

    public androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return anOWwQcxiGIXjuxM(authPromptHost, this.mPromptInfo, null, executor, authPromptCallback);
    }
}

