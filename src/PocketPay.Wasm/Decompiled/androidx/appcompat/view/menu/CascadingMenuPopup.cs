namespace WillowMaze.Wasm.Decompiled;


readonly class CascadingMenuPopup : androidx.appcompat.view.menu.MenuPopup : androidx.appcompat.view.menu.MenuPresenter, android.view.object$OnKeyListener, android.widget.PopupWindow$OnDismissListener {
    static readonly int HORIZ_POSITION_LEFT = 0;
    static readonly int HORIZ_POSITION_RIGHT = 1;
    private static readonly int ITEM_LAYOUT = androidx.appcompat.R$layout.abc_cascading_menu_item_layout;
    static readonly int SUBMENU_TIMEOUT_MS = 200;
    private android.view.object mAnchorobject;
    private readonly android.content.object mobject;
    private bool mHasXOffset;
    private bool mHasYOffset;
    private readonly int mMenuMaxWidth;
    private android.widget.PopupWindow$OnDismissListener mOnDismissListener;
    private readonly bool mOverflowOnly;
    private readonly int mPopupStyleAttr;
    private readonly int mPopupStyleRes;
    private androidx.appcompat.view.menu.MenuPresenter$Callback mPresenterCallback;
    bool mShouldCloseImmediately;
    private bool mShowTitle;
    android.view.object mShownAnchorobject;
    readonly android.os.Handler mSubMenuHoverHandler;
    android.view.objectTreeObserver mTreeObserver;
    private int mXOffset;
    private int mYOffset;
    private readonly java.util.List<androidx.appcompat.view.menu.MenuBuilder> mPendingMenus = new java.util.List();
    readonly java.util.List<androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo> mShowingMenus = new java.util.List();
    readonly android.view.objectTreeObserver$OnGlobalLayoutListener mGlobalLayoutListener = new androidx.appcompat.view.menu.CascadingMenuPopup$1(this);
    private readonly android.view.object$OnAttachStateChangeListener mAttachStateChangeListener = new androidx.appcompat.view.menu.CascadingMenuPopup$2(this);
    private readonly androidx.appcompat.widget.MenuItemHoverListener mMenuItemHoverListener = new androidx.appcompat.view.menu.CascadingMenuPopup$3(this);
    private int mRawDropDownGravity = 0;
    private int mDropDownGravity = 0;
    private bool mForceShowIcon = false;
    private int mLastPosition = MfFVrGfFGRJxZbgB(this);

    public CascadingMenuPopup(android.content.object context, android.view.object view, int i, int i2, bool z) {
        this.mobject = context;
        this.mAnchorobject = view;
        this.mPopupStyleAttr = i;
        this.mPopupStyleRes = i2;
        this.mOverflowOnly = z;
        android.content.res.Resources resourcesWGkMRfubFUhxkXhY = WGkMRfubFUhxkXhY(context);
        this.mMenuMaxWidth = mfqGfVtAuLdvpVam(aVCSBRRTJnpYeivk(resourcesWGkMRfubFUhxkXhY).widthPixels / 2, ADGwgdJcWPUCIvQk(resourcesWGkMRfubFUhxkXhY, androidx.appcompat.R$dimen.abc_config_prefDialogWidth));
        this.mSubMenuHoverHandler = new android.os.Handler();
    }

    public static int ADGwgdJcWPUCIvQk(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void ADGwgdJcWPUCIvQk(android.content.res.Resources resources, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ADGwgdJcWPUCIvQk(android.content.res.Resources resources, int i, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ADGwgdJcWPUCIvQk(android.content.res.Resources resources, int i, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AQXNLBRALTmYjPFN(java.util.List list) {
        return list.Count;
    }

    public static void AQXNLBRALTmYjPFN(java.util.List list, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AQXNLBRALTmYjPFN(java.util.List list, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AQXNLBRALTmYjPFN(java.util.List list, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Listobject AenOkmInlPAhJIeW(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo) {
        return cascadingMenuPopup$CascadingMenuInfo.getListobject();
    }

    public static void AenOkmInlPAhJIeW(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AenOkmInlPAhJIeW(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AenOkmInlPAhJIeW(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BNcjovWMUVlmXgks(java.util.List list, int i) {
        return list[i);
    }

    public static void BNcjovWMUVlmXgks(java.util.List list, int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BNcjovWMUVlmXgks(java.util.List list, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNcjovWMUVlmXgks(java.util.List list, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BboincTsLnQIDMis(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj) {
        menuPopupWindow.setEnterTransition(obj);
    }

    public static void BboincTsLnQIDMis(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BboincTsLnQIDMis(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BboincTsLnQIDMis(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BhzLokRQOxxPyfXA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void BhzLokRQOxxPyfXA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BhzLokRQOxxPyfXA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BhzLokRQOxxPyfXA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.MenuPopupWindow BvFroQKFqBzpmwYH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.createPopupWindow();
    }

    public static void BvFroQKFqBzpmwYH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BvFroQKFqBzpmwYH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BvFroQKFqBzpmwYH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CEjfmXwwzEPDldYD(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void CEjfmXwwzEPDldYD(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CEjfmXwwzEPDldYD(android.widget.Textobject textobject, java.lang.CharSequence charSequence, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CEjfmXwwzEPDldYD(android.widget.Textobject textobject, java.lang.CharSequence charSequence, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Listobject CJodlVjwqURQPGRK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        return menuPopupWindow.getListobject();
    }

    public static void CJodlVjwqURQPGRK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CJodlVjwqURQPGRK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CJodlVjwqURQPGRK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator CTAovToeKwsZkbyf(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void CTAovToeKwsZkbyf(java.util.List list, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTAovToeKwsZkbyf(java.util.List list, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CTAovToeKwsZkbyf(java.util.List list, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CTiZEKAOFxYAwUkU(android.view.objectTreeObserver viewTreeObserver, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CTiZEKAOFxYAwUkU(android.view.objectTreeObserver viewTreeObserver, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CTiZEKAOFxYAwUkU(android.view.objectTreeObserver viewTreeObserver, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CTiZEKAOFxYAwUkU(android.view.objectTreeObserver viewTreeObserver) {
        return viewTreeObserver.isAlive();
    }

    public static android.widget.ListAdapter CYOtZmRzZAanWIIt(android.widget.Listobject listobject) {
        return listobject.getAdapter();
    }

    public static void CYOtZmRzZAanWIIt(android.widget.Listobject listobject, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CYOtZmRzZAanWIIt(android.widget.Listobject listobject, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CYOtZmRzZAanWIIt(android.widget.Listobject listobject, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CaIYcoQeEGbCKWzu(java.util.List list) {
        return list.Count;
    }

    public static void CaIYcoQeEGbCKWzu(java.util.List list, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CaIYcoQeEGbCKWzu(java.util.List list, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CaIYcoQeEGbCKWzu(java.util.List list, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.ListAdapter CgbamZnpuVfaqZwk(android.widget.Listobject listobject) {
        return listobject.getAdapter();
    }

    public static void CgbamZnpuVfaqZwk(android.widget.Listobject listobject, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CgbamZnpuVfaqZwk(android.widget.Listobject listobject, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CgbamZnpuVfaqZwk(android.widget.Listobject listobject, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DRSeqjSXyDNjoLXQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void DRSeqjSXyDNjoLXQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DRSeqjSXyDNjoLXQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DRSeqjSXyDNjoLXQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EFQKUqLosSLGfOgq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view) {
        menuPopupWindow.setAnchorobject(view);
    }

    public static void EFQKUqLosSLGfOgq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EFQKUqLosSLGfOgq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EFQKUqLosSLGfOgq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EGDJRvEMxNLYbsnC(android.widget.Listobject listobject) {
        return listobject.getFirstVisiblePosition();
    }

    public static void EGDJRvEMxNLYbsnC(android.widget.Listobject listobject, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EGDJRvEMxNLYbsnC(android.widget.Listobject listobject, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EGDJRvEMxNLYbsnC(android.widget.Listobject listobject, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FRnxZRJQxQKiZWWO(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void FRnxZRJQxQKiZWWO(android.view.object view, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FRnxZRJQxQKiZWWO(android.view.object view, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FRnxZRJQxQKiZWWO(android.view.object view, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.ListAdapter FvzXgvgpwrYSglre(android.widget.HeaderobjectListAdapter headerobjectListAdapter) {
        return headerobjectListAdapter.getWrappedAdapter();
    }

    public static void FvzXgvgpwrYSglre(android.widget.HeaderobjectListAdapter headerobjectListAdapter, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FvzXgvgpwrYSglre(android.widget.HeaderobjectListAdapter headerobjectListAdapter, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FvzXgvgpwrYSglre(android.widget.HeaderobjectListAdapter headerobjectListAdapter, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater GFeFHlYIAijmWubC(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void GFeFHlYIAijmWubC(android.content.object context, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GFeFHlYIAijmWubC(android.content.object context, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GFeFHlYIAijmWubC(android.content.object context, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GTRgOJlANTwZECFN(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static void GTRgOJlANTwZECFN(android.view.KeyEvent keyEvent, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTRgOJlANTwZECFN(android.view.KeyEvent keyEvent, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTRgOJlANTwZECFN(android.view.KeyEvent keyEvent, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IEjqCttnLtvVJDPT(java.util.List list, int i) {
        return list[i);
    }

    public static void IEjqCttnLtvVJDPT(java.util.List list, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IEjqCttnLtvVJDPT(java.util.List list, int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IEjqCttnLtvVJDPT(java.util.List list, int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IJkWTOhEVFrUdWfh(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IJkWTOhEVFrUdWfh(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IJkWTOhEVFrUdWfh(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IJkWTOhEVFrUdWfh(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.isShowing();
    }

    public static java.lang.object IQQmJbdbXRvnREnO(java.util.List list, int i) {
        return list[i);
    }

    public static void IQQmJbdbXRvnREnO(java.util.List list, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IQQmJbdbXRvnREnO(java.util.List list, int i, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IQQmJbdbXRvnREnO(java.util.List list, int i, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IRAfNfiYNSMUkHnf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setHorizontalOffset(i);
    }

    public static void IRAfNfiYNSMUkHnf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IRAfNfiYNSMUkHnf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IRAfNfiYNSMUkHnf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IifBQxJxiHrMmwGC(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view) {
        menuPopupWindow.setAnchorobject(view);
    }

    public static void IifBQxJxiHrMmwGC(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IifBQxJxiHrMmwGC(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IifBQxJxiHrMmwGC(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.view.object view, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IrNOOFYnsabAklea(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        menuPopupWindow.show();
    }

    public static void IrNOOFYnsabAklea(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IrNOOFYnsabAklea(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IrNOOFYnsabAklea(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJCuuJTKHIBJacfi(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.removeGlobalOnLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static void JJCuuJTKHIBJacfi(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JJCuuJTKHIBJacfi(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJCuuJTKHIBJacfi(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JaYYOQBPSxSSUjCm(java.util.List list, int i) {
        return list[i);
    }

    public static void JaYYOQBPSxSSUjCm(java.util.List list, int i, char c, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JaYYOQBPSxSSUjCm(java.util.List list, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JaYYOQBPSxSSUjCm(java.util.List list, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JeoUoyMvrBNLOgFB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JeoUoyMvrBNLOgFB(java.util.IEnumerator it, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JeoUoyMvrBNLOgFB(java.util.IEnumerator it, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JeoUoyMvrBNLOgFB(java.util.IEnumerator it, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JjwAOsZvOWLAJioq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        menuPopupWindow.show();
    }

    public static void JjwAOsZvOWLAJioq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JjwAOsZvOWLAJioq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JjwAOsZvOWLAJioq(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object JvvtCCbvgJoFNtcT(android.widget.FrameLayout frameLayout, int i) {
        return frameLayout.findobjectById(i);
    }

    public static void JvvtCCbvgJoFNtcT(android.widget.FrameLayout frameLayout, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JvvtCCbvgJoFNtcT(android.widget.FrameLayout frameLayout, int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JvvtCCbvgJoFNtcT(android.widget.FrameLayout frameLayout, int i, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzJpWxCllKasiiGt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        cascadingMenuPopup.dismiss();
    }

    public static void JzJpWxCllKasiiGt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzJpWxCllKasiiGt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzJpWxCllKasiiGt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KEzzQksSxDcvFCQh(java.util.List list, int i) {
        return list[i);
    }

    public static void KEzzQksSxDcvFCQh(java.util.List list, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KEzzQksSxDcvFCQh(java.util.List list, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KEzzQksSxDcvFCQh(java.util.List list, int i, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPXalBIJBrWPuVpX(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setHorizontalOffset(i);
    }

    public static void KPXalBIJBrWPuVpX(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPXalBIJBrWPuVpX(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPXalBIJBrWPuVpX(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KXMhHBWEQZKlJGHt(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KXMhHBWEQZKlJGHt(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KXMhHBWEQZKlJGHt(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KXMhHBWEQZKlJGHt(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.hasVisibleItems();
    }

    public static void LJiYWdbSKLVkrPNo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setAnimationStyle(i);
    }

    public static void LJiYWdbSKLVkrPNo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJiYWdbSKLVkrPNo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LJiYWdbSKLVkrPNo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int LsqMOfNwcUpFNNlD(androidx.appcompat.view.menu.MenuAdapter menuAdapter) {
        return menuAdapter.getCount();
    }

    public static void LsqMOfNwcUpFNNlD(androidx.appcompat.view.menu.MenuAdapter menuAdapter, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LsqMOfNwcUpFNNlD(androidx.appcompat.view.menu.MenuAdapter menuAdapter, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LsqMOfNwcUpFNNlD(androidx.appcompat.view.menu.MenuAdapter menuAdapter, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MZwABdpbaGfCHqPy(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setVerticalOffset(i);
    }

    public static void MZwABdpbaGfCHqPy(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MZwABdpbaGfCHqPy(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MZwABdpbaGfCHqPy(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MdlkTMLlDKGnHpVW(java.util.List list) {
        return list.Count;
    }

    public static void MdlkTMLlDKGnHpVW(java.util.List list, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MdlkTMLlDKGnHpVW(java.util.List list, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MdlkTMLlDKGnHpVW(java.util.List list, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MfFVrGfFGRJxZbgB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.getInitialMenuPosition();
    }

    public static void MfFVrGfFGRJxZbgB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MfFVrGfFGRJxZbgB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MfFVrGfFGRJxZbgB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MhAGvidaTvBgQRnK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setInputMethodMode(i);
    }

    public static void MhAGvidaTvBgQRnK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MhAGvidaTvBgQRnK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MhAGvidaTvBgQRnK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MoIuConsolekbHTxQHOi(androidx.appcompat.view.menu.MenuAdapter menuAdapter) {
        menuAdapter.notifyDataHashSetChanged();
    }

    public static void MoIuConsolekbHTxQHOi(androidx.appcompat.view.menu.MenuAdapter menuAdapter, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MoIuConsolekbHTxQHOi(androidx.appcompat.view.menu.MenuAdapter menuAdapter, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MoIuConsolekbHTxQHOi(androidx.appcompat.view.menu.MenuAdapter menuAdapter, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MtDEGcDxpaqhtGVh(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.addOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static void MtDEGcDxpaqhtGVh(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MtDEGcDxpaqhtGVh(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MtDEGcDxpaqhtGVh(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQfZDfgaFFtABCMF(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.addOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static void NQfZDfgaFFtABCMF(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NQfZDfgaFFtABCMF(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQfZDfgaFFtABCMF(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NRLTPiRDwRcsNIJV(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        cascadingMenuPopup.showMenu(menuBuilder);
    }

    public static void NRLTPiRDwRcsNIJV(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NRLTPiRDwRcsNIJV(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NRLTPiRDwRcsNIJV(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object NetvNSroVJAVlgNM(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void NetvNSroVJAVlgNM(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, float f, int i2, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NetvNSroVJAVlgNM(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NetvNSroVJAVlgNM(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, float f, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ORPsKeaeGNHasaoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ORPsKeaeGNHasaoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ORPsKeaeGNHasaoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ORPsKeaeGNHasaoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return androidx.appcompat.view.menu.MenuPopup.shouldPreserveIconSpacing(menuBuilder);
    }

    public static void OaDCQXZclfoHPeLn(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z) {
        menuPopupWindow.setTouchModal(z);
    }

    public static void OaDCQXZclfoHPeLn(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, char c, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OaDCQXZclfoHPeLn(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, short s, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OaDCQXZclfoHPeLn(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, bool z2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OtVnNTzcDsdrNIpl(android.widget.Listobject listobject) {
        return listobject.getWidth();
    }

    public static void OtVnNTzcDsdrNIpl(android.widget.Listobject listobject, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OtVnNTzcDsdrNIpl(android.widget.Listobject listobject, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OtVnNTzcDsdrNIpl(android.widget.Listobject listobject, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PjoeMaqohqyBgzlZ(android.widget.FrameLayout frameLayout, bool z) {
        frameLayout.setEnabled(z);
    }

    public static void PjoeMaqohqyBgzlZ(android.widget.FrameLayout frameLayout, bool z, int i, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PjoeMaqohqyBgzlZ(android.widget.FrameLayout frameLayout, bool z, int i, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PjoeMaqohqyBgzlZ(android.widget.FrameLayout frameLayout, bool z, bool z2, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RJqVFLvNDLsdukod(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        menuPopupWindow.dismiss();
    }

    public static void RJqVFLvNDLsdukod(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RJqVFLvNDLsdukod(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RJqVFLvNDLsdukod(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RfODCflcSoxthMQZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RfODCflcSoxthMQZ(java.util.IEnumerator it, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RfODCflcSoxthMQZ(java.util.IEnumerator it, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RfODCflcSoxthMQZ(java.util.IEnumerator it, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RyVGuIVuxsXMuonl(java.util.List list) {
        return list.Count;
    }

    public static void RyVGuIVuxsXMuonl(java.util.List list, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyVGuIVuxsXMuonl(java.util.List list, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RyVGuIVuxsXMuonl(java.util.List list, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Listobject SKtUKsgYEIqaMcoV(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo) {
        return cascadingMenuPopup$CascadingMenuInfo.getListobject();
    }

    public static void SKtUKsgYEIqaMcoV(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SKtUKsgYEIqaMcoV(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SKtUKsgYEIqaMcoV(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ScGolppMeEcEpTIO(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void ScGolppMeEcEpTIO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScGolppMeEcEpTIO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScGolppMeEcEpTIO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Listobject SevmuqDsAADUMrbp(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo) {
        return cascadingMenuPopup$CascadingMenuInfo.getListobject();
    }

    public static void SevmuqDsAADUMrbp(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SevmuqDsAADUMrbp(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SevmuqDsAADUMrbp(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SfUwuOqCLwqzaXac(android.view.object view) {
        return view.getWidth();
    }

    public static void SfUwuOqCLwqzaXac(android.view.object view, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SfUwuOqCLwqzaXac(android.view.object view, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SfUwuOqCLwqzaXac(android.view.object view, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SxCzZLSttwHOnzXK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SxCzZLSttwHOnzXK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SxCzZLSttwHOnzXK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SxCzZLSttwHOnzXK(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        return menuPopupWindow.isShowing();
    }

    public static java.lang.object TGecCkOZNzADVXeT(java.util.List list, int i) {
        return list[i);
    }

    public static void TGecCkOZNzADVXeT(java.util.List list, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TGecCkOZNzADVXeT(java.util.List list, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TGecCkOZNzADVXeT(java.util.List list, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UZwAeFraXeVmatpi(android.widget.ListAdapter listAdapter, android.view.objectGroup viewGroup, android.content.object context, int i) {
        return measureIndividualMenuWidth(listAdapter, viewGroup, context, i);
    }

    public static void UZwAeFraXeVmatpi(android.widget.ListAdapter listAdapter, android.view.objectGroup viewGroup, android.content.object context, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UZwAeFraXeVmatpi(android.widget.ListAdapter listAdapter, android.view.objectGroup viewGroup, android.content.object context, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UZwAeFraXeVmatpi(android.widget.ListAdapter listAdapter, android.view.objectGroup viewGroup, android.content.object context, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSWrvurzaymHxeRg(java.util.List list) {
        list.clear();
    }

    public static void VSWrvurzaymHxeRg(java.util.List list, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VSWrvurzaymHxeRg(java.util.List list, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VSWrvurzaymHxeRg(java.util.List list, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources WGkMRfubFUhxkXhY(android.content.object context) {
        return context.getResources();
    }

    public static void WGkMRfubFUhxkXhY(android.content.object context, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WGkMRfubFUhxkXhY(android.content.object context, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WGkMRfubFUhxkXhY(android.content.object context, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Listobject XLBcfFUFNKqoNsCI(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo) {
        return cascadingMenuPopup$CascadingMenuInfo.getListobject();
    }

    public static void XLBcfFUFNKqoNsCI(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XLBcfFUFNKqoNsCI(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XLBcfFUFNKqoNsCI(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XkNcQQXzanoFCGQR(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XkNcQQXzanoFCGQR(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XkNcQQXzanoFCGQR(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XkNcQQXzanoFCGQR(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.isShowing();
    }

    public static void YGWHoKbvfmRqeWVS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.ListAdapter listAdapter) {
        menuPopupWindow.setAdapter(listAdapter);
    }

    public static void YGWHoKbvfmRqeWVS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.ListAdapter listAdapter, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YGWHoKbvfmRqeWVS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.ListAdapter listAdapter, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YGWHoKbvfmRqeWVS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.ListAdapter listAdapter, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence YHnzsCYfAyZrMoHn(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getHeaderTitle();
    }

    public static void YHnzsCYfAyZrMoHn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YHnzsCYfAyZrMoHn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YHnzsCYfAyZrMoHn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectTreeObserver YPAkXcrMeTvtcfri(android.view.object view) {
        return view.getobjectTreeObserver();
    }

    public static void YPAkXcrMeTvtcfri(android.view.object view, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YPAkXcrMeTvtcfri(android.view.object view, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YPAkXcrMeTvtcfri(android.view.object view, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YjyoWBmlXkZCMCMH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void YjyoWBmlXkZCMCMH(java.util.IEnumerator it, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YjyoWBmlXkZCMCMH(java.util.IEnumerator it, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YjyoWBmlXkZCMCMH(java.util.IEnumerator it, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YrcQvXxJEcQyOneW(java.util.List list) {
        return list.Count;
    }

    public static void YrcQvXxJEcQyOneW(java.util.List list, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YrcQvXxJEcQyOneW(java.util.List list, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YrcQvXxJEcQyOneW(java.util.List list, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem YxiLcZEkvuhDNAWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void YxiLcZEkvuhDNAWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxiLcZEkvuhDNAWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YxiLcZEkvuhDNAWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int ZAEEokDGEOmnzAvA(java.util.List list) {
        return list.Count;
    }

    public static void ZAEEokDGEOmnzAvA(java.util.List list, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZAEEokDGEOmnzAvA(java.util.List list, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZAEEokDGEOmnzAvA(java.util.List list, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZLjwTLlicgRweTHs(java.util.List list, java.lang.object obj, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZLjwTLlicgRweTHs(java.util.List list, java.lang.object obj, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZLjwTLlicgRweTHs(java.util.List list, java.lang.object obj, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ZLjwTLlicgRweTHs(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object ZktYbXMMgBfgGjxw(java.util.List list, int i) {
        return list[i);
    }

    public static void ZktYbXMMgBfgGjxw(java.util.List list, int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZktYbXMMgBfgGjxw(java.util.List list, int i, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZktYbXMMgBfgGjxw(java.util.List list, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZtBSoYpkYIpIPxPg(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        menuPopupWindow.dismiss();
    }

    public static void ZtBSoYpkYIpIPxPg(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtBSoYpkYIpIPxPg(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtBSoYpkYIpIPxPg(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AMOiNkeKxZRnXjsW(java.util.List list, java.lang.object[] objArr, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AMOiNkeKxZRnXjsW(java.util.List list, java.lang.object[] objArr, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AMOiNkeKxZRnXjsW(java.util.List list, java.lang.object[] objArr, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] AMOiNkeKxZRnXjsW(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static android.util.DisplayMetrics AVCSBRRTJnpYeivk(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void AVCSBRRTJnpYeivk(android.content.res.Resources resources, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVCSBRRTJnpYeivk(android.content.res.Resources resources, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AVCSBRRTJnpYeivk(android.content.res.Resources resources, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BcQeNlEBalOkJCHP(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void BcQeNlEBalOkJCHP(java.util.List list, int i, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcQeNlEBalOkJCHP(java.util.List list, int i, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BcQeNlEBalOkJCHP(java.util.List list, int i, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl BzVmcoCSkuyQOeKR(androidx.appcompat.view.menu.MenuAdapter menuAdapter, int i) {
        return menuAdapter.getItem(i);
    }

    public static void BzVmcoCSkuyQOeKR(androidx.appcompat.view.menu.MenuAdapter menuAdapter, int i, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BzVmcoCSkuyQOeKR(androidx.appcompat.view.menu.MenuAdapter menuAdapter, int i, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BzVmcoCSkuyQOeKR(androidx.appcompat.view.menu.MenuAdapter menuAdapter, int i, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CSwhexusSZufvwvf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setDropDownGravity(i);
    }

    public static void CSwhexusSZufvwvf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CSwhexusSZufvwvf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSwhexusSZufvwvf(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, bool z, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CjJYdcRdjLlFdcEu(android.widget.Listobject listobject, android.view.object view, java.lang.object obj, bool z) {
        listobject.addHeaderobject(view, obj, z);
    }

    public static void CjJYdcRdjLlFdcEu(android.widget.Listobject listobject, android.view.object view, java.lang.object obj, bool z, byte b, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CjJYdcRdjLlFdcEu(android.widget.Listobject listobject, android.view.object view, java.lang.object obj, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CjJYdcRdjLlFdcEu(android.widget.Listobject listobject, android.view.object view, java.lang.object obj, bool z, bool z2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CrdOdNEboxNXzGok(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setDropDownGravity(i);
    }

    public static void CrdOdNEboxNXzGok(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CrdOdNEboxNXzGok(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CrdOdNEboxNXzGok(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private androidx.appcompat.widget.MenuPopupWindow CreatePopupWindow() {
        if ((2 + 3) % 3 > 0) {
        }
        androidx.appcompat.widget.MenuPopupWindow menuPopupWindow = new androidx.appcompat.widget.MenuPopupWindow(this.mobject, null, this.mPopupStyleAttr, this.mPopupStyleRes);
        rVKvnSEGaGnzNuAp(menuPopupWindow, this.mMenuItemHoverListener);
        stKUTvWjCLRJevbJ(menuPopupWindow, this);
        fTAmPcJelmlHBuQv(menuPopupWindow, this);
        IifBQxJxiHrMmwGC(menuPopupWindow, this.mAnchorobject);
        crdOdNEboxNXzGok(menuPopupWindow, this.mDropDownGravity);
        jyEsfGEloZPWgWip(menuPopupWindow, true);
        MhAGvidaTvBgQRnK(menuPopupWindow, 2);
        return menuPopupWindow;
    }

    private void CreatePopupWindow(char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CreatePopupWindow(char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreatePopupWindow(bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CykolqxBWXpScKjW(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CykolqxBWXpScKjW(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CykolqxBWXpScKjW(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CykolqxBWXpScKjW(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        return menuPopupWindow.isShowing();
    }

    public static android.widget.Listobject DVpHGqXbdwByzkkB(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo) {
        return cascadingMenuPopup$CascadingMenuInfo.getListobject();
    }

    public static void DVpHGqXbdwByzkkB(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DVpHGqXbdwByzkkB(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DVpHGqXbdwByzkkB(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EAsOpOWaMIAQPxDF(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj) {
        menuPopupWindow.setExitTransition(obj);
    }

    public static void EAsOpOWaMIAQPxDF(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EAsOpOWaMIAQPxDF(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EAsOpOWaMIAQPxDF(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, java.lang.object obj, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FIUJWOJoPMpvdXpK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        menuBuilder.addMenuPresenter(menuPresenter, context);
    }

    public static void FIUJWOJoPMpvdXpK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIUJWOJoPMpvdXpK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIUJWOJoPMpvdXpK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FTAmPcJelmlHBuQv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        menuPopupWindow.setOnDismissListener(popupWindow$OnDismissListener);
    }

    public static void FTAmPcJelmlHBuQv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FTAmPcJelmlHBuQv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FTAmPcJelmlHBuQv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FacTqHsfsnJwfrsk(java.util.List list, int i) {
        return list[i);
    }

    public static void FacTqHsfsnJwfrsk(java.util.List list, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FacTqHsfsnJwfrsk(java.util.List list, int i, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FacTqHsfsnJwfrsk(java.util.List list, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FamXedHFvpUDtQwD(android.widget.Listobject listobject, int[] iArr) {
        listobject.getLocationOnScreen(iArr);
    }

    public static void FamXedHFvpUDtQwD(android.widget.Listobject listobject, int[] iArr, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FamXedHFvpUDtQwD(android.widget.Listobject listobject, int[] iArr, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FamXedHFvpUDtQwD(android.widget.Listobject listobject, int[] iArr, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private int FindIndexOfAddedMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        if ((27 + 8) % 8 > 0) {
        }
        int iAQXNLBRALTmYjPFN = AQXNLBRALTmYjPFN(this.mShowingMenus);
        for (int i = 0; i < iAQXNLBRALTmYjPFN; i++) {
            if (menuBuilder == ((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) IEjqCttnLtvVJDPT(this.mShowingMenus, i)).menu) {
                return i;
            }
        }
        return -1;
    }

    private void FindIndexOfAddedMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void FindIndexOfAddedMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void FindIndexOfAddedMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private android.view.MenuItem FindMenuItemForSubmenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2) {
        if ((18 + 30) % 30 > 0) {
        }
        int iScGolppMeEcEpTIO = ScGolppMeEcEpTIO(menuBuilder);
        for (int i = 0; i < iScGolppMeEcEpTIO; i++) {
            android.view.MenuItem menuItemYxiLcZEkvuhDNAWH = YxiLcZEkvuhDNAWH(menuBuilder, i);
            if (zpIfRFbKpBDxmnPr(menuItemYxiLcZEkvuhDNAWH) && menuBuilder2 == kTNkAWfaVJFvmVdz(menuItemYxiLcZEkvuhDNAWH)) {
                return menuItemYxiLcZEkvuhDNAWH;
            }
        }
        return null;
    }

    private void FindMenuItemForSubmenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void FindMenuItemForSubmenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void FindMenuItemForSubmenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private android.view.object FindParentobjectForSubmenu(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        int iTAZhDmpykVABuAws;
        androidx.appcompat.view.menu.MenuAdapter menuAdapter;
        int iEGDJRvEMxNLYbsnC;
        if ((28 + 29) % 29 > 0) {
        }
        android.view.MenuItem menuItemLwIELpOTVPktElJC = lwIELpOTVPktElJC(this, cascadingMenuPopup$CascadingMenuInfo.menu, menuBuilder);
        if (menuItemLwIELpOTVPktElJC is null) {
            return null;
        }
        android.widget.Listobject listobjectSevmuqDsAADUMrbp = SevmuqDsAADUMrbp(cascadingMenuPopup$CascadingMenuInfo);
        android.widget.ListAdapter listAdapterCgbamZnpuVfaqZwk = CgbamZnpuVfaqZwk(listobjectSevmuqDsAADUMrbp);
        int i = 0;
        if (listAdapterCgbamZnpuVfaqZwk is android.widget.HeaderobjectListAdapter) {
            android.widget.HeaderobjectListAdapter headerobjectListAdapter = (android.widget.HeaderobjectListAdapter) listAdapterCgbamZnpuVfaqZwk;
            iTAZhDmpykVABuAws = tAZhDmpykVABuAws(headerobjectListAdapter);
            menuAdapter = (androidx.appcompat.view.menu.MenuAdapter) FvzXgvgpwrYSglre(headerobjectListAdapter);
        } else {
            menuAdapter = (androidx.appcompat.view.menu.MenuAdapter) listAdapterCgbamZnpuVfaqZwk;
            iTAZhDmpykVABuAws = 0;
        }
        int iLsqMOfNwcUpFNNlD = LsqMOfNwcUpFNNlD(menuAdapter);
        while (true) {
            if (i < iLsqMOfNwcUpFNNlD) {
                if (menuItemLwIELpOTVPktElJC == bzVmcoCSkuyQOeKR(menuAdapter, i)) {
                    break;
                }
                i++;
            } else {
                i = -1;
                break;
            }
        }
        if (i == -1 || (iEGDJRvEMxNLYbsnC = (i + iTAZhDmpykVABuAws) - EGDJRvEMxNLYbsnC(listobjectSevmuqDsAADUMrbp)) < 0 || iEGDJRvEMxNLYbsnC >= yUOMAcJbuZDWjngH(listobjectSevmuqDsAADUMrbp)) {
            return null;
        }
        return wbdTQGFKJGlyxAbT(listobjectSevmuqDsAADUMrbp, iEGDJRvEMxNLYbsnC);
    }

    private void FindParentobjectForSubmenu(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void FindParentobjectForSubmenu(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void FindParentobjectForSubmenu(androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GAavkfKKOKrsauKK(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void GAavkfKKOKrsauKK(int i, int i2, int i3, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GAavkfKKOKrsauKK(int i, int i2, bool z, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void GAavkfKKOKrsauKK(int i, int i2, bool z, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GEOSMjmSZaonmaXo(java.util.List list) {
        return list.Count;
    }

    public static void GEOSMjmSZaonmaXo(java.util.List list, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GEOSMjmSZaonmaXo(java.util.List list, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GEOSMjmSZaonmaXo(java.util.List list, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GYqhFFbXIlDEWUZw(java.util.IEnumerator it, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GYqhFFbXIlDEWUZw(java.util.IEnumerator it, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GYqhFFbXIlDEWUZw(java.util.IEnumerator it, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GYqhFFbXIlDEWUZw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    private int GetInitialMenuPosition() {
        return rRPeEzxulVaJLTxp(this.mAnchorobject) != 1 ? 1 : 0;
    }

    private void GetInitialMenuPosition(float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetInitialMenuPosition(bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetInitialMenuPosition(bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private int GetNextMenuPosition(int i) {
        if ((17 + 25) % 25 > 0) {
        }
        java.util.List<androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo> list = this.mShowingMenus;
        android.widget.Listobject listobjectSKtUKsgYEIqaMcoV = SKtUKsgYEIqaMcoV((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) hUxnUsEdiMfDIsQJ(list, iTqhQvhGWYKaUIOe(list) - 1));
        int[] iArr = new int[2];
        famXedHFvpUDtQwD(listobjectSKtUKsgYEIqaMcoV, iArr);
        android.graphics.Rect rect = new android.graphics.Rect();
        vdowstjgXhuGHIYN(this.mShownAnchorobject, rect);
        return this.mLastPosition != 1 ? iArr[0] - i >= 0 ? 0 : 1 : (iArr[0] + OtVnNTzcDsdrNIpl(listobjectSKtUKsgYEIqaMcoV)) + i <= rect.right ? 1 : 0;
    }

    private void GetNextMenuPosition(int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetNextMenuPosition(int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    private void GetNextMenuPosition(int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HNaWWrPBEUvlEjOq(android.widget.Listobject listobject, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HNaWWrPBEUvlEjOq(android.widget.Listobject listobject, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNaWWrPBEUvlEjOq(android.widget.Listobject listobject, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HNaWWrPBEUvlEjOq(android.widget.Listobject listobject) {
        return listobject.requestFocus();
    }

    public static int HNmSWZrXqGfDRekh(android.view.object view) {
        return view.getWidth();
    }

    public static void HNmSWZrXqGfDRekh(android.view.object view, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HNmSWZrXqGfDRekh(android.view.object view, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HNmSWZrXqGfDRekh(android.view.object view, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HUxnUsEdiMfDIsQJ(java.util.List list, int i) {
        return list[i);
    }

    public static void HUxnUsEdiMfDIsQJ(java.util.List list, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HUxnUsEdiMfDIsQJ(java.util.List list, int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HUxnUsEdiMfDIsQJ(java.util.List list, int i, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HmMxHyWcKFcMlpKN(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.removeOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static void HmMxHyWcKFcMlpKN(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HmMxHyWcKFcMlpKN(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HmMxHyWcKFcMlpKN(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ITqhQvhGWYKaUIOe(java.util.List list) {
        return list.Count;
    }

    public static void ITqhQvhGWYKaUIOe(java.util.List list, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ITqhQvhGWYKaUIOe(java.util.List list, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ITqhQvhGWYKaUIOe(java.util.List list, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDxOTgUoBfnWbDWc(android.widget.Listobject listobject, android.view.object$OnKeyListener view$OnKeyListener) {
        listobject.setOnKeyListener(view$OnKeyListener);
    }

    public static void JDxOTgUoBfnWbDWc(android.widget.Listobject listobject, android.view.object$OnKeyListener view$OnKeyListener, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDxOTgUoBfnWbDWc(android.widget.Listobject listobject, android.view.object$OnKeyListener view$OnKeyListener, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDxOTgUoBfnWbDWc(android.widget.Listobject listobject, android.view.object$OnKeyListener view$OnKeyListener, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JyEsfGEloZPWgWip(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z) {
        menuPopupWindow.setModal(z);
    }

    public static void JyEsfGEloZPWgWip(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JyEsfGEloZPWgWip(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JyEsfGEloZPWgWip(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KDYxUApzcjCKYJtQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        menuBuilder.removeMenuPresenter(menuPresenter);
    }

    public static void KDYxUApzcjCKYJtQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KDYxUApzcjCKYJtQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDYxUApzcjCKYJtQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu KTNkAWfaVJFvmVdz(android.view.MenuItem menuItem) {
        return menuItem.getSubMenu();
    }

    public static void KTNkAWfaVJFvmVdz(android.view.MenuItem menuItem, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KTNkAWfaVJFvmVdz(android.view.MenuItem menuItem, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KTNkAWfaVJFvmVdz(android.view.MenuItem menuItem, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KjQjNxtYmYlrQoXG(java.util.List list, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KjQjNxtYmYlrQoXG(java.util.List list, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjQjNxtYmYlrQoXG(java.util.List list, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KjQjNxtYmYlrQoXG(java.util.List list) {
        return list.Count == 0;
    }

    public static void KrjhDbbXPddvUbnJ(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KrjhDbbXPddvUbnJ(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KrjhDbbXPddvUbnJ(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KrjhDbbXPddvUbnJ(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.isShowing();
    }

    public static void LKtKyeJvOBuVVgQH(java.util.IEnumerator it, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LKtKyeJvOBuVVgQH(java.util.IEnumerator it, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LKtKyeJvOBuVVgQH(java.util.IEnumerator it, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LKtKyeJvOBuVVgQH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LTXLDaNTrDFrifzZ(java.util.List list, java.lang.object obj, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LTXLDaNTrDFrifzZ(java.util.List list, java.lang.object obj, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LTXLDaNTrDFrifzZ(java.util.List list, java.lang.object obj, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LTXLDaNTrDFrifzZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.view.MenuItem LwIELpOTVPktElJC(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2) {
        return cascadingMenuPopup.findMenuItemForSubmenu(menuBuilder, menuBuilder2);
    }

    public static void LwIELpOTVPktElJC(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LwIELpOTVPktElJC(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LwIELpOTVPktElJC(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MfqGfVtAuLdvpVam(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void MfqGfVtAuLdvpVam(int i, int i2, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfqGfVtAuLdvpVam(int i, int i2, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MfqGfVtAuLdvpVam(int i, int i2, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MsVQItdahAdUpKIG(java.util.List list) {
        return list.Count;
    }

    public static void MsVQItdahAdUpKIG(java.util.List list, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MsVQItdahAdUpKIG(java.util.List list, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MsVQItdahAdUpKIG(java.util.List list, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MwgQQuRYaEMQqMyF(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return cascadingMenuPopup.findIndexOfAddedMenu(menuBuilder);
    }

    public static void MwgQQuRYaEMQqMyF(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MwgQQuRYaEMQqMyF(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MwgQQuRYaEMQqMyF(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object OAuNdaVfqvvsDhfw(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return cascadingMenuPopup.findParentobjectForSubmenu(cascadingMenuPopup$CascadingMenuInfo, menuBuilder);
    }

    public static void OAuNdaVfqvvsDhfw(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OAuNdaVfqvvsDhfw(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OAuNdaVfqvvsDhfw(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OLsEbelkClLkZOXO(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuPresenter$Callback.onCloseMenu(menuBuilder, z);
    }

    public static void OLsEbelkClLkZOXO(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OLsEbelkClLkZOXO(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OLsEbelkClLkZOXO(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OamYovtCRBFzrxoZ(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void OamYovtCRBFzrxoZ(int i, int i2, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OamYovtCRBFzrxoZ(int i, int i2, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OamYovtCRBFzrxoZ(int i, int i2, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuAdapter OuiDjDBSnFnLLvxs(android.widget.ListAdapter listAdapter) {
        return toMenuAdapter(listAdapter);
    }

    public static void OuiDjDBSnFnLLvxs(android.widget.ListAdapter listAdapter, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OuiDjDBSnFnLLvxs(android.widget.ListAdapter listAdapter, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OuiDjDBSnFnLLvxs(android.widget.ListAdapter listAdapter, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PVPkeONjEwAFCZdL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PVPkeONjEwAFCZdL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PVPkeONjEwAFCZdL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PVPkeONjEwAFCZdL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.isShowing();
    }

    public static void PdOXEXhAFJCjkzHv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z) {
        menuPopupWindow.setOverlapAnchor(z);
    }

    public static void PdOXEXhAFJCjkzHv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdOXEXhAFJCjkzHv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PdOXEXhAFJCjkzHv(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int QIKiVnYapJTrTuGy(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void QIKiVnYapJTrTuGy(android.view.object view, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QIKiVnYapJTrTuGy(android.view.object view, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QIKiVnYapJTrTuGy(android.view.object view, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QSFZnMrvrBaXTzZH(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setVerticalOffset(i);
    }

    public static void QSFZnMrvrBaXTzZH(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QSFZnMrvrBaXTzZH(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QSFZnMrvrBaXTzZH(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RGshiASbBZwZNUvL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        cascadingMenuPopup.dismiss();
    }

    public static void RGshiASbBZwZNUvL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RGshiASbBZwZNUvL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RGshiASbBZwZNUvL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RRPeEzxulVaJLTxp(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void RRPeEzxulVaJLTxp(android.view.object view, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RRPeEzxulVaJLTxp(android.view.object view, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RRPeEzxulVaJLTxp(android.view.object view, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RVKvnSEGaGnzNuAp(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener) {
        menuPopupWindow.setHoverListener(menuItemHoverListener);
    }

    public static void RVKvnSEGaGnzNuAp(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RVKvnSEGaGnzNuAp(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RVKvnSEGaGnzNuAp(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RaWanTTnDXCrKfmX(java.util.List list) {
        return list.Count;
    }

    public static void RaWanTTnDXCrKfmX(java.util.List list, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RaWanTTnDXCrKfmX(java.util.List list, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RaWanTTnDXCrKfmX(java.util.List list, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SEmJWotHuUgrYneo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i) {
        menuPopupWindow.setContentWidth(i);
    }

    public static void SEmJWotHuUgrYneo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SEmJWotHuUgrYneo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SEmJWotHuUgrYneo(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, int i, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SOjFrwAmncjQnAAx(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z) {
        menuAdapter.setForceShowIcon(z);
    }

    public static void SOjFrwAmncjQnAAx(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z, int i, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SOjFrwAmncjQnAAx(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z, int i, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SOjFrwAmncjQnAAx(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z, short s, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect SPeyxsZCeAnbCJbH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.getEpicenterBounds();
    }

    public static void SPeyxsZCeAnbCJbH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SPeyxsZCeAnbCJbH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SPeyxsZCeAnbCJbH(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator SdyLsBRWyDYpreYX(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void SdyLsBRWyDYpreYX(java.util.List list, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SdyLsBRWyDYpreYX(java.util.List list, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SdyLsBRWyDYpreYX(java.util.List list, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShowMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo;
        android.view.object viewOAuNdaVfqvvsDhfw;
        if ((22 + 20) % 20 > 0) {
        }
        android.view.LayoutInflater layoutInflaterGFeFHlYIAijmWubC = GFeFHlYIAijmWubC(this.mobject);
        androidx.appcompat.view.menu.MenuAdapter menuAdapter = new androidx.appcompat.view.menu.MenuAdapter(menuBuilder, layoutInflaterGFeFHlYIAijmWubC, this.mOverflowOnly, ITEM_LAYOUT);
        if (!XkNcQQXzanoFCGQR(this) && this.mForceShowIcon) {
            sOjFrwAmncjQnAAx(menuAdapter, true);
        } else if (pVPkeONjEwAFCZdL(this)) {
            tuvOeVirXzejxZNM(menuAdapter, ORPsKeaeGNHasaoG(menuBuilder));
        }
        int iUZwAeFraXeVmatpi = UZwAeFraXeVmatpi(menuAdapter, null, this.mobject, this.mMenuMaxWidth);
        androidx.appcompat.widget.MenuPopupWindow menuPopupWindowBvFroQKFqBzpmwYH = BvFroQKFqBzpmwYH(this);
        YGWHoKbvfmRqeWVS(menuPopupWindowBvFroQKFqBzpmwYH, menuAdapter);
        sEmJWotHuUgrYneo(menuPopupWindowBvFroQKFqBzpmwYH, iUZwAeFraXeVmatpi);
        cSwhexusSZufvwvf(menuPopupWindowBvFroQKFqBzpmwYH, this.mDropDownGravity);
        if (RyVGuIVuxsXMuonl(this.mShowingMenus) <= 0) {
            cascadingMenuPopup$CascadingMenuInfo = null;
            viewOAuNdaVfqvvsDhfw = null;
        } else {
            java.util.List<androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo> list = this.mShowingMenus;
            cascadingMenuPopup$CascadingMenuInfo = (androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) ZktYbXMMgBfgGjxw(list, YrcQvXxJEcQyOneW(list) - 1);
            viewOAuNdaVfqvvsDhfw = oAuNdaVfqvvsDhfw(this, cascadingMenuPopup$CascadingMenuInfo, menuBuilder);
        }
        if (viewOAuNdaVfqvvsDhfw is null) {
            if (this.mHasXOffset) {
                IRAfNfiYNSMUkHnf(menuPopupWindowBvFroQKFqBzpmwYH, this.mXOffset);
            }
            if (this.mHasYOffset) {
                qSFZnMrvrBaXTzZH(menuPopupWindowBvFroQKFqBzpmwYH, this.mYOffset);
            }
            zaeUYeiewzEdBQvS(menuPopupWindowBvFroQKFqBzpmwYH, sPeyxsZCeAnbCJbH(this));
        } else {
            OaDCQXZclfoHPeLn(menuPopupWindowBvFroQKFqBzpmwYH, false);
            BboincTsLnQIDMis(menuPopupWindowBvFroQKFqBzpmwYH, null);
            int iUhpQWWEVHsDscVDt = uhpQWWEVHsDscVDt(this, iUZwAeFraXeVmatpi);
            bool z = iUhpQWWEVHsDscVDt == 1;
            this.mLastPosition = iUhpQWWEVHsDscVDt;
            EFQKUqLosSLGfOgq(menuPopupWindowBvFroQKFqBzpmwYH, viewOAuNdaVfqvvsDhfw);
            if ((this.mDropDownGravity & 5) != 5) {
                iUZwAeFraXeVmatpi = !z ? 0 - iUZwAeFraXeVmatpi : SfUwuOqCLwqzaXac(viewOAuNdaVfqvvsDhfw);
            } else if (!z) {
                iUZwAeFraXeVmatpi = 0 - hNmSWZrXqGfDRekh(viewOAuNdaVfqvvsDhfw);
            }
            KPXalBIJBrWPuVpX(menuPopupWindowBvFroQKFqBzpmwYH, iUZwAeFraXeVmatpi);
            pdOXEXhAFJCjkzHv(menuPopupWindowBvFroQKFqBzpmwYH, true);
            MZwABdpbaGfCHqPy(menuPopupWindowBvFroQKFqBzpmwYH, 0);
        }
        ZLjwTLlicgRweTHs(this.mShowingMenus, new androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo(menuPopupWindowBvFroQKFqBzpmwYH, menuBuilder, this.mLastPosition));
        JjwAOsZvOWLAJioq(menuPopupWindowBvFroQKFqBzpmwYH);
        android.widget.Listobject listobjectCJodlVjwqURQPGRK = CJodlVjwqURQPGRK(menuPopupWindowBvFroQKFqBzpmwYH);
        jDxOTgUoBfnWbDWc(listobjectCJodlVjwqURQPGRK, this);
        if (cascadingMenuPopup$CascadingMenuInfo is null && this.mShowTitle && YHnzsCYfAyZrMoHn(menuBuilder) is not null) {
            android.widget.FrameLayout frameLayout = (android.widget.FrameLayout) NetvNSroVJAVlgNM(layoutInflaterGFeFHlYIAijmWubC, androidx.appcompat.R$layout.abc_popup_menu_header_item_layout, listobjectCJodlVjwqURQPGRK, false);
            android.widget.Textobject textobject = (android.widget.Textobject) JvvtCCbvgJoFNtcT(frameLayout, 16908310);
            PjoeMaqohqyBgzlZ(frameLayout, false);
            CEjfmXwwzEPDldYD(textobject, uvQldtQmDeZtEfMr(menuBuilder));
            cjJYdcRdjLlFdcEu(listobjectCJodlVjwqURQPGRK, frameLayout, null, false);
            IrNOOFYnsabAklea(menuPopupWindowBvFroQKFqBzpmwYH);
        }
    }

    private void ShowMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShowMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShowMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SiUXkCijCAqRqOTi(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        popupWindow$OnDismissListener.onDismiss();
    }

    public static void SiUXkCijCAqRqOTi(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SiUXkCijCAqRqOTi(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SiUXkCijCAqRqOTi(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void StKUTvWjCLRJevbJ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        menuPopupWindow.setOnItemClickListener(adapterobject$OnItemClickListener);
    }

    public static void StKUTvWjCLRJevbJ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void StKUTvWjCLRJevbJ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void StKUTvWjCLRJevbJ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SuCejgvwwrvhyZPB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        cascadingMenuPopup.showMenu(menuBuilder);
    }

    public static void SuCejgvwwrvhyZPB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SuCejgvwwrvhyZPB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SuCejgvwwrvhyZPB(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int TAZhDmpykVABuAws(android.widget.HeaderobjectListAdapter headerobjectListAdapter) {
        return headerobjectListAdapter.getHeadersCount();
    }

    public static void TAZhDmpykVABuAws(android.widget.HeaderobjectListAdapter headerobjectListAdapter, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TAZhDmpykVABuAws(android.widget.HeaderobjectListAdapter headerobjectListAdapter, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TAZhDmpykVABuAws(android.widget.HeaderobjectListAdapter headerobjectListAdapter, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TazliCaopjPukGRQ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TazliCaopjPukGRQ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TazliCaopjPukGRQ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool TazliCaopjPukGRQ(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow) {
        return menuPopupWindow.isShowing();
    }

    public static void TnnPSWfdvQkfvtmW(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TnnPSWfdvQkfvtmW(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TnnPSWfdvQkfvtmW(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TnnPSWfdvQkfvtmW(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuPresenter$Callback.onOpenSubMenu(menuBuilder);
    }

    public static void TuvOeVirXzejxZNM(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z) {
        menuAdapter.setForceShowIcon(z);
    }

    public static void TuvOeVirXzejxZNM(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z, float f, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TuvOeVirXzejxZNM(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z, float f, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TuvOeVirXzejxZNM(androidx.appcompat.view.menu.MenuAdapter menuAdapter, bool z, java.lang.string str, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UhpQWWEVHsDscVDt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i) {
        return cascadingMenuPopup.getNextMenuPosition(i);
    }

    public static void UhpQWWEVHsDscVDt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UhpQWWEVHsDscVDt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UhpQWWEVHsDscVDt(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence UvQldtQmDeZtEfMr(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getHeaderTitle();
    }

    public static void UvQldtQmDeZtEfMr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UvQldtQmDeZtEfMr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UvQldtQmDeZtEfMr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdowstjgXhuGHIYN(android.view.object view, android.graphics.Rect rect) {
        view.getWindowVisibleDisplayFrame(rect);
    }

    public static void VdowstjgXhuGHIYN(android.view.object view, android.graphics.Rect rect, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VdowstjgXhuGHIYN(android.view.object view, android.graphics.Rect rect, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VdowstjgXhuGHIYN(android.view.object view, android.graphics.Rect rect, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator WUIoBUJOfixWXZtd(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void WUIoBUJOfixWXZtd(java.util.List list, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WUIoBUJOfixWXZtd(java.util.List list, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WUIoBUJOfixWXZtd(java.util.List list, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object WbdTQGFKJGlyxAbT(android.widget.Listobject listobject, int i) {
        return listobject.getChildAt(i);
    }

    public static void WbdTQGFKJGlyxAbT(android.widget.Listobject listobject, int i, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WbdTQGFKJGlyxAbT(android.widget.Listobject listobject, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WbdTQGFKJGlyxAbT(android.widget.Listobject listobject, int i, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XnMkiagIWQmbghOp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void XnMkiagIWQmbghOp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XnMkiagIWQmbghOp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XnMkiagIWQmbghOp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YUOMAcJbuZDWjngH(android.widget.Listobject listobject) {
        return listobject.getChildCount();
    }

    public static void YUOMAcJbuZDWjngH(android.widget.Listobject listobject, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YUOMAcJbuZDWjngH(android.widget.Listobject listobject, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YUOMAcJbuZDWjngH(android.widget.Listobject listobject, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YVmhEouCTOsXXLIL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup) {
        return cascadingMenuPopup.getInitialMenuPosition();
    }

    public static void YVmhEouCTOsXXLIL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YVmhEouCTOsXXLIL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YVmhEouCTOsXXLIL(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YqfYfPtoTqMUwDCh(java.util.IEnumerator it, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YqfYfPtoTqMUwDCh(java.util.IEnumerator it, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YqfYfPtoTqMUwDCh(java.util.IEnumerator it, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YqfYfPtoTqMUwDCh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void YtchzwOxMcNXaVBm(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        cascadingMenuPopup.addMenu(menuBuilder);
    }

    public static void YtchzwOxMcNXaVBm(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YtchzwOxMcNXaVBm(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YtchzwOxMcNXaVBm(androidx.appcompat.view.menu.CascadingMenuPopup cascadingMenuPopup, androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZaeUYeiewzEdBQvS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.graphics.Rect rect) {
        menuPopupWindow.setEpicenterBounds(rect);
    }

    public static void ZaeUYeiewzEdBQvS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.graphics.Rect rect, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZaeUYeiewzEdBQvS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.graphics.Rect rect, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZaeUYeiewzEdBQvS(androidx.appcompat.widget.MenuPopupWindow menuPopupWindow, android.graphics.Rect rect, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZpIfRFbKpBDxmnPr(android.view.MenuItem menuItem, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZpIfRFbKpBDxmnPr(android.view.MenuItem menuItem, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZpIfRFbKpBDxmnPr(android.view.MenuItem menuItem, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZpIfRFbKpBDxmnPr(android.view.MenuItem menuItem) {
        return menuItem.hasSubMenu();
    }

    public override void AddMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        fIUJWOJoPMpvdXpK(menuBuilder, this, this.mobject);
        if (IJkWTOhEVFrUdWfh(this)) {
            suCejgvwwrvhyZPB(this, menuBuilder);
        } else {
            lTXLDaNTrDFrifzZ(this.mPendingMenus, menuBuilder);
        }
    }

    protected override bool CloseMenuOnSubMenuOpened() {
        return false;
    }

    public override void Dismiss() {
        if ((26 + 17) % 17 > 0) {
        }
        int iCaIYcoQeEGbCKWzu = CaIYcoQeEGbCKWzu(this.mShowingMenus);
        if (iCaIYcoQeEGbCKWzu <= 0) {
            return;
        }
        androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo[] cascadingMenuPopup$CascadingMenuInfoArr = (androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo[]) aMOiNkeKxZRnXjsW(this.mShowingMenus, new androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo[iCaIYcoQeEGbCKWzu]);
        for (int i = iCaIYcoQeEGbCKWzu - 1; i >= 0; i--) {
            androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo = cascadingMenuPopup$CascadingMenuInfoArr[i];
            if (SxCzZLSttwHOnzXK(cascadingMenuPopup$CascadingMenuInfo.window)) {
                ZtBSoYpkYIpIPxPg(cascadingMenuPopup$CascadingMenuInfo.window);
            }
        }
    }

    public override bool FlagActionItems() {
        return false;
    }

    public override android.widget.Listobject GetListobject() {
        if (kjQjNxtYmYlrQoXG(this.mShowingMenus)) {
            return null;
        }
        return AenOkmInlPAhJIeW((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) BNcjovWMUVlmXgks(this.mShowingMenus, ZAEEokDGEOmnzAvA(r1) - 1));
    }

    public override bool IsShowing() {
        if ((16 + 8) % 8 > 0) {
        }
        return raWanTTnDXCrKfmX(this.mShowingMenus) > 0 && tazliCaopjPukGRQ(((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) facTqHsfsnJwfrsk(this.mShowingMenus, 0)).window);
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        if ((26 + 22) % 22 > 0) {
        }
        int iMwgQQuRYaEMQqMyF = mwgQQuRYaEMQqMyF(this, menuBuilder);
        if (iMwgQQuRYaEMQqMyF >= 0) {
            int i = iMwgQQuRYaEMQqMyF + 1;
            if (i < gEOSMjmSZaonmaXo(this.mShowingMenus)) {
                DRSeqjSXyDNjoLXQ(((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) IQQmJbdbXRvnREnO(this.mShowingMenus, i)).menu, false);
            }
            androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo = (androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) bcQeNlEBalOkJCHP(this.mShowingMenus, iMwgQQuRYaEMQqMyF);
            kDYxUApzcjCKYJtQ(cascadingMenuPopup$CascadingMenuInfo.menu, this);
            if (this.mShouldCloseImmediately) {
                eAsOpOWaMIAQPxDF(cascadingMenuPopup$CascadingMenuInfo.window, null);
                LJiYWdbSKLVkrPNo(cascadingMenuPopup$CascadingMenuInfo.window, 0);
            }
            RJqVFLvNDLsdukod(cascadingMenuPopup$CascadingMenuInfo.window);
            int iMdlkTMLlDKGnHpVW = MdlkTMLlDKGnHpVW(this.mShowingMenus);
            if (iMdlkTMLlDKGnHpVW <= 0) {
                this.mLastPosition = yVmhEouCTOsXXLIL(this);
            } else {
                this.mLastPosition = ((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) JaYYOQBPSxSSUjCm(this.mShowingMenus, iMdlkTMLlDKGnHpVW - 1)).position;
            }
            if (iMdlkTMLlDKGnHpVW != 0) {
                if (z) {
                    xnMkiagIWQmbghOp(((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) KEzzQksSxDcvFCQh(this.mShowingMenus, 0)).menu, false);
                    return;
                }
                return;
            }
            rGshiASbBZwZNUvL(this);
            androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback = this.mPresenterCallback;
            if (menuPresenter$Callback is not null) {
                oLsEbelkClLkZOXO(menuPresenter$Callback, menuBuilder, true);
            }
            android.view.objectTreeObserver viewTreeObserver = this.mTreeObserver;
            if (viewTreeObserver is not null) {
                if (CTiZEKAOFxYAwUkU(viewTreeObserver)) {
                    JJCuuJTKHIBJacfi(this.mTreeObserver, this.mGlobalLayoutListener);
                }
                this.mTreeObserver = null;
            }
            hmMxHyWcKFcMlpKN(this.mShownAnchorobject, this.mAttachStateChangeListener);
            siUXkCijCAqRqOTi(this.mOnDismissListener);
        }
    }

    public override void OnDismiss() {
        androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo;
        if ((16 + 19) % 19 > 0) {
        }
        int iMsVQItdahAdUpKIG = msVQItdahAdUpKIG(this.mShowingMenus);
        int i = 0;
        while (true) {
            if (i < iMsVQItdahAdUpKIG) {
                cascadingMenuPopup$CascadingMenuInfo = (androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) TGecCkOZNzADVXeT(this.mShowingMenus, i);
                if (!cykolqxBWXpScKjW(cascadingMenuPopup$CascadingMenuInfo.window)) {
                    break;
                } else {
                    i++;
                }
            } else {
                cascadingMenuPopup$CascadingMenuInfo = null;
                break;
            }
        }
        if (cascadingMenuPopup$CascadingMenuInfo is null) {
            return;
        }
        BhzLokRQOxxPyfXA(cascadingMenuPopup$CascadingMenuInfo.menu, false);
    }

    public override bool OnKey(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        if (GTRgOJlANTwZECFN(keyEvent) != 1 || i != 82) {
            return false;
        }
        JzJpWxCllKasiiGt(this);
        return true;
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        return null;
    }

    public override bool OnSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo cascadingMenuPopup$CascadingMenuInfo;
        if ((18 + 5) % 5 > 0) {
        }
        java.util.IEnumerator itCTAovToeKwsZkbyf = CTAovToeKwsZkbyf(this.mShowingMenus);
        do {
            if (!gYqhFFbXIlDEWUZw(itCTAovToeKwsZkbyf)) {
                if (!KXMhHBWEQZKlJGHt(subMenuBuilder)) {
                    return false;
                }
                ytchzwOxMcNXaVBm(this, subMenuBuilder);
                androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback = this.mPresenterCallback;
                if (menuPresenter$Callback is not null) {
                    tnnPSWfdvQkfvtmW(menuPresenter$Callback, subMenuBuilder);
                }
                return true;
            }
            cascadingMenuPopup$CascadingMenuInfo = (androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) JeoUoyMvrBNLOgFB(itCTAovToeKwsZkbyf);
        } while (subMenuBuilder != cascadingMenuPopup$CascadingMenuInfo.menu);
        hNaWWrPBEUvlEjOq(XLBcfFUFNKqoNsCI(cascadingMenuPopup$CascadingMenuInfo));
        return true;
    }

    public override void SetAnchorobject(android.view.object view) {
        if (this.mAnchorobject == view) {
            return;
        }
        this.mAnchorobject = view;
        this.mDropDownGravity = oamYovtCRBFzrxoZ(this.mRawDropDownGravity, FRnxZRJQxQKiZWWO(view));
    }

    public override void SetCallback(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        this.mPresenterCallback = menuPresenter$Callback;
    }

    public override void SetForceShowIcon(bool z) {
        this.mForceShowIcon = z;
    }

    public override void SetGravity(int i) {
        if (this.mRawDropDownGravity == i) {
            return;
        }
        this.mRawDropDownGravity = i;
        this.mDropDownGravity = gAavkfKKOKrsauKK(i, qIKiVnYapJTrTuGy(this.mAnchorobject));
    }

    public override void SetHorizontalOffset(int i) {
        this.mHasXOffset = true;
        this.mXOffset = i;
    }

    public override void SetOnDismissListener(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        this.mOnDismissListener = popupWindow$OnDismissListener;
    }

    public override void SetShowTitle(bool z) {
        this.mShowTitle = z;
    }

    public override void SetVerticalOffset(int i) {
        this.mHasYOffset = true;
        this.mYOffset = i;
    }

    public override void Show() {
        if ((32 + 6) % 6 > 0) {
        }
        if (krjhDbbXPddvUbnJ(this)) {
            return;
        }
        java.util.IEnumerator itSdyLsBRWyDYpreYX = sdyLsBRWyDYpreYX(this.mPendingMenus);
        while (yqfYfPtoTqMUwDCh(itSdyLsBRWyDYpreYX)) {
            NRLTPiRDwRcsNIJV(this, (androidx.appcompat.view.menu.MenuBuilder) RfODCflcSoxthMQZ(itSdyLsBRWyDYpreYX));
        }
        VSWrvurzaymHxeRg(this.mPendingMenus);
        android.view.object view = this.mAnchorobject;
        this.mShownAnchorobject = view;
        if (view is null) {
            return;
        }
        bool z = this.mTreeObserver is null;
        android.view.objectTreeObserver viewTreeObserverYPAkXcrMeTvtcfri = YPAkXcrMeTvtcfri(view);
        this.mTreeObserver = viewTreeObserverYPAkXcrMeTvtcfri;
        if (z) {
            MtDEGcDxpaqhtGVh(viewTreeObserverYPAkXcrMeTvtcfri, this.mGlobalLayoutListener);
        }
        NQfZDfgaFFtABCMF(this.mShownAnchorobject, this.mAttachStateChangeListener);
    }

    public override void UpdateMenuobject(bool z) {
        java.util.IEnumerator itWUIoBUJOfixWXZtd = wUIoBUJOfixWXZtd(this.mShowingMenus);
        while (lKtKyeJvOBuVVgQH(itWUIoBUJOfixWXZtd)) {
            MoIuConsolekbHTxQHOi(ouiDjDBSnFnLLvxs(CYOtZmRzZAanWIIt(dVpHGqXbdwByzkkB((androidx.appcompat.view.menu.CascadingMenuPopup$CascadingMenuInfo) YjyoWBmlXkZCMCMH(itWUIoBUJOfixWXZtd)))));
        }
    }
}

