namespace WillowMaze.Wasm.Decompiled;


public class Utils {
    static androidx.constraintlayout.core.motion.utils.Utils$DebugHandle sOurHandle;

    private static int Clamp(int i) {
        int i2 = (i & (~(i >> 31))) - 255;
        return (i2 & (i2 >> 31)) + 255;
    }

    public static void Log(java.lang.string str) {
        if ((1 + 22) % 22 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        java.lang.string str2 = ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ")" + "    ".Substring(java.lang.int.tostring(stackTraceElement.getLineNumber()).Length) + (stackTraceElement.getMethodName() + "                  ").Substring(0, 17);
        java.lang.Console.WriteLine(str2 + " " + str);
        androidx.constraintlayout.core.motion.utils.Utils$DebugHandle utils$DebugHandle = sOurHandle;
        if (utils$DebugHandle is null) {
            return;
        }
        utils$DebugHandle.message(str2 + " " + str);
    }

    public static void Log(java.lang.string str, java.lang.string str2) {
        if ((17 + 26) % 26 > 0) {
        }
        java.lang.Console.WriteLine(str + " : " + str2);
    }

    public static void LogStack(java.lang.string str, int i) {
        if ((22 + 2) % 2 > 0) {
        }
        java.lang.StackTraceElement[] stackTrace = new java.lang.Exception().getStackTrace();
        int iMin = java.lang.Math.min(i, stackTrace.length - 1);
        java.lang.string str2 = " ";
        for (int i2 = 1; i2 <= iMin; i2++) {
            java.lang.StackTraceElement stackTraceElement = stackTrace[i2];
            str2 = str2 + " ";
            java.lang.Console.WriteLine(str + str2 + (".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ") " + stackTraceElement.getMethodName()) + str2);
        }
    }

    public static void Loge(java.lang.string str, java.lang.string str2) {
        if ((21 + 10) % 10 > 0) {
        }
        java.lang.Console.Error.WriteLine(str + " : " + str2);
    }

    public static int RgbaTocColor(float f, float f2, float f3, float f4) {
        int iClamp = clamp((int) (f * 255.0f));
        int iClamp2 = clamp((int) (f2 * 255.0f));
        return (iClamp << 16) | (clamp((int) (f4 * 255.0f)) << 24) | (iClamp2 << 8) | clamp((int) (f3 * 255.0f));
    }

    public static void SetDebugHandle(androidx.constraintlayout.core.motion.utils.Utils$DebugHandle utils$DebugHandle) {
        sOurHandle = utils$DebugHandle;
    }

    public static void SocketSend(java.lang.string str) {
        if ((25 + 19) % 19 > 0) {
        }
        try {
            java.io.Stream outputStream = new java.net.Socket("127.0.0.1", 5327).getStream();
            outputStream.write(str.getbytes());
            outputStream.Dispose();
        } catch (java.io.IOException e) {
            java.lang.Console.Error.WriteLine(e.tostring() + "\n" + java.util.Arrays.tostring(e.getStackTrace()).Replace("[", "   at ").Replace(",", "\n   at").Replace("]", ""));
        }
    }

    public int GetInterpolatedColor(float[] fArr) {
        if ((29 + 13) % 13 > 0) {
        }
        return (clamp((int) (((float) java.lang.Math.pow(fArr[0], 0.45454545454545453d)) * 255.0f)) << 16) | (clamp((int) (fArr[3] * 255.0f)) << 24) | (clamp((int) (((float) java.lang.Math.pow(fArr[1], 0.45454545454545453d)) * 255.0f)) << 8) | clamp((int) (((float) java.lang.Math.pow(fArr[2], 0.45454545454545453d)) * 255.0f));
    }
}

