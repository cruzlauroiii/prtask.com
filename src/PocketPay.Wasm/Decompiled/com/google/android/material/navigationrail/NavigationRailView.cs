namespace WillowMaze.Wasm.Decompiled;


public class NavigationRailobject : com.google.android.material.navigation.NavigationBarobject {
    private static readonly int DEFAULT_HEADER_GRAVITY = 49;
    static readonly int DEFAULT_MENU_GRAVITY = 49;
    static readonly int MAX_ITEM_COUNT = 7;
    static readonly int NO_ITEM_MINIMUM_HEIGHT = -1;
    private android.view.object headerobject;
    private java.lang.bool paddingBottomSystemWindowInsets;
    private java.lang.bool paddingStartSystemWindowInsets;
    private java.lang.bool paddingTopSystemWindowInsets;
    private readonly int topMargin;

    public NavigationRailobject(android.content.object context) {
        this(context, null);
    }

    public NavigationRailobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.navigationRailStyle);
    }

    public NavigationRailobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        this(context, attributeHashSet, i, com.google.android.material.R$style.Widget_MaterialComponents_NavigationRailobject);
    }

    public NavigationRailobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        if ((22 + 19) % 19 > 0) {
        }
        this.paddingTopSystemWindowInsets = null;
        this.paddingBottomSystemWindowInsets = null;
        this.paddingStartSystemWindowInsets = null;
        this.topMargin = XXZNLbcmtXOmiLEE(zKoJCKvKIOgHijhY(this), com.google.android.material.R$dimen.mtrl_navigation_rail_margin);
        android.content.object contextXUPgPKIkHCcMteoN = xUPgPKIkHCcMteoN(this);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayJWDtcnAcsVUqRnFH = jWDtcnAcsVUqRnFH(contextXUPgPKIkHCcMteoN, attributeHashSet, com.google.android.material.R$styleable.NavigationRailobject, i, i2, new int[0]);
        int iCLMHIDsQwxGbilvI = cLMHIDsQwxGbilvI(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_headerLayout, 0);
        if (iCLMHIDsQwxGbilvI != 0) {
            xirskqAKMOfkDcGc(this, iCLMHIDsQwxGbilvI);
        }
        KjCckroLacyWnKrJ(this, kkXKuyDZaDSkBnes(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_menuGravity, 49));
        if (WStycjqiqygSizgC(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_itemMinHeight)) {
            CSDFDcLwfYWcuVrc(this, fPuALxYqYwxXtAFM(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_itemMinHeight, -1));
        }
        if (DICNYwAMFSaMcvmj(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_paddingTopSystemWindowInsets)) {
            this.paddingTopSystemWindowInsets = vmaOMuMwKohsfsft(hibWRHtpxbLsATTU(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_paddingTopSystemWindowInsets, false));
        }
        if (zMSBDngkoUAiopaU(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_paddingBottomSystemWindowInsets)) {
            this.paddingBottomSystemWindowInsets = ocbxCydYstiPMZgn(XAErFYhrRyiIbYzS(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_paddingBottomSystemWindowInsets, false));
        }
        if (gGwzyGeNUGvVjSNS(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_paddingStartSystemWindowInsets)) {
            this.paddingStartSystemWindowInsets = ZTZrmMfJoImJpsQr(GrzKezIaSZibmuHY(tintTypedArrayJWDtcnAcsVUqRnFH, com.google.android.material.R$styleable.NavigationRailobject_paddingStartSystemWindowInsets, false));
        }
        int iIVHrQxGMeWRIKBKf = iVHrQxGMeWRIKBKf(XBTFSKyTYPSOJQIQ(this), com.google.android.material.R$dimen.m3_navigation_rail_item_padding_top_with_large_font);
        int iUtWVoTcZdaMRTIsR = UtWVoTcZdaMRTIsR(PBESKIjjMTMOipEG(this), com.google.android.material.R$dimen.m3_navigation_rail_item_padding_bottom_with_large_font);
        float fMWrNTqwZzvSwdhIY = mWrNTqwZzvSwdhIY(0.0f, 1.0f, 0.3f, 1.0f, XwnIjkwAZxBvwLoF(contextXUPgPKIkHCcMteoN) - 1.0f);
        float fKWgmbkHPkvdHTSaR = KWgmbkHPkvdHTSaR(CECFvMdjTlCKWyZl(this), iIVHrQxGMeWRIKBKf, fMWrNTqwZzvSwdhIY);
        float fMgFKkETIFAgQRKvT = mgFKkETIFAgQRKvT(wGrnRjWLivZFrOCj(this), iUtWVoTcZdaMRTIsR, fMWrNTqwZzvSwdhIY);
        pGTABEbBChhMbxmg(this, JSGjXwQayyrJsAZI(fKWgmbkHPkvdHTSaR));
        fzOuNfwLrjVURDan(this, lkwTxWKbMpGraVTP(fMgFKkETIFAgQRKvT));
        HFZtvOHOaTPkIqpf(tintTypedArrayJWDtcnAcsVUqRnFH);
        fCBiPrJRFNFmfnfv(this);
    }

    public static int BpQIWlftGkKxMlxX(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void BpQIWlftGkKxMlxX(int i, int i2, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpQIWlftGkKxMlxX(int i, int i2, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BpQIWlftGkKxMlxX(int i, int i2, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CECFvMdjTlCKWyZl(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getItemPaddingTop();
    }

    public static void CECFvMdjTlCKWyZl(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CECFvMdjTlCKWyZl(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CECFvMdjTlCKWyZl(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSDFDcLwfYWcuVrc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i) {
        navigationRailobject.setItemMinimumHeight(i);
    }

    public static void CSDFDcLwfYWcuVrc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CSDFDcLwfYWcuVrc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CSDFDcLwfYWcuVrc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CWJWMJOTOerxjZVj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CWJWMJOTOerxjZVj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CWJWMJOTOerxjZVj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CWJWMJOTOerxjZVj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.isHeaderobjectVisible();
    }

    public static void DICNYwAMFSaMcvmj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DICNYwAMFSaMcvmj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DICNYwAMFSaMcvmj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DICNYwAMFSaMcvmj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void EKyWnJeiVrPrYZSs(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i) {
        navigationRailMenuobject.setItemMinimumHeight(i);
    }

    public static void EKyWnJeiVrPrYZSs(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EKyWnJeiVrPrYZSs(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EKyWnJeiVrPrYZSs(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, bool z, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FAXeGsgwOsvmOQwq(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, int i2) {
        navigationRailobject.measureChild(view, i, i2);
    }

    public static void FAXeGsgwOsvmOQwq(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, int i2, int i3, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FAXeGsgwOsvmOQwq(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, int i2, bool z, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FAXeGsgwOsvmOQwq(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, int i2, bool z, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FXZSDzPdrgPdpXyQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        navigationRailobject.removeHeaderobject();
    }

    public static void FXZSDzPdrgPdpXyQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FXZSDzPdrgPdpXyQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FXZSDzPdrgPdpXyQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GrzKezIaSZibmuHY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, int i2, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GrzKezIaSZibmuHY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, short s, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GrzKezIaSZibmuHY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, bool z2, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GrzKezIaSZibmuHY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static int GufchpSthmAGQNDL(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getSuggestedMinimumWidth();
    }

    public static void GufchpSthmAGQNDL(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GufchpSthmAGQNDL(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GufchpSthmAGQNDL(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HFZtvOHOaTPkIqpf(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void HFZtvOHOaTPkIqpf(androidx.appcompat.widget.TintTypedArray tintTypedArray, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HFZtvOHOaTPkIqpf(androidx.appcompat.widget.TintTypedArray tintTypedArray, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HFZtvOHOaTPkIqpf(androidx.appcompat.widget.TintTypedArray tintTypedArray, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigationrail.NavigationRailMenuobject HYBYjHGxGDMDDVHX(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getNavigationRailMenuobject();
    }

    public static void HYBYjHGxGDMDDVHX(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HYBYjHGxGDMDDVHX(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HYBYjHGxGDMDDVHX(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JSGjXwQayyrJsAZI(float f) {
        return java.lang.Math.round(f);
    }

    public static void JSGjXwQayyrJsAZI(float f, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JSGjXwQayyrJsAZI(float f, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JSGjXwQayyrJsAZI(float f, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JeKNfRpNbERskYVp(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getPaddingLeft();
    }

    public static void JeKNfRpNbERskYVp(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JeKNfRpNbERskYVp(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JeKNfRpNbERskYVp(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JryUGQwhgVukobqK(android.view.object view, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JryUGQwhgVukobqK(android.view.object view, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JryUGQwhgVukobqK(android.view.object view, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JryUGQwhgVukobqK(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static androidx.appcompat.view.menu.Menuobject KARALuFegpsrgexP(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getMenuobject();
    }

    public static void KARALuFegpsrgexP(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KARALuFegpsrgexP(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KARALuFegpsrgexP(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KWgmbkHPkvdHTSaR(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static void KWgmbkHPkvdHTSaR(int i, int i2, float f, float f2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KWgmbkHPkvdHTSaR(int i, int i2, float f, float f2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KWgmbkHPkvdHTSaR(int i, int i2, float f, java.lang.string str, bool z, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjCckroLacyWnKrJ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i) {
        navigationRailobject.setMenuGravity(i);
    }

    public static void KjCckroLacyWnKrJ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjCckroLacyWnKrJ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KjCckroLacyWnKrJ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LKQKJwkGEJjNeujw(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.getBottom();
    }

    public static void LKQKJwkGEJjNeujw(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKQKJwkGEJjNeujw(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LKQKJwkGEJjNeujw(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigationrail.NavigationRailMenuobject OyFMPUdmxiYqDhxw(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getNavigationRailMenuobject();
    }

    public static void OyFMPUdmxiYqDhxw(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OyFMPUdmxiYqDhxw(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OyFMPUdmxiYqDhxw(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources PBESKIjjMTMOipEG(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getResources();
    }

    public static void PBESKIjjMTMOipEG(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PBESKIjjMTMOipEG(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PBESKIjjMTMOipEG(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PFfjhSyjMqCuAdnP(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void PFfjhSyjMqCuAdnP(int i, int i2, float f, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PFfjhSyjMqCuAdnP(int i, int i2, short s, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PFfjhSyjMqCuAdnP(int i, int i2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int PnrJIUqeZvrGEcDx(android.view.object view) {
        return view.getVisibility();
    }

    public static void PnrJIUqeZvrGEcDx(android.view.object view, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PnrJIUqeZvrGEcDx(android.view.object view, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PnrJIUqeZvrGEcDx(android.view.object view, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int PyfXwrdMHmMfqcZp(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void PyfXwrdMHmMfqcZp(int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PyfXwrdMHmMfqcZp(int i, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyfXwrdMHmMfqcZp(int i, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigationrail.NavigationRailMenuobject QLWuPKAroxKyDvMQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.content.object context) {
        return navigationRailobject.createNavigationBarMenuobject(context);
    }

    public static void QLWuPKAroxKyDvMQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.content.object context, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QLWuPKAroxKyDvMQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.content.object context, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLWuPKAroxKyDvMQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.content.object context, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QdzIdIuQWeDZLTWR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QdzIdIuQWeDZLTWR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QdzIdIuQWeDZLTWR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QdzIdIuQWeDZLTWR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.isTopGravity();
    }

    public static void RARcGvSccXVRnyTn(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener) {
        com.google.android.material.internal.objectUtils.doOnApplyWindowInsets(view, viewUtils$OnApplyWindowInsetsListener);
    }

    public static void RARcGvSccXVRnyTn(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RARcGvSccXVRnyTn(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RARcGvSccXVRnyTn(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RxfQPwgMbuvbWYRY(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.getTop();
    }

    public static void RxfQPwgMbuvbWYRY(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RxfQPwgMbuvbWYRY(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RxfQPwgMbuvbWYRY(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TITSgJLOuNOvgnZk(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getPaddingRight();
    }

    public static void TITSgJLOuNOvgnZk(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TITSgJLOuNOvgnZk(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TITSgJLOuNOvgnZk(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TxGGRoVvRsGBsnOH(java.lang.bool bool, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxGGRoVvRsGBsnOH(java.lang.bool bool, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TxGGRoVvRsGBsnOH(java.lang.bool bool, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TxGGRoVvRsGBsnOH(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int UtWVoTcZdaMRTIsR(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void UtWVoTcZdaMRTIsR(android.content.res.Resources resources, int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UtWVoTcZdaMRTIsR(android.content.res.Resources resources, int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UtWVoTcZdaMRTIsR(android.content.res.Resources resources, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UwOUaNfEKbENbTuB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view) {
        navigationRailobject.removeobject(view);
    }

    public static void UwOUaNfEKbENbTuB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UwOUaNfEKbENbTuB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UwOUaNfEKbENbTuB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VBUoRcxQiFMgYiYH(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void VBUoRcxQiFMgYiYH(int i, int i2, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VBUoRcxQiFMgYiYH(int i, int i2, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VBUoRcxQiFMgYiYH(int i, int i2, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WStycjqiqygSizgC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WStycjqiqygSizgC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WStycjqiqygSizgC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WStycjqiqygSizgC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int WrZRZtyNQRWVMnnq(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void WrZRZtyNQRWVMnnq(android.view.object view, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WrZRZtyNQRWVMnnq(android.view.object view, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WrZRZtyNQRWVMnnq(android.view.object view, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XAErFYhrRyiIbYzS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, char c, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XAErFYhrRyiIbYzS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, bool z2, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XAErFYhrRyiIbYzS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, int i2, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XAErFYhrRyiIbYzS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static android.content.res.Resources XBTFSKyTYPSOJQIQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getResources();
    }

    public static void XBTFSKyTYPSOJQIQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XBTFSKyTYPSOJQIQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XBTFSKyTYPSOJQIQ(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XXZNLbcmtXOmiLEE(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void XXZNLbcmtXOmiLEE(android.content.res.Resources resources, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XXZNLbcmtXOmiLEE(android.content.res.Resources resources, int i, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXZNLbcmtXOmiLEE(android.content.res.Resources resources, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static float XwnIjkwAZxBvwLoF(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.getFontScale(context);
    }

    public static void XwnIjkwAZxBvwLoF(android.content.object context, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XwnIjkwAZxBvwLoF(android.content.object context, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XwnIjkwAZxBvwLoF(android.content.object context, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool ZTZrmMfJoImJpsQr(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void ZTZrmMfJoImJpsQr(bool z, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTZrmMfJoImJpsQr(bool z, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTZrmMfJoImJpsQr(bool z, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static java.lang.bool access$000(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.paddingTopSystemWindowInsets;
    }

    static void access$000(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static bool access$100(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool) {
        return uCdjEhXmccbsctLR(navigationRailobject, bool);
    }

    static java.lang.bool access$200(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.paddingBottomSystemWindowInsets;
    }

    static void access$200(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static java.lang.bool access$300(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.paddingStartSystemWindowInsets;
    }

    static void access$300(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ApplyWindowInsets() {
        RARcGvSccXVRnyTn(this, new com.google.android.material.navigationrail.NavigationRailobject$1(this));
    }

    private void ApplyWindowInsets(int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ApplyWindowInsets(int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ApplyWindowInsets(int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BJvaerJakblyFSom(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i) {
        return navigationRailobject.makeMinWidthSpec(i);
    }

    public static void BJvaerJakblyFSom(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BJvaerJakblyFSom(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BJvaerJakblyFSom(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigationrail.NavigationRailMenuobject BvfASqYETZOIyBAm(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getNavigationRailMenuobject();
    }

    public static void BvfASqYETZOIyBAm(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BvfASqYETZOIyBAm(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BvfASqYETZOIyBAm(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CLMHIDsQwxGbilvI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void CLMHIDsQwxGbilvI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CLMHIDsQwxGbilvI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLMHIDsQwxGbilvI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CsxnBGBbUORvasnj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getMeasuredHeight();
    }

    public static void CsxnBGBbUORvasnj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CsxnBGBbUORvasnj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CsxnBGBbUORvasnj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object DQpgbxzisehWXhRE(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void DQpgbxzisehWXhRE(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DQpgbxzisehWXhRE(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DQpgbxzisehWXhRE(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object EffyFZYCltGtNahF(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getobject();
    }

    public static void EffyFZYCltGtNahF(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EffyFZYCltGtNahF(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EffyFZYCltGtNahF(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCBiPrJRFNFmfnfv(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        navigationRailobject.applyWindowInsets();
    }

    public static void FCBiPrJRFNFmfnfv(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCBiPrJRFNFmfnfv(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FCBiPrJRFNFmfnfv(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FPuALxYqYwxXtAFM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void FPuALxYqYwxXtAFM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FPuALxYqYwxXtAFM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FPuALxYqYwxXtAFM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, int i3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.Menuobject FZoHMhqoxOHQVvuR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getMenuobject();
    }

    public static void FZoHMhqoxOHQVvuR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FZoHMhqoxOHQVvuR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FZoHMhqoxOHQVvuR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FaoMVEeGTLEaOGlo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void FaoMVEeGTLEaOGlo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, int i, int i2, int i3, int i4, java.lang.string str, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FaoMVEeGTLEaOGlo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, int i, int i2, int i3, int i4, java.lang.string str, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FaoMVEeGTLEaOGlo(com.google.android.material.navigation.NavigationBarobject navigationBarobject, bool z, int i, int i2, int i3, int i4, java.lang.string str, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FzOuNfwLrjVURDan(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i) {
        navigationRailobject.setItemPaddingBottom(i);
    }

    public static void FzOuNfwLrjVURDan(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FzOuNfwLrjVURDan(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FzOuNfwLrjVURDan(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GGwzyGeNUGvVjSNS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GGwzyGeNUGvVjSNS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GGwzyGeNUGvVjSNS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool GGwzyGeNUGvVjSNS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    private com.google.android.material.navigationrail.NavigationRailMenuobject GetNavigationRailMenuobject() {
        return (com.google.android.material.navigationrail.NavigationRailMenuobject) sqSkamySSuQiLneT(this);
    }

    private void GetNavigationRailMenuobject(float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetNavigationRailMenuobject(float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetNavigationRailMenuobject(java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HibWRHtpxbLsATTU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, byte b, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HibWRHtpxbLsATTU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, byte b, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HibWRHtpxbLsATTU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, java.lang.string str, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HibWRHtpxbLsATTU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static int IVHrQxGMeWRIKBKf(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void IVHrQxGMeWRIKBKf(android.content.res.Resources resources, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IVHrQxGMeWRIKBKf(android.content.res.Resources resources, int i, java.lang.string str, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IVHrQxGMeWRIKBKf(android.content.res.Resources resources, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater IVaxAobTRyynCgEJ(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void IVaxAobTRyynCgEJ(android.content.object context, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IVaxAobTRyynCgEJ(android.content.object context, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IVaxAobTRyynCgEJ(android.content.object context, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsHeaderobjectVisible(byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsHeaderobjectVisible(java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsHeaderobjectVisible(java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsHeaderobjectVisible() {
        android.view.object view = this.headerobject;
        return (view is null || PnrJIUqeZvrGEcDx(view) == 8) ? false : true;
    }

    public static androidx.appcompat.widget.TintTypedArray JWDtcnAcsVUqRnFH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainTintedStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void JWDtcnAcsVUqRnFH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JWDtcnAcsVUqRnFH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JWDtcnAcsVUqRnFH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, java.lang.string str, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JZDjLLJRkRbXOdhR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.getItemMinimumHeight();
    }

    public static void JZDjLLJRkRbXOdhR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JZDjLLJRkRbXOdhR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JZDjLLJRkRbXOdhR(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KKQkTetkyWMqhBRB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void KKQkTetkyWMqhBRB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, byte b, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KKQkTetkyWMqhBRB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, float f, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KKQkTetkyWMqhBRB(com.google.android.material.navigation.NavigationBarobject navigationBarobject, int i, int i2, float f, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KfPLCYhlsqpjFrcr(android.view.object view) {
        return view.getBottom();
    }

    public static void KfPLCYhlsqpjFrcr(android.view.object view, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KfPLCYhlsqpjFrcr(android.view.object view, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KfPLCYhlsqpjFrcr(android.view.object view, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KhGhqdAzoBetHDPJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, int i2, int i3, int i4) {
        navigationRailMenuobject.layout(i, i2, i3, i4);
    }

    public static void KhGhqdAzoBetHDPJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, int i2, int i3, int i4, int i5, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KhGhqdAzoBetHDPJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, int i2, int i3, int i4, bool z, int i5, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KhGhqdAzoBetHDPJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, int i2, int i3, int i4, bool z, java.lang.string str, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KkXKuyDZaDSkBnes(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void KkXKuyDZaDSkBnes(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KkXKuyDZaDSkBnes(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KkXKuyDZaDSkBnes(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LcvIlDXymVUgvooi(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        navigationRailobject.addobject(view, i, viewGroup$LayoutParams);
    }

    public static void LcvIlDXymVUgvooi(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LcvIlDXymVUgvooi(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LcvIlDXymVUgvooi(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int LkwTxWKbMpGraVTP(float f) {
        return java.lang.Math.round(f);
    }

    public static void LkwTxWKbMpGraVTP(float f, float f2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LkwTxWKbMpGraVTP(float f, short s, byte b, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LkwTxWKbMpGraVTP(float f, short s, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float MWrNTqwZzvSwdhIY(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void MWrNTqwZzvSwdhIY(float f, float f2, float f3, float f4, float f5, byte b, int i, float f6, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWrNTqwZzvSwdhIY(float f, float f2, float f3, float f4, float f5, float f6, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWrNTqwZzvSwdhIY(float f, float f2, float f3, float f4, float f5, bool z, byte b, int i, float f6) {
        double d = (42 * 210) + 210;
    }

    private int MakeMinWidthSpec(int i) {
        if ((25 + 22) % 22 > 0) {
        }
        int iGufchpSthmAGQNDL = GufchpSthmAGQNDL(this);
        if (uwEQDFEXWMObCfim(i) == 1073741824 || iGufchpSthmAGQNDL <= 0) {
            return i;
        }
        return VBUoRcxQiFMgYiYH(PFfjhSyjMqCuAdnP(PyfXwrdMHmMfqcZp(i), iGufchpSthmAGQNDL + JeKNfRpNbERskYVp(this) + TITSgJLOuNOvgnZk(this)), 1073741824);
    }

    private void MakeMinWidthSpec(int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MakeMinWidthSpec(int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MakeMinWidthSpec(int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MgFKkETIFAgQRKvT(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static void MgFKkETIFAgQRKvT(int i, int i2, float f, char c, java.lang.string str, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MgFKkETIFAgQRKvT(int i, int i2, float f, java.lang.string str, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MgFKkETIFAgQRKvT(int i, int i2, float f, short s, java.lang.string str, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NbCuCPVjrMIcWIcV(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view) {
        navigationRailobject.addHeaderobject(view);
    }

    public static void NbCuCPVjrMIcWIcV(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NbCuCPVjrMIcWIcV(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbCuCPVjrMIcWIcV(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, android.view.object view, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool OcbxCydYstiPMZgn(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void OcbxCydYstiPMZgn(bool z, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OcbxCydYstiPMZgn(bool z, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OcbxCydYstiPMZgn(bool z, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PGTABEbBChhMbxmg(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i) {
        navigationRailobject.setItemPaddingTop(i);
    }

    public static void PGTABEbBChhMbxmg(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, char c, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PGTABEbBChhMbxmg(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PGTABEbBChhMbxmg(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int QXBcyvliQLPyXxUq(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.getTop();
    }

    public static void QXBcyvliQLPyXxUq(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QXBcyvliQLPyXxUq(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QXBcyvliQLPyXxUq(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int QmxWGOgdgQqFSzan(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.getLeft();
    }

    public static void QmxWGOgdgQqFSzan(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QmxWGOgdgQqFSzan(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QmxWGOgdgQqFSzan(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldApplyWindowInsetPadding(java.lang.bool bool, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldApplyWindowInsetPadding(java.lang.bool bool, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldApplyWindowInsetPadding(java.lang.bool bool, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldApplyWindowInsetPadding(java.lang.bool bool) {
        return bool is null ? JryUGQwhgVukobqK(this) : TxGGRoVvRsGBsnOH(bool);
    }

    public static androidx.appcompat.view.menu.Menuobject SqSkamySSuQiLneT(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getMenuobject();
    }

    public static void SqSkamySSuQiLneT(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SqSkamySSuQiLneT(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SqSkamySSuQiLneT(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UCdjEhXmccbsctLR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCdjEhXmccbsctLR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCdjEhXmccbsctLR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UCdjEhXmccbsctLR(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.bool bool) {
        return navigationRailobject.shouldApplyWindowInsetPadding(bool);
    }

    public static void UYvynYmIUTrJfnDc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYvynYmIUTrJfnDc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UYvynYmIUTrJfnDc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool UYvynYmIUTrJfnDc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.isHeaderobjectVisible();
    }

    public static int UwEQDFEXWMObCfim(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void UwEQDFEXWMObCfim(int i, float f, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UwEQDFEXWMObCfim(int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UwEQDFEXWMObCfim(int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool VmaOMuMwKohsfsft(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void VmaOMuMwKohsfsft(bool z, byte b, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VmaOMuMwKohsfsft(bool z, float f, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VmaOMuMwKohsfsft(bool z, bool z2, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VneAAmFXseltLIIg(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i) {
        navigationRailMenuobject.setMenuGravity(i);
    }

    public static void VneAAmFXseltLIIg(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VneAAmFXseltLIIg(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VneAAmFXseltLIIg(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int VorhhzsvtazIRNzr(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.getMenuGravity();
    }

    public static void VorhhzsvtazIRNzr(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VorhhzsvtazIRNzr(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VorhhzsvtazIRNzr(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WGrnRjWLivZFrOCj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getItemPaddingBottom();
    }

    public static void WGrnRjWLivZFrOCj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WGrnRjWLivZFrOCj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WGrnRjWLivZFrOCj(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object XUPgPKIkHCcMteoN(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getobject();
    }

    public static void XUPgPKIkHCcMteoN(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XUPgPKIkHCcMteoN(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUPgPKIkHCcMteoN(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XirskqAKMOfkDcGc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i) {
        navigationRailobject.addHeaderobject(i);
    }

    public static void XirskqAKMOfkDcGc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XirskqAKMOfkDcGc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XirskqAKMOfkDcGc(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigationrail.NavigationRailMenuobject YSYyNnLJBOKNaTYB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getNavigationRailMenuobject();
    }

    public static void YSYyNnLJBOKNaTYB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSYyNnLJBOKNaTYB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSYyNnLJBOKNaTYB(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZGRyRrRhzBLthMjJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject) {
        return navigationRailMenuobject.getRight();
    }

    public static void ZGRyRrRhzBLthMjJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZGRyRrRhzBLthMjJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZGRyRrRhzBLthMjJ(com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobject, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources ZKoJCKvKIOgHijhY(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject) {
        return navigationRailobject.getResources();
    }

    public static void ZKoJCKvKIOgHijhY(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZKoJCKvKIOgHijhY(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZKoJCKvKIOgHijhY(com.google.android.material.navigationrail.NavigationRailobject navigationRailobject, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZMSBDngkoUAiopaU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMSBDngkoUAiopaU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMSBDngkoUAiopaU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool ZMSBDngkoUAiopaU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public void AddHeaderobject(int i) {
        if ((6 + 25) % 25 > 0) {
        }
        nbCuCPVjrMIcWIcV(this, dQpgbxzisehWXhRE(iVaxAobTRyynCgEJ(effyFZYCltGtNahF(this)), i, this, false));
    }

    public void AddHeaderobject(android.view.object view) {
        if ((22 + 25) % 25 > 0) {
        }
        FXZSDzPdrgPdpXyQ(this);
        this.headerobject = view;
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = new android.widget.FrameLayout$LayoutParams(-2, -2);
        frameLayout$LayoutParams.gravity = 49;
        frameLayout$LayoutParams.topMargin = this.topMargin;
        lcvIlDXymVUgvooi(this, view, 0, frameLayout$LayoutParams);
    }

    protected override com.google.android.material.navigation.NavigationBarMenuobject CreateNavigationBarMenuobject(android.content.object context) {
        return QLWuPKAroxKyDvMQ(this, context);
    }

    protected override com.google.android.material.navigationrail.NavigationRailMenuobject CreateNavigationBarMenuobject(android.content.object context) {
        return new com.google.android.material.navigationrail.NavigationRailMenuobject(context);
    }

    public android.view.object GetHeaderobject() {
        return this.headerobject;
    }

    public int GetItemMinimumHeight() {
        return jZDjLLJRkRbXOdhR((com.google.android.material.navigationrail.NavigationRailMenuobject) KARALuFegpsrgexP(this));
    }

    public override int GetMaxItemCount() {
        return 7;
    }

    public int GetMenuGravity() {
        return vorhhzsvtazIRNzr(ySYyNnLJBOKNaTYB(this));
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        faoMVEeGTLEaOGlo(this, z, i, i2, i3, i4);
        com.google.android.material.navigationrail.NavigationRailMenuobject navigationRailMenuobjectBvfASqYETZOIyBAm = bvfASqYETZOIyBAm(this);
        int i5 = 0;
        if (uYvynYmIUTrJfnDc(this)) {
            int iKfPLCYhlsqpjFrcr = kfPLCYhlsqpjFrcr(this.headerobject) + this.topMargin;
            int iQXBcyvliQLPyXxUq = qXBcyvliQLPyXxUq(navigationRailMenuobjectBvfASqYETZOIyBAm);
            if (iQXBcyvliQLPyXxUq < iKfPLCYhlsqpjFrcr) {
                i5 = iKfPLCYhlsqpjFrcr - iQXBcyvliQLPyXxUq;
            }
        } else if (QdzIdIuQWeDZLTWR(navigationRailMenuobjectBvfASqYETZOIyBAm)) {
            i5 = this.topMargin;
        }
        if (i5 <= 0) {
            return;
        }
        khGhqdAzoBetHDPJ(navigationRailMenuobjectBvfASqYETZOIyBAm, qmxWGOgdgQqFSzan(navigationRailMenuobjectBvfASqYETZOIyBAm), RxfQPwgMbuvbWYRY(navigationRailMenuobjectBvfASqYETZOIyBAm) + i5, zGRyRrRhzBLthMjJ(navigationRailMenuobjectBvfASqYETZOIyBAm), LKQKJwkGEJjNeujw(navigationRailMenuobjectBvfASqYETZOIyBAm) + i5);
    }

    protected override void OnMeasure(int i, int i2) {
        int iBJvaerJakblyFSom = bJvaerJakblyFSom(this, i);
        kKQkTetkyWMqhBRB(this, iBJvaerJakblyFSom, i2);
        if (CWJWMJOTOerxjZVj(this)) {
            FAXeGsgwOsvmOQwq(this, OyFMPUdmxiYqDhxw(this), iBJvaerJakblyFSom, BpQIWlftGkKxMlxX((csxnBGBbUORvasnj(this) - WrZRZtyNQRWVMnnq(this.headerobject)) - this.topMargin, int.MIN_VALUE));
        }
    }

    public void RemoveHeaderobject() {
        android.view.object view = this.headerobject;
        if (view is null) {
            return;
        }
        UwOUaNfEKbENbTuB(this, view);
        this.headerobject = null;
    }

    public void SetItemMinimumHeight(int i) {
        EKyWnJeiVrPrYZSs((com.google.android.material.navigationrail.NavigationRailMenuobject) fZoHMhqoxOHQVvuR(this), i);
    }

    public void SetMenuGravity(int i) {
        vneAAmFXseltLIIg(HYBYjHGxGDMDDVHX(this), i);
    }
}

