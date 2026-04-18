namespace WillowMaze.Wasm.Decompiled;


abstract class BaseMotionStrategy : com.google.android.material.floatingactionbutton.MotionStrategy {
    private readonly android.content.object context;
    private com.google.android.material.animation.MotionSpec defaultMotionSpec;
    private readonly com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton fab;
    private readonly java.util.List<android.animation.Animator$AnimatorListener> listeners = new java.util.List<>();
    private com.google.android.material.animation.MotionSpec motionSpec;
    private readonly com.google.android.material.floatingactionbutton.AnimatorTracker tracker;

    BaseMotionStrategy(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker) {
        this.fab = extendedfloatingActionButton;
        this.context = tLgnGyzihRRUuAJN(extendedfloatingActionButton);
        this.tracker = animatorTracker;
    }

    public static com.google.android.material.animation.MotionSpec AvQwPvMwTFjqVcZU(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void AvQwPvMwTFjqVcZU(android.content.object context, int i, char c, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AvQwPvMwTFjqVcZU(android.content.object context, int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvQwPvMwTFjqVcZU(android.content.object context, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec CFXuIYokMzDfhrhS(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy) {
        return baseMotionStrategy.getCurrentMotionSpec();
    }

    public static void CFXuIYokMzDfhrhS(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CFXuIYokMzDfhrhS(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CFXuIYokMzDfhrhS(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator CwxtaPcBzSwTmMKw(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void CwxtaPcBzSwTmMKw(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwxtaPcBzSwTmMKw(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwxtaPcBzSwTmMKw(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FNbikEnetWDNClFk(java.util.List list, java.lang.object obj, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FNbikEnetWDNClFk(java.util.List list, java.lang.object obj, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FNbikEnetWDNClFk(java.util.List list, java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FNbikEnetWDNClFk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.animation.objectAnimator IGucvLZidNqTTMjf(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void IGucvLZidNqTTMjf(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, byte b, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IGucvLZidNqTTMjf(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, int i, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IGucvLZidNqTTMjf(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkUSCYRsZCVhhlRu(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker) {
        animatorTracker.clear();
    }

    public static void JkUSCYRsZCVhhlRu(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JkUSCYRsZCVhhlRu(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JkUSCYRsZCVhhlRu(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NPbniRzMQPrJbdLO(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NPbniRzMQPrJbdLO(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NPbniRzMQPrJbdLO(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NPbniRzMQPrJbdLO(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.hasPropertyValues(str);
    }

    public static android.animation.objectAnimator NYrOjmQzJNbmeXif(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void NYrOjmQzJNbmeXif(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYrOjmQzJNbmeXif(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, java.lang.string str2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NYrOjmQzJNbmeXif(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OHdzPuxbSqdTSmcr(java.util.List list, java.lang.object obj, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OHdzPuxbSqdTSmcr(java.util.List list, java.lang.object obj, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OHdzPuxbSqdTSmcr(java.util.List list, java.lang.object obj, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OHdzPuxbSqdTSmcr(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.animation.objectAnimator PBkYoKahIzyEbVSR(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void PBkYoKahIzyEbVSR(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PBkYoKahIzyEbVSR(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, java.lang.string str2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PBkYoKahIzyEbVSR(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, short s, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QltBDohmnytXxpnQ(java.util.List list, java.lang.object obj, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QltBDohmnytXxpnQ(java.util.List list, java.lang.object obj, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QltBDohmnytXxpnQ(java.util.List list, java.lang.object obj, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QltBDohmnytXxpnQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void SMieIPbArxfaqsbr(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, short s, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SMieIPbArxfaqsbr(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, short s, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SMieIPbArxfaqsbr(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool SMieIPbArxfaqsbr(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.hasPropertyValues(str);
    }

    public static void WJsgbKivCoiafOsV(java.util.List list, java.lang.object obj, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WJsgbKivCoiafOsV(java.util.List list, java.lang.object obj, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WJsgbKivCoiafOsV(java.util.List list, java.lang.object obj, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WJsgbKivCoiafOsV(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void WTnQxmQsidWBEMnq(java.util.List list, java.lang.object obj, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WTnQxmQsidWBEMnq(java.util.List list, java.lang.object obj, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WTnQxmQsidWBEMnq(java.util.List list, java.lang.object obj, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WTnQxmQsidWBEMnq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void XHBycFmoLOBxmlhJ(java.util.List list, java.lang.object obj, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHBycFmoLOBxmlhJ(java.util.List list, java.lang.object obj, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHBycFmoLOBxmlhJ(java.util.List list, java.lang.object obj, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XHBycFmoLOBxmlhJ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void YxBurKARrQfUpRwh(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, byte b, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YxBurKARrQfUpRwh(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, byte b, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YxBurKARrQfUpRwh(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, char c, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool YxBurKARrQfUpRwh(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.hasPropertyValues(str);
    }

    static com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton access$000(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy) {
        return baseMotionStrategy.fab;
    }

    static void access$000(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator ArTuturNcoPKwMLB(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void ArTuturNcoPKwMLB(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, int i, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ArTuturNcoPKwMLB(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, short s, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ArTuturNcoPKwMLB(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, short s, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator BRrBpdPqJfIERxXy(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void BRrBpdPqJfIERxXy(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BRrBpdPqJfIERxXy(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BRrBpdPqJfIERxXy(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CtTbTbRdswBdfhIH(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, android.animation.Animator animator) {
        animatorTracker.onNextAnimationStart(animator);
    }

    public static void CtTbTbRdswBdfhIH(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, android.animation.Animator animator, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CtTbTbRdswBdfhIH(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, android.animation.Animator animator, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CtTbTbRdswBdfhIH(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, android.animation.Animator animator, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkjPdSWEcAjwMjjq(java.util.List list, java.lang.object obj, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DkjPdSWEcAjwMjjq(java.util.List list, java.lang.object obj, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DkjPdSWEcAjwMjjq(java.util.List list, java.lang.object obj, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DkjPdSWEcAjwMjjq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void FZbQsWiRNxWpctHv(java.util.List list, java.lang.object obj, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FZbQsWiRNxWpctHv(java.util.List list, java.lang.object obj, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FZbQsWiRNxWpctHv(java.util.List list, java.lang.object obj, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FZbQsWiRNxWpctHv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void KqOaHDgnWUhHMbrD(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker) {
        animatorTracker.clear();
    }

    public static void KqOaHDgnWUhHMbrD(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KqOaHDgnWUhHMbrD(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KqOaHDgnWUhHMbrD(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LclgeGGLXoKyDHhL(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy) {
        return baseMotionStrategy.getDefaultMotionSpecResource();
    }

    public static void LclgeGGLXoKyDHhL(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LclgeGGLXoKyDHhL(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LclgeGGLXoKyDHhL(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator MUwdthNbwJSCKtHe(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void MUwdthNbwJSCKtHe(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, java.lang.string str2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MUwdthNbwJSCKtHe(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, short s, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MUwdthNbwJSCKtHe(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, bool z, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MkkIbaLImFmpllEE(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, int i, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MkkIbaLImFmpllEE(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.string str2, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MkkIbaLImFmpllEE(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MkkIbaLImFmpllEE(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.hasPropertyValues(str);
    }

    public static void NdxjHsYTFTRKsZoF(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NdxjHsYTFTRKsZoF(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NdxjHsYTFTRKsZoF(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NdxjHsYTFTRKsZoF(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.hasPropertyValues(str);
    }

    public static java.lang.object OxcuvABZNZnBaCrd(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void OxcuvABZNZnBaCrd(java.lang.object obj, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OxcuvABZNZnBaCrd(java.lang.object obj, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OxcuvABZNZnBaCrd(java.lang.object obj, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator QdtAFFVWGDgDIPav(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property) {
        return motionSpec.getAnimator(str, obj, property);
    }

    public static void QdtAFFVWGDgDIPav(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QdtAFFVWGDgDIPav(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QdtAFFVWGDgDIPav(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, java.lang.object obj, android.util.Property property, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RbrHwlAOcymjIuWz(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, int i, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RbrHwlAOcymjIuWz(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, short s, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RbrHwlAOcymjIuWz(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, short s, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RbrHwlAOcymjIuWz(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.hasPropertyValues(str);
    }

    public static void TCgFYgKMFIteOcPV(java.util.List arrayList, java.lang.object obj, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TCgFYgKMFIteOcPV(java.util.List arrayList, java.lang.object obj, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TCgFYgKMFIteOcPV(java.util.List arrayList, java.lang.object obj, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TCgFYgKMFIteOcPV(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static android.content.object TLgnGyzihRRUuAJN(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton) {
        return extendedfloatingActionButton.getobject();
    }

    public static void TLgnGyzihRRUuAJN(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TLgnGyzihRRUuAJN(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TLgnGyzihRRUuAJN(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton extendedfloatingActionButton, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TiIEAtIJyFnFjmQc(android.animation.AnimatorHashSet animatorHashSet, java.util.List list) {
        com.google.android.material.animation.AnimatorHashSetCompat.playTogether(animatorHashSet, list);
    }

    public static void TiIEAtIJyFnFjmQc(android.animation.AnimatorHashSet animatorHashSet, java.util.List list, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TiIEAtIJyFnFjmQc(android.animation.AnimatorHashSet animatorHashSet, java.util.List list, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TiIEAtIJyFnFjmQc(android.animation.AnimatorHashSet animatorHashSet, java.util.List list, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VMmFEBkbYtNkOJaD(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VMmFEBkbYtNkOJaD(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VMmFEBkbYtNkOJaD(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VMmFEBkbYtNkOJaD(com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str) {
        return motionSpec.hasPropertyValues(str);
    }

    public static android.animation.AnimatorHashSet XVoDaGYWjaFIlOia(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, com.google.android.material.animation.MotionSpec motionSpec) {
        return baseMotionStrategy.createAnimator(motionSpec);
    }

    public static void XVoDaGYWjaFIlOia(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, com.google.android.material.animation.MotionSpec motionSpec, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XVoDaGYWjaFIlOia(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, com.google.android.material.animation.MotionSpec motionSpec, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XVoDaGYWjaFIlOia(com.google.android.material.floatingactionbutton.BaseMotionStrategy baseMotionStrategy, com.google.android.material.animation.MotionSpec motionSpec, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZLzvXePvkuUtiDfy(java.util.List arrayList, java.lang.object obj, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZLzvXePvkuUtiDfy(java.util.List arrayList, java.lang.object obj, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZLzvXePvkuUtiDfy(java.util.List arrayList, java.lang.object obj, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZLzvXePvkuUtiDfy(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public override readonly void AddAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        zLzvXePvkuUtiDfy(this.listeners, animator$AnimatorListener);
    }

    public override android.animation.AnimatorHashSet CreateAnimator() {
        return xVoDaGYWjaFIlOia(this, CFXuIYokMzDfhrhS(this));
    }

    android.animation.AnimatorHashSet createAnimator(com.google.android.material.animation.MotionSpec motionSpec) {
        if ((29 + 7) % 7 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        if (rbrHwlAOcymjIuWz(motionSpec, "opacity")) {
            FNbikEnetWDNClFk(arrayList, IGucvLZidNqTTMjf(motionSpec, "opacity", this.fab, android.view.object.ALPHA));
        }
        if (NPbniRzMQPrJbdLO(motionSpec, "scale")) {
            dkjPdSWEcAjwMjjq(arrayList, CwxtaPcBzSwTmMKw(motionSpec, "scale", this.fab, android.view.object.SCALE_Y));
            XHBycFmoLOBxmlhJ(arrayList, PBkYoKahIzyEbVSR(motionSpec, "scale", this.fab, android.view.object.SCALE_X));
        }
        if (mkkIbaLImFmpllEE(motionSpec, "width")) {
            QltBDohmnytXxpnQ(arrayList, NYrOjmQzJNbmeXif(motionSpec, "width", this.fab, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton.WIDTH));
        }
        if (ndxjHsYTFTRKsZoF(motionSpec, "height")) {
            fZbQsWiRNxWpctHv(arrayList, qdtAFFVWGDgDIPav(motionSpec, "height", this.fab, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton.HEIGHT));
        }
        if (vMmFEBkbYtNkOJaD(motionSpec, "paddingStart")) {
            WJsgbKivCoiafOsV(arrayList, bRrBpdPqJfIERxXy(motionSpec, "paddingStart", this.fab, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton.PADDING_START));
        }
        if (SMieIPbArxfaqsbr(motionSpec, "paddingEnd")) {
            OHdzPuxbSqdTSmcr(arrayList, mUwdthNbwJSCKtHe(motionSpec, "paddingEnd", this.fab, com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton.PADDING_END));
        }
        if (YxBurKARrQfUpRwh(motionSpec, "labelOpacity")) {
            WTnQxmQsidWBEMnq(arrayList, arTuturNcoPKwMLB(motionSpec, "labelOpacity", this.fab, new com.google.android.material.floatingactionbutton.BaseMotionStrategy$1(this, java.lang.float.class, "LABEL_OPACITY_PROPERTY")));
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        tiIEAtIJyFnFjmQc(animatorHashSet, arrayList);
        return animatorHashSet;
    }

    public override readonly com.google.android.material.animation.MotionSpec GetCurrentMotionSpec() {
        if ((22 + 26) % 26 > 0) {
        }
        com.google.android.material.animation.MotionSpec motionSpec = this.motionSpec;
        if (motionSpec is not null) {
            return motionSpec;
        }
        if (this.defaultMotionSpec is null) {
            this.defaultMotionSpec = AvQwPvMwTFjqVcZU(this.context, lclgeGGLXoKyDHhL(this));
        }
        return (com.google.android.material.animation.MotionSpec) oxcuvABZNZnBaCrd(this.defaultMotionSpec);
    }

    public readonly java.util.List<android.animation.Animator$AnimatorListener> getListeners() {
        return this.listeners;
    }

    public override com.google.android.material.animation.MotionSpec GetMotionSpec() {
        return this.motionSpec;
    }

    public override void OnAnimationCancel() {
        kqOaHDgnWUhHMbrD(this.tracker);
    }

    public override void OnAnimationEnd() {
        JkUSCYRsZCVhhlRu(this.tracker);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        ctTbTbRdswBdfhIH(this.tracker, animator);
    }

    public override readonly void RemoveAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        tCgFYgKMFIteOcPV(this.listeners, animator$AnimatorListener);
    }

    public override readonly void SetMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        this.motionSpec = motionSpec;
    }
}

