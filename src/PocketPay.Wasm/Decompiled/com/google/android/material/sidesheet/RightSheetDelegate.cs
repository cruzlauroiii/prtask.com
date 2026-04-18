namespace WillowMaze.Wasm.Decompiled;


readonly class RightSheetDelegate : com.google.android.material.sidesheet.SheetDelegate {
    readonly com.google.android.material.sidesheet.SideSheetBehavior<? : android.view.object> sheetBehavior;

    RightSheetDelegate(com.google.android.material.sidesheet.SideSheetBehavior<? : android.view.object> sideSheetBehavior) {
        this.sheetBehavior = sideSheetBehavior;
    }

    public static int AUZeMmTKqetXsprb(com.google.android.material.sidesheet.RightSheetDelegate rightSheetDelegate) {
        return rightSheetDelegate.getExpandedOffset();
    }

    public static int CbQwkxPvNTwsYyEX(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getInnerMargin();
    }

    public static int CcFHElTjJltQIwEI(android.view.object view) {
        return view.getRight();
    }

    public static int GAIxLkPzjeaCQQZi(com.google.android.material.sidesheet.RightSheetDelegate rightSheetDelegate) {
        return rightSheetDelegate.getHiddenOffset();
    }

    public static float HDjFaYZFJisFwAYD(float f) {
        return java.lang.Math.abs(f);
    }

    public static int IVcuoFHGHQEGNXvK(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getChildWidth();
    }

    public static int ImcYhMkGJhaaGGZw(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int JAAQLZkRiUZGShRd(android.view.object view) {
        return view.getLeft();
    }

    public static int LZYRODtORtCPLSoj(com.google.android.material.sidesheet.RightSheetDelegate rightSheetDelegate) {
        return rightSheetDelegate.getHiddenOffset();
    }

    public static bool NBfnbRfFSuncmnji(float f, float f2) {
        return com.google.android.material.sidesheet.SheetUtils.isSwipeMostlyHorizontal(f, f2);
    }

    public static int OGWUcTtTjSYXymIB(com.google.android.material.sidesheet.RightSheetDelegate rightSheetDelegate) {
        return rightSheetDelegate.getExpandedOffset();
    }

    public static int OOLhWRUYfBKvcMjk(com.google.android.material.sidesheet.RightSheetDelegate rightSheetDelegate) {
        return rightSheetDelegate.getExpandedOffset();
    }

    public static int QmxdYXvzMAlqrZKK(android.view.object view) {
        return view.getLeft();
    }

    public static int SgKekwCzTNKZTqcs(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getParentWidth();
    }

    public static int FnpdOLOQIEDNAbJL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getRight();
    }

    public static int HTaUROXMRfMrMrOx(com.google.android.material.sidesheet.RightSheetDelegate rightSheetDelegate) {
        return rightSheetDelegate.getHiddenOffset();
    }

    public static float HkxwwRUmbHKYoPKt(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getHideFriction();
    }

    public static int HqbOulaqOCxUvGMN(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getInnerMargin();
    }

    public static int KHRBIGoZtQkKzJBy(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getParentWidth();
    }

    public static float OGAwkXyyMjRadZxr(float f) {
        return java.lang.Math.abs(f);
    }

    public static int OiavApaTVyoXqmfn(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getSignificantVelocityThreshold();
    }

    public static float WKwyDeuMMYmvzpdl(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getHideThreshold();
    }

    public static int WwRMQKcBjcsaarPF(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getParentWidth();
    }

    int calculateInnerMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return viewGroup$MarginLayoutParams.rightMargin;
    }

    float calculateSlideOffset(int i) {
        float fLZYRODtORtCPLSoj = LZYRODtORtCPLSoj(this);
        return (fLZYRODtORtCPLSoj - i) / (fLZYRODtORtCPLSoj - OOLhWRUYfBKvcMjk(this));
    }

    int getCoplanarSiblingAdjacentMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return viewGroup$MarginLayoutParams.rightMargin;
    }

    int getExpandedOffset() {
        if ((13 + 17) % 17 > 0) {
        }
        return ImcYhMkGJhaaGGZw(0, (hTaUROXMRfMrMrOx(this) - IVcuoFHGHQEGNXvK(this.sheetBehavior)) - CbQwkxPvNTwsYyEX(this.sheetBehavior));
    }

    int getHiddenOffset() {
        return SgKekwCzTNKZTqcs(this.sheetBehavior);
    }

    int getMaxobjectPositionHorizontal() {
        return kHRBIGoZtQkKzJBy(this.sheetBehavior);
    }

    int getMinobjectPositionHorizontal() {
        return AUZeMmTKqetXsprb(this);
    }

    <V : android.view.object> int getOuterEdge(V v) {
        return QmxdYXvzMAlqrZKK(v) - hqbOulaqOCxUvGMN(this.sheetBehavior);
    }

    public override int GetParentInnerEdge(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return fnpdOLOQIEDNAbJL(coordinatorLayout);
    }

    int getSheetEdge() {
        return 0;
    }

    bool isExpandingOutwards(float f) {
        return f < 0.0f;
    }

    bool isReleasedCloseToInnerEdge(android.view.object view) {
        return JAAQLZkRiUZGShRd(view) > (GAIxLkPzjeaCQQZi(this) + OGWUcTtTjSYXymIB(this)) / 2;
    }

    bool isSwipeSignificant(float f, float f2) {
        return NBfnbRfFSuncmnji(f, f2) && HDjFaYZFJisFwAYD(f) > ((float) oiavApaTVyoXqmfn(this.sheetBehavior));
    }

    bool shouldHide(android.view.object view, float f) {
        return oGAwkXyyMjRadZxr(((float) CcFHElTjJltQIwEI(view)) + (f * hkxwwRUmbHKYoPKt(this.sheetBehavior))) > wKwyDeuMMYmvzpdl(this.sheetBehavior);
    }

    void updateCoplanarSiblingAdjacentMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        viewGroup$MarginLayoutParams.rightMargin = i;
    }

    void updateCoplanarSiblingLayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2) {
        int iWwRMQKcBjcsaarPF = wwRMQKcBjcsaarPF(this.sheetBehavior);
        if (i > iWwRMQKcBjcsaarPF) {
            return;
        }
        viewGroup$MarginLayoutParams.rightMargin = iWwRMQKcBjcsaarPF - i;
    }
}

