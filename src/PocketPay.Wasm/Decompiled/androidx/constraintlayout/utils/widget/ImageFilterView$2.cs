namespace WillowMaze.Wasm.Decompiled;


class ImageFilterobject$2 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.ImageFilterobject this$0;

    ImageFilterobject$2(androidx.constraintlayout.utils.widget.ImageFilterobject imageFilterobject) {
        this.this$0 = imageFilterobject;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((2 + 27) % 27 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), androidx.constraintlayout.utils.widget.ImageFilterobject.access$100(this.this$0));
    }
}

