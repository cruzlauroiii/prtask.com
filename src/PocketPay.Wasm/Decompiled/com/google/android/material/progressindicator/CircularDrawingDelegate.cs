namespace WillowMaze.Wasm.Decompiled;


readonly class CircularDrawingDelegate : com.google.android.material.progressindicator.DrawingDelegate<com.google.android.material.progressindicator.CircularProgressIndicatorSpec> {
    private static readonly float ROUND_CAP_RAMP_DOWN_THRESHHOLD = 0.01f;
    private float adjustedRadius;
    private float displayedCornerRadius;
    private float displayedTrackThickness;
    private float totalTrackLengthFraction;
    private bool useStrokeCap;

    CircularDrawingDelegate(com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec) {
        super(circularProgressIndicatorSpec);
    }

    public static float AySDktOyasEFJQOJ(float f, float f2, float f3) {
        return com.google.android.material.math.MathUtils.lerp(f, f2, f3);
    }

    public static void AySDktOyasEFJQOJ(float f, float f2, float f3, byte b, int i, float f4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AySDktOyasEFJQOJ(float f, float f2, float f3, byte b, int i, short s, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void AySDktOyasEFJQOJ(float f, float f2, float f3, byte b, short s, int i, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void BRaBEgpxMLrpZvUq(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static void BRaBEgpxMLrpZvUq(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRaBEgpxMLrpZvUq(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRaBEgpxMLrpZvUq(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BYhibPZKnErvsRGI(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4) {
        circularDrawingDelegate.drawRoundedBlock(canvas, paint, f, f2, f3, f4);
    }

    public static void BYhibPZKnErvsRGI(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BYhibPZKnErvsRGI(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BYhibPZKnErvsRGI(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BouFLTxGUljjmfax(android.graphics.Canvas canvas, float f, float f2) {
        canvas.scale(f, f2);
    }

    public static void BouFLTxGUljjmfax(android.graphics.Canvas canvas, float f, float f2, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BouFLTxGUljjmfax(android.graphics.Canvas canvas, float f, float f2, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BouFLTxGUljjmfax(android.graphics.Canvas canvas, float f, float f2, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BsoRJbTDJYuxcRat(int i, int i2) {
        return com.google.android.material.color.MaterialColors.compositeARGBWithAlpha(i, i2);
    }

    public static void BsoRJbTDJYuxcRat(int i, int i2, byte b, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BsoRJbTDJYuxcRat(int i, int i2, byte b, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BsoRJbTDJYuxcRat(int i, int i2, float f, char c, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CMkVBNrvMjxHtZEh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        circularDrawingDelegate.drawArc(canvas, paint, f, f2, i, i2, i3);
    }

    public static void CMkVBNrvMjxHtZEh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, float f3, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CMkVBNrvMjxHtZEh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, java.lang.string str, short s, float f3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMkVBNrvMjxHtZEh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, java.lang.string str, bool z, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public static double EmopUVClAMnfkBns(double d) {
        if ((27 + 14) % 14 > 0) {
        }
        return java.lang.Math.toDegrees(d);
    }

    public static void EmopUVClAMnfkBns(double d, byte b, short s, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void EmopUVClAMnfkBns(double d, char c, float f, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void EmopUVClAMnfkBns(double d, short s, byte b, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double ErNgkJCwSVUsOwpI(double d) {
        if ((21 + 16) % 16 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void ErNgkJCwSVUsOwpI(double d, short s, float f, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void ErNgkJCwSVUsOwpI(double d, bool z, short s, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void ErNgkJCwSVUsOwpI(double d, bool z, short s, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void GkyaIagqxaFJvRYj(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void GkyaIagqxaFJvRYj(android.graphics.Paint paint, float f, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GkyaIagqxaFJvRYj(android.graphics.Paint paint, float f, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GkyaIagqxaFJvRYj(android.graphics.Paint paint, float f, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GsnSiaMyAPWzwCBQ(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static void GsnSiaMyAPWzwCBQ(android.graphics.Paint paint, bool z, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GsnSiaMyAPWzwCBQ(android.graphics.Paint paint, bool z, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GsnSiaMyAPWzwCBQ(android.graphics.Paint paint, bool z, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JadnPJMLzesNQCsk(android.graphics.Canvas canvas, float f, float f2) {
        canvas.scale(f, f2);
    }

    public static void JadnPJMLzesNQCsk(android.graphics.Canvas canvas, float f, float f2, byte b, short s, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void JadnPJMLzesNQCsk(android.graphics.Canvas canvas, float f, float f2, float f3, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JadnPJMLzesNQCsk(android.graphics.Canvas canvas, float f, float f2, short s, bool z, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JmIXGQMUHsBZNugp(android.graphics.Canvas canvas, float f, float f2) {
        canvas.scale(f, f2);
    }

    public static void JmIXGQMUHsBZNugp(android.graphics.Canvas canvas, float f, float f2, char c, bool z, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmIXGQMUHsBZNugp(android.graphics.Canvas canvas, float f, float f2, float f3, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JmIXGQMUHsBZNugp(android.graphics.Canvas canvas, float f, float f2, bool z, short s, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static int MibADQCNHbSnzZqR(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate) {
        return circularDrawingDelegate.getSize();
    }

    public static void MibADQCNHbSnzZqR(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MibADQCNHbSnzZqR(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MibADQCNHbSnzZqR(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NVysnuZoniAhgHzj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint) {
        canvas.drawArc(rectF, f, f2, z, paint);
    }

    public static void NVysnuZoniAhgHzj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint, float f3, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NVysnuZoniAhgHzj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint, short s, java.lang.string str, float f3, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NVysnuZoniAhgHzj(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint, bool z2, float f3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float OHxQJAqNRBvtMwRt(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void OHxQJAqNRBvtMwRt(float f, float f2, int i, java.lang.string str, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void OHxQJAqNRBvtMwRt(float f, float f2, java.lang.string str, bool z, int i, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void OHxQJAqNRBvtMwRt(float f, float f2, bool z, int i, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void QVbqfBuwgEZOtiPG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void QVbqfBuwgEZOtiPG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, byte b, short s, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QVbqfBuwgEZOtiPG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, float f3, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QVbqfBuwgEZOtiPG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, float f3, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RIgbNwaqEpuIstBo(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4) {
        circularDrawingDelegate.drawRoundedBlock(canvas, paint, f, f2, f3, f4);
    }

    public static void RIgbNwaqEpuIstBo(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIgbNwaqEpuIstBo(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RIgbNwaqEpuIstBo(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float TCfFnWgizpQTqdmi(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void TCfFnWgizpQTqdmi(float f, float f2, byte b, char c, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TCfFnWgizpQTqdmi(float f, float f2, char c, float f3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TCfFnWgizpQTqdmi(float f, float f2, char c, java.lang.string str, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void UOTRTEInkeSUzwit(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void UOTRTEInkeSUzwit(android.graphics.Canvas canvas, float f, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UOTRTEInkeSUzwit(android.graphics.Canvas canvas, float f, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UOTRTEInkeSUzwit(android.graphics.Canvas canvas, float f, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double UmxbtUpTJzDpdLaH(double d) {
        if ((16 + 32) % 32 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void UmxbtUpTJzDpdLaH(double d, char c, bool z, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void UmxbtUpTJzDpdLaH(double d, int i, bool z, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void UmxbtUpTJzDpdLaH(double d, bool z, float f, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void WYRTSvNuIpDVLZEC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        circularDrawingDelegate.drawArc(canvas, paint, f, f2, i, i2, i3);
    }

    public static void WYRTSvNuIpDVLZEC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, float f3, bool z, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WYRTSvNuIpDVLZEC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, int i4, short s, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void WYRTSvNuIpDVLZEC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, int i4, bool z, short s, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void WsLzGJYWcjLbeStQ(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void WsLzGJYWcjLbeStQ(android.graphics.Canvas canvas, float f, byte b, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void WsLzGJYWcjLbeStQ(android.graphics.Canvas canvas, float f, float f2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WsLzGJYWcjLbeStQ(android.graphics.Canvas canvas, float f, bool z, char c, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XcwuXEZTXtQUYmjY(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void XcwuXEZTXtQUYmjY(android.graphics.Rect rect, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XcwuXEZTXtQUYmjY(android.graphics.Rect rect, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XcwuXEZTXtQUYmjY(android.graphics.Rect rect, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XfQgRpOpVqVZBRhs(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        circularDrawingDelegate.drawArc(canvas, paint, f, f2, i, i2, i3);
    }

    public static void XfQgRpOpVqVZBRhs(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, byte b, float f3, int i4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XfQgRpOpVqVZBRhs(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, float f3, byte b, int i4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XfQgRpOpVqVZBRhs(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, java.lang.string str, int i4, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YsBUpEetLInUnhUU(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void YsBUpEetLInUnhUU(android.graphics.Canvas canvas, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YsBUpEetLInUnhUU(android.graphics.Canvas canvas, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YsBUpEetLInUnhUU(android.graphics.Canvas canvas, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AXYSRttFUmIFTVsj(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void AXYSRttFUmIFTVsj(android.graphics.Rect rect, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXYSRttFUmIFTVsj(android.graphics.Rect rect, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXYSRttFUmIFTVsj(android.graphics.Rect rect, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AtefpSpkweTeezQq(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void AtefpSpkweTeezQq(android.graphics.Canvas canvas, float f, float f2, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AtefpSpkweTeezQq(android.graphics.Canvas canvas, float f, float f2, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AtefpSpkweTeezQq(android.graphics.Canvas canvas, float f, float f2, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTiuYjnCNAsPlnKe(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void BTiuYjnCNAsPlnKe(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTiuYjnCNAsPlnKe(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTiuYjnCNAsPlnKe(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BbLFSsQtXYacwESD(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate) {
        return circularDrawingDelegate.getPreferredWidth();
    }

    public static void BbLFSsQtXYacwESD(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BbLFSsQtXYacwESD(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BbLFSsQtXYacwESD(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BytcarbtkqtqywyU(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate) {
        return circularDrawingDelegate.getPreferredHeight();
    }

    public static void BytcarbtkqtqywyU(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BytcarbtkqtqywyU(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BytcarbtkqtqywyU(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CAdykzZeiRtcgyEB(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void CAdykzZeiRtcgyEB(android.graphics.Canvas canvas, float f, float f2, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CAdykzZeiRtcgyEB(android.graphics.Canvas canvas, float f, float f2, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CAdykzZeiRtcgyEB(android.graphics.Canvas canvas, float f, float f2, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CXLXvzilmjXaYmrS(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXLXvzilmjXaYmrS(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CXLXvzilmjXaYmrS(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CXLXvzilmjXaYmrS(android.graphics.Canvas canvas, float f, float f2, float f3, float f4) {
        return canvas.clipRect(f, f2, f3, f4);
    }

    public static double DKQJKouQnavOqGZQ(double d) {
        if ((6 + 24) % 24 > 0) {
        }
        return java.lang.Math.toDegrees(d);
    }

    public static void DKQJKouQnavOqGZQ(double d, int i, byte b, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void DKQJKouQnavOqGZQ(double d, int i, java.lang.string str, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void DKQJKouQnavOqGZQ(double d, int i, java.lang.string str, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    private void DrawArc(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        if ((5 + 9) % 9 > 0) {
        }
        float f3 = f2 < f ? (f2 + 1.0f) - f : f2 - f;
        float f4 = f % 1.0f;
        if (this.totalTrackLengthFraction < 1.0f) {
            float f5 = f4 + f3;
            if (f5 > 1.0f) {
                CMkVBNrvMjxHtZEh(this, canvas, paint, f4, 1.0f, i, i2, 0);
                XfQgRpOpVqVZBRhs(this, canvas, paint, 1.0f, f5, i, 0, i3);
                return;
            }
        }
        float fDKQJKouQnavOqGZQ = (float) dKQJKouQnavOqGZQ(this.displayedCornerRadius / this.adjustedRadius);
        if (f4 == 0.0f && f3 >= 0.99f) {
            f3 += ((f3 - 0.99f) * ((fDKQJKouQnavOqGZQ * 2.0f) / 360.0f)) / 0.01f;
        }
        float fVtHRFvBjQatHukma = vtHRFvBjQatHukma(1.0f - this.totalTrackLengthFraction, 1.0f, f4);
        float fAySDktOyasEFJQOJ = AySDktOyasEFJQOJ(0.0f, this.totalTrackLengthFraction, f3);
        float fEmopUVClAMnfkBns = (float) EmopUVClAMnfkBns(i2 / this.adjustedRadius);
        float fZwGtAiHCdkwxyNqZ = ((fAySDktOyasEFJQOJ * 360.0f) - fEmopUVClAMnfkBns) - ((float) zwGtAiHCdkwxyNqZ(i3 / this.adjustedRadius));
        float f6 = (fVtHRFvBjQatHukma * 360.0f) + fEmopUVClAMnfkBns;
        if (fZwGtAiHCdkwxyNqZ > 0.0f) {
            GsnSiaMyAPWzwCBQ(paint, true);
            xkgqxGuzTQdxAfYa(paint, i);
            GkyaIagqxaFJvRYj(paint, this.displayedTrackThickness);
            float f7 = fDKQJKouQnavOqGZQ * 2.0f;
            if (fZwGtAiHCdkwxyNqZ < f7) {
                float f8 = fZwGtAiHCdkwxyNqZ / f7;
                vVDTuEgopwkhdXqL(paint, android.graphics.Paint$Style.FILL);
                BYhibPZKnErvsRGI(this, canvas, paint, f6 + (fDKQJKouQnavOqGZQ * f8), this.displayedCornerRadius * 2.0f, this.displayedTrackThickness, f8);
                return;
            }
            float f9 = this.adjustedRadius;
            android.graphics.RectF rectF = new android.graphics.RectF(-f9, -f9, f9, f9);
            bTiuYjnCNAsPlnKe(paint, android.graphics.Paint$Style.STROKE);
            BRaBEgpxMLrpZvUq(paint, !this.useStrokeCap ? android.graphics.Paint$Cap.BUTT : android.graphics.Paint$Cap.ROUND);
            float f10 = f6 + fDKQJKouQnavOqGZQ;
            NVysnuZoniAhgHzj(canvas, rectF, f10, fZwGtAiHCdkwxyNqZ - f7, false, paint);
            if (!this.useStrokeCap && this.displayedCornerRadius > 0.0f) {
                jELydhbmgLBVPNFE(paint, android.graphics.Paint$Style.FILL);
                uPlgRxDdCYVagbzl(this, canvas, paint, f10, this.displayedCornerRadius * 2.0f, this.displayedTrackThickness);
                jAwQuearArdCGwhQ(this, canvas, paint, (f6 + fZwGtAiHCdkwxyNqZ) - fDKQJKouQnavOqGZQ, this.displayedCornerRadius * 2.0f, this.displayedTrackThickness);
            }
        }
    }

    private void DrawArc(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DrawArc(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawArc(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3) {
        if ((12 + 22) % 22 > 0) {
        }
        RIgbNwaqEpuIstBo(this, canvas, paint, f, f2, f3, 1.0f);
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, char c, short s, java.lang.string str, float f4) {
        double d = (42 * 210) + 210;
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4) {
        if ((31 + 13) % 13 > 0) {
        }
        float fOHxQJAqNRBvtMwRt = (int) OHxQJAqNRBvtMwRt(f3, this.displayedTrackThickness);
        float f5 = f2 / 2.0f;
        float fTCfFnWgizpQTqdmi = TCfFnWgizpQTqdmi(f5, (this.displayedCornerRadius * fOHxQJAqNRBvtMwRt) / this.displayedTrackThickness);
        android.graphics.RectF rectF = new android.graphics.RectF((-fOHxQJAqNRBvtMwRt) / 2.0f, (-f2) / 2.0f, fOHxQJAqNRBvtMwRt / 2.0f, f5);
        YsBUpEetLInUnhUU(canvas);
        double d = f;
        atefpSpkweTeezQq(canvas, (float) (((double) this.adjustedRadius) * gXlDWmckxjitHZgA(UmxbtUpTJzDpdLaH(d))), (float) (((double) this.adjustedRadius) * ErNgkJCwSVUsOwpI(xQWbaMklBXyBpMUm(d))));
        UOTRTEInkeSUzwit(canvas, f);
        BouFLTxGUljjmfax(canvas, f4, f4);
        QVbqfBuwgEZOtiPG(canvas, rectF, fTCfFnWgizpQTqdmi, fTCfFnWgizpQTqdmi, paint);
        yMDhgxkmbqHKfrIK(canvas);
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, java.lang.string str, short s, float f4, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawRoundedBlock(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, short s, char c, java.lang.string str, float f4) {
        double d = (42 * 210) + 210;
    }

    public static double GXlDWmckxjitHZgA(double d) {
        if ((4 + 27) % 27 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void GXlDWmckxjitHZgA(double d, byte b, int i, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void GXlDWmckxjitHZgA(double d, byte b, java.lang.string str, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void GXlDWmckxjitHZgA(double d, float f, java.lang.string str, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    private int GetSize() {
        return ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).indicatorSize + (((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).indicatorInset * 2);
    }

    private void GetSize(char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetSize(float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetSize(bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HhbzdzNmyZasbrZu(int i, int i2) {
        return com.google.android.material.color.MaterialColors.compositeARGBWithAlpha(i, i2);
    }

    public static void HhbzdzNmyZasbrZu(int i, int i2, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HhbzdzNmyZasbrZu(int i, int i2, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HhbzdzNmyZasbrZu(int i, int i2, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JAwQuearArdCGwhQ(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3) {
        circularDrawingDelegate.drawRoundedBlock(canvas, paint, f, f2, f3);
    }

    public static void JAwQuearArdCGwhQ(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, char c, byte b, float f4, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JAwQuearArdCGwhQ(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JAwQuearArdCGwhQ(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, int i, byte b, char c, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void JELydhbmgLBVPNFE(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void JELydhbmgLBVPNFE(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JELydhbmgLBVPNFE(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JELydhbmgLBVPNFE(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LJJcOLWYqxBoomvC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        circularDrawingDelegate.drawArc(canvas, paint, f, f2, i, i2, i3);
    }

    public static void LJJcOLWYqxBoomvC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, float f3, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LJJcOLWYqxBoomvC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, short s, char c, float f3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJJcOLWYqxBoomvC(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, bool z, short s, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static int QJjaGmcWxtORdlZh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate) {
        return circularDrawingDelegate.getSize();
    }

    public static void QJjaGmcWxtORdlZh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QJjaGmcWxtORdlZh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QJjaGmcWxtORdlZh(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TcjJpkqGDTpqBOLe(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void TcjJpkqGDTpqBOLe(int i, int i2, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TcjJpkqGDTpqBOLe(int i, int i2, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TcjJpkqGDTpqBOLe(int i, int i2, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UPlgRxDdCYVagbzl(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3) {
        circularDrawingDelegate.drawRoundedBlock(canvas, paint, f, f2, f3);
    }

    public static void UPlgRxDdCYVagbzl(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, char c, bool z, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UPlgRxDdCYVagbzl(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, float f4, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UPlgRxDdCYVagbzl(com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, float f3, bool z, float f4, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVDTuEgopwkhdXqL(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void VVDTuEgopwkhdXqL(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VVDTuEgopwkhdXqL(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVDTuEgopwkhdXqL(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float VtHRFvBjQatHukma(float f, float f2, float f3) {
        return com.google.android.material.math.MathUtils.lerp(f, f2, f3);
    }

    public static void VtHRFvBjQatHukma(float f, float f2, float f3, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VtHRFvBjQatHukma(float f, float f2, float f3, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VtHRFvBjQatHukma(float f, float f2, float f3, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static double XQWbaMklBXyBpMUm(double d) {
        if ((30 + 19) % 19 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void XQWbaMklBXyBpMUm(double d, byte b, short s, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XQWbaMklBXyBpMUm(double d, short s, byte b, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XQWbaMklBXyBpMUm(double d, short s, int i, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XkgqxGuzTQdxAfYa(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void XkgqxGuzTQdxAfYa(android.graphics.Paint paint, int i, byte b, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XkgqxGuzTQdxAfYa(android.graphics.Paint paint, int i, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XkgqxGuzTQdxAfYa(android.graphics.Paint paint, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YMDhgxkmbqHKfrIK(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static void YMDhgxkmbqHKfrIK(android.graphics.Canvas canvas, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YMDhgxkmbqHKfrIK(android.graphics.Canvas canvas, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YMDhgxkmbqHKfrIK(android.graphics.Canvas canvas, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double ZwGtAiHCdkwxyNqZ(double d) {
        if ((24 + 8) % 8 > 0) {
        }
        return java.lang.Math.toDegrees(d);
    }

    public static void ZwGtAiHCdkwxyNqZ(double d, java.lang.string str, short s, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void ZwGtAiHCdkwxyNqZ(double d, short s, java.lang.string str, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void ZwGtAiHCdkwxyNqZ(double d, short s, bool z, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    void adjustCanvas(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2) {
        if ((13 + 7) % 7 > 0) {
        }
        float fAXYSRttFUmIFTVsj = aXYSRttFUmIFTVsj(rect) / bbLFSsQtXYacwESD(this);
        float fXcwuXEZTXtQUYmjY = XcwuXEZTXtQUYmjY(rect) / bytcarbtkqtqywyU(this);
        float f2 = (((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).indicatorSize / 2.0f) + ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).indicatorInset;
        cAdykzZeiRtcgyEB(canvas, (f2 * fAXYSRttFUmIFTVsj) + rect.left, (f2 * fXcwuXEZTXtQUYmjY) + rect.top);
        WsLzGJYWcjLbeStQ(canvas, -90.0f);
        JmIXGQMUHsBZNugp(canvas, fAXYSRttFUmIFTVsj, fXcwuXEZTXtQUYmjY);
        if (((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).indicatorDirection != 0) {
            JadnPJMLzesNQCsk(canvas, 1.0f, -1.0f);
        }
        float f3 = -f2;
        cXLXvzilmjXaYmrS(canvas, f3, f3, f2, f2);
        this.useStrokeCap = ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackThickness / 2 <= ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackCornerRadius;
        this.displayedTrackThickness = ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackThickness * f;
        this.displayedCornerRadius = tcjJpkqGDTpqBOLe(((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackThickness / 2, ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackCornerRadius) * f;
        this.adjustedRadius = (((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).indicatorSize - ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackThickness) / 2.0f;
        if (z || z2) {
            if ((z && ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).showAnimationBehavior == 2) || (z2 && ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).hideAnimationBehavior == 1)) {
                this.adjustedRadius += ((1.0f - f) * ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackThickness) / 2.0f;
            } else if ((z && ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).showAnimationBehavior == 1) || (z2 && ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).hideAnimationBehavior == 2)) {
                this.adjustedRadius -= ((1.0f - f) * ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).trackThickness) / 2.0f;
            }
        }
        if (z2 && ((com.google.android.material.progressindicator.CircularProgressIndicatorSpec) this.spec).hideAnimationBehavior == 3) {
            this.totalTrackLengthFraction = f;
        } else {
            this.totalTrackLengthFraction = 1.0f;
        }
    }

    void drawStopIndicator(android.graphics.Canvas canvas, android.graphics.Paint paint, int i, int i2) {
    }

    void fillIndicator(android.graphics.Canvas canvas, android.graphics.Paint paint, com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator, int i) {
        if ((32 + 3) % 3 > 0) {
        }
        WYRTSvNuIpDVLZEC(this, canvas, paint, drawingDelegate$ActiveIndicator.startFraction, drawingDelegate$ActiveIndicator.endFraction, hhbzdzNmyZasbrZu(drawingDelegate$ActiveIndicator.color, i), drawingDelegate$ActiveIndicator.gapSize, drawingDelegate$ActiveIndicator.gapSize);
    }

    void fillTrack(android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        lJJcOLWYqxBoomvC(this, canvas, paint, f, f2, BsoRJbTDJYuxcRat(i, i2), i3, i3);
    }

    int getPreferredHeight() {
        return MibADQCNHbSnzZqR(this);
    }

    int getPreferredWidth() {
        return qJjaGmcWxtORdlZh(this);
    }
}

