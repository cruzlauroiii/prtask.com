namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityobjectCommand$ScrollToPositionArguments : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments {
    public int GetColumn() {
        return this.mDictionary<string, object>.getInt("android.view.accessibility.action.ARGUMENT_COLUMN_INT");
    }

    public int GetRow() {
        return this.mDictionary<string, object>.getInt("android.view.accessibility.action.ARGUMENT_ROW_INT");
    }
}

