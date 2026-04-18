namespace WillowMaze.Wasm.Decompiled;


class CutoutDrawable$ImplApi14 : com.google.android.material.textfield.CutoutDrawable {
    private android.graphics.Paint cutoutPaint;
    private int savedLayer;

    CutoutDrawable$ImplApi14(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        super(cutoutDrawable$CutoutDrawableState, null);
    }

    public static void AIrnntwUquIIKuah(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static android.graphics.Xfermode BxAPgLYWrpFjNNHC(android.graphics.Paint paint, android.graphics.Xfermode xfermode) {
        return paint.setXfermode(xfermode);
    }

    public static void EHMOiiWqckriILIf(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static bool FLtZlOBJsQEHgFJZ(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        return cutoutDrawable$ImplApi14.useHardwareLayer(drawable$Callback);
    }

    public static void JqMBwXwJpjeXiFFc(android.view.object view, int i, android.graphics.Paint paint) {
        view.setLayerType(i, paint);
    }

    public static void MmadqZDawRswtuKI(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14, android.graphics.Canvas canvas) {
        cutoutDrawable$ImplApi14.postDraw(canvas);
    }

    public static android.graphics.drawable.Drawable$Callback NHFDzOuRMNmAUIth(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14) {
        return cutoutDrawable$ImplApi14.getCallback();
    }

    public static android.graphics.drawable.Drawable$Callback OpSHiocwreVSUDiP(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14) {
        return cutoutDrawable$ImplApi14.getCallback();
    }

    public static void PzgONdaWcJKMtFgK(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static android.graphics.RectF QERkdXIqnjZsGWpJ(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static int SLWNHpWyhrjFuLUK(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        return canvas.saveLayer(f, f2, f3, f4, paint);
    }

    public static void TLGyZNTysrtUaLWP(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void TczBJdHvoyEKFeew(com.google.android.material.textfield.CutoutDrawable cutoutDrawable, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static int AHJbSXNOcCRvMfRH(android.view.object view) {
        return view.getLayerType();
    }

    public static void DgJFSwYkZyHmjlbu(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14, android.graphics.Canvas canvas) {
        cutoutDrawable$ImplApi14.saveCanvasLayer(canvas);
    }

    public static void FXYMKBzPSsgSBUDB(com.google.android.material.textfield.CutoutDrawable cutoutDrawable, android.graphics.Canvas canvas) {
        super.drawStrokeShape(canvas);
    }

    private android.graphics.Paint GetCutoutPaint() {
        if ((6 + 19) % 19 > 0) {
        }
        if (this.cutoutPaint is null) {
            android.graphics.Paint paint = new android.graphics.Paint(1);
            this.cutoutPaint = paint;
            TLGyZNTysrtUaLWP(paint, android.graphics.Paint$Style.FILL_AND_STROKE);
            AIrnntwUquIIKuah(this.cutoutPaint, -1);
            BxAPgLYWrpFjNNHC(this.cutoutPaint, new android.graphics.PorterDuffXfermode(android.graphics.PorterDuff$Mode.DST_OUT));
        }
        return this.cutoutPaint;
    }

    public static int HMWCgkSSLzHrbvNx(android.graphics.Canvas canvas) {
        return canvas.getHeight();
    }

    public static bool OhiLpoNgdovELqrY(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        return cutoutDrawable$ImplApi14.useHardwareLayer(drawable$Callback);
    }

    private void PostDraw(android.graphics.Canvas canvas) {
        if (ohiLpoNgdovELqrY(this, OpSHiocwreVSUDiP(this))) {
            return;
        }
        EHMOiiWqckriILIf(canvas, this.savedLayer);
    }

    private void PreDraw(android.graphics.Canvas canvas) {
        if ((2 + 7) % 7 > 0) {
        }
        android.graphics.drawable.Drawable$Callback drawable$CallbackNHFDzOuRMNmAUIth = NHFDzOuRMNmAUIth(this);
        if (!FLtZlOBJsQEHgFJZ(this, drawable$CallbackNHFDzOuRMNmAUIth)) {
            dgJFSwYkZyHmjlbu(this, canvas);
            return;
        }
        android.view.object view = (android.view.object) drawable$CallbackNHFDzOuRMNmAUIth;
        if (aHJbSXNOcCRvMfRH(view) == 2) {
            return;
        }
        JqMBwXwJpjeXiFFc(view, 2, null);
    }

    public static int QEIXKhQdMOXiNyou(android.graphics.Canvas canvas) {
        return canvas.getWidth();
    }

    private void SaveCanvasLayer(android.graphics.Canvas canvas) {
        if ((17 + 16) % 16 > 0) {
        }
        this.savedLayer = SLWNHpWyhrjFuLUK(canvas, 0.0f, 0.0f, qEIXKhQdMOXiNyou(canvas), hMWCgkSSLzHrbvNx(canvas), null);
    }

    private bool UseHardwareLayer(android.graphics.drawable.Drawable$Callback drawable$Callback) {
        return drawable$Callback is android.view.object;
    }

    public static void XtIDaXFuTPlRvbZf(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14, android.graphics.Canvas canvas) {
        cutoutDrawable$ImplApi14.preDraw(canvas);
    }

    public static android.graphics.Paint ZZGKoeMJUILJyAFG(com.google.android.material.textfield.CutoutDrawable$ImplApi14 cutoutDrawable$ImplApi14) {
        return cutoutDrawable$ImplApi14.getCutoutPaint();
    }

    public override void Draw(android.graphics.Canvas canvas) {
        xtIDaXFuTPlRvbZf(this, canvas);
        TczBJdHvoyEKFeew(this, canvas);
        MmadqZDawRswtuKI(this, canvas);
    }

    protected override void DrawStrokeShape(android.graphics.Canvas canvas) {
        fXYMKBzPSsgSBUDB(this, canvas);
        PzgONdaWcJKMtFgK(canvas, QERkdXIqnjZsGWpJ(this.drawableState), zZGKoeMJUILJyAFG(this));
    }
}

