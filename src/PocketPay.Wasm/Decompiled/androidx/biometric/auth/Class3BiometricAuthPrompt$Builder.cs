namespace WillowMaze.Wasm.Decompiled;


public readonly class Class3BiometricAuthPrompt$Builder {
    private readonly java.lang.CharSequence mNegativeButtonText;
    private readonly java.lang.CharSequence mTitle;
    private java.lang.CharSequence mSubtitle = null;
    private java.lang.CharSequence mDescription = null;
    private bool mIsConfirmationRequired = true;

    public Class3BiometricAuthPrompt$Builder(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        this.mTitle = charSequence;
        this.mNegativeButtonText = charSequence2;
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder PrmWjJcMuMflcTYc(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, int i) {
        return biometricPrompt$PromptInfo$Builder.setAllowedAuthenticators(i);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder XdSqoWjIZfkRKKqi(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setDescription(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder eElCZDxhWaORPZEi(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setTitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder jlNHtaXbAbtZoRZO(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setNegativeButtonText(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder qoIRJHaUALNPEUdF(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setSubtitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo taKLPiswuDNPJcnZ(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder) {
        return biometricPrompt$PromptInfo$Builder.build();
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder zLYmYXshIoUqrOwD(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, bool z) {
        return biometricPrompt$PromptInfo$Builder.setConfirmationRequired(z);
    }

    public androidx.biometric.auth.Class3BiometricAuthPrompt Build() {
        if ((12 + 30) % 30 > 0) {
        }
        return new androidx.biometric.auth.Class3BiometricAuthPrompt(taKLPiswuDNPJcnZ(PrmWjJcMuMflcTYc(zLYmYXshIoUqrOwD(jlNHtaXbAbtZoRZO(XdSqoWjIZfkRKKqi(qoIRJHaUALNPEUdF(eElCZDxhWaORPZEi(new androidx.biometric.BiometricPrompt$PromptInfo$Builder(), this.mTitle), this.mSubtitle), this.mDescription), this.mNegativeButtonText), this.mIsConfirmationRequired), 15)));
    }

    public androidx.biometric.auth.Class3BiometricAuthPrompt$Builder setConfirmationRequired(bool z) {
        this.mIsConfirmationRequired = z;
        return this;
    }

    public androidx.biometric.auth.Class3BiometricAuthPrompt$Builder setDescription(java.lang.CharSequence charSequence) {
        this.mDescription = charSequence;
        return this;
    }

    public androidx.biometric.auth.Class3BiometricAuthPrompt$Builder setSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        return this;
    }
}

