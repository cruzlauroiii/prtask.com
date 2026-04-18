namespace WillowMaze.Wasm.Decompiled;


class RoundRectDrawable : android.graphics.drawable.Drawable {
    private android.content.res.ColorStateList mBackground;
    private readonly android.graphics.RectF mBoundsF;
    private readonly android.graphics.Rect mBoundsI;
    private float mPadding;
    private float mRadius;
    private android.content.res.ColorStateList mTint;
    private android.graphics.PorterDuffColorFilter mTintFilter;
    private bool mInsetForPadding = false;
    private bool mInsetForRadius = true;
    private android.graphics.PorterDuff$Mode mTintMode = android.graphics.PorterDuff$Mode.SRC_IN;
    private readonly android.graphics.Paint mPaint = new android.graphics.Paint(5);

    RoundRectDrawable(android.content.res.ColorStateList colorStateList, float f) {
        this.mRadius = f;
        TjUMCvDZcdjDugIU(this, colorStateList);
        this.mBoundsF = new android.graphics.RectF();
        this.mBoundsI = new android.graphics.Rect();
    }

    public static android.graphics.PorterDuffColorFilter BUNgVgCvpBUInyDi(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return roundRectDrawable.createTintFilter(colorStateList, porterDuff$Mode);
    }

    public static android.graphics.ColorFilter DSByjrIPjaKNUUzB(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static int FlyMIGJQcACTuFjW(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static int FnsvpsOlzJieugxz(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static float GMyJkxkZycsaeJGR(float f, float f2, bool z) {
        return androidx.cardview.widget.RoundRectDrawableWithShadow.calculateHorizontalPadding(f, f2, z);
    }

    public static int HUnAgEnhLtqJWmVs(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.graphics.ColorFilter JgcywqXaXYhktptu(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void NIsiUnLATzPtpnhw(android.graphics.Outline outline, android.graphics.Rect rect, float f) {
        outline.setRoundRect(rect, f);
    }

    public static int NShIqjLuufgymkho(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void PncZXCEcoyyOiETm(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        roundRectDrawable.invalidateSelf();
    }

    public static int PuewTwyIBeIaLChH(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.graphics.PorterDuffColorFilter QiYkqzePKfcFgIDj(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return roundRectDrawable.createTintFilter(colorStateList, porterDuff$Mode);
    }

    public static int[] SVauvbvneVGeuezO(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        return roundRectDrawable.getState();
    }

    public static int[] SVvxOpNCNamjUzWn(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        return roundRectDrawable.getState();
    }

    public static void TjUMCvDZcdjDugIU(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.content.res.ColorStateList colorStateList) {
        roundRectDrawable.setBackground(colorStateList);
    }

    public static void TnSBpsCZKxJHDcUD(android.graphics.Rect rect, int i, int i2) {
        rect.inset(i, i2);
    }

    public static void UsOMfijzDbZyYOQN(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        roundRectDrawable.invalidateSelf();
    }

    public static int VbLzpMhhKDJBzlVN(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static double WuVZVdLFIzNoEFvs(double d) {
        if ((4 + 23) % 23 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static android.graphics.ColorFilter XQyXhSFgLNDWMufY(android.graphics.Paint paint) {
        return paint.getColorFilter();
    }

    public static void XxjvNsyUZBKZEpvR(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.content.res.ColorStateList colorStateList) {
        roundRectDrawable.setBackground(colorStateList);
    }

    public static android.graphics.PorterDuffColorFilter YrmQBlHgfUjLDfQE(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return roundRectDrawable.createTintFilter(colorStateList, porterDuff$Mode);
    }

    public static void ZSdSqwZwHGYjHOFz(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void BGDYwmLYpEvhELXS(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.graphics.Rect rect) {
        roundRectDrawable.updateBounds(rect);
    }

    public static void BLMZiPMcAGLtQOnR(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.graphics.Rect rect) {
        roundRectDrawable.updateBounds(rect);
    }

    private android.graphics.PorterDuffColorFilter CreateTintFilter(android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (colorStateList is null || porterDuff$Mode is null) {
            return null;
        }
        return new android.graphics.PorterDuffColorFilter(HUnAgEnhLtqJWmVs(colorStateList, SVauvbvneVGeuezO(this), 0), porterDuff$Mode);
    }

    public static bool FEIVYubcvCWgbobM(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static android.graphics.ColorFilter GUiHKbhClsAXmZAi(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void HGZGxOAqrrzAGVrl(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static float HgqQmdGnVLdERLFJ(float f, float f2, bool z) {
        return androidx.cardview.widget.RoundRectDrawableWithShadow.calculateVerticalPadding(f, f2, z);
    }

    public static double KnbPhWZhOXJOlJYK(double d) {
        if ((6 + 24) % 24 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static bool LMdYtGkyzSIHDbZA(android.graphics.drawable.Drawable drawable) {
        return super.isStateful();
    }

    public static void MUrrQLHhcTnPpTmc(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        roundRectDrawable.invalidateSelf();
    }

    public static void OVzTtuFHnptkbSym(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void QDCecddDAOUCAhGZ(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static bool QLzdkVlzsbHfixTR(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static void QPimNvDNSSkZgTdf(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void QQvZjjmAJeOGmgTH(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    private void SetBackground(android.content.res.ColorStateList colorStateList) {
        if ((9 + 13) % 13 > 0) {
        }
        if (colorStateList is null) {
            colorStateList = wuzHeDqPjQnqPeVo(0);
        }
        this.mBackground = colorStateList;
        xxIpDYViLOatBaqo(this.mPaint, FlyMIGJQcACTuFjW(colorStateList, SVvxOpNCNamjUzWn(this), FnsvpsOlzJieugxz(this.mBackground)));
    }

    public static void TgrOOpLCBGpmIbIH(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        roundRectDrawable.invalidateSelf();
    }

    public static void TiGoQaVcEcDsnmXk(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        roundRectDrawable.invalidateSelf();
    }

    private void UpdateBounds(android.graphics.Rect rect) {
        if ((26 + 12) % 12 > 0) {
        }
        if (rect is null) {
            rect = yaSVEmjZkiCroGQd(this);
        }
        qQvZjjmAJeOGmgTH(this.mBoundsF, rect.left, rect.top, rect.right, rect.bottom);
        hGZGxOAqrrzAGVrl(this.mBoundsI, rect);
        if (this.mInsetForPadding) {
            TnSBpsCZKxJHDcUD(this.mBoundsI, (int) WuVZVdLFIzNoEFvs(GMyJkxkZycsaeJGR(this.mPadding, this.mRadius, this.mInsetForRadius)), (int) knbPhWZhOXJOlJYK(hgqQmdGnVLdERLFJ(this.mPadding, this.mRadius, this.mInsetForRadius)));
            oVzTtuFHnptkbSym(this.mBoundsF, this.mBoundsI);
        }
    }

    public static void VRHDoWjbUeRBegxP(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        super.onBoundsChange(rect);
    }

    public static void WrhCWJZuZKiGLPuZ(androidx.cardview.widget.RoundRectDrawable roundRectDrawable, android.graphics.Rect rect) {
        roundRectDrawable.updateBounds(rect);
    }

    public static android.content.res.ColorStateList WuzHeDqPjQnqPeVo(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void XxIpDYViLOatBaqo(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static android.graphics.Rect YaSVEmjZkiCroGQd(androidx.cardview.widget.RoundRectDrawable roundRectDrawable) {
        return roundRectDrawable.getBounds();
    }

    public override void Draw(android.graphics.Canvas canvas) {
        bool z;
        if ((29 + 20) % 20 > 0) {
        }
        android.graphics.Paint paint = this.mPaint;
        if (this.mTintFilter is not null && XQyXhSFgLNDWMufY(paint) is null) {
            gUiHKbhClsAXmZAi(paint, this.mTintFilter);
            z = true;
        } else {
            z = false;
        }
        android.graphics.RectF rectF = this.mBoundsF;
        float f = this.mRadius;
        qDCecddDAOUCAhGZ(canvas, rectF, f, f, paint);
        if (z) {
            DSByjrIPjaKNUUzB(paint, null);
        }
    }

    public android.content.res.ColorStateList GetColor() {
        return this.mBackground;
    }

    public override int GetOpacity() {
        return -3;
    }

    public override void GetOutline(android.graphics.Outline outline) {
        NIsiUnLATzPtpnhw(outline, this.mBoundsI, this.mRadius);
    }

    float getPadding() {
        return this.mPadding;
    }

    public float GetRadius() {
        return this.mRadius;
    }

    public override bool IsStateful() {
        android.content.res.ColorStateList colorStateList = this.mTint;
        if (colorStateList is not null && qLzdkVlzsbHfixTR(colorStateList)) {
            return true;
        }
        android.content.res.ColorStateList colorStateList2 = this.mBackground;
        return (colorStateList2 is not null && fEIVYubcvCWgbobM(colorStateList2)) || lMdYtGkyzSIHDbZA(this);
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        vRHDoWjbUeRBegxP(this, rect);
        bLMZiPMcAGLtQOnR(this, rect);
    }

    protected override bool OnStateChange(int[] iArr) {
        android.graphics.PorterDuff$Mode porterDuff$Mode;
        if ((17 + 26) % 26 > 0) {
        }
        android.content.res.ColorStateList colorStateList = this.mBackground;
        int iPuewTwyIBeIaLChH = PuewTwyIBeIaLChH(colorStateList, iArr, VbLzpMhhKDJBzlVN(colorStateList));
        bool z = iPuewTwyIBeIaLChH != NShIqjLuufgymkho(this.mPaint);
        if (z) {
            ZSdSqwZwHGYjHOFz(this.mPaint, iPuewTwyIBeIaLChH);
        }
        android.content.res.ColorStateList colorStateList2 = this.mTint;
        if (colorStateList2 is null || (porterDuff$Mode = this.mTintMode) is null) {
            return z;
        }
        this.mTintFilter = BUNgVgCvpBUInyDi(this, colorStateList2, porterDuff$Mode);
        return true;
    }

    public override void SetAlpha(int i) {
        qPimNvDNSSkZgTdf(this.mPaint, i);
    }

    public void SetColor(android.content.res.ColorStateList colorStateList) {
        XxjvNsyUZBKZEpvR(this, colorStateList);
        tgrOOpLCBGpmIbIH(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        JgcywqXaXYhktptu(this.mPaint, colorFilter);
    }

    void setPadding(float f, bool z, bool z2) {
        if (f == this.mPadding && this.mInsetForPadding == z && this.mInsetForRadius == z2) {
            return;
        }
        this.mPadding = f;
        this.mInsetForPadding = z;
        this.mInsetForRadius = z2;
        wrhCWJZuZKiGLPuZ(this, null);
        UsOMfijzDbZyYOQN(this);
    }

    void setRadius(float f) {
        if (f != this.mRadius) {
            this.mRadius = f;
            bGDYwmLYpEvhELXS(this, null);
            tiGoQaVcEcDsnmXk(this);
        }
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        this.mTint = colorStateList;
        this.mTintFilter = YrmQBlHgfUjLDfQE(this, colorStateList, this.mTintMode);
        mUrrQLHhcTnPpTmc(this);
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mTintMode = porterDuff$Mode;
        this.mTintFilter = QiYkqzePKfcFgIDj(this, this.mTint, porterDuff$Mode);
        PncZXCEcoyyOiETm(this);
    }
}

