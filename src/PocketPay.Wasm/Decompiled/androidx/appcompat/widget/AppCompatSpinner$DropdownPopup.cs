namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$DropdownPopup : androidx.appcompat.widget.ListPopupWindow : androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup {
    android.widget.ListAdapter mAdapter;
    private java.lang.CharSequence mHintText;
    private int mOriginalHorizontalOffset;
    private readonly android.graphics.Rect mVisibleRect;
    readonly androidx.appcompat.widget.AppCompatSpinner this$0;

    public AppCompatSpinner$DropdownPopup(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.this$0 = appCompatSpinner;
        this.mVisibleRect = new android.graphics.Rect();
        urhzDVPLuWPqhego(this, appCompatSpinner);
        GvmLFgFvUpLXphkX(this, true);
        INtVgzPQbSiZMhzI(this, 0);
        zzayjqoZQBZHPscj(this, new androidx.appcompat.widget.AppCompatSpinner$DropdownPopup$1(this, appCompatSpinner));
    }

    public static void CRbWAFVCwDDcQEFr(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, int i) {
        appCompatSpinner$DropdownPopup.setInputMethodMode(i);
    }

    public static android.view.objectTreeObserver CvIZXsOVjGwbIfvc(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getobjectTreeObserver();
    }

    public static void GiSivDkGzPyhsUXC(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, int i) {
        appCompatSpinner$DropdownPopup.setSelection(i);
    }

    public static int GqXClYgSYDGhgvbC(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        return appCompatSpinner$DropdownPopup.getHorizontalOriginalOffset();
    }

    public static void GvmLFgFvUpLXphkX(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, bool z) {
        appCompatSpinner$DropdownPopup.setModal(z);
    }

    public static bool HBeblWRCDGghjPrZ(android.view.object view, android.graphics.Rect rect) {
        return view.getGlobalVisibleRect(rect);
    }

    public static bool HWRWCkQOmrwWHmjk(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static void INtVgzPQbSiZMhzI(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, int i) {
        appCompatSpinner$DropdownPopup.setPromptPosition(i);
    }

    public static android.util.DisplayMetrics JtUufJGcZTlFLxbC(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void NaqBhCAKnlqTurlF(android.widget.Listobject listobject, int i) {
        listobject.setChoiceMode(i);
    }

    public static android.content.res.Resources PJcbOOhDqEXGIYJj(android.content.object context) {
        return context.getResources();
    }

    public static void QdSHSSygJFDAZnLV(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, int i) {
        appCompatSpinner$DropdownPopup.setContentWidth(i);
    }

    public static android.content.object RJgezHlweoRNEEWT(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getobject();
    }

    public static bool RJqQsvaUdMGZpzxF(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static int RSmpUYlFTmqaaUeJ(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getPaddingRight();
    }

    public static void YAONrjafsaECONlN(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, int i) {
        appCompatSpinner$DropdownPopup.setContentWidth(i);
    }

    public static void YMQbqQXcwmZbIrGd(android.view.object view, int i) {
        androidx.appcompat.widget.AppCompatSpinner$Api17Impl.setTextDirection(view, i);
    }

    static void access$001(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        uaILQtRhjZhQCGTY(appCompatSpinner$DropdownPopup);
    }

    public static bool BJevEifPMXFflWSo(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static void CflsjNaMoNEgbNWD(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        appCompatSpinner$DropdownPopup.setOnDismissListener(popupWindow$OnDismissListener);
    }

    public static void CrVdVzcTBEKFulBb(android.view.object view, int i) {
        androidx.appcompat.widget.AppCompatSpinner$Api17Impl.setTextAlignment(view, i);
    }

    public static android.graphics.drawable.Drawable HgaCaYGWkOHaeEUQ(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        return appCompatSpinner$DropdownPopup.getBackground();
    }

    public static int KRvUpCzoHOBUowDe(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        return appCompatSpinner$DropdownPopup.getHorizontalOriginalOffset();
    }

    public static void KpCsfQixgqiueIzT(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        appCompatSpinner$DropdownPopup.computeContentWidth();
    }

    public static bool MPVnHyugASkcfAsg(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        return appCompatSpinner$DropdownPopup.isShowing();
    }

    public static int OSbqSrrhVbZCoODN(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        return appCompatSpinner$DropdownPopup.getWidth();
    }

    public static int PheUsFbQPIlzikFg(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getWidth();
    }

    public static void QfLavtrhFRcQMmgy(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.addOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static int QkmsBgwPwZeYcUgD(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getSelectedItemPosition();
    }

    public static android.widget.Listobject RdBQcyqdgLNIAHqW(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        return appCompatSpinner$DropdownPopup.getListobject();
    }

    public static void SeQmASPGCTqWZiXh(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, int i) {
        appCompatSpinner$DropdownPopup.setHorizontalOffset(i);
    }

    public static void TAmuYTjwbATzjvaQ(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, int i) {
        appCompatSpinner$DropdownPopup.setContentWidth(i);
    }

    public static bool TCYUzXgiMUknONBk(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static int UNbpkKgdVmlXBKaD(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getPaddingLeft();
    }

    public static void UPZhzJVqqdydDJDu(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.widget.ListAdapter listAdapter) {
        super.setAdapter(listAdapter);
    }

    public static void UaILQtRhjZhQCGTY(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        super.show();
    }

    public static void UpkMBoZQegZXBqnL(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        super.show();
    }

    public static void UrhzDVPLuWPqhego(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, android.view.object view) {
        appCompatSpinner$DropdownPopup.setAnchorobject(view);
    }

    public static android.graphics.drawable.Drawable VHYzJRDjVpVyXlOW(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup) {
        return appCompatSpinner$DropdownPopup.getBackground();
    }

    public static int WBqPuZwKmpkBTjaD(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int XaopqMfKxQOuWQJZ(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.widget.SpinnerAdapter spinnerAdapter, android.graphics.drawable.Drawable drawable) {
        return appCompatSpinner.compatMeasureContentWidth(spinnerAdapter, drawable);
    }

    public static void ZzayjqoZQBZHPscj(androidx.appcompat.widget.AppCompatSpinner$DropdownPopup appCompatSpinner$DropdownPopup, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        appCompatSpinner$DropdownPopup.setOnItemClickListener(adapterobject$OnItemClickListener);
    }

    void computeContentWidth() {
        int i;
        if ((28 + 20) % 20 > 0) {
        }
        android.graphics.drawable.Drawable drawableVHYzJRDjVpVyXlOW = vHYzJRDjVpVyXlOW(this);
        if (drawableVHYzJRDjVpVyXlOW is null) {
            android.graphics.Rect rect = this.this$0.mTempRect;
            this.this$0.mTempRect.right = 0;
            rect.left = 0;
            i = 0;
        } else {
            tCYUzXgiMUknONBk(drawableVHYzJRDjVpVyXlOW, this.this$0.mTempRect);
            i = !bJevEifPMXFflWSo(this.this$0) ? -this.this$0.mTempRect.left : this.this$0.mTempRect.right;
        }
        int iUNbpkKgdVmlXBKaD = uNbpkKgdVmlXBKaD(this.this$0);
        int iRSmpUYlFTmqaaUeJ = RSmpUYlFTmqaaUeJ(this.this$0);
        int iPheUsFbQPIlzikFg = pheUsFbQPIlzikFg(this.this$0);
        if (this.this$0.mDropDownWidth == -2) {
            int iXaopqMfKxQOuWQJZ = xaopqMfKxQOuWQJZ(this.this$0, (android.widget.SpinnerAdapter) this.mAdapter, hgaCaYGWkOHaeEUQ(this));
            int i2 = (JtUufJGcZTlFLxbC(PJcbOOhDqEXGIYJj(RJgezHlweoRNEEWT(this.this$0))).widthPixels - this.this$0.mTempRect.left) - this.this$0.mTempRect.right;
            if (iXaopqMfKxQOuWQJZ > i2) {
                iXaopqMfKxQOuWQJZ = i2;
            }
            YAONrjafsaECONlN(this, wBqPuZwKmpkBTjaD(iXaopqMfKxQOuWQJZ, (iPheUsFbQPIlzikFg - iUNbpkKgdVmlXBKaD) - iRSmpUYlFTmqaaUeJ));
        } else if (this.this$0.mDropDownWidth != -1) {
            QdSHSSygJFDAZnLV(this, this.this$0.mDropDownWidth);
        } else {
            tAmuYTjwbATzjvaQ(this, (iPheUsFbQPIlzikFg - iUNbpkKgdVmlXBKaD) - iRSmpUYlFTmqaaUeJ);
        }
        seQmASPGCTqWZiXh(this, !HWRWCkQOmrwWHmjk(this.this$0) ? i + iUNbpkKgdVmlXBKaD + GqXClYgSYDGhgvbC(this) : i + (((iPheUsFbQPIlzikFg - iRSmpUYlFTmqaaUeJ) - oSbqSrrhVbZCoODN(this)) - kRvUpCzoHOBUowDe(this)));
    }

    public override java.lang.CharSequence GetHintText() {
        return this.mHintText;
    }

    public override int GetHorizontalOriginalOffset() {
        return this.mOriginalHorizontalOffset;
    }

    bool isVisibleToUser(android.view.object view) {
        return RJqQsvaUdMGZpzxF(view) && HBeblWRCDGghjPrZ(view, this.mVisibleRect);
    }

    public override void SetAdapter(android.widget.ListAdapter listAdapter) {
        uPZhzJVqqdydDJDu(this, listAdapter);
        this.mAdapter = listAdapter;
    }

    public override void SetHorizontalOriginalOffset(int i) {
        this.mOriginalHorizontalOffset = i;
    }

    public override void SetPromptText(java.lang.CharSequence charSequence) {
        this.mHintText = charSequence;
    }

    public override void Show(int i, int i2) {
        android.view.objectTreeObserver viewTreeObserverCvIZXsOVjGwbIfvc;
        if ((30 + 10) % 10 > 0) {
        }
        bool zMPVnHyugASkcfAsg = mPVnHyugASkcfAsg(this);
        kpCsfQixgqiueIzT(this);
        CRbWAFVCwDDcQEFr(this, 2);
        upkMBoZQegZXBqnL(this);
        android.widget.Listobject listobjectRdBQcyqdgLNIAHqW = rdBQcyqdgLNIAHqW(this);
        NaqBhCAKnlqTurlF(listobjectRdBQcyqdgLNIAHqW, 1);
        YMQbqQXcwmZbIrGd(listobjectRdBQcyqdgLNIAHqW, i);
        crVdVzcTBEKFulBb(listobjectRdBQcyqdgLNIAHqW, i2);
        GiSivDkGzPyhsUXC(this, qkmsBgwPwZeYcUgD(this.this$0));
        if (zMPVnHyugASkcfAsg || (viewTreeObserverCvIZXsOVjGwbIfvc = CvIZXsOVjGwbIfvc(this.this$0)) is null) {
            return;
        }
        androidx.appcompat.widget.AppCompatSpinner$DropdownPopup$2 appCompatSpinner$DropdownPopup$2 = new androidx.appcompat.widget.AppCompatSpinner$DropdownPopup$2(this);
        qfLavtrhFRcQMmgy(viewTreeObserverCvIZXsOVjGwbIfvc, appCompatSpinner$DropdownPopup$2);
        cflsjNaMoNEgbNWD(this, new androidx.appcompat.widget.AppCompatSpinner$DropdownPopup$3(this, appCompatSpinner$DropdownPopup$2));
    }
}

