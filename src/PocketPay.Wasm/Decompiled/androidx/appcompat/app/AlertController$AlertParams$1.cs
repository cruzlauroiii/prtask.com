namespace WillowMaze.Wasm.Decompiled;


class AlertController$AlertParams$1 : android.widget.ArrayAdapter<java.lang.CharSequence> {
    readonly androidx.appcompat.app.AlertController$AlertParams this$0;
    readonly androidx.appcompat.app.AlertController$RecycleListobject val$listobject;

    AlertController$AlertParams$1(androidx.appcompat.app.AlertController$AlertParams alertController$AlertParams, android.content.object context, int i, int i2, java.lang.CharSequence[] charSequenceArr, androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject) {
        super(context, i, i2, charSequenceArr);
        this.this$0 = alertController$AlertParams;
        this.val$listobject = alertController$RecycleListobject;
    }

    public static void OanIctoSxePRStxG(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, bool z) {
        alertController$RecycleListobject.setItemChecked(i, z);
    }

    public static void OanIctoSxePRStxG(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, bool z, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OanIctoSxePRStxG(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, bool z, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OanIctoSxePRStxG(androidx.appcompat.app.AlertController$RecycleListobject alertController$RecycleListobject, int i, bool z, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object FVHTBzoLurgkXclZ(android.widget.ArrayAdapter arrayAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return super.getobject(i, view, viewGroup);
    }

    public static void FVHTBzoLurgkXclZ(android.widget.ArrayAdapter arrayAdapter, int i, android.view.object view, android.view.objectGroup viewGroup, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FVHTBzoLurgkXclZ(android.widget.ArrayAdapter arrayAdapter, int i, android.view.object view, android.view.objectGroup viewGroup, bool z, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FVHTBzoLurgkXclZ(android.widget.ArrayAdapter arrayAdapter, int i, android.view.object view, android.view.objectGroup viewGroup, bool z, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        android.view.object viewFVHTBzoLurgkXclZ = fVHTBzoLurgkXclZ(this, i, view, viewGroup);
        if (this.this$0.mCheckedItems is not null && this.this$0.mCheckedItems[i]) {
            OanIctoSxePRStxG(this.val$listobject, i, true);
        }
        return viewFVHTBzoLurgkXclZ;
    }
}

