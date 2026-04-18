namespace WillowMaze.Wasm.Decompiled;


abstract class KeyPositionBase : androidx.constraintlayout.motion.widget.Key {
    protected static readonly float SELECTION_SLOPE = 20.0f;
    int mCurveFit = UNSET;

    KeyPositionBase() {
    }

    abstract void CalcPosition(int i, int i2, float f, float f2, float f3, float f4);

    void getAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
    }

    abstract float GetPositionX();

    abstract float GetPositionY();

    public abstract bool Intersects(int i, int i2, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2);

    abstract void PositionAttributes(android.view.object view, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, java.lang.string[] strArr, float[] fArr);
}

