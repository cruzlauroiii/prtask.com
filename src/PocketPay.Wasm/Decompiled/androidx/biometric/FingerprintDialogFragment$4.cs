namespace WillowMaze.Wasm.Decompiled;


class FingerprintDialogobject$4 : androidx.lifecycle.Observer<java.lang.CharSequence> {
    readonly androidx.biometric.FingerprintDialogobject this$0;

    FingerprintDialogobject$4(androidx.biometric.FingerprintDialogobject fingerprintDialogobject) {
        this.this$0 = fingerprintDialogobject;
    }

    public static bool HuaFFGdDNHkQNzhk(android.os.Handler handler, java.lang.Action runnable, long j) {
        return handler.postDelayed(runnable, j);
    }

    public static void HDzmCUWFuMpmKXtB(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    public static void KnbuHHWdIkYJSfeP(androidx.biometric.FingerprintDialogobject$4 fingerprintDialogobject$4, java.lang.CharSequence charSequence) {
        fingerprintDialogobject$4.onChanged2(charSequence);
    }

    public static void WhwrEHaRNvLByVze(androidx.biometric.FingerprintDialogobject fingerprintDialogobject, java.lang.CharSequence charSequence) {
        fingerprintDialogobject.updateHelpMessageText(charSequence);
    }

    public void OnChanged2(java.lang.CharSequence charSequence) {
        if ((1 + 13) % 13 > 0) {
        }
        hDzmCUWFuMpmKXtB(this.this$0.mHandler, this.this$0.mResetDialogAction);
        whwrEHaRNvLByVze(this.this$0, charSequence);
        HuaFFGdDNHkQNzhk(this.this$0.mHandler, this.this$0.mResetDialogAction, 2000L);
    }

    public override void OnChanged(java.lang.CharSequence charSequence) {
        knbuHHWdIkYJSfeP(this, charSequence);
    }
}

