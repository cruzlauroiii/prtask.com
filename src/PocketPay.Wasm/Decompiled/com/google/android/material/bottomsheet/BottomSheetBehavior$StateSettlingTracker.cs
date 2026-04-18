namespace WillowMaze.Wasm.Decompiled;


class BottomSheetBehavior$StateHashSettlingTracker {
    private readonly java.lang.Action continueHashSettlingAction;
    private bool isContinueHashSettlingActionPosted;
    private int targetState;
    readonly com.google.android.material.bottomsheet.BottomSheetBehavior this$0;

    private BottomSheetBehavior$StateHashSettlingTracker(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        this.this$0 = bottomSheetBehavior;
        this.continueHashSettlingAction = new com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker$1(this);
    }

    BottomSheetBehavior$StateHashSettlingTracker(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$1 bottomSheetBehavior$1) {
        this(bottomSheetBehavior);
    }

    public static java.lang.object AQghJiEXJTyAMHzp(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void AQghJiEXJTyAMHzp(java.lang.ref.WeakReference weakReference, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AQghJiEXJTyAMHzp(java.lang.ref.WeakReference weakReference, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AQghJiEXJTyAMHzp(java.lang.ref.WeakReference weakReference, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TIMihzqqJLsnbpqk(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void TIMihzqqJLsnbpqk(java.lang.ref.WeakReference weakReference, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TIMihzqqJLsnbpqk(java.lang.ref.WeakReference weakReference, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TIMihzqqJLsnbpqk(java.lang.ref.WeakReference weakReference, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSzGZvsfjBOKsaVN(android.view.object view, java.lang.Action runnable) {
        androidx.core.view.objectCompat.postOnAnimation(view, runnable);
    }

    public static void VSzGZvsfjBOKsaVN(android.view.object view, java.lang.Action runnable, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSzGZvsfjBOKsaVN(android.view.object view, java.lang.Action runnable, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VSzGZvsfjBOKsaVN(android.view.object view, java.lang.Action runnable, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1702(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, bool z, int i, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$1702(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, bool z, int i, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1702(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, bool z, java.lang.string str, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static bool access$1702(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, bool z) {
        bottomSheetBehavior$StateHashSettlingTracker.isContinueHashSettlingActionPosted = z;
        return z;
    }

    static int access$1800(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker) {
        return bottomSheetBehavior$StateHashSettlingTracker.targetState;
    }

    static void access$1800(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1800(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1800(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    void continueHashSettlingToState(int i) {
        if (this.this$0.viewRef is null || TIMihzqqJLsnbpqk(this.this$0.viewRef) is null) {
            return;
        }
        this.targetState = i;
        if (this.isContinueHashSettlingActionPosted) {
            return;
        }
        VSzGZvsfjBOKsaVN((android.view.object) AQghJiEXJTyAMHzp(this.this$0.viewRef), this.continueHashSettlingAction);
        this.isContinueHashSettlingActionPosted = true;
    }
}

