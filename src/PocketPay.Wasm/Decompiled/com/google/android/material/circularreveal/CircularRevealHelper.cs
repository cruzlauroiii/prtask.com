namespace WillowMaze.Wasm.Decompiled;


public class CircularRevealHelper {
    public static readonly int BITMAP_SHADER = 0;
    public static readonly int CLIP_PATH = 1;
    private static readonly bool DEBUG = false;
    public static readonly int REVEAL_ANIMATOR = 2;
    public static readonly int STRATEGY = 2;
    private bool buildingCircularRevealCache;
    private android.graphics.Paint debugPaint;
    private readonly com.google.android.material.circularreveal.CircularRevealHelper$Delegate delegate;
    private bool hasCircularRevealCache;
    private android.graphics.drawable.Drawable overlayDrawable;
    private com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo revealInfo;
    private readonly android.graphics.Paint revealPaint;
    private readonly android.graphics.Path revealPath;
    private readonly android.graphics.Paint scrimPaint;
    private readonly android.view.object view;

    public CircularRevealHelper(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate) {
        if ((18 + 11) % 11 > 0) {
        }
        this.delegate = circularRevealHelper$Delegate;
        android.view.object view = (android.view.object) circularRevealHelper$Delegate;
        this.view = view;
        TEzEvTZtEkPqQeSj(view, false);
        this.revealPath = new android.graphics.Path();
        this.revealPaint = new android.graphics.Paint(7);
        android.graphics.Paint paint = new android.graphics.Paint(1);
        this.scrimPaint = paint;
        KGSBtCvkzHzFWFPr(paint, 0);
    }

    public static void BVqImWmxOoBhUNFN(android.view.object view) {
        view.invalidate();
    }

