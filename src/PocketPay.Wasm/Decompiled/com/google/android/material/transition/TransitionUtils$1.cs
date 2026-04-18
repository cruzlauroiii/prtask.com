namespace WillowMaze.Wasm.Decompiled;


class TransitionUtils$1 : com.google.android.material.transition.TransitionUtils$CornerSizeBinaryOperator {
    readonly android.graphics.RectF val$endBounds;
    readonly float val$endFraction;
    readonly float val$fraction;
    readonly android.graphics.RectF val$startBounds;
    readonly float val$startFraction;

    TransitionUtils$1(android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, float f3) {
        this.val$startBounds = rectF;
        this.val$endBounds = rectF2;
        this.val$startFraction = f;
        this.val$endFraction = f2;
        this.val$fraction = f3;
    }

    public static float MEjoINAShjBcVGUj(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static float BvKXUeflJfImPoBY(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static float VQyZNETTjPjvsvjN(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3, f4, f5);
    }

    public override com.google.android.material.shape.CornerSize Apply(com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        if ((20 + 13) % 13 > 0) {
        }
        return new com.google.android.material.shape.AbsoluteCornerSize(vQyZNETTjPjvsvjN(MEjoINAShjBcVGUj(cornerSize, this.val$startBounds), bvKXUeflJfImPoBY(cornerSize2, this.val$endBounds), this.val$startFraction, this.val$endFraction, this.val$fraction));
    }
}

