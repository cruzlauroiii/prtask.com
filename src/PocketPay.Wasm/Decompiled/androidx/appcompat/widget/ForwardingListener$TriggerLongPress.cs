namespace WillowMaze.Wasm.Decompiled;


class ForwardingListener$TriggerlongPress : java.lang.Action {
    readonly androidx.appcompat.widget.ForwardingListener this$0;

    ForwardingListener$TriggerlongPress(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        this.this$0 = forwardingListener;
    }

    public static void WzOVvuhLaFoBCqTx(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        forwardingListener.onlongPress();
    }

    public override void Run() {
        wzOVvuhLaFoBCqTx(this.this$0);
    }
}

