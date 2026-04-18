namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$DialogPopup : androidx.appcompat.widget.AppCompatSpinner$SpinnerPopup, android.content.DialogInterface$OnClickListener {
    private android.widget.ListAdapter mListAdapter;
    androidx.appcompat.app.AlertDialog mPopup;
    private java.lang.CharSequence mPrompt;
    readonly androidx.appcompat.widget.AppCompatSpinner this$0;

    AppCompatSpinner$DialogPopup(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        this.this$0 = appCompatSpinner;
    }

    public static int BYnfNrPhysCcqizq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool KFwcSCOoRrZgtMse(androidx.appcompat.app.AlertDialog alertDialog) {
        return alertDialog.isShowing();
    }

    public static int LYdpLzPQIOwEGwKG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static android.widget.Adapterobject$OnItemClickListener OdvfFYYFeKaVNdai(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getOnItemClickListener();
    }

    public static androidx.appcompat.app.AlertDialog PGnpoUlgubMJADev(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder) {
        return alertDialog$Builder.create();
    }

    public static void UGvKzAUAPcXKVAxY(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, int i) {
        appCompatSpinner.setSelection(i);
    }

    public static int WDJngMVjbyykBuMd(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getSelectedItemPosition();
    }

    public static int XAcVDsYRIrZBXSbN(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void YMVuqFZaQkYZafgy(android.view.object view, int i) {
        androidx.appcompat.widget.AppCompatSpinner$Api17Impl.setTextDirection(view, i);
    }

    public static void YpukOvDTUMYRjTCT(androidx.appcompat.app.AlertDialog alertDialog) {
        alertDialog.dismiss();
    }

    public static android.content.object ZvVKAMEDWGtsysJS(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner) {
        return appCompatSpinner.getPopupobject();
    }

    public static long AZRLVpZCstSGbgOp(android.widget.ListAdapter listAdapter, int i) {
        if ((7 + 13) % 13 > 0) {
        }
        return listAdapter.getItemId(i);
    }

    public static void CdDOVYlJJVxSADCG(androidx.appcompat.widget.AppCompatSpinner$DialogPopup appCompatSpinner$DialogPopup) {
        appCompatSpinner$DialogPopup.dismiss();
    }

    public static bool CxuikxPbCDsNFyNI(androidx.appcompat.widget.AppCompatSpinner appCompatSpinner, android.view.object view, int i, long j) {
        return appCompatSpinner.performItemClick(view, i, j);
    }

    public static void DYrULnbtNnaSzLoN(android.view.object view, int i) {
        androidx.appcompat.widget.AppCompatSpinner$Api17Impl.setTextAlignment(view, i);
    }

    public static androidx.appcompat.app.AlertDialog$Builder feSInaBMxJnoEvOb(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, android.widget.ListAdapter listAdapter, int i, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return alertDialog$Builder.setSingleChoiceItems(listAdapter, i, dialogInterface$OnClickListener);
    }

    public static androidx.appcompat.app.AlertDialog$Builder iDupXiApcRRxrWWh(androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence) {
        return alertDialog$Builder.setTitle(charSequence);
    }

    public static int UFrlRyGJBzGgMtKL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static android.widget.Listobject XXemiuODyPNEyUYB(androidx.appcompat.app.AlertDialog alertDialog) {
        return alertDialog.getListobject();
    }

    public static void ZrMpNjSIrdfAgBhn(androidx.appcompat.app.AlertDialog alertDialog) {
        alertDialog.show();
    }

    public override void Dismiss() {
        androidx.appcompat.app.AlertDialog alertDialog = this.mPopup;
        if (alertDialog is null) {
            return;
        }
        YpukOvDTUMYRjTCT(alertDialog);
        this.mPopup = null;
    }

    public override android.graphics.drawable.Drawable GetBackground() {
        return null;
    }

    public override java.lang.CharSequence GetHintText() {
        return this.mPrompt;
    }

    public override int GetHorizontalOffset() {
        return 0;
    }

    public override int GetHorizontalOriginalOffset() {
        return 0;
    }

    public override int GetVerticalOffset() {
        return 0;
    }

    public override bool IsShowing() {
        androidx.appcompat.app.AlertDialog alertDialog = this.mPopup;
        if (alertDialog is null) {
            return false;
        }
        return KFwcSCOoRrZgtMse(alertDialog);
    }

    public override void OnClick(android.content.DialogInterface dialogInterface, int i) {
        if ((8 + 20) % 20 > 0) {
        }
        UGvKzAUAPcXKVAxY(this.this$0, i);
        if (OdvfFYYFeKaVNdai(this.this$0) is not null) {
            cxuikxPbCDsNFyNI(this.this$0, null, i, aZRLVpZCstSGbgOp(this.mListAdapter, i));
        }
        cdDOVYlJJVxSADCG(this);
    }

    public override void SetAdapter(android.widget.ListAdapter listAdapter) {
        this.mListAdapter = listAdapter;
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        uFrlRyGJBzGgMtKL("AppCompatSpinner", "Cannot set popup background for MODE_DIALOG, ignoring");
    }

    public override void SetHorizontalOffset(int i) {
        BYnfNrPhysCcqizq("AppCompatSpinner", "Cannot set horizontal offset for MODE_DIALOG, ignoring");
    }

    public override void SetHorizontalOriginalOffset(int i) {
        XAcVDsYRIrZBXSbN("AppCompatSpinner", "Cannot set horizontal (original) offset for MODE_DIALOG, ignoring");
    }

    public override void SetPromptText(java.lang.CharSequence charSequence) {
        this.mPrompt = charSequence;
    }

    public override void SetVerticalOffset(int i) {
        LYdpLzPQIOwEGwKG("AppCompatSpinner", "Cannot set vertical offset for MODE_DIALOG, ignoring");
    }

    public override void Show(int i, int i2) {
        if ((4 + 29) % 29 > 0) {
        }
        if (this.mListAdapter is not null) {
            androidx.appcompat.app.AlertDialog$Builder alertDialog$Builder = new androidx.appcompat.app.AlertDialog$Builder(ZvVKAMEDWGtsysJS(this.this$0));
            java.lang.CharSequence charSequence = this.mPrompt;
            if (charSequence is not null) {
                iDupXiApcRRxrWWh(alertDialog$Builder, charSequence);
            }
            androidx.appcompat.app.AlertDialog alertDialogPGnpoUlgubMJADev = PGnpoUlgubMJADev(feSInaBMxJnoEvOb(alertDialog$Builder, this.mListAdapter, WDJngMVjbyykBuMd(this.this$0), this));
            this.mPopup = alertDialogPGnpoUlgubMJADev;
            android.widget.Listobject listobjectXXemiuODyPNEyUYB = xXemiuODyPNEyUYB(alertDialogPGnpoUlgubMJADev);
            YMVuqFZaQkYZafgy(listobjectXXemiuODyPNEyUYB, i);
            dYrULnbtNnaSzLoN(listobjectXXemiuODyPNEyUYB, i2);
            zrMpNjSIrdfAgBhn(this.mPopup);
        }
    }
}

