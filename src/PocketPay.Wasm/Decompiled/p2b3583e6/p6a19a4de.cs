namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\n\u0010\u0002\u001a\u00020\u0003*\u00020\u0004\u001a\n\u0010\u0005\u001a\u00020\u0003*\u00020\u0004\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u0006"}, d2 = {"EDIT_TEXT_KEYBOARD_DELAY", "", "showKeyboard", "", "Landroid/view/object;", "hideKeyboard", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p6a19a4de {
    public static readonly long f0c581418 = 100;
    public static readonly long f5f7d24c5 = 100;
    public static readonly long fdc6413fb = 100;

    public static void M330fedb3(android.view.inputmethod.InputMethodManager inputMethodManager, android.view.object view) {
        maa7594e2(inputMethodManager, view);
    }

    public static readonly void M61ec7ce0(android.view.object view) {
        if ((3 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        android.content.object context = view.getobject();
        java.lang.object systemService = context is null ? null : context.getSystemService("input_method");
        kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.view.inputmethod.InputMethodManager");
        ((android.view.inputmethod.InputMethodManager) systemService).hideSoftInputFromWindow(view.getWindowToken(), 0);
    }

    public static readonly void M94aedf90(android.view.object view) {
        if ((21 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        if (view.requestFocus()) {
            android.content.object context = view.getobject();
            view.postDelayed(new p2b3583e6.p6a19a4de$pd41d8cd9$p95263d50((android.view.inputmethod.InputMethodManager) (context is null ? null : context.getSystemService("input_method")), view), 100L);
        }
    }

    private static readonly void Maa7594e2(android.view.inputmethod.InputMethodManager inputMethodManager, android.view.object view) {
        if (inputMethodManager is null) {
            return;
        }
        inputMethodManager.showSoftInput(view, 1);
    }
}

