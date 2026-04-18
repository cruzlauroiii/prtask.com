namespace WillowMaze.Wasm.Decompiled;


public class DrawableContainerCompat : android.graphics.drawable.Drawable : android.graphics.drawable.Drawable$Callback {
    private static readonly bool DEBUG = false;
    private static readonly bool DEFAULT_DITHER = true;
    private static readonly java.lang.string TAG = "DrawableContainerCompat";
    private java.lang.Action mAnimationAction;
    private androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback mBlockInvalidateCallback;
    private android.graphics.drawable.Drawable mCurrDrawable;
    private androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState mDrawableContainerState;
    private long mEnterAnimationEnd;
    private long mExitAnimationEnd;
    private bool mHasAlpha;
    private android.graphics.Rect mHotspotBounds;
    private android.graphics.drawable.Drawable mLastDrawable;
    private bool mMutated;
    private int mAlpha = 255;
    private int mCurIndex = -1;

    public static android.graphics.drawable.Drawable$Callback AGmVFCIZesJKUJRK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getCallback();
    }

    public static void AGmVFCIZesJKUJRK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AGmVFCIZesJKUJRK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AGmVFCIZesJKUJRK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ATUwQPJdCDczNccK(android.graphics.drawable.Drawable drawable, bool z) {
        androidx.core.graphics.drawable.DrawableCompat.setAutoMirrored(drawable, z);
    }

    public static void ATUwQPJdCDczNccK(android.graphics.drawable.Drawable drawable, bool z, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ATUwQPJdCDczNccK(android.graphics.drawable.Drawable drawable, bool z, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ATUwQPJdCDczNccK(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AgNoXoOviWRPoNUn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AgNoXoOviWRPoNUn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AgNoXoOviWRPoNUn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AgNoXoOviWRPoNUn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return super.getPadding(rect);
    }

    public static int AxEWeigLJaRcScBF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getChangingConfigurations();
    }

    public static void AxEWeigLJaRcScBF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AxEWeigLJaRcScBF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AxEWeigLJaRcScBF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CDfpgGsKvfDsMDow(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CDfpgGsKvfDsMDow(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CDfpgGsKvfDsMDow(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool CDfpgGsKvfDsMDow(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.isConstantSize();
    }

    public static void CypQHnDLTVsiDYio(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, java.lang.string str, float f, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void CypQHnDLTVsiDYio(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, char c, bool z3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CypQHnDLTVsiDYio(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, bool z3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CypQHnDLTVsiDYio(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void DoegHBgYywaNTVar(android.graphics.drawable.Drawable drawable, int[] iArr, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DoegHBgYywaNTVar(android.graphics.drawable.Drawable drawable, int[] iArr, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DoegHBgYywaNTVar(android.graphics.drawable.Drawable drawable, int[] iArr, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DoegHBgYywaNTVar(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void DxsWOzrImOZrVMlb(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable) {
        drawableContainerCompat.initializeDrawableForDisplay(drawable);
    }

    public static void DxsWOzrImOZrVMlb(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DxsWOzrImOZrVMlb(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DxsWOzrImOZrVMlb(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EYMbnrtqTqamMaPn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.getChangingConfigurations();
    }

    public static void EYMbnrtqTqamMaPn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EYMbnrtqTqamMaPn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EYMbnrtqTqamMaPn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FcxAFGEcbpqahQHQ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void FcxAFGEcbpqahQHQ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FcxAFGEcbpqahQHQ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FcxAFGEcbpqahQHQ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GKUoDxXXyKteqSvj(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void GKUoDxXXyKteqSvj(android.graphics.drawable.Drawable drawable, int i, float f, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GKUoDxXXyKteqSvj(android.graphics.drawable.Drawable drawable, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GKUoDxXXyKteqSvj(android.graphics.drawable.Drawable drawable, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GZUEvMTOPIVLlTYN(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GZUEvMTOPIVLlTYN(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GZUEvMTOPIVLlTYN(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] GZUEvMTOPIVLlTYN(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getState();
    }

    public static android.graphics.drawable.Drawable$Callback HIxFqZHMbFyUjbkK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getCallback();
    }

    public static void HIxFqZHMbFyUjbkK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HIxFqZHMbFyUjbkK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HIxFqZHMbFyUjbkK(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.util.DisplayMetrics HzZecZNwSOozoGej(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void HzZecZNwSOozoGej(android.content.res.Resources resources, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HzZecZNwSOozoGej(android.content.res.Resources resources, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HzZecZNwSOozoGej(android.content.res.Resources resources, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IZVbxASuERaPWdpk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.clearMutated();
    }

    public static void IZVbxASuERaPWdpk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IZVbxASuERaPWdpk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IZVbxASuERaPWdpk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KEYJcYwmBWWGrcFI(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        drawable$Callback.scheduleDrawable(drawable, runnable, j);
    }

    public static void KEYJcYwmBWWGrcFI(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEYJcYwmBWWGrcFI(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KEYJcYwmBWWGrcFI(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KeXJPFORJtqTvpZR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KeXJPFORJtqTvpZR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KeXJPFORJtqTvpZR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KeXJPFORJtqTvpZR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.canApplyTheme();
    }

    public static android.graphics.drawable.Drawable$Callback KlIwOSHGRzOcXizO(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback) {
        return drawableContainerCompat$BlockInvalidateCallback.unwrap();
    }

    public static void KlIwOSHGRzOcXizO(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KlIwOSHGRzOcXizO(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlIwOSHGRzOcXizO(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect KuiWCtlIxPdaTUGM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getBounds();
    }

    public static void KuiWCtlIxPdaTUGM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KuiWCtlIxPdaTUGM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KuiWCtlIxPdaTUGM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LOhuGwgUZkMoeHLa(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.invalidateCache();
    }

    public static void LOhuGwgUZkMoeHLa(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LOhuGwgUZkMoeHLa(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LOhuGwgUZkMoeHLa(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LfUlUIVMplKYTIsH(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void LfUlUIVMplKYTIsH(android.graphics.Rect rect, android.graphics.Rect rect2, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LfUlUIVMplKYTIsH(android.graphics.Rect rect, android.graphics.Rect rect2, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LfUlUIVMplKYTIsH(android.graphics.Rect rect, android.graphics.Rect rect2, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnRscOvGRGSAjUny(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static void LnRscOvGRGSAjUny(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LnRscOvGRGSAjUny(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LnRscOvGRGSAjUny(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpTPzTzkTZKtCOZq(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LpTPzTzkTZKtCOZq(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpTPzTzkTZKtCOZq(android.graphics.drawable.Drawable drawable, bool z, bool z2, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LpTPzTzkTZKtCOZq(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void LzieTOHosDfYMjGh(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void LzieTOHosDfYMjGh(android.graphics.drawable.Drawable drawable, int i, int i2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LzieTOHosDfYMjGh(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LzieTOHosDfYMjGh(android.graphics.drawable.Drawable drawable, int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MCvZLusIQAJZTLyF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MCvZLusIQAJZTLyF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MCvZLusIQAJZTLyF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MCvZLusIQAJZTLyF(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i) {
        return drawableContainerCompat.selectDrawable(i);
    }

    public static void MXEcTaxktqJXDvPW(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MXEcTaxktqJXDvPW(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXEcTaxktqJXDvPW(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MXEcTaxktqJXDvPW(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.canConstantState();
    }

    public static void MaCpuLWibJOocGYf(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void MaCpuLWibJOocGYf(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MaCpuLWibJOocGYf(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MaCpuLWibJOocGYf(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MnLgUUOBjwvlVzFu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z) {
        drawableContainerCompat.animate(z);
    }

    public static void MnLgUUOBjwvlVzFu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, byte b, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MnLgUUOBjwvlVzFu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, bool z2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MnLgUUOBjwvlVzFu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, bool z2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MrJfBhWQsaEAmUOv(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        drawableContainerCompat.invalidateSelf();
    }

    public static void MrJfBhWQsaEAmUOv(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MrJfBhWQsaEAmUOv(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MrJfBhWQsaEAmUOv(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback MwMibfFnqfguGMaM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getCallback();
    }

    public static void MwMibfFnqfguGMaM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MwMibfFnqfguGMaM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MwMibfFnqfguGMaM(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NKjjWpGyOQiVzeGc(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void NKjjWpGyOQiVzeGc(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NKjjWpGyOQiVzeGc(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NKjjWpGyOQiVzeGc(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NdagHXGUkxiGLdwf(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.getConstantMinimumWidth();
    }

    public static void NdagHXGUkxiGLdwf(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdagHXGUkxiGLdwf(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NdagHXGUkxiGLdwf(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect NdjfAakvVwVXWnEy(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.getConstantPadding();
    }

    public static void NdjfAakvVwVXWnEy(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdjfAakvVwVXWnEy(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdjfAakvVwVXWnEy(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiCqexRKafkpZeoC(android.graphics.drawable.Drawable drawable, bool z, bool z2, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NiCqexRKafkpZeoC(android.graphics.drawable.Drawable drawable, bool z, bool z2, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NiCqexRKafkpZeoC(android.graphics.drawable.Drawable drawable, bool z, bool z2, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NiCqexRKafkpZeoC(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void NjakKsVLbJiLCSrd(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat.setConstantState(drawableContainerCompat$DrawableContainerState);
    }

    public static void NjakKsVLbJiLCSrd(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NjakKsVLbJiLCSrd(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NjakKsVLbJiLCSrd(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int NpJJtVmfrlLecsdx(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void NpJJtVmfrlLecsdx(android.graphics.drawable.Drawable drawable, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NpJJtVmfrlLecsdx(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NpJJtVmfrlLecsdx(android.graphics.drawable.Drawable drawable, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OVZjYfILxLxKTdQu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z) {
        drawableContainerCompat.animate(z);
    }

    public static void OVZjYfILxLxKTdQu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OVZjYfILxLxKTdQu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OVZjYfILxLxKTdQu(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OjQJcdsRaxZicaqo(android.graphics.drawable.Drawable drawable, float f, float f2) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspot(drawable, f, f2);
    }

    public static void OjQJcdsRaxZicaqo(android.graphics.drawable.Drawable drawable, float f, float f2, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjQJcdsRaxZicaqo(android.graphics.drawable.Drawable drawable, float f, float f2, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OjQJcdsRaxZicaqo(android.graphics.drawable.Drawable drawable, float f, float f2, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback PuCZbBOcrAyAZDNg(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        return drawableContainerCompat$BlockInvalidateCallback.wrap(drawable$Callback);
    }

    public static void PuCZbBOcrAyAZDNg(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PuCZbBOcrAyAZDNg(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, android.graphics.drawable.Drawable$Callback drawable$Callback, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PuCZbBOcrAyAZDNg(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PvzTZxJvAnGNVVKF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PvzTZxJvAnGNVVKF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PvzTZxJvAnGNVVKF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool PvzTZxJvAnGNVVKF(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void PzqInBGXiZOlITGE(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void PzqInBGXiZOlITGE(android.graphics.drawable.Drawable drawable, int i, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PzqInBGXiZOlITGE(android.graphics.drawable.Drawable drawable, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PzqInBGXiZOlITGE(android.graphics.drawable.Drawable drawable, int i, short s, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QHfwWuRdelFfhsRB(android.graphics.drawable.Drawable drawable) {
        return drawable.getMinimumHeight();
    }

    public static void QHfwWuRdelFfhsRB(android.graphics.drawable.Drawable drawable, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QHfwWuRdelFfhsRB(android.graphics.drawable.Drawable drawable, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QHfwWuRdelFfhsRB(android.graphics.drawable.Drawable drawable, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QLVHxzRhtuTTBHCi(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable) {
        drawableContainerCompat.unscheduleSelf(runnable);
    }

    public static void QLVHxzRhtuTTBHCi(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QLVHxzRhtuTTBHCi(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLVHxzRhtuTTBHCi(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RaBZVJFdZboFeFOp(android.graphics.drawable.Drawable drawable, bool z) {
        androidx.core.graphics.drawable.DrawableCompat.setAutoMirrored(drawable, z);
    }

    public static void RaBZVJFdZboFeFOp(android.graphics.drawable.Drawable drawable, bool z, byte b, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RaBZVJFdZboFeFOp(android.graphics.drawable.Drawable drawable, bool z, char c, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void RaBZVJFdZboFeFOp(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback ReCHHoSrTorpNird(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback) {
        return drawableContainerCompat$BlockInvalidateCallback.unwrap();
    }

    public static void ReCHHoSrTorpNird(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ReCHHoSrTorpNird(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ReCHHoSrTorpNird(androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback drawableContainerCompat$BlockInvalidateCallback, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SHMiWYNIqgRWuFBP(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void SHMiWYNIqgRWuFBP(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SHMiWYNIqgRWuFBP(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SHMiWYNIqgRWuFBP(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMlxShqIiIegFgPF(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static void UMlxShqIiIegFgPF(android.graphics.drawable.Drawable drawable, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMlxShqIiIegFgPF(android.graphics.drawable.Drawable drawable, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UMlxShqIiIegFgPF(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UbqrHSMTcQThMePp(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        drawable$Callback.unscheduleDrawable(drawable, runnable);
    }

    public static void UbqrHSMTcQThMePp(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UbqrHSMTcQThMePp(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbqrHSMTcQThMePp(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback VLtGHREHCyVyCxqX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getCallback();
    }

    public static void VLtGHREHCyVyCxqX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VLtGHREHCyVyCxqX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VLtGHREHCyVyCxqX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WkhFezLtQkhAeTez(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkhFezLtQkhAeTez(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WkhFezLtQkhAeTez(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WkhFezLtQkhAeTez(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.isStateful();
    }

    public static long WzLeGABRMteOYVns() {
        if ((10 + 23) % 23 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static void WzLeGABRMteOYVns(byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzLeGABRMteOYVns(char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzLeGABRMteOYVns(char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XFZCSbSUvvNCQeyK(android.graphics.drawable.Drawable drawable, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XFZCSbSUvvNCQeyK(android.graphics.drawable.Drawable drawable, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XFZCSbSUvvNCQeyK(android.graphics.drawable.Drawable drawable, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XFZCSbSUvvNCQeyK(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static int XcZWQMAnLkyvpbQF(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.getConstantMinimumHeight();
    }

    public static void XcZWQMAnLkyvpbQF(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XcZWQMAnLkyvpbQF(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XcZWQMAnLkyvpbQF(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback XoozBaEOChyIwBQr(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getCallback();
    }

    public static void XoozBaEOChyIwBQr(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XoozBaEOChyIwBQr(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XoozBaEOChyIwBQr(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpGIdoUNSATnYYoq(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void YpGIdoUNSATnYYoq(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpGIdoUNSATnYYoq(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YpGIdoUNSATnYYoq(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YutadQTEJFSkrtpJ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        super.getHotspotBounds(rect);
    }

    public static void YutadQTEJFSkrtpJ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YutadQTEJFSkrtpJ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YutadQTEJFSkrtpJ(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZWWnlddreQLmuHNy(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void ZWWnlddreQLmuHNy(android.graphics.drawable.Drawable drawable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZWWnlddreQLmuHNy(android.graphics.drawable.Drawable drawable, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZWWnlddreQLmuHNy(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AGioBLETzjlQTGkg(android.graphics.drawable.Drawable drawable) {
        return drawable.getMinimumWidth();
    }

    public static void AGioBLETzjlQTGkg(android.graphics.drawable.Drawable drawable, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AGioBLETzjlQTGkg(android.graphics.drawable.Drawable drawable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AGioBLETzjlQTGkg(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AsljOvDryZJpJEmu(android.graphics.drawable.Drawable drawable, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AsljOvDryZJpJEmu(android.graphics.drawable.Drawable drawable, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AsljOvDryZJpJEmu(android.graphics.drawable.Drawable drawable, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool AsljOvDryZJpJEmu(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static void AxYNqkSyPnrrCjiH(android.graphics.drawable.Drawable drawable, int i, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxYNqkSyPnrrCjiH(android.graphics.drawable.Drawable drawable, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AxYNqkSyPnrrCjiH(android.graphics.drawable.Drawable drawable, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool AxYNqkSyPnrrCjiH(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static void AybrReRnVGHGYQst(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources) {
        drawableContainerCompat$DrawableContainerState.updateDensity(resources);
    }

    public static void AybrReRnVGHGYQst(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AybrReRnVGHGYQst(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AybrReRnVGHGYQst(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BERCoDhmJIRDlfUV(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable) {
        drawable$Callback.invalidateDrawable(drawable);
    }

    public static void BERCoDhmJIRDlfUV(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BERCoDhmJIRDlfUV(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BERCoDhmJIRDlfUV(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CMTRFUnbfjmyOCQz(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMTRFUnbfjmyOCQz(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMTRFUnbfjmyOCQz(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CMTRFUnbfjmyOCQz(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.needsMirroring();
    }

    public static int CQjWEyZGKUkhAZEL(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void CQjWEyZGKUkhAZEL(android.graphics.drawable.Drawable drawable, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CQjWEyZGKUkhAZEL(android.graphics.drawable.Drawable drawable, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CQjWEyZGKUkhAZEL(android.graphics.drawable.Drawable drawable, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CWJBwkIXEGPYvhdO(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void CWJBwkIXEGPYvhdO(android.graphics.drawable.Drawable drawable, int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CWJBwkIXEGPYvhdO(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CWJBwkIXEGPYvhdO(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CgKgUKlsYwUgqWlM(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CgKgUKlsYwUgqWlM(android.graphics.drawable.Drawable drawable, int i, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CgKgUKlsYwUgqWlM(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CgKgUKlsYwUgqWlM(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static void CmPHmzfYTZdaeqNu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void CmPHmzfYTZdaeqNu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CmPHmzfYTZdaeqNu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CmPHmzfYTZdaeqNu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DoqadGahMrgBMEON(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    public static void DoqadGahMrgBMEON(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DoqadGahMrgBMEON(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DoqadGahMrgBMEON(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EDtYIYAlLLReAkIu(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.getOpacity();
    }

    public static void EDtYIYAlLLReAkIu(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDtYIYAlLLReAkIu(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EDtYIYAlLLReAkIu(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEZGHqIqMpwsXMUT(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources$Theme resources$Theme) {
        drawableContainerCompat$DrawableContainerState.applyTheme(resources$Theme);
    }

    public static void EEZGHqIqMpwsXMUT(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources$Theme resources$Theme, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EEZGHqIqMpwsXMUT(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources$Theme resources$Theme, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EEZGHqIqMpwsXMUT(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources$Theme resources$Theme, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FFfSfqAhDbqrfXjP(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void FFfSfqAhDbqrfXjP(android.graphics.drawable.Drawable drawable, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FFfSfqAhDbqrfXjP(android.graphics.drawable.Drawable drawable, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFfSfqAhDbqrfXjP(android.graphics.drawable.Drawable drawable, int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList FfnbRPxXOuEyoBxM(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void FfnbRPxXOuEyoBxM(int i, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FfnbRPxXOuEyoBxM(int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FfnbRPxXOuEyoBxM(int i, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FhlHfIzcXGzhtgFj(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    public static void FhlHfIzcXGzhtgFj(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FhlHfIzcXGzhtgFj(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FhlHfIzcXGzhtgFj(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GRQLsZElmQJUFXUL(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getLevel();
    }

    public static void GRQLsZElmQJUFXUL(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRQLsZElmQJUFXUL(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRQLsZElmQJUFXUL(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HiNwpegoqtzTgEEt(android.graphics.drawable.Drawable drawable, android.graphics.Outline outline) {
        androidx.appcompat.graphics.drawable.DrawableContainerCompat$Api21Impl.getOutline(drawable, outline);
    }

    public static void HiNwpegoqtzTgEEt(android.graphics.drawable.Drawable drawable, android.graphics.Outline outline, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HiNwpegoqtzTgEEt(android.graphics.drawable.Drawable drawable, android.graphics.Outline outline, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HiNwpegoqtzTgEEt(android.graphics.drawable.Drawable drawable, android.graphics.Outline outline, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void InitializeDrawableForDisplay(android.graphics.drawable.Drawable drawable) {
        if ((16 + 25) % 25 > 0) {
        }
        if (this.mBlockInvalidateCallback is null) {
            this.mBlockInvalidateCallback = new androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback();
        }
        vQkQlmcBIgIFvALO(drawable, PuCZbBOcrAyAZDNg(this.mBlockInvalidateCallback, nsXLELUFiGFNMgtu(drawable)));
        try {
            if (this.mDrawableContainerState.mEnterFadeDuration <= 0 && this.mHasAlpha) {
                GKUoDxXXyKteqSvj(drawable, this.mAlpha);
            }
            if (this.mDrawableContainerState.mHasColorFilter) {
                doqadGahMrgBMEON(drawable, this.mDrawableContainerState.mColorFilter);
            } else {
                if (this.mDrawableContainerState.mHasTintList) {
                    NKjjWpGyOQiVzeGc(drawable, this.mDrawableContainerState.mTintList);
                }
                if (this.mDrawableContainerState.mHasTintMode) {
                    MaCpuLWibJOocGYf(drawable, this.mDrawableContainerState.mTintMode);
                }
            }
            wyhsWhdXgIBpPwXB(drawable, rLcCUvBOaaBwWZBA(this), true);
            jYorLhHgrjjqDUjF(drawable, this.mDrawableContainerState.mDither);
            lOUSrhYZoVwTgZCp(drawable, GZUEvMTOPIVLlTYN(this));
            cgKgUKlsYwUgqWlM(drawable, gRQLsZElmQJUFXUL(this));
            muZwmVZbzRivvltx(drawable, KuiWCtlIxPdaTUGM(this));
            XFZCSbSUvvNCQeyK(drawable, mfLjRzZpDtzQsSWU(this));
            ATUwQPJdCDczNccK(drawable, this.mDrawableContainerState.mAutoMirrored);
            android.graphics.Rect rect = this.mHotspotBounds;
            if (rect is not null) {
                mBepPfSSzceaalAb(drawable, rect.left, rect.top, rect.right, rect.bottom);
            }
            ldNRTxOpqceqWGlb(drawable, KlIwOSHGRzOcXizO(this.mBlockInvalidateCallback));
        } catch (java.lang.Exception th) {
            SHMiWYNIqgRWuFBP(drawable, ReCHHoSrTorpNird(this.mBlockInvalidateCallback));
            throw th;
        }
    }

    private void InitializeDrawableForDisplay(android.graphics.drawable.Drawable drawable, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void InitializeDrawableForDisplay(android.graphics.drawable.Drawable drawable, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void InitializeDrawableForDisplay(android.graphics.drawable.Drawable drawable, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JHawVJDrxLUixGJi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.getConstantHeight();
    }

    public static void JHawVJDrxLUixGJi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JHawVJDrxLUixGJi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JHawVJDrxLUixGJi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JYorLhHgrjjqDUjF(android.graphics.drawable.Drawable drawable, bool z) {
        drawable.setDither(z);
    }

    public static void JYorLhHgrjjqDUjF(android.graphics.drawable.Drawable drawable, bool z, int i, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JYorLhHgrjjqDUjF(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JYorLhHgrjjqDUjF(android.graphics.drawable.Drawable drawable, bool z, bool z2, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JgzCvghjRpIwdlRv(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JgzCvghjRpIwdlRv(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JgzCvghjRpIwdlRv(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JgzCvghjRpIwdlRv(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.isConstantSize();
    }

    public static void KEQNHhDfIGVqBCht(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable, long j) {
        drawableContainerCompat.scheduleSelf(runnable, j);
    }

    public static void KEQNHhDfIGVqBCht(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable, long j, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KEQNHhDfIGVqBCht(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable, long j, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KEQNHhDfIGVqBCht(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.Action runnable, long j, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KPGBCyCbUTkzdkcb(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KPGBCyCbUTkzdkcb(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPGBCyCbUTkzdkcb(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KPGBCyCbUTkzdkcb(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.isConstantSize();
    }

    public static void LLWpphNbaFMLtsXq(android.graphics.drawable.Drawable drawable, bool z) {
        drawable.setDither(z);
    }

    public static void LLWpphNbaFMLtsXq(android.graphics.drawable.Drawable drawable, bool z, char c, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LLWpphNbaFMLtsXq(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LLWpphNbaFMLtsXq(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LOUSrhYZoVwTgZCp(android.graphics.drawable.Drawable drawable, int[] iArr, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LOUSrhYZoVwTgZCp(android.graphics.drawable.Drawable drawable, int[] iArr, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOUSrhYZoVwTgZCp(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LOUSrhYZoVwTgZCp(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void LdNRTxOpqceqWGlb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void LdNRTxOpqceqWGlb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LdNRTxOpqceqWGlb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LdNRTxOpqceqWGlb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MBepPfSSzceaalAb(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public static void MBepPfSSzceaalAb(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBepPfSSzceaalAb(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MBepPfSSzceaalAb(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MfLjRzZpDtzQsSWU(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void MfLjRzZpDtzQsSWU(android.graphics.drawable.Drawable drawable, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MfLjRzZpDtzQsSWU(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfLjRzZpDtzQsSWU(android.graphics.drawable.Drawable drawable, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MuZwmVZbzRivvltx(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void MuZwmVZbzRivvltx(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MuZwmVZbzRivvltx(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MuZwmVZbzRivvltx(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NWfehGfcnRPqvAeP(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void NWfehGfcnRPqvAeP(android.graphics.Rect rect, int i, int i2, int i3, int i4, short s, char c, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void NWfehGfcnRPqvAeP(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, char c, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NWfehGfcnRPqvAeP(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, short s, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NeeXjJGsfZCRizay(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.getConstantWidth();
    }

    public static void NeeXjJGsfZCRizay(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NeeXjJGsfZCRizay(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NeeXjJGsfZCRizay(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void NeedsMirroring(byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void NeedsMirroring(bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void NeedsMirroring(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private bool NeedsMirroring() {
        return uzuYbHwLAgvaykVG(this) && cQjWEyZGKUkhAZEL(this) == 1;
    }

    public static android.graphics.drawable.Drawable$Callback nsXLELUFiGFNMgtu(android.graphics.drawable.Drawable drawable) {
        return drawable.getCallback();
    }

    public static void NsXLELUFiGFNMgtu(android.graphics.drawable.Drawable drawable, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NsXLELUFiGFNMgtu(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NsXLELUFiGFNMgtu(android.graphics.drawable.Drawable drawable, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PBepdDigSIxadLsV(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void PBepdDigSIxadLsV(android.graphics.drawable.Drawable drawable, int i, char c, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PBepdDigSIxadLsV(android.graphics.drawable.Drawable drawable, int i, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PBepdDigSIxadLsV(android.graphics.drawable.Drawable drawable, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PGubTwoVQEouwKdm(android.graphics.drawable.Drawable drawable, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PGubTwoVQEouwKdm(android.graphics.drawable.Drawable drawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PGubTwoVQEouwKdm(android.graphics.drawable.Drawable drawable, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PGubTwoVQEouwKdm(android.graphics.drawable.Drawable drawable) {
        return drawable.isVisible();
    }

    public static int PomCUYTkfvpHexfP(android.graphics.drawable.Drawable drawable) {
        return super.getChangingConfigurations();
    }

    public static void PomCUYTkfvpHexfP(android.graphics.drawable.Drawable drawable, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PomCUYTkfvpHexfP(android.graphics.drawable.Drawable drawable, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PomCUYTkfvpHexfP(android.graphics.drawable.Drawable drawable, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PrOGuVERemCnwhqV(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.content.res.ColorStateList colorStateList) {
        drawableContainerCompat.setTintList(colorStateList);
    }

    public static void PrOGuVERemCnwhqV(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.content.res.ColorStateList colorStateList, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrOGuVERemCnwhqV(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrOGuVERemCnwhqV(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.content.res.ColorStateList colorStateList, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PtbWGOqsoRdrqqHX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        drawableContainerCompat.invalidateSelf();
    }

    public static void PtbWGOqsoRdrqqHX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PtbWGOqsoRdrqqHX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PtbWGOqsoRdrqqHX(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QRcBqELENJlHKxUg(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void QRcBqELENJlHKxUg(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QRcBqELENJlHKxUg(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QRcBqELENJlHKxUg(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QYhMTFrWeGqvTyrU(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QYhMTFrWeGqvTyrU(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QYhMTFrWeGqvTyrU(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QYhMTFrWeGqvTyrU(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static void RLcCUvBOaaBwWZBA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RLcCUvBOaaBwWZBA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RLcCUvBOaaBwWZBA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RLcCUvBOaaBwWZBA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.isVisible();
    }

    static int ResolveDensity(android.content.res.Resources resources, int i) {
        if (resources is not null) {
            i = HzZecZNwSOozoGej(resources).densityDpi;
        }
        if (i != 0) {
            return i;
        }
        return 160;
    }

    static void ResolveDensity(android.content.res.Resources resources, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    static void ResolveDensity(android.content.res.Resources resources, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void ResolveDensity(android.content.res.Resources resources, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable TTFMyVajOtEbYysH(android.graphics.drawable.Drawable drawable) {
        return super.mutate();
    }

    public static void TTFMyVajOtEbYysH(android.graphics.drawable.Drawable drawable, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTFMyVajOtEbYysH(android.graphics.drawable.Drawable drawable, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTFMyVajOtEbYysH(android.graphics.drawable.Drawable drawable, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TttDWsfPFAoQpqPt(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.mutate();
    }

    public static void TttDWsfPFAoQpqPt(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TttDWsfPFAoQpqPt(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TttDWsfPFAoQpqPt(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TwFXqcqiWAqMVzAn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2, byte b, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TwFXqcqiWAqMVzAn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2, char c, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TwFXqcqiWAqMVzAn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2, short s, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static bool TwFXqcqiWAqMVzAn(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2) {
        return drawableContainerCompat$DrawableContainerState.setLayoutDirection(i, i2);
    }

    public static void TxGWsihdBelQpJqp(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, byte b, bool z3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TxGWsihdBelQpJqp(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, java.lang.string str, byte b, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void TxGWsihdBelQpJqp(android.graphics.drawable.Drawable drawable, bool z, bool z2, java.lang.string str, float f, byte b, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static bool TxGWsihdBelQpJqp(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void TxfNerrjRCXpTEnn(android.graphics.drawable.Drawable drawable, int[] iArr, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxfNerrjRCXpTEnn(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxfNerrjRCXpTEnn(android.graphics.drawable.Drawable drawable, int[] iArr, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TxfNerrjRCXpTEnn(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.graphics.drawable.Drawable UlrxAmpBZNhQahOk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i) {
        return drawableContainerCompat$DrawableContainerState.getChild(i);
    }

    public static void UlrxAmpBZNhQahOk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UlrxAmpBZNhQahOk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlrxAmpBZNhQahOk(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UzuYbHwLAgvaykVG(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UzuYbHwLAgvaykVG(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UzuYbHwLAgvaykVG(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UzuYbHwLAgvaykVG(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.isAutoMirrored();
    }

    public static void VQkQlmcBIgIFvALO(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void VQkQlmcBIgIFvALO(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VQkQlmcBIgIFvALO(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VQkQlmcBIgIFvALO(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VxomJbSAUgswghMe(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VxomJbSAUgswghMe(android.graphics.drawable.Drawable drawable, bool z, bool z2, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VxomJbSAUgswghMe(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool VxomJbSAUgswghMe(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void WLDDjHakbPjybgRj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void WLDDjHakbPjybgRj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WLDDjHakbPjybgRj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WLDDjHakbPjybgRj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WfwZNGfgVHlWltSB(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable) {
        drawableContainerCompat.initializeDrawableForDisplay(drawable);
    }

    public static void WfwZNGfgVHlWltSB(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WfwZNGfgVHlWltSB(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WfwZNGfgVHlWltSB(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.graphics.drawable.Drawable drawable, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkBCndIAnsyezZEV(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public static void WkBCndIAnsyezZEV(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, int i5, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WkBCndIAnsyezZEV(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, java.lang.string str, char c, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void WkBCndIAnsyezZEV(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, java.lang.string str, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WyhsWhdXgIBpPwXB(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, int i, short s, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void WyhsWhdXgIBpPwXB(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, bool z3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WyhsWhdXgIBpPwXB(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, int i, char c, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static bool WyhsWhdXgIBpPwXB(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static int XJcVMYXkaQUHacWA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getCurrentIndex();
    }

    public static void XJcVMYXkaQUHacWA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XJcVMYXkaQUHacWA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XJcVMYXkaQUHacWA(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XYyImgZgtVglYycv(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void XYyImgZgtVglYycv(android.graphics.Rect rect, android.graphics.Rect rect2, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XYyImgZgtVglYycv(android.graphics.Rect rect, android.graphics.Rect rect2, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XYyImgZgtVglYycv(android.graphics.Rect rect, android.graphics.Rect rect2, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable XezWikyhlrAcmzVR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i) {
        return drawableContainerCompat$DrawableContainerState.getChild(i);
    }

    public static void XezWikyhlrAcmzVR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XezWikyhlrAcmzVR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XezWikyhlrAcmzVR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XodwpnQTuijSlqSK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XodwpnQTuijSlqSK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XodwpnQTuijSlqSK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XodwpnQTuijSlqSK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        return drawableContainerCompat$DrawableContainerState.isConstantSize();
    }

    public static long YkFUDfPPDyMSCUoa() {
        if ((5 + 4) % 4 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static void YkFUDfPPDyMSCUoa(char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YkFUDfPPDyMSCUoa(short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YkFUDfPPDyMSCUoa(bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState yoObKLhkIyattgcf(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.cloneConstantState();
    }

    public static void YoObKLhkIyattgcf(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YoObKLhkIyattgcf(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YoObKLhkIyattgcf(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YumhbeEaMacsgJYn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void YumhbeEaMacsgJYn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YumhbeEaMacsgJYn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YumhbeEaMacsgJYn(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback zCFVFXKBNAIHzZVJ(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat) {
        return drawableContainerCompat.getCallback();
    }

    public static void ZCFVFXKBNAIHzZVJ(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZCFVFXKBNAIHzZVJ(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZCFVFXKBNAIHzZVJ(androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    void animate(bool z) {
        bool z2;
        android.graphics.drawable.Drawable drawable;
        long j;
        if ((10 + 24) % 24 > 0) {
        }
        bool z3 = true;
        this.mHasAlpha = true;
        long jWzLeGABRMteOYVns = WzLeGABRMteOYVns();
        android.graphics.drawable.Drawable drawable2 = this.mCurrDrawable;
        if (drawable2 is not null) {
            long j2 = this.mEnterAnimationEnd;
            if (j2 != 0) {
                if (j2 > jWzLeGABRMteOYVns) {
                    pBepdDigSIxadLsV(this.mCurrDrawable, ((255 - (((int) ((j2 - jWzLeGABRMteOYVns) * 255)) / this.mDrawableContainerState.mEnterFadeDuration)) * this.mAlpha) / 255);
                    z2 = true;
                } else {
                    PzqInBGXiZOlITGE(drawable2, this.mAlpha);
                    this.mEnterAnimationEnd = 0L;
                }
            }
            drawable = this.mLastDrawable;
            if (drawable is null) {
                j = this.mExitAnimationEnd;
                if (j != 0) {
                    if (j > jWzLeGABRMteOYVns) {
                        fFfSfqAhDbqrfXjP(this.mLastDrawable, ((((int) ((j - jWzLeGABRMteOYVns) * 255)) / this.mDrawableContainerState.mExitFadeDuration) * this.mAlpha) / 255);
                    } else {
                        txGWsihdBelQpJqp(drawable, false, false);
                        this.mLastDrawable = null;
                        this.mExitAnimationEnd = 0L;
                    }
                }
                if (!z && z3) {
                    kEQNHhDfIGVqBCht(this, this.mAnimationAction, jWzLeGABRMteOYVns + 16);
                }
                return;
            }
            this.mExitAnimationEnd = 0L;
            z3 = z2;
            if (z) {
                return;
            }
            kEQNHhDfIGVqBCht(this, this.mAnimationAction, jWzLeGABRMteOYVns + 16);
        }
        this.mEnterAnimationEnd = 0L;
        z2 = false;
        drawable = this.mLastDrawable;
        if (drawable is null) {
            j = this.mExitAnimationEnd;
            if (j != 0) {
                if (j > jWzLeGABRMteOYVns) {
                    fFfSfqAhDbqrfXjP(this.mLastDrawable, ((((int) ((j - jWzLeGABRMteOYVns) * 255)) / this.mDrawableContainerState.mExitFadeDuration) * this.mAlpha) / 255);
                } else {
                    txGWsihdBelQpJqp(drawable, false, false);
                    this.mLastDrawable = null;
                    this.mExitAnimationEnd = 0L;
                }
            }
            if (z) {
                return;
            }
            kEQNHhDfIGVqBCht(this, this.mAnimationAction, jWzLeGABRMteOYVns + 16);
        }
        this.mExitAnimationEnd = 0L;
        z3 = z2;
        if (z) {
            return;
        }
        kEQNHhDfIGVqBCht(this, this.mAnimationAction, jWzLeGABRMteOYVns + 16);
    }

    public override void ApplyTheme(android.content.res.Resources$Theme resources$Theme) {
        eEZGHqIqMpwsXMUT(this.mDrawableContainerState, resources$Theme);
    }

    public override bool CanApplyTheme() {
        return KeXJPFORJtqTvpZR(this.mDrawableContainerState);
    }

    void clearMutated() {
        IZVbxASuERaPWdpk(this.mDrawableContainerState);
        this.mMutated = false;
    }

    androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState cloneConstantState() {
        return this.mDrawableContainerState;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is not null) {
            wLDDjHakbPjybgRj(drawable, canvas);
        }
        android.graphics.drawable.Drawable drawable2 = this.mLastDrawable;
        if (drawable2 is null) {
            return;
        }
        qRcBqELENJlHKxUg(drawable2, canvas);
    }

    public override int GetAlpha() {
        return this.mAlpha;
    }

    public override int GetChangingConfigurations() {
        return EYMbnrtqTqamMaPn(this.mDrawableContainerState) | pomCUYTkfvpHexfP(this);
    }

    public readonly android.graphics.drawable.Drawable$ConstantState getConstantState() {
        if ((16 + 1) % 1 > 0) {
        }
        if (!MXEcTaxktqJXDvPW(this.mDrawableContainerState)) {
            return null;
        }
        this.mDrawableContainerState.mChangingConfigurations = AxEWeigLJaRcScBF(this);
        return this.mDrawableContainerState;
    }

    public override android.graphics.drawable.Drawable GetCurrent() {
        return this.mCurrDrawable;
    }

    int getCurrentIndex() {
        return this.mCurIndex;
    }

    public override void GetHotspotBounds(android.graphics.Rect rect) {
        android.graphics.Rect rect2 = this.mHotspotBounds;
        if (rect2 is null) {
            YutadQTEJFSkrtpJ(this, rect);
        } else {
            LfUlUIVMplKYTIsH(rect, rect2);
        }
    }

    public override int GetIntrinsicHeight() {
        if (kPGBCyCbUTkzdkcb(this.mDrawableContainerState)) {
            return jHawVJDrxLUixGJi(this.mDrawableContainerState);
        }
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return -1;
        }
        return NpJJtVmfrlLecsdx(drawable);
    }

    public override int GetIntrinsicWidth() {
        if (jgzCvghjRpIwdlRv(this.mDrawableContainerState)) {
            return neeXjJGsfZCRizay(this.mDrawableContainerState);
        }
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return -1;
        }
        return ZWWnlddreQLmuHNy(drawable);
    }

    public override int GetMinimumHeight() {
        if (CDfpgGsKvfDsMDow(this.mDrawableContainerState)) {
            return XcZWQMAnLkyvpbQF(this.mDrawableContainerState);
        }
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return 0;
        }
        return QHfwWuRdelFfhsRB(drawable);
    }

    public override int GetMinimumWidth() {
        if (xodwpnQTuijSlqSK(this.mDrawableContainerState)) {
            return NdagHXGUkxiGLdwf(this.mDrawableContainerState);
        }
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return 0;
        }
        return aGioBLETzjlQTGkg(drawable);
    }

    public override int GetOpacity() {
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is not null && pGubTwoVQEouwKdm(drawable)) {
            return eDtYIYAlLLReAkIu(this.mDrawableContainerState);
        }
        return -2;
    }

    public override void GetOutline(android.graphics.Outline outline) {
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return;
        }
        hiNwpegoqtzTgEEt(drawable, outline);
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        bool zAgNoXoOviWRPoNUn;
        if ((23 + 1) % 1 > 0) {
        }
        android.graphics.Rect rectNdjfAakvVwVXWnEy = NdjfAakvVwVXWnEy(this.mDrawableContainerState);
        if (rectNdjfAakvVwVXWnEy is null) {
            android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
            zAgNoXoOviWRPoNUn = drawable is null ? AgNoXoOviWRPoNUn(this, rect) : PvzTZxJvAnGNVVKF(drawable, rect);
        } else {
            xYyImgZgtVglYycv(rect, rectNdjfAakvVwVXWnEy);
            zAgNoXoOviWRPoNUn = (rectNdjfAakvVwVXWnEy.right | ((rectNdjfAakvVwVXWnEy.left | rectNdjfAakvVwVXWnEy.top) | rectNdjfAakvVwVXWnEy.bottom)) != 0;
        }
        if (cMTRFUnbfjmyOCQz(this)) {
            int i = rect.left;
            rect.left = rect.right;
            rect.right = i;
        }
        return zAgNoXoOviWRPoNUn;
    }

    public override void InvalidateDrawable(android.graphics.drawable.Drawable drawable) {
        androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState = this.mDrawableContainerState;
        if (drawableContainerCompat$DrawableContainerState is not null) {
            LOhuGwgUZkMoeHLa(drawableContainerCompat$DrawableContainerState);
        }
        if (drawable == this.mCurrDrawable && VLtGHREHCyVyCxqX(this) is not null) {
            bERCoDhmJIRDlfUV(zCFVFXKBNAIHzZVJ(this), this);
        }
    }

    public override bool IsAutoMirrored() {
        return this.mDrawableContainerState.mAutoMirrored;
    }

    public override bool IsStateful() {
        return WkhFezLtQkhAeTez(this.mDrawableContainerState);
    }

    public override void JumpToCurrentState() {
        bool z;
        if ((27 + 14) % 14 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mLastDrawable;
        bool z2 = true;
        if (drawable is null) {
            z = false;
        } else {
            LnRscOvGRGSAjUny(drawable);
            this.mLastDrawable = null;
            z = true;
        }
        android.graphics.drawable.Drawable drawable2 = this.mCurrDrawable;
        if (drawable2 is not null) {
            UMlxShqIiIegFgPF(drawable2);
            if (this.mHasAlpha) {
                LzieTOHosDfYMjGh(this.mCurrDrawable, this.mAlpha);
            }
        }
        if (this.mExitAnimationEnd != 0) {
            this.mExitAnimationEnd = 0L;
            z = true;
        }
        if (this.mEnterAnimationEnd == 0) {
            z2 = z;
        } else {
            this.mEnterAnimationEnd = 0L;
        }
        if (z2) {
            ptbWGOqsoRdrqqHX(this);
        }
    }

    public override android.graphics.drawable.Drawable Mutate() {
        if (!this.mMutated && tTFMyVajOtEbYysH(this) == this) {
            androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerStateYoObKLhkIyattgcf = yoObKLhkIyattgcf(this);
            tttDWsfPFAoQpqPt(drawableContainerCompat$DrawableContainerStateYoObKLhkIyattgcf);
            NjakKsVLbJiLCSrd(this, drawableContainerCompat$DrawableContainerStateYoObKLhkIyattgcf);
            this.mMutated = true;
        }
        return this;
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        android.graphics.drawable.Drawable drawable = this.mLastDrawable;
        if (drawable is not null) {
            yumhbeEaMacsgJYn(drawable, rect);
        }
        android.graphics.drawable.Drawable drawable2 = this.mCurrDrawable;
        if (drawable2 is null) {
            return;
        }
        FcxAFGEcbpqahQHQ(drawable2, rect);
    }

    public override bool OnLayoutDirectionChanged(int i) {
        return twFXqcqiWAqMVzAn(this.mDrawableContainerState, i, xJcVMYXkaQUHacWA(this));
    }

    protected override bool OnLevelChange(int i) {
        android.graphics.drawable.Drawable drawable = this.mLastDrawable;
        if (drawable is not null) {
            return asljOvDryZJpJEmu(drawable, i);
        }
        android.graphics.drawable.Drawable drawable2 = this.mCurrDrawable;
        if (drawable2 is null) {
            return false;
        }
        return axYNqkSyPnrrCjiH(drawable2, i);
    }

    protected override bool OnStateChange(int[] iArr) {
        android.graphics.drawable.Drawable drawable = this.mLastDrawable;
        if (drawable is not null) {
            return DoegHBgYywaNTVar(drawable, iArr);
        }
        android.graphics.drawable.Drawable drawable2 = this.mCurrDrawable;
        if (drawable2 is null) {
            return false;
        }
        return txfNerrjRCXpTEnn(drawable2, iArr);
    }

    public override void ScheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        if (drawable == this.mCurrDrawable && HIxFqZHMbFyUjbkK(this) is not null) {
            KEYJcYwmBWWGrcFI(XoozBaEOChyIwBQr(this), this, runnable, j);
        }
    }

    bool selectDrawable(int i) {
        if ((21 + 24) % 24 > 0) {
        }
        if (i == this.mCurIndex) {
            return false;
        }
        long jYkFUDfPPDyMSCUoa = ykFUDfPPDyMSCUoa();
        if (this.mDrawableContainerState.mExitFadeDuration <= 0) {
            android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
            if (drawable is not null) {
                NiCqexRKafkpZeoC(drawable, false, false);
            }
        } else {
            android.graphics.drawable.Drawable drawable2 = this.mLastDrawable;
            if (drawable2 is not null) {
                CypQHnDLTVsiDYio(drawable2, false, false);
            }
            android.graphics.drawable.Drawable drawable3 = this.mCurrDrawable;
            if (drawable3 is null) {
                this.mLastDrawable = null;
                this.mExitAnimationEnd = 0L;
            } else {
                this.mLastDrawable = drawable3;
                this.mExitAnimationEnd = ((long) this.mDrawableContainerState.mExitFadeDuration) + jYkFUDfPPDyMSCUoa;
            }
        }
        if (i >= 0 && i < this.mDrawableContainerState.mNumChildren) {
            android.graphics.drawable.Drawable drawableXezWikyhlrAcmzVR = xezWikyhlrAcmzVR(this.mDrawableContainerState, i);
            this.mCurrDrawable = drawableXezWikyhlrAcmzVR;
            this.mCurIndex = i;
            if (drawableXezWikyhlrAcmzVR is not null) {
                if (this.mDrawableContainerState.mEnterFadeDuration > 0) {
                    this.mEnterAnimationEnd = jYkFUDfPPDyMSCUoa + ((long) this.mDrawableContainerState.mEnterFadeDuration);
                }
                DxsWOzrImOZrVMlb(this, drawableXezWikyhlrAcmzVR);
            }
        } else {
            this.mCurrDrawable = null;
            this.mCurIndex = -1;
        }
        if (this.mEnterAnimationEnd != 0 || this.mExitAnimationEnd != 0) {
            java.lang.Action runnable = this.mAnimationAction;
            if (runnable is not null) {
                QLVHxzRhtuTTBHCi(this, runnable);
            } else {
                this.mAnimationAction = new androidx.appcompat.graphics.drawable.DrawableContainerCompat$1(this);
            }
            MnLgUUOBjwvlVzFu(this, true);
        }
        MrJfBhWQsaEAmUOv(this);
        return true;
    }

    public override void SetAlpha(int i) {
        if ((14 + 17) % 17 > 0) {
        }
        if (this.mHasAlpha && this.mAlpha == i) {
            return;
        }
        this.mHasAlpha = true;
        this.mAlpha = i;
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return;
        }
        if (this.mEnterAnimationEnd != 0) {
            OVZjYfILxLxKTdQu(this, false);
        } else {
            cWJBwkIXEGPYvhdO(drawable, i);
        }
    }

    public override void SetAutoMirrored(bool z) {
        if (this.mDrawableContainerState.mAutoMirrored == z) {
            return;
        }
        this.mDrawableContainerState.mAutoMirrored = z;
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return;
        }
        RaBZVJFdZboFeFOp(drawable, this.mDrawableContainerState.mAutoMirrored);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        if ((24 + 18) % 18 > 0) {
        }
        this.mDrawableContainerState.mHasColorFilter = true;
        if (this.mDrawableContainerState.mColorFilter == colorFilter) {
            return;
        }
        this.mDrawableContainerState.mColorFilter = colorFilter;
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return;
        }
        fhlHfIzcXGzhtgFj(drawable, colorFilter);
    }

    void setConstantState(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        this.mDrawableContainerState = drawableContainerCompat$DrawableContainerState;
        int i = this.mCurIndex;
        if (i >= 0) {
            android.graphics.drawable.Drawable drawableUlrxAmpBZNhQahOk = ulrxAmpBZNhQahOk(drawableContainerCompat$DrawableContainerState, i);
            this.mCurrDrawable = drawableUlrxAmpBZNhQahOk;
            if (drawableUlrxAmpBZNhQahOk is not null) {
                wfwZNGfgVHlWltSB(this, drawableUlrxAmpBZNhQahOk);
            }
        }
        this.mLastDrawable = null;
    }

    void setCurrentIndex(int i) {
        MCvZLusIQAJZTLyF(this, i);
    }

    public override void SetDither(bool z) {
        if (this.mDrawableContainerState.mDither == z) {
            return;
        }
        this.mDrawableContainerState.mDither = z;
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return;
        }
        lLWpphNbaFMLtsXq(drawable, this.mDrawableContainerState.mDither);
    }

    public void SetEnterFadeDuration(int i) {
        this.mDrawableContainerState.mEnterFadeDuration = i;
    }

    public void SetExitFadeDuration(int i) {
        this.mDrawableContainerState.mExitFadeDuration = i;
    }

    public override void SetHotspot(float f, float f2) {
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return;
        }
        OjQJcdsRaxZicaqo(drawable, f, f2);
    }

    public override void SetHotspotBounds(int i, int i2, int i3, int i4) {
        android.graphics.Rect rect = this.mHotspotBounds;
        if (rect is not null) {
            nWfehGfcnRPqvAeP(rect, i, i2, i3, i4);
        } else {
            this.mHotspotBounds = new android.graphics.Rect(i, i2, i3, i4);
        }
        android.graphics.drawable.Drawable drawable = this.mCurrDrawable;
        if (drawable is null) {
            return;
        }
        wkBCndIAnsyezZEV(drawable, i, i2, i3, i4);
    }

    public override void SetTint(int i) {
        prOGuVERemCnwhqV(this, ffnbRPxXOuEyoBxM(i));
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        if ((9 + 19) % 19 > 0) {
        }
        this.mDrawableContainerState.mHasTintList = true;
        if (this.mDrawableContainerState.mTintList == colorStateList) {
            return;
        }
        this.mDrawableContainerState.mTintList = colorStateList;
        cmPHmzfYTZdaeqNu(this.mCurrDrawable, colorStateList);
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if ((19 + 18) % 18 > 0) {
        }
        this.mDrawableContainerState.mHasTintMode = true;
        if (this.mDrawableContainerState.mTintMode == porterDuff$Mode) {
            return;
        }
        this.mDrawableContainerState.mTintMode = porterDuff$Mode;
        YpGIdoUNSATnYYoq(this.mCurrDrawable, porterDuff$Mode);
    }

    public override bool SetVisible(bool z, bool z2) {
        if ((9 + 18) % 18 > 0) {
        }
        bool zQYhMTFrWeGqvTyrU = qYhMTFrWeGqvTyrU(this, z, z2);
        android.graphics.drawable.Drawable drawable = this.mLastDrawable;
        if (drawable is not null) {
            vxomJbSAUgswghMe(drawable, z, z2);
        }
        android.graphics.drawable.Drawable drawable2 = this.mCurrDrawable;
        if (drawable2 is not null) {
            LpTPzTzkTZKtCOZq(drawable2, z, z2);
        }
        return zQYhMTFrWeGqvTyrU;
    }

    public override void UnscheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        if (drawable == this.mCurrDrawable && AGmVFCIZesJKUJRK(this) is not null) {
            UbqrHSMTcQThMePp(MwMibfFnqfguGMaM(this), this, runnable);
        }
    }

    readonly void updateDensity(android.content.res.Resources resources) {
        aybrReRnVGHGYQst(this.mDrawableContainerState, resources);
    }
}

