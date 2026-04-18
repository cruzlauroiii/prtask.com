namespace WillowMaze.Wasm.Decompiled;


class BottomAppBar$7 : android.animation.AnimatorListenerAdapter {
    public bool cancelled;
    readonly com.google.android.material.bottomappbar.BottomAppBar this$0;
    readonly androidx.appcompat.widget.ActionMenuobject val$actionMenuobject;
    readonly bool val$targetAttached;
    readonly int val$targetMode;

    BottomAppBar$7(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z) {
        this.this$0 = bottomAppBar;
        this.val$actionMenuobject = actionMenuobject;
        this.val$targetMode = i;
        this.val$targetAttached = z;
    }

    public static int BpYUVqVDIJaTBhwu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return com.google.android.material.bottomappbar.BottomAppBar.access$2100(bottomAppBar);
    }

    public static void BpYUVqVDIJaTBhwu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpYUVqVDIJaTBhwu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpYUVqVDIJaTBhwu(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HHnjjcHiLiaNodTF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar) {
        return com.google.android.material.bottomappbar.BottomAppBar.access$2100(bottomAppBar);
    }

    public static void HHnjjcHiLiaNodTF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HHnjjcHiLiaNodTF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HHnjjcHiLiaNodTF(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PdVZpmdsSvMFTyoG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2) {
        com.google.android.material.bottomappbar.BottomAppBar.access$2200(bottomAppBar, actionMenuobject, i, z, z2);
    }

    public static void PdVZpmdsSvMFTyoG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdVZpmdsSvMFTyoG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PdVZpmdsSvMFTyoG(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, bool z, bool z2, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PdWfpgQctDejJyCS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i) {
        bottomAppBar.replaceMenu(i);
    }

    public static void PdWfpgQctDejJyCS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, float f, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PdWfpgQctDejJyCS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PdWfpgQctDejJyCS(com.google.android.material.bottomappbar.BottomAppBar bottomAppBar, int i, java.lang.string str, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.cancelled = true;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((18 + 14) % 14 > 0) {
        }
        if (this.cancelled) {
            return;
        }
        bool z = BpYUVqVDIJaTBhwu(this.this$0) != 0;
        com.google.android.material.bottomappbar.BottomAppBar bottomAppBar = this.this$0;
        pdWfpgQctDejJyCS(bottomAppBar, hHnjjcHiLiaNodTF(bottomAppBar));
        pdVZpmdsSvMFTyoG(this.this$0, this.val$actionMenuobject, this.val$targetMode, this.val$targetAttached, z);
    }
}

