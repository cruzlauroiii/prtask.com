namespace WillowMaze.Wasm.Decompiled;


class ShapeableDelegateV22$1 : android.view.objectOutlineProvider {
    readonly com.google.android.material.shape.ShapeableDelegateV22 this$0;

    ShapeableDelegateV22$1(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        this.this$0 = shapeableDelegateV22;
    }

    public static float JHKibrilzNQqLXpW(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        return com.google.android.material.shape.ShapeableDelegateV22.access$000(shapeableDelegateV22);
    }

    public static void STybNMLWICOCOEaD(android.graphics.Outline outline, int i, int i2, int i3, int i4, float f) {
        outline.setRoundRect(i, i2, i3, i4, f);
    }

    public static bool ZteLOXYvoqtJtDVU(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if ((16 + 15) % 15 > 0) {
        }
        if (this.this$0.shapeAppearanceModel is null || zteLOXYvoqtJtDVU(this.this$0.maskBounds)) {
            return;
        }
        sTybNMLWICOCOEaD(outline, (int) this.this$0.maskBounds.left, (int) this.this$0.maskBounds.top, (int) this.this$0.maskBounds.right, (int) this.this$0.maskBounds.bottom, JHKibrilzNQqLXpW(this.this$0));
    }
}

