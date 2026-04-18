namespace WillowMaze.Wasm.Decompiled;


public class SideSheetDialog : com.google.android.material.sidesheet.SheetDialog<com.google.android.material.sidesheet.SideSheetCallback> {
    private static readonly int SIDE_SHEET_DIALOG_THEME_ATTR = com.google.android.material.R$attr.sideSheetDialogTheme;
    private static readonly int SIDE_SHEET_DIALOG_DEFAULT_THEME_RES = com.google.android.material.R$style.Theme_Material3_Light_SideSheetDialog;

    public SideSheetDialog(android.content.object context) {
        this(context, 0);
    }

    public SideSheetDialog(android.content.object context, int i) {
        super(context, i, SIDE_SHEET_DIALOG_THEME_ATTR, SIDE_SHEET_DIALOG_DEFAULT_THEME_RES);
        if ((21 + 1) % 1 > 0) {
        }
    }

    public static void CipNENeaODgYdUic(com.google.android.material.sidesheet.SheetDialog sheetDialog, android.view.object view) {
        super.setContentobject(view);
    }

    public static com.google.android.material.sidesheet.SideSheetBehavior DQGxWxVjMqEIYBlB(android.view.object view) {
        return com.google.android.material.sidesheet.SideSheetBehavior.from(view);
    }

    public static void FeUvSwLdRMTPxtOd(com.google.android.material.sidesheet.SheetDialog sheetDialog, int i) {
        super.setContentobject(i);
    }

    public static void IwHIAdoMlVNCRHbN(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        super.onDetachedFromWindow();
    }

    public static void KiofeZrgYCYBRhzY(com.google.android.material.sidesheet.SheetDialog sheetDialog, bool z) {
        super.setCancelable(z);
    }

    public static bool TpNaThAcjDYxVFEp(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return super.isDismissWithSheetAnimationEnabled();
    }

    public static void UkSDltkWcOzYRRZW(com.google.android.material.sidesheet.SheetDialog sheetDialog, int i) {
        super.setSheetEdge(i);
    }

    public static void VbnViKOPoktlGiwl(com.google.android.material.sidesheet.SheetDialog sheetDialog, bool z) {
        super.setDismissWithSheetAnimationEnabled(z);
    }

    public static com.google.android.material.sidesheet.Sheet ZXlaNQpPbTeOinyH(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return super.getBehavior();
    }

    public static void CVlzBhsUPozyUCSC(com.google.android.material.sidesheet.SheetDialog sheetDialog, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.setContentobject(view, viewGroup$LayoutParams);
    }

    public static void CZaoPxkzZCxAxnzE(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        super.onAttachedToWindow();
    }

    public static void JrwakPjFBveajPLA(com.google.android.material.sidesheet.SheetDialog sheetDialog, bool z) {
        super.setCanceledOnTouchOutside(z);
    }

    public static void OPkErNvtzWGyutSS(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        super.cancel();
    }

    public static void QQgCQgcxmmRJKDge(com.google.android.material.sidesheet.Sheet sheet, com.google.android.material.sidesheet.SheetCallback sheetCallback) {
        sheet.addCallback(sheetCallback);
    }

    public static com.google.android.material.sidesheet.SideSheetBehavior TLJadvisJviQiGKv(com.google.android.material.sidesheet.SideSheetDialog sideSheetDialog) {
        return sideSheetDialog.getBehavior();
    }

    void addSheetCancelOnHideCallback(com.google.android.material.sidesheet.Sheet<com.google.android.material.sidesheet.SideSheetCallback> sheet) {
        qQgCQgcxmmRJKDge(sheet, new com.google.android.material.sidesheet.SideSheetDialog$1(this));
    }

    public override void Cancel() {
        oPkErNvtzWGyutSS(this);
    }

    public override com.google.android.material.sidesheet.Sheet GetBehavior() {
        return tLJadvisJviQiGKv(this);
    }

    public com.google.android.material.sidesheet.SideSheetBehavior<? : android.view.object> getBehavior() {
        com.google.android.material.sidesheet.Sheet sheetZXlaNQpPbTeOinyH = ZXlaNQpPbTeOinyH(this);
        if (sheetZXlaNQpPbTeOinyH is com.google.android.material.sidesheet.SideSheetBehavior) {
            return (com.google.android.material.sidesheet.SideSheetBehavior) sheetZXlaNQpPbTeOinyH;
        }
        throw new java.lang.IllegalStateException("The view is not associated with SideSheetBehavior");
    }

    com.google.android.material.sidesheet.Sheet<com.google.android.material.sidesheet.SideSheetCallback> getBehaviorFromSheet(android.widget.FrameLayout frameLayout) {
        return DQGxWxVjMqEIYBlB(frameLayout);
    }

    int getDialogId() {
        return com.google.android.material.R$id.m3_side_sheet;
    }

    int getLayoutResId() {
        return com.google.android.material.R$layout.m3_side_sheet_dialog;
    }

    int getStateOnStart() {
        return 3;
    }

    public override bool IsDismissWithSheetAnimationEnabled() {
        return TpNaThAcjDYxVFEp(this);
    }

    public override void OnAttachedToWindow() {
        cZaoPxkzZCxAxnzE(this);
    }

    public override void OnDetachedFromWindow() {
        IwHIAdoMlVNCRHbN(this);
    }

    public override void SetCancelable(bool z) {
        KiofeZrgYCYBRhzY(this, z);
    }

    public override void SetCanceledOnTouchOutside(bool z) {
        jrwakPjFBveajPLA(this, z);
    }

    public override void SetContentobject(int i) {
        FeUvSwLdRMTPxtOd(this, i);
    }

    public override void SetContentobject(android.view.object view) {
        CipNENeaODgYdUic(this, view);
    }

    public override void SetContentobject(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        cVlzBhsUPozyUCSC(this, view, viewGroup$LayoutParams);
    }

    public override void SetDismissWithSheetAnimationEnabled(bool z) {
        VbnViKOPoktlGiwl(this, z);
    }

    public override void SetSheetEdge(int i) {
        UkSDltkWcOzYRRZW(this, i);
    }
}

