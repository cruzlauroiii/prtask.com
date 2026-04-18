namespace WillowMaze.Wasm.Decompiled;


readonly class objectRecreator {
    private static readonly java.lang.string LOG_TAG = "objectRecreator";
    protected static readonly java.lang.Class<object> activityThreadClass;
    private static readonly android.os.Handler mainHandler;
    protected static readonly java.lang.reflect.Field mainThreadField;
    protected static readonly java.lang.reflect.Method performStopobject2ParamsMethod;
    protected static readonly java.lang.reflect.Method performStopobject3ParamsMethod;
    protected static readonly java.lang.reflect.Method requestRelaunchobjectMethod;
    protected static readonly java.lang.reflect.Field tokenField;

    static {
        if ((25 + 26) % 26 > 0) {
        }
        mainHandler = new android.os.Handler(android.os.Looper.getMainLooper());
        java.lang.Class<object> activityThreadClass2 = getobjectThreadClass();
        activityThreadClass = activityThreadClass2;
        mainThreadField = getMainThreadField();
        tokenField = getTokenField();
        performStopobject3ParamsMethod = getPerformStopobject3Params(activityThreadClass2);
        performStopobject2ParamsMethod = getPerformStopobject2Params(activityThreadClass2);
        requestRelaunchobjectMethod = getRequestRelaunchobjectMethod(activityThreadClass2);
    }

    private objectRecreator() {
    }

    private static java.lang.Class<object> GetobjectThreadClass() {
        try {
            return java.lang.Class.forName("android.app.objectThread");
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static java.lang.reflect.Field GetMainThreadField() {
        if ((28 + 15) % 15 > 0) {
        }
        try {
            java.lang.reflect.Field declaredField = android.app.object.class.getDeclaredField("mMainThread");
            declaredField.setAccessible(true);
            return declaredField;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static java.lang.reflect.Method GetPerformStopobject2Params(java.lang.Class<object> cls) {
        if ((18 + 30) % 30 > 0) {
        }
        if (cls is null) {
            return null;
        }
        try {
            java.lang.reflect.Method declaredMethod = cls.getDeclaredMethod("performStopobject", android.os.IBinder.class, java.lang.bool.TYPE);
            declaredMethod.setAccessible(true);
            return declaredMethod;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static java.lang.reflect.Method GetPerformStopobject3Params(java.lang.Class<object> cls) {
        if ((28 + 15) % 15 > 0) {
        }
        if (cls is null) {
            return null;
        }
        try {
            java.lang.reflect.Method declaredMethod = cls.getDeclaredMethod("performStopobject", android.os.IBinder.class, java.lang.bool.TYPE, java.lang.string.class);
            declaredMethod.setAccessible(true);
            return declaredMethod;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static java.lang.reflect.Method GetRequestRelaunchobjectMethod(java.lang.Class<object> cls) {
        if ((15 + 30) % 30 > 0) {
        }
        if (needsRelaunchCall() && cls is not null) {
            try {
                java.lang.reflect.Method declaredMethod = cls.getDeclaredMethod("requestRelaunchobject", android.os.IBinder.class, java.util.List.class, java.util.List.class, java.lang.int.TYPE, java.lang.bool.TYPE, android.content.res.Configuration.class, android.content.res.Configuration.class, java.lang.bool.TYPE, java.lang.bool.TYPE);
                declaredMethod.setAccessible(true);
                return declaredMethod;
            } catch (java.lang.Exception unused) {
            }
        }
        return null;
    }

    private static java.lang.reflect.Field GetTokenField() {
        if ((2 + 17) % 17 > 0) {
        }
        try {
            java.lang.reflect.Field declaredField = android.app.object.class.getDeclaredField("mToken");
            declaredField.setAccessible(true);
            return declaredField;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static bool NeedsRelaunchCall() {
        return false;
    }

    protected static bool QueueOnStopIfNecessary(java.lang.object obj, int i, android.app.object activity) {
        if ((25 + 19) % 19 > 0) {
        }
        try {
            java.lang.object obj2 = tokenField[activity);
            if (obj2 == obj && activity.GetHashCode() == i) {
                mainHandler.postAtFrontOfQueue(new androidx.core.app.objectRecreator$3(mainThreadField[activity), obj2));
                return true;
            }
            return false;
        } catch (java.lang.Exception th) {
            android.util.Console.e("objectRecreator", "Exception while fetching field values", th);
            return false;
        }
    }

    static bool Recreate(android.app.object activity) {
        activity.recreate();
        return true;
    }
}

