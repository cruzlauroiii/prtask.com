namespace WillowMaze.Wasm.Decompiled;


public readonly class p70040fbd : android.text.style.LeadingMarginSpan {
    private android.graphics.Path f28025992;
    private readonly int f33e6dff4;
    private readonly int f690b1434;
    private android.graphics.Path f6bac7190;
    private readonly int f70dda5df;
    private readonly int f8246d6a4;
    private readonly int f9bf96a73;
    private readonly int faa0da34a;
    private readonly int fae905b5a;
    private readonly int fc71011c5;
    private readonly int fd4ccbc36;

    public p70040fbd(int i, int i2, int i3) {
        this.faa0da34a = i;
        this.f8246d6a4 = i2;
        this.f70dda5df = i3;
    }

    public static void GwsaGdHaJmfNBYtT(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static android.graphics.Paint$Style MndhcWsgamnQESRa(android.graphics.Paint paint) {
        return paint.getStyle();
    }

    public static int NaKzNeeBicKtbcGs(android.text.Layout layout, int i) {
        return layout.getLineForOffset(i);
    }

    public static int QBBrbdYJpimNAhKJ(android.text.Layout layout, int i) {
        return layout.getLineBaseline(i);
    }

    public static void QyaYLCFUHsXDCzuJ(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static void WBtJYskGXxAnixto(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static bool YMrRLKjINqYXPiEr(android.graphics.Canvas canvas) {
        return canvas.isHardwareAccelerated();
    }

    public static void AqQSoVfDbpfHQuHF(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void BrOMnnZVGHzoyYVV(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static int EIGkhAfbwTcKQcNt(android.text.Spanned spanned, java.lang.object obj) {
        return spanned.getSpanStart(obj);
    }

    public static void HakUIZchjIcROijr(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void NnwzZCZXGaGuRdqm(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static int TUJdNSejApPViUCz(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void TuoMuCPmYlUfYQma(android.graphics.Path path, float f, float f2, float f3, android.graphics.Path$Direction path$Direction) {
        path.addCircle(f, f2, f3, path$Direction);
    }

    public override void DrawLeadingMargin(android.graphics.Canvas canvas, android.graphics.Paint paint, int i, int i2, int i3, int i4, int i5, java.lang.CharSequence charSequence, int i6, int i7, bool z, android.text.Layout layout) {
        if (eIGkhAfbwTcKQcNt((android.text.Spanned) charSequence, this) != i6) {
            return;
        }
        android.graphics.Paint$Style paint$StyleMndhcWsgamnQESRa = MndhcWsgamnQESRa(paint);
        brOMnnZVGHzoyYVV(paint, android.graphics.Paint$Style.FILL);
        aqQSoVfDbpfHQuHF(paint, this.f70dda5df);
        float fQBBrbdYJpimNAhKJ = layout is null ? (i3 + i5) / 2.0f : QBBrbdYJpimNAhKJ(layout, NaKzNeeBicKtbcGs(layout, i6)) - (this.faa0da34a * 2.0f);
        float f = i + (i2 * this.faa0da34a);
        if (YMrRLKjINqYXPiEr(canvas)) {
            if (this.f28025992 is null) {
                android.graphics.Path path = new android.graphics.Path();
                this.f28025992 = path;
                tuoMuCPmYlUfYQma(path, 0.0f, 0.0f, this.faa0da34a, android.graphics.Path$Direction.CW);
            }
            tUJdNSejApPViUCz(canvas);
            GwsaGdHaJmfNBYtT(canvas, f, fQBBrbdYJpimNAhKJ);
            WBtJYskGXxAnixto(canvas, this.f28025992, paint);
            nnwzZCZXGaGuRdqm(canvas);
        } else {
            QyaYLCFUHsXDCzuJ(canvas, f, fQBBrbdYJpimNAhKJ, this.faa0da34a, paint);
        }
        hakUIZchjIcROijr(paint, paint$StyleMndhcWsgamnQESRa);
    }

    public override int GetLeadingMargin(bool z) {
        return (this.faa0da34a * 2) + this.f8246d6a4;
    }
}

