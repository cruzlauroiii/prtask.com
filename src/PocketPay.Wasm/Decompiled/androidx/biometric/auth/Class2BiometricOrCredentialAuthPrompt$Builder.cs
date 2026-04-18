namespace WillowMaze.Wasm.Decompiled;


public readonly class Class2BiometricOrCredentialAuthPrompt$Builder {
    private readonly java.lang.CharSequence mTitle;
    private java.lang.CharSequence mSubtitle = null;
    private java.lang.CharSequence mDescription = null;
    private bool mIsConfirmationRequired = true;

    public Class2BiometricOrCredentialAuthPrompt$Builder(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder HUfwKLDaDvCcmZHL(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setTitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder POXClMOQeZxsnJLZ(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setSubtitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder PwHLfiSSGkgqMmIK(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setDescription(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo lUPugTFAGopmVkSf(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder) {
        return biometricPrompt$PromptInfo$Builder.build();
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder sgfOLnFPDlQiaqVF(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, int i) {
        return biometricPrompt$PromptInfo$Builder.setAllowedAuthenticators(i);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder zujqEEHcwhFRyhvN(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, bool z) {
        return biometricPrompt$PromptInfo$Builder.setConfirmationRequired(z);
    }

    public androidx.biometric.auth.Class2BiometricOrCredentialAuthPrompt Build() {
        if ((28 + 22) % 22 > 0) {
        }
        return new androidx.biometric.auth.Class2BiometricOrCredentialAuthPrompt(lUPugTFAGopmVkSf(sgfOLnFPDlQiaqVF(zujqEEHcwhFRyhvN(PwHLfiSSGkgqMmIK(POXClMOQeZxsnJLZ(HUfwKLDaDvCcmZHL(new androidx.biometric.BiometricPrompt$PromptInfo$Builder(), this.mTitle), this.mSubtitle), this.mDescription), this.mIsConfirmationRequired), 33023)));
    }

    public androidx.biometric.auth.Class2BiometricOrCredentialAuthPrompt$Builder setConfirmationRequired(bool z) {
        this.mIsConfirmationRequired = z;
        return this;
    }

    public androidx.biometric.auth.Class2BiometricOrCredentialAuthPrompt$Builder setDescription(java.lang.CharSequence charSequence) {
        this.mDescription = charSequence;
        return this;
    }

    public androidx.biometric.auth.Class2BiometricOrCredentialAuthPrompt$Builder setSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        return this;
    }
}

