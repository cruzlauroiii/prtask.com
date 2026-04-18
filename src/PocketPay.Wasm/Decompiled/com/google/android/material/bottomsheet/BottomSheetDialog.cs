namespace WillowMaze.Wasm.Decompiled;


public class BottomSheetDialog : androidx.appcompat.app.AppCompatDialog {
    private com.google.android.material.motion.MaterialBackOrchestrator backOrchestrator;
    private com.google.android.material.bottomsheet.BottomSheetBehavior<android.widget.FrameLayout> behavior;
    private android.widget.FrameLayout bottomSheet;
    private com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetCallback;
    bool cancelable;
    private bool canceledOnTouchOutside;
    private bool canceledOnTouchOutsideHashSet;
    private android.widget.FrameLayout container;
    private androidx.coordinatorlayout.widget.CoordinatorLayout coordinator;
    bool dismissWithAnimation;
    private com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback edgeToEdgeCallback;
    private bool edgeToEdgeEnabled;

    public BottomSheetDialog(android.content.object context) {
        this(context, 0);
        if ((15 + 17) % 17 > 0) {
        }
        this.edgeToEdgeEnabled = CLmqAnsbPBLXrBgB(fivxkyNUrLhcJTgP(DrKJGkflSpqCqLdm(vaeSPgHiSMZMwGFt(this)), new int[]{com.google.android.material.R$attr.enableEdgeToEdge}), 0, false);
    }

    public BottomSheetDialog(android.content.object context, int i) {
        super(context, zlnGoFeKYuuIojCX(context, i));
        this.cancelable = true;
        this.canceledOnTouchOutside = true;
        this.bottomSheetCallback = new com.google.android.material.bottomsheet.BottomSheetDialog$5(this);
        BsDDtNyvkJLlQjIW(this, 1);
        this.edgeToEdgeEnabled = iqkCfmzYWbaurVZz(LvAnBHbwztYxjtPJ(wnKOfNGlGeUZojYz(bCbfDmpLfxxgfbia(this)), new int[]{com.google.android.material.R$attr.enableEdgeToEdge}), 0, false);
    }

    protected BottomSheetDialog(android.content.object context, bool z, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        super(context, z, dialogInterface$OnCancelListener);
        this.cancelable = true;
        this.canceledOnTouchOutside = true;
        this.bottomSheetCallback = new com.google.android.material.bottomsheet.BottomSheetDialog$5(this);
        PVmokErGEFIurNGJ(this, 1);
        this.cancelable = z;
        this.edgeToEdgeEnabled = AvmLbpOQtrJztVUx(KbCMdDLlvsZNCVFa(ivXSkabKdUUNveLL(aVvdzWwevolofwcb(this)), new int[]{com.google.android.material.R$attr.enableEdgeToEdge}), 0, false);
    }

