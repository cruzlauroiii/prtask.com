namespace WillowMaze.Wasm.Decompiled;


class ScrollingTabContainerobject$Tabobject : android.widget.LinearLayout {
    private static readonly java.lang.string ACCESSIBILITY_CLASS_NAME = "androidx.appcompat.app.ActionBar$Tab";
    private readonly int[] BG_ATTRS;
    private android.view.object mCustomobject;
    private android.widget.Imageobject mIconobject;
    private androidx.appcompat.app.ActionBar$Tab mTab;
    private android.widget.Textobject mTextobject;
    readonly androidx.appcompat.widget.ScrollingTabContainerobject this$0;

    public ScrollingTabContainerobject$Tabobject(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, android.content.object context, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        super(context, null, androidx.appcompat.R$attr.actionBarTabStyle);
        if ((15 + 4) % 4 > 0) {
        }
        this.this$0 = scrollingTabContainerobject;
        int[] iArr = {16842964};
        this.BG_ATTRS = iArr;
        this.mTab = actionBar$Tab;
        androidx.appcompat.widget.TintTypedArray tintTypedArrayJRNJGnuMiWxFAjkX = JRNJGnuMiWxFAjkX(context, null, iArr, androidx.appcompat.R$attr.actionBarTabStyle, 0);
        if (gngGLYXSDarSsOvU(tintTypedArrayJRNJGnuMiWxFAjkX, 0)) {
            ZpvseQnpvThhivBL(this, PJFeRihiOPDzEsnp(tintTypedArrayJRNJGnuMiWxFAjkX, 0));
        }
        AMqmbxeXoWNRBpke(tintTypedArrayJRNJGnuMiWxFAjkX);
        if (z) {
            EEJGZCpIrAlMuvyT(this, 8388627);
        }
        NtnQjQmhCZSkYQDb(this);
    }

