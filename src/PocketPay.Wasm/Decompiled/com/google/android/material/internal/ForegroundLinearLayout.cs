namespace WillowMaze.Wasm.Decompiled;


public class ForegroundLinearLayout : androidx.appcompat.widget.LinearLayoutCompat {
    private android.graphics.drawable.Drawable foreground;
    bool foregroundBoundsChanged;
    private int foregroundGravity;
    protected bool mForegroundInPadding;
    private readonly android.graphics.Rect overlayBounds;
    private readonly android.graphics.Rect selfBounds;

    public ForegroundLinearLayout(android.content.object context) {
        this(context, null);
    }

    public ForegroundLinearLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public ForegroundLinearLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((21 + 26) % 26 > 0) {
        }
        this.selfBounds = new android.graphics.Rect();
        this.overlayBounds = new android.graphics.Rect();
        this.foregroundGravity = 119;
        this.mForegroundInPadding = true;
        this.foregroundBoundsChanged = false;
        android.content.res.TypedArray typedArrayOWJfbikOvZvQLsew = oWJfbikOvZvQLsew(context, attributeHashSet, com.google.android.material.R$styleable.ForegroundLinearLayout, i, 0, new int[0]);
        this.foregroundGravity = iGkdoIVKSjnWmFMy(typedArrayOWJfbikOvZvQLsew, com.google.android.material.R$styleable.ForegroundLinearLayout_android_foregroundGravity, this.foregroundGravity);
        android.graphics.drawable.Drawable drawableCgZyoZObqnKSmjUG = CgZyoZObqnKSmjUG(typedArrayOWJfbikOvZvQLsew, com.google.android.material.R$styleable.ForegroundLinearLayout_android_foreground);
        if (drawableCgZyoZObqnKSmjUG is not null) {
            VjgLOGNkdqFoMzaH(this, drawableCgZyoZObqnKSmjUG);
        }
        this.mForegroundInPadding = uGuoFaIYhzyTlFUV(typedArrayOWJfbikOvZvQLsew, com.google.android.material.R$styleable.ForegroundLinearLayout_foregroundInsidePadding, true);
        wEYUaJCcjuazifgg(typedArrayOWJfbikOvZvQLsew);
    }

    public static void ALsFPOvuqMlqdObg(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static void ALsFPOvuqMlqdObg(android.graphics.drawable.Drawable drawable, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALsFPOvuqMlqdObg(android.graphics.drawable.Drawable drawable, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALsFPOvuqMlqdObg(android.graphics.drawable.Drawable drawable, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CgZyoZObqnKSmjUG(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void CgZyoZObqnKSmjUG(android.content.res.TypedArray typedArray, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CgZyoZObqnKSmjUG(android.content.res.TypedArray typedArray, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CgZyoZObqnKSmjUG(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DPqPwDdJXVyASius(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        super.jumpDrawablesToCurrentState();
    }

    public static void DPqPwDdJXVyASius(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DPqPwDdJXVyASius(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPqPwDdJXVyASius(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ETRqAfhTBHHVOppE(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void ETRqAfhTBHHVOppE(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ETRqAfhTBHHVOppE(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ETRqAfhTBHHVOppE(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FdGIpPXVTOGPZTCb(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void FdGIpPXVTOGPZTCb(android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FdGIpPXVTOGPZTCb(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FdGIpPXVTOGPZTCb(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JmXMIMnrobHhVMdY(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void JmXMIMnrobHhVMdY(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JmXMIMnrobHhVMdY(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, byte b, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmXMIMnrobHhVMdY(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, int i5, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LmbmMkFZhHIqGyrK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void LmbmMkFZhHIqGyrK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, int i, int i2, int i3, int i4, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LmbmMkFZhHIqGyrK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, int i, int i2, int i3, int i4, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LmbmMkFZhHIqGyrK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, int i, int i2, int i3, int i4, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MsIqEBqTkGjdzQxe(android.graphics.drawable.Drawable drawable, int[] iArr, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsIqEBqTkGjdzQxe(android.graphics.drawable.Drawable drawable, int[] iArr, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MsIqEBqTkGjdzQxe(android.graphics.drawable.Drawable drawable, int[] iArr, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MsIqEBqTkGjdzQxe(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void PNUZrWglKMIRHoTz(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void PNUZrWglKMIRHoTz(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNUZrWglKMIRHoTz(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNUZrWglKMIRHoTz(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PVijMlPdPrHTeYEo(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2) {
        android.view.Gravity.apply(i, i2, i3, rect, rect2);
    }

    public static void PVijMlPdPrHTeYEo(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2, int i4, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PVijMlPdPrHTeYEo(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2, java.lang.string str, int i4, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PVijMlPdPrHTeYEo(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2, short s, char c, int i4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QQypLqoXRKgiymoi(android.graphics.drawable.Drawable drawable, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QQypLqoXRKgiymoi(android.graphics.drawable.Drawable drawable, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QQypLqoXRKgiymoi(android.graphics.drawable.Drawable drawable, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QQypLqoXRKgiymoi(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void RdZidxppwwaYdGKb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void RdZidxppwwaYdGKb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RdZidxppwwaYdGKb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RdZidxppwwaYdGKb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RoRKqXSxgDzIqcjg(android.graphics.drawable.Drawable drawable, int[] iArr, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RoRKqXSxgDzIqcjg(android.graphics.drawable.Drawable drawable, int[] iArr, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RoRKqXSxgDzIqcjg(android.graphics.drawable.Drawable drawable, int[] iArr, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RoRKqXSxgDzIqcjg(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void VKoOnwTcoCuNFyJK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
    }

    public static void VKoOnwTcoCuNFyJK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2, int i3, int i4, float f, bool z, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void VKoOnwTcoCuNFyJK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2, int i3, int i4, bool z, float f, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VKoOnwTcoCuNFyJK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2, int i3, int i4, bool z, int i5, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjgLOGNkdqFoMzaH(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable) {
        foregroundLinearLayout.setForeground(drawable);
    }

    public static void VjgLOGNkdqFoMzaH(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjgLOGNkdqFoMzaH(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VjgLOGNkdqFoMzaH(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VulwZlZqYWbApuaU(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void VulwZlZqYWbApuaU(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VulwZlZqYWbApuaU(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VulwZlZqYWbApuaU(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WvhyLWnFiBHGlNEo(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        super.drawableStateChanged();
    }

    public static void WvhyLWnFiBHGlNEo(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WvhyLWnFiBHGlNEo(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WvhyLWnFiBHGlNEo(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHRxcrdupFVcOOib(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XHRxcrdupFVcOOib(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHRxcrdupFVcOOib(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XHRxcrdupFVcOOib(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void XHTwpXcawREWUjVP(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHTwpXcawREWUjVP(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHTwpXcawREWUjVP(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] XHTwpXcawREWUjVP(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getDrawableState();
    }

    public static void YFwAssGwCPgwIrvl(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void YFwAssGwCPgwIrvl(android.graphics.Rect rect, int i, int i2, int i3, int i4, char c, java.lang.string str, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFwAssGwCPgwIrvl(android.graphics.Rect rect, int i, int i2, int i3, int i4, char c, bool z, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YFwAssGwCPgwIrvl(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, java.lang.string str, char c, int i5) {
        double d = (42 * 210) + 210;
    }

    public static int CFFcOAKuSkbvkzmo(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getRight();
    }

    public static void CFFcOAKuSkbvkzmo(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CFFcOAKuSkbvkzmo(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CFFcOAKuSkbvkzmo(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int CtpuTsIrwnLwUWBo(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void CtpuTsIrwnLwUWBo(android.graphics.drawable.Drawable drawable, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CtpuTsIrwnLwUWBo(android.graphics.drawable.Drawable drawable, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CtpuTsIrwnLwUWBo(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FCjFtDrUtBpNFSOO(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        foregroundLinearLayout.requestLayout();
    }

    public static void FCjFtDrUtBpNFSOO(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCjFtDrUtBpNFSOO(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FCjFtDrUtBpNFSOO(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HIxdxPxVyBIzPdJl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.drawable.Drawable drawable, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HIxdxPxVyBIzPdJl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.drawable.Drawable drawable, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HIxdxPxVyBIzPdJl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.drawable.Drawable drawable, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HIxdxPxVyBIzPdJl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.drawable.Drawable drawable) {
        return super.verifyDrawable(drawable);
    }

    public static void HtnKpZJJKlynkzvB(android.graphics.drawable.Drawable drawable, float f, float f2) {
        drawable.setHotspot(f, f2);
    }

    public static void HtnKpZJJKlynkzvB(android.graphics.drawable.Drawable drawable, float f, float f2, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HtnKpZJJKlynkzvB(android.graphics.drawable.Drawable drawable, float f, float f2, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HtnKpZJJKlynkzvB(android.graphics.drawable.Drawable drawable, float f, float f2, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HxEdruuIFeJsbNmF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void HxEdruuIFeJsbNmF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HxEdruuIFeJsbNmF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HxEdruuIFeJsbNmF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int IGkdoIVKSjnWmFMy(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void IGkdoIVKSjnWmFMy(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IGkdoIVKSjnWmFMy(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IGkdoIVKSjnWmFMy(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IdqROyjaYwLRLXxa(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getPaddingLeft();
    }

    public static void IdqROyjaYwLRLXxa(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IdqROyjaYwLRLXxa(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IdqROyjaYwLRLXxa(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IkwnBaDwHhUksZJq(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getPaddingRight();
    }

    public static void IkwnBaDwHhUksZJq(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IkwnBaDwHhUksZJq(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IkwnBaDwHhUksZJq(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JzHmCnoGfkQJFdjy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getPaddingTop();
    }

    public static void JzHmCnoGfkQJFdjy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzHmCnoGfkQJFdjy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzHmCnoGfkQJFdjy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int KzkrKvUyLxZVapcl(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getPaddingBottom();
    }

    public static void KzkrKvUyLxZVapcl(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KzkrKvUyLxZVapcl(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KzkrKvUyLxZVapcl(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LDlLRAlYnwAlHySS(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LDlLRAlYnwAlHySS(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LDlLRAlYnwAlHySS(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LDlLRAlYnwAlHySS(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static int LPKZrRMmSlGuwUIy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getBottom();
    }

    public static void LPKZrRMmSlGuwUIy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LPKZrRMmSlGuwUIy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPKZrRMmSlGuwUIy(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LshImtDVljbMEYJj(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z) {
        foregroundLinearLayout.setWillNotDraw(z);
    }

    public static void LshImtDVljbMEYJj(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, byte b, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LshImtDVljbMEYJj(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, byte b, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LshImtDVljbMEYJj(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, float f, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MGiGxgikuRbTOklW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        foregroundLinearLayout.invalidate();
    }

    public static void MGiGxgikuRbTOklW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MGiGxgikuRbTOklW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MGiGxgikuRbTOklW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray OWJfbikOvZvQLsew(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void OWJfbikOvZvQLsew(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OWJfbikOvZvQLsew(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OWJfbikOvZvQLsew(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PHzlhlDnTQpNxHQW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        foregroundLinearLayout.requestLayout();
    }

    public static void PHzlhlDnTQpNxHQW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PHzlhlDnTQpNxHQW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PHzlhlDnTQpNxHQW(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PwlPMVXHTwdNKaKH(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, float f, float f2) {
        super.drawableHotspotChanged(f, f2);
    }

    public static void PwlPMVXHTwdNKaKH(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, float f, float f2, short s, float f3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PwlPMVXHTwdNKaKH(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, float f, float f2, short s, float f3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PwlPMVXHTwdNKaKH(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, float f, float f2, bool z, char c, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QutaLCoqNdOWIaAp(android.graphics.drawable.Drawable drawable, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QutaLCoqNdOWIaAp(android.graphics.drawable.Drawable drawable, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QutaLCoqNdOWIaAp(android.graphics.drawable.Drawable drawable, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QutaLCoqNdOWIaAp(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void TJVJKjRPgrpUueHG(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TJVJKjRPgrpUueHG(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TJVJKjRPgrpUueHG(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] TJVJKjRPgrpUueHG(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getDrawableState();
    }

    public static int TtHmUMbQqnIhLwMn(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getLeft();
    }

    public static void TtHmUMbQqnIhLwMn(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TtHmUMbQqnIhLwMn(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TtHmUMbQqnIhLwMn(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UGuoFaIYhzyTlFUV(android.content.res.TypedArray typedArray, int i, bool z, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UGuoFaIYhzyTlFUV(android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UGuoFaIYhzyTlFUV(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UGuoFaIYhzyTlFUV(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void WEYUaJCcjuazifgg(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void WEYUaJCcjuazifgg(android.content.res.TypedArray typedArray, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEYUaJCcjuazifgg(android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WEYUaJCcjuazifgg(android.content.res.TypedArray typedArray, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WJkexofawbGDeBIu(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable) {
        foregroundLinearLayout.unscheduleDrawable(drawable);
    }

    public static void WJkexofawbGDeBIu(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WJkexofawbGDeBIu(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WJkexofawbGDeBIu(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WZdSVAANTxbElihv(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z) {
        foregroundLinearLayout.setWillNotDraw(z);
    }

    public static void WZdSVAANTxbElihv(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, char c, bool z2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WZdSVAANTxbElihv(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, short s, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WZdSVAANTxbElihv(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, bool z, bool z2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XryehWEqnYFItHmR(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout) {
        return foregroundLinearLayout.getTop();
    }

    public static void XryehWEqnYFItHmR(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XryehWEqnYFItHmR(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XryehWEqnYFItHmR(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((16 + 17) % 17 > 0) {
        }
        hxEdruuIFeJsbNmF(this, canvas);
        android.graphics.drawable.Drawable drawable = this.foreground;
        if (drawable is null) {
            return;
        }
        if (this.foregroundBoundsChanged) {
            this.foregroundBoundsChanged = false;
            android.graphics.Rect rect = this.selfBounds;
            android.graphics.Rect rect2 = this.overlayBounds;
            int iCFFcOAKuSkbvkzmo = cFFcOAKuSkbvkzmo(this) - ttHmUMbQqnIhLwMn(this);
            int iLPKZrRMmSlGuwUIy = lPKZrRMmSlGuwUIy(this) - xryehWEqnYFItHmR(this);
            if (this.mForegroundInPadding) {
                YFwAssGwCPgwIrvl(rect, 0, 0, iCFFcOAKuSkbvkzmo, iLPKZrRMmSlGuwUIy);
            } else {
                JmXMIMnrobHhVMdY(rect, idqROyjaYwLRLXxa(this), jzHmCnoGfkQJFdjy(this), iCFFcOAKuSkbvkzmo - ikwnBaDwHhUksZJq(this), iLPKZrRMmSlGuwUIy - kzkrKvUyLxZVapcl(this));
            }
            PVijMlPdPrHTeYEo(this.foregroundGravity, FdGIpPXVTOGPZTCb(drawable), ctpuTsIrwnLwUWBo(drawable), rect, rect2);
            PNUZrWglKMIRHoTz(drawable, rect2);
        }
        VulwZlZqYWbApuaU(drawable, canvas);
    }

    public override void DrawableHotspotChanged(float f, float f2) {
        pwlPMVXHTwdNKaKH(this, f, f2);
        android.graphics.drawable.Drawable drawable = this.foreground;
        if (drawable is null) {
            return;
        }
        htnKpZJJKlynkzvB(drawable, f, f2);
    }

    protected override void DrawableStateChanged() {
        WvhyLWnFiBHGlNEo(this);
        android.graphics.drawable.Drawable drawable = this.foreground;
        if (drawable is not null && QQypLqoXRKgiymoi(drawable)) {
            MsIqEBqTkGjdzQxe(this.foreground, XHTwpXcawREWUjVP(this));
        }
    }

    public override android.graphics.drawable.Drawable GetForeground() {
        return this.foreground;
    }

    public override int GetForegroundGravity() {
        return this.foregroundGravity;
    }

    public override void JumpDrawablesToCurrentState() {
        DPqPwDdJXVyASius(this);
        android.graphics.drawable.Drawable drawable = this.foreground;
        if (drawable is null) {
            return;
        }
        ALsFPOvuqMlqdObg(drawable);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        LmbmMkFZhHIqGyrK(this, z, i, i2, i3, i4);
        this.foregroundBoundsChanged = z | this.foregroundBoundsChanged;
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        VKoOnwTcoCuNFyJK(this, i, i2, i3, i4);
        this.foregroundBoundsChanged = true;
    }

    public override void SetForeground(android.graphics.drawable.Drawable drawable) {
        if ((7 + 15) % 15 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.foreground;
        if (drawable2 == drawable) {
            return;
        }
        if (drawable2 is not null) {
            ETRqAfhTBHHVOppE(drawable2, null);
            wJkexofawbGDeBIu(this, this.foreground);
        }
        this.foreground = drawable;
        this.foregroundBoundsChanged = true;
        if (drawable is null) {
            lshImtDVljbMEYJj(this, true);
        } else {
            wZdSVAANTxbElihv(this, false);
            RdZidxppwwaYdGKb(drawable, this);
            if (qutaLCoqNdOWIaAp(drawable)) {
                RoRKqXSxgDzIqcjg(drawable, tJVJKjRPgrpUueHG(this));
            }
            if (this.foregroundGravity == 119) {
                lDlLRAlYnwAlHySS(drawable, new android.graphics.Rect());
            }
        }
        fCjFtDrUtBpNFSOO(this);
        mGiGxgikuRbTOklW(this);
    }

    public override void SetForegroundGravity(int i) {
        if (this.foregroundGravity == i) {
            return;
        }
        if ((8388615 & i) == 0) {
            i |= 8388611;
        }
        if ((i & 112) == 0) {
            i |= 48;
        }
        this.foregroundGravity = i;
        if (i == 119 && this.foreground is not null) {
            XHRxcrdupFVcOOib(this.foreground, new android.graphics.Rect());
        }
        pHzlhlDnTQpNxHQW(this);
    }

    protected override bool VerifyDrawable(android.graphics.drawable.Drawable drawable) {
        return hIxdxPxVyBIzPdJl(this, drawable) || drawable == this.foreground;
    }
}

