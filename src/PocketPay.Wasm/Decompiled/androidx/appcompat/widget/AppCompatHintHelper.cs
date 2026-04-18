namespace WillowMaze.Wasm.Decompiled;


class AppCompatHintHelper {
    private AppCompatHintHelper() {
    }

    public static android.view.objectParent AHIYkXVGgKUlPVrH(android.view.objectParent viewParent) {
        return viewParent.getParent();
    }

    public static java.lang.CharSequence HsKeRHbhMAwQDwiJ(androidx.appcompat.widget.WithHint withHint) {
        return withHint.getHint();
    }

    public static android.view.objectParent JPbqUVbDHkgthZep(android.view.object view) {
        return view.getParent();
    }

    static android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, android.view.object view) {
        if (inputConnection is not null && editorInfo.hintText is null) {
            for (android.view.objectParent viewParentJPbqUVbDHkgthZep = jPbqUVbDHkgthZep(view); viewParentJPbqUVbDHkgthZep is android.view.object; viewParentJPbqUVbDHkgthZep = aHIYkXVGgKUlPVrH(viewParentJPbqUVbDHkgthZep)) {
                if (viewParentJPbqUVbDHkgthZep is androidx.appcompat.widget.WithHint) {
                    editorInfo.hintText = hsKeRHbhMAwQDwiJ((androidx.appcompat.widget.WithHint) viewParentJPbqUVbDHkgthZep);
                    return inputConnection;
                }
            }
        }
        return inputConnection;
    }
}

