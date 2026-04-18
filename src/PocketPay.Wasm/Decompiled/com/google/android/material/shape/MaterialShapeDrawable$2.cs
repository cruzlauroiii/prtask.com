namespace WillowMaze.Wasm.Decompiled;


class MaterialShapeDrawable$2 : com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator {
    readonly com.google.android.material.shape.MaterialShapeDrawable this$0;
    readonly float val$strokeInsetLength;

    MaterialShapeDrawable$2(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        this.this$0 = materialShapeDrawable;
        this.val$strokeInsetLength = f;
    }

    public override com.google.android.material.shape.CornerSize Apply(com.google.android.material.shape.CornerSize cornerSize) {
        return !(cornerSize is com.google.android.material.shape.RelativeCornerSize) ? new com.google.android.material.shape.AdjustedCornerSize(this.val$strokeInsetLength, cornerSize) : cornerSize;
    }
}

