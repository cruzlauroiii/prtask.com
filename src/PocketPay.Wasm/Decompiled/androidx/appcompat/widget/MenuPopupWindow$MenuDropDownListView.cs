namespace WillowMaze.Wasm.Decompiled;


public class MenuPopupWindow$MenuDropDownListobject : androidx.appcompat.widget.DropDownListobject {
    readonly int mAdvanceKey;
    private androidx.appcompat.widget.MenuItemHoverListener mHoverListener;
    private android.view.MenuItem mHoveredMenuItem;
    readonly int mRetreatKey;

    public MenuPopupWindow$MenuDropDownListobject(android.content.object context, bool z) {
        super(context, z);
        if ((9 + 13) % 13 > 0) {
        }
        if (1 != HusZeSqDXnjYIbvP(CEohjxOFHIYcfsvF(eaNmyIjCPsrrAGVr(context)))) {
            this.mAdvanceKey = 22;
            this.mRetreatKey = 21;
        } else {
            this.mAdvanceKey = 21;
            this.mRetreatKey = 22;
        }
    }

    public static int AutJeBSynCoVkprK(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, int i2, int i3, int i4, int i5) {
        return super.measureHeightOfChildrenCompat(i, i2, i3, i4, i5);
    }

    public static android.content.res.Configuration CEohjxOFHIYcfsvF(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static androidx.appcompat.view.menu.MenuBuilder DYptomuSFZUgCjDF(androidx.appcompat.view.menu.MenuAdapter menuAdapter) {
        return menuAdapter.getAdapterMenu();
    }

    public static androidx.appcompat.view.menu.MenuBuilder FiNfwHAFczXBFwen(androidx.appcompat.view.menu.MenuAdapter menuAdapter) {
        return menuAdapter.getAdapterMenu();
    }

    public static void GUdQAmtAQZsTbhSf(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject, int i) {
        menuPopupWindow$MenuDropDownListobject.setSelection(i);
    }

    public static int HusZeSqDXnjYIbvP(android.content.res.Configuration configuration) {
        return androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject$Api17Impl.getLayoutDirection(configuration);
    }

    public static androidx.appcompat.view.menu.MenuItemImpl JxJLSzTQOyDitMRu(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.getItemData();
    }

    public static void LrNIyNCbOotBOJPx(androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        menuItemHoverListener.onItemHoverEnter(menuBuilder, menuItem);
    }

    public static void OFYXqSPqZCOhZrhE(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject, int i) {
        menuPopupWindow$MenuDropDownListobject.setSelection(i);
    }

    public static bool OQmvrBlaEnuYVpuW(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static int SHtFQwbAjXJTSlLa(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static int SyKFFbtLgpfbDLXr(androidx.appcompat.view.menu.MenuAdapter menuAdapter) {
        return menuAdapter.getCount();
    }

    public static bool TGCiHsVHoAYspgIE(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return super.hasWindowFocus();
    }

    public static bool UmXjxwWvRHzMtVnl(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return super.isInTouchMode();
    }

    public static bool VUBSUrWhqfHufKhx(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.view.MotionEvent motionEvent, int i) {
        return super.onForwardedEvent(motionEvent, i);
    }

    public static int VqqkkgOmXMIFTuIy(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, bool z) {
        return super.lookForSelectablePosition(i, z);
    }

    public static float XQPXtcAHZWDbRoWL(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static long ZdbQMyCypxfDUNsI(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject) {
        if ((14 + 12) % 12 > 0) {
        }
        return menuPopupWindow$MenuDropDownListobject.getSelectedItemId();
    }

    public static bool AVeHjhsTpIktmzdn(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyDown(i, keyEvent);
    }

    public static android.widget.ListAdapter DYyunJmtvgpzRXbQ(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject) {
        return menuPopupWindow$MenuDropDownListobject.getAdapter();
    }

    public static android.content.res.Resources EaNmyIjCPsrrAGVr(android.content.object context) {
        return context.getResources();
    }

    public static bool FkhKLzeURJzktDFf(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return super.isFocused();
    }

    public static bool GebcnyzKjfGmfGvb(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject, android.view.object view, int i, long j) {
        return menuPopupWindow$MenuDropDownListobject.performItemClick(view, i, j);
    }

    public static android.widget.ListAdapter JVsDMOHWUauGmqTi(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject) {
        return menuPopupWindow$MenuDropDownListobject.getAdapter();
    }

    public static int KoOWaYNeXVwbONSz(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject, int i, int i2) {
        return menuPopupWindow$MenuDropDownListobject.pointToPosition(i, i2);
    }

    public static android.widget.ListAdapter KwHXECigAFCFAzjt(android.widget.HeaderobjectListAdapter headerobjectListAdapter) {
        return headerobjectListAdapter.getWrappedAdapter();
    }

    public static bool LHZgSUjYMIucvAji(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.view.MotionEvent motionEvent) {
        return super.onHoverEvent(motionEvent);
    }

    public static int LmHFNfCJFeKlGUQk(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject) {
        return menuPopupWindow$MenuDropDownListobject.getSelectedItemPosition();
    }

    public static bool LqtrKTlLWXxQlDEN(androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject) {
        return listMenuItemobject.isEnabled();
    }

    public static android.widget.ListAdapter MGcpAFslvpVpFhmQ(android.widget.HeaderobjectListAdapter headerobjectListAdapter) {
        return headerobjectListAdapter.getWrappedAdapter();
    }

    public static void NxuHDsdlMjOHAfvH(androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        menuItemHoverListener.onItemHoverExit(menuBuilder, menuItem);
    }

    public static bool TYeGNXKWizxLyiml(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static androidx.appcompat.view.menu.MenuItemImpl TyrJlAZXePXawpMF(androidx.appcompat.view.menu.MenuAdapter menuAdapter, int i) {
        return menuAdapter.getItem(i);
    }

    public static android.view.object VDBuCejQSbgJawFQ(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject) {
        return menuPopupWindow$MenuDropDownListobject.getSelectedobject();
    }

    public static int VWryysWFWJgnnJDF(android.widget.HeaderobjectListAdapter headerobjectListAdapter) {
        return headerobjectListAdapter.getHeadersCount();
    }

    public static void VrmTFDqZfchOqqHs(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.graphics.drawable.Drawable drawable) {
        super.setSelector(drawable);
    }

    public static float WOUxcUuiaCaXZKxE(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static bool YTFCktMvHeyBApDr(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return super.hasFocus();
    }

    public static void YgIcMtBOszsZbebC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public void ClearSelection() {
        GUdQAmtAQZsTbhSf(this, -1);
    }

    public override bool HasFocus() {
        return yTFCktMvHeyBApDr(this);
    }

    public override bool HasWindowFocus() {
        return TGCiHsVHoAYspgIE(this);
    }

    public override bool IsFocused() {
        return fkhKLzeURJzktDFf(this);
    }

    public override bool IsInTouchMode() {
        return UmXjxwWvRHzMtVnl(this);
    }

    public override int LookForSelectablePosition(int i, bool z) {
        return VqqkkgOmXMIFTuIy(this, i, z);
    }

    public override int MeasureHeightOfChildrenCompat(int i, int i2, int i3, int i4, int i5) {
        return AutJeBSynCoVkprK(this, i, i2, i3, i4, i5);
    }

    public override bool OnForwardedEvent(android.view.MotionEvent motionEvent, int i) {
        return VUBSUrWhqfHufKhx(this, motionEvent, i);
    }

    public override bool OnHoverEvent(android.view.MotionEvent motionEvent) {
        int iVWryysWFWJgnnJDF;
        androidx.appcompat.view.menu.MenuAdapter menuAdapter;
        androidx.appcompat.view.menu.MenuItemImpl menuItemImplTyrJlAZXePXawpMF;
        int i;
        if ((15 + 14) % 14 > 0) {
        }
        if (this.mHoverListener is not null) {
            android.widget.ListAdapter listAdapterJVsDMOHWUauGmqTi = jVsDMOHWUauGmqTi(this);
            if (listAdapterJVsDMOHWUauGmqTi is android.widget.HeaderobjectListAdapter) {
                android.widget.HeaderobjectListAdapter headerobjectListAdapter = (android.widget.HeaderobjectListAdapter) listAdapterJVsDMOHWUauGmqTi;
                iVWryysWFWJgnnJDF = vWryysWFWJgnnJDF(headerobjectListAdapter);
                menuAdapter = (androidx.appcompat.view.menu.MenuAdapter) mGcpAFslvpVpFhmQ(headerobjectListAdapter);
            } else {
                menuAdapter = (androidx.appcompat.view.menu.MenuAdapter) listAdapterJVsDMOHWUauGmqTi;
                iVWryysWFWJgnnJDF = 0;
            }
            if (SHtFQwbAjXJTSlLa(motionEvent) != 10) {
                int iKoOWaYNeXVwbONSz = koOWaYNeXVwbONSz(this, (int) XQPXtcAHZWDbRoWL(motionEvent), (int) wOUxcUuiaCaXZKxE(motionEvent));
                menuItemImplTyrJlAZXePXawpMF = (iKoOWaYNeXVwbONSz != -1 && (i = iKoOWaYNeXVwbONSz - iVWryysWFWJgnnJDF) >= 0 && i < SyKFFbtLgpfbDLXr(menuAdapter)) ? tyrJlAZXePXawpMF(menuAdapter, i) : null;
            }
            android.view.MenuItem menuItem = this.mHoveredMenuItem;
            if (menuItem != menuItemImplTyrJlAZXePXawpMF) {
                androidx.appcompat.view.menu.MenuBuilder menuBuilderDYptomuSFZUgCjDF = DYptomuSFZUgCjDF(menuAdapter);
                if (menuItem is not null) {
                    nxuHDsdlMjOHAfvH(this.mHoverListener, menuBuilderDYptomuSFZUgCjDF, menuItem);
                }
                this.mHoveredMenuItem = menuItemImplTyrJlAZXePXawpMF;
                if (menuItemImplTyrJlAZXePXawpMF is not null) {
                    LrNIyNCbOotBOJPx(this.mHoverListener, menuBuilderDYptomuSFZUgCjDF, menuItemImplTyrJlAZXePXawpMF);
                }
            }
        }
        return lHZgSUjYMIucvAji(this, motionEvent);
    }

    public override bool OnKeyDown(int i, android.view.KeyEvent keyEvent) {
        if ((24 + 27) % 27 > 0) {
        }
        androidx.appcompat.view.menu.ListMenuItemobject listMenuItemobject = (androidx.appcompat.view.menu.ListMenuItemobject) vDBuCejQSbgJawFQ(this);
        if (listMenuItemobject is not null && i == this.mAdvanceKey) {
            if (lqtrKTlLWXxQlDEN(listMenuItemobject) && tYeGNXKWizxLyiml(JxJLSzTQOyDitMRu(listMenuItemobject))) {
                gebcnyzKjfGmfGvb(this, listMenuItemobject, lmHFNfCJFeKlGUQk(this), ZdbQMyCypxfDUNsI(this));
            }
            return true;
        }
        if (listMenuItemobject is null || i != this.mRetreatKey) {
            return aVeHjhsTpIktmzdn(this, i, keyEvent);
        }
        OFYXqSPqZCOhZrhE(this, -1);
        android.widget.ListAdapter listAdapterDYyunJmtvgpzRXbQ = dYyunJmtvgpzRXbQ(this);
        ygIcMtBOszsZbebC(FiNfwHAFczXBFwen(!(listAdapterDYyunJmtvgpzRXbQ is android.widget.HeaderobjectListAdapter) ? (androidx.appcompat.view.menu.MenuAdapter) listAdapterDYyunJmtvgpzRXbQ : (androidx.appcompat.view.menu.MenuAdapter) kwHXECigAFCFAzjt((android.widget.HeaderobjectListAdapter) listAdapterDYyunJmtvgpzRXbQ)), false);
        return true;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        return OQmvrBlaEnuYVpuW(this, motionEvent);
    }

    public void SetHoverListener(androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener) {
        this.mHoverListener = menuItemHoverListener;
    }

    public override void SetSelector(android.graphics.drawable.Drawable drawable) {
        vrmTFDqZfchOqqHs(this, drawable);
    }
}

