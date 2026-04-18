namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@java.lang.Deprecated
public class ShadowDrawableWrapper : androidx.appcompat.graphics.drawable.DrawableWrapperCompat {
    static readonly double COS_45 = 0.0d;
    static readonly float SHADOW_BOTTOM_SCALE = 1.0f;
    static readonly float SHADOW_HORIZ_SCALE = 0.5f;
    static readonly float SHADOW_MULTIPLIER = 1.5f;
    static readonly float SHADOW_TOP_SCALE = 0.25f;
    private bool addPaddingForCorners;
    readonly android.graphics.RectF contentBounds;
    float cornerRadius;
    readonly android.graphics.Paint cornerShadowPaint;
    android.graphics.Path cornerShadowPath;
    private bool dirty;
    readonly android.graphics.Paint edgeShadowPaint;
    float maxShadowSize;
    private bool printedShadowClipWarning;
    float rawMaxShadowSize;
    float rawShadowSize;
    private float rotation;
    private readonly int shadowEndColor;
    private readonly int shadowMiddleColor;
    float shadowSize;
    private readonly int shadowStartColor;

    static {
            goto L4
        L4:
            goto L29
        L7:
            goto L33
        Lb:
            int r0 = r0 + r1
            goto L42
        L11:
            goto L19
        L14:
            goto L48
        L18:
            return
        L19:
            goto L26
        L1d:
            if (r0 <= 0) goto L22
            goto L14
        L22:
            goto L11
        L26:
            goto L14
        L29:
            goto L51
        L2d:
            com.google.android.material.shadow.ShadowDrawableWrapper.COS_45 = r0
            goto L18
        L33:
            r0 = 4
            goto L5c
        L3a:
            double r0 = qlgTYkLAkhHEiJXA(r0)
            goto L54
        L42:
            int r0 = r0 % r1
            goto L1d
        L48:
            r0 = 4631530004285489152(0x4046800000000000, double:45.0)
            goto L3a
        L51:
            goto L7
        L54:
            double r0 = LXcHvatZfOfBYiLY(r0)
            goto L2d
        L5c:
            r1 = 14
            goto Lb
    }

    public ShadowDrawableWrapper(android.content.object r2, android.graphics.drawable.Drawable r3, float r4, float r5, float r6) {
            r1 = this;
            goto L77
        L4:
            int r4 = ocsWBzsFTGxcvfYo(r4)
            goto Lc
        Lc:
            float r4 = (float) r4
            goto L18
        L11:
            oPSbUGmEAwbVFxys(r4, r3)
            goto Ld7
        L18:
            r1.cornerRadius = r4
            goto Lc9
        L1e:
            int r0 = com.google.android.material.C1151R.color.design_fab_shadow_end_color
            goto L69
        L24:
            r1.shadowMiddleColor = r0
            goto L1e
        L2a:
            r3 = 1
            goto Laa
        L2f:
            UgWlrPKTjXlgbSej(r2, r0)
            goto L4
        L36:
            int r0 = waQbjYfIgAkJSyNB(r2, r0)
            goto L85
        L3e:
            r1.printedShadowClipWarning = r3
            goto L50
        L44:
            r1.addPaddingForCorners = r3
            goto L9e
        L4a:
            android.graphics.Paint$Style r0 = android.graphics.Paint.Style.FILL
            goto L2f
        L50:
            int r0 = com.google.android.material.C1151R.color.design_fab_shadow_start_color
            goto L36
        L56:
            int r0 = com.google.android.material.C1151R.color.design_fab_shadow_mid_color
            goto Lcf
        L5c:
            r1.edgeShadowPaint = r4
            goto L11
        L62:
            r1.<init>(r3)
            goto L2a
        L69:
            int r2 = aglVGCYmStwsoirq(r2, r0)
            goto L91
        L71:
            android.graphics.Paint r4 = new android.graphics.Paint
            goto L7e
        L77:
            goto Lb7
        L7a:
            goto L62
        L7e:
            r4.<init>(r2)
            goto L5c
        L85:
            r1.shadowStartColor = r0
            goto L56
        L8b:
            r1.cornerShadowPaint = r2
            goto L4a
        L91:
            r1.shadowEndColor = r2
            goto Lc0
        L97:
            r4.<init>()
            goto Lb0
        L9e:
            r3 = 0
            goto L3e
        La3:
            r2.<init>(r0)
            goto L8b
        Laa:
            r1.dirty = r3
            goto L44
        Lb0:
            r1.contentBounds = r4
            goto L71
        Lb6:
            return
        Lb7:
            goto Lc6
        Lbb:
            r0 = 5
            goto La3
        Lc0:
            android.graphics.Paint r2 = new android.graphics.Paint
            goto Lbb
        Lc6:
            goto L7a
        Lc9:
            android.graphics.RectF r4 = new android.graphics.RectF
            goto L97
        Lcf:
            int r0 = qHDkqdbLmweLOXAM(r2, r0)
            goto L24
        Ld7:
            iYzoDNNUCZxUmbJa(r1, r5, r6)
            goto Lb6
    }

