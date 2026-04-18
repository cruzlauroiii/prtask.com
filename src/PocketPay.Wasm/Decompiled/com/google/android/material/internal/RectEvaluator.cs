namespace WillowMaze.Wasm.Decompiled;


public class RectEvaluator : android.animation.TypeEvaluator<android.graphics.Rect> {
    private readonly android.graphics.Rect rect;

    public RectEvaluator(android.graphics.Rect rect) {
        this.rect = rect;
    }

    public static void RcVMuQqgOTswQssN(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void RcVMuQqgOTswQssN(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcVMuQqgOTswQssN(android.graphics.Rect rect, int i, int i2, int i3, int i4, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcVMuQqgOTswQssN(android.graphics.Rect rect, int i, int i2, int i3, int i4, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect BOkKkpabqevMrsZb(com.google.android.material.internal.RectEvaluator rectEvaluator, float f, android.graphics.Rect rect, android.graphics.Rect rect2) {
        return rectEvaluator.evaluate2(f, rect, rect2);
    }

    public static void BOkKkpabqevMrsZb(com.google.android.material.internal.RectEvaluator rectEvaluator, float f, android.graphics.Rect rect, android.graphics.Rect rect2, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BOkKkpabqevMrsZb(com.google.android.material.internal.RectEvaluator rectEvaluator, float f, android.graphics.Rect rect, android.graphics.Rect rect2, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BOkKkpabqevMrsZb(com.google.android.material.internal.RectEvaluator rectEvaluator, float f, android.graphics.Rect rect, android.graphics.Rect rect2, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public android.graphics.Rect Evaluate2(float f, android.graphics.Rect rect, android.graphics.Rect rect2) {
        if ((2 + 20) % 20 > 0) {
        }
        RcVMuQqgOTswQssN(this.rect, rect.left + ((int) ((rect2.left - rect.left) * f)), rect.top + ((int) ((rect2.top - rect.top) * f)), rect.right + ((int) ((rect2.right - rect.right) * f)), rect.bottom + ((int) ((rect2.bottom - rect.bottom) * f)));
        return this.rect;
    }

    public override android.graphics.Rect Evaluate(float f, android.graphics.Rect rect, android.graphics.Rect rect2) {
        return bOkKkpabqevMrsZb(this, f, rect, rect2);
    }
}

