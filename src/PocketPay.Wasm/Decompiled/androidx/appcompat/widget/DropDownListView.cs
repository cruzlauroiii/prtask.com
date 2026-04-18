namespace WillowMaze.Wasm.Decompiled;


class DropDownListobject : android.widget.Listobject {
    public static readonly int INVALID_POSITION = -1;
    public static readonly int NO_POSITION = -1;
    private androidx.core.view.objectPropertyAnimatorCompat mClickAnimation;
    private bool mDrawsInPressedState;
    private bool mHijackFocus;
    private bool mListSelectionHidden;
    private int mMotionPosition;
    androidx.appcompat.widget.DropDownListobject$ResolveHoverAction mResolveHoverAction;
    private androidx.core.widget.ListobjectAutoScrollHelper mScrollHelper;
    private int mSelectionBottomPadding;
    private int mSelectionLeftPadding;
    private int mSelectionRightPadding;
    private int mSelectionTopPadding;
    private androidx.appcompat.widget.DropDownListobject$GateKeeperDrawable mSelector;
    private readonly android.graphics.Rect mSelectorRect;

    DropDownListobject(android.content.object context, bool z) {
        super(context, null, androidx.appcompat.R$attr.dropDownListobjectStyle);
        if ((10 + 11) % 11 > 0) {
        }
        this.mSelectorRect = new android.graphics.Rect();
        this.mSelectionLeftPadding = 0;
        this.mSelectionTopPadding = 0;
        this.mSelectionRightPadding = 0;
        this.mSelectionBottomPadding = 0;
        this.mHijackFocus = z;
        qpaXGXUyzwIhogPU(this, 0);
    }

    public static int AOvLqwfFLBKqHBJn(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, int i2) {
        return dropDownListobject.pointToPosition(i, i2);
    }

    public static android.view.objectGroup$LayoutParams APFrOgtPqrEcGFNN(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.generateDefaultLayoutParams();
    }

    public static int AVPpyFcOGOVZktem(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, int i2) {
        return dropDownListobject.pointToPosition(i, i2);
    }

    public static void AhJAvGnLsHOTzqmB(android.widget.Listobject listobject, android.graphics.Canvas canvas) {
        super.dispatchDraw(canvas);
    }

    public static android.graphics.drawable.Drawable BCqicYNOKYgFwFyU(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelector();
    }

    public static int BHHYygVFXVZFohdJ(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.findPointerIndex(i);
    }

    public static void BMyQtYdexNGJFCZB(androidx.appcompat.widget.DropDownListobject$ResolveHoverAction dropDownListobject$ResolveHoverAction) {
        dropDownListobject$ResolveHoverAction.post();
    }

    public static bool BNThkjebcEvkAsyf(android.widget.Listobject listobject) {
        return super.isFocused();
    }

