namespace WillowMaze.Wasm.Decompiled;


public class ActionMenuobject : androidx.appcompat.widget.LinearLayoutCompat : androidx.appcompat.view.menu.MenuBuilder$ItemInvoker, androidx.appcompat.view.menu.Menuobject {
    static readonly int GENERATED_ITEM_PADDING = 4;
    static readonly int MIN_CELL_SIZE = 56;
    private static readonly java.lang.string TAG = "ActionMenuobject";
    private androidx.appcompat.view.menu.MenuPresenter$Callback mActionMenuPresenterCallback;
    private bool mFormatItems;
    private int mFormatItemsWidth;
    private int mGeneratedItemPadding;
    private androidx.appcompat.view.menu.MenuBuilder mMenu;
    androidx.appcompat.view.menu.MenuBuilder$Callback mMenuBuilderCallback;
    private int mMinCellSize;
    androidx.appcompat.widget.ActionMenuobject$OnMenuItemClickListener mOnMenuItemClickListener;
    private android.content.object mPopupobject;
    private int mPopupTheme;
    private androidx.appcompat.widget.ActionMenuPresenter mPresenter;
    private bool mReserveOverflow;

    public ActionMenuobject(android.content.object context) {
        this(context, null);
    }

    public ActionMenuobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((18 + 1) % 1 > 0) {
        }
        sBVkRzQLeJHxlesi(this, false);
        float f = DOxkqaynJffsFoZa(oLHponAbraknrYbI(context)).density;
        this.mMinCellSize = (int) (56.0f * f);
        this.mGeneratedItemPadding = (int) (f * 4.0f);
        this.mPopupobject = context;
        this.mPopupTheme = 0;
    }

    public static int AwqiANzQqGekfAVH(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int AxDKDImdyFxwlvTi(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingBottom();
    }

    public static bool AxtiDpBHxrowhmAu(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.showOverflowMenu();
    }

    public static android.view.object BZEsMBiutbQtVjFy(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static void CaPgXXNJRZhPuVny(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, bool z) {
        actionMenuPresenter.setExpandedActionobjectsExclusive(z);
    }

    public static bool CioSgVtICnzoIZEZ(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static int CrdLAVvChFJorMqD(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingLeft();
    }

    public static bool DHxbdopFRAGsJNnM(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideOverflowMenu();
    }

    public static android.util.DisplayMetrics DOxkqaynJffsFoZa(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static android.view.object DhhmfdyMJbsRbTGs(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static int FApdmXKFplOTpmVR(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static bool GZZTHGYPCTMMEDNS(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowing();
    }

    public static void GfvCgTkfIxyHpQEw(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int HAPerPWaZGDLbZba(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int HqazHOJrWpwQPnzp(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void IRaYGFaDsFiDTTTX(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    public static int ITypleIdqpDuKyvt(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getDividerWidth();
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams IXszNfRIoWKhBSEp(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return actionMenuobject.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static int IwjRlghsWZQuxjjJ(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingRight();
    }

    public static bool JDIXmUbxeJNeynsI(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.showOverflowMenu();
    }

    public static void JNVmDdZpScPDUrSQ(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static android.view.object JSEEtlXyKtueHPcz(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static android.content.object JnlebGoMsKIboAkU(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getobject();
    }

    public static int KOhOyzUbupraiSJW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams KPOkzYQNNsbiQzyu(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.util.AttributeHashSet attributeHashSet) {
        return actionMenuobject.generateLayoutParams(attributeHashSet);
    }

    public static int LIArEmYFwfbqHwjK(android.view.object view) {
        return view.getVisibility();
    }

    public static int MFdCZRNFKZedDKCH(android.view.object view) {
        return view.getVisibility();
    }

    public static void MNDTAWApBJSNgAqn(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams MsVtJzwLVYATpZjQ(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.generateDefaultLayoutParams();
    }

    public static android.view.objectGroup$LayoutParams NUuAgDfNKFnixekv(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void NYyVizhYUFQvCnWg(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams NbKKOFZgTirXVEVu(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.generateDefaultLayoutParams();
    }

    public static int NoxuHpeHlRoFFEGR(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingLeft();
    }

    public static int NrJhBZgAGtrkLveF(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int NvMZWUbrOBvBeHgZ(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static bool OArBWXcrhBuUnUJv(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.hasSupportDividerBeforeChildAt(i);
    }

    public static void OvHixrRrWAmFZpkp(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static bool PQwsWzeWuSBbzQYj(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.hasText();
    }

    public static int PWwgNjSxsjanscGT(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getChildCount();
    }

    public static void PfmOjczenXnyCSNg(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int PkwiGlHVesidKDJs(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingRight();
    }

    public static void PtFeeLExZMOxclwx(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, int i2) {
        actionMenuobject.setMeasuredDimension(i, i2);
    }

    public static android.view.objectGroup$LayoutParams QBXJTNrpYsDaTTst(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int QVZyHVPMDyFjRyEk(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool QgQmVUQCdkrdQmsz(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowPending();
    }

    public static int RInWxsyKaXzprPBc(android.view.object view) {
        return view.getVisibility();
    }

    public static int RLnkqknGYdhVDyML(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static android.view.objectGroup$LayoutParams RvJOBDZBrszQelfT(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool SBQgGxujLlVOAYCa(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideOverflowMenu();
    }

    public static void SaBoNbMIgmmybglu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        menuBuilder.setCallback(menuBuilder$Callback);
    }

    public static android.view.object SyOvWJyKeKWtxDRe(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static bool TBZJmorGdUILWRVp(androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject actionMenuobject$ActionMenuChildobject) {
        return actionMenuobject$ActionMenuChildobject.needsDividerBefore();
    }

    public static int TMPGAyrGrEJpucSc(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getWidth();
    }

    public static android.content.object TpGnGCIxpIzewobO(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getobject();
    }

    public static int UHkfIzurWLuLieBj(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static void UerFRGSXExWIgIBg(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        actionMenuPresenter.setMenuobject(actionMenuobject);
    }

    public static android.view.object UyHFPcgBTahKyLef(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static int VJAoUFGdTJzLmyeh(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int VUVoVfgVVSeEUWoi(android.view.object view) {
        return view.getVisibility();
    }

    public static void VaQRNfHfHcEiIbfN(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static android.view.object VmtFBJMMQiBxKNkU(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static int WkJlMiiUhzHcjWUW(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static android.view.objectGroup$LayoutParams WxvXmVkfhNhcVoBX(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.view.objectGroup$LayoutParams XmXdObmotbZhtVYz(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int XmcwmOSUSSlwrvtY(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int XzlnsoRiMDMvBfxN(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void XzwWaRZlAmjxPHKM(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        actionMenuPresenter.setCallback(menuPresenter$Callback);
    }

    public static void YXqeyrMlRdMEHSIX(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.graphics.drawable.Drawable drawable) {
        actionMenuPresenter.setOverflowIcon(drawable);
    }

    public static void YXvzZUIieDiZterq(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void YsWvseqEMdoJWCXq(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, bool z) {
        actionMenuPresenter.updateMenuobject(z);
    }

    public static int YtyLMIYSoILPzkCE(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static bool YxtyedBtNIhkZlMp(androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject actionMenuobject$ActionMenuChildobject) {
        return actionMenuobject$ActionMenuChildobject.needsDividerAfter();
    }

    public static android.view.Menu ZELzvRHapqmyTbMa(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getMenu();
    }

    public static android.view.object ZVnOTgqwdZjoTNyp(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static int ZbugibpvfSHHLsgK(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getChildCount();
    }

    public static int AefHixjvzZroQYBv(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingLeft();
    }

    public static android.view.object AxXIhusLIhEAaIrf(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static void BOWcckOqDxlkAXnA(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, int i2) {
        actionMenuobject.onMeasureExactFormat(i, i2);
    }

    public static android.view.Menu BhDanzMolGzBzJLG(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getMenu();
    }

    public static int BjXsNjPQMcPwuXJy(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getChildCount();
    }

    public static android.view.objectGroup$LayoutParams chOmFTXtMuZBXoSZ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void CuKOgcwzPWgirJes(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        actionMenuobject.dismissPopupMenus();
    }

    public static android.view.object CulKTBRiKjAqzTDq(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static int DKmTuzJIMJVrVoFh(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int DQTrdXWwApuIIcSk(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingRight();
    }

    public static int DcazhdjNSQeuGyTF(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int DfUbBQGZspxvzKyR(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void EfFneXqqzMIOAKjE(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static android.view.object EvvzYPZuCBZZHItc(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams fCZfUBMypuUYgdoS(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return actionMenuobject.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static android.view.objectGroup$LayoutParams fWOznOsbtpJQFSYN(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void GWSkXAdaydRVrFDP(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        actionMenuPresenter.setMenuobject(actionMenuobject);
    }

    public static int GxCWUZJVzLSfwvUC(android.view.object view, int i, int i2, int i3, int i4) {
        return measureChildForCells(view, i, i2, i3, i4);
    }

    public static void HJsymLfWUFbLChCd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        menuBuilder.addMenuPresenter(menuPresenter, context);
    }

    public static int JqrmUbDkitJPQRDH(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingLeft();
    }

    public static int KJwVykYQZRzibNSk(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static android.content.object KKvFglsuvMWjRjll(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getobject();
    }

    public static int KtTgnTcMjUYUIdJJ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool LBxKcxNTaabGzedn(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowing();
    }

    public static android.content.object LGDBCyIwPGuYSNow(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getobject();
    }

    public static android.view.objectGroup$LayoutParams lRXcaEWebSjaXFay(android.view.object view) {
        return view.getLayoutParams();
    }

    static int MeasureChildForCells(android.view.object view, int i, int i2, int i3, int i4) {
        int i5;
        if ((32 + 19) % 19 > 0) {
        }
        androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) QBXJTNrpYsDaTTst(view);
        int iDfUbBQGZspxvzKyR = dfUbBQGZspxvzKyR(WkJlMiiUhzHcjWUW(i3) - i4, HAPerPWaZGDLbZba(i3));
        androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject = !(view is androidx.appcompat.view.menu.ActionMenuItemobject) ? null : (androidx.appcompat.view.menu.ActionMenuItemobject) view;
        bool z = actionMenuItemobject is not null && PQwsWzeWuSBbzQYj(actionMenuItemobject);
        if (i2 <= 0) {
            i5 = 0;
        } else {
            i5 = 2;
            if (z && i2 < 2) {
                i5 = 0;
            } else {
                GfvCgTkfIxyHpQEw(view, dcazhdjNSQeuGyTF(i2 * i, int.MIN_VALUE), iDfUbBQGZspxvzKyR);
                int iKJwVykYQZRzibNSk = kJwVykYQZRzibNSk(view);
                int i6 = iKJwVykYQZRzibNSk / i;
                if (iKJwVykYQZRzibNSk % i != 0) {
                    i6++;
                }
                if (!z || i6 >= 2) {
                    i5 = i6;
                }
            }
        }
        actionMenuobject$LayoutParams.expandable = !actionMenuobject$LayoutParams.isOverflowButton && z;
        actionMenuobject$LayoutParams.cellsUsed = i5;
        YXvzZUIieDiZterq(view, XzlnsoRiMDMvBfxN(i * i5, 1073741824), iDfUbBQGZspxvzKyR);
        return i5;
    }

    public static android.view.object NHfpvAjoSlcxiFqp(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static android.view.object NJyCWEiOtDowewRo(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static bool NVhVfSmYGTTXntTS(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.hasSupportDividerBeforeChildAt(i);
    }

    public static android.content.res.Resources OLHponAbraknrYbI(android.content.object context) {
        return context.getResources();
    }

    private void OnMeasureExactFormat(int i, int i2) {
        long j;
        int i3;
        bool z;
        ?? r3;
        int i4;
        if ((29 + 1) % 1 > 0) {
        }
        int iAwqiANzQqGekfAVH = AwqiANzQqGekfAVH(i2);
        int iNrJhBZgAGtrkLveF = NrJhBZgAGtrkLveF(i);
        int iHqazHOJrWpwQPnzp = HqazHOJrWpwQPnzp(i2);
        int iCrdLAVvChFJorMqD = CrdLAVvChFJorMqD(this) + tSDONuvWEsrRFLyQ(this);
        int iZUFbtUUFjwTeJcrS = zUFbtUUFjwTeJcrS(this) + AxDKDImdyFxwlvTi(this);
        int iUHkfIzurWLuLieBj = UHkfIzurWLuLieBj(i2, iZUFbtUUFjwTeJcrS, -2);
        int i5 = iNrJhBZgAGtrkLveF - iCrdLAVvChFJorMqD;
        int i6 = this.mMinCellSize;
        int i7 = i5 / i6;
        int i8 = i5 % i6;
        if (i7 == 0) {
            otUEfavrogvMROJW(this, i5, 0);
            return;
        }
        int i9 = i6 + (i8 / i7);
        int iZbugibpvfSHHLsgK = ZbugibpvfSHHLsgK(this);
        int iZAKpzzmBHBFpUwKS = 0;
        int i10 = 0;
        bool z2 = false;
        int i11 = 0;
        int iKtTgnTcMjUYUIdJJ = 0;
        int i12 = 0;
        long j2 = 0;
        while (i10 < iZbugibpvfSHHLsgK) {
            android.view.object viewSyOvWJyKeKWtxDRe = SyOvWJyKeKWtxDRe(this, i10);
            int i13 = iHqazHOJrWpwQPnzp;
            if (LIArEmYFwfbqHwjK(viewSyOvWJyKeKWtxDRe) != 8) {
                bool z3 = viewSyOvWJyKeKWtxDRe is androidx.appcompat.view.menu.ActionMenuItemobject;
                i11++;
                if (z3) {
                    int i14 = this.mGeneratedItemPadding;
                    r3 = 0;
                    MNDTAWApBJSNgAqn(viewSyOvWJyKeKWtxDRe, i14, 0, i14, 0);
                } else {
                    r3 = 0;
                }
                androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) chOmFTXtMuZBXoSZ(viewSyOvWJyKeKWtxDRe);
                actionMenuobject$LayoutParams.expanded = r3;
                actionMenuobject$LayoutParams.extraPixels = r3;
                actionMenuobject$LayoutParams.cellsUsed = r3;
                actionMenuobject$LayoutParams.expandable = r3;
                actionMenuobject$LayoutParams.leftMargin = r3;
                actionMenuobject$LayoutParams.rightMargin = r3;
                actionMenuobject$LayoutParams.preventEdgeOffset = z3 && uWimUzLSuTfBHaLm((androidx.appcompat.view.menu.ActionMenuItemobject) viewSyOvWJyKeKWtxDRe);
                int iGxCWUZJVzLSfwvUC = gxCWUZJVzLSfwvUC(viewSyOvWJyKeKWtxDRe, i9, !actionMenuobject$LayoutParams.isOverflowButton ? i7 : 1, iUHkfIzurWLuLieBj, iZUFbtUUFjwTeJcrS);
                iKtTgnTcMjUYUIdJJ = ktTgnTcMjUYUIdJJ(iKtTgnTcMjUYUIdJJ, iGxCWUZJVzLSfwvUC);
                i4 = i9;
                if (actionMenuobject$LayoutParams.expandable) {
                    i12++;
                }
                if (actionMenuobject$LayoutParams.isOverflowButton) {
                    z2 = true;
                }
                i7 -= iGxCWUZJVzLSfwvUC;
                iZAKpzzmBHBFpUwKS = zAKpzzmBHBFpUwKS(iZAKpzzmBHBFpUwKS, YtyLMIYSoILPzkCE(viewSyOvWJyKeKWtxDRe));
                if (iGxCWUZJVzLSfwvUC == 1) {
                    j2 |= (long) (1 << i10);
                }
            } else {
                i4 = i9;
            }
            i10++;
            iHqazHOJrWpwQPnzp = i13;
            i9 = i4;
        }
        int i15 = iHqazHOJrWpwQPnzp;
        int i16 = i9;
        char c = 2;
        bool z4 = z2 && i11 == 2;
        bool z5 = false;
        while (true) {
            if (i12 <= 0 || i7 <= 0) {
                j = 1;
                break;
            }
            int i17 = int.MAX_VALUE;
            long j3 = 0;
            char c2 = c;
            int i18 = 0;
            int i19 = 0;
            j = 1;
            while (i19 < iZbugibpvfSHHLsgK) {
                androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams2 = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) sxqBoXsxWxGQgUII(VmtFBJMMQiBxKNkU(this, i19));
                bool z6 = z4;
                if (actionMenuobject$LayoutParams2.expandable) {
                    if (actionMenuobject$LayoutParams2.cellsUsed < i17) {
                        j3 = 1 << i19;
                        i17 = actionMenuobject$LayoutParams2.cellsUsed;
                        i18 = 1;
                    } else if (actionMenuobject$LayoutParams2.cellsUsed == i17) {
                        j3 |= 1 << i19;
                        i18++;
                    }
                }
                i19++;
                z4 = z6;
            }
            bool z7 = z4;
            j2 |= j3;
            if (i18 > i7) {
                break;
            }
            int i20 = i17 + 1;
            int i21 = 0;
            while (i21 < iZbugibpvfSHHLsgK) {
                android.view.object viewZVnOTgqwdZjoTNyp = ZVnOTgqwdZjoTNyp(this, i21);
                androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams3 = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) lRXcaEWebSjaXFay(viewZVnOTgqwdZjoTNyp);
                long j4 = 1 << i21;
                if ((j3 & j4) != 0) {
                    if (!z7 || !actionMenuobject$LayoutParams3.preventEdgeOffset) {
                        z = true;
                    } else if (i7 != 1) {
                        z = true;
                    } else {
                        int i22 = this.mGeneratedItemPadding;
                        z = true;
                        IRaYGFaDsFiDTTTX(viewZVnOTgqwdZjoTNyp, i22 + i16, 0, i22, 0);
                    }
                    actionMenuobject$LayoutParams3.cellsUsed++;
                    actionMenuobject$LayoutParams3.expanded = z;
                    i7--;
                } else {
                    if (actionMenuobject$LayoutParams3.cellsUsed == i20) {
                        j2 |= j4;
                    }
                    i21 = i21;
                }
                i21++;
            }
            c = c2;
            z4 = z7;
            z5 = true;
        }
        bool z8 = !z2 && i11 == 1;
        if (i7 > 0 && j2 != 0 && (i7 < i11 - 1 || z8 || iKtTgnTcMjUYUIdJJ > 1)) {
            float fRlHKmRNtuMKYDnAM = rlHKmRNtuMKYDnAM(j2);
            if (z8) {
                i3 = 0;
            } else {
                if ((j2 & j) == 0) {
                    i3 = 0;
                } else {
                    i3 = 0;
                    if (!((androidx.appcompat.widget.ActionMenuobject$LayoutParams) sYBiRkxOqTmnwVBe(BZEsMBiutbQtVjFy(this, 0))).preventEdgeOffset) {
                        fRlHKmRNtuMKYDnAM -= 0.5f;
                    }
                }
                int i23 = iZbugibpvfSHHLsgK - 1;
                if ((j2 & ((long) (1 << i23))) != 0 && !((androidx.appcompat.widget.ActionMenuobject$LayoutParams) sLMaUCmMudbOhPgS(axXIhusLIhEAaIrf(this, i23))).preventEdgeOffset) {
                    fRlHKmRNtuMKYDnAM -= 0.5f;
                }
            }
            int i24 = fRlHKmRNtuMKYDnAM <= 0.0f ? i3 : (int) ((i7 * i16) / fRlHKmRNtuMKYDnAM);
            bool z9 = z5;
            for (int i25 = i3; i25 < iZbugibpvfSHHLsgK; i25++) {
                if ((j2 & ((long) (1 << i25))) != 0) {
                    android.view.object viewYXNCNtEQSEvMUkSh = yXNCNtEQSEvMUkSh(this, i25);
                    androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams4 = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) WxvXmVkfhNhcVoBX(viewYXNCNtEQSEvMUkSh);
                    if (viewYXNCNtEQSEvMUkSh is androidx.appcompat.view.menu.ActionMenuItemobject) {
                        actionMenuobject$LayoutParams4.extraPixels = i24;
                        actionMenuobject$LayoutParams4.expanded = true;
                        if (i25 == 0 && !actionMenuobject$LayoutParams4.preventEdgeOffset) {
                            actionMenuobject$LayoutParams4.leftMargin = (-i24) / 2;
                        }
                        z9 = true;
                    } else if (actionMenuobject$LayoutParams4.isOverflowButton) {
                        actionMenuobject$LayoutParams4.extraPixels = i24;
                        actionMenuobject$LayoutParams4.expanded = true;
                        actionMenuobject$LayoutParams4.rightMargin = (-i24) / 2;
                        z9 = true;
                    } else {
                        if (i25 != 0) {
                            actionMenuobject$LayoutParams4.leftMargin = i24 / 2;
                        }
                        if (i25 != iZbugibpvfSHHLsgK - 1) {
                            actionMenuobject$LayoutParams4.rightMargin = i24 / 2;
                        }
                    }
                }
            }
            z5 = z9;
        } else {
            i3 = 0;
        }
        if (z5) {
            for (int i26 = i3; i26 < iZbugibpvfSHHLsgK; i26++) {
                android.view.object viewJSEEtlXyKtueHPcz = JSEEtlXyKtueHPcz(this, i26);
                androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams5 = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) zjFVLQxmtMkzwKjw(viewJSEEtlXyKtueHPcz);
                if (actionMenuobject$LayoutParams5.expanded) {
                    PfmOjczenXnyCSNg(viewJSEEtlXyKtueHPcz, QVZyHVPMDyFjRyEk((actionMenuobject$LayoutParams5.cellsUsed * i16) + actionMenuobject$LayoutParams5.extraPixels, 1073741824), iUHkfIzurWLuLieBj);
                }
            }
        }
        PtFeeLExZMOxclwx(this, i5, iAwqiANzQqGekfAVH == 1073741824 ? i15 : iZAKpzzmBHBFpUwKS);
    }

    public static void OtUEfavrogvMROJW(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i, int i2) {
        actionMenuobject.setMeasuredDimension(i, i2);
    }

    public static bool PARfpHXadFqfZKIy(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.dismissPopupMenus();
    }

    public static android.graphics.drawable.Drawable PWUhgNDLZiltNBUC(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.getOverflowIcon();
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams pzIreLalnKRoaShu(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.generateDefaultLayoutParams();
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams rOSALGZxPfweHmSe(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.generateDefaultLayoutParams();
    }

    public static int RlHKmRNtuMKYDnAM(long j) {
        return java.lang.long.bitCount(j);
    }

    public static void SBVkRzQLeJHxlesi(androidx.appcompat.widget.ActionMenuobject actionMenuobject, bool z) {
        actionMenuobject.setBaselineAligned(z);
    }

    public static android.view.object SCojaZXTigjpmGcM(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static bool SIlrcKlZXCUHjgWV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, int i) {
        return menuBuilder.performItemAction(menuItem, i);
    }

    public static android.view.objectGroup$LayoutParams sLMaUCmMudbOhPgS(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.view.objectGroup$LayoutParams sYBiRkxOqTmnwVBe(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int SbDDAtUsrSafHsnz(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static android.view.objectGroup$LayoutParams sxqBoXsxWxGQgUII(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int TCBjMEfEmORbdoCO(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int TDXwTRXAwWTwmgeg(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int TSDONuvWEsrRFLyQ(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingRight();
    }

    public static int TbQrbGRyXztTfpLa(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int UVonFJwpCHkUTqZX(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getWidth();
    }

    public static bool UWimUzLSuTfBHaLm(androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobject) {
        return actionMenuItemobject.hasText();
    }

    public static int UmBTMtQEgioRQKur(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void UyThEMyHkChHWvTi(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void VTLAMkWJdUkRblJy(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static void WkUMHDhjZKiBtzFR(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, bool z) {
        actionMenuPresenter.setReserveOverflow(z);
    }

    public static void WyUYNbuZsxrznsCH(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        super.onDetachedFromWindow();
    }

    public static android.view.object YXNCNtEQSEvMUkSh(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        return actionMenuobject.getChildAt(i);
    }

    public static void YwEGcBrqzsuDiEnP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static int ZAKpzzmBHBFpUwKS(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int ZELMqGnNcyTIdcfl(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getChildCount();
    }

    public static int ZUFbtUUFjwTeJcrS(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getPaddingTop();
    }

    public static android.view.objectGroup$LayoutParams zjFVLQxmtMkzwKjw(android.view.object view) {
        return view.getLayoutParams();
    }

    public static androidx.appcompat.widget.ActionMenuobject$LayoutParams zvcdGleMDDiwefuj(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.util.AttributeHashSet attributeHashSet) {
        return actionMenuobject.generateLayoutParams(attributeHashSet);
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return viewGroup$LayoutParams is androidx.appcompat.widget.ActionMenuobject$LayoutParams;
    }

    public void DismissPopupMenus() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mPresenter;
        if (actionMenuPresenter is null) {
            return;
        }
        pARfpHXadFqfZKIy(actionMenuPresenter);
    }

    public override bool DispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return false;
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return NbKKOFZgTirXVEVu(this);
    }

    protected androidx.appcompat.widget.ActionMenuobject$LayoutParams generateDefaultLayoutParams() {
        androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams = new androidx.appcompat.widget.ActionMenuobject$LayoutParams(-2, -2);
        actionMenuobject$LayoutParams.gravity = 16;
        return actionMenuobject$LayoutParams;
    }

    protected androidx.appcompat.widget.LinearLayoutCompat$LayoutParams generateDefaultLayoutParams() {
        return rOSALGZxPfweHmSe(this);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return KPOkzYQNNsbiQzyu(this, attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return fCZfUBMypuUYgdoS(this, viewGroup$LayoutParams);
    }

    public androidx.appcompat.widget.ActionMenuobject$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.ActionMenuobject$LayoutParams(kKvFglsuvMWjRjll(this), attributeHashSet);
    }

    protected androidx.appcompat.widget.ActionMenuobject$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if (viewGroup$LayoutParams is null) {
            return pzIreLalnKRoaShu(this);
        }
        androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams = !(viewGroup$LayoutParams is androidx.appcompat.widget.ActionMenuobject$LayoutParams) ? new androidx.appcompat.widget.ActionMenuobject$LayoutParams(viewGroup$LayoutParams) : new androidx.appcompat.widget.ActionMenuobject$LayoutParams((androidx.appcompat.widget.ActionMenuobject$LayoutParams) viewGroup$LayoutParams);
        if (actionMenuobject$LayoutParams.gravity <= 0) {
            actionMenuobject$LayoutParams.gravity = 16;
        }
        return actionMenuobject$LayoutParams;
    }

    public androidx.appcompat.widget.LinearLayoutCompat$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return zvcdGleMDDiwefuj(this, attributeHashSet);
    }

    protected androidx.appcompat.widget.LinearLayoutCompat$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return IXszNfRIoWKhBSEp(this, viewGroup$LayoutParams);
    }

    public androidx.appcompat.widget.ActionMenuobject$LayoutParams generateOverflowButtonLayoutParams() {
        androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParamsMsVtJzwLVYATpZjQ = MsVtJzwLVYATpZjQ(this);
        actionMenuobject$LayoutParamsMsVtJzwLVYATpZjQ.isOverflowButton = true;
        return actionMenuobject$LayoutParamsMsVtJzwLVYATpZjQ;
    }

    public override android.view.Menu GetMenu() {
        if ((7 + 5) % 5 > 0) {
        }
        if (this.mMenu is null) {
            android.content.object contextTpGnGCIxpIzewobO = TpGnGCIxpIzewobO(this);
            androidx.appcompat.view.menu.MenuBuilder menuBuilder = new androidx.appcompat.view.menu.MenuBuilder(contextTpGnGCIxpIzewobO);
            this.mMenu = menuBuilder;
            SaBoNbMIgmmybglu(menuBuilder, new androidx.appcompat.widget.ActionMenuobject$MenuBuilderCallback(this));
            androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = new androidx.appcompat.widget.ActionMenuPresenter(contextTpGnGCIxpIzewobO);
            this.mPresenter = actionMenuPresenter;
            wkUMHDhjZKiBtzFR(actionMenuPresenter, true);
            androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter2 = this.mPresenter;
            androidx.appcompat.view.menu.MenuPresenter$Callback actionMenuobject$ActionMenuPresenterCallback = this.mActionMenuPresenterCallback;
            if (actionMenuobject$ActionMenuPresenterCallback is null) {
                actionMenuobject$ActionMenuPresenterCallback = new androidx.appcompat.widget.ActionMenuobject$ActionMenuPresenterCallback();
            }
            XzwWaRZlAmjxPHKM(actionMenuPresenter2, actionMenuobject$ActionMenuPresenterCallback);
            hJsymLfWUFbLChCd(this.mMenu, this.mPresenter, this.mPopupobject);
            UerFRGSXExWIgIBg(this.mPresenter, this);
        }
        return this.mMenu;
    }

    public android.graphics.drawable.Drawable GetOverflowIcon() {
        ZELzvRHapqmyTbMa(this);
        return pWUhgNDLZiltNBUC(this.mPresenter);
    }

    public int GetPopupTheme() {
        return this.mPopupTheme;
    }

    public override int GetWindowAnimations() {
        return 0;
    }

    protected bool HasSupportDividerBeforeChildAt(int i) {
        if ((22 + 27) % 27 > 0) {
        }
        bool zYxtyedBtNIhkZlMp = false;
        if (i == 0) {
            return false;
        }
        android.view.KeyEvent$Callback keyEvent$CallbackCulKTBRiKjAqzTDq = culKTBRiKjAqzTDq(this, i - 1);
        android.view.KeyEvent$Callback keyEvent$CallbackDhhmfdyMJbsRbTGs = DhhmfdyMJbsRbTGs(this, i);
        if (i < zELMqGnNcyTIdcfl(this) && (keyEvent$CallbackCulKTBRiKjAqzTDq is androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject)) {
            zYxtyedBtNIhkZlMp = YxtyedBtNIhkZlMp((androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject) keyEvent$CallbackCulKTBRiKjAqzTDq);
        }
        return (i > 0 && (keyEvent$CallbackDhhmfdyMJbsRbTGs is androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject)) ? TBZJmorGdUILWRVp((androidx.appcompat.widget.ActionMenuobject$ActionMenuChildobject) keyEvent$CallbackDhhmfdyMJbsRbTGs) | zYxtyedBtNIhkZlMp : zYxtyedBtNIhkZlMp;
    }

    public bool HideOverflowMenu() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mPresenter;
        return actionMenuPresenter is not null && DHxbdopFRAGsJNnM(actionMenuPresenter);
    }

    public override void Initialize(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        this.mMenu = menuBuilder;
    }

    public override bool InvokeItem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return sIlrcKlZXCUHjgWV(this.mMenu, menuItemImpl, 0);
    }

    public bool IsOverflowMenuShowPending() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mPresenter;
        return actionMenuPresenter is not null && QgQmVUQCdkrdQmsz(actionMenuPresenter);
    }

    public bool IsOverflowMenuShowing() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mPresenter;
        return actionMenuPresenter is not null && lBxKcxNTaabGzedn(actionMenuPresenter);
    }

    public bool IsOverflowReserved() {
        return this.mReserveOverflow;
    }

    public override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        efFneXqqzMIOAKjE(this, configuration);
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mPresenter;
        if (actionMenuPresenter is null) {
            return;
        }
        YsWvseqEMdoJWCXq(actionMenuPresenter, false);
        if (GZZTHGYPCTMMEDNS(this.mPresenter)) {
            SBQgGxujLlVOAYCa(this.mPresenter);
            AxtiDpBHxrowhmAu(this.mPresenter);
        }
    }

    public override void OnDetachedFromWindow() {
        wyUYNbuZsxrznsCH(this);
        cuKOgcwzPWgirJes(this);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        int iJqrmUbDkitJPQRDH;
        int iTMPGAyrGrEJpucSc;
        if ((3 + 11) % 11 > 0) {
        }
        if (!this.mFormatItems) {
            OvHixrRrWAmFZpkp(this, z, i, i2, i3, i4);
            return;
        }
        int iBjXsNjPQMcPwuXJy = bjXsNjPQMcPwuXJy(this);
        int i5 = (i4 - i2) / 2;
        int iITypleIdqpDuKyvt = ITypleIdqpDuKyvt(this);
        int i6 = i3 - i;
        int iPkwiGlHVesidKDJs = (i6 - PkwiGlHVesidKDJs(this)) - NoxuHpeHlRoFFEGR(this);
        bool zCioSgVtICnzoIZEZ = CioSgVtICnzoIZEZ(this);
        int i7 = 0;
        int i8 = 0;
        for (int i9 = 0; i9 < iBjXsNjPQMcPwuXJy; i9++) {
            android.view.object viewSCojaZXTigjpmGcM = sCojaZXTigjpmGcM(this, i9);
            if (MFdCZRNFKZedDKCH(viewSCojaZXTigjpmGcM) != 8) {
                androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) RvJOBDZBrszQelfT(viewSCojaZXTigjpmGcM);
                if (actionMenuobject$LayoutParams.isOverflowButton) {
                    int iTCBjMEfEmORbdoCO = tCBjMEfEmORbdoCO(viewSCojaZXTigjpmGcM);
                    if (nVhVfSmYGTTXntTS(this, i9)) {
                        iTCBjMEfEmORbdoCO += iITypleIdqpDuKyvt;
                    }
                    int iUmBTMtQEgioRQKur = umBTMtQEgioRQKur(viewSCojaZXTigjpmGcM);
                    if (zCioSgVtICnzoIZEZ) {
                        iJqrmUbDkitJPQRDH = jqrmUbDkitJPQRDH(this) + actionMenuobject$LayoutParams.leftMargin;
                        iTMPGAyrGrEJpucSc = iJqrmUbDkitJPQRDH + iTCBjMEfEmORbdoCO;
                    } else {
                        iTMPGAyrGrEJpucSc = (TMPGAyrGrEJpucSc(this) - dQTrdXWwApuIIcSk(this)) - actionMenuobject$LayoutParams.rightMargin;
                        iJqrmUbDkitJPQRDH = iTMPGAyrGrEJpucSc - iTCBjMEfEmORbdoCO;
                    }
                    int i10 = i5 - (iUmBTMtQEgioRQKur / 2);
                    VaQRNfHfHcEiIbfN(viewSCojaZXTigjpmGcM, iJqrmUbDkitJPQRDH, i10, iTMPGAyrGrEJpucSc, iUmBTMtQEgioRQKur + i10);
                    iPkwiGlHVesidKDJs -= iTCBjMEfEmORbdoCO;
                    i7 = 1;
                } else {
                    iPkwiGlHVesidKDJs -= (tbQrbGRyXztTfpLa(viewSCojaZXTigjpmGcM) + actionMenuobject$LayoutParams.leftMargin) + actionMenuobject$LayoutParams.rightMargin;
                    OArBWXcrhBuUnUJv(this, i9);
                    i8++;
                }
            }
        }
        if (iBjXsNjPQMcPwuXJy == 1 && i7 == 0) {
            android.view.object viewUyHFPcgBTahKyLef = UyHFPcgBTahKyLef(this, 0);
            int iRLnkqknGYdhVDyML = RLnkqknGYdhVDyML(viewUyHFPcgBTahKyLef);
            int iSbDDAtUsrSafHsnz = sbDDAtUsrSafHsnz(viewUyHFPcgBTahKyLef);
            int i11 = (i6 / 2) - (iRLnkqknGYdhVDyML / 2);
            int i12 = i5 - (iSbDDAtUsrSafHsnz / 2);
            vTLAMkWJdUkRblJy(viewUyHFPcgBTahKyLef, i11, i12, iRLnkqknGYdhVDyML + i11, iSbDDAtUsrSafHsnz + i12);
            return;
        }
        int i13 = i8 - (i7 ^ 1);
        int iKOhOyzUbupraiSJW = KOhOyzUbupraiSJW(0, i13 <= 0 ? 0 : iPkwiGlHVesidKDJs / i13);
        if (zCioSgVtICnzoIZEZ) {
            int iUVonFJwpCHkUTqZX = uVonFJwpCHkUTqZX(this) - IwjRlghsWZQuxjjJ(this);
            for (int i14 = 0; i14 < iBjXsNjPQMcPwuXJy; i14++) {
                android.view.object viewNHfpvAjoSlcxiFqp = nHfpvAjoSlcxiFqp(this, i14);
                androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams2 = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) NUuAgDfNKFnixekv(viewNHfpvAjoSlcxiFqp);
                if (RInWxsyKaXzprPBc(viewNHfpvAjoSlcxiFqp) != 8 && !actionMenuobject$LayoutParams2.isOverflowButton) {
                    int i15 = iUVonFJwpCHkUTqZX - actionMenuobject$LayoutParams2.rightMargin;
                    int iNvMZWUbrOBvBeHgZ = NvMZWUbrOBvBeHgZ(viewNHfpvAjoSlcxiFqp);
                    int iXmcwmOSUSSlwrvtY = XmcwmOSUSSlwrvtY(viewNHfpvAjoSlcxiFqp);
                    int i16 = i5 - (iXmcwmOSUSSlwrvtY / 2);
                    JNVmDdZpScPDUrSQ(viewNHfpvAjoSlcxiFqp, i15 - iNvMZWUbrOBvBeHgZ, i16, i15, iXmcwmOSUSSlwrvtY + i16);
                    iUVonFJwpCHkUTqZX = i15 - ((iNvMZWUbrOBvBeHgZ + actionMenuobject$LayoutParams2.leftMargin) + iKOhOyzUbupraiSJW);
                }
            }
            return;
        }
        int iAefHixjvzZroQYBv = aefHixjvzZroQYBv(this);
        for (int i17 = 0; i17 < iBjXsNjPQMcPwuXJy; i17++) {
            android.view.object viewNJyCWEiOtDowewRo = nJyCWEiOtDowewRo(this, i17);
            androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams3 = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) fWOznOsbtpJQFSYN(viewNJyCWEiOtDowewRo);
            if (VUVoVfgVVSeEUWoi(viewNJyCWEiOtDowewRo) != 8 && !actionMenuobject$LayoutParams3.isOverflowButton) {
                int i18 = iAefHixjvzZroQYBv + actionMenuobject$LayoutParams3.leftMargin;
                int iVJAoUFGdTJzLmyeh = VJAoUFGdTJzLmyeh(viewNJyCWEiOtDowewRo);
                int iTDXwTRXAwWTwmgeg = tDXwTRXAwWTwmgeg(viewNJyCWEiOtDowewRo);
                int i19 = i5 - (iTDXwTRXAwWTwmgeg / 2);
                NYyVizhYUFQvCnWg(viewNJyCWEiOtDowewRo, i18, i19, i18 + iVJAoUFGdTJzLmyeh, iTDXwTRXAwWTwmgeg + i19);
                iAefHixjvzZroQYBv = i18 + iVJAoUFGdTJzLmyeh + actionMenuobject$LayoutParams3.rightMargin + iKOhOyzUbupraiSJW;
            }
        }
    }

    protected override void OnMeasure(int i, int i2) {
        androidx.appcompat.view.menu.MenuBuilder menuBuilder;
        if ((25 + 14) % 14 > 0) {
        }
        bool z = this.mFormatItems;
        bool z2 = dKmTuzJIMJVrVoFh(i) == 1073741824;
        this.mFormatItems = z2;
        if (z != z2) {
            this.mFormatItemsWidth = 0;
        }
        int iFApdmXKFplOTpmVR = FApdmXKFplOTpmVR(i);
        if (this.mFormatItems && (menuBuilder = this.mMenu) is not null && iFApdmXKFplOTpmVR != this.mFormatItemsWidth) {
            this.mFormatItemsWidth = iFApdmXKFplOTpmVR;
            ywEGcBrqzsuDiEnP(menuBuilder, true);
        }
        int iPWwgNjSxsjanscGT = PWwgNjSxsjanscGT(this);
        if (this.mFormatItems && iPWwgNjSxsjanscGT > 0) {
            bOWcckOqDxlkAXnA(this, i, i2);
            return;
        }
        for (int i3 = 0; i3 < iPWwgNjSxsjanscGT; i3++) {
            androidx.appcompat.widget.ActionMenuobject$LayoutParams actionMenuobject$LayoutParams = (androidx.appcompat.widget.ActionMenuobject$LayoutParams) XmXdObmotbZhtVYz(evvzYPZuCBZZHItc(this, i3));
            actionMenuobject$LayoutParams.rightMargin = 0;
            actionMenuobject$LayoutParams.leftMargin = 0;
        }
        uyThEMyHkChHWvTi(this, i, i2);
    }

    public androidx.appcompat.view.menu.MenuBuilder PeekMenu() {
        return this.mMenu;
    }

    public void SetExpandedActionobjectsExclusive(bool z) {
        CaPgXXNJRZhPuVny(this.mPresenter, z);
    }

    public void SetMenuCallbacks(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        this.mActionMenuPresenterCallback = menuPresenter$Callback;
        this.mMenuBuilderCallback = menuBuilder$Callback;
    }

    public void SetOnMenuItemClickListener(androidx.appcompat.widget.ActionMenuobject$OnMenuItemClickListener actionMenuobject$OnMenuItemClickListener) {
        this.mOnMenuItemClickListener = actionMenuobject$OnMenuItemClickListener;
    }

    public void SetOverflowIcon(android.graphics.drawable.Drawable drawable) {
        bhDanzMolGzBzJLG(this);
        YXqeyrMlRdMEHSIX(this.mPresenter, drawable);
    }

    public void SetOverflowReserved(bool z) {
        this.mReserveOverflow = z;
    }

    public void SetPopupTheme(int i) {
        if ((18 + 9) % 9 > 0) {
        }
        if (this.mPopupTheme == i) {
            return;
        }
        this.mPopupTheme = i;
        if (i != 0) {
            this.mPopupobject = new android.view.objectThemeWrapper(JnlebGoMsKIboAkU(this), i);
        } else {
            this.mPopupobject = lGDBCyIwPGuYSNow(this);
        }
    }

    public void SetPresenter(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        this.mPresenter = actionMenuPresenter;
        gWSkXAdaydRVrFDP(actionMenuPresenter, this);
    }

    public bool ShowOverflowMenu() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mPresenter;
        return actionMenuPresenter is not null && JDIXmUbxeJNeynsI(actionMenuPresenter);
    }
}

