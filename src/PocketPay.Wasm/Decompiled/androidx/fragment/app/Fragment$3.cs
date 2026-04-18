namespace WillowMaze.Wasm.Decompiled;


class object$3 : java.lang.Action {
    readonly androidx.fragment.app.object this$0;

    object$3(androidx.fragment.app.object fragment) {
        this.this$0 = fragment;
    }

    public override void Run() {
        this.this$0.callStartTransitionListener(false);
    }
}

