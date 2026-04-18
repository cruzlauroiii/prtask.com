namespace WillowMaze.Wasm.Decompiled;


public readonly class CircularRevealCompat {
    private CircularRevealCompat() {
    }

    public static com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo MBQCnPBcGbybfsiz(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        return circularRevealWidget.getRevealInfo();
    }

    public static void MBQCnPBcGbybfsiz(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MBQCnPBcGbybfsiz(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MBQCnPBcGbybfsiz(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RbEcSLVPHTDLslhd(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void RbEcSLVPHTDLslhd(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RbEcSLVPHTDLslhd(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RbEcSLVPHTDLslhd(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator TVThuNEuHrPNZQRX(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr) {
        return android.animation.objectAnimator.ofobject(obj, (android.util.Property<java.lang.object, V>) property, typeEvaluator, objArr);
    }

    public static void TVThuNEuHrPNZQRX(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TVThuNEuHrPNZQRX(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TVThuNEuHrPNZQRX(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3) {
        if ((26 + 10) % 10 > 0) {
        }
        android.util.Property<com.google.android.material.circularreveal.CircularRevealWidget, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo> property = com.google.android.material.circularreveal.CircularRevealWidget$CircularRevealProperty.CIRCULAR_REVEAL;
        android.animation.TypeEvaluator<com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo> typeEvaluator = com.google.android.material.circularreveal.CircularRevealWidget$CircularRevealEvaluator.CIRCULAR_REVEAL;
        com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo[] circularRevealWidget$RevealInfoArr = new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo[1];
        circularRevealWidget$RevealInfoArr[0] = new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo(f, f2, f3);
        android.animation.objectAnimator objectAnimatorTVThuNEuHrPNZQRX = TVThuNEuHrPNZQRX(circularRevealWidget, property, typeEvaluator, circularRevealWidget$RevealInfoArr);
        com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfoMBQCnPBcGbybfsiz = MBQCnPBcGbybfsiz(circularRevealWidget);
        if (circularRevealWidget$RevealInfoMBQCnPBcGbybfsiz is null) {
            throw new java.lang.IllegalStateException("Caller must set a non-null RevealInfo before calling this.");
        }
        android.animation.Animator animatorWcsAihUALePgaGWH = wcsAihUALePgaGWH((android.view.object) circularRevealWidget, (int) f, (int) f2, circularRevealWidget$RevealInfoMBQCnPBcGbybfsiz.radius, f3);
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = objectAnimatorTVThuNEuHrPNZQRX;
        animatorArr[1] = animatorWcsAihUALePgaGWH;
        RbEcSLVPHTDLslhd(animatorHashSet, animatorArr);
        return animatorHashSet;
    }

    public static android.animation.Animator CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3, float f4) {
        if ((19 + 6) % 6 > 0) {
        }
        android.util.Property<com.google.android.material.circularreveal.CircularRevealWidget, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo> property = com.google.android.material.circularreveal.CircularRevealWidget$CircularRevealProperty.CIRCULAR_REVEAL;
        android.animation.TypeEvaluator<com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo> typeEvaluator = com.google.android.material.circularreveal.CircularRevealWidget$CircularRevealEvaluator.CIRCULAR_REVEAL;
        com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo[] circularRevealWidget$RevealInfoArr = new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo[2];
        circularRevealWidget$RevealInfoArr[0] = new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo(f, f2, f3);
        circularRevealWidget$RevealInfoArr[1] = new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo(f, f2, f4);
        android.animation.objectAnimator objectAnimatorGTyHixpgAeFbpeXW = gTyHixpgAeFbpeXW(circularRevealWidget, property, typeEvaluator, circularRevealWidget$RevealInfoArr);
        android.animation.Animator animatorIySOVqbzAYlBSFjn = iySOVqbzAYlBSFjn((android.view.object) circularRevealWidget, (int) f, (int) f2, f3, f4);
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = objectAnimatorGTyHixpgAeFbpeXW;
        animatorArr[1] = animatorIySOVqbzAYlBSFjn;
        xLkbwhKLeBmpemwF(animatorHashSet, animatorArr);
        return animatorHashSet;
    }

    public static void CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3, float f4, byte b, short s, float f5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3, float f4, bool z, float f5, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3, float f4, bool z, short s, float f5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3, int i, bool z, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3, java.lang.string str, int i, float f4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularReveal(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, float f, float f2, float f3, bool z, int i, java.lang.string str, float f4) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator$AnimatorListener createCircularRevealListener(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        return new com.google.android.material.circularreveal.CircularRevealCompat$1(circularRevealWidget);
    }

    public static void CreateCircularRevealListener(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularRevealListener(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularRevealListener(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator GTyHixpgAeFbpeXW(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr) {
        return android.animation.objectAnimator.ofobject(obj, (android.util.Property<java.lang.object, V>) property, typeEvaluator, objArr);
    }

    public static void GTyHixpgAeFbpeXW(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTyHixpgAeFbpeXW(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GTyHixpgAeFbpeXW(java.lang.object obj, android.util.Property property, android.animation.TypeEvaluator typeEvaluator, java.lang.object[] objArr, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator IySOVqbzAYlBSFjn(android.view.object view, int i, int i2, float f, float f2) {
        return android.view.objectAnimationUtils.createCircularReveal(view, i, i2, f, f2);
    }

    public static void IySOVqbzAYlBSFjn(android.view.object view, int i, int i2, float f, float f2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IySOVqbzAYlBSFjn(android.view.object view, int i, int i2, float f, float f2, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IySOVqbzAYlBSFjn(android.view.object view, int i, int i2, float f, float f2, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator WcsAihUALePgaGWH(android.view.object view, int i, int i2, float f, float f2) {
        return android.view.objectAnimationUtils.createCircularReveal(view, i, i2, f, f2);
    }

    public static void WcsAihUALePgaGWH(android.view.object view, int i, int i2, float f, float f2, byte b, bool z, short s, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void WcsAihUALePgaGWH(android.view.object view, int i, int i2, float f, float f2, float f3, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WcsAihUALePgaGWH(android.view.object view, int i, int i2, float f, float f2, short s, bool z, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XLkbwhKLeBmpemwF(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void XLkbwhKLeBmpemwF(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XLkbwhKLeBmpemwF(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XLkbwhKLeBmpemwF(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }
}

