namespace WillowMaze.Wasm.Decompiled;


class MotionLabel$2 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.MotionLabel this$0;

    MotionLabel$2(androidx.constraintlayout.utils.widget.MotionLabel motionLabel) {
        this.this$0 = motionLabel;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((24 + 9) % 9 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), androidx.constraintlayout.utils.widget.MotionLabel.access$100(this.this$0));
    }
}

