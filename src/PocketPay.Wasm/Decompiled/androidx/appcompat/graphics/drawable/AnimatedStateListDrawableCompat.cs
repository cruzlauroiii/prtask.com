namespace WillowMaze.Wasm.Decompiled;


public class AnimatedStateListDrawableCompat : androidx.appcompat.graphics.drawable.StateListDrawableCompat : androidx.core.graphics.drawable.TintAwareDrawable {
    private static readonly java.lang.string ELEMENT_ITEM = "item";
    private static readonly java.lang.string ELEMENT_TRANSITION = "transition";
    private static readonly java.lang.string ITEM_MISSING_DRAWABLE_ERROR = ": <item> tag requires a 'drawable' attribute or child tag defining a drawable";
    private static readonly java.lang.string LOGTAG = "AnimatedStateListDrawableCompat";
    private static readonly java.lang.string TRANSITION_MISSING_DRAWABLE_ERROR = ": <transition> tag requires a 'drawable' attribute or child tag defining a drawable";
    private static readonly java.lang.string TRANSITION_MISSING_FROM_TO_ID = ": <transition> tag requires 'fromId' & 'toId' attributes";
    private bool mMutated;
    private androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState mState;
    private androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition mTransition;
    private int mTransitionFromIndex;
    private int mTransitionToIndex;

    public AnimatedStateListDrawableCompat() {
        this(null, null);
    }

    AnimatedStateListDrawableCompat(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, android.content.res.Resources resources) {
        super(null);
        this.mTransitionToIndex = -1;
        this.mTransitionFromIndex = -1;
        pZqrQpCQmVmcKzlT(this, new androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState(animatedStateListDrawableCompat$AnimatedStateListState, this, resources));
        uRwEpWkWrCOeGzjf(this, dOQMOLImLTdmbptK(this));
        EJLRtLMXnxaPlXSH(this);
    }

    public static int AhiOJDroywmpfulc(android.content.res.TypedArray typedArray) {
        return androidx.appcompat.resources.Compatibility$Api21Impl.getChangingConfigurations(typedArray);
    }

