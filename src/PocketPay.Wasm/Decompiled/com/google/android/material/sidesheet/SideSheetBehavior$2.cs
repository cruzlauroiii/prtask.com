namespace WillowMaze.Wasm.Decompiled;


class SideSheetBehavior$2 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.sidesheet.SideSheetBehavior this$0;

    SideSheetBehavior$2(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        this.this$0 = sideSheetBehavior;
    }

    public static java.lang.object FFhRsYDFtQubFDiX(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void LAWuUGAlCQanNeGV(android.view.object view) {
        view.requestLayout();
    }

    public static java.lang.object YfuvAxSaHJqVBkEA(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.ref.WeakReference YyGqZvMpFcTsMCme(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$100(sideSheetBehavior);
    }

    public static void AOTMuIMOIjdKjSxD(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setStateInternal(i);
    }

    public static java.lang.ref.WeakReference FQoZyTCkMDzJLahE(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$100(sideSheetBehavior);
    }

    public static java.lang.ref.WeakReference ZQgqAycdsRXNAFyL(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$100(sideSheetBehavior);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        aOTMuIMOIjdKjSxD(this.this$0, 5);
        if (fQoZyTCkMDzJLahE(this.this$0) is null || FFhRsYDFtQubFDiX(zQgqAycdsRXNAFyL(this.this$0)) is null) {
            return;
        }
        LAWuUGAlCQanNeGV((android.view.object) YfuvAxSaHJqVBkEA(YyGqZvMpFcTsMCme(this.this$0)));
    }
}

