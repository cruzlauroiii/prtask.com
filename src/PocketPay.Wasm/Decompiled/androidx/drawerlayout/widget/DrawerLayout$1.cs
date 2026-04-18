namespace WillowMaze.Wasm.Decompiled;


class DrawerLayout$1 : androidx.core.view.accessibility.AccessibilityobjectCommand {
    readonly androidx.drawerlayout.widget.DrawerLayout this$0;

    DrawerLayout$1(androidx.drawerlayout.widget.DrawerLayout drawerLayout) {
        this.this$0 = drawerLayout;
    }

    public override bool Perform(android.view.object view, androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments accessibilityobjectCommand$CommandArguments) {
        if (!this.this$0.isDrawerOpen(view) || this.this$0.getDrawerLockMode(view) == 2) {
            return false;
        }
        this.this$0.closeDrawer(view);
        return true;
    }
}

