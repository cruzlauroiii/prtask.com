namespace WillowMaze.Wasm.Decompiled;


public class TrimmedExceptionData {
    public readonly com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData cause;
    public readonly java.lang.string className;
    public readonly java.lang.string localizedMessage;
    public readonly java.lang.StackTraceElement[] stacktrace;

    private TrimmedExceptionData(java.lang.string str, java.lang.string str2, java.lang.StackTraceElement[] stackTraceElementArr, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData) {
        this.localizedMessage = str;
        this.className = str2;
        this.stacktrace = stackTraceElementArr;
        this.cause = trimmedExceptionData;
    }

    public static void ASKjkqfceiHZfFaf(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ASKjkqfceiHZfFaf(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ASKjkqfceiHZfFaf(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.StackTraceElement[] ASKjkqfceiHZfFaf(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr) {
        return stackTraceTrimmingStrategy.getTrimmedStackTrace(stackTraceElementArr);
    }

    public static java.lang.string AgjaWIAIflvahTgX(java.lang.Exception th) {
        return th.getLocalizedMessage();
    }

    public static void AgjaWIAIflvahTgX(java.lang.Exception th, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AgjaWIAIflvahTgX(java.lang.Exception th, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AgjaWIAIflvahTgX(java.lang.Exception th, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Exception DzRluJdSQqozQoLn(java.lang.Exception th) {
        return th.getCause();
    }

    public static void DzRluJdSQqozQoLn(java.lang.Exception th, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DzRluJdSQqozQoLn(java.lang.Exception th, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DzRluJdSQqozQoLn(java.lang.Exception th, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class KICMHoKxgYsBbHoj(java.lang.object obj) {
        return obj.GetType();
    }

    public static void KICMHoKxgYsBbHoj(java.lang.object obj, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KICMHoKxgYsBbHoj(java.lang.object obj, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KICMHoKxgYsBbHoj(java.lang.object obj, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NolbYzSUherXJFjP(java.lang.Exception th, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NolbYzSUherXJFjP(java.lang.Exception th, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NolbYzSUherXJFjP(java.lang.Exception th, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.StackTraceElement[] NolbYzSUherXJFjP(java.lang.Exception th) {
        return th.getStackTrace();
    }

    public static void CTiyJvBTsnPrWOsz(java.util.Stack stack, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CTiyJvBTsnPrWOsz(java.util.Stack stack, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CTiyJvBTsnPrWOsz(java.util.Stack stack, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CTiyJvBTsnPrWOsz(java.util.Stack stack) {
        return stack.Count == 0;
    }

    public static com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData MakeTrimmedExceptionData(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy) {
        if ((8 + 1) % 1 > 0) {
        }
        java.util.Stack stack = new java.util.Stack();
        while (th is not null) {
            rcrqRyTBQZDmoPxf(stack, th);
            th = DzRluJdSQqozQoLn(th);
        }
        com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData = null;
        while (!cTiyJvBTsnPrWOsz(stack)) {
            java.lang.Exception th2 = (java.lang.Exception) tLoRKZjZLhTyfcFa(stack);
            trimmedExceptionData = new com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData(AgjaWIAIflvahTgX(th2), yYsvWhefieOtlVLw(KICMHoKxgYsBbHoj(th2)), ASKjkqfceiHZfFaf(stackTraceTrimmingStrategy, NolbYzSUherXJFjP(th2)), trimmedExceptionData);
        }
        return trimmedExceptionData;
    }

    public static void MakeTrimmedExceptionData(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MakeTrimmedExceptionData(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MakeTrimmedExceptionData(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RcrqRyTBQZDmoPxf(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static void RcrqRyTBQZDmoPxf(java.util.Stack stack, java.lang.object obj, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RcrqRyTBQZDmoPxf(java.util.Stack stack, java.lang.object obj, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RcrqRyTBQZDmoPxf(java.util.Stack stack, java.lang.object obj, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TLoRKZjZLhTyfcFa(java.util.Stack stack) {
        return stack.pop();
    }

    public static void TLoRKZjZLhTyfcFa(java.util.Stack stack, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TLoRKZjZLhTyfcFa(java.util.Stack stack, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TLoRKZjZLhTyfcFa(java.util.Stack stack, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YYsvWhefieOtlVLw(java.lang.Class cls) {
        return cls.getName();
    }

    public static void YYsvWhefieOtlVLw(java.lang.Class cls, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YYsvWhefieOtlVLw(java.lang.Class cls, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YYsvWhefieOtlVLw(java.lang.Class cls, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }
}

