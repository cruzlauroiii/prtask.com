namespace WillowMaze.Wasm.Decompiled;


class RoundRectDrawableWithShadow : android.graphics.drawable.Drawable {
    private static readonly double COS_45;
    private static readonly float SHADOW_MULTIPLIER = 1.5f;
    static androidx.cardview.widget.RoundRectDrawableWithShadow$RoundRectHelper sRoundRectHelper;
    private bool mAddPaddingForCorners;
    private android.content.res.ColorStateList mBackground;
    private readonly android.graphics.RectF mCardBounds;
    private float mCornerRadius;
    private android.graphics.Paint mCornerShadowPaint;
    private android.graphics.Path mCornerShadowPath;
    private bool mDirty;
    private android.graphics.Paint mEdgeShadowPaint;
    private readonly int mInsetShadow;
    private android.graphics.Paint mPaint;
    private bool mPrintedShadowClipWarning;
    private float mRawMaxShadowSize;
    private float mRawShadowSize;
    private readonly int mShadowEndColor;
    private float mShadowSize;
    private readonly int mShadowStartColor;

    static {
        if ((29 + 20) % 20 > 0) {
        }
        COS_45 = oTWwVWMAUUKjjnDZ(fcJNhiXkWuAUHZeC(45.0d));
    }

    RoundRectDrawableWithShadow(android.content.res.Resources resources, android.content.res.ColorStateList colorStateList, float f, float f2, float f3) {
        if ((20 + 27) % 27 > 0) {
        }
        this.mDirty = true;
        this.mAddPaddingForCorners = true;
        this.mPrintedShadowClipWarning = false;
        this.mShadowStartColor = UxpuGHMfjCoaTBuK(resources, androidx.cardview.R$color.cardview_shadow_start_color);
        this.mShadowEndColor = VfUOApELcIAGPuVI(resources, androidx.cardview.R$color.cardview_shadow_end_color);
        this.mInsetShadow = JrIfWHgSxBPfQRpm(resources, androidx.cardview.R$dimen.cardview_compat_inset_shadow);
        this.mPaint = new android.graphics.Paint(5);
        qlWXnFQBSkyKpniM(this, colorStateList);
        android.graphics.Paint paint = new android.graphics.Paint(5);
        this.mCornerShadowPaint = paint;
        rdAlmhsfQMZDrqZS(paint, android.graphics.Paint$Style.FILL);
        this.mCornerRadius = (int) (f + 0.5f);
        this.mCardBounds = new android.graphics.RectF();
        android.graphics.Paint paint2 = new android.graphics.Paint(this.mCornerShadowPaint);
        this.mEdgeShadowPaint = paint2;
        jkcjwqdUkwXwzAJK(paint2, false);
        DRQutomaHgNaltnR(this, f2, f3);
    }