    public static void AhiOJDroywmpfulc(android.content.res.TypedArray typedArray, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AhiOJDroywmpfulc(android.content.res.TypedArray typedArray, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhiOJDroywmpfulc(android.content.res.TypedArray typedArray, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources AuVFucInFiWlXIpf(android.content.object context) {
        return context.getResources();
    }

    public static void AuVFucInFiWlXIpf(android.content.object context, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AuVFucInFiWlXIpf(android.content.object context, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AuVFucInFiWlXIpf(android.content.object context, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoQiGtMjhNdFNcNY(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.util.AttributeHashSet attributeHashSet, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BoQiGtMjhNdFNcNY(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.util.AttributeHashSet attributeHashSet, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BoQiGtMjhNdFNcNY(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.util.AttributeHashSet attributeHashSet, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] BoQiGtMjhNdFNcNY(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.util.AttributeHashSet attributeHashSet) {
        return animatedStateListDrawableCompat.extractStateHashSet(attributeHashSet);
    }

    public static void BofsESsbOYJuJtXN(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i) {
        animatedStateListDrawableCompat$AnimatedStateListState.setExitFadeDuration(i);
    }

    public static void BofsESsbOYJuJtXN(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BofsESsbOYJuJtXN(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BofsESsbOYJuJtXN(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void COdgJcBPsiYvJLDz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void COdgJcBPsiYvJLDz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void COdgJcBPsiYvJLDz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, java.lang.string str, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool COdgJcBPsiYvJLDz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i) {
        return animatedStateListDrawableCompat.selectDrawable(i);
    }

    public static int CRabljCFRpdAXAXO(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return animatedStateListDrawableCompat.parseTransition(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void CRabljCFRpdAXAXO(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRabljCFRpdAXAXO(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRabljCFRpdAXAXO(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CTUWGRIUYjGTqpLp(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTUWGRIUYjGTqpLp(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTUWGRIUYjGTqpLp(android.content.res.TypedArray typedArray, int i, bool z, float f, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CTUWGRIUYjGTqpLp(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState DeWZQEOtMKpyHTBc(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.cloneConstantState();
    }

    public static void DeWZQEOtMKpyHTBc(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DeWZQEOtMKpyHTBc(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DeWZQEOtMKpyHTBc(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EJLRtLMXnxaPlXSH(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        animatedStateListDrawableCompat.jumpToCurrentState();
    }

    public static void EJLRtLMXnxaPlXSH(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EJLRtLMXnxaPlXSH(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EJLRtLMXnxaPlXSH(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FDpRmqNlHFMbTtyF(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void FDpRmqNlHFMbTtyF(android.content.res.TypedArray typedArray, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FDpRmqNlHFMbTtyF(android.content.res.TypedArray typedArray, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FDpRmqNlHFMbTtyF(android.content.res.TypedArray typedArray, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FIXxLiMjHqyPNbGC(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getPositionDescription();
    }

    public static void FIXxLiMjHqyPNbGC(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIXxLiMjHqyPNbGC(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FIXxLiMjHqyPNbGC(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GfneFIzNsjBSzExl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GfneFIzNsjBSzExl(java.lang.stringBuilder sb, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GfneFIzNsjBSzExl(java.lang.stringBuilder sb, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GfneFIzNsjBSzExl(java.lang.stringBuilder sb, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GuSntLcXXBbTsfYz(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.Current;
    }

    public static void GuSntLcXXBbTsfYz(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GuSntLcXXBbTsfYz(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GuSntLcXXBbTsfYz(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HDnCfWYmoXHsOYcL(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HDnCfWYmoXHsOYcL(android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HDnCfWYmoXHsOYcL(android.content.res.TypedArray typedArray, int i, bool z, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HDnCfWYmoXHsOYcL(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int HXVjBRgkAmwbBoSl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.getCurrentIndex();
    }

    public static void HXVjBRgkAmwbBoSl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HXVjBRgkAmwbBoSl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HXVjBRgkAmwbBoSl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HqCRpWrKVAaiFsHm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HqCRpWrKVAaiFsHm(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HqCRpWrKVAaiFsHm(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HqCRpWrKVAaiFsHm(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int IMtVFNrcaAWEEqVT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z) {
        return animatedStateListDrawableCompat$AnimatedStateListState.addTransition(i, i2, drawable, z);
    }

    public static void IMtVFNrcaAWEEqVT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, float f, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IMtVFNrcaAWEEqVT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, float f, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IMtVFNrcaAWEEqVT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IlyYWAnZoAPSkxip(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition) {
        animatedStateListDrawableCompat$Transition.start();
    }

    public static void IlyYWAnZoAPSkxip(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IlyYWAnZoAPSkxip(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IlyYWAnZoAPSkxip(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.vectordrawable.graphics.drawable.VectorDrawableCompat ImkCGWfCnkwTRpom(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.createFromXmlInner(resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void ImkCGWfCnkwTRpom(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImkCGWfCnkwTRpom(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ImkCGWfCnkwTRpom(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JDSAIEbEInzbeEMm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JDSAIEbEInzbeEMm(java.lang.stringBuilder sb, java.lang.string str, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JDSAIEbEInzbeEMm(java.lang.stringBuilder sb, java.lang.string str, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDSAIEbEInzbeEMm(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JYcdFMQevJiuLTjp(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        animatedStateListDrawableCompat.jumpToCurrentState();
    }

    public static void JYcdFMQevJiuLTjp(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JYcdFMQevJiuLTjp(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JYcdFMQevJiuLTjp(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JmQzPWYiTHDzwozU(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JmQzPWYiTHDzwozU(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JmQzPWYiTHDzwozU(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JmQzPWYiTHDzwozU(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i) {
        return animatedStateListDrawableCompat.selectDrawable(i);
    }

    public static void KPmcEAaFwOXotRgz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        animatedStateListDrawableCompat.init();
    }

    public static void KPmcEAaFwOXotRgz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KPmcEAaFwOXotRgz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KPmcEAaFwOXotRgz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KYRdjOUsVyxWMhBU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KYRdjOUsVyxWMhBU(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYRdjOUsVyxWMhBU(java.lang.stringBuilder sb, java.lang.string str, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KYRdjOUsVyxWMhBU(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KfFWTAhQrbzlxVIu(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat) {
        super.jumpToCurrentState();
    }

    public static void KfFWTAhQrbzlxVIu(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KfFWTAhQrbzlxVIu(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KfFWTAhQrbzlxVIu(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KyJhCiysIddTsDvV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KyJhCiysIddTsDvV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KyJhCiysIddTsDvV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KyJhCiysIddTsDvV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i) {
        return animatedStateListDrawableCompat.selectDrawable(i);
    }

    public static int KzbkIiozoSAVmewU(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.Current;
    }

    public static void KzbkIiozoSAVmewU(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KzbkIiozoSAVmewU(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KzbkIiozoSAVmewU(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LMTYgvXazBDhqbss(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LMTYgvXazBDhqbss(android.graphics.drawable.Drawable drawable, int[] iArr, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LMTYgvXazBDhqbss(android.graphics.drawable.Drawable drawable, int[] iArr, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LMTYgvXazBDhqbss(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static androidx.appcompat.widget.ResourceManagerInternal LqJZtOHVjEwBUkjX() {
        return androidx.appcompat.widget.ResourceManagerInternal[);
    }

    public static void LqJZtOHVjEwBUkjX(java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LqJZtOHVjEwBUkjX(java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LqJZtOHVjEwBUkjX(bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDxTUFjmDCEvyzZX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, bool z2, int i, bool z3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDxTUFjmDCEvyzZX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, bool z2, short s, int i, bool z3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDxTUFjmDCEvyzZX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, bool z2, bool z3, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MDxTUFjmDCEvyzZX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, bool z2) {
        return animatedStateListDrawableCompat.setVisible(z, z2);
    }

    public static void MuwIWnGhLYDIBtGl(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat) {
        super.clearMutated();
    }

    public static void MuwIWnGhLYDIBtGl(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MuwIWnGhLYDIBtGl(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MuwIWnGhLYDIBtGl(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NGkbKscPMyZglCPw(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, char c, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGkbKscPMyZglCPw(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, bool z, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NGkbKscPMyZglCPw(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, bool z, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NGkbKscPMyZglCPw(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2) {
        return animatedStateListDrawableCompat$AnimatedStateListState.isTransitionReversed(i, i2);
    }

    public static android.graphics.drawable.Drawable NjxxtUxQhnCMkvao(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return androidx.appcompat.resources.Compatibility$Api21Impl.createFromXmlInner(resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void NjxxtUxQhnCMkvao(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NjxxtUxQhnCMkvao(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NjxxtUxQhnCMkvao(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OFCWIxIhSKhUMmkq(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return resourceManagerInternal.getDrawable(context, i);
    }

    public static void OFCWIxIhSKhUMmkq(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OFCWIxIhSKhUMmkq(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OFCWIxIhSKhUMmkq(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OImkOWlZyrnvhnaf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition) {
        animatedStateListDrawableCompat$Transition.start();
    }

    public static void OImkOWlZyrnvhnaf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OImkOWlZyrnvhnaf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OImkOWlZyrnvhnaf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OVeLvEteeHbKStbA(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void OVeLvEteeHbKStbA(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OVeLvEteeHbKStbA(android.content.res.TypedArray typedArray, int i, int i2, int i3, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OVeLvEteeHbKStbA(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OcaWRXlqkEhJHKzA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OcaWRXlqkEhJHKzA(java.lang.stringBuilder sb, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcaWRXlqkEhJHKzA(java.lang.stringBuilder sb, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OcaWRXlqkEhJHKzA(java.lang.stringBuilder sb, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QHzMzStcwkEThdxr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i) {
        return animatedStateListDrawableCompat$AnimatedStateListState.getKeyframeIdAt(i);
    }

    public static void QHzMzStcwkEThdxr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, float f, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QHzMzStcwkEThdxr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QHzMzStcwkEThdxr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RRFKmQMTgpwOoxkc(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void RRFKmQMTgpwOoxkc(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RRFKmQMTgpwOoxkc(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RRFKmQMTgpwOoxkc(android.content.res.TypedArray typedArray, int i, int i2, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState RTHgiHNJjpolOiHo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.cloneConstantState();
    }

    public static void RTHgiHNJjpolOiHo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RTHgiHNJjpolOiHo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RTHgiHNJjpolOiHo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RgxBCDVpEMpVfAjT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void RgxBCDVpEMpVfAjT(android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RgxBCDVpEMpVfAjT(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RgxBCDVpEMpVfAjT(android.content.res.TypedArray typedArray, int i, int i2, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SThPvLKiEiXJmqMZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z) {
        animatedStateListDrawableCompat$AnimatedStateListState.setVariablePadding(z);
    }

    public static void SThPvLKiEiXJmqMZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SThPvLKiEiXJmqMZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, short s, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SThPvLKiEiXJmqMZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SZmxAkvQhmnkglXl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SZmxAkvQhmnkglXl(java.lang.stringBuilder sb, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SZmxAkvQhmnkglXl(java.lang.stringBuilder sb, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SZmxAkvQhmnkglXl(java.lang.stringBuilder sb, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TTwXThKAqDdzUHoZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition) {
        animatedStateListDrawableCompat$Transition.reverse();
    }

    public static void TTwXThKAqDdzUHoZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TTwXThKAqDdzUHoZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTwXThKAqDdzUHoZ(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TUGzfftOYQDoCCSc(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void TUGzfftOYQDoCCSc(android.content.res.TypedArray typedArray, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TUGzfftOYQDoCCSc(android.content.res.TypedArray typedArray, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TUGzfftOYQDoCCSc(android.content.res.TypedArray typedArray, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TieSgYySTsNBAScR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TieSgYySTsNBAScR(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TieSgYySTsNBAScR(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TieSgYySTsNBAScR(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable TtCXvnjRRKJCefXl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.getCurrent();
    }

    public static void TtCXvnjRRKJCefXl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtCXvnjRRKJCefXl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TtCXvnjRRKJCefXl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UJUVSDcweRLQAyUF(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void UJUVSDcweRLQAyUF(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UJUVSDcweRLQAyUF(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UJUVSDcweRLQAyUF(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UROBHkAfgxIXlKcm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i) {
        return animatedStateListDrawableCompat$AnimatedStateListState.getKeyframeIdAt(i);
    }

    public static void UROBHkAfgxIXlKcm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UROBHkAfgxIXlKcm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UROBHkAfgxIXlKcm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UuMYeJeElGCdYcPI(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.TypedArray typedArray) {
        animatedStateListDrawableCompat.updateStateFromTypedArray(typedArray);
    }

    public static void UuMYeJeElGCdYcPI(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.TypedArray typedArray, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UuMYeJeElGCdYcPI(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.TypedArray typedArray, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UuMYeJeElGCdYcPI(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.TypedArray typedArray, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VmVHOdzdCdxNJSQW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i) {
        return animatedStateListDrawableCompat$AnimatedStateListState.addStateHashSet(iArr, drawable, i);
    }

    public static void VmVHOdzdCdxNJSQW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VmVHOdzdCdxNJSQW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VmVHOdzdCdxNJSQW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WHanAyuQItPaaqWF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        animatedStateListDrawableCompat.inflateChildElements(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void WHanAyuQItPaaqWF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WHanAyuQItPaaqWF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WHanAyuQItPaaqWF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WOvabUpoiheQwLJr(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getPositionDescription();
    }

    public static void WOvabUpoiheQwLJr(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WOvabUpoiheQwLJr(org.xmlpull.v1.XmlPullParser xmlPullParser, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOvabUpoiheQwLJr(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WPwyccNqOlBVJrJb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WPwyccNqOlBVJrJb(java.lang.stringBuilder sb, java.lang.string str, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WPwyccNqOlBVJrJb(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WPwyccNqOlBVJrJb(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XIwemnfPShwrzRWk(java.lang.object obj) {
        return androidx.core.util.objectsCompat.requireNonNull(obj);
    }

    public static void XIwemnfPShwrzRWk(java.lang.object obj, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XIwemnfPShwrzRWk(java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XIwemnfPShwrzRWk(java.lang.object obj, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XOvNEtsSiAdVgQlS(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.Current;
    }

    public static void XOvNEtsSiAdVgQlS(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XOvNEtsSiAdVgQlS(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XOvNEtsSiAdVgQlS(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XlXFFfIdiUaWebKz(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.Current;
    }

    public static void XlXFFfIdiUaWebKz(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XlXFFfIdiUaWebKz(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XlXFFfIdiUaWebKz(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YMqDRddFLjdFufaB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z) {
        animatedStateListDrawableCompat$AnimatedStateListState.setConstantSize(z);
    }

    public static void YMqDRddFLjdFufaB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMqDRddFLjdFufaB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YMqDRddFLjdFufaB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YfZQNYRLLlmUqJIh(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i) {
        animatedStateListDrawableCompat$AnimatedStateListState.setEnterFadeDuration(i);
    }

    public static void YfZQNYRLLlmUqJIh(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YfZQNYRLLlmUqJIh(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YfZQNYRLLlmUqJIh(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YyisnWJVXGMzyWOI(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i) {
        return resourceManagerInternal.getDrawable(context, i);
    }

    public static void YyisnWJVXGMzyWOI(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YyisnWJVXGMzyWOI(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YyisnWJVXGMzyWOI(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZtXOdVhpVPRGRChf(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return androidx.appcompat.resources.Compatibility$Api21Impl.createFromXmlInner(resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void ZtXOdVhpVPRGRChf(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtXOdVhpVPRGRChf(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZtXOdVhpVPRGRChf(android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray ABHEEoNfUwUReCAX(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, iArr);
    }

    public static void ABHEEoNfUwUReCAX(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ABHEEoNfUwUReCAX(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ABHEEoNfUwUReCAX(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AoieyoykkCuYrUBu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AoieyoykkCuYrUBu(java.lang.stringBuilder sb, java.lang.string str, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AoieyoykkCuYrUBu(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AoieyoykkCuYrUBu(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat BWBGhwAAOWaTvhzU(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat.createFromXmlInner(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void BWBGhwAAOWaTvhzU(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BWBGhwAAOWaTvhzU(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BWBGhwAAOWaTvhzU(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BYZWUdckqOrkAxCe(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, bool z, bool z2, char c, bool z3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BYZWUdckqOrkAxCe(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, bool z, bool z2, float f, short s, char c, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void BYZWUdckqOrkAxCe(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, bool z, bool z2, short s, char c, float f, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static bool BYZWUdckqOrkAxCe(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static void CPwNPTCPnATIrHTo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CPwNPTCPnATIrHTo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CPwNPTCPnATIrHTo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool CPwNPTCPnATIrHTo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr) {
        return animatedStateListDrawableCompat.onStateChange(iArr);
    }

    public static java.lang.object CSfKzGLOBWHCWaJS(java.lang.object obj) {
        return androidx.core.util.objectsCompat.requireNonNull(obj);
    }

    public static void CSfKzGLOBWHCWaJS(java.lang.object obj, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CSfKzGLOBWHCWaJS(java.lang.object obj, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSfKzGLOBWHCWaJS(java.lang.object obj, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CVGQAzancbnFLUhf(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static void CVGQAzancbnFLUhf(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CVGQAzancbnFLUhf(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CVGQAzancbnFLUhf(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat Create(android.content.object context, int i, android.content.res.Resources$Theme resources$Theme) {
        int iXOvNEtsSiAdVgQlS;
        if ((15 + 11) % 11 > 0) {
        }
        try {
            android.content.res.Resources resourcesAuVFucInFiWlXIpf = AuVFucInFiWlXIpf(context);
            android.content.res.XmlResourceParser xmlResourceParserNjFBeDnTTkzJfMwl = njFBeDnTTkzJfMwl(resourcesAuVFucInFiWlXIpf, i);
            android.util.AttributeHashSet attributeHashSetDladoItjwRFqMcek = dladoItjwRFqMcek(xmlResourceParserNjFBeDnTTkzJfMwl);
            do {
                iXOvNEtsSiAdVgQlS = XOvNEtsSiAdVgQlS(xmlResourceParserNjFBeDnTTkzJfMwl);
                if (iXOvNEtsSiAdVgQlS == 2) {
                    break;
                }
            } while (iXOvNEtsSiAdVgQlS != 1);
            if (iXOvNEtsSiAdVgQlS == 2) {
                return zhXckQwnYzkVlcLt(context, resourcesAuVFucInFiWlXIpf, xmlResourceParserNjFBeDnTTkzJfMwl, attributeHashSetDladoItjwRFqMcek, resources$Theme);
            }
            throw new org.xmlpull.v1.XmlPullParserException("No start tag found");
        } catch (java.io.IOException e) {
            hlDbtMjEdXNjbPTp(LOGTAG, "parser error", e);
            return null;
        } catch (org.xmlpull.v1.XmlPullParserException e2) {
            kQzoptXGqCwamyVm(LOGTAG, "parser error", e2);
            return null;
        }
    }

    public static void Create(android.content.object context, int i, android.content.res.Resources$Theme resources$Theme, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, int i, android.content.res.Resources$Theme resources$Theme, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, int i, android.content.res.Resources$Theme resources$Theme, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat CreateFromXmlInner(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((6 + 18) % 18 > 0) {
        }
        java.lang.string strCVGQAzancbnFLUhf = cVGQAzancbnFLUhf(xmlPullParser);
        if (!vTpbMAabGNKXWXOO(strCVGQAzancbnFLUhf, "animated-selector")) {
            throw new org.xmlpull.v1.XmlPullParserException(kISoFCtMFhRZcMBZ(JDSAIEbEInzbeEMm(yqbJcaYFqPgyJuCZ(TieSgYySTsNBAScR(new java.lang.stringBuilder(), ogzjycKVhiOzTFeh(xmlPullParser)), ": invalid animated-selector tag "), strCVGQAzancbnFLUhf)));
        }
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat = new androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat();
        pZrLKIQHoTIgaPCA(animatedStateListDrawableCompat, context, resources, xmlPullParser, attributeHashSet, resources$Theme);
        return animatedStateListDrawableCompat;
    }

    public static void CreateFromXmlInner(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromXmlInner(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromXmlInner(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DOQMOLImLTdmbptK(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DOQMOLImLTdmbptK(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DOQMOLImLTdmbptK(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] DOQMOLImLTdmbptK(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.getState();
    }

    public static void DWcYpBifhJChttuF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWcYpBifhJChttuF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWcYpBifhJChttuF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DWcYpBifhJChttuF(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition) {
        return animatedStateListDrawableCompat$Transition.canReverse();
    }

    public static android.util.AttributeHashSet DladoItjwRFqMcek(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return android.util.Xml.asAttributeHashSet(xmlPullParser);
    }

    public static void DladoItjwRFqMcek(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DladoItjwRFqMcek(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DladoItjwRFqMcek(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ERwOEIpBAyrcfEFM(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getPositionDescription();
    }

    public static void ERwOEIpBAyrcfEFM(org.xmlpull.v1.XmlPullParser xmlPullParser, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERwOEIpBAyrcfEFM(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERwOEIpBAyrcfEFM(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ETvELdADpexzZuvl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.getCurrentIndex();
    }

    public static void ETvELdADpexzZuvl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ETvELdADpexzZuvl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ETvELdADpexzZuvl(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ElXXomETRDeXfVAo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ElXXomETRDeXfVAo(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ElXXomETRDeXfVAo(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ElXXomETRDeXfVAo(java.lang.stringBuilder sb, java.lang.string str, char c, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FDujEcvxUJNIPxez(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FDujEcvxUJNIPxez(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FDujEcvxUJNIPxez(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDujEcvxUJNIPxez(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FKlslcXNQRfLwqML(java.lang.string str, java.lang.object obj, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FKlslcXNQRfLwqML(java.lang.string str, java.lang.object obj, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FKlslcXNQRfLwqML(java.lang.string str, java.lang.object obj, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FKlslcXNQRfLwqML(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void FgKnEsFFaSbfGteM(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        super.setConstantState(drawableContainerCompat$DrawableContainerState);
    }

    public static void FgKnEsFFaSbfGteM(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FgKnEsFFaSbfGteM(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FgKnEsFFaSbfGteM(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FqJOBgknvhLKxtzm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FqJOBgknvhLKxtzm(java.lang.stringBuilder sb, java.lang.string str, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqJOBgknvhLKxtzm(java.lang.stringBuilder sb, java.lang.string str, float f, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FqJOBgknvhLKxtzm(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HVIyzrQMExyOLIJA(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static void HVIyzrQMExyOLIJA(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HVIyzrQMExyOLIJA(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HVIyzrQMExyOLIJA(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HlDbtMjEdXNjbPTp(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void HlDbtMjEdXNjbPTp(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlDbtMjEdXNjbPTp(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlDbtMjEdXNjbPTp(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HuhmxFTLkayqepwW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState) {
        animatedStateListDrawableCompat$AnimatedStateListState.mutate();
    }

    public static void HuhmxFTLkayqepwW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HuhmxFTLkayqepwW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HuhmxFTLkayqepwW(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int HxzQALNoNVQWXFbz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z) {
        return animatedStateListDrawableCompat$AnimatedStateListState.addTransition(i, i2, drawable, z);
    }

    public static void HxzQALNoNVQWXFbz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, float f, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HxzQALNoNVQWXFbz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HxzQALNoNVQWXFbz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable IZaHRWAWWgwCtjKL(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat) {
        return super.mutate();
    }

    public static void IZaHRWAWWgwCtjKL(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZaHRWAWWgwCtjKL(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IZaHRWAWWgwCtjKL(androidx.appcompat.graphics.drawable.StateListDrawableCompat stateListDrawableCompat, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IaqsgCLMOBVtDucx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i) {
        return animatedStateListDrawableCompat$AnimatedStateListState.addStateHashSet(iArr, drawable, i);
    }

    public static void IaqsgCLMOBVtDucx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IaqsgCLMOBVtDucx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IaqsgCLMOBVtDucx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void InflateChildElements(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((7 + 7) % 7 > 0) {
        }
        int iOYCXGBuaJicrzSHG = oYCXGBuaJicrzSHG(xmlPullParser) + 1;
        while (true) {
            int iGuSntLcXXBbTsfYz = GuSntLcXXBbTsfYz(xmlPullParser);
            if (iGuSntLcXXBbTsfYz == 1) {
                return;
            }
            int iYSOjIunmWVvoMrMI = ySOjIunmWVvoMrMI(xmlPullParser);
            if (iYSOjIunmWVvoMrMI < iOYCXGBuaJicrzSHG && iGuSntLcXXBbTsfYz == 3) {
                return;
            }
            if (iGuSntLcXXBbTsfYz == 2 && iYSOjIunmWVvoMrMI <= iOYCXGBuaJicrzSHG) {
                if (vwJTkizDkbVOcfUt(vQQxtFcGfYcojGJe(xmlPullParser), "item")) {
                    sXFAjfiymTELoUZr(this, context, resources, xmlPullParser, attributeHashSet, resources$Theme);
                } else if (fKlslcXNQRfLwqML(hVIyzrQMExyOLIJA(xmlPullParser), "transition")) {
                    CRabljCFRpdAXAXO(this, context, resources, xmlPullParser, attributeHashSet, resources$Theme);
                }
            }
        }
    }

    private void InflateChildElements(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InflateChildElements(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void InflateChildElements(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void Init() {
        xcxWddiiFzMpIVWE(this, qiXgwjjgfdFkjSkD(this));
    }

    private void Init(char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void Init(char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void Init(float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IqFktCVjVXQUHDFm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.Resources resources) {
        animatedStateListDrawableCompat.updateDensity(resources);
    }

    public static void IqFktCVjVXQUHDFm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.Resources resources, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IqFktCVjVXQUHDFm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.Resources resources, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IqFktCVjVXQUHDFm(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.res.Resources resources, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.ResourceManagerInternal JDZRBEQSKYYgzHWf() {
        return androidx.appcompat.widget.ResourceManagerInternal[);
    }

    public static void JDZRBEQSKYYgzHWf(byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDZRBEQSKYYgzHWf(java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JDZRBEQSKYYgzHWf(java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JFjUqfiRPxZGjSRO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void JFjUqfiRPxZGjSRO(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JFjUqfiRPxZGjSRO(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JFjUqfiRPxZGjSRO(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JpifmsMatyNFJtsB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpifmsMatyNFJtsB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JpifmsMatyNFJtsB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int[] JpifmsMatyNFJtsB(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.getState();
    }

    public static java.lang.string JzUFvqcyilEVLFUg(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static void JzUFvqcyilEVLFUg(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzUFvqcyilEVLFUg(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JzUFvqcyilEVLFUg(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KDZOefPkHGVTIoZC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KDZOefPkHGVTIoZC(java.lang.stringBuilder sb, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDZOefPkHGVTIoZC(java.lang.stringBuilder sb, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KDZOefPkHGVTIoZC(java.lang.stringBuilder sb, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KISoFCtMFhRZcMBZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KISoFCtMFhRZcMBZ(java.lang.stringBuilder sb, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KISoFCtMFhRZcMBZ(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KISoFCtMFhRZcMBZ(java.lang.stringBuilder sb, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int KQzoptXGqCwamyVm(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void KQzoptXGqCwamyVm(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KQzoptXGqCwamyVm(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KQzoptXGqCwamyVm(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KivkBbFkBSaCIMEc(android.content.res.TypedArray typedArray, int i, bool z, int i2, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KivkBbFkBSaCIMEc(android.content.res.TypedArray typedArray, int i, bool z, int i2, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KivkBbFkBSaCIMEc(android.content.res.TypedArray typedArray, int i, bool z, short s, bool z2, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool KivkBbFkBSaCIMEc(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.content.res.TypedArray LPYyZnZflcHrVkRz(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, iArr);
    }

    public static void LPYyZnZflcHrVkRz(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LPYyZnZflcHrVkRz(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LPYyZnZflcHrVkRz(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LerUTQHvjnzPMxUS(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static void LerUTQHvjnzPMxUS(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LerUTQHvjnzPMxUS(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LerUTQHvjnzPMxUS(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LjgMiLxhbrkYNpOz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, char c, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LjgMiLxhbrkYNpOz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, int i3, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LjgMiLxhbrkYNpOz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, short s, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LjgMiLxhbrkYNpOz(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2) {
        return animatedStateListDrawableCompat$AnimatedStateListState.transitionHasReversibleFlag(i, i2);
    }

    public static android.content.res.XmlResourceParser NjFBeDnTTkzJfMwl(android.content.res.Resources resources, int i) {
        return resources.getXml(i);
    }

    public static void NjFBeDnTTkzJfMwl(android.content.res.Resources resources, int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NjFBeDnTTkzJfMwl(android.content.res.Resources resources, int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NjFBeDnTTkzJfMwl(android.content.res.Resources resources, int i, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OYCXGBuaJicrzSHG(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getDepth();
    }

    public static void OYCXGBuaJicrzSHG(org.xmlpull.v1.XmlPullParser xmlPullParser, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OYCXGBuaJicrzSHG(org.xmlpull.v1.XmlPullParser xmlPullParser, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OYCXGBuaJicrzSHG(org.xmlpull.v1.XmlPullParser xmlPullParser, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OgzjycKVhiOzTFeh(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getPositionDescription();
    }

    public static void OgzjycKVhiOzTFeh(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OgzjycKVhiOzTFeh(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OgzjycKVhiOzTFeh(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OviaQesnkdyuBeWo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition) {
        animatedStateListDrawableCompat$Transition.stop();
    }

    public static void OviaQesnkdyuBeWo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OviaQesnkdyuBeWo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OviaQesnkdyuBeWo(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PUkrYSgPjTuHaIvd(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void PUkrYSgPjTuHaIvd(android.content.res.TypedArray typedArray, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PUkrYSgPjTuHaIvd(android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PUkrYSgPjTuHaIvd(android.content.res.TypedArray typedArray, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZLoWlMXPIvfmNfA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z) {
        animatedStateListDrawableCompat.setDither(z);
    }

    public static void PZLoWlMXPIvfmNfA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, byte b, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZLoWlMXPIvfmNfA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, int i, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZLoWlMXPIvfmNfA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, int i, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PZeGhqbWUgAaUeEB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PZeGhqbWUgAaUeEB(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PZeGhqbWUgAaUeEB(java.lang.stringBuilder sb, java.lang.string str, int i, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZeGhqbWUgAaUeEB(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PZqrQpCQmVmcKzlT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        animatedStateListDrawableCompat.setConstantState(drawableContainerCompat$DrawableContainerState);
    }

    public static void PZqrQpCQmVmcKzlT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZqrQpCQmVmcKzlT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZqrQpCQmVmcKzlT(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZrLKIQHoTIgaPCA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        animatedStateListDrawableCompat.inflate(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void PZrLKIQHoTIgaPCA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZrLKIQHoTIgaPCA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZrLKIQHoTIgaPCA(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private int ParseItem(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        int iKzbkIiozoSAVmewU;
        if ((31 + 18) % 18 > 0) {
        }
        android.content.res.TypedArray typedArrayABHEEoNfUwUReCAX = aBHEEoNfUwUReCAX(resources, resources$Theme, attributeHashSet, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableItem);
        int iXygnQEEeJjmYMhhP = xygnQEEeJjmYMhhP(typedArrayABHEEoNfUwUReCAX, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableItem_android_id, 0);
        int iJFjUqfiRPxZGjSRO = jFjUqfiRPxZGjSRO(typedArrayABHEEoNfUwUReCAX, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableItem_android_drawable, -1);
        android.graphics.drawable.Drawable drawableOFCWIxIhSKhUMmkq = iJFjUqfiRPxZGjSRO <= 0 ? null : OFCWIxIhSKhUMmkq(LqJZtOHVjEwBUkjX(), context, iJFjUqfiRPxZGjSRO);
        pUkrYSgPjTuHaIvd(typedArrayABHEEoNfUwUReCAX);
        int[] iArrBoQiGtMjhNdFNcNY = BoQiGtMjhNdFNcNY(this, attributeHashSet);
        if (drawableOFCWIxIhSKhUMmkq is null) {
            do {
                iKzbkIiozoSAVmewU = KzbkIiozoSAVmewU(xmlPullParser);
            } while (iKzbkIiozoSAVmewU == 4);
            if (iKzbkIiozoSAVmewU != 2) {
                throw new org.xmlpull.v1.XmlPullParserException(kDZOefPkHGVTIoZC(fqJOBgknvhLKxtzm(KYRdjOUsVyxWMhBU(new java.lang.stringBuilder(), WOvabUpoiheQwLJr(xmlPullParser)), ": <item> tag requires a 'drawable' attribute or child tag defining a drawable")));
            }
            drawableOFCWIxIhSKhUMmkq = !wnNxEJnoFGGDPgQq(lerUTQHvjnzPMxUS(xmlPullParser), "vector") ? NjxxtUxQhnCMkvao(resources, xmlPullParser, attributeHashSet, resources$Theme) : ImkCGWfCnkwTRpom(resources, xmlPullParser, attributeHashSet, resources$Theme);
        }
        if (drawableOFCWIxIhSKhUMmkq is null) {
            throw new org.xmlpull.v1.XmlPullParserException(SZmxAkvQhmnkglXl(aoieyoykkCuYrUBu(fDujEcvxUJNIPxez(new java.lang.stringBuilder(), wPsqTqwrqABHhTZB(xmlPullParser)), ": <item> tag requires a 'drawable' attribute or child tag defining a drawable")));
        }
        return VmVHOdzdCdxNJSQW(this.mState, iArrBoQiGtMjhNdFNcNY, drawableOFCWIxIhSKhUMmkq, iXygnQEEeJjmYMhhP);
    }

    private void ParseItem(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void ParseItem(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void ParseItem(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private int ParseTransition(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        int iXlXFFfIdiUaWebKz;
        if ((13 + 20) % 20 > 0) {
        }
        android.content.res.TypedArray typedArrayLPYyZnZflcHrVkRz = lPYyZnZflcHrVkRz(resources, resources$Theme, attributeHashSet, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableTransition);
        int iUJUVSDcweRLQAyUF = UJUVSDcweRLQAyUF(typedArrayLPYyZnZflcHrVkRz, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableTransition_android_fromId, -1);
        int iXVJlKrzByDsyqIvO = xVJlKrzByDsyqIvO(typedArrayLPYyZnZflcHrVkRz, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableTransition_android_toId, -1);
        int iOVeLvEteeHbKStbA = OVeLvEteeHbKStbA(typedArrayLPYyZnZflcHrVkRz, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableTransition_android_drawable, -1);
        android.graphics.drawable.Drawable drawableYyisnWJVXGMzyWOI = iOVeLvEteeHbKStbA <= 0 ? null : YyisnWJVXGMzyWOI(jDZRBEQSKYYgzHWf(), context, iOVeLvEteeHbKStbA);
        bool zZmJTlPEoxNRpZjoM = zmJTlPEoxNRpZjoM(typedArrayLPYyZnZflcHrVkRz, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableTransition_android_reversible, false);
        TUGzfftOYQDoCCSc(typedArrayLPYyZnZflcHrVkRz);
        if (drawableYyisnWJVXGMzyWOI is null) {
            do {
                iXlXFFfIdiUaWebKz = XlXFFfIdiUaWebKz(xmlPullParser);
            } while (iXlXFFfIdiUaWebKz == 4);
            if (iXlXFFfIdiUaWebKz != 2) {
                throw new org.xmlpull.v1.XmlPullParserException(GfneFIzNsjBSzExl(wQjzrIWGlLeejrlL(ttpucUsXxyGxBobV(new java.lang.stringBuilder(), FIXxLiMjHqyPNbGC(xmlPullParser)), ": <transition> tag requires a 'drawable' attribute or child tag defining a drawable")));
            }
            drawableYyisnWJVXGMzyWOI = !rTeeTuNIuaXsejwD(jzUFvqcyilEVLFUg(xmlPullParser), "animated-vector") ? ZtXOdVhpVPRGRChf(resources, xmlPullParser, attributeHashSet, resources$Theme) : bWBGhwAAOWaTvhzU(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
        }
        if (drawableYyisnWJVXGMzyWOI is null) {
            throw new org.xmlpull.v1.XmlPullParserException(OcaWRXlqkEhJHKzA(elXXomETRDeXfVAo(WPwyccNqOlBVJrJb(new java.lang.stringBuilder(), eRwOEIpBAyrcfEFM(xmlPullParser)), ": <transition> tag requires a 'drawable' attribute or child tag defining a drawable")));
        }
        if (iUJUVSDcweRLQAyUF == -1 || iXVJlKrzByDsyqIvO == -1) {
            throw new org.xmlpull.v1.XmlPullParserException(uTDLgdvpXhnGNQYV(HqCRpWrKVAaiFsHm(pZeGhqbWUgAaUeEB(new java.lang.stringBuilder(), tnCWRStHXQxQNwlE(xmlPullParser)), ": <transition> tag requires 'fromId' & 'toId' attributes")));
        }
        return IMtVFNrcaAWEEqVT(this.mState, iUJUVSDcweRLQAyUF, iXVJlKrzByDsyqIvO, drawableYyisnWJVXGMzyWOI, zZmJTlPEoxNRpZjoM);
    }

    private void ParseTransition(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void ParseTransition(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void ParseTransition(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray PcRuDFvJnoBIVqYD(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, iArr);
    }

    public static void PcRuDFvJnoBIVqYD(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PcRuDFvJnoBIVqYD(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PcRuDFvJnoBIVqYD(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QSXNIUwaZukaHkiV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QSXNIUwaZukaHkiV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, int i2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QSXNIUwaZukaHkiV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool QSXNIUwaZukaHkiV(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int i) {
        return animatedStateListDrawableCompat.selectTransition(i);
    }

    public static int QXHgTJsjfkQrdiOE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr) {
        return animatedStateListDrawableCompat$AnimatedStateListState.indexOfKeyframe(iArr);
    }

    public static void QXHgTJsjfkQrdiOE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QXHgTJsjfkQrdiOE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXHgTJsjfkQrdiOE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int[] iArr, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QiXgwjjgfdFkjSkD(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QiXgwjjgfdFkjSkD(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QiXgwjjgfdFkjSkD(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] QiXgwjjgfdFkjSkD(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.getState();
    }

    public static void RTeeTuNIuaXsejwD(java.lang.string str, java.lang.object obj, float f, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RTeeTuNIuaXsejwD(java.lang.string str, java.lang.object obj, java.lang.string str2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RTeeTuNIuaXsejwD(java.lang.string str, java.lang.object obj, bool z, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RTeeTuNIuaXsejwD(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int SHXEOxvNChlDIrVE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2) {
        return animatedStateListDrawableCompat$AnimatedStateListState.indexOfTransition(i, i2);
    }

    public static void SHXEOxvNChlDIrVE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SHXEOxvNChlDIrVE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SHXEOxvNChlDIrVE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState, int i, int i2, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SXFAjfiymTELoUZr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return animatedStateListDrawableCompat.parseItem(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void SXFAjfiymTELoUZr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SXFAjfiymTELoUZr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SXFAjfiymTELoUZr(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void SelectTransition(int i, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void SelectTransition(int i, int i2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SelectTransition(int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool SelectTransition(int i) {
        int iETvELdADpexzZuvl;
        int iSHXEOxvNChlDIrVE;
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$AnimationDrawableTransition;
        if ((29 + 31) % 31 > 0) {
        }
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition = this.mTransition;
        if (animatedStateListDrawableCompat$Transition is null) {
            iETvELdADpexzZuvl = eTvELdADpexzZuvl(this);
        } else {
            if (i == this.mTransitionToIndex) {
                return true;
            }
            if (i == this.mTransitionFromIndex && dWcYpBifhJChttuF(animatedStateListDrawableCompat$Transition)) {
                TTwXThKAqDdzUHoZ(animatedStateListDrawableCompat$Transition);
                this.mTransitionToIndex = this.mTransitionFromIndex;
                this.mTransitionFromIndex = i;
                return true;
            }
            iETvELdADpexzZuvl = this.mTransitionToIndex;
            oviaQesnkdyuBeWo(animatedStateListDrawableCompat$Transition);
        }
        this.mTransition = null;
        this.mTransitionFromIndex = -1;
        this.mTransitionToIndex = -1;
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState = this.mState;
        int iQHzMzStcwkEThdxr = QHzMzStcwkEThdxr(animatedStateListDrawableCompat$AnimatedStateListState, iETvELdADpexzZuvl);
        int iUROBHkAfgxIXlKcm = UROBHkAfgxIXlKcm(animatedStateListDrawableCompat$AnimatedStateListState, i);
        if (iUROBHkAfgxIXlKcm == 0 || iQHzMzStcwkEThdxr == 0 || (iSHXEOxvNChlDIrVE = sHXEOxvNChlDIrVE(animatedStateListDrawableCompat$AnimatedStateListState, iQHzMzStcwkEThdxr, iUROBHkAfgxIXlKcm)) < 0) {
            return false;
        }
        bool zLjgMiLxhbrkYNpOz = ljgMiLxhbrkYNpOz(animatedStateListDrawableCompat$AnimatedStateListState, iQHzMzStcwkEThdxr, iUROBHkAfgxIXlKcm);
        JmQzPWYiTHDzwozU(this, iSHXEOxvNChlDIrVE);
        java.lang.object objTtCXvnjRRKJCefXl = TtCXvnjRRKJCefXl(this);
        if (objTtCXvnjRRKJCefXl is android.graphics.drawable.AnimationDrawable) {
            animatedStateListDrawableCompat$AnimationDrawableTransition = new androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimationDrawableTransition((android.graphics.drawable.AnimationDrawable) objTtCXvnjRRKJCefXl, NGkbKscPMyZglCPw(animatedStateListDrawableCompat$AnimatedStateListState, iQHzMzStcwkEThdxr, iUROBHkAfgxIXlKcm), zLjgMiLxhbrkYNpOz);
        } else {
            if (!(objTtCXvnjRRKJCefXl is androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat)) {
                if (objTtCXvnjRRKJCefXl is android.graphics.drawable.Animatable) {
                    animatedStateListDrawableCompat$AnimationDrawableTransition = new androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatableTransition((android.graphics.drawable.Animatable) objTtCXvnjRRKJCefXl);
                }
                return false;
            }
            animatedStateListDrawableCompat$AnimationDrawableTransition = new androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedVectorDrawableTransition((androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat) objTtCXvnjRRKJCefXl);
        }
        IlyYWAnZoAPSkxip(animatedStateListDrawableCompat$AnimationDrawableTransition);
        this.mTransition = animatedStateListDrawableCompat$AnimationDrawableTransition;
        this.mTransitionFromIndex = iETvELdADpexzZuvl;
        this.mTransitionToIndex = i;
        return true;
    }

    public static java.lang.string TnCWRStHXQxQNwlE(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getPositionDescription();
    }

    public static void TnCWRStHXQxQNwlE(org.xmlpull.v1.XmlPullParser xmlPullParser, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TnCWRStHXQxQNwlE(org.xmlpull.v1.XmlPullParser xmlPullParser, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TnCWRStHXQxQNwlE(org.xmlpull.v1.XmlPullParser xmlPullParser, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TtpucUsXxyGxBobV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TtpucUsXxyGxBobV(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TtpucUsXxyGxBobV(java.lang.stringBuilder sb, java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TtpucUsXxyGxBobV(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void URwEpWkWrCOeGzjf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void URwEpWkWrCOeGzjf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void URwEpWkWrCOeGzjf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool URwEpWkWrCOeGzjf(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr) {
        return animatedStateListDrawableCompat.onStateChange(iArr);
    }

    public static java.lang.string UTDLgdvpXhnGNQYV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UTDLgdvpXhnGNQYV(java.lang.stringBuilder sb, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UTDLgdvpXhnGNQYV(java.lang.stringBuilder sb, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UTDLgdvpXhnGNQYV(java.lang.stringBuilder sb, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray) {
        if ((21 + 28) % 28 > 0) {
        }
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState animatedStateListDrawableCompat$AnimatedStateListState = this.mState;
        animatedStateListDrawableCompat$AnimatedStateListState.mChangingConfigurations |= AhiOJDroywmpfulc(typedArray);
        SThPvLKiEiXJmqMZ(animatedStateListDrawableCompat$AnimatedStateListState, HDnCfWYmoXHsOYcL(typedArray, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableCompat_android_variablePadding, animatedStateListDrawableCompat$AnimatedStateListState.mVariablePadding));
        YMqDRddFLjdFufaB(animatedStateListDrawableCompat$AnimatedStateListState, kivkBbFkBSaCIMEc(typedArray, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableCompat_android_constantSize, animatedStateListDrawableCompat$AnimatedStateListState.mConstantSize));
        YfZQNYRLLlmUqJIh(animatedStateListDrawableCompat$AnimatedStateListState, RRFKmQMTgpwOoxkc(typedArray, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableCompat_android_enterFadeDuration, animatedStateListDrawableCompat$AnimatedStateListState.mEnterFadeDuration));
        BofsESsbOYJuJtXN(animatedStateListDrawableCompat$AnimatedStateListState, RgxBCDVpEMpVfAjT(typedArray, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableCompat_android_exitFadeDuration, animatedStateListDrawableCompat$AnimatedStateListState.mExitFadeDuration));
        pZLoWlMXPIvfmNfA(this, zUriTorWWgosvsZp(typedArray, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableCompat_android_dither, animatedStateListDrawableCompat$AnimatedStateListState.mDither));
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VQQxtFcGfYcojGJe(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static void VQQxtFcGfYcojGJe(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VQQxtFcGfYcojGJe(org.xmlpull.v1.XmlPullParser xmlPullParser, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VQQxtFcGfYcojGJe(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VTpbMAabGNKXWXOO(java.lang.string str, java.lang.object obj, float f, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VTpbMAabGNKXWXOO(java.lang.string str, java.lang.object obj, int i, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VTpbMAabGNKXWXOO(java.lang.string str, java.lang.object obj, java.lang.string str2, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VTpbMAabGNKXWXOO(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void VwJTkizDkbVOcfUt(java.lang.string str, java.lang.object obj, char c, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VwJTkizDkbVOcfUt(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VwJTkizDkbVOcfUt(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VwJTkizDkbVOcfUt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string WPsqTqwrqABHhTZB(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getPositionDescription();
    }

    public static void WPsqTqwrqABHhTZB(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WPsqTqwrqABHhTZB(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WPsqTqwrqABHhTZB(org.xmlpull.v1.XmlPullParser xmlPullParser, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WQjzrIWGlLeejrlL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WQjzrIWGlLeejrlL(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WQjzrIWGlLeejrlL(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WQjzrIWGlLeejrlL(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WnNxEJnoFGGDPgQq(java.lang.string str, java.lang.object obj, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WnNxEJnoFGGDPgQq(java.lang.string str, java.lang.object obj, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WnNxEJnoFGGDPgQq(java.lang.string str, java.lang.object obj, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WnNxEJnoFGGDPgQq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int XVJlKrzByDsyqIvO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void XVJlKrzByDsyqIvO(android.content.res.TypedArray typedArray, int i, int i2, int i3, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XVJlKrzByDsyqIvO(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XVJlKrzByDsyqIvO(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void XcxWddiiFzMpIVWE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XcxWddiiFzMpIVWE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XcxWddiiFzMpIVWE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XcxWddiiFzMpIVWE(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, int[] iArr) {
        return animatedStateListDrawableCompat.onStateChange(iArr);
    }

    public static int XygnQEEeJjmYMhhP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void XygnQEEeJjmYMhhP(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XygnQEEeJjmYMhhP(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XygnQEEeJjmYMhhP(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YFCPRtFnrFlrEhfj(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition) {
        animatedStateListDrawableCompat$Transition.stop();
    }

    public static void YFCPRtFnrFlrEhfj(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YFCPRtFnrFlrEhfj(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YFCPRtFnrFlrEhfj(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YSOjIunmWVvoMrMI(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getDepth();
    }

    public static void YSOjIunmWVvoMrMI(org.xmlpull.v1.XmlPullParser xmlPullParser, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSOjIunmWVvoMrMI(org.xmlpull.v1.XmlPullParser xmlPullParser, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YSOjIunmWVvoMrMI(org.xmlpull.v1.XmlPullParser xmlPullParser, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YqbJcaYFqPgyJuCZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YqbJcaYFqPgyJuCZ(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YqbJcaYFqPgyJuCZ(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YqbJcaYFqPgyJuCZ(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZCZYTeezvgxFUMyk(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat) {
        return animatedStateListDrawableCompat.getCurrent();
    }

    public static void ZCZYTeezvgxFUMyk(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZCZYTeezvgxFUMyk(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZCZYTeezvgxFUMyk(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat animatedStateListDrawableCompat, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZUriTorWWgosvsZp(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZUriTorWWgosvsZp(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZUriTorWWgosvsZp(android.content.res.TypedArray typedArray, int i, bool z, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZUriTorWWgosvsZp(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat ZhXckQwnYzkVlcLt(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) {
        return createFromXmlInner(context, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    public static void ZhXckQwnYzkVlcLt(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhXckQwnYzkVlcLt(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhXckQwnYzkVlcLt(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZmJTlPEoxNRpZjoM(android.content.res.TypedArray typedArray, int i, bool z, char c, bool z2, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZmJTlPEoxNRpZjoM(android.content.res.TypedArray typedArray, int i, bool z, float f, bool z2, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZmJTlPEoxNRpZjoM(android.content.res.TypedArray typedArray, int i, bool z, int i2, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZmJTlPEoxNRpZjoM(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public void AddState(int[] iArr, android.graphics.drawable.Drawable drawable, int i) {
        cSfKzGLOBWHCWaJS(drawable);
        iaqsgCLMOBVtDucx(this.mState, iArr, drawable, i);
        cPwNPTCPnATIrHTo(this, jpifmsMatyNFJtsB(this));
    }

    public <T : android.graphics.drawable.Drawable & android.graphics.drawable.Animatable> void addTransition(int i, int i2, T t, bool z) {
        XIwemnfPShwrzRWk(t);
        hxzQALNoNVQWXFbz(this.mState, i, i2, t, z);
    }

    void clearMutated() {
        MuwIWnGhLYDIBtGl(this);
        this.mMutated = false;
    }

    androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState cloneConstantState() {
        if ((7 + 12) % 12 > 0) {
        }
        return new androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState(this.mState, this, null);
    }

    androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState cloneConstantState() {
        return RTHgiHNJjpolOiHo(this);
    }

    androidx.appcompat.graphics.drawable.StateListDrawableCompat$StateListState cloneConstantState() {
        return DeWZQEOtMKpyHTBc(this);
    }

    public override void Inflate(android.content.object context, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((20 + 20) % 20 > 0) {
        }
        android.content.res.TypedArray typedArrayPcRuDFvJnoBIVqYD = pcRuDFvJnoBIVqYD(resources, resources$Theme, attributeHashSet, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableCompat);
        MDxTUFjmDCEvyzZX(this, CTUWGRIUYjGTqpLp(typedArrayPcRuDFvJnoBIVqYD, androidx.appcompat.resources.R$styleable.AnimatedStateListDrawableCompat_android_visible, true), true);
        UuMYeJeElGCdYcPI(this, typedArrayPcRuDFvJnoBIVqYD);
        iqFktCVjVXQUHDFm(this, resources);
        FDpRmqNlHFMbTtyF(typedArrayPcRuDFvJnoBIVqYD);
        WHanAyuQItPaaqWF(this, context, resources, xmlPullParser, attributeHashSet, resources$Theme);
        KPmcEAaFwOXotRgz(this);
    }

    public override bool IsStateful() {
        return true;
    }

    public override void JumpToCurrentState() {
        KfFWTAhQrbzlxVIu(this);
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition = this.mTransition;
        if (animatedStateListDrawableCompat$Transition is null) {
            return;
        }
        yFCPRtFnrFlrEhfj(animatedStateListDrawableCompat$Transition);
        this.mTransition = null;
        KyJhCiysIddTsDvV(this, this.mTransitionToIndex);
        this.mTransitionToIndex = -1;
        this.mTransitionFromIndex = -1;
    }

    public override android.graphics.drawable.Drawable Mutate() {
        if (!this.mMutated && iZaHRWAWWgwCtjKL(this) == this) {
            huhmxFTLkayqepwW(this.mState);
            this.mMutated = true;
        }
        return this;
    }

    protected override bool OnStateChange(int[] iArr) {
        if ((26 + 14) % 14 > 0) {
        }
        int iQXHgTJsjfkQrdiOE = qXHgTJsjfkQrdiOE(this.mState, iArr);
        bool z = iQXHgTJsjfkQrdiOE != HXVjBRgkAmwbBoSl(this) && (qSXNIUwaZukaHkiV(this, iQXHgTJsjfkQrdiOE) || COdgJcBPsiYvJLDz(this, iQXHgTJsjfkQrdiOE));
        android.graphics.drawable.Drawable drawableZCZYTeezvgxFUMyk = zCZYTeezvgxFUMyk(this);
        return drawableZCZYTeezvgxFUMyk is null ? z : LMTYgvXazBDhqbss(drawableZCZYTeezvgxFUMyk, iArr) | z;
    }

    void setConstantState(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        fgKnEsFFaSbfGteM(this, drawableContainerCompat$DrawableContainerState);
        if (drawableContainerCompat$DrawableContainerState is androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState) {
            this.mState = (androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$AnimatedStateListState) drawableContainerCompat$DrawableContainerState;
        }
    }

    public override bool SetVisible(bool z, bool z2) {
        if ((6 + 13) % 13 > 0) {
        }
        bool zBYZWUdckqOrkAxCe = bYZWUdckqOrkAxCe(this, z, z2);
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition animatedStateListDrawableCompat$Transition = this.mTransition;
        if (animatedStateListDrawableCompat$Transition is not null && (zBYZWUdckqOrkAxCe || z2)) {
            if (z) {
                OImkOWlZyrnvhnaf(animatedStateListDrawableCompat$Transition);
                return zBYZWUdckqOrkAxCe;
            }
            JYcdFMQevJiuLTjp(this);
        }
        return zBYZWUdckqOrkAxCe;
    }
}

