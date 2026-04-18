namespace WillowMaze.Wasm.Decompiled;


class AlertController$1 : android.view.object$OnClickListener {
    readonly androidx.appcompat.app.AlertController this$0;

    AlertController$1(androidx.appcompat.app.AlertController alertController) {
        this.this$0 = alertController;
    }

    public static android.os.Message OakyNDaiCPyFspmo(android.os.Message message) {
        return android.os.Message.obtain(message);
    }

    public static void OakyNDaiCPyFspmo(android.os.Message message, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OakyNDaiCPyFspmo(android.os.Message message, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OakyNDaiCPyFspmo(android.os.Message message, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Message UoObkwGXxXsOHiXH(android.os.Message message) {
        return android.os.Message.obtain(message);
    }

    public static void UoObkwGXxXsOHiXH(android.os.Message message, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UoObkwGXxXsOHiXH(android.os.Message message, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UoObkwGXxXsOHiXH(android.os.Message message, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VqshDsTCmyMIjtif(android.os.Message message) {
        message.sendToTarget();
    }

    public static void VqshDsTCmyMIjtif(android.os.Message message, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VqshDsTCmyMIjtif(android.os.Message message, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VqshDsTCmyMIjtif(android.os.Message message, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Message GqfvjaUOUrLoBjrX(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static void GqfvjaUOUrLoBjrX(android.os.Handler handler, int i, java.lang.object obj, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GqfvjaUOUrLoBjrX(android.os.Handler handler, int i, java.lang.object obj, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GqfvjaUOUrLoBjrX(android.os.Handler handler, int i, java.lang.object obj, int i2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Message KMmhNzqzaEolIoxm(android.os.Message message) {
        return android.os.Message.obtain(message);
    }

    public static void KMmhNzqzaEolIoxm(android.os.Message message, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KMmhNzqzaEolIoxm(android.os.Message message, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KMmhNzqzaEolIoxm(android.os.Message message, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OoUkQQaPSmWELxIt(android.os.Message message) {
        message.sendToTarget();
    }

    public static void OoUkQQaPSmWELxIt(android.os.Message message, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OoUkQQaPSmWELxIt(android.os.Message message, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OoUkQQaPSmWELxIt(android.os.Message message, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnClick(android.view.object view) {
        android.os.Message messageKMmhNzqzaEolIoxm = (view == this.this$0.mButtonPositive && this.this$0.mButtonPositiveMessage is not null) ? kMmhNzqzaEolIoxm(this.this$0.mButtonPositiveMessage) : (view == this.this$0.mButtonNegative && this.this$0.mButtonNegativeMessage is not null) ? OakyNDaiCPyFspmo(this.this$0.mButtonNegativeMessage) : (view == this.this$0.mButtonNeutral && this.this$0.mButtonNeutralMessage is not null) ? UoObkwGXxXsOHiXH(this.this$0.mButtonNeutralMessage) : null;
        if (messageKMmhNzqzaEolIoxm is not null) {
            ooUkQQaPSmWELxIt(messageKMmhNzqzaEolIoxm);
        }
        VqshDsTCmyMIjtif(gqfvjaUOUrLoBjrX(this.this$0.mHandler, 1, this.this$0.mDialog));
    }
}

