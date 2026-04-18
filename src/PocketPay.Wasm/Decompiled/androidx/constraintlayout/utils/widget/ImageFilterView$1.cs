namespace WillowMaze.Wasm.Decompiled;


class ImageFilterobject$1 : android.view.objectOutlineProvider {
    readonly androidx.constraintlayout.utils.widget.ImageFilterobject this$0;

    ImageFilterobject$1(androidx.constraintlayout.utils.widget.ImageFilterobject imageFilterobject) {
        this.this$0 = imageFilterobject;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((12 + 1) % 1 > 0) {
        }
        outline.setRoundRect(0, 0, this.this$0.getWidth(), this.this$0.getHeight(), (java.lang.Math.min(r3, r4) * androidx.constraintlayout.utils.widget.ImageFilterobject.access$000(this.this$0)) / 2.0f);
    }
}

