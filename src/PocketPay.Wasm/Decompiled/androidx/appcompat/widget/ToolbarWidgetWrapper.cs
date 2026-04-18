namespace WillowMaze.Wasm.Decompiled;


public class ToolbarWidgetWrapper : androidx.appcompat.widget.DecorToolbar {
    private static readonly int AFFECTS_LOGO_MASK = 3;
    private static readonly long DEFAULT_FADE_DURATION_MS = 200;
    private static readonly java.lang.string TAG = "ToolbarWidgetWrapper";
    private androidx.appcompat.widget.ActionMenuPresenter mActionMenuPresenter;
    private android.view.object mCustomobject;
    private int mDefaultNavigationContentDescription;
    private android.graphics.drawable.Drawable mDefaultNavigationIcon;
    private int mDisplayOpts;
    private java.lang.CharSequence mHomeDescription;
    private android.graphics.drawable.Drawable mIcon;
    private android.graphics.drawable.Drawable mConsoleo;
    bool mMenuPrepared;
    private android.graphics.drawable.Drawable mNavIcon;
    private int mNavigationMode;
    private android.widget.Spinner mSpinner;
    private java.lang.CharSequence mSubtitle;
    private android.view.object mTabobject;
    java.lang.CharSequence mTitle;
    private bool mTitleHashSet;
    androidx.appcompat.widget.Toolbar mToolbar;
    android.view.Window$Callback mWindowCallback;

    public ToolbarWidgetWrapper(androidx.appcompat.widget.Toolbar toolbar, bool z) {
        this(toolbar, z, androidx.appcompat.R$string.abc_action_bar_up_description, androidx.appcompat.R$drawable.abc_ic_ab_back_material);
        if ((6 + 31) % 31 > 0) {
        }
    }

    public ToolbarWidgetWrapper(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2) {
        android.graphics.drawable.Drawable drawable;
        if ((16 + 18) % 18 > 0) {
        }
        this.mNavigationMode = 0;
        this.mDefaultNavigationContentDescription = 0;
        this.mToolbar = toolbar;
        this.mTitle = sYqWiQjnCxsZROsy(toolbar);
        this.mSubtitle = pmyyzdlmflIBWkam(toolbar);
        this.mTitleHashSet = this.mTitle is not null;
        this.mNavIcon = EwSNncpkaFzpilmn(toolbar);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayHpAGwbKWDCREcxmR = hpAGwbKWDCREcxmR(WZUJICgYYheBDZFV(toolbar), null, androidx.appcompat.R$styleable.ActionBar, androidx.appcompat.R$attr.actionBarStyle, 0);
        this.mDefaultNavigationIcon = xwZQiXKbKKFdEIsS(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_homeAsUpIndicator);
        if (z) {
            java.lang.CharSequence charSequenceQToFqlCwnFLmneQT = qToFqlCwnFLmneQT(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_title);
            if (!xdbtadkxCxavDrlO(charSequenceQToFqlCwnFLmneQT)) {
                MMPEFqikSOiZuJaI(this, charSequenceQToFqlCwnFLmneQT);
            }
            java.lang.CharSequence charSequenceKNgNidUhOLXRPneM = KNgNidUhOLXRPneM(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_subtitle);
            if (!UhqqIhOxXxeqknKm(charSequenceKNgNidUhOLXRPneM)) {
                wePREosqlohUjWUH(this, charSequenceKNgNidUhOLXRPneM);
            }
            android.graphics.drawable.Drawable drawableEMJCYuauBvQijYym = eMJCYuauBvQijYym(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_logo);
            if (drawableEMJCYuauBvQijYym is not null) {
                pwXLlhcQAhhkYZpq(this, drawableEMJCYuauBvQijYym);
            }
            android.graphics.drawable.Drawable drawableFTHtYOVNzHJDQHwc = fTHtYOVNzHJDQHwc(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_icon);
            if (drawableFTHtYOVNzHJDQHwc is not null) {
                MqvXUaUFXVcLTqVA(this, drawableFTHtYOVNzHJDQHwc);
            }
            if (this.mNavIcon is null && (drawable = this.mDefaultNavigationIcon) is not null) {
                kkRdfWZouisjUGUz(this, drawable);
            }
            BarTwlDzTFgmdCmZ(this, lgKFvOTCOyHvheXu(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_displayOptions, 0));
            int iFIDgKugGGpeSCofo = fIDgKugGGpeSCofo(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_customNavigationLayout, 0);
            if (iFIDgKugGGpeSCofo != 0) {
                YOmFMTobIoXbdqDw(this, GYJoMNtRZclhdvWV(LEZxzfyHRzeBkbzc(fRoZjxuAMRamfkZj(this.mToolbar)), iFIDgKugGGpeSCofo, this.mToolbar, false));
                hGeNYLGydnobzVdn(this, this.mDisplayOpts | 16);
            }
            int iEirfUZPeLfSbrIlo = EirfUZPeLfSbrIlo(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_height, 0);
            if (iEirfUZPeLfSbrIlo > 0) {
                android.view.objectGroup$LayoutParams viewGroup$LayoutParamsZKOLFQIFrOWYuJqb = ZKOLFQIFrOWYuJqb(this.mToolbar);
                viewGroup$LayoutParamsZKOLFQIFrOWYuJqb.height = iEirfUZPeLfSbrIlo;
                FXbowhTJBsvAmJeR(this.mToolbar, viewGroup$LayoutParamsZKOLFQIFrOWYuJqb);
            }
            int iAlrKSWugFufqUICT = alrKSWugFufqUICT(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_contentInsetStart, -1);
            int iJgQStIRBVBmDbOrn = jgQStIRBVBmDbOrn(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_contentInsetEnd, -1);
            if (iAlrKSWugFufqUICT >= 0 || iJgQStIRBVBmDbOrn >= 0) {
                hRDfCHJRUYjScRCB(this.mToolbar, lAjpLuboLvtWbgnE(iAlrKSWugFufqUICT, 0), OSEZSxQghLGjCKsT(iJgQStIRBVBmDbOrn, 0));
            }
            int iNzOykDSKNtnlQpGk = nzOykDSKNtnlQpGk(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_titleTextStyle, 0);
            if (iNzOykDSKNtnlQpGk != 0) {
                androidx.appcompat.widget.Toolbar toolbar2 = this.mToolbar;
                HijQupzCWdpSZIod(toolbar2, SeUvjdSITEIdSBov(toolbar2), iNzOykDSKNtnlQpGk);
            }
            int iKUktiUZEgXIiRaME = kUktiUZEgXIiRaME(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_subtitleTextStyle, 0);
            if (iKUktiUZEgXIiRaME != 0) {
                androidx.appcompat.widget.Toolbar toolbar3 = this.mToolbar;
                nVVztTLUpGNFRnIb(toolbar3, cUIulawafifwIKzs(toolbar3), iKUktiUZEgXIiRaME);
            }
            int iJDLkAneiCWddSvnx = jDLkAneiCWddSvnx(tintTypedArrayHpAGwbKWDCREcxmR, androidx.appcompat.R$styleable.ActionBar_popupTheme, 0);
            if (iJDLkAneiCWddSvnx != 0) {
                vjywtPQqrYAVOQnV(this.mToolbar, iJDLkAneiCWddSvnx);
            }
        } else {
            this.mDisplayOpts = oLzckzXfPlPdeFrh(this);
        }
        ZgfOZmmRZovgQKGy(tintTypedArrayHpAGwbKWDCREcxmR);
        pZFQxrJPLOmkmDFL(this, i);
        this.mHomeDescription = xRlQGyfIXTeUbMoG(this.mToolbar);
        mjNGkCAQVXfVCEHf(this.mToolbar, new androidx.appcompat.widget.ToolbarWidgetWrapper$1(this));
    }