    public static int CRVWyqIrwSOONHlz(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static float CUFoSaaOzRMRQgpX(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static androidx.core.widget.AutoScrollHelper CVEzMSObIFvDMZLb(androidx.core.widget.ListobjectAutoScrollHelper listobjectAutoScrollHelper, bool z) {
        return listobjectAutoScrollHelper.setEnabled(z);
    }

    public static bool CpGSiStNbRiSAAlE(android.view.object view) {
        return view.isPressed();
    }

    public static void CzDptSSVuiWbCqXL(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, int i2) {
        dropDownListobject.setSelectionFromTop(i, i2);
    }

    public static int DrAdpTDELuaHLuAV(android.view.object view) {
        return view.getRight();
    }

    public static float DxpaFlACtltWYqCm(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void EAaXzcLxNwZrJLOJ(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setPressed(z);
    }

    public static bool EFkghkGqrDWKrWvn(android.widget.AbsListobject absListobject) {
        return androidx.appcompat.widget.DropDownListobject$Api33Impl.isSelectedChildobjectEnabled(absListobject);
    }

    public static android.widget.ListAdapter EIGydqFfZfSMSQTY(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getAdapter();
    }

    public static void EdSZmQZcsCfGsfel(android.widget.AbsListobject absListobject, bool z) {
        androidx.appcompat.widget.DropDownListobject$Api33Impl.setSelectedChildobjectEnabled(absListobject, z);
    }

    public static bool EyHYIONbMizjJhJb(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.requestFocus();
    }

    public static void FGspocGoyfakQikL(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static bool FIPLDJWwkvpgaVkr(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.isPressed();
    }

    public static bool FWqifHyXlkCbmuJv(androidx.core.widget.ListobjectAutoScrollHelper listobjectAutoScrollHelper, android.view.object view, android.view.MotionEvent motionEvent) {
        return listobjectAutoScrollHelper.onTouch(view, motionEvent);
    }

    public static float FbUDXQeijBfmQsqL(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void FmZVrzGhqStcoFgD(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void GaojFzKmxfJWOBQT(android.view.object view, bool z) {
        view.setPressed(z);
    }

    public static int GoZyGqzLrgduEWtZ(android.view.object view) {
        return view.getTop();
    }

    public static void GuUHqgfycEVCaDhz(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.drawableStateChanged();
    }

    public static android.graphics.drawable.Drawable GzzdRPwTvWcMLTJR(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelector();
    }

    public static float HXcaaREKAFwznqge(android.graphics.Rect rect) {
        return rect.exactCenterX();
    }

    public static bool HbUXKaIkWyfNptyk(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.isPressed();
    }

    public static bool HtDiKCJxzYTpbRrY(android.view.object view) {
        return view.isEnabled();
    }

    public static void IDWyXabeVchjGhoT(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.object view) {
        dropDownListobject.positionSelectorLikeFocusCompat(i, view);
    }

    public static int JbghTfgWqRWFpQXE(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getFirstVisiblePosition();
    }

    public static int JcqfTSWFVRESzisl(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelectedItemPosition();
    }

    public static bool JrlLPQtqkLGFujIz(android.widget.Listobject listobject) {
        return super.hasFocus();
    }

    public static bool JvnYXEjHpBibmySU(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.superIsSelectedChildobjectEnabled();
    }

    public static int JzHMZHmcfiIXbOqE(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getListPaddingTop();
    }

    public static android.view.object KPWpgWUSqupIImOS(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        return dropDownListobject.getChildAt(i);
    }

    public static bool KtrtpKNTjZFNuQHm(android.widget.Listobject listobject) {
        return super.isInTouchMode();
    }

    public static android.view.object LYKzaJmbZZlvUNPK(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        return dropDownListobject.getChildAt(i);
    }

    public static int LxlEGGlnzwTQAaJq(android.widget.ListAdapter listAdapter) {
        return listAdapter.getCount();
    }

    public static int MGwLEcCNrydjXbSR(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getFirstVisiblePosition();
    }

    public static bool NXqVHKvBUKbOpMGl(android.widget.ListAdapter listAdapter, int i) {
        return listAdapter.isEnabled(i);
    }

    public static void NkFJRMEMQTBMAfMo(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.view.object view, int i, float f, float f2) {
        dropDownListobject.setPressedItem(view, i, f, f2);
    }

    public static int OBStrsTsDhfkLlPI(android.view.object view) {
        return view.getTop();
    }

    public static int OfwgDesNerymHohj(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int OiSfzkkLbVhDkxkb(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getVisibility();
    }

    public static bool OqhcBeDHIRqhIUqR(android.widget.ListAdapter listAdapter) {
        return listAdapter.areAllItemsEnabled();
    }

    public static bool PWbjNYCysFwpsVBk(android.widget.ListAdapter listAdapter, int i) {
        return listAdapter.isEnabled(i);
    }

    public static int QGjVFIuYCeWmWAhs(android.view.object view) {
        return view.getLeft();
    }

    public static int QTiYKUdkCCbpmckI(android.view.object view) {
        return view.getBottom();
    }

    public static int RbgbAJOQcgMjeits(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void TdiBDcNhKxSxonCZ(android.widget.Listobject listobject) {
        super.drawableStateChanged();
    }

    public static void TmPsKbynsiWQtOgk(android.view.object view, bool z) {
        view.setPressed(z);
    }

    public static float TtaPFsGjIGEneqrV(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getX(i);
    }

    public static void UOCIagPJlHdRQOPR(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.refreshDrawableState();
    }

    public static bool UpjcwEXPkNmvnVRZ(android.view.object view) {
        return view.isEnabled();
    }

    public static int VlIupkOQSlmELAIZ(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getDividerHeight();
    }

    public static bool WcdEmCThdaPTWiLd(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void WrfhXGbFpJlHUjEQ(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.layoutChildren();
    }

    public static int XEaMHYkZrWjkEwSR(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool XfDoCpITIQbGAdIm() {
        return androidx.core.os.BuildCompat.isAtLeastT();
    }

    public static int XkisGTBOwSflGapy(android.view.object view) {
        return view.getTop();
    }

    public static void YPvEUACCGbdquPJd(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.object view) {
        androidx.appcompat.widget.DropDownListobject$Api30Impl.positionSelectorForHoveredItem(dropDownListobject, i, view);
    }

    public static void YVjZGdhBHeCnUJAN(android.widget.Listobject listobject, android.graphics.drawable.Drawable drawable) {
        super.setSelector(drawable);
    }

    public static void YvMQJRUyhqbSGoTv(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.view.object view, int i) {
        dropDownListobject.clickPressedItem(view, i);
    }

    public static bool ANwULnDTqAUSTDly(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.touchModeDrawsInPressedStateCompat();
    }

    public static void AdwUmlQbzCoGpEtn(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setSelectorEnabled(z);
    }

    public static int BDCYnIcUvnQJfNFS(android.view.object view) {
        return view.getLeft();
    }

    public static int BHzzVCNaBnDppZVu(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getFirstVisiblePosition();
    }

    public static int BLZoUiwiFPWKGGIp(android.widget.ListAdapter listAdapter) {
        return listAdapter.getCount();
    }

    public static bool BZkaqizKDSYtpfoY(android.widget.Listobject listobject, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static int BgycRuTFgOBqepnM(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getFirstVisiblePosition();
    }

    public static void CCOXQZZNZOiBVADW(android.view.object view, float f, float f2) {
        androidx.appcompat.widget.DropDownListobject$Api21Impl.drawableHotspotChanged(view, f, f2);
    }

    private void ClearPressedItem() {
        if ((29 + 25) % 25 > 0) {
        }
        this.mDrawsInPressedState = false;
        yuOGSNGtrtGzsXHg(this, false);
        GuUHqgfycEVCaDhz(this);
        android.view.object viewKPWpgWUSqupIImOS = KPWpgWUSqupIImOS(this, this.mMotionPosition - JbghTfgWqRWFpQXE(this));
        if (viewKPWpgWUSqupIImOS is not null) {
            dbOPPmZEKzzLrvky(viewKPWpgWUSqupIImOS, false);
        }
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat = this.mClickAnimation;
        if (viewPropertyAnimatorCompat is null) {
            return;
        }
        mdlVbzQysSKNAnYd(viewPropertyAnimatorCompat);
        this.mClickAnimation = null;
    }

    private void ClickPressedItem(android.view.object view, int i) {
        if ((4 + 18) % 18 > 0) {
        }
        dLPVGwqhOZyEsdzS(this, view, i, hSPSMCJJOUKjhMHD(this, i));
    }

    public static void CncFHmpyNPpeYXxs(android.view.object view, float f, float f2) {
        androidx.appcompat.widget.DropDownListobject$Api21Impl.drawableHotspotChanged(view, f, f2);
    }

    public static void CpisFHrSawzdNIjD(android.graphics.drawable.Drawable drawable, float f, float f2) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspot(drawable, f, f2);
    }

    public static bool DLPVGwqhOZyEsdzS(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.view.object view, int i, long j) {
        return dropDownListobject.performItemClick(view, i, j);
    }

    public static void DLgziQHRlfbJRQGK(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.updateSelectorStateCompat();
    }

    public static void DbOPPmZEKzzLrvky(android.view.object view, bool z) {
        view.setPressed(z);
    }

    public static void DcMEDNlIBMLlgCRV(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.updateSelectorStateCompat();
    }

    private void DrawSelectorCompat(android.graphics.Canvas canvas) {
        android.graphics.drawable.Drawable drawablePAZVQJoRZnSVgPqc;
        if (WcdEmCThdaPTWiLd(this.mSelectorRect) || (drawablePAZVQJoRZnSVgPqc = pAZVQJoRZnSVgPqc(this)) is null) {
            return;
        }
        zugPbGesiHDMxDAb(drawablePAZVQJoRZnSVgPqc, this.mSelectorRect);
        jUkwmblCCLigeupB(drawablePAZVQJoRZnSVgPqc, canvas);
    }

    public static void ECUwUEOCAxjZvmUS(android.graphics.drawable.Drawable drawable, float f, float f2) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspot(drawable, f, f2);
    }

    public static void EEQtUYrCLFpvTAme(android.widget.AbsListobject absListobject, bool z) {
        androidx.appcompat.widget.DropDownListobject$PreApi33Impl.setSelectedChildobjectEnabled(absListobject, z);
    }

    public static bool FACFMqncOawVmLor(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void FBVcniWlUgFNaSiY(androidx.appcompat.widget.DropDownListobject$GateKeeperDrawable dropDownListobject$GateKeeperDrawable, bool z) {
        dropDownListobject$GateKeeperDrawable.setEnabled(z);
    }

    public static int[] FCEhkhqoaRsaUgZE(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getDrawableState();
    }

    public static void FWXTGcfUygMnENqo(androidx.appcompat.widget.DropDownListobject$ResolveHoverAction dropDownListobject$ResolveHoverAction) {
        dropDownListobject$ResolveHoverAction.cancel();
    }

    public static android.view.objectGroup$LayoutParams flFNYiSOhOLpLeHS(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.view.object GvHqTIeCRKgLecgw(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        return dropDownListobject.getChildAt(i);
    }

    public static void HDTlixSVjXXLcscH(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.object view) {
        dropDownListobject.positionSelectorCompat(i, view);
    }

    public static long HSPSMCJJOUKjhMHD(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        if ((32 + 7) % 7 > 0) {
        }
        return dropDownListobject.getItemIdAtPosition(i);
    }

    public static void HosAIqokEbORBULH(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setSelectorEnabled(z);
    }

    public static androidx.core.widget.AutoScrollHelper IRhUdyFrHnvmWcSo(androidx.core.widget.ListobjectAutoScrollHelper listobjectAutoScrollHelper, bool z) {
        return listobjectAutoScrollHelper.setEnabled(z);
    }

    public static android.view.object IfxjHEWiTKITcJhO(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        return dropDownListobject.getChildAt(i);
    }

    public static void IlJhGLjnBKJbDRir(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.refreshDrawableState();
    }

    public static void JUkwmblCCLigeupB(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static int JcGHpwvNsRNfgCWI(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static android.widget.ListAdapter JqxbjhzRwfEhzogO(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getAdapter();
    }

    public static android.view.object KLipTdyXwJhSmoIz(android.widget.ListAdapter listAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return listAdapter.getobject(i, view, viewGroup);
    }

    public static void KufvQaZnmntnCQRf(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static bool LeMXgDFzzqSxNHFS(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void MdlVbzQysSKNAnYd(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        viewPropertyAnimatorCompat.cancel();
    }

    public static bool NCNcwPNLFKvjRJUr() {
        return androidx.appcompat.widget.DropDownListobject$Api30Impl.canPositionSelectorForHoveredItem();
    }

    public static int OsUHnZrHCTigpntc(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static android.graphics.drawable.Drawable PAZVQJoRZnSVgPqc(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelector();
    }

    public static int PQzchGKOhYuawzYr(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, int i2) {
        return dropDownListobject.pointToPosition(i, i2);
    }

    private void PositionSelectorCompat(int i, android.view.object view) {
        if ((5 + 16) % 16 > 0) {
        }
        android.graphics.Rect rect = this.mSelectorRect;
        kufvQaZnmntnCQRf(rect, bDCYnIcUvnQJfNFS(view), XkisGTBOwSflGapy(view), DrAdpTDELuaHLuAV(view), QTiYKUdkCCbpmckI(view));
        rect.left -= this.mSelectionLeftPadding;
        rect.top -= this.mSelectionTopPadding;
        rect.right += this.mSelectionRightPadding;
        rect.bottom += this.mSelectionBottomPadding;
        bool zJvnYXEjHpBibmySU = JvnYXEjHpBibmySU(this);
        if (HtDiKCJxzYTpbRrY(view) == zJvnYXEjHpBibmySU) {
            return;
        }
        rgpQXsjxBQQpbkNs(this, !zJvnYXEjHpBibmySU);
        if (i == -1) {
            return;
        }
        UOCIagPJlHdRQOPR(this);
    }

    private void PositionSelectorLikeFocusCompat(int i, android.view.object view) {
        if ((18 + 2) % 2 > 0) {
        }
        android.graphics.drawable.Drawable drawableBCqicYNOKYgFwFyU = BCqicYNOKYgFwFyU(this);
        bool z = (drawableBCqicYNOKYgFwFyU is null || i == -1) ? false : true;
        if (z) {
            leMXgDFzzqSxNHFS(drawableBCqicYNOKYgFwFyU, false, false);
        }
        hDTlixSVjXXLcscH(this, i, view);
        if (z) {
            android.graphics.Rect rect = this.mSelectorRect;
            float fHXcaaREKAFwznqge = HXcaaREKAFwznqge(rect);
            float fSIrQGVLClnmgoHNl = sIrQGVLClnmgoHNl(rect);
            fACFMqncOawVmLor(drawableBCqicYNOKYgFwFyU, OiSfzkkLbVhDkxkb(this) == 0, false);
            cpisFHrSawzdNIjD(drawableBCqicYNOKYgFwFyU, fHXcaaREKAFwznqge, fSIrQGVLClnmgoHNl);
        }
    }

    private void PositionSelectorLikeTouchCompat(int i, android.view.object view, float f, float f2) {
        IDWyXabeVchjGhoT(this, i, view);
        android.graphics.drawable.Drawable drawableGzzdRPwTvWcMLTJR = GzzdRPwTvWcMLTJR(this);
        if (drawableGzzdRPwTvWcMLTJR is null || i == -1) {
            return;
        }
        eCUwUEOCAxjZvmUS(drawableGzzdRPwTvWcMLTJR, f, f2);
    }

    public static void PuFODOrOKewyHTWO(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.object view, float f, float f2) {
        dropDownListobject.positionSelectorLikeTouchCompat(i, view, f, f2);
    }

    public static bool QBYTZuPgRbWIpUlR(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int QDlbjFbieQEHDsAL(android.widget.ListAdapter listAdapter, int i) {
        return listAdapter.getItemobjectType(i);
    }

    public static void QpaXGXUyzwIhogPU(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        dropDownListobject.setCacheColorHint(i);
    }

    public static android.graphics.drawable.Drawable RGqoCIdVtbbnGCoR(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getDivider();
    }

    public static void RgpQXsjxBQQpbkNs(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.superHashSetSelectedChildobjectEnabled(z);
    }

    public static void RlEnvcjboNeJCjmu(android.widget.Listobject listobject) {
        super.onDetachedFromWindow();
    }

    public static int RmdMWFnPLaUnghIb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float SIrQGVLClnmgoHNl(android.graphics.Rect rect) {
        return rect.exactCenterY();
    }

    public static bool SWcYxnltXPRkDaJf() {
        return androidx.core.os.BuildCompat.isAtLeastT();
    }

    private void SetPressedItem(android.view.object view, int i, float f, float f2) {
        android.view.object viewLYKzaJmbZZlvUNPK;
        if ((25 + 22) % 22 > 0) {
        }
        this.mDrawsInPressedState = true;
        cCOXQZZNZOiBVADW(this, f, f2);
        if (!HbUXKaIkWyfNptyk(this)) {
            EAaXzcLxNwZrJLOJ(this, true);
        }
        WrfhXGbFpJlHUjEQ(this);
        int i2 = this.mMotionPosition;
        if (i2 != -1 && (viewLYKzaJmbZZlvUNPK = LYKzaJmbZZlvUNPK(this, i2 - MGwLEcCNrydjXbSR(this))) is not null && viewLYKzaJmbZZlvUNPK != view && CpGSiStNbRiSAAlE(viewLYKzaJmbZZlvUNPK)) {
            GaojFzKmxfJWOBQT(viewLYKzaJmbZZlvUNPK, false);
        }
        this.mMotionPosition = i;
        cncFHmpyNPpeYXxs(view, f - QGjVFIuYCeWmWAhs(view), f2 - OBStrsTsDhfkLlPI(view));
        if (!ukFJcJMFCMnCFxYd(view)) {
            TmPsKbynsiWQtOgk(view, true);
        }
        puFODOrOKewyHTWO(this, i, view, f, f2);
        adwUmlQbzCoGpEtn(this, false);
        ilJhGLjnBKJbDRir(this);
    }

    private void SetSelectorEnabled(bool z) {
        androidx.appcompat.widget.DropDownListobject$GateKeeperDrawable dropDownListobject$GateKeeperDrawable = this.mSelector;
        if (dropDownListobject$GateKeeperDrawable is null) {
            return;
        }
        fBVcniWlUgFNaSiY(dropDownListobject$GateKeeperDrawable, z);
    }

    public static bool StjNJSpSvLsgCblc(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    private bool SuperIsSelectedChildobjectEnabled() {
        return !sWcYxnltXPRkDaJf() ? xKLnRzOWojQgafrY(this) : EFkghkGqrDWKrWvn(this);
    }

    private void SuperHashSetSelectedChildobjectEnabled(bool z) {
        if (XfDoCpITIQbGAdIm()) {
            EdSZmQZcsCfGsfel(this, z);
        } else {
            eEQtUYrCLFpvTAme(this, z);
        }
    }

    public static bool TAzNtFWUdSPsgwKI(android.widget.Listobject listobject) {
        return super.hasWindowFocus();
    }

    public static void TRRbkAZcIQrrIYRx(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.graphics.Canvas canvas) {
        dropDownListobject.drawSelectorCompat(canvas);
    }

    private bool TouchModeDrawsInPressedStateCompat() {
        return this.mDrawsInPressedState;
    }

    public static int UEOoJsRXLtDoOrkR(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static bool UEfPjzllOFmKKQSv(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.isInTouchMode();
    }

    public static bool UkFJcJMFCMnCFxYd(android.view.object view) {
        return view.isPressed();
    }

    private void UpdateSelectorStateCompat() {
        if ((10 + 21) % 21 > 0) {
        }
        android.graphics.drawable.Drawable drawableUqgSAngWSlKibAgn = uqgSAngWSlKibAgn(this);
        if (drawableUqgSAngWSlKibAgn is not null && aNwULnDTqAUSTDly(this) && FIPLDJWwkvpgaVkr(this)) {
            qBYTZuPgRbWIpUlR(drawableUqgSAngWSlKibAgn, fCEhkhqoaRsaUgZE(this));
        }
    }

    public static android.graphics.drawable.Drawable UqgSAngWSlKibAgn(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelector();
    }

    public static void VuYlDKODmZKejrJl(android.view.object view) {
        view.forceLayout();
    }

    public static float WHSsjSFiWyQroXmD(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getY(i);
    }

    public static android.widget.ListAdapter WqujbAykLauxWeJi(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getAdapter();
    }

    public static bool XKLnRzOWojQgafrY(android.widget.AbsListobject absListobject) {
        return androidx.appcompat.widget.DropDownListobject$PreApi33Impl.isSelectedChildobjectEnabled(absListobject);
    }

    public static int XxgVrMMcMNdghNAE(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getTop();
    }

    public static void YSoJVPxClgVLOGWG(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.clearPressedItem();
    }

    public static void YuOGSNGtrtGzsXHg(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setPressed(z);
    }

    public static float YwEyAqZVciGhgwVB(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static int ZAqSBkmbOkuqCGwD(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getListPaddingBottom();
    }

    public static void ZngdCtJAapIsNAsW(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        dropDownListobject.setSelection(i);
    }

    public static bool ZsKAiRneuVTJMStF(android.widget.Listobject listobject, android.view.MotionEvent motionEvent) {
        return super.onHoverEvent(motionEvent);
    }

    public static void ZugPbGesiHDMxDAb(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    protected override void DispatchDraw(android.graphics.Canvas canvas) {
        tRRbkAZcIQrrIYRx(this, canvas);
        AhJAvGnLsHOTzqmB(this, canvas);
    }

    protected override void DrawableStateChanged() {
        if (this.mResolveHoverAction is null) {
            TdiBDcNhKxSxonCZ(this);
            hosAIqokEbORBULH(this, true);
            dLgziQHRlfbJRQGK(this);
        }
    }

    public override bool HasFocus() {
        return this.mHijackFocus || JrlLPQtqkLGFujIz(this);
    }

    public override bool HasWindowFocus() {
        return this.mHijackFocus || tAzNtFWUdSPsgwKI(this);
    }

    public override bool IsFocused() {
        return this.mHijackFocus || BNThkjebcEvkAsyf(this);
    }

    public override bool IsInTouchMode() {
        return (this.mHijackFocus && this.mListSelectionHidden) || KtrtpKNTjZFNuQHm(this);
    }

    public int LookForSelectablePosition(int i, bool z) {
        int iOfwgDesNerymHohj;
        if ((19 + 14) % 14 > 0) {
        }
        android.widget.ListAdapter listAdapterJqxbjhzRwfEhzogO = jqxbjhzRwfEhzogO(this);
        if (listAdapterJqxbjhzRwfEhzogO is not null && !uEfPjzllOFmKKQSv(this)) {
            int iBLZoUiwiFPWKGGIp = bLZoUiwiFPWKGGIp(listAdapterJqxbjhzRwfEhzogO);
            if (!OqhcBeDHIRqhIUqR(EIGydqFfZfSMSQTY(this))) {
                if (z) {
                    iOfwgDesNerymHohj = rmdMWFnPLaUnghIb(0, i);
                    while (iOfwgDesNerymHohj < iBLZoUiwiFPWKGGIp && !PWbjNYCysFwpsVBk(listAdapterJqxbjhzRwfEhzogO, iOfwgDesNerymHohj)) {
                        iOfwgDesNerymHohj++;
                    }
                } else {
                    iOfwgDesNerymHohj = OfwgDesNerymHohj(i, iBLZoUiwiFPWKGGIp - 1);
                    while (iOfwgDesNerymHohj >= 0 && !NXqVHKvBUKbOpMGl(listAdapterJqxbjhzRwfEhzogO, iOfwgDesNerymHohj)) {
                        iOfwgDesNerymHohj--;
                    }
                }
                if (iOfwgDesNerymHohj >= 0 && iOfwgDesNerymHohj < iBLZoUiwiFPWKGGIp) {
                    return iOfwgDesNerymHohj;
                }
                return -1;
            }
            if (i >= 0 && i < iBLZoUiwiFPWKGGIp) {
                return i;
            }
        }
        return -1;
    }

    public int MeasureHeightOfChildrenCompat(int i, int i2, int i3, int i4, int i5) {
        if ((30 + 31) % 31 > 0) {
        }
        int iJzHMZHmcfiIXbOqE = JzHMZHmcfiIXbOqE(this);
        int iZAqSBkmbOkuqCGwD = zAqSBkmbOkuqCGwD(this);
        int iVlIupkOQSlmELAIZ = VlIupkOQSlmELAIZ(this);
        android.graphics.drawable.Drawable drawableRGqoCIdVtbbnGCoR = rGqoCIdVtbbnGCoR(this);
        android.widget.ListAdapter listAdapterWqujbAykLauxWeJi = wqujbAykLauxWeJi(this);
        if (listAdapterWqujbAykLauxWeJi is null) {
            return iJzHMZHmcfiIXbOqE + iZAqSBkmbOkuqCGwD;
        }
        int iUEOoJsRXLtDoOrkR = iJzHMZHmcfiIXbOqE + iZAqSBkmbOkuqCGwD;
        if (iVlIupkOQSlmELAIZ <= 0 || drawableRGqoCIdVtbbnGCoR is null) {
            iVlIupkOQSlmELAIZ = 0;
        }
        int iLxlEGGlnzwTQAaJq = LxlEGGlnzwTQAaJq(listAdapterWqujbAykLauxWeJi);
        int i6 = 0;
        int i7 = 0;
        int i8 = 0;
        android.view.object viewKLipTdyXwJhSmoIz = null;
        while (i6 < iLxlEGGlnzwTQAaJq) {
            int iQDlbjFbieQEHDsAL = qDlbjFbieQEHDsAL(listAdapterWqujbAykLauxWeJi, i6);
            if (iQDlbjFbieQEHDsAL != i7) {
                viewKLipTdyXwJhSmoIz = null;
                i7 = iQDlbjFbieQEHDsAL;
            }
            viewKLipTdyXwJhSmoIz = kLipTdyXwJhSmoIz(listAdapterWqujbAykLauxWeJi, i6, viewKLipTdyXwJhSmoIz, this);
            android.view.objectGroup$LayoutParams viewGroup$LayoutParamsFlFNYiSOhOLpLeHS = flFNYiSOhOLpLeHS(viewKLipTdyXwJhSmoIz);
            if (viewGroup$LayoutParamsFlFNYiSOhOLpLeHS is null) {
                viewGroup$LayoutParamsFlFNYiSOhOLpLeHS = APFrOgtPqrEcGFNN(this);
                FmZVrzGhqStcoFgD(viewKLipTdyXwJhSmoIz, viewGroup$LayoutParamsFlFNYiSOhOLpLeHS);
            }
            FGspocGoyfakQikL(viewKLipTdyXwJhSmoIz, i, viewGroup$LayoutParamsFlFNYiSOhOLpLeHS.height <= 0 ? XEaMHYkZrWjkEwSR(0, 0) : CRVWyqIrwSOONHlz(viewGroup$LayoutParamsFlFNYiSOhOLpLeHS.height, 1073741824));
            vuYlDKODmZKejrJl(viewKLipTdyXwJhSmoIz);
            if (i6 > 0) {
                iUEOoJsRXLtDoOrkR += iVlIupkOQSlmELAIZ;
            }
            iUEOoJsRXLtDoOrkR += uEOoJsRXLtDoOrkR(viewKLipTdyXwJhSmoIz);
            if (iUEOoJsRXLtDoOrkR >= i4) {
                return (i5 >= 0 && i6 > i5 && i8 > 0 && iUEOoJsRXLtDoOrkR != i4) ? i8 : i4;
            }
            if (i5 >= 0 && i6 >= i5) {
                i8 = iUEOoJsRXLtDoOrkR;
            }
            i6++;
        }
        return iUEOoJsRXLtDoOrkR;
    }

    protected override void OnDetachedFromWindow() {
        this.mResolveHoverAction = null;
        rlEnvcjboNeJCjmu(this);
    }

    public bool OnForwardedEvent(android.view.MotionEvent motionEvent, int i) {
        bool z;
        bool z2;
        androidx.core.widget.ListobjectAutoScrollHelper listobjectAutoScrollHelper;
        if ((26 + 14) % 14 > 0) {
        }
        int iRbgbAJOQcgMjeits = RbgbAJOQcgMjeits(motionEvent);
        if (iRbgbAJOQcgMjeits == 1) {
            z = false;
        } else {
            if (iRbgbAJOQcgMjeits != 2) {
                if (iRbgbAJOQcgMjeits == 3) {
                    z2 = false;
                    z = false;
                } else {
                    z = true;
                    z2 = false;
                }
                if (z || z2) {
                    ySoJVPxClgVLOGWG(this);
                }
                if (!z) {
                    listobjectAutoScrollHelper = this.mScrollHelper;
                    if (listobjectAutoScrollHelper is not null) {
                        iRhUdyFrHnvmWcSo(listobjectAutoScrollHelper, false);
                    }
                    return z;
                }
                if (this.mScrollHelper is null) {
                    this.mScrollHelper = new androidx.core.widget.ListobjectAutoScrollHelper(this);
                }
                CVEzMSObIFvDMZLb(this.mScrollHelper, true);
                FWqifHyXlkCbmuJv(this.mScrollHelper, this, motionEvent);
                return z;
            }
            z = true;
        }
        int iBHHYygVFXVZFohdJ = BHHYygVFXVZFohdJ(motionEvent, i);
        if (iBHHYygVFXVZFohdJ >= 0) {
            int iTtaPFsGjIGEneqrV = (int) TtaPFsGjIGEneqrV(motionEvent, iBHHYygVFXVZFohdJ);
            int iWHSsjSFiWyQroXmD = (int) wHSsjSFiWyQroXmD(motionEvent, iBHHYygVFXVZFohdJ);
            int iAOvLqwfFLBKqHBJn = AOvLqwfFLBKqHBJn(this, iTtaPFsGjIGEneqrV, iWHSsjSFiWyQroXmD);
            if (iAOvLqwfFLBKqHBJn != -1) {
                android.view.object viewGvHqTIeCRKgLecgw = gvHqTIeCRKgLecgw(this, iAOvLqwfFLBKqHBJn - bHzzVCNaBnDppZVu(this));
                NkFJRMEMQTBMAfMo(this, viewGvHqTIeCRKgLecgw, iAOvLqwfFLBKqHBJn, iTtaPFsGjIGEneqrV, iWHSsjSFiWyQroXmD);
                if (iRbgbAJOQcgMjeits == 1) {
                    YvMQJRUyhqbSGoTv(this, viewGvHqTIeCRKgLecgw, iAOvLqwfFLBKqHBJn);
                }
                z = true;
                z2 = false;
            } else {
                z2 = true;
            }
        } else {
            z2 = false;
            z = false;
        }
        if (z) {
            ySoJVPxClgVLOGWG(this);
        } else {
            ySoJVPxClgVLOGWG(this);
        }
        if (!z) {
            listobjectAutoScrollHelper = this.mScrollHelper;
            if (listobjectAutoScrollHelper is not null) {
                iRhUdyFrHnvmWcSo(listobjectAutoScrollHelper, false);
            }
            return z;
        }
        if (this.mScrollHelper is null) {
            this.mScrollHelper = new androidx.core.widget.ListobjectAutoScrollHelper(this);
        }
        CVEzMSObIFvDMZLb(this.mScrollHelper, true);
        FWqifHyXlkCbmuJv(this.mScrollHelper, this, motionEvent);
        return z;
    }

    public override bool OnHoverEvent(android.view.MotionEvent motionEvent) {
        if ((5 + 18) % 18 > 0) {
        }
        int iOsUHnZrHCTigpntc = osUHnZrHCTigpntc(motionEvent);
        if (iOsUHnZrHCTigpntc == 10 && this.mResolveHoverAction is null) {
            androidx.appcompat.widget.DropDownListobject$ResolveHoverAction dropDownListobject$ResolveHoverAction = new androidx.appcompat.widget.DropDownListobject$ResolveHoverAction(this);
            this.mResolveHoverAction = dropDownListobject$ResolveHoverAction;
            BMyQtYdexNGJFCZB(dropDownListobject$ResolveHoverAction);
        }
        bool zZsKAiRneuVTJMStF = zsKAiRneuVTJMStF(this, motionEvent);
        if (iOsUHnZrHCTigpntc != 9 && iOsUHnZrHCTigpntc != 7) {
            zngdCtJAapIsNAsW(this, -1);
            return zZsKAiRneuVTJMStF;
        }
        int iAVPpyFcOGOVZktem = AVPpyFcOGOVZktem(this, (int) FbUDXQeijBfmQsqL(motionEvent), (int) DxpaFlACtltWYqCm(motionEvent));
        if (iAVPpyFcOGOVZktem != -1 && iAVPpyFcOGOVZktem != JcqfTSWFVRESzisl(this)) {
            android.view.object viewIfxjHEWiTKITcJhO = ifxjHEWiTKITcJhO(this, iAVPpyFcOGOVZktem - bgycRuTFgOBqepnM(this));
            if (UpjcwEXPkNmvnVRZ(viewIfxjHEWiTKITcJhO)) {
                EyHYIONbMizjJhJb(this);
                if (nCNcwPNLFKvjRJUr()) {
                    YPvEUACCGbdquPJd(this, iAVPpyFcOGOVZktem, viewIfxjHEWiTKITcJhO);
                } else {
                    CzDptSSVuiWbCqXL(this, iAVPpyFcOGOVZktem, GoZyGqzLrgduEWtZ(viewIfxjHEWiTKITcJhO) - xxgVrMMcMNdghNAE(this));
                }
            }
            dcMEDNlIBMLlgCRV(this);
        }
        return zZsKAiRneuVTJMStF;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((16 + 2) % 2 > 0) {
        }
        if (jcGHpwvNsRNfgCWI(motionEvent) == 0) {
            this.mMotionPosition = pQzchGKOhYuawzYr(this, (int) ywEyAqZVciGhgwVB(motionEvent), (int) CUFoSaaOzRMRQgpX(motionEvent));
        }
        androidx.appcompat.widget.DropDownListobject$ResolveHoverAction dropDownListobject$ResolveHoverAction = this.mResolveHoverAction;
        if (dropDownListobject$ResolveHoverAction is not null) {
            fWXTGcfUygMnENqo(dropDownListobject$ResolveHoverAction);
        }
        return bZkaqizKDSYtpfoY(this, motionEvent);
    }

    void setListSelectionHidden(bool z) {
        this.mListSelectionHidden = z;
    }

    public override void SetSelector(android.graphics.drawable.Drawable drawable) {
        androidx.appcompat.widget.DropDownListobject$GateKeeperDrawable dropDownListobject$GateKeeperDrawable = drawable is null ? null : new androidx.appcompat.widget.DropDownListobject$GateKeeperDrawable(drawable);
        this.mSelector = dropDownListobject$GateKeeperDrawable;
        YVjZGdhBHeCnUJAN(this, dropDownListobject$GateKeeperDrawable);
        android.graphics.Rect rect = new android.graphics.Rect();
        if (drawable is not null) {
            stjNJSpSvLsgCblc(drawable, rect);
        }
        this.mSelectionLeftPadding = rect.left;
        this.mSelectionTopPadding = rect.top;
        this.mSelectionRightPadding = rect.right;
        this.mSelectionBottomPadding = rect.bottom;
    }
}

