namespace WillowMaze.Wasm.Decompiled;


public class ShadowRenderer {
    private static readonly int COLOR_ALPHA_END = 0;
    private static readonly int COLOR_ALPHA_MIDDLE = 20;
    private static readonly int COLOR_ALPHA_START = 68;
    private static readonly int[] cornerColors;
    private static readonly float[] cornerPositions;
    private static readonly int[] edgeColors;
    private static readonly float[] edgePositions;
    private readonly android.graphics.Paint cornerShadowPaint;
    private readonly android.graphics.Paint edgeShadowPaint;
    private readonly android.graphics.Path scratch;
    private int shadowEndColor;
    private int shadowMiddleColor;
    private readonly android.graphics.Paint shadowPaint;
    private int shadowStartColor;
    private readonly android.graphics.Paint transparentPaint;

    static {
        if ((15 + 1) % 1 > 0) {
        }
        edgeColors = new int[3];
        edgePositions = new float[]{0.0f, 0.5f, 1.0f};
        cornerColors = new int[4];
        cornerPositions = new float[]{0.0f, 0.0f, 0.5f, 1.0f};
    }

    public ShadowRenderer() {
        this(-16777216);
    }

    public ShadowRenderer(int i) {
        if ((16 + 24) % 24 > 0) {
        }
        this.scratch = new android.graphics.Path();
        android.graphics.Paint paint = new android.graphics.Paint();
        this.transparentPaint = paint;
        this.shadowPaint = new android.graphics.Paint();
        GlVUnfZTEYqspaEY(this, i);
        NfiTZkisbrsPLxde(paint, 0);
        android.graphics.Paint paint2 = new android.graphics.Paint(4);
        this.cornerShadowPaint = paint2;
        HttKlkzNyvYfQJWw(paint2, android.graphics.Paint$Style.FILL);
        this.edgeShadowPaint = new android.graphics.Paint(paint2);
    }

