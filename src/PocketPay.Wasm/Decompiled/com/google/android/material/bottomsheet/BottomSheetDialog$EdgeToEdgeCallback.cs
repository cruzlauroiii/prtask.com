namespace WillowMaze.Wasm.Decompiled;


class BottomSheetDialog$EdgeToEdgeCallback : com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback {
    private readonly androidx.core.view.WindowInsetsCompat insetsCompat;
    private readonly java.lang.bool lightBottomSheet;
    private bool lightStatusBar;
    private android.view.Window window;

    private BottomSheetDialog$EdgeToEdgeCallback(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        this.insetsCompat = windowInsetsCompat;
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawableFPAqpeaSENzePVsW = fPAqpeaSENzePVsW(delsxCPCFGmHjsao(view));
        android.content.res.ColorStateList colorStateListHXIZhKbkLjFcejcv = materialShapeDrawableFPAqpeaSENzePVsW is null ? hXIZhKbkLjFcejcv(view) : YkouSRAHTBsLxpOp(materialShapeDrawableFPAqpeaSENzePVsW);
        if (colorStateListHXIZhKbkLjFcejcv is not null) {
            this.lightBottomSheet = xgieKnPLHXbrvFik(qYsHXGWusXvtzCvl(kDbqqGIYnJqKZRaz(colorStateListHXIZhKbkLjFcejcv)));
            return;
        }
        java.lang.int numMyukMMbvGZJVdaLc = myukMMbvGZJVdaLc(view);
        if (numMyukMMbvGZJVdaLc is null) {
            this.lightBottomSheet = null;
        } else {
            this.lightBottomSheet = clhbWxfLJGlabzxl(NdgnfAMeIgXaBjuz(UMrmfSugUrXGLenY(numMyukMMbvGZJVdaLc)));
        }
    }

    BottomSheetDialog$EdgeToEdgeCallback(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, com.google.android.material.bottomsheet.BottomSheetDialog$1 bottomSheetDialog$1) {
        this(view, windowInsetsCompat);
    }

    public static void ADUpnKQpkzDsVfkx(android.view.Window window, bool z) {
        com.google.android.material.internal.EdgeToEdgeUtils.setLightStatusBar(window, z);
    }

