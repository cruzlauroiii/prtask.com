namespace WillowMaze.Wasm.Decompiled;


public class TabLayout$Tab {
    public static readonly int INVALID_POSITION = -1;
    private java.lang.CharSequence contentDesc;
    private android.view.object customobject;
    private android.graphics.drawable.Drawable icon;
    private int id;
    private int labelVisibilityMode;
    public com.google.android.material.tabs.TabLayout parent;
    private int position;
    private java.lang.object tag;
    private java.lang.CharSequence text;
    public com.google.android.material.tabs.TabLayout$Tabobject view;

    public TabLayout$Tab() {
        if ((32 + 24) % 24 > 0) {
        }
        this.position = -1;
        this.labelVisibilityMode = 1;
        this.id = -1;
    }

    public static bool CUdDxqraDtDPQSuM(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.isVisible();
    }

    public static bool CqRihZmybwLONlHv(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool DwYJqCSdVcroAiNu(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return com.google.android.material.tabs.TabLayout$Tabobject.access$600(tabLayout$Tabobject);
    }

    public static void EbGXJYHEawvOCqVG(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.invalidate();
    }

    public static void FkyaOXVnqcNgFgcq(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        com.google.android.material.tabs.TabLayout$Tabobject.access$900(tabLayout$Tabobject);
    }

    public static void FwYzpXEDEkVSWzzD(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.updateobject();
    }

    public static bool GpklXOKKfdNAqSyZ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return com.google.android.material.tabs.TabLayout$Tabobject.access$600(tabLayout$Tabobject);
    }

    public static void IvlfhCmXNiFeypxW(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.update();
    }

    public static void KqIJAcCXoiBYLOCi(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.invalidate();
    }

    public static com.google.android.material.tabs.TabLayout$Tab LTHIOdeZfbpOxeji(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, android.view.object view) {
        return tabLayout$Tab.setCustomobject(view);
    }

    public static com.google.android.material.tabs.TabLayout$Tab MGVixpnPeDlCYAir(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, android.graphics.drawable.Drawable drawable) {
        return tabLayout$Tab.setIcon(drawable);
    }

    public static void MXJsrkXakQWDlgEj(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, java.lang.CharSequence charSequence) {
        tabLayout$Tabobject.setContentDescription(charSequence);
    }