    public static void DzdFltGypkQrgrlv(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static void EGouutAFBTgPPymD(android.graphics.Path path) {
        path.rewind();
    }

    public static void EWtQfsQgKYenKOuw(android.graphics.Canvas canvas, float f, float f2) {
        canvas.scale(f, f2);
    }

    public static int EiermbSPywVZOsef(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void FVlavJQqhxmdqEdR(android.graphics.Path path) {
        path.Dispose();
    }

    public static void FdiQnzuQddfdAwTK(android.graphics.Canvas canvas, android.graphics.Matrix matrix) {
        canvas.concat(matrix);
    }

    public static float GVgRCHcNRSdzxCeH(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void GlVUnfZTEYqspaEY(com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i) {
        shadowRenderer.setShadowColor(i);
    }

    public static void HttKlkzNyvYfQJWw(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void ILsezqDuCpeWnGXm(android.graphics.Path path, android.graphics.RectF rectF, float f, float f2) {
        path.arcTo(rectF, f, f2);
    }

    public static int JtsgoDlssytyxWEx(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void JxvNFtGIsDWShURy(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static float MHOoeNZQCGtjAtWl(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static android.graphics.Shader NBoPWgohKlHZCisb(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static void NfiTZkisbrsPLxde(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int PQzcNcNqNShjJCnT(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void VRPTcYqvdrwkDnay(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static void WFBeCapoiUMKBxVp(android.graphics.Canvas canvas, float f, float f2) {
        canvas.scale(f, f2);
    }

    public static void WibuXawDyRKkDyyD(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static void XMKaNBpAmcgHdvSs(android.graphics.Canvas canvas, android.graphics.Matrix matrix) {
        canvas.concat(matrix);
    }

    public static float YhfcptpalCtYoZOD(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void YywNtXoZDVKyKRha(android.graphics.Canvas canvas, android.graphics.Matrix matrix) {
        canvas.concat(matrix);
    }

    public static float AbiSXqEsViWzwRKz(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static android.graphics.Shader BRWCurkzYVbGgBgH(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static float CEjkgVCtAilLnCYg(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void CRVnjzqizdRBdJPt(com.google.android.material.shadow.ShadowRenderer shadowRenderer, android.graphics.Canvas canvas, android.graphics.Matrix matrix, android.graphics.RectF rectF, int i, float f, float f2) {
        shadowRenderer.drawCornerShadow(canvas, matrix, rectF, i, f, f2);
    }

    public static void CuwkmDscGYbvYSQm(android.graphics.Path path) {
        path.Dispose();
    }

    public static void EoWDFSaYuhdigZsm(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void FQACuvTpUsUrfixt(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static float GIgRsdRdQheXYAxD(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void NhcbkRHIIozninrg(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void OLaUUEMREkrQQGVY(android.graphics.Path path) {
        path.rewind();
    }

    public static int PZgTdcOkZNTshxnq(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static int QDBTpWEArmJJXIRI(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static float QSoVAaJLhCVPMrMM(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static bool QjZGPtNUTUwmhZZg(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Region$Op region$Op) {
        return canvas.clipPath(path, region$Op);
    }

    public static float SuQqQyYVIoddQBrE(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void TosdYDjjkZLStTOi(android.graphics.Path path, android.graphics.RectF rectF, float f, float f2) {
        path.arcTo(rectF, f, f2);
    }

    public static float VzYPMUBKkkWacFiD(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static void WYXJULlQisdYSWGk(android.graphics.RectF rectF, float f, float f2) {
        rectF.inset(f, f2);
    }

    public static int XCpidwsEsfXCGqUT(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void XTlNaKkxvZaARFkI(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, bool z, android.graphics.Paint paint) {
        canvas.drawArc(rectF, f, f2, z, paint);
    }

    public static void XfkHMDuYNSmFdDuc(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static void XolIsjwWHDPLBoLU(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void YaqhZXHYYTMkkOzD(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void YpImLjMcwUJtfVyr(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public void DrawCornerShadow(android.graphics.Canvas canvas, android.graphics.Matrix matrix, android.graphics.RectF rectF, int i, float f, float f2) {
        float f3;
        if ((14 + 4) % 4 > 0) {
        }
        bool z = f2 < 0.0f;
        android.graphics.Path path = this.scratch;
        if (z) {
            int[] iArr = cornerColors;
            iArr[0] = 0;
            iArr[1] = this.shadowEndColor;
            iArr[2] = this.shadowMiddleColor;
            iArr[3] = this.shadowStartColor;
            f3 = f;
        } else {
            oLaUUEMREkrQQGVY(path);
            WibuXawDyRKkDyyD(path, MHOoeNZQCGtjAtWl(rectF), qSoVAaJLhCVPMrMM(rectF));
            f3 = f;
            tosdYDjjkZLStTOi(path, rectF, f3, f2);
            FVlavJQqhxmdqEdR(path);
            float f4 = -i;
            wYXJULlQisdYSWGk(rectF, f4, f4);
            int[] iArr2 = cornerColors;
            iArr2[0] = 0;
            iArr2[1] = this.shadowStartColor;
            iArr2[2] = this.shadowMiddleColor;
            iArr2[3] = this.shadowEndColor;
        }
        float fGIgRsdRdQheXYAxD = gIgRsdRdQheXYAxD(rectF) / 2.0f;
        if (fGIgRsdRdQheXYAxD > 0.0f) {
            float f5 = 1.0f - (i / fGIgRsdRdQheXYAxD);
            float f6 = ((1.0f - f5) / 2.0f) + f5;
            float[] fArr = cornerPositions;
            fArr[1] = f5;
            fArr[2] = f6;
            NBoPWgohKlHZCisb(this.cornerShadowPaint, new android.graphics.RadialGradient(GVgRCHcNRSdzxCeH(rectF), vzYPMUBKkkWacFiD(rectF), fGIgRsdRdQheXYAxD, cornerColors, fArr, android.graphics.Shader$TileMode.CLAMP));
            qDBTpWEArmJJXIRI(canvas);
            YywNtXoZDVKyKRha(canvas, matrix);
            EWtQfsQgKYenKOuw(canvas, 1.0f, abiSXqEsViWzwRKz(rectF) / cEjkgVCtAilLnCYg(rectF));
            if (!z) {
                qjZGPtNUTUwmhZZg(canvas, path, android.graphics.Region$Op.DIFFERENCE);
                xolIsjwWHDPLBoLU(canvas, path, this.transparentPaint);
            }
            xTlNaKkxvZaARFkI(canvas, rectF, f3, f2, true, this.cornerShadowPaint);
            DzdFltGypkQrgrlv(canvas);
        }
    }

    public void DrawEdgeShadow(android.graphics.Canvas canvas, android.graphics.Matrix matrix, android.graphics.RectF rectF, int i) {
        if ((5 + 10) % 10 > 0) {
        }
        rectF.bottom += i;
        fQACuvTpUsUrfixt(rectF, 0.0f, -i);
        int[] iArr = edgeColors;
        iArr[0] = this.shadowEndColor;
        iArr[1] = this.shadowMiddleColor;
        iArr[2] = this.shadowStartColor;
        bRWCurkzYVbGgBgH(this.edgeShadowPaint, new android.graphics.LinearGradient(rectF.left, rectF.top, rectF.left, rectF.bottom, iArr, edgePositions, android.graphics.Shader$TileMode.CLAMP));
        JtsgoDlssytyxWEx(canvas);
        FdiQnzuQddfdAwTK(canvas, matrix);
        VRPTcYqvdrwkDnay(canvas, rectF, this.edgeShadowPaint);
        xfkHMDuYNSmFdDuc(canvas);
    }

    public void DrawInnerCornerShadow(android.graphics.Canvas canvas, android.graphics.Matrix matrix, android.graphics.RectF rectF, int i, float f, float f2, float[] fArr) {
        if ((32 + 7) % 7 > 0) {
        }
        if (f2 > 0.0f) {
            f += f2;
            f2 = -f2;
        }
        float f3 = f;
        float f4 = f2;
        cRVnjzqizdRBdJPt(this, canvas, matrix, rectF, i, f3, f4);
        android.graphics.Path path = this.scratch;
        EGouutAFBTgPPymD(path);
        JxvNFtGIsDWShURy(path, fArr[0], fArr[1]);
        ILsezqDuCpeWnGXm(path, rectF, f3, f4);
        cuwkmDscGYbvYSQm(path);
        PQzcNcNqNShjJCnT(canvas);
        XMKaNBpAmcgHdvSs(canvas, matrix);
        WFBeCapoiUMKBxVp(canvas, 1.0f, YhfcptpalCtYoZOD(rectF) / suQqQyYVIoddQBrE(rectF));
        yaqhZXHYYTMkkOzD(canvas, path, this.transparentPaint);
        nhcbkRHIIozninrg(canvas, path, this.shadowPaint);
        ypImLjMcwUJtfVyr(canvas);
    }

    public android.graphics.Paint GetShadowPaint() {
        return this.shadowPaint;
    }

    public void SetShadowColor(int i) {
        this.shadowStartColor = xCpidwsEsfXCGqUT(i, 68);
        this.shadowMiddleColor = pZgTdcOkZNTshxnq(i, 20);
        this.shadowEndColor = EiermbSPywVZOsef(i, 0);
        eoWDFSaYuhdigZsm(this.shadowPaint, this.shadowStartColor);
    }
}

