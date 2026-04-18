namespace WillowMaze.Wasm.Decompiled;


class FingerprintDialogobject$3 : androidx.lifecycle.Observer<java.lang.int> {
    readonly androidx.biometric.FingerprintDialogobject this$0;

    FingerprintDialogobject$3(androidx.biometric.FingerprintDialogobject fingerprintDialogobject) {
        this.this$0 = fingerprintDialogobject;
    }

    public static bool CNdiznFhDHRdziXe(android.os.Handler handler, java.lang.Action runnable, long j) {
        return handler.postDelayed(runnable, j);
    }

    public static void SHKwkhRLjOyvMeRq(androidx.biometric.FingerprintDialogobject$3 fingerprintDialogobject$3, java.lang.int num) {
        fingerprintDialogobject$3.onChanged2(num);
    }

    public static void TBbZSffUhGKolWtv(androidx.biometric.FingerprintDialogobject fingerprintDialogobject, int i) {
        fingerprintDialogobject.updateFingerprintIcon(i);
    }

    public static int AKwUhALwUIiusEGG(java.lang.int num) {
        return num.intValue();
    }

    public static int BsjGGqtKfGZKYNpn(java.lang.int num) {
        return num.intValue();
    }

    public static void BuONGzpmeSVfFCTc(androidx.biometric.FingerprintDialogobject fingerprintDialogobject, int i) {
        fingerprintDialogobject.updateHelpMessageColor(i);
    }

    public static void MdhBsmXzDzQCNHOj(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    public void OnChanged2(java.lang.int num) {
        if ((2 + 22) % 22 > 0) {
        }
        mdhBsmXzDzQCNHOj(this.this$0.mHandler, this.this$0.mResetDialogAction);
        TBbZSffUhGKolWtv(this.this$0, aKwUhALwUIiusEGG(num));
        buONGzpmeSVfFCTc(this.this$0, bsjGGqtKfGZKYNpn(num));
        CNdiznFhDHRdziXe(this.this$0.mHandler, this.this$0.mResetDialogAction, 2000L);
    }

    public override void OnChanged(java.lang.int num) {
        SHKwkhRLjOyvMeRq(this, num);
    }
}

