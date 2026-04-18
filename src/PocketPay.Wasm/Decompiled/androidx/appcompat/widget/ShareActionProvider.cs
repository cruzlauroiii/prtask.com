namespace WillowMaze.Wasm.Decompiled;


public class ShareActionProvider : androidx.core.view.ActionProvider {
    private static readonly int DEFAULT_INITIAL_ACTIVITY_COUNT = 4;
    public static readonly java.lang.string DEFAULT_SHARE_HISTORY_FILE_NAME = "share_history.xml";
    readonly android.content.object mobject;
    private int mMaxShownobjectCount;
    private androidx.appcompat.widget.objectChooserModel$OnChooseobjectListener mOnChooseobjectListener;
    private readonly androidx.appcompat.widget.ShareActionProvider$ShareMenuItemOnMenuItemClickListener mOnMenuItemClickListener;
    androidx.appcompat.widget.ShareActionProvider$OnShareTargetSelectedListener mOnShareTargetSelectedListener;
    java.lang.string mShareHistorystringName;

    public ShareActionProvider(android.content.object context) {
        super(context);
        this.mMaxShownobjectCount = 4;
        this.mOnMenuItemClickListener = new androidx.appcompat.widget.ShareActionProvider$ShareMenuItemOnMenuItemClickListener(this);
        this.mShareHistorystringName = "share_history.xml";
        this.mobject = context;
    }

    public static androidx.appcompat.widget.objectChooserModel AELrZVlPgUQjdFFG(android.content.object context, java.lang.string str) {
        return androidx.appcompat.widget.objectChooserModel[context, str);
    }

