namespace WillowMaze.Wasm.Decompiled;


class MotionLayout$3 : java.lang.Action {
    readonly androidx.constraintlayout.motion.widget.MotionLayout this$0;
    readonly android.view.object val$target;

    MotionLayout$3(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, android.view.object view) {
        this.this$0 = motionLayout;
        this.val$target = view;
    }

    public override void Run() {
        this.val$target.setNestedScrollingEnabled(true);
    }
}

