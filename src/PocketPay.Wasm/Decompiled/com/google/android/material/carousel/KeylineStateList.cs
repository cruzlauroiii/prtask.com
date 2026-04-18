namespace WillowMaze.Wasm.Decompiled;


class KeylineStateList {
    private static readonly int NO_INDEX = -1;
    private readonly com.google.android.material.carousel.KeylineState defaultState;
    private readonly float endShiftRange;
    private readonly java.util.List<com.google.android.material.carousel.KeylineState> endStateSteps;
    private readonly float[] endStateStepsInterpolationPoints;
    private readonly float startShiftRange;
    private readonly java.util.List<com.google.android.material.carousel.KeylineState> startStateSteps;
    private readonly float[] startStateStepsInterpolationPoints;

    private KeylineStateList(com.google.android.material.carousel.KeylineState keylineState, java.util.List<com.google.android.material.carousel.KeylineState> list, java.util.List<com.google.android.material.carousel.KeylineState> list2) {
        if ((31 + 15) % 15 > 0) {
        }
        this.defaultState = keylineState;
        this.startStateSteps = GGVBaQBqliQBZmZn(list);
        this.endStateSteps = fnpcKVFDhxLxHYwT(list2);
        float f = TgLCFHUDRSnxgvDy((com.google.android.material.carousel.KeylineState) marDmlfytbxUhUim(list, eOMKJmKrfMzLmEIH(list) - 1)).loc - JwyUEJOjBYuaQJCi(keylineState).loc;
        this.startShiftRange = f;
        float f2 = NEkLEmWtzWWfxSYC(keylineState).loc - oAyvPWbpzlGzUIeg((com.google.android.material.carousel.KeylineState) gFCqIapUVGqZpGDR(list2, LvNfDzTmLCrmeyTM(list2) - 1)).loc;
        this.endShiftRange = f2;
        this.startStateStepsInterpolationPoints = RgrwCZAbmLqddNBO(f, list, true);
        this.endStateStepsInterpolationPoints = yUIGvsHtpevMHzHk(f2, list2, false);
    }

