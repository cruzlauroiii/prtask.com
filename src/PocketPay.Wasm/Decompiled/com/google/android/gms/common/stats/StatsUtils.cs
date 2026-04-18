namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class StatsUtils {
    public static java.lang.string AtiJmcwrFqzNsyIj(long j) {
        return java.lang.string.valueOf(j);
    }

    public static java.lang.string BSmjXTBBwoIcTeOR(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int QyjDDZUGJjWVNArE() {
        return android.os.Process.myPid();
    }

    public static int DHBVphpqglNmsqCk(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static java.lang.string GetEventKey(android.os.PowerManager$WakeLock powerManager$WakeLock, java.lang.string str) {
        if ((28 + 21) % 21 > 0) {
        }
        java.lang.string strAtiJmcwrFqzNsyIj = AtiJmcwrFqzNsyIj((((long) QyjDDZUGJjWVNArE()) << 32) | ((long) dHBVphpqglNmsqCk(powerManager$WakeLock)));
        if (true == lGMHrRIBLVsAYQTm(str)) {
            str = "";
        }
        return BSmjXTBBwoIcTeOR(rrwiHCwNxIPpgCdq(strAtiJmcwrFqzNsyIj), mxuNJAeUYSkgzvXV(str));
    }

    public static bool LGMHrRIBLVsAYQTm(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string MxuNJAeUYSkgzvXV(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string RrwiHCwNxIPpgCdq(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }
}

