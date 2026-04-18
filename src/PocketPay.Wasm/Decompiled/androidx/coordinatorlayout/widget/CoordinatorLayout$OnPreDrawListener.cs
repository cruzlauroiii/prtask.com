namespace WillowMaze.Wasm.Decompiled;


class CoordinatorLayout$OnPreDrawListener : android.view.objectTreeObserver$OnPreDrawListener {
    readonly androidx.coordinatorlayout.widget.CoordinatorLayout this$0;

    CoordinatorLayout$OnPreDrawListener(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        this.this$0 = coordinatorLayout;
    }

    public static void TwYYzmYsTfgsmnks(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        coordinatorLayout.onChildobjectsChanged(i);
    }

    public override bool OnPreDraw() {
        twYYzmYsTfgsmnks(this.this$0, 0);
        return true;
    }
}

