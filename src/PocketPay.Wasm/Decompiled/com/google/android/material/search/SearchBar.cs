namespace WillowMaze.Wasm.Decompiled;


public class SearchBar : androidx.appcompat.widget.Toolbar {
    private static readonly int DEFAULT_SCROLL_FLAGS = 53;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Material3_SearchBar;
    private static readonly java.lang.string NAMESPACE_APP = "http://schemas.android.com/apk/res-auto";
    private readonly android.view.accessibility.AccessibilityManager accessibilityManager;
    private com.google.android.material.shape.MaterialShapeDrawable backgroundShape;
    private android.view.object centerobject;
    private readonly bool defaultMarginsEnabled;
    private readonly android.graphics.drawable.Drawable defaultNavigationIcon;
    private bool defaultScrollFlagsEnabled;
    private readonly bool forceDefaultNavigationOnClickListener;
    private readonly bool layoutInflated;
    private int menuResId;
    private java.lang.int navigationIconTint;
    private android.graphics.drawable.Drawable originalNavigationIconBackground;
    private readonly com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper;
    private readonly android.widget.Textobject textobject;
    private readonly bool tintNavigationIcon;
    private readonly androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener touchExplorationStateChangeListener;

    public SearchBar(android.content.object context) {
        this(context, null);
    }

