namespace WillowMaze.Wasm.Decompiled;


class BiometricPrompt$ResetCallbackObserver : androidx.lifecycle.DefaultLifecycleObserver {
    private readonly java.lang.ref.WeakReference<androidx.biometric.BiometricobjectModel> mobjectModelRef;

    BiometricPrompt$ResetCallbackObserver(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        this.mobjectModelRef = new java.lang.ref.WeakReference<>(biometricobjectModel);
    }

    public static void ELbGfxcWFcNjKpWN(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        biometricobjectModel.resetClientCallback();
    }

    public static java.lang.object GZdDgkJSVklckYNo(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object PteUltRjLtxqupkh(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public override void OnDestroy(androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        if (pteUltRjLtxqupkh(this.mobjectModelRef) is null) {
            return;
        }
        ELbGfxcWFcNjKpWN((androidx.biometric.BiometricobjectModel) GZdDgkJSVklckYNo(this.mobjectModelRef));
    }
}