    public static com.google.android.material.carousel.KeylineState AFWYuYbYIVGLAxEz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3) {
        return shiftKeylineStateForPadding(keylineState, f, f2, z, f3);
    }

    public static void AFWYuYbYIVGLAxEz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, float f4, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void AFWYuYbYIVGLAxEz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, short s, float f4, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void AFWYuYbYIVGLAxEz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, short s, bool z2, java.lang.string str, float f4) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline BGhstKBEuGQzwrQa(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void BGhstKBEuGQzwrQa(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BGhstKBEuGQzwrQa(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BGhstKBEuGQzwrQa(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline BKwMTchGlSQNtEVz(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void BKwMTchGlSQNtEVz(com.google.android.material.carousel.KeylineState keylineState, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BKwMTchGlSQNtEVz(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKwMTchGlSQNtEVz(com.google.android.material.carousel.KeylineState keylineState, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState BqJUAVnKMTCHxoua(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2) {
        return moveKeylineAndCreateKeylineState(keylineState, i, i2, f, i3, i4, f2);
    }

    public static void BqJUAVnKMTCHxoua(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, byte b, short s, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void BqJUAVnKMTCHxoua(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, float f3, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BqJUAVnKMTCHxoua(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, java.lang.string str, byte b, short s, float f3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder CUMFwxjGBMIeDpQu(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4) {
        return keylineState$Builder.addKeyline(f, f2, f3, z, z2, f4);
    }

    public static void CUMFwxjGBMIeDpQu(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, char c, float f5, bool z3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CUMFwxjGBMIeDpQu(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, short s, bool z3, float f5, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CUMFwxjGBMIeDpQu(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, bool z3, float f5, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DklnlGGUrWXbOBgi(com.google.android.material.carousel.Carousel carousel, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DklnlGGUrWXbOBgi(com.google.android.material.carousel.Carousel carousel, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DklnlGGUrWXbOBgi(com.google.android.material.carousel.Carousel carousel, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DklnlGGUrWXbOBgi(com.google.android.material.carousel.Carousel carousel) {
        return carousel.isHorizontal();
    }

    public static int ERuSFehIdSAqrPVr(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeylineIndex();
    }

    public static void ERuSFehIdSAqrPVr(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERuSFehIdSAqrPVr(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ERuSFehIdSAqrPVr(com.google.android.material.carousel.KeylineState keylineState, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int EsyKtCxNQDRldvIS(java.util.List list) {
        return list.Count;
    }

    public static void EsyKtCxNQDRldvIS(java.util.List list, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EsyKtCxNQDRldvIS(java.util.List list, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EsyKtCxNQDRldvIS(java.util.List list, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ExpKCiCDSVilzZOr(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void ExpKCiCDSVilzZOr(com.google.android.material.carousel.KeylineState keylineState, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ExpKCiCDSVilzZOr(com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ExpKCiCDSVilzZOr(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState FJkRGZWWNqKReVCX(java.util.List list, float f, float[] fArr) {
        return lerp(list, f, fArr);
    }

    public static void FJkRGZWWNqKReVCX(java.util.List list, float f, float[] fArr, byte b, int i, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void FJkRGZWWNqKReVCX(java.util.List list, float f, float[] fArr, int i, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FJkRGZWWNqKReVCX(java.util.List list, float f, float[] fArr, short s, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline FNDxjKgUPBzhCkvI(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void FNDxjKgUPBzhCkvI(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FNDxjKgUPBzhCkvI(com.google.android.material.carousel.KeylineState keylineState, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FNDxjKgUPBzhCkvI(com.google.android.material.carousel.KeylineState keylineState, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FrWdgATeJdMQQFRb(java.util.List list) {
        return list.Count;
    }

    public static void FrWdgATeJdMQQFRb(java.util.List list, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FrWdgATeJdMQQFRb(java.util.List list, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrWdgATeJdMQQFRb(java.util.List list, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List GGVBaQBqliQBZmZn(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void GGVBaQBqliQBZmZn(java.util.List list, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GGVBaQBqliQBZmZn(java.util.List list, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GGVBaQBqliQBZmZn(java.util.List list, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GKFkFbCSjDGORoLh(java.util.List list, int i) {
        return list[i);
    }

    public static void GKFkFbCSjDGORoLh(java.util.List list, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GKFkFbCSjDGORoLh(java.util.List list, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GKFkFbCSjDGORoLh(java.util.List list, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GVKpTOpnYPECYdkd(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeylineIndex();
    }

    public static void GVKpTOpnYPECYdkd(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GVKpTOpnYPECYdkd(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GVKpTOpnYPECYdkd(com.google.android.material.carousel.KeylineState keylineState, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List GpzeRUDtutcSlSyw(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void GpzeRUDtutcSlSyw(com.google.android.material.carousel.KeylineState keylineState, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GpzeRUDtutcSlSyw(com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GpzeRUDtutcSlSyw(com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState HfUBEiFdPKZRdDuq(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3) {
        return shiftKeylineStateForPadding(keylineState, f, f2, z, f3);
    }

    public static void HfUBEiFdPKZRdDuq(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, byte b, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HfUBEiFdPKZRdDuq(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, java.lang.string str, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HfUBEiFdPKZRdDuq(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, bool z2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HikAEsZUPgKvFvzY(com.google.android.material.carousel.Carousel carousel, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HikAEsZUPgKvFvzY(com.google.android.material.carousel.Carousel carousel, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HikAEsZUPgKvFvzY(com.google.android.material.carousel.Carousel carousel, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HikAEsZUPgKvFvzY(com.google.android.material.carousel.Carousel carousel) {
        return carousel.isHorizontal();
    }

    public static com.google.android.material.carousel.KeylineState$Keyline IAxbWoRWwlIXvopD(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void IAxbWoRWwlIXvopD(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IAxbWoRWwlIXvopD(com.google.android.material.carousel.KeylineState keylineState, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IAxbWoRWwlIXvopD(com.google.android.material.carousel.KeylineState keylineState, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ITRGNdWRtNJfMOvg(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void ITRGNdWRtNJfMOvg(float f, float f2, float f3, float f4, float f5, int i, char c, float f6, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ITRGNdWRtNJfMOvg(float f, float f2, float f3, float f4, float f5, int i, java.lang.string str, char c, float f6) {
        double d = (42 * 210) + 210;
    }

    public static void ITRGNdWRtNJfMOvg(float f, float f2, float f3, float f4, float f5, java.lang.string str, int i, char c, float f6) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IhxLJzyjKyCPgfqD(java.util.List list, int i) {
        return list[i);
    }

    public static void IhxLJzyjKyCPgfqD(java.util.List list, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IhxLJzyjKyCPgfqD(java.util.List list, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IhxLJzyjKyCPgfqD(java.util.List list, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JFEeMyTSVUsVJblo(java.util.List list, int i) {
        return list[i);
    }

    public static void JFEeMyTSVUsVJblo(java.util.List list, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JFEeMyTSVUsVJblo(java.util.List list, int i, float f, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JFEeMyTSVUsVJblo(java.util.List list, int i, int i2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List JVyYYsCJiUwyojfV(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void JVyYYsCJiUwyojfV(com.google.android.material.carousel.KeylineState keylineState, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JVyYYsCJiUwyojfV(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JVyYYsCJiUwyojfV(com.google.android.material.carousel.KeylineState keylineState, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JaaNMluueEPWgpPS(java.util.List list, int i) {
        return list[i);
    }

    public static void JaaNMluueEPWgpPS(java.util.List list, int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JaaNMluueEPWgpPS(java.util.List list, int i, bool z, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JaaNMluueEPWgpPS(java.util.List list, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JdtOiXfHTLEBOkql(java.util.List list, int i) {
        return list[i);
    }

    public static void JdtOiXfHTLEBOkql(java.util.List list, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JdtOiXfHTLEBOkql(java.util.List list, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JdtOiXfHTLEBOkql(java.util.List list, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline JnZXZmQYfeWtbJKT(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void JnZXZmQYfeWtbJKT(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JnZXZmQYfeWtbJKT(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JnZXZmQYfeWtbJKT(com.google.android.material.carousel.KeylineState keylineState, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline JwyUEJOjBYuaQJCi(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void JwyUEJOjBYuaQJCi(com.google.android.material.carousel.KeylineState keylineState, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JwyUEJOjBYuaQJCi(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwyUEJOjBYuaQJCi(com.google.android.material.carousel.KeylineState keylineState, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KxlIDIlmVtxQFuNi(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeylineIndex();
    }

    public static void KxlIDIlmVtxQFuNi(com.google.android.material.carousel.KeylineState keylineState, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KxlIDIlmVtxQFuNi(com.google.android.material.carousel.KeylineState keylineState, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KxlIDIlmVtxQFuNi(com.google.android.material.carousel.KeylineState keylineState, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder LTMcpdGFvfxayZAn(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6) {
        return keylineState$Builder.addKeyline(f, f2, f3, z, z2, f4, f5, f6);
    }

    public static void LTMcpdGFvfxayZAn(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6, byte b, bool z3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LTMcpdGFvfxayZAn(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6, short s, int i, byte b, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void LTMcpdGFvfxayZAn(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6, bool z3, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LYomjzAOzuJIMrnG(java.util.List list, int i) {
        return list[i);
    }

    public static void LYomjzAOzuJIMrnG(java.util.List list, int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LYomjzAOzuJIMrnG(java.util.List list, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LYomjzAOzuJIMrnG(java.util.List list, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LebnhZkeloFjEeIs(java.util.List list) {
        return list.Count;
    }

    public static void LebnhZkeloFjEeIs(java.util.List list, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LebnhZkeloFjEeIs(java.util.List list, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LebnhZkeloFjEeIs(java.util.List list, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LvNfDzTmLCrmeyTM(java.util.List list) {
        return list.Count;
    }

    public static void LvNfDzTmLCrmeyTM(java.util.List list, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LvNfDzTmLCrmeyTM(java.util.List list, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LvNfDzTmLCrmeyTM(java.util.List list, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState MKzCZuNMMAeDdyXT(com.google.android.material.carousel.KeylineState keylineState, float f, float f2) {
        return shiftKeylinesAndCreateKeylineState(keylineState, f, f2);
    }

    public static void MKzCZuNMMAeDdyXT(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MKzCZuNMMAeDdyXT(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MKzCZuNMMAeDdyXT(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline NEkLEmWtzWWfxSYC(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastKeyline();
    }

    public static void NEkLEmWtzWWfxSYC(com.google.android.material.carousel.KeylineState keylineState, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NEkLEmWtzWWfxSYC(com.google.android.material.carousel.KeylineState keylineState, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NEkLEmWtzWWfxSYC(com.google.android.material.carousel.KeylineState keylineState, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NKnnZfrPKREeRTRO(java.util.List list, java.lang.object obj, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NKnnZfrPKREeRTRO(java.util.List list, java.lang.object obj, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NKnnZfrPKREeRTRO(java.util.List list, java.lang.object obj, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NKnnZfrPKREeRTRO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List NjubljFJEofvviok(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void NjubljFJEofvviok(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NjubljFJEofvviok(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NjubljFJEofvviok(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NwwccBIKDwfkvKPb(com.google.android.material.carousel.Carousel carousel) {
        return carousel.getContainerHeight();
    }

    public static void NwwccBIKDwfkvKPb(com.google.android.material.carousel.Carousel carousel, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NwwccBIKDwfkvKPb(com.google.android.material.carousel.Carousel carousel, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NwwccBIKDwfkvKPb(com.google.android.material.carousel.Carousel carousel, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PyhVFaFyQaOtfLSz(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void PyhVFaFyQaOtfLSz(com.google.android.material.carousel.KeylineState keylineState, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PyhVFaFyQaOtfLSz(com.google.android.material.carousel.KeylineState keylineState, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyhVFaFyQaOtfLSz(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState QYUSKxBYkAmtHSgz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3) {
        return shiftKeylineStateForPadding(keylineState, f, f2, z, f3);
    }

    public static void QYUSKxBYkAmtHSgz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QYUSKxBYkAmtHSgz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QYUSKxBYkAmtHSgz(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState QcEbFXnGeFNJzEsJ(com.google.android.material.carousel.KeylineStateList keylineStateList, java.util.List list, float f, float[] fArr) {
        return keylineStateList.closestStateStepFromInterpolation(list, f, fArr);
    }

    public static void QcEbFXnGeFNJzEsJ(com.google.android.material.carousel.KeylineStateList keylineStateList, java.util.List list, float f, float[] fArr, float f2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QcEbFXnGeFNJzEsJ(com.google.android.material.carousel.KeylineStateList keylineStateList, java.util.List list, float f, float[] fArr, float f2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QcEbFXnGeFNJzEsJ(com.google.android.material.carousel.KeylineStateList keylineStateList, java.util.List list, float f, float[] fArr, java.lang.string str, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int QjNmKdhbHPWnGXnv(com.google.android.material.carousel.Carousel carousel) {
        return carousel.getContainerWidth();
    }

    public static void QjNmKdhbHPWnGXnv(com.google.android.material.carousel.Carousel carousel, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QjNmKdhbHPWnGXnv(com.google.android.material.carousel.Carousel carousel, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QjNmKdhbHPWnGXnv(com.google.android.material.carousel.Carousel carousel, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RgrwCZAbmLqddNBO(float f, java.util.List list, bool z, int i, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void RgrwCZAbmLqddNBO(float f, java.util.List list, bool z, int i, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RgrwCZAbmLqddNBO(float f, java.util.List list, bool z, bool z2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float[] RgrwCZAbmLqddNBO(float f, java.util.List list, bool z) {
        return getStateStepInterpolationPoints(f, list, z);
    }

    public static int RibRgBOVnEfYWBwC(com.google.android.material.carousel.KeylineState keylineState, float f) {
        return findFirstIndexAfterLastFocalKeylineWithMask(keylineState, f);
    }

    public static void RibRgBOVnEfYWBwC(com.google.android.material.carousel.KeylineState keylineState, float f, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RibRgBOVnEfYWBwC(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RibRgBOVnEfYWBwC(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RpJsiBcAcPPgVyPu(java.util.List list, java.lang.object obj, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RpJsiBcAcPPgVyPu(java.util.List list, java.lang.object obj, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RpJsiBcAcPPgVyPu(java.util.List list, java.lang.object obj, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RpJsiBcAcPPgVyPu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.material.carousel.KeylineState ShFhGusawWMbCbFx(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3) {
        return shiftKeylineStateForPadding(keylineState, f, f2, z, f3);
    }

    public static void ShFhGusawWMbCbFx(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, char c, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ShFhGusawWMbCbFx(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, char c, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ShFhGusawWMbCbFx(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, char c, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline SwrhpdTCMjOriqMz(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void SwrhpdTCMjOriqMz(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SwrhpdTCMjOriqMz(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SwrhpdTCMjOriqMz(com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline THJIPXrmWnZVjyXN(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstNonAnchorKeyline();
    }

    public static void THJIPXrmWnZVjyXN(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void THJIPXrmWnZVjyXN(com.google.android.material.carousel.KeylineState keylineState, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void THJIPXrmWnZVjyXN(com.google.android.material.carousel.KeylineState keylineState, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline TREajgGgLcQKOKiA(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void TREajgGgLcQKOKiA(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TREajgGgLcQKOKiA(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TREajgGgLcQKOKiA(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float TfBQaIdgdpIexnQw(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void TfBQaIdgdpIexnQw(com.google.android.material.carousel.KeylineState keylineState, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TfBQaIdgdpIexnQw(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TfBQaIdgdpIexnQw(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline TgLCFHUDRSnxgvDy(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void TgLCFHUDRSnxgvDy(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TgLCFHUDRSnxgvDy(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TgLCFHUDRSnxgvDy(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List TtFacVrTMAhINwym(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void TtFacVrTMAhINwym(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TtFacVrTMAhINwym(com.google.android.material.carousel.KeylineState keylineState, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TtFacVrTMAhINwym(com.google.android.material.carousel.KeylineState keylineState, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TvtUIXejjUIyOwev(java.util.List list) {
        return list.Count;
    }

    public static void TvtUIXejjUIyOwev(java.util.List list, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TvtUIXejjUIyOwev(java.util.List list, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TvtUIXejjUIyOwev(java.util.List list, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UByYvPcvdzGeAuBv(java.util.List list) {
        return list.Count;
    }

    public static void UByYvPcvdzGeAuBv(java.util.List list, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UByYvPcvdzGeAuBv(java.util.List list, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UByYvPcvdzGeAuBv(java.util.List list, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UKGzpihMjHAoRDUk(java.util.List list, int i) {
        return list[i);
    }

    public static void UKGzpihMjHAoRDUk(java.util.List list, int i, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UKGzpihMjHAoRDUk(java.util.List list, int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UKGzpihMjHAoRDUk(java.util.List list, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UKvrXCPlzjHzKdXa(com.google.android.material.carousel.Carousel carousel) {
        return carousel.getContainerWidth();
    }

    public static void UKvrXCPlzjHzKdXa(com.google.android.material.carousel.Carousel carousel, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UKvrXCPlzjHzKdXa(com.google.android.material.carousel.Carousel carousel, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UKvrXCPlzjHzKdXa(com.google.android.material.carousel.Carousel carousel, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UYgQikVVzHxSPdML(java.util.List list, int i) {
        return list[i);
    }

    public static void UYgQikVVzHxSPdML(java.util.List list, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYgQikVVzHxSPdML(java.util.List list, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYgQikVVzHxSPdML(java.util.List list, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder UnDdwvWkulnhUJLr(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4) {
        return keylineState$Builder.addKeyline(f, f2, f3, z, z2, f4);
    }

    public static void UnDdwvWkulnhUJLr(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, char c, java.lang.string str, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void UnDdwvWkulnhUJLr(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, java.lang.string str, char c, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void UnDdwvWkulnhUJLr(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, java.lang.string str, char c, float f5, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static int UpIHQrJDhdrBQnrZ(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void UpIHQrJDhdrBQnrZ(int i, int i2, int i3, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpIHQrJDhdrBQnrZ(int i, int i2, int i3, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UpIHQrJDhdrBQnrZ(int i, int i2, int i3, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int UsiCnpMnnohFgQte(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void UsiCnpMnnohFgQte(int i, int i2, int i3, int i4, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UsiCnpMnnohFgQte(int i, int i2, int i3, java.lang.string str, int i4, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UsiCnpMnnohFgQte(int i, int i2, int i3, bool z, int i4, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline UuzYgRWXNkoAVzrq(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void UuzYgRWXNkoAVzrq(com.google.android.material.carousel.KeylineState keylineState, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UuzYgRWXNkoAVzrq(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UuzYgRWXNkoAVzrq(com.google.android.material.carousel.KeylineState keylineState, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline VPWbRdLUGGjhuZHM(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void VPWbRdLUGGjhuZHM(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VPWbRdLUGGjhuZHM(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPWbRdLUGGjhuZHM(com.google.android.material.carousel.KeylineState keylineState, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VXZSUpzkCmpcGobE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void VXZSUpzkCmpcGobE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VXZSUpzkCmpcGobE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VXZSUpzkCmpcGobE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List VYBmzUyLoKDbGwro(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void VYBmzUyLoKDbGwro(com.google.android.material.carousel.KeylineState keylineState, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYBmzUyLoKDbGwro(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VYBmzUyLoKDbGwro(com.google.android.material.carousel.KeylineState keylineState, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VpibQAsbZslKxSVM(java.util.List list) {
        return list.Count;
    }

    public static void VpibQAsbZslKxSVM(java.util.List list, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VpibQAsbZslKxSVM(java.util.List list, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VpibQAsbZslKxSVM(java.util.List list, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WTadIJJnnsKPlDPW(java.util.List list, int i) {
        return list[i);
    }

    public static void WTadIJJnnsKPlDPW(java.util.List list, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WTadIJJnnsKPlDPW(java.util.List list, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WTadIJJnnsKPlDPW(java.util.List list, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline WUCdJzyHVrXtkbAv(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void WUCdJzyHVrXtkbAv(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WUCdJzyHVrXtkbAv(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WUCdJzyHVrXtkbAv(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WbdhKPbbbiQDSCsQ(java.util.List list, int i) {
        return list[i);
    }

    public static void WbdhKPbbbiQDSCsQ(java.util.List list, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WbdhKPbbbiQDSCsQ(java.util.List list, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WbdhKPbbbiQDSCsQ(java.util.List list, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WuEvSxcORlEbryvr(java.util.List list, java.lang.object obj, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuEvSxcORlEbryvr(java.util.List list, java.lang.object obj, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WuEvSxcORlEbryvr(java.util.List list, java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WuEvSxcORlEbryvr(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object XKdcxXIYQvRdGPqc(java.util.List list, int i) {
        return list[i);
    }

    public static void XKdcxXIYQvRdGPqc(java.util.List list, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKdcxXIYQvRdGPqc(java.util.List list, int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XKdcxXIYQvRdGPqc(java.util.List list, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState XjLwgQKSNjNtYwcp(com.google.android.material.carousel.KeylineState keylineState, float f, float f2) {
        return shiftKeylinesAndCreateKeylineState(keylineState, f, f2);
    }

    public static void XjLwgQKSNjNtYwcp(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjLwgQKSNjNtYwcp(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XjLwgQKSNjNtYwcp(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline XqmJqXpEAVtnmdQM(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void XqmJqXpEAVtnmdQM(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XqmJqXpEAVtnmdQM(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XqmJqXpEAVtnmdQM(com.google.android.material.carousel.KeylineState keylineState, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List YVnapzshwKrLirEz(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void YVnapzshwKrLirEz(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YVnapzshwKrLirEz(com.google.android.material.carousel.KeylineState keylineState, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YVnapzshwKrLirEz(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YknnBVYaUmEANUwN(java.util.List list, int i) {
        return list[i);
    }

    public static void YknnBVYaUmEANUwN(java.util.List list, int i, int i2, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YknnBVYaUmEANUwN(java.util.List list, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YknnBVYaUmEANUwN(java.util.List list, int i, java.lang.string str, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YrapyWAarcUwUWwf(com.google.android.material.carousel.KeylineState keylineState) {
        return findLastNonAnchorKeylineIndex(keylineState);
    }

    public static void YrapyWAarcUwUWwf(com.google.android.material.carousel.KeylineState keylineState, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrapyWAarcUwUWwf(com.google.android.material.carousel.KeylineState keylineState, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YrapyWAarcUwUWwf(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline ZExsGAsRfrUPYIJt(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void ZExsGAsRfrUPYIJt(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZExsGAsRfrUPYIJt(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZExsGAsRfrUPYIJt(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZvPkAHfeYgxGiqtG(java.util.List list, int i) {
        return list[i);
    }

    public static void ZvPkAHfeYgxGiqtG(java.util.List list, int i, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZvPkAHfeYgxGiqtG(java.util.List list, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZvPkAHfeYgxGiqtG(java.util.List list, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int AJehrmkYbRbDIKef(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeylineIndex();
    }

    public static void AJehrmkYbRbDIKef(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AJehrmkYbRbDIKef(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AJehrmkYbRbDIKef(com.google.android.material.carousel.KeylineState keylineState, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static float AxqKDWMEvkRsPSJC(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void AxqKDWMEvkRsPSJC(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AxqKDWMEvkRsPSJC(com.google.android.material.carousel.KeylineState keylineState, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AxqKDWMEvkRsPSJC(com.google.android.material.carousel.KeylineState keylineState, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BJZYkJnaliCqFaXF(java.util.List list, java.lang.object obj, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BJZYkJnaliCqFaXF(java.util.List list, java.lang.object obj, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BJZYkJnaliCqFaXF(java.util.List list, java.lang.object obj, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BJZYkJnaliCqFaXF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.material.carousel.KeylineState BNwVlQfQIovPZNNa(com.google.android.material.carousel.KeylineState keylineState, com.google.android.material.carousel.KeylineState keylineState2, float f) {
        return com.google.android.material.carousel.KeylineState.lerp(keylineState, keylineState2, f);
    }

    public static void BNwVlQfQIovPZNNa(com.google.android.material.carousel.KeylineState keylineState, com.google.android.material.carousel.KeylineState keylineState2, float f, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BNwVlQfQIovPZNNa(com.google.android.material.carousel.KeylineState keylineState, com.google.android.material.carousel.KeylineState keylineState2, float f, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BNwVlQfQIovPZNNa(com.google.android.material.carousel.KeylineState keylineState, com.google.android.material.carousel.KeylineState keylineState2, float f, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BVGVdqJZBoVuutVf(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getNumberOfNonAnchorKeylines();
    }

    public static void BVGVdqJZBoVuutVf(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BVGVdqJZBoVuutVf(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BVGVdqJZBoVuutVf(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float BxUoUSlEXmMAjion(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void BxUoUSlEXmMAjion(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxUoUSlEXmMAjion(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxUoUSlEXmMAjion(com.google.android.material.carousel.KeylineState keylineState, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState CCiBrTPEPqGnmUIW(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2) {
        return moveKeylineAndCreateKeylineState(keylineState, i, i2, f, i3, i4, f2);
    }

    public static void CCiBrTPEPqGnmUIW(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, byte b, java.lang.string str, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CCiBrTPEPqGnmUIW(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, byte b, bool z, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CCiBrTPEPqGnmUIW(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, bool z, java.lang.string str, byte b, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void CMFeZnJoRXkocqNr(com.google.android.material.carousel.Carousel carousel, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CMFeZnJoRXkocqNr(com.google.android.material.carousel.Carousel carousel, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CMFeZnJoRXkocqNr(com.google.android.material.carousel.Carousel carousel, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CMFeZnJoRXkocqNr(com.google.android.material.carousel.Carousel carousel) {
        return carousel.isHorizontal();
    }

    public static com.google.android.material.carousel.KeylineState$Keyline cQwzCWKZWPFgluKx(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void CQwzCWKZWPFgluKx(com.google.android.material.carousel.KeylineState keylineState, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CQwzCWKZWPFgluKx(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CQwzCWKZWPFgluKx(com.google.android.material.carousel.KeylineState keylineState, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline cbnqgtuXuMtyGqyf(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastKeyline();
    }

    public static void CbnqgtuXuMtyGqyf(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CbnqgtuXuMtyGqyf(com.google.android.material.carousel.KeylineState keylineState, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CbnqgtuXuMtyGqyf(com.google.android.material.carousel.KeylineState keylineState, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.carousel.KeylineState ClosestStateStepFromInterpolation(java.util.List<com.google.android.material.carousel.KeylineState> list, float f, float[] fArr) {
        float[] fArrVPdtLtwuHlueZCNy = vPdtLtwuHlueZCNy(list, f, fArr);
        return fArrVPdtLtwuHlueZCNy[0] < 0.5f ? (com.google.android.material.carousel.KeylineState) UYgQikVVzHxSPdML(list, (int) fArrVPdtLtwuHlueZCNy[1]) : (com.google.android.material.carousel.KeylineState) XKdcxXIYQvRdGPqc(list, (int) fArrVPdtLtwuHlueZCNy[2]);
    }

    private void ClosestStateStepFromInterpolation(java.util.List list, float f, float[] fArr, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ClosestStateStepFromInterpolation(java.util.List list, float f, float[] fArr, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ClosestStateStepFromInterpolation(java.util.List list, float f, float[] fArr, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState CxEoIHKbRSGcUyMs(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getEndState();
    }

    public static void CxEoIHKbRSGcUyMs(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CxEoIHKbRSGcUyMs(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CxEoIHKbRSGcUyMs(com.google.android.material.carousel.KeylineStateList keylineStateList, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EHkVvGkVuXQobVde(java.util.List list, java.lang.object obj, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EHkVvGkVuXQobVde(java.util.List list, java.lang.object obj, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EHkVvGkVuXQobVde(java.util.List list, java.lang.object obj, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EHkVvGkVuXQobVde(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int EOMKJmKrfMzLmEIH(java.util.List list) {
        return list.Count;
    }

    public static void EOMKJmKrfMzLmEIH(java.util.List list, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EOMKJmKrfMzLmEIH(java.util.List list, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EOMKJmKrfMzLmEIH(java.util.List list, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EUgWoUbOehPuaCYr(java.util.List list) {
        return list.Count;
    }

    public static void EUgWoUbOehPuaCYr(java.util.List list, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUgWoUbOehPuaCYr(java.util.List list, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EUgWoUbOehPuaCYr(java.util.List list, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List EoNIGbYIXJtjeJEg(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void EoNIGbYIXJtjeJEg(com.google.android.material.carousel.KeylineState keylineState, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EoNIGbYIXJtjeJEg(com.google.android.material.carousel.KeylineState keylineState, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EoNIGbYIXJtjeJEg(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EooSwBGFPpKqDBFC(java.util.List list) {
        return list.Count;
    }

    public static void EooSwBGFPpKqDBFC(java.util.List list, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EooSwBGFPpKqDBFC(java.util.List list, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EooSwBGFPpKqDBFC(java.util.List list, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ExcFHvmEOspLOaUo(java.util.List list, java.lang.object obj, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ExcFHvmEOspLOaUo(java.util.List list, java.lang.object obj, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ExcFHvmEOspLOaUo(java.util.List list, java.lang.object obj, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ExcFHvmEOspLOaUo(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int FLvHKMWZevOsqloz(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeylineIndex();
    }

    public static void FLvHKMWZevOsqloz(com.google.android.material.carousel.KeylineState keylineState, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FLvHKMWZevOsqloz(com.google.android.material.carousel.KeylineState keylineState, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLvHKMWZevOsqloz(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FhqwontnbPZTSeVS(com.google.android.material.carousel.Carousel carousel) {
        return carousel.getContainerWidth();
    }

    public static void FhqwontnbPZTSeVS(com.google.android.material.carousel.Carousel carousel, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhqwontnbPZTSeVS(com.google.android.material.carousel.Carousel carousel, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FhqwontnbPZTSeVS(com.google.android.material.carousel.Carousel carousel, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static int FindFirstIndexAfterLastFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f) {
        if ((31 + 11) % 11 > 0) {
        }
        for (int iKxlIDIlmVtxQFuNi = KxlIDIlmVtxQFuNi(keylineState); iKxlIDIlmVtxQFuNi < ymyNFzAoMeAquwrv(xhVoPDjClIIONZLA(keylineState)); iKxlIDIlmVtxQFuNi++) {
            if (f == ((com.google.android.material.carousel.KeylineState$Keyline) fmnOCwfkeSyrsAiX(zBCbmVqnuzInVszB(keylineState), iKxlIDIlmVtxQFuNi)).mask) {
                return iKxlIDIlmVtxQFuNi;
            }
        }
        return naqhhXsWKCTwqHMC(YVnapzshwKrLirEz(keylineState)) - 1;
    }

    private static void FindFirstIndexAfterLastFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void FindFirstIndexAfterLastFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void FindFirstIndexAfterLastFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private static int FindFirstNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState) {
        if ((8 + 10) % 10 > 0) {
        }
        for (int i = 0; i < LebnhZkeloFjEeIs(jJWvOgFcsDnMEsBt(keylineState)); i++) {
            if (!((com.google.android.material.carousel.KeylineState$Keyline) jbjqFqonNpLLVqqQ(TtFacVrTMAhINwym(keylineState), i)).isAnchor) {
                return i;
            }
        }
        return -1;
    }

    private static void FindFirstNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static void FindFirstNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void FindFirstNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static int FindLastIndexBeforeFirstFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f) {
        if ((16 + 13) % 13 > 0) {
        }
        for (int iGVKpTOpnYPECYdkd = GVKpTOpnYPECYdkd(keylineState) - 1; iGVKpTOpnYPECYdkd >= 0; iGVKpTOpnYPECYdkd--) {
            if (f == ((com.google.android.material.carousel.KeylineState$Keyline) JdtOiXfHTLEBOkql(pTRXflFjaLBvSXpG(keylineState), iGVKpTOpnYPECYdkd)).mask) {
                return iGVKpTOpnYPECYdkd;
            }
        }
        return 0;
    }

    private static void FindLastIndexBeforeFirstFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f, char c, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private static void FindLastIndexBeforeFirstFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f, char c, int i, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    private static void FindLastIndexBeforeFirstFocalKeylineWithMask(com.google.android.material.carousel.KeylineState keylineState, float f, short s, int i, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    private static int FindLastNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState) {
        if ((20 + 15) % 15 > 0) {
        }
        for (int iMgEotpfqcAaObaOZ = mgEotpfqcAaObaOZ(jdYGUzMqVrPPXaGw(keylineState)) - 1; iMgEotpfqcAaObaOZ >= 0; iMgEotpfqcAaObaOZ--) {
            if (!((com.google.android.material.carousel.KeylineState$Keyline) uXqBxlqvxElJvpbT(eoNIGbYIXJtjeJEg(keylineState), iMgEotpfqcAaObaOZ)).isAnchor) {
                return iMgEotpfqcAaObaOZ;
            }
        }
        return -1;
    }

    private static void FindLastNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void FindLastNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static void FindLastNonAnchorKeylineIndex(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FmnOCwfkeSyrsAiX(java.util.List list, int i) {
        return list[i);
    }

    public static void FmnOCwfkeSyrsAiX(java.util.List list, int i, char c, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FmnOCwfkeSyrsAiX(java.util.List list, int i, char c, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FmnOCwfkeSyrsAiX(java.util.List list, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List FnpcKVFDhxLxHYwT(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void FnpcKVFDhxLxHYwT(java.util.List list, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnpcKVFDhxLxHYwT(java.util.List list, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FnpcKVFDhxLxHYwT(java.util.List list, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.carousel.KeylineStateList From(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3) {
        return new com.google.android.material.carousel.KeylineStateList(keylineState, ibtJolLjjMvHBknP(carousel, keylineState, f, f2), hOlJDFPAtxvLstPp(carousel, keylineState, f, f3));
    }

    static void From(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3, char c, java.lang.string str, short s, float f4) {
        double d = (42 * 210) + 210;
    }

    static void From(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3, java.lang.string str, char c, float f4, short s) {
        double d = (42 * 210) + 210;
    }

    static void From(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3, short s, java.lang.string str, char c, float f4) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GABFVUmiVyEoBhME(java.util.List list, int i) {
        return list[i);
    }

    public static void GABFVUmiVyEoBhME(java.util.List list, int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GABFVUmiVyEoBhME(java.util.List list, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GABFVUmiVyEoBhME(java.util.List list, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GFCqIapUVGqZpGDR(java.util.List list, int i) {
        return list[i);
    }

    public static void GFCqIapUVGqZpGDR(java.util.List list, int i, char c, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GFCqIapUVGqZpGDR(java.util.List list, int i, float f, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GFCqIapUVGqZpGDR(java.util.List list, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepInterpolationPoints(float f, java.util.List list, bool z, byte b, int i, float f2, bool z2) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepInterpolationPoints(float f, java.util.List list, bool z, int i, bool z2, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepInterpolationPoints(float f, java.util.List list, bool z, bool z2, float f2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private static float[] GetStateStepInterpolationPoints(float f, java.util.List<com.google.android.material.carousel.KeylineState> list, bool z) {
        if ((23 + 4) % 4 > 0) {
        }
        int iPSrnmbDIZnNcmDne = pSrnmbDIZnNcmDne(list);
        float[] fArr = new float[iPSrnmbDIZnNcmDne];
        int i = 1;
        while (i < iPSrnmbDIZnNcmDne) {
            int i2 = i - 1;
            com.google.android.material.carousel.KeylineState keylineState = (com.google.android.material.carousel.KeylineState) ZvPkAHfeYgxGiqtG(list, i2);
            com.google.android.material.carousel.KeylineState keylineState2 = (com.google.android.material.carousel.KeylineState) kFmcEMQzsQOjIjHN(list, i);
            fArr[i] = i != iPSrnmbDIZnNcmDne + (-1) ? fArr[i2] + ((!z ? cbnqgtuXuMtyGqyf(keylineState).loc - jnshBIyuLaOLwdFB(keylineState2).loc : uvciewvkmAbDirdz(keylineState2).loc - JnZXZmQYfeWtbJKT(keylineState).loc) / f) : 1.0f;
            i++;
        }
        return fArr;
    }

    private static java.util.List<com.google.android.material.carousel.KeylineState> GetStateStepsEnd(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2) {
        if ((29 + 5) % 5 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        hEAtBfPRtaLnubVZ(arrayList, keylineState);
        int iYrapyWAarcUwUWwf = YrapyWAarcUwUWwf(keylineState);
        float fTxDUxKNwJHBskDGm = !cMFeZnJoRXkocqNr(carousel) ? txDUxKNwJHBskDGm(carousel) : fhqwontnbPZTSeVS(carousel);
        if (!yXDuOnSudQkPvArB(carousel, keylineState) && iYrapyWAarcUwUWwf != -1) {
            int iNaYjfODcUyClEKDA = iYrapyWAarcUwUWwf - naYjfODcUyClEKDA(keylineState);
            float f3 = SwrhpdTCMjOriqMz(keylineState).locOffset - (IAxbWoRWwlIXvopD(keylineState).maskedItemSize / 2.0f);
            if (iNaYjfODcUyClEKDA <= 0 && BGhstKBEuGQzwrQa(keylineState).cutoff > 0.0f) {
                WuEvSxcORlEbryvr(arrayList, MKzCZuNMMAeDdyXT(keylineState, f3 - VPWbRdLUGGjhuZHM(keylineState).cutoff, fTxDUxKNwJHBskDGm));
                return arrayList;
            }
            int i = 0;
            float f4 = 0.0f;
            while (i < iNaYjfODcUyClEKDA) {
                com.google.android.material.carousel.KeylineState keylineState2 = (com.google.android.material.carousel.KeylineState) YknnBVYaUmEANUwN(arrayList, EsyKtCxNQDRldvIS(arrayList) - 1);
                int i2 = iYrapyWAarcUwUWwf - i;
                float f5 = f4 + ((com.google.android.material.carousel.KeylineState$Keyline) gABFVUmiVyEoBhME(PyhVFaFyQaOtfLSz(keylineState), i2)).cutoff;
                int i3 = i2 + 1;
                com.google.android.material.carousel.KeylineState keylineStateRzVIjyJeSOdtzgSh = rzVIjyJeSOdtzgSh(keylineState2, iYrapyWAarcUwUWwf, i3 >= mOVTmsdyKymxnilJ(GpzeRUDtutcSlSyw(keylineState)) ? 0 : mLnvUPOjPSnvSpIi(keylineState2, ((com.google.android.material.carousel.KeylineState$Keyline) lIqxoLzLlmIUCmoF(JVyYYsCJiUwyojfV(keylineState), i3)).mask) + 1, f3 - f5, pEHXkylflezLAHNR(keylineState) + i + 1, ERuSFehIdSAqrPVr(keylineState) + i + 1, fTxDUxKNwJHBskDGm);
                if (i == iNaYjfODcUyClEKDA - 1 && f2 > 0.0f) {
                    keylineStateRzVIjyJeSOdtzgSh = HfUBEiFdPKZRdDuq(keylineStateRzVIjyJeSOdtzgSh, f2, fTxDUxKNwJHBskDGm, false, f);
                }
                eHkVvGkVuXQobVde(arrayList, keylineStateRzVIjyJeSOdtzgSh);
                i++;
                f4 = f5;
            }
        } else if (f2 > 0.0f) {
            NKnnZfrPKREeRTRO(arrayList, AFWYuYbYIVGLAxEz(keylineState, f2, fTxDUxKNwJHBskDGm, false, f));
        }
        return arrayList;
    }

    private static void GetStateStepsEnd(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepsEnd(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepsEnd(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepsRange(java.util.List list, float f, float[] fArr, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepsRange(java.util.List list, float f, float[] fArr, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepsRange(java.util.List list, float f, float[] fArr, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static float[] GetStateStepsRange(java.util.List<com.google.android.material.carousel.KeylineState> list, float f, float[] fArr) {
        if ((23 + 5) % 5 > 0) {
        }
        int iFrWdgATeJdMQQFRb = FrWdgATeJdMQQFRb(list);
        float f2 = fArr[0];
        int i = 1;
        while (i < iFrWdgATeJdMQQFRb) {
            float f3 = fArr[i];
            if (f <= f3) {
                int i2 = i - 1;
                float fILoprXsIUZxjfosx = iLoprXsIUZxjfosx(0.0f, 1.0f, f2, f3, f);
                float f4 = i2;
                float f5 = i;
                float[] fArr2 = new float[3];
                fArr2[0] = fILoprXsIUZxjfosx;
                fArr2[1] = f4;
                fArr2[2] = f5;
                return fArr2;
            }
            i++;
            f2 = f3;
        }
        return new float[]{0.0f, 0.0f, 0.0f};
    }

    private static java.util.List<com.google.android.material.carousel.KeylineState> GetStateStepsStart(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2) {
        if ((27 + 19) % 19 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        RpJsiBcAcPPgVyPu(arrayList, keylineState);
        int iGhXQdcucKlNxEBCA = ghXQdcucKlNxEBCA(keylineState);
        float fSMBAmsVMRGUCmHCj = !DklnlGGUrWXbOBgi(carousel) ? sMBAmsVMRGUCmHCj(carousel) : QjNmKdhbHPWnGXnv(carousel);
        if (!yXiBQRefQEeXIYQV(keylineState) && iGhXQdcucKlNxEBCA != -1) {
            int iAJehrmkYbRbDIKef = aJehrmkYbRbDIKef(keylineState) - iGhXQdcucKlNxEBCA;
            float f3 = UuzYgRWXNkoAVzrq(keylineState).locOffset - (BKwMTchGlSQNtEVz(keylineState).maskedItemSize / 2.0f);
            if (iAJehrmkYbRbDIKef <= 0 && sCpnlrkyXFFMojBn(keylineState).cutoff > 0.0f) {
                bJZYkJnaliCqFaXF(arrayList, XjLwgQKSNjNtYwcp(keylineState, f3 + FNDxjKgUPBzhCkvI(keylineState).cutoff, fSMBAmsVMRGUCmHCj));
                return arrayList;
            }
            int i = 0;
            float f4 = 0.0f;
            while (i < iAJehrmkYbRbDIKef) {
                com.google.android.material.carousel.KeylineState keylineState2 = (com.google.android.material.carousel.KeylineState) sbvcFVvXbBYRvNaz(arrayList, UByYvPcvdzGeAuBv(arrayList) - 1);
                int i2 = iGhXQdcucKlNxEBCA + i;
                int iRtVZkOkpUJmNgRNC = rtVZkOkpUJmNgRNC(VYBmzUyLoKDbGwro(keylineState)) - 1;
                float f5 = f4 + ((com.google.android.material.carousel.KeylineState$Keyline) IhxLJzyjKyCPgfqD(NjubljFJEofvviok(keylineState), i2)).cutoff;
                int i3 = i2 - 1;
                if (i3 >= 0) {
                    iRtVZkOkpUJmNgRNC = RibRgBOVnEfYWBwC(keylineState2, ((com.google.android.material.carousel.KeylineState$Keyline) WTadIJJnnsKPlDPW(lELAZrhIecaqsyuk(keylineState), i3)).mask) - 1;
                }
                com.google.android.material.carousel.KeylineState keylineStateCCiBrTPEPqGnmUIW = cCiBrTPEPqGnmUIW(keylineState2, iGhXQdcucKlNxEBCA, iRtVZkOkpUJmNgRNC, f3 + f5, (rRnSbcEPylQFsDyz(keylineState) - i) - 1, (xEkcWRhrGvdFZvvY(keylineState) - i) - 1, fSMBAmsVMRGUCmHCj);
                if (i == iAJehrmkYbRbDIKef - 1 && f2 > 0.0f) {
                    keylineStateCCiBrTPEPqGnmUIW = ShFhGusawWMbCbFx(keylineStateCCiBrTPEPqGnmUIW, f2, fSMBAmsVMRGUCmHCj, true, f);
                }
                excFHvmEOspLOaUo(arrayList, keylineStateCCiBrTPEPqGnmUIW);
                i++;
                f4 = f5;
            }
        } else if (f2 > 0.0f) {
            jIYARnXLJRwtWeKi(arrayList, QYUSKxBYkAmtHSgz(keylineState, f2, fSMBAmsVMRGUCmHCj, true, f));
        }
        return arrayList;
    }

    private static void GetStateStepsStart(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepsStart(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateStepsStart(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, short s, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GhXQdcucKlNxEBCA(com.google.android.material.carousel.KeylineState keylineState) {
        return findFirstNonAnchorKeylineIndex(keylineState);
    }

    public static void GhXQdcucKlNxEBCA(com.google.android.material.carousel.KeylineState keylineState, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GhXQdcucKlNxEBCA(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GhXQdcucKlNxEBCA(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HEAtBfPRtaLnubVZ(java.util.List list, java.lang.object obj, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HEAtBfPRtaLnubVZ(java.util.List list, java.lang.object obj, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HEAtBfPRtaLnubVZ(java.util.List list, java.lang.object obj, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HEAtBfPRtaLnubVZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List HKDVZQQHWSMEsxjM(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void HKDVZQQHWSMEsxjM(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HKDVZQQHWSMEsxjM(com.google.android.material.carousel.KeylineState keylineState, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HKDVZQQHWSMEsxjM(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List HOlJDFPAtxvLstPp(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2) {
        return getStateStepsEnd(carousel, keylineState, f, f2);
    }

    public static void HOlJDFPAtxvLstPp(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HOlJDFPAtxvLstPp(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HOlJDFPAtxvLstPp(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IIpRDBaRGmukLJQR(java.util.List list, float f, float[] fArr, int i, char c, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IIpRDBaRGmukLJQR(java.util.List list, float f, float[] fArr, int i, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IIpRDBaRGmukLJQR(java.util.List list, float f, float[] fArr, short s, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float[] IIpRDBaRGmukLJQR(java.util.List list, float f, float[] fArr) {
        return getStateStepsRange(list, f, fArr);
    }

    public static float ILoprXsIUZxjfosx(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void ILoprXsIUZxjfosx(float f, float f2, float f3, float f4, float f5, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILoprXsIUZxjfosx(float f, float f2, float f3, float f4, float f5, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ILoprXsIUZxjfosx(float f, float f2, float f3, float f4, float f5, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List IbtJolLjjMvHBknP(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2) {
        return getStateStepsStart(carousel, keylineState, f, f2);
    }

    public static void IbtJolLjjMvHBknP(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, char c, bool z, int i, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void IbtJolLjjMvHBknP(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, int i, float f3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IbtJolLjjMvHBknP(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, int i, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int IpjpRHHeZRyPioiX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IpjpRHHeZRyPioiX(int i, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IpjpRHHeZRyPioiX(int i, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IpjpRHHeZRyPioiX(int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void IsFirstFocalItemAtLeftOfContainer(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void IsFirstFocalItemAtLeftOfContainer(com.google.android.material.carousel.KeylineState keylineState, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void IsFirstFocalItemAtLeftOfContainer(com.google.android.material.carousel.KeylineState keylineState, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private static bool IsFirstFocalItemAtLeftOfContainer(com.google.android.material.carousel.KeylineState keylineState) {
        if ((17 + 7) % 7 > 0) {
        }
        return ZExsGAsRfrUPYIJt(keylineState).locOffset - (wKpbdsVmVvRJdGjV(keylineState).maskedItemSize / 2.0f) >= 0.0f && nhmVmBStCgbPVSsH(keylineState) == THJIPXrmWnZVjyXN(keylineState);
    }

    private static void IsLastFocalItemVisibleAtRightOfContainer(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private static void IsLastFocalItemVisibleAtRightOfContainer(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void IsLastFocalItemVisibleAtRightOfContainer(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static bool IsLastFocalItemVisibleAtRightOfContainer(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState) {
        if ((8 + 16) % 16 > 0) {
        }
        int iNwwccBIKDwfkvKPb = NwwccBIKDwfkvKPb(carousel);
        if (HikAEsZUPgKvFvzY(carousel)) {
            iNwwccBIKDwfkvKPb = UKvrXCPlzjHzKdXa(carousel);
        }
        return uMVSCXBchGBdNHHC(keylineState).locOffset + (TREajgGgLcQKOKiA(keylineState).maskedItemSize / 2.0f) <= ((float) iNwwccBIKDwfkvKPb) && cQwzCWKZWPFgluKx(keylineState) == ncRjghVfDlraHnTg(keylineState);
    }

    public static com.google.android.material.carousel.KeylineState IxgOArZAgSacIyXY(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder) {
        return keylineState$Builder.build();
    }

    public static void IxgOArZAgSacIyXY(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IxgOArZAgSacIyXY(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxgOArZAgSacIyXY(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JIYARnXLJRwtWeKi(java.util.List list, java.lang.object obj, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JIYARnXLJRwtWeKi(java.util.List list, java.lang.object obj, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JIYARnXLJRwtWeKi(java.util.List list, java.lang.object obj, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JIYARnXLJRwtWeKi(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List JJWvOgFcsDnMEsBt(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void JJWvOgFcsDnMEsBt(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JJWvOgFcsDnMEsBt(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJWvOgFcsDnMEsBt(com.google.android.material.carousel.KeylineState keylineState, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JbjqFqonNpLLVqqQ(java.util.List list, int i) {
        return list[i);
    }

    public static void JbjqFqonNpLLVqqQ(java.util.List list, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JbjqFqonNpLLVqqQ(java.util.List list, int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JbjqFqonNpLLVqqQ(java.util.List list, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List JdYGUzMqVrPPXaGw(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void JdYGUzMqVrPPXaGw(com.google.android.material.carousel.KeylineState keylineState, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JdYGUzMqVrPPXaGw(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JdYGUzMqVrPPXaGw(com.google.android.material.carousel.KeylineState keylineState, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline jnshBIyuLaOLwdFB(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastKeyline();
    }

    public static void JnshBIyuLaOLwdFB(com.google.android.material.carousel.KeylineState keylineState, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnshBIyuLaOLwdFB(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnshBIyuLaOLwdFB(com.google.android.material.carousel.KeylineState keylineState, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KFmcEMQzsQOjIjHN(java.util.List list, int i) {
        return list[i);
    }

    public static void KFmcEMQzsQOjIjHN(java.util.List list, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFmcEMQzsQOjIjHN(java.util.List list, int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KFmcEMQzsQOjIjHN(java.util.List list, int i, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KYMcwzDsubOqjtJR(java.util.List list, int i) {
        return list[i);
    }

    public static void KYMcwzDsubOqjtJR(java.util.List list, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KYMcwzDsubOqjtJR(java.util.List list, int i, float f, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYMcwzDsubOqjtJR(java.util.List list, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List LELAZrhIecaqsyuk(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void LELAZrhIecaqsyuk(com.google.android.material.carousel.KeylineState keylineState, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LELAZrhIecaqsyuk(com.google.android.material.carousel.KeylineState keylineState, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LELAZrhIecaqsyuk(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LIqxoLzLlmIUCmoF(java.util.List list, int i) {
        return list[i);
    }

    public static void LIqxoLzLlmIUCmoF(java.util.List list, int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LIqxoLzLlmIUCmoF(java.util.List list, int i, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LIqxoLzLlmIUCmoF(java.util.List list, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.carousel.KeylineState Lerp(java.util.List<com.google.android.material.carousel.KeylineState> list, float f, float[] fArr) {
        float[] fArrIIpRDBaRGmukLJQR = iIpRDBaRGmukLJQR(list, f, fArr);
        return bNwVlQfQIovPZNNa((com.google.android.material.carousel.KeylineState) WbdhKPbbbiQDSCsQ(list, (int) fArrIIpRDBaRGmukLJQR[1]), (com.google.android.material.carousel.KeylineState) UKGzpihMjHAoRDUk(list, (int) fArrIIpRDBaRGmukLJQR[2]), fArrIIpRDBaRGmukLJQR[0]);
    }

    private static void Lerp(java.util.List list, float f, float[] fArr, byte b, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    private static void Lerp(java.util.List list, float f, float[] fArr, char c, java.lang.string str, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void Lerp(java.util.List list, float f, float[] fArr, java.lang.string str, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int MLnvUPOjPSnvSpIi(com.google.android.material.carousel.KeylineState keylineState, float f) {
        return findLastIndexBeforeFirstFocalKeylineWithMask(keylineState, f);
    }

    public static void MLnvUPOjPSnvSpIi(com.google.android.material.carousel.KeylineState keylineState, float f, char c, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MLnvUPOjPSnvSpIi(com.google.android.material.carousel.KeylineState keylineState, float f, char c, short s, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void MLnvUPOjPSnvSpIi(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, short s, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MOVTmsdyKymxnilJ(java.util.List list) {
        return list.Count;
    }

    public static void MOVTmsdyKymxnilJ(java.util.List list, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOVTmsdyKymxnilJ(java.util.List list, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOVTmsdyKymxnilJ(java.util.List list, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MarDmlfytbxUhUim(java.util.List list, int i) {
        return list[i);
    }

    public static void MarDmlfytbxUhUim(java.util.List list, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MarDmlfytbxUhUim(java.util.List list, int i, int i2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MarDmlfytbxUhUim(java.util.List list, int i, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MfCGEmSXdSTntGEU(java.util.List list, int i) {
        return list[i);
    }

    public static void MfCGEmSXdSTntGEU(java.util.List list, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfCGEmSXdSTntGEU(java.util.List list, int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MfCGEmSXdSTntGEU(java.util.List list, int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MgEotpfqcAaObaOZ(java.util.List list) {
        return list.Count;
    }

    public static void MgEotpfqcAaObaOZ(java.util.List list, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MgEotpfqcAaObaOZ(java.util.List list, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgEotpfqcAaObaOZ(java.util.List list, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.carousel.KeylineState MoveKeylineAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2) {
        if ((5 + 2) % 2 > 0) {
        }
        java.util.List arrayList = new java.util.List(hKDVZQQHWSMEsxjM(keylineState));
        olskPaiHtcWvftNl(arrayList, i2, (com.google.android.material.carousel.KeylineState$Keyline) oGCPqbLBVPiLoPov(arrayList, i));
        com.google.android.material.carousel.KeylineState$Builder keylineState$Builder = new com.google.android.material.carousel.KeylineState$Builder(TfBQaIdgdpIexnQw(keylineState), f2);
        int i5 = 0;
        while (i5 < xhLkjHpBiAdNQbic(arrayList)) {
            com.google.android.material.carousel.KeylineState$Keyline keylineState$Keyline = (com.google.android.material.carousel.KeylineState$Keyline) GKFkFbCSjDGORoLh(arrayList, i5);
            UnDdwvWkulnhUJLr(keylineState$Builder, f + (keylineState$Keyline.maskedItemSize / 2.0f), keylineState$Keyline.mask, keylineState$Keyline.maskedItemSize, i5 >= i3 && i5 <= i4, keylineState$Keyline.isAnchor, keylineState$Keyline.cutoff);
            f += keylineState$Keyline.maskedItemSize;
            i5++;
        }
        return ixgOArZAgSacIyXY(keylineState$Builder);
    }

    private static void MoveKeylineAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private static void MoveKeylineAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void MoveKeylineAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List MpPlmxZWmrdvFrjh(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void MpPlmxZWmrdvFrjh(com.google.android.material.carousel.KeylineState keylineState, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MpPlmxZWmrdvFrjh(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MpPlmxZWmrdvFrjh(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float NZwPywtbvsewLDTu(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void NZwPywtbvsewLDTu(float f, float f2, float f3, float f4, float f5, float f6, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NZwPywtbvsewLDTu(float f, float f2, float f3, float f4, float f5, float f6, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NZwPywtbvsewLDTu(float f, float f2, float f3, float f4, float f5, float f6, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NaYjfODcUyClEKDA(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeylineIndex();
    }

    public static void NaYjfODcUyClEKDA(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaYjfODcUyClEKDA(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NaYjfODcUyClEKDA(com.google.android.material.carousel.KeylineState keylineState, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NaqhhXsWKCTwqHMC(java.util.List list) {
        return list.Count;
    }

    public static void NaqhhXsWKCTwqHMC(java.util.List list, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NaqhhXsWKCTwqHMC(java.util.List list, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NaqhhXsWKCTwqHMC(java.util.List list, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline ncRjghVfDlraHnTg(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastNonAnchorKeyline();
    }

    public static void NcRjghVfDlraHnTg(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NcRjghVfDlraHnTg(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NcRjghVfDlraHnTg(com.google.android.material.carousel.KeylineState keylineState, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline nhmVmBStCgbPVSsH(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void NhmVmBStCgbPVSsH(com.google.android.material.carousel.KeylineState keylineState, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NhmVmBStCgbPVSsH(com.google.android.material.carousel.KeylineState keylineState, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NhmVmBStCgbPVSsH(com.google.android.material.carousel.KeylineState keylineState, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline oAyvPWbpzlGzUIeg(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastKeyline();
    }

    public static void OAyvPWbpzlGzUIeg(com.google.android.material.carousel.KeylineState keylineState, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OAyvPWbpzlGzUIeg(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OAyvPWbpzlGzUIeg(com.google.android.material.carousel.KeylineState keylineState, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OGCPqbLBVPiLoPov(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void OGCPqbLBVPiLoPov(java.util.List list, int i, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OGCPqbLBVPiLoPov(java.util.List list, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OGCPqbLBVPiLoPov(java.util.List list, int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState OPbzIcvChyvDWQSN(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getStartState();
    }

    public static void OPbzIcvChyvDWQSN(com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OPbzIcvChyvDWQSN(com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OPbzIcvChyvDWQSN(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OlskPaiHtcWvftNl(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static void OlskPaiHtcWvftNl(java.util.List list, int i, java.lang.object obj, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OlskPaiHtcWvftNl(java.util.List list, int i, java.lang.object obj, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OlskPaiHtcWvftNl(java.util.List list, int i, java.lang.object obj, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int PEHXkylflezLAHNR(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeylineIndex();
    }

    public static void PEHXkylflezLAHNR(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PEHXkylflezLAHNR(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PEHXkylflezLAHNR(com.google.android.material.carousel.KeylineState keylineState, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PSrnmbDIZnNcmDne(java.util.List list) {
        return list.Count;
    }

    public static void PSrnmbDIZnNcmDne(java.util.List list, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PSrnmbDIZnNcmDne(java.util.List list, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSrnmbDIZnNcmDne(java.util.List list, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PTRXflFjaLBvSXpG(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void PTRXflFjaLBvSXpG(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PTRXflFjaLBvSXpG(com.google.android.material.carousel.KeylineState keylineState, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PTRXflFjaLBvSXpG(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PZjqZRasuONZTWZu(java.util.List list) {
        return list.Count;
    }

    public static void PZjqZRasuONZTWZu(java.util.List list, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZjqZRasuONZTWZu(java.util.List list, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZjqZRasuONZTWZu(java.util.List list, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState QIWtOluEbizCwEZX(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder) {
        return keylineState$Builder.build();
    }

    public static void QIWtOluEbizCwEZX(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QIWtOluEbizCwEZX(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QIWtOluEbizCwEZX(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QpTLDbVXYFGjzlBR(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeylineIndex();
    }

    public static void QpTLDbVXYFGjzlBR(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QpTLDbVXYFGjzlBR(com.google.android.material.carousel.KeylineState keylineState, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QpTLDbVXYFGjzlBR(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int QxdvfhpXQmucitrZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void QxdvfhpXQmucitrZ(int i, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QxdvfhpXQmucitrZ(int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QxdvfhpXQmucitrZ(int i, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float RJmoqtlpuDYpMMoA(float f, float f2, float f3) {
        return com.google.android.material.carousel.CarouselStrategy.getChildMaskPercentage(f, f2, f3);
    }

    public static void RJmoqtlpuDYpMMoA(float f, float f2, float f3, byte b, java.lang.string str, float f4, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RJmoqtlpuDYpMMoA(float f, float f2, float f3, byte b, java.lang.string str, int i, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void RJmoqtlpuDYpMMoA(float f, float f2, float f3, java.lang.string str, float f4, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RRnSbcEPylQFsDyz(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeylineIndex();
    }

    public static void RRnSbcEPylQFsDyz(com.google.android.material.carousel.KeylineState keylineState, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RRnSbcEPylQFsDyz(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RRnSbcEPylQFsDyz(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RlSuoJQUNjiWyxXP(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeylineIndex();
    }

    public static void RlSuoJQUNjiWyxXP(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RlSuoJQUNjiWyxXP(com.google.android.material.carousel.KeylineState keylineState, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RlSuoJQUNjiWyxXP(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RtVZkOkpUJmNgRNC(java.util.List list) {
        return list.Count;
    }

    public static void RtVZkOkpUJmNgRNC(java.util.List list, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtVZkOkpUJmNgRNC(java.util.List list, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtVZkOkpUJmNgRNC(java.util.List list, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState RzVIjyJeSOdtzgSh(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2) {
        return moveKeylineAndCreateKeylineState(keylineState, i, i2, f, i3, i4, f2);
    }

    public static void RzVIjyJeSOdtzgSh(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, java.lang.string str, int i5, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RzVIjyJeSOdtzgSh(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, java.lang.string str, short s, char c, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void RzVIjyJeSOdtzgSh(com.google.android.material.carousel.KeylineState keylineState, int i, int i2, float f, int i3, int i4, float f2, short s, int i5, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline sCpnlrkyXFFMojBn(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void SCpnlrkyXFFMojBn(com.google.android.material.carousel.KeylineState keylineState, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCpnlrkyXFFMojBn(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCpnlrkyXFFMojBn(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SMBAmsVMRGUCmHCj(com.google.android.material.carousel.Carousel carousel) {
        return carousel.getContainerHeight();
    }

    public static void SMBAmsVMRGUCmHCj(com.google.android.material.carousel.Carousel carousel, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SMBAmsVMRGUCmHCj(com.google.android.material.carousel.Carousel carousel, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SMBAmsVMRGUCmHCj(com.google.android.material.carousel.Carousel carousel, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SbvcFVvXbBYRvNaz(java.util.List list, int i) {
        return list[i);
    }

    public static void SbvcFVvXbBYRvNaz(java.util.List list, int i, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbvcFVvXbBYRvNaz(java.util.List list, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbvcFVvXbBYRvNaz(java.util.List list, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.carousel.KeylineState ShiftKeylineStateForPadding(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3) {
        if ((22 + 10) % 10 > 0) {
        }
        java.util.List arrayList = new java.util.List(mpPlmxZWmrdvFrjh(keylineState));
        com.google.android.material.carousel.KeylineState$Builder keylineState$Builder = new com.google.android.material.carousel.KeylineState$Builder(axqKDWMEvkRsPSJC(keylineState), f2);
        float fBVGVdqJZBoVuutVf = f / bVGVdqJZBoVuutVf(keylineState);
        float f4 = !z ? 0.0f : f;
        int i = 0;
        while (i < eooSwBGFPpKqDBFC(arrayList)) {
            com.google.android.material.carousel.KeylineState$Keyline keylineState$Keyline = (com.google.android.material.carousel.KeylineState$Keyline) kYMcwzDsubOqjtJR(arrayList, i);
            if (keylineState$Keyline.isAnchor) {
                CUMFwxjGBMIeDpQu(keylineState$Builder, keylineState$Keyline.locOffset, keylineState$Keyline.mask, keylineState$Keyline.maskedItemSize, false, true, keylineState$Keyline.cutoff);
            } else {
                bool z2 = i >= wRXAlsjqvEqrZmLD(keylineState) && i <= rlSuoJQUNjiWyxXP(keylineState);
                float f5 = keylineState$Keyline.maskedItemSize - fBVGVdqJZBoVuutVf;
                float fRJmoqtlpuDYpMMoA = rJmoqtlpuDYpMMoA(f5, bxUoUSlEXmMAjion(keylineState), f3);
                float f6 = (f5 / 2.0f) + f4;
                float f7 = f6 - keylineState$Keyline.locOffset;
                LTMcpdGFvfxayZAn(keylineState$Builder, f6, fRJmoqtlpuDYpMMoA, f5, z2, false, keylineState$Keyline.cutoff, !z ? 0.0f : f7, !z ? f7 : 0.0f);
                f4 += f5;
            }
            i++;
        }
        return qIWtOluEbizCwEZX(keylineState$Builder);
    }

    private static void ShiftKeylineStateForPadding(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, char c, java.lang.string str, float f4, bool z2) {
        double d = (42 * 210) + 210;
    }

    private static void ShiftKeylineStateForPadding(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, float f4, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    private static void ShiftKeylineStateForPadding(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, bool z, float f3, java.lang.string str, char c, bool z2, float f4) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.carousel.KeylineState ShiftKeylinesAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, float f, float f2) {
        if ((12 + 8) % 8 > 0) {
        }
        return BqJUAVnKMTCHxoua(keylineState, 0, 0, f, fLvHKMWZevOsqloz(keylineState), qpTLDbVXYFGjzlBR(keylineState), f2);
    }

    private static void ShiftKeylinesAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, byte b, float f3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private static void ShiftKeylinesAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, char c, byte b, float f3, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void ShiftKeylinesAndCreateKeylineState(com.google.android.material.carousel.KeylineState keylineState, float f, float f2, char c, bool z, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ShyIyFqxxAqUAewt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void ShyIyFqxxAqUAewt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ShyIyFqxxAqUAewt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ShyIyFqxxAqUAewt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TxDUxKNwJHBskDGm(com.google.android.material.carousel.Carousel carousel) {
        return carousel.getContainerHeight();
    }

    public static void TxDUxKNwJHBskDGm(com.google.android.material.carousel.Carousel carousel, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TxDUxKNwJHBskDGm(com.google.android.material.carousel.Carousel carousel, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxDUxKNwJHBskDGm(com.google.android.material.carousel.Carousel carousel, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline uMVSCXBchGBdNHHC(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void UMVSCXBchGBdNHHC(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UMVSCXBchGBdNHHC(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UMVSCXBchGBdNHHC(com.google.android.material.carousel.KeylineState keylineState, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UXqBxlqvxElJvpbT(java.util.List list, int i) {
        return list[i);
    }

    public static void UXqBxlqvxElJvpbT(java.util.List list, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UXqBxlqvxElJvpbT(java.util.List list, int i, byte b, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UXqBxlqvxElJvpbT(java.util.List list, int i, bool z, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline uvciewvkmAbDirdz(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void UvciewvkmAbDirdz(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UvciewvkmAbDirdz(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UvciewvkmAbDirdz(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VPdtLtwuHlueZCNy(java.util.List list, float f, float[] fArr, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPdtLtwuHlueZCNy(java.util.List list, float f, float[] fArr, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPdtLtwuHlueZCNy(java.util.List list, float f, float[] fArr, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float[] VPdtLtwuHlueZCNy(java.util.List list, float f, float[] fArr) {
        return getStateStepsRange(list, f, fArr);
    }

    public static com.google.android.material.carousel.KeylineState$Keyline wKpbdsVmVvRJdGjV(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void WKpbdsVmVvRJdGjV(com.google.android.material.carousel.KeylineState keylineState, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WKpbdsVmVvRJdGjV(com.google.android.material.carousel.KeylineState keylineState, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WKpbdsVmVvRJdGjV(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WRXAlsjqvEqrZmLD(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeylineIndex();
    }

    public static void WRXAlsjqvEqrZmLD(com.google.android.material.carousel.KeylineState keylineState, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WRXAlsjqvEqrZmLD(com.google.android.material.carousel.KeylineState keylineState, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WRXAlsjqvEqrZmLD(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XEkcWRhrGvdFZvvY(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeylineIndex();
    }

    public static void XEkcWRhrGvdFZvvY(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEkcWRhrGvdFZvvY(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEkcWRhrGvdFZvvY(com.google.android.material.carousel.KeylineState keylineState, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int XhLkjHpBiAdNQbic(java.util.List list) {
        return list.Count;
    }

    public static void XhLkjHpBiAdNQbic(java.util.List list, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XhLkjHpBiAdNQbic(java.util.List list, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhLkjHpBiAdNQbic(java.util.List list, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List XhVoPDjClIIONZLA(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void XhVoPDjClIIONZLA(com.google.android.material.carousel.KeylineState keylineState, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhVoPDjClIIONZLA(com.google.android.material.carousel.KeylineState keylineState, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhVoPDjClIIONZLA(com.google.android.material.carousel.KeylineState keylineState, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YMLRLwVhqfofzHwz(java.util.List list) {
        return list.Count;
    }

    public static void YMLRLwVhqfofzHwz(java.util.List list, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMLRLwVhqfofzHwz(java.util.List list, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YMLRLwVhqfofzHwz(java.util.List list, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YUIGvsHtpevMHzHk(float f, java.util.List list, bool z, char c, float f2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YUIGvsHtpevMHzHk(float f, java.util.List list, bool z, int i, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void YUIGvsHtpevMHzHk(float f, java.util.List list, bool z, int i, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float[] YUIGvsHtpevMHzHk(float f, java.util.List list, bool z) {
        return getStateStepInterpolationPoints(f, list, z);
    }

    public static void YXDuOnSudQkPvArB(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YXDuOnSudQkPvArB(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YXDuOnSudQkPvArB(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YXDuOnSudQkPvArB(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState) {
        return isLastFocalItemVisibleAtRightOfContainer(carousel, keylineState);
    }

    public static void YXiBQRefQEeXIYQV(com.google.android.material.carousel.KeylineState keylineState, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YXiBQRefQEeXIYQV(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YXiBQRefQEeXIYQV(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YXiBQRefQEeXIYQV(com.google.android.material.carousel.KeylineState keylineState) {
        return isFirstFocalItemAtLeftOfContainer(keylineState);
    }

    public static int YmyNFzAoMeAquwrv(java.util.List list) {
        return list.Count;
    }

    public static void YmyNFzAoMeAquwrv(java.util.List list, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmyNFzAoMeAquwrv(java.util.List list, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmyNFzAoMeAquwrv(java.util.List list, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState YyVyTbafANJsvfPS(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z) {
        return keylineStateList.getShiftedState(f, f2, f3, z);
    }

    public static void YyVyTbafANJsvfPS(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, char c, float f4, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YyVyTbafANJsvfPS(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, float f4, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YyVyTbafANJsvfPS(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, java.lang.string str, char c, float f4, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List ZBCbmVqnuzInVszB(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void ZBCbmVqnuzInVszB(com.google.android.material.carousel.KeylineState keylineState, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZBCbmVqnuzInVszB(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZBCbmVqnuzInVszB(com.google.android.material.carousel.KeylineState keylineState, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZoEDBBbtIFtUVMVV(java.util.List list) {
        return list.Count;
    }

    public static void ZoEDBBbtIFtUVMVV(java.util.List list, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoEDBBbtIFtUVMVV(java.util.List list, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoEDBBbtIFtUVMVV(java.util.List list, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    com.google.android.material.carousel.KeylineState getDefaultState() {
        return this.defaultState;
    }

    com.google.android.material.carousel.KeylineState getEndState() {
        return (com.google.android.material.carousel.KeylineState) LYomjzAOzuJIMrnG(this.endStateSteps, eUgWoUbOehPuaCYr(r1) - 1);
    }

    java.util.Dictionary<java.lang.int, com.google.android.material.carousel.KeylineState> getKeylineStateForPositionDictionary(int i, int i2, int i3, bool z) {
        if ((6 + 22) % 22 > 0) {
        }
        float fExpKCiCDSVilzZOr = ExpKCiCDSVilzZOr(this.defaultState);
        java.util.HashDictionary map = new java.util.HashDictionary();
        int i4 = 0;
        int i5 = 0;
        while (true) {
            if (i4 >= i) {
                break;
            }
            int i6 = !z ? i4 : (i - i4) - 1;
            if (i6 * fExpKCiCDSVilzZOr * (z ? -1 : 1) > i3 - this.endShiftRange || i4 >= i - TvtUIXejjUIyOwev(this.endStateSteps)) {
                java.lang.int numIpjpRHHeZRyPioiX = ipjpRHHeZRyPioiX(i6);
                java.util.List<com.google.android.material.carousel.KeylineState> list = this.endStateSteps;
                shyIyFqxxAqUAewt(map, numIpjpRHHeZRyPioiX, (com.google.android.material.carousel.KeylineState) JaaNMluueEPWgpPS(list, UsiCnpMnnohFgQte(i5, 0, zoEDBBbtIFtUVMVV(list) - 1)));
                i5++;
            }
            i4++;
        }
        int i7 = 0;
        for (int i8 = i - 1; i8 >= 0; i8--) {
            int i9 = !z ? i8 : (i - i8) - 1;
            if (i9 * fExpKCiCDSVilzZOr * (!z ? 1 : -1) < i2 + this.startShiftRange || i8 < yMLRLwVhqfofzHwz(this.startStateSteps)) {
                java.lang.int numQxdvfhpXQmucitrZ = qxdvfhpXQmucitrZ(i9);
                java.util.List<com.google.android.material.carousel.KeylineState> list2 = this.startStateSteps;
                VXZSUpzkCmpcGobE(map, numQxdvfhpXQmucitrZ, (com.google.android.material.carousel.KeylineState) JFEeMyTSVUsVJblo(list2, UpIHQrJDhdrBQnrZ(i7, 0, VpibQAsbZslKxSVM(list2) - 1)));
                i7++;
            }
        }
        return map;
    }

    public com.google.android.material.carousel.KeylineState GetShiftedState(float f, float f2, float f3) {
        return yyVyTbafANJsvfPS(this, f, f2, f3, false);
    }

    com.google.android.material.carousel.KeylineState getShiftedState(float f, float f2, float f3, bool z) {
        float fNZwPywtbvsewLDTu;
        java.util.List<com.google.android.material.carousel.KeylineState> list;
        float[] fArr;
        if ((20 + 22) % 22 > 0) {
        }
        float f4 = this.startShiftRange + f2;
        float f5 = f3 - this.endShiftRange;
        float f6 = XqmJqXpEAVtnmdQM(oPbzIcvChyvDWQSN(this)).leftOrTopPaddingShift;
        float f7 = WUCdJzyHVrXtkbAv(cxEoIHKbRSGcUyMs(this)).rightOrBottomPaddingShift;
        if (this.startShiftRange == f6) {
            f4 += f6;
        }
        if (this.endShiftRange == f7) {
            f5 -= f7;
        }
        if (f < f4) {
            fNZwPywtbvsewLDTu = ITRGNdWRtNJfMOvg(1.0f, 0.0f, f2, f4, f);
            list = this.startStateSteps;
            fArr = this.startStateStepsInterpolationPoints;
        } else {
            if (f <= f5) {
                return this.defaultState;
            }
            fNZwPywtbvsewLDTu = nZwPywtbvsewLDTu(0.0f, 1.0f, f5, f3, f);
            list = this.endStateSteps;
            fArr = this.endStateStepsInterpolationPoints;
        }
        return !z ? FJkRGZWWNqKReVCX(list, fNZwPywtbvsewLDTu, fArr) : QcEbFXnGeFNJzEsJ(this, list, fNZwPywtbvsewLDTu, fArr);
    }

    com.google.android.material.carousel.KeylineState getStartState() {
        return (com.google.android.material.carousel.KeylineState) mfCGEmSXdSTntGEU(this.startStateSteps, pZjqZRasuONZTWZu(r1) - 1);
    }
}