    public static void ADUpnKQpkzDsVfkx(android.view.Window window, bool z, char c, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ADUpnKQpkzDsVfkx(android.view.Window window, bool z, char c, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ADUpnKQpkzDsVfkx(android.view.Window window, bool z, char c, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HzDiOGKqEcaswoMt(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void HzDiOGKqEcaswoMt(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HzDiOGKqEcaswoMt(androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HzDiOGKqEcaswoMt(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxRYPfwytvJdFrBv(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view) {
        bottomSheetDialog$EdgeToEdgeCallback.setPaddingForPosition(view);
    }

    public static void IxRYPfwytvJdFrBv(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxRYPfwytvJdFrBv(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxRYPfwytvJdFrBv(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KQxiNrIJcOxtsFUS(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    public static void KQxiNrIJcOxtsFUS(android.view.object view, int i, int i2, int i3, int i4, byte b, java.lang.string str, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void KQxiNrIJcOxtsFUS(android.view.object view, int i, int i2, int i3, int i4, java.lang.string str, byte b, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void KQxiNrIJcOxtsFUS(android.view.object view, int i, int i2, int i3, int i4, java.lang.string str, int i5, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NDNVwMVbTVRmROzD(android.view.object view) {
        return view.getPaddingBottom();
    }

    public static void NDNVwMVbTVRmROzD(android.view.object view, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NDNVwMVbTVRmROzD(android.view.object view, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NDNVwMVbTVRmROzD(android.view.object view, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NbCeBHdtKZFOjmJc(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    public static void NbCeBHdtKZFOjmJc(android.view.object view, int i, int i2, int i3, int i4, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NbCeBHdtKZFOjmJc(android.view.object view, int i, int i2, int i3, int i4, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NbCeBHdtKZFOjmJc(android.view.object view, int i, int i2, int i3, int i4, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NbfXqkGJYWdrADry(android.view.object view) {
        return view.getTop();
    }

    public static void NbfXqkGJYWdrADry(android.view.object view, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NbfXqkGJYWdrADry(android.view.object view, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbfXqkGJYWdrADry(android.view.object view, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NdgnfAMeIgXaBjuz(int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdgnfAMeIgXaBjuz(int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdgnfAMeIgXaBjuz(int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NdgnfAMeIgXaBjuz(int i) {
        return com.google.android.material.color.MaterialColors.isColorLight(i);
    }

    public static int QfURVwtdYVIaEcBi(android.view.object view) {
        return view.getTop();
    }

    public static void QfURVwtdYVIaEcBi(android.view.object view, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QfURVwtdYVIaEcBi(android.view.object view, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QfURVwtdYVIaEcBi(android.view.object view, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SyETZLdmxbLqcBnp(android.view.Window window, bool z) {
        com.google.android.material.internal.EdgeToEdgeUtils.setLightStatusBar(window, z);
    }

    public static void SyETZLdmxbLqcBnp(android.view.Window window, bool z, char c, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SyETZLdmxbLqcBnp(android.view.Window window, bool z, char c, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SyETZLdmxbLqcBnp(android.view.Window window, bool z, bool z2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TAOqSbRfbUSfClZq(android.view.Window window) {
        return window.getDecorobject();
    }

    public static void TAOqSbRfbUSfClZq(android.view.Window window, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TAOqSbRfbUSfClZq(android.view.Window window, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TAOqSbRfbUSfClZq(android.view.Window window, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int UMrmfSugUrXGLenY(java.lang.int num) {
        return num.intValue();
    }

    public static void UMrmfSugUrXGLenY(java.lang.int num, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UMrmfSugUrXGLenY(java.lang.int num, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMrmfSugUrXGLenY(java.lang.int num, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WLRckVUmigxxqSXQ(androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WLRckVUmigxxqSXQ(androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WLRckVUmigxxqSXQ(androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WLRckVUmigxxqSXQ(androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat) {
        return windowInsetsControllerCompat.isAppearanceLightStatusBars();
    }

    public static android.content.res.ColorStateList YkouSRAHTBsLxpOp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static void YkouSRAHTBsLxpOp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YkouSRAHTBsLxpOp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkouSRAHTBsLxpOp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BoZuppmoJPRLABNU(android.view.object view) {
        return view.getPaddingLeft();
    }

    public static void BoZuppmoJPRLABNU(android.view.object view, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoZuppmoJPRLABNU(android.view.object view, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoZuppmoJPRLABNU(android.view.object view, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CiLBoXTmtsjYIYVV(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view) {
        bottomSheetDialog$EdgeToEdgeCallback.setPaddingForPosition(view);
    }

    public static void CiLBoXTmtsjYIYVV(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CiLBoXTmtsjYIYVV(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CiLBoXTmtsjYIYVV(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool ClhbWxfLJGlabzxl(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void ClhbWxfLJGlabzxl(bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ClhbWxfLJGlabzxl(bool z, float f, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ClhbWxfLJGlabzxl(bool z, bool z2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomsheet.BottomSheetBehavior DelsxCPCFGmHjsao(android.view.object view) {
        return com.google.android.material.bottomsheet.BottomSheetBehavior.from(view);
    }

    public static void DelsxCPCFGmHjsao(android.view.object view, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DelsxCPCFGmHjsao(android.view.object view, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DelsxCPCFGmHjsao(android.view.object view, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable FPAqpeaSENzePVsW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getMaterialShapeDrawable();
    }

    public static void FPAqpeaSENzePVsW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FPAqpeaSENzePVsW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FPAqpeaSENzePVsW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FYoOeTdDxQpCzCIi(android.view.object view) {
        return view.getPaddingLeft();
    }

    public static void FYoOeTdDxQpCzCIi(android.view.object view, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FYoOeTdDxQpCzCIi(android.view.object view, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FYoOeTdDxQpCzCIi(android.view.object view, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList HXIZhKbkLjFcejcv(android.view.object view) {
        return androidx.core.view.objectCompat.getBackgroundTintList(view);
    }

    public static void HXIZhKbkLjFcejcv(android.view.object view, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HXIZhKbkLjFcejcv(android.view.object view, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HXIZhKbkLjFcejcv(android.view.object view, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int JMzUqGsqWmjasEsO(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void JMzUqGsqWmjasEsO(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMzUqGsqWmjasEsO(androidx.core.view.WindowInsetsCompat windowInsetsCompat, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMzUqGsqWmjasEsO(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KDbqqGIYnJqKZRaz(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void KDbqqGIYnJqKZRaz(android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KDbqqGIYnJqKZRaz(android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDbqqGIYnJqKZRaz(android.content.res.ColorStateList colorStateList, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LlfzqkElZJzVoamd(android.view.object view) {
        return view.getPaddingRight();
    }

    public static void LlfzqkElZJzVoamd(android.view.object view, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LlfzqkElZJzVoamd(android.view.object view, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LlfzqkElZJzVoamd(android.view.object view, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int MyukMMbvGZJVdaLc(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getBackgroundColor(view);
    }

    public static void MyukMMbvGZJVdaLc(android.view.object view, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MyukMMbvGZJVdaLc(android.view.object view, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MyukMMbvGZJVdaLc(android.view.object view, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.WindowInsetsControllerCompat NhVotdqxFdgcesYc(android.view.Window window, android.view.object view) {
        return androidx.core.view.WindowCompat.getInsetsController(window, view);
    }

    public static void NhVotdqxFdgcesYc(android.view.Window window, android.view.object view, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NhVotdqxFdgcesYc(android.view.Window window, android.view.object view, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NhVotdqxFdgcesYc(android.view.Window window, android.view.object view, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OcHyDfszXLqQburM(android.view.object view) {
        return view.getPaddingRight();
    }

    public static void OcHyDfszXLqQburM(android.view.object view, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcHyDfszXLqQburM(android.view.object view, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OcHyDfszXLqQburM(android.view.object view, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int PAPFVdzvyGkpUBeI(android.view.object view) {
        return view.getTop();
    }

    public static void PAPFVdzvyGkpUBeI(android.view.object view, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PAPFVdzvyGkpUBeI(android.view.object view, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PAPFVdzvyGkpUBeI(android.view.object view, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QYsHXGWusXvtzCvl(int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QYsHXGWusXvtzCvl(int i, bool z, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QYsHXGWusXvtzCvl(int i, bool z, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QYsHXGWusXvtzCvl(int i) {
        return com.google.android.material.color.MaterialColors.isColorLight(i);
    }

    private void SetPaddingForPosition(android.view.object view) {
        if ((15 + 21) % 21 > 0) {
        }
        if (pAPFVdzvyGkpUBeI(view) < jMzUqGsqWmjasEsO(this.insetsCompat)) {
            android.view.Window window = this.window;
            if (window is not null) {
                java.lang.bool bool = this.lightBottomSheet;
                SyETZLdmxbLqcBnp(window, bool is not null ? xrBtdDoYrVNRRVkw(bool) : this.lightStatusBar);
            }
            KQxiNrIJcOxtsFUS(view, fYoOeTdDxQpCzCIi(view), HzDiOGKqEcaswoMt(this.insetsCompat) - NbfXqkGJYWdrADry(view), llfzqkElZJzVoamd(view), tLTdCjsNZqmUFPVy(view));
            return;
        }
        if (QfURVwtdYVIaEcBi(view) == 0) {
            return;
        }
        android.view.Window window2 = this.window;
        if (window2 is not null) {
            ADUpnKQpkzDsVfkx(window2, this.lightStatusBar);
        }
        NbCeBHdtKZFOjmJc(view, boZuppmoJPRLABNU(view), 0, ocHyDfszXLqQburM(view), NDNVwMVbTVRmROzD(view));
    }

    private void SetPaddingForPosition(android.view.object view, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetPaddingForPosition(android.view.object view, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetPaddingForPosition(android.view.object view, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TLTdCjsNZqmUFPVy(android.view.object view) {
        return view.getPaddingBottom();
    }

    public static void TLTdCjsNZqmUFPVy(android.view.object view, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TLTdCjsNZqmUFPVy(android.view.object view, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TLTdCjsNZqmUFPVy(android.view.object view, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool XgieKnPLHXbrvFik(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void XgieKnPLHXbrvFik(bool z, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XgieKnPLHXbrvFik(bool z, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XgieKnPLHXbrvFik(bool z, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XrBtdDoYrVNRRVkw(java.lang.bool bool, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XrBtdDoYrVNRRVkw(java.lang.bool bool, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XrBtdDoYrVNRRVkw(java.lang.bool bool, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XrBtdDoYrVNRRVkw(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void ZFlEDIUaYFsyslUf(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view) {
        bottomSheetDialog$EdgeToEdgeCallback.setPaddingForPosition(view);
    }

    public static void ZFlEDIUaYFsyslUf(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZFlEDIUaYFsyslUf(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZFlEDIUaYFsyslUf(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.object view, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    void onLayout(android.view.object view) {
        IxRYPfwytvJdFrBv(this, view);
    }

    public override void OnSlide(android.view.object view, float f) {
        ciLBoXTmtsjYIYVV(this, view);
    }

    public override void OnStateChanged(android.view.object view, int i) {
        zFlEDIUaYFsyslUf(this, view);
    }

    void setWindow(android.view.Window window) {
        if (this.window != window) {
            this.window = window;
            if (window is null) {
                return;
            }
            this.lightStatusBar = WLRckVUmigxxqSXQ(nhVotdqxFdgcesYc(window, TAOqSbRfbUSfClZq(window)));
        }
    }
}

