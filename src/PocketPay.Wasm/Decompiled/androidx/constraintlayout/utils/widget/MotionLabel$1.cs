namespace WillowMaze.Wasm.Decompiled;


class MotionLabel$1 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.MotionLabel this$0;

    MotionLabel$1(androidx.constraintlayout.utils.widget.MotionLabel motionLabel) {
        this.this$0 = motionLabel;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((12 + 7) % 7 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), (java.lang.Math.min(r3, r4) * androidx.constraintlayout.utils.widget.MotionLabel.access$000(this.this$0)) / 2.0f);
    }
}