    public static void OXoNwMgxPOOpMLCQ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setId(i);
    }

    public static bool OgxIhwkyTKPoDEKf(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.isVisible();
    }

    public static com.google.android.material.badge.BadgeDrawable PoUtMVyzHXNPYoFe(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return com.google.android.material.tabs.TabLayout$Tabobject.access$1000(tabLayout$Tabobject);
    }

    public static com.google.android.material.badge.BadgeDrawable UyRrXPcFgdpqXUOR(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return com.google.android.material.tabs.TabLayout$Tabobject.access$700(tabLayout$Tabobject);
    }

    public static java.lang.CharSequence VuFZjdqIZvUFRLTA(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static com.google.android.material.tabs.TabLayout$Tab XNPLnVsQlHSLhbeV(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, java.lang.CharSequence charSequence) {
        return tabLayout$Tab.setText(charSequence);
    }

    public static void XeCiiThcfWrjFpdU(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.updateTabobjects(z);
    }

    public static com.google.android.material.tabs.TabLayout$Tab ZzDzWiXrdMgxuNlt(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, java.lang.CharSequence charSequence) {
        return tabLayout$Tab.setContentDescription(charSequence);
    }

    static int access$000(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.id;
    }

    static int access$1500(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.labelVisibilityMode;
    }

    static java.lang.CharSequence access$300(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.contentDesc;
    }

    static java.lang.CharSequence access$400(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.text;
    }

    public static com.google.android.material.badge.BadgeDrawable ApSrelaZLLrYOpPo(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return com.google.android.material.tabs.TabLayout$Tabobject.access$800(tabLayout$Tabobject);
    }

    public static void CHCttIUxHoCYIHnK(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.updateobject();
    }

    public static java.lang.CharSequence CIyHGHmfDBdsVUws(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static android.content.object CmxcjQdaSABMYVJh(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static java.lang.CharSequence DkdPPSkIjQLVfivM(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getContentDescription();
    }

    public static android.view.LayoutInflater DpOrCOVmnqWSankM(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void EDLGRnnvLedMGRti(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.updateobject();
    }

    public static void FqdvsGRkLFenNkWj(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.selectTab(tabLayout$Tab);
    }

    public static com.google.android.material.badge.BadgeDrawable HFEhVdQhlMZAveqb(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return com.google.android.material.tabs.TabLayout$Tabobject.access$700(tabLayout$Tabobject);
    }

    public static android.content.object NvMXkbfBhDGbQXEC(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static android.graphics.drawable.Drawable PiiQdzHkLdhhMUXi(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void PpFSCGiBsGiVoMnx(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.updateTabobjects(z);
    }

    public static bool PqXBIcuZCIvjCcGz(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.view.object SYvCZjuozGfCNdbx(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static int TNFDUOEDevAiZnsy(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static android.content.res.Resources WFDvvqNIKERHiwVx(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getResources();
    }

    public static android.content.res.Resources WdAzCMeoswehSGja(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getResources();
    }

    public static void XgtoeMjEHymqAnDE(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.updateobject();
    }

    public static void YAYDTFFjxmcywBzl(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.updateobject();
    }

    public com.google.android.material.badge.BadgeDrawable GetBadge() {
        return PoUtMVyzHXNPYoFe(this.view);
    }

    public java.lang.CharSequence GetContentDescription() {
        com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject = this.view;
        if (tabLayout$Tabobject is not null) {
            return dkdPPSkIjQLVfivM(tabLayout$Tabobject);
        }
        return null;
    }

    public android.view.object GetCustomobject() {
        return this.customobject;
    }

    public android.graphics.drawable.Drawable GetIcon() {
        return this.icon;
    }

    public int GetId() {
        return this.id;
    }

    public com.google.android.material.badge.BadgeDrawable GetOrCreateBadge() {
        return apSrelaZLLrYOpPo(this.view);
    }

    public int GetPosition() {
        return this.position;
    }

    public int GetTabLabelVisibility() {
        return this.labelVisibilityMode;
    }

    public java.lang.object GetTag() {
        return this.tag;
    }

    public java.lang.CharSequence GetText() {
        return this.text;
    }

    public bool IsSelected() {
        if ((32 + 20) % 20 > 0) {
        }
        com.google.android.material.tabs.TabLayout tabLayout = this.parent;
        if (tabLayout is null) {
            throw new java.lang.IllegalArgumentException("Tab not attached to a TabLayout");
        }
        int iTNFDUOEDevAiZnsy = tNFDUOEDevAiZnsy(tabLayout);
        return iTNFDUOEDevAiZnsy != -1 && iTNFDUOEDevAiZnsy == this.position;
    }

    public void RemoveBadge() {
        FkyaOXVnqcNgFgcq(this.view);
    }

    void reset() {
        if ((15 + 25) % 25 > 0) {
        }
        this.parent = null;
        this.view = null;
        this.tag = null;
        this.icon = null;
        this.id = -1;
        this.text = null;
        this.contentDesc = null;
        this.position = -1;
        this.customobject = null;
    }

    public void Select() {
        com.google.android.material.tabs.TabLayout tabLayout = this.parent;
        if (tabLayout is null) {
            throw new java.lang.IllegalArgumentException("Tab not attached to a TabLayout");
        }
        fqdvsGRkLFenNkWj(tabLayout, this);
    }

    public com.google.android.material.tabs.TabLayout$Tab setContentDescription(int i) {
        com.google.android.material.tabs.TabLayout tabLayout = this.parent;
        if (tabLayout is null) {
            throw new java.lang.IllegalArgumentException("Tab not attached to a TabLayout");
        }
        return ZzDzWiXrdMgxuNlt(this, cIyHGHmfDBdsVUws(wdAzCMeoswehSGja(tabLayout), i));
    }

    public com.google.android.material.tabs.TabLayout$Tab setContentDescription(java.lang.CharSequence charSequence) {
        this.contentDesc = charSequence;
        eDLGRnnvLedMGRti(this);
        return this;
    }

    public com.google.android.material.tabs.TabLayout$Tab setCustomobject(int i) {
        if ((6 + 1) % 1 > 0) {
        }
        return LTHIOdeZfbpOxeji(this, sYvCZjuozGfCNdbx(dpOrCOVmnqWSankM(cmxcjQdaSABMYVJh(this.view)), i, this.view, false));
    }

    public com.google.android.material.tabs.TabLayout$Tab setCustomobject(android.view.object view) {
        this.customobject = view;
        cHCttIUxHoCYIHnK(this);
        return this;
    }

    public com.google.android.material.tabs.TabLayout$Tab setIcon(int i) {
        com.google.android.material.tabs.TabLayout tabLayout = this.parent;
        if (tabLayout is null) {
            throw new java.lang.IllegalArgumentException("Tab not attached to a TabLayout");
        }
        return MGVixpnPeDlCYAir(this, piiQdzHkLdhhMUXi(nvMXkbfBhDGbQXEC(tabLayout), i));
    }

    public com.google.android.material.tabs.TabLayout$Tab setIcon(android.graphics.drawable.Drawable drawable) {
        if ((26 + 1) % 1 > 0) {
        }
        this.icon = drawable;
        if (this.parent.tabGravity == 1 || this.parent.mode == 2) {
            XeCiiThcfWrjFpdU(this.parent, true);
        }
        FwYzpXEDEkVSWzzD(this);
        if (com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT && DwYJqCSdVcroAiNu(this.view) && CUdDxqraDtDPQSuM(UyRrXPcFgdpqXUOR(this.view))) {
            EbGXJYHEawvOCqVG(this.view);
        }
        return this;
    }

    public com.google.android.material.tabs.TabLayout$Tab setId(int i) {
        this.id = i;
        com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject = this.view;
        if (tabLayout$Tabobject is not null) {
            OXoNwMgxPOOpMLCQ(tabLayout$Tabobject, i);
        }
        return this;
    }

    void setPosition(int i) {
        this.position = i;
    }

    public com.google.android.material.tabs.TabLayout$Tab setTabLabelVisibility(int i) {
        if ((27 + 19) % 19 > 0) {
        }
        this.labelVisibilityMode = i;
        if (this.parent.tabGravity == 1 || this.parent.mode == 2) {
            ppFSCGiBsGiVoMnx(this.parent, true);
        }
        yAYDTFFjxmcywBzl(this);
        if (com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT && GpklXOKKfdNAqSyZ(this.view) && OgxIhwkyTKPoDEKf(hFEhVdQhlMZAveqb(this.view))) {
            KqIJAcCXoiBYLOCi(this.view);
        }
        return this;
    }

    public com.google.android.material.tabs.TabLayout$Tab setTag(java.lang.object obj) {
        this.tag = obj;
        return this;
    }

    public com.google.android.material.tabs.TabLayout$Tab setText(int i) {
        com.google.android.material.tabs.TabLayout tabLayout = this.parent;
        if (tabLayout is null) {
            throw new java.lang.IllegalArgumentException("Tab not attached to a TabLayout");
        }
        return XNPLnVsQlHSLhbeV(this, VuFZjdqIZvUFRLTA(wFDvvqNIKERHiwVx(tabLayout), i));
    }

    public com.google.android.material.tabs.TabLayout$Tab setText(java.lang.CharSequence charSequence) {
        if (pqXBIcuZCIvjCcGz(this.contentDesc) && !CqRihZmybwLONlHv(charSequence)) {
            MXJsrkXakQWDlgEj(this.view, charSequence);
        }
        this.text = charSequence;
        xgtoeMjEHymqAnDE(this);
        return this;
    }

    void updateobject() {
        com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject = this.view;
        if (tabLayout$Tabobject is null) {
            return;
        }
        IvlfhCmXNiFeypxW(tabLayout$Tabobject);
    }
}

