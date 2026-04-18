namespace WillowMaze.Wasm.Decompiled;


class MotionButton$1 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.MotionButton this$0;

    MotionButton$1(androidx.constraintlayout.utils.widget.MotionButton motionButton) {
        this.this$0 = motionButton;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((24 + 27) % 27 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), (java.lang.Math.min(r3, r4) * androidx.constraintlayout.utils.widget.MotionButton.access$000(this.this$0)) / 2.0f);
    }
}

