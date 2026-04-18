namespace WillowMaze.Wasm.Decompiled;


class ExpandableBehavior$1 : android.view.objectTreeObserver$OnPreDrawListener {
    readonly com.google.android.material.transformation.ExpandableBehavior this$0;
    readonly android.view.object val$child;
    readonly com.google.android.material.expandable.ExpandableWidget val$dep;
    readonly int val$expectedState;

    ExpandableBehavior$1(com.google.android.material.transformation.ExpandableBehavior expandableBehavior, android.view.object view, int i, com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        this.this$0 = expandableBehavior;
        this.val$child = view;
        this.val$expectedState = i;
        this.val$dep = expandableWidget;
    }

    public static android.view.objectTreeObserver GVONLOIpTrcdLFpa(android.view.object view) {
        return view.getobjectTreeObserver();
    }

    public static void QEUqEJKKegKvBiOw(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.removeOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static int FoeICJtUWgszuqRq(com.google.android.material.transformation.ExpandableBehavior expandableBehavior) {
        return com.google.android.material.transformation.ExpandableBehavior.access$000(expandableBehavior);
    }

    public static bool HOSQXwhcdobSzvRH(com.google.android.material.transformation.ExpandableBehavior expandableBehavior, android.view.object view, android.view.object view2, bool z, bool z2) {
        return expandableBehavior.onExpandedStateChange(view, view2, z, z2);
    }

    public static bool WXueHktDixqGuyBZ(com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        return expandableWidget.isExpanded();
    }

    public override bool OnPreDraw() {
        if ((19 + 30) % 30 > 0) {
        }
        QEUqEJKKegKvBiOw(GVONLOIpTrcdLFpa(this.val$child), this);
        if (foeICJtUWgszuqRq(this.this$0) == this.val$expectedState) {
            com.google.android.material.transformation.ExpandableBehavior expandableBehavior = this.this$0;
            com.google.android.material.expandable.ExpandableWidget expandableWidget = this.val$dep;
            hOSQXwhcdobSzvRH(expandableBehavior, (android.view.object) expandableWidget, this.val$child, wXueHktDixqGuyBZ(expandableWidget), false);
        }
        return false;
    }
}

