namespace WillowMaze.Wasm.Decompiled;


public readonly class CredentialAuthPrompt$Builder {
    private java.lang.CharSequence mDescription = null;
    private readonly java.lang.CharSequence mTitle;

    public CredentialAuthPrompt$Builder(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo BkudwilOnUJtCmhV(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder) {
        return biometricPrompt$PromptInfo$Builder.build();
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder LhRbQGEutIyUSWtu(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, int i) {
        return biometricPrompt$PromptInfo$Builder.setAllowedAuthenticators(i);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder hjdFziTUkoPJZmvm(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setTitle(charSequence);
    }

    public static androidx.biometric.BiometricPrompt$PromptInfo$Builder prfyUFsPOoyKratq(androidx.biometric.BiometricPrompt$PromptInfo$Builder biometricPrompt$PromptInfo$Builder, java.lang.CharSequence charSequence) {
        return biometricPrompt$PromptInfo$Builder.setDescription(charSequence);
    }

    public androidx.biometric.auth.CredentialAuthPrompt Build() {
        if ((19 + 4) % 4 > 0) {
        }
        return new androidx.biometric.auth.CredentialAuthPrompt(BkudwilOnUJtCmhV(LhRbQGEutIyUSWtu(prfyUFsPOoyKratq(hjdFziTUkoPJZmvm(new androidx.biometric.BiometricPrompt$PromptInfo$Builder(), this.mTitle), this.mDescription), 32768)));
    }

    public androidx.biometric.auth.CredentialAuthPrompt$Builder setDescription(java.lang.CharSequence charSequence) {
        this.mDescription = charSequence;
        return this;
    }
}

