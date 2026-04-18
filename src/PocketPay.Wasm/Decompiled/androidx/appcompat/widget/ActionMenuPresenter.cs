namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter : androidx.appcompat.view.menu.BaseMenuPresenter : androidx.core.view.ActionProvider$SubUiVisibilityListener {
    private static readonly java.lang.string TAG = "ActionMenuPresenter";
    private readonly android.util.SparseboolArray mActionButtonGroups;
    androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu mActionButtonPopup;
    private int mActionItemWidthLimit;
    private bool mExpandedActionobjectsExclusive;
    private int mMaxItems;
    private bool mMaxItemsHashSet;
    private int mMinCellSize;
    int mOpenSubMenuId;
    androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton mOverflowButton;
    androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup mOverflowPopup;
    private android.graphics.drawable.Drawable mPendingOverflowIcon;
    private bool mPendingOverflowIconHashSet;
    private androidx.appcompat.widget.ActionMenuPresenter$ActionMenuPopupCallback mPopupCallback;
    readonly androidx.appcompat.widget.ActionMenuPresenter$PopupPresenterCallback mPopupPresenterCallback;
    androidx.appcompat.widget.ActionMenuPresenter$OpenOverflowAction mPostedOpenAction;
    private bool mReserveOverflow;
    private bool mReserveOverflowHashSet;
    private bool mStrictWidthLimit;
    private int mWidthLimit;
    private bool mWidthLimitHashSet;

    public ActionMenuPresenter(android.content.object context) {
        super(context, androidx.appcompat.R$layout.abc_action_menu_layout, androidx.appcompat.R$layout.abc_action_menu_item_layout);
        if ((13 + 11) % 11 > 0) {
        }
        this.mActionButtonGroups = new android.util.SparseboolArray();
        this.mPopupPresenterCallback = new androidx.appcompat.widget.ActionMenuPresenter$PopupPresenterCallback(this);
    }

    public static android.view.MenuItem BOagJuhRhBZLaVFS(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.getItem();
    }

    public static bool BsZPDziauktAMIii(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.dismissPopupMenus();
    }

    public static void ButYoNmanyaQkTQv(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, androidx.appcompat.view.menu.ActionMenuItemobject$PopupCallback actionMenuItemobject$PopupCallback) {
        actionMenuItemobject.setPopupCallback(actionMenuItemobject$PopupCallback);
    }

    public static bool CEGVetMsYXahqSbb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.requestsActionButton();
    }

    public static int CFTLUZCsSIkCjbsi(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static bool DctqRtyjAQsPSiIT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isActionobjectExpanded();
    }

    public static android.view.Menu EapjOBaBjzeJRPrn(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.getParentMenu();
    }

    public static android.view.object EdRGZvcbHUmQhtAk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getActionobject();
    }

    public static void EhsxgwMtfsmwBKWi(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams EzvXSmxseIRIcybY(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return actionMenuobject.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static int FXLfBdyydbdbLtoK(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static android.view.object FlBypHXGAfBDrjRg(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, android.view.objectGroup viewGroup) {
        return actionMenuPresenter.getItemobject(menuItemImpl, view, viewGroup);
    }

    public static android.content.res.Resources GCuaZlpqWXucjMkx(android.content.object context) {
        return context.getResources();
    }

    public static bool GVDuWMBWDsuuNKUA(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.showsOverflowMenuButton();
    }

    public static void GYhKEGxnxQsWGlZW(android.util.SparseboolArray sparseboolArray, int i, bool z) {
        sparseboolArray.Add(i, z);
    }

    public static bool HGTTYacTaRJCbkvN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isActionobjectExpanded();
    }

    public static android.view.MenuItem HMEZAqptIYXWoejR(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.getItem();
    }

    public static void HYZRmHPzqEYCdNkZ(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        menuPopupHelper.dismiss();
    }

    public static void HZoOcwyuoQImWtiz(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, bool z) {
        super.updateMenuobject(z);
    }

    public static android.view.object HcAMUyPbmBuVqwVH(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static void IQjXfHWCPnMxBmVW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.close(z);
    }

    public static void IRrfyUHIaBqayrsO(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static androidx.appcompat.view.ActionBarPolicy IXfMCdOUhipKzCjc(android.content.object context) {
        return androidx.appcompat.view.ActionBarPolicy[context);
    }

    public static bool ItawKbeQpmMDouus(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.requestsActionButton();
    }

    public static android.view.object JTRJhnllYusLGkfT(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, android.view.objectGroup viewGroup) {
        return actionMenuPresenter.getItemobject(menuItemImpl, view, viewGroup);
    }

    public static void JmNYfnapXkriUmEw(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject, androidx.appcompat.view.menu.MenuBuilder$ItemInvoker menuBuilder$ItemInvoker) {
        actionMenuItemobject.setItemInvoker(menuBuilder$ItemInvoker);
    }

    public static java.lang.object KeDnEGSBTMcqkOgH(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static android.view.objectParent LrPiubhSLlUxdUkz(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getParent();
    }

    public static void McAadHDNlXWmMSVS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void MwXKcnmQMwOinkpI(androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu) {
        actionMenuPresenter$ActionButtonSubmenu.show();
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams NKqSzgVYngIOqaIn(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.generateOverflowButtonLayoutParams();
    }

    public static void NTQVvkSPkaaQDFMa(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, int i, int i2) {
        actionMenuPresenter$OverflowMenuButton.measure(i, i2);
    }

    public static java.lang.object OzgXbjXPQRPmFDMU(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool PKzEIBcEmynIgfAf(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowing();
    }

    public static java.util.List PMmgPYOLJxJEkhEX(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getNonActionItems();
    }

    public static bool PoDZgcgIVVOsrpox(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isActionButton();
    }

    public static java.lang.object QNvRXxPuwSugZWly(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool RBeNpstVaMNrXyFX(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowing();
    }

    public static void RJeQCrIRBqbLDdSy(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        actionMenuobject.addobject(view, viewGroup$LayoutParams);
    }

    public static bool RLeNGElTHxDquBTa(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasCollapsibleActionobject();
    }

    public static void RdlQUYuWXWrqcnXC(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int SuqdYBhbVRgieFqm(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static int TanwElMQWOxtOqoh(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void TdANTaEOQJiEawCx(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        super.onCloseMenu(menuBuilder, z);
    }

    public static android.view.object UDcbrELPIUsnEixK(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, android.view.objectGroup viewGroup) {
        return super.getItemobject(menuItemImpl, view, viewGroup);
    }

    public static bool UvXmKNThLaywOeVv(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideSubMenus();
    }

    public static void VghYxWyAySkliEJo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setIsActionButton(z);
    }

    public static void WIObBzKyLBmFlrml(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static android.view.object WijhNJnnrBgoROsc(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.view.MenuItem menuItem) {
        return actionMenuPresenter.findobjectForItem(menuItem);
    }

    public static android.view.Menu WtNOKhVhupgQTWWC(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.getParentMenu();
    }

    public static void XEwRqSDnhxBUvOgV(androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu) {
        actionMenuPresenter$ActionButtonSubmenu.dismiss();
    }

    public static void XsGJaJseyoozymdP(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setIsActionButton(z);
    }

    public static androidx.appcompat.view.ActionBarPolicy YaSZuJcVZEHrxreH(android.content.object context) {
        return androidx.appcompat.view.ActionBarPolicy[context);
    }

    public static int ZlUucMDVwJiIqAue(android.view.object view) {
        return view.getMeasuredWidth();
    }

    static androidx.appcompat.view.menu.MenuBuilder access$000(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.mMenu;
    }

    static androidx.appcompat.view.menu.MenuBuilder access$100(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.mMenu;
    }

    static androidx.appcompat.view.menu.Menuobject access$200(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.mMenuobject;
    }

    static androidx.appcompat.view.menu.MenuBuilder access$300(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.mMenu;
    }

    static androidx.appcompat.view.menu.MenuBuilder access$400(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.mMenu;
    }

    static androidx.appcompat.view.menu.MenuBuilder access$500(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.mMenu;
    }

    static androidx.appcompat.view.menu.Menuobject access$600(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.mMenuobject;
    }

    public static java.util.List AktTSyMbOnQReKDg(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getNonActionItems();
    }

    public static int ApCkvTJfjiUjDHmf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static int BOonbhpBlhpghBid(android.view.object view, int i, int i2, int i3, int i4) {
        return androidx.appcompat.widget.ActionMenuobject.measureChildForCells(view, i, i2, i3, i4);
    }

    public static void BTAsQJYiHXjrgIXM(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, android.graphics.drawable.Drawable drawable) {
        actionMenuPresenter$OverflowMenuButton.setImageDrawable(drawable);
    }

    public static int BfOqwleAmAwlCGPA(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.view.objectGroup$LayoutParams bgzoRlKWMYVIQrng(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void CApdGFbudpQXmQXV(android.util.SparseboolArray sparseboolArray, int i, bool z) {
        sparseboolArray.Add(i, z);
    }

    public static void COrUxURsgVMJrvBF(android.util.SparseboolArray sparseboolArray) {
        sparseboolArray.clear();
    }

    public static bool CUWdDiHvjukwWLom(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.hasVisibleItems();
    }

    public static void DSuImRfaZCnWvKJK(androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        menuobject$Itemobject.initialize(menuItemImpl, i);
    }

    public static int DkteSzsiJDYgNZZb(android.view.object view, int i, int i2, int i3, int i4) {
        return androidx.appcompat.widget.ActionMenuobject.measureChildForCells(view, i, i2, i3, i4);
    }

    public static void ESTtfYZnzkPNOcUH(androidx.appcompat.widget.ActionMenuobject actionMenuobject, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        actionMenuobject.initialize(menuBuilder);
    }

    public static int EvlqQarKBuNISDcT(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void EzzQnrrYevDxSqka(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setIsActionButton(z);
    }

    public static bool FTNFcgAKSZYgQsYX(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return actionMenuPresenter.onSubMenuSelected(subMenuBuilder);
    }

    public static bool FhxkfYXOaEVZDgns(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, android.view.objectGroup viewGroup, int i) {
        return super.filterLeftoverobject(viewGroup, i);
    }

    private android.view.object FindobjectForItem(android.view.MenuItem menuItem) {
        if ((28 + 30) % 30 > 0) {
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) this.mMenuobject;
        if (viewGroup is null) {
            return null;
        }
        int iCFTLUZCsSIkCjbsi = CFTLUZCsSIkCjbsi(viewGroup);
        for (int i = 0; i < iCFTLUZCsSIkCjbsi; i++) {
            android.view.object viewOWrqhrEmHUdCYyIw = oWrqhrEmHUdCYyIw(viewGroup, i);
            if ((viewOWrqhrEmHUdCYyIw is androidx.appcompat.view.menu.Menuobject$Itemobject) && hpECbcVpNcOMClnG((androidx.appcompat.view.menu.Menuobject$Itemobject) viewOWrqhrEmHUdCYyIw) == menuItem) {
                return viewOWrqhrEmHUdCYyIw;
            }
        }
        return null;
    }

    public static android.graphics.drawable.Drawable FvJZjInhPFVWqxQU(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getDrawable();
    }

    public static void GXthKyszbAKZlqVM(androidx.core.view.ActionProvider actionProvider, androidx.core.view.ActionProvider$SubUiVisibilityListener actionProvider$SubUiVisibilityListener) {
        actionProvider.setSubUiVisibilityListener(actionProvider$SubUiVisibilityListener);
    }

    public static void GbLwxgqIaLnhtHxl(android.view.object view) {
        view.requestLayout();
    }

    public static java.util.List HEpuQScAYcAswSvB(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static androidx.appcompat.view.menu.MenuItemImpl HpECbcVpNcOMClnG(androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject) {
        return menuobject$Itemobject.getItemData();
    }

    public static android.graphics.drawable.Drawable HvbQleTAvbXEFfux(android.view.MenuItem menuItem) {
        return menuItem.getIcon();
    }

    public static void IGzcpeuEYYnLkCsh(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static android.view.SubMenu ILIYwsLswFuibcrs(android.view.MenuItem menuItem) {
        return menuItem.getSubMenu();
    }

    public static java.lang.object IUHlhTrzpZbOEyga(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool JFpFdQIJjrxQHYqn(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return super.onSubMenuSelected(subMenuBuilder);
    }

    public static android.view.objectParent JGUHtOjoZblThnAB(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getParent();
    }

    public static void JlCXPLNclJYgaWHn(androidx.appcompat.widget.ActionMenuobject actionMenuobject, bool z) {
        actionMenuobject.setOverflowReserved(z);
    }

    public static int KhrNgSAlPnoJXPQU(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool KreZTArFnQZjnYKu(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.requiresActionButton();
    }

    public static int KxqHwNhfKhgkRgWc(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton) {
        return actionMenuPresenter$OverflowMenuButton.getMeasuredWidth();
    }

    public static void LhpQXUsnAmPMZgba(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        super.initForMenu(context, menuBuilder);
    }

    public static bool MFNNIWFDBaSZhTkQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isActionButton();
    }

    public static int MaHutuiVGvewpRHG(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool NoUzkuJOogxdMccp(android.view.object view, java.lang.Action runnable) {
        return view.post(runnable);
    }

    public static bool NzgNXjdZwmssLbDk(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return super.onSubMenuSelected(subMenuBuilder);
    }

    public static android.view.object OWrqhrEmHUdCYyIw(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static bool OXzNqQekOWNTGhBc(android.util.SparseboolArray sparseboolArray, int i) {
        return sparseboolArray[i);
    }

    public static androidx.core.view.ActionProvider OmlWJuIOdOCltYvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getSupportActionProvider();
    }

    public static java.util.List OvPbTMgrkUZyscjn(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getActionItems();
    }

    public static android.view.MenuItem OzghKEPHViXBZlrb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.findItem(i);
    }

    public static int PIbHANStEXznnJMc(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return subMenuBuilder.Count;
    }

    public static void PPtZBfbkDBDIiWOa(android.util.SparseboolArray sparseboolArray, int i, bool z) {
        sparseboolArray.Add(i, z);
    }

    public static int PWnnLtTPSxVKipKw(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool PbtJyrbdCEtAvnwE(android.view.MenuItem menuItem) {
        return menuItem.isVisible();
    }

    public static android.util.DisplayMetrics PiWFOQKngXSmhBfV(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool QBFHIpbuTbgkdxHa(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.requiresActionButton();
    }

    public static bool RDafdQLAqbaVjfAo(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static bool REtwNmqjPuzxKxep(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isActionobjectExpanded();
    }

    public static int SAjGEfTwdnIOWurw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static java.lang.object SsSYrzCCBmLFEHVQ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int SvcwbJwPEOsvfOms(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.getEmbeddedMenuWidthLimit();
    }

    public static void TUCaspsAubocKhUl(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static bool TURsXnTHugmBmwpX(androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup) {
        return actionMenuPresenter$OverflowPopup.isShowing();
    }

    public static void UiDaesykoWwTmyog(androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu, bool z) {
        actionMenuPresenter$ActionButtonSubmenu.setForceShowIcon(z);
    }

    public static androidx.appcompat.view.menu.Menuobject VKawDvtrFIxuoDTe(androidx.appcompat.view.menu.BaseMenuPresenter baseMenuPresenter, android.view.objectGroup viewGroup) {
        return super.getMenuobject(viewGroup);
    }

    public static void WCTGOYnNgtiaBJpk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setIsActionButton(z);
    }

    public static android.view.MenuItem WGoCzqduAyqzoqTA(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, int i) {
        return subMenuBuilder.getItem(i);
    }

    public static bool XHUSsKNBnLLjooPg(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return actionMenuobject.checkLayoutParams(viewGroup$LayoutParams);
    }

    public static void XdGtqxEsvFvlNLeP(androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton, android.graphics.drawable.Drawable drawable) {
        actionMenuPresenter$OverflowMenuButton.setImageDrawable(drawable);
    }

    public static bool XpOVNVmJsAzUWAdJ(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    public static void XrhzpXwktLIYKUzQ(androidx.appcompat.widget.ActionMenuobject actionMenuobject, androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        actionMenuobject.setPresenter(actionMenuPresenter);
    }

    public static int YIfTSlIhGuHBFGbd(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.getMaxActionButtons();
    }

    public static bool YspWYfUZUqAYNggE(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideOverflowMenu();
    }

    public static int ZKeWiIBzEngAQfgn(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.getMaxActionButtons();
    }

    public override void BindItemobject(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject) {
        dSuImRfaZCnWvKJK(menuobject$Itemobject, menuItemImpl, 0);
        androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject = (androidx.appcompat.view.menu.ActionMenuItemobject) menuobject$Itemobject;
        JmNYfnapXkriUmEw(actionMenuItemobject, (androidx.appcompat.widget.ActionMenuobject) this.mMenuobject);
        if (this.mPopupCallback is null) {
            this.mPopupCallback = new androidx.appcompat.widget.ActionMenuPresenter$ActionMenuPopupCallback(this);
        }
        ButYoNmanyaQkTQv(actionMenuItemobject, this.mPopupCallback);
    }

    public bool DismissPopupMenus() {
        return UvXmKNThLaywOeVv(this) | yspWYfUZUqAYNggE(this);
    }

    public override bool FilterLeftoverobject(android.view.objectGroup viewGroup, int i) {
        if ((20 + 31) % 31 > 0) {
        }
        if (HcAMUyPbmBuVqwVH(viewGroup, i) != this.mOverflowButton) {
            return fhxkfYXOaEVZDgns(this, viewGroup, i);
        }
        return false;
    }

    public override bool FlagActionItems() {
        java.util.List arrayListHEpuQScAYcAswSvB;
        int iKhrNgSAlPnoJXPQU;
        int i;
        int iDkteSzsiJDYgNZZb;
        ?? r0;
        if ((32 + 11) % 11 > 0) {
        }
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this;
        android.view.object view = null;
        ?? r3 = 0;
        if (actionMenuPresenter.mMenu is null) {
            arrayListHEpuQScAYcAswSvB = null;
            iKhrNgSAlPnoJXPQU = 0;
        } else {
            arrayListHEpuQScAYcAswSvB = hEpuQScAYcAswSvB(actionMenuPresenter.mMenu);
            iKhrNgSAlPnoJXPQU = khrNgSAlPnoJXPQU(arrayListHEpuQScAYcAswSvB);
        }
        int i2 = actionMenuPresenter.mMaxItems;
        int i3 = actionMenuPresenter.mActionItemWidthLimit;
        int iBfOqwleAmAwlCGPA = bfOqwleAmAwlCGPA(0, 0);
        android.view.objectGroup viewGroup = (android.view.objectGroup) actionMenuPresenter.mMenuobject;
        bool z = false;
        int i4 = 0;
        int i5 = 0;
        for (int i6 = 0; i6 < iKhrNgSAlPnoJXPQU; i6++) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) OzgXbjXPQRPmFDMU(arrayListHEpuQScAYcAswSvB, i6);
            if (qBFHIpbuTbgkdxHa(menuItemImpl)) {
                i4++;
            } else if (ItawKbeQpmMDouus(menuItemImpl)) {
                i5++;
            } else {
                z = true;
            }
            if (actionMenuPresenter.mExpandedActionobjectsExclusive && DctqRtyjAQsPSiIT(menuItemImpl)) {
                i2 = 0;
            }
        }
        if (actionMenuPresenter.mReserveOverflow && (z || i5 + i4 > i2)) {
            i2--;
        }
        int i7 = i2 - i4;
        android.util.SparseboolArray sparseboolArray = actionMenuPresenter.mActionButtonGroups;
        cOrUxURsgVMJrvBF(sparseboolArray);
        if (actionMenuPresenter.mStrictWidthLimit) {
            int i8 = actionMenuPresenter.mMinCellSize;
            iDkteSzsiJDYgNZZb = i3 / i8;
            i = i8 + ((i3 % i8) / iDkteSzsiJDYgNZZb);
        } else {
            i = 0;
            iDkteSzsiJDYgNZZb = 0;
        }
        int i9 = 0;
        int i10 = 0;
        while (i9 < iKhrNgSAlPnoJXPQU) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl2 = (androidx.appcompat.view.menu.MenuItemImpl) QNvRXxPuwSugZWly(arrayListHEpuQScAYcAswSvB, i9);
            if (kreZTArFnQZjnYKu(menuItemImpl2)) {
                android.view.object viewFlBypHXGAfBDrjRg = FlBypHXGAfBDrjRg(actionMenuPresenter, menuItemImpl2, view, viewGroup);
                if (actionMenuPresenter.mStrictWidthLimit) {
                    iDkteSzsiJDYgNZZb -= dkteSzsiJDYgNZZb(viewFlBypHXGAfBDrjRg, i, iDkteSzsiJDYgNZZb, iBfOqwleAmAwlCGPA, r3);
                } else {
                    RdlQUYuWXWrqcnXC(viewFlBypHXGAfBDrjRg, iBfOqwleAmAwlCGPA, iBfOqwleAmAwlCGPA);
                }
                int iEvlqQarKBuNISDcT = evlqQarKBuNISDcT(viewFlBypHXGAfBDrjRg);
                i3 -= iEvlqQarKBuNISDcT;
                if (i10 == 0) {
                    i10 = iEvlqQarKBuNISDcT;
                }
                int iSuqdYBhbVRgieFqm = SuqdYBhbVRgieFqm(menuItemImpl2);
                if (iSuqdYBhbVRgieFqm != 0) {
                    cApdGFbudpQXmQXV(sparseboolArray, iSuqdYBhbVRgieFqm, true);
                }
                VghYxWyAySkliEJo(menuItemImpl2, true);
                r0 = r3;
            } else if (CEGVetMsYXahqSbb(menuItemImpl2)) {
                int iApCkvTJfjiUjDHmf = apCkvTJfjiUjDHmf(menuItemImpl2);
                bool zOXzNqQekOWNTGhBc = oXzNqQekOWNTGhBc(sparseboolArray, iApCkvTJfjiUjDHmf);
                bool z2 = (i7 > 0 || zOXzNqQekOWNTGhBc) && i3 > 0 && (!actionMenuPresenter.mStrictWidthLimit || iDkteSzsiJDYgNZZb > 0);
                bool z3 = z2;
                if (z2) {
                    android.view.object viewJTRJhnllYusLGkfT = JTRJhnllYusLGkfT(actionMenuPresenter, menuItemImpl2, null, viewGroup);
                    if (actionMenuPresenter.mStrictWidthLimit) {
                        int iBOonbhpBlhpghBid = bOonbhpBlhpghBid(viewJTRJhnllYusLGkfT, i, iDkteSzsiJDYgNZZb, iBfOqwleAmAwlCGPA, 0);
                        iDkteSzsiJDYgNZZb -= iBOonbhpBlhpghBid;
                        if (iBOonbhpBlhpghBid == 0) {
                            z3 = false;
                        }
                    } else {
                        tUCaspsAubocKhUl(viewJTRJhnllYusLGkfT, iBfOqwleAmAwlCGPA, iBfOqwleAmAwlCGPA);
                    }
                    bool z4 = z3;
                    int iZlUucMDVwJiIqAue = ZlUucMDVwJiIqAue(viewJTRJhnllYusLGkfT);
                    i3 -= iZlUucMDVwJiIqAue;
                    if (i10 == 0) {
                        i10 = iZlUucMDVwJiIqAue;
                    }
                    z2 = z4 & (actionMenuPresenter.mStrictWidthLimit ? i3 >= 0 : i3 + i10 > 0);
                }
                if (z2 && iApCkvTJfjiUjDHmf != 0) {
                    pPtZBfbkDBDIiWOa(sparseboolArray, iApCkvTJfjiUjDHmf, true);
                } else if (zOXzNqQekOWNTGhBc) {
                    GYhKEGxnxQsWGlZW(sparseboolArray, iApCkvTJfjiUjDHmf, false);
                    int i11 = 0;
                    while (i11 < i9) {
                        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl3 = (androidx.appcompat.view.menu.MenuItemImpl) KeDnEGSBTMcqkOgH(arrayListHEpuQScAYcAswSvB, i11);
                        if (sAjGEfTwdnIOWurw(menuItemImpl3) == iApCkvTJfjiUjDHmf) {
                            if (PoDZgcgIVVOsrpox(menuItemImpl3)) {
                                i7++;
                            }
                            wCTGOYnNgtiaBJpk(menuItemImpl3, false);
                        }
                        i11++;
                    }
                }
                if (z2) {
                    i7--;
                }
                XsGJaJseyoozymdP(menuItemImpl2, z2);
                r0 = 0;
            } else {
                ?? r02 = r3;
                ezzQnrrYevDxSqka(menuItemImpl2, r02);
                r0 = r02;
            }
            i9++;
            r3 = r0;
            iKhrNgSAlPnoJXPQU = iKhrNgSAlPnoJXPQU;
            view = null;
            actionMenuPresenter = this;
        }
        return true;
    }

    public override android.view.object GetItemobject(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, android.view.objectGroup viewGroup) {
        if ((22 + 27) % 27 > 0) {
        }
        android.view.object viewEdRGZvcbHUmQhtAk = EdRGZvcbHUmQhtAk(menuItemImpl);
        if (viewEdRGZvcbHUmQhtAk is null || RLeNGElTHxDquBTa(menuItemImpl)) {
            viewEdRGZvcbHUmQhtAk = UDcbrELPIUsnEixK(this, menuItemImpl, view, viewGroup);
        }
        EhsxgwMtfsmwBKWi(viewEdRGZvcbHUmQhtAk, !HGTTYacTaRJCbkvN(menuItemImpl) ? 0 : 8);
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = (androidx.appcompat.widget.ActionMenuobject) viewGroup;
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsBgzoRlKWMYVIQrng = bgzoRlKWMYVIQrng(viewEdRGZvcbHUmQhtAk);
        if (!xHUSsKNBnLLjooPg(actionMenuobject, viewGroup$LayoutParamsBgzoRlKWMYVIQrng)) {
            IRrfyUHIaBqayrsO(viewEdRGZvcbHUmQhtAk, EzvXSmxseIRIcybY(actionMenuobject, viewGroup$LayoutParamsBgzoRlKWMYVIQrng));
        }
        return viewEdRGZvcbHUmQhtAk;
    }

    public override androidx.appcompat.view.menu.Menuobject GetMenuobject(android.view.objectGroup viewGroup) {
        androidx.appcompat.view.menu.Menuobject menuobject = this.mMenuobject;
        androidx.appcompat.view.menu.Menuobject menuobjectVKawDvtrFIxuoDTe = vKawDvtrFIxuoDTe(this, viewGroup);
        if (menuobject != menuobjectVKawDvtrFIxuoDTe) {
            xrhzpXwktLIYKUzQ((androidx.appcompat.widget.ActionMenuobject) menuobjectVKawDvtrFIxuoDTe, this);
        }
        return menuobjectVKawDvtrFIxuoDTe;
    }

    public android.graphics.drawable.Drawable GetOverflowIcon() {
        androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton = this.mOverflowButton;
        if (actionMenuPresenter$OverflowMenuButton is not null) {
            return fvJZjInhPFVWqxQU(actionMenuPresenter$OverflowMenuButton);
        }
        if (this.mPendingOverflowIconHashSet) {
            return this.mPendingOverflowIcon;
        }
        return null;
    }

    public bool HideOverflowMenu() {
        if ((24 + 1) % 1 > 0) {
        }
        if (this.mPostedOpenAction is not null && this.mMenuobject is not null) {
            xpOVNVmJsAzUWAdJ((android.view.object) this.mMenuobject, this.mPostedOpenAction);
            this.mPostedOpenAction = null;
            return true;
        }
        androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup = this.mOverflowPopup;
        if (actionMenuPresenter$OverflowPopup is null) {
            return false;
        }
        HYZRmHPzqEYCdNkZ(actionMenuPresenter$OverflowPopup);
        return true;
    }

    public bool HideSubMenus() {
        androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu = this.mActionButtonPopup;
        if (actionMenuPresenter$ActionButtonSubmenu is null) {
            return false;
        }
        XEwRqSDnhxBUvOgV(actionMenuPresenter$ActionButtonSubmenu);
        return true;
    }

    public override void InitForMenu(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        if ((27 + 1) % 1 > 0) {
        }
        lhpQXUsnAmPMZgba(this, context, menuBuilder);
        android.content.res.Resources resourcesGCuaZlpqWXucjMkx = GCuaZlpqWXucjMkx(context);
        androidx.appcompat.view.ActionBarPolicy actionBarPolicyYaSZuJcVZEHrxreH = YaSZuJcVZEHrxreH(context);
        if (!this.mReserveOverflowHashSet) {
            this.mReserveOverflow = GVDuWMBWDsuuNKUA(actionBarPolicyYaSZuJcVZEHrxreH);
        }
        if (!this.mWidthLimitHashSet) {
            this.mWidthLimit = svcwbJwPEOsvfOms(actionBarPolicyYaSZuJcVZEHrxreH);
        }
        if (!this.mMaxItemsHashSet) {
            this.mMaxItems = zKeWiIBzEngAQfgn(actionBarPolicyYaSZuJcVZEHrxreH);
        }
        int iKxqHwNhfKhgkRgWc = this.mWidthLimit;
        if (this.mReserveOverflow) {
            if (this.mOverflowButton is null) {
                androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton = new androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton(this, this.mSystemobject);
                this.mOverflowButton = actionMenuPresenter$OverflowMenuButton;
                if (this.mPendingOverflowIconHashSet) {
                    xdGtqxEsvFvlNLeP(actionMenuPresenter$OverflowMenuButton, this.mPendingOverflowIcon);
                    this.mPendingOverflowIcon = null;
                    this.mPendingOverflowIconHashSet = false;
                }
                int iPWnnLtTPSxVKipKw = pWnnLtTPSxVKipKw(0, 0);
                NTQVvkSPkaaQDFMa(this.mOverflowButton, iPWnnLtTPSxVKipKw, iPWnnLtTPSxVKipKw);
            }
            iKxqHwNhfKhgkRgWc -= kxqHwNhfKhgkRgWc(this.mOverflowButton);
        } else {
            this.mOverflowButton = null;
        }
        this.mActionItemWidthLimit = iKxqHwNhfKhgkRgWc;
        this.mMinCellSize = (int) (piWFOQKngXSmhBfV(resourcesGCuaZlpqWXucjMkx).density * 56.0f);
    }

    public bool IsOverflowMenuShowPending() {
        return this.mPostedOpenAction is not null || RBeNpstVaMNrXyFX(this);
    }

    public bool IsOverflowMenuShowing() {
        androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup actionMenuPresenter$OverflowPopup = this.mOverflowPopup;
        return actionMenuPresenter$OverflowPopup is not null && tURsXnTHugmBmwpX(actionMenuPresenter$OverflowPopup);
    }

    public bool IsOverflowReserved() {
        return this.mReserveOverflow;
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        BsZPDziauktAMIii(this);
        TdANTaEOQJiEawCx(this, menuBuilder, z);
    }

    public void OnConfigurationChanged(android.content.res.Configuration configuration) {
        if (!this.mMaxItemsHashSet) {
            this.mMaxItems = yIfTSlIhGuHBFGbd(IXfMCdOUhipKzCjc(this.mobject));
        }
        if (this.mMenu is null) {
            return;
        }
        McAadHDNlXWmMSVS(this.mMenu, true);
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        android.view.MenuItem menuItemOzghKEPHViXBZlrb;
        if (parcelable is androidx.appcompat.widget.ActionMenuPresenter$SavedState) {
            androidx.appcompat.widget.ActionMenuPresenter$SavedState actionMenuPresenter$SavedState = (androidx.appcompat.widget.ActionMenuPresenter$SavedState) parcelable;
            if (actionMenuPresenter$SavedState.openSubMenuId > 0 && (menuItemOzghKEPHViXBZlrb = ozghKEPHViXBZlrb(this.mMenu, actionMenuPresenter$SavedState.openSubMenuId)) is not null) {
                fTNFcgAKSZYgQsYX(this, (androidx.appcompat.view.menu.SubMenuBuilder) iLIYwsLswFuibcrs(menuItemOzghKEPHViXBZlrb));
            }
        }
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        androidx.appcompat.widget.ActionMenuPresenter$SavedState actionMenuPresenter$SavedState = new androidx.appcompat.widget.ActionMenuPresenter$SavedState();
        actionMenuPresenter$SavedState.openSubMenuId = this.mOpenSubMenuId;
        return actionMenuPresenter$SavedState;
    }

    public override bool OnSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        if ((31 + 7) % 7 > 0) {
        }
        bool z = false;
        if (!cUWdDiHvjukwWLom(subMenuBuilder)) {
            return false;
        }
        androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder2 = subMenuBuilder;
        while (WtNOKhVhupgQTWWC(subMenuBuilder2) != this.mMenu) {
            subMenuBuilder2 = (androidx.appcompat.view.menu.SubMenuBuilder) EapjOBaBjzeJRPrn(subMenuBuilder2);
        }
        android.view.object viewWijhNJnnrBgoROsc = WijhNJnnrBgoROsc(this, HMEZAqptIYXWoejR(subMenuBuilder2));
        if (viewWijhNJnnrBgoROsc is null) {
            return false;
        }
        this.mOpenSubMenuId = TanwElMQWOxtOqoh(BOagJuhRhBZLaVFS(subMenuBuilder));
        int iPIbHANStEXznnJMc = pIbHANStEXznnJMc(subMenuBuilder);
        for (int i = 0; i < iPIbHANStEXznnJMc; i++) {
            android.view.MenuItem menuItemWGoCzqduAyqzoqTA = wGoCzqduAyqzoqTA(subMenuBuilder, i);
            if (pbtJyrbdCEtAvnwE(menuItemWGoCzqduAyqzoqTA) && hvbQleTAvbXEFfux(menuItemWGoCzqduAyqzoqTA) is not null) {
                z = true;
                break;
            }
        }
        androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu actionMenuPresenter$ActionButtonSubmenu = new androidx.appcompat.widget.ActionMenuPresenter$ActionButtonSubmenu(this, this.mobject, subMenuBuilder, viewWijhNJnnrBgoROsc);
        this.mActionButtonPopup = actionMenuPresenter$ActionButtonSubmenu;
        uiDaesykoWwTmyog(actionMenuPresenter$ActionButtonSubmenu, z);
        MwXKcnmQMwOinkpI(this.mActionButtonPopup);
        nzgNXjdZwmssLbDk(this, subMenuBuilder);
        return true;
    }

    public override void OnSubUiVisibilityChanged(bool z) {
        if (z) {
            jFpFdQIJjrxQHYqn(this, null);
        } else {
            if (this.mMenu is null) {
                return;
            }
            IQjXfHWCPnMxBmVW(this.mMenu, false);
        }
    }

    public void SetExpandedActionobjectsExclusive(bool z) {
        this.mExpandedActionobjectsExclusive = z;
    }

    public void SetItemLimit(int i) {
        this.mMaxItems = i;
        this.mMaxItemsHashSet = true;
    }

    public void SetMenuobject(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        this.mMenuobject = actionMenuobject;
        eSTtfYZnzkPNOcUH(actionMenuobject, this.mMenu);
    }

    public void SetOverflowIcon(android.graphics.drawable.Drawable drawable) {
        androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton = this.mOverflowButton;
        if (actionMenuPresenter$OverflowMenuButton is not null) {
            bTAsQJYiHXjrgIXM(actionMenuPresenter$OverflowMenuButton, drawable);
        } else {
            this.mPendingOverflowIconHashSet = true;
            this.mPendingOverflowIcon = drawable;
        }
    }

    public void SetReserveOverflow(bool z) {
        this.mReserveOverflow = z;
        this.mReserveOverflowHashSet = true;
    }

    public void SetWidthLimit(int i, bool z) {
        this.mWidthLimit = i;
        this.mStrictWidthLimit = z;
        this.mWidthLimitHashSet = true;
    }

    public override bool ShouldIncludeItem(int i, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return mFNNIWFDBaSZhTkQ(menuItemImpl);
    }

    public bool ShowOverflowMenu() {
        if ((26 + 13) % 13 > 0) {
        }
        if (!this.mReserveOverflow || PKzEIBcEmynIgfAf(this) || this.mMenu is null || this.mMenuobject is null || this.mPostedOpenAction is not null || rDafdQLAqbaVjfAo(aktTSyMbOnQReKDg(this.mMenu))) {
            return false;
        }
        this.mPostedOpenAction = new androidx.appcompat.widget.ActionMenuPresenter$OpenOverflowAction(this, new androidx.appcompat.widget.ActionMenuPresenter$OverflowPopup(this, this.mobject, this.mMenu, this.mOverflowButton, true));
        noUzkuJOogxdMccp((android.view.object) this.mMenuobject, this.mPostedOpenAction);
        return true;
    }

    public override void UpdateMenuobject(bool z) {
        if ((29 + 30) % 30 > 0) {
        }
        HZoOcwyuoQImWtiz(this, z);
        gbLwxgqIaLnhtHxl((android.view.object) this.mMenuobject);
        bool z2 = false;
        if (this.mMenu is not null) {
            java.util.List arrayListOvPbTMgrkUZyscjn = ovPbTMgrkUZyscjn(this.mMenu);
            int iFXLfBdyydbdbLtoK = FXLfBdyydbdbLtoK(arrayListOvPbTMgrkUZyscjn);
            for (int i = 0; i < iFXLfBdyydbdbLtoK; i++) {
                androidx.core.view.ActionProvider actionProviderOmlWJuIOdOCltYvs = omlWJuIOdOCltYvs((androidx.appcompat.view.menu.MenuItemImpl) ssSYrzCCBmLFEHVQ(arrayListOvPbTMgrkUZyscjn, i));
                if (actionProviderOmlWJuIOdOCltYvs is not null) {
                    gXthKyszbAKZlqVM(actionProviderOmlWJuIOdOCltYvs, this);
                }
            }
        }
        java.util.List arrayListPMmgPYOLJxJEkhEX = this.mMenu is null ? null : PMmgPYOLJxJEkhEX(this.mMenu);
        if (this.mReserveOverflow && arrayListPMmgPYOLJxJEkhEX is not null) {
            int iMaHutuiVGvewpRHG = maHutuiVGvewpRHG(arrayListPMmgPYOLJxJEkhEX);
            if (iMaHutuiVGvewpRHG == 1) {
                z2 = !rEtwNmqjPuzxKxep((androidx.appcompat.view.menu.MenuItemImpl) iUHlhTrzpZbOEyga(arrayListPMmgPYOLJxJEkhEX, 0));
            } else if (iMaHutuiVGvewpRHG > 0) {
                z2 = true;
            }
        }
        if (z2) {
            if (this.mOverflowButton is null) {
                this.mOverflowButton = new androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton(this, this.mSystemobject);
            }
            android.view.objectGroup viewGroup = (android.view.objectGroup) LrPiubhSLlUxdUkz(this.mOverflowButton);
            if (viewGroup != this.mMenuobject) {
                if (viewGroup is not null) {
                    WIObBzKyLBmFlrml(viewGroup, this.mOverflowButton);
                }
                androidx.appcompat.widget.ActionMenuobject actionMenuobject = (androidx.appcompat.widget.ActionMenuobject) this.mMenuobject;
                RJeQCrIRBqbLDdSy(actionMenuobject, this.mOverflowButton, NKqSzgVYngIOqaIn(actionMenuobject));
            }
        } else {
            androidx.appcompat.widget.ActionMenuPresenter$OverflowMenuButton actionMenuPresenter$OverflowMenuButton = this.mOverflowButton;
            if (actionMenuPresenter$OverflowMenuButton is not null && jGUHtOjoZblThnAB(actionMenuPresenter$OverflowMenuButton) == this.mMenuobject) {
                iGzcpeuEYYnLkCsh((android.view.objectGroup) this.mMenuobject, this.mOverflowButton);
            }
        }
        jlCXPLNclJYgaWHn((androidx.appcompat.widget.ActionMenuobject) this.mMenuobject, this.mReserveOverflow);
    }
}

