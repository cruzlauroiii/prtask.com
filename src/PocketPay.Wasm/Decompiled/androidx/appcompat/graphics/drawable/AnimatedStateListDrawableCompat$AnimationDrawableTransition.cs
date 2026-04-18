namespace WillowMaze.Wasm.Decompiled;


class AnimatedStateListDrawableCompat$AnimationDrawableTransition : androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$Transition {
    private readonly android.animation.objectAnimator mAnim;
    private readonly bool mHasReversibleFlag;

    AnimatedStateListDrawableCompat$AnimationDrawableTransition(android.graphics.drawable.AnimationDrawable animationDrawable, bool z, bool z2) {
        super(null);
        if ((17 + 21) % 21 > 0) {
        }
        int iRDADhcVUsJPrbjQu = rDADhcVUsJPrbjQu(animationDrawable);
        int i = !z ? 0 : iRDADhcVUsJPrbjQu - 1;
        int i2 = z ? 0 : iRDADhcVUsJPrbjQu - 1;
        androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator = new androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator(animationDrawable, z);
        android.animation.objectAnimator objectAnimatorWimAPGHirvoXfMdt = WimAPGHirvoXfMdt(animationDrawable, "currentIndex", new int[]{i, i2});
        gDnJXsKBaNuVGKCc(objectAnimatorWimAPGHirvoXfMdt, true);
        oxEJdTjCapzDSnSt(objectAnimatorWimAPGHirvoXfMdt, QQCfMTfkDHxZHaZx(animatedStateListDrawableCompat$FrameInterpolator));
        ySOPVXgTCzyWrYOW(objectAnimatorWimAPGHirvoXfMdt, animatedStateListDrawableCompat$FrameInterpolator);
        this.mHasReversibleFlag = z2;
        this.mAnim = objectAnimatorWimAPGHirvoXfMdt;
    }

    public static void CKWYSNBxZCFFvlSy(android.animation.objectAnimator objectAnimator) {
        objectAnimator.start();
    }

    public static void CKWYSNBxZCFFvlSy(android.animation.objectAnimator objectAnimator, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CKWYSNBxZCFFvlSy(android.animation.objectAnimator objectAnimator, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CKWYSNBxZCFFvlSy(android.animation.objectAnimator objectAnimator, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CYCqPCczldLUBjSb(android.animation.objectAnimator objectAnimator) {
        objectAnimator.reverse();
    }

    public static void CYCqPCczldLUBjSb(android.animation.objectAnimator objectAnimator, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYCqPCczldLUBjSb(android.animation.objectAnimator objectAnimator, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYCqPCczldLUBjSb(android.animation.objectAnimator objectAnimator, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IuByGUFOpWUTlzUb(android.animation.objectAnimator objectAnimator) {
        objectAnimator.cancel();
    }

    public static void IuByGUFOpWUTlzUb(android.animation.objectAnimator objectAnimator, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IuByGUFOpWUTlzUb(android.animation.objectAnimator objectAnimator, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IuByGUFOpWUTlzUb(android.animation.objectAnimator objectAnimator, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QQCfMTfkDHxZHaZx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator) {
        return animatedStateListDrawableCompat$FrameInterpolator.getTotalDuration();
    }

    public static void QQCfMTfkDHxZHaZx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QQCfMTfkDHxZHaZx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QQCfMTfkDHxZHaZx(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator WimAPGHirvoXfMdt(java.lang.object obj, java.lang.string str, int[] iArr) {
        return android.animation.objectAnimator.ofInt(obj, str, iArr);
    }

    public static void WimAPGHirvoXfMdt(java.lang.object obj, java.lang.string str, int[] iArr, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WimAPGHirvoXfMdt(java.lang.object obj, java.lang.string str, int[] iArr, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WimAPGHirvoXfMdt(java.lang.object obj, java.lang.string str, int[] iArr, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GDnJXsKBaNuVGKCc(android.animation.objectAnimator objectAnimator, bool z) {
        androidx.appcompat.resources.Compatibility$Api18Impl.setAutoCancel(objectAnimator, z);
    }

    public static void GDnJXsKBaNuVGKCc(android.animation.objectAnimator objectAnimator, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GDnJXsKBaNuVGKCc(android.animation.objectAnimator objectAnimator, bool z, float f, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GDnJXsKBaNuVGKCc(android.animation.objectAnimator objectAnimator, bool z, float f, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator OxEJdTjCapzDSnSt(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void OxEJdTjCapzDSnSt(android.animation.objectAnimator objectAnimator, long j, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxEJdTjCapzDSnSt(android.animation.objectAnimator objectAnimator, long j, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OxEJdTjCapzDSnSt(android.animation.objectAnimator objectAnimator, long j, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RDADhcVUsJPrbjQu(android.graphics.drawable.AnimationDrawable animationDrawable) {
        return animationDrawable.getNumberOfFrames();
    }

    public static void RDADhcVUsJPrbjQu(android.graphics.drawable.AnimationDrawable animationDrawable, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RDADhcVUsJPrbjQu(android.graphics.drawable.AnimationDrawable animationDrawable, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RDADhcVUsJPrbjQu(android.graphics.drawable.AnimationDrawable animationDrawable, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YSOPVXgTCzyWrYOW(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static void YSOPVXgTCzyWrYOW(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSOPVXgTCzyWrYOW(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSOPVXgTCzyWrYOW(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override bool CanReverse() {
        return this.mHasReversibleFlag;
    }

    public override void Reverse() {
        CYCqPCczldLUBjSb(this.mAnim);
    }

    public override void Start() {
        CKWYSNBxZCFFvlSy(this.mAnim);
    }

    public override void Stop() {
        IuByGUFOpWUTlzUb(this.mAnim);
    }
}