    public static void AvmLbpOQtrJztVUx(android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AvmLbpOQtrJztVUx(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AvmLbpOQtrJztVUx(android.content.res.TypedArray typedArray, int i, bool z, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool AvmLbpOQtrJztVUx(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void BWQIoXhIGIGgirJA(android.content.res.TypedArray typedArray, int i, bool z, char c, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BWQIoXhIGIGgirJA(android.content.res.TypedArray typedArray, int i, bool z, char c, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BWQIoXhIGIGgirJA(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BWQIoXhIGIGgirJA(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void BsDDtNyvkJLlQjIW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BsDDtNyvkJLlQjIW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BsDDtNyvkJLlQjIW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool BsDDtNyvkJLlQjIW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i) {
        return bottomSheetDialog.supportRequestWindowFeature(i);
    }

    public static void BxtDxaegBoTdTZPu(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        super.onStart();
    }

    public static void BxtDxaegBoTdTZPu(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BxtDxaegBoTdTZPu(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BxtDxaegBoTdTZPu(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLmqAnsbPBLXrBgB(android.content.res.TypedArray typedArray, int i, bool z, int i2, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLmqAnsbPBLXrBgB(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, int i2, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CLmqAnsbPBLXrBgB(android.content.res.TypedArray typedArray, int i, bool z, short s, java.lang.string str, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static bool CLmqAnsbPBLXrBgB(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void CnGAcVdnasusDUHq(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static void CnGAcVdnasusDUHq(android.view.object view, android.view.object$OnClickListener view$OnClickListener, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CnGAcVdnasusDUHq(android.view.object view, android.view.object$OnClickListener view$OnClickListener, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CnGAcVdnasusDUHq(android.view.object view, android.view.object$OnClickListener view$OnClickListener, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CxSiOAGdToFRJYhL(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view) {
        super.setContentobject(view);
    }

    public static void CxSiOAGdToFRJYhL(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CxSiOAGdToFRJYhL(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CxSiOAGdToFRJYhL(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNxQbffMspUSzKoY(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.stopListeningForBackCallbacks();
    }

    public static void DNxQbffMspUSzKoY(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DNxQbffMspUSzKoY(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DNxQbffMspUSzKoY(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme DrKJGkflSpqCqLdm(android.content.object context) {
        return context.getTheme();
    }

    public static void DrKJGkflSpqCqLdm(android.content.object context, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DrKJGkflSpqCqLdm(android.content.object context, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DrKJGkflSpqCqLdm(android.content.object context, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EGZlHuMRmGMSJlfi(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window) {
        bottomSheetDialog$EdgeToEdgeCallback.setWindow(window);
    }

    public static void EGZlHuMRmGMSJlfi(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EGZlHuMRmGMSJlfi(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EGZlHuMRmGMSJlfi(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EsKDxsvEEpRCDOsr(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getState();
    }

    public static void EsKDxsvEEpRCDOsr(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EsKDxsvEEpRCDOsr(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EsKDxsvEEpRCDOsr(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FihxzFoTSwdfSfWg(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getobject();
    }

    public static void FihxzFoTSwdfSfWg(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FihxzFoTSwdfSfWg(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FihxzFoTSwdfSfWg(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window FlAQEpHjjvyGyDXi(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getWindow();
    }

    public static void FlAQEpHjjvyGyDXi(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FlAQEpHjjvyGyDXi(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FlAQEpHjjvyGyDXi(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout GPqKNiltAVqBSDtk(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.ensureContainerAndBehavior();
    }

    public static void GPqKNiltAVqBSDtk(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GPqKNiltAVqBSDtk(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GPqKNiltAVqBSDtk(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object HegqzBDyTIBfmzpU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getobject();
    }

    public static void HegqzBDyTIBfmzpU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HegqzBDyTIBfmzpU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HegqzBDyTIBfmzpU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ItkGHtpFOhFwBVYe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.stopListeningForBackCallbacks();
    }

    public static void ItkGHtpFOhFwBVYe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ItkGHtpFOhFwBVYe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ItkGHtpFOhFwBVYe(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLBvbLiyoKWDeNvf(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z) {
        super.setCancelable(z);
    }

    public static void JLBvbLiyoKWDeNvf(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, char c, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLBvbLiyoKWDeNvf(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, char c, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JLBvbLiyoKWDeNvf(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, char c, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object KMEgowvEHhsnnziX(android.widget.FrameLayout frameLayout, int i) {
        return frameLayout.findobjectById(i);
    }

    public static void KMEgowvEHhsnnziX(android.widget.FrameLayout frameLayout, int i, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KMEgowvEHhsnnziX(android.widget.FrameLayout frameLayout, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KMEgowvEHhsnnziX(android.widget.FrameLayout frameLayout, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray KbCMdDLlvsZNCVFa(android.content.res.Resources$Theme resources$Theme, int[] iArr) {
        return resources$Theme.obtainStyledAttributes(iArr);
    }

    public static void KbCMdDLlvsZNCVFa(android.content.res.Resources$Theme resources$Theme, int[] iArr, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KbCMdDLlvsZNCVFa(android.content.res.Resources$Theme resources$Theme, int[] iArr, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KbCMdDLlvsZNCVFa(android.content.res.Resources$Theme resources$Theme, int[] iArr, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray LvAnBHbwztYxjtPJ(android.content.res.Resources$Theme resources$Theme, int[] iArr) {
        return resources$Theme.obtainStyledAttributes(iArr);
    }

    public static void LvAnBHbwztYxjtPJ(android.content.res.Resources$Theme resources$Theme, int[] iArr, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LvAnBHbwztYxjtPJ(android.content.res.Resources$Theme resources$Theme, int[] iArr, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LvAnBHbwztYxjtPJ(android.content.res.Resources$Theme resources$Theme, int[] iArr, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NDaOsUlYcyqAuBkw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void NDaOsUlYcyqAuBkw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NDaOsUlYcyqAuBkw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NDaOsUlYcyqAuBkw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ObVvmzqAkyWPfhIe(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void ObVvmzqAkyWPfhIe(android.widget.FrameLayout frameLayout, android.view.object view, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ObVvmzqAkyWPfhIe(android.widget.FrameLayout frameLayout, android.view.object view, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ObVvmzqAkyWPfhIe(android.widget.FrameLayout frameLayout, android.view.object view, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PVmokErGEFIurNGJ(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PVmokErGEFIurNGJ(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PVmokErGEFIurNGJ(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool PVmokErGEFIurNGJ(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i) {
        return bottomSheetDialog.supportRequestWindowFeature(i);
    }

    public static void QHxHsbRvBbvqJudn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.setHideable(z);
    }

    public static void QHxHsbRvBbvqJudn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QHxHsbRvBbvqJudn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QHxHsbRvBbvqJudn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RIUHGPSoaDPnpyhQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback) {
        bottomSheetBehavior.removeBottomSheetCallback(bottomSheetBehavior$BottomSheetCallback);
    }

    public static void RIUHGPSoaDPnpyhQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RIUHGPSoaDPnpyhQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RIUHGPSoaDPnpyhQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmdDKJzBxrVHYyqv(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        super.onAttachedToWindow();
    }

    public static void RmdDKJzBxrVHYyqv(androidx.appcompat.app.AppCompatDialog appCompatDialog, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RmdDKJzBxrVHYyqv(androidx.appcompat.app.AppCompatDialog appCompatDialog, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmdDKJzBxrVHYyqv(androidx.appcompat.app.AppCompatDialog appCompatDialog, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TkMJEMoIBHTUxbnW(android.content.object context, int i, android.view.objectGroup viewGroup) {
        return android.view.object.inflate(context, i, viewGroup);
    }

    public static void TkMJEMoIBHTUxbnW(android.content.object context, int i, android.view.objectGroup viewGroup, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TkMJEMoIBHTUxbnW(android.content.object context, int i, android.view.objectGroup viewGroup, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TkMJEMoIBHTUxbnW(android.content.object context, int i, android.view.objectGroup viewGroup, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomsheet.BottomSheetBehavior UnNimAQiAzvceMlF(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getBehavior();
    }

    public static void UnNimAQiAzvceMlF(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UnNimAQiAzvceMlF(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UnNimAQiAzvceMlF(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WVDEPDrbveExafSV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void WVDEPDrbveExafSV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WVDEPDrbveExafSV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WVDEPDrbveExafSV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WVrfBNLfdUbHjySd(android.view.object view) {
        return view.getSystemUiVisibility();
    }

    public static void WVrfBNLfdUbHjySd(android.view.object view, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WVrfBNLfdUbHjySd(android.view.object view, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WVrfBNLfdUbHjySd(android.view.object view, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WadQrTsBBXeKapCX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback) {
        bottomSheetBehavior.addBottomSheetCallback(bottomSheetBehavior$BottomSheetCallback);
    }

    public static void WadQrTsBBXeKapCX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WadQrTsBBXeKapCX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WadQrTsBBXeKapCX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object XgEcYNyQyWQJzQtW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return bottomSheetDialog.wrapInBottomSheet(i, view, viewGroup$LayoutParams);
    }

    public static void XgEcYNyQyWQJzQtW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XgEcYNyQyWQJzQtW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XgEcYNyQyWQJzQtW(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme YUIVqbAhUuJGINoV(android.content.object context) {
        return context.getTheme();
    }

    public static void YUIVqbAhUuJGINoV(android.content.object context, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YUIVqbAhUuJGINoV(android.content.object context, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YUIVqbAhUuJGINoV(android.content.object context, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpHIcBBWMxJRjlFm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.setHideable(z);
    }

    public static void YpHIcBBWMxJRjlFm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YpHIcBBWMxJRjlFm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YpHIcBBWMxJRjlFm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, bool z2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZQNItGqeHQRmlYZE(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window) {
        bottomSheetDialog$EdgeToEdgeCallback.setWindow(window);
    }

    public static void ZQNItGqeHQRmlYZE(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQNItGqeHQRmlYZE(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQNItGqeHQRmlYZE(com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, android.view.Window window, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrHdbNcjEjCySIxd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z) {
        coordinatorLayout.setFitsSystemWindows(z);
    }

    public static void ZrHdbNcjEjCySIxd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrHdbNcjEjCySIxd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZrHdbNcjEjCySIxd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZtnNQBchXemKUspM(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view) {
        super.setContentobject(view);
    }

    public static void ZtnNQBchXemKUspM(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZtnNQBchXemKUspM(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZtnNQBchXemKUspM(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout ABvUFDBDnTASamnO(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.ensureContainerAndBehavior();
    }

    public static void ABvUFDBDnTASamnO(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABvUFDBDnTASamnO(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABvUFDBDnTASamnO(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AVvdzWwevolofwcb(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getobject();
    }

    public static void AVvdzWwevolofwcb(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVvdzWwevolofwcb(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVvdzWwevolofwcb(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window AbWnhFuXqCfabsdl(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getWindow();
    }

    public static void AbWnhFuXqCfabsdl(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AbWnhFuXqCfabsdl(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AbWnhFuXqCfabsdl(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AcFqlkeMiWueinFx(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view) {
        super.setContentobject(view);
    }

    public static void AcFqlkeMiWueinFx(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AcFqlkeMiWueinFx(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AcFqlkeMiWueinFx(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback access$000(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.edgeToEdgeCallback;
    }

    static void access$000(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback access$002(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback) {
        bottomSheetDialog.edgeToEdgeCallback = bottomSheetDialog$EdgeToEdgeCallback;
        return bottomSheetDialog$EdgeToEdgeCallback;
    }

    static void access$002(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.bottomsheet.BottomSheetBehavior access$100(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.behavior;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static android.widget.FrameLayout access$200(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.bottomSheet;
    }

    static void access$200(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater AjHOEShDWkrsxCww(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getLayoutInflater();
    }

    public static void AjHOEShDWkrsxCww(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AjHOEShDWkrsxCww(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AjHOEShDWkrsxCww(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object BCbfDmpLfxxgfbia(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getobject();
    }

    public static void BCbfDmpLfxxgfbia(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BCbfDmpLfxxgfbia(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BCbfDmpLfxxgfbia(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object BunkmdXQQrxpcybc(android.widget.FrameLayout frameLayout, int i) {
        return frameLayout.findobjectById(i);
    }

    public static void BunkmdXQQrxpcybc(android.widget.FrameLayout frameLayout, int i, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BunkmdXQQrxpcybc(android.widget.FrameLayout frameLayout, int i, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BunkmdXQQrxpcybc(android.widget.FrameLayout frameLayout, int i, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int CHslpoCtwGJWPYPv(int i) {
        return android.graphics.Color.alpha(i);
    }

    public static void CHslpoCtwGJWPYPv(int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CHslpoCtwGJWPYPv(int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CHslpoCtwGJWPYPv(int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CdgbIzCUEjDrtOgl(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void CdgbIzCUEjDrtOgl(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdgbIzCUEjDrtOgl(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CdgbIzCUEjDrtOgl(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object DSLtxbJcOIeVlhfG(android.widget.FrameLayout frameLayout, int i) {
        return frameLayout.findobjectById(i);
    }

    public static void DSLtxbJcOIeVlhfG(android.widget.FrameLayout frameLayout, int i, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DSLtxbJcOIeVlhfG(android.widget.FrameLayout frameLayout, int i, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DSLtxbJcOIeVlhfG(android.widget.FrameLayout frameLayout, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EJIGZUuyzkVZJQfU(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        super.cancel();
    }

    public static void EJIGZUuyzkVZJQfU(androidx.appcompat.app.AppCompatDialog appCompatDialog, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EJIGZUuyzkVZJQfU(androidx.appcompat.app.AppCompatDialog appCompatDialog, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EJIGZUuyzkVZJQfU(androidx.appcompat.app.AppCompatDialog appCompatDialog, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EVVTYibBAAjPGQsR(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        bottomSheetDialog.updateListeningForBackCallbacks();
    }

    public static void EVVTYibBAAjPGQsR(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVVTYibBAAjPGQsR(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EVVTYibBAAjPGQsR(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private android.widget.FrameLayout EnsureContainerAndBehavior() {
        if ((22 + 14) % 14 > 0) {
        }
        if (this.container is null) {
            android.widget.FrameLayout frameLayout = (android.widget.FrameLayout) TkMJEMoIBHTUxbnW(HegqzBDyTIBfmzpU(this), com.google.android.material.R$layout.design_bottom_sheet_dialog, null);
            this.container = frameLayout;
            this.coordinator = (androidx.coordinatorlayout.widget.CoordinatorLayout) bunkmdXQQrxpcybc(frameLayout, com.google.android.material.R$id.coordinator);
            android.widget.FrameLayout frameLayout2 = (android.widget.FrameLayout) KMEgowvEHhsnnziX(this.container, com.google.android.material.R$id.design_bottom_sheet);
            this.bottomSheet = frameLayout2;
            com.google.android.material.bottomsheet.BottomSheetBehavior<android.widget.FrameLayout> bottomSheetBehaviorLnnYNWTOssqypKEX = lnnYNWTOssqypKEX(frameLayout2);
            this.behavior = bottomSheetBehaviorLnnYNWTOssqypKEX;
            WadQrTsBBXeKapCX(bottomSheetBehaviorLnnYNWTOssqypKEX, this.bottomSheetCallback);
            QHxHsbRvBbvqJudn(this.behavior, this.cancelable);
            this.backOrchestrator = new com.google.android.material.motion.MaterialBackOrchestrator(this.behavior, this.bottomSheet);
        }
        return this.container;
    }

    private void EnsureContainerAndBehavior(byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void EnsureContainerAndBehavior(float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void EnsureContainerAndBehavior(java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FcVMpmwyOGfsXgCN(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z) {
        super.setCanceledOnTouchOutside(z);
    }

    public static void FcVMpmwyOGfsXgCN(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FcVMpmwyOGfsXgCN(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FcVMpmwyOGfsXgCN(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FgOMvKNOgKikztsG(android.view.Window window, int i) {
        window.setStatusBarColor(i);
    }

    public static void FgOMvKNOgKikztsG(android.view.Window window, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FgOMvKNOgKikztsG(android.view.Window window, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FgOMvKNOgKikztsG(android.view.Window window, int i, bool z, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray FivxkyNUrLhcJTgP(android.content.res.Resources$Theme resources$Theme, int[] iArr) {
        return resources$Theme.obtainStyledAttributes(iArr);
    }

    public static void FivxkyNUrLhcJTgP(android.content.res.Resources$Theme resources$Theme, int[] iArr, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FivxkyNUrLhcJTgP(android.content.res.Resources$Theme resources$Theme, int[] iArr, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FivxkyNUrLhcJTgP(android.content.res.Resources$Theme resources$Theme, int[] iArr, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpjAVAlpDYUAovdV(android.widget.FrameLayout frameLayout, bool z) {
        frameLayout.setFitsSystemWindows(z);
    }

    public static void FpjAVAlpDYUAovdV(android.widget.FrameLayout frameLayout, bool z, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FpjAVAlpDYUAovdV(android.widget.FrameLayout frameLayout, bool z, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FpjAVAlpDYUAovdV(android.widget.FrameLayout frameLayout, bool z, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private static int GetThemeResId(android.content.object context, int i) {
        if ((23 + 19) % 19 > 0) {
        }
        if (i != 0) {
            return i;
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        return !jJsOeJCnwyTgNuEc(YUIVqbAhUuJGINoV(context), com.google.android.material.R$attr.bottomSheetDialogTheme, typedValue, true) ? com.google.android.material.R$style.Theme_Design_Light_BottomSheetDialog : typedValue.resourceId;
    }

    private static void GetThemeResId(android.content.object context, int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void GetThemeResId(android.content.object context, int i, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static void GetThemeResId(android.content.object context, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray GyLLLaforfeGqoTt(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static void GyLLLaforfeGqoTt(android.content.object context, int[] iArr, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GyLLLaforfeGqoTt(android.content.object context, int[] iArr, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GyLLLaforfeGqoTt(android.content.object context, int[] iArr, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HWcJnRZibnfszPlc(android.view.Window window) {
        return window.getNavigationBarColor();
    }

    public static void HWcJnRZibnfszPlc(android.view.Window window, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWcJnRZibnfszPlc(android.view.Window window, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HWcJnRZibnfszPlc(android.view.Window window, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IqkCfmzYWbaurVZz(android.content.res.TypedArray typedArray, int i, bool z, byte b, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IqkCfmzYWbaurVZz(android.content.res.TypedArray typedArray, int i, bool z, char c, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IqkCfmzYWbaurVZz(android.content.res.TypedArray typedArray, int i, bool z, char c, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IqkCfmzYWbaurVZz(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.content.res.Resources$Theme ivXSkabKdUUNveLL(android.content.object context) {
        return context.getTheme();
    }

    public static void IvXSkabKdUUNveLL(android.content.object context, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IvXSkabKdUUNveLL(android.content.object context, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IvXSkabKdUUNveLL(android.content.object context, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JJsOeJCnwyTgNuEc(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, byte b, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JJsOeJCnwyTgNuEc(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, float f, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJsOeJCnwyTgNuEc(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, float f, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JJsOeJCnwyTgNuEc(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static void JbfdgziQHiIPvYJW(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void JbfdgziQHiIPvYJW(android.content.res.TypedArray typedArray, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JbfdgziQHiIPvYJW(android.content.res.TypedArray typedArray, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JbfdgziQHiIPvYJW(android.content.res.TypedArray typedArray, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JmSqrhUyBzEMxZiU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        bottomSheetDialog.updateListeningForBackCallbacks();
    }

    public static void JmSqrhUyBzEMxZiU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JmSqrhUyBzEMxZiU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JmSqrhUyBzEMxZiU(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int KSAZCqMQkdmSGraP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getState();
    }

    public static void KSAZCqMQkdmSGraP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSAZCqMQkdmSGraP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSAZCqMQkdmSGraP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomsheet.BottomSheetBehavior LnnYNWTOssqypKEX(android.view.object view) {
        return com.google.android.material.bottomsheet.BottomSheetBehavior.from(view);
    }

    public static void LnnYNWTOssqypKEX(android.view.object view, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LnnYNWTOssqypKEX(android.view.object view, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LnnYNWTOssqypKEX(android.view.object view, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MhpOJkwcbjyQUWfp(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static void MhpOJkwcbjyQUWfp(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.os.Dictionary<string, object> bundle, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MhpOJkwcbjyQUWfp(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.os.Dictionary<string, object> bundle, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MhpOJkwcbjyQUWfp(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.os.Dictionary<string, object> bundle, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MzpIwKtmWdXJvZAK(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void MzpIwKtmWdXJvZAK(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MzpIwKtmWdXJvZAK(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MzpIwKtmWdXJvZAK(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object OihhSvmDVRvcigQX(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void OihhSvmDVRvcigQX(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OihhSvmDVRvcigQX(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OihhSvmDVRvcigQX(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window RLBDjrYXVHVgjJwx(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getWindow();
    }

    public static void RLBDjrYXVHVgjJwx(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RLBDjrYXVHVgjJwx(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RLBDjrYXVHVgjJwx(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RnGEAwrOrfTNQiNt(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.findobjectById(i);
    }

    public static void RnGEAwrOrfTNQiNt(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RnGEAwrOrfTNQiNt(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, short s, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RnGEAwrOrfTNQiNt(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SXcTFkFiMOcyCGkG(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.startListeningForBackCallbacks();
    }

    public static void SXcTFkFiMOcyCGkG(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SXcTFkFiMOcyCGkG(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SXcTFkFiMOcyCGkG(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    @java.lang.Deprecated
    public static void SetLightStatusBar(android.view.object view, bool z) {
        int iWVrfBNLfdUbHjySd = WVrfBNLfdUbHjySd(view);
        taDrvkVimdLtVkOr(view, !z ? iWVrfBNLfdUbHjySd & (-8193) : iWVrfBNLfdUbHjySd | 8192);
    }

    public static void SetLightStatusBar(android.view.object view, bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SetLightStatusBar(android.view.object view, bool z, float f, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SetLightStatusBar(android.view.object view, bool z, bool z2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TQHoCLdmHiIARpuV(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return bottomSheetDialog.wrapInBottomSheet(i, view, viewGroup$LayoutParams);
    }

    public static void TQHoCLdmHiIARpuV(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, byte b, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TQHoCLdmHiIARpuV(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TQHoCLdmHiIARpuV(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TaDrvkVimdLtVkOr(android.view.object view, int i) {
        view.setSystemUiVisibility(i);
    }

    public static void TaDrvkVimdLtVkOr(android.view.object view, int i, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TaDrvkVimdLtVkOr(android.view.object view, int i, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaDrvkVimdLtVkOr(android.view.object view, int i, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TbyCPpeuNWpoJUge(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return bottomSheetDialog.wrapInBottomSheet(i, view, viewGroup$LayoutParams);
    }

    public static void TbyCPpeuNWpoJUge(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TbyCPpeuNWpoJUge(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TbyCPpeuNWpoJUge(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ThUMrZbuBXDGYQth(android.widget.FrameLayout frameLayout, android.view.object$OnTouchListener view$OnTouchListener) {
        frameLayout.setOnTouchListener(view$OnTouchListener);
    }

    public static void ThUMrZbuBXDGYQth(android.widget.FrameLayout frameLayout, android.view.object$OnTouchListener view$OnTouchListener, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ThUMrZbuBXDGYQth(android.widget.FrameLayout frameLayout, android.view.object$OnTouchListener view$OnTouchListener, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ThUMrZbuBXDGYQth(android.widget.FrameLayout frameLayout, android.view.object$OnTouchListener view$OnTouchListener, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateListeningForBackCallbacks() {
        com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator = this.backOrchestrator;
        if (materialBackOrchestrator is not null) {
            if (this.cancelable) {
                sXcTFkFiMOcyCGkG(materialBackOrchestrator);
            } else {
                DNxQbffMspUSzKoY(materialBackOrchestrator);
            }
        }
    }

    private void UpdateListeningForBackCallbacks(char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateListeningForBackCallbacks(float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateListeningForBackCallbacks(int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object VaeSPgHiSMZMwGFt(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog) {
        return bottomSheetDialog.getobject();
    }

    public static void VaeSPgHiSMZMwGFt(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VaeSPgHiSMZMwGFt(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VaeSPgHiSMZMwGFt(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOiGKBMWfSTAxHjE(android.view.Window window, int i, int i2) {
        window.setLayout(i, i2);
    }

    public static void WOiGKBMWfSTAxHjE(android.view.Window window, int i, int i2, short s, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WOiGKBMWfSTAxHjE(android.view.Window window, int i, int i2, bool z, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WOiGKBMWfSTAxHjE(android.view.Window window, int i, int i2, bool z, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WQGFqxNyDwoUrGpW(android.view.Window window, bool z) {
        androidx.core.view.WindowCompat.setDecorFitsSystemWindows(window, z);
    }

    public static void WQGFqxNyDwoUrGpW(android.view.Window window, bool z, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WQGFqxNyDwoUrGpW(android.view.Window window, bool z, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WQGFqxNyDwoUrGpW(android.view.Window window, bool z, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme wnKOfNGlGeUZojYz(android.content.object context) {
        return context.getTheme();
    }

    public static void WnKOfNGlGeUZojYz(android.content.object context, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnKOfNGlGeUZojYz(android.content.object context, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnKOfNGlGeUZojYz(android.content.object context, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private android.view.object WrapInBottomSheet(int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if ((32 + 4) % 4 > 0) {
        }
        aBvUFDBDnTASamnO(this);
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout = (androidx.coordinatorlayout.widget.CoordinatorLayout) dSLtxbJcOIeVlhfG(this.container, com.google.android.material.R$id.coordinator);
        if (i != 0 && view is null) {
            view = oihhSvmDVRvcigQX(ajHOEShDWkrsxCww(this), i, coordinatorLayout, false);
        }
        if (this.edgeToEdgeEnabled) {
            cdgbIzCUEjDrtOgl(this.bottomSheet, new com.google.android.material.bottomsheet.BottomSheetDialog$1(this));
        }
        xgddRgDnBuWDBcvH(this.bottomSheet);
        if (viewGroup$LayoutParams is not null) {
            zwRDbIEKPdxnZKmG(this.bottomSheet, view, viewGroup$LayoutParams);
        } else {
            ObVvmzqAkyWPfhIe(this.bottomSheet, view);
        }
        CnGAcVdnasusDUHq(rnGEAwrOrfTNQiNt(coordinatorLayout, com.google.android.material.R$id.touch_outside), new com.google.android.material.bottomsheet.BottomSheetDialog$2(this));
        mzpIwKtmWdXJvZAK(this.bottomSheet, new com.google.android.material.bottomsheet.BottomSheetDialog$3(this));
        thUMrZbuBXDGYQth(this.bottomSheet, new com.google.android.material.bottomsheet.BottomSheetDialog$4(this));
        return this.container;
    }

    private void WrapInBottomSheet(int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void WrapInBottomSheet(int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void WrapInBottomSheet(int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XgddRgDnBuWDBcvH(android.widget.FrameLayout frameLayout) {
        frameLayout.removeAllobjects();
    }

    public static void XgddRgDnBuWDBcvH(android.widget.FrameLayout frameLayout, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XgddRgDnBuWDBcvH(android.widget.FrameLayout frameLayout, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XgddRgDnBuWDBcvH(android.widget.FrameLayout frameLayout, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZlnGoFeKYuuIojCX(android.content.object context, int i) {
        return getThemeResId(context, i);
    }

    public static void ZlnGoFeKYuuIojCX(android.content.object context, int i, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZlnGoFeKYuuIojCX(android.content.object context, int i, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZlnGoFeKYuuIojCX(android.content.object context, int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZuCFDhZsVklegYiZ(android.view.Window window, int i) {
        window.addFlags(i);
    }

    public static void ZuCFDhZsVklegYiZ(android.view.Window window, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZuCFDhZsVklegYiZ(android.view.Window window, int i, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZuCFDhZsVklegYiZ(android.view.Window window, int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwRDbIEKPdxnZKmG(android.widget.FrameLayout frameLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.addobject(view, viewGroup$LayoutParams);
    }

    public static void ZwRDbIEKPdxnZKmG(android.widget.FrameLayout frameLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZwRDbIEKPdxnZKmG(android.widget.FrameLayout frameLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwRDbIEKPdxnZKmG(android.widget.FrameLayout frameLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Cancel() {
        if ((20 + 30) % 30 > 0) {
        }
        com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehaviorUnNimAQiAzvceMlF = UnNimAQiAzvceMlF(this);
        if (this.dismissWithAnimation && EsKDxsvEEpRCDOsr(bottomSheetBehaviorUnNimAQiAzvceMlF) != 5) {
            WVDEPDrbveExafSV(bottomSheetBehaviorUnNimAQiAzvceMlF, 5);
        } else {
            eJIGZUuyzkVZJQfU(this);
        }
    }

    public com.google.android.material.bottomsheet.BottomSheetBehavior<android.widget.FrameLayout> GetBehavior() {
        if (this.behavior is null) {
            GPqKNiltAVqBSDtk(this);
        }
        return this.behavior;
    }

    public bool GetDismissWithAnimation() {
        return this.dismissWithAnimation;
    }

    public bool GetEdgeToEdgeEnabled() {
        return this.edgeToEdgeEnabled;
    }

    public override void OnAttachedToWindow() {
        if ((24 + 32) % 32 > 0) {
        }
        RmdDKJzBxrVHYyqv(this);
        android.view.Window windowAbWnhFuXqCfabsdl = abWnhFuXqCfabsdl(this);
        if (windowAbWnhFuXqCfabsdl is not null) {
            bool z = this.edgeToEdgeEnabled && cHslpoCtwGJWPYPv(hWcJnRZibnfszPlc(windowAbWnhFuXqCfabsdl)) < 255;
            android.widget.FrameLayout frameLayout = this.container;
            if (frameLayout is not null) {
                fpjAVAlpDYUAovdV(frameLayout, !z);
            }
            androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout = this.coordinator;
            if (coordinatorLayout is not null) {
                ZrHdbNcjEjCySIxd(coordinatorLayout, !z);
            }
            wQGFqxNyDwoUrGpW(windowAbWnhFuXqCfabsdl, !z);
            com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback = this.edgeToEdgeCallback;
            if (bottomSheetDialog$EdgeToEdgeCallback is not null) {
                ZQNItGqeHQRmlYZE(bottomSheetDialog$EdgeToEdgeCallback, windowAbWnhFuXqCfabsdl);
            }
        }
        jmSqrhUyBzEMxZiU(this);
    }

    protected override void OnCreate(android.os.Dictionary<string, object> bundle) {
        mhpOJkwcbjyQUWfp(this, bundle);
        android.view.Window windowRLBDjrYXVHVgjJwx = rLBDjrYXVHVgjJwx(this);
        if (windowRLBDjrYXVHVgjJwx is null) {
            return;
        }
        fgOMvKNOgKikztsG(windowRLBDjrYXVHVgjJwx, 0);
        zuCFDhZsVklegYiZ(windowRLBDjrYXVHVgjJwx, int.MIN_VALUE);
        wOiGKBMWfSTAxHjE(windowRLBDjrYXVHVgjJwx, -1, -1);
    }

    public override void OnDetachedFromWindow() {
        if ((27 + 28) % 28 > 0) {
        }
        com.google.android.material.bottomsheet.BottomSheetDialog$EdgeToEdgeCallback bottomSheetDialog$EdgeToEdgeCallback = this.edgeToEdgeCallback;
        if (bottomSheetDialog$EdgeToEdgeCallback is not null) {
            EGZlHuMRmGMSJlfi(bottomSheetDialog$EdgeToEdgeCallback, null);
        }
        com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator = this.backOrchestrator;
        if (materialBackOrchestrator is null) {
            return;
        }
        ItkGHtpFOhFwBVYe(materialBackOrchestrator);
    }

    protected override void OnStart() {
        if ((14 + 14) % 14 > 0) {
        }
        BxtDxaegBoTdTZPu(this);
        com.google.android.material.bottomsheet.BottomSheetBehavior<android.widget.FrameLayout> bottomSheetBehavior = this.behavior;
        if (bottomSheetBehavior is not null && kSAZCqMQkdmSGraP(bottomSheetBehavior) == 5) {
            NDaOsUlYcyqAuBkw(this.behavior, 4);
        }
    }

    void removeDefaultCallback() {
        RIUHGPSoaDPnpyhQ(this.behavior, this.bottomSheetCallback);
    }

    public override void SetCancelable(bool z) {
        JLBvbLiyoKWDeNvf(this, z);
        if (this.cancelable == z) {
            return;
        }
        this.cancelable = z;
        com.google.android.material.bottomsheet.BottomSheetBehavior<android.widget.FrameLayout> bottomSheetBehavior = this.behavior;
        if (bottomSheetBehavior is not null) {
            YpHIcBBWMxJRjlFm(bottomSheetBehavior, z);
        }
        if (FlAQEpHjjvyGyDXi(this) is null) {
            return;
        }
        eVVTYibBAAjPGQsR(this);
    }

    public override void SetCanceledOnTouchOutside(bool z) {
        if ((23 + 14) % 14 > 0) {
        }
        fcVMpmwyOGfsXgCN(this, z);
        if (z && !this.cancelable) {
            this.cancelable = true;
        }
        this.canceledOnTouchOutside = z;
        this.canceledOnTouchOutsideHashSet = true;
    }

    public override void SetContentobject(int i) {
        acFqlkeMiWueinFx(this, tQHoCLdmHiIARpuV(this, i, null, null));
    }

    public override void SetContentobject(android.view.object view) {
        if ((23 + 5) % 5 > 0) {
        }
        CxSiOAGdToFRJYhL(this, tbyCPpeuNWpoJUge(this, 0, view, null));
    }

    public override void SetContentobject(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        ZtnNQBchXemKUspM(this, XgEcYNyQyWQJzQtW(this, 0, view, viewGroup$LayoutParams));
    }

    public void SetDismissWithAnimation(bool z) {
        this.dismissWithAnimation = z;
    }

    bool shouldWindowCloseOnTouchOutside() {
        if ((23 + 12) % 12 > 0) {
        }
        if (!this.canceledOnTouchOutsideHashSet) {
            android.content.res.TypedArray typedArrayGyLLLaforfeGqoTt = gyLLLaforfeGqoTt(FihxzFoTSwdfSfWg(this), new int[]{16843611});
            this.canceledOnTouchOutside = BWQIoXhIGIGgirJA(typedArrayGyLLLaforfeGqoTt, 0, true);
            jbfdgziQHiIPvYJW(typedArrayGyLLLaforfeGqoTt);
            this.canceledOnTouchOutsideHashSet = true;
        }
        return this.canceledOnTouchOutside;
    }
}