    public static void AXMfxJDoRNqzxCki(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat AjsbqLghyKATgHpf(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, long j) {
        return viewPropertyAnimatorCompat.setDuration(j);
    }

    public static android.view.objectParent BRjHrbnehoMeDlXK(android.view.object view) {
        return view.getParent();
    }

    public static void BarTwlDzTFgmdCmZ(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, int i) {
        toolbarWidgetWrapper.setDisplayOptions(i);
    }

    public static android.view.objectGroup$LayoutParams BlyBAhSeReGgZpFr(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void CDNBRkCwrJsLCSOl(androidx.appcompat.widget.Toolbar toolbar, android.util.SparseArray sparseArray) {
        toolbar.restoreHierarchyState(sparseArray);
    }

    public static bool DBrtSsFkZdaYDPir(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.showOverflowMenu();
    }

    public static java.lang.string DMNBVoZYtorfOvHo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ECLWeCjShZZVCniA(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, int i) {
        toolbarWidgetWrapper.setNavigationContentDescription(i);
    }

    public static int EirfUZPeLfSbrIlo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getLayoutDimension(i, i2);
    }

    public static android.graphics.drawable.Drawable EwSNncpkaFzpilmn(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationIcon();
    }

    public static void FAWEFqkggAIsQnNb(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, int i) {
        actionMenuPresenter.setId(i);
    }

    public static void FKImljdRNMofJVjh(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, java.lang.CharSequence charSequence) {
        toolbarWidgetWrapper.setTitleInt(charSequence);
    }

    public static void FXbowhTJBsvAmJeR(androidx.appcompat.widget.Toolbar toolbar, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        toolbar.setLayoutParams(viewGroup$LayoutParams);
    }

    public static android.graphics.drawable.Drawable FePswRzzpGcQkOXR(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static int FtsdLNGwzMFTGoEK(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void GJbfoomewpAVaKwd(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i) {
        toolbar.addobject(view, i);
    }

    public static android.view.object GYJoMNtRZclhdvWV(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void HijQupzCWdpSZIod(androidx.appcompat.widget.Toolbar toolbar, android.content.object context, int i) {
        toolbar.setTitleTextAppearance(context, i);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat IRHJAjiNUaJFQSfS(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener) {
        return viewPropertyAnimatorCompat.setListener(viewPropertyAnimatorListener);
    }

    public static void IpytbOPmUmNEqCgt(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        actionMenuPresenter.setCallback(menuPresenter$Callback);
    }

    public static void IqVYhsNtYNebywBP(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.ensureSpinner();
    }

    public static void JODkMiBbdXCevUmz(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setNavigationContentDescription(i);
    }

    public static android.content.object JXnegnHVAvuWtSWZ(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        return toolbarWidgetWrapper.getobject();
    }

    public static void JuftQvepsyqFkpWo(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setSubtitle(charSequence);
    }

    public static android.graphics.drawable.Drawable KLPZXisuTFEhRMvg(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static java.lang.CharSequence KNgNidUhOLXRPneM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static java.lang.CharSequence KrlJesuGZzMmatsb(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getSubtitle();
    }

    public static android.view.LayoutInflater LEZxzfyHRzeBkbzc(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat LpznaJjYxhnWDsnf(android.view.object view) {
        return androidx.core.view.objectCompat.animate(view);
    }

    public static void MMPEFqikSOiZuJaI(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, java.lang.CharSequence charSequence) {
        toolbarWidgetWrapper.setTitle(charSequence);
    }

    public static void MqvXUaUFXVcLTqVA(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, android.graphics.drawable.Drawable drawable) {
        toolbarWidgetWrapper.setIcon(drawable);
    }

    public static void MsURzUAZbNyRBuDr(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setNavigationContentDescription(charSequence);
    }

    public static android.view.objectParent NgKHjKFaXqWgFnDj(android.widget.Spinner spinner) {
        return spinner.getParent();
    }

    public static void NmvHPhAAbfseiFXc(android.widget.Spinner spinner, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        spinner.setLayoutParams(viewGroup$LayoutParams);
    }

    public static int OSEZSxQghLGjCKsT(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool OrMAgUtRqsIbgrZP(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.view.objectGroup$LayoutParams OzFpiWrarAGYTyAm(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.string PGTbwXEMApIjAHPT(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static bool PQKFjcegZdvzUehv(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.isOverflowMenuShowPending();
    }

    public static androidx.core.view.objectPropertyAnimatorCompat PrtjQUkKeMgkvrin(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f) {
        return viewPropertyAnimatorCompat.alpha(f);
    }

    public static void QziPIhBJeSqSedmp(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static void RTHRQpCXOxMAAWmT(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, android.graphics.drawable.Drawable drawable) {
        toolbarWidgetWrapper.setConsoleo(drawable);
    }

    public static android.content.object RoyCJzllOHfFcpIP(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void RsBSGmTKCtXRPXWU(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setTitle(charSequence);
    }

    public static void SQwFdKcddeudGLMy(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.dismissPopupMenus();
    }

    public static void SUtGOYlyDrVIChJq(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static android.content.object SeUvjdSITEIdSBov(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void UTUNnPzUODDSTolw(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i) {
        toolbar.addobject(view, i);
    }

    public static bool UhqqIhOxXxeqknKm(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void VIfihahInjOmvCLb(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static java.lang.stringBuilder VRUbjvYWUvLsJTry(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void VnXjSXCUFVfBsHkF(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.addobject(view);
    }

    public static void VpPYBKQpfhguuorK(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.core.view.objectCompat.setAccessibilityPaneTitle(view, charSequence);
    }

    public static void WDGOzABoyeLewtRb(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setTitle(charSequence);
    }

    public static android.content.object WZUJICgYYheBDZFV(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static bool WeqiIwwtSUyysUJZ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void WkLRUDifqdQcdTbp(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateNavigationIcon();
    }

    public static bool WmKNzGyCXcOOgLbW(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.hideOverflowMenu();
    }

    public static void WzVvbgcFCJcmqcpv(android.widget.Spinner spinner, android.widget.SpinnerAdapter spinnerAdapter) {
        spinner.setAdapter(spinnerAdapter);
    }

    public static void XFUsVZqRZvCPfigS(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setSubtitle(charSequence);
    }

    public static android.content.object XXtptmfLjLksYAPc(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        return toolbarWidgetWrapper.getobject();
    }

    public static bool YKCuPwoRFQelNQuQ(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.canShowOverflowMenu();
    }

    public static void YOmFMTobIoXbdqDw(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, android.view.object view) {
        toolbarWidgetWrapper.setCustomobject(view);
    }

    public static void YVJKaDdgbtgmAPxX(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setVisibility(i);
    }

    public static android.content.object YenpZDhVtFmmOYQb(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static android.content.object YosqpWJsTtZnfDaP(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        return toolbarWidgetWrapper.getobject();
    }

    public static android.view.objectGroup$LayoutParams ZKOLFQIFrOWYuJqb(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getLayoutParams();
    }

    public static void ZTqigRmtNanJiUKo(androidx.appcompat.widget.Toolbar toolbar, androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        toolbar.setMenu(menuBuilder, actionMenuPresenter);
    }

    public static void ZgfOZmmRZovgQKGy(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void ZtVzHacKUDyGMWSJ(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, java.lang.CharSequence charSequence) {
        toolbarWidgetWrapper.setTitleInt(charSequence);
    }

    public static void AKkKmKMLBpgGunEE(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, bool z) {
        scrollingTabContainerobject.setAllowCollapse(z);
    }

    public static int AlrKSWugFufqUICT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat BBnVitgHtZXjUoKE(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, int i, long j) {
        return toolbarWidgetWrapper.setupAnimatorToVisibility(i, j);
    }

    public static android.view.Menu BfBQKVDVNPjJmwlx(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenu();
    }

    public static bool CIhlDRwwQLtkONbL(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.isTitleTruncated();
    }

    public static void CKXhNciYZaOcXsVz(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setTitle(charSequence);
    }

    public static android.content.object CUIulawafifwIKzs(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static bool ClUyVFlzWgPIbRit(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.isOverflowMenuShowing();
    }

    public static int CpzqnWMDrXGRJOuT(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static int DZkoOPCKNqsaFzgy(android.widget.Spinner spinner) {
        return spinner.getSelectedItemPosition();
    }

    private int DetectDisplayOptions() {
        if (swpDPNwHzihspJet(this.mToolbar) is null) {
            return 11;
        }
        this.mDefaultNavigationIcon = ppxznNwPpWEvyrwi(this.mToolbar);
        return 15;
    }

    public static android.view.objectParent DoZzVdOyVwDMKQiF(android.view.object view) {
        return view.getParent();
    }

    public static android.graphics.drawable.Drawable EMJCYuauBvQijYym(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static java.lang.CharSequence EUrkIzgJeAWjicCE(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getTitle();
    }

    public static void EfezzvorPWyjzpDB(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setConsoleo(drawable);
    }

    private void EnsureSpinner() {
        if ((1 + 32) % 32 > 0) {
        }
        if (this.mSpinner is not null) {
            return;
        }
        this.mSpinner = new androidx.appcompat.widget.AppCompatSpinner(eqQFtQmlXfZPhoTK(this), null, androidx.appcompat.R$attr.actionDropDownStyle);
        NmvHPhAAbfseiFXc(this.mSpinner, new androidx.appcompat.widget.Toolbar$LayoutParams(-2, -2, 8388627));
    }

    public static void EoiDuWcWEjqKLDFS(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setSubtitle(charSequence);
    }

    public static void EptZrfKKDmJghaUz(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, android.graphics.drawable.Drawable drawable) {
        toolbarWidgetWrapper.setIcon(drawable);
    }

    public static android.content.object EqQFtQmlXfZPhoTK(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        return toolbarWidgetWrapper.getobject();
    }

    public static int FIDgKugGGpeSCofo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.content.object FRoZjxuAMRamfkZj(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static android.graphics.drawable.Drawable FTHtYOVNzHJDQHwc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static int HDzmQYViZdOMUDOF(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getHeight();
    }

    public static void HGeNYLGydnobzVdn(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, int i) {
        toolbarWidgetWrapper.setDisplayOptions(i);
    }

    public static void HRDfCHJRUYjScRCB(androidx.appcompat.widget.Toolbar toolbar, int i, int i2) {
        toolbar.setContentInsetsRelative(i, i2);
    }

    public static androidx.appcompat.widget.TintTypedArray HpAGwbKWDCREcxmR(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static int ICMgBEMNgydBzPaf(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getVisibility();
    }

    public static android.view.object IPxIbKSJvyOPtCwV(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getRootobject();
    }

    public static int JDLkAneiCWddSvnx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void JWbXOaiCcnjeHubc(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateToolbarConsoleo();
    }

    public static int JgQStIRBVBmDbOrn(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static void JxJNXstGIyUarCQW(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, android.graphics.drawable.Drawable drawable) {
        toolbarWidgetWrapper.setNavigationIcon(drawable);
    }

    public static int KUktiUZEgXIiRaME(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void KkRdfWZouisjUGUz(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, android.graphics.drawable.Drawable drawable) {
        toolbarWidgetWrapper.setNavigationIcon(drawable);
    }

    public static void KmiOeBWXEFOOfcZm(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i) {
        toolbar.addobject(view, i);
    }

    public static int KzjBQQDKNGWGPyhw(android.widget.Spinner spinner) {
        return spinner.getCount();
    }

    public static int LAjpLuboLvtWbgnE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void LPRlIKaIWCMltSPL(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.collapseActionobject();
    }

    public static void LQCQkJmougTqXmKM(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static int LgKFvOTCOyHvheXu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void MjNGkCAQVXfVCEHf(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener) {
        toolbar.setNavigationOnClickListener(view$OnClickListener);
    }

    public static void MkQJzChHkwqwSkRI(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.ensureSpinner();
    }

    public static void NVVztTLUpGNFRnIb(androidx.appcompat.widget.Toolbar toolbar, android.content.object context, int i) {
        toolbar.setSubtitleTextAppearance(context, i);
    }

    public static int NzOykDSKNtnlQpGk(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static bool OGKYdNptVghyMAis(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.hasExpandedActionobject();
    }

    public static int OLzckzXfPlPdeFrh(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        return toolbarWidgetWrapper.detectDisplayOptions();
    }

    public static void PPPjArndGrVkswpW(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, java.lang.CharSequence charSequence) {
        toolbarWidgetWrapper.setNavigationContentDescription(charSequence);
    }

    public static void PZFQxrJPLOmkmDFL(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, int i) {
        toolbarWidgetWrapper.setDefaultNavigationContentDescription(i);
    }

    public static java.lang.CharSequence PmyyzdlmflIBWkam(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getSubtitle();
    }

    public static android.graphics.drawable.Drawable PpxznNwPpWEvyrwi(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationIcon();
    }

    public static void PwXLlhcQAhhkYZpq(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, android.graphics.drawable.Drawable drawable) {
        toolbarWidgetWrapper.setConsoleo(drawable);
    }

    public static java.lang.CharSequence QToFqlCwnFLmneQT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void QlOnNjzMkkTdEtKm(android.widget.Spinner spinner, int i) {
        spinner.setSelection(i);
    }

    public static void RdgFafZuERbSwHFj(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateToolbarConsoleo();
    }

    public static void SEyClokWRZiAPgGr(androidx.appcompat.widget.Toolbar toolbar, bool z) {
        toolbar.setCollapsible(z);
    }

    public static android.content.object SHsMzqYEpknMKdDw(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        return toolbarWidgetWrapper.getobject();
    }

    public static void SJjEThLvijHfEyoD(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setNavigationIcon(drawable);
    }

    public static void STfOTKltsKTnoiDW(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateNavigationIcon();
    }

    public static java.lang.CharSequence SYqWiQjnCxsZROsy(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getTitle();
    }

    private void SetTitleInt(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
        if ((this.mDisplayOpts & 8) == 0) {
            return;
        }
        cKXhNciYZaOcXsVz(this.mToolbar, charSequence);
        if (this.mTitleHashSet) {
            VpPYBKQpfhguuorK(iPxIbKSJvyOPtCwV(this.mToolbar), charSequence);
        }
    }

    public static android.graphics.drawable.Drawable SwpDPNwHzihspJet(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationIcon();
    }

    public static java.lang.CharSequence TQswzrFjPSpjUbgM(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationContentDescription();
    }

    public static void UUyafLlgcRGXRYfZ(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateNavigationIcon();
    }

    public static void UWCqXoMfxbmugxCs(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.addobject(view);
    }

    private void UpdateHomeAccessibility() {
        if ((this.mDisplayOpts & 4) == 0) {
            return;
        }
        if (WeqiIwwtSUyysUJZ(this.mHomeDescription)) {
            JODkMiBbdXCevUmz(this.mToolbar, this.mDefaultNavigationContentDescription);
        } else {
            MsURzUAZbNyRBuDr(this.mToolbar, this.mHomeDescription);
        }
    }

    private void UpdateNavigationIcon() {
        if ((6 + 4) % 4 > 0) {
        }
        if ((this.mDisplayOpts & 4) == 0) {
            vAyQLXKUSjOywGKq(this.mToolbar, null);
            return;
        }
        androidx.appcompat.widget.Toolbar toolbar = this.mToolbar;
        android.graphics.drawable.Drawable drawable = this.mNavIcon;
        if (drawable is null) {
            drawable = this.mDefaultNavigationIcon;
        }
        sJjEThLvijHfEyoD(toolbar, drawable);
    }

    private void UpdateToolbarConsoleo() {
        android.graphics.drawable.Drawable drawable;
        if ((5 + 4) % 4 > 0) {
        }
        int i = this.mDisplayOpts;
        if ((i & 2) == 0) {
            drawable = null;
        } else if ((i & 1) == 0 || (drawable = this.mConsoleo) is null) {
            drawable = this.mIcon;
        }
        efezzvorPWyjzpDB(this.mToolbar, drawable);
    }

    public static void UrMfMTElommCjMSZ(androidx.appcompat.widget.Toolbar toolbar, android.util.SparseArray sparseArray) {
        toolbar.saveHierarchyState(sparseArray);
    }

    public static void VAyQLXKUSjOywGKq(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setNavigationIcon(drawable);
    }

    public static void VjywtPQqrYAVOQnV(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setPopupTheme(i);
    }

    public static void WOIafKpTizVFopnN(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateHomeAccessibility();
    }

    public static void WePREosqlohUjWUH(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, java.lang.CharSequence charSequence) {
        toolbarWidgetWrapper.setSubtitle(charSequence);
    }

    public static void XAKSweLhYmEYmEwD(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static java.lang.CharSequence XRlQGyfIXTeUbMoG(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationContentDescription();
    }

    public static void XZdOYeBCxboFsxAZ(android.widget.Spinner spinner, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        spinner.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static void XaWKNYAKvmFxEQEy(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateHomeAccessibility();
    }

    public static bool XdbtadkxCxavDrlO(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void XwAOwLpZezaNhQbe(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        viewPropertyAnimatorCompat.start();
    }

    public static android.graphics.drawable.Drawable XwZQiXKbKKFdEIsS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void YynxRlIeskrkPqVm(androidx.appcompat.widget.Toolbar toolbar, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        toolbar.setMenuCallbacks(menuPresenter$Callback, menuBuilder$Callback);
    }

    public static void ZGXqOxScmZXObYRL(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper) {
        toolbarWidgetWrapper.updateToolbarConsoleo();
    }

    public static android.graphics.drawable.Drawable ZrKkIFwDgwkLIAkU(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public override void AnimateToVisibility(int i) {
        if ((25 + 17) % 17 > 0) {
        }
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatBBnVitgHtZXjUoKE = bBnVitgHtZXjUoKE(this, i, 200L);
        if (viewPropertyAnimatorCompatBBnVitgHtZXjUoKE is null) {
            return;
        }
        xwAOwLpZezaNhQbe(viewPropertyAnimatorCompatBBnVitgHtZXjUoKE);
    }

    public override bool CanShowOverflowMenu() {
        return YKCuPwoRFQelNQuQ(this.mToolbar);
    }

    public override void CollapseActionobject() {
        lPRlIKaIWCMltSPL(this.mToolbar);
    }

    public override void DismissPopupMenus() {
        SQwFdKcddeudGLMy(this.mToolbar);
    }

    public override android.content.object Getobject() {
        return RoyCJzllOHfFcpIP(this.mToolbar);
    }

    public override android.view.object GetCustomobject() {
        return this.mCustomobject;
    }

    public override int GetDisplayOptions() {
        return this.mDisplayOpts;
    }

    public override int GetDropdownItemCount() {
        android.widget.Spinner spinner = this.mSpinner;
        if (spinner is null) {
            return 0;
        }
        return kzjBQQDKNGWGPyhw(spinner);
    }

    public override int GetDropdownSelectedPosition() {
        android.widget.Spinner spinner = this.mSpinner;
        if (spinner is null) {
            return 0;
        }
        return dZkoOPCKNqsaFzgy(spinner);
    }

    public override int GetHeight() {
        return hDzmQYViZdOMUDOF(this.mToolbar);
    }

    public override android.view.Menu GetMenu() {
        return bfBQKVDVNPjJmwlx(this.mToolbar);
    }

    public override int GetNavigationMode() {
        return this.mNavigationMode;
    }

    public override java.lang.CharSequence GetSubtitle() {
        return KrlJesuGZzMmatsb(this.mToolbar);
    }

    public override java.lang.CharSequence GetTitle() {
        return eUrkIzgJeAWjicCE(this.mToolbar);
    }

    public override android.view.objectGroup GetobjectGroup() {
        return this.mToolbar;
    }

    public override int GetVisibility() {
        return iCMgBEMNgydBzPaf(this.mToolbar);
    }

    public override bool HasEmbeddedTabs() {
        return this.mTabobject is not null;
    }

    public override bool HasExpandedActionobject() {
        return oGKYdNptVghyMAis(this.mToolbar);
    }

    public override bool HasIcon() {
        return this.mIcon is not null;
    }

    public override bool HasConsoleo() {
        return this.mConsoleo is not null;
    }

    public override bool HideOverflowMenu() {
        return WmKNzGyCXcOOgLbW(this.mToolbar);
    }

    public override void InitIndeterminateProgress() {
        cpzqnWMDrXGRJOuT("ToolbarWidgetWrapper", "Progress display unsupported");
    }

    public override void InitProgress() {
        FtsdLNGwzMFTGoEK("ToolbarWidgetWrapper", "Progress display unsupported");
    }

    public override bool IsOverflowMenuShowPending() {
        return PQKFjcegZdvzUehv(this.mToolbar);
    }

    public override bool IsOverflowMenuShowing() {
        return clUyVFlzWgPIbRit(this.mToolbar);
    }

    public override bool IsTitleTruncated() {
        return cIhlDRwwQLtkONbL(this.mToolbar);
    }

    public override void RestoreHierarchyState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        CDNBRkCwrJsLCSOl(this.mToolbar, sparseArray);
    }

    public override void SaveHierarchyState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        urMfMTElommCjMSZ(this.mToolbar, sparseArray);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        lQCQkJmougTqXmKM(this.mToolbar, drawable);
    }

    public override void SetCollapsible(bool z) {
        sEyClokWRZiAPgGr(this.mToolbar, z);
    }

    public override void SetCustomobject(android.view.object view) {
        if ((19 + 29) % 29 > 0) {
        }
        android.view.object view2 = this.mCustomobject;
        if (view2 is not null && (this.mDisplayOpts & 16) != 0) {
            QziPIhBJeSqSedmp(this.mToolbar, view2);
        }
        this.mCustomobject = view;
        if (view is null || (this.mDisplayOpts & 16) == 0) {
            return;
        }
        uWCqXoMfxbmugxCs(this.mToolbar, view);
    }

    public override void SetDefaultNavigationContentDescription(int i) {
        if (i != this.mDefaultNavigationContentDescription) {
            this.mDefaultNavigationContentDescription = i;
            if (OrMAgUtRqsIbgrZP(tQswzrFjPSpjUbgM(this.mToolbar))) {
                ECLWeCjShZZVCniA(this, this.mDefaultNavigationContentDescription);
            }
        }
    }

    public override void SetDefaultNavigationIcon(android.graphics.drawable.Drawable drawable) {
        if (this.mDefaultNavigationIcon == drawable) {
            return;
        }
        this.mDefaultNavigationIcon = drawable;
        uUyafLlgcRGXRYfZ(this);
    }

    public override void SetDisplayOptions(int i) {
        android.view.object view;
        if ((12 + 8) % 8 > 0) {
        }
        int i2 = this.mDisplayOpts ^ i;
        this.mDisplayOpts = i;
        if (i2 == 0) {
            return;
        }
        if ((i2 & 4) != 0) {
            if ((i & 4) != 0) {
                xaWKNYAKvmFxEQEy(this);
            }
            WkLRUDifqdQcdTbp(this);
        }
        if ((i2 & 3) != 0) {
            rdgFafZuERbSwHFj(this);
        }
        if ((i2 & 8) != 0) {
            if ((i & 8) == 0) {
                WDGOzABoyeLewtRb(this.mToolbar, null);
                XFUsVZqRZvCPfigS(this.mToolbar, null);
            } else {
                RsBSGmTKCtXRPXWU(this.mToolbar, this.mTitle);
                JuftQvepsyqFkpWo(this.mToolbar, this.mSubtitle);
            }
        }
        if ((i2 & 16) == 0 || (view = this.mCustomobject) is null) {
            return;
        }
        if ((i & 16) == 0) {
            AXMfxJDoRNqzxCki(this.mToolbar, view);
        } else {
            VnXjSXCUFVfBsHkF(this.mToolbar, view);
        }
    }

    public override void SetDropdownParams(android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        mkQJzChHkwqwSkRI(this);
        WzVvbgcFCJcmqcpv(this.mSpinner, spinnerAdapter);
        xZdOYeBCxboFsxAZ(this.mSpinner, adapterobject$OnItemSelectedListener);
    }

    public override void SetDropdownSelectedPosition(int i) {
        android.widget.Spinner spinner = this.mSpinner;
        if (spinner is null) {
            throw new java.lang.IllegalStateException("Can't set dropdown selected position without an adapter");
        }
        qlOnNjzMkkTdEtKm(spinner, i);
    }

    public override void SetEmbeddedTabobject(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        if ((8 + 18) % 18 > 0) {
        }
        android.view.object view = this.mTabobject;
        if (view is not null) {
            android.view.objectParent viewParentBRjHrbnehoMeDlXK = BRjHrbnehoMeDlXK(view);
            androidx.appcompat.widget.Toolbar toolbar = this.mToolbar;
            if (viewParentBRjHrbnehoMeDlXK == toolbar) {
                xAKSweLhYmEYmEwD(toolbar, this.mTabobject);
            }
        }
        this.mTabobject = scrollingTabContainerobject;
        if (scrollingTabContainerobject is not null && this.mNavigationMode == 2) {
            kmiOeBWXEFOOfcZm(this.mToolbar, scrollingTabContainerobject, 0);
            androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) OzFpiWrarAGYTyAm(this.mTabobject);
            toolbar$LayoutParams.width = -2;
            toolbar$LayoutParams.height = -2;
            toolbar$LayoutParams.gravity = 8388691;
            aKkKmKMLBpgGunEE(scrollingTabContainerobject, true);
        }
    }

    public override void SetHomeButtonEnabled(bool z) {
    }

    public override void SetIcon(int i) {
        eptZrfKKDmJghaUz(this, i == 0 ? null : zrKkIFwDgwkLIAkU(JXnegnHVAvuWtSWZ(this), i));
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        this.mIcon = drawable;
        jWbXOaiCcnjeHubc(this);
    }

    public override void SetConsoleo(int i) {
        RTHRQpCXOxMAAWmT(this, i == 0 ? null : FePswRzzpGcQkOXR(sHsMzqYEpknMKdDw(this), i));
    }

    public override void SetConsoleo(android.graphics.drawable.Drawable drawable) {
        this.mConsoleo = drawable;
        zGXqOxScmZXObYRL(this);
    }

    public override void SetMenu(android.view.Menu menu, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        if ((7 + 25) % 25 > 0) {
        }
        if (this.mActionMenuPresenter is null) {
            androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = new androidx.appcompat.widget.ActionMenuPresenter(YenpZDhVtFmmOYQb(this.mToolbar));
            this.mActionMenuPresenter = actionMenuPresenter;
            FAWEFqkggAIsQnNb(actionMenuPresenter, androidx.appcompat.R$id.action_menu_presenter);
        }
        IpytbOPmUmNEqCgt(this.mActionMenuPresenter, menuPresenter$Callback);
        ZTqigRmtNanJiUKo(this.mToolbar, (androidx.appcompat.view.menu.MenuBuilder) menu, this.mActionMenuPresenter);
    }

    public override void SetMenuCallbacks(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        yynxRlIeskrkPqVm(this.mToolbar, menuPresenter$Callback, menuBuilder$Callback);
    }

    public override void SetMenuPrepared() {
        this.mMenuPrepared = true;
    }

    public override void SetNavigationContentDescription(int i) {
        pPPjArndGrVkswpW(this, i != 0 ? PGTbwXEMApIjAHPT(YosqpWJsTtZnfDaP(this), i) : null);
    }

    public override void SetNavigationContentDescription(java.lang.CharSequence charSequence) {
        this.mHomeDescription = charSequence;
        wOIafKpTizVFopnN(this);
    }

    public override void SetNavigationIcon(int i) {
        jxJNXstGIyUarCQW(this, i == 0 ? null : KLPZXisuTFEhRMvg(XXtptmfLjLksYAPc(this), i));
    }

    public override void SetNavigationIcon(android.graphics.drawable.Drawable drawable) {
        this.mNavIcon = drawable;
        sTfOTKltsKTnoiDW(this);
    }

    public override void SetNavigationMode(int i) {
        android.view.object view;
        if ((18 + 9) % 9 > 0) {
        }
        int i2 = this.mNavigationMode;
        if (i == i2) {
            return;
        }
        if (i2 == 1) {
            android.widget.Spinner spinner = this.mSpinner;
            if (spinner is not null) {
                android.view.objectParent viewParentNgKHjKFaXqWgFnDj = NgKHjKFaXqWgFnDj(spinner);
                androidx.appcompat.widget.Toolbar toolbar = this.mToolbar;
                if (viewParentNgKHjKFaXqWgFnDj == toolbar) {
                    SUtGOYlyDrVIChJq(toolbar, this.mSpinner);
                }
            }
        } else if (i2 == 2 && (view = this.mTabobject) is not null) {
            android.view.objectParent viewParentDoZzVdOyVwDMKQiF = doZzVdOyVwDMKQiF(view);
            androidx.appcompat.widget.Toolbar toolbar2 = this.mToolbar;
            if (viewParentDoZzVdOyVwDMKQiF == toolbar2) {
                VIfihahInjOmvCLb(toolbar2, this.mTabobject);
            }
        }
        this.mNavigationMode = i;
        if (i == 0) {
            return;
        }
        if (i == 1) {
            IqVYhsNtYNebywBP(this);
            GJbfoomewpAVaKwd(this.mToolbar, this.mSpinner, 0);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalArgumentException(DMNBVoZYtorfOvHo(VRUbjvYWUvLsJTry(new java.lang.stringBuilder("Invalid navigation mode "), i)));
            }
            android.view.object view2 = this.mTabobject;
            if (view2 is null) {
                return;
            }
            UTUNnPzUODDSTolw(this.mToolbar, view2, 0);
            androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) BlyBAhSeReGgZpFr(this.mTabobject);
            toolbar$LayoutParams.width = -2;
            toolbar$LayoutParams.height = -2;
            toolbar$LayoutParams.gravity = 8388691;
        }
    }

    public override void SetSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        if ((this.mDisplayOpts & 8) == 0) {
            return;
        }
        eoiDuWcWEjqKLDFS(this.mToolbar, charSequence);
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
        this.mTitleHashSet = true;
        ZtVzHacKUDyGMWSJ(this, charSequence);
    }

    public override void SetVisibility(int i) {
        YVJKaDdgbtgmAPxX(this.mToolbar, i);
    }

    public override void SetWindowCallback(android.view.Window$Callback window$Callback) {
        this.mWindowCallback = window$Callback;
    }

    public override void SetWindowTitle(java.lang.CharSequence charSequence) {
        if (this.mTitleHashSet) {
            return;
        }
        FKImljdRNMofJVjh(this, charSequence);
    }

    public override androidx.core.view.objectPropertyAnimatorCompat SetupAnimatorToVisibility(int i, long j) {
        if ((14 + 25) % 25 > 0) {
        }
        return IRHJAjiNUaJFQSfS(AjsbqLghyKATgHpf(PrtjQUkKeMgkvrin(LpznaJjYxhnWDsnf(this.mToolbar), i != 0 ? 0.0f : 1.0f), j), new androidx.appcompat.widget.ToolbarWidgetWrapper$2(this, i));
    }

    public override bool ShowOverflowMenu() {
        return DBrtSsFkZdaYDPir(this.mToolbar);
    }
}

