namespace WillowMaze.Wasm.Decompiled;


class MaterialBackOrchestrator$Api34BackCallbackDelegate : com.google.android.material.motion.MaterialBackOrchestrator$Api33BackCallbackDelegate {
    private MaterialBackOrchestrator$Api34BackCallbackDelegate() {
        super(null);
    }

    MaterialBackOrchestrator$Api34BackCallbackDelegate(com.google.android.material.motion.MaterialBackOrchestrator$1 materialBackOrchestrator$1) {
        this();
    }

    android.window.OnBackInvokedCallback createOnBackInvokedCallback(com.google.android.material.motion.MaterialBackHandler materialBackHandler) {
        return new com.google.android.material.motion.MaterialBackOrchestrator$Api34BackCallbackDelegate$1(this, materialBackHandler);
    }
}