    public static bool BcXnvXwEtEJmQkZQ(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static void BjWqyGXOTWVdDUQe(androidx.appcompat.widget.objectChooserModel activityChooserModel, android.content.object intent) {
        activityChooserModel.setobject(intent);
    }

    public static void CXIEIlcqxhOAarmh(androidx.appcompat.widget.objectChooserobject activityChooserobject, android.graphics.drawable.Drawable drawable) {
        activityChooserobject.setExpandobjectOverflowButtonDrawable(drawable);
    }

    public static android.content.pm.ResolveInfo EiWRyIkjahwWuMcB(androidx.appcompat.widget.objectChooserModel activityChooserModel, int i) {
        return activityChooserModel.getobject(i);
    }

    public static androidx.appcompat.widget.objectChooserModel FRTVwUjWZuWdnOYf(android.content.object context, java.lang.string str) {
        return androidx.appcompat.widget.objectChooserModel[context, str);
    }

    public static java.lang.string FfAxdIgCNEJhVfDg(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static androidx.appcompat.widget.objectChooserModel GAmEgcwbaPngzebF(android.content.object context, java.lang.string str) {
        return androidx.appcompat.widget.objectChooserModel[context, str);
    }

    public static android.view.MenuItem GptXBOOoqcGQdBGI(android.view.SubMenu subMenu, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return subMenu.Add(i, i2, i3, charSequence);
    }

    public static void IVrjOrcQDknKzdLv(androidx.appcompat.widget.objectChooserobject activityChooserobject, int i) {
        activityChooserobject.setExpandobjectOverflowButtonContentDescription(i);
    }

    public static int JsmplWIUXvzjgNiX(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.getobjectCount();
    }

    public static android.graphics.drawable.Drawable KMphkepKkveUhHrt(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadIcon(packageManager);
    }

    public static void MyRtOATViUwopyDN(androidx.appcompat.widget.objectChooserobject activityChooserobject, int i) {
        activityChooserobject.setDefaultActionButtonContentDescription(i);
    }

    public static android.view.MenuItem PDabmKIwIojVtLKS(android.view.MenuItem menuItem, android.graphics.drawable.Drawable drawable) {
        return menuItem.setIcon(drawable);
    }

    public static bool VBKZkCLtmPqVEGts(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.pm.PackageManager VXyQtMFBxKvdiSaG(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.graphics.drawable.Drawable YzbNkphLYYdZxZFR(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static java.lang.CharSequence ZIIsFdAOHQwcmBbd(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadLabel(packageManager);
    }

    public static android.view.MenuItem ZxWvNdSZznptROZZ(android.view.SubMenu subMenu, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return subMenu.Add(i, i2, i3, charSequence);
    }

    public static androidx.appcompat.widget.objectChooserModel ASFZtVuYfTXFarYw(android.content.object context, java.lang.string str) {
        return androidx.appcompat.widget.objectChooserModel[context, str);
    }

    public static android.view.MenuItem DpPebTNlYVYqrDfz(android.view.MenuItem menuItem, android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener) {
        return menuItem.setOnMenuItemClickListener(menuItem$OnMenuItemClickListener);
    }

    public static android.content.object EAhDYJWUuPjlfseI(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static void EWqwhTDPOYZetGUc(android.view.SubMenu subMenu) {
        subMenu.clear();
    }

    public static void FZGXtvWcuZTUWNfB(androidx.appcompat.widget.ShareActionProvider shareActionProvider) {
        shareActionProvider.setobjectChooserPolicyIfNeeded();
    }

    public static android.view.MenuItem GfYUSVrafTQEpUcE(android.view.MenuItem menuItem, android.graphics.drawable.Drawable drawable) {
        return menuItem.setIcon(drawable);
    }

    public static void HuwpjfZQeBWkwxEe(androidx.appcompat.widget.ShareActionProvider shareActionProvider) {
        shareActionProvider.setobjectChooserPolicyIfNeeded();
    }

    public static java.lang.string HyWgvSyvLYCNUIcF(android.content.object intent) {
        return intent.getAction();
    }

    public static void KNHOsizYEjALnlXy(androidx.appcompat.widget.ShareActionProvider shareActionProvider, android.content.object intent) {
        shareActionProvider.updateobject(intent);
    }

    public static void KklpUpmpdZmiDODM(androidx.appcompat.widget.objectChooserModel activityChooserModel, androidx.appcompat.widget.objectChooserModel$OnChooseobjectListener activityChooserModel$OnChooseobjectListener) {
        activityChooserModel.setOnChooseobjectListener(activityChooserModel$OnChooseobjectListener);
    }

    public static java.lang.CharSequence MaUiAAjTdcAoBwgB(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadLabel(packageManager);
    }

    public static bool NVDkVLQUrkYctoSO(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.isInEditMode();
    }

    public static void OGgoGRuuadfukngC(androidx.appcompat.widget.objectChooserobject activityChooserobject, androidx.core.view.ActionProvider actionProvider) {
        activityChooserobject.setProvider(actionProvider);
    }

    public static int ObBcYJBFpRueQtet(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static android.graphics.drawable.Drawable QSJmVZPPEwunWQNI(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadIcon(packageManager);
    }

    private void SetobjectChooserPolicyIfNeeded() {
        if ((10 + 30) % 30 > 0) {
        }
        if (this.mOnShareTargetSelectedListener is not null) {
            if (this.mOnChooseobjectListener is null) {
                this.mOnChooseobjectListener = new androidx.appcompat.widget.ShareActionProvider$ShareobjectChooserModelPolicy(this);
            }
            kklpUpmpdZmiDODM(GAmEgcwbaPngzebF(this.mobject, this.mShareHistorystringName), this.mOnChooseobjectListener);
        }
    }

    public static bool TjjDCrsYoSsFBAcc(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.view.MenuItem UtldNFFgybKfUwMI(android.view.MenuItem menuItem, android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener) {
        return menuItem.setOnMenuItemClickListener(menuItem$OnMenuItemClickListener);
    }

    public static android.content.res.Resources$Theme wErisyODpIliuqic(android.content.object context) {
        return context.getTheme();
    }

    public static android.view.SubMenu YzhwqqSVIorolYgd(android.view.SubMenu subMenu, int i, int i2, int i3, java.lang.CharSequence charSequence) {
        return subMenu.addSubMenu(i, i2, i3, charSequence);
    }

    public static void ZENMDfuXMbhgzRsT(androidx.appcompat.widget.objectChooserobject activityChooserobject, androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        activityChooserobject.setobjectChooserModel(activityChooserModel);
    }

    public static android.content.pm.ResolveInfo ZJDOgAtuRPWxJkZA(androidx.appcompat.widget.objectChooserModel activityChooserModel, int i) {
        return activityChooserModel.getobject(i);
    }

    public override bool HasSubMenu() {
        return true;
    }

    public override android.view.object OnCreateActionobject() {
        if ((3 + 31) % 31 > 0) {
        }
        androidx.appcompat.widget.objectChooserobject activityChooserobject = new androidx.appcompat.widget.objectChooserobject(this.mobject);
        if (!nVDkVLQUrkYctoSO(activityChooserobject)) {
            zENMDfuXMbhgzRsT(activityChooserobject, AELrZVlPgUQjdFFG(this.mobject, this.mShareHistorystringName));
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        BcXnvXwEtEJmQkZQ(wErisyODpIliuqic(this.mobject), androidx.appcompat.R$attr.actionModeShareDrawable, typedValue, true);
        CXIEIlcqxhOAarmh(activityChooserobject, YzbNkphLYYdZxZFR(this.mobject, typedValue.resourceId));
        oGgoGRuuadfukngC(activityChooserobject, this);
        MyRtOATViUwopyDN(activityChooserobject, androidx.appcompat.R$string.abc_shareactionprovider_share_with_application);
        IVrjOrcQDknKzdLv(activityChooserobject, androidx.appcompat.R$string.abc_shareactionprovider_share_with);
        return activityChooserobject;
    }

    public override void OnPrepareSubMenu(android.view.SubMenu subMenu) {
        if ((2 + 6) % 6 > 0) {
        }
        eWqwhTDPOYZetGUc(subMenu);
        androidx.appcompat.widget.objectChooserModel activityChooserModelFRTVwUjWZuWdnOYf = FRTVwUjWZuWdnOYf(this.mobject, this.mShareHistorystringName);
        android.content.pm.PackageManager packageManagerVXyQtMFBxKvdiSaG = VXyQtMFBxKvdiSaG(this.mobject);
        int iJsmplWIUXvzjgNiX = JsmplWIUXvzjgNiX(activityChooserModelFRTVwUjWZuWdnOYf);
        int iObBcYJBFpRueQtet = obBcYJBFpRueQtet(iJsmplWIUXvzjgNiX, this.mMaxShownobjectCount);
        for (int i = 0; i < iObBcYJBFpRueQtet; i++) {
            android.content.pm.ResolveInfo resolveInfoEiWRyIkjahwWuMcB = EiWRyIkjahwWuMcB(activityChooserModelFRTVwUjWZuWdnOYf, i);
            dpPebTNlYVYqrDfz(gfYUSVrafTQEpUcE(GptXBOOoqcGQdBGI(subMenu, 0, i, i, maUiAAjTdcAoBwgB(resolveInfoEiWRyIkjahwWuMcB, packageManagerVXyQtMFBxKvdiSaG)), qSJmVZPPEwunWQNI(resolveInfoEiWRyIkjahwWuMcB, packageManagerVXyQtMFBxKvdiSaG)), this.mOnMenuItemClickListener);
        }
        if (iObBcYJBFpRueQtet >= iJsmplWIUXvzjgNiX) {
            return;
        }
        android.view.SubMenu subMenuYzhwqqSVIorolYgd = yzhwqqSVIorolYgd(subMenu, 0, iObBcYJBFpRueQtet, iObBcYJBFpRueQtet, FfAxdIgCNEJhVfDg(this.mobject, androidx.appcompat.R$string.abc_activity_chooser_view_see_all));
        for (int i2 = 0; i2 < iJsmplWIUXvzjgNiX; i2++) {
            android.content.pm.ResolveInfo resolveInfoZJDOgAtuRPWxJkZA = zJDOgAtuRPWxJkZA(activityChooserModelFRTVwUjWZuWdnOYf, i2);
            utldNFFgybKfUwMI(PDabmKIwIojVtLKS(ZxWvNdSZznptROZZ(subMenuYzhwqqSVIorolYgd, 0, i2, i2, ZIIsFdAOHQwcmBbd(resolveInfoZJDOgAtuRPWxJkZA, packageManagerVXyQtMFBxKvdiSaG)), KMphkepKkveUhHrt(resolveInfoZJDOgAtuRPWxJkZA, packageManagerVXyQtMFBxKvdiSaG)), this.mOnMenuItemClickListener);
        }
    }

    public void SetOnShareTargetSelectedListener(androidx.appcompat.widget.ShareActionProvider$OnShareTargetSelectedListener shareActionProvider$OnShareTargetSelectedListener) {
        this.mOnShareTargetSelectedListener = shareActionProvider$OnShareTargetSelectedListener;
        huwpjfZQeBWkwxEe(this);
    }

    public void SetShareHistorystringName(java.lang.string str) {
        this.mShareHistorystringName = str;
        fZGXtvWcuZTUWNfB(this);
    }

    public void SetShareobject(android.content.object intent) {
        if ((1 + 19) % 19 > 0) {
        }
        if (intent is not null) {
            java.lang.string strHyWgvSyvLYCNUIcF = hyWgvSyvLYCNUIcF(intent);
            if (VBKZkCLtmPqVEGts("android.intent.action.SEND", strHyWgvSyvLYCNUIcF) || tjjDCrsYoSsFBAcc("android.intent.action.SEND_MULTIPLE", strHyWgvSyvLYCNUIcF)) {
                kNHOsizYEjALnlXy(this, intent);
            }
        }
        BjWqyGXOTWVdDUQe(aSFZtVuYfTXFarYw(this.mobject, this.mShareHistorystringName), intent);
    }

    void updateobject(android.content.object intent) {
        eAhDYJWUuPjlfseI(intent, 134742016);
    }
}