    public SearchBar(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialSearchBarStyle);
    }

    public SearchBar(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((9 + 2) % 2 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(CPjxRwJoupiwmwwW(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.menuResId = -1;
        this.touchExplorationStateChangeListener = new com.google.android.material.search.SearchBar$$ExternalSyntheticLambda1(this);
        android.content.object contextTrqOmddtrbygTYVj = TrqOmddtrbygTYVj(this);
        uJzlNAmdcwUjbnsl(this, attributeHashSet);
        this.defaultNavigationIcon = gWxSTFkmhuZwteyz(contextTrqOmddtrbygTYVj, hoTJfoEeksDKaIUU(this));
        this.searchBarAnimationHelper = new com.google.android.material.search.SearchBarAnimationHelper();
        android.content.res.TypedArray typedArrayRLvvcjOJJryARQtm = RLvvcjOJJryARQtm(contextTrqOmddtrbygTYVj, attributeHashSet, com.google.android.material.R$styleable.SearchBar, i, i2, new int[0]);
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelICnRhtRlXRymkmFJ = iCnRhtRlXRymkmFJ(sCfNhUCHJmczyuSa(contextTrqOmddtrbygTYVj, attributeHashSet, i, i2));
        int iCshWvAGRftUFVode = CshWvAGRftUFVode(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_backgroundTint, 0);
        float fAvqMjTjLvwrGRMDM = AvqMjTjLvwrGRMDM(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_elevation, 0.0f);
        this.defaultMarginsEnabled = nWxGaAoKVQfihtyf(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_defaultMarginsEnabled, true);
        this.defaultScrollFlagsEnabled = iDehWaTnatJfmVRq(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_defaultScrollFlagsEnabled, true);
        bool zVspLPoMKsLJBjKgH = VspLPoMKsLJBjKgH(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_hideNavigationIcon, false);
        this.forceDefaultNavigationOnClickListener = ARwehsalTJvpidFJ(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_forceDefaultNavigationOnClickListener, false);
        this.tintNavigationIcon = TXYXHKbCWsoyUlnH(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_tintNavigationIcon, true);
        if (SxnEVOnxYVPGzmrN(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_navigationIconTint)) {
            this.navigationIconTint = CdmDZUUjpDVYYBFO(LCFjRXIoIzgvQvUT(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_navigationIconTint, -1));
        }
        int iQGkXvpzngRVUkmtx = qGkXvpzngRVUkmtx(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_android_textAppearance, -1);
        java.lang.string strDqmTOFUpezVcCLyi = DqmTOFUpezVcCLyi(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_android_text);
        java.lang.string strFIGpegaoGmONTHOr = FIGpegaoGmONTHOr(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_android_hint);
        float fYAkXczqskmaWFbSY = YAkXczqskmaWFbSY(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_strokeWidth, -1.0f);
        int iHmPpFZvBtsqNIxLO = HmPpFZvBtsqNIxLO(typedArrayRLvvcjOJJryARQtm, com.google.android.material.R$styleable.SearchBar_strokeColor, 0);
        bgsNswbfPJvOdWVb(typedArrayRLvvcjOJJryARQtm);
        if (!zVspLPoMKsLJBjKgH) {
            wsffbsNDpOFmvIoQ(this);
        }
        uTEMpbgYdrXBcCMa(this, true);
        KbJHqyXwrLtpCcUm(this, true);
        VsPhNELpquoCttXa(lXsiDuqIDkclcUvn(contextTrqOmddtrbygTYVj), com.google.android.material.R$layout.mtrl_search_bar, this);
        this.layoutInflated = true;
        this.textobject = (android.widget.Textobject) NPtQWxxuHGTkixmp(this, com.google.android.material.R$id.open_search_bar_text_view);
        mpCgPaEQRhsENZli(this, fAvqMjTjLvwrGRMDM);
        ETQVFrmNBLDSFEdD(this, iQGkXvpzngRVUkmtx, strDqmTOFUpezVcCLyi, strFIGpegaoGmONTHOr);
        meQVciFgnPiWHoba(this, shapeAppearanceModelICnRhtRlXRymkmFJ, iCshWvAGRftUFVode, fAvqMjTjLvwrGRMDM, fYAkXczqskmaWFbSY, iHmPpFZvBtsqNIxLO);
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) SfCdMrIUCxGOULql(idPUtNGLJaGhJFOT(this), "accessibility");
        EWlfQbuKFGWtXdsp(this);
    }

    public static void AGRHeeaouFBdMCHK(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void AGRHeeaouFBdMCHK(android.widget.Textobject textobject, int i, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AGRHeeaouFBdMCHK(android.widget.Textobject textobject, int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AGRHeeaouFBdMCHK(android.widget.Textobject textobject, int i, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ARwehsalTJvpidFJ(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARwehsalTJvpidFJ(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ARwehsalTJvpidFJ(android.content.res.TypedArray typedArray, int i, bool z, short s, bool z2, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool ARwehsalTJvpidFJ(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static float AvqMjTjLvwrGRMDM(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void AvqMjTjLvwrGRMDM(android.content.res.TypedArray typedArray, int i, float f, byte b, float f2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvqMjTjLvwrGRMDM(android.content.res.TypedArray typedArray, int i, float f, char c, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void AvqMjTjLvwrGRMDM(android.content.res.TypedArray typedArray, int i, float f, char c, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void BCPwmkGMwdGVucVA(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i) {
        appBarLayout$LayoutParams.setScrollFlags(i);
    }

    public static void BCPwmkGMwdGVucVA(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BCPwmkGMwdGVucVA(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BCPwmkGMwdGVucVA(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BDsDvwqZDyNCTzdz(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.addobject(view, i, viewGroup$LayoutParams);
    }

    public static void BDsDvwqZDyNCTzdz(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BDsDvwqZDyNCTzdz(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BDsDvwqZDyNCTzdz(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpfevlsTsMQxFlrm(com.google.android.material.search.SearchBar searchBar) {
        searchBar.setHandwritingBoundsInsets();
    }

    public static void BpfevlsTsMQxFlrm(com.google.android.material.search.SearchBar searchBar, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpfevlsTsMQxFlrm(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpfevlsTsMQxFlrm(com.google.android.material.search.SearchBar searchBar, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CJAIgUggfPkOxtXu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void CJAIgUggfPkOxtXu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CJAIgUggfPkOxtXu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CJAIgUggfPkOxtXu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMBAIyZlEAaMMEYJ(com.google.android.material.search.SearchBar searchBar, bool z) {
        searchBar.setNavigationIconDecorative(z);
    }

    public static void CMBAIyZlEAaMMEYJ(com.google.android.material.search.SearchBar searchBar, bool z, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CMBAIyZlEAaMMEYJ(com.google.android.material.search.SearchBar searchBar, bool z, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CMBAIyZlEAaMMEYJ(com.google.android.material.search.SearchBar searchBar, bool z, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object CPjxRwJoupiwmwwW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void CPjxRwJoupiwmwwW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, byte b, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CPjxRwJoupiwmwwW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, float f, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void CPjxRwJoupiwmwwW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams CYTRewAeKIpBaQND(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getLayoutParams();
    }

    public static void CYTRewAeKIpBaQND(com.google.android.material.search.SearchBar searchBar, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYTRewAeKIpBaQND(com.google.android.material.search.SearchBar searchBar, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYTRewAeKIpBaQND(com.google.android.material.search.SearchBar searchBar, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int CdmDZUUjpDVYYBFO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void CdmDZUUjpDVYYBFO(int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdmDZUUjpDVYYBFO(int i, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdmDZUUjpDVYYBFO(int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CshWvAGRftUFVode(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void CshWvAGRftUFVode(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CshWvAGRftUFVode(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CshWvAGRftUFVode(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CshrHloYnhUJmXhG(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CshrHloYnhUJmXhG(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CshrHloYnhUJmXhG(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CshrHloYnhUJmXhG(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper) {
        return searchBarAnimationHelper.isExpanding();
    }

    public static void DERhlefidGFxQosT(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DERhlefidGFxQosT(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DERhlefidGFxQosT(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DERhlefidGFxQosT(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper) {
        return searchBarAnimationHelper.isOnLoadAnimationFadeInEnabled();
    }

    public static int DIEDKCxkEehuvbyO(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void DIEDKCxkEehuvbyO(android.view.object view, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DIEDKCxkEehuvbyO(android.view.object view, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DIEDKCxkEehuvbyO(android.view.object view, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DYQQNRhFgIfLmNuA(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable) {
        searchBar.setNavigationIcon(drawable);
    }

    public static void DYQQNRhFgIfLmNuA(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYQQNRhFgIfLmNuA(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DYQQNRhFgIfLmNuA(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhnYTikhhxLPzwyr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setText(charSequence);
    }

    public static void DhnYTikhhxLPzwyr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DhnYTikhhxLPzwyr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DhnYTikhhxLPzwyr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DocjnxXjvGoiLJbS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        searchBarAnimationHelper.addExpandAnimationListener(animatorListenerAdapter);
    }

    public static void DocjnxXjvGoiLJbS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DocjnxXjvGoiLJbS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DocjnxXjvGoiLJbS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DqmTOFUpezVcCLyi(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void DqmTOFUpezVcCLyi(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DqmTOFUpezVcCLyi(android.content.res.TypedArray typedArray, int i, short s, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DqmTOFUpezVcCLyi(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ETQVFrmNBLDSFEdD(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, java.lang.string str2) {
        searchBar.initTextobject(i, str, str2);
    }

    public static void ETQVFrmNBLDSFEdD(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, java.lang.string str2, char c, int i2, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ETQVFrmNBLDSFEdD(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, java.lang.string str2, int i2, char c, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ETQVFrmNBLDSFEdD(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, java.lang.string str2, java.lang.string str3, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWlfQbuKFGWtXdsp(com.google.android.material.search.SearchBar searchBar) {
        searchBar.setupTouchExplorationStateChangeListener();
    }

    public static void EWlfQbuKFGWtXdsp(com.google.android.material.search.SearchBar searchBar, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EWlfQbuKFGWtXdsp(com.google.android.material.search.SearchBar searchBar, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EWlfQbuKFGWtXdsp(com.google.android.material.search.SearchBar searchBar, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ErFjFQWHwIcrTZUh(android.widget.ImageButton imageButton, bool z) {
        imageButton.setFocusable(z);
    }

    public static void ErFjFQWHwIcrTZUh(android.widget.ImageButton imageButton, bool z, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ErFjFQWHwIcrTZUh(android.widget.ImageButton imageButton, bool z, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ErFjFQWHwIcrTZUh(android.widget.ImageButton imageButton, bool z, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FIGpegaoGmONTHOr(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void FIGpegaoGmONTHOr(android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FIGpegaoGmONTHOr(android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FIGpegaoGmONTHOr(android.content.res.TypedArray typedArray, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FKNxKwcGYsgIByyt(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void FKNxKwcGYsgIByyt(android.content.res.Resources resources, int i, byte b, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FKNxKwcGYsgIByyt(android.content.res.Resources resources, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FKNxKwcGYsgIByyt(android.content.res.Resources resources, int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FXZJlprTjnaeOZwE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback) {
        searchBarAnimationHelper.addOnLoadAnimationCallback(searchBar$OnLoadAnimationCallback);
    }

    public static void FXZJlprTjnaeOZwE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FXZJlprTjnaeOZwE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FXZJlprTjnaeOZwE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FfcjnwLGbXtbOdUu(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams) {
        return appBarLayout$LayoutParams.getScrollFlags();
    }

    public static void FfcjnwLGbXtbOdUu(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FfcjnwLGbXtbOdUu(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FfcjnwLGbXtbOdUu(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FiptoBlfWMByEUdd(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getMeasuredWidth();
    }

    public static void FiptoBlfWMByEUdd(com.google.android.material.search.SearchBar searchBar, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FiptoBlfWMByEUdd(com.google.android.material.search.SearchBar searchBar, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FiptoBlfWMByEUdd(com.google.android.material.search.SearchBar searchBar, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FoAEIxXNaVsAhhQJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void FoAEIxXNaVsAhhQJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, float f2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FoAEIxXNaVsAhhQJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, float f2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FoAEIxXNaVsAhhQJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, int i, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void GIMJsCCwyiTZXtlN(com.google.android.material.search.SearchBar searchBar, android.view.object view) {
        searchBar.addobject(view);
    }

    public static void GIMJsCCwyiTZXtlN(com.google.android.material.search.SearchBar searchBar, android.view.object view, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GIMJsCCwyiTZXtlN(com.google.android.material.search.SearchBar searchBar, android.view.object view, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GIMJsCCwyiTZXtlN(com.google.android.material.search.SearchBar searchBar, android.view.object view, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GLiEgiZVyUskCMUO(com.google.android.material.search.SearchBar searchBar, bool z) {
        searchBar.setFocusableInTouchMode(z);
    }

    public static void GLiEgiZVyUskCMUO(com.google.android.material.search.SearchBar searchBar, bool z, char c, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GLiEgiZVyUskCMUO(com.google.android.material.search.SearchBar searchBar, bool z, float f, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GLiEgiZVyUskCMUO(com.google.android.material.search.SearchBar searchBar, bool z, bool z2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GNEsApaQfyecDhYG(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void GNEsApaQfyecDhYG(android.graphics.drawable.Drawable drawable, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNEsApaQfyecDhYG(android.graphics.drawable.Drawable drawable, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNEsApaQfyecDhYG(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSZtamCuEtFKSlFK(android.widget.Textobject textobject, int i) {
        textobject.setText(i);
    }

    public static void HSZtamCuEtFKSlFK(android.widget.Textobject textobject, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HSZtamCuEtFKSlFK(android.widget.Textobject textobject, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HSZtamCuEtFKSlFK(android.widget.Textobject textobject, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList HhyDoyLaGwCEJjmA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getStrokeColor();
    }

    public static void HhyDoyLaGwCEJjmA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HhyDoyLaGwCEJjmA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HhyDoyLaGwCEJjmA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int HmPpFZvBtsqNIxLO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void HmPpFZvBtsqNIxLO(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HmPpFZvBtsqNIxLO(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HmPpFZvBtsqNIxLO(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HyDhZXKlZiPgvwHF(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener) {
        super.setNavigationOnClickListener(view$OnClickListener);
    }

    public static void HyDhZXKlZiPgvwHF(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HyDhZXKlZiPgvwHF(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HyDhZXKlZiPgvwHF(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams HzBazOIuwzxHJapi(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static void HzBazOIuwzxHJapi(android.widget.Textobject textobject, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HzBazOIuwzxHJapi(android.widget.Textobject textobject, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HzBazOIuwzxHJapi(android.widget.Textobject textobject, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IMfrKowwlguQfOAr(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void IMfrKowwlguQfOAr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IMfrKowwlguQfOAr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IMfrKowwlguQfOAr(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IOPnIhyDXlElTEiR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar) {
        searchBarAnimationHelper.stopOnLoadAnimation(searchBar);
    }

    public static void IOPnIhyDXlElTEiR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IOPnIhyDXlElTEiR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IOPnIhyDXlElTEiR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IRwkWwtYSvecCtkH(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setShowingHintText(z);
    }

    public static void IRwkWwtYSvecCtkH(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, java.lang.string str, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IRwkWwtYSvecCtkH(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, int i, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IRwkWwtYSvecCtkH(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, java.lang.string str, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable IjWRRHXNvLVpxHNb(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getNavigationIcon();
    }

    public static void IjWRRHXNvLVpxHNb(com.google.android.material.search.SearchBar searchBar, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IjWRRHXNvLVpxHNb(com.google.android.material.search.SearchBar searchBar, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IjWRRHXNvLVpxHNb(com.google.android.material.search.SearchBar searchBar, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JHMxnqXoOmslFMwD(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void JHMxnqXoOmslFMwD(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JHMxnqXoOmslFMwD(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JHMxnqXoOmslFMwD(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JHdPfuWkAuNvPnmT(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void JHdPfuWkAuNvPnmT(android.graphics.drawable.Drawable drawable, int i, float f, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JHdPfuWkAuNvPnmT(android.graphics.drawable.Drawable drawable, int i, float f, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JHdPfuWkAuNvPnmT(android.graphics.drawable.Drawable drawable, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JHxUiUlcSsCcOqWD(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JHxUiUlcSsCcOqWD(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JHxUiUlcSsCcOqWD(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool JHxUiUlcSsCcOqWD(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        return searchBar.expand(view, appBarLayout, z);
    }

    public static int KToXxSmnTHMBlwYI(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getMeasuredWidth();
    }

    public static void KToXxSmnTHMBlwYI(com.google.android.material.search.SearchBar searchBar, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KToXxSmnTHMBlwYI(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KToXxSmnTHMBlwYI(com.google.android.material.search.SearchBar searchBar, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KbJHqyXwrLtpCcUm(com.google.android.material.search.SearchBar searchBar, bool z) {
        searchBar.setFocusable(z);
    }

    public static void KbJHqyXwrLtpCcUm(com.google.android.material.search.SearchBar searchBar, bool z, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KbJHqyXwrLtpCcUm(com.google.android.material.search.SearchBar searchBar, bool z, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KbJHqyXwrLtpCcUm(com.google.android.material.search.SearchBar searchBar, bool z, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtNUkfVNToTPQgzv(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence) {
        searchBar.setText(charSequence);
    }

    public static void KtNUkfVNToTPQgzv(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KtNUkfVNToTPQgzv(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KtNUkfVNToTPQgzv(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence KujXQyHsTfMeRvVA(android.widget.Textobject textobject) {
        return textobject.getHint();
    }

    public static void KujXQyHsTfMeRvVA(android.widget.Textobject textobject, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KujXQyHsTfMeRvVA(android.widget.Textobject textobject, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KujXQyHsTfMeRvVA(android.widget.Textobject textobject, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LCFjRXIoIzgvQvUT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void LCFjRXIoIzgvQvUT(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LCFjRXIoIzgvQvUT(android.content.res.TypedArray typedArray, int i, int i2, int i3, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LCFjRXIoIzgvQvUT(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LmQkdgANTceFlViv(android.widget.ImageButton imageButton, bool z) {
        imageButton.setClickable(z);
    }

    public static void LmQkdgANTceFlViv(android.widget.ImageButton imageButton, bool z, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LmQkdgANTceFlViv(android.widget.ImageButton imageButton, bool z, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LmQkdgANTceFlViv(android.widget.ImageButton imageButton, bool z, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MKMAMqoNOdTVQMnE(com.google.android.material.search.SearchBar searchBar) {
        searchBar.setOrClearDefaultScrollFlags();
    }

    public static void MKMAMqoNOdTVQMnE(com.google.android.material.search.SearchBar searchBar, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MKMAMqoNOdTVQMnE(com.google.android.material.search.SearchBar searchBar, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MKMAMqoNOdTVQMnE(com.google.android.material.search.SearchBar searchBar, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NMvHpEFumCVvYPls(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NMvHpEFumCVvYPls(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NMvHpEFumCVvYPls(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NMvHpEFumCVvYPls(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return searchBar.collapse(view, appBarLayout);
    }

    public static android.view.object NPtQWxxuHGTkixmp(com.google.android.material.search.SearchBar searchBar, int i) {
        return searchBar.findobjectById(i);
    }

    public static void NPtQWxxuHGTkixmp(com.google.android.material.search.SearchBar searchBar, int i, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NPtQWxxuHGTkixmp(com.google.android.material.search.SearchBar searchBar, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NPtQWxxuHGTkixmp(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NxWcFpHSJFbzvgvd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void NxWcFpHSJFbzvgvd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NxWcFpHSJFbzvgvd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NxWcFpHSJFbzvgvd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OIpCPGktMlZHxYEO(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getLayoutDirection();
    }

    public static void OIpCPGktMlZHxYEO(com.google.android.material.search.SearchBar searchBar, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OIpCPGktMlZHxYEO(com.google.android.material.search.SearchBar searchBar, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OIpCPGktMlZHxYEO(com.google.android.material.search.SearchBar searchBar, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence OSIqWOcnUlenBYGE(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getHint();
    }

    public static void OSIqWOcnUlenBYGE(com.google.android.material.search.SearchBar searchBar, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OSIqWOcnUlenBYGE(com.google.android.material.search.SearchBar searchBar, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OSIqWOcnUlenBYGE(com.google.android.material.search.SearchBar searchBar, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList OUnqMgGJkDtQeaFM(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void OUnqMgGJkDtQeaFM(int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OUnqMgGJkDtQeaFM(int i, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OUnqMgGJkDtQeaFM(int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OaaNtZxpbIFfsmrF(android.view.object view) {
        return view.getLeft();
    }

    public static void OaaNtZxpbIFfsmrF(android.view.object view, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OaaNtZxpbIFfsmrF(android.view.object view, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OaaNtZxpbIFfsmrF(android.view.object view, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static float OfpZyvCBpRXvylyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopLeftCornerResolvedSize();
    }

    public static void OfpZyvCBpRXvylyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OfpZyvCBpRXvylyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OfpZyvCBpRXvylyC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PCQmsTqUANjDoQFV(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PCQmsTqUANjDoQFV(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PCQmsTqUANjDoQFV(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool PCQmsTqUANjDoQFV(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return searchBar.expand(view, appBarLayout);
    }

    public static float PSCFpxWCAgEgKWdM(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void PSCFpxWCAgEgKWdM(android.view.object view, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSCFpxWCAgEgKWdM(android.view.object view, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PSCFpxWCAgEgKWdM(android.view.object view, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PUMPBAEzsoaEjpwU(android.widget.Textobject textobject, int i) {
        textobject.setHint(i);
    }

    public static void PUMPBAEzsoaEjpwU(android.widget.Textobject textobject, int i, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PUMPBAEzsoaEjpwU(android.widget.Textobject textobject, int i, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PUMPBAEzsoaEjpwU(android.widget.Textobject textobject, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZqHGkeShpyPRCzm(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setHint(charSequence);
    }

    public static void PZqHGkeShpyPRCzm(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZqHGkeShpyPRCzm(android.widget.Textobject textobject, java.lang.CharSequence charSequence, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZqHGkeShpyPRCzm(android.widget.Textobject textobject, java.lang.CharSequence charSequence, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QQZRAinpdvZpjNrf(android.view.object view, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QQZRAinpdvZpjNrf(android.view.object view, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QQZRAinpdvZpjNrf(android.view.object view, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QQZRAinpdvZpjNrf(android.view.object view) {
        return view.isClickable();
    }

    public static void QevrbjhBXCbSTvVS(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, int i2, int i3, int i4) {
        searchBar.layoutChild(view, i, i2, i3, i4);
    }

    public static void QevrbjhBXCbSTvVS(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, int i2, int i3, int i4, byte b, int i5, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QevrbjhBXCbSTvVS(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, int i2, int i3, int i4, int i5, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QevrbjhBXCbSTvVS(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, int i2, int i3, int i4, int i5, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray RLvvcjOJJryARQtm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void RLvvcjOJJryARQtm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RLvvcjOJJryARQtm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RLvvcjOJJryARQtm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SKDXOOCZGkGNWLrg(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence) {
        searchBar.setHint(charSequence);
    }

    public static void SKDXOOCZGkGNWLrg(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SKDXOOCZGkGNWLrg(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKDXOOCZGkGNWLrg(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SPnlJxrrSsWcXlZR(com.google.android.material.search.SearchBar searchBar, int i, int i2) {
        return searchBar.defaultIfZero(i, i2);
    }

    public static void SPnlJxrrSsWcXlZR(com.google.android.material.search.SearchBar searchBar, int i, int i2, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SPnlJxrrSsWcXlZR(com.google.android.material.search.SearchBar searchBar, int i, int i2, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SPnlJxrrSsWcXlZR(com.google.android.material.search.SearchBar searchBar, int i, int i2, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SSMqncUWOxXEwGPO(android.view.object view) {
        return view.getLeft();
    }

    public static void SSMqncUWOxXEwGPO(android.view.object view, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSMqncUWOxXEwGPO(android.view.object view, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSMqncUWOxXEwGPO(android.view.object view, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence SYTRZXGWXqHMypMV(android.widget.Textobject textobject) {
        return textobject.getText();
    }

    public static void SYTRZXGWXqHMypMV(android.widget.Textobject textobject, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SYTRZXGWXqHMypMV(android.widget.Textobject textobject, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SYTRZXGWXqHMypMV(android.widget.Textobject textobject, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SfCdMrIUCxGOULql(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void SfCdMrIUCxGOULql(android.content.object context, java.lang.string str, byte b, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SfCdMrIUCxGOULql(android.content.object context, java.lang.string str, byte b, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SfCdMrIUCxGOULql(android.content.object context, java.lang.string str, short s, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SjscqeInGeVxhBPZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SjscqeInGeVxhBPZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SjscqeInGeVxhBPZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SjscqeInGeVxhBPZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return searchBarAnimationHelper.removeExpandAnimationListener(animatorListenerAdapter);
    }

    public static void SpmScXAgwDYfcvYt(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void SpmScXAgwDYfcvYt(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, java.lang.string str, int i5, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SpmScXAgwDYfcvYt(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, java.lang.string str, short s, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SpmScXAgwDYfcvYt(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, short s, java.lang.string str, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SuVNXxtbKIllwBdn(com.google.android.material.search.SearchBar searchBar) {
        searchBar.setHandwritingBoundsInsets();
    }

    public static void SuVNXxtbKIllwBdn(com.google.android.material.search.SearchBar searchBar, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SuVNXxtbKIllwBdn(com.google.android.material.search.SearchBar searchBar, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SuVNXxtbKIllwBdn(com.google.android.material.search.SearchBar searchBar, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SxnEVOnxYVPGzmrN(android.content.res.TypedArray typedArray, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SxnEVOnxYVPGzmrN(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SxnEVOnxYVPGzmrN(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SxnEVOnxYVPGzmrN(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void TXYXHKbCWsoyUlnH(android.content.res.TypedArray typedArray, int i, bool z, int i2, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TXYXHKbCWsoyUlnH(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TXYXHKbCWsoyUlnH(android.content.res.TypedArray typedArray, int i, bool z, short s, java.lang.string str, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool TXYXHKbCWsoyUlnH(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.content.object TrqOmddtrbygTYVj(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getobject();
    }

    public static void TrqOmddtrbygTYVj(com.google.android.material.search.SearchBar searchBar, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TrqOmddtrbygTYVj(com.google.android.material.search.SearchBar searchBar, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TrqOmddtrbygTYVj(com.google.android.material.search.SearchBar searchBar, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UFxauaXVzCORqjBO(java.lang.object obj) {
        return obj.tostring();
    }

    public static void UFxauaXVzCORqjBO(java.lang.object obj, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UFxauaXVzCORqjBO(java.lang.object obj, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UFxauaXVzCORqjBO(java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UYfWLPpfqLDnwXPb(androidx.appcompat.widget.Toolbar toolbar, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void UYfWLPpfqLDnwXPb(androidx.appcompat.widget.Toolbar toolbar, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UYfWLPpfqLDnwXPb(androidx.appcompat.widget.Toolbar toolbar, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UYfWLPpfqLDnwXPb(androidx.appcompat.widget.Toolbar toolbar, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources UjuqdIReJQROoAJr(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getResources();
    }

    public static void UjuqdIReJQROoAJr(com.google.android.material.search.SearchBar searchBar, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UjuqdIReJQROoAJr(com.google.android.material.search.SearchBar searchBar, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UjuqdIReJQROoAJr(com.google.android.material.search.SearchBar searchBar, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams UyVjOkARhpKcGobO(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getLayoutParams();
    }

    public static void UyVjOkARhpKcGobO(com.google.android.material.search.SearchBar searchBar, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UyVjOkARhpKcGobO(com.google.android.material.search.SearchBar searchBar, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UyVjOkARhpKcGobO(com.google.android.material.search.SearchBar searchBar, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VQoiTGadWUCUQYVg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i) {
        materialShapeDrawable.setStroke(f, i);
    }

    public static void VQoiTGadWUCUQYVg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, byte b, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void VQoiTGadWUCUQYVg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, char c, byte b, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VQoiTGadWUCUQYVg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, float f2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VkMFxXDjZnZgCtBH(android.view.object view) {
        return view.getVisibility();
    }

    public static void VkMFxXDjZnZgCtBH(android.view.object view, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VkMFxXDjZnZgCtBH(android.view.object view, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VkMFxXDjZnZgCtBH(android.view.object view, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VsPhNELpquoCttXa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static void VsPhNELpquoCttXa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VsPhNELpquoCttXa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VsPhNELpquoCttXa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VspLPoMKsLJBjKgH(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VspLPoMKsLJBjKgH(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VspLPoMKsLJBjKgH(android.content.res.TypedArray typedArray, int i, bool z, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VspLPoMKsLJBjKgH(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int WIIBSxjGttgDoqqB(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getWidth();
    }

    public static void WIIBSxjGttgDoqqB(com.google.android.material.search.SearchBar searchBar, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WIIBSxjGttgDoqqB(com.google.android.material.search.SearchBar searchBar, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WIIBSxjGttgDoqqB(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WRpgWqsQkNAXNYSr(int i, int i2) {
        return com.google.android.material.color.MaterialColors.layer(i, i2);
    }

    public static void WRpgWqsQkNAXNYSr(int i, int i2, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WRpgWqsQkNAXNYSr(int i, int i2, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WRpgWqsQkNAXNYSr(int i, int i2, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float WYrFqaFyazQdXHiT(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getStrokeWidth();
    }

    public static void WYrFqaFyazQdXHiT(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WYrFqaFyazQdXHiT(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYrFqaFyazQdXHiT(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEDwAwxRkIKrRokB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        searchBarAnimationHelper.startCollapseAnimation(searchBar, view, appBarLayout, z);
    }

    public static void XEDwAwxRkIKrRokB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XEDwAwxRkIKrRokB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XEDwAwxRkIKrRokB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XWukLVcTyhnEzOgg(com.google.android.material.search.SearchBar searchBar, bool z) {
        searchBar.setFocusableInTouchMode(z);
    }

    public static void XWukLVcTyhnEzOgg(com.google.android.material.search.SearchBar searchBar, bool z, short s, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XWukLVcTyhnEzOgg(com.google.android.material.search.SearchBar searchBar, bool z, short s, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWukLVcTyhnEzOgg(com.google.android.material.search.SearchBar searchBar, bool z, bool z2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float YAkXczqskmaWFbSY(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void YAkXczqskmaWFbSY(android.content.res.TypedArray typedArray, int i, float f, float f2, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YAkXczqskmaWFbSY(android.content.res.TypedArray typedArray, int i, float f, float f2, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YAkXczqskmaWFbSY(android.content.res.TypedArray typedArray, int i, float f, float f2, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YgKuyUNMjRAzHprx(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence) {
        searchBar.setText(charSequence);
    }

    public static void YgKuyUNMjRAzHprx(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YgKuyUNMjRAzHprx(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YgKuyUNMjRAzHprx(com.google.android.material.search.SearchBar searchBar, java.lang.CharSequence charSequence, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZmnxjreQhnPDdiJP(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZmnxjreQhnPDdiJP(com.google.android.material.search.SearchBar searchBar, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZmnxjreQhnPDdiJP(com.google.android.material.search.SearchBar searchBar, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZmnxjreQhnPDdiJP(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.isCollapsing();
    }

    public static void AAvtqiPAMUMDjFET(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void AAvtqiPAMUMDjFET(android.view.object view, android.graphics.drawable.Drawable drawable, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAvtqiPAMUMDjFET(android.view.object view, android.graphics.drawable.Drawable drawable, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAvtqiPAMUMDjFET(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AXlSNmMduvIgDzJZ(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void AXlSNmMduvIgDzJZ(android.view.object view, float f, byte b, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void AXlSNmMduvIgDzJZ(android.view.object view, float f, char c, float f2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXlSNmMduvIgDzJZ(android.view.object view, float f, short s, float f2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static android.view.accessibility.AccessibilityManager access$000(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.accessibilityManager;
    }

    static void access$000(com.google.android.material.search.SearchBar searchBar, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.search.SearchBar searchBar, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.search.SearchBar searchBar, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener access$100(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.touchExplorationStateChangeListener;
    }

    static void access$100(com.google.android.material.search.SearchBar searchBar, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BDoYegNFRYPfFfFT(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static void BDoYegNFRYPfFfFT(android.view.object view, int i, int i2, int i3, int i4, byte b, int i5, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BDoYegNFRYPfFfFT(android.view.object view, int i, int i2, int i3, int i4, char c, byte b, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BDoYegNFRYPfFfFT(android.view.object view, int i, int i2, int i3, int i4, int i5, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BJQiCxuZOTOpKOFC(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void BJQiCxuZOTOpKOFC(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, char c, bool z, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BJQiCxuZOTOpKOFC(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, java.lang.string str3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJQiCxuZOTOpKOFC(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, char c, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void BKWZhTPlnvgwRrKk(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.stopDispatchingItemsChanged();
    }

    public static void BKWZhTPlnvgwRrKk(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKWZhTPlnvgwRrKk(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKWZhTPlnvgwRrKk(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BSzteMGEYilFHwAd(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getWidth();
    }

    public static void BSzteMGEYilFHwAd(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BSzteMGEYilFHwAd(com.google.android.material.search.SearchBar searchBar, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BSzteMGEYilFHwAd(com.google.android.material.search.SearchBar searchBar, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BTCnKnJQdUxGWSYo(com.google.android.material.search.SearchBar searchBar, int i, int i2) {
        return searchBar.defaultIfZero(i, i2);
    }

    public static void BTCnKnJQdUxGWSYo(com.google.android.material.search.SearchBar searchBar, int i, int i2, char c, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BTCnKnJQdUxGWSYo(com.google.android.material.search.SearchBar searchBar, int i, int i2, char c, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void BTCnKnJQdUxGWSYo(com.google.android.material.search.SearchBar searchBar, int i, int i2, int i3, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BgsNswbfPJvOdWVb(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void BgsNswbfPJvOdWVb(android.content.res.TypedArray typedArray, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BgsNswbfPJvOdWVb(android.content.res.TypedArray typedArray, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BgsNswbfPJvOdWVb(android.content.res.TypedArray typedArray, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxrPHvhduWzZlhyS(com.google.android.material.search.SearchBar searchBar) {
        searchBar.setOrClearDefaultScrollFlags();
    }

    public static void BxrPHvhduWzZlhyS(com.google.android.material.search.SearchBar searchBar, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BxrPHvhduWzZlhyS(com.google.android.material.search.SearchBar searchBar, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BxrPHvhduWzZlhyS(com.google.android.material.search.SearchBar searchBar, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable CJmuudkhuuKEcVdC(com.google.android.material.search.SearchBar$SavedState searchBar$SavedState) {
        return searchBar$SavedState.getSuperState();
    }

    public static void CJmuudkhuuKEcVdC(com.google.android.material.search.SearchBar$SavedState searchBar$SavedState, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CJmuudkhuuKEcVdC(com.google.android.material.search.SearchBar$SavedState searchBar$SavedState, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CJmuudkhuuKEcVdC(com.google.android.material.search.SearchBar$SavedState searchBar$SavedState, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLjEgmnerzKyOiXc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStrokeColor(colorStateList);
    }

    public static void CLjEgmnerzKyOiXc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLjEgmnerzKyOiXc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CLjEgmnerzKyOiXc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CNpklDMoBqEcJaQf(android.view.accessibility.AccessibilityManager accessibilityManager, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CNpklDMoBqEcJaQf(android.view.accessibility.AccessibilityManager accessibilityManager, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CNpklDMoBqEcJaQf(android.view.accessibility.AccessibilityManager accessibilityManager, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CNpklDMoBqEcJaQf(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    public static int CbqOeNlcfmHXbSIG(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getMeasuredWidth();
    }

    public static void CbqOeNlcfmHXbSIG(com.google.android.material.search.SearchBar searchBar, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CbqOeNlcfmHXbSIG(com.google.android.material.search.SearchBar searchBar, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CbqOeNlcfmHXbSIG(com.google.android.material.search.SearchBar searchBar, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams dEIGsQGMNSjNhDHA(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getLayoutParams();
    }

    public static void DEIGsQGMNSjNhDHA(com.google.android.material.search.SearchBar searchBar, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DEIGsQGMNSjNhDHA(com.google.android.material.search.SearchBar searchBar, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DEIGsQGMNSjNhDHA(com.google.android.material.search.SearchBar searchBar, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private int DefaultIfZero(int i, int i2) {
        return i != 0 ? i : i2;
    }

    private void DefaultIfZero(int i, int i2, float f, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void DefaultIfZero(int i, int i2, bool z, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    private void DefaultIfZero(int i, int i2, bool z, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DkpoQNkljmhWBOyt(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        super.setNavigationIcon(drawable);
    }

    public static void DkpoQNkljmhWBOyt(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DkpoQNkljmhWBOyt(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DkpoQNkljmhWBOyt(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DwkbQBFmKHcluYmM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void DwkbQBFmKHcluYmM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DwkbQBFmKHcluYmM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DwkbQBFmKHcluYmM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EYxQtRggAuPfQGyI(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void EYxQtRggAuPfQGyI(android.content.res.Resources resources, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EYxQtRggAuPfQGyI(android.content.res.Resources resources, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EYxQtRggAuPfQGyI(android.content.res.Resources resources, int i, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EkHZZZayDItwVheq(java.lang.int num) {
        return num.intValue();
    }

    public static void EkHZZZayDItwVheq(java.lang.int num, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EkHZZZayDItwVheq(java.lang.int num, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EkHZZZayDItwVheq(java.lang.int num, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable EzYxIWmkAZrxWEEK(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getNavigationIcon();
    }

    public static void EzYxIWmkAZrxWEEK(com.google.android.material.search.SearchBar searchBar, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EzYxIWmkAZrxWEEK(com.google.android.material.search.SearchBar searchBar, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EzYxIWmkAZrxWEEK(com.google.android.material.search.SearchBar searchBar, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FSZgUFddxvcnpZgx(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void FSZgUFddxvcnpZgx(android.view.object view, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FSZgUFddxvcnpZgx(android.view.object view, int i, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FSZgUFddxvcnpZgx(android.view.object view, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FYGXOOWMzhDndtck(androidx.appcompat.widget.Toolbar toolbar) {
        super.onAttachedToWindow();
    }

    public static void FYGXOOWMzhDndtck(androidx.appcompat.widget.Toolbar toolbar, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FYGXOOWMzhDndtck(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FYGXOOWMzhDndtck(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GVREYQmBvVVvTbao(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getDefaultMarginVerticalResource();
    }

    public static void GVREYQmBvVVvTbao(com.google.android.material.search.SearchBar searchBar, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GVREYQmBvVVvTbao(com.google.android.material.search.SearchBar searchBar, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GVREYQmBvVVvTbao(com.google.android.material.search.SearchBar searchBar, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GWxSTFkmhuZwteyz(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void GWxSTFkmhuZwteyz(android.content.object context, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GWxSTFkmhuZwteyz(android.content.object context, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GWxSTFkmhuZwteyz(android.content.object context, int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    private android.content.res.ColorStateList GetCompatBackgroundColorStateList(int i, int i2) {
        if ((30 + 8) % 8 > 0) {
        }
        int[][] iArr = {new int[]{16842919}, new int[]{16842908}, new int[0]};
        int iWRpgWqsQkNAXNYSr = WRpgWqsQkNAXNYSr(i, i2);
        return new android.content.res.ColorStateList(iArr, new int[]{iWRpgWqsQkNAXNYSr, iWRpgWqsQkNAXNYSr, i});
    }

    private void GetCompatBackgroundColorStateList(int i, int i2, char c, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetCompatBackgroundColorStateList(int i, int i2, int i3, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetCompatBackgroundColorStateList(int i, int i2, java.lang.string str, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GredaCbhOZnjwgJK(androidx.appcompat.widget.Toolbar toolbar, float f) {
        super.setElevation(f);
    }

    public static void GredaCbhOZnjwgJK(androidx.appcompat.widget.Toolbar toolbar, float f, byte b, float f2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GredaCbhOZnjwgJK(androidx.appcompat.widget.Toolbar toolbar, float f, char c, byte b, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GredaCbhOZnjwgJK(androidx.appcompat.widget.Toolbar toolbar, float f, float f2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GtteIBpakcEuYChH(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void GtteIBpakcEuYChH(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtteIBpakcEuYChH(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GtteIBpakcEuYChH(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HUVmrKuWicvsDdFx(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginStart(viewGroup$MarginLayoutParams, i);
    }

    public static void HUVmrKuWicvsDdFx(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HUVmrKuWicvsDdFx(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HUVmrKuWicvsDdFx(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HZuzmdBKWTnfbZuH(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i) {
        appBarLayout$LayoutParams.setScrollFlags(i);
    }

    public static void HZuzmdBKWTnfbZuH(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HZuzmdBKWTnfbZuH(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HZuzmdBKWTnfbZuH(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HgTWsSLRlWkUUFkB(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, float f, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgTWsSLRlWkUUFkB(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HgTWsSLRlWkUUFkB(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HgTWsSLRlWkUUFkB(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        return searchBar.collapse(view, appBarLayout, z);
    }

    public static int HoTJfoEeksDKaIUU(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getDefaultNavigationIconResource();
    }

    public static void HoTJfoEeksDKaIUU(com.google.android.material.search.SearchBar searchBar, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HoTJfoEeksDKaIUU(com.google.android.material.search.SearchBar searchBar, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HoTJfoEeksDKaIUU(com.google.android.material.search.SearchBar searchBar, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HrRzrjEdUjSvDgTy(com.google.android.material.search.SearchBar searchBar, bool z) {
        searchBar.setNavigationIconDecorative(z);
    }

    public static void HrRzrjEdUjSvDgTy(com.google.android.material.search.SearchBar searchBar, bool z, byte b, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HrRzrjEdUjSvDgTy(com.google.android.material.search.SearchBar searchBar, bool z, char c, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HrRzrjEdUjSvDgTy(com.google.android.material.search.SearchBar searchBar, bool z, short s, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable HsleOzKglcctvsDX(android.widget.ImageButton imageButton) {
        return imageButton.getBackground();
    }

    public static void HsleOzKglcctvsDX(android.widget.ImageButton imageButton, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HsleOzKglcctvsDX(android.widget.ImageButton imageButton, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HsleOzKglcctvsDX(android.widget.ImageButton imageButton, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float IAOkVTNfLQBluVfE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getElevation();
    }

    public static void IAOkVTNfLQBluVfE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IAOkVTNfLQBluVfE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IAOkVTNfLQBluVfE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel ICnRhtRlXRymkmFJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void ICnRhtRlXRymkmFJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ICnRhtRlXRymkmFJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ICnRhtRlXRymkmFJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IDehWaTnatJfmVRq(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IDehWaTnatJfmVRq(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IDehWaTnatJfmVRq(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool IDehWaTnatJfmVRq(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int IGCnieuDrMtKEwRU(com.google.android.material.search.SearchBar searchBar, int i, int i2) {
        return searchBar.defaultIfZero(i, i2);
    }

    public static void IGCnieuDrMtKEwRU(com.google.android.material.search.SearchBar searchBar, int i, int i2, float f, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IGCnieuDrMtKEwRU(com.google.android.material.search.SearchBar searchBar, int i, int i2, float f, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IGCnieuDrMtKEwRU(com.google.android.material.search.SearchBar searchBar, int i, int i2, int i3, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ITGejKmqtGbObhGk(com.google.android.material.search.SearchBar searchBar, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ITGejKmqtGbObhGk(com.google.android.material.search.SearchBar searchBar, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ITGejKmqtGbObhGk(com.google.android.material.search.SearchBar searchBar, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ITGejKmqtGbObhGk(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.isExpanding();
    }

    public static void IVZbvBPcaEKkwAFu(com.google.android.material.search.SearchBar searchBar, android.view.object view) {
        searchBar.removeobject(view);
    }

    public static void IVZbvBPcaEKkwAFu(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IVZbvBPcaEKkwAFu(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IVZbvBPcaEKkwAFu(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object IdPUtNGLJaGhJFOT(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getobject();
    }

    public static void IdPUtNGLJaGhJFOT(com.google.android.material.search.SearchBar searchBar, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IdPUtNGLJaGhJFOT(com.google.android.material.search.SearchBar searchBar, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdPUtNGLJaGhJFOT(com.google.android.material.search.SearchBar searchBar, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IdeHrRJPPvJkZJuH(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getMeasuredHeight();
    }

    public static void IdeHrRJPPvJkZJuH(com.google.android.material.search.SearchBar searchBar, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdeHrRJPPvJkZJuH(com.google.android.material.search.SearchBar searchBar, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdeHrRJPPvJkZJuH(com.google.android.material.search.SearchBar searchBar, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IkacHuwOkoSxKuPj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setHintText(charSequence);
    }

    public static void IkacHuwOkoSxKuPj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IkacHuwOkoSxKuPj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IkacHuwOkoSxKuPj(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void InitBackground(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2) {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(shapeAppearanceModel);
        this.backgroundShape = materialShapeDrawable;
        dwkbQBFmKHcluYmM(materialShapeDrawable, klSUhuObXLdYOhta(this));
        NxWcFpHSJFbzvgvd(this.backgroundShape, f);
        if (f2 >= 0.0f) {
            VQoiTGadWUCUQYVg(this.backgroundShape, f2, i2);
        }
        int iFSZgUFddxvcnpZgx = fSZgUFddxvcnpZgx(this, com.google.android.material.R$attr.colorControlHighlight);
        CJAIgUggfPkOxtXu(this.backgroundShape, ypCWfMlmDqqeDsiQ(i));
        android.content.res.ColorStateList colorStateListMqkpwobTMKAOSQJa = mqkpwobTMKAOSQJa(iFSZgUFddxvcnpZgx);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = this.backgroundShape;
        aAvtqiPAMUMDjFET(this, new android.graphics.drawable.RippleDrawable(colorStateListMqkpwobTMKAOSQJa, materialShapeDrawable2, materialShapeDrawable2));
    }

    private void InitBackground(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2, float f3, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    private void InitBackground(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2, float f3, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InitBackground(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2, int i3, java.lang.string str, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InitNavigationIcon() {
        DYQQNRhFgIfLmNuA(this, sgKHbMZNrcELTECy(this) is not null ? IjWRRHXNvLVpxHNb(this) : this.defaultNavigationIcon);
        CMBAIyZlEAaMMEYJ(this, true);
    }

    private void InitNavigationIcon(char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InitNavigationIcon(short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void InitNavigationIcon(bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void InitTextobject(int i, java.lang.string str, java.lang.string str2) {
        if (i != -1) {
            AGRHeeaouFBdMCHK(this.textobject, i);
        }
        YgKuyUNMjRAzHprx(this, str);
        SKDXOOCZGkGNWLrg(this, str2);
        if (ezYxIWmkAZrxWEEK(this) is not null) {
            return;
        }
        hUVmrKuWicvsDdFx((android.view.objectGroup$MarginLayoutParams) HzBazOIuwzxHJapi(this.textobject), eYxQtRggAuPfQGyI(lNJhrXdhdHZWnSnj(this), com.google.android.material.R$dimen.m3_searchbar_text_margin_start_no_navigation_icon));
    }

    private void InitTextobject(int i, java.lang.string str, java.lang.string str2, float f, java.lang.string str3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void InitTextobject(int i, java.lang.string str, java.lang.string str2, float f, short s, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InitTextobject(int i, java.lang.string str, java.lang.string str2, short s, float f, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static int JEoJDXoHavJdMshG(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void JEoJDXoHavJdMshG(android.view.object view, int i, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JEoJDXoHavJdMshG(android.view.object view, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JEoJDXoHavJdMshG(android.view.object view, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHuWuOkTjMWNDKcq(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void JHuWuOkTjMWNDKcq(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JHuWuOkTjMWNDKcq(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JHuWuOkTjMWNDKcq(androidx.appcompat.widget.Toolbar toolbar, android.os.Parcelable parcelable, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JIUOnkJRbLDbLSqH(com.google.android.material.search.SearchBar searchBar, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JIUOnkJRbLDbLSqH(com.google.android.material.search.SearchBar searchBar, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JIUOnkJRbLDbLSqH(com.google.android.material.search.SearchBar searchBar, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JIUOnkJRbLDbLSqH(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.isCollapsing();
    }

    public static int JKaNudDEUQcTqzuo(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getStrokeColor();
    }

    public static void JKaNudDEUQcTqzuo(com.google.android.material.search.SearchBar searchBar, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKaNudDEUQcTqzuo(com.google.android.material.search.SearchBar searchBar, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKaNudDEUQcTqzuo(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JMUahKaNWbCltfeA(com.google.android.material.search.SearchBar searchBar, java.lang.Action runnable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMUahKaNWbCltfeA(com.google.android.material.search.SearchBar searchBar, java.lang.Action runnable, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JMUahKaNWbCltfeA(com.google.android.material.search.SearchBar searchBar, java.lang.Action runnable, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JMUahKaNWbCltfeA(com.google.android.material.search.SearchBar searchBar, java.lang.Action runnable) {
        return searchBar.post(runnable);
    }

    public static android.graphics.drawable.Drawable JmukQyaVxHExykgH(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable) {
        return searchBar.maybeTintNavigationIcon(drawable);
    }

    public static void JmukQyaVxHExykgH(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JmukQyaVxHExykgH(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JmukQyaVxHExykgH(com.google.android.material.search.SearchBar searchBar, android.graphics.drawable.Drawable drawable, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int KfoGbrPTxwKRGsDB(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void KfoGbrPTxwKRGsDB(android.content.res.ColorStateList colorStateList, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfoGbrPTxwKRGsDB(android.content.res.ColorStateList colorStateList, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfoGbrPTxwKRGsDB(android.content.res.ColorStateList colorStateList, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KlSUhuObXLdYOhta(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getobject();
    }

    public static void KlSUhuObXLdYOhta(com.google.android.material.search.SearchBar searchBar, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KlSUhuObXLdYOhta(com.google.android.material.search.SearchBar searchBar, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KlSUhuObXLdYOhta(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtvuKoHTqBDKeoEk(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void KtvuKoHTqBDKeoEk(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KtvuKoHTqBDKeoEk(android.widget.Textobject textobject, java.lang.CharSequence charSequence, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtvuKoHTqBDKeoEk(android.widget.Textobject textobject, java.lang.CharSequence charSequence, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LLJwXXupleGvONuD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z) {
        searchBarAnimationHelper.setOnLoadAnimationFadeInEnabled(z);
    }

    public static void LLJwXXupleGvONuD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, char c, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LLJwXXupleGvONuD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, short s, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LLJwXXupleGvONuD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, short s, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources LNJhrXdhdHZWnSnj(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getResources();
    }

    public static void LNJhrXdhdHZWnSnj(com.google.android.material.search.SearchBar searchBar, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LNJhrXdhdHZWnSnj(com.google.android.material.search.SearchBar searchBar, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LNJhrXdhdHZWnSnj(com.google.android.material.search.SearchBar searchBar, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater LXsiDuqIDkclcUvn(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void LXsiDuqIDkclcUvn(android.content.object context, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LXsiDuqIDkclcUvn(android.content.object context, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LXsiDuqIDkclcUvn(android.content.object context, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LahPjITShwZhhPkl(android.view.object view) {
        return view.getVisibility();
    }

    public static void LahPjITShwZhhPkl(android.view.object view, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LahPjITShwZhhPkl(android.view.object view, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LahPjITShwZhhPkl(android.view.object view, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void LayoutCenterobject() {
        if ((28 + 14) % 14 > 0) {
        }
        android.view.object view = this.centerobject;
        if (view is not null) {
            int iWxnkNDFUlGZVROLH = wxnkNDFUlGZVROLH(view);
            int iCbqOeNlcfmHXbSIG = (cbqOeNlcfmHXbSIG(this) / 2) - (iWxnkNDFUlGZVROLH / 2);
            int i = iCbqOeNlcfmHXbSIG + iWxnkNDFUlGZVROLH;
            int iQmORBoxLIOsEjilm = qmORBoxLIOsEjilm(this.centerobject);
            int iIdeHrRJPPvJkZJuH = (ideHrRJPPvJkZJuH(this) / 2) - (iQmORBoxLIOsEjilm / 2);
            QevrbjhBXCbSTvVS(this, this.centerobject, iCbqOeNlcfmHXbSIG, iIdeHrRJPPvJkZJuH, i, iIdeHrRJPPvJkZJuH + iQmORBoxLIOsEjilm);
        }
    }

    private void LayoutCenterobject(float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void LayoutCenterobject(java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void LayoutCenterobject(java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void LayoutChild(android.view.object view, int i, int i2, int i3, int i4) {
        if ((13 + 3) % 3 > 0) {
        }
        if (DIEDKCxkEehuvbyO(this) != 1) {
            nLAiPFMyLCyBVuQI(view, i, i2, i3, i4);
        } else {
            bDoYegNFRYPfFfFT(view, KToXxSmnTHMBlwYI(this) - i3, i2, FiptoBlfWMByEUdd(this) - i, i4);
        }
    }

    private void LayoutChild(android.view.object view, int i, int i2, int i3, int i4, int i5, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void LayoutChild(android.view.object view, int i, int i2, int i3, int i4, java.lang.string str, short s, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    private void LayoutChild(android.view.object view, int i, int i2, int i3, int i4, short s, java.lang.string str, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void LluxDcZSzdHYubCj(com.google.android.material.search.SearchBar searchBar) {
        searchBar.setDefaultMargins();
    }

    public static void LluxDcZSzdHYubCj(com.google.android.material.search.SearchBar searchBar, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LluxDcZSzdHYubCj(com.google.android.material.search.SearchBar searchBar, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LluxDcZSzdHYubCj(com.google.android.material.search.SearchBar searchBar, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence LwnLLCLEoZwfSKSf(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getHint();
    }

    public static void LwnLLCLEoZwfSKSf(com.google.android.material.search.SearchBar searchBar, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LwnLLCLEoZwfSKSf(com.google.android.material.search.SearchBar searchBar, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LwnLLCLEoZwfSKSf(com.google.android.material.search.SearchBar searchBar, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.ImageButton MQUAZnWcrENbMDEz(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getNavigationIconButton(toolbar);
    }

    public static void MQUAZnWcrENbMDEz(androidx.appcompat.widget.Toolbar toolbar, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MQUAZnWcrENbMDEz(androidx.appcompat.widget.Toolbar toolbar, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MQUAZnWcrENbMDEz(androidx.appcompat.widget.Toolbar toolbar, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int MUZizotKFUoRuLSa(android.view.object view) {
        return view.getRight();
    }

    public static void MUZizotKFUoRuLSa(android.view.object view, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MUZizotKFUoRuLSa(android.view.object view, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MUZizotKFUoRuLSa(android.view.object view, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable) {
        int iJEoJDXoHavJdMshG;
        if (this.tintNavigationIcon && drawable is not null) {
            java.lang.int num = this.navigationIconTint;
            if (num is null) {
                iJEoJDXoHavJdMshG = jEoJDXoHavJdMshG(this, drawable != this.defaultNavigationIcon ? com.google.android.material.R$attr.colorOnSurface : com.google.android.material.R$attr.colorOnSurfaceVariant);
            } else {
                iJEoJDXoHavJdMshG = ekHZZZayDItwVheq(num);
            }
            drawable = gtteIBpakcEuYChH(GNEsApaQfyecDhYG(drawable));
            JHdPfuWkAuNvPnmT(drawable, iJEoJDXoHavJdMshG);
        }
        return drawable;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MeQVciFgnPiWHoba(com.google.android.material.search.SearchBar searchBar, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2) {
        searchBar.initBackground(shapeAppearanceModel, i, f, f2, i2);
    }

    public static void MeQVciFgnPiWHoba(com.google.android.material.search.SearchBar searchBar, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2, int i3, float f3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MeQVciFgnPiWHoba(com.google.android.material.search.SearchBar searchBar, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2, int i3, java.lang.string str, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MeQVciFgnPiWHoba(com.google.android.material.search.SearchBar searchBar, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, float f2, int i2, short s, float f3, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    private void MeasureCenterobject(int i, int i2) {
        android.view.object view = this.centerobject;
        if (view is null) {
            return;
        }
        pupXnKoEYaYwURWZ(view, i, i2);
    }

    private void MeasureCenterobject(int i, int i2, char c, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void MeasureCenterobject(int i, int i2, float f, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void MeasureCenterobject(int i, int i2, java.lang.string str, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.ActionMenuobject MmHPTNvSiwbbTjtI(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getActionMenuobject(toolbar);
    }

    public static void MmHPTNvSiwbbTjtI(androidx.appcompat.widget.Toolbar toolbar, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmHPTNvSiwbbTjtI(androidx.appcompat.widget.Toolbar toolbar, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MmHPTNvSiwbbTjtI(androidx.appcompat.widget.Toolbar toolbar, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MpCgPaEQRhsENZli(android.view.object view, float f) {
        androidx.core.view.objectCompat.setElevation(view, f);
    }

    public static void MpCgPaEQRhsENZli(android.view.object view, float f, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MpCgPaEQRhsENZli(android.view.object view, float f, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MpCgPaEQRhsENZli(android.view.object view, float f, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList MqkpwobTMKAOSQJa(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void MqkpwobTMKAOSQJa(int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MqkpwobTMKAOSQJa(int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MqkpwobTMKAOSQJa(int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NGixPmFeuBjjJqRD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGixPmFeuBjjJqRD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGixPmFeuBjjJqRD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool NGixPmFeuBjjJqRD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback) {
        return searchBarAnimationHelper.removeOnLoadAnimationCallback(searchBar$OnLoadAnimationCallback);
    }

    public static void NLAiPFMyLCyBVuQI(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static void NLAiPFMyLCyBVuQI(android.view.object view, int i, int i2, int i3, int i4, byte b, bool z, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NLAiPFMyLCyBVuQI(android.view.object view, int i, int i2, int i3, int i4, byte b, bool z, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void NLAiPFMyLCyBVuQI(android.view.object view, int i, int i2, int i3, int i4, bool z, int i5, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NWxGaAoKVQfihtyf(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NWxGaAoKVQfihtyf(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NWxGaAoKVQfihtyf(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NWxGaAoKVQfihtyf(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void NiAQlYvcvdhRtaYd(com.google.android.material.search.SearchBar searchBar) {
        searchBar.layoutCenterobject();
    }

    public static void NiAQlYvcvdhRtaYd(com.google.android.material.search.SearchBar searchBar, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiAQlYvcvdhRtaYd(com.google.android.material.search.SearchBar searchBar, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiAQlYvcvdhRtaYd(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NtEunyymHtIYfWPg(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void NtEunyymHtIYfWPg(java.lang.Class cls, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NtEunyymHtIYfWPg(java.lang.Class cls, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NtEunyymHtIYfWPg(java.lang.Class cls, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OaEvLFnBckyTVejT(com.google.android.material.search.SearchBar searchBar, float f, float f2, float f3, float f4) {
        searchBar.setHandwritingBoundsOffsets(f, f2, f3, f4);
    }

    public static void OaEvLFnBckyTVejT(com.google.android.material.search.SearchBar searchBar, float f, float f2, float f3, float f4, byte b, float f5, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OaEvLFnBckyTVejT(com.google.android.material.search.SearchBar searchBar, float f, float f2, float f3, float f4, bool z, byte b, float f5, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OaEvLFnBckyTVejT(com.google.android.material.search.SearchBar searchBar, float f, float f2, float f3, float f4, bool z, float f5, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OazBDMGdvQgJzqJG(com.google.android.material.search.SearchBar searchBar, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        searchBar.addOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static void OazBDMGdvQgJzqJG(com.google.android.material.search.SearchBar searchBar, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OazBDMGdvQgJzqJG(com.google.android.material.search.SearchBar searchBar, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OazBDMGdvQgJzqJG(com.google.android.material.search.SearchBar searchBar, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OxnAoergLdGZGBqN(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar) {
        searchBarAnimationHelper.startOnLoadAnimation(searchBar);
    }

    public static void OxnAoergLdGZGBqN(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxnAoergLdGZGBqN(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OxnAoergLdGZGBqN(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PCqLatePbsVHTgEf(android.view.accessibility.AccessibilityManager accessibilityManager, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PCqLatePbsVHTgEf(android.view.accessibility.AccessibilityManager accessibilityManager, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PCqLatePbsVHTgEf(android.view.accessibility.AccessibilityManager accessibilityManager, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool PCqLatePbsVHTgEf(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isEnabled();
    }

    public static android.view.Menu PEXYIlWfVhLKiGCm(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getMenu();
    }

    public static void PEXYIlWfVhLKiGCm(com.google.android.material.search.SearchBar searchBar, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PEXYIlWfVhLKiGCm(com.google.android.material.search.SearchBar searchBar, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PEXYIlWfVhLKiGCm(com.google.android.material.search.SearchBar searchBar, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PUGFqcffxiGusZgg(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void PUGFqcffxiGusZgg(android.content.res.Resources resources, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PUGFqcffxiGusZgg(android.content.res.Resources resources, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PUGFqcffxiGusZgg(android.content.res.Resources resources, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PupXnKoEYaYwURWZ(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void PupXnKoEYaYwURWZ(android.view.object view, int i, int i2, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PupXnKoEYaYwURWZ(android.view.object view, int i, int i2, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PupXnKoEYaYwURWZ(android.view.object view, int i, int i2, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QEZyYKeceqXZpEgu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setStrokeWidth(f);
    }

    public static void QEZyYKeceqXZpEgu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, float f2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QEZyYKeceqXZpEgu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QEZyYKeceqXZpEgu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, int i, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QGkXvpzngRVUkmtx(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void QGkXvpzngRVUkmtx(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QGkXvpzngRVUkmtx(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QGkXvpzngRVUkmtx(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QfGunspKWoIaadvP(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        searchBarAnimationHelper.startExpandAnimation(searchBar, view, appBarLayout, z);
    }

    public static void QfGunspKWoIaadvP(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, int i, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QfGunspKWoIaadvP(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QfGunspKWoIaadvP(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QfaptCDjykDrPHAS(java.lang.CharSequence charSequence, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QfaptCDjykDrPHAS(java.lang.CharSequence charSequence, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QfaptCDjykDrPHAS(java.lang.CharSequence charSequence, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QfaptCDjykDrPHAS(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int QmORBoxLIOsEjilm(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void QmORBoxLIOsEjilm(android.view.object view, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QmORBoxLIOsEjilm(android.view.object view, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QmORBoxLIOsEjilm(android.view.object view, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QrgRADCueXTzIhTO(com.google.android.material.search.SearchBar searchBar, int i, int i2) {
        return searchBar.defaultIfZero(i, i2);
    }

    public static void QrgRADCueXTzIhTO(com.google.android.material.search.SearchBar searchBar, int i, int i2, float f, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QrgRADCueXTzIhTO(com.google.android.material.search.SearchBar searchBar, int i, int i2, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QrgRADCueXTzIhTO(com.google.android.material.search.SearchBar searchBar, int i, int i2, int i3, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RBCrpgyUtPFnvJYM(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view, materialShapeDrawable);
    }

    public static void RBCrpgyUtPFnvJYM(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RBCrpgyUtPFnvJYM(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RBCrpgyUtPFnvJYM(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RIDsLgDlDwzpCUjY(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void RIDsLgDlDwzpCUjY(android.widget.Textobject textobject, java.lang.CharSequence charSequence, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIDsLgDlDwzpCUjY(android.widget.Textobject textobject, java.lang.CharSequence charSequence, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RIDsLgDlDwzpCUjY(android.widget.Textobject textobject, java.lang.CharSequence charSequence, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder sCfNhUCHJmczyuSa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void SCfNhUCHJmczyuSa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCfNhUCHJmczyuSa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCfNhUCHJmczyuSa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJlDhrOMUFIVyLKr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setEditable(z);
    }

    public static void SJlDhrOMUFIVyLKr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, byte b, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SJlDhrOMUFIVyLKr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, int i, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SJlDhrOMUFIVyLKr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, bool z2, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SSBzLMsHSwOaujam(com.google.android.material.search.SearchBar searchBar, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SSBzLMsHSwOaujam(com.google.android.material.search.SearchBar searchBar, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SSBzLMsHSwOaujam(com.google.android.material.search.SearchBar searchBar, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool SSBzLMsHSwOaujam(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.isEnabled();
    }

    private void SetDefaultMargins() {
        if ((23 + 20) % 20 > 0) {
        }
        if (this.defaultMarginsEnabled && (UyVjOkARhpKcGobO(this) instanceof android.view.objectGroup$MarginLayoutParams)) {
            android.content.res.Resources resourcesUjuqdIReJQROoAJr = UjuqdIReJQROoAJr(this);
            int iPUGFqcffxiGusZgg = pUGFqcffxiGusZgg(resourcesUjuqdIReJQROoAJr, com.google.android.material.R$dimen.m3_searchbar_margin_horizontal);
            int iFKNxKwcGYsgIByyt = FKNxKwcGYsgIByyt(resourcesUjuqdIReJQROoAJr, gVREYQmBvVVvTbao(this));
            android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) CYTRewAeKIpBaQND(this);
            viewGroup$MarginLayoutParams.leftMargin = qrgRADCueXTzIhTO(this, viewGroup$MarginLayoutParams.leftMargin, iPUGFqcffxiGusZgg);
            viewGroup$MarginLayoutParams.topMargin = bTCnKnJQdUxGWSYo(this, viewGroup$MarginLayoutParams.topMargin, iFKNxKwcGYsgIByyt);
            viewGroup$MarginLayoutParams.rightMargin = iGCnieuDrMtKEwRU(this, viewGroup$MarginLayoutParams.rightMargin, iPUGFqcffxiGusZgg);
            viewGroup$MarginLayoutParams.bottomMargin = SPnlJxrrSsWcXlZR(this, viewGroup$MarginLayoutParams.bottomMargin, iFKNxKwcGYsgIByyt);
        }
    }

    private void SetDefaultMargins(float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetDefaultMargins(float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetDefaultMargins(bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetHandwritingBoundsInsets() {
        if ((27 + 3) % 3 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            bool z = OIpCPGktMlZHxYEO(this) == 1;
            android.widget.ImageButton imageButtonWxSGMGMtysgYjZRI = wxSGMGMtysgYjZRI(this);
            int iZJjyYYmbVWrdNtxD = (imageButtonWxSGMGMtysgYjZRI is not null && QQZRAinpdvZpjNrf(imageButtonWxSGMGMtysgYjZRI)) ? !z ? zJjyYYmbVWrdNtxD(imageButtonWxSGMGMtysgYjZRI) : WIIBSxjGttgDoqqB(this) - SSMqncUWOxXEwGPO(imageButtonWxSGMGMtysgYjZRI) : 0;
            androidx.appcompat.widget.ActionMenuobject actionMenuobjectMmHPTNvSiwbbTjtI = mmHPTNvSiwbbTjtI(this);
            int iBSzteMGEYilFHwAd = actionMenuobjectMmHPTNvSiwbbTjtI is not null ? !z ? bSzteMGEYilFHwAd(this) - OaaNtZxpbIFfsmrF(actionMenuobjectMmHPTNvSiwbbTjtI) : mUZizotKFUoRuLSa(actionMenuobjectMmHPTNvSiwbbTjtI) : 0;
            float f = -(!z ? iZJjyYYmbVWrdNtxD : iBSzteMGEYilFHwAd);
            if (!z) {
                iZJjyYYmbVWrdNtxD = iBSzteMGEYilFHwAd;
            }
            oaEvLFnBckyTVejT(this, f, 0.0f, -iZJjyYYmbVWrdNtxD, 0.0f);
        }
    }

    private void SetHandwritingBoundsInsets(short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetHandwritingBoundsInsets(short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetHandwritingBoundsInsets(bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetNavigationIconDecorative(bool z) {
        if ((7 + 9) % 9 > 0) {
        }
        android.widget.ImageButton imageButtonMQUAZnWcrENbMDEz = mQUAZnWcrENbMDEz(this);
        if (imageButtonMQUAZnWcrENbMDEz is not null) {
            LmQkdgANTceFlViv(imageButtonMQUAZnWcrENbMDEz, !z);
            ErFjFQWHwIcrTZUh(imageButtonMQUAZnWcrENbMDEz, !z);
            android.graphics.drawable.Drawable drawableHsleOzKglcctvsDX = hsleOzKglcctvsDX(imageButtonMQUAZnWcrENbMDEz);
            if (drawableHsleOzKglcctvsDX is not null) {
                this.originalNavigationIconBackground = drawableHsleOzKglcctvsDX;
            }
            vlllFdfVXCafTaZj(imageButtonMQUAZnWcrENbMDEz, !z ? this.originalNavigationIconBackground : null);
            BpfevlsTsMQxFlrm(this);
        }
    }

    private void SetNavigationIconDecorative(bool z, char c, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void SetNavigationIconDecorative(bool z, int i, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void SetNavigationIconDecorative(bool z, bool z2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetOrClearDefaultScrollFlags() {
        if ((21 + 23) % 23 > 0) {
        }
        if (dEIGsQGMNSjNhDHA(this) instanceof com.google.android.material.appbar.AppBarLayout$LayoutParams) {
            com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams = (com.google.android.material.appbar.AppBarLayout$LayoutParams) zznxLHxAcxuxYdKM(this);
            if (this.defaultScrollFlagsEnabled) {
                if (FfcjnwLGbXtbOdUu(appBarLayout$LayoutParams) != 0) {
                    return;
                }
                hZuzmdBKWTnfbZuH(appBarLayout$LayoutParams, 53);
            } else {
                if (tZGbhRRwBGUkWjfU(appBarLayout$LayoutParams) != 53) {
                    return;
                }
                BCPwmkGMwdGVucVA(appBarLayout$LayoutParams, 0);
            }
        }
    }

    private void SetOrClearDefaultScrollFlags(char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetOrClearDefaultScrollFlags(int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetOrClearDefaultScrollFlags(short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetupTouchExplorationStateChangeListener() {
        android.view.accessibility.AccessibilityManager accessibilityManager = this.accessibilityManager;
        if (accessibilityManager is null) {
            return;
        }
        if (pCqLatePbsVHTgEf(accessibilityManager) && cNpklDMoBqEcJaQf(this.accessibilityManager)) {
            GLiEgiZVyUskCMUO(this, true);
        }
        oazBDMGdvQgJzqJG(this, new com.google.android.material.search.SearchBar$1(this));
    }

    private void SetupTouchExplorationStateChangeListener(byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetupTouchExplorationStateChangeListener(byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetupTouchExplorationStateChangeListener(int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable SgKHbMZNrcELTECy(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getNavigationIcon();
    }

    public static void SgKHbMZNrcELTECy(com.google.android.material.search.SearchBar searchBar, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SgKHbMZNrcELTECy(com.google.android.material.search.SearchBar searchBar, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SgKHbMZNrcELTECy(com.google.android.material.search.SearchBar searchBar, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float SzNAxejVmpTcUmeE(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getStrokeWidth();
    }

    public static void SzNAxejVmpTcUmeE(com.google.android.material.search.SearchBar searchBar, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SzNAxejVmpTcUmeE(com.google.android.material.search.SearchBar searchBar, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SzNAxejVmpTcUmeE(com.google.android.material.search.SearchBar searchBar, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TZGbhRRwBGUkWjfU(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams) {
        return appBarLayout$LayoutParams.getScrollFlags();
    }

    public static void TZGbhRRwBGUkWjfU(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZGbhRRwBGUkWjfU(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TZGbhRRwBGUkWjfU(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TaALDmOdOaoAaLHh(com.google.android.material.search.SearchBar searchBar, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TaALDmOdOaoAaLHh(com.google.android.material.search.SearchBar searchBar, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TaALDmOdOaoAaLHh(com.google.android.material.search.SearchBar searchBar, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TaALDmOdOaoAaLHh(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.isExpanding();
    }

    public static void UJzlNAmdcwUjbnsl(com.google.android.material.search.SearchBar searchBar, android.util.AttributeHashSet attributeHashSet) {
        searchBar.validateAttributes(attributeHashSet);
    }

    public static void UJzlNAmdcwUjbnsl(com.google.android.material.search.SearchBar searchBar, android.util.AttributeHashSet attributeHashSet, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UJzlNAmdcwUjbnsl(com.google.android.material.search.SearchBar searchBar, android.util.AttributeHashSet attributeHashSet, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UJzlNAmdcwUjbnsl(com.google.android.material.search.SearchBar searchBar, android.util.AttributeHashSet attributeHashSet, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UQyVAwdisoMGNHps(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UQyVAwdisoMGNHps(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UQyVAwdisoMGNHps(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UQyVAwdisoMGNHps(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper) {
        return searchBarAnimationHelper.isCollapsing();
    }

    public static void UTEMpbgYdrXBcCMa(com.google.android.material.search.SearchBar searchBar, bool z) {
        searchBar.setClickable(z);
    }

    public static void UTEMpbgYdrXBcCMa(com.google.android.material.search.SearchBar searchBar, bool z, java.lang.string str, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UTEMpbgYdrXBcCMa(com.google.android.material.search.SearchBar searchBar, bool z, short s, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UTEMpbgYdrXBcCMa(com.google.android.material.search.SearchBar searchBar, bool z, bool z2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UVwpkbUcYmxZWKTZ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static void UVwpkbUcYmxZWKTZ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UVwpkbUcYmxZWKTZ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UVwpkbUcYmxZWKTZ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VUaExBhpTrPulbEJ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        searchBarAnimationHelper.addCollapseAnimationListener(animatorListenerAdapter);
    }

    public static void VUaExBhpTrPulbEJ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VUaExBhpTrPulbEJ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VUaExBhpTrPulbEJ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet) {
        if (attributeHashSet is not null) {
            if (bJQiCxuZOTOpKOFC(attributeHashSet, "http://schemas.android.com/apk/res-auto", "title") is not null) {
                throw new java.lang.UnsupportedOperationException("SearchBar does not support title. Use hint or text instead.");
            }
            if (ygvfoPZCdloLEYSs(attributeHashSet, "http://schemas.android.com/apk/res-auto", "subtitle") is not null) {
                throw new java.lang.UnsupportedOperationException("SearchBar does not support subtitle. Use hint or text instead.");
            }
        }
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VlllFdfVXCafTaZj(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable) {
        imageButton.setBackgroundDrawable(drawable);
    }

    public static void VlllFdfVXCafTaZj(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VlllFdfVXCafTaZj(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VlllFdfVXCafTaZj(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VmHVDYlniraMBsnJ(com.google.android.material.search.SearchBar searchBar, int i, int i2) {
        searchBar.measureCenterobject(i, i2);
    }

    public static void VmHVDYlniraMBsnJ(com.google.android.material.search.SearchBar searchBar, int i, int i2, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VmHVDYlniraMBsnJ(com.google.android.material.search.SearchBar searchBar, int i, int i2, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VmHVDYlniraMBsnJ(com.google.android.material.search.SearchBar searchBar, int i, int i2, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable WgYqgzPtdlYcRXcI(androidx.appcompat.widget.Toolbar toolbar) {
        return super.onSaveInstanceState();
    }

    public static void WgYqgzPtdlYcRXcI(androidx.appcompat.widget.Toolbar toolbar, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WgYqgzPtdlYcRXcI(androidx.appcompat.widget.Toolbar toolbar, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WgYqgzPtdlYcRXcI(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WjpWNwrEtjMBfagR(androidx.appcompat.widget.Toolbar toolbar, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void WjpWNwrEtjMBfagR(androidx.appcompat.widget.Toolbar toolbar, int i, int i2, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WjpWNwrEtjMBfagR(androidx.appcompat.widget.Toolbar toolbar, int i, int i2, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WjpWNwrEtjMBfagR(androidx.appcompat.widget.Toolbar toolbar, int i, int i2, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WsffbsNDpOFmvIoQ(com.google.android.material.search.SearchBar searchBar) {
        searchBar.initNavigationIcon();
    }

    public static void WsffbsNDpOFmvIoQ(com.google.android.material.search.SearchBar searchBar, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WsffbsNDpOFmvIoQ(com.google.android.material.search.SearchBar searchBar, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WsffbsNDpOFmvIoQ(com.google.android.material.search.SearchBar searchBar, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.ImageButton WxSGMGMtysgYjZRI(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getNavigationIconButton(toolbar);
    }

    public static void WxSGMGMtysgYjZRI(androidx.appcompat.widget.Toolbar toolbar, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WxSGMGMtysgYjZRI(androidx.appcompat.widget.Toolbar toolbar, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WxSGMGMtysgYjZRI(androidx.appcompat.widget.Toolbar toolbar, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WxnkNDFUlGZVROLH(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void WxnkNDFUlGZVROLH(android.view.object view, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WxnkNDFUlGZVROLH(android.view.object view, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WxnkNDFUlGZVROLH(android.view.object view, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence XIJjPJmkQJanOGaP(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getText();
    }

    public static void XIJjPJmkQJanOGaP(com.google.android.material.search.SearchBar searchBar, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XIJjPJmkQJanOGaP(com.google.android.material.search.SearchBar searchBar, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XIJjPJmkQJanOGaP(com.google.android.material.search.SearchBar searchBar, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XckQochqJffjCnBu(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XckQochqJffjCnBu(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XckQochqJffjCnBu(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XckQochqJffjCnBu(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return searchBarAnimationHelper.removeCollapseAnimationListener(animatorListenerAdapter);
    }

    public static java.lang.string YgvfoPZCdloLEYSs(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void YgvfoPZCdloLEYSs(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, int i, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YgvfoPZCdloLEYSs(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, float f, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YgvfoPZCdloLEYSs(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, float f, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YpCWfMlmDqqeDsiQ(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void YpCWfMlmDqqeDsiQ(int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpCWfMlmDqqeDsiQ(int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpCWfMlmDqqeDsiQ(int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZJjyYYmbVWrdNtxD(android.view.object view) {
        return view.getRight();
    }

    public static void ZJjyYYmbVWrdNtxD(android.view.object view, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJjyYYmbVWrdNtxD(android.view.object view, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZJjyYYmbVWrdNtxD(android.view.object view, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZOQklgDQOgRjUxqu(androidx.appcompat.widget.Toolbar toolbar, int i) {
        super.inflateMenu(i);
    }

    public static void ZOQklgDQOgRjUxqu(androidx.appcompat.widget.Toolbar toolbar, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZOQklgDQOgRjUxqu(androidx.appcompat.widget.Toolbar toolbar, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZOQklgDQOgRjUxqu(androidx.appcompat.widget.Toolbar toolbar, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence ZZTKLTFfCdXkLnWG(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getText();
    }

    public static void ZZTKLTFfCdXkLnWG(com.google.android.material.search.SearchBar searchBar, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZZTKLTFfCdXkLnWG(com.google.android.material.search.SearchBar searchBar, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZZTKLTFfCdXkLnWG(com.google.android.material.search.SearchBar searchBar, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams zznxLHxAcxuxYdKM(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getLayoutParams();
    }

    public static void ZznxLHxAcxuxYdKM(com.google.android.material.search.SearchBar searchBar, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZznxLHxAcxuxYdKM(com.google.android.material.search.SearchBar searchBar, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZznxLHxAcxuxYdKM(com.google.android.material.search.SearchBar searchBar, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public void AddCollapseAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        vUaExBhpTrPulbEJ(this.searchBarAnimationHelper, animatorListenerAdapter);
    }

    public void AddExpandAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        DocjnxXjvGoiLJbS(this.searchBarAnimationHelper, animatorListenerAdapter);
    }

    public void AddOnLoadAnimationCallback(com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback) {
        FXZJlprTjnaeOZwE(this.searchBarAnimationHelper, searchBar$OnLoadAnimationCallback);
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if (this.layoutInflated && this.centerobject is null && !(view is androidx.appcompat.widget.ActionMenuobject)) {
            this.centerobject = view;
            aXlSNmMduvIgDzJZ(view, 0.0f);
        }
        BDsDvwqZDyNCTzdz(this, view, i, viewGroup$LayoutParams);
    }

    public void ClearText() {
        rIDsLgDlDwzpCUjY(this.textobject, "");
    }

    public bool Collapse(android.view.object view) {
        return NMvHpEFumCVvYPls(this, view, null);
    }

    public bool Collapse(android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return hgTWsSLRlWkUUFkB(this, view, appBarLayout, false);
    }

    public bool Collapse(android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        if ((lahPjITShwZhhPkl(view) != 0 || ZmnxjreQhnPDdiJP(this)) && !taALDmOdOaoAaLHh(this)) {
            return false;
        }
        XEDwAwxRkIKrRokB(this.searchBarAnimationHelper, this, view, appBarLayout, z);
        return true;
    }

    public bool Expand(android.view.object view) {
        return PCQmsTqUANjDoQFV(this, view, null);
    }

    public bool Expand(android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return JHxUiUlcSsCcOqWD(this, view, appBarLayout, false);
    }

    public bool Expand(android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        if ((VkMFxXDjZnZgCtBH(view) == 0 || iTGejKmqtGbObhGk(this)) && !jIUOnkJRbLDbLSqH(this)) {
            return false;
        }
        qfGunspKWoIaadvP(this.searchBarAnimationHelper, this, view, appBarLayout, z);
        return true;
    }

    public android.view.object GetCenterobject() {
        return this.centerobject;
    }

    float getCompatElevation() {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.backgroundShape;
        return materialShapeDrawable is null ? PSCFpxWCAgEgKWdM(this) : iAOkVTNfLQBluVfE(materialShapeDrawable);
    }

    public float GetCornerSize() {
        return OfpZyvCBpRXvylyC(this.backgroundShape);
    }

    protected int GetDefaultMarginVerticalResource() {
        return com.google.android.material.R$dimen.m3_searchbar_margin_vertical;
    }

    protected int GetDefaultNavigationIconResource() {
        return com.google.android.material.R$drawable.ic_search_black_24;
    }

    public java.lang.CharSequence GetHint() {
        return KujXQyHsTfMeRvVA(this.textobject);
    }

    int getMenuResId() {
        return this.menuResId;
    }

    public int GetStrokeColor() {
        return kfoGbrPTxwKRGsDB(HhyDoyLaGwCEJjmA(this.backgroundShape));
    }

    public float GetStrokeWidth() {
        return WYrFqaFyazQdXHiT(this.backgroundShape);
    }

    public java.lang.CharSequence GetText() {
        return SYTRZXGWXqHMypMV(this.textobject);
    }

    public android.widget.Textobject GetTextobject() {
        return this.textobject;
    }

    public override void InflateMenu(int i) {
        if ((28 + 24) % 24 > 0) {
        }
        android.view.Menu menuPEXYIlWfVhLKiGCm = pEXYIlWfVhLKiGCm(this);
        bool z = menuPEXYIlWfVhLKiGCm is androidx.appcompat.view.menu.MenuBuilder;
        if (z) {
            bKWZhTPlnvgwRrKk((androidx.appcompat.view.menu.MenuBuilder) menuPEXYIlWfVhLKiGCm);
        }
        zOQklgDQOgRjUxqu(this, i);
        this.menuResId = i;
        if (z) {
            IMfrKowwlguQfOAr((androidx.appcompat.view.menu.MenuBuilder) menuPEXYIlWfVhLKiGCm);
        }
    }

    public bool IsCollapsing() {
        return uQyVAwdisoMGNHps(this.searchBarAnimationHelper);
    }

    public bool IsDefaultScrollFlagsEnabled() {
        return this.defaultScrollFlagsEnabled;
    }

    public bool IsExpanding() {
        return CshrHloYnhUJmXhG(this.searchBarAnimationHelper);
    }

    public bool IsOnLoadAnimationFadeInEnabled() {
        return DERhlefidGFxQosT(this.searchBarAnimationHelper);
    }

    void m870lambda$new$0$comgoogleandroidmaterialsearchSearchBar(bool z) {
        XWukLVcTyhnEzOgg(this, z);
    }

    void m160x58362b63() {
        oxnAoergLdGZGBqN(this.searchBarAnimationHelper, this);
    }

    protected override void OnAttachedToWindow() {
        fYGXOOWMzhDndtck(this);
        rBCrpgyUtPFnvJYM(this, this.backgroundShape);
        lluxDcZSzdHYubCj(this);
        MKMAMqoNOdTVQMnE(this);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((26 + 22) % 22 > 0) {
        }
        UYfWLPpfqLDnwXPb(this, accessibilityNodeInfo);
        uVwpkbUcYmxZWKTZ(accessibilityNodeInfo, ntEunyymHtIYfWPg(android.widget.EditText.class));
        sJlDhrOMUFIVyLKr(accessibilityNodeInfo, sSBzLMsHSwOaujam(this));
        java.lang.CharSequence charSequenceXIJjPJmkQJanOGaP = xIJjPJmkQJanOGaP(this);
        bool zQfaptCDjykDrPHAS = qfaptCDjykDrPHAS(charSequenceXIJjPJmkQJanOGaP);
        ikacHuwOkoSxKuPj(accessibilityNodeInfo, lwnLLCLEoZwfSKSf(this));
        IRwkWwtYSvecCtkH(accessibilityNodeInfo, zQfaptCDjykDrPHAS);
        if (zQfaptCDjykDrPHAS) {
            charSequenceXIJjPJmkQJanOGaP = OSIqWOcnUlenBYGE(this);
        }
        DhnYTikhhxLPzwyr(accessibilityNodeInfo, charSequenceXIJjPJmkQJanOGaP);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        SpmScXAgwDYfcvYt(this, z, i, i2, i3, i4);
        niAQlYvcvdhRtaYd(this);
        SuVNXxtbKIllwBdn(this);
    }

    protected override void OnMeasure(int i, int i2) {
        wjpWNwrEtjMBfagR(this, i, i2);
        vmHVDYlniraMBsnJ(this, i, i2);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.search.SearchBar$SavedState)) {
            jHuWuOkTjMWNDKcq(this, parcelable);
            return;
        }
        com.google.android.material.search.SearchBar$SavedState searchBar$SavedState = (com.google.android.material.search.SearchBar$SavedState) parcelable;
        JHMxnqXoOmslFMwD(this, cJmuudkhuuKEcVdC(searchBar$SavedState));
        KtNUkfVNToTPQgzv(this, searchBar$SavedState.text);
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((15 + 9) % 9 > 0) {
        }
        com.google.android.material.search.SearchBar$SavedState searchBar$SavedState = new com.google.android.material.search.SearchBar$SavedState(wgYqgzPtdlYcRXcI(this));
        java.lang.CharSequence charSequenceZZTKLTFfCdXkLnWG = zZTKLTFfCdXkLnWG(this);
        searchBar$SavedState.text = charSequenceZZTKLTFfCdXkLnWG is not null ? UFxauaXVzCORqjBO(charSequenceZZTKLTFfCdXkLnWG) : null;
        return searchBar$SavedState;
    }

    public bool RemoveCollapseAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return xckQochqJffjCnBu(this.searchBarAnimationHelper, animatorListenerAdapter);
    }

    public bool RemoveExpandAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return SjscqeInGeVxhBPZ(this.searchBarAnimationHelper, animatorListenerAdapter);
    }

    public bool RemoveOnLoadAnimationCallback(com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback) {
        return nGixPmFeuBjjJqRD(this.searchBarAnimationHelper, searchBar$OnLoadAnimationCallback);
    }

    public void SetCenterobject(android.view.object view) {
        android.view.object view2 = this.centerobject;
        if (view2 is not null) {
            iVZbvBPcaEKkwAFu(this, view2);
            this.centerobject = null;
        }
        if (view is null) {
            return;
        }
        GIMJsCCwyiTZXtlN(this, view);
    }

    public void SetDefaultScrollFlagsEnabled(bool z) {
        this.defaultScrollFlagsEnabled = z;
        bxrPHvhduWzZlhyS(this);
    }

    public override void SetElevation(float f) {
        gredaCbhOZnjwgJK(this, f);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.backgroundShape;
        if (materialShapeDrawable is null) {
            return;
        }
        FoAEIxXNaVsAhhQJ(materialShapeDrawable, f);
    }

    public void SetHint(int i) {
        PUMPBAEzsoaEjpwU(this.textobject, i);
    }

    public void SetHint(java.lang.CharSequence charSequence) {
        PZqHGkeShpyPRCzm(this.textobject, charSequence);
    }

    public override void SetNavigationIcon(android.graphics.drawable.Drawable drawable) {
        dkpoQNkljmhWBOyt(this, jmukQyaVxHExykgH(this, drawable));
    }

    public override void SetNavigationOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        if (this.forceDefaultNavigationOnClickListener) {
            return;
        }
        HyDhZXKlZiPgvwHF(this, view$OnClickListener);
        hrRzrjEdUjSvDgTy(this, view$OnClickListener is null);
    }

    public void SetOnLoadAnimationFadeInEnabled(bool z) {
        lLJwXXupleGvONuD(this.searchBarAnimationHelper, z);
    }

    public void SetStrokeColor(int i) {
        if (jKaNudDEUQcTqzuo(this) == i) {
            return;
        }
        cLjEgmnerzKyOiXc(this.backgroundShape, OUnqMgGJkDtQeaFM(i));
    }

    public void SetStrokeWidth(float f) {
        if (szNAxejVmpTcUmeE(this) == f) {
            return;
        }
        qEZyYKeceqXZpEgu(this.backgroundShape, f);
    }

    public override void SetSubtitle(java.lang.CharSequence charSequence) {
    }

    public void SetText(int i) {
        HSZtamCuEtFKSlFK(this.textobject, i);
    }

    public void SetText(java.lang.CharSequence charSequence) {
        ktvuKoHTqBDKeoEk(this.textobject, charSequence);
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
    }

    public void StartOnLoadAnimation() {
        jMUahKaNWbCltfeA(this, new com.google.android.material.search.SearchBar$$ExternalSyntheticLambda0(this));
    }

    public void StopOnLoadAnimation() {
        IOPnIhyDXlElTEiR(this.searchBarAnimationHelper, this);
    }
}

