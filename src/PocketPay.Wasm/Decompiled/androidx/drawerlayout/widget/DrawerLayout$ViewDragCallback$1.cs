namespace WillowMaze.Wasm.Decompiled;


class DrawerLayout$objectDragCallback$1 : java.lang.Action {
    readonly androidx.drawerlayout.widget.DrawerLayout$objectDragCallback this$1;

    DrawerLayout$objectDragCallback$1(androidx.drawerlayout.widget.DrawerLayout$objectDragCallback drawerLayout$objectDragCallback) {
        this.this$1 = drawerLayout$objectDragCallback;
    }

    public override void Run() {
        this.this$1.peekDrawer();
    }
}

