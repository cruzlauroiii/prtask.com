namespace WillowMaze.Wasm.Decompiled;


class FingerprintDialogobject$2 : android.content.DialogInterface$OnClickListener {
    readonly androidx.biometric.FingerprintDialogobject this$0;

    FingerprintDialogobject$2(androidx.biometric.FingerprintDialogobject fingerprintDialogobject) {
        this.this$0 = fingerprintDialogobject;
    }

    public static void DKitcEGlsXHRzogh(androidx.biometric.BiometricobjectModel biometricobjectModel, bool z) {
        biometricobjectModel.setNegativeButtonPressPending(z);
    }

    public override void OnClick(android.content.DialogInterface dialogInterface, int i) {
        DKitcEGlsXHRzogh(this.this$0.mobjectModel, true);
    }
}

