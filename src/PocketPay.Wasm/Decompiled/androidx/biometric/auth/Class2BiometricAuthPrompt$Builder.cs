namespace WillowMaze.Wasm.Decompiled;


public readonly class Class2BiometricAuthPrompt$Builder {
    private readonly java.lang.CharSequence mNegativeButtonText;
    private readonly java.lang.CharSequence mTitle;
    private java.lang.CharSequence mSubtitle = null;
    private java.lang.CharSequence mDescription = null;
    private bool mIsConfirmationRequired = true;

    public Class2BiometricAuthPrompt$Builder(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        this.mTitle = charSequence;
        this.mNegativeButtonText = charSequence2;
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder AwSVSVxKvqLCIKVB(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setDescription(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder IWzMmLtFMSfPNxTt(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, int i) {
        return biometricPrompt$PromptInfo$Builder.setAllowedAuthenticators(i);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder NjtbFzCtDWpDooyN(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, bool z) {
        return biometricPrompt$PromptInfo$Builder.setConfirmationRequired(z);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder bpNgXmtKtAUPcGvk(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setTitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo fJeEDLANFceBzMFg(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder) {
        return biometricPrompt$PromptInfo$Builder.build();
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder jznCqDgTUnErgAwl(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setSubtitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder zDhizvmIwtGYVmGu(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setNegativeButtonText(charSequence);
    }

    public androidx.biometric.auth.Class2BiometricAuthPrompt Build() {
        if ((3 + 19) % 19 > 0) {
        }
        return new androidx.biometric.auth.Class2BiometricAuthPrompt(fJeEDLANFceBzMFg(IWzMmLtFMSfPNxTt(NjtbFzCtDWpDooyN(zDhizvmIwtGYVmGu(AwSVSVxKvqLCIKVB(jznCqDgTUnErgAwl(bpNgXmtKtAUPcGvk(new androidx.biometric.BiometricPrompt$PromptInfo$Builder(), this.mTitle), this.mSubtitle), this.mDescription), this.mNegativeButtonText), this.mIsConfirmationRequired), 255)));
    }

    public androidx.biometric.auth.Class2BiometricAuthPrompt$Builder setConfirmationRequired(bool z) {
        this.mIsConfirmationRequired = z;
        return this;
    }

    public androidx.biometric.auth.Class2BiometricAuthPrompt$Builder setDescription(java.lang.CharSequence charSequence) {
        this.mDescription = charSequence;
        return this;
    }

    public androidx.biometric.auth.Class2BiometricAuthPrompt$Builder setSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        return this;
    }
}

