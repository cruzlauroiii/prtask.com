namespace WillowMaze.Wasm.Decompiled;


class object$4 : java.lang.Action {
    readonly androidx.fragment.app.object this$0;
    readonly androidx.fragment.app.SpecialEffectsController val$controller;

    object$4(androidx.fragment.app.object fragment, androidx.fragment.app.SpecialEffectsController specialEffectsController) {
        this.this$0 = fragment;
        this.val$controller = specialEffectsController;
    }

    public override void Run() {
        if (this.val$controller.isPendingExecute()) {
            this.val$controller.executePendingOperations();
        }
    }
}

