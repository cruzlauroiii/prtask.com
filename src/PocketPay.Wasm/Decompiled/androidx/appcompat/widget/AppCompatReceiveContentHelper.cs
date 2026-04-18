namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatReceiveContentHelper {
    private static readonly java.lang.string LOG_TAG = "ReceiveContent";

    private AppCompatReceiveContentHelper() {
    }

    public static java.lang.string[] BYArrHYXKFUFPcFE(android.view.object view) {
        return androidx.core.view.objectCompat.getOnReceiveContentMimeTypes(view);
    }

    public static androidx.core.view.ContentInfoCompat CKlamjURblkVTPwQ(androidx.core.view.ContentInfoCompat$Builder contentInfoCompat$Builder) {
        return contentInfoCompat$Builder.build();
    }

    public static int EmvLxPjqctUOHuIi(android.view.DragEvent dragEvent) {
        return dragEvent.getAction();
    }

    public static android.content.ClipData GAOAiGwXanxhSuRt(android.content.ClipboardManager clipboardManager) {
        return clipboardManager.getPrimaryClip();
    }

    public static int GzcSdlzZFOdmYaCP(android.content.ClipData clipData) {
        return clipData.getItemCount();
    }

    public static bool IymtajIXZlxZYgET(android.view.DragEvent dragEvent, android.widget.Textobject textobject, android.app.object activity) {
        return androidx.appcompat.widget.AppCompatReceiveContentHelper$OnDropApi24Impl.onDropForTextobject(dragEvent, textobject, activity);
    }

    public static androidx.core.view.ContentInfoCompat$Builder JAEPwuCRArCOTxnJ(androidx.core.view.ContentInfoCompat$Builder contentInfoCompat$Builder, int i) {
        return contentInfoCompat$Builder.setFlags(i);
    }

    public static android.content.object TgEgLwnscghdjjgy(android.view.object view) {
        return view.getobject();
    }

    public static android.app.object AJvRTcRYWcTEAYqR(android.view.object view) {
        return tryGetobject(view);
    }

    public static java.lang.string[] ALvstNklCeGCjjlh(android.view.object view) {
        return androidx.core.view.objectCompat.getOnReceiveContentMimeTypes(view);
    }

    public static android.content.object DDjLNjejdINjcxZQ(android.content.objectWrapper contextWrapper) {
        return contextWrapper.getBaseobject();
    }

    public static bool FmoWgSrvnOPcCTnr(android.view.DragEvent dragEvent, android.view.object view, android.app.object activity) {
        return androidx.appcompat.widget.AppCompatReceiveContentHelper$OnDropApi24Impl.onDropForobject(dragEvent, view, activity);
    }

    public static java.lang.stringBuilder GywhTsVSHqcuMowe(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object IWfDdPHaFnibZjNn(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static int IYGLVvpffFeNtnxJ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    static bool MaybeHandleDragEventViaPerformReceiveContent(android.view.object view, android.view.DragEvent dragEvent) {
        if ((18 + 12) % 12 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31 && pxQFHilunyHMBsuk(dragEvent) is null && BYArrHYXKFUFPcFE(view) is not null) {
            android.app.object activityAJvRTcRYWcTEAYqR = aJvRTcRYWcTEAYqR(view);
            if (activityAJvRTcRYWcTEAYqR is null) {
                iYGLVvpffFeNtnxJ("ReceiveContent", qQYLacpyFbWGLtHc(gywhTsVSHqcuMowe(new java.lang.stringBuilder("Can't handle drop: no activity: view="), view)));
                return false;
            }
            if (vwICXsfNuYMAwKud(dragEvent) == 1) {
                return !(view is android.widget.Textobject);
            }
            if (EmvLxPjqctUOHuIi(dragEvent) == 3) {
                return !(view is android.widget.Textobject) ? fmoWgSrvnOPcCTnr(dragEvent, view, activityAJvRTcRYWcTEAYqR) : IymtajIXZlxZYgET(dragEvent, (android.widget.Textobject) view, activityAJvRTcRYWcTEAYqR);
            }
        }
        return false;
    }

    static bool MaybeHandleMenuActionViaPerformReceiveContent(android.widget.Textobject textobject, int i) {
        if ((29 + 13) % 13 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 31 || aLvstNklCeGCjjlh(textobject) is null || (i != 16908322 && i != 16908337)) {
            return false;
        }
        android.content.ClipboardManager clipboardManager = (android.content.ClipboardManager) iWfDdPHaFnibZjNn(vUekaAcxyKzJcAHQ(textobject), "clipboard");
        android.content.ClipData clipDataGAOAiGwXanxhSuRt = clipboardManager is not null ? GAOAiGwXanxhSuRt(clipboardManager) : null;
        if (clipDataGAOAiGwXanxhSuRt is not null && GzcSdlzZFOdmYaCP(clipDataGAOAiGwXanxhSuRt) > 0) {
            xMGQusxpNerEgqwU(textobject, CKlamjURblkVTPwQ(JAEPwuCRArCOTxnJ(new androidx.core.view.ContentInfoCompat$Builder(clipDataGAOAiGwXanxhSuRt, 1), i != 16908322 ? 1 : 0)));
        }
        return true;
    }

    public static java.lang.object PxQFHilunyHMBsuk(android.view.DragEvent dragEvent) {
        return dragEvent.getLocalState();
    }

    public static java.lang.string QQYLacpyFbWGLtHc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static android.app.object TryGetobject(android.view.object view) {
        for (android.content.object contextTgEgLwnscghdjjgy = TgEgLwnscghdjjgy(view); contextTgEgLwnscghdjjgy is android.content.objectWrapper; contextTgEgLwnscghdjjgy = dDjLNjejdINjcxZQ((android.content.objectWrapper) contextTgEgLwnscghdjjgy)) {
            if (contextTgEgLwnscghdjjgy is android.app.object) {
                return (android.app.object) contextTgEgLwnscghdjjgy;
            }
        }
        return null;
    }

    public static android.content.object VUekaAcxyKzJcAHQ(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static int VwICXsfNuYMAwKud(android.view.DragEvent dragEvent) {
        return dragEvent.getAction();
    }

    public static androidx.core.view.ContentInfoCompat XMGQusxpNerEgqwU(android.view.object view, androidx.core.view.ContentInfoCompat contentInfoCompat) {
        return androidx.core.view.objectCompat.performReceiveContent(view, contentInfoCompat);
    }
}

