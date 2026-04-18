namespace WillowMaze.Wasm.Decompiled;


public class ListMenuPresenter : androidx.appcompat.view.menu.MenuPresenter, android.widget.Adapterobject$OnItemClickListener {
    private static readonly java.lang.string TAG = "ListMenuPresenter";
    public static readonly java.lang.string VIEWS_TAG = "android:menu:list";
    androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter mAdapter;
    private androidx.appcompat.view.menu.MenuPresenter$Callback mCallback;
    android.content.object mobject;
    private int mId;
    android.view.LayoutInflater mInflater;
    int mItemIndexOffset;
    int mItemLayoutRes;
    androidx.appcompat.view.menu.MenuBuilder mMenu;
    androidx.appcompat.view.menu.ExpandedMenuobject mMenuobject;
    int mThemeRes;

    public ListMenuPresenter(int i, int i2) {
        this.mItemLayoutRes = i;
        this.mThemeRes = i2;
    }

    public ListMenuPresenter(android.content.object context, int i) {
        this(i, 0);
        this.mobject = context;
        this.mInflater = FfGzQycVvmkSDBoL(context);
    }

    public static void BGJcVFUNBhXcpMRQ(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BGJcVFUNBhXcpMRQ(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BGJcVFUNBhXcpMRQ(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool BGJcVFUNBhXcpMRQ(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.hasVisibleItems();
    }

    public static void ClNHnduKxteukbap(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ClNHnduKxteukbap(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ClNHnduKxteukbap(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ClNHnduKxteukbap(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, androidx.appcompat.view.menu.MenuPresenter menuPresenter, int i) {
        return menuBuilder.performItemAction(menuItem, menuPresenter, i);
    }

    public static void DnxGNgPAStKBouJU(android.view.object view, android.util.SparseArray sparseArray) {
        view.restoreHierarchyState(sparseArray);
    }

    public static void DnxGNgPAStKBouJU(android.view.object view, android.util.SparseArray sparseArray, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DnxGNgPAStKBouJU(android.view.object view, android.util.SparseArray sparseArray, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DnxGNgPAStKBouJU(android.view.object view, android.util.SparseArray sparseArray, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DrbZBkhcAtuucGoV(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle) {
        listMenuPresenter.saveHierarchyState(bundle);
    }

    public static void DrbZBkhcAtuucGoV(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DrbZBkhcAtuucGoV(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DrbZBkhcAtuucGoV(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater FfGzQycVvmkSDBoL(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void FfGzQycVvmkSDBoL(android.content.object context, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FfGzQycVvmkSDBoL(android.content.object context, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FfGzQycVvmkSDBoL(android.content.object context, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LwlhgzVMorLtLxRq(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, bool z) {
        listMenuPresenter.updateMenuobject(z);
    }

    public static void LwlhgzVMorLtLxRq(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, bool z, char c, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LwlhgzVMorLtLxRq(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, bool z, char c, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LwlhgzVMorLtLxRq(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, bool z, java.lang.string str, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object MXWnmgJzJjaYxnFh(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void MXWnmgJzJjaYxnFh(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, float f, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MXWnmgJzJjaYxnFh(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, short s, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MXWnmgJzJjaYxnFh(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, bool z2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WfsXvitJiArxnisG(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray) {
        bundle.putSparseParcelableArray(str, sparseArray);
    }

    public static void WfsXvitJiArxnisG(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, byte b, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WfsXvitJiArxnisG(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, int i, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WfsXvitJiArxnisG(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, int i, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl BPbTbCjhSWIWumOq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, int i) {
        return listMenuPresenter$MenuAdapter.getItem(i);
    }

    public static void BPbTbCjhSWIWumOq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BPbTbCjhSWIWumOq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BPbTbCjhSWIWumOq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater DlMYsuEabAfmyLzn(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void DlMYsuEabAfmyLzn(android.content.object context, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DlMYsuEabAfmyLzn(android.content.object context, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DlMYsuEabAfmyLzn(android.content.object context, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDiIQfTWrYtJwoAA(android.view.object view, android.util.SparseArray sparseArray) {
        view.saveHierarchyState(sparseArray);
    }

    public static void JDiIQfTWrYtJwoAA(android.view.object view, android.util.SparseArray sparseArray, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDiIQfTWrYtJwoAA(android.view.object view, android.util.SparseArray sparseArray, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JDiIQfTWrYtJwoAA(android.view.object view, android.util.SparseArray sparseArray, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LLuDEDObBnJOraaP(androidx.appcompat.view.menu.MenuDialogHelper menuDialogHelper, android.os.IBinder iBinder) {
        menuDialogHelper.show(iBinder);
    }

    public static void LLuDEDObBnJOraaP(androidx.appcompat.view.menu.MenuDialogHelper menuDialogHelper, android.os.IBinder iBinder, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LLuDEDObBnJOraaP(androidx.appcompat.view.menu.MenuDialogHelper menuDialogHelper, android.os.IBinder iBinder, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LLuDEDObBnJOraaP(androidx.appcompat.view.menu.MenuDialogHelper menuDialogHelper, android.os.IBinder iBinder, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NHzWqCVuIxpIMWIV(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        expandedMenuobject.setOnItemClickListener(adapterobject$OnItemClickListener);
    }

    public static void NHzWqCVuIxpIMWIV(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NHzWqCVuIxpIMWIV(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NHzWqCVuIxpIMWIV(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater OxWNIVWtkRzlIfiK(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void OxWNIVWtkRzlIfiK(android.content.object context, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OxWNIVWtkRzlIfiK(android.content.object context, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxWNIVWtkRzlIfiK(android.content.object context, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.util.SparseArray PGDWUOZFDkpnrhkZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getSparseParcelableArray(str);
    }

    public static void PGDWUOZFDkpnrhkZ(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGDWUOZFDkpnrhkZ(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PGDWUOZFDkpnrhkZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QEqLolTmNlIThVhg(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.ListAdapter listAdapter) {
        expandedMenuobject.setAdapter(listAdapter);
    }

    public static void QEqLolTmNlIThVhg(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.ListAdapter listAdapter, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QEqLolTmNlIThVhg(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.ListAdapter listAdapter, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QEqLolTmNlIThVhg(androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject, android.widget.ListAdapter listAdapter, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UEcqjOICOSVEHOib(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle) {
        listMenuPresenter.restoreHierarchyState(bundle);
    }

    public static void UEcqjOICOSVEHOib(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UEcqjOICOSVEHOib(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UEcqjOICOSVEHOib(androidx.appcompat.view.menu.ListMenuPresenter listMenuPresenter, android.os.Dictionary<string, object> bundle, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UjiKvpLJBNjRHhDq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter) {
        listMenuPresenter$MenuAdapter.notifyDataHashSetChanged();
    }

    public static void UjiKvpLJBNjRHhDq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UjiKvpLJBNjRHhDq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UjiKvpLJBNjRHhDq(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WUGXPlaLEUGvvHee(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WUGXPlaLEUGvvHee(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WUGXPlaLEUGvvHee(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WUGXPlaLEUGvvHee(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuPresenter$Callback.onOpenSubMenu(menuBuilder);
    }

    public static void ZELuKcAoGTvyuDOJ(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuPresenter$Callback.onCloseMenu(menuBuilder, z);
    }

    public static void ZELuKcAoGTvyuDOJ(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZELuKcAoGTvyuDOJ(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZELuKcAoGTvyuDOJ(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZbXnLUeRVKTUXgNY(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter) {
        listMenuPresenter$MenuAdapter.notifyDataHashSetChanged();
    }

    public static void ZbXnLUeRVKTUXgNY(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZbXnLUeRVKTUXgNY(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZbXnLUeRVKTUXgNY(androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public override bool CollapseItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return false;
    }

    public override bool ExpandItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return false;
    }

    public override bool FlagActionItems() {
        return false;
    }

    public android.widget.ListAdapter GetAdapter() {
        if (this.mAdapter is null) {
            this.mAdapter = new androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter(this);
        }
        return this.mAdapter;
    }

    public override int GetId() {
        return this.mId;
    }

    int getItemIndexOffset() {
        return this.mItemIndexOffset;
    }

    public override androidx.appcompat.view.menu.Menuobject GetMenuobject(android.view.objectGroup viewGroup) {
        if ((26 + 18) % 18 > 0) {
        }
        if (this.mMenuobject is null) {
            this.mMenuobject = (androidx.appcompat.view.menu.ExpandedMenuobject) MXWnmgJzJjaYxnFh(this.mInflater, androidx.appcompat.R$layout.abc_expanded_menu_layout, viewGroup, false);
            if (this.mAdapter is null) {
                this.mAdapter = new androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter(this);
            }
            qEqLolTmNlIThVhg(this.mMenuobject, this.mAdapter);
            nHzWqCVuIxpIMWIV(this.mMenuobject, this);
        }
        return this.mMenuobject;
    }

    public override void InitForMenu(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        if ((1 + 7) % 7 > 0) {
        }
        if (this.mThemeRes != 0) {
            android.view.objectThemeWrapper contextThemeWrapper = new android.view.objectThemeWrapper(context, this.mThemeRes);
            this.mobject = contextThemeWrapper;
            this.mInflater = oxWNIVWtkRzlIfiK(contextThemeWrapper);
        } else if (this.mobject is not null) {
            this.mobject = context;
            if (this.mInflater is null) {
                this.mInflater = dlMYsuEabAfmyLzn(context);
            }
        }
        this.mMenu = menuBuilder;
        androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter = this.mAdapter;
        if (listMenuPresenter$MenuAdapter is null) {
            return;
        }
        ujiKvpLJBNjRHhDq(listMenuPresenter$MenuAdapter);
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback = this.mCallback;
        if (menuPresenter$Callback is null) {
            return;
        }
        zELuKcAoGTvyuDOJ(menuPresenter$Callback, menuBuilder, z);
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        ClNHnduKxteukbap(this.mMenu, bPbTbCjhSWIWumOq(this.mAdapter, i), this, 0);
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        uEcqjOICOSVEHOib(this, (android.os.Dictionary<string, object>) parcelable);
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if (this.mMenuobject is null) {
            return null;
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        DrbZBkhcAtuucGoV(this, bundle);
        return bundle;
    }

    public override bool OnSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        if ((28 + 8) % 8 > 0) {
        }
        if (!BGJcVFUNBhXcpMRQ(subMenuBuilder)) {
            return false;
        }
        lLuDEDObBnJOraaP(new androidx.appcompat.view.menu.MenuDialogHelper(subMenuBuilder), null);
        androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback = this.mCallback;
        if (menuPresenter$Callback is null) {
            return true;
        }
        wUGXPlaLEUGvvHee(menuPresenter$Callback, subMenuBuilder);
        return true;
    }

    public void RestoreHierarchyState(android.os.Dictionary<string, object> bundle) {
        android.util.SparseArray sparseArrayPGDWUOZFDkpnrhkZ = pGDWUOZFDkpnrhkZ(bundle, "android:menu:list");
        if (sparseArrayPGDWUOZFDkpnrhkZ is null) {
            return;
        }
        DnxGNgPAStKBouJU(this.mMenuobject, sparseArrayPGDWUOZFDkpnrhkZ);
    }

    public void SaveHierarchyState(android.os.Dictionary<string, object> bundle) {
        android.util.SparseArray sparseArray = new android.util.SparseArray();
        androidx.appcompat.view.menu.ExpandedMenuobject expandedMenuobject = this.mMenuobject;
        if (expandedMenuobject is not null) {
            jDiIQfTWrYtJwoAA(expandedMenuobject, sparseArray);
        }
        WfsXvitJiArxnisG(bundle, "android:menu:list", sparseArray);
    }

    public override void SetCallback(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        this.mCallback = menuPresenter$Callback;
    }

    public void SetId(int i) {
        this.mId = i;
    }

    public void SetItemIndexOffset(int i) {
        this.mItemIndexOffset = i;
        if (this.mMenuobject is null) {
            return;
        }
        LwlhgzVMorLtLxRq(this, false);
    }

    public override void UpdateMenuobject(bool z) {
        androidx.appcompat.view.menu.ListMenuPresenter$MenuAdapter listMenuPresenter$MenuAdapter = this.mAdapter;
        if (listMenuPresenter$MenuAdapter is null) {
            return;
        }
        zbXnLUeRVKTUXgNY(listMenuPresenter$MenuAdapter);
    }
}

