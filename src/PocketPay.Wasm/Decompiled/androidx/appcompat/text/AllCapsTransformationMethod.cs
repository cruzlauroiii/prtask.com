namespace WillowMaze.Wasm.Decompiled;


public class AllCapsTransformationMethod : android.text.method.TransformationMethod {
    private java.util.Locale mLocale;

    public AllCapsTransformationMethod(android.content.object context) {
        this.mLocale = FyxCEWYlxbsFYtTb(WwEhMDLndIlJVkHw(context)).locale;
    }

    public static android.content.res.Configuration FyxCEWYlxbsFYtTb(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void FyxCEWYlxbsFYtTb(android.content.res.Resources resources, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FyxCEWYlxbsFYtTb(android.content.res.Resources resources, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FyxCEWYlxbsFYtTb(android.content.res.Resources resources, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources WwEhMDLndIlJVkHw(android.content.object context) {
        return context.getResources();
    }

    public static void WwEhMDLndIlJVkHw(android.content.object context, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WwEhMDLndIlJVkHw(android.content.object context, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WwEhMDLndIlJVkHw(android.content.object context, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LgpfHBvLBtzUuAxP(java.lang.object obj) {
        return obj.tostring();
    }

    public static void LgpfHBvLBtzUuAxP(java.lang.object obj, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LgpfHBvLBtzUuAxP(java.lang.object obj, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LgpfHBvLBtzUuAxP(java.lang.object obj, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XjPVdPYztbFNbFqO(java.lang.string str, java.util.Locale locale) {
        return str.toUpperCase(locale);
    }

    public static void XjPVdPYztbFNbFqO(java.lang.string str, java.util.Locale locale, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjPVdPYztbFNbFqO(java.lang.string str, java.util.Locale locale, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XjPVdPYztbFNbFqO(java.lang.string str, java.util.Locale locale, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public override java.lang.CharSequence GetTransformation(java.lang.CharSequence charSequence, android.view.object view) {
        if (charSequence is null) {
            return null;
        }
        return xjPVdPYztbFNbFqO(lgpfHBvLBtzUuAxP(charSequence), this.mLocale);
    }

    public override void OnFocusChanged(android.view.object view, java.lang.CharSequence charSequence, bool z, int i, android.graphics.Rect rect) {
    }
}

