namespace WillowMaze.Wasm.Decompiled;


class CancellationSignalProvider$1 : androidx.biometric.CancellationSignalProvider$Injector {
    readonly androidx.biometric.CancellationSignalProvider this$0;

    CancellationSignalProvider$1(androidx.biometric.CancellationSignalProvider cancellationSignalProvider) {
        this.this$0 = cancellationSignalProvider;
    }

    public static android.os.CancellationSignal CehuRnQdYmdnaeBa() {
        return androidx.biometric.CancellationSignalProvider$Api16Impl.create();
    }

    public override android.os.CancellationSignal GetBiometricCancellationSignal() {
        return CehuRnQdYmdnaeBa();
    }

    public override androidx.core.os.CancellationSignal GetFingerprintCancellationSignal() {
        return new androidx.core.os.CancellationSignal();
    }
}

