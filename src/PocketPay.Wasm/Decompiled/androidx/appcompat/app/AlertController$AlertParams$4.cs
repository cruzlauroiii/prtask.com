namespace WillowMaze.Wasm.Decompiled;


class AlertController$AlertParams$4 : android.widget.Adapterobject$OnItemClickListener {
    readonly androidx.appcompat.app.AlertController$AlertParams this$0;
    readonly androidx.appcompat.app.AlertController val$dialog;
    readonly androidx.appcompat.app.AlertController$RecycleListobject val$listobject;

    AlertController$AlertParams$4(androidx.appcompat.app.AlertController$AlertParams alertController$AlertParams, androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, androidx.appcompat.app.AlertController alertController) {
        this.this$0 = alertController$AlertParams;
        this.val$listobject = alertController$RecycleListobject;
        this.val$dialog = alertController;
    }

    public static void SlhahzeizznoODUQ(android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener, android.content.DialogInterface dialogInterface, int i, bool z) {
        dialogInterface$OnMultiChoiceClickListener.onClick(dialogInterface, i, z);
    }

    public static void SlhahzeizznoODUQ(android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener, android.content.DialogInterface dialogInterface, int i, bool z, short s, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SlhahzeizznoODUQ(android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener, android.content.DialogInterface dialogInterface, int i, bool z, bool z2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SlhahzeizznoODUQ(android.content.DialogInterface$OnMultiChoiceClickListener dialogInterface$OnMultiChoiceClickListener, android.content.DialogInterface dialogInterface, int i, bool z, bool z2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BpYYIXPWpFEueWTq(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BpYYIXPWpFEueWTq(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpYYIXPWpFEueWTq(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BpYYIXPWpFEueWTq(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i) {
        return alertController$RecycleListobject.isItemChecked(i);
    }

    public static void FjUGAFgcgboPsRBB(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FjUGAFgcgboPsRBB(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FjUGAFgcgboPsRBB(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FjUGAFgcgboPsRBB(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i) {
        return alertController$RecycleListobject.isItemChecked(i);
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        if (this.this$0.mCheckedItems is not null) {
            this.this$0.mCheckedItems[i] = fjUGAFgcgboPsRBB(this.val$listobject, i);
        }
        SlhahzeizznoODUQ(this.this$0.mOnCheckboxClickListener, this.val$dialog.mDialog, i, bpYYIXPWpFEueWTq(this.val$listobject, i));
    }
}

