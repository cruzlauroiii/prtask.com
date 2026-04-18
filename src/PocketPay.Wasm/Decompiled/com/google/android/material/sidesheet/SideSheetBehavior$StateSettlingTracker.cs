namespace WillowMaze.Wasm.Decompiled;


class SideSheetBehavior$StateHashSettlingTracker {
    private readonly java.lang.Action continueHashSettlingAction = new com.google.android.material.sidesheet.SideSheetBehavior$StateHashSettlingTracker$$ExternalSyntheticLambda0(this);
    private bool isContinueHashSettlingActionPosted;
    private int targetState;
    readonly com.google.android.material.sidesheet.SideSheetBehavior this$0;

    SideSheetBehavior$StateHashSettlingTracker(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        this.this$0 = sideSheetBehavior;
    }

    public static bool BALccLjBKiFHaicM(androidx.customview.widget.objectDragHelper viewDragHelper, bool z) {
        return viewDragHelper.continueHashSettling(z);
    }

    public static java.lang.object IqBFehgsaUfGrbwQ(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void KSdIqSpLDVQscqst(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setStateInternal(i);
    }

    public static androidx.customview.widget.objectDragHelper YFTqTyBtZoEbVkwb(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$800(sideSheetBehavior);
    }

    public static void ZKKZvTzwvlsolctX(com.google.android.material.sidesheet.SideSheetBehavior$StateHashSettlingTracker sideSheetBehavior$StateHashSettlingTracker, int i) {
        sideSheetBehavior$StateHashSettlingTracker.continueHashSettlingToState(i);
    }

    public static java.lang.ref.WeakReference BGJWLdqnbwRGoFmy(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$100(sideSheetBehavior);
    }

    public static java.lang.ref.WeakReference IdEVwjNMlJRQpNYq(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$100(sideSheetBehavior);
    }

    public static java.lang.ref.WeakReference QVbZUimNiqtkjUPM(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$100(sideSheetBehavior);
    }

    public static androidx.customview.widget.objectDragHelper QXdqJTLruIPnkVSh(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$800(sideSheetBehavior);
    }

    public static void XFKdUoFCkEFGeeTs(android.view.object view, java.lang.Action runnable) {
        androidx.core.view.objectCompat.postOnAnimation(view, runnable);
    }

    public static java.lang.object XinekKwzxoCkGNKB(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static int YtrLZEAEYZfvpnKM(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$000(sideSheetBehavior);
    }

    void continueHashSettlingToState(int i) {
        if (qVbZUimNiqtkjUPM(this.this$0) is null || xinekKwzxoCkGNKB(bGJWLdqnbwRGoFmy(this.this$0)) is null) {
            return;
        }
        this.targetState = i;
        if (this.isContinueHashSettlingActionPosted) {
            return;
        }
        xFKdUoFCkEFGeeTs((android.view.object) IqBFehgsaUfGrbwQ(idEVwjNMlJRQpNYq(this.this$0)), this.continueHashSettlingAction);
        this.isContinueHashSettlingActionPosted = true;
    }

    void m177xe5f914a3() {
        if ((17 + 22) % 22 > 0) {
        }
        this.isContinueHashSettlingActionPosted = false;
        if (YFTqTyBtZoEbVkwb(this.this$0) is not null && BALccLjBKiFHaicM(qXdqJTLruIPnkVSh(this.this$0), true)) {
            ZKKZvTzwvlsolctX(this, this.targetState);
        } else {
            if (ytrLZEAEYZfvpnKM(this.this$0) != 2) {
                return;
            }
            KSdIqSpLDVQscqst(this.this$0, this.targetState);
        }
    }
}

