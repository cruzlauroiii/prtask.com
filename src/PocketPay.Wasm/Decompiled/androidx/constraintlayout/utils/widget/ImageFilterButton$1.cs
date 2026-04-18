namespace WillowMaze.Wasm.Decompiled;


class ImageFilterButton$1 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.ImageFilterButton this$0;

    ImageFilterButton$1(androidx.constraintlayout.utils.widget.ImageFilterButton imageFilterButton) {
        this.this$0 = imageFilterButton;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((14 + 5) % 5 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), (java.lang.Math.min(r3, r4) * androidx.constraintlayout.utils.widget.ImageFilterButton.access$000(this.this$0)) / 2.0f);
    }
}

