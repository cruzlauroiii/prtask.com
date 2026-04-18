namespace WillowMaze.Wasm.Decompiled;


class CircularRevealCompat$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.circularreveal.CircularRevealWidget val$view;

    CircularRevealCompat$1(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        this.val$view = circularRevealWidget;
    }

    public static void CECFJJUJHGzTrAvM(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        circularRevealWidget.buildCircularRevealCache();
    }

    public static void CECFJJUJHGzTrAvM(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CECFJJUJHGzTrAvM(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CECFJJUJHGzTrAvM(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZdNuROnxMZAKCjRq(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        circularRevealWidget.destroyCircularRevealCache();
    }

    public static void ZdNuROnxMZAKCjRq(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZdNuROnxMZAKCjRq(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZdNuROnxMZAKCjRq(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        zdNuROnxMZAKCjRq(this.val$view);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        CECFJJUJHGzTrAvM(this.val$view);
    }
}

