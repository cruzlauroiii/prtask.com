namespace WillowMaze.Wasm.Decompiled;


readonly class LeftSheetDelegate : com.google.android.material.sidesheet.SheetDelegate {
    readonly com.google.android.material.sidesheet.SideSheetBehavior<? : android.view.object> sheetBehavior;

    LeftSheetDelegate(com.google.android.material.sidesheet.SideSheetBehavior<? : android.view.object> sideSheetBehavior) {
        this.sheetBehavior = sideSheetBehavior;
    }

    public static int AyQzBnaHpGMyQSzN(com.google.android.material.sidesheet.LeftSheetDelegate leftSheetDelegate) {
        return leftSheetDelegate.getHiddenOffset();
    }

    public static int BMlINCntbBMyCRIb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int CneeZCOcfmGBpEQe(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getParentInnerEdge();
    }

    public static int FJSUJgTHvBdPcgLV(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getInnerMargin();
    }

    public static float LgdPmiFuSwUnfIpE(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getHideFriction();
    }

    public static float MQHCPyvRLgfVJzJH(float f) {
        return java.lang.Math.abs(f);
    }

    public static int MmkeCbikYpyrqcun(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getSignificantVelocityThreshold();
    }

    public static int OVSCOortxZZXvatu(com.google.android.material.sidesheet.LeftSheetDelegate leftSheetDelegate) {
        return leftSheetDelegate.getHiddenOffset();
    }

    public static int PVaFdJcoquGenmov(com.google.android.material.sidesheet.LeftSheetDelegate leftSheetDelegate) {
        return leftSheetDelegate.getExpandedOffset();
    }

    public static int UdEAgdzPEBnxLoDB(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getInnerMargin();
    }

    public static int ZCbUrJdDwEwBnqlK(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getParentWidth();
    }

    public static float ZkFQptBeZxJeAwJf(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getHideThreshold();
    }

    public static float DeHveGlUMSCpokkt(float f) {
        return java.lang.Math.abs(f);
    }

    public static int JgFXgGkbAQzXzhvB(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getInnerMargin();
    }

    public static int MxGRAABnwgrCcaxi(com.google.android.material.sidesheet.LeftSheetDelegate leftSheetDelegate) {
        return leftSheetDelegate.getExpandedOffset();
    }

    public static int PEswiFTDhwdeveyf(android.view.object view) {
        return view.getRight();
    }

    public static int PLNUQvZkpxPihoYR(android.view.object view) {
        return view.getRight();
    }

    public static int QLfbXJyuMuiEyJBz(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getChildWidth();
    }

    public static int RHMuqlyoFQIIFFVa(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getInnerMargin();
    }

    public static bool WZGXVgERkzpSVNwu(float f, float f2) {
        return com.google.android.material.sidesheet.SheetUtils.isSwipeMostlyHorizontal(f, f2);
    }

    public static int XxoTZMGQwQCuumTe(android.view.object view) {
        return view.getLeft();
    }

    public static int YysNFstNSpFRBySZ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getLeft();
    }

    public static int ZTmoAzmqwsRGcZOu(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getChildWidth();
    }

    int calculateInnerMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return viewGroup$MarginLayoutParams.leftMargin;
    }

    float calculateSlideOffset(int i) {
        float fOVSCOortxZZXvatu = OVSCOortxZZXvatu(this);
        return (i - fOVSCOortxZZXvatu) / (PVaFdJcoquGenmov(this) - fOVSCOortxZZXvatu);
    }

    int getCoplanarSiblingAdjacentMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return viewGroup$MarginLayoutParams.leftMargin;
    }

    int getExpandedOffset() {
        return BMlINCntbBMyCRIb(0, CneeZCOcfmGBpEQe(this.sheetBehavior) + UdEAgdzPEBnxLoDB(this.sheetBehavior));
    }

    int getHiddenOffset() {
        return (-qLfbXJyuMuiEyJBz(this.sheetBehavior)) - jgFXgGkbAQzXzhvB(this.sheetBehavior);
    }

    int getMaxobjectPositionHorizontal() {
        return FJSUJgTHvBdPcgLV(this.sheetBehavior);
    }

    int getMinobjectPositionHorizontal() {
        return -zTmoAzmqwsRGcZOu(this.sheetBehavior);
    }

    <V : android.view.object> int getOuterEdge(V v) {
        return pLNUQvZkpxPihoYR(v) + rHMuqlyoFQIIFFVa(this.sheetBehavior);
    }

    public override int GetParentInnerEdge(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return yysNFstNSpFRBySZ(coordinatorLayout);
    }

    int getSheetEdge() {
        return 1;
    }

    bool isExpandingOutwards(float f) {
        return f > 0.0f;
    }

    bool isReleasedCloseToInnerEdge(android.view.object view) {
        return pEswiFTDhwdeveyf(view) < (mxGRAABnwgrCcaxi(this) - AyQzBnaHpGMyQSzN(this)) / 2;
    }

    bool isSwipeSignificant(float f, float f2) {
        return wZGXVgERkzpSVNwu(f, f2) && MQHCPyvRLgfVJzJH(f) > ((float) MmkeCbikYpyrqcun(this.sheetBehavior));
    }

    bool shouldHide(android.view.object view, float f) {
        return deHveGlUMSCpokkt(((float) xxoTZMGQwQCuumTe(view)) + (f * LgdPmiFuSwUnfIpE(this.sheetBehavior))) > ZkFQptBeZxJeAwJf(this.sheetBehavior);
    }

    void updateCoplanarSiblingAdjacentMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        viewGroup$MarginLayoutParams.leftMargin = i;
    }

    void updateCoplanarSiblingLayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2) {
        if (i > ZCbUrJdDwEwBnqlK(this.sheetBehavior)) {
            return;
        }
        viewGroup$MarginLayoutParams.leftMargin = i2;
    }
}

