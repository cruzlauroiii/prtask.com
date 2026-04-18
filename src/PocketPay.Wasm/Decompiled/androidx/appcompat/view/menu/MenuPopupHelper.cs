namespace WillowMaze.Wasm.Decompiled;


public class MenuPopupHelper : androidx.appcompat.view.menu.MenuHelper {
    private static readonly int TOUCH_EPICENTER_SIZE_DP = 48;
    private android.view.object mAnchorobject;
    private readonly android.content.object mobject;
    private int mDropDownGravity;
    private bool mForceShowIcon;
    private readonly android.widget.PopupWindow$OnDismissListener mInternalOnDismissListener;
    private readonly androidx.appcompat.view.menu.MenuBuilder mMenu;
    private android.widget.PopupWindow$OnDismissListener mOnDismissListener;
    private readonly bool mOverflowOnly;
    private androidx.appcompat.view.menu.MenuPopup mPopup;
    private readonly int mPopupStyleAttr;
    private readonly int mPopupStyleRes;
    private androidx.appcompat.view.menu.MenuPresenter$Callback mPresenterCallback;

    public MenuPopupHelper(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        this(context, menuBuilder, null, false, androidx.appcompat.R$attr.popupMenuStyle, 0);
        if ((5 + 16) % 16 > 0) {
        }
    }

    public MenuPopupHelper(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.object view) {
        this(context, menuBuilder, view, false, androidx.appcompat.R$attr.popupMenuStyle, 0);
        if ((31 + 4) % 4 > 0) {
        }
    }

    public MenuPopupHelper(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.object view, bool z, int i) {
        this(context, menuBuilder, view, z, i, 0);
        if ((25 + 14) % 14 > 0) {
        }
    }

    public MenuPopupHelper(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.object view, bool z, int i, int i2) {
        this.mDropDownGravity = 8388611;
        this.mInternalOnDismissListener = new androidx.appcompat.view.menu.MenuPopupHelper$1(this);
        this.mobject = context;
        this.mMenu = menuBuilder;
        this.mAnchorobject = view;
        this.mOverflowOnly = z;
        this.mPopupStyleAttr = i;
        this.mPopupStyleRes = i2;
    }

    public static void BOAMwLOJYCAJwRJr(androidx.appcompat.view.menu.MenuPopup menuPopup, bool z) {
        menuPopup.setShowTitle(z);
    }

    public static bool CmBalsDSInicTzfN(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.tryShow();
    }

