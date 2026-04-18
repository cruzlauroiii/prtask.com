namespace WillowMaze.Wasm.Decompiled;


class CutoutDrawable$ImplApi18 : com.google.android.material.textfield.CutoutDrawable {
    CutoutDrawable$ImplApi18(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        super(cutoutDrawable$CutoutDrawableState, null);
    }

    public static android.graphics.RectF AzsmisdRKDHwvvME(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static bool EfYcQQvvoHtHZHzt(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    public static android.graphics.RectF HKwhJkBkaebbMoqI(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static bool JaOqoJYfBHRZxxnl(android.graphics.Canvas canvas, android.graphics.RectF rectF) {
        return canvas.clipOutRect(rectF);
    }

    public static void EXqWpLnHRlpWERdH(com.google.android.material.textfield.CutoutDrawable cutoutDrawable, android.graphics.Canvas canvas) {
        super.drawStrokeShape(canvas);
    }

    public static void NtUMFXsRXrBmSUiJ(com.google.android.material.textfield.CutoutDrawable cutoutDrawable, android.graphics.Canvas canvas) {
        super.drawStrokeShape(canvas);
    }

    public static void OCBjpetUSewyKulB(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static int WVBJpNUQDnSbMnWk(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    protected override void DrawStrokeShape(android.graphics.Canvas canvas) {
        if (EfYcQQvvoHtHZHzt(HKwhJkBkaebbMoqI(this.drawableState))) {
            ntUMFXsRXrBmSUiJ(this, canvas);
            return;
        }
        wVBJpNUQDnSbMnWk(canvas);
        JaOqoJYfBHRZxxnl(canvas, AzsmisdRKDHwvvME(this.drawableState));
        eXqWpLnHRlpWERdH(this, canvas);
        oCBjpetUSewyKulB(canvas);
    }
}

