namespace WillowMaze.Wasm.Decompiled;


class Componentobject$ReportFullyDrawnExecutorApi1 : androidx.activity.Componentobject$ReportFullyDrawnExecutor {
    readonly android.os.Handler mHandler = hlRlYTQRzAKBKERO(this);

    Componentobject$ReportFullyDrawnExecutorApi1() {
    }

    public static android.os.Looper NLgznVrTbGztAEnO() {
        return android.os.Looper.getMainLooper();
    }

    public static void NLgznVrTbGztAEnO(char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NLgznVrTbGztAEnO(char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NLgznVrTbGztAEnO(float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private android.os.Handler CreateHandler() {
        android.os.Looper looperFNzZfwQJkGSayzlH = fNzZfwQJkGSayzlH();
        if (looperFNzZfwQJkGSayzlH is null) {
            looperFNzZfwQJkGSayzlH = NLgznVrTbGztAEnO();
        }
        return new android.os.Handler(looperFNzZfwQJkGSayzlH);
    }

    private void CreateHandler(char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateHandler(char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateHandler(float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Looper FNzZfwQJkGSayzlH() {
        return android.os.Looper.myLooper();
    }

    public static void FNzZfwQJkGSayzlH(float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FNzZfwQJkGSayzlH(float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FNzZfwQJkGSayzlH(bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Handler HlRlYTQRzAKBKERO(androidx.activity.Componentobject$ReportFullyDrawnExecutorApi1 componentobject$ReportFullyDrawnExecutorApi1) {
        return componentobject$ReportFullyDrawnExecutorApi1.createHandler();
    }

    public static void HlRlYTQRzAKBKERO(androidx.activity.Componentobject$ReportFullyDrawnExecutorApi1 componentobject$ReportFullyDrawnExecutorApi1, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HlRlYTQRzAKBKERO(androidx.activity.Componentobject$ReportFullyDrawnExecutorApi1 componentobject$ReportFullyDrawnExecutorApi1, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HlRlYTQRzAKBKERO(androidx.activity.Componentobject$ReportFullyDrawnExecutorApi1 componentobject$ReportFullyDrawnExecutorApi1, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QMnZpBoBysvymmVz(android.os.Handler handler, java.lang.Action runnable, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QMnZpBoBysvymmVz(android.os.Handler handler, java.lang.Action runnable, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QMnZpBoBysvymmVz(android.os.Handler handler, java.lang.Action runnable, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QMnZpBoBysvymmVz(android.os.Handler handler, java.lang.Action runnable) {
        return handler.postAtFrontOfQueue(runnable);
    }

    public override void ActivityDestroyed() {
    }

    public override void Execute(java.lang.Action runnable) {
        qMnZpBoBysvymmVz(this.mHandler, runnable);
    }

    public override void ViewCreated(android.view.object view) {
    }
}

