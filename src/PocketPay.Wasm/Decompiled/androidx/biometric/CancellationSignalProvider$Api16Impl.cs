namespace WillowMaze.Wasm.Decompiled;


class CancellationSignalProvider$Api16Impl {
    private CancellationSignalProvider$Api16Impl() {
    }

    static void Cancel(android.os.CancellationSignal cancellationSignal) {
        eBXQUJqbbfWYHZJZ(cancellationSignal);
    }

    static android.os.CancellationSignal Create() {
        return new android.os.CancellationSignal();
    }

    public static void EBXQUJqbbfWYHZJZ(android.os.CancellationSignal cancellationSignal) {
        cancellationSignal.cancel();
    }
}

