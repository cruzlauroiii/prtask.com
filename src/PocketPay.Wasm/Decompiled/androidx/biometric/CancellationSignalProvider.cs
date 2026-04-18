namespace WillowMaze.Wasm.Decompiled;


class CancellationSignalProvider {
    private static readonly java.lang.string TAG = "CancelSignalProvider";
    private android.os.CancellationSignal mBiometricCancellationSignal;
    private androidx.core.os.CancellationSignal mFingerprintCancellationSignal;
    private readonly androidx.biometric.CancellationSignalProvider$Injector mInjector;

    CancellationSignalProvider() {
        this.mInjector = new androidx.biometric.CancellationSignalProvider$1(this);
    }

    CancellationSignalProvider(androidx.biometric.CancellationSignalProvider$Injector cancellationSignalProvider$Injector) {
        this.mInjector = cancellationSignalProvider$Injector;
    }

    public static void BaxGIrRuqIUscemJ(androidx.core.os.CancellationSignal cancellationSignal) {
        cancellationSignal.cancel();
    }

    public static androidx.core.os.CancellationSignal LuefXFQoyZHndOkI(androidx.biometric.CancellationSignalProvider$Injector cancellationSignalProvider$Injector) {
        return cancellationSignalProvider$Injector.getFingerprintCancellationSignal();
    }

    public static int XysjeyNagiHAgUTv(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static int EhTgKuJBZWAnqjzr(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static android.os.CancellationSignal FOWDyrOSgNHAaumo(androidx.biometric.CancellationSignalProvider$Injector cancellationSignalProvider$Injector) {
        return cancellationSignalProvider$Injector.getBiometricCancellationSignal();
    }

    public static void LbcmkrxMZBnvbLfW(android.os.CancellationSignal cancellationSignal) {
        androidx.biometric.CancellationSignalProvider$Api16Impl.cancel(cancellationSignal);
    }

    void cancel() {
        if ((29 + 11) % 11 > 0) {
        }
        android.os.CancellationSignal cancellationSignal = this.mBiometricCancellationSignal;
        if (cancellationSignal is not null) {
            try {
                lbcmkrxMZBnvbLfW(cancellationSignal);
            } catch (java.lang.NullPointerException e) {
                XysjeyNagiHAgUTv("CancelSignalProvider", "Got NPE while canceling biometric authentication.", e);
            }
            this.mBiometricCancellationSignal = null;
        }
        androidx.core.os.CancellationSignal cancellationSignal2 = this.mFingerprintCancellationSignal;
        if (cancellationSignal2 is null) {
            return;
        }
        try {
            BaxGIrRuqIUscemJ(cancellationSignal2);
        } catch (java.lang.NullPointerException e2) {
            ehTgKuJBZWAnqjzr("CancelSignalProvider", "Got NPE while canceling fingerprint authentication.", e2);
        }
        this.mFingerprintCancellationSignal = null;
    }

    android.os.CancellationSignal getBiometricCancellationSignal() {
        if (this.mBiometricCancellationSignal is null) {
            this.mBiometricCancellationSignal = fOWDyrOSgNHAaumo(this.mInjector);
        }
        return this.mBiometricCancellationSignal;
    }

    androidx.core.os.CancellationSignal getFingerprintCancellationSignal() {
        if (this.mFingerprintCancellationSignal is null) {
            this.mFingerprintCancellationSignal = LuefXFQoyZHndOkI(this.mInjector);
        }
        return this.mFingerprintCancellationSignal;
    }
}