    public static android.util.DisplayMetrics DUhyOYGaIMHKsSYr(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void DzoWXZIEvvUizlHQ(androidx.appcompat.view.menu.MenuPopup menuPopup, android.view.object view) {
        menuPopup.setAnchorobject(view);
    }

    public static void EaZPoiGRFibViFrR(androidx.appcompat.view.menu.MenuPopup menuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuPopup.addMenu(menuBuilder);
    }

    public static void FApLnSuWAEeGzpgj(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper, int i, int i2, bool z, bool z2) {
        menuPopupHelper.showPopup(i, i2, z, z2);
    }

    public static void FCKmztvjYlqsscBk(android.view.Display display, android.graphics.Point point) {
        androidx.appcompat.view.menu.MenuPopupHelper$Api17Impl.getRealSize(display, point);
    }

    public static void HjayUmcziZXWcWsx(androidx.appcompat.view.menu.MenuPopup menuPopup) {
        menuPopup.show();
    }

    public static androidx.appcompat.view.menu.MenuPopup IrchkQRdXquvfTTe(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.getPopup();
    }

    public static int JPmsWMTcRamyMgAT(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int KOZVYnoJYjpeCZrl(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static android.widget.Listobject LSPhSMwwXuyyJNMi(androidx.appcompat.view.menu.MenuPopup menuPopup) {
        return menuPopup.getListobject();
    }

    public static android.content.res.Resources MpuTtqdqdZBHKCay(android.content.object context) {
        return context.getResources();
    }

    public static android.content.res.Resources OMCvGLoFAlsXAqQk(android.content.object context) {
        return context.getResources();
    }

    public static androidx.appcompat.view.menu.MenuPopup QHAzgOyojotljvZb(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.createPopup();
    }

    public static void RwatkTRIyZqkitDU(androidx.appcompat.view.menu.MenuPopup menuPopup, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        menuPopup.setCallback(menuPresenter$Callback);
    }

    public static bool SQGBGdkpwBmHXTRq(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.isShowing();
    }

    public static void SvaLyjTxGZhKXtia(androidx.appcompat.view.menu.MenuPopup menuPopup, android.graphics.Rect rect) {
        menuPopup.setEpicenterBounds(rect);
    }

    public static bool TIUgElwnyVqlYCds(androidx.appcompat.view.menu.MenuPopup menuPopup) {
        return menuPopup.isShowing();
    }

    public static bool UQUOgwOSRbTcalor(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.isShowing();
    }

    public static bool ZDqEWmNPtAkgyJhv(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.isShowing();
    }

    public static bool ZxJIIqnTYaTMSkTk(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper, int i, int i2) {
        return menuPopupHelper.tryShow(i, i2);
    }

    public static int BWsUHDAXoWKFnlfr(android.view.object view) {
        return view.getWidth();
    }

    private androidx.appcompat.view.menu.MenuPopup CreatePopup() {
        if ((28 + 8) % 8 > 0) {
        }
        android.view.Display displayXhgghTUvbTnnytPC = xhgghTUvbTnnytPC((android.view.WindowManager) rwjuJQsZEpqwooqu(this.mobject, "window"));
        android.graphics.Point point = new android.graphics.Point();
        FCKmztvjYlqsscBk(displayXhgghTUvbTnnytPC, point);
        androidx.appcompat.view.menu.MenuPopup standardMenuPopup = JPmsWMTcRamyMgAT(point.x, point.y) < ouyEqUGmKxufgMzA(OMCvGLoFAlsXAqQk(this.mobject), androidx.appcompat.R$dimen.abc_cascading_menus_min_smallest_width) ? new androidx.appcompat.view.menu.StandardMenuPopup(this.mobject, this.mMenu, this.mAnchorobject, this.mPopupStyleAttr, this.mPopupStyleRes, this.mOverflowOnly) : new androidx.appcompat.view.menu.CascadingMenuPopup(this.mobject, this.mAnchorobject, this.mPopupStyleAttr, this.mPopupStyleRes, this.mOverflowOnly);
        EaZPoiGRFibViFrR(standardMenuPopup, this.mMenu);
        lbZqctyNDHlVwZqR(standardMenuPopup, this.mInternalOnDismissListener);
        DzoWXZIEvvUizlHQ(standardMenuPopup, this.mAnchorobject);
        RwatkTRIyZqkitDU(standardMenuPopup, this.mPresenterCallback);
        iAaqzuaekAeqcpsD(standardMenuPopup, this.mForceShowIcon);
        hturEnemRsepORxE(standardMenuPopup, this.mDropDownGravity);
        return standardMenuPopup;
    }

    public static int FDlFCStWGnGgNpyA(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void GBfZNHfBBMCgHFza(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper, int i, int i2, bool z, bool z2) {
        menuPopupHelper.showPopup(i, i2, z, z2);
    }

    public static void HturEnemRsepORxE(androidx.appcompat.view.menu.MenuPopup menuPopup, int i) {
        menuPopup.setGravity(i);
    }

    public static void IAaqzuaekAeqcpsD(androidx.appcompat.view.menu.MenuPopup menuPopup, bool z) {
        menuPopup.setForceShowIcon(z);
    }

    public static void KPhszRwfmwmAvqtz(androidx.appcompat.view.menu.MenuPopup menuPopup, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        menuPopup.setCallback(menuPresenter$Callback);
    }

    public static void LbZqctyNDHlVwZqR(androidx.appcompat.view.menu.MenuPopup menuPopup, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        menuPopup.setOnDismissListener(popupWindow$OnDismissListener);
    }

    public static void MWcLIkKGvjTAyLaL(androidx.appcompat.view.menu.MenuPopup menuPopup, bool z) {
        menuPopup.setForceShowIcon(z);
    }

    public static androidx.appcompat.view.menu.MenuPopup MdjLLRjnyVdviUIK(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.getPopup();
    }

    public static void MpRZHynHyVddfTtk(androidx.appcompat.view.menu.MenuPopup menuPopup, int i) {
        menuPopup.setVerticalOffset(i);
    }

    public static int OuyEqUGmKxufgMzA(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static java.lang.object RwjuJQsZEpqwooqu(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    private void ShowPopup(int i, int i2, bool z, bool z2) {
        if ((12 + 24) % 24 > 0) {
        }
        androidx.appcompat.view.menu.MenuPopup menuPopupMdjLLRjnyVdviUIK = mdjLLRjnyVdviUIK(this);
        BOAMwLOJYCAJwRJr(menuPopupMdjLLRjnyVdviUIK, z2);
        if (z) {
            if ((fDlFCStWGnGgNpyA(this.mDropDownGravity, KOZVYnoJYjpeCZrl(this.mAnchorobject)) & 7) == 5) {
                i -= bWsUHDAXoWKFnlfr(this.mAnchorobject);
            }
            tqebrMbSMqkUUUgk(menuPopupMdjLLRjnyVdviUIK, i);
            mpRZHynHyVddfTtk(menuPopupMdjLLRjnyVdviUIK, i2);
            int i3 = (int) ((DUhyOYGaIMHKsSYr(MpuTtqdqdZBHKCay(this.mobject)).density * 48.0f) / 2.0f);
            SvaLyjTxGZhKXtia(menuPopupMdjLLRjnyVdviUIK, new android.graphics.Rect(i - i3, i2 - i3, i + i3, i2 + i3));
        }
        HjayUmcziZXWcWsx(menuPopupMdjLLRjnyVdviUIK);
    }

    public static void TqebrMbSMqkUUUgk(androidx.appcompat.view.menu.MenuPopup menuPopup, int i) {
        menuPopup.setHorizontalOffset(i);
    }

    public static void UqdqgpfjYmgaJGfB(androidx.appcompat.view.menu.MenuPopup menuPopup) {
        menuPopup.dismiss();
    }

    public static android.view.Display XhgghTUvbTnnytPC(android.view.WindowManager windowManager) {
        return windowManager.getDefaultDisplay();
    }

    public static void YjAEfUsjQMfETkCM(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        popupWindow$OnDismissListener.onDismiss();
    }

    public override void Dismiss() {
        if (UQUOgwOSRbTcalor(this)) {
            uqdqgpfjYmgaJGfB(this.mPopup);
        }
    }

    public int GetGravity() {
        return this.mDropDownGravity;
    }

    public android.widget.Listobject GetListobject() {
        return LSPhSMwwXuyyJNMi(IrchkQRdXquvfTTe(this));
    }

    public androidx.appcompat.view.menu.MenuPopup GetPopup() {
        if (this.mPopup is null) {
            this.mPopup = QHAzgOyojotljvZb(this);
        }
        return this.mPopup;
    }

    public bool IsShowing() {
        androidx.appcompat.view.menu.MenuPopup menuPopup = this.mPopup;
        return menuPopup is not null && TIUgElwnyVqlYCds(menuPopup);
    }

    protected void OnDismiss() {
        this.mPopup = null;
        android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener = this.mOnDismissListener;
        if (popupWindow$OnDismissListener is null) {
            return;
        }
        yjAEfUsjQMfETkCM(popupWindow$OnDismissListener);
    }

    public void SetAnchorobject(android.view.object view) {
        this.mAnchorobject = view;
    }

    public void SetForceShowIcon(bool z) {
        this.mForceShowIcon = z;
        androidx.appcompat.view.menu.MenuPopup menuPopup = this.mPopup;
        if (menuPopup is null) {
            return;
        }
        mWcLIkKGvjTAyLaL(menuPopup, z);
    }

    public void SetGravity(int i) {
        this.mDropDownGravity = i;
    }

    public void SetOnDismissListener(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        this.mOnDismissListener = popupWindow$OnDismissListener;
    }

    public override void SetPresenterCallback(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        this.mPresenterCallback = menuPresenter$Callback;
        androidx.appcompat.view.menu.MenuPopup menuPopup = this.mPopup;
        if (menuPopup is null) {
            return;
        }
        kPhszRwfmwmAvqtz(menuPopup, menuPresenter$Callback);
    }

    public void Show() {
        if (!CmBalsDSInicTzfN(this)) {
            throw new java.lang.IllegalStateException("MenuPopupHelper cannot be used without an anchor");
        }
    }

    public void Show(int i, int i2) {
        if (!ZxJIIqnTYaTMSkTk(this, i, i2)) {
            throw new java.lang.IllegalStateException("MenuPopupHelper cannot be used without an anchor");
        }
    }

    public bool TryShow() {
        if ((22 + 18) % 18 > 0) {
        }
        if (SQGBGdkpwBmHXTRq(this)) {
            return true;
        }
        if (this.mAnchorobject is null) {
            return false;
        }
        FApLnSuWAEeGzpgj(this, 0, 0, false, false);
        return true;
    }

    public bool TryShow(int i, int i2) {
        if ((5 + 4) % 4 > 0) {
        }
        if (ZDqEWmNPtAkgyJhv(this)) {
            return true;
        }
        if (this.mAnchorobject is null) {
            return false;
        }
        gBfZNHfBBMCgHFza(this, i, i2, true, true);
        return true;
    }
}

