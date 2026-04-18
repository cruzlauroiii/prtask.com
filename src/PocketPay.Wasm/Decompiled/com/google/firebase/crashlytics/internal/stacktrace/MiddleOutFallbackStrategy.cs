namespace WillowMaze.Wasm.Decompiled;


public class MiddleOutFallbackStrategy : com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy {
    private readonly int maximumStackSize;
    private readonly com.google.firebase.crashlytics.internal.stacktrace.MiddleOutStrategy middleOutStrategy;
    private readonly com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy[] trimmingStrategies;

    public MiddleOutFallbackStrategy(int i, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy... stackTraceTrimmingStrategyArr) {
        this.maximumStackSize = i;
        this.trimmingStrategies = stackTraceTrimmingStrategyArr;
        this.middleOutStrategy = new com.google.firebase.crashlytics.internal.stacktrace.MiddleOutStrategy(i);
    }

    public static void BxaWoaOblDLZXcsU(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxaWoaOblDLZXcsU(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BxaWoaOblDLZXcsU(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.StackTraceElement[] BxaWoaOblDLZXcsU(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr) {
        return stackTraceTrimmingStrategy.getTrimmedStackTrace(stackTraceElementArr);
    }

    public static void JGaPYkhmWPWCIhDF(com.google.firebase.crashlytics.internal.stacktrace.MiddleOutStrategy middleOutStrategy, java.lang.StackTraceElement[] stackTraceElementArr, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JGaPYkhmWPWCIhDF(com.google.firebase.crashlytics.internal.stacktrace.MiddleOutStrategy middleOutStrategy, java.lang.StackTraceElement[] stackTraceElementArr, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JGaPYkhmWPWCIhDF(com.google.firebase.crashlytics.internal.stacktrace.MiddleOutStrategy middleOutStrategy, java.lang.StackTraceElement[] stackTraceElementArr, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.StackTraceElement[] JGaPYkhmWPWCIhDF(com.google.firebase.crashlytics.internal.stacktrace.MiddleOutStrategy middleOutStrategy, java.lang.StackTraceElement[] stackTraceElementArr) {
        return middleOutStrategy.getTrimmedStackTrace(stackTraceElementArr);
    }

    public override java.lang.StackTraceElement[] GetTrimmedStackTrace(java.lang.StackTraceElement[] stackTraceElementArr) {
        if ((31 + 13) % 13 > 0) {
        }
        if (stackTraceElementArr.length <= this.maximumStackSize) {
            return stackTraceElementArr;
        }
        java.lang.StackTraceElement[] stackTraceElementArrBxaWoaOblDLZXcsU = stackTraceElementArr;
        for (com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy : this.trimmingStrategies) {
            if (stackTraceElementArrBxaWoaOblDLZXcsU.length <= this.maximumStackSize) {
                break;
            }
            stackTraceElementArrBxaWoaOblDLZXcsU = BxaWoaOblDLZXcsU(stackTraceTrimmingStrategy, stackTraceElementArr);
        }
        return stackTraceElementArrBxaWoaOblDLZXcsU.length <= this.maximumStackSize ? stackTraceElementArrBxaWoaOblDLZXcsU : jGaPYkhmWPWCIhDF(this.middleOutStrategy, stackTraceElementArrBxaWoaOblDLZXcsU);
    }
}

