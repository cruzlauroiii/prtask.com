namespace WillowMaze.Wasm.Decompiled;


public class ActionBarobjectobject : androidx.appcompat.widget.AbsActionBarobject {
    private android.view.object mClose;
    private android.view.object mCloseButton;
    private int mCloseItemLayout;
    private android.view.object mCustomobject;
    private java.lang.CharSequence mSubtitle;
    private int mSubtitleStyleRes;
    private android.widget.Textobject mSubtitleobject;
    private java.lang.CharSequence mTitle;
    private android.widget.LinearLayout mTitleLayout;
    private bool mTitleobject?;
    private int mTitleStyleRes;
    private android.widget.Textobject mTitleobject;

    public ActionBarobjectobject(android.content.object context) {
        this(context, null);
    }

    public ActionBarobjectobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.actionModeStyle);
    }

    public ActionBarobjectobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((4 + 8) % 8 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayXBZAGZIZUmgIWtfI = xBZAGZIZUmgIWtfI(context, attributeHashSet, androidx.appcompat.R$styleable.ActionMode, i, 0);
        VbRqvtKhJzDFVlsi(this, IFdQJYDJWcCUjmJF(tintTypedArrayXBZAGZIZUmgIWtfI, androidx.appcompat.R$styleable.ActionMode_background));
        this.mTitleStyleRes = gdmSphfhgEJXUvUW(tintTypedArrayXBZAGZIZUmgIWtfI, androidx.appcompat.R$styleable.ActionMode_titleTextStyle, 0);
        this.mSubtitleStyleRes = TLMgXVyHUKZkYylR(tintTypedArrayXBZAGZIZUmgIWtfI, androidx.appcompat.R$styleable.ActionMode_subtitleTextStyle, 0);
        this.mContentHeight = HnrTMtVtWvJwYulH(tintTypedArrayXBZAGZIZUmgIWtfI, androidx.appcompat.R$styleable.ActionMode_height, 0);
        this.mCloseItemLayout = cgLaXVDGNthZpmDq(tintTypedArrayXBZAGZIZUmgIWtfI, androidx.appcompat.R$styleable.ActionMode_closeItemLayout, androidx.appcompat.R$layout.abc_action_mode_close_item_material);
        DozVpJpDSiUXbAYq(tintTypedArrayXBZAGZIZUmgIWtfI);
    }

    public static int BAonSwSCsMhCfBrL(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingTop();
    }

    public static int CFsuUWqsSDWhfXoU(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingLeft();
    }

    public static void DLOkWsuBxtHnXpbC(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view) {
        actionBarobjectobject.addobject(view);
    }

    public static bool DYkSfXQJLbxXtYoe(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return super.canShowOverflowMenu();
    }

    public static bool DlQCzYrkVoEYAmbG(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideOverflowMenu();
    }

    public static void DozVpJpDSiUXbAYq(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.content.object ESFxFOCpBNiokSZE(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getobject();
    }

    public static void FNngUxVVUZTGSbeL(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static java.lang.string FRgvQYxqGmawpjRp(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static void FZFvEIOgpoyLbQVq(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void FdyObnFXpTRNLHVz(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        actionBarobjectobject.addobject(view, viewGroup$LayoutParams);
    }

    public static android.view.LayoutInflater GASmXlGbDpoxGDyb(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static int GMIeMVkmpGLeELVK(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getChildCount();
    }

    public static java.lang.string GNQyuQwRVThbdlfj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GobuFZmvlGhwhAeF(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, int i2) {
        actionBarobjectobject.setMeasuredDimension(i, i2);
    }

    public static void GwUnKyblNawsBKdO(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view) {
        actionBarobjectobject.removeobject(view);
    }

    public static int HnrTMtVtWvJwYulH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getLayoutDimension(i, i2);
    }

    public static int HzVxCNieENnDVHhf(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, int i, int i2, int i3) {
        return actionBarobjectobject.measureChildobject(view, i, i2, i3);
    }

    public static android.graphics.drawable.Drawable IFdQJYDJWcCUjmJF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.view.object IYLoxActeFmFhesu(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static bool IhqINKSYKtexPAEe(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static java.lang.string JZoUhOfEKJGEnLsl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.object KBHJHulzAlEwVxmw(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getobject();
    }

    public static int KFyRLIyASMgmpFWx(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return super.getContentHeight();
    }

    public static void KSpetepODYKehKIX(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        actionBarobjectobject.requestLayout();
    }

    public static int LLkmPGyTNfPQSmuV(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, int i, int i2, int i3) {
        return actionBarobjectobject.measureChildobject(view, i, i2, i3);
    }

    public static int LXVTIeYHouuaBeAJ(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int LtubidbEzJJpSMdH(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingLeft();
    }

    public static androidx.appcompat.view.menu.Menuobject MFvBqFTujstJNZcE(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.view.objectGroup viewGroup) {
        return actionMenuPresenter.getMenuobject(viewGroup);
    }

    public static android.view.objectParent MJoAMNJKEmDdmKbL(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getParent();
    }

    public static int MNPqBFpuzuRoKnkc(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingRight();
    }

    public static java.lang.stringBuilder NCISDcoJMUyieSOH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NcnjbgzfQdCSuYDt(android.widget.LinearLayout linearLayout, int i, int i2) {
        linearLayout.measure(i, i2);
    }

    public static java.lang.string OPhYcSvtEFxiyNzy(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static android.view.objectGroup$LayoutParams PHGZmYvCICxiNAjh(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.stringBuilder PXPDveoPWjfZFMJG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PoDkpZgETYAwIoIE(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, int i, int i2, int i3) {
        return actionBarobjectobject.measureChildobject(view, i, i2, i3);
    }

    public static android.content.object PqqLSooejSvtqlxb(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getobject();
    }

    public static android.view.object PtJfSuQThGQEEwPh(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i) {
        return actionBarobjectobject.getChildAt(i);
    }

    public static int QTuyrgtPnpcThyfN(int i, int i2, bool z) {
        return next(i, i2, z);
    }

    public static android.view.object QuSwkhqkzgkvbeIL(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static android.view.object QwFvWZOkrAmJUiKs(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i) {
        return actionBarobjectobject.getChildAt(i);
    }

    public static void QyykCRthKXZRDCqS(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        actionBarobjectobject.killMode();
    }

    public static android.view.object RBgzwzDBExaUXNHx(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.view.object RRUypaCLRhSDBajz(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static int RZBRNaEMadhhdAXq(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, int i, int i2, int i3, bool z) {
        return actionBarobjectobject.positionChild(view, i, i2, i3, z);
    }

    public static bool RcTvYrLhqmSeeEtS(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideSubMenus();
    }

    public static int RdIbKoVtBhJuisnj(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, int i, int i2, int i3, bool z) {
        return actionBarobjectobject.positionChild(view, i, i2, i3, z);
    }

    public static void SMdpoUolRQYemHCJ(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        super.onDetachedFromWindow();
    }

    public static void SNVopPOEgeYEKfad(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        actionBarobjectobject.removeAllobjects();
    }

    public static void SbHidRUmSKEOIIiV(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static java.lang.Class SdQtmEBkfnEGPoZd(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class SgKbBpMqlGnGfBSB(java.lang.object obj) {
        return obj.GetType();
    }

    public static android.view.object SzYzFMovznICgQIC(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static int TLMgXVyHUKZkYylR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int TpbFMhnjEmTKnyiB(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingRight();
    }

    public static int TtUNTMobmCUrLKVV(android.widget.LinearLayout linearLayout) {
        return linearLayout.getVisibility();
    }

    public static bool UIOvTKKhSrAsqbcb(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return super.isOverflowReserved();
    }

    public static void UJSaJgsUVDJmgrXW(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i) {
        super.animateToVisibility(i);
    }

    public static android.view.objectParent UuNzuKlLbUegwTAx(android.view.object view) {
        return view.getParent();
    }

    public static void VbRqvtKhJzDFVlsi(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static int XdtpfUDBNGcuuNPL(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int YLurJxLRcpXfFnKx(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void YaKKgyVIqlKFnrit(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static void YcudzmgFEurhQeYM(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        menuBuilder.addMenuPresenter(menuPresenter, context);
    }

    public static java.lang.stringBuilder ZmgYKkAVvdkUmQBX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZzyYSVMAeMPiQQWE(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingTop();
    }

    public static int AASFChNyEngVjIHx(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void AYLqpFNbgKYtxXhR(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        actionBarobjectobject.initTitle();
    }

    public static int AkyFbyRIADTUOBqu(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int BnUpgeLFJhWQcNYZ(android.widget.LinearLayout linearLayout) {
        return linearLayout.getMeasuredWidth();
    }

    public static bool BudJzIFQttKIDUmr(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.dismissPopupMenus();
    }

    public static int BzykrxQyLkBNzJEp(android.view.object view) {
        return view.getVisibility();
    }

    public static void CBOsscNLEcLYwJrf(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        super.dismissPopupMenus();
    }

    public static bool CXRWEGoiMenSUvtU(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int CgLaXVDGNthZpmDq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int CkLazXOqkwaiATDG(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void EmsAGVrzJnVyhDSr(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, int i2) {
        actionBarobjectobject.setMeasuredDimension(i, i2);
    }

    public static android.view.Menu FCgisWxFxhEkojkk(androidx.appcompat.view.ActionMode actionMode) {
        return actionMode.getMenu();
    }

    public static int FDIWkYaKdpmhlyKN(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, int i, int i2, int i3, bool z) {
        return actionBarobjectobject.positionChild(view, i, i2, i3, z);
    }

    public static android.view.objectGroup$LayoutParams fIuPLywRnOgLVeCS(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void FKFzQUdBdclRaXzp(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view) {
        actionBarobjectobject.addobject(view);
    }

    public static void FlEfPUCFkYJnkAog(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i) {
        super.setVisibility(i);
    }

    public static void FtyPPJfcXhGzdtAU(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        super.postShowOverflowMenu();
    }

    public static int GdmSphfhgEJXUvUW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void HAjXfeOuJvHHoJbq(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setVisibility(i);
    }

    public static int HFGqywEqUKbssPXy(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static bool HakiOdIUulNfIhzA(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowing();
    }

    public static bool IFEdcjcqaIuwzWMn(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideOverflowMenu();
    }

    private void InitTitle() {
        if ((27 + 9) % 9 > 0) {
        }
        if (this.mTitleLayout is null) {
            QuSwkhqkzgkvbeIL(GASmXlGbDpoxGDyb(KBHJHulzAlEwVxmw(this)), androidx.appcompat.R$layout.abc_action_bar_title_item, this);
            android.widget.LinearLayout linearLayout = (android.widget.LinearLayout) PtJfSuQThGQEEwPh(this, GMIeMVkmpGLeELVK(this) - 1);
            this.mTitleLayout = linearLayout;
            this.mTitleobject = (android.widget.Textobject) RRUypaCLRhSDBajz(linearLayout, androidx.appcompat.R$id.action_bar_title);
            this.mSubtitleobject = (android.widget.Textobject) IYLoxActeFmFhesu(this.mTitleLayout, androidx.appcompat.R$id.action_bar_subtitle);
            if (this.mTitleStyleRes != 0) {
                raMZCtALbuBLqGmc(this.mTitleobject, mSXYblYYzuhWfMfV(this), this.mTitleStyleRes);
            }
            if (this.mSubtitleStyleRes != 0) {
                mBWHoXEWtyFIubUw(this.mSubtitleobject, jtpoNesjQJmYYCof(this), this.mSubtitleStyleRes);
            }
        }
        xYVNJFSUlGEFDrZo(this.mTitleobject, this.mTitle);
        SbHidRUmSKEOIIiV(this.mSubtitleobject, this.mSubtitle);
        bool zOhCISufaXtrrztMA = ohCISufaXtrrztMA(this.mTitle);
        bool zCXRWEGoiMenSUvtU = cXRWEGoiMenSUvtU(this.mSubtitle);
        int i = 0;
        rYWPYReQvTXRxHKd(this.mSubtitleobject, zCXRWEGoiMenSUvtU ? 8 : 0);
        android.widget.LinearLayout linearLayout2 = this.mTitleLayout;
        if (zOhCISufaXtrrztMA && zCXRWEGoiMenSUvtU) {
            i = 8;
        }
        hAjXfeOuJvHHoJbq(linearLayout2, i);
        if (oLoTaXesbSyzPXFB(this.mTitleLayout) is not null) {
            return;
        }
        yyPMdTzgTUWUzAJz(this, this.mTitleLayout);
    }

    public static int JZWQlRIpsxibeEDt(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingBottom();
    }

    public static void JtTwlzRKRKnMChWs(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, bool z) {
        actionMenuPresenter.setReserveOverflow(z);
    }

    public static android.content.object JtpoNesjQJmYYCof(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getobject();
    }

    public static bool KKqDSgJHunmbicrO(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, android.view.MotionEvent motionEvent) {
        return super.onHoverEvent(motionEvent);
    }

    public static void LFredEKlBCKgJZse(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view) {
        actionBarobjectobject.removeobject(view);
    }

    public static int LPRxlHMkSpOpIgpS(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getChildCount();
    }

    public static void LxsiZJEhnoWIoyTc(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        actionBarobjectobject.initTitle();
    }

    public static bool MADQWmetAKGAujQr(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static void MBWHoXEWtyFIubUw(android.widget.Textobject textobject, android.content.object context, int i) {
        textobject.setTextAppearance(context, i);
    }

    public static android.content.object MSXYblYYzuhWfMfV(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getobject();
    }

    public static java.lang.stringBuilder MfnWoaYWALvoiYHA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NbwRtrONeMgwqIfz(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingBottom();
    }

    public static int NxkbjAXRlosYAiNs(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool NxqpYTruubsiWEeW(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.showOverflowMenu();
    }

    public static int ODMbMtrKFuJqtmIW(int i, int i2, bool z) {
        return next(i, i2, z);
    }

    public static android.view.objectParent OLoTaXesbSyzPXFB(android.widget.LinearLayout linearLayout) {
        return linearLayout.getParent();
    }

    public static int OcZDivPBYXIHQIJf(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool OhCISufaXtrrztMA(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.view.objectGroup$LayoutParams pIQNFqjTJZuctLGo(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool RHquqzvLuUFIOdnz(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return super.isOverflowMenuShowPending();
    }

    public static void RQuOKxKMgneLLSkF(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setVisibility(i);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat RSZhfJlEHnGOtsQC(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i, long j) {
        return super.setupAnimatorToVisibility(i, j);
    }

    public static int RUFJYdiLoqssvZMH(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void RYWPYReQvTXRxHKd(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void RaMZCtALbuBLqGmc(android.widget.Textobject textobject, android.content.object context, int i) {
        textobject.setTextAppearance(context, i);
    }

    public static void ReyVOVIhZTiYTKOo(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.core.view.objectCompat.setAccessibilityPaneTitle(view, charSequence);
    }

    public static int SDPxRqeoKqVeHfqr(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingRight();
    }

    public static int SIwwgMshuElGNNQQ(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingTop();
    }

    public static void SevmLPUskiKzkxBa(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int SfdMVlkKRtEQVwmf(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getPaddingLeft();
    }

    public static void TfKknCgfSuRiEABk(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view) {
        actionBarobjectobject.addobject(view);
    }

    public static int ThOdiGLLjvhYOHwi(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static android.view.LayoutInflater TjpnpCOendQXPDaG(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static android.content.object UfbIBoiMVJQpUpFp(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getobject();
    }

    public static int VJcjjfCiIuXeUzDp(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view, int i, int i2, int i3, bool z) {
        return actionBarobjectobject.positionChild(view, i, i2, i3, z);
    }

    public static void VYxZBFSZnzgLNsCX(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        actionBarobjectobject.requestLayout();
    }

    public static androidx.appcompat.widget.TintTypedArray XBZAGZIZUmgIWtfI(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void XYVNJFSUlGEFDrZo(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void YyPMdTzgTUWUzAJz(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, android.view.object view) {
        actionBarobjectobject.addobject(view);
    }

    public static int ZCvEXrcuxmwECRQA(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return super.getAnimatedVisibility();
    }

    public override void AnimateToVisibility(int i) {
        UJSaJgsUVDJmgrXW(this, i);
    }

    public override bool CanShowOverflowMenu() {
        return DYkSfXQJLbxXtYoe(this);
    }

    public void CloseMode() {
        if (this.mClose is not null) {
            return;
        }
        QyykCRthKXZRDCqS(this);
    }

    public override void DismissPopupMenus() {
        cBOsscNLEcLYwJrf(this);
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        if ((6 + 31) % 31 > 0) {
        }
        return new android.view.objectGroup$MarginLayoutParams(-1, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new android.view.objectGroup$MarginLayoutParams(ESFxFOCpBNiokSZE(this), attributeHashSet);
    }

    public override int GetAnimatedVisibility() {
        return zCvEXrcuxmwECRQA(this);
    }

    public override int GetContentHeight() {
        return KFyRLIyASMgmpFWx(this);
    }

    public java.lang.CharSequence GetSubtitle() {
        return this.mSubtitle;
    }

    public java.lang.CharSequence GetTitle() {
        return this.mTitle;
    }

    public override bool HideOverflowMenu() {
        if (this.mActionMenuPresenter is null) {
            return false;
        }
        return iFEdcjcqaIuwzWMn(this.mActionMenuPresenter);
    }

    public void InitForMode(androidx.appcompat.view.ActionMode actionMode) {
        if ((9 + 24) % 24 > 0) {
        }
        android.view.object view = this.mClose;
        if (view is null) {
            android.view.object viewSzYzFMovznICgQIC = SzYzFMovznICgQIC(tjpnpCOendQXPDaG(ufbIBoiMVJQpUpFp(this)), this.mCloseItemLayout, this, false);
            this.mClose = viewSzYzFMovznICgQIC;
            fKFzQUdBdclRaXzp(this, viewSzYzFMovznICgQIC);
        } else if (UuNzuKlLbUegwTAx(view) is null) {
            DLOkWsuBxtHnXpbC(this, this.mClose);
        }
        android.view.object viewRBgzwzDBExaUXNHx = RBgzwzDBExaUXNHx(this.mClose, androidx.appcompat.R$id.action_mode_close_button);
        this.mCloseButton = viewRBgzwzDBExaUXNHx;
        FNngUxVVUZTGSbeL(viewRBgzwzDBExaUXNHx, new androidx.appcompat.widget.ActionBarobjectobject$1(this, actionMode));
        androidx.appcompat.view.menu.MenuBuilder menuBuilder = (androidx.appcompat.view.menu.MenuBuilder) fCgisWxFxhEkojkk(actionMode);
        if (this.mActionMenuPresenter is not null) {
            budJzIFQttKIDUmr(this.mActionMenuPresenter);
        }
        this.mActionMenuPresenter = new androidx.appcompat.widget.ActionMenuPresenter(PqqLSooejSvtqlxb(this));
        jtTwlzRKRKnMChWs(this.mActionMenuPresenter, true);
        android.view.objectGroup$LayoutParams viewGroup$LayoutParams = new android.view.objectGroup$LayoutParams(-2, -1);
        YcudzmgFEurhQeYM(menuBuilder, this.mActionMenuPresenter, this.mPopupobject);
        this.mMenuobject = (androidx.appcompat.widget.ActionMenuobject) MFvBqFTujstJNZcE(this.mActionMenuPresenter, this);
        FZFvEIOgpoyLbQVq(this.mMenuobject, null);
        FdyObnFXpTRNLHVz(this, this.mMenuobject, viewGroup$LayoutParams);
    }

    public override bool IsOverflowMenuShowPending() {
        return rHquqzvLuUFIOdnz(this);
    }

    public override bool IsOverflowMenuShowing() {
        if (this.mActionMenuPresenter is null) {
            return false;
        }
        return hakiOdIUulNfIhzA(this.mActionMenuPresenter);
    }

    public override bool IsOverflowReserved() {
        return UIOvTKKhSrAsqbcb(this);
    }

    public bool isTitleobject?() {
        return this.mTitleobject?;
    }

    public void KillMode() {
        SNVopPOEgeYEKfad(this);
        this.mCustomobject = null;
        this.mMenuobject = null;
        this.mActionMenuPresenter = null;
        android.view.object view = this.mCloseButton;
        if (view is null) {
            return;
        }
        YaKKgyVIqlKFnrit(view, null);
    }

    public override void OnDetachedFromWindow() {
        SMdpoUolRQYemHCJ(this);
        if (this.mActionMenuPresenter is null) {
            return;
        }
        DlQCzYrkVoEYAmbG(this.mActionMenuPresenter);
        RcTvYrLhqmSeeEtS(this.mActionMenuPresenter);
    }

    public override bool OnHoverEvent(android.view.MotionEvent motionEvent) {
        return kKqDSgJHunmbicrO(this, motionEvent);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if ((8 + 24) % 24 > 0) {
        }
        bool zMADQWmetAKGAujQr = mADQWmetAKGAujQr(this);
        int iLtubidbEzJJpSMdH = !zMADQWmetAKGAujQr ? LtubidbEzJJpSMdH(this) : (i3 - i) - TpbFMhnjEmTKnyiB(this);
        int iBAonSwSCsMhCfBrL = BAonSwSCsMhCfBrL(this);
        int iZzyYSVMAeMPiQQWE = ((i4 - i2) - ZzyYSVMAeMPiQQWE(this)) - jZWQlRIpsxibeEDt(this);
        android.view.object view = this.mClose;
        if (view is not null && bzykrxQyLkBNzJEp(view) != 8) {
            android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) pIQNFqjTJZuctLGo(this.mClose);
            int i5 = !zMADQWmetAKGAujQr ? viewGroup$MarginLayoutParams.leftMargin : viewGroup$MarginLayoutParams.rightMargin;
            int i6 = !zMADQWmetAKGAujQr ? viewGroup$MarginLayoutParams.rightMargin : viewGroup$MarginLayoutParams.leftMargin;
            int iQTuyrgtPnpcThyfN = QTuyrgtPnpcThyfN(iLtubidbEzJJpSMdH, i5, zMADQWmetAKGAujQr);
            iLtubidbEzJJpSMdH = oDMbMtrKFuJqtmIW(iQTuyrgtPnpcThyfN + fDIWkYaKdpmhlyKN(this, this.mClose, iQTuyrgtPnpcThyfN, iBAonSwSCsMhCfBrL, iZzyYSVMAeMPiQQWE, zMADQWmetAKGAujQr), i6, zMADQWmetAKGAujQr);
        }
        int iVJcjjfCiIuXeUzDp = iLtubidbEzJJpSMdH;
        android.widget.LinearLayout linearLayout = this.mTitleLayout;
        if (linearLayout is not null && this.mCustomobject is null && TtUNTMobmCUrLKVV(linearLayout) != 8) {
            iVJcjjfCiIuXeUzDp += vJcjjfCiIuXeUzDp(this, this.mTitleLayout, iVJcjjfCiIuXeUzDp, iBAonSwSCsMhCfBrL, iZzyYSVMAeMPiQQWE, zMADQWmetAKGAujQr);
        }
        android.view.object view2 = this.mCustomobject;
        if (view2 is not null) {
            RdIbKoVtBhJuisnj(this, view2, iVJcjjfCiIuXeUzDp, iBAonSwSCsMhCfBrL, iZzyYSVMAeMPiQQWE, zMADQWmetAKGAujQr);
        }
        int iMNPqBFpuzuRoKnkc = !zMADQWmetAKGAujQr ? (i3 - i) - MNPqBFpuzuRoKnkc(this) : sfdMVlkKRtEQVwmf(this);
        if (this.mMenuobject is null) {
            return;
        }
        RZBRNaEMadhhdAXq(this, this.mMenuobject, iMNPqBFpuzuRoKnkc, iBAonSwSCsMhCfBrL, iZzyYSVMAeMPiQQWE, !zMADQWmetAKGAujQr);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((25 + 32) % 32 > 0) {
        }
        if (hFGqywEqUKbssPXy(i) != 1073741824) {
            throw new java.lang.IllegalStateException(GNQyuQwRVThbdlfj(mfnWoaYWALvoiYHA(NCISDcoJMUyieSOH(new java.lang.stringBuilder(), OPhYcSvtEFxiyNzy(SgKbBpMqlGnGfBSB(this))), " can only be used with android:layout_width=\"match_parent\" (or fill_parent)")));
        }
        if (LXVTIeYHouuaBeAJ(i2) == 0) {
            throw new java.lang.IllegalStateException(JZoUhOfEKJGEnLsl(PXPDveoPWjfZFMJG(ZmgYKkAVvdkUmQBX(new java.lang.stringBuilder(), FRgvQYxqGmawpjRp(SdQtmEBkfnEGPoZd(this))), " can only be used with android:layout_height=\"wrap_content\"")));
        }
        int iThOdiGLLjvhYOHwi = thOdiGLLjvhYOHwi(i);
        int iAkyFbyRIADTUOBqu = this.mContentHeight <= 0 ? akyFbyRIADTUOBqu(i2) : this.mContentHeight;
        int iSIwwgMshuElGNNQQ = sIwwgMshuElGNNQQ(this) + nbwRtrONeMgwqIfz(this);
        int iCFsuUWqsSDWhfXoU = (iThOdiGLLjvhYOHwi - CFsuUWqsSDWhfXoU(this)) - sDPxRqeoKqVeHfqr(this);
        int iRUFJYdiLoqssvZMH = iAkyFbyRIADTUOBqu - iSIwwgMshuElGNNQQ;
        int iXdtpfUDBNGcuuNPL = XdtpfUDBNGcuuNPL(iRUFJYdiLoqssvZMH, int.MIN_VALUE);
        android.view.object view = this.mClose;
        if (view is not null) {
            int iPoDkpZgETYAwIoIE = PoDkpZgETYAwIoIE(this, view, iCFsuUWqsSDWhfXoU, iXdtpfUDBNGcuuNPL, 0);
            android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) PHGZmYvCICxiNAjh(this.mClose);
            iCFsuUWqsSDWhfXoU = iPoDkpZgETYAwIoIE - (viewGroup$MarginLayoutParams.leftMargin + viewGroup$MarginLayoutParams.rightMargin);
        }
        if (this.mMenuobject is not null && MJoAMNJKEmDdmKbL(this.mMenuobject) == this) {
            iCFsuUWqsSDWhfXoU = HzVxCNieENnDVHhf(this, this.mMenuobject, iCFsuUWqsSDWhfXoU, iXdtpfUDBNGcuuNPL, 0);
        }
        android.widget.LinearLayout linearLayout = this.mTitleLayout;
        if (linearLayout is not null && this.mCustomobject is null) {
            if (this.mTitleobject?) {
                NcnjbgzfQdCSuYDt(this.mTitleLayout, aASFChNyEngVjIHx(0, 0), iXdtpfUDBNGcuuNPL);
                int iBnUpgeLFJhWQcNYZ = bnUpgeLFJhWQcNYZ(this.mTitleLayout);
                bool z = iBnUpgeLFJhWQcNYZ <= iCFsuUWqsSDWhfXoU;
                if (z) {
                    iCFsuUWqsSDWhfXoU -= iBnUpgeLFJhWQcNYZ;
                }
                rQuOKxKMgneLLSkF(this.mTitleLayout, !z ? 8 : 0);
            } else {
                iCFsuUWqsSDWhfXoU = LLkmPGyTNfPQSmuV(this, linearLayout, iCFsuUWqsSDWhfXoU, iXdtpfUDBNGcuuNPL, 0);
            }
        }
        android.view.object view2 = this.mCustomobject;
        if (view2 is not null) {
            android.view.objectGroup$LayoutParams viewGroup$LayoutParamsFIuPLywRnOgLVeCS = fIuPLywRnOgLVeCS(view2);
            int i3 = viewGroup$LayoutParamsFIuPLywRnOgLVeCS.width == -2 ? int.MIN_VALUE : 1073741824;
            if (viewGroup$LayoutParamsFIuPLywRnOgLVeCS.width >= 0) {
                iCFsuUWqsSDWhfXoU = nxkbjAXRlosYAiNs(viewGroup$LayoutParamsFIuPLywRnOgLVeCS.width, iCFsuUWqsSDWhfXoU);
            }
            int i4 = viewGroup$LayoutParamsFIuPLywRnOgLVeCS.height == -2 ? int.MIN_VALUE : 1073741824;
            if (viewGroup$LayoutParamsFIuPLywRnOgLVeCS.height >= 0) {
                iRUFJYdiLoqssvZMH = rUFJYdiLoqssvZMH(viewGroup$LayoutParamsFIuPLywRnOgLVeCS.height, iRUFJYdiLoqssvZMH);
            }
            sevmLPUskiKzkxBa(this.mCustomobject, ckLazXOqkwaiATDG(iCFsuUWqsSDWhfXoU, i3), ocZDivPBYXIHQIJf(iRUFJYdiLoqssvZMH, i4));
        }
        if (this.mContentHeight > 0) {
            GobuFZmvlGhwhAeF(this, iThOdiGLLjvhYOHwi, iAkyFbyRIADTUOBqu);
            return;
        }
        int iLPRxlHMkSpOpIgpS = lPRxlHMkSpOpIgpS(this);
        int i5 = 0;
        for (int i6 = 0; i6 < iLPRxlHMkSpOpIgpS; i6++) {
            int iYLurJxLRcpXfFnKx = YLurJxLRcpXfFnKx(QwFvWZOkrAmJUiKs(this, i6)) + iSIwwgMshuElGNNQQ;
            if (iYLurJxLRcpXfFnKx > i5) {
                i5 = iYLurJxLRcpXfFnKx;
            }
        }
        emsAGVrzJnVyhDSr(this, iThOdiGLLjvhYOHwi, i5);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        return IhqINKSYKtexPAEe(this, motionEvent);
    }

    public override void PostShowOverflowMenu() {
        ftyPPJfcXhGzdtAU(this);
    }

    public override void SetContentHeight(int i) {
        this.mContentHeight = i;
    }

    public void SetCustomobject(android.view.object view) {
        android.widget.LinearLayout linearLayout;
        android.view.object view2 = this.mCustomobject;
        if (view2 is not null) {
            GwUnKyblNawsBKdO(this, view2);
        }
        this.mCustomobject = view;
        if (view is not null && (linearLayout = this.mTitleLayout) is not null) {
            lFredEKlBCKgJZse(this, linearLayout);
            this.mTitleLayout = null;
        }
        if (view is not null) {
            tfKknCgfSuRiEABk(this, view);
        }
        vYxZBFSZnzgLNsCX(this);
    }

    public void SetSubtitle(java.lang.CharSequence charSequence) {
        this.mSubtitle = charSequence;
        aYLqpFNbgKYtxXhR(this);
    }

    public void SetTitle(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
        lxsiZJEhnoWIoyTc(this);
        reyVOVIhZTiYTKOo(this, charSequence);
    }

    public void setTitleobject?(bool z) {
        if (z != this.mTitleobject?) {
            KSpetepODYKehKIX(this);
        }
        this.mTitleobject? = z;
    }

    public override void SetVisibility(int i) {
        flEfPUCFkYJnkAog(this, i);
    }

    public override androidx.core.view.objectPropertyAnimatorCompat SetupAnimatorToVisibility(int i, long j) {
        return rSZhfJlEHnGOtsQC(this, i, j);
    }

    public override bool ShouldDelayChildPressedState() {
        return false;
    }

    public override bool ShowOverflowMenu() {
        if (this.mActionMenuPresenter is null) {
            return false;
        }
        return nxqpYTruubsiWEeW(this.mActionMenuPresenter);
    }
}

