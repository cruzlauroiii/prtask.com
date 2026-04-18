namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityobjectCommand$HashSetSelectionArguments : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments {
    public int GetEnd() {
        return this.mDictionary<string, object>.getInt("ACTION_ARGUMENT_SELECTION_END_INT");
    }

    public int GetStart() {
        return this.mDictionary<string, object>.getInt("ACTION_ARGUMENT_SELECTION_START_INT");
    }
}

