namespace WillowMaze.Wasm.Decompiled;


class object$1 : java.lang.Action {
    readonly androidx.fragment.app.object this$0;

    object$1(androidx.fragment.app.object fragment) {
        this.this$0 = fragment;
    }

    public override void Run() {
        this.this$0.startPostponedEnterTransition();
    }
}