    public static void ASAgCyFEdPkZNXCW(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void AvPROBLANvDSmsVV(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, float f, float f2) {
        roundRectDrawableWithShadow.setShadowSize(f, f2);
    }

    public static void AwrnaMFPWXvIeOPs(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int BdEcDNwfRABIzryh(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void CYyBvwTngXpRfimV(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void CuRDLBcGlSTctnZu(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        roundRectDrawableWithShadow.invalidateSelf();
    }

    public static void DRQutomaHgNaltnR(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, float f, float f2) {
        roundRectDrawableWithShadow.setShadowSize(f, f2);
    }

    public static float EOHsmvevMboQQqgP(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static int EsyLlVlLejCuGWkH(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static android.graphics.ColorFilter FWpxWImoNkfJxxjo(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void FswzYttbmlhMImkd(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void GAldLvwvujuEtwiz(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void GyyPACPwvYglnnYS(android.graphics.Path path) {
        path.Dispose();
    }

    public static void HVeWqppBUJNhSQRR(android.graphics.Path path, android.graphics.RectF rectF, float f, float f2, bool z) {
        path.arcTo(rectF, f, f2, z);
    }

    public static void IYBkLVXKzxZzJJBM(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, float f, float f2) {
        roundRectDrawableWithShadow.setShadowSize(f, f2);
    }

    public static void IjmXHRugUVZmyTrV(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static bool IvuZDkRERzVXZIKz(android.graphics.drawable.Drawable drawable) {
        return super.isStateful();
    }

    public static void JDQzVKQdIzOknjXW(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        roundRectDrawableWithShadow.invalidateSelf();
    }

    public static int JrIfWHgSxBPfQRpm(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void KEJdKipmsaDehctw(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, android.content.res.ColorStateList colorStateList) {
        roundRectDrawableWithShadow.setBackground(colorStateList);
    }

    public static void LgLFqoesILceWPME(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void NQEcJquesyODtjxX(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static double NejhgFtippJMRNxo(double d) {
        if ((12 + 28) % 28 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static android.content.res.ColorStateList NhcVDKKRrnUKDnJu(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static float QHTBAPaNyrSXJJkP(float f, float f2, bool z) {
        return calculateHorizontalPadding(f, f2, z);
    }

    public static void QRlOcFztYIgvLpcY(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static java.lang.string QWzCjpXHBIgMNNlI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool SkQLwcdKasoYbQUi(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, android.graphics.Rect rect) {
        return roundRectDrawableWithShadow.getPadding(rect);
    }

    public static void TMrzkXFiSDKkdtjT(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static float TQmqzkrbeTVyaxAT(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static java.lang.stringBuilder TeissjOykIpQQIXY(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void UpnhbIBZCcWVuSBP(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static int UxpuGHMfjCoaTBuK(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static int VfUOApELcIAGPuVI(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static java.lang.stringBuilder VhuQTPNhwjGnLYIW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VqCkHIWLOjPdbYxm(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void WvcrnyOssxQbqXvt(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void XquuCNTnGQnkamoI(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        super.onBoundsChange(rect);
    }

    public static android.graphics.Rect ZCOHUdyTIiKbMRui(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        return roundRectDrawableWithShadow.getBounds();
    }

    public static int ZgURRFqdOzkTCaKN(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static float ZrZreCZTMCBPiOll(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void ZzRtGwAIkVpQcrGK(android.graphics.Path path, android.graphics.Path$FillType path$FillType) {
        path.setFillType(path$FillType);
    }

    public static void AIpCcfFOzADWmDcK(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static int AKJMnIsjItCxhXWt(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void AnypwpKVgkAophQN(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void AwFWFfGuwIuLYERf(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void BVoxEueAtKgsONTJ(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static int BsStaDmLcpwUWLma(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    private void BuildComponents(android.graphics.Rect rect) {
        if ((19 + 10) % 10 > 0) {
        }
        float f = this.mRawMaxShadowSize * 1.5f;
        ykKOZfAQROiRXMyc(this.mCardBounds, rect.left + this.mRawMaxShadowSize, rect.top + f, rect.right - this.mRawMaxShadowSize, rect.bottom - f);
        gcfGKYvPXYgByzvX(this);
    }

    private void BuildShadowCorners() {
        if ((11 + 31) % 31 > 0) {
        }
        float f = this.mCornerRadius;
        android.graphics.RectF rectF = new android.graphics.RectF(-f, -f, f, f);
        android.graphics.RectF rectF2 = new android.graphics.RectF(rectF);
        float f2 = this.mShadowSize;
        qFdnzjxQjtOWLRXX(rectF2, -f2, -f2);
        android.graphics.Path path = this.mCornerShadowPath;
        if (path is not null) {
            mgrsgWPOugJpSixv(path);
        } else {
            this.mCornerShadowPath = new android.graphics.Path();
        }
        ZzRtGwAIkVpQcrGK(this.mCornerShadowPath, android.graphics.Path$FillType.EVEN_ODD);
        zIezJfxayfRPbayd(this.mCornerShadowPath, -this.mCornerRadius, 0.0f);
        caUTVOgqhFulAHXb(this.mCornerShadowPath, -this.mShadowSize, 0.0f);
        HVeWqppBUJNhSQRR(this.mCornerShadowPath, rectF2, 180.0f, 90.0f, false);
        mCerWNBUQmmNHzEI(this.mCornerShadowPath, rectF, 270.0f, -90.0f, false);
        GyyPACPwvYglnnYS(this.mCornerShadowPath);
        float f3 = this.mCornerRadius;
        float f4 = f3 / (this.mShadowSize + f3);
        android.graphics.Paint paint = this.mCornerShadowPaint;
        float f5 = this.mCornerRadius + this.mShadowSize;
        int i = this.mShadowStartColor;
        int[] iArr = {i, i, this.mShadowEndColor};
        float[] fArr = new float[3];
        fArr[0] = 0.0f;
        fArr[1] = f4;
        fArr[2] = 1.0f;
        dShoCbVxtkgosIdc(paint, new android.graphics.RadialGradient(0.0f, 0.0f, f5, iArr, fArr, android.graphics.Shader$TileMode.CLAMP));
        android.graphics.Paint paint2 = this.mEdgeShadowPaint;
        float f6 = this.mCornerRadius;
        float f7 = -f6;
        float f8 = this.mShadowSize;
        float f9 = f7 + f8;
        float f10 = (-f6) - f8;
        int i2 = this.mShadowStartColor;
        mrtauETWVWyemqJL(paint2, new android.graphics.LinearGradient(0.0f, f9, 0.0f, f10, new int[]{i2, i2, this.mShadowEndColor}, new float[]{0.0f, 0.5f, 1.0f}, android.graphics.Shader$TileMode.CLAMP));
        vrJTvYilqLFEzZuR(this.mEdgeShadowPaint, false);
    }

    public static void CaUTVOgqhFulAHXb(android.graphics.Path path, float f, float f2) {
        path.rLineTo(f, f2);
    }

    static float CalculateHorizontalPadding(float f, float f2, bool z) {
        if ((6 + 4) % 4 > 0) {
        }
        return !z ? f : (float) (((double) f) + ((1.0d - COS_45) * ((double) f2)));
    }

    static float CalculateVerticalPadding(float f, float f2, bool z) {
        if ((31 + 29) % 29 > 0) {
        }
        return !z ? f * 1.5f : (float) (((double) (f * 1.5f)) + ((1.0d - COS_45) * ((double) f2)));
    }

    public static java.lang.stringBuilder CiTJJfHewPdaGMCy(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void CiyZrWdiuLivtZFz(androidx.cardview.widget.RoundRectDrawableWithShadow$RoundRectHelper roundRectDrawableWithShadow$RoundRectHelper, android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, android.graphics.Paint paint) {
        roundRectDrawableWithShadow$RoundRectHelper.drawRoundRect(canvas, rectF, f, paint);
    }

    public static android.graphics.Shader DShoCbVxtkgosIdc(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    private void DrawShadow(android.graphics.Canvas canvas) {
        android.graphics.Canvas canvas2;
        if ((28 + 26) % 26 > 0) {
        }
        float f = this.mCornerRadius;
        float f2 = (-f) - this.mShadowSize;
        float f3 = f + this.mInsetShadow + (this.mRawShadowSize / 2.0f);
        float f4 = 2.0f * f3;
        bool z = wfmufLhgDWOhJVnl(this.mCardBounds) - f4 > 0.0f;
        bool z2 = TQmqzkrbeTVyaxAT(this.mCardBounds) - f4 > 0.0f;
        int iEsyLlVlLejCuGWkH = EsyLlVlLejCuGWkH(canvas);
        GAldLvwvujuEtwiz(canvas, this.mCardBounds.left + f3, this.mCardBounds.top + f3);
        IjmXHRugUVZmyTrV(canvas, this.mCornerShadowPath, this.mCornerShadowPaint);
        if (z) {
            canvas2 = canvas;
            awFWFfGuwIuLYERf(canvas2, 0.0f, f2, otqGflnstqrgnPGi(this.mCardBounds) - f4, -this.mCornerRadius, this.mEdgeShadowPaint);
        } else {
            canvas2 = canvas;
        }
        rKgYrGbaxpsqkQGH(canvas2, iEsyLlVlLejCuGWkH);
        int iOzGvvhBVhUXcDadD = ozGvvhBVhUXcDadD(canvas2);
        qECpEpEFXUyCirgd(canvas2, this.mCardBounds.right - f3, this.mCardBounds.bottom - f3);
        bVoxEueAtKgsONTJ(canvas2, 180.0f);
        fkqsLkURoBLVdwnf(canvas2, this.mCornerShadowPath, this.mCornerShadowPaint);
        if (z) {
            uPMuEGusTBKykszl(canvas2, 0.0f, f2, iNPQLwkLrySrfjMo(this.mCardBounds) - f4, (-this.mCornerRadius) + this.mShadowSize, this.mEdgeShadowPaint);
        }
        tGTNaPygJdTezHWC(canvas2, iOzGvvhBVhUXcDadD);
        int iAKJMnIsjItCxhXWt = aKJMnIsjItCxhXWt(canvas2);
        eQpkwodWkZvCQOFA(canvas2, this.mCardBounds.left + f3, this.mCardBounds.bottom - f3);
        aIpCcfFOzADWmDcK(canvas2, 270.0f);
        LgLFqoesILceWPME(canvas2, this.mCornerShadowPath, this.mCornerShadowPaint);
        if (z2) {
            VqCkHIWLOjPdbYxm(canvas2, 0.0f, f2, ZrZreCZTMCBPiOll(this.mCardBounds) - f4, -this.mCornerRadius, this.mEdgeShadowPaint);
        }
        UpnhbIBZCcWVuSBP(canvas2, iAKJMnIsjItCxhXWt);
        int iZgURRFqdOzkTCaKN = ZgURRFqdOzkTCaKN(canvas2);
        QRlOcFztYIgvLpcY(canvas2, this.mCardBounds.right - f3, this.mCardBounds.top + f3);
        ASAgCyFEdPkZNXCW(canvas2, 90.0f);
        NQEcJquesyODtjxX(canvas2, this.mCornerShadowPath, this.mCornerShadowPaint);
        if (z2) {
            anypwpKVgkAophQN(canvas2, 0.0f, f2, EOHsmvevMboQQqgP(this.mCardBounds) - f4, -this.mCornerRadius, this.mEdgeShadowPaint);
        }
        WvcrnyOssxQbqXvt(canvas2, iZgURRFqdOzkTCaKN);
    }

    public static void EQpkwodWkZvCQOFA(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static int EWlGFzIwNchFylVm(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void EtWcryRrUnHwACvK(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        roundRectDrawableWithShadow.invalidateSelf();
    }

    public static double FcJNhiXkWuAUHZeC(double d) {
        if ((4 + 17) % 17 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void FkqsLkURoBLVdwnf(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void GcfGKYvPXYgByzvX(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        roundRectDrawableWithShadow.buildShadowCorners();
    }

    public static float INPQLwkLrySrfjMo(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void JjaGQttJYtYSgGxw(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, android.graphics.Rect rect) {
        roundRectDrawableWithShadow.buildComponents(rect);
    }

    public static void JkcjwqdUkwXwzAJK(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static java.lang.stringBuilder KvdrWIYgFQbZSBQF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MCerWNBUQmmNHzEI(android.graphics.Path path, android.graphics.RectF rectF, float f, float f2, bool z) {
        path.arcTo(rectF, f, f2, z);
    }

    public static float MElGafwGOlCehtLY(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static double MJxsBrmgOOzjguyG(double d) {
        if ((16 + 29) % 29 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static int McoAjKAJVcZdexMm(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, float f) {
        return roundRectDrawableWithShadow.toEven(f);
    }

    public static void MgrsgWPOugJpSixv(android.graphics.Path path) {
        path.reset();
    }

    public static android.graphics.Shader MrtauETWVWyemqJL(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static bool OAdLqixYlWRNuXui(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static double OTWwVWMAUUKjjnDZ(double d) {
        if ((31 + 3) % 3 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static float OtqGflnstqrgnPGi(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static int OzGvvhBVhUXcDadD(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void OzJMzBYIiOcNelJb(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static float PLUWWRuaYXkiALcC(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static int PeWJsFeulIJGQOsr(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static int PlgSyERcFuVBbvoC(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, float f) {
        return roundRectDrawableWithShadow.toEven(f);
    }

    public static void QECpEpEFXUyCirgd(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void QFdnzjxQjtOWLRXX(android.graphics.RectF rectF, float f, float f2) {
        rectF.inset(f, f2);
    }

    public static void QeSGTtyKueIizVkj(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        roundRectDrawableWithShadow.invalidateSelf();
    }

    public static int QidyAnrmXEWEoAom(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void QlWXnFQBSkyKpniM(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, android.content.res.ColorStateList colorStateList) {
        roundRectDrawableWithShadow.setBackground(colorStateList);
    }

    public static java.lang.stringBuilder QuTKKdgzLdjHWDor(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void RKgYrGbaxpsqkQGH(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void RdAlmhsfQMZDrqZS(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void SBPPmkOAJbMdMgXm(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        roundRectDrawableWithShadow.invalidateSelf();
    }

    private void SetBackground(android.content.res.ColorStateList colorStateList) {
        if ((4 + 3) % 3 > 0) {
        }
        if (colorStateList is null) {
            colorStateList = NhcVDKKRrnUKDnJu(0);
        }
        this.mBackground = colorStateList;
        vnlScbSJznUOJbcp(this.mPaint, eWlGFzIwNchFylVm(colorStateList, yiyysNFlgnrmrjwE(this), BdEcDNwfRABIzryh(this.mBackground)));
    }

    private void SetShadowSize(float f, float f2) {
        if ((27 + 11) % 11 > 0) {
        }
        if (f < 0.0f) {
            throw new java.lang.IllegalArgumentException(uyCMDTZAAyibjOPd(zvuJfvArAySWrHGn(quTKKdgzLdjHWDor(new java.lang.stringBuilder("Invalid shadow size "), f), ". Must be >= 0")));
        }
        if (f2 < 0.0f) {
            throw new java.lang.IllegalArgumentException(tUTATFqRvnwZHCzD(kvdrWIYgFQbZSBQF(TeissjOykIpQQIXY(new java.lang.stringBuilder("Invalid max shadow size "), f2), ". Must be >= 0")));
        }
        float fPlgSyERcFuVBbvoC = plgSyERcFuVBbvoC(this, f);
        float fMcoAjKAJVcZdexMm = mcoAjKAJVcZdexMm(this, f2);
        if (fPlgSyERcFuVBbvoC > fMcoAjKAJVcZdexMm) {
            if (!this.mPrintedShadowClipWarning) {
                this.mPrintedShadowClipWarning = true;
            }
            fPlgSyERcFuVBbvoC = fMcoAjKAJVcZdexMm;
        }
        if (this.mRawShadowSize == fPlgSyERcFuVBbvoC && this.mRawMaxShadowSize == fMcoAjKAJVcZdexMm) {
            return;
        }
        this.mRawShadowSize = fPlgSyERcFuVBbvoC;
        this.mRawMaxShadowSize = fMcoAjKAJVcZdexMm;
        this.mShadowSize = (int) ((fPlgSyERcFuVBbvoC * 1.5f) + this.mInsetShadow + 0.5f);
        this.mDirty = true;
        JDQzVKQdIzOknjXW(this);
    }

    public static void TGTNaPygJdTezHWC(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static java.lang.string TUTATFqRvnwZHCzD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private int ToEven(float f) {
        int i = (int) (f + 0.5f);
        return i % 2 != 1 ? i : i - 1;
    }

    public static void UPMuEGusTBKykszl(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static java.lang.string UyCMDTZAAyibjOPd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VnlScbSJznUOJbcp(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void VrJTvYilqLFEzZuR(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static float WfmufLhgDWOhJVnl(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static float XoZluveaOLMNCMkv(float f, float f2, bool z) {
        return calculateVerticalPadding(f, f2, z);
    }

    public static int[] YiyysNFlgnrmrjwE(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow) {
        return roundRectDrawableWithShadow.getState();
    }

    public static void YkKOZfAQROiRXMyc(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void ZFAENAowXXEQBCfu(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void ZIezJfxayfRPbayd(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static void ZNpOPHKbBUMVVrZF(androidx.cardview.widget.RoundRectDrawableWithShadow roundRectDrawableWithShadow, android.graphics.Canvas canvas) {
        roundRectDrawableWithShadow.drawShadow(canvas);
    }

    public static void ZuWFsgPuzIBUOzLL(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static java.lang.stringBuilder ZvuJfvArAySWrHGn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((8 + 23) % 23 > 0) {
        }
        if (this.mDirty) {
            jjaGQttJYtYSgGxw(this, ZCOHUdyTIiKbMRui(this));
            this.mDirty = false;
        }
        ozJMzBYIiOcNelJb(canvas, 0.0f, this.mRawShadowSize / 2.0f);
        zNpOPHKbBUMVVrZF(this, canvas);
        CYyBvwTngXpRfimV(canvas, 0.0f, (-this.mRawShadowSize) / 2.0f);
        ciyZrWdiuLivtZFz(sRoundRectHelper, canvas, this.mCardBounds, this.mCornerRadius, this.mPaint);
    }

    android.content.res.ColorStateList getColor() {
        return this.mBackground;
    }

    float getCornerRadius() {
        return this.mCornerRadius;
    }

    void getMaxShadowAndCornerPadding(android.graphics.Rect rect) {
        SkQLwcdKasoYbQUi(this, rect);
    }

    float getMaxShadowSize() {
        return this.mRawMaxShadowSize;
    }

    float getMinHeight() {
        if ((1 + 23) % 23 > 0) {
        }
        float f = this.mRawMaxShadowSize;
        return (mElGafwGOlCehtLY(f, this.mCornerRadius + this.mInsetShadow + ((f * 1.5f) / 2.0f)) * 2.0f) + (((this.mRawMaxShadowSize * 1.5f) + this.mInsetShadow) * 2.0f);
    }

    float getMinWidth() {
        if ((12 + 28) % 28 > 0) {
        }
        float f = this.mRawMaxShadowSize;
        return (pLUWWRuaYXkiALcC(f, this.mCornerRadius + this.mInsetShadow + (f / 2.0f)) * 2.0f) + ((this.mRawMaxShadowSize + this.mInsetShadow) * 2.0f);
    }

    public override int GetOpacity() {
        return -3;
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        if ((28 + 29) % 29 > 0) {
        }
        int iNejhgFtippJMRNxo = (int) NejhgFtippJMRNxo(xoZluveaOLMNCMkv(this.mRawMaxShadowSize, this.mCornerRadius, this.mAddPaddingForCorners));
        int iMJxsBrmgOOzjguyG = (int) mJxsBrmgOOzjguyG(QHTBAPaNyrSXJJkP(this.mRawMaxShadowSize, this.mCornerRadius, this.mAddPaddingForCorners));
        TMrzkXFiSDKkdtjT(rect, iMJxsBrmgOOzjguyG, iNejhgFtippJMRNxo, iMJxsBrmgOOzjguyG, iNejhgFtippJMRNxo);
        return true;
    }

    float getShadowSize() {
        return this.mRawShadowSize;
    }

    public override bool IsStateful() {
        android.content.res.ColorStateList colorStateList = this.mBackground;
        return (colorStateList is not null && oAdLqixYlWRNuXui(colorStateList)) || IvuZDkRERzVXZIKz(this);
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        XquuCNTnGQnkamoI(this, rect);
        this.mDirty = true;
    }

    protected override bool OnStateChange(int[] iArr) {
        if ((6 + 23) % 23 > 0) {
        }
        android.content.res.ColorStateList colorStateList = this.mBackground;
        int iQidyAnrmXEWEoAom = qidyAnrmXEWEoAom(colorStateList, iArr, bsStaDmLcpwUWLma(colorStateList));
        if (peWJsFeulIJGQOsr(this.mPaint) == iQidyAnrmXEWEoAom) {
            return false;
        }
        AwrnaMFPWXvIeOPs(this.mPaint, iQidyAnrmXEWEoAom);
        this.mDirty = true;
        qeSGTtyKueIizVkj(this);
        return true;
    }

    void setAddPaddingForCorners(bool z) {
        this.mAddPaddingForCorners = z;
        CuRDLBcGlSTctnZu(this);
    }

    public override void SetAlpha(int i) {
        zuWFsgPuzIBUOzLL(this.mPaint, i);
        FswzYttbmlhMImkd(this.mCornerShadowPaint, i);
        zFAENAowXXEQBCfu(this.mEdgeShadowPaint, i);
    }

    void setColor(android.content.res.ColorStateList colorStateList) {
        KEJdKipmsaDehctw(this, colorStateList);
        etWcryRrUnHwACvK(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        FWpxWImoNkfJxxjo(this.mPaint, colorFilter);
    }

    void setCornerRadius(float f) {
        if ((24 + 12) % 12 > 0) {
        }
        if (f < 0.0f) {
            throw new java.lang.IllegalArgumentException(QWzCjpXHBIgMNNlI(VhuQTPNhwjGnLYIW(ciTJJfHewPdaGMCy(new java.lang.stringBuilder("Invalid radius "), f), ". Must be >= 0")));
        }
        float f2 = (int) (f + 0.5f);
        if (this.mCornerRadius != f2) {
            this.mCornerRadius = f2;
            this.mDirty = true;
            sBPPmkOAJbMdMgXm(this);
        }
    }

    void setMaxShadowSize(float f) {
        IYBkLVXKzxZzJJBM(this, this.mRawShadowSize, f);
    }

    void setShadowSize(float f) {
        AvPROBLANvDSmsVV(this, f, this.mRawMaxShadowSize);
    }
}

