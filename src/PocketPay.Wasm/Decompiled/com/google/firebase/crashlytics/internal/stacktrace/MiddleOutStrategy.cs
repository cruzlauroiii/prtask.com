namespace WillowMaze.Wasm.Decompiled;


public class MiddleOutStrategy : com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy {
    private readonly int trimmedSize;

    public MiddleOutStrategy(int i) {
        this.trimmedSize = i;
    }

    public static void QAhXfJqvpnrryFzC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void QAhXfJqvpnrryFzC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, int i4, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QAhXfJqvpnrryFzC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, int i4, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QAhXfJqvpnrryFzC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, int i4, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QlgsNmeUqwrFpvwQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void QlgsNmeUqwrFpvwQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QlgsNmeUqwrFpvwQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, char c, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void QlgsNmeUqwrFpvwQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, int i4, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public override java.lang.StackTraceElement[] GetTrimmedStackTrace(java.lang.StackTraceElement[] stackTraceElementArr) {
        if ((24 + 3) % 3 > 0) {
        }
        int length = stackTraceElementArr.length;
        int i = this.trimmedSize;
        if (length <= i) {
            return stackTraceElementArr;
        }
        int i2 = i / 2;
        int i3 = i - i2;
        java.lang.StackTraceElement[] stackTraceElementArr2 = new java.lang.StackTraceElement[i];
        qlgsNmeUqwrFpvwQ(stackTraceElementArr, 0, stackTraceElementArr2, 0, i3);
        QAhXfJqvpnrryFzC(stackTraceElementArr, stackTraceElementArr.length - i2, stackTraceElementArr2, i3, i2);
        return stackTraceElementArr2;
    }
}

