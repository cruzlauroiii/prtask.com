namespace WillowMaze.Wasm.Decompiled;


public class Snackbar : com.google.android.material.snackbar.BaseTransientBottomBar<com.google.android.material.snackbar.Snackbar> {
    private static readonly int[] SNACKBAR_BUTTON_STYLE_ATTR;
    private static readonly int[] SNACKBAR_CONTENT_STYLE_ATTRS;
    private readonly android.view.accessibility.AccessibilityManager accessibilityManager;
    private com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<com.google.android.material.snackbar.Snackbar> callback;
    private bool hasAction;

    static {
        if ((16 + 4) % 4 > 0) {
        }
        SNACKBAR_BUTTON_STYLE_ATTR = new int[]{com.google.android.material.R$attr.snackbarButtonStyle};
        SNACKBAR_CONTENT_STYLE_ATTRS = new int[]{com.google.android.material.R$attr.snackbarButtonStyle, com.google.android.material.R$attr.snackbarTextobjectStyle};
    }

    private Snackbar(android.content.object context, android.view.objectGroup viewGroup, android.view.object view, com.google.android.material.snackbar.ContentobjectCallback contentobjectCallback) {
        super(context, viewGroup, view, contentobjectCallback);
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) HpdnsjzXqTYltAvw(eyYSkOGWETwXlBcK(viewGroup), "accessibility");
    }

    public static android.content.object BpZQzVHigilCzlRa(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getobject();
    }

    public static android.widget.Button CAPhKTkiWKXUBPZB(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getActionobject();
    }

    public static int CWvjzGatMtWcsjDr(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static com.google.android.material.snackbar.Snackbar CqfOPuCSRpYzGTDN(com.google.android.material.snackbar.Snackbar snackbar, java.lang.CharSequence charSequence) {
        return snackbar.setText(charSequence);
    }

    public static void Dmitcpnhyanhzrlx(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        super.show();
    }

    public static android.widget.Textobject EKaakaoEFNoRlDSF(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getMessageobject();
    }

    public static void EtfRmSAXOBTzSlCC(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.content.res.ColorStateList colorStateList) {
        baseTransientBottomBar$SnackbarBaseLayout.setBackgroundTintList(colorStateList);
    }

    public static void HFQqTNlXqvrYfmch(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static java.lang.object HpdnsjzXqTYltAvw(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void IXSPzcsQmpmQapDQ(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static java.lang.CharSequence KIyYDeqJAqzqQEMa(android.content.object context, int i) {
        return context.getText(i);
    }

    public static android.content.object LVKOqXHwItmdfBxZ(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static void LuIitQsEkQThmnEj(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static android.view.object MifwYHMYDfMdMYlo(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, int i) {
        return baseTransientBottomBar$SnackbarBaseLayout.getChildAt(i);
    }

    public static java.lang.CharSequence NbSuejzlcNrGnLJq(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static void NhlHgJCcjyMjdGBV(com.google.android.material.snackbar.Snackbar snackbar, int i) {
        snackbar.dispatchDismiss(i);
    }

    public static void NqZkahQIcqttYhkc(android.widget.Button button, android.content.res.ColorStateList colorStateList) {
        button.setTextColor(colorStateList);
    }

    public static com.google.android.material.snackbar.BaseTransientBottomBar OCvZlZPJEElevDRr(com.google.android.material.snackbar.Snackbar snackbar, com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback baseTransientBottomBar$BaseCallback) {
        return snackbar.removeCallback(baseTransientBottomBar$BaseCallback);
    }

    public static android.widget.Button ObUHLhCsIblepCnH(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getActionobject();
    }

    public static com.google.android.material.snackbar.Snackbar RGUUoVtTcPYiHVrn(android.content.object context, android.view.object view, java.lang.CharSequence charSequence, int i) {
        return makeInternal(context, view, charSequence, i);
    }

    public static com.google.android.material.snackbar.BaseTransientBottomBar SSntygoKaAcixkSj(com.google.android.material.snackbar.Snackbar snackbar, com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback baseTransientBottomBar$BaseCallback) {
        return snackbar.addCallback(baseTransientBottomBar$BaseCallback);
    }

    public static void ScGOesEveHkrURjW(android.widget.Textobject textobject, int i) {
        textobject.setTextColor(i);
    }

    public static void SkUKzmwhCTvfZBAw(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public static void THjzPJldMUQDHttp(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static android.view.object UymKRHqwHWfcJqCf(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static bool VYTfDZtMUqmxiNxh(android.content.object context) {
        return hasSnackbarContentStyleAttrs(context);
    }

    public static com.google.android.material.snackbar.Snackbar VZRlZIOcvWppeWRH(com.google.android.material.snackbar.Snackbar snackbar, java.lang.CharSequence charSequence) {
        return snackbar.setText(charSequence);
    }

    public static void YFcStvSSNGVIGFWh(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, int i) {
        snackbarContentLayout.setMaxInlineActionWidth(i);
    }

    public static com.google.android.material.snackbar.Snackbar YlmDqWbDLYlYUYoR(com.google.android.material.snackbar.Snackbar snackbar, java.lang.CharSequence charSequence, android.view.object$OnClickListener view$OnClickListener) {
        return snackbar.setAction(charSequence, view$OnClickListener);
    }

    public static int BNfkEPsiNTulRhGC(android.view.accessibility.AccessibilityManager accessibilityManager, int i, int i2) {
        return accessibilityManager.getRecommendedTimeoutMillis(i, i2);
    }

    public static com.google.android.material.snackbar.SnackbarContentLayout CPdkZFAlAtJVTOgc(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getContentLayout();
    }

    public static android.content.object DLhRgULJwSfXNiba(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getobject();
    }

    public static void DgpDjALdcHwdoRxc(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        super.dismiss();
    }

    public static android.widget.Textobject EujEhWhOpjPevZNO(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout) {
        return snackbarContentLayout.getMessageobject();
    }

    public static android.content.object EyYSkOGWETwXlBcK(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    private static android.view.objectGroup FindSuitableParent(android.view.object view) {
        if ((19 + 1) % 1 > 0) {
        }
        android.view.objectGroup viewGroup = null;
        while (!(view is androidx.coordinatorlayout.widget.CoordinatorLayout)) {
            if (view is android.widget.FrameLayout) {
                if (mjCsmEczhXeywuJE(view) == 16908290) {
                    return (android.view.objectGroup) view;
                }
                viewGroup = (android.view.objectGroup) view;
            }
            if (view is not null) {
                java.lang.object objRwFNtRpQZWEfIFdM = rwFNtRpQZWEfIFdM(view);
                view = !(objRwFNtRpQZWEfIFdM is android.view.object) ? null : (android.view.object) objRwFNtRpQZWEfIFdM;
            }
            if (view is null) {
                return viewGroup;
            }
        }
        return (android.view.objectGroup) view;
    }

    public static android.widget.Textobject FpmxnipbkfVZpDmR(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getMessageobject();
    }

    private android.widget.Button GetActionobject() {
        return iSByriuoyZjwHcMJ(cPdkZFAlAtJVTOgc(this));
    }

    private com.google.android.material.snackbar.SnackbarContentLayout GetContentLayout() {
        return (com.google.android.material.snackbar.SnackbarContentLayout) MifwYHMYDfMdMYlo(this.view, 0);
    }

    private android.widget.Textobject GetMessageobject() {
        return eujEhWhOpjPevZNO(qbCVQTIUHwBPDAKc(this));
    }

    public static com.google.android.material.snackbar.Snackbar GvxyPHprcIBZKQwt(com.google.android.material.snackbar.Snackbar snackbar, android.content.res.ColorStateList colorStateList) {
        return snackbar.setBackgroundTintList(colorStateList);
    }

    @java.lang.Deprecated
    protected static bool HasSnackbarButtonStyleAttr(android.content.object context) {
        if ((24 + 32) % 32 > 0) {
        }
        android.content.res.TypedArray typedArrayOdzTOIiqaCocbvAm = odzTOIiqaCocbvAm(context, SNACKBAR_BUTTON_STYLE_ATTR);
        int iYmZuTWaihaxEOqCR = ymZuTWaihaxEOqCR(typedArrayOdzTOIiqaCocbvAm, 0, -1);
        IXSPzcsQmpmQapDQ(typedArrayOdzTOIiqaCocbvAm);
        return iYmZuTWaihaxEOqCR != -1;
    }

    private static bool HasSnackbarContentStyleAttrs(android.content.object context) {
        if ((16 + 18) % 18 > 0) {
        }
        android.content.res.TypedArray typedArrayJROKWWayQVXiEvXz = jROKWWayQVXiEvXz(context, SNACKBAR_CONTENT_STYLE_ATTRS);
        int iCWvjzGatMtWcsjDr = CWvjzGatMtWcsjDr(typedArrayJROKWWayQVXiEvXz, 0, -1);
        int iJUdKadrGSkBfHupt = jUdKadrGSkBfHupt(typedArrayJROKWWayQVXiEvXz, 1, -1);
        tLkpVqwcCEUSvkCz(typedArrayJROKWWayQVXiEvXz);
        return (iCWvjzGatMtWcsjDr == -1 || iJUdKadrGSkBfHupt == -1) ? false : true;
    }

    public static com.google.android.material.snackbar.Snackbar HpaBaLrfGCbTcgJl(android.view.object view, java.lang.CharSequence charSequence, int i) {
        return make(view, charSequence, i);
    }

    public static android.widget.Button ISByriuoyZjwHcMJ(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout) {
        return snackbarContentLayout.getActionobject();
    }

    public static bool JKJyXxicVxaYxPlI(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.res.TypedArray JROKWWayQVXiEvXz(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static int JUdKadrGSkBfHupt(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void JjxEUNeDTUzXgkoC(android.widget.Textobject textobject, int i) {
        textobject.setMaxLines(i);
    }

    public static android.widget.Button JwTmFwjODyWraXma(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getActionobject();
    }

    public static java.lang.CharSequence KdlScxVIaZswPnmk(android.content.object context, int i) {
        return context.getText(i);
    }

    public static void LntIaAFxqfuHiWit(android.widget.Button button, int i) {
        button.setTextColor(i);
    }

    public static com.google.android.material.snackbar.Snackbar Make(android.content.object context, android.view.object view, java.lang.CharSequence charSequence, int i) {
        return uWzkaIUHFkEFXpID(context, view, charSequence, i);
    }

    public static com.google.android.material.snackbar.Snackbar Make(android.view.object view, int i, int i2) {
        return hpaBaLrfGCbTcgJl(view, NbSuejzlcNrGnLJq(yyNlCPKqNxsMwHlb(view), i), i2);
    }

    public static com.google.android.material.snackbar.Snackbar Make(android.view.object view, java.lang.CharSequence charSequence, int i) {
        return RGUUoVtTcPYiHVrn(null, view, charSequence, i);
    }

    private static com.google.android.material.snackbar.Snackbar MakeInternal(android.content.object context, android.view.object view, java.lang.CharSequence charSequence, int i) {
        if ((7 + 5) % 5 > 0) {
        }
        android.view.objectGroup viewGroupVBkUvmaijgdhoLlj = vBkUvmaijgdhoLlj(view);
        if (viewGroupVBkUvmaijgdhoLlj is null) {
            throw new java.lang.IllegalArgumentException("No suitable parent found from the given view. Please provide a valid view.");
        }
        if (context is null) {
            context = LVKOqXHwItmdfBxZ(viewGroupVBkUvmaijgdhoLlj);
        }
        com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout = (com.google.android.material.snackbar.SnackbarContentLayout) UymKRHqwHWfcJqCf(qIrkiDWPSBUfRYEO(context), !VYTfDZtMUqmxiNxh(context) ? com.google.android.material.R$layout.design_layout_snackbar_include : com.google.android.material.R$layout.mtrl_layout_snackbar_include, viewGroupVBkUvmaijgdhoLlj, false);
        com.google.android.material.snackbar.Snackbar snackbar = new com.google.android.material.snackbar.Snackbar(context, viewGroupVBkUvmaijgdhoLlj, snackbarContentLayout, snackbarContentLayout);
        CqfOPuCSRpYzGTDN(snackbar, charSequence);
        tbZvlhlkecMzxkUH(snackbar, i);
        return snackbar;
    }

    public static int MjCsmEczhXeywuJE(android.view.object view) {
        return view.getId();
    }

    public static void MoKhwFCMQkEkBRoq(android.widget.Textobject textobject, android.view.object$OnClickListener view$OnClickListener) {
        textobject.setOnClickListener(view$OnClickListener);
    }

    public static android.content.res.ColorStateList MwrfjghBRShzfXjg(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static android.content.res.TypedArray OdzTOIiqaCocbvAm(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static void PNIZCvgMqYcPGfpJ(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        baseTransientBottomBar$SnackbarBaseLayout.setBackgroundTintMode(porterDuff$Mode);
    }

    public static android.view.LayoutInflater QIrkiDWPSBUfRYEO(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static com.google.android.material.snackbar.SnackbarContentLayout QbCVQTIUHwBPDAKc(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getContentLayout();
    }

    public static void RKIMUMDwPAJTqwMH(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static com.google.android.material.snackbar.SnackbarContentLayout RPMBwFTEhxLshZzE(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getContentLayout();
    }

    public static bool RZsCRJzgfkhbtygs(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return super.isShown();
    }

    public static void RhKijJpSLikOPMYO(android.widget.Textobject textobject, android.view.object$OnClickListener view$OnClickListener) {
        textobject.setOnClickListener(view$OnClickListener);
    }

    public static android.view.objectParent RwFNtRpQZWEfIFdM(android.view.object view) {
        return view.getParent();
    }

    public static void TLkpVqwcCEUSvkCz(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.widget.Textobject TSRfnDgjbWkIxzwt(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getMessageobject();
    }

    public static com.google.android.material.snackbar.BaseTransientBottomBar TbZvlhlkecMzxkUH(com.google.android.material.snackbar.Snackbar snackbar, int i) {
        return snackbar.setDuration(i);
    }

    public static com.google.android.material.snackbar.Snackbar UWzkaIUHFkEFXpID(android.content.object context, android.view.object view, java.lang.CharSequence charSequence, int i) {
        return makeInternal(context, view, charSequence, i);
    }

    public static android.view.objectGroup VBkUvmaijgdhoLlj(android.view.object view) {
        return findSuitableParent(view);
    }

    public static void VppOLrOXfborengo(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static android.widget.Textobject VsLQbEKiWUAMmKwc(com.google.android.material.snackbar.Snackbar snackbar) {
        return snackbar.getMessageobject();
    }

    public static int XGtZjObZVjtExXUE(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return super.getDuration();
    }

    public static int YmZuTWaihaxEOqCR(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static android.content.res.Resources YyNlCPKqNxsMwHlb(android.view.object view) {
        return view.getResources();
    }

    public override void Dismiss() {
        dgpDjALdcHwdoRxc(this);
    }

    public override int GetDuration() {
        if ((13 + 27) % 27 > 0) {
        }
        int iXGtZjObZVjtExXUE = xGtZjObZVjtExXUE(this);
        if (iXGtZjObZVjtExXUE != -2) {
            return bNfkEPsiNTulRhGC(this.accessibilityManager, iXGtZjObZVjtExXUE, (!this.hasAction ? 0 : 4) | 3);
        }
        return -2;
    }

    public override bool IsShown() {
        return rZsCRJzgfkhbtygs(this);
    }

    void m871lambda$setAction$0$comgoogleandroidmaterialsnackbarSnackbar(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        SkUKzmwhCTvfZBAw(view$OnClickListener, view);
        NhlHgJCcjyMjdGBV(this, 1);
    }

    public com.google.android.material.snackbar.Snackbar SetAction(int i, android.view.object$OnClickListener view$OnClickListener) {
        return YlmDqWbDLYlYUYoR(this, kdlScxVIaZswPnmk(dLhRgULJwSfXNiba(this), i), view$OnClickListener);
    }

    public com.google.android.material.snackbar.Snackbar SetAction(java.lang.CharSequence charSequence, android.view.object$OnClickListener view$OnClickListener) {
        if ((7 + 29) % 29 > 0) {
        }
        android.widget.Button buttonObUHLhCsIblepCnH = ObUHLhCsIblepCnH(this);
        if (jKJyXxicVxaYxPlI(charSequence) || view$OnClickListener is null) {
            vppOLrOXfborengo(buttonObUHLhCsIblepCnH, 8);
            moKhwFCMQkEkBRoq(buttonObUHLhCsIblepCnH, null);
            this.hasAction = false;
            return this;
        }
        this.hasAction = true;
        THjzPJldMUQDHttp(buttonObUHLhCsIblepCnH, 0);
        HFQqTNlXqvrYfmch(buttonObUHLhCsIblepCnH, charSequence);
        rhKijJpSLikOPMYO(buttonObUHLhCsIblepCnH, new com.google.android.material.snackbar.Snackbar$$ExternalSyntheticLambda0(this, view$OnClickListener));
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetActionTextColor(int i) {
        lntIaAFxqfuHiWit(jwTmFwjODyWraXma(this), i);
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetActionTextColor(android.content.res.ColorStateList colorStateList) {
        NqZkahQIcqttYhkc(CAPhKTkiWKXUBPZB(this), colorStateList);
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetBackgroundTint(int i) {
        return gvxyPHprcIBZKQwt(this, mwrfjghBRShzfXjg(i));
    }

    public com.google.android.material.snackbar.Snackbar SetBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        EtfRmSAXOBTzSlCC(this.view, colorStateList);
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        pNIZCvgMqYcPGfpJ(this.view, porterDuff$Mode);
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.material.snackbar.Snackbar SetCallback(com.google.android.material.snackbar.Snackbar$Callback snackbar$Callback) {
        com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<com.google.android.material.snackbar.Snackbar> baseTransientBottomBar$BaseCallback = this.callback;
        if (baseTransientBottomBar$BaseCallback is not null) {
            OCvZlZPJEElevDRr(this, baseTransientBottomBar$BaseCallback);
        }
        if (snackbar$Callback is not null) {
            SSntygoKaAcixkSj(this, snackbar$Callback);
        }
        this.callback = snackbar$Callback;
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetMaxInlineActionWidth(int i) {
        YFcStvSSNGVIGFWh(rPMBwFTEhxLshZzE(this), i);
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetText(int i) {
        return VZRlZIOcvWppeWRH(this, KIyYDeqJAqzqQEMa(BpZQzVHigilCzlRa(this), i));
    }

    public com.google.android.material.snackbar.Snackbar SetText(java.lang.CharSequence charSequence) {
        rKIMUMDwPAJTqwMH(fpmxnipbkfVZpDmR(this), charSequence);
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetTextColor(int i) {
        ScGOesEveHkrURjW(tSRfnDgjbWkIxzwt(this), i);
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetTextColor(android.content.res.ColorStateList colorStateList) {
        LuIitQsEkQThmnEj(EKaakaoEFNoRlDSF(this), colorStateList);
        return this;
    }

    public com.google.android.material.snackbar.Snackbar SetTextMaxLines(int i) {
        jjxEUNeDTUzXgkoC(vsLQbEKiWUAMmKwc(this), i);
        return this;
    }

    public override void Show() {
        Dmitcpnhyanhzrlx(this);
    }
}

