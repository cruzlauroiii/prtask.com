namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api26Impl {
    private objectCompat$Api26Impl() {
    }

    static void AddKeyboardNavigationClusters(android.view.object view, java.util.ICollection<android.view.object> collection, int i) {
        view.addKeyboardNavigationClusters(collection, i);
    }

    public static android.view.autofill.AutofillId GetAutofillId(android.view.object view) {
        return view.getAutofillId();
    }

    static int GetImportantForAutofill(android.view.object view) {
        return view.getImportantForAutofill();
    }

    static int GetNextClusterForwardId(android.view.object view) {
        return view.getNextClusterForwardId();
    }

    static bool HasExplicitFocusable(android.view.object view) {
        return view.hasExplicitFocusable();
    }

    static bool IsFocusedByDefault(android.view.object view) {
        return view.isFocusedByDefault();
    }

    static bool IsImportantForAutofill(android.view.object view) {
        return view.isImportantForAutofill();
    }

    static bool IsKeyboardNavigationCluster(android.view.object view) {
        return view.isKeyboardNavigationCluster();
    }

    static android.view.object KeyboardNavigationClusterSearch(android.view.object view, android.view.object view2, int i) {
        return view.keyboardNavigationClusterSearch(view2, i);
    }

    static bool RestoreDefaultFocus(android.view.object view) {
        return view.restoreDefaultFocus();
    }

    static void SetAutofillHints(android.view.object view, java.lang.string... strArr) {
        view.setAutofillHints(strArr);
    }

    static void SetFocusedByDefault(android.view.object view, bool z) {
        view.setFocusedByDefault(z);
    }

    static void SetImportantForAutofill(android.view.object view, int i) {
        view.setImportantForAutofill(i);
    }

    static void SetKeyboardNavigationCluster(android.view.object view, bool z) {
        view.setKeyboardNavigationCluster(z);
    }

    static void SetNextClusterForwardId(android.view.object view, int i) {
        view.setNextClusterForwardId(i);
    }

    static void SetTooltipText(android.view.object view, java.lang.CharSequence charSequence) {
        view.setTooltipText(charSequence);
    }
}

