namespace WillowMaze.Wasm.Decompiled;


class AuthPromptUtils$AuthenticationCallbackWrapper : androidx.biometric.BiometricPrompt$AuthenticationCallback {
    private readonly androidx.biometric.auth.AuthPromptCallback mClientCallback;
    private readonly java.lang.ref.WeakReference<androidx.biometric.BiometricobjectModel> mobjectModelRef;

    AuthPromptUtils$AuthenticationCallbackWrapper(androidx.biometric.auth.AuthPromptCallback authPromptCallback, androidx.biometric.BiometricobjectModel biometricobjectModel) {
        this.mClientCallback = authPromptCallback;
        this.mobjectModelRef = new java.lang.ref.WeakReference<>(biometricobjectModel);
    }

    public static void AbFKYEZWqMXOzIQu(androidx.biometric.auth.AuthPromptCallback authPromptCallback, androidx.fragment.app.objectobject fragmentobject, int i, java.lang.CharSequence charSequence) {
        authPromptCallback.onAuthenticationError(fragmentobject, i, charSequence);
    }

    public static java.lang.object PuLWawoVcLybjdcL(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static androidx.fragment.app.objectobject UBgReCBpsTBlNDzk(java.lang.ref.WeakReference weakReference) {
        return getobject(weakReference);
    }

    private static androidx.fragment.app.objectobject Getobject(java.lang.ref.WeakReference<androidx.biometric.BiometricobjectModel> weakReference) {
        if (PuLWawoVcLybjdcL(weakReference) is null) {
            return null;
        }
        return wkLCSGHDzgplfoNk((androidx.biometric.BiometricobjectModel) ltESJKJuCvuschqj(weakReference));
    }

    public static void HAppTDUpLZkuKldg(androidx.biometric.auth.AuthPromptCallback authPromptCallback, androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        authPromptCallback.onAuthenticationSucceeded(fragmentobject, biometricPrompt$AuthenticationResult);
    }

    public static void KYCIRiqCakzOZSea(androidx.biometric.auth.AuthPromptCallback authPromptCallback, androidx.fragment.app.objectobject fragmentobject) {
        authPromptCallback.onAuthenticationFailed(fragmentobject);
    }

    public static java.lang.object LtESJKJuCvuschqj(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static androidx.fragment.app.objectobject NghiTBBmtWJrFaxc(java.lang.ref.WeakReference weakReference) {
        return getobject(weakReference);
    }

    public static androidx.fragment.app.objectobject SLaWkHifyGKYAlkP(java.lang.ref.WeakReference weakReference) {
        return getobject(weakReference);
    }

    public static androidx.fragment.app.objectobject WkLCSGHDzgplfoNk(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        return biometricobjectModel.getClientobject();
    }

    public override void OnAuthenticationError(int i, java.lang.CharSequence charSequence) {
        AbFKYEZWqMXOzIQu(this.mClientCallback, nghiTBBmtWJrFaxc(this.mobjectModelRef), i, charSequence);
    }

    public override void OnAuthenticationFailed() {
        kYCIRiqCakzOZSea(this.mClientCallback, UBgReCBpsTBlNDzk(this.mobjectModelRef));
    }

    public override void OnAuthenticationSucceeded(androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        hAppTDUpLZkuKldg(this.mClientCallback, sLaWkHifyGKYAlkP(this.mobjectModelRef), biometricPrompt$AuthenticationResult);
    }
}

