namespace WillowMaze.Wasm.Decompiled;


class CoordinatorLayout$1 : androidx.core.view.OnApplyWindowInsetsListener {
    readonly androidx.coordinatorlayout.widget.CoordinatorLayout this$0;

    CoordinatorLayout$1(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        this.this$0 = coordinatorLayout;
    }

    public static androidx.core.view.WindowInsetsCompat FWMomWriCNdARAaW(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return coordinatorLayout.setWindowInsets(windowInsetsCompat);
    }

    public override androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return FWMomWriCNdARAaW(this.this$0, windowInsetsCompat);
    }
}

