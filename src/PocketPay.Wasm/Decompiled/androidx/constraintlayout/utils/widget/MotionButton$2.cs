namespace WillowMaze.Wasm.Decompiled;


class MotionButton$2 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.MotionButton this$0;

    MotionButton$2(androidx.constraintlayout.utils.widget.MotionButton motionButton) {
        this.this$0 = motionButton;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((22 + 22) % 22 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), androidx.constraintlayout.utils.widget.MotionButton.access$100(this.this$0));
    }
}

