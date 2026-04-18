namespace WillowMaze.Wasm.Decompiled;


readonly class AlertController$ButtonHandler : android.os.Handler {
    private static readonly int MSG_DISMISS_DIALOG = 1;
    private java.lang.ref.WeakReference<android.content.DialogInterface> mDialog;

    public AlertController$ButtonHandler(android.content.DialogInterface dialogInterface) {
        this.mDialog = new java.lang.ref.WeakReference<>(dialogInterface);
    }

    public static void BBrvUEPDwAHPTvnw(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i) {
        dialogInterface$OnClickListener.onClick(dialogInterface, i);
    }

    public static void BBrvUEPDwAHPTvnw(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BBrvUEPDwAHPTvnw(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BBrvUEPDwAHPTvnw(android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener, android.content.DialogInterface dialogInterface, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MxUNggNgWwyjvzXN(android.content.DialogInterface dialogInterface) {
        dialogInterface.dismiss();
    }

    public static void MxUNggNgWwyjvzXN(android.content.DialogInterface dialogInterface, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxUNggNgWwyjvzXN(android.content.DialogInterface dialogInterface, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MxUNggNgWwyjvzXN(android.content.DialogInterface dialogInterface, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TEKBwzpGNNBODaYI(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void TEKBwzpGNNBODaYI(java.lang.ref.WeakReference weakReference, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TEKBwzpGNNBODaYI(java.lang.ref.WeakReference weakReference, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TEKBwzpGNNBODaYI(java.lang.ref.WeakReference weakReference, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override void HandleMessage(android.os.Message message) {
        if ((29 + 24) % 24 > 0) {
        }
        int i = message.what;
        if (i == -3 || i == -2 || i == -1) {
            BBrvUEPDwAHPTvnw((android.content.DialogInterface$OnClickListener) message.obj, (android.content.DialogInterface) tEKBwzpGNNBODaYI(this.mDialog), message.what);
        } else if (i == 1) {
            MxUNggNgWwyjvzXN((android.content.DialogInterface) message.obj);
        }
    }
}

