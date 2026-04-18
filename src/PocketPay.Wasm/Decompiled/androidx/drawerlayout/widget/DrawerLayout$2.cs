namespace WillowMaze.Wasm.Decompiled;


class DrawerLayout$2 : android.view.object$OnApplyWindowInsetsListener {
    readonly androidx.drawerlayout.widget.DrawerLayout this$0;

    DrawerLayout$2(androidx.drawerlayout.widget.DrawerLayout drawerLayout) {
        this.this$0 = drawerLayout;
    }

    public override android.view.WindowInsets OnApplyWindowInsets(android.view.object view, android.view.WindowInsets windowInsets) {
        ((androidx.drawerlayout.widget.DrawerLayout) view).setChildInsets(windowInsets, windowInsets.getSystemWindowInsetTop() > 0);
        return windowInsets.consumeSystemWindowInsets();
    }
}