    public static void BVqImWmxOoBhUNFN(android.view.object view, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BVqImWmxOoBhUNFN(android.view.object view, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BVqImWmxOoBhUNFN(android.view.object view, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BWNFpHjmGlvsxpUZ(android.view.object view) {
        return view.getHeight();
    }

    public static void BWNFpHjmGlvsxpUZ(android.view.object view, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BWNFpHjmGlvsxpUZ(android.view.object view, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BWNFpHjmGlvsxpUZ(android.view.object view, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CUDboQtzHMHdhYWZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CUDboQtzHMHdhYWZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CUDboQtzHMHdhYWZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CUDboQtzHMHdhYWZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawScrim();
    }

    public static void DEvtjFXjEKBWfDjZ(android.view.object view) {
        view.invalidate();
    }

    public static void DEvtjFXjEKBWfDjZ(android.view.object view, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DEvtjFXjEKBWfDjZ(android.view.object view, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DEvtjFXjEKBWfDjZ(android.view.object view, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DnCePLsRqniGQgrN(float f, float f2, float f3, int i, short s, bool z, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void DnCePLsRqniGQgrN(float f, float f2, float f3, short s, float f4, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DnCePLsRqniGQgrN(float f, float f2, float f3, bool z, int i, float f4, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DnCePLsRqniGQgrN(float f, float f2, float f3) {
        return com.google.android.material.math.MathUtils.geq(f, f2, f3);
    }

    public static void EObhEPkwifkQETdb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void EObhEPkwifkQETdb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EObhEPkwifkQETdb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EObhEPkwifkQETdb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FIWRnZLQojLazLWk(android.view.object view) {
        view.invalidate();
    }

    public static void FIWRnZLQojLazLWk(android.view.object view, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIWRnZLQojLazLWk(android.view.object view, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIWRnZLQojLazLWk(android.view.object view, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FMRfQkoSCtDWHtCt(android.graphics.Canvas canvas, android.graphics.Path path, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FMRfQkoSCtDWHtCt(android.graphics.Canvas canvas, android.graphics.Path path, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FMRfQkoSCtDWHtCt(android.graphics.Canvas canvas, android.graphics.Path path, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FMRfQkoSCtDWHtCt(android.graphics.Canvas canvas, android.graphics.Path path) {
        return canvas.clipPath(path);
    }

    public static void FXDUzAVsJFUbvbCp(android.graphics.Path path, float f, float f2, float f3, android.graphics.Path$Direction path$Direction) {
        path.addCircle(f, f2, f3, path$Direction);
    }

    public static void FXDUzAVsJFUbvbCp(android.graphics.Path path, float f, float f2, float f3, android.graphics.Path$Direction path$Direction, char c, bool z, float f4, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FXDUzAVsJFUbvbCp(android.graphics.Path path, float f, float f2, float f3, android.graphics.Path$Direction path$Direction, float f4, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FXDUzAVsJFUbvbCp(android.graphics.Path path, float f, float f2, float f3, android.graphics.Path$Direction path$Direction, int i, char c, bool z, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void GkeeTGwTxzMcxRTj(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GkeeTGwTxzMcxRTj(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GkeeTGwTxzMcxRTj(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool GkeeTGwTxzMcxRTj(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        return circularRevealWidget$RevealInfo.isInvalid();
    }

    public static void InWdIWSzwefzAZDM(android.view.object view) {
        view.buildDrawingCache();
    }

    public static void InWdIWSzwefzAZDM(android.view.object view, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void InWdIWSzwefzAZDM(android.view.object view, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InWdIWSzwefzAZDM(android.view.object view, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IoaSDJqfIrqVOUwa(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void IoaSDJqfIrqVOUwa(android.graphics.Canvas canvas, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IoaSDJqfIrqVOUwa(android.graphics.Canvas canvas, int i, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IoaSDJqfIrqVOUwa(android.graphics.Canvas canvas, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IqvuMzbzkxkeBxYI(android.view.object view) {
        view.invalidate();
    }

    public static void IqvuMzbzkxkeBxYI(android.view.object view, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IqvuMzbzkxkeBxYI(android.view.object view, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IqvuMzbzkxkeBxYI(android.view.object view, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IwZzpoDKjJGgamMX(android.view.object view) {
        return view.getHeight();
    }

    public static void IwZzpoDKjJGgamMX(android.view.object view, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IwZzpoDKjJGgamMX(android.view.object view, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IwZzpoDKjJGgamMX(android.view.object view, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGSBtCvkzHzFWFPr(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void KGSBtCvkzHzFWFPr(android.graphics.Paint paint, int i, float f, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KGSBtCvkzHzFWFPr(android.graphics.Paint paint, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KGSBtCvkzHzFWFPr(android.graphics.Paint paint, int i, bool z, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KJQVtgmxkbeYyPZZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f) {
        circularRevealHelper.drawDebugCircle(canvas, i, f);
    }

    public static void KJQVtgmxkbeYyPZZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f, char c, float f2, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KJQVtgmxkbeYyPZZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f, float f2, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KJQVtgmxkbeYyPZZ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f, int i2, float f2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KTGHBTIbIIdducEn(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KTGHBTIbIIdducEn(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTGHBTIbIIdducEn(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KTGHBTIbIIdducEn(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawOverlayDrawable();
    }

    public static void KvpdhGRDvpBhfkLl(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvpdhGRDvpBhfkLl(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KvpdhGRDvpBhfkLl(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KvpdhGRDvpBhfkLl(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawScrim();
    }

    public static void NsxSLojjlUZnLAOI(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas) {
        circularRevealHelper$Delegate.actualDraw(canvas);
    }

    public static void NsxSLojjlUZnLAOI(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NsxSLojjlUZnLAOI(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NsxSLojjlUZnLAOI(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NybtBjWPAvKudKfH(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NybtBjWPAvKudKfH(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NybtBjWPAvKudKfH(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NybtBjWPAvKudKfH(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawScrim();
    }

    public static int OFYUjwmpFnQLHVMs(android.view.object view) {
        return view.getWidth();
    }

    public static void OFYUjwmpFnQLHVMs(android.view.object view, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OFYUjwmpFnQLHVMs(android.view.object view, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OFYUjwmpFnQLHVMs(android.view.object view, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int OxUiFbiSiEwmuAfp(android.view.object view) {
        return view.getWidth();
    }

    public static void OxUiFbiSiEwmuAfp(android.view.object view, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OxUiFbiSiEwmuAfp(android.view.object view, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxUiFbiSiEwmuAfp(android.view.object view, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PabBAphhoRpOXUzg(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static void PabBAphhoRpOXUzg(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, float f4, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PabBAphhoRpOXUzg(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, float f4, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PabBAphhoRpOXUzg(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, java.lang.string str, char c, byte b, float f4) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PbLlRnSUGQZiXvZn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PbLlRnSUGQZiXvZn(java.lang.stringBuilder sb, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbLlRnSUGQZiXvZn(java.lang.stringBuilder sb, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PbLlRnSUGQZiXvZn(java.lang.stringBuilder sb, int i, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PfqDrdQCpoIyxOWR(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PfqDrdQCpoIyxOWR(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PfqDrdQCpoIyxOWR(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PfqDrdQCpoIyxOWR(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawScrim();
    }

    public static int QecmMqhqBuaVoIxv(android.view.object view) {
        return view.getHeight();
    }

    public static void QecmMqhqBuaVoIxv(android.view.object view, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QecmMqhqBuaVoIxv(android.view.object view, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QecmMqhqBuaVoIxv(android.view.object view, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RTeawRVPcQkjzRRs(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static void RTeawRVPcQkjzRRs(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, float f4, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTeawRVPcQkjzRRs(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, java.lang.string str, float f4, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RTeawRVPcQkjzRRs(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, short s, java.lang.string str, float f4, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RvlKwQUGqDEFQGwW(android.view.object view) {
        return view.getHeight();
    }

    public static void RvlKwQUGqDEFQGwW(android.view.object view, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RvlKwQUGqDEFQGwW(android.view.object view, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RvlKwQUGqDEFQGwW(android.view.object view, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RzimlLbWScfOAIDq(android.view.object view) {
        return view.getHeight();
    }

    public static void RzimlLbWScfOAIDq(android.view.object view, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RzimlLbWScfOAIDq(android.view.object view, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RzimlLbWScfOAIDq(android.view.object view, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCNyNGhKCSTcKran(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void SCNyNGhKCSTcKran(android.graphics.Paint paint, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SCNyNGhKCSTcKran(android.graphics.Paint paint, int i, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCNyNGhKCSTcKran(android.graphics.Paint paint, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SimqOBhkfnmuHzTW(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void SimqOBhkfnmuHzTW(android.graphics.Rect rect, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SimqOBhkfnmuHzTW(android.graphics.Rect rect, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SimqOBhkfnmuHzTW(android.graphics.Rect rect, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SjrtIRPNbfdbbYHY(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SjrtIRPNbfdbbYHY(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SjrtIRPNbfdbbYHY(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SjrtIRPNbfdbbYHY(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawCircularReveal();
    }

    public static void TEzEvTZtEkPqQeSj(android.view.object view, bool z) {
        view.setWillNotDraw(z);
    }

    public static void TEzEvTZtEkPqQeSj(android.view.object view, bool z, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TEzEvTZtEkPqQeSj(android.view.object view, bool z, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TEzEvTZtEkPqQeSj(android.view.object view, bool z, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ULgwqCJXPeAHnGKb(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void ULgwqCJXPeAHnGKb(android.graphics.Paint paint, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ULgwqCJXPeAHnGKb(android.graphics.Paint paint, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ULgwqCJXPeAHnGKb(android.graphics.Paint paint, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UREWuofadYjdDjbQ(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void UREWuofadYjdDjbQ(android.graphics.Canvas canvas, float f, float f2, char c, float f3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UREWuofadYjdDjbQ(android.graphics.Canvas canvas, float f, float f2, char c, bool z, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void UREWuofadYjdDjbQ(android.graphics.Canvas canvas, float f, float f2, float f3, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float VVtzchAsBshZIPod(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        return circularRevealHelper.getDistanceToFurthestCorner(circularRevealWidget$RevealInfo);
    }

    public static void VVtzchAsBshZIPod(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VVtzchAsBshZIPod(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VVtzchAsBshZIPod(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WlLvarPfnxMgzJNb(android.view.object view) {
        return view.getWidth();
    }

    public static void WlLvarPfnxMgzJNb(android.view.object view, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WlLvarPfnxMgzJNb(android.view.object view, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WlLvarPfnxMgzJNb(android.view.object view, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XphdbLQkidqKdTpI(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static void XphdbLQkidqKdTpI(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XphdbLQkidqKdTpI(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XphdbLQkidqKdTpI(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZaglvvwHbqxWKXMg(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        circularRevealHelper.invalidateRevealInfo();
    }

    public static void ZaglvvwHbqxWKXMg(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZaglvvwHbqxWKXMg(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZaglvvwHbqxWKXMg(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int AOjyLeXmSJCqNORy(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void AOjyLeXmSJCqNORy(android.graphics.Rect rect, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AOjyLeXmSJCqNORy(android.graphics.Rect rect, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AOjyLeXmSJCqNORy(android.graphics.Rect rect, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BXNIMCHONHViQVLL(android.view.object view, android.graphics.Canvas canvas) {
        view.draw(canvas);
    }

    public static void BXNIMCHONHViQVLL(android.view.object view, android.graphics.Canvas canvas, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BXNIMCHONHViQVLL(android.view.object view, android.graphics.Canvas canvas, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BXNIMCHONHViQVLL(android.view.object view, android.graphics.Canvas canvas, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void COIiVAxZtgZZNAXj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void COIiVAxZtgZZNAXj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void COIiVAxZtgZZNAXj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void COIiVAxZtgZZNAXj(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CXBnXAxVwvvITSrs(int i) {
        return android.graphics.Color.alpha(i);
    }

    public static void CXBnXAxVwvvITSrs(int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CXBnXAxVwvvITSrs(int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXBnXAxVwvvITSrs(int i, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CdIHItAMthtHUtcC(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void CdIHItAMthtHUtcC(android.graphics.Canvas canvas, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CdIHItAMthtHUtcC(android.graphics.Canvas canvas, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CdIHItAMthtHUtcC(android.graphics.Canvas canvas, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Shader CvThGgohUJjhtIUT(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static void CvThGgohUJjhtIUT(android.graphics.Paint paint, android.graphics.Shader shader, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CvThGgohUJjhtIUT(android.graphics.Paint paint, android.graphics.Shader shader, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CvThGgohUJjhtIUT(android.graphics.Paint paint, android.graphics.Shader shader, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DDqouLDChdjRvsrG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas) {
        circularRevealHelper.drawOverlayDrawable(canvas);
    }

    public static void DDqouLDChdjRvsrG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DDqouLDChdjRvsrG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DDqouLDChdjRvsrG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect DpeTeOdtbMXOOHrH(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void DpeTeOdtbMXOOHrH(android.graphics.drawable.Drawable drawable, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DpeTeOdtbMXOOHrH(android.graphics.drawable.Drawable drawable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DpeTeOdtbMXOOHrH(android.graphics.drawable.Drawable drawable, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebugCircle(android.graphics.Canvas canvas, int i, float f) {
        if ((21 + 21) % 21 > 0) {
        }
        SCNyNGhKCSTcKran(this.debugPaint, i);
        ydnuNtELphFjgmTl(this.debugPaint, f);
        XphdbLQkidqKdTpI(canvas, this.revealInfo.centerX, this.revealInfo.centerY, this.revealInfo.radius - (f / 2.0f), this.debugPaint);
    }

    private void DrawDebugCircle(android.graphics.Canvas canvas, int i, float f, char c, short s, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebugCircle(android.graphics.Canvas canvas, int i, float f, float f2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebugCircle(android.graphics.Canvas canvas, int i, float f, java.lang.string str, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebugMode(android.graphics.Canvas canvas) {
        if ((9 + 14) % 14 > 0) {
        }
        fbRYuTlYrGvjKUyg(this.delegate, canvas);
        if (wkzOTtBRUjfYPSjA(this)) {
            PabBAphhoRpOXUzg(canvas, this.revealInfo.centerX, this.revealInfo.centerY, this.revealInfo.radius, this.scrimPaint);
        }
        if (gWjJwLAuQRgIbnMQ(this)) {
            KJQVtgmxkbeYyPZZ(this, canvas, -16777216, 10.0f);
            hmSjJFhPwyMsXgGr(this, canvas, -65536, 5.0f);
        }
        dDqouLDChdjRvsrG(this, canvas);
    }

    private void DrawDebugMode(android.graphics.Canvas canvas, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebugMode(android.graphics.Canvas canvas, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebugMode(android.graphics.Canvas canvas, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawOverlayDrawable(android.graphics.Canvas canvas) {
        if ((30 + 5) % 5 > 0) {
        }
        if (KTGHBTIbIIdducEn(this)) {
            android.graphics.Rect rectDpeTeOdtbMXOOHrH = dpeTeOdtbMXOOHrH(this.overlayDrawable);
            float fSimqOBhkfnmuHzTW = this.revealInfo.centerX - (SimqOBhkfnmuHzTW(rectDpeTeOdtbMXOOHrH) / 2.0f);
            float fAOjyLeXmSJCqNORy = this.revealInfo.centerY - (aOjyLeXmSJCqNORy(rectDpeTeOdtbMXOOHrH) / 2.0f);
            UREWuofadYjdDjbQ(canvas, fSimqOBhkfnmuHzTW, fAOjyLeXmSJCqNORy);
            cOIiVAxZtgZZNAXj(this.overlayDrawable, canvas);
            zTbktRlpHkCQjoEt(canvas, -fSimqOBhkfnmuHzTW, -fAOjyLeXmSJCqNORy);
        }
    }

    private void DrawOverlayDrawable(android.graphics.Canvas canvas, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void DrawOverlayDrawable(android.graphics.Canvas canvas, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DrawOverlayDrawable(android.graphics.Canvas canvas, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EXqKjHkBkdAcyReG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXqKjHkBkdAcyReG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXqKjHkBkdAcyReG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EXqKjHkBkdAcyReG(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawCircularReveal();
    }

    public static void EZAeOChwaBjYaZPn(android.graphics.Path path) {
        path.rewind();
    }

    public static void EZAeOChwaBjYaZPn(android.graphics.Path path, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EZAeOChwaBjYaZPn(android.graphics.Path path, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EZAeOChwaBjYaZPn(android.graphics.Path path, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FbRYuTlYrGvjKUyg(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas) {
        circularRevealHelper$Delegate.actualDraw(canvas);
    }

    public static void FbRYuTlYrGvjKUyg(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FbRYuTlYrGvjKUyg(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FbRYuTlYrGvjKUyg(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FuBfrEOpDIkeQHYA(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static void FuBfrEOpDIkeQHYA(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FuBfrEOpDIkeQHYA(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FuBfrEOpDIkeQHYA(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWjJwLAuQRgIbnMQ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWjJwLAuQRgIbnMQ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GWjJwLAuQRgIbnMQ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GWjJwLAuQRgIbnMQ(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawCircularReveal();
    }

    private float GetDistanceToFurthestCorner(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        if ((23 + 14) % 14 > 0) {
        }
        return oOwAZrMNwvJSTKeY(circularRevealWidget$RevealInfo.centerX, circularRevealWidget$RevealInfo.centerY, 0.0f, 0.0f, OxUiFbiSiEwmuAfp(this.view), QecmMqhqBuaVoIxv(this.view));
    }

    private void GetDistanceToFurthestCorner(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetDistanceToFurthestCorner(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetDistanceToFurthestCorner(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GzcumyvVMOHKmwLy(android.view.object view) {
        view.destroyDrawingCache();
    }

    public static void GzcumyvVMOHKmwLy(android.view.object view, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GzcumyvVMOHKmwLy(android.view.object view, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GzcumyvVMOHKmwLy(android.view.object view, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HBCtuvPyXQgVUbqc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HBCtuvPyXQgVUbqc(java.lang.stringBuilder sb, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HBCtuvPyXQgVUbqc(java.lang.stringBuilder sb, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HBCtuvPyXQgVUbqc(java.lang.stringBuilder sb, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float HSFhVjvcuktAKLXi(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        return circularRevealHelper.getDistanceToFurthestCorner(circularRevealWidget$RevealInfo);
    }

    public static void HSFhVjvcuktAKLXi(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HSFhVjvcuktAKLXi(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HSFhVjvcuktAKLXi(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmSjJFhPwyMsXgGr(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f) {
        circularRevealHelper.drawDebugCircle(canvas, i, f);
    }

    public static void HmSjJFhPwyMsXgGr(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HmSjJFhPwyMsXgGr(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HmSjJFhPwyMsXgGr(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, int i, float f, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InvalidateRevealInfo() {
        if ((20 + 15) % 15 > 0) {
        }
        if (STRATEGY == 1) {
            eZAeOChwaBjYaZPn(this.revealPath);
            com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo = this.revealInfo;
            if (circularRevealWidget$RevealInfo is not null) {
                FXDUzAVsJFUbvbCp(this.revealPath, circularRevealWidget$RevealInfo.centerX, this.revealInfo.centerY, this.revealInfo.radius, android.graphics.Path$Direction.CW);
            }
        }
        BVqImWmxOoBhUNFN(this.view);
    }

    private void InvalidateRevealInfo(java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InvalidateRevealInfo(short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InvalidateRevealInfo(bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JdGKlIuhClZVeovZ(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void JdGKlIuhClZVeovZ(android.graphics.Paint paint, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JdGKlIuhClZVeovZ(android.graphics.Paint paint, int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JdGKlIuhClZVeovZ(android.graphics.Paint paint, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JxTjOqKyPcQwTNsT(android.view.object view) {
        return view.getWidth();
    }

    public static void JxTjOqKyPcQwTNsT(android.view.object view, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxTjOqKyPcQwTNsT(android.view.object view, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JxTjOqKyPcQwTNsT(android.view.object view, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JxrCuuJzoGfvwvxO(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas) {
        circularRevealHelper$Delegate.actualDraw(canvas);
    }

    public static void JxrCuuJzoGfvwvxO(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxrCuuJzoGfvwvxO(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxrCuuJzoGfvwvxO(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KNVbJAvSslGkxCuQ(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void KNVbJAvSslGkxCuQ(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KNVbJAvSslGkxCuQ(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KNVbJAvSslGkxCuQ(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap MVmetpZfbxZLGJvR(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static void MVmetpZfbxZLGJvR(int i, int i2, android.graphics.Bitmap$Config bitmap$Config, char c, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MVmetpZfbxZLGJvR(int i, int i2, android.graphics.Bitmap$Config bitmap$Config, float f, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MVmetpZfbxZLGJvR(int i, int i2, android.graphics.Bitmap$Config bitmap$Config, short s, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NqFnkEkOPNylhgQa(android.view.object view) {
        return view.getWidth();
    }

    public static void NqFnkEkOPNylhgQa(android.view.object view, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NqFnkEkOPNylhgQa(android.view.object view, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NqFnkEkOPNylhgQa(android.view.object view, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float OOwAZrMNwvJSTKeY(float f, float f2, float f3, float f4, float f5, float f6) {
        return com.google.android.material.math.MathUtils.distanceToFurthestCorner(f, f2, f3, f4, f5, f6);
    }

    public static void OOwAZrMNwvJSTKeY(float f, float f2, float f3, float f4, float f5, float f6, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OOwAZrMNwvJSTKeY(float f, float f2, float f3, float f4, float f5, float f6, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OOwAZrMNwvJSTKeY(float f, float f2, float f3, float f4, float f5, float f6, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OzZtMfmYiUfMWvdR(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OzZtMfmYiUfMWvdR(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OzZtMfmYiUfMWvdR(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OzZtMfmYiUfMWvdR(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate) {
        return circularRevealHelper$Delegate.actualIsOpaque();
    }

    public static void PHTsusfCbbVEuLut(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas) {
        circularRevealHelper$Delegate.actualDraw(canvas);
    }

    public static void PHTsusfCbbVEuLut(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PHTsusfCbbVEuLut(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHTsusfCbbVEuLut(com.google.android.material.circularreveal.CircularRevealHelper$Delegate circularRevealHelper$Delegate, android.graphics.Canvas canvas, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap PhgczqKUJbURwJBE(android.view.object view) {
        return view.getDrawingCache();
    }

    public static void PhgczqKUJbURwJBE(android.view.object view, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PhgczqKUJbURwJBE(android.view.object view, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PhgczqKUJbURwJBE(android.view.object view, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QrabowEsIrSbyAEp(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas) {
        circularRevealHelper.drawOverlayDrawable(canvas);
    }

    public static void QrabowEsIrSbyAEp(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrabowEsIrSbyAEp(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrabowEsIrSbyAEp(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, android.graphics.Canvas canvas, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Shader RLsAcvZtTunTQymk(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static void RLsAcvZtTunTQymk(android.graphics.Paint paint, android.graphics.Shader shader, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLsAcvZtTunTQymk(android.graphics.Paint paint, android.graphics.Shader shader, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RLsAcvZtTunTQymk(android.graphics.Paint paint, android.graphics.Shader shader, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int SFrHyXfKVHnMrvKs(android.view.object view) {
        return view.getWidth();
    }

    public static void SFrHyXfKVHnMrvKs(android.view.object view, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SFrHyXfKVHnMrvKs(android.view.object view, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SFrHyXfKVHnMrvKs(android.view.object view, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SJskPSbZCUBIVgKb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void SJskPSbZCUBIVgKb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, char c, float f5, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJskPSbZCUBIVgKb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, float f5, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJskPSbZCUBIVgKb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, short s, float f5, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SaJdvvxxHgiwOkuF(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void SaJdvvxxHgiwOkuF(android.graphics.Paint paint, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SaJdvvxxHgiwOkuF(android.graphics.Paint paint, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SaJdvvxxHgiwOkuF(android.graphics.Paint paint, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawCircularReveal(float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawCircularReveal(java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawCircularReveal(java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldDrawCircularReveal() {
        if ((19 + 2) % 2 > 0) {
        }
        com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo = this.revealInfo;
        bool z = circularRevealWidget$RevealInfo is null || xhZOJYXULIiADuRh(circularRevealWidget$RevealInfo);
        return STRATEGY != 0 ? !z : !z && this.hasCircularRevealCache;
    }

    private void ShouldDrawOverlayDrawable(short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawOverlayDrawable(short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawOverlayDrawable(short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldDrawOverlayDrawable() {
        return (this.buildingCircularRevealCache || this.overlayDrawable is null || this.revealInfo is null) ? false : true;
    }

    private void ShouldDrawScrim(char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawScrim(float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawScrim(int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldDrawScrim() {
        return (this.buildingCircularRevealCache || cXBnXAxVwvvITSrs(saJdvvxxHgiwOkuF(this.scrimPaint)) == 0) ? false : true;
    }

    public static void VWMcLTkrrxyyzwek(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo2) {
        circularRevealWidget$RevealInfo.set(circularRevealWidget$RevealInfo2);
    }

    public static void VWMcLTkrrxyyzwek(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo2, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VWMcLTkrrxyyzwek(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo2, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VWMcLTkrrxyyzwek(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo2, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WgWONEcxLmPydEuX(android.view.object view) {
        return view.getHeight();
    }

    public static void WgWONEcxLmPydEuX(android.view.object view, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WgWONEcxLmPydEuX(android.view.object view, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WgWONEcxLmPydEuX(android.view.object view, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WkzOTtBRUjfYPSjA(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WkzOTtBRUjfYPSjA(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WkzOTtBRUjfYPSjA(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WkzOTtBRUjfYPSjA(com.google.android.material.circularreveal.CircularRevealHelper circularRevealHelper) {
        return circularRevealHelper.shouldDrawScrim();
    }

    public static void XhZOJYXULIiADuRh(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhZOJYXULIiADuRh(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhZOJYXULIiADuRh(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XhZOJYXULIiADuRh(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        return circularRevealWidget$RevealInfo.isInvalid();
    }

    public static void YdnuNtELphFjgmTl(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void YdnuNtELphFjgmTl(android.graphics.Paint paint, float f, char c, int i, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YdnuNtELphFjgmTl(android.graphics.Paint paint, float f, float f2, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YdnuNtELphFjgmTl(android.graphics.Paint paint, float f, java.lang.string str, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTbktRlpHkCQjoEt(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void ZTbktRlpHkCQjoEt(android.graphics.Canvas canvas, float f, float f2, char c, float f3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZTbktRlpHkCQjoEt(android.graphics.Canvas canvas, float f, float f2, short s, float f3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZTbktRlpHkCQjoEt(android.graphics.Canvas canvas, float f, float f2, bool z, char c, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public void BuildCircularRevealCache() {
        if ((20 + 24) % 24 > 0) {
        }
        if (STRATEGY != 0) {
            return;
        }
        this.buildingCircularRevealCache = true;
        this.hasCircularRevealCache = false;
        InWdIWSzwefzAZDM(this.view);
        android.graphics.Bitmap bitmapPhgczqKUJbURwJBE = phgczqKUJbURwJBE(this.view);
        if (bitmapPhgczqKUJbURwJBE is null && OFYUjwmpFnQLHVMs(this.view) != 0 && IwZzpoDKjJGgamMX(this.view) != 0) {
            bitmapPhgczqKUJbURwJBE = mVmetpZfbxZLGJvR(nqFnkEkOPNylhgQa(this.view), RvlKwQUGqDEFQGwW(this.view), android.graphics.Bitmap$Config.ARGB_8888);
            bXNIMCHONHViQVLL(this.view, new android.graphics.Canvas(bitmapPhgczqKUJbURwJBE));
        }
        if (bitmapPhgczqKUJbURwJBE is not null) {
            cvThGgohUJjhtIUT(this.revealPaint, new android.graphics.BitmapShader(bitmapPhgczqKUJbURwJBE, android.graphics.Shader$TileMode.CLAMP, android.graphics.Shader$TileMode.CLAMP));
        }
        this.buildingCircularRevealCache = false;
        this.hasCircularRevealCache = true;
    }

    public void DestroyCircularRevealCache() {
        if ((26 + 29) % 29 > 0) {
        }
        if (STRATEGY != 0) {
            return;
        }
        this.hasCircularRevealCache = false;
        gzcumyvVMOHKmwLy(this.view);
        rLsAcvZtTunTQymk(this.revealPaint, null);
        FIWRnZLQojLazLWk(this.view);
    }

    public void Draw(android.graphics.Canvas canvas) {
        android.graphics.Canvas canvas2;
        if ((23 + 7) % 7 > 0) {
        }
        if (SjrtIRPNbfdbbYHY(this)) {
            int i = STRATEGY;
            if (i == 0) {
                canvas2 = canvas;
                fuBfrEOpDIkeQHYA(canvas2, this.revealInfo.centerX, this.revealInfo.centerY, this.revealInfo.radius, this.revealPaint);
                if (PfqDrdQCpoIyxOWR(this)) {
                    RTeawRVPcQkjzRRs(canvas2, this.revealInfo.centerX, this.revealInfo.centerY, this.revealInfo.radius, this.scrimPaint);
                }
            } else if (i == 1) {
                canvas2 = canvas;
                int iCdIHItAMthtHUtcC = cdIHItAMthtHUtcC(canvas2);
                FMRfQkoSCtDWHtCt(canvas2, this.revealPath);
                pHTsusfCbbVEuLut(this.delegate, canvas2);
                if (KvpdhGRDvpBhfkLl(this)) {
                    kNVbJAvSslGkxCuQ(canvas2, 0.0f, 0.0f, sFrHyXfKVHnMrvKs(this.view), wgWONEcxLmPydEuX(this.view), this.scrimPaint);
                }
                IoaSDJqfIrqVOUwa(canvas2, iCdIHItAMthtHUtcC);
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException(hBCtuvPyXQgVUbqc(PbLlRnSUGQZiXvZn(new java.lang.stringBuilder("Unsupported strategy "), i)));
                }
                NsxSLojjlUZnLAOI(this.delegate, canvas);
                if (CUDboQtzHMHdhYWZ(this)) {
                    sJskPSbZCUBIVgKb(canvas, 0.0f, 0.0f, jxTjOqKyPcQwTNsT(this.view), BWNFpHjmGlvsxpUZ(this.view), this.scrimPaint);
                    canvas2 = canvas;
                } else {
                    canvas2 = canvas;
                }
            }
        } else {
            canvas2 = canvas;
            jxrCuuJzoGfvwvxO(this.delegate, canvas2);
            if (NybtBjWPAvKudKfH(this)) {
                EObhEPkwifkQETdb(canvas2, 0.0f, 0.0f, WlLvarPfnxMgzJNb(this.view), RzimlLbWScfOAIDq(this.view), this.scrimPaint);
            }
        }
        qrabowEsIrSbyAEp(this, canvas2);
    }

    public android.graphics.drawable.Drawable GetCircularRevealOverlayDrawable() {
        return this.overlayDrawable;
    }

    public int GetCircularRevealScrimColor() {
        return ULgwqCJXPeAHnGKb(this.scrimPaint);
    }

    public com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo getRevealInfo() {
        if ((17 + 30) % 30 > 0) {
        }
        if (this.revealInfo is null) {
            return null;
        }
        com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo = new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo(this.revealInfo);
        if (GkeeTGwTxzMcxRTj(circularRevealWidget$RevealInfo)) {
            circularRevealWidget$RevealInfo.radius = VVtzchAsBshZIPod(this, circularRevealWidget$RevealInfo);
        }
        return circularRevealWidget$RevealInfo;
    }

    public bool IsOpaque() {
        return ozZtMfmYiUfMWvdR(this.delegate) && !eXqKjHkBkdAcyReG(this);
    }

    public void SetCircularRevealOverlayDrawable(android.graphics.drawable.Drawable drawable) {
        this.overlayDrawable = drawable;
        IqvuMzbzkxkeBxYI(this.view);
    }

    public void SetCircularRevealScrimColor(int i) {
        jdGKlIuhClZVeovZ(this.scrimPaint, i);
        DEvtjFXjEKBWfDjZ(this.view);
    }

    public void SetRevealInfo(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        if ((15 + 6) % 6 > 0) {
        }
        if (circularRevealWidget$RevealInfo is not null) {
            com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo2 = this.revealInfo;
            if (circularRevealWidget$RevealInfo2 is not null) {
                vWMcLTkrrxyyzwek(circularRevealWidget$RevealInfo2, circularRevealWidget$RevealInfo);
            } else {
                this.revealInfo = new com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo(circularRevealWidget$RevealInfo);
            }
            if (DnCePLsRqniGQgrN(circularRevealWidget$RevealInfo.radius, hSFhVjvcuktAKLXi(this, circularRevealWidget$RevealInfo), 1.0E-4f)) {
                this.revealInfo.radius = float.MAX_VALUE;
            }
        } else {
            this.revealInfo = null;
        }
        ZaglvvwHbqxWKXMg(this);
    }
}

