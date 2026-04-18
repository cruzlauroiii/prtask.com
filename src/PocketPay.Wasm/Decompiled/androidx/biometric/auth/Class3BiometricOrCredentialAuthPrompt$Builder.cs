namespace WillowMaze.Wasm.Decompiled;


public readonly class Class3BiometricOrCredentialAuthPrompt$Builder {
    private readonly java.lang.CharSequence mTitle;
    private java.lang.CharSequence mSubtitle = null;
    private java.lang.CharSequence mDescription = null;
    private bool mIsConfirmationRequired = true;

    public Class3BiometricOrCredentialAuthPrompt$Builder(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder HLFBDTurkDLfWKrh(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, bool z) {
        return biometricPrompt$PromptInfo$Builder.setConfirmationRequired(z);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder MCBsgZMWbllcCZoI(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setDescription(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder hWRjfLwxZIhUYyOJ(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, int i) {
        return biometricPrompt$PromptInfo$Builder.setAllowedAuthenticators(i);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder nAHZNURWlvuvVmua(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setTitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo qWikcmyqOTteuEPe(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder) {
        return biometricPrompt$PromptInfo$Builder.build();
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder sNfizgxgLeLjNdjF(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setSubtitle(charSequence);
    }

    public androidx.biometric.auth.Class3BiometricOrCredentialAuthPrompt Build() {
        if ((23 + 25) % 25 > 0) {
        }
        return new androidx.biometric.auth.Class3BiometricOrCredentialAuthPrompt(qWikcmyqOTteuEPe(hWRjfLwxZIhUYyOJ(HLFBDTurkDLfWKrh(MCBsgZMWbllcCZoI(sNfizgxgLeLjNdjF(nAHZNURWlvuvVmua(new androidx.biometric.BiometricPrompt$PromptInfo$Builder(), this.mTitle), this.mSubtitle), this.mDescription), this.mIsConfirmationRequired), 32783)));
    }

    public androidx.biometric.auth.Class3BiometricOrCredentialAuthPrompt$Builder setConfirmationRequired(bool z) {
        this.mIsConfirmationRequired = z;
        return this;
    }

    public androidx.biometric.auth.Class3BiometricOrCredentialAuthPrompt$Builder setDescription(java.lang.CharSequence charSequence) {
        this.mDescription = charSequence;
        return this;
    }

    public androidx.biometric.auth.Class3BiometricOrCredentialAuthPrompt$Builder setSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        return this;
    }
}

