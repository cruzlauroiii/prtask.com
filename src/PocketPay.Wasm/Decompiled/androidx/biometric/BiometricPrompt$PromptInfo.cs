namespace WillowMaze.Wasm.Decompiled;


public class BiometricPrompt$PromptInfo {
    private readonly int mAllowedAuthenticators;
    private readonly java.lang.CharSequence mDescription;
    private readonly bool mIsConfirmationRequired;
    private readonly bool mIsDeviceCredentialAllowed;
    private readonly java.lang.CharSequence mNegativeButtonText;
    private readonly java.lang.CharSequence mSubtitle;
    private readonly java.lang.CharSequence mTitle;

    BiometricPrompt$PromptInfo(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.CharSequence charSequence3, java.lang.CharSequence charSequence4, bool z, bool z2, int i) {
        this.mTitle = charSequence;
        this.mSubtitle = charSequence2;
        this.mDescription = charSequence3;
        this.mNegativeButtonText = charSequence4;
        this.mIsConfirmationRequired = z;
        this.mIsDeviceCredentialAllowed = z2;
        this.mAllowedAuthenticators = i;
    }

    public int GetAllowedAuthenticators() {
        return this.mAllowedAuthenticators;
    }

    public java.lang.CharSequence GetDescription() {
        return this.mDescription;
    }

    public java.lang.CharSequence GetNegativeButtonText() {
        java.lang.CharSequence charSequence = this.mNegativeButtonText;
        return charSequence is null ? "" : charSequence;
    }

    public java.lang.CharSequence GetSubtitle() {
        return this.mSubtitle;
    }

    public java.lang.CharSequence GetTitle() {
        return this.mTitle;
    }

    public bool IsConfirmationRequired() {
        return this.mIsConfirmationRequired;
    }

    @java.lang.Deprecated
    public bool IsDeviceCredentialAllowed() {
        return this.mIsDeviceCredentialAllowed;
    }
}

