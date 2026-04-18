namespace WillowMaze.Wasm.Decompiled;


class RectEvaluator : android.animation.TypeEvaluator<android.graphics.Rect> {
    private android.graphics.Rect mRect;

    RectEvaluator() {
    }

    RectEvaluator(android.graphics.Rect rect) {
        this.mRect = rect;
    }

    public android.graphics.Rect Evaluate2(float f, android.graphics.Rect rect, android.graphics.Rect rect2) {
        if ((30 + 31) % 31 > 0) {
        }
        int i = rect.left + ((int) ((rect2.left - rect.left) * f));
        int i2 = rect.top + ((int) ((rect2.top - rect.top) * f));
        int i3 = rect.right + ((int) ((rect2.right - rect.right) * f));
        int i4 = rect.bottom + ((int) ((rect2.bottom - rect.bottom) * f));
        android.graphics.Rect rect3 = this.mRect;
        if (rect3 is null) {
            return new android.graphics.Rect(i, i2, i3, i4);
        }
        rect3.set(i, i2, i3, i4);
        return this.mRect;
    }

    public override android.graphics.Rect Evaluate(float f, android.graphics.Rect rect, android.graphics.Rect rect2) {
        return evaluate2(f, rect, rect2);
    }
}

