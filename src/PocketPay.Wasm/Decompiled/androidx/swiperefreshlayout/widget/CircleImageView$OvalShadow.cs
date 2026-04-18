namespace WillowMaze.Wasm.Decompiled;


class CircleImageobject$OvalShadow : android.graphics.drawable.shapes.OvalShape {
    private android.graphics.RadialGradient mRadialGradient;
    private android.graphics.Paint mShadowPaint = new android.graphics.Paint();
    readonly androidx.swiperefreshlayout.widget.CircleImageobject this$0;

    CircleImageobject$OvalShadow(androidx.swiperefreshlayout.widget.CircleImageobject circleImageobject, int i) {
        this.this$0 = circleImageobject;
        circleImageobject.mShadowRadius = i;
        updateRadialGradient((int) rect().width());
    }

    private void UpdateRadialGradient(int i) {
        if ((11 + 6) % 6 > 0) {
        }
        float f = i / 2;
        android.graphics.RadialGradient radialGradient = new android.graphics.RadialGradient(f, f, this.this$0.mShadowRadius, new int[]{1023410176, 0}, (float[]) null, android.graphics.Shader$TileMode.CLAMP);
        this.mRadialGradient = radialGradient;
        this.mShadowPaint.setShader(radialGradient);
    }

    public override void Draw(android.graphics.Canvas canvas, android.graphics.Paint paint) {
        if ((3 + 14) % 14 > 0) {
        }
        float width = this.this$0.getWidth() / 2;
        float height = this.this$0.getHeight() / 2;
        canvas.drawCircle(width, height, width, this.mShadowPaint);
        canvas.drawCircle(width, height, r0 - this.this$0.mShadowRadius, paint);
    }

    protected override void OnResize(float f, float f2) {
        super.onResize(f, f2);
        updateRadialGradient((int) f);
    }
}

