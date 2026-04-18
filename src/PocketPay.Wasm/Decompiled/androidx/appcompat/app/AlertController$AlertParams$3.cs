namespace WillowMaze.Wasm.Decompiled;


class AlertController$AlertParams$3 : android.widget.Adapterobject$OnItemClickListener {
    readonly androidx.appcompat.app.AlertController$AlertParams this$0;
    readonly androidx.appcompat.app.AlertController val$dialog;

    AlertController$AlertParams$3(androidx.appcompat.app.AlertController$AlertParams alertController$AlertParams, androidx.appcompat.app.AlertController alertController) {
        this.this$0 = alertController$AlertParams;
        this.val$dialog = alertController;
    }

    public static void KJwznmwTHQlSInSJ(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        appCompatDialog.dismiss();
    }

    public static void KJwznmwTHQlSInSJ(androidx.appcompat.app.AppCompatDialog appCompatDialog, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KJwznmwTHQlSInSJ(androidx.appcompat.app.AppCompatDialog appCompatDialog, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KJwznmwTHQlSInSJ(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KqlyCgvvzLFbYvvV(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i) {
        dialogInterface$OnClickListener.onClick(dialogInterface, i);
    }

    public static void KqlyCgvvzLFbYvvV(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KqlyCgvvzLFbYvvV(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KqlyCgvvzLFbYvvV(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        kqlyCgvvzLFbYvvV(this.this$0.mOnClickListener, this.val$dialog.mDialog, i);
        if (this.this$0.mIsSingleChoice) {
            return;
        }
        KJwznmwTHQlSInSJ(this.val$dialog.mDialog);
    }
}

