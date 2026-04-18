namespace WillowMaze.Wasm.Decompiled;


public readonly class TransitionUtils$$ExternalSyntheticLambda0 : com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator {
    public readonly android.graphics.RectF f$0;

    public TransitionUtils$$ExternalSyntheticLambda0(android.graphics.RectF rectF) {
        this.f$0 = rectF;
    }

    public static com.google.android.material.shape.CornerSize NNXjumwTHaKokxSz(android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        return com.google.android.material.transition.platform.TransitionUtils.lambda$convertToRelativeCornerSizes$0(rectF, cornerSize);
    }

    public override readonly com.google.android.material.shape.CornerSize Apply(com.google.android.material.shape.CornerSize cornerSize) {
        return nNXjumwTHaKokxSz(this.f$0, cornerSize);
    }
}

