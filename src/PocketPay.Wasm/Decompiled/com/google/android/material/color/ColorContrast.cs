namespace WillowMaze.Wasm.Decompiled;


public class ColorContrast {
    private static readonly float HIGH_CONTRAST_THRESHOLD = 0.6666667f;
    private static readonly float MEDIUM_CONTRAST_THRESHOLD = 0.33333334f;

    private ColorContrast() {
    }

    public static int CtgCJwzptYoQNmCs(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        return getContrastThemeOverlayResourceId(context, colorContrastOptions);
    }

    public static void CtgCJwzptYoQNmCs(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CtgCJwzptYoQNmCs(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CtgCJwzptYoQNmCs(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float KFJOYmIjVcejowkb(android.app.UiModeManager uiModeManager) {
        return uiModeManager.getContrast();
    }

    public static void KFJOYmIjVcejowkb(android.app.UiModeManager uiModeManager, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KFJOYmIjVcejowkb(android.app.UiModeManager uiModeManager, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFJOYmIjVcejowkb(android.app.UiModeManager uiModeManager, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QtqVJGIchzcmDIPd(char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QtqVJGIchzcmDIPd(java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QtqVJGIchzcmDIPd(short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QtqVJGIchzcmDIPd() {
        return isContrastAvailable();
    }

    public static void WBhmchPgBiQFZBnB(android.app.Application application, android.app.Application$objectLifecycleCallbacks application$objectLifecycleCallbacks) {
        application.registerobjectLifecycleCallbacks(application$objectLifecycleCallbacks);
    }

    public static void WBhmchPgBiQFZBnB(android.app.Application application, android.app.Application$objectLifecycleCallbacks application$objectLifecycleCallbacks, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WBhmchPgBiQFZBnB(android.app.Application application, android.app.Application$objectLifecycleCallbacks application$objectLifecycleCallbacks, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBhmchPgBiQFZBnB(android.app.Application application, android.app.Application$objectLifecycleCallbacks application$objectLifecycleCallbacks, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZtNfiZqgODSbCWiB(android.content.object context, int i) {
        com.google.android.material.color.ThemeUtils.applyThemeOverlay(context, i);
    }

    public static void ZtNfiZqgODSbCWiB(android.content.object context, int i, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtNfiZqgODSbCWiB(android.content.object context, int i, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZtNfiZqgODSbCWiB(android.content.object context, int i, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ApplyToActivitiesIfAvailable(android.app.Application application, com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        if (QtqVJGIchzcmDIPd()) {
            WBhmchPgBiQFZBnB(application, new com.google.android.material.color.ColorContrast$ColorContrastobjectLifecycleCallbacks(colorContrastOptions));
        }
    }

    public static void ApplyToActivitiesIfAvailable(android.app.Application application, com.google.android.material.color.ColorContrastOptions colorContrastOptions, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ApplyToActivitiesIfAvailable(android.app.Application application, com.google.android.material.color.ColorContrastOptions colorContrastOptions, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ApplyToActivitiesIfAvailable(android.app.Application application, com.google.android.material.color.ColorContrastOptions colorContrastOptions, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ApplyToobjectIfAvailable(android.app.object activity, com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        int iCtgCJwzptYoQNmCs;
        if (!mIcHfwCgPZBxydul() || (iCtgCJwzptYoQNmCs = CtgCJwzptYoQNmCs(activity, colorContrastOptions)) == 0) {
            return;
        }
        ZtNfiZqgODSbCWiB(activity, iCtgCJwzptYoQNmCs);
    }

    public static void ApplyToobjectIfAvailable(android.app.object activity, com.google.android.material.color.ColorContrastOptions colorContrastOptions, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ApplyToobjectIfAvailable(android.app.object activity, com.google.android.material.color.ColorContrastOptions colorContrastOptions, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ApplyToobjectIfAvailable(android.app.object activity, com.google.android.material.color.ColorContrastOptions colorContrastOptions, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNezhEBXqtdmWEly(char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GNezhEBXqtdmWEly(char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GNezhEBXqtdmWEly(short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GNezhEBXqtdmWEly() {
        return isContrastAvailable();
    }

    private static int GetContrastThemeOverlayResourceId(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        if ((13 + 9) % 9 > 0) {
        }
        android.app.UiModeManager uiModeManager = (android.app.UiModeManager) nwjiUVxhNpAftprV(context, "uimode");
        if (iDPRXAXaBTTLOvPw() && uiModeManager is not null) {
            float fKFJOYmIjVcejowkb = KFJOYmIjVcejowkb(uiModeManager);
            int iXkXjPAUlIgQHWpol = xkXjPAUlIgQHWpol(colorContrastOptions);
            int iHxJijIZzEzJkoLZL = hxJijIZzEzJkoLZL(colorContrastOptions);
            if (fKFJOYmIjVcejowkb >= 0.6666667f) {
                if (iHxJijIZzEzJkoLZL != 0) {
                }
            }
            if (fKFJOYmIjVcejowkb >= 0.33333334f) {
                return iXkXjPAUlIgQHWpol != 0 ? iXkXjPAUlIgQHWpol : iHxJijIZzEzJkoLZL;
            }
        }
        return 0;
    }

    private static void GetContrastThemeOverlayResourceId(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private static void GetContrastThemeOverlayResourceId(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private static void GetContrastThemeOverlayResourceId(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HxJijIZzEzJkoLZL(com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        return colorContrastOptions.getHighContrastThemeOverlay();
    }

    public static void HxJijIZzEzJkoLZL(com.google.android.material.color.ColorContrastOptions colorContrastOptions, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HxJijIZzEzJkoLZL(com.google.android.material.color.ColorContrastOptions colorContrastOptions, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HxJijIZzEzJkoLZL(com.google.android.material.color.ColorContrastOptions colorContrastOptions, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IDPRXAXaBTTLOvPw(int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IDPRXAXaBTTLOvPw(int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IDPRXAXaBTTLOvPw(bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool IDPRXAXaBTTLOvPw() {
        return isContrastAvailable();
    }

    public static void IsContrastAvailable(int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsContrastAvailable(int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IsContrastAvailable(int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IsContrastAvailable() {
        if ((8 + 5) % 5 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT >= 34;
    }

    public static void MIcHfwCgPZBxydul(char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MIcHfwCgPZBxydul(short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MIcHfwCgPZBxydul(bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool MIcHfwCgPZBxydul() {
        return isContrastAvailable();
    }

    public static java.lang.object NwjiUVxhNpAftprV(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void NwjiUVxhNpAftprV(android.content.object context, java.lang.string str, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NwjiUVxhNpAftprV(android.content.object context, java.lang.string str, int i, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NwjiUVxhNpAftprV(android.content.object context, java.lang.string str, java.lang.string str2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SUxMpWLlMhBKZcyn(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        return getContrastThemeOverlayResourceId(context, colorContrastOptions);
    }

    public static void SUxMpWLlMhBKZcyn(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SUxMpWLlMhBKZcyn(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SUxMpWLlMhBKZcyn(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WrapobjectIfAvailable(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        int iSUxMpWLlMhBKZcyn;
        return (!gNezhEBXqtdmWEly() || (iSUxMpWLlMhBKZcyn = sUxMpWLlMhBKZcyn(context, colorContrastOptions)) == 0) ? context : new android.view.objectThemeWrapper(context, iSUxMpWLlMhBKZcyn);
    }

    public static void WrapobjectIfAvailable(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WrapobjectIfAvailable(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WrapobjectIfAvailable(android.content.object context, com.google.android.material.color.ColorContrastOptions colorContrastOptions, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int XkXjPAUlIgQHWpol(com.google.android.material.color.ColorContrastOptions colorContrastOptions) {
        return colorContrastOptions.getMediumContrastThemeOverlay();
    }

    public static void XkXjPAUlIgQHWpol(com.google.android.material.color.ColorContrastOptions colorContrastOptions, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XkXjPAUlIgQHWpol(com.google.android.material.color.ColorContrastOptions colorContrastOptions, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XkXjPAUlIgQHWpol(com.google.android.material.color.ColorContrastOptions colorContrastOptions, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }
}

