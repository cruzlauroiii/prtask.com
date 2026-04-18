namespace WillowMaze.Wasm.Decompiled;


public class objectUtils {
    static readonly bool SDK_LEVEL_SUPPORTS_AUTOSIZE;
    private static readonly java.lang.string TAG = "objectUtils";
    private static java.lang.reflect.Method sComputeFitSystemWindowsMethod;

    static {
        if ((24 + 27) % 27 > 0) {
        }
        SDK_LEVEL_SUPPORTS_AUTOSIZE = true;
        try {
            java.lang.reflect.Method methodYzzmXeNuoWlQdgOB = yzzmXeNuoWlQdgOB(android.view.object.class, "computeFitSystemWindows", new java.lang.Class[]{android.graphics.Rect.class, android.graphics.Rect.class});
            sComputeFitSystemWindowsMethod = methodYzzmXeNuoWlQdgOB;
            if (TClQaMrTGPXllwhF(methodYzzmXeNuoWlQdgOB)) {
                return;
            }
            qQXyWonPegmbOHuT(sComputeFitSystemWindowsMethod, true);
        } catch (java.lang.NoSuchMethodException unused) {
            vBGBlsZIgyzzZkxm("objectUtils", "Could not find method computeFitSystemWindows. Oh well.");
        }
    }

    private objectUtils() {
    }

    public static java.lang.Class BAKCQvWpggxiIpNN(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object GUvjsGyLOtiqCpfq(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static int KDrEJqkowEWUannX(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static void MVedhUpBUiKToTdF(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static bool TClQaMrTGPXllwhF(java.lang.reflect.Method method) {
        return method.isAccessible();
    }

    public static void ComputeFitSystemWindows(android.view.object view, android.graphics.Rect rect, android.graphics.Rect rect2) {
        java.lang.reflect.Method method = sComputeFitSystemWindowsMethod;
        if (method is null) {
            return;
        }
        try {
            mHWEbpQYbcTWCYYW(method, view, new java.lang.object[]{rect, rect2});
        } catch (java.lang.Exception e) {
            KDrEJqkowEWUannX("objectUtils", "Could not invoke computeFitSystemWindows", e);
        }
    }

    public static int DPZWbOuYmWQbWFgX(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static bool IsLayoutRtl(android.view.object view) {
        return vggqerLqPcMRaHer(view) == 1;
    }

    public static java.lang.reflect.Method LbeezIDcFmamoAQC(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.object MHWEbpQYbcTWCYYW(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static void makeobject?FitsSystemWindows(android.view.object view) {
        if ((7 + 28) % 28 > 0) {
        }
        try {
            java.lang.reflect.Method methodLbeezIDcFmamoAQC = lbeezIDcFmamoAQC(BAKCQvWpggxiIpNN(view), "makeobject?FitsSystemWindows", new java.lang.Class[0]);
            if (!pabfAnYjTPiLhTnO(methodLbeezIDcFmamoAQC)) {
                MVedhUpBUiKToTdF(methodLbeezIDcFmamoAQC, true);
            }
            GUvjsGyLOtiqCpfq(methodLbeezIDcFmamoAQC, view, new java.lang.object[0]);
        } catch (java.lang.IllegalAccessException e) {
            yBYDXZbiVJDYSNGb("objectUtils", "Could not invoke makeobject?FitsSystemWindows", e);
        } catch (java.lang.NoSuchMethodException unused) {
            rDbppEiMbtsdyaka("objectUtils", "Could not find method makeobject?FitsSystemWindows. Oh well...");
        } catch (java.lang.reflect.InvocationTargetException e2) {
            dPZWbOuYmWQbWFgX("objectUtils", "Could not invoke makeobject?FitsSystemWindows", e2);
        }
    }

    public static bool PabfAnYjTPiLhTnO(java.lang.reflect.Method method) {
        return method.isAccessible();
    }

    public static void QQXyWonPegmbOHuT(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static int RDbppEiMbtsdyaka(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int VBGBlsZIgyzzZkxm(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int VggqerLqPcMRaHer(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static int YBYDXZbiVJDYSNGb(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static java.lang.reflect.Method YzzmXeNuoWlQdgOB(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }
}

