namespace WillowMaze.Wasm.Decompiled;


public class ScrimInsetsFrameLayout : android.widget.FrameLayout {
    private bool drawBottomInsetForeground;
    private bool drawLeftInsetForeground;
    private bool drawRightInsetForeground;
    private bool drawTopInsetForeground;
    android.graphics.drawable.Drawable insetForeground;
    android.graphics.Rect insets;
    private android.graphics.Rect tempRect;

    public ScrimInsetsFrameLayout(android.content.object context) {
        this(context, null);
    }

    public ScrimInsetsFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public ScrimInsetsFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((13 + 30) % 30 > 0) {
        }
        this.tempRect = new android.graphics.Rect();
        this.drawTopInsetForeground = true;
        this.drawBottomInsetForeground = true;
        this.drawLeftInsetForeground = true;
        this.drawRightInsetForeground = true;
        android.content.res.TypedArray typedArrayLVHHrloGvpdqfLdl = LVHHrloGvpdqfLdl(context, attributeHashSet, com.google.android.material.R$styleable.ScrimInsetsFrameLayout, i, com.google.android.material.R$style.Widget_Design_ScrimInsetsFrameLayout, new int[0]);
        this.insetForeground = jXGwcpJCPOToaSHH(typedArrayLVHHrloGvpdqfLdl, com.google.android.material.R$styleable.ScrimInsetsFrameLayout_insetForeground);
        HpExovINKaIkAiME(typedArrayLVHHrloGvpdqfLdl);
        XmdRNKejCaNvJqZr(this, true);
        mgStSBpTYpiKEMXy(this, new com.google.android.material.internal.ScrimInsetsFrameLayout$1(this));
    }

    public static void FMPIAnwjNKNYDgzj(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void FMPIAnwjNKNYDgzj(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMPIAnwjNKNYDgzj(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FMPIAnwjNKNYDgzj(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FkXEGQuPEMttzzub(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void FkXEGQuPEMttzzub(android.graphics.Rect rect, int i, int i2, int i3, int i4, char c, bool z, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkXEGQuPEMttzzub(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FkXEGQuPEMttzzub(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, char c, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void HpExovINKaIkAiME(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void HpExovINKaIkAiME(android.content.res.TypedArray typedArray, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HpExovINKaIkAiME(android.content.res.TypedArray typedArray, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpExovINKaIkAiME(android.content.res.TypedArray typedArray, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JDOCijUKoGudrjjF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void JDOCijUKoGudrjjF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JDOCijUKoGudrjjF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDOCijUKoGudrjjF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray LVHHrloGvpdqfLdl(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void LVHHrloGvpdqfLdl(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LVHHrloGvpdqfLdl(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LVHHrloGvpdqfLdl(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LqoJejRMJhVjlhpd(android.widget.FrameLayout frameLayout) {
        super.onAttachedToWindow();
    }

    public static void LqoJejRMJhVjlhpd(android.widget.FrameLayout frameLayout, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqoJejRMJhVjlhpd(android.widget.FrameLayout frameLayout, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LqoJejRMJhVjlhpd(android.widget.FrameLayout frameLayout, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OkuXAYuHhMplFsIZ(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void OkuXAYuHhMplFsIZ(android.graphics.Canvas canvas, int i, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OkuXAYuHhMplFsIZ(android.graphics.Canvas canvas, int i, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OkuXAYuHhMplFsIZ(android.graphics.Canvas canvas, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QFaCqCFCxcHXTXNx(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void QFaCqCFCxcHXTXNx(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, short s, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void QFaCqCFCxcHXTXNx(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QFaCqCFCxcHXTXNx(android.graphics.Rect rect, int i, int i2, int i3, int i4, short s, int i5, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QqFTlTOxQRrHLMWd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void QqFTlTOxQRrHLMWd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QqFTlTOxQRrHLMWd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqFTlTOxQRrHLMWd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int SpnOOBiuXdgaQMed(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout) {
        return scrimInsetsFrameLayout.getWidth();
    }

    public static void SpnOOBiuXdgaQMed(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SpnOOBiuXdgaQMed(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SpnOOBiuXdgaQMed(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UpjbjblrCYqtGKYc(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout) {
        return scrimInsetsFrameLayout.getHeight();
    }

    public static void UpjbjblrCYqtGKYc(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UpjbjblrCYqtGKYc(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpjbjblrCYqtGKYc(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UvaxJOLrMGxmTlIy(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void UvaxJOLrMGxmTlIy(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UvaxJOLrMGxmTlIy(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UvaxJOLrMGxmTlIy(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XmdRNKejCaNvJqZr(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, bool z) {
        scrimInsetsFrameLayout.setWillNotDraw(z);
    }

    public static void XmdRNKejCaNvJqZr(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, bool z, float f, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XmdRNKejCaNvJqZr(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, bool z, bool z2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XmdRNKejCaNvJqZr(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, bool z, bool z2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XnckHHYMlWsISdBZ(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void XnckHHYMlWsISdBZ(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XnckHHYMlWsISdBZ(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XnckHHYMlWsISdBZ(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YduyPYKtXYqaUFqS(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void YduyPYKtXYqaUFqS(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YduyPYKtXYqaUFqS(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YduyPYKtXYqaUFqS(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYRyAlMXQqugKLVb(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void AYRyAlMXQqugKLVb(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AYRyAlMXQqugKLVb(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AYRyAlMXQqugKLVb(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EKZKHyhTdmNgdmbg(android.widget.FrameLayout frameLayout) {
        super.onDetachedFromWindow();
    }

    public static void EKZKHyhTdmNgdmbg(android.widget.FrameLayout frameLayout, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EKZKHyhTdmNgdmbg(android.widget.FrameLayout frameLayout, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EKZKHyhTdmNgdmbg(android.widget.FrameLayout frameLayout, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GGTePMNZbQswSsRY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void GGTePMNZbQswSsRY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GGTePMNZbQswSsRY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GGTePMNZbQswSsRY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HMvqQGAbTxPlucoo(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void HMvqQGAbTxPlucoo(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HMvqQGAbTxPlucoo(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HMvqQGAbTxPlucoo(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IJBpPkkQbrdbptvT(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void IJBpPkkQbrdbptvT(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJBpPkkQbrdbptvT(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJBpPkkQbrdbptvT(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JXGwcpJCPOToaSHH(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void JXGwcpJCPOToaSHH(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JXGwcpJCPOToaSHH(android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JXGwcpJCPOToaSHH(android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int MezFtdJPfAogvjXW(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout) {
        return scrimInsetsFrameLayout.getScrollY();
    }

    public static void MezFtdJPfAogvjXW(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MezFtdJPfAogvjXW(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MezFtdJPfAogvjXW(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MgStSBpTYpiKEMXy(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void MgStSBpTYpiKEMXy(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgStSBpTYpiKEMXy(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MgStSBpTYpiKEMXy(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QGXoFvkpVrTfjShs(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void QGXoFvkpVrTfjShs(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, int i5, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGXoFvkpVrTfjShs(android.graphics.Rect rect, int i, int i2, int i3, int i4, char c, byte b, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGXoFvkpVrTfjShs(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TBepqtVfnSjgHZGF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout) {
        return scrimInsetsFrameLayout.getScrollX();
    }

    public static void TBepqtVfnSjgHZGF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TBepqtVfnSjgHZGF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TBepqtVfnSjgHZGF(com.google.android.material.internal.ScrimInsetsFrameLayout scrimInsetsFrameLayout, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TfbsKrZFyJkOuHep(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void TfbsKrZFyJkOuHep(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TfbsKrZFyJkOuHep(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TfbsKrZFyJkOuHep(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UwfMWDLhorHLuNbi(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void UwfMWDLhorHLuNbi(android.graphics.Canvas canvas, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UwfMWDLhorHLuNbi(android.graphics.Canvas canvas, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UwfMWDLhorHLuNbi(android.graphics.Canvas canvas, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VMtQFfISBDUdtvCU(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void VMtQFfISBDUdtvCU(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VMtQFfISBDUdtvCU(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VMtQFfISBDUdtvCU(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WLudIsNCEZBjaBxL(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void WLudIsNCEZBjaBxL(android.graphics.Canvas canvas, float f, float f2, byte b, int i, float f3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WLudIsNCEZBjaBxL(android.graphics.Canvas canvas, float f, float f2, byte b, bool z, int i, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void WLudIsNCEZBjaBxL(android.graphics.Canvas canvas, float f, float f2, float f3, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((14 + 4) % 4 > 0) {
        }
        vMtQFfISBDUdtvCU(this, canvas);
        int iSpnOOBiuXdgaQMed = SpnOOBiuXdgaQMed(this);
        int iUpjbjblrCYqtGKYc = UpjbjblrCYqtGKYc(this);
        if (this.insets is null || this.insetForeground is null) {
            return;
        }
        int iUwfMWDLhorHLuNbi = uwfMWDLhorHLuNbi(canvas);
        wLudIsNCEZBjaBxL(canvas, tBepqtVfnSjgHZGF(this), mezFtdJPfAogvjXW(this));
        if (this.drawTopInsetForeground) {
            qGXoFvkpVrTfjShs(this.tempRect, 0, 0, iSpnOOBiuXdgaQMed, this.insets.top);
            FMPIAnwjNKNYDgzj(this.insetForeground, this.tempRect);
            aYRyAlMXQqugKLVb(this.insetForeground, canvas);
        }
        if (this.drawBottomInsetForeground) {
            XnckHHYMlWsISdBZ(this.tempRect, 0, iUpjbjblrCYqtGKYc - this.insets.bottom, iSpnOOBiuXdgaQMed, iUpjbjblrCYqtGKYc);
            JDOCijUKoGudrjjF(this.insetForeground, this.tempRect);
            tfbsKrZFyJkOuHep(this.insetForeground, canvas);
        }
        if (this.drawLeftInsetForeground) {
            QFaCqCFCxcHXTXNx(this.tempRect, 0, this.insets.top, this.insets.left, iUpjbjblrCYqtGKYc - this.insets.bottom);
            iJBpPkkQbrdbptvT(this.insetForeground, this.tempRect);
            YduyPYKtXYqaUFqS(this.insetForeground, canvas);
        }
        if (this.drawRightInsetForeground) {
            FkXEGQuPEMttzzub(this.tempRect, iSpnOOBiuXdgaQMed - this.insets.right, this.insets.top, iSpnOOBiuXdgaQMed, iUpjbjblrCYqtGKYc - this.insets.bottom);
            hMvqQGAbTxPlucoo(this.insetForeground, this.tempRect);
            QqFTlTOxQRrHLMWd(this.insetForeground, canvas);
        }
        OkuXAYuHhMplFsIZ(canvas, iUwfMWDLhorHLuNbi);
    }

    protected override void OnAttachedToWindow() {
        LqoJejRMJhVjlhpd(this);
        android.graphics.drawable.Drawable drawable = this.insetForeground;
        if (drawable is null) {
            return;
        }
        gGTePMNZbQswSsRY(drawable, this);
    }

    protected override void OnDetachedFromWindow() {
        eKZKHyhTdmNgdmbg(this);
        android.graphics.drawable.Drawable drawable = this.insetForeground;
        if (drawable is null) {
            return;
        }
        UvaxJOLrMGxmTlIy(drawable, null);
    }

    protected void OnInsetsChanged(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
    }

    public void SetDrawBottomInsetForeground(bool z) {
        this.drawBottomInsetForeground = z;
    }

    public void SetDrawLeftInsetForeground(bool z) {
        this.drawLeftInsetForeground = z;
    }

    public void SetDrawRightInsetForeground(bool z) {
        this.drawRightInsetForeground = z;
    }

    public void SetDrawTopInsetForeground(bool z) {
        this.drawTopInsetForeground = z;
    }

    public void SetScrimInsetForeground(android.graphics.drawable.Drawable drawable) {
        this.insetForeground = drawable;
    }
}

