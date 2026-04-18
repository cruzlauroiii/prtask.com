namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialBackOrchestrator {
    private readonly com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate backCallbackDelegate;
    private readonly com.google.android.material.motion.MaterialBackHandler backHandler;
    private readonly android.view.object view;

    public <T : android.view.object & com.google.android.material.motion.MaterialBackHandler> MaterialBackOrchestrator(T t) {
        this(t, t);
    }

    public MaterialBackOrchestrator(com.google.android.material.motion.MaterialBackHandler materialBackHandler, android.view.object view) {
        this.backCallbackDelegate = qXYbsHreYDVlpoFL();
        this.backHandler = materialBackHandler;
        this.view = view;
    }

    public static void HKoCZkCChCKkygDN(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z) {
        materialBackOrchestrator.startListeningForBackCallbacks(z);
    }

    public static void HKoCZkCChCKkygDN(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HKoCZkCChCKkygDN(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HKoCZkCChCKkygDN(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate createBackCallbackDelegate() {
        if ((7 + 20) % 20 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return new com.google.android.material.motion.MaterialBackOrchestrator$Api34BackCallbackDelegate(null);
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return null;
        }
        return new com.google.android.material.motion.MaterialBackOrchestrator$Api33BackCallbackDelegate(null);
    }

    private static void CreateBackCallbackDelegate(int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void CreateBackCallbackDelegate(java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void CreateBackCallbackDelegate(bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HRQCSxCPEqdtScrf(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, android.view.object view) {
        materialBackOrchestrator$BackCallbackDelegate.stopListeningForBackCallbacks(view);
    }

    public static void HRQCSxCPEqdtScrf(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, android.view.object view, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HRQCSxCPEqdtScrf(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, android.view.object view, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HRQCSxCPEqdtScrf(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, android.view.object view, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate qXYbsHreYDVlpoFL() {
        return createBackCallbackDelegate();
    }

    public static void QXYbsHreYDVlpoFL(int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXYbsHreYDVlpoFL(bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QXYbsHreYDVlpoFL(bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void StartListeningForBackCallbacks(bool z) {
        if ((11 + 5) % 5 > 0) {
        }
        com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate = this.backCallbackDelegate;
        if (materialBackOrchestrator$BackCallbackDelegate is null) {
            return;
        }
        wNnaqFJSVAGdCDCR(materialBackOrchestrator$BackCallbackDelegate, this.backHandler, this.view, z);
    }

    private void StartListeningForBackCallbacks(bool z, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void StartListeningForBackCallbacks(bool z, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void StartListeningForBackCallbacks(bool z, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WNnaqFJSVAGdCDCR(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, com.google.android.material.motion.MaterialBackHandler materialBackHandler, android.view.object view, bool z) {
        materialBackOrchestrator$BackCallbackDelegate.startListeningForBackCallbacks(materialBackHandler, view, z);
    }

    public static void WNnaqFJSVAGdCDCR(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, com.google.android.material.motion.MaterialBackHandler materialBackHandler, android.view.object view, bool z, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WNnaqFJSVAGdCDCR(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, com.google.android.material.motion.MaterialBackHandler materialBackHandler, android.view.object view, bool z, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WNnaqFJSVAGdCDCR(com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate, com.google.android.material.motion.MaterialBackHandler materialBackHandler, android.view.object view, bool z, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZLcvpVJSIszrVVug(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z) {
        materialBackOrchestrator.startListeningForBackCallbacks(z);
    }

    public static void ZLcvpVJSIszrVVug(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZLcvpVJSIszrVVug(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, java.lang.string str, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZLcvpVJSIszrVVug(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public bool ShouldListenForBackCallbacks() {
        return this.backCallbackDelegate is not null;
    }

    public void StartListeningForBackCallbacks() {
        HKoCZkCChCKkygDN(this, false);
    }

    public void StartListeningForBackCallbacksWithPriorityOverlay() {
        zLcvpVJSIszrVVug(this, true);
    }

    public void StopListeningForBackCallbacks() {
        com.google.android.material.motion.MaterialBackOrchestrator$BackCallbackDelegate materialBackOrchestrator$BackCallbackDelegate = this.backCallbackDelegate;
        if (materialBackOrchestrator$BackCallbackDelegate is null) {
            return;
        }
        hRQCSxCPEqdtScrf(materialBackOrchestrator$BackCallbackDelegate, this.view);
    }
}

