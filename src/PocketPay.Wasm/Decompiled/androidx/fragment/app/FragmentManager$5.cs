namespace WillowMaze.Wasm.Decompiled;


class objectManager$5 : java.lang.Action {
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$5(androidx.fragment.app.objectManager fragmentManager) {
        this.this$0 = fragmentManager;
    }

    public override void Run() {
        this.this$0.execPendingActions(true);
    }
}

