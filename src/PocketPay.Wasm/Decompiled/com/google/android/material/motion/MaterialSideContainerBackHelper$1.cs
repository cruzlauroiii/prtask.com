namespace WillowMaze.Wasm.Decompiled;


class MaterialSideContainerBackHelper$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.motion.MaterialSideContainerBackHelper this$0;
    readonly int val$gravity;
    readonly bool val$leftSwipeEdge;

    MaterialSideContainerBackHelper$1(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, bool z, int i) {
        this.this$0 = materialSideContainerBackHelper;
        this.val$leftSwipeEdge = z;
        this.val$gravity = i;
    }

    public static void NoAXpPqFoKPksKNU(android.view.object view, float f) {
        view.setTranslationX(f);
    }

    public static void NoAXpPqFoKPksKNU(android.view.object view, float f, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NoAXpPqFoKPksKNU(android.view.object view, float f, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NoAXpPqFoKPksKNU(android.view.object view, float f, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QtdGXuhSEPcSLmCx(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f, bool z, int i) {
        materialSideContainerBackHelper.updateBackProgress(f, z, i);
    }

    public static void QtdGXuhSEPcSLmCx(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f, bool z, int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QtdGXuhSEPcSLmCx(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f, bool z, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QtdGXuhSEPcSLmCx(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, float f, bool z, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((13 + 12) % 12 > 0) {
        }
        NoAXpPqFoKPksKNU(this.this$0.view, 0.0f);
        QtdGXuhSEPcSLmCx(this.this$0, 0.0f, this.val$leftSwipeEdge, this.val$gravity);
    }
}

