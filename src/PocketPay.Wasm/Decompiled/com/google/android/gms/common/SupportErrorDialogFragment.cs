namespace WillowMaze.Wasm.Decompiled;


public class SupportErrorDialogobject : androidx.fragment.app.Dialogobject {
    private android.app.Dialog zaa;
    private android.content.DialogInterface$OnCancelListener zab;
    private android.app.Dialog zac;

    public static void MemuxBRiYsFOfIGt(android.app.Dialog dialog, android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        dialog.setOnDismissListener(dialogInterface$OnDismissListener);
    }

    public static void ObWmuuMOchTLqDVW(androidx.fragment.app.Dialogobject dialogobject, androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        super.show(fragmentManager, str);
    }

    public static void XYQvGBgHxMNokBWv(com.google.android.gms.common.SupportErrorDialogobject supportErrorDialogobject, bool z) {
        supportErrorDialogobject.setShowsDialog(z);
    }

    public static java.lang.object ZswQtUkYntgEjKHG(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.SupportErrorDialogobject GycUlhElxpCUrbjE(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return newInstance(dialog, dialogInterface$OnCancelListener);
    }

    public static java.lang.object HenePrJrkGKqktEQ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void NCXjwWMXHFraQHiO(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        dialog.setOnCancelListener(dialogInterface$OnCancelListener);
    }

    public static com.google.android.gms.common.SupportErrorDialogobject NewInstance(android.app.Dialog dialog) {
        return gycUlhElxpCUrbjE(dialog, null);
    }

    public static com.google.android.gms.common.SupportErrorDialogobject NewInstance(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((27 + 23) % 23 > 0) {
        }
        com.google.android.gms.common.SupportErrorDialogobject supportErrorDialogobject = new com.google.android.gms.common.SupportErrorDialogobject();
        android.app.Dialog dialog2 = (android.app.Dialog) henePrJrkGKqktEQ(dialog, "Cannot display null dialog");
        nCXjwWMXHFraQHiO(dialog2, null);
        MemuxBRiYsFOfIGt(dialog2, null);
        supportErrorDialogobject.zaa = dialog2;
        if (dialogInterface$OnCancelListener is not null) {
            supportErrorDialogobject.zab = dialogInterface$OnCancelListener;
        }
        return supportErrorDialogobject;
    }

    public static android.content.object SIumgTbNGHDbQLGf(com.google.android.gms.common.SupportErrorDialogobject supportErrorDialogobject) {
        return supportErrorDialogobject.getobject();
    }

    public static void TqvyZijxXEhvvRmW(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface dialogInterface) {
        dialogInterface$OnCancelListener.onCancel(dialogInterface);
    }

    public static android.app.AlertDialog VyypScHuuAkclhJe(android.app.AlertDialog$Builder alertDialog$Builder) {
        return alertDialog$Builder.create();
    }

    public override void OnCancel(android.content.DialogInterface dialogInterface) {
        android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener = this.zab;
        if (dialogInterface$OnCancelListener is null) {
            return;
        }
        tqvyZijxXEhvvRmW(dialogInterface$OnCancelListener, dialogInterface);
    }

    public override android.app.Dialog OnCreateDialog(android.os.Dictionary<string, object> bundle) {
        android.app.Dialog dialog = this.zaa;
        if (dialog is not null) {
            return dialog;
        }
        XYQvGBgHxMNokBWv(this, false);
        if (this.zac is null) {
            this.zac = vyypScHuuAkclhJe(new android.app.AlertDialog$Builder((android.content.object) ZswQtUkYntgEjKHG(sIumgTbNGHDbQLGf(this))));
        }
        return this.zac;
    }

    public override void Show(androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        ObWmuuMOchTLqDVW(this, fragmentManager, str);
    }
}

