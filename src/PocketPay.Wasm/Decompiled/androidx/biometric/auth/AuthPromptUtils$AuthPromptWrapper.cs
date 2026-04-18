namespace WillowMaze.Wasm.Decompiled;


class AuthPromptUtils$AuthPromptWrapper : androidx.biometric.auth.AuthPrompt {
    private readonly java.lang.ref.WeakReference<androidx.biometric.BiometricPrompt> mBiometricPromptRef;

    AuthPromptUtils$AuthPromptWrapper(androidx.biometric.BiometricPrompt biometricPrompt) {
        this.mBiometricPromptRef = new java.lang.ref.WeakReference<>(biometricPrompt);
    }

    public static java.lang.object XRDPBvlGZjUWfHPJ(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object OWelDuIltIZKciNY(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void SrRganwLxUUtjEfu(androidx.biometric.BiometricPrompt biometricPrompt) {
        biometricPrompt.cancelAuthentication();
    }

    public override void CancelAuthentication() {
        if (oWelDuIltIZKciNY(this.mBiometricPromptRef) is null) {
            return;
        }
        srRganwLxUUtjEfu((androidx.biometric.BiometricPrompt) XRDPBvlGZjUWfHPJ(this.mBiometricPromptRef));
    }
}

