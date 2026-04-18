namespace WillowMaze.Wasm.Decompiled;


public class ErrorDialogobject : android.app.Dialogobject {
    private android.app.Dialog zaa;
    private android.content.DialogInterface$OnCancelListener zab;
    private android.app.Dialog zac;

    public static void FVKSGHycxwGhyCJw(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface dialogInterface) {
        dialogInterface$OnCancelListener.onCancel(dialogInterface);
    }

    public static void GHaLekmCyZeIndVu(android.app.Dialog dialog, android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        dialog.setOnDismissListener(dialogInterface$OnDismissListener);
    }

    public static void JNiyeZBjDaqqEfru(com.google.android.gms.common.ErrorDialogobject errorDialogobject, bool z) {
        errorDialogobject.setShowsDialog(z);
    }

    public static void ViwpRVzkSHonImKd(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        dialog.setOnCancelListener(dialogInterface$OnCancelListener);
    }

    public static com.google.android.gms.common.ErrorDialogobject VwjNByXTJaFuRmLk(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return newInstance(dialog, dialogInterface$OnCancelListener);
    }

    public static java.lang.object IOaeVOpAAxVzNyAD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.app.object IZEjTQNjSWuWxbWT(com.google.android.gms.common.ErrorDialogobject errorDialogobject) {
        return errorDialogobject.getobject();
    }

    public static com.google.android.gms.common.ErrorDialogobject NewInstance(android.app.Dialog dialog) {
        return VwjNByXTJaFuRmLk(dialog, null);
    }

    public static com.google.android.gms.common.ErrorDialogobject NewInstance(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((6 + 12) % 12 > 0) {
        }
        com.google.android.gms.common.ErrorDialogobject errorDialogobject = new com.google.android.gms.common.ErrorDialogobject();
        android.app.Dialog dialog2 = (android.app.Dialog) qKilYcnjZfeYpIhB(dialog, "Cannot display null dialog");
        ViwpRVzkSHonImKd(dialog2, null);
        GHaLekmCyZeIndVu(dialog2, null);
        errorDialogobject.zaa = dialog2;
        if (dialogInterface$OnCancelListener is not null) {
            errorDialogobject.zab = dialogInterface$OnCancelListener;
        }
        return errorDialogobject;
    }

    public static java.lang.object QKilYcnjZfeYpIhB(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.app.AlertDialog VGgbTuVBJQYnHgEz(android.app.AlertDialog$Builder alertDialog$Builder) {
        return alertDialog$Builder.create();
    }

    public static void VRvKqUQFEeQPWiFs(android.app.Dialogobject dialogobject, android.app.objectManager fragmentManager, java.lang.string str) {
        super.show(fragmentManager, str);
    }

    public override void OnCancel(android.content.DialogInterface dialogInterface) {
        android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener = this.zab;
        if (dialogInterface$OnCancelListener is null) {
            return;
        }
        FVKSGHycxwGhyCJw(dialogInterface$OnCancelListener, dialogInterface);
    }

    public override android.app.Dialog OnCreateDialog(android.os.Dictionary<string, object> bundle) {
        android.app.Dialog dialog = this.zaa;
        if (dialog is not null) {
            return dialog;
        }
        JNiyeZBjDaqqEfru(this, false);
        if (this.zac is null) {
            this.zac = vGgbTuVBJQYnHgEz(new android.app.AlertDialog$Builder((android.content.object) iOaeVOpAAxVzNyAD(iZEjTQNjSWuWxbWT(this))));
        }
        return this.zac;
    }

    public override void Show(android.app.objectManager fragmentManager, java.lang.string str) {
        vRvKqUQFEeQPWiFs(this, fragmentManager, str);
    }
}

