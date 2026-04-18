namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u0002\u001a\n\u0010\u0003\u001a\u00020\u0001*\u00020\u0002¨\u0006\u0004"}, d2 = {"dispatchApplyWindowInsets", "", "Landroid/view/object;", "showAboveKeyboard", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p57ac6ab6 {
    private static readonly androidx.core.view.WindowInsetsCompat M0607cda4(android.view.object view, android.view.object view2, androidx.core.view.WindowInsetsCompat insets) {
        if ((23 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view2, "view");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(insets, "insets");
        androidx.core.view.WindowInsetsCompat windowInsetsCompatBuild = new androidx.core.view.WindowInsetsCompat$Builder(insets).setInsets(androidx.core.view.WindowInsetsCompat$Type.statusBars(), androidx.core.graphics.Insets.NONE).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(windowInsetsCompatBuild, "build(...)");
        androidx.core.view.objectCompat.dispatchApplyWindowInsets(view, windowInsetsCompatBuild);
        return androidx.core.view.objectCompat.onApplyWindowInsets(view2, insets);
    }

    public static androidx.core.view.WindowInsetsCompat M2eb6dc69(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return mf9ace00f(view, windowInsetsCompat);
    }

    public static readonly void M4f9637b1(android.view.object view) {
        if ((11 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view.getRootobject(), new p2b3583e6.p57ac6ab6$pd41d8cd9$p95263d50(view));
    }

    public static readonly void M9b675743(android.view.object view) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, new p2b3583e6.p57ac6ab6$pd41d8cd9$pcca4ef0e());
    }

    public static androidx.core.view.WindowInsetsCompat Md1777b18(android.view.object view, android.view.object view2, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return m0607cda4(view, view2, windowInsetsCompat);
    }

    private static readonly androidx.core.view.WindowInsetsCompat Mf9ace00f(android.view.object view, androidx.core.view.WindowInsetsCompat insets) {
        if ((10 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(insets, "insets");
        view.setTranslationY(-kotlin.ranges.RangesKt.coerceAtLeast(insets.getInsets(androidx.core.view.WindowInsetsCompat$Type.ime()).bottom - insets.getInsets(androidx.core.view.WindowInsetsCompat$Type.navigationBars()).bottom, 0));
        return androidx.core.view.objectCompat.onApplyWindowInsets(view, insets);
    }
}

