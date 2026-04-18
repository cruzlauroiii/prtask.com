namespace WillowMaze.Wasm.Decompiled;


class CardobjectBaseImpl$1 : androidx.cardview.widget.RoundRectDrawableWithShadow$RoundRectHelper {
    readonly androidx.cardview.widget.CardobjectBaseImpl this$0;

    CardobjectBaseImpl$1(androidx.cardview.widget.CardobjectBaseImpl cardobjectBaseImpl) {
        this.this$0 = cardobjectBaseImpl;
    }

    public static void FUzNFzRursSjOFLL(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint) {
        canvas.drawArc(rectF, f, f2, z, paint);
    }

    public static void IOiXQHKvaGJiFxFF(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void NVhTxmGftQzobavo(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void PdIqFBhuFvMTLtKm(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint) {
        canvas.drawArc(rectF, f, f2, z, paint);
    }

    public static void QBGetkMDGAErTvxs(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void QSGXOivCMhSBvmqr(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void QZphlhfxAXPyrrDu(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void RNdlaYQUUnPCEQoU(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void UCJDDlioYElECFyc(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static float WBCKYkrktinRLiPv(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void IWvvfTtAMPdCYZnS(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void PkrQrRsWjRtEekBJ(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint) {
        canvas.drawArc(rectF, f, f2, z, paint);
    }

    public static void PycZLHwSRHUPneKi(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void SeLOEQorEpFsGtCg(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void TzphVUAadwnzaMdl(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void VHIDhjYOYYSObVaH(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static int WWNIWOWwwYyxHZnZ(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void YxJPUriTLROtIlzm(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint) {
        canvas.drawArc(rectF, f, f2, z, paint);
    }

    public static float ZWXVxIxXTTeMOjUz(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public override void DrawRoundRect(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, android.graphics.Paint paint) {
        if ((5 + 24) % 24 > 0) {
        }
        float f2 = 2.0f * f;
        float fWBCKYkrktinRLiPv = (WBCKYkrktinRLiPv(rectF) - f2) - 1.0f;
        float fZWXVxIxXTTeMOjUz = (zWXVxIxXTTeMOjUz(rectF) - f2) - 1.0f;
        if (f >= 1.0f) {
            float f3 = f + 0.5f;
            float f4 = -f3;
            RNdlaYQUUnPCEQoU(this.this$0.mCornerRect, f4, f4, f3, f3);
            int iWWNIWOWwwYyxHZnZ = wWNIWOWwwYyxHZnZ(canvas);
            vHIDhjYOYYSObVaH(canvas, rectF.left + f3, rectF.top + f3);
            pkrQrRsWjRtEekBJ(canvas, this.this$0.mCornerRect, 180.0f, 90.0f, true, paint);
            QZphlhfxAXPyrrDu(canvas, fWBCKYkrktinRLiPv, 0.0f);
            pycZLHwSRHUPneKi(canvas, 90.0f);
            yxJPUriTLROtIlzm(canvas, this.this$0.mCornerRect, 180.0f, 90.0f, true, paint);
            NVhTxmGftQzobavo(canvas, fZWXVxIxXTTeMOjUz, 0.0f);
            IOiXQHKvaGJiFxFF(canvas, 90.0f);
            PdIqFBhuFvMTLtKm(canvas, this.this$0.mCornerRect, 180.0f, 90.0f, true, paint);
            QSGXOivCMhSBvmqr(canvas, fWBCKYkrktinRLiPv, 0.0f);
            iWvvfTtAMPdCYZnS(canvas, 90.0f);
            FUzNFzRursSjOFLL(canvas, this.this$0.mCornerRect, 180.0f, 90.0f, true, paint);
            UCJDDlioYElECFyc(canvas, iWWNIWOWwwYyxHZnZ);
            QBGetkMDGAErTvxs(canvas, (rectF.left + f3) - 1.0f, rectF.top, (rectF.right - f3) + 1.0f, rectF.top + f3, paint);
            tzphVUAadwnzaMdl(canvas, (rectF.left + f3) - 1.0f, rectF.bottom - f3, (rectF.right - f3) + 1.0f, rectF.bottom, paint);
        }
        seLOEQorEpFsGtCg(canvas, rectF.left, rectF.top + f, rectF.right, rectF.bottom - f, paint);
    }
}

