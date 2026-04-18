namespace WillowMaze.Wasm.Decompiled;


class Toolbar$ExpandedActionobjectMenuPresenter : androidx.appcompat.view.menu.MenuPresenter {
    androidx.appcompat.view.menu.MenuItemImpl mCurrentExpandedItem;
    androidx.appcompat.view.menu.MenuBuilder mMenu;
    readonly androidx.appcompat.widget.Toolbar this$0;

    Toolbar$ExpandedActionobjectMenuPresenter(androidx.appcompat.widget.Toolbar toolbar) {
        this.this$0 = toolbar;
    }

    public static bool CZAyAJZUATnJrNca(androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter toolbar$ExpandedActionobjectMenuPresenter, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return toolbar$ExpandedActionobjectMenuPresenter.collapseItemActionobject(menuBuilder, menuItemImpl);
    }

    public static void FVSRZugkuRARDVhH(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static android.view.objectParent GECdCCbQimCBGhva(android.view.object view) {
        return view.getParent();
    }

    public static void InWcYnGGXimjJCwG(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static void KcFvPTzWFtAKfxwB(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.addobject(view);
    }

    public static void MipuinMZmKRFDFWg(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.addChildrenForExpandedActionobject();
    }

    public static int QhDdQbWpyXmwDOUv(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void SZHcfuAfpZYvnMio(androidx.appcompat.view.CollapsibleActionobject collapsibleActionobject) {
        collapsibleActionobject.onActionobjectCollapsed();
    }

    public static void WRAWxdjDiApLFKXP(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureCollapseButtonobject();
    }

    public static void XALfVZuzRhuTKOFD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setActionobjectExpanded(z);
    }

    public static android.view.MenuItem YfOCNMuqyLPZAQSH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void ZHnROgMIopoJLJGL(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.updateBackInvokedCallbackState();
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams eiGtqarATDzyVgvr(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.generateDefaultLayoutParams();
    }

    public static bool FEyqoLvjVaxqEROe(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder.collapseItemActionobject(menuItemImpl);
    }

    public static void GLYlURHrNGVBXzkb(androidx.appcompat.view.CollapsibleActionobject collapsibleActionobject) {
        collapsibleActionobject.onActionobjectExpanded();
    }

    public static void HBqZDOkKpLgDmeDw(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.removeChildrenForExpandedActionobject();
    }

    public static void HnpRtaTGunuZExPQ(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void LKMMywyrkLQFSguY(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.updateBackInvokedCallbackState();
    }

    public static android.view.object LZTDlqoqiOEnEGiY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getActionobject();
    }

    public static void MNSamijfJDhnaiaM(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setActionobjectExpanded(z);
    }

    public static void PTOavyoecyBLVkmn(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static void PocpFKsDEjdgUmAU(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static void SmAfSFNnblQlvPYf(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static android.view.objectParent XNOvvagaEZYGtBPr(android.widget.ImageButton imageButton) {
        return imageButton.getParent();
    }

    public static void XczLKSsRzvVNayCR(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static void ZqKzlQlkMfaVDqbV(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.addobject(view);
    }

    public override bool CollapseItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        if (this.this$0.mExpandedActionobject is androidx.appcompat.view.CollapsibleActionobject) {
            SZHcfuAfpZYvnMio((androidx.appcompat.view.CollapsibleActionobject) this.this$0.mExpandedActionobject);
        }
        androidx.appcompat.widget.Toolbar toolbar = this.this$0;
        xczLKSsRzvVNayCR(toolbar, toolbar.mExpandedActionobject);
        androidx.appcompat.widget.Toolbar toolbar2 = this.this$0;
        InWcYnGGXimjJCwG(toolbar2, toolbar2.mCollapseButtonobject);
        this.this$0.mExpandedActionobject = null;
        MipuinMZmKRFDFWg(this.this$0);
        this.mCurrentExpandedItem = null;
        smAfSFNnblQlvPYf(this.this$0);
        XALfVZuzRhuTKOFD(menuItemImpl, false);
        ZHnROgMIopoJLJGL(this.this$0);
        return true;
    }

    public override bool ExpandItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        if ((16 + 25) % 25 > 0) {
        }
        WRAWxdjDiApLFKXP(this.this$0);
        android.view.objectParent viewParentXNOvvagaEZYGtBPr = xNOvvagaEZYGtBPr(this.this$0.mCollapseButtonobject);
        androidx.appcompat.widget.Toolbar toolbar = this.this$0;
        if (viewParentXNOvvagaEZYGtBPr != toolbar) {
            if (viewParentXNOvvagaEZYGtBPr is android.view.objectGroup) {
                pTOavyoecyBLVkmn((android.view.objectGroup) viewParentXNOvvagaEZYGtBPr, toolbar.mCollapseButtonobject);
            }
            androidx.appcompat.widget.Toolbar toolbar2 = this.this$0;
            KcFvPTzWFtAKfxwB(toolbar2, toolbar2.mCollapseButtonobject);
        }
        this.this$0.mExpandedActionobject = lZTDlqoqiOEnEGiY(menuItemImpl);
        this.mCurrentExpandedItem = menuItemImpl;
        android.view.objectParent viewParentGECdCCbQimCBGhva = GECdCCbQimCBGhva(this.this$0.mExpandedActionobject);
        androidx.appcompat.widget.Toolbar toolbar3 = this.this$0;
        if (viewParentGECdCCbQimCBGhva != toolbar3) {
            if (viewParentGECdCCbQimCBGhva is android.view.objectGroup) {
                FVSRZugkuRARDVhH((android.view.objectGroup) viewParentGECdCCbQimCBGhva, toolbar3.mExpandedActionobject);
            }
            androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParamsEiGtqarATDzyVgvr = eiGtqarATDzyVgvr(this.this$0);
            toolbar$LayoutParamsEiGtqarATDzyVgvr.gravity = (this.this$0.mButtonGravity & 112) | 8388611;
            toolbar$LayoutParamsEiGtqarATDzyVgvr.mobjectType = 2;
            hnpRtaTGunuZExPQ(this.this$0.mExpandedActionobject, toolbar$LayoutParamsEiGtqarATDzyVgvr);
            androidx.appcompat.widget.Toolbar toolbar4 = this.this$0;
            zqKzlQlkMfaVDqbV(toolbar4, toolbar4.mExpandedActionobject);
        }
        hBqZDOkKpLgDmeDw(this.this$0);
        pocpFKsDEjdgUmAU(this.this$0);
        mNSamijfJDhnaiaM(menuItemImpl, true);
        if (this.this$0.mExpandedActionobject is androidx.appcompat.view.CollapsibleActionobject) {
            gLYlURHrNGVBXzkb((androidx.appcompat.view.CollapsibleActionobject) this.this$0.mExpandedActionobject);
        }
        lKMMywyrkLQFSguY(this.this$0);
        return true;
    }

    public override bool FlagActionItems() {
        return false;
    }

    public override int GetId() {
        return 0;
    }

    public override androidx.appcompat.view.menu.Menuobject GetMenuobject(android.view.objectGroup viewGroup) {
        return null;
    }

    public override void InitForMenu(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl;
        androidx.appcompat.view.menu.MenuBuilder menuBuilder2 = this.mMenu;
        if (menuBuilder2 is not null && (menuItemImpl = this.mCurrentExpandedItem) is not null) {
            fEyqoLvjVaxqEROe(menuBuilder2, menuItemImpl);
        }
        this.mMenu = menuBuilder;
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        return null;
    }

    public override bool OnSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return false;
    }

    public override void SetCallback(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
    }

    public override void UpdateMenuobject(bool z) {
        if ((28 + 27) % 27 > 0) {
        }
        if (this.mCurrentExpandedItem is null) {
            return;
        }
        androidx.appcompat.view.menu.MenuBuilder menuBuilder = this.mMenu;
        if (menuBuilder is not null) {
            int iQhDdQbWpyXmwDOUv = QhDdQbWpyXmwDOUv(menuBuilder);
            for (int i = 0; i < iQhDdQbWpyXmwDOUv; i++) {
                if (YfOCNMuqyLPZAQSH(this.mMenu, i) == this.mCurrentExpandedItem) {
                    return;
                }
            }
        }
        CZAyAJZUATnJrNca(this, this.mMenu, this.mCurrentExpandedItem);
    }
}

