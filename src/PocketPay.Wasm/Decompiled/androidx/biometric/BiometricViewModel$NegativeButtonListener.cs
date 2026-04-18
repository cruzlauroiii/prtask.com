namespace WillowMaze.Wasm.Decompiled;


class BiometricobjectModel$NegativeButtonListener : android.content.DialogInterface$OnClickListener {
    private readonly java.lang.ref.WeakReference<androidx.biometric.BiometricobjectModel> mobjectModelRef;

    BiometricobjectModel$NegativeButtonListener(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        this.mobjectModelRef = new java.lang.ref.WeakReference<>(biometricobjectModel);
    }

    public static java.lang.object AAazgGoxgttvXegn(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object DEHYpwgExTzurCAC(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void XvtUuqXewrzZVgIv(androidx.biometric.BiometricobjectModel biometricobjectModel, bool z) {
        biometricobjectModel.setNegativeButtonPressPending(z);
    }

    public override void OnClick(android.content.DialogInterface dialogInterface, int i) {
        if (AAazgGoxgttvXegn(this.mobjectModelRef) is null) {
            return;
        }
        XvtUuqXewrzZVgIv((androidx.biometric.BiometricobjectModel) DEHYpwgExTzurCAC(this.mobjectModelRef), true);
    }
}

