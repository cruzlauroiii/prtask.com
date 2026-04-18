namespace WillowMaze.Wasm.Decompiled;


class ImageFilterButton$2 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.ImageFilterButton this$0;

    ImageFilterButton$2(androidx.constraintlayout.utils.widget.ImageFilterButton imageFilterButton) {
        this.this$0 = imageFilterButton;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((14 + 21) % 21 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), androidx.constraintlayout.utils.widget.ImageFilterButton.access$100(this.this$0));
    }
}

