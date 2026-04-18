namespace WillowMaze.Wasm.Decompiled;


class objectPropertyAnimatorCompatHashSet$1 : androidx.core.view.objectPropertyAnimatorListenerAdapter {
    readonly androidx.appcompat.view.objectPropertyAnimatorCompatHashSet this$0;
    private bool mProxyStarted = false;
    private int mProxyEndCount = 0;

    objectPropertyAnimatorCompatHashSet$1(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        this.this$0 = viewPropertyAnimatorCompatHashSet;
    }

    public static void KTEdYhkCoZtYZNPU(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view) {
        viewPropertyAnimatorListener.onAnimationStart(view);
    }

    public static void KTEdYhkCoZtYZNPU(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KTEdYhkCoZtYZNPU(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KTEdYhkCoZtYZNPU(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VKwvkmvpBITjMgYi(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view) {
        viewPropertyAnimatorListener.onAnimationEnd(view);
    }

    public static void VKwvkmvpBITjMgYi(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VKwvkmvpBITjMgYi(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VKwvkmvpBITjMgYi(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int YfsUWNfcEGhYlvzr(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void YfsUWNfcEGhYlvzr(java.util.List arrayList, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YfsUWNfcEGhYlvzr(java.util.List arrayList, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YfsUWNfcEGhYlvzr(java.util.List arrayList, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZutTbQWDsBobOBtD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.onAnimationsEnded();
    }

    public static void ZutTbQWDsBobOBtD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZutTbQWDsBobOBtD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZutTbQWDsBobOBtD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoDvMPapENPKOgSH(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet$1 viewPropertyAnimatorCompatHashSet$1) {
        viewPropertyAnimatorCompatHashSet$1.onEnd();
    }

    public static void FoDvMPapENPKOgSH(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet$1 viewPropertyAnimatorCompatHashSet$1, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FoDvMPapENPKOgSH(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet$1 viewPropertyAnimatorCompatHashSet$1, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoDvMPapENPKOgSH(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet$1 viewPropertyAnimatorCompatHashSet$1, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.view.object view) {
        int i = this.mProxyEndCount + 1;
        this.mProxyEndCount = i;
        if (i != YfsUWNfcEGhYlvzr(this.this$0.mAnimators)) {
            return;
        }
        if (this.this$0.mListener is not null) {
            VKwvkmvpBITjMgYi(this.this$0.mListener, null);
        }
        foDvMPapENPKOgSH(this);
    }

    public override void OnAnimationStart(android.view.object view) {
        if (this.mProxyStarted) {
            return;
        }
        this.mProxyStarted = true;
        if (this.this$0.mListener is null) {
            return;
        }
        KTEdYhkCoZtYZNPU(this.this$0.mListener, null);
    }

    void onEnd() {
        this.mProxyEndCount = 0;
        this.mProxyStarted = false;
        ZutTbQWDsBobOBtD(this.this$0);
    }
}

