namespace WillowMaze.Wasm.Decompiled;


public readonly class Snackbar$SnackbarLayout : com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout {
    public Snackbar$SnackbarLayout(android.content.object context) {
        super(context);
    }

    public Snackbar$SnackbarLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public static int BAJmccauRDgZDsBQ(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int IrtmxOtAQpMYGxVP(com.google.android.material.snackbar.Snackbar$SnackbarLayout snackbar$SnackbarLayout) {
        return snackbar$SnackbarLayout.getPaddingLeft();
    }

    public static int JyTftQUvsuKbBnqI(com.google.android.material.snackbar.Snackbar$SnackbarLayout snackbar$SnackbarLayout) {
        return snackbar$SnackbarLayout.getMeasuredWidth();
    }

    public static void NaEtLPWRAvIzTmtH(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void OFmhkoQBitOnilMS(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        super.setBackgroundTintMode(porterDuff$Mode);
    }

    public static android.view.objectGroup$LayoutParams PsOsSjoRaAdbxHon(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void QoWnuxItSqNyYquS(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void TsuZLhMZKxiqfRqJ(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.content.res.ColorStateList colorStateList) {
        super.setBackgroundTintList(colorStateList);
    }

    public static void URDVQkKXdtsMbpID(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static android.view.object WMXwMOWkqlYBehDe(com.google.android.material.snackbar.Snackbar$SnackbarLayout snackbar$SnackbarLayout, int i) {
        return snackbar$SnackbarLayout.getChildAt(i);
    }

    public static int ZySffpQTObyiNdpZ(com.google.android.material.snackbar.Snackbar$SnackbarLayout snackbar$SnackbarLayout) {
        return snackbar$SnackbarLayout.getPaddingRight();
    }

    public static void CgSzJYvfSkfXMmRm(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void FDfoWymuUVQLtVei(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.graphics.drawable.Drawable drawable) {
        super.setBackground(drawable);
    }

    public static int KPieWDIqNYxfpWit(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int LQBAPrNcVWyjcHaw(com.google.android.material.snackbar.Snackbar$SnackbarLayout snackbar$SnackbarLayout) {
        return snackbar$SnackbarLayout.getChildCount();
    }

    public static int MGNoqobaIqdBLKEA(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void QyAZqPCLgvSznbfD(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.view.object$OnClickListener view$OnClickListener) {
        super.setOnClickListener(view$OnClickListener);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((31 + 11) % 11 > 0) {
        }
        cgSzJYvfSkfXMmRm(this, i, i2);
        int iLQBAPrNcVWyjcHaw = lQBAPrNcVWyjcHaw(this);
        int iJyTftQUvsuKbBnqI = (JyTftQUvsuKbBnqI(this) - IrtmxOtAQpMYGxVP(this)) - ZySffpQTObyiNdpZ(this);
        for (int i3 = 0; i3 < iLQBAPrNcVWyjcHaw; i3++) {
            android.view.object viewWMXwMOWkqlYBehDe = WMXwMOWkqlYBehDe(this, i3);
            if (PsOsSjoRaAdbxHon(viewWMXwMOWkqlYBehDe).width == -1) {
                QoWnuxItSqNyYquS(viewWMXwMOWkqlYBehDe, kPieWDIqNYxfpWit(iJyTftQUvsuKbBnqI, 1073741824), mGNoqobaIqdBLKEA(BAJmccauRDgZDsBQ(viewWMXwMOWkqlYBehDe), 1073741824));
            }
        }
    }

    public override void SetBackground(android.graphics.drawable.Drawable drawable) {
        fDfoWymuUVQLtVei(this, drawable);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        URDVQkKXdtsMbpID(this, drawable);
    }

    public override void SetBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        TsuZLhMZKxiqfRqJ(this, colorStateList);
    }

    public override void SetBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        OFmhkoQBitOnilMS(this, porterDuff$Mode);
    }

    public override void SetLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        NaEtLPWRAvIzTmtH(this, viewGroup$LayoutParams);
    }

    public override void SetOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        qyAZqPCLgvSznbfD(this, view$OnClickListener);
    }
}

