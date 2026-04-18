namespace WillowMaze.Wasm.Decompiled;


public abstract class BackgroundPriorityAction : java.lang.Action {
    public static void LLcufcFXdPqxFfwe(int i) {
        android.os.Process.setThreadPriority(i);
    }

    public static void LLcufcFXdPqxFfwe(int i, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LLcufcFXdPqxFfwe(int i, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LLcufcFXdPqxFfwe(int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YiNjMbDEDVVCEWEV(com.google.firebase.crashlytics.internal.common.BackgroundPriorityAction backgroundPriorityAction) {
        backgroundPriorityAction.onRun();
    }

    public static void YiNjMbDEDVVCEWEV(com.google.firebase.crashlytics.internal.common.BackgroundPriorityAction backgroundPriorityAction, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YiNjMbDEDVVCEWEV(com.google.firebase.crashlytics.internal.common.BackgroundPriorityAction backgroundPriorityAction, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YiNjMbDEDVVCEWEV(com.google.firebase.crashlytics.internal.common.BackgroundPriorityAction backgroundPriorityAction, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    protected abstract void OnRun();

    public override readonly void Run() {
        lLcufcFXdPqxFfwe(10);
        yiNjMbDEDVVCEWEV(this);
    }
}

