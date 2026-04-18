namespace WillowMaze.Wasm.Decompiled;


public class MenuBuilder : androidx.core.internal.view.SupportMenu {
    private static readonly java.lang.string ACTION_VIEW_STATES_KEY = "android:menu:actionviewstates";
    private static readonly java.lang.string EXPANDED_ACTION_VIEW_ID = "android:menu:expandedactionview";
    private static readonly java.lang.string PRESENTER_KEY = "android:menu:presenters";
    private static readonly java.lang.string TAG = "MenuBuilder";
    private static readonly int[] sCategoryToOrder = {1, 4, 5, 3, 2, 0};
    private java.util.List<androidx.appcompat.view.menu.MenuItemImpl> mActionItems;
    private androidx.appcompat.view.menu.MenuBuilder$Callback mCallback;
    private readonly android.content.object mobject;
    private android.view.objectMenu$objectMenuInfo mCurrentMenuInfo;
    private int mDefaultShowAsAction;
    private androidx.appcompat.view.menu.MenuItemImpl mExpandedItem;
    private bool mGroupDividerEnabled;
    android.graphics.drawable.Drawable mHeaderIcon;
    java.lang.CharSequence mHeaderTitle;
    android.view.object mHeaderobject;
    private bool mIsActionItemsStale;
    private bool mIsClosing;
    private bool mIsVisibleItemsStale;
    private java.util.List<androidx.appcompat.view.menu.MenuItemImpl> mItems;
    private bool mItemsChangedWhileDispatchPrevented;
    private java.util.List<androidx.appcompat.view.menu.MenuItemImpl> mNonActionItems;
    private bool mobject?IconsVisible;
    private bool mOverrideVisibleItems;
    private java.util.concurrent.CopyOnWriteList<java.lang.ref.WeakReference<androidx.appcompat.view.menu.MenuPresenter>> mPresenters;
    private bool mPreventDispatchingItemsChanged;
    private bool mQwertyMode;
    private readonly android.content.res.Resources mResources;
    private bool mshortcutsVisible;
    private bool mStructureChangedWhileDispatchPrevented;
    private java.util.List<androidx.appcompat.view.menu.MenuItemImpl> mTempshortcutItemList;
    private java.util.List<androidx.appcompat.view.menu.MenuItemImpl> mVisibleItems;

    public MenuBuilder(android.content.object context) {
        if ((13 + 30) % 30 > 0) {
        }
        this.mDefaultShowAsAction = 0;
        this.mPreventDispatchingItemsChanged = false;
        this.mItemsChangedWhileDispatchPrevented = false;
        this.mStructureChangedWhileDispatchPrevented = false;
        this.mobject?IconsVisible = false;
        this.mIsClosing = false;
        this.mTempshortcutItemList = new java.util.List<>();
        this.mPresenters = new java.util.concurrent.CopyOnWriteList<>();
        this.mGroupDividerEnabled = false;
        this.mobject = context;
        this.mResources = XclvcbSjOTfbFqIJ(context);
        this.mItems = new java.util.List<>();
        this.mVisibleItems = new java.util.List<>();
        this.mIsVisibleItemsStale = true;
        this.mActionItems = new java.util.List<>();
        this.mNonActionItems = new java.util.List<>();
        this.mIsActionItemsStale = true;
        kGnEZCwEeCcDhiNS(this, true);
    }

