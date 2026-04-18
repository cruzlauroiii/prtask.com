namespace WillowMaze.Wasm.Decompiled;


public class BiometricPrompt$PromptInfo$Builder {
    private java.lang.CharSequence mTitle = null;
    private java.lang.CharSequence mSubtitle = null;
    private java.lang.CharSequence mDescription = null;
    private java.lang.CharSequence mNegativeButtonText = null;
    private bool mIsConfirmationRequired = true;
    private bool mIsDeviceCredentialAllowed = false;
    private int mAllowedAuthenticators = 0;

    public static bool BpcasoxBfCybWnvS(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool FIaTaZpIkUDfacbh(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool LihSTdFutNJYjPgO(int i) {
        return androidx.biometric.AuthenticatorUtils.isDeviceCredentialAllowed(i);
    }

    public static java.lang.stringBuilder QUrgejwWVLdKPKhm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SIJxidJSSVEzwvoY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string VpgAFJVIaBviQslU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string BCZbYfSLhxbiONxo(int i) {
        return androidx.biometric.AuthenticatorUtils.convertTostring(i);
    }

    public static bool HozpgwYxwJUMXNJE(int i) {
        return androidx.biometric.AuthenticatorUtils.isSupportedCombination(i);
    }

    public static bool RCngBQzbWNBsqRuZ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder WjKdiBOntqrMpkdB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public androidx.biometric.BiometricPrompt$PromptInfo build() {
        if ((8 + 13) % 13 > 0) {
        }
        if (FIaTaZpIkUDfacbh(this.mTitle)) {
            throw new java.lang.IllegalArgumentException("Title must be set and non-empty.");
        }
        if (!hozpgwYxwJUMXNJE(this.mAllowedAuthenticators)) {
            throw new java.lang.IllegalArgumentException(VpgAFJVIaBviQslU(QUrgejwWVLdKPKhm(wjKdiBOntqrMpkdB(SIJxidJSSVEzwvoY(new java.lang.stringBuilder("Authenticator combination is unsupported on API "), android.os.Build$VERSION.SDK_INT), ": "), bCZbYfSLhxbiONxo(this.mAllowedAuthenticators))));
        }
        int i = this.mAllowedAuthenticators;
        bool zLihSTdFutNJYjPgO = i == 0 ? this.mIsDeviceCredentialAllowed : LihSTdFutNJYjPgO(i);
        if (rCngBQzbWNBsqRuZ(this.mNegativeButtonText) && !zLihSTdFutNJYjPgO) {
            throw new java.lang.IllegalArgumentException("Negative text must be set and non-empty.");
        }
        if (!BpcasoxBfCybWnvS(this.mNegativeButtonText) && zLihSTdFutNJYjPgO) {
            throw new java.lang.IllegalArgumentException("Negative text must not be set if device credential authentication is allowed.");
        }
        return new androidx.biometric.BiometricPrompt$PromptInfo(this.mTitle, this.mSubtitle, this.mDescription, this.mNegativeButtonText, this.mIsConfirmationRequired, this.mIsDeviceCredentialAllowed, this.mAllowedAuthenticators);
    }

    public androidx.biometric.BiometricPrompt$PromptInfo$Builder setAllowedAuthenticators(int i) {
        this.mAllowedAuthenticators = i;
        return this;
    }

    public androidx.biometric.BiometricPrompt$PromptInfo$Builder setConfirmationRequired(bool z) {
        this.mIsConfirmationRequired = z;
        return this;
    }

    public androidx.biometric.BiometricPrompt$PromptInfo$Builder setDescription(java.lang.CharSequence charSequence) {
        this.mDescription = charSequence;
        return this;
    }

    @java.lang.Deprecated
    public androidx.biometric.BiometricPrompt$PromptInfo$Builder setDeviceCredentialAllowed(bool z) {
        this.mIsDeviceCredentialAllowed = z;
        return this;
    }

    public androidx.biometric.BiometricPrompt$PromptInfo$Builder setNegativeButtonText(java.lang.CharSequence charSequence) {
        this.mNegativeButtonText = charSequence;
        return this;
    }

    public androidx.biometric.BiometricPrompt$PromptInfo$Builder setSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        return this;
    }

    public androidx.biometric.BiometricPrompt$PromptInfo$Builder setTitle(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
        return this;
    }
}

