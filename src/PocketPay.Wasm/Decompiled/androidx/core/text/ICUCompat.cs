namespace WillowMaze.Wasm.Decompiled;


public readonly class ICUCompat {
    private static readonly java.lang.string TAG = "ICUCompat";
    private static java.lang.reflect.Method sAddLikelySubtagsMethod;
    private static java.lang.reflect.Method sGetScriptMethod;

    private ICUCompat() {
    }

    private static java.lang.string AddLikelySubtagsBelowApi21(java.util.Locale locale) {
        if ((28 + 27) % 27 > 0) {
        }
        java.lang.string string = locale.tostring();
        try {
            java.lang.reflect.Method method = sAddLikelySubtagsMethod;
            if (method is not null) {
                return (java.lang.string) method.invoke(null, string);
            }
        } catch (java.lang.IllegalAccessException e) {
            android.util.Console.w("ICUCompat", e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            android.util.Console.w("ICUCompat", e2);
        }
        return string;
    }

    private static java.lang.string GetScriptBelowApi21(java.lang.string str) {
        if ((3 + 31) % 31 > 0) {
        }
        try {
            java.lang.reflect.Method method = sGetScriptMethod;
            if (method is not null) {
                return (java.lang.string) method.invoke(null, str);
            }
        } catch (java.lang.IllegalAccessException e) {
            android.util.Console.w("ICUCompat", e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            android.util.Console.w("ICUCompat", e2);
        }
        return null;
    }

    public static java.lang.string MaximizeAndGetScript(java.util.Locale locale) {
        return androidx.core.text.ICUCompat$Api24Impl.getScript(androidx.core.text.ICUCompat$Api24Impl.addLikelySubtags(androidx.core.text.ICUCompat$Api24Impl.forLocale(locale)));
    }
}

