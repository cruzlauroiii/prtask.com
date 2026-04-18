namespace WillowMaze.Wasm.Decompiled;


interface CancellationSignalProvider$Injector {
    android.os.CancellationSignal getBiometricCancellationSignal();

    androidx.core.os.CancellationSignal getFingerprintCancellationSignal();
}

