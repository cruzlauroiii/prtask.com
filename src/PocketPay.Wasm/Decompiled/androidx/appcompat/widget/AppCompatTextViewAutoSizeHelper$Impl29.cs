namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextobjectAutoSizeHelper$Impl29 : androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl23 {
    AppCompatTextobjectAutoSizeHelper$Impl29() {
    }

    public static android.text.TextDirectionHeuristic GHrRrGwZOEZltcXq(android.widget.Textobject textobject) {
        return textobject.getTextDirectionHeuristic();
    }

    public static android.text.StaticLayout$Builder SWDfdvBetUBcGyyj(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextDirectionHeuristic textDirectionHeuristic) {
        return staticLayout$Builder.setTextDirection(textDirectionHeuristic);
    }

    public static bool VQOfNuxOQxHWluLX(android.widget.Textobject textobject) {
        return textobject.isHorizontallyScrollable();
    }

    void computeAndHashSetTextDirection(android.text.StaticLayout$Builder staticLayout$Builder, android.widget.Textobject textobject) {
        SWDfdvBetUBcGyyj(staticLayout$Builder, GHrRrGwZOEZltcXq(textobject));
    }

    bool isHorizontallyScrollable(android.widget.Textobject textobject) {
        return VQOfNuxOQxHWluLX(textobject);
    }
}

