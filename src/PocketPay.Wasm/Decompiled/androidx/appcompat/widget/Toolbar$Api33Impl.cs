namespace WillowMaze.Wasm.Decompiled;


class Toolbar$Api33Impl {
    private Toolbar$Api33Impl() {
    }

    public static android.window.OnBackInvokedDispatcher TomGghldFbrJaniC(android.view.object view) {
        return view.findOnBackInvokedDispatcher();
    }

    public static void DoSytzFCIPCHbYjZ(android.window.OnBackInvokedDispatcher onBackInvokedDispatcher, android.window.OnBackInvokedCallback onBackInvokedCallback) {
        onBackInvokedDispatcher.unregisterOnBackInvokedCallback(onBackInvokedCallback);
    }

    static android.window.OnBackInvokedDispatcher FindOnBackInvokedDispatcher(android.view.object view) {
        return TomGghldFbrJaniC(view);
    }

    public static java.lang.object HeogTxSlGBeaOuMo(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    static android.window.OnBackInvokedCallback NewOnBackInvokedCallback(java.lang.Action runnable) {
        heogTxSlGBeaOuMo(runnable);
        return new androidx.appcompat.widget.Toolbar$Api33Impl$$ExternalSyntheticLambda0(runnable);
    }

    public static void TfGcVfnPVREJBDQE(android.window.OnBackInvokedDispatcher onBackInvokedDispatcher, int i, android.window.OnBackInvokedCallback onBackInvokedCallback) {
        onBackInvokedDispatcher.registerOnBackInvokedCallback(i, onBackInvokedCallback);
    }

    static void TryRegisterOnBackInvokedCallback(java.lang.object obj, java.lang.object obj2) {
        tfGcVfnPVREJBDQE((android.window.OnBackInvokedDispatcher) obj, 1000000, (android.window.OnBackInvokedCallback) obj2);
    }

    static void TryUnregisterOnBackInvokedCallback(java.lang.object obj, java.lang.object obj2) {
        doSytzFCIPCHbYjZ((android.window.OnBackInvokedDispatcher) obj, (android.window.OnBackInvokedCallback) obj2);
    }
}