    public static void AYXOjffIZtQCcXvg(com.google.android.material.shadow.ShadowDrawableWrapper r0) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.invalidateSelf()
            goto L7
    }

    public static void BxchzWmllAdEZKjK(com.google.android.material.shadow.ShadowDrawableWrapper r0, float r1, float r2) {
            goto L13
        L4:
            r0.setShadowSize(r1, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static void ByLjHUrlLNicUQho(android.graphics.Canvas r0, float r1, float r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.scale(r1, r2)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static float COnMSdJfvJIHexcb(float r1, float r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            float r0 = java.lang.Math.max(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void CkegyDbhpqKsakng(android.graphics.Canvas r0, float r1, float r2) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.scale(r1, r2)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void DMdBAsSXiCngAaiK(android.graphics.Canvas r0, float r1, float r2, float r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.rotate(r1, r2, r3)
            goto Le
    }

    public static float GfuFocHuBtqAoQsp(float r1, float r2, bool r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            float r0 = calculateHorizontalPadding(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.graphics.Rect HIrUEleWplXcgXup(com.google.android.material.shadow.ShadowDrawableWrapper r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.graphics.Rect r0 = r1.getBounds()
            goto Le
    }

    public static void HMjtGsbkBbovxYwa(android.graphics.Canvas r0, float r1, float r2) {
            goto L10
        L4:
            r0.translate(r1, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void HMpwsmbUnJUgKJyj(android.graphics.Canvas r0, float r1, float r2, float r3, float r4, android.graphics.Paint r5) {
            goto Lb
        L4:
            r0.drawRect(r1, r2, r3, r4, r5)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static int HqraWFKtVbelYfLP(float r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = toEven(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void JrINAlokyPnRIxdz(android.graphics.Paint r0, int r1) {
            goto L13
        L4:
            r0.setAlpha(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static void LUKtSWYVymSlAqjp(android.graphics.Canvas r0, android.graphics.Path r1, android.graphics.Paint r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.drawPath(r1, r2)
            goto L7
    }

    public static double LXcHvatZfOfBYiLY(double r2) {
            goto L1f
        L4:
            r0 = 30
            goto L18
        Lb:
            goto L27
        Le:
            goto L2b
        L12:
            int r0 = r0 % r1
            goto L39
        L18:
            r1 = 29
            goto L33
        L1f:
            goto L45
        L22:
            goto L4
        L26:
            return r0
        L27:
            goto L42
        L2b:
            double r0 = java.lang.Math.cos(r2)
            goto L26
        L33:
            int r0 = r0 + r1
            goto L12
        L39:
            if (r0 <= 0) goto L3e
            goto Le
        L3e:
            goto Lb
        L42:
            goto Le
        L45:
            goto L49
        L49:
            goto L22
    }

    public static float LcsXAQJQbrzuGYpe(android.graphics.RectF r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            float r0 = r1.width()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static android.graphics.drawable.Drawable LdQRtvYBRKDyIXYQ(com.google.android.material.shadow.ShadowDrawableWrapper r1) {
            goto Lf
        L4:
            goto L12
        L7:
            android.graphics.drawable.Drawable r0 = r1.getDrawable()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void LowgMLtfcDCLCUaF(android.graphics.Canvas r0, float r1, float r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.scale(r1, r2)
            goto L7
    }

    public static void NWwFHXYwRfqSCxLF(android.graphics.Canvas r0, float r1, float r2, float r3, float r4, android.graphics.Paint r5) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.drawRect(r1, r2, r3, r4, r5)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static float ODpOCLnIlDPdKsEQ(android.graphics.RectF r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            float r0 = r1.height()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static float OeBByajsLZfEvEep(float r1, float r2) {
            goto L14
        L4:
            float r0 = java.lang.Math.max(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void OocPyVFfXucfAzpO(com.google.android.material.shadow.ShadowDrawableWrapper r0, android.graphics.Rect r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.buildComponents(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void PJNfauVbKLpGHgFI(android.graphics.Paint r0, int r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setAlpha(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static float PUFwmcKfdhqzHRRa(float r1, float r2, bool r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            float r0 = calculateVerticalPadding(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static float QfbPgUPrLtsvESbe(android.graphics.RectF r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            float r0 = r1.centerX()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void RPECuSEnDYKIywlM(android.graphics.Canvas r0, int r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.restoreToCount(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void RfHJeDheSEcnGyWv(android.graphics.Canvas r0, int r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.restoreToCount(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void SJenyDtCgZKeqDbp(com.google.android.material.shadow.ShadowDrawableWrapper r0) {
            goto L13
        L4:
            r0.buildShadowCorners()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static void SnIeEDQqcfVYkvKI(com.google.android.material.shadow.ShadowDrawableWrapper r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.invalidateSelf()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static int TWIkfIEGQlGNGukD(android.graphics.Canvas r1) {
            goto Lf
        L4:
            int r0 = r1.save()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static android.graphics.Shader TXolfErKumynNyuL(android.graphics.Paint r1, android.graphics.Shader r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            android.graphics.Shader r0 = r1.setShader(r2)
            goto L7
    }

    public static void TbMJSdYIijyrlIgY(android.graphics.RectF r0, float r1, float r2, float r3, float r4) {
            goto L13
        L4:
            r0.set(r1, r2, r3, r4)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static int TnLxLvHyJIIDtoGY(android.graphics.Canvas r1) {
            goto Lc
        L4:
            int r0 = r1.save()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void TusswFihXoZWhvzL(android.graphics.Canvas r0, int r1) {
            goto Le
        L4:
            r0.restoreToCount(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void UTlevOsqGdgPnROu(android.graphics.Canvas r0, int r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.restoreToCount(r1)
            goto L7
    }

    public static int UWWEdQHhSecErskA(float r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = java.lang.Math.round(r1)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void UgWlrPKTjXlgbSej(android.graphics.Paint r0, android.graphics.Paint.Style r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.setStyle(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void UqWMNEYwsbBlzpTG(android.graphics.Canvas r0, int r1) {
            goto L10
        L4:
            r0.restoreToCount(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void VJKgvuTosuBCxALl(android.graphics.Canvas r0, float r1) {
            goto L13
        L4:
            r0.rotate(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static void VXohHIneEKKDHAOz(android.graphics.Path r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.Dispose()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static double WkmadOQSswZLyxfA(double r2) {
            goto L1c
        L4:
            goto L15
        L7:
            goto L19
        Lb:
            r0 = 13
            goto L23
        L12:
            goto L3a
        L15:
            goto L44
        L19:
            goto L1f
        L1c:
            goto L7
        L1f:
            goto Lb
        L23:
            r1 = 18
            goto L3e
        L2a:
            if (r0 <= 0) goto L2f
            goto L15
        L2f:
            goto L12
        L33:
            int r0 = r0 % r1
            goto L2a
        L39:
            return r0
        L3a:
            goto L4
        L3e:
            int r0 = r0 + r1
            goto L33
        L44:
            double r0 = java.lang.Math.ceil(r2)
            goto L39
    }

    public static void WwgDmlFccDnOBEkF(android.graphics.Paint r0, bool r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.setAntiAlias(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void YRkSSuQqZLscRExY(com.google.android.material.shadow.ShadowDrawableWrapper r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.invalidateSelf()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static int YjRCUWHQUlcsBvUt(android.graphics.Canvas r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            int r0 = r1.save()
            goto L4
    }

    public static void ZaSvjxTulcEWVlgY(android.graphics.Canvas r0, android.graphics.Path r1, android.graphics.Paint r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.drawPath(r1, r2)
            goto Le
    }

    public static int ZlkwczVoaSVYbteV(float r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            int r0 = java.lang.Math.round(r1)
            goto Lb
    }

    public static void AEJAeGPXZEbZwPTh(android.graphics.Canvas r0, float r1, float r2) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.translate(r1, r2)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void AUlirYkGFTsdnOPm(android.graphics.Path r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.reset()
            goto Le
    }

    public static void AVMbmHizpLTAHSDn(android.graphics.Path r0, android.graphics.RectF r1, float r2, float r3, bool r4) {
            goto L13
        L4:
            r0.arcTo(r1, r2, r3, r4)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static int AglVGCYmStwsoirq(android.content.object r1, int r2) {
            goto Lc
        L4:
            int r0 = androidx.core.content.objectCompat.getColor(r1, r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static float BKBEecenPpwAUCcD(android.graphics.RectF r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            float r0 = r1.width()
            goto L4
    }

    public static void BceuipGNFlSjxfen(com.google.android.material.shadow.ShadowDrawableWrapper r0, android.graphics.Canvas r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.drawShadow(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    private void BuildComponents(android.graphics.Rect r7) {
            r6 = this;
            goto L51
        L4:
            int r7 = r7.bottom
            goto Lb7
        La:
            android.graphics.drawable.Drawable r7 = LdQRtvYBRKDyIXYQ(r6)
            goto Lf0
        L12:
            r1 = 1069547520(0x3fc00000, float:1.5)
            goto L1d
        L18:
            float r2 = r2 + r3
            goto L2d
        L1d:
            float r0 = r0 * r1
            goto Lc6
        L22:
            int r0 = (int) r0
            goto L102
        L27:
            android.graphics.RectF r2 = r6.contentBounds
            goto Ld3
        L2d:
            int r3 = r7.top
            goto Lc1
        L33:
            android.graphics.RectF r3 = r6.contentBounds
            goto Lac
        L39:
            goto L6b
        L3c:
            goto Ld9
        L40:
            TbMJSdYIijyrlIgY(r1, r2, r3, r4, r7)
            goto La
        L47:
            float r4 = r4 - r5
            goto L4
        L4c:
            float r4 = (float) r4
            goto L76
        L51:
            goto L95
        L54:
            goto L6f
        L58:
            if (r0 <= 0) goto L5d
            goto L3c
        L5d:
            goto L39
        L61:
            goto L54
        L64:
            int r2 = r7.left
            goto Le5
        L6a:
            return
        L6b:
            goto L92
        L6f:
            r0 = 9
            goto Lcc
        L76:
            float r5 = r6.rawMaxShadowSize
            goto L47
        L7c:
            int r2 = (int) r2
            goto L33
        L81:
            SJenyDtCgZKeqDbp(r6)
            goto L6a
        L88:
            int r1 = (int) r1
            goto L27
        L8d:
            int r3 = (int) r3
            goto La5
        L92:
            goto L3c
        L95:
            goto L61
        L99:
            int r0 = r0 % r1
            goto L58
        L9f:
            int r0 = r0 + r1
            goto L99
        La5:
            tyvvPJfPQvVYGTWD(r7, r0, r1, r2, r3)
            goto L81
        Lac:
            float r3 = r3.bottom
            goto L8d
        Lb2:
            float r3 = r3 + r0
            goto Lf6
        Lb7:
            float r7 = (float) r7
            goto Lbc
        Lbc:
            float r7 = r7 - r0
            goto L40
        Lc1:
            float r3 = (float) r3
            goto Lb2
        Lc6:
            android.graphics.RectF r1 = r6.contentBounds
            goto L64
        Lcc:
            r1 = 14
            goto L9f
        Ld3:
            float r2 = r2.right
            goto L7c
        Ld9:
            float r0 = r6.rawMaxShadowSize
            goto L12
        Ldf:
            float r0 = r0.left
            goto L22
        Le5:
            float r2 = (float) r2
            goto Lfc
        Lea:
            float r1 = r1.top
            goto L88
        Lf0:
            android.graphics.RectF r0 = r6.contentBounds
            goto Ldf
        Lf6:
            int r4 = r7.right
            goto L4c
        Lfc:
            float r3 = r6.rawMaxShadowSize
            goto L18
        L102:
            android.graphics.RectF r1 = r6.contentBounds
            goto Lea
    }

    private void BuildShadowCorners() {
            r15 = this;
            goto L1c2
        L4:
            int r11 = r15.shadowMiddleColor
            goto L8f
        La:
            r8 = r7
            goto L11c
        Lf:
            float r10 = -r2
            goto L1ec
        L14:
            if (r0 <= 0) goto L19
            goto L268
        L19:
            goto L265
        L1d:
            int r0 = r0 + r1
            goto Lec
        L23:
            float r1 = r15.cornerRadius
            goto L259
        L29:
            android.graphics.Path r2 = r15.cornerShadowPath
            goto L12e
        L2f:
            android.graphics.Shader$TileMode r13 = android.graphics.Shader.TileMode.CLAMP
            goto L129
        L35:
            float r3 = -r2
            goto L249
        L3a:
            float r9 = r0.top
            goto L84
        L40:
            r2 = 2
            goto L1b0
        L45:
            r1.<init>(r0)
            goto L52
        L4c:
            android.graphics.Paint r2 = r15.edgeShadowPaint
            goto L185
        L52:
            float r2 = r15.shadowSize
            goto L35
        L58:
            r5 = 1065353216(0x3f800000, float:1.0)
            goto L5e
        L5e:
            float r7 = r5 - r2
            goto L14a
        L64:
            android.graphics.Paint r14 = r15.cornerShadowPaint
            goto La
        L6a:
            int r0 = r15.shadowStartColor
            goto L105
        L70:
            r0 = 20
            goto Le0
        L77:
            r7.<init>(r8, r9, r10, r11, r12, r13)
            goto L10e
        L7e:
            android.graphics.Path r2 = r15.cornerShadowPath
            goto Lda
        L84:
            float r11 = r1.top
            goto L6a
        L8a:
            float r3 = -r3
            goto L115
        L8f:
            int r12 = r15.shadowEndColor
            goto L137
        L95:
            gxRgVqFklOvTfcrE(r2, r3)
            goto L7e
        L9c:
            r10 = 0
            goto L19e
        La1:
            int[] r12 = new int[]{r0, r1, r4}
            goto L221
        La9:
            r3 = 1132920832(0x43870000, float:270.0)
            goto L1ce
        Laf:
            schtbAWRIswPmPGT(r1, r3, r2)
            goto L29
        Lb6:
            if (r2 > 0) goto Lbb
            goto L111
        Lbb:
            goto L23d
        Lbf:
            return
        Lca:
            goto L122
        Lce:
            float[] r12 = new float[r9]
            goto L1da
        Ld4:
            r5 = 1119092736(0x42b40000, float:90.0)
            goto L145
        Lda:
            float r3 = r15.cornerRadius
            goto L215
        Le0:
            r1 = 17
            goto L1d
        Le7:
            r3 = 3
            goto Lb6
        Lec:
            int r0 = r0 % r1
            goto L14
        Lf2:
            float r3 = r15.shadowSize
            goto L8a
        Lf8:
            dfErLDNyAsHxKxSx(r2, r7)
            goto L1e0
        Lff:
            r12[r3] = r5
            goto L2f
        L105:
            int r1 = r15.shadowMiddleColor
            goto L15e
        L10b:
            goto L1c5
        L10e:
            TXolfErKumynNyuL(r14, r7)
        L111:
            goto L4c
        L115:
            cdulbnCbXqXuwPrR(r2, r3, r4)
            goto L169
        L11c:
            android.graphics.RadialGradient r7 = new android.graphics.RadialGradient
            goto L1b6
        L122:
            goto L268
        L125:
            goto L10b
        L129:
            r8 = 0
            goto L180
        L12e:
            if (r2 == 0) goto L133
            goto L245
        L133:
            goto L204
        L137:
            int[] r11 = new int[]{r6, r9, r11, r12}
            goto L24e
        L13f:
            r15.cornerShadowPath = r2
            goto L243
        L145:
            r6 = 0
            goto L21a
        L14a:
            r8 = 1073741824(0x40000000, float:2.0)
            goto L238
        L150:
            VXohHIneEKKDHAOz(r2)
            goto L198
        L157:
            aUlirYkGFTsdnOPm(r2)
        L15a:
            goto L1bc
        L15e:
            int r4 = r15.shadowEndColor
            goto La1
        L164:
            r4 = 0
            goto L191
        L169:
            android.graphics.Path r2 = r15.cornerShadowPath
            goto L17a
        L16f:
            float r3 = -r1
            goto L25e
        L174:
            android.graphics.Path r2 = r15.cornerShadowPath
            goto La9
        L17a:
            r3 = 1127481344(0x43340000, float:180.0)
            goto Ld4
        L180:
            r9 = 0
            goto L77
        L185:
            android.graphics.LinearGradient r7 = new android.graphics.LinearGradient
            goto L3a
        L18b:
            android.graphics.RectF r0 = new android.graphics.RectF
            goto L23
        L191:
            smanDzrGLggecExY(r2, r3, r4)
            goto L253
        L198:
            float r2 = r1.top
            goto Lf
        L19e:
            r7.<init>(r8, r9, r10, r11, r12, r13, r14)
            goto Lf8
        L1a5:
            android.graphics.Path$FillType r3 = android.graphics.Path.FillType.EVEN_ODD
            goto L95
        L1ab:
            float r7 = r7 + r2
            goto L64
        L1b0:
            r12[r2] = r8
            goto Lff
        L1b6:
            int r9 = r15.shadowStartColor
            goto L4
        L1bc:
            android.graphics.Path r2 = r15.cornerShadowPath
            goto L1a5
        L1c2:
            goto L125
        L1c5:
            goto L70
        L1c9:
            float r2 = r2 / r10
            goto L58
        L1ce:
            r5 = -1028390912(0xffffffffc2b40000, float:-90.0)
            goto L1fd
        L1d4:
            android.graphics.Shader$TileMode r14 = android.graphics.Shader.TileMode.CLAMP
            goto L1f2
        L1da:
            r12[r6] = r4
            goto L20a
        L1e0:
            android.graphics.Paint r15 = r15.edgeShadowPaint
            goto L22a
        L1e6:
            android.graphics.Path r2 = r15.cornerShadowPath
            goto L150
        L1ec:
            int r2 = (r10 > r4 ? 1 : (r10 == r4 ? 0 : -1))
            goto Le7
        L1f2:
            r8 = 0
            goto L9c
        L1f7:
            r12[r4] = r2
            goto L40
        L1fd:
            zwIfTLMemlVRWCEq(r2, r0, r3, r5, r6)
            goto L1e6
        L204:
            android.graphics.Path r2 = new android.graphics.Path
            goto L231
        L20a:
            r4 = 1
            goto L1f7
        L20f:
            android.graphics.RectF r1 = new android.graphics.RectF
            goto L45
        L215:
            float r3 = -r3
            goto L164
        L21a:
            aVMbmHizpLTAHSDn(r2, r1, r3, r5, r6)
            goto L174
        L221:
            float[] r13 = new float[r3]
            r13 = {x00c0: FILL_ARRAY_DATA , data: [0, 1056964608, 1065353216} // fill-array
            goto L1d4
        L22a:
            WwgDmlFccDnOBEkF(r15, r6)
            goto Lbf
        L231:
            r2.<init>()
            goto L13f
        L238:
            float r7 = r7 / r8
            goto L1ab
        L23d:
            float r2 = r15.cornerRadius
            goto L1c9
        L243:
            goto L15a
        L245:
            goto L157
        L249:
            float r2 = -r2
            goto Laf
        L24e:
            r9 = 4
            goto Lce
        L253:
            android.graphics.Path r2 = r15.cornerShadowPath
            goto Lf2
        L259:
            float r2 = -r1
            goto L16f
        L25e:
            r0.<init>(r2, r3, r1, r1)
            goto L20f
        L265:
            goto Lca
        L268:
            goto L18b
    }

    public static void CLujPtnaPYJKcBjU(androidx.appcompat.graphics.drawable.DrawableWrapperCompat r0, android.graphics.Canvas r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            super.draw(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static float CalculateHorizontalPadding(float r6, float r7, bool r8) {
            goto L4c
        L4:
            return r6
        L5:
            goto L6b
        L9:
            r1 = 26
            goto L10
        L10:
            int r0 = r0 + r1
            goto L59
        L16:
            double r4 = com.google.android.material.shadow.ShadowDrawableWrapper.COS_45
            goto L42
        L1c:
            if (r8 != 0) goto L21
            goto L48
        L21:
            goto L72
        L25:
            double r6 = (double) r7
            goto L36
        L2a:
            double r0 = r0 + r2
            goto L47
        L2f:
            r0 = 27
            goto L9
        L36:
            double r2 = r2 * r6
            goto L2a
        L3b:
            goto L5
        L3e:
            goto L1c
        L42:
            double r2 = r2 - r4
            goto L25
        L47:
            float r6 = (float) r0
        L48:
            goto L4
        L4c:
            goto L6e
        L4f:
            goto L2f
        L53:
            r2 = 4607182418800017408(0x3ff0000000000000, double:1.0)
            goto L16
        L59:
            int r0 = r0 % r1
            goto L62
        L5f:
            goto L4f
        L62:
            if (r0 <= 0) goto L67
            goto L3e
        L67:
            goto L3b
        L6b:
            goto L3e
        L6e:
            goto L5f
        L72:
            double r0 = (double) r6
            goto L53
    }

    public static float CalculateVerticalPadding(float r6, float r7, bool r8) {
            goto L49
        L4:
            r0 = 14
            goto L61
        Lb:
            double r2 = r2 - r4
            goto L16
        L10:
            r2 = 4607182418800017408(0x3ff0000000000000, double:1.0)
            goto L80
        L16:
            double r6 = (double) r7
            goto L3d
        L1b:
            goto L45
        L1e:
            goto L22
        L22:
            goto L4c
        L25:
            double r0 = (double) r6
            goto L10
        L2a:
            return r6
        L2b:
            goto L1b
        L2f:
            float r6 = (float) r0
            goto L7b
        L34:
            if (r0 <= 0) goto L39
            goto L45
        L39:
            goto L42
        L3d:
            double r2 = r2 * r6
            goto L68
        L42:
            goto L2b
        L45:
            goto L5b
        L49:
            goto L1e
        L4c:
            goto L4
        L50:
            float r6 = r6 * r0
            goto L2a
        L55:
            int r0 = r0 % r1
            goto L34
        L5b:
            r0 = 1069547520(0x3fc00000, float:1.5)
            goto L72
        L61:
            r1 = 8
            goto L86
        L68:
            double r0 = r0 + r2
            goto L2f
        L6d:
            float r6 = r6 * r0
            goto L25
        L72:
            if (r8 != 0) goto L77
            goto L7c
        L77:
            goto L6d
        L7b:
            return r6
        L7c:
            goto L50
        L80:
            double r4 = com.google.android.material.shadow.ShadowDrawableWrapper.COS_45
            goto Lb
        L86:
            int r0 = r0 + r1
            goto L55
    }

    public static void CdulbnCbXqXuwPrR(android.graphics.Path r0, float r1, float r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.rLineTo(r1, r2)
            goto L7
    }

    public static android.graphics.Shader DfErLDNyAsHxKxSx(android.graphics.Paint r1, android.graphics.Shader r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.graphics.Shader r0 = r1.setShader(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    private void DrawShadow(android.graphics.Canvas r19) {
            r18 = this;
            goto L2aa
        L4:
            iTyQMnivITldVKVz(r1, r13, r14)
            goto L3e3
        Lb:
            int r2 = (r2 > r4 ? 1 : (r2 == r4 ? 0 : -1))
            goto L434
        L11:
            r16 = r2
            goto L1f0
        L17:
            float r4 = r4.left
            goto L201
        L1d:
            float r2 = r2 + r8
            goto L1fb
        L22:
            gTHJzQhpTdbIUZaR(r1, r2, r4)
            goto L24e
        L29:
            NWwFHXYwRfqSCxLF(r1, r2, r3, r4, r5, r6)
        L2c:
            goto L277
        L30:
            r4 = 1065353216(0x3f800000, float:1.0)
            goto L36d
        L36:
            float r5 = r5 + r8
            goto L160
        L3b:
            r2 = r0
            goto L355
        L40:
            android.graphics.Paint r5 = r0.edgeShadowPaint
            goto L409
        L46:
            int r2 = (r2 > r4 ? 1 : (r2 == r4 ? 0 : -1))
            goto L2f7
        L4c:
            float r4 = rMIqbJaCtILxZPMc(r4)
            goto L32f
        L54:
            r12 = r2
        L55:
            goto L21f
        L59:
            float r2 = r2 - r9
            goto L18a
        L5e:
            HMjtGsbkBbovxYwa(r1, r2, r4)
            goto L3d0
        L65:
            aEJAeGPXZEbZwPTh(r1, r2, r4)
            goto L4
        L6c:
            LUKtSWYVymSlAqjp(r1, r2, r4)
            goto La6
        L73:
            ByLjHUrlLNicUQho(r1, r13, r14)
            goto L29f
        L7a:
            float r5 = r0.cornerRadius
            goto L272
        L80:
            float r12 = r4 / r14
            goto L1e3
        L86:
            return
        L87:
            goto L3d7
        L8b:
            float r4 = r12 / r13
            goto L1d6
        L91:
            float r2 = lTPtHWxAFRRLBnag(r2)
            goto L241
        L99:
            r17 = r12
            goto L1ea
        L9f:
            LowgMLtfcDCLCUaF(r1, r12, r4)
            goto L213
        La6:
            if (r11 != 0) goto Lab
            goto L393
        Lab:
            goto L31b
        Laf:
            int r0 = r0 + r1
            goto L171
        Lb5:
            r10 = r6
        Lb6:
            goto L39d
        Lba:
            float r4 = r4 * r2
            goto L44f
        Lbf:
            RPECuSEnDYKIywlM(r1, r7)
            goto L86
        Lc6:
            ZaSvjxTulcEWVlgY(r1, r4, r5)
            goto Lf1
        Lcd:
            android.graphics.RectF r5 = r0.contentBounds
            goto L345
        Ld3:
            r6 = 0
            goto L269
        Ld8:
            oYYDywgzRaDkwyqX(r1, r4, r5)
            goto L73
        Ldf:
            float r3 = r0.shadowSize
            goto L3b9
        Le5:
            android.graphics.RectF r2 = r0.contentBounds
            goto L91
        Leb:
            float r2 = r17 / r13
            goto L11d
        Lf1:
            if (r10 != 0) goto Lf6
            goto L1f7
        Lf6:
            goto L8b
        Lfa:
            UTlevOsqGdgPnROu(r1, r6)
            goto Lbf
        L101:
            if (r0 <= 0) goto L106
            goto L15c
        L106:
            goto L159
        L10a:
            android.graphics.RectF r4 = r0.contentBounds
            goto L219
        L110:
            oTnCtoCRqLLwTZcT(r1, r2, r4)
            goto L3a8
        L117:
            android.graphics.RectF r4 = r0.contentBounds
            goto L135
        L11d:
            r4 = r17
            goto L195
        L123:
            float r4 = r2 - r9
            goto L1aa
        L129:
            r12 = 1065353216(0x3f800000, float:1.0)
            goto L33f
        L12f:
            android.graphics.Paint r5 = r0.cornerShadowPaint
            goto Lc6
        L135:
            float r4 = LcsXAQJQbrzuGYpe(r4)
            goto L28b
        L13d:
            r1 = r19
            goto L246
        L143:
            r2 = 0
            goto L29
        L148:
            android.graphics.Paint r6 = r0.edgeShadowPaint
            goto L3de
        L14e:
            android.graphics.RectF r4 = r0.contentBounds
            goto L4c
        L154:
            float r5 = -r2
            goto L2bf
        L159:
            goto L87
        L15c:
            goto L1a4
        L160:
            float r13 = r8 / r5
            goto L257
        L166:
            android.graphics.Paint r4 = r0.cornerShadowPaint
            goto L22
        L16c:
            float r2 = -r8
            goto Ldf
        L171:
            int r0 = r0 % r1
            goto L101
        L177:
            wyYDLpYPKPDiuHxR(r1, r2)
            goto L23b
        L17e:
            r2 = 1132920832(0x43870000, float:270.0)
            goto L298
        L184:
            float r4 = r0.cornerRadius
            goto L2c5
        L18a:
            r4 = 0
            goto L46
        L18f:
            android.graphics.RectF r2 = r0.contentBounds
            goto L37f
        L195:
            CkegyDbhpqKsakng(r1, r2, r4)
            goto L427
        L19c:
            float r3 = QfbPgUPrLtsvESbe(r3)
            goto L14e
        L1a4:
            r0 = r18
            goto L13d
        L1aa:
            float r2 = r0.cornerRadius
            goto L2fc
        L1b0:
            r5 = 1056964608(0x3f000000, float:0.5)
            goto L3bf
        L1b6:
            float r2 = r2 + r8
            goto L10a
        L1bb:
            android.graphics.Paint r4 = r0.cornerShadowPaint
            goto L6c
        L1c1:
            android.graphics.RectF r4 = r0.contentBounds
            goto L17
        L1c7:
            r0 = 31
            goto L40e
        L1ce:
            int r12 = TnLxLvHyJIIDtoGY(r1)
            goto L449
        L1d6:
            nMNpNkqaAPJkfluv(r1, r4, r12)
            goto L117
        L1dd:
            float r2 = r0.rotation
            goto L397
        L1e3:
            nkVEuPQRyePISPpF(r1, r12, r4)
            goto Le5
        L1ea:
            r12 = r16
            goto L2f0
        L1f0:
            r2 = 0
            goto L99
        L1f5:
            goto L55
        L1f7:
            goto L3fe
        L1fb:
            float r15 = r8 / r2
            goto L206
        L201:
            float r4 = r4 + r8
            goto Lcd
        L206:
            int r2 = TWIkfIEGQlGNGukD(r1)
            goto L1c1
        L20e:
            float r2 = r2 - r8
            goto L373
        L213:
            android.graphics.RectF r2 = r0.contentBounds
            goto L313
        L219:
            float r4 = r4.bottom
            goto L43d
        L21f:
            RfHJeDheSEcnGyWv(r1, r12)
            goto L1ce
        L226:
            float r2 = r2.right
            goto L404
        L22c:
            float r2 = ODpOCLnIlDPdKsEQ(r2)
            goto L2a5
        L234:
            TusswFihXoZWhvzL(r1, r12)
            goto L321
        L23b:
            android.graphics.Path r2 = r0.cornerShadowPath
            goto L455
        L241:
            float r2 = r2 - r9
            goto L184
        L246:
            int r7 = mhEWwIavXPNeflao(r1)
            goto L1dd
        L24e:
            if (r11 != 0) goto L253
            goto L2c
        L253:
            goto L30
        L257:
            float r4 = r4 + r8
            goto L329
        L25c:
            hJdUtutfvWtiGcZI(r1, r2)
            goto L367
        L263:
            r4 = 1073741824(0x40000000, float:2.0)
            goto L361
        L269:
            if (r2 > 0) goto L26e
            goto L2d7
        L26e:
            goto L3b4
        L272:
            float r5 = -r5
            goto L35b
        L277:
            UqWMNEYwsbBlzpTG(r1, r10)
            goto L27e
        L27e:
            int r6 = xzlswvJSHItcEMEu(r1)
            goto L2e1
        L286:
            float r4 = r4 + r8
            goto L65
        L28b:
            float r4 = r4 - r9
            goto L7a
        L290:
            float r2 = bKBEecenPpwAUCcD(r2)
            goto L263
        L298:
            VJKgvuTosuBCxALl(r1, r2)
            goto L2db
        L29f:
            android.graphics.Path r4 = r0.cornerShadowPath
            goto L12f
        L2a5:
            float r2 = r2 - r9
            goto Lb
        L2aa:
            goto L3da
        L2ad:
            goto L1c7
        L2b1:
            float r2 = iqWGYTzkRbuNjpST(r2)
            goto L123
        L2b9:
            float r2 = r0.rawShadowSize
            goto L385
        L2bf:
            android.graphics.Paint r6 = r0.edgeShadowPaint
            goto L143
        L2c5:
            float r4 = -r4
            goto L40
        L2ca:
            float r4 = r4.top
            goto L286
        L2d0:
            float r5 = r5 + r2
            goto L148
        L2d5:
            goto Lb6
        L2d7:
            goto Lb5
        L2db:
            android.graphics.Path r2 = r0.cornerShadowPath
            goto L166
        L2e1:
            android.graphics.RectF r2 = r0.contentBounds
            goto L226
        L2e7:
            goto L3b0
        L2e9:
            goto L3af
        L2ed:
            goto L2ad
        L2f0:
            HMpwsmbUnJUgKJyj(r1, r2, r3, r4, r5, r6)
            goto L1f5
        L2f7:
            r5 = 1
            goto Ld3
        L2fc:
            float r2 = -r2
            goto L307
        L301:
            r2 = 1127481344(0x43340000, float:180.0)
            goto L177
        L307:
            float r5 = r0.shadowSize
            goto L2d0
        L30d:
            float r2 = r2.right
            goto L20e
        L313:
            float r2 = pVIXQrNTTFSQMgAl(r2)
            goto L379
        L31b:
            r4 = 1065353216(0x3f800000, float:1.0)
            goto L80
        L321:
            int r10 = YjRCUWHQUlcsBvUt(r1)
            goto L18f
        L329:
            float r14 = r8 / r4
            goto L1d
        L32f:
            DMdBAsSXiCngAaiK(r1, r2, r3, r4)
            goto L3ee
        L336:
            if (r10 != 0) goto L33b
            goto L430
        L33b:
            goto Leb
        L33f:
            float r6 = r2 * r12
            goto L3f4
        L345:
            float r5 = r5.top
            goto L350
        L34b:
            float r4 = r4 - r8
            goto L110
        L350:
            float r5 = r5 + r8
            goto Ld8
        L355:
            r0 = r19
            goto L38b
        L35b:
            android.graphics.Paint r6 = r0.edgeShadowPaint
            goto L11
        L361:
            float r9 = r8 * r4
            goto L59
        L367:
            android.graphics.Path r2 = r0.cornerShadowPath
            goto L1bb
        L36d:
            float r12 = r4 / r15
            goto L9f
        L373:
            android.graphics.RectF r4 = r0.contentBounds
            goto L421
        L379:
            float r4 = r2 - r9
            goto L415
        L37f:
            float r2 = r2.left
            goto L1b6
        L385:
            r4 = 1048576000(0x3e800000, float:0.25)
            goto Lba
        L38b:
            zCmFfNNAukDAreOD(r0, r1, r2, r3, r4, r5)
            goto L392
        L392:
            r1 = r0
        L393:
            goto Lfa
        L397:
            android.graphics.RectF r3 = r0.contentBounds
            goto L19c
        L39d:
            android.graphics.RectF r2 = r0.contentBounds
            goto L22c
        L3a3:
            r11 = r5
            goto L2e7
        L3a8:
            tpQumIZJtFiDyWFr(r1, r13, r15)
            goto L301
        L3af:
            r11 = r6
        L3b0:
            goto L2b9
        L3b4:
            r10 = r5
            goto L2d5
        L3b9:
            float r3 = r2 - r3
            goto L41b
        L3bf:
            float r5 = r5 * r2
            goto L3ca
        L3c4:
            android.graphics.RectF r4 = r0.contentBounds
            goto L2ca
        L3ca:
            float r5 = r2 - r5
            goto L129
        L3d0:
            lwlJbdTqWKKeFznN(r1, r13, r15)
            goto L17e
        L3d7:
            goto L15c
        L3da:
            goto L2ed
        L3de:
            r2 = 0
            goto L42d
        L3e3:
            r2 = 1119092736(0x42b40000, float:90.0)
            goto L25c
        L3e9:
            r3 = r2
            goto L3b
        L3ee:
            float r8 = r0.cornerRadius
            goto L16c
        L3f4:
            float r2 = r2 - r6
            goto L36
        L3f9:
            r0 = r3
            goto L3e9
        L3fe:
            r17 = r12
            goto L54
        L404:
            float r2 = r2 - r8
            goto L3c4
        L409:
            r1 = 0
            goto L3f9
        L40e:
            r1 = 12
            goto Laf
        L415:
            float r2 = r0.cornerRadius
            goto L154
        L41b:
            android.graphics.RectF r2 = r0.contentBounds
            goto L290
        L421:
            float r4 = r4.bottom
            goto L34b
        L427:
            android.graphics.RectF r2 = r0.contentBounds
            goto L2b1
        L42d:
            wrdJMKLNtJCDoXhn(r1, r2, r3, r4, r5, r6)
        L430:
            goto L234
        L434:
            if (r2 > 0) goto L439
            goto L2e9
        L439:
            goto L3a3
        L43d:
            float r4 = r4 - r8
            goto L5e
        L442:
            ldlosjixiHQRKzlX(r1, r2, r4)
            goto L336
        L449:
            android.graphics.RectF r2 = r0.contentBounds
            goto L30d
        L44f:
            float r4 = r2 - r4
            goto L1b0
        L455:
            android.graphics.Paint r4 = r0.cornerShadowPaint
            goto L442
    }

    public static void GTHJzQhpTdbIUZaR(android.graphics.Canvas r0, android.graphics.Path r1, android.graphics.Paint r2) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.drawPath(r1, r2)
            goto L4
    }

    public static void GxRgVqFklOvTfcrE(android.graphics.Path r0, android.graphics.Path.FillType r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.setFillType(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void HJdUtutfvWtiGcZI(android.graphics.Canvas r0, float r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.rotate(r1)
            goto Lb
        L17:
            goto L7
    }

    public static void ITyQMnivITldVKVz(android.graphics.Canvas r0, float r1, float r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.scale(r1, r2)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void IYzoDNNUCZxUmbJa(com.google.android.material.shadow.ShadowDrawableWrapper r0, float r1, float r2) {
            goto Lb
        L4:
            r0.setShadowSize(r1, r2)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static float IqWGYTzkRbuNjpST(android.graphics.RectF r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            float r0 = r1.width()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static double ItDGvBfBQWGkpKnC(double r2) {
            goto L4
        L4:
            goto L35
        L7:
            goto L40
        Lb:
            r1 = 5
            goto L12
        L12:
            int r0 = r0 + r1
            goto L18
        L18:
            int r0 = r0 % r1
            goto L21
        L1e:
            goto L7
        L21:
            if (r0 <= 0) goto L26
            goto L3c
        L26:
            goto L39
        L2a:
            double r0 = java.lang.Math.ceil(r2)
            goto L47
        L32:
            goto L3c
        L35:
            goto L1e
        L39:
            goto L48
        L3c:
            goto L2a
        L40:
            r0 = 9
            goto Lb
        L47:
            return r0
        L48:
            goto L32
    }

    public static void JWgFhGvHxcRovEtm(androidx.appcompat.graphics.drawable.DrawableWrapperCompat r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            super.setAlpha(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static float LTPtHWxAFRRLBnag(android.graphics.RectF r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            float r0 = r1.height()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void LdlosjixiHQRKzlX(android.graphics.Canvas r0, android.graphics.Path r1, android.graphics.Paint r2) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.drawPath(r1, r2)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void LwlJbdTqWKKeFznN(android.graphics.Canvas r0, float r1, float r2) {
            goto Lb
        L4:
            r0.scale(r1, r2)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static int MhEWwIavXPNeflao(android.graphics.Canvas r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.save()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void NMNpNkqaAPJkfluv(android.graphics.Canvas r0, float r1, float r2) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.scale(r1, r2)
            goto L4
    }

    public static int NYfKzXTCcFhNgNfM(float r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = toEven(r1)
            goto Le
    }

    public static void NkVEuPQRyePISPpF(android.graphics.Canvas r0, float r1, float r2) {
            goto Le
        L4:
            r0.scale(r1, r2)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void OPSbUGmEAwbVFxys(android.graphics.Paint r0, bool r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.setAntiAlias(r1)
            goto Lb
    }

    public static void OTnCtoCRqLLwTZcT(android.graphics.Canvas r0, float r1, float r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.translate(r1, r2)
            goto Le
    }

    public static void OWEKZFYCCGFzfeXy(android.graphics.Rect r0, int r1, int r2, int r3, int r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.set(r1, r2, r3, r4)
            goto Lb
    }

    public static void OYYDywgzRaDkwyqX(android.graphics.Canvas r0, float r1, float r2) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.translate(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static int OcsWBzsFTGxcvfYo(float r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            int r0 = java.lang.Math.round(r1)
            goto L7
    }

    public static void OwUzeWlzpPMitZbJ(com.google.android.material.shadow.ShadowDrawableWrapper r0, float r1, float r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setShadowSize(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static float PVIXQrNTTFSQMgAl(android.graphics.RectF r1) {
            goto L14
        L4:
            goto L17
        L7:
            float r0 = r1.height()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static int QHDkqdbLmweLOXAM(android.content.object r1, int r2) {
            goto Lc
        L4:
            int r0 = androidx.core.content.objectCompat.getColor(r1, r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static double QlgTYkLAkhHEiJXA(double r2) {
            goto L4
        L4:
            goto L48
        L7:
            goto L17
        Lb:
            goto L7
        Le:
            if (r0 <= 0) goto L13
            goto L21
        L13:
            goto L1e
        L17:
            r0 = 15
            goto L2b
        L1e:
            goto L41
        L21:
            goto L38
        L25:
            int r0 = r0 + r1
            goto L32
        L2b:
            r1 = 16
            goto L25
        L32:
            int r0 = r0 % r1
            goto Le
        L38:
            double r0 = java.lang.Math.toRadians(r2)
            goto L40
        L40:
            return r0
        L41:
            goto L45
        L45:
            goto L21
        L48:
            goto Lb
    }

    public static float RMIqbJaCtILxZPMc(android.graphics.RectF r1) {
            goto L11
        L4:
            float r0 = r1.centerY()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void SchtbAWRIswPmPGT(android.graphics.RectF r0, float r1, float r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.inset(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void SmanDzrGLggecExY(android.graphics.Path r0, float r1, float r2) {
            goto L13
        L4:
            r0.moveTo(r1, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static int TJHclycbvXcFiWuK(float r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            int r0 = java.lang.Math.round(r1)
            goto Le
    }

    private static int ToEven(float r2) {
            goto L4
        L4:
            goto L3e
        L7:
            goto L2c
        Lb:
            r1 = 10
            goto L54
        L12:
            r1 = 1
            goto L4b
        L17:
            return r2
        L18:
            goto L3b
        L1c:
            goto L18
        L1f:
            goto L33
        L23:
            if (r0 <= 0) goto L28
            goto L1f
        L28:
            goto L1c
        L2c:
            r0 = 18
            goto Lb
        L33:
            int r2 = ZlkwczVoaSVYbteV(r2)
            goto L45
        L3b:
            goto L1f
        L3e:
            goto L42
        L42:
            goto L7
        L45:
            int r0 = r2 % 2
            goto L12
        L4b:
            if (r0 == r1) goto L50
            goto L5b
        L50:
            goto L5a
        L54:
            int r0 = r0 + r1
            goto L5f
        L5a:
            int r2 = r2 - r1
        L5b:
            goto L17
        L5f:
            int r0 = r0 % r1
            goto L23
    }

    public static void TpQumIZJtFiDyWFr(android.graphics.Canvas r0, float r1, float r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.scale(r1, r2)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void TyvvPJfPQvVYGTWD(android.graphics.drawable.Drawable r0, int r1, int r2, int r3, int r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.setBounds(r1, r2, r3, r4)
            goto L4
    }

    public static int WaQbjYfIgAkJSyNB(android.content.object r1, int r2) {
            goto Lf
        L4:
            int r0 = androidx.core.content.objectCompat.getColor(r1, r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void WrdJMKLNtJCDoXhn(android.graphics.Canvas r0, float r1, float r2, float r3, float r4, android.graphics.Paint r5) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.drawRect(r1, r2, r3, r4, r5)
            goto L4
        L17:
            goto Lc
    }

    public static void WyYDLpYPKPDiuHxR(android.graphics.Canvas r0, float r1) {
            goto Lb
        L4:
            r0.rotate(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static int XzlswvJSHItcEMEu(android.graphics.Canvas r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = r1.save()
            goto Le
    }

    public static void YYTFmEUltZtNudUk(com.google.android.material.shadow.ShadowDrawableWrapper r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.invalidateSelf()
            goto Lb
        L17:
            goto L7
    }

    public static void ZCmFfNNAukDAreOD(android.graphics.Canvas r0, float r1, float r2, float r3, float r4, android.graphics.Paint r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.drawRect(r1, r2, r3, r4, r5)
            goto Le
    }

    public static void ZwIfTLMemlVRWCEq(android.graphics.Path r0, android.graphics.RectF r1, float r2, float r3, bool r4) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.arcTo(r1, r2, r3, r4)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    @Override // androidx.appcompat.graphics.drawable.DrawableWrapperCompat, android.graphics.drawable.Drawable
    public void Draw(android.graphics.Canvas r2) {
            r1 = this;
            goto L31
        L4:
            return
        L5:
            goto L38
        L9:
            bceuipGNFlSjxfen(r1, r2)
            goto L22
        L10:
            r0 = 0
            goto L3b
        L15:
            bool r0 = r1.dirty
            goto L41
        L1b:
            OocPyVFfXucfAzpO(r1, r0)
            goto L10
        L22:
            cLujPtnaPYJKcBjU(r1, r2)
            goto L4
        L29:
            android.graphics.Rect r0 = HIrUEleWplXcgXup(r1)
            goto L1b
        L31:
            goto L5
        L34:
            goto L15
        L38:
            goto L34
        L3b:
            r1.dirty = r0
        L3d:
            goto L9
        L41:
            if (r0 != 0) goto L46
            goto L3d
        L46:
            goto L29
    }

    public float GetCornerRadius() {
            r0 = this;
            goto L12
        L4:
            float r0 = r0.cornerRadius
            goto Ld
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    public float GetMaxShadowSize() {
            r0 = this;
            goto Lf
        L4:
            float r0 = r0.rawMaxShadowSize
            goto La
        La:
            return r0
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            goto L12
    }

    public float GetMinHeight() {
            r5 = this;
            goto L3b
        L4:
            if (r0 <= 0) goto L9
            goto L5c
        L9:
            goto L59
        Ld:
            float r5 = r5 * r2
            goto L7d
        L12:
            goto L3e
        L15:
            float r0 = r0 + r5
            goto L21
        L1a:
            r0 = 3
            goto L26
        L21:
            return r0
        L22:
            goto L87
        L26:
            r1 = 9
            goto L6b
        L2d:
            float r0 = OeBByajsLZfEvEep(r0, r1)
            goto L66
        L35:
            float r3 = r0 * r2
            goto L77
        L3b:
            goto L8a
        L3e:
            goto L1a
        L42:
            float r3 = r3 / r4
            goto L82
        L47:
            int r0 = r0 % r1
            goto L4
        L4d:
            float r0 = r5.rawMaxShadowSize
            goto L60
        L53:
            r2 = 1069547520(0x3fc00000, float:1.5)
            goto L35
        L59:
            goto L22
        L5c:
            goto L4d
        L60:
            float r1 = r5.cornerRadius
            goto L53
        L66:
            float r0 = r0 * r4
            goto L71
        L6b:
            int r0 = r0 + r1
            goto L47
        L71:
            float r5 = r5.rawMaxShadowSize
            goto Ld
        L77:
            r4 = 1073741824(0x40000000, float:2.0)
            goto L42
        L7d:
            float r5 = r5 * r4
            goto L15
        L82:
            float r1 = r1 + r3
            goto L2d
        L87:
            goto L5c
        L8a:
            goto L12
    }

    public float GetMinWidth() {
            r4 = this;
            goto L6b
        L4:
            r1 = 12
            goto Lb
        Lb:
            int r0 = r0 + r1
            goto L2d
        L11:
            goto L7a
        L14:
            goto L4f
        L18:
            float r0 = COnMSdJfvJIHexcb(r0, r1)
            goto L66
        L20:
            r0 = 22
            goto L4
        L27:
            float r0 = r4.rawMaxShadowSize
            goto L5b
        L2d:
            int r0 = r0 % r1
            goto L52
        L33:
            float r0 = r0 + r4
            goto L61
        L38:
            float r3 = r0 / r2
            goto L72
        L3e:
            r2 = 1073741824(0x40000000, float:2.0)
            goto L38
        L44:
            float r4 = r4.rawMaxShadowSize
            goto L4a
        L4a:
            float r4 = r4 * r2
            goto L33
        L4f:
            goto L6e
        L52:
            if (r0 <= 0) goto L57
            goto L7a
        L57:
            goto L77
        L5b:
            float r1 = r4.cornerRadius
            goto L3e
        L61:
            return r0
        L62:
            goto L11
        L66:
            float r0 = r0 * r2
            goto L44
        L6b:
            goto L14
        L6e:
            goto L20
        L72:
            float r1 = r1 + r3
            goto L18
        L77:
            goto L62
        L7a:
            goto L27
    }

    @Override // androidx.appcompat.graphics.drawable.DrawableWrapperCompat, android.graphics.drawable.Drawable
    public int GetOpacity() {
            r0 = this;
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0 = -3
            goto L4
    }

    @Override // androidx.appcompat.graphics.drawable.DrawableWrapperCompat, android.graphics.drawable.Drawable
    public bool GetPadding(android.graphics.Rect r4) {
            r3 = this;
            goto L68
        L4:
            float r1 = r3.rawMaxShadowSize
            goto L9b
        La:
            double r1 = (double) r3
            goto L39
        Lf:
            bool r2 = r3.addPaddingForCorners
            goto L15
        L15:
            float r0 = PUFwmcKfdhqzHRRa(r0, r1, r2)
            goto L6f
        L1d:
            r1 = 29
            goto L59
        L24:
            int r3 = (int) r1
            goto L4c
        L29:
            goto L6b
        L2c:
            r0 = 3
            goto L1d
        L33:
            float r0 = r3.rawMaxShadowSize
            goto L53
        L39:
            double r1 = itDGvBfBQWGkpKnC(r1)
            goto L24
        L41:
            int r0 = (int) r0
            goto L4
        L46:
            bool r3 = r3.addPaddingForCorners
            goto L7c
        L4c:
            oWEKZFYCCGFzfeXy(r4, r3, r0, r3, r0)
            goto L96
        L53:
            float r1 = r3.cornerRadius
            goto Lf
        L59:
            int r0 = r0 + r1
            goto L8b
        L5f:
            if (r0 <= 0) goto L64
            goto La4
        L64:
            goto La1
        L68:
            goto L87
        L6b:
            goto L2c
        L6f:
            double r0 = (double) r0
            goto L74
        L74:
            double r0 = WkmadOQSswZLyxfA(r0)
            goto L41
        L7c:
            float r3 = GfuFocHuBtqAoQsp(r1, r2, r3)
            goto La
        L84:
            goto La4
        L87:
            goto L29
        L8b:
            int r0 = r0 % r1
            goto L5f
        L91:
            return r3
        L92:
            goto L84
        L96:
            r3 = 1
            goto L91
        L9b:
            float r2 = r3.cornerRadius
            goto L46
        La1:
            goto L92
        La4:
            goto L33
    }

    public float GetShadowSize() {
            r0 = this;
            goto Ld
        L4:
            float r0 = r0.rawShadowSize
            goto L14
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return r0
        L15:
            goto La
    }

    @Override // androidx.appcompat.graphics.drawable.DrawableWrapperCompat, android.graphics.drawable.Drawable
    protected void OnBoundsChange(android.graphics.Rect r1) {
            r0 = this;
            goto L17
        L4:
            r1 = 1
            goto Lc
        L9:
            goto L1a
        Lc:
            r0.dirty = r1
            goto L12
        L12:
            return
        L13:
            goto L9
        L17:
            goto L13
        L1a:
            goto L4
    }

    public void SetAddPaddingForCorners(bool r1) {
            r0 = this;
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r0.addPaddingForCorners = r1
            goto L19
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
        L19:
            YRkSSuQqZLscRExY(r0)
            goto L4
    }

    @Override // androidx.appcompat.graphics.drawable.DrawableWrapperCompat, android.graphics.drawable.Drawable
    public void SetAlpha(int r2) {
            r1 = this;
            goto L1d
        L4:
            jWgFhGvHxcRovEtm(r1, r2)
            goto L17
        Lb:
            PJNfauVbKLpGHgFI(r0, r2)
            goto L2b
        L12:
            return
        L13:
            goto L31
        L17:
            android.graphics.Paint r0 = r1.cornerShadowPaint
            goto Lb
        L1d:
            goto L13
        L20:
            goto L4
        L24:
            JrINAlokyPnRIxdz(r1, r2)
            goto L12
        L2b:
            android.graphics.Paint r1 = r1.edgeShadowPaint
            goto L24
        L31:
            goto L20
    }

    public void SetCornerRadius(float r2) {
            r1 = this;
            goto L20
        L4:
            goto L23
        L7:
            if (r0 == 0) goto Lc
            goto L1c
        Lc:
            goto L1b
        L10:
            return
        L11:
            goto L4
        L15:
            r1.cornerRadius = r2
            goto L4d
        L1b:
            return
        L1c:
            goto L15
        L20:
            goto L11
        L23:
            goto L34
        L27:
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L7
        L2d:
            yYTFmEUltZtNudUk(r1)
            goto L10
        L34:
            int r2 = UWWEdQHhSecErskA(r2)
            goto L3c
        L3c:
            float r2 = (float) r2
            goto L41
        L41:
            float r0 = r1.cornerRadius
            goto L27
        L47:
            r1.dirty = r2
            goto L2d
        L4d:
            r2 = 1
            goto L47
    }

    public void SetMaxShadowSize(float r2) {
            r1 = this;
            goto L10
        L4:
            BxchzWmllAdEZKjK(r1, r0, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L1a
        L17:
            goto L13
        L1a:
            float r0 = r1.rawShadowSize
            goto L4
    }

    public readonly void SetRotation(float r2) {
            r1 = this;
            goto L2e
        L4:
            goto L31
        L7:
            AYXOjffIZtQCcXvg(r1)
        La:
            goto L20
        Le:
            float r0 = r1.rotation
            goto L14
        L14:
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L25
        L1a:
            r1.rotation = r2
            goto L7
        L20:
            return
        L21:
            goto L4
        L25:
            if (r0 != 0) goto L2a
            goto La
        L2a:
            goto L1a
        L2e:
            goto L21
        L31:
            goto Le
    }

    public void SetShadowSize(float r2) {
            r1 = this;
            goto Lb
        L4:
            owUzeWlzpPMitZbJ(r1, r2, r0)
            goto L1b
        Lb:
            goto L1c
        Le:
            goto L12
        L12:
            float r0 = r1.rawMaxShadowSize
            goto L4
        L18:
            goto Le
        L1b:
            return
        L1c:
            goto L18
    }

    public void SetShadowSize(float r3, float r4) {
            r2 = this;
            goto La4
        L4:
            r2.rawMaxShadowSize = r4
            goto L127
        La:
            if (r0 == 0) goto Lf
            goto L5b
        Lf:
            goto Ldc
        L13:
            SnIeEDQqcfVYkvKI(r2)
            goto Lbd
        L1a:
            if (r0 <= 0) goto L1f
            goto L33
        L1f:
            goto L30
        L23:
            r2.dirty = r1
            goto L13
        L29:
            r2.<init>(r3)
            goto Lf8
        L30:
            goto Lf9
        L33:
            goto Lfd
        L37:
            r2.shadowSize = r3
            goto L108
        L3d:
            if (r0 >= 0) goto L42
            goto Lbe
        L42:
            goto L10e
        L46:
            float r3 = r3 * r0
            goto L11f
        L4b:
            if (r0 == 0) goto L50
            goto L5b
        L50:
            goto L5a
        L54:
            int r0 = r0 + r1
            goto L12d
        L5a:
            return
        L5b:
            goto Ld0
        L5f:
            goto L33
        L62:
            goto Lef
        L66:
            r1 = 19
            goto L54
        L6d:
            r2.printedShadowClipWarning = r1
        L6f:
            goto L82
        L73:
            float r4 = (float) r4
            goto Lf2
        L78:
            r1 = 1
            goto L116
        L7d:
            float r3 = (float) r3
            goto L37
        L82:
            r3 = r4
        L83:
            goto L9e
        L87:
            int r0 = (r4 > r0 ? 1 : (r4 == r0 ? 0 : -1))
            goto L3d
        L8d:
            int r1 = (r3 > r0 ? 1 : (r3 == r0 ? 0 : -1))
            goto Lab
        L93:
            bool r3 = r2.printedShadowClipWarning
            goto Lb4
        L99:
            float r3 = (float) r3
            goto Lc8
        L9e:
            float r0 = r2.rawShadowSize
            goto Le9
        La4:
            goto L62
        La7:
            goto Le2
        Lab:
            if (r1 >= 0) goto Lb0
            goto Lbe
        Lb0:
            goto L87
        Lb4:
            if (r3 == 0) goto Lb9
            goto L6f
        Lb9:
            goto L6d
        Lbd:
            return
        Lbe:
            goto Lc2
        Lc2:
            java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
            goto Ld6
        Lc8:
            int r4 = nYfKzXTCcFhNgNfM(r4)
            goto L73
        Ld0:
            r2.rawShadowSize = r3
            goto L4
        Ld6:
            java.lang.string r3 = "invalid shadow size"
            goto L29
        Ldc:
            float r0 = r2.rawMaxShadowSize
            goto L102
        Le2:
            r0 = 4
            goto L66
        Le9:
            int r0 = (r0 > r3 ? 1 : (r0 == r3 ? 0 : -1))
            goto La
        Lef:
            goto La7
        Lf2:
            int r0 = (r3 > r4 ? 1 : (r3 == r4 ? 0 : -1))
            goto L78
        Lf8:
            throw r2
        Lf9:
            goto L5f
        Lfd:
            r0 = 0
            goto L8d
        L102:
            int r0 = (r0 > r4 ? 1 : (r0 == r4 ? 0 : -1))
            goto L4b
        L108:
            r2.maxShadowSize = r4
            goto L23
        L10e:
            int r3 = HqraWFKtVbelYfLP(r3)
            goto L99
        L116:
            if (r0 > 0) goto L11b
            goto L83
        L11b:
            goto L93
        L11f:
            int r3 = tJHclycbvXcFiWuK(r3)
            goto L7d
        L127:
            r0 = 1069547520(0x3fc00000, float:1.5)
            goto L46
        L12d:
            int r0 = r0 % r1
            goto L1a
    }
}