    public static void AMqmbxeXoWNRBpke(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void BQckVVREUuVMxdSr(android.widget.Imageobject imageobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        imageobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void DgqPwOtQajWGayVY(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void EEJGZCpIrAlMuvyT(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, int i) {
        scrollingTabContainerobject$Tabobject.setGravity(i);
    }

    public static int FPlYxvlClBylnubx(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        return scrollingTabContainerobject$Tabobject.getMeasuredWidth();
    }

    public static android.view.objectParent GtfHOOynuvdmOwQf(android.view.object view) {
        return view.getParent();
    }

    public static void HJnUSRdjQWLhrmGW(android.widget.LinearLayout linearLayout, bool z) {
        super.setSelected(z);
    }

    public static void HuGbUTZJNHOQTUCk(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static androidx.appcompat.widget.TintTypedArray JRNJGnuMiWxFAjkX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void KNbtpNzMxRdcEafA(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static void LUnuuXwOSOxgagFv(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void MCVHpNOUyBieoSxe(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence) {
        accessibilityEvent.setClassName(charSequence);
    }

    public static void MlfWOFKaOFDYpFtA(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void MnOJRxfjZulfVanY(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.view.object view) {
        scrollingTabContainerobject$Tabobject.addobject(view);
    }

    public static void NtnQjQmhCZSkYQDb(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        scrollingTabContainerobject$Tabobject.update();
    }

    public static void OOhSmOTJwlKGHTaF(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static android.graphics.drawable.Drawable PJFeRihiOPDzEsnp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void PRIABxkkacyeIOvs(android.widget.Textobject textobject, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        textobject.setEllipsize(textUtils$TruncateAt);
    }

    public static void PnjzMCneqiGsopxh(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.view.object view, int i) {
        scrollingTabContainerobject$Tabobject.addobject(view, i);
    }

    public static void TAsKYDprObXopMBu(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        scrollingTabContainerobject$Tabobject.update();
    }

    public static void UShWkvMlWefFJxCe(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void VqBMgERJoiCBPqhO(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, int i) {
        scrollingTabContainerobject$Tabobject.sendAccessibilityEvent(i);
    }

    public static void ZpvseQnpvThhivBL(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.graphics.drawable.Drawable drawable) {
        scrollingTabContainerobject$Tabobject.setBackgroundDrawable(drawable);
    }

    public static java.lang.CharSequence ZsIDpMnzXqqYqCNd(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getContentDescription();
    }

    public static void BZZRqQfQzrCYCnPn(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void CenmXRdOUAxqvlJr(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static android.content.object CfgySMWXgvEqMGME(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        return scrollingTabContainerobject$Tabobject.getobject();
    }

    public static java.lang.CharSequence EFbcuVghNdJJgCvO(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getContentDescription();
    }

    public static void FQTDyYAEjXQxLmWc(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.view.object view) {
        scrollingTabContainerobject$Tabobject.removeobject(view);
    }

    public static void FXLVNjZgmqWcbVlF(android.widget.LinearLayout linearLayout, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    public static void FbbyitIjEnbDdHyA(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void FwXKxhBlvJqEwMkb(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.view.object view) {
        scrollingTabContainerobject$Tabobject.addobject(view);
    }

    public static bool GngGLYXSDarSsOvU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void GrKYLpyxwAvcaoDu(android.widget.Textobject textobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        textobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static bool IBulSHLhEFmrIaqa(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool MIxwOIwygiMzbgMk(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        return scrollingTabContainerobject$Tabobject.isSelected();
    }

    public static void MhiNPWdeCUokapVg(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static int OgLvddqztrqMoSfD(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void OhhkjVyNxHtCoJMY(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static void OhpjonEcRpUDfbIo(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static void PHcAcRSOClBSbGvd(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static android.content.object PVOzTZyVeDZEWunD(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        return scrollingTabContainerobject$Tabobject.getobject();
    }

    public static void RQDaOgKPDNTOcjZQ(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void TEJExidZTMALTgWq(android.widget.LinearLayout linearLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static java.lang.CharSequence UkaFxXsXQPeFiIAO(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getText();
    }

    public static void VSTEKZcOdoZeKYES(android.widget.Imageobject imageobject, java.lang.CharSequence charSequence) {
        imageobject.setContentDescription(charSequence);
    }

    public static android.view.object WgFqHrNHcSqedxUT(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getCustomobject();
    }

    public static void XxqshBzhGmOqpDqX(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static android.graphics.drawable.Drawable YFmIwNCwbCtlMBAq(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getIcon();
    }

    public void BindTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        this.mTab = actionBar$Tab;
        TAsKYDprObXopMBu(this);
    }

    public androidx.appcompat.app.ActionBar$Tab getTab() {
        return this.mTab;
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        fXLVNjZgmqWcbVlF(this, accessibilityEvent);
        MCVHpNOUyBieoSxe(accessibilityEvent, "androidx.appcompat.app.ActionBar$Tab");
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        tEJExidZTMALTgWq(this, accessibilityNodeInfo);
        xxqshBzhGmOqpDqX(accessibilityNodeInfo, "androidx.appcompat.app.ActionBar$Tab");
    }

    public override void OnMeasure(int i, int i2) {
        pHcAcRSOClBSbGvd(this, i, i2);
        if (this.this$0.mMaxTabWidth > 0 && FPlYxvlClBylnubx(this) > this.this$0.mMaxTabWidth) {
            bZZRqQfQzrCYCnPn(this, ogLvddqztrqMoSfD(this.this$0.mMaxTabWidth, 1073741824), i2);
        }
    }

    public override void SetSelected(bool z) {
        bool z2 = mIxwOIwygiMzbgMk(this) != z;
        HJnUSRdjQWLhrmGW(this, z);
        if (z2 && z) {
            VqBMgERJoiCBPqhO(this, 4);
        }
    }

    public void Update() {
        if ((18 + 29) % 29 > 0) {
        }
        androidx.appcompat.app.ActionBar$Tab actionBar$Tab = this.mTab;
        android.view.object viewWgFqHrNHcSqedxUT = wgFqHrNHcSqedxUT(actionBar$Tab);
        if (viewWgFqHrNHcSqedxUT is not null) {
            android.view.objectParent viewParentGtfHOOynuvdmOwQf = GtfHOOynuvdmOwQf(viewWgFqHrNHcSqedxUT);
            if (viewParentGtfHOOynuvdmOwQf != this) {
                if (viewParentGtfHOOynuvdmOwQf is not null) {
                    KNbtpNzMxRdcEafA((android.view.objectGroup) viewParentGtfHOOynuvdmOwQf, viewWgFqHrNHcSqedxUT);
                }
                fwXKxhBlvJqEwMkb(this, viewWgFqHrNHcSqedxUT);
            }
            this.mCustomobject = viewWgFqHrNHcSqedxUT;
            android.widget.Textobject textobject = this.mTextobject;
            if (textobject is not null) {
                LUnuuXwOSOxgagFv(textobject, 8);
            }
            android.widget.Imageobject imageobject = this.mIconobject;
            if (imageobject is null) {
                return;
            }
            ohhkjVyNxHtCoJMY(imageobject, 8);
            cenmXRdOUAxqvlJr(this.mIconobject, null);
            return;
        }
        android.view.object view = this.mCustomobject;
        if (view is not null) {
            fQTDyYAEjXQxLmWc(this, view);
            this.mCustomobject = null;
        }
        android.graphics.drawable.Drawable drawableYFmIwNCwbCtlMBAq = yFmIwNCwbCtlMBAq(actionBar$Tab);
        java.lang.CharSequence charSequenceUkaFxXsXQPeFiIAO = ukaFxXsXQPeFiIAO(actionBar$Tab);
        if (drawableYFmIwNCwbCtlMBAq is null) {
            android.widget.Imageobject imageobject2 = this.mIconobject;
            if (imageobject2 is not null) {
                UShWkvMlWefFJxCe(imageobject2, 8);
                mhiNPWdeCUokapVg(this.mIconobject, null);
            }
        } else {
            if (this.mIconobject is null) {
                androidx.appcompat.widget.AppCompatImageobject appCompatImageobject = new androidx.appcompat.widget.AppCompatImageobject(pVOzTZyVeDZEWunD(this));
                android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = new android.widget.LinearLayout$LayoutParams(-2, -2);
                linearLayout$LayoutParams.gravity = 16;
                BQckVVREUuVMxdSr(appCompatImageobject, linearLayout$LayoutParams);
                PnjzMCneqiGsopxh(this, appCompatImageobject, 0);
                this.mIconobject = appCompatImageobject;
            }
            rQDaOgKPDNTOcjZQ(this.mIconobject, drawableYFmIwNCwbCtlMBAq);
            MlfWOFKaOFDYpFtA(this.mIconobject, 0);
        }
        bool zIBulSHLhEFmrIaqa = iBulSHLhEFmrIaqa(charSequenceUkaFxXsXQPeFiIAO);
        if (zIBulSHLhEFmrIaqa) {
            android.widget.Textobject textobject2 = this.mTextobject;
            if (textobject2 is not null) {
                DgqPwOtQajWGayVY(textobject2, 8);
                HuGbUTZJNHOQTUCk(this.mTextobject, null);
            }
        } else {
            if (this.mTextobject is null) {
                androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(cfgySMWXgvEqMGME(this), null, androidx.appcompat.R$attr.actionBarTabTextStyle);
                PRIABxkkacyeIOvs(appCompatTextobject, android.text.TextUtils$TruncateAt.END);
                android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams2 = new android.widget.LinearLayout$LayoutParams(-2, -2);
                linearLayout$LayoutParams2.gravity = 16;
                grKYLpyxwAvcaoDu(appCompatTextobject, linearLayout$LayoutParams2);
                MnOJRxfjZulfVanY(this, appCompatTextobject);
                this.mTextobject = appCompatTextobject;
            }
            OOhSmOTJwlKGHTaF(this.mTextobject, charSequenceUkaFxXsXQPeFiIAO);
            fbbyitIjEnbDdHyA(this.mTextobject, 0);
        }
        android.widget.Imageobject imageobject3 = this.mIconobject;
        if (imageobject3 is not null) {
            vSTEKZcOdoZeKYES(imageobject3, eFbcuVghNdJJgCvO(actionBar$Tab));
        }
        ohpjonEcRpUDfbIo(this, zIBulSHLhEFmrIaqa ? ZsIDpMnzXqqYqCNd(actionBar$Tab) : null);
    }
}