    public static void AAjmuorIotHRqwUL(java.util.List arrayList, java.lang.object obj, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AAjmuorIotHRqwUL(java.util.List arrayList, java.lang.object obj, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AAjmuorIotHRqwUL(java.util.List arrayList, java.lang.object obj, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AAjmuorIotHRqwUL(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.util.IEnumerator ACQMexLNNtheKJhs(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void ACQMexLNNtheKJhs(java.util.concurrent.CopyOnWriteList copyOnWriteList, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACQMexLNNtheKJhs(java.util.concurrent.CopyOnWriteList copyOnWriteList, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACQMexLNNtheKJhs(java.util.concurrent.CopyOnWriteList copyOnWriteList, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AGsXuZfAjaZiDtuA(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void AGsXuZfAjaZiDtuA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AGsXuZfAjaZiDtuA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AGsXuZfAjaZiDtuA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AHpxsHDVWepCvSny(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void AHpxsHDVWepCvSny(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AHpxsHDVWepCvSny(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AHpxsHDVWepCvSny(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int APqUYrrluRpHvPFT(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void APqUYrrluRpHvPFT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void APqUYrrluRpHvPFT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void APqUYrrluRpHvPFT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AkCJBqjzuPeeQZYx(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void AkCJBqjzuPeeQZYx(java.util.List arrayList, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AkCJBqjzuPeeQZYx(java.util.List arrayList, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkCJBqjzuPeeQZYx(java.util.List arrayList, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu AqcmPidEqYRYdyik(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getSubMenu();
    }

    public static void AqcmPidEqYRYdyik(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AqcmPidEqYRYdyik(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AqcmPidEqYRYdyik(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AxdCGCsQzfQHclru(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxdCGCsQzfQHclru(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxdCGCsQzfQHclru(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AxdCGCsQzfQHclru(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return menuPresenter.onSubMenuSelected(subMenuBuilder);
    }

    public static void BFDnQKuhUSyxkygg(java.util.IEnumerator it, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BFDnQKuhUSyxkygg(java.util.IEnumerator it, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BFDnQKuhUSyxkygg(java.util.IEnumerator it, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BFDnQKuhUSyxkygg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void BFJxLxorCcuiVyUD(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void BFJxLxorCcuiVyUD(java.util.List arrayList, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BFJxLxorCcuiVyUD(java.util.List arrayList, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BFJxLxorCcuiVyUD(java.util.List arrayList, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BKaUDwtMVGDsFTUW(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        copyOnWriteList.clear();
    }

    public static void BKaUDwtMVGDsFTUW(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKaUDwtMVGDsFTUW(java.util.concurrent.CopyOnWriteList copyOnWriteList, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BKaUDwtMVGDsFTUW(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BalFEtsfLyYINwWX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BalFEtsfLyYINwWX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BalFEtsfLyYINwWX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BalFEtsfLyYINwWX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static int BfGtCDyTvGJXUrKv(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void BfGtCDyTvGJXUrKv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BfGtCDyTvGJXUrKv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BfGtCDyTvGJXUrKv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CDeYRhexLeEfNdJT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setExclusiveCheckable(z);
    }

    public static void CDeYRhexLeEfNdJT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CDeYRhexLeEfNdJT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CDeYRhexLeEfNdJT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CPObGqWaBVhXabDb(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void CPObGqWaBVhXabDb(java.lang.ref.WeakReference weakReference, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CPObGqWaBVhXabDb(java.lang.ref.WeakReference weakReference, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CPObGqWaBVhXabDb(java.lang.ref.WeakReference weakReference, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CQMhnRpBQXQPyPbX(android.view.MenuItem menuItem, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CQMhnRpBQXQPyPbX(android.view.MenuItem menuItem, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CQMhnRpBQXQPyPbX(android.view.MenuItem menuItem, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CQMhnRpBQXQPyPbX(android.view.MenuItem menuItem) {
        return menuItem.hasSubMenu();
    }

    public static void CiJiSTgWpAaEPmnW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        menuBuilder.removeGroup(i);
    }

    public static void CiJiSTgWpAaEPmnW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CiJiSTgWpAaEPmnW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CiJiSTgWpAaEPmnW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DIgcHYLkcMoqRkIo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void DIgcHYLkcMoqRkIo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DIgcHYLkcMoqRkIo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DIgcHYLkcMoqRkIo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DgBeAQpozqCTYyDA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DgBeAQpozqCTYyDA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DgBeAQpozqCTYyDA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, float f, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DgBeAQpozqCTYyDA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i) {
        return menuBuilder.performItemAction(menuItem, i);
    }

    public static void DtERXAnPDNenLfoH(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setCheckedInt(z);
    }

    public static void DtERXAnPDNenLfoH(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DtERXAnPDNenLfoH(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DtERXAnPDNenLfoH(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DvTzBslVuAyIyshz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void DvTzBslVuAyIyshz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvTzBslVuAyIyshz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvTzBslVuAyIyshz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator EQlvorSHUpCAiVmw(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void EQlvorSHUpCAiVmw(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQlvorSHUpCAiVmw(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EQlvorSHUpCAiVmw(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ERNWghqajMxWEwiM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static void ERNWghqajMxWEwiM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERNWghqajMxWEwiM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ERNWghqajMxWEwiM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EcWmLLDgoKFCaCfv(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void EcWmLLDgoKFCaCfv(android.util.SparseArray sparseArray, int i, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EcWmLLDgoKFCaCfv(android.util.SparseArray sparseArray, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EcWmLLDgoKFCaCfv(android.util.SparseArray sparseArray, int i, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int EhFQRVhITcbGfeqp(android.view.object view) {
        return view.getId();
    }

    public static void EhFQRVhITcbGfeqp(android.view.object view, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EhFQRVhITcbGfeqp(android.view.object view, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EhFQRVhITcbGfeqp(android.view.object view, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EprhYyjCbwNTKYNn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle) {
        menuBuilder.dispatchRestoreInstanceState(bundle);
    }

    public static void EprhYyjCbwNTKYNn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EprhYyjCbwNTKYNn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EprhYyjCbwNTKYNn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FBVGUBOxtGGDznTV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void FBVGUBOxtGGDznTV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FBVGUBOxtGGDznTV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FBVGUBOxtGGDznTV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FDeFzNXBGYadDUrg(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void FDeFzNXBGYadDUrg(java.util.List arrayList, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FDeFzNXBGYadDUrg(java.util.List arrayList, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FDeFzNXBGYadDUrg(java.util.List arrayList, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FLyIhfmUiPjthjAv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FLyIhfmUiPjthjAv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FLyIhfmUiPjthjAv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FLyIhfmUiPjthjAv(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isQwertyMode();
    }

    public static androidx.appcompat.view.menu.MenuItemImpl FVbyPwuFlAkscroG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent) {
        return menuBuilder.findItemWithshortcutForKey(i, keyEvent);
    }

    public static void FVbyPwuFlAkscroG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FVbyPwuFlAkscroG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVbyPwuFlAkscroG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu FWngquDGrZaVBCzo(android.view.MenuItem menuItem) {
        return menuItem.getSubMenu();
    }

    public static void FWngquDGrZaVBCzo(android.view.MenuItem menuItem, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FWngquDGrZaVBCzo(android.view.MenuItem menuItem, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FWngquDGrZaVBCzo(android.view.MenuItem menuItem, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List FaZeKAuiBRQSQEvT(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static void FaZeKAuiBRQSQEvT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FaZeKAuiBRQSQEvT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FaZeKAuiBRQSQEvT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FeHTCjtFrEJZURPC(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void FeHTCjtFrEJZURPC(java.util.List arrayList, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FeHTCjtFrEJZURPC(java.util.List arrayList, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FeHTCjtFrEJZURPC(java.util.List arrayList, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FfJMsGAlWXfISjsC(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void FfJMsGAlWXfISjsC(java.util.List arrayList, int i, char c, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FfJMsGAlWXfISjsC(java.util.List arrayList, int i, float f, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FfJMsGAlWXfISjsC(java.util.List arrayList, int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FhjtrnQFruvNpqiC(java.util.concurrent.CopyOnWriteList copyOnWriteList, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhjtrnQFruvNpqiC(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FhjtrnQFruvNpqiC(java.util.concurrent.CopyOnWriteList copyOnWriteList, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FhjtrnQFruvNpqiC(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count == 0;
    }

    public static int FjNPlcEaOhlHCKme(androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        return menuPresenter.getId();
    }

    public static void FjNPlcEaOhlHCKme(androidx.appcompat.view.menu.MenuPresenter menuPresenter, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FjNPlcEaOhlHCKme(androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FjNPlcEaOhlHCKme(androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FoieWmKzgaJbEJXa(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void FoieWmKzgaJbEJXa(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FoieWmKzgaJbEJXa(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FoieWmKzgaJbEJXa(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqQLHytpucDznFFt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent) {
        menuBuilder.findItemsWithshortcutForKey(list, i, keyEvent);
    }

    public static void FqQLHytpucDznFFt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FqQLHytpucDznFFt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FqQLHytpucDznFFt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GGkHGqZBDMAQOBvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static void GGkHGqZBDMAQOBvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GGkHGqZBDMAQOBvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GGkHGqZBDMAQOBvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GLXxOcSywBGbTmre(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void GLXxOcSywBGbTmre(java.lang.ref.WeakReference weakReference, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GLXxOcSywBGbTmre(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GLXxOcSywBGbTmre(java.lang.ref.WeakReference weakReference, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem GifPypkCZewWsTPn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.findItem(i);
    }

    public static void GifPypkCZewWsTPn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GifPypkCZewWsTPn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GifPypkCZewWsTPn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GjCCBvKihXmsFfbx(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void GjCCBvKihXmsFfbx(java.util.List arrayList, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GjCCBvKihXmsFfbx(java.util.List arrayList, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjCCBvKihXmsFfbx(java.util.List arrayList, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GlfYNENHIIlYTXIz(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GlfYNENHIIlYTXIz(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GlfYNENHIIlYTXIz(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GlfYNENHIIlYTXIz(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return menuPresenter.onSubMenuSelected(subMenuBuilder);
    }

    public static void GtUhYAFyqeUuleJA(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GtUhYAFyqeUuleJA(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GtUhYAFyqeUuleJA(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GtUhYAFyqeUuleJA(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static void GtvGYLWwZbQIEvMG(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtvGYLWwZbQIEvMG(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GtvGYLWwZbQIEvMG(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GtvGYLWwZbQIEvMG(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData) {
        return keyEvent.getKeyData(keycharDictionary$KeyData);
    }

    public static java.lang.object HCbnjMVoWVfynLCJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HCbnjMVoWVfynLCJ(java.util.IEnumerator it, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCbnjMVoWVfynLCJ(java.util.IEnumerator it, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HCbnjMVoWVfynLCJ(java.util.IEnumerator it, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HNSzjbRLACNAGdvs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HNSzjbRLACNAGdvs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNSzjbRLACNAGdvs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HNSzjbRLACNAGdvs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder.collapseItemActionobject(menuItemImpl);
    }

    public static int HnqLhMbvlPpHszeK(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void HnqLhMbvlPpHszeK(java.util.List arrayList, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HnqLhMbvlPpHszeK(java.util.List arrayList, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HnqLhMbvlPpHszeK(java.util.List arrayList, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem HsnYGKQPPPkfsJtn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.Add(i, i2, i3, charSequence);
    }

    public static void HsnYGKQPPPkfsJtn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, int i4, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HsnYGKQPPPkfsJtn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, int i4, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HsnYGKQPPPkfsJtn(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, short s, java.lang.string str, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static int ICZdAMhxPlQECnnS(android.view.MenuItem menuItem) {
        return menuItem.getGroupId();
    }

    public static void ICZdAMhxPlQECnnS(android.view.MenuItem menuItem, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ICZdAMhxPlQECnnS(android.view.MenuItem menuItem, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ICZdAMhxPlQECnnS(android.view.MenuItem menuItem, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IYZpCjnpomhMXScN(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IYZpCjnpomhMXScN(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IYZpCjnpomhMXScN(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IYZpCjnpomhMXScN(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuPresenter.collapseItemActionobject(menuBuilder, menuItemImpl);
    }

    public static void ItibdjtUikLAZwEs(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.stopDispatchingItemsChanged();
    }

    public static void ItibdjtUikLAZwEs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ItibdjtUikLAZwEs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ItibdjtUikLAZwEs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JILeScwMdrcobUEH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void JILeScwMdrcobUEH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JILeScwMdrcobUEH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JILeScwMdrcobUEH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMEbROpgBsBUgrfc(java.util.List arrayList, java.lang.object obj, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMEbROpgBsBUgrfc(java.util.List arrayList, java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JMEbROpgBsBUgrfc(java.util.List arrayList, java.lang.object obj, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JMEbROpgBsBUgrfc(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void JNIwkKTsEVowvcXz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JNIwkKTsEVowvcXz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JNIwkKTsEVowvcXz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JNIwkKTsEVowvcXz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isActionButton();
    }

    public static java.lang.object JPJJZCCedtLeaAXx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JPJJZCCedtLeaAXx(java.util.IEnumerator it, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JPJJZCCedtLeaAXx(java.util.IEnumerator it, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JPJJZCCedtLeaAXx(java.util.IEnumerator it, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem JuDJoeyKtrUSgYqU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addInternal(i, i2, i3, charSequence);
    }

    public static void JuDJoeyKtrUSgYqU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, char c, byte b, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JuDJoeyKtrUSgYqU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, char c, int i4, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JuDJoeyKtrUSgYqU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, int i4, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KHPDtStsikOEYKpN(android.view.object view, android.util.SparseArray sparseArray) {
        view.saveHierarchyState(sparseArray);
    }

    public static void KHPDtStsikOEYKpN(android.view.object view, android.util.SparseArray sparseArray, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KHPDtStsikOEYKpN(android.view.object view, android.util.SparseArray sparseArray, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KHPDtStsikOEYKpN(android.view.object view, android.util.SparseArray sparseArray, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KMKcIftFNCwlfBNf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent) {
        menuBuilder.findItemsWithshortcutForKey(list, i, keyEvent);
    }

    public static void KMKcIftFNCwlfBNf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KMKcIftFNCwlfBNf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KMKcIftFNCwlfBNf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.util.List list, int i, android.view.KeyEvent keyEvent, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KcVIcnaEetRiYCyW(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.stopDispatchingItemsChanged();
    }

    public static void KcVIcnaEetRiYCyW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KcVIcnaEetRiYCyW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KcVIcnaEetRiYCyW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KfypzSxBKVTGLbcW(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void KfypzSxBKVTGLbcW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KfypzSxBKVTGLbcW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KfypzSxBKVTGLbcW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KiiOKxhJehjNUqly(java.util.List list) {
        return list.Count;
    }

    public static void KiiOKxhJehjNUqly(java.util.List list, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KiiOKxhJehjNUqly(java.util.List list, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KiiOKxhJehjNUqly(java.util.List list, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KmVyflDKWniHXksA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void KmVyflDKWniHXksA(java.util.IEnumerator it, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmVyflDKWniHXksA(java.util.IEnumerator it, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KmVyflDKWniHXksA(java.util.IEnumerator it, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu KoOVlWuWpOEwNfdt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getSubMenu();
    }

    public static void KoOVlWuWpOEwNfdt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KoOVlWuWpOEwNfdt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KoOVlWuWpOEwNfdt(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator KzkQaTCGNfpZeIlK(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void KzkQaTCGNfpZeIlK(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KzkQaTCGNfpZeIlK(java.util.concurrent.CopyOnWriteList copyOnWriteList, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KzkQaTCGNfpZeIlK(java.util.concurrent.CopyOnWriteList copyOnWriteList, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources LnuOtnYPJMKXRSFQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getResources();
    }

    public static void LnuOtnYPJMKXRSFQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnuOtnYPJMKXRSFQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LnuOtnYPJMKXRSFQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LwWiGULRqPvyagBi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view) {
        menuBuilder.setHeaderInternal(i, charSequence, i2, drawable, view);
    }

    public static void LwWiGULRqPvyagBi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, byte b, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LwWiGULRqPvyagBi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, float f, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LwWiGULRqPvyagBi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, bool z, float f, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MUnqvreNjldbvVnD(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MUnqvreNjldbvVnD(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MUnqvreNjldbvVnD(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MUnqvreNjldbvVnD(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        return menuBuilder$Callback.onMenuItemSelected(menuBuilder, menuItem);
    }

    public static void MoNPcgzudTCraPhS(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MoNPcgzudTCraPhS(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MoNPcgzudTCraPhS(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MoNPcgzudTCraPhS(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count == 0;
    }

    public static int MxhCIRysnOSnSAVJ(android.view.KeyEvent keyEvent) {
        return keyEvent.getMetaState();
    }

    public static void MxhCIRysnOSnSAVJ(android.view.KeyEvent keyEvent, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MxhCIRysnOSnSAVJ(android.view.KeyEvent keyEvent, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MxhCIRysnOSnSAVJ(android.view.KeyEvent keyEvent, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NDpZDKhULflIoeiJ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NDpZDKhULflIoeiJ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NDpZDKhULflIoeiJ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NDpZDKhULflIoeiJ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        return menuItemImpl.setVisibleInt(z);
    }

    public static void NJYCNcxLJpZfJZaO(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NJYCNcxLJpZfJZaO(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NJYCNcxLJpZfJZaO(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NJYCNcxLJpZfJZaO(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuPresenter.expandItemActionobject(menuBuilder, menuItemImpl);
    }

    public static java.lang.object NXTJKsnRukpkKEis(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NXTJKsnRukpkKEis(java.util.IEnumerator it, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXTJKsnRukpkKEis(java.util.IEnumerator it, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NXTJKsnRukpkKEis(java.util.IEnumerator it, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NXhDWWaGIIDgNgFd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void NXhDWWaGIIDgNgFd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NXhDWWaGIIDgNgFd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NXhDWWaGIIDgNgFd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NahXHUGznIrPnWyf(androidx.appcompat.view.menu.MenuPresenter menuPresenter, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NahXHUGznIrPnWyf(androidx.appcompat.view.menu.MenuPresenter menuPresenter, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NahXHUGznIrPnWyf(androidx.appcompat.view.menu.MenuPresenter menuPresenter, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NahXHUGznIrPnWyf(androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        return menuPresenter.flagActionItems();
    }

    public static android.view.MenuItem NbdnCqzkNoABmris(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addInternal(i, i2, i3, charSequence);
    }

    public static void NbdnCqzkNoABmris(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, byte b, java.lang.string str, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void NbdnCqzkNoABmris(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, float f, java.lang.string str, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NbdnCqzkNoABmris(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, java.lang.string str, int i4, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem NdgqWMflFLnfHOBO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addInternal(i, i2, i3, charSequence);
    }

    public static void NdgqWMflFLnfHOBO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NdgqWMflFLnfHOBO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NdgqWMflFLnfHOBO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OMFylUOASXFmKThK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void OMFylUOASXFmKThK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OMFylUOASXFmKThK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OMFylUOASXFmKThK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OhTridliMJUrSCPl(androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        return menuPresenter.getId();
    }

    public static void OhTridliMJUrSCPl(androidx.appcompat.view.menu.MenuPresenter menuPresenter, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OhTridliMJUrSCPl(androidx.appcompat.view.menu.MenuPresenter menuPresenter, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OhTridliMJUrSCPl(androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OnGkSJZOtJgUxptp(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OnGkSJZOtJgUxptp(java.util.IEnumerator it, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OnGkSJZOtJgUxptp(java.util.IEnumerator it, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OnGkSJZOtJgUxptp(java.util.IEnumerator it, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OrcvYPYMeIbLsOTB(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void OrcvYPYMeIbLsOTB(java.util.List arrayList, int i, float f, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OrcvYPYMeIbLsOTB(java.util.List arrayList, int i, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OrcvYPYMeIbLsOTB(java.util.List arrayList, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OtSBDbudTodlyrRf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z) {
        menuBuilder.removeItemAtInt(i, z);
    }

    public static void OtSBDbudTodlyrRf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, byte b, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OtSBDbudTodlyrRf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, byte b, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OtSBDbudTodlyrRf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, java.lang.string str, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PBShpgSAXJtaXikr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PBShpgSAXJtaXikr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PBShpgSAXJtaXikr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool PBShpgSAXJtaXikr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static void PGMVSEoWPMtzyHKL(java.util.IEnumerator it, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PGMVSEoWPMtzyHKL(java.util.IEnumerator it, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PGMVSEoWPMtzyHKL(java.util.IEnumerator it, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PGMVSEoWPMtzyHKL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.view.MenuItem PUhuQEoiXyRcQIEP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addInternal(i, i2, i3, charSequence);
    }

    public static void PUhuQEoiXyRcQIEP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, char c, int i4, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PUhuQEoiXyRcQIEP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, char c, short s, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void PUhuQEoiXyRcQIEP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, float f, char c, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PVEUYVfqFnnhVZCY(java.util.concurrent.CopyOnWriteList copyOnWriteList, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PVEUYVfqFnnhVZCY(java.util.concurrent.CopyOnWriteList copyOnWriteList, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PVEUYVfqFnnhVZCY(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PVEUYVfqFnnhVZCY(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count == 0;
    }

    public static android.content.object PbRPJFaplKoeEKmI(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void PbRPJFaplKoeEKmI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PbRPJFaplKoeEKmI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PbRPJFaplKoeEKmI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QPFuoNxVJUdmOkau(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QPFuoNxVJUdmOkau(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, int i2, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPFuoNxVJUdmOkau(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QPFuoNxVJUdmOkau(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i) {
        return menuBuilder.performItemAction(menuItem, i);
    }

    public static void QbCueizqyzNSxlOA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QbCueizqyzNSxlOA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QbCueizqyzNSxlOA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QbCueizqyzNSxlOA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.expandActionobject();
    }

    public static void QkeneiqCCfaOraYT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QkeneiqCCfaOraYT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QkeneiqCCfaOraYT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QkeneiqCCfaOraYT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static int QndHFBxnvBsfMtKa(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void QndHFBxnvBsfMtKa(java.util.List arrayList, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QndHFBxnvBsfMtKa(java.util.List arrayList, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QndHFBxnvBsfMtKa(java.util.List arrayList, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QryvqIMBrSjWQFgT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QryvqIMBrSjWQFgT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QryvqIMBrSjWQFgT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QryvqIMBrSjWQFgT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static android.view.MenuItem QvbPsOZdCPiEgSuX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        return menuItemImpl.setCheckable(z);
    }

    public static void QvbPsOZdCPiEgSuX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QvbPsOZdCPiEgSuX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QvbPsOZdCPiEgSuX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QxWAjqJSdOyUEkza(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        menuBuilder.addMenuPresenter(menuPresenter, context);
    }

    public static void QxWAjqJSdOyUEkza(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QxWAjqJSdOyUEkza(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QxWAjqJSdOyUEkza(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QykHlkzDdyHWEEJE(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void QykHlkzDdyHWEEJE(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QykHlkzDdyHWEEJE(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QykHlkzDdyHWEEJE(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RFTXgBIvBACyfIpZ(android.view.MenuItem menuItem) {
        return menuItem.getActionobject();
    }

    public static void RFTXgBIvBACyfIpZ(android.view.MenuItem menuItem, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RFTXgBIvBACyfIpZ(android.view.MenuItem menuItem, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RFTXgBIvBACyfIpZ(android.view.MenuItem menuItem, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RKUkgdbgPKSJGUjR(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void RKUkgdbgPKSJGUjR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RKUkgdbgPKSJGUjR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RKUkgdbgPKSJGUjR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RUSgAKBOzOxHTtIS(java.util.List list, java.lang.object obj, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RUSgAKBOzOxHTtIS(java.util.List list, java.lang.object obj, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RUSgAKBOzOxHTtIS(java.util.List list, java.lang.object obj, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RUSgAKBOzOxHTtIS(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object RcVbOTaDKHBbFRKw(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void RcVbOTaDKHBbFRKw(java.util.List arrayList, int i, byte b, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RcVbOTaDKHBbFRKw(java.util.List arrayList, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RcVbOTaDKHBbFRKw(java.util.List arrayList, int i, int i2, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.ActionProvider RgCDIFHwphPlQiYv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getSupportActionProvider();
    }

    public static void RgCDIFHwphPlQiYv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RgCDIFHwphPlQiYv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RgCDIFHwphPlQiYv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RpMvNrkJvXGYeJrF(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void RpMvNrkJvXGYeJrF(java.util.List arrayList, int i, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RpMvNrkJvXGYeJrF(java.util.List arrayList, int i, float f, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RpMvNrkJvXGYeJrF(java.util.List arrayList, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RtRrubWcgCdqygtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void RtRrubWcgCdqygtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtRrubWcgCdqygtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RtRrubWcgCdqygtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDzRAVMKRURVaucY(androidx.core.view.ActionProvider actionProvider, android.view.SubMenu subMenu) {
        actionProvider.onPrepareSubMenu(subMenu);
    }

    public static void SDzRAVMKRURVaucY(androidx.core.view.ActionProvider actionProvider, android.view.SubMenu subMenu, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SDzRAVMKRURVaucY(androidx.core.view.ActionProvider actionProvider, android.view.SubMenu subMenu, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SDzRAVMKRURVaucY(androidx.core.view.ActionProvider actionProvider, android.view.SubMenu subMenu, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SYBAMGmKalYNfcVQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void SYBAMGmKalYNfcVQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, bool z2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SYBAMGmKalYNfcVQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SYBAMGmKalYNfcVQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SYWrwsoTcwrnTqGZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void SYWrwsoTcwrnTqGZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SYWrwsoTcwrnTqGZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SYWrwsoTcwrnTqGZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SbFMZMkURSVUfhbx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SbFMZMkURSVUfhbx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SbFMZMkURSVUfhbx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SbFMZMkURSVUfhbx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isVisible();
    }

    public static void ScidQyObBjLLKXjB(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ScidQyObBjLLKXjB(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ScidQyObBjLLKXjB(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ScidQyObBjLLKXjB(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i) {
        return menuBuilder.performItemAction(menuItem, menuPresenter, i);
    }

    public static java.lang.CharSequence SmVrdOtndnCTXzst(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadLabel(packageManager);
    }

    public static void SmVrdOtndnCTXzst(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SmVrdOtndnCTXzst(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SmVrdOtndnCTXzst(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SmcnwXTcFPBricyo(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void SmcnwXTcFPBricyo(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SmcnwXTcFPBricyo(java.lang.ref.WeakReference weakReference, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SmcnwXTcFPBricyo(java.lang.ref.WeakReference weakReference, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TChcZmrLEKXjFTTR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void TChcZmrLEKXjFTTR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TChcZmrLEKXjFTTR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TChcZmrLEKXjFTTR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFXCNujufutchHpU(java.util.List arrayList, java.util.ICollection collection, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFXCNujufutchHpU(java.util.List arrayList, java.util.ICollection collection, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFXCNujufutchHpU(java.util.List arrayList, java.util.ICollection collection, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TFXCNujufutchHpU(java.util.List arrayList, java.util.ICollection collection) {
        return arrayList.addAll(collection);
    }

    public static void TdtEEgfpkskuchVA(android.view.MenuItem menuItem, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TdtEEgfpkskuchVA(android.view.MenuItem menuItem, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TdtEEgfpkskuchVA(android.view.MenuItem menuItem, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TdtEEgfpkskuchVA(android.view.MenuItem menuItem) {
        return menuItem.hasSubMenu();
    }

    public static void TjciyApMaTxnOhga(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TjciyApMaTxnOhga(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TjciyApMaTxnOhga(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TjciyApMaTxnOhga(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isEnabled();
    }

    public static java.lang.string TpJuZlbkfaYktKCw(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getActionobjectStatesKey();
    }

    public static void TpJuZlbkfaYktKCw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TpJuZlbkfaYktKCw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TpJuZlbkfaYktKCw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TyPBlUlpGVISAOBe(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void TyPBlUlpGVISAOBe(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TyPBlUlpGVISAOBe(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, short s, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TyPBlUlpGVISAOBe(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem USSwoXrgMjOkkOUJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void USSwoXrgMjOkkOUJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void USSwoXrgMjOkkOUJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void USSwoXrgMjOkkOUJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UlQOkYWWxWGGkSlL(java.util.List arrayList, java.lang.object obj, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UlQOkYWWxWGGkSlL(java.util.List arrayList, java.lang.object obj, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UlQOkYWWxWGGkSlL(java.util.List arrayList, java.lang.object obj, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UlQOkYWWxWGGkSlL(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void UljSMlRfTixtXzoI(android.view.MenuItem menuItem, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UljSMlRfTixtXzoI(android.view.MenuItem menuItem, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UljSMlRfTixtXzoI(android.view.MenuItem menuItem, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UljSMlRfTixtXzoI(android.view.MenuItem menuItem) {
        return menuItem.expandActionobject();
    }

    public static void VDDnFZMDZnPSFgFs(java.util.IEnumerator it, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VDDnFZMDZnPSFgFs(java.util.IEnumerator it, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VDDnFZMDZnPSFgFs(java.util.IEnumerator it, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VDDnFZMDZnPSFgFs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.graphics.drawable.Drawable VRuPMgrblECRguxS(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static void VRuPMgrblECRguxS(android.content.object context, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VRuPMgrblECRguxS(android.content.object context, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VRuPMgrblECRguxS(android.content.object context, int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VTRClwiVMdTxRYVi(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle) {
        subMenuBuilder.saveActionobjectStates(bundle);
    }

    public static void VTRClwiVMdTxRYVi(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VTRClwiVMdTxRYVi(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VTRClwiVMdTxRYVi(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VhXNfiWFjFizwpME(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.findItemIndex(i);
    }

    public static void VhXNfiWFjFizwpME(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VhXNfiWFjFizwpME(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VhXNfiWFjFizwpME(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VqQwsJNcahFSGVQK(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void VqQwsJNcahFSGVQK(java.util.List arrayList, int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VqQwsJNcahFSGVQK(java.util.List arrayList, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VqQwsJNcahFSGVQK(java.util.List arrayList, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WCwattXxjmPAaruL(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void WCwattXxjmPAaruL(java.lang.ref.WeakReference weakReference, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WCwattXxjmPAaruL(java.lang.ref.WeakReference weakReference, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WCwattXxjmPAaruL(java.lang.ref.WeakReference weakReference, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WTSrznwNFEWbwEHK(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.clear();
    }

    public static void WTSrznwNFEWbwEHK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WTSrznwNFEWbwEHK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WTSrznwNFEWbwEHK(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence WVdWuDmcKMctFrZw(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static void WVdWuDmcKMctFrZw(android.content.res.Resources resources, int i, char c, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WVdWuDmcKMctFrZw(android.content.res.Resources resources, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WVdWuDmcKMctFrZw(android.content.res.Resources resources, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WcfURhnfHtsCLAaI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static void WcfURhnfHtsCLAaI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WcfURhnfHtsCLAaI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WcfURhnfHtsCLAaI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhthqXFAMhsmlCkT(android.view.MenuItem menuItem, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WhthqXFAMhsmlCkT(android.view.MenuItem menuItem, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WhthqXFAMhsmlCkT(android.view.MenuItem menuItem, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WhthqXFAMhsmlCkT(android.view.MenuItem menuItem) {
        return menuItem.isActionobjectExpanded();
    }

    public static int WoJtCVjmxVvOBrlH(android.view.object view) {
        return view.getId();
    }

    public static void WoJtCVjmxVvOBrlH(android.view.object view, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WoJtCVjmxVvOBrlH(android.view.object view, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WoJtCVjmxVvOBrlH(android.view.object view, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static char WoeuZRqRjoMBXCEb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getNumericshortcut();
    }

    public static void WoeuZRqRjoMBXCEb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WoeuZRqRjoMBXCEb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WoeuZRqRjoMBXCEb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WuMVNOHWGaxtndnU(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void WuMVNOHWGaxtndnU(android.content.res.Resources resources, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuMVNOHWGaxtndnU(android.content.res.Resources resources, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WuMVNOHWGaxtndnU(android.content.res.Resources resources, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHZmrSyQkRETBsif(java.util.IEnumerator it, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHZmrSyQkRETBsif(java.util.IEnumerator it, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XHZmrSyQkRETBsif(java.util.IEnumerator it, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XHZmrSyQkRETBsif(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void XQlPFhreyiNkwehK(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XQlPFhreyiNkwehK(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XQlPFhreyiNkwehK(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XQlPFhreyiNkwehK(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static void XbuUxKmxuLblCGsf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        menuItemImpl.setSubMenu(subMenuBuilder);
    }

    public static void XbuUxKmxuLblCGsf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XbuUxKmxuLblCGsf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XbuUxKmxuLblCGsf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources XclvcbSjOTfbFqIJ(android.content.object context) {
        return context.getResources();
    }

    public static void XclvcbSjOTfbFqIJ(android.content.object context, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XclvcbSjOTfbFqIJ(android.content.object context, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XclvcbSjOTfbFqIJ(android.content.object context, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XmgkLdfnZlcfWJcv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2) {
        return menuBuilder.findGroupIndex(i, i2);
    }

    public static void XmgkLdfnZlcfWJcv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, byte b, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void XmgkLdfnZlcfWJcv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, bool z, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XmgkLdfnZlcfWJcv(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, bool z, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XoFynnowaFgMahgF(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XoFynnowaFgMahgF(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XoFynnowaFgMahgF(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XoFynnowaFgMahgF(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static android.os.Parcelable XuHsIcsFUIBijHXR(androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        return menuPresenter.onSaveInstanceState();
    }

    public static void XuHsIcsFUIBijHXR(androidx.appcompat.view.menu.MenuPresenter menuPresenter, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XuHsIcsFUIBijHXR(androidx.appcompat.view.menu.MenuPresenter menuPresenter, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XuHsIcsFUIBijHXR(androidx.appcompat.view.menu.MenuPresenter menuPresenter, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YLtdXuqtcxHIMTlO(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void YLtdXuqtcxHIMTlO(java.util.List arrayList, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YLtdXuqtcxHIMTlO(java.util.List arrayList, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YLtdXuqtcxHIMTlO(java.util.List arrayList, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YQguZkUrrOjpPDWq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getNumericModifiers();
    }

    public static void YQguZkUrrOjpPDWq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YQguZkUrrOjpPDWq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQguZkUrrOjpPDWq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YVPvlKBksYHKVUmw(java.util.IEnumerator it, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YVPvlKBksYHKVUmw(java.util.IEnumerator it, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YVPvlKBksYHKVUmw(java.util.IEnumerator it, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YVPvlKBksYHKVUmw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void YagQacEOYpaytpAc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle) {
        menuBuilder.dispatchSaveInstanceState(bundle);
    }

    public static void YagQacEOYpaytpAc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YagQacEOYpaytpAc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YagQacEOYpaytpAc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.os.Dictionary<string, object> bundle, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YdxjMyKydFmlEIuO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YdxjMyKydFmlEIuO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YdxjMyKydFmlEIuO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YdxjMyKydFmlEIuO(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasCollapsibleActionobject();
    }

    public static void YuLBlreaiulFZfLU(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YuLBlreaiulFZfLU(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YuLBlreaiulFZfLU(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool YuLBlreaiulFZfLU(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Add(obj);
    }

    public static java.lang.object ZaLTbNGtijeaNtGe(java.util.List list, int i) {
        return list[i);
    }

    public static void ZaLTbNGtijeaNtGe(java.util.List list, int i, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZaLTbNGtijeaNtGe(java.util.List list, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZaLTbNGtijeaNtGe(java.util.List list, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZjQpgcXqGVlTHXhJ(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void ZjQpgcXqGVlTHXhJ(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZjQpgcXqGVlTHXhJ(java.lang.ref.WeakReference weakReference, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZjQpgcXqGVlTHXhJ(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZvfBdabyYwzwAaCj(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getActionobjectStatesKey();
    }

    public static void ZvfBdabyYwzwAaCj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvfBdabyYwzwAaCj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZvfBdabyYwzwAaCj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZxEJAenElqKPqMnp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void ZxEJAenElqKPqMnp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZxEJAenElqKPqMnp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZxEJAenElqKPqMnp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZztCFstpRunKZdtr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZztCFstpRunKZdtr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZztCFstpRunKZdtr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZztCFstpRunKZdtr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        return menuBuilder.dispatchSubMenuSelected(subMenuBuilder, menuPresenter);
    }

    public static void AAcYwmfVKbOmOTbD(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.flagActionItems();
    }

    public static void AAcYwmfVKbOmOTbD(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AAcYwmfVKbOmOTbD(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AAcYwmfVKbOmOTbD(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int AJrAfeDsdwuYNBvF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static void AJrAfeDsdwuYNBvF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AJrAfeDsdwuYNBvF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AJrAfeDsdwuYNBvF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AXKYRnzcmsFrRdmN(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void AXKYRnzcmsFrRdmN(android.view.MenuItem menuItem, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXKYRnzcmsFrRdmN(android.view.MenuItem menuItem, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AXKYRnzcmsFrRdmN(android.view.MenuItem menuItem, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AXsmBFCkKxleJBBh(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AXsmBFCkKxleJBBh(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXsmBFCkKxleJBBh(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AXsmBFCkKxleJBBh(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count == 0;
    }

    public static void AYjczzQgnDyYtskH(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.stopDispatchingItemsChanged();
    }

    public static void AYjczzQgnDyYtskH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AYjczzQgnDyYtskH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AYjczzQgnDyYtskH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AheTWVDBiKAOpNUZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void AheTWVDBiKAOpNUZ(java.util.IEnumerator it, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AheTWVDBiKAOpNUZ(java.util.IEnumerator it, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AheTWVDBiKAOpNUZ(java.util.IEnumerator it, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BLkfjznxgDqRTaWR(android.view.KeyEvent keyEvent) {
        return keyEvent.getModifiers();
    }

    public static void BLkfjznxgDqRTaWR(android.view.KeyEvent keyEvent, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLkfjznxgDqRTaWR(android.view.KeyEvent keyEvent, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BLkfjznxgDqRTaWR(android.view.KeyEvent keyEvent, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNrqLsHQqtLqppKz(java.util.IEnumerator it, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BNrqLsHQqtLqppKz(java.util.IEnumerator it, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BNrqLsHQqtLqppKz(java.util.IEnumerator it, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BNrqLsHQqtLqppKz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.view.MenuItem BmRflKjqEKAyOhUl(android.view.MenuItem menuItem, android.content.object intent) {
        return menuItem.setobject(intent);
    }

    public static void BmRflKjqEKAyOhUl(android.view.MenuItem menuItem, android.content.object intent, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BmRflKjqEKAyOhUl(android.view.MenuItem menuItem, android.content.object intent, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BmRflKjqEKAyOhUl(android.view.MenuItem menuItem, android.content.object intent, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BttmfdeVdSBNmgcS(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void BttmfdeVdSBNmgcS(java.util.List arrayList, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BttmfdeVdSBNmgcS(java.util.List arrayList, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BttmfdeVdSBNmgcS(java.util.List arrayList, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CAdTIyEibMJJCNem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CAdTIyEibMJJCNem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CAdTIyEibMJJCNem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CAdTIyEibMJJCNem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isEnabled();
    }

    public static android.util.SparseArray CSqrvVstAxsbNJEJ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getSparseParcelableArray(str);
    }

    public static void CSqrvVstAxsbNJEJ(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CSqrvVstAxsbNJEJ(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CSqrvVstAxsbNJEJ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CWpAeokGjnRjhFdH(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.os.Parcelable parcelable) {
        menuPresenter.onRestoreInstanceState(parcelable);
    }

    public static void CWpAeokGjnRjhFdH(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.os.Parcelable parcelable, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CWpAeokGjnRjhFdH(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.os.Parcelable parcelable, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CWpAeokGjnRjhFdH(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.os.Parcelable parcelable, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private androidx.appcompat.view.menu.MenuItemImpl CreateNewMenuItem(int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5) {
        if ((6 + 19) % 19 > 0) {
        }
        return new androidx.appcompat.view.menu.MenuItemImpl(this, i, i2, i3, i4, charSequence, i5);
    }

    private void CreateNewMenuItem(int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5, byte b, int i6, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateNewMenuItem(int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5, short s, byte b, int i6, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateNewMenuItem(int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5, short s, float f, byte b, int i6) {
        double d = (42 * 210) + 210;
    }

    public static void DDmQJgEhisgBeaes(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.flagActionItems();
    }

    public static void DDmQJgEhisgBeaes(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DDmQJgEhisgBeaes(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DDmQJgEhisgBeaes(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DGABrWwfCtTaqCoS(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void DGABrWwfCtTaqCoS(android.util.SparseArray sparseArray, int i, java.lang.object obj, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DGABrWwfCtTaqCoS(android.util.SparseArray sparseArray, int i, java.lang.object obj, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DGABrWwfCtTaqCoS(android.util.SparseArray sparseArray, int i, java.lang.object obj, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu DWCsVpcdkKlUabti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addSubMenu(i, i2, i3, charSequence);
    }

    public static void DWCsVpcdkKlUabti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DWCsVpcdkKlUabti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DWCsVpcdkKlUabti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchPresenterUpdate(bool z) {
        if ((14 + 14) % 14 > 0) {
        }
        if (FhjtrnQFruvNpqiC(this.mPresenters)) {
            return;
        }
        KcVIcnaEetRiYCyW(this);
        java.util.IEnumerator itYPTyaXnzlLYPnRzb = yPTyaXnzlLYPnRzb(this.mPresenters);
        while (hzuxyfCbgkzKbnQD(itYPTyaXnzlLYPnRzb)) {
            java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) xvhsNyvBrOARxJfK(itYPTyaXnzlLYPnRzb);
            androidx.appcompat.view.menu.MenuPresenter menuPresenter = (androidx.appcompat.view.menu.MenuPresenter) qNPyXRDoIWheljGK(weakReference);
            if (menuPresenter is not null) {
                rBQXybLaFhhhsOWa(menuPresenter, z);
            } else {
                nRULQnjEODhgMLwT(this.mPresenters, weakReference);
            }
        }
        oxXCOIEKHKVrtmlz(this);
    }

    private void DispatchPresenterUpdate(bool z, byte b, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void DispatchPresenterUpdate(bool z, char c, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void DispatchPresenterUpdate(bool z, int i, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void DispatchRestoreInstanceState(android.os.Dictionary<string, object> bundle) {
        android.os.Parcelable parcelable;
        if ((14 + 9) % 9 > 0) {
        }
        android.util.SparseArray sparseArrayLQWTUCUBpTfSnOzq = lQWTUCUBpTfSnOzq(bundle, "android:menu:presenters");
        if (sparseArrayLQWTUCUBpTfSnOzq is null || MoNPcgzudTCraPhS(this.mPresenters)) {
            return;
        }
        java.util.IEnumerator itEQlvorSHUpCAiVmw = EQlvorSHUpCAiVmw(this.mPresenters);
        while (XHZmrSyQkRETBsif(itEQlvorSHUpCAiVmw)) {
            java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) JPJJZCCedtLeaAXx(itEQlvorSHUpCAiVmw);
            androidx.appcompat.view.menu.MenuPresenter menuPresenter = (androidx.appcompat.view.menu.MenuPresenter) CPObGqWaBVhXabDb(weakReference);
            if (menuPresenter is not null) {
                int iFjNPlcEaOhlHCKme = FjNPlcEaOhlHCKme(menuPresenter);
                if (iFjNPlcEaOhlHCKme > 0 && (parcelable = (android.os.Parcelable) EcWmLLDgoKFCaCfv(sparseArrayLQWTUCUBpTfSnOzq, iFjNPlcEaOhlHCKme)) is not null) {
                    cWpAeokGjnRjhFdH(menuPresenter, parcelable);
                }
            } else {
                oyUWwvThYSNpiQxv(this.mPresenters, weakReference);
            }
        }
    }

    private void DispatchRestoreInstanceState(android.os.Dictionary<string, object> bundle, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void DispatchRestoreInstanceState(android.os.Dictionary<string, object> bundle, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DispatchRestoreInstanceState(android.os.Dictionary<string, object> bundle, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        android.os.Parcelable parcelableXuHsIcsFUIBijHXR;
        if ((5 + 32) % 32 > 0) {
        }
        if (zNZsvQZTKzuBwcDC(this.mPresenters)) {
            return;
        }
        android.util.SparseArray sparseArray = new android.util.SparseArray();
        java.util.IEnumerator itNFMObQzcsSnGkzgV = nFMObQzcsSnGkzgV(this.mPresenters);
        while (bNrqLsHQqtLqppKz(itNFMObQzcsSnGkzgV)) {
            java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) KmVyflDKWniHXksA(itNFMObQzcsSnGkzgV);
            androidx.appcompat.view.menu.MenuPresenter menuPresenter = (androidx.appcompat.view.menu.MenuPresenter) WCwattXxjmPAaruL(weakReference);
            if (menuPresenter is not null) {
                int iOhTridliMJUrSCPl = OhTridliMJUrSCPl(menuPresenter);
                if (iOhTridliMJUrSCPl > 0 && (parcelableXuHsIcsFUIBijHXR = XuHsIcsFUIBijHXR(menuPresenter)) is not null) {
                    dGABrWwfCtTaqCoS(sparseArray, iOhTridliMJUrSCPl, parcelableXuHsIcsFUIBijHXR);
                }
            } else {
                GtUhYAFyqeUuleJA(this.mPresenters, weakReference);
            }
        }
        tIUTjULQyHYWlBfL(bundle, "android:menu:presenters", sparseArray);
    }

    private void DispatchSaveInstanceState(android.os.Dictionary<string, object> bundle, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchSaveInstanceState(android.os.Dictionary<string, object> bundle, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DispatchSaveInstanceState(android.os.Dictionary<string, object> bundle, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void DispatchSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void DispatchSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void DispatchSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private bool DispatchSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        if ((23 + 15) % 15 > 0) {
        }
        if (aXsmBFCkKxleJBBh(this.mPresenters)) {
            return false;
        }
        bool zGlfYNENHIIlYTXIz = menuPresenter is not null ? GlfYNENHIIlYTXIz(menuPresenter, subMenuBuilder) : false;
        java.util.IEnumerator itQMHuOuALRGvDvvXl = qMHuOuALRGvDvvXl(this.mPresenters);
        while (YVPvlKBksYHKVUmw(itQMHuOuALRGvDvvXl)) {
            java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) OnGkSJZOtJgUxptp(itQMHuOuALRGvDvvXl);
            androidx.appcompat.view.menu.MenuPresenter menuPresenter2 = (androidx.appcompat.view.menu.MenuPresenter) lJgiSxatbjKRbmjL(weakReference);
            if (menuPresenter2 is null) {
                QkeneiqCCfaOraYT(this.mPresenters, weakReference);
            } else if (!zGlfYNENHIIlYTXIz) {
                zGlfYNENHIIlYTXIz = AxdCGCsQzfQHclru(menuPresenter2, subMenuBuilder);
            }
        }
        return zGlfYNENHIIlYTXIz;
    }

    public static android.view.MenuItem EDiSaSgwDRgIIfPC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addInternal(i, i2, i3, charSequence);
    }

    public static void EDiSaSgwDRgIIfPC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EDiSaSgwDRgIIfPC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EDiSaSgwDRgIIfPC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object EQNMNgewxbKXIGfQ(android.view.MenuItem menuItem) {
        return menuItem.getActionobject();
    }

    public static void EQNMNgewxbKXIGfQ(android.view.MenuItem menuItem, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQNMNgewxbKXIGfQ(android.view.MenuItem menuItem, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EQNMNgewxbKXIGfQ(android.view.MenuItem menuItem, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EToFMCfHjmyyOFwr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z) {
        menuBuilder.removeItemAtInt(i, z);
    }

    public static void EToFMCfHjmyyOFwr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, byte b, short s, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EToFMCfHjmyyOFwr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, short s, byte b, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EToFMCfHjmyyOFwr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, bool z2, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu EcGDQFuSnrxHojug(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addSubMenu(i, i2, i3, charSequence);
    }

    public static void EcGDQFuSnrxHojug(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, int i4, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EcGDQFuSnrxHojug(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, java.lang.string str, byte b, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EcGDQFuSnrxHojug(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, short s, byte b, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void EeOIkWrFjvVuACZU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EeOIkWrFjvVuACZU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EeOIkWrFjvVuACZU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EeOIkWrFjvVuACZU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static android.content.pm.PackageManager EhECoZSLWpnukJqr(android.content.object context) {
        return context.getPackageManager();
    }

    public static void EhECoZSLWpnukJqr(android.content.object context, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EhECoZSLWpnukJqr(android.content.object context, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EhECoZSLWpnukJqr(android.content.object context, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FWmbYCmnNxrwaTkU(android.view.objectConfiguration viewConfiguration, android.content.object context, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FWmbYCmnNxrwaTkU(android.view.objectConfiguration viewConfiguration, android.content.object context, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FWmbYCmnNxrwaTkU(android.view.objectConfiguration viewConfiguration, android.content.object context, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FWmbYCmnNxrwaTkU(android.view.objectConfiguration viewConfiguration, android.content.object context) {
        return androidx.core.view.objectConfigurationCompat.shouldShowMenushortcutsWhenKeyboardPresent(viewConfiguration, context);
    }

    public static int FfnhOCFNIwUivPQO(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void FfnhOCFNIwUivPQO(java.util.List arrayList, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FfnhOCFNIwUivPQO(java.util.List arrayList, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FfnhOCFNIwUivPQO(java.util.List arrayList, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FgWJIeJMOsmUdfIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void FgWJIeJMOsmUdfIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgWJIeJMOsmUdfIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FgWJIeJMOsmUdfIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private static int FindInsertIndex(java.util.List<androidx.appcompat.view.menu.MenuItemImpl> arrayList, int i) {
        if ((20 + 21) % 21 > 0) {
        }
        for (int iHnqLhMbvlPpHszeK = HnqLhMbvlPpHszeK(arrayList) - 1; iHnqLhMbvlPpHszeK >= 0; iHnqLhMbvlPpHszeK--) {
            if (qhXceCnGKJspASVx((androidx.appcompat.view.menu.MenuItemImpl) lfUeKmixFliyeUrZ(arrayList, iHnqLhMbvlPpHszeK)) <= i) {
                return iHnqLhMbvlPpHszeK + 1;
            }
        }
        return 0;
    }

    private static void FindInsertIndex(java.util.List arrayList, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    private static void FindInsertIndex(java.util.List arrayList, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    private static void FindInsertIndex(java.util.List arrayList, int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FosBtobuRLJUxncc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static void FosBtobuRLJUxncc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FosBtobuRLJUxncc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FosBtobuRLJUxncc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator FuVMhPKzgMCCMGuH(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void FuVMhPKzgMCCMGuH(java.util.concurrent.CopyOnWriteList copyOnWriteList, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FuVMhPKzgMCCMGuH(java.util.concurrent.CopyOnWriteList copyOnWriteList, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FuVMhPKzgMCCMGuH(java.util.concurrent.CopyOnWriteList copyOnWriteList, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GAafyEgiMebqhhcj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GAafyEgiMebqhhcj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GAafyEgiMebqhhcj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GAafyEgiMebqhhcj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isExclusiveCheckable();
    }

    public static android.view.MenuItem GBzCTsasyfjgWjaW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        return menuItemImpl.setEnabled(z);
    }

    public static void GBzCTsasyfjgWjaW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GBzCTsasyfjgWjaW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GBzCTsasyfjgWjaW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQoURTWRapebysIg(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void GQoURTWRapebysIg(java.util.List arrayList, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GQoURTWRapebysIg(java.util.List arrayList, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GQoURTWRapebysIg(java.util.List arrayList, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GUwLbfiKxRvzLtkA(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void GUwLbfiKxRvzLtkA(java.util.List arrayList, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GUwLbfiKxRvzLtkA(java.util.List arrayList, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GUwLbfiKxRvzLtkA(java.util.List arrayList, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static char GWRXDAfPKGiAxVff(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getAlphabeticshortcut();
    }

    public static void GWRXDAfPKGiAxVff(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWRXDAfPKGiAxVff(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWRXDAfPKGiAxVff(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GbmBiGbJajMxoQvL(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuPresenter.onCloseMenu(menuBuilder, z);
    }

    public static void GbmBiGbJajMxoQvL(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GbmBiGbJajMxoQvL(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GbmBiGbJajMxoQvL(androidx.appcompat.view.menu.MenuPresenter menuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static int GetOrdering(int i) {
        if ((4 + 18) % 18 > 0) {
        }
        int i2 = ((-65536) & i) >> 16;
        if (i2 >= 0) {
            int[] iArr = sCategoryToOrder;
            if (i2 < iArr.length) {
                return (i & 65535) | (iArr[i2] << 16);
            }
        }
        throw new java.lang.IllegalArgumentException("order does not contain a valid category.");
    }

    private static void GetOrdering(int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetOrdering(int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static void GetOrdering(int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GnSySOxOewGJCxnd(androidx.core.view.ActionProvider actionProvider, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GnSySOxOewGJCxnd(androidx.core.view.ActionProvider actionProvider, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GnSySOxOewGJCxnd(androidx.core.view.ActionProvider actionProvider, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool GnSySOxOewGJCxnd(androidx.core.view.ActionProvider actionProvider) {
        return actionProvider.hasSubMenu();
    }

    public static void HLHMJFHxkMGrjvly(java.util.IEnumerator it, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HLHMJFHxkMGrjvly(java.util.IEnumerator it, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HLHMJFHxkMGrjvly(java.util.IEnumerator it, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HLHMJFHxkMGrjvly(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int HlvedcAMRAiiXCWG(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void HlvedcAMRAiiXCWG(java.util.List arrayList, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlvedcAMRAiiXCWG(java.util.List arrayList, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlvedcAMRAiiXCWG(java.util.List arrayList, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HzZjHvwxLieWxewa(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void HzZjHvwxLieWxewa(java.util.List arrayList, int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HzZjHvwxLieWxewa(java.util.List arrayList, int i, bool z, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HzZjHvwxLieWxewa(java.util.List arrayList, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HzuxyfCbgkzKbnQD(java.util.IEnumerator it, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HzuxyfCbgkzKbnQD(java.util.IEnumerator it, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HzuxyfCbgkzKbnQD(java.util.IEnumerator it, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool HzuxyfCbgkzKbnQD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void IGRGIPtrfgwmlCVx(java.util.IEnumerator it, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IGRGIPtrfgwmlCVx(java.util.IEnumerator it, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IGRGIPtrfgwmlCVx(java.util.IEnumerator it, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IGRGIPtrfgwmlCVx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string IUItbrVFAVvfqMPt(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void IUItbrVFAVvfqMPt(android.content.res.Resources resources, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUItbrVFAVvfqMPt(android.content.res.Resources resources, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUItbrVFAVvfqMPt(android.content.res.Resources resources, int i, java.lang.string str, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IfrKaFIZDIybvOpL(java.util.List arrayList, int i) {
        return arrayList.Remove(i);
    }

    public static void IfrKaFIZDIybvOpL(java.util.List arrayList, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IfrKaFIZDIybvOpL(java.util.List arrayList, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfrKaFIZDIybvOpL(java.util.List arrayList, int i, bool z, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxwzllIOpHvflGzW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo) {
        menuItemImpl.setMenuInfo(contextMenu$objectMenuInfo);
    }

    public static void IxwzllIOpHvflGzW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IxwzllIOpHvflGzW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IxwzllIOpHvflGzW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JHkoNqvUzkGxNase(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JHkoNqvUzkGxNase(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JHkoNqvUzkGxNase(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool JHkoNqvUzkGxNase(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static androidx.appcompat.view.menu.MenuItemImpl JKCaaJGYIYOZnWCJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent) {
        return menuBuilder.findItemWithshortcutForKey(i, keyEvent);
    }

    public static void JKCaaJGYIYOZnWCJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent, float f, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKCaaJGYIYOZnWCJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKCaaJGYIYOZnWCJ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, android.view.KeyEvent keyEvent, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int JNxmTgjTzOihUCIP(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void JNxmTgjTzOihUCIP(java.util.List arrayList, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JNxmTgjTzOihUCIP(java.util.List arrayList, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JNxmTgjTzOihUCIP(java.util.List arrayList, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JVKUcyNbBcmoylsW(android.view.object view, android.util.SparseArray sparseArray) {
        view.restoreHierarchyState(sparseArray);
    }

    public static void JVKUcyNbBcmoylsW(android.view.object view, android.util.SparseArray sparseArray, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JVKUcyNbBcmoylsW(android.view.object view, android.util.SparseArray sparseArray, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JVKUcyNbBcmoylsW(android.view.object view, android.util.SparseArray sparseArray, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JVhdNtbGMaqJUfst(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.dispatchPresenterUpdate(z);
    }

    public static void JVhdNtbGMaqJUfst(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JVhdNtbGMaqJUfst(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JVhdNtbGMaqJUfst(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static char JwqnzdSpAWhfFXTA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getNumericshortcut();
    }

    public static void JwqnzdSpAWhfFXTA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JwqnzdSpAWhfFXTA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwqnzdSpAWhfFXTA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KGnEZCwEeCcDhiNS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.setshortcutsVisibleInner(z);
    }

    public static void KGnEZCwEeCcDhiNS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KGnEZCwEeCcDhiNS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KGnEZCwEeCcDhiNS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int KJuSIMznAQNkbjcD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static void KJuSIMznAQNkbjcD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KJuSIMznAQNkbjcD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KJuSIMznAQNkbjcD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KNXGqqCOtXCmOuke(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void KNXGqqCOtXCmOuke(java.util.List arrayList, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KNXGqqCOtXCmOuke(java.util.List arrayList, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KNXGqqCOtXCmOuke(java.util.List arrayList, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int KYcZzpAllgRCpbpy(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void KYcZzpAllgRCpbpy(java.util.List arrayList, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KYcZzpAllgRCpbpy(java.util.List arrayList, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KYcZzpAllgRCpbpy(java.util.List arrayList, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KcUphzepPwOOWgUH(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KcUphzepPwOOWgUH(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KcUphzepPwOOWgUH(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KcUphzepPwOOWgUH(android.view.KeyEvent keyEvent, android.view.KeycharDictionary$KeyData keycharDictionary$KeyData) {
        return keyEvent.getKeyData(keycharDictionary$KeyData);
    }

    public static void KdXKnTmQiKpyXSif(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle) {
        subMenuBuilder.restoreActionobjectStates(bundle);
    }

    public static void KdXKnTmQiKpyXSif(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KdXKnTmQiKpyXSif(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KdXKnTmQiKpyXSif(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, android.os.Dictionary<string, object> bundle, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KhynbcmkpQNqfljX(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void KhynbcmkpQNqfljX(java.util.List arrayList, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KhynbcmkpQNqfljX(java.util.List arrayList, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KhynbcmkpQNqfljX(java.util.List arrayList, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KtaaARcSEJGMkhSb(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuPresenter.initForMenu(context, menuBuilder);
    }

    public static void KtaaARcSEJGMkhSb(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KtaaARcSEJGMkhSb(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtaaARcSEJGMkhSb(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LChnZDMzdvUikXtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z) {
        menuBuilder.removeItemAtInt(i, z);
    }

    public static void LChnZDMzdvUikXtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, short s, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LChnZDMzdvUikXtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, short s, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LChnZDMzdvUikXtM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, bool z2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LEtXIdJflGKdcWBw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void LEtXIdJflGKdcWBw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LEtXIdJflGKdcWBw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LEtXIdJflGKdcWBw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LJgiSxatbjKRbmjL(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void LJgiSxatbjKRbmjL(java.lang.ref.WeakReference weakReference, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LJgiSxatbjKRbmjL(java.lang.ref.WeakReference weakReference, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LJgiSxatbjKRbmjL(java.lang.ref.WeakReference weakReference, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.util.SparseArray LQWTUCUBpTfSnOzq(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getSparseParcelableArray(str);
    }

    public static void LQWTUCUBpTfSnOzq(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LQWTUCUBpTfSnOzq(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LQWTUCUBpTfSnOzq(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LRNyHLzMqpqzJXaM(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void LRNyHLzMqpqzJXaM(java.util.List arrayList, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LRNyHLzMqpqzJXaM(java.util.List arrayList, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LRNyHLzMqpqzJXaM(java.util.List arrayList, int i, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LSsdproSgXWRvSUy(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void LSsdproSgXWRvSUy(android.content.res.Resources resources, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSsdproSgXWRvSUy(android.content.res.Resources resources, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSsdproSgXWRvSUy(android.content.res.Resources resources, int i, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List LbMjloYmrZNwPhSI(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static void LbMjloYmrZNwPhSI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LbMjloYmrZNwPhSI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LbMjloYmrZNwPhSI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LfUeKmixFliyeUrZ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void LfUeKmixFliyeUrZ(java.util.List arrayList, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LfUeKmixFliyeUrZ(java.util.List arrayList, int i, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LfUeKmixFliyeUrZ(java.util.List arrayList, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu LgAoCdxnakosonyn(android.view.MenuItem menuItem) {
        return menuItem.getSubMenu();
    }

    public static void LgAoCdxnakosonyn(android.view.MenuItem menuItem, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LgAoCdxnakosonyn(android.view.MenuItem menuItem, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LgAoCdxnakosonyn(android.view.MenuItem menuItem, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LtolmSbgfLbzJevW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.setshortcutsVisibleInner(z);
    }

    public static void LtolmSbgfLbzJevW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LtolmSbgfLbzJevW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LtolmSbgfLbzJevW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator MGLZTAfAnHrRvWjM(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void MGLZTAfAnHrRvWjM(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MGLZTAfAnHrRvWjM(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MGLZTAfAnHrRvWjM(java.util.concurrent.CopyOnWriteList copyOnWriteList, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MXHdboDLWggziSim(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void MXHdboDLWggziSim(java.util.List arrayList, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MXHdboDLWggziSim(java.util.List arrayList, int i, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MXHdboDLWggziSim(java.util.List arrayList, int i, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MYjbAcfwvShBPJKy(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void MYjbAcfwvShBPJKy(java.util.List arrayList, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MYjbAcfwvShBPJKy(java.util.List arrayList, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MYjbAcfwvShBPJKy(java.util.List arrayList, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object McAAUdVmYKBhsZfz(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void McAAUdVmYKBhsZfz(java.util.List arrayList, int i, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void McAAUdVmYKBhsZfz(java.util.List arrayList, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void McAAUdVmYKBhsZfz(java.util.List arrayList, int i, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfmeMvIcRwyLrGSk(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder$Callback.onMenuModeChange(menuBuilder);
    }

    public static void MfmeMvIcRwyLrGSk(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MfmeMvIcRwyLrGSk(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MfmeMvIcRwyLrGSk(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl MgOwKTZyuIlOGCTS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5) {
        return menuBuilder.createNewMenuItem(i, i2, i3, i4, charSequence, i5);
    }

    public static void MgOwKTZyuIlOGCTS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5, int i6, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MgOwKTZyuIlOGCTS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5, short s, float f, java.lang.string str, int i6) {
        double d = (42 * 210) + 210;
    }

    public static void MgOwKTZyuIlOGCTS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5, short s, int i6, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MqscTtnIJcvZwPAR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view) {
        menuBuilder.setHeaderInternal(i, charSequence, i2, drawable, view);
    }

    public static void MqscTtnIJcvZwPAR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqscTtnIJcvZwPAR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MqscTtnIJcvZwPAR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator MxClEyRXKMhFgZqn(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void MxClEyRXKMhFgZqn(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxClEyRXKMhFgZqn(java.util.concurrent.CopyOnWriteList copyOnWriteList, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxClEyRXKMhFgZqn(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator NFMObQzcsSnGkzgV(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void NFMObQzcsSnGkzgV(java.util.concurrent.CopyOnWriteList copyOnWriteList, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NFMObQzcsSnGkzgV(java.util.concurrent.CopyOnWriteList copyOnWriteList, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NFMObQzcsSnGkzgV(java.util.concurrent.CopyOnWriteList copyOnWriteList, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NFVxAUtbfhOjRDwn(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void NFVxAUtbfhOjRDwn(java.util.List arrayList, int i, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NFVxAUtbfhOjRDwn(java.util.List arrayList, int i, short s, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NFVxAUtbfhOjRDwn(java.util.List arrayList, int i, short s, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NGyeVflTYLCVMjTn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGyeVflTYLCVMjTn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NGyeVflTYLCVMjTn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NGyeVflTYLCVMjTn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isVisible();
    }

    public static java.lang.object NPtVqJTXjIQlerew(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void NPtVqJTXjIQlerew(java.lang.ref.WeakReference weakReference, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NPtVqJTXjIQlerew(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NPtVqJTXjIQlerew(java.lang.ref.WeakReference weakReference, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NRULQnjEODhgMLwT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NRULQnjEODhgMLwT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NRULQnjEODhgMLwT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NRULQnjEODhgMLwT(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static int NXZSoLiUhNOcYpQg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void NXZSoLiUhNOcYpQg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NXZSoLiUhNOcYpQg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NXZSoLiUhNOcYpQg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NZvgsFbzNRJIgDVu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void NZvgsFbzNRJIgDVu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NZvgsFbzNRJIgDVu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NZvgsFbzNRJIgDVu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NlaWwQKrlGwQXsxT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void NlaWwQKrlGwQXsxT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NlaWwQKrlGwQXsxT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NlaWwQKrlGwQXsxT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NodaUkwOefAwxUPo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.findGroupIndex(i);
    }

    public static void NodaUkwOefAwxUPo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NodaUkwOefAwxUPo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NodaUkwOefAwxUPo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object OWAiMrnoZCWTazmY(android.content.object intent, android.content.ComponentName componentName) {
        return intent.setComponent(componentName);
    }

    public static void OWAiMrnoZCWTazmY(android.content.object intent, android.content.ComponentName componentName, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OWAiMrnoZCWTazmY(android.content.object intent, android.content.ComponentName componentName, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OWAiMrnoZCWTazmY(android.content.object intent, android.content.ComponentName componentName, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static char OWGJfrxrcTniFWix(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getAlphabeticshortcut();
    }

    public static void OWGJfrxrcTniFWix(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OWGJfrxrcTniFWix(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OWGJfrxrcTniFWix(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OgkAeKdlgUoXjMdL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void OgkAeKdlgUoXjMdL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OgkAeKdlgUoXjMdL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OgkAeKdlgUoXjMdL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OjTdDOmWSlyfsKjr(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.stopDispatchingItemsChanged();
    }

    public static void OjTdDOmWSlyfsKjr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjTdDOmWSlyfsKjr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjTdDOmWSlyfsKjr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OlLrFNOiFoQCgDwI(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void OlLrFNOiFoQCgDwI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OlLrFNOiFoQCgDwI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OlLrFNOiFoQCgDwI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OtYPmYglkdWzQmnc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        menuItemImpl.setSubMenu(subMenuBuilder);
    }

    public static void OtYPmYglkdWzQmnc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OtYPmYglkdWzQmnc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OtYPmYglkdWzQmnc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OxXCOIEKHKVrtmlz(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void OxXCOIEKHKVrtmlz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OxXCOIEKHKVrtmlz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxXCOIEKHKVrtmlz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OyUWwvThYSNpiQxv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OyUWwvThYSNpiQxv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OyUWwvThYSNpiQxv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OyUWwvThYSNpiQxv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static java.util.List PEKPZCtotvCuQYob(android.content.pm.PackageManager packageManager, android.content.ComponentName componentName, android.content.object[] intentArr, android.content.object intent, int i) {
        return packageManager.queryobjectobjectOptions(componentName, intentArr, intent, i);
    }

    public static void PEKPZCtotvCuQYob(android.content.pm.PackageManager packageManager, android.content.ComponentName componentName, android.content.object[] intentArr, android.content.object intent, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PEKPZCtotvCuQYob(android.content.pm.PackageManager packageManager, android.content.ComponentName componentName, android.content.object[] intentArr, android.content.object intent, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PEKPZCtotvCuQYob(android.content.pm.PackageManager packageManager, android.content.ComponentName componentName, android.content.object[] intentArr, android.content.object intent, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu PJDDvNaDwElumxdC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getSubMenu();
    }

    public static void PJDDvNaDwElumxdC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PJDDvNaDwElumxdC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PJDDvNaDwElumxdC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PJnnxGZQfLZrVFli(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view) {
        menuBuilder.setHeaderInternal(i, charSequence, i2, drawable, view);
    }

    public static void PJnnxGZQfLZrVFli(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PJnnxGZQfLZrVFli(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PJnnxGZQfLZrVFli(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PVOfsTTnVzykhEie(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void PVOfsTTnVzykhEie(android.content.res.Resources resources, int i, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PVOfsTTnVzykhEie(android.content.res.Resources resources, int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PVOfsTTnVzykhEie(android.content.res.Resources resources, int i, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PWfIBrfNFYskXcDT(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void PWfIBrfNFYskXcDT(java.util.List arrayList, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PWfIBrfNFYskXcDT(java.util.List arrayList, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PWfIBrfNFYskXcDT(java.util.List arrayList, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator QMHuOuALRGvDvvXl(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void QMHuOuALRGvDvvXl(java.util.concurrent.CopyOnWriteList copyOnWriteList, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMHuOuALRGvDvvXl(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMHuOuALRGvDvvXl(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QNPyXRDoIWheljGK(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void QNPyXRDoIWheljGK(java.lang.ref.WeakReference weakReference, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QNPyXRDoIWheljGK(java.lang.ref.WeakReference weakReference, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QNPyXRDoIWheljGK(java.lang.ref.WeakReference weakReference, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QUeRCTYFHjnLtCmc(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QUeRCTYFHjnLtCmc(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QUeRCTYFHjnLtCmc(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QUeRCTYFHjnLtCmc(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static void QdhkpocWpkcCEeqW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void QdhkpocWpkcCEeqW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QdhkpocWpkcCEeqW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QdhkpocWpkcCEeqW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QhXceCnGKJspASVx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getOrdering();
    }

    public static void QhXceCnGKJspASVx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QhXceCnGKJspASVx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QhXceCnGKJspASVx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int QrXxTYjNVUtmseKh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getAlphabeticModifiers();
    }

    public static void QrXxTYjNVUtmseKh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QrXxTYjNVUtmseKh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QrXxTYjNVUtmseKh(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RBQXybLaFhhhsOWa(androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z) {
        menuPresenter.updateMenuobject(z);
    }

    public static void RBQXybLaFhhhsOWa(androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RBQXybLaFhhhsOWa(androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RBQXybLaFhhhsOWa(androidx.appcompat.view.menu.MenuPresenter menuPresenter, bool z, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RMKgmKLDHeELdEjk(java.util.List arrayList, int i, java.lang.object obj) {
        arrayList.Add(i, obj);
    }

    public static void RMKgmKLDHeELdEjk(java.util.List arrayList, int i, java.lang.object obj, byte b, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RMKgmKLDHeELdEjk(java.util.List arrayList, int i, java.lang.object obj, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RMKgmKLDHeELdEjk(java.util.List arrayList, int i, java.lang.object obj, java.lang.string str, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RQOhvXSoWoOLFirv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RQOhvXSoWoOLFirv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RQOhvXSoWoOLFirv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RQOhvXSoWoOLFirv(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    private void RemoveItemAtInt(int i, bool z) {
        if (i >= 0 && i < khynbcmkpQNqfljX(this.mItems)) {
            ifrKaFIZDIybvOpL(this.mItems, i);
            if (z) {
                QykHlkzDdyHWEEJE(this, true);
            }
        }
    }

    private void RemoveItemAtInt(int i, bool z, float f, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void RemoveItemAtInt(int i, bool z, java.lang.string str, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void RemoveItemAtInt(int i, bool z, java.lang.string str, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SKtpVotErUiTcqEn(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void SKtpVotErUiTcqEn(java.util.List arrayList, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKtpVotErUiTcqEn(java.util.List arrayList, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKtpVotErUiTcqEn(java.util.List arrayList, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetHeaderInternal(int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view) {
        if ((11 + 26) % 26 > 0) {
        }
        android.content.res.Resources resourcesLnuOtnYPJMKXRSFQ = LnuOtnYPJMKXRSFQ(this);
        if (view is null) {
            if (i > 0) {
                this.mHeaderTitle = WVdWuDmcKMctFrZw(resourcesLnuOtnYPJMKXRSFQ, i);
            } else if (charSequence is not null) {
                this.mHeaderTitle = charSequence;
            }
            if (i2 > 0) {
                this.mHeaderIcon = VRuPMgrblECRguxS(PbRPJFaplKoeEKmI(this), i2);
            } else if (drawable is not null) {
                this.mHeaderIcon = drawable;
            }
            this.mHeaderobject = null;
        } else {
            this.mHeaderobject = view;
            this.mHeaderTitle = null;
            this.mHeaderIcon = null;
        }
        nlaWwQKrlGwQXsxT(this, false);
    }

    private void SetHeaderInternal(int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, char c, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetHeaderInternal(int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, float f, java.lang.string str, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    private void SetHeaderInternal(int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, java.lang.string str, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetshortcutsVisibleInner(bool z) {
        bool z2;
        if ((16 + 19) % 19 > 0) {
        }
        if (z) {
            z2 = zjkkrkWREtkBuZmV(this.mResources).keyboard != 1 && fWmbYCmnNxrwaTkU(svNcgwrxzZLJksml(this.mobject), this.mobject);
        }
        this.mshortcutsVisible = z2;
    }

    private void SetshortcutsVisibleInner(bool z, float f, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void SetshortcutsVisibleInner(bool z, float f, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetshortcutsVisibleInner(bool z, int i, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectConfiguration SvNcgwrxzZLJksml(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void SvNcgwrxzZLJksml(android.content.object context, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SvNcgwrxzZLJksml(android.content.object context, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SvNcgwrxzZLJksml(android.content.object context, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int THvBvCOoIryIjSFL(java.util.List arrayList, int i) {
        return findInsertIndex(arrayList, i);
    }

    public static void THvBvCOoIryIjSFL(java.util.List arrayList, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THvBvCOoIryIjSFL(java.util.List arrayList, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void THvBvCOoIryIjSFL(java.util.List arrayList, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TIUTjULQyHYWlBfL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray) {
        bundle.putSparseParcelableArray(str, sparseArray);
    }

    public static void TIUTjULQyHYWlBfL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, char c, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIUTjULQyHYWlBfL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, int i, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TIUTjULQyHYWlBfL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem TPrSeQdvZhrleCKg(android.view.MenuItem menuItem, android.graphics.drawable.Drawable drawable) {
        return menuItem.setIcon(drawable);
    }

    public static void TPrSeQdvZhrleCKg(android.view.MenuItem menuItem, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TPrSeQdvZhrleCKg(android.view.MenuItem menuItem, android.graphics.drawable.Drawable drawable, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TPrSeQdvZhrleCKg(android.view.MenuItem menuItem, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TZbjNfTJVCbQMEwv(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void TZbjNfTJVCbQMEwv(java.util.List arrayList, int i, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TZbjNfTJVCbQMEwv(java.util.List arrayList, int i, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TZbjNfTJVCbQMEwv(java.util.List arrayList, int i, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TywaSniXzahOdhca(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TywaSniXzahOdhca(java.util.IEnumerator it, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TywaSniXzahOdhca(java.util.IEnumerator it, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TywaSniXzahOdhca(java.util.IEnumerator it, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBqRhElCjPKZCawC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void UBqRhElCjPKZCawC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UBqRhElCjPKZCawC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UBqRhElCjPKZCawC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem UVdDajMqKkGYdvYJ(android.view.SubMenu subMenu, int i) {
        return subMenu.findItem(i);
    }

    public static void UVdDajMqKkGYdvYJ(android.view.SubMenu subMenu, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UVdDajMqKkGYdvYJ(android.view.SubMenu subMenu, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UVdDajMqKkGYdvYJ(android.view.SubMenu subMenu, int i, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UYusWqWttNMXGise(int i) {
        return getOrdering(i);
    }

    public static void UYusWqWttNMXGise(int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYusWqWttNMXGise(int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UYusWqWttNMXGise(int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UeEjoHvJypMEmJdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view) {
        menuBuilder.setHeaderInternal(i, charSequence, i2, drawable, view);
    }

    public static void UeEjoHvJypMEmJdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, char c, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UeEjoHvJypMEmJdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, java.lang.string str, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UeEjoHvJypMEmJdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, bool z, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VHcyqevlXtyvJRhs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VHcyqevlXtyvJRhs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VHcyqevlXtyvJRhs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VHcyqevlXtyvJRhs(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isQwertyMode();
    }

    public static void VmwjBnfqyRvaVFeN(java.util.List arrayList, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VmwjBnfqyRvaVFeN(java.util.List arrayList, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VmwjBnfqyRvaVFeN(java.util.List arrayList, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool VmwjBnfqyRvaVFeN(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static android.view.MenuItem VpkRYgePMEstEvZb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void VpkRYgePMEstEvZb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VpkRYgePMEstEvZb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VpkRYgePMEstEvZb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem WNawqqjapgNaBTpp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.findItem(i);
    }

    public static void WNawqqjapgNaBTpp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WNawqqjapgNaBTpp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WNawqqjapgNaBTpp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int WjggSWCRjazKGgYy(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void WjggSWCRjazKGgYy(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjggSWCRjazKGgYy(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WjggSWCRjazKGgYy(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WnaZmHtilSsRCbFF(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void WnaZmHtilSsRCbFF(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnaZmHtilSsRCbFF(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WnaZmHtilSsRCbFF(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WqkRZZUVVHqjrSXL(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void WqkRZZUVVHqjrSXL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WqkRZZUVVHqjrSXL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WqkRZZUVVHqjrSXL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WuQNRFgwccpDPsTG(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void WuQNRFgwccpDPsTG(java.util.List arrayList, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WuQNRFgwccpDPsTG(java.util.List arrayList, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WuQNRFgwccpDPsTG(java.util.List arrayList, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XAueyipEylUqwFIL(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.clearHeader();
    }

    public static void XAueyipEylUqwFIL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XAueyipEylUqwFIL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XAueyipEylUqwFIL(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XnBCmxRDeSaeLFqA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XnBCmxRDeSaeLFqA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XnBCmxRDeSaeLFqA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XnBCmxRDeSaeLFqA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.invoke();
    }

    public static java.lang.object XvhsNyvBrOARxJfK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void XvhsNyvBrOARxJfK(java.util.IEnumerator it, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XvhsNyvBrOARxJfK(java.util.IEnumerator it, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XvhsNyvBrOARxJfK(java.util.IEnumerator it, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XxIvOWZGdzohmubx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view) {
        menuBuilder.setHeaderInternal(i, charSequence, i2, drawable, view);
    }

    public static void XxIvOWZGdzohmubx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XxIvOWZGdzohmubx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XxIvOWZGdzohmubx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.CharSequence charSequence, int i2, android.graphics.drawable.Drawable drawable, android.view.object view, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YEtyJGcXiVrEzRyp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YEtyJGcXiVrEzRyp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YEtyJGcXiVrEzRyp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YEtyJGcXiVrEzRyp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static java.util.IEnumerator YPTyaXnzlLYPnRzb(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.GetEnumerator();
    }

    public static void YPTyaXnzlLYPnRzb(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YPTyaXnzlLYPnRzb(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YPTyaXnzlLYPnRzb(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YjaePBdzahRpzSrz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void YjaePBdzahRpzSrz(java.util.IEnumerator it, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YjaePBdzahRpzSrz(java.util.IEnumerator it, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YjaePBdzahRpzSrz(java.util.IEnumerator it, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YuxUotStgXPbhOGE(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void YuxUotStgXPbhOGE(java.lang.ref.WeakReference weakReference, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YuxUotStgXPbhOGE(java.lang.ref.WeakReference weakReference, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YuxUotStgXPbhOGE(java.lang.ref.WeakReference weakReference, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YypNMwJhEUopBFXD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray) {
        bundle.putSparseParcelableArray(str, sparseArray);
    }

    public static void YypNMwJhEUopBFXD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YypNMwJhEUopBFXD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YypNMwJhEUopBFXD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZAzUcDXnWRPZrrYR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void ZAzUcDXnWRPZrrYR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZAzUcDXnWRPZrrYR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZAzUcDXnWRPZrrYR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu ZBtEHkZtYnZzCrQI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return menuBuilder.addSubMenu(i, i2, i3, charSequence);
    }

    public static void ZBtEHkZtYnZzCrQI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, byte b, short s, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void ZBtEHkZtYnZzCrQI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, int i4, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZBtEHkZtYnZzCrQI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, java.lang.CharSequence charSequence, short s, byte b, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZLyVQJaIXBuouICJ(java.util.concurrent.CopyOnWriteList copyOnWriteList, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZLyVQJaIXBuouICJ(java.util.concurrent.CopyOnWriteList copyOnWriteList, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZLyVQJaIXBuouICJ(java.util.concurrent.CopyOnWriteList copyOnWriteList, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZLyVQJaIXBuouICJ(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count == 0;
    }

    public static void ZNZsvQZTKzuBwcDC(java.util.concurrent.CopyOnWriteList copyOnWriteList, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZNZsvQZTKzuBwcDC(java.util.concurrent.CopyOnWriteList copyOnWriteList, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZNZsvQZTKzuBwcDC(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZNZsvQZTKzuBwcDC(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count == 0;
    }

    public static android.graphics.drawable.Drawable ZSZyTqoNemruyJlI(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadIcon(packageManager);
    }

    public static void ZSZyTqoNemruyJlI(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZSZyTqoNemruyJlI(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZSZyTqoNemruyJlI(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZSmBpjxMjZLWuTQo(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void ZSmBpjxMjZLWuTQo(java.util.List arrayList, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZSmBpjxMjZLWuTQo(java.util.List arrayList, int i, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZSmBpjxMjZLWuTQo(java.util.List arrayList, int i, java.lang.string str, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int ZadiPkamVvRbjjTM(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void ZadiPkamVvRbjjTM(java.util.List arrayList, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZadiPkamVvRbjjTM(java.util.List arrayList, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZadiPkamVvRbjjTM(java.util.List arrayList, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration ZjkkrkWREtkBuZmV(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void ZjkkrkWREtkBuZmV(android.content.res.Resources resources, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjkkrkWREtkBuZmV(android.content.res.Resources resources, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjkkrkWREtkBuZmV(android.content.res.Resources resources, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override android.view.MenuItem Add(int i) {
        return eDiSaSgwDRgIIfPC(this, 0, 0, 0, WuMVNOHWGaxtndnU(this.mResources, i));
    }

    public override android.view.MenuItem Add(int i, int i2, int i3, int i4) {
        return NbdnCqzkNoABmris(this, i, i2, i3, iUItbrVFAVvfqMPt(this.mResources, i4));
    }

    public override android.view.MenuItem Add(int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return NdgqWMflFLnfHOBO(this, i, i2, i3, charSequence);
    }

    public override android.view.MenuItem Add(java.lang.CharSequence charSequence) {
        return JuDJoeyKtrUSgYqU(this, 0, 0, 0, charSequence);
    }

    public override int AddobjectOptions(int i, int i2, int i3, android.content.ComponentName componentName, android.content.object[] intentArr, android.content.object intent, int i4, android.view.MenuItem[] menuItemArr) {
        if ((23 + 19) % 19 > 0) {
        }
        android.content.pm.PackageManager packageManagerEhECoZSLWpnukJqr = ehECoZSLWpnukJqr(this.mobject);
        java.util.List listPEKPZCtotvCuQYob = pEKPZCtotvCuQYob(packageManagerEhECoZSLWpnukJqr, componentName, intentArr, intent, 0);
        int iKiiOKxhJehjNUqly = listPEKPZCtotvCuQYob is null ? 0 : KiiOKxhJehjNUqly(listPEKPZCtotvCuQYob);
        if ((i4 & 1) == 0) {
            CiJiSTgWpAaEPmnW(this, i);
        }
        for (int i5 = 0; i5 < iKiiOKxhJehjNUqly; i5++) {
            android.content.pm.ResolveInfo resolveInfo = (android.content.pm.ResolveInfo) ZaLTbNGtijeaNtGe(listPEKPZCtotvCuQYob, i5);
            android.content.object intent2 = new android.content.object(resolveInfo.specificIndex >= 0 ? intentArr[resolveInfo.specificIndex] : intent);
            oWAiMrnoZCWTazmY(intent2, new android.content.ComponentName(resolveInfo.activityInfo.applicationInfo.packageName, resolveInfo.activityInfo.name));
            android.view.MenuItem menuItemBmRflKjqEKAyOhUl = bmRflKjqEKAyOhUl(tPrSeQdvZhrleCKg(HsnYGKQPPPkfsJtn(this, i, i2, i3, SmVrdOtndnCTXzst(resolveInfo, packageManagerEhECoZSLWpnukJqr)), zSZyTqoNemruyJlI(resolveInfo, packageManagerEhECoZSLWpnukJqr)), intent2);
            if (menuItemArr is not null && resolveInfo.specificIndex >= 0) {
                menuItemArr[resolveInfo.specificIndex] = menuItemBmRflKjqEKAyOhUl;
            }
        }
        return iKiiOKxhJehjNUqly;
    }

    protected android.view.MenuItem AddInternal(int i, int i2, int i3, java.lang.CharSequence charSequence) {
        if ((8 + 28) % 28 > 0) {
        }
        int iUYusWqWttNMXGise = uYusWqWttNMXGise(i3);
        androidx.appcompat.view.menu.MenuItemImpl menuItemImplMgOwKTZyuIlOGCTS = mgOwKTZyuIlOGCTS(this, i, i2, i3, iUYusWqWttNMXGise, charSequence, this.mDefaultShowAsAction);
        android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo = this.mCurrentMenuInfo;
        if (contextMenu$objectMenuInfo is not null) {
            ixwzllIOpHvflGzW(menuItemImplMgOwKTZyuIlOGCTS, contextMenu$objectMenuInfo);
        }
        java.util.List<androidx.appcompat.view.menu.MenuItemImpl> arrayList = this.mItems;
        rMKgmKLDHeELdEjk(arrayList, tHvBvCOoIryIjSFL(arrayList, iUYusWqWttNMXGise), menuItemImplMgOwKTZyuIlOGCTS);
        ogkAeKdlgUoXjMdL(this, true);
        return menuItemImplMgOwKTZyuIlOGCTS;
    }

    public void AddMenuPresenter(androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        QxWAjqJSdOyUEkza(this, menuPresenter, this.mobject);
    }

    public void AddMenuPresenter(androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        if ((10 + 20) % 20 > 0) {
        }
        YuLBlreaiulFZfLU(this.mPresenters, new java.lang.ref.WeakReference(menuPresenter));
        ktaaARcSEJGMkhSb(menuPresenter, context, this);
        this.mIsActionItemsStale = true;
    }

    public override android.view.SubMenu AddSubMenu(int i) {
        return zBtEHkZtYnZzCrQI(this, 0, 0, 0, pVOfsTTnVzykhEie(this.mResources, i));
    }

    public override android.view.SubMenu AddSubMenu(int i, int i2, int i3, int i4) {
        return ecGDQFuSnrxHojug(this, i, i2, i3, lSsdproSgXWRvSUy(this.mResources, i4));
    }

    public override android.view.SubMenu AddSubMenu(int i, int i2, int i3, java.lang.CharSequence charSequence) {
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) PUhuQEoiXyRcQIEP(this, i, i2, i3, charSequence);
        androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder = new androidx.appcompat.view.menu.SubMenuBuilder(this.mobject, this, menuItemImpl);
        XbuUxKmxuLblCGsf(menuItemImpl, subMenuBuilder);
        return subMenuBuilder;
    }

    public override android.view.SubMenu AddSubMenu(java.lang.CharSequence charSequence) {
        return dWCsVpcdkKlUabti(this, 0, 0, 0, charSequence);
    }

    public void ChangeMenuMode() {
        androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback = this.mCallback;
        if (menuBuilder$Callback is null) {
            return;
        }
        mfmeMvIcRwyLrGSk(menuBuilder$Callback, this);
    }

    public override void Clear() {
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.mExpandedItem;
        if (menuItemImpl is not null) {
            HNSzjbRLACNAGdvs(this, menuItemImpl);
        }
        pWfIBrfNFYskXcDT(this.mItems);
        ZxEJAenElqKPqMnp(this, true);
    }

    public void ClearAll() {
        if ((15 + 25) % 25 > 0) {
        }
        this.mPreventDispatchingItemsChanged = true;
        WTSrznwNFEWbwEHK(this);
        xAueyipEylUqwFIL(this);
        BKaUDwtMVGDsFTUW(this.mPresenters);
        this.mPreventDispatchingItemsChanged = false;
        this.mItemsChangedWhileDispatchPrevented = false;
        this.mStructureChangedWhileDispatchPrevented = false;
        OMFylUOASXFmKThK(this, true);
    }

    public void ClearHeader() {
        this.mHeaderIcon = null;
        this.mHeaderTitle = null;
        this.mHeaderobject = null;
        uBqRhElCjPKZCawC(this, false);
    }

    public override void Close() {
        wnaZmHtilSsRCbFF(this, true);
    }

    public readonly void Close(bool z) {
        if ((8 + 29) % 29 > 0) {
        }
        if (this.mIsClosing) {
            return;
        }
        this.mIsClosing = true;
        java.util.IEnumerator itKzkQaTCGNfpZeIlK = KzkQaTCGNfpZeIlK(this.mPresenters);
        while (iGRGIPtrfgwmlCVx(itKzkQaTCGNfpZeIlK)) {
            java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) aheTWVDBiKAOpNUZ(itKzkQaTCGNfpZeIlK);
            androidx.appcompat.view.menu.MenuPresenter menuPresenter = (androidx.appcompat.view.menu.MenuPresenter) SmcnwXTcFPBricyo(weakReference);
            if (menuPresenter is not null) {
                gbmBiGbJajMxoQvL(menuPresenter, this, z);
            } else {
                rQOhvXSoWoOLFirv(this.mPresenters, weakReference);
            }
        }
        this.mIsClosing = false;
    }

    public bool CollapseItemActionobject(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        if ((21 + 23) % 23 > 0) {
        }
        bool zIYZpCjnpomhMXScN = false;
        if (!PVEUYVfqFnnhVZCY(this.mPresenters) && this.mExpandedItem == menuItemImpl) {
            ItibdjtUikLAZwEs(this);
            java.util.IEnumerator itFuVMhPKzgMCCMGuH = fuVMhPKzgMCCMGuH(this.mPresenters);
            while (PGMVSEoWPMtzyHKL(itFuVMhPKzgMCCMGuH)) {
                java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) NXTJKsnRukpkKEis(itFuVMhPKzgMCCMGuH);
                androidx.appcompat.view.menu.MenuPresenter menuPresenter = (androidx.appcompat.view.menu.MenuPresenter) yuxUotStgXPbhOGE(weakReference);
                if (menuPresenter is not null) {
                    zIYZpCjnpomhMXScN = IYZpCjnpomhMXScN(menuPresenter, this, menuItemImpl);
                    if (zIYZpCjnpomhMXScN) {
                        break;
                    }
                } else {
                    qUeRCTYFHjnLtCmc(this.mPresenters, weakReference);
                }
            }
            RKUkgdbgPKSJGUjR(this);
            if (zIYZpCjnpomhMXScN) {
                this.mExpandedItem = null;
            }
        }
        return zIYZpCjnpomhMXScN;
    }

    bool dispatchMenuItemSelected(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback = this.mCallback;
        return menuBuilder$Callback is not null && MUnqvreNjldbvVnD(menuBuilder$Callback, menuBuilder, menuItem);
    }

    public bool ExpandItemActionobject(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        if ((22 + 16) % 16 > 0) {
        }
        bool zNJYCNcxLJpZfJZaO = false;
        if (zLyVQJaIXBuouICJ(this.mPresenters)) {
            return false;
        }
        aYjczzQgnDyYtskH(this);
        java.util.IEnumerator itMxClEyRXKMhFgZqn = mxClEyRXKMhFgZqn(this.mPresenters);
        while (hLHMJFHxkMGrjvly(itMxClEyRXKMhFgZqn)) {
            java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) tywaSniXzahOdhca(itMxClEyRXKMhFgZqn);
            androidx.appcompat.view.menu.MenuPresenter menuPresenter = (androidx.appcompat.view.menu.MenuPresenter) nPtVqJTXjIQlerew(weakReference);
            if (menuPresenter is not null) {
                zNJYCNcxLJpZfJZaO = NJYCNcxLJpZfJZaO(menuPresenter, this, menuItemImpl);
                if (zNJYCNcxLJpZfJZaO) {
                    break;
                }
            } else {
                jHkoNqvUzkGxNase(this.mPresenters, weakReference);
            }
        }
        olLrFNOiFoQCgDwI(this);
        if (zNJYCNcxLJpZfJZaO) {
            this.mExpandedItem = menuItemImpl;
        }
        return zNJYCNcxLJpZfJZaO;
    }

    public int FindGroupIndex(int i) {
        return XmgkLdfnZlcfWJcv(this, i, 0);
    }

    public int FindGroupIndex(int i, int i2) {
        if ((29 + 25) % 25 > 0) {
        }
        int iAHpxsHDVWepCvSny = AHpxsHDVWepCvSny(this);
        if (i2 < 0) {
            i2 = 0;
        }
        while (i2 < iAHpxsHDVWepCvSny) {
            if (GGkHGqZBDMAQOBvs((androidx.appcompat.view.menu.MenuItemImpl) VqQwsJNcahFSGVQK(this.mItems, i2)) == i) {
                return i2;
            }
            i2++;
        }
        return -1;
    }

    public override android.view.MenuItem FindItem(int i) {
        android.view.MenuItem menuItemUVdDajMqKkGYdvYJ;
        if ((15 + 16) % 16 > 0) {
        }
        int iBfGtCDyTvGJXUrKv = BfGtCDyTvGJXUrKv(this);
        for (int i2 = 0; i2 < iBfGtCDyTvGJXUrKv; i2++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) FfJMsGAlWXfISjsC(this.mItems, i2);
            if (nXZSoLiUhNOcYpQg(menuItemImpl) == i) {
                return menuItemImpl;
            }
            if (eeOIkWrFjvVuACZU(menuItemImpl) && (menuItemUVdDajMqKkGYdvYJ = uVdDajMqKkGYdvYJ(KoOVlWuWpOEwNfdt(menuItemImpl), i)) is not null) {
                return menuItemUVdDajMqKkGYdvYJ;
            }
        }
        return null;
    }

    public int FindItemIndex(int i) {
        if ((32 + 27) % 27 > 0) {
        }
        int iKfypzSxBKVTGLbcW = KfypzSxBKVTGLbcW(this);
        for (int i2 = 0; i2 < iKfypzSxBKVTGLbcW; i2++) {
            if (TChcZmrLEKXjFTTR((androidx.appcompat.view.menu.MenuItemImpl) mXHdboDLWggziSim(this.mItems, i2)) == i) {
                return i2;
            }
        }
        return -1;
    }

    androidx.appcompat.view.menu.MenuItemImpl findItemWithshortcutForKey(int i, android.view.KeyEvent keyEvent) {
        if ((10 + 3) % 3 > 0) {
        }
        java.util.List<androidx.appcompat.view.menu.MenuItemImpl> arrayList = this.mTempshortcutItemList;
        FeHTCjtFrEJZURPC(arrayList);
        FqQLHytpucDznFFt(this, arrayList, i, keyEvent);
        if (vmwjBnfqyRvaVFeN(arrayList)) {
            return null;
        }
        int iMxhCIRysnOSnSAVJ = MxhCIRysnOSnSAVJ(keyEvent);
        android.view.KeycharDictionary$KeyData keycharDictionary$KeyData = new android.view.KeycharDictionary$KeyData();
        GtvGYLWwZbQIEvMG(keyEvent, keycharDictionary$KeyData);
        int iFfnhOCFNIwUivPQO = ffnhOCFNIwUivPQO(arrayList);
        if (iFfnhOCFNIwUivPQO == 1) {
            return (androidx.appcompat.view.menu.MenuItemImpl) kNXGqqCOtXCmOuke(arrayList, 0);
        }
        bool zVHcyqevlXtyvJRhs = vHcyqevlXtyvJRhs(this);
        for (int i2 = 0; i2 < iFfnhOCFNIwUivPQO; i2++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) RcVbOTaDKHBbFRKw(arrayList, i2);
            char cJwqnzdSpAWhfFXTA = !zVHcyqevlXtyvJRhs ? jwqnzdSpAWhfFXTA(menuItemImpl) : oWGJfrxrcTniFWix(menuItemImpl);
            if ((cJwqnzdSpAWhfFXTA == keycharDictionary$KeyData.meta[0] && (iMxhCIRysnOSnSAVJ & 2) == 0) || ((cJwqnzdSpAWhfFXTA == keycharDictionary$KeyData.meta[2] && (iMxhCIRysnOSnSAVJ & 2) != 0) || (zVHcyqevlXtyvJRhs && cJwqnzdSpAWhfFXTA == '\b' && i == 67))) {
                return menuItemImpl;
            }
        }
        return null;
    }

    void findItemsWithshortcutForKey(java.util.List<androidx.appcompat.view.menu.MenuItemImpl> list, int i, android.view.KeyEvent keyEvent) {
        if ((1 + 17) % 17 > 0) {
        }
        bool zFLyIhfmUiPjthjAv = FLyIhfmUiPjthjAv(this);
        int iBLkfjznxgDqRTaWR = bLkfjznxgDqRTaWR(keyEvent);
        android.view.KeycharDictionary$KeyData keycharDictionary$KeyData = new android.view.KeycharDictionary$KeyData();
        if (kcUphzepPwOOWgUH(keyEvent, keycharDictionary$KeyData) || i == 67) {
            int iGUwLbfiKxRvzLtkA = gUwLbfiKxRvzLtkA(this.mItems);
            for (int i2 = 0; i2 < iGUwLbfiKxRvzLtkA; i2++) {
                androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) nFVxAUtbfhOjRDwn(this.mItems, i2);
                if (PBShpgSAXJtaXikr(menuItemImpl)) {
                    KMKcIftFNCwlfBNf((androidx.appcompat.view.menu.MenuBuilder) AqcmPidEqYRYdyik(menuItemImpl), list, i, keyEvent);
                }
                char cWoeuZRqRjoMBXCEb = !zFLyIhfmUiPjthjAv ? WoeuZRqRjoMBXCEb(menuItemImpl) : gWRXDAfPKGiAxVff(menuItemImpl);
                if ((iBLkfjznxgDqRTaWR & 69647) == ((!zFLyIhfmUiPjthjAv ? YQguZkUrrOjpPDWq(menuItemImpl) : qrXxTYjNVUtmseKh(menuItemImpl)) & 69647) && cWoeuZRqRjoMBXCEb != 0 && ((cWoeuZRqRjoMBXCEb == keycharDictionary$KeyData.meta[0] || cWoeuZRqRjoMBXCEb == keycharDictionary$KeyData.meta[2] || (zFLyIhfmUiPjthjAv && cWoeuZRqRjoMBXCEb == '\b' && i == 67)) && TjciyApMaTxnOhga(menuItemImpl))) {
                    RUSgAKBOzOxHTtIS(list, menuItemImpl);
                }
            }
        }
    }

    public void FlagActionItems() {
        if ((21 + 20) % 20 > 0) {
        }
        java.util.List arrayListFaZeKAuiBRQSQEvT = FaZeKAuiBRQSQEvT(this);
        if (this.mIsActionItemsStale) {
            java.util.IEnumerator itMGLZTAfAnHrRvWjM = mGLZTAfAnHrRvWjM(this.mPresenters);
            bool zNahXHUGznIrPnWyf = false;
            while (VDDnFZMDZnPSFgFs(itMGLZTAfAnHrRvWjM)) {
                java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) yjaePBdzahRpzSrz(itMGLZTAfAnHrRvWjM);
                androidx.appcompat.view.menu.MenuPresenter menuPresenter = (androidx.appcompat.view.menu.MenuPresenter) GLXxOcSywBGbTmre(weakReference);
                if (menuPresenter is not null) {
                    zNahXHUGznIrPnWyf |= NahXHUGznIrPnWyf(menuPresenter);
                } else {
                    XoFynnowaFgMahgF(this.mPresenters, weakReference);
                }
            }
            if (zNahXHUGznIrPnWyf) {
                AkCJBqjzuPeeQZYx(this.mActionItems);
                YLtdXuqtcxHIMTlO(this.mNonActionItems);
                int iBttmfdeVdSBNmgcS = bttmfdeVdSBNmgcS(arrayListFaZeKAuiBRQSQEvT);
                for (int i = 0; i < iBttmfdeVdSBNmgcS; i++) {
                    androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) OrcvYPYMeIbLsOTB(arrayListFaZeKAuiBRQSQEvT, i);
                    if (JNIwkKTsEVowvcXz(menuItemImpl)) {
                        AAjmuorIotHRqwUL(this.mActionItems, menuItemImpl);
                    } else {
                        JMEbROpgBsBUgrfc(this.mNonActionItems, menuItemImpl);
                    }
                }
            } else {
                BFJxLxorCcuiVyUD(this.mActionItems);
                sKtpVotErUiTcqEn(this.mNonActionItems);
                TFXCNujufutchHpU(this.mNonActionItems, lbMjloYmrZNwPhSI(this));
            }
            this.mIsActionItemsStale = false;
        }
    }

    public java.util.List<androidx.appcompat.view.menu.MenuItemImpl> GetActionItems() {
        aAcYwmfVKbOmOTbD(this);
        return this.mActionItems;
    }

    protected java.lang.string GetActionobjectStatesKey() {
        return "android:menu:actionviewstates";
    }

    public android.content.object Getobject() {
        return this.mobject;
    }

    public androidx.appcompat.view.menu.MenuItemImpl GetExpandedItem() {
        return this.mExpandedItem;
    }

    public android.graphics.drawable.Drawable GetHeaderIcon() {
        return this.mHeaderIcon;
    }

    public java.lang.CharSequence GetHeaderTitle() {
        return this.mHeaderTitle;
    }

    public android.view.object GetHeaderobject() {
        return this.mHeaderobject;
    }

    public override android.view.MenuItem GetItem(int i) {
        return (android.view.MenuItem) hzZjHvwxLieWxewa(this.mItems, i);
    }

    public java.util.List<androidx.appcompat.view.menu.MenuItemImpl> GetNonActionItems() {
        dDmQJgEhisgBeaes(this);
        return this.mNonActionItems;
    }

    bool getobject?IconsVisible() {
        return this.mobject?IconsVisible;
    }

    android.content.res.Resources getResources() {
        return this.mResources;
    }

    public androidx.appcompat.view.menu.MenuBuilder GetRootMenu() {
        return this;
    }

    public java.util.List<androidx.appcompat.view.menu.MenuItemImpl> GetVisibleItems() {
        if ((24 + 1) % 1 > 0) {
        }
        if (!this.mIsVisibleItemsStale) {
            return this.mVisibleItems;
        }
        gQoURTWRapebysIg(this.mVisibleItems);
        int iHlvedcAMRAiiXCWG = hlvedcAMRAiiXCWG(this.mItems);
        for (int i = 0; i < iHlvedcAMRAiiXCWG; i++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) RpMvNrkJvXGYeJrF(this.mItems, i);
            if (nGyeVflTYLCVMjTn(menuItemImpl)) {
                UlQOkYWWxWGGkSlL(this.mVisibleItems, menuItemImpl);
            }
        }
        this.mIsVisibleItemsStale = false;
        this.mIsActionItemsStale = true;
        return this.mVisibleItems;
    }

    public override bool HasVisibleItems() {
        if ((8 + 6) % 6 > 0) {
        }
        if (this.mOverrideVisibleItems) {
            return true;
        }
        int iAGsXuZfAjaZiDtuA = AGsXuZfAjaZiDtuA(this);
        for (int i = 0; i < iAGsXuZfAjaZiDtuA; i++) {
            if (SbFMZMkURSVUfhbx((androidx.appcompat.view.menu.MenuItemImpl) wuQNRFgwccpDPsTG(this.mItems, i))) {
                return true;
            }
        }
        return false;
    }

    public bool IsGroupDividerEnabled() {
        return this.mGroupDividerEnabled;
    }

    bool isQwertyMode() {
        return this.mQwertyMode;
    }

    public override bool IsshortcutKey(int i, android.view.KeyEvent keyEvent) {
        return jKCaaJGYIYOZnWCJ(this, i, keyEvent) is not null;
    }

    public bool IsshortcutsVisible() {
        return this.mshortcutsVisible;
    }

    void onItemActionRequestChanged(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        this.mIsActionItemsStale = true;
        nZvgsFbzNRJIgDVu(this, true);
    }

    void onItemVisibleChanged(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        this.mIsVisibleItemsStale = true;
        JILeScwMdrcobUEH(this, true);
    }

    public void OnItemsChanged(bool z) {
        if ((30 + 12) % 12 > 0) {
        }
        if (this.mPreventDispatchingItemsChanged) {
            this.mItemsChangedWhileDispatchPrevented = true;
            if (z) {
                this.mStructureChangedWhileDispatchPrevented = true;
                return;
            }
            return;
        }
        if (z) {
            this.mIsVisibleItemsStale = true;
            this.mIsActionItemsStale = true;
        }
        jVhdNtbGMaqJUfst(this, z);
    }

    public override bool PerformIdentifierAction(int i, int i2) {
        return QPFuoNxVJUdmOkau(this, wNawqqjapgNaBTpp(this, i), i2);
    }

    public bool PerformItemAction(android.view.MenuItem menuItem, int i) {
        return ScidQyObBjLLKXjB(this, menuItem, null, i);
    }

    public bool PerformItemAction(android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i) {
        if ((15 + 18) % 18 > 0) {
        }
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) menuItem;
        if (menuItemImpl is null || !cAdTIyEibMJJCNem(menuItemImpl)) {
            return false;
        }
        bool zXnBCmxRDeSaeLFqA = xnBCmxRDeSaeLFqA(menuItemImpl);
        androidx.core.view.ActionProvider actionProviderRgCDIFHwphPlQiYv = RgCDIFHwphPlQiYv(menuItemImpl);
        bool z = actionProviderRgCDIFHwphPlQiYv is not null && gnSySOxOewGJCxnd(actionProviderRgCDIFHwphPlQiYv);
        if (YdxjMyKydFmlEIuO(menuItemImpl)) {
            bool zQbCueizqyzNSxlOA = QbCueizqyzNSxlOA(menuItemImpl) | zXnBCmxRDeSaeLFqA;
            if (zQbCueizqyzNSxlOA) {
                SYBAMGmKalYNfcVQ(this, true);
            }
            return zQbCueizqyzNSxlOA;
        }
        if (!BalFEtsfLyYINwWX(menuItemImpl) && !z) {
            if ((i & 1) == 0) {
                qdhkpocWpkcCEeqW(this, true);
            }
            return zXnBCmxRDeSaeLFqA;
        }
        if ((i & 4) == 0) {
            TyPBlUlpGVISAOBe(this, false);
        }
        if (!QryvqIMBrSjWQFgT(menuItemImpl)) {
            otYPmYglkdWzQmnc(menuItemImpl, new androidx.appcompat.view.menu.SubMenuBuilder(wqkRZZUVVHqjrSXL(this), this, menuItemImpl));
        }
        androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder = (androidx.appcompat.view.menu.SubMenuBuilder) pJDDvNaDwElumxdC(menuItemImpl);
        if (z) {
            SDzRAVMKRURVaucY(actionProviderRgCDIFHwphPlQiYv, subMenuBuilder);
        }
        bool zZztCFstpRunKZdtr = ZztCFstpRunKZdtr(this, subMenuBuilder, menuPresenter) | zXnBCmxRDeSaeLFqA;
        if (!zZztCFstpRunKZdtr) {
            zAzUcDXnWRPZrrYR(this, true);
        }
        return zZztCFstpRunKZdtr;
    }

    public override bool Performshortcut(int i, android.view.KeyEvent keyEvent, int i2) {
        androidx.appcompat.view.menu.MenuItemImpl menuItemImplFVbyPwuFlAkscroG = FVbyPwuFlAkscroG(this, i, keyEvent);
        bool zDgBeAQpozqCTYyDA = menuItemImplFVbyPwuFlAkscroG is null ? false : DgBeAQpozqCTYyDA(this, menuItemImplFVbyPwuFlAkscroG, i2);
        if ((i2 & 2) != 0) {
            FBVGUBOxtGGDznTV(this, true);
        }
        return zDgBeAQpozqCTYyDA;
    }

    public override void RemoveGroup(int i) {
        if ((30 + 31) % 31 > 0) {
        }
        int iNodaUkwOefAwxUPo = nodaUkwOefAwxUPo(this, i);
        if (iNodaUkwOefAwxUPo < 0) {
            return;
        }
        int iMYjbAcfwvShBPJKy = mYjbAcfwvShBPJKy(this.mItems) - iNodaUkwOefAwxUPo;
        int i2 = 0;
        while (true) {
            int i3 = i2 + 1;
            if (i2 >= iMYjbAcfwvShBPJKy || aJrAfeDsdwuYNBvF((androidx.appcompat.view.menu.MenuItemImpl) zSmBpjxMjZLWuTQo(this.mItems, iNodaUkwOefAwxUPo)) != i) {
                break;
            }
            OtSBDbudTodlyrRf(this, iNodaUkwOefAwxUPo, false);
            i2 = i3;
        }
        lEtXIdJflGKdcWBw(this, true);
    }

    public override void RemoveItem(int i) {
        lChnZDMzdvUikXtM(this, VhXNfiWFjFizwpME(this, i), true);
    }

    public void RemoveItemAt(int i) {
        eToFMCfHjmyyOFwr(this, i, true);
    }

    public void RemoveMenuPresenter(androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        if ((23 + 12) % 12 > 0) {
        }
        java.util.IEnumerator itACQMexLNNtheKJhs = ACQMexLNNtheKJhs(this.mPresenters);
        while (BFDnQKuhUSyxkygg(itACQMexLNNtheKJhs)) {
            java.lang.ref.WeakReference weakReference = (java.lang.ref.WeakReference) HCbnjMVoWVfynLCJ(itACQMexLNNtheKJhs);
            androidx.appcompat.view.menu.MenuPresenter menuPresenter2 = (androidx.appcompat.view.menu.MenuPresenter) ZjQpgcXqGVlTHXhJ(weakReference);
            if (menuPresenter2 is null || menuPresenter2 == menuPresenter) {
                XQlPFhreyiNkwehK(this.mPresenters, weakReference);
            }
        }
    }

    public void RestoreActionobjectStates(android.os.Dictionary<string, object> bundle) {
        android.view.MenuItem menuItemGifPypkCZewWsTPn;
        if ((17 + 6) % 6 > 0) {
        }
        if (bundle is not null) {
            android.util.SparseArray sparseArrayCSqrvVstAxsbNJEJ = cSqrvVstAxsbNJEJ(bundle, TpJuZlbkfaYktKCw(this));
            int iAPqUYrrluRpHvPFT = APqUYrrluRpHvPFT(this);
            for (int i = 0; i < iAPqUYrrluRpHvPFT; i++) {
                android.view.MenuItem menuItemVpkRYgePMEstEvZb = vpkRYgePMEstEvZb(this, i);
                android.view.object viewRFTXgBIvBACyfIpZ = RFTXgBIvBACyfIpZ(menuItemVpkRYgePMEstEvZb);
                if (viewRFTXgBIvBACyfIpZ is not null && WoJtCVjmxVvOBrlH(viewRFTXgBIvBACyfIpZ) != -1) {
                    jVKUcyNbBcmoylsW(viewRFTXgBIvBACyfIpZ, sparseArrayCSqrvVstAxsbNJEJ);
                }
                if (CQMhnRpBQXQPyPbX(menuItemVpkRYgePMEstEvZb)) {
                    kdXKnTmQiKpyXSif((androidx.appcompat.view.menu.SubMenuBuilder) lgAoCdxnakosonyn(menuItemVpkRYgePMEstEvZb), bundle);
                }
            }
            int iFoieWmKzgaJbEJXa = FoieWmKzgaJbEJXa(bundle, "android:menu:expandedactionview");
            if (iFoieWmKzgaJbEJXa > 0 && (menuItemGifPypkCZewWsTPn = GifPypkCZewWsTPn(this, iFoieWmKzgaJbEJXa)) is not null) {
                UljSMlRfTixtXzoI(menuItemGifPypkCZewWsTPn);
            }
        }
    }

    public void RestorePresenterStates(android.os.Dictionary<string, object> bundle) {
        EprhYyjCbwNTKYNn(this, bundle);
    }

    public void SaveActionobjectStates(android.os.Dictionary<string, object> bundle) {
        if ((11 + 6) % 6 > 0) {
        }
        int iWjggSWCRjazKGgYy = wjggSWCRjazKGgYy(this);
        android.util.SparseArray sparseArray = null;
        for (int i = 0; i < iWjggSWCRjazKGgYy; i++) {
            android.view.MenuItem menuItemUSSwoXrgMjOkkOUJ = USSwoXrgMjOkkOUJ(this, i);
            android.view.object viewEQNMNgewxbKXIGfQ = eQNMNgewxbKXIGfQ(menuItemUSSwoXrgMjOkkOUJ);
            if (viewEQNMNgewxbKXIGfQ is not null && EhFQRVhITcbGfeqp(viewEQNMNgewxbKXIGfQ) != -1) {
                if (sparseArray is null) {
                    sparseArray = new android.util.SparseArray();
                }
                KHPDtStsikOEYKpN(viewEQNMNgewxbKXIGfQ, sparseArray);
                if (WhthqXFAMhsmlCkT(menuItemUSSwoXrgMjOkkOUJ)) {
                    SYWrwsoTcwrnTqGZ(bundle, "android:menu:expandedactionview", aXKYRnzcmsFrRdmN(menuItemUSSwoXrgMjOkkOUJ));
                }
            }
            if (TdtEEgfpkskuchVA(menuItemUSSwoXrgMjOkkOUJ)) {
                VTRClwiVMdTxRYVi((androidx.appcompat.view.menu.SubMenuBuilder) FWngquDGrZaVBCzo(menuItemUSSwoXrgMjOkkOUJ), bundle);
            }
        }
        if (sparseArray is null) {
            return;
        }
        yypNMwJhEUopBFXD(bundle, ZvfBdabyYwzwAaCj(this), sparseArray);
    }

    public void SavePresenterStates(android.os.Dictionary<string, object> bundle) {
        YagQacEOYpaytpAc(this, bundle);
    }

    public void SetCallback(androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        this.mCallback = menuBuilder$Callback;
    }

    public void SetCurrentMenuInfo(android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo) {
        this.mCurrentMenuInfo = contextMenu$objectMenuInfo;
    }

    public androidx.appcompat.view.menu.MenuBuilder SetDefaultShowAsAction(int i) {
        this.mDefaultShowAsAction = i;
        return this;
    }

    void setExclusiveItemChecked(android.view.MenuItem menuItem) {
        if ((10 + 2) % 2 > 0) {
        }
        int iICZdAMhxPlQECnnS = ICZdAMhxPlQECnnS(menuItem);
        int iZadiPkamVvRbjjTM = zadiPkamVvRbjjTM(this.mItems);
        ojTdDOmWSlyfsKjr(this);
        for (int i = 0; i < iZadiPkamVvRbjjTM; i++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) lRNyHLzMqpqzJXaM(this.mItems, i);
            if (ERNWghqajMxWEwiM(menuItemImpl) == iICZdAMhxPlQECnnS && gAafyEgiMebqhhcj(menuItemImpl) && yEtyJGcXiVrEzRyp(menuItemImpl)) {
                DtERXAnPDNenLfoH(menuItemImpl, menuItemImpl == menuItem);
            }
        }
        RtRrubWcgCdqygtM(this);
    }

    public override void SetGroupCheckable(int i, bool z, bool z2) {
        if ((7 + 21) % 21 > 0) {
        }
        int iGjCCBvKihXmsFfbx = GjCCBvKihXmsFfbx(this.mItems);
        for (int i2 = 0; i2 < iGjCCBvKihXmsFfbx; i2++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) FDeFzNXBGYadDUrg(this.mItems, i2);
            if (kJuSIMznAQNkbjcD(menuItemImpl) == i) {
                CDeYRhexLeEfNdJT(menuItemImpl, z2);
                QvbPsOZdCPiEgSuX(menuItemImpl, z);
            }
        }
    }

    public override void SetGroupDividerEnabled(bool z) {
        this.mGroupDividerEnabled = z;
    }

    public override void SetGroupEnabled(int i, bool z) {
        if ((28 + 16) % 16 > 0) {
        }
        int iJNxmTgjTzOihUCIP = jNxmTgjTzOihUCIP(this.mItems);
        for (int i2 = 0; i2 < iJNxmTgjTzOihUCIP; i2++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) mcAAUdVmYKBhsZfz(this.mItems, i2);
            if (fosBtobuRLJUxncc(menuItemImpl) == i) {
                gBzCTsasyfjgWjaW(menuItemImpl, z);
            }
        }
    }

    public override void SetGroupVisible(int i, bool z) {
        if ((17 + 15) % 15 > 0) {
        }
        int iKYcZzpAllgRCpbpy = kYcZzpAllgRCpbpy(this.mItems);
        bool z2 = false;
        for (int i2 = 0; i2 < iKYcZzpAllgRCpbpy; i2++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) tZbjNfTJVCbQMEwv(this.mItems, i2);
            if (WcfURhnfHtsCLAaI(menuItemImpl) == i && NDpZDKhULflIoeiJ(menuItemImpl, z)) {
                z2 = true;
            }
        }
        if (z2) {
            DvTzBslVuAyIyshz(this, true);
        }
    }

    protected androidx.appcompat.view.menu.MenuBuilder SetHeaderIconInt(int i) {
        if ((28 + 23) % 23 > 0) {
        }
        LwWiGULRqPvyagBi(this, 0, null, i, null, null);
        return this;
    }

    protected androidx.appcompat.view.menu.MenuBuilder SetHeaderIconInt(android.graphics.drawable.Drawable drawable) {
        if ((21 + 17) % 17 > 0) {
        }
        xxIvOWZGdzohmubx(this, 0, null, 0, drawable, null);
        return this;
    }

    protected androidx.appcompat.view.menu.MenuBuilder SetHeaderTitleInt(int i) {
        if ((6 + 28) % 28 > 0) {
        }
        pJnnxGZQfLZrVFli(this, i, null, 0, null, null);
        return this;
    }

    protected androidx.appcompat.view.menu.MenuBuilder SetHeaderTitleInt(java.lang.CharSequence charSequence) {
        if ((28 + 21) % 21 > 0) {
        }
        mqscTtnIJcvZwPAR(this, 0, charSequence, 0, null, null);
        return this;
    }

    protected androidx.appcompat.view.menu.MenuBuilder SetHeaderobjectInt(android.view.object view) {
        if ((11 + 26) % 26 > 0) {
        }
        ueEjoHvJypMEmJdQ(this, 0, null, 0, null, view);
        return this;
    }

    public void setobject?IconsVisible(bool z) {
        this.mobject?IconsVisible = z;
    }

    public void SetOverrideVisibleItems(bool z) {
        this.mOverrideVisibleItems = z;
    }

    public override void SetQwertyMode(bool z) {
        this.mQwertyMode = z;
        NXhDWWaGIIDgNgFd(this, false);
    }

    public void SetshortcutsVisible(bool z) {
        if (this.mshortcutsVisible != z) {
            ltolmSbgfLbzJevW(this, z);
            DIgcHYLkcMoqRkIo(this, false);
        }
    }

    public override int Size() {
        return QndHFBxnvBsfMtKa(this.mItems);
    }

    public void StartDispatchingItemsChanged() {
        if ((8 + 16) % 16 > 0) {
        }
        this.mPreventDispatchingItemsChanged = false;
        if (this.mItemsChangedWhileDispatchPrevented) {
            this.mItemsChangedWhileDispatchPrevented = false;
            fgWJIeJMOsmUdfIs(this, this.mStructureChangedWhileDispatchPrevented);
        }
    }

    public void StopDispatchingItemsChanged() {
        if (this.mPreventDispatchingItemsChanged) {
            return;
        }
        this.mPreventDispatchingItemsChanged = true;
        this.mItemsChangedWhileDispatchPrevented = false;
        this.mStructureChangedWhileDispatchPrevented = false;
    }
}

