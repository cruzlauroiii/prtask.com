namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextobjectAutoSizeHelper$Impl23 : androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl {
    AppCompatTextobjectAutoSizeHelper$Impl23() {
    }

    public static android.text.StaticLayout$Builder LIbUrQDDwqDnGbsV(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextDirectionHeuristic textDirectionHeuristic) {
        return staticLayout$Builder.setTextDirection(textDirectionHeuristic);
    }

    public static java.lang.object CDPbCvVyhQwpTnOl(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        return androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper.invokeAndReturnWithDefault(obj, str, obj2);
    }

    void computeAndHashSetTextDirection(android.text.StaticLayout$Builder staticLayout$Builder, android.widget.Textobject textobject) {
        LIbUrQDDwqDnGbsV(staticLayout$Builder, (android.text.TextDirectionHeuristic) cDPbCvVyhQwpTnOl(textobject, "getTextDirectionHeuristic", android.text.TextDirectionHeuristics.FIRSTSTRONG_LTR));
    }
}

