namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityobjectCommand$MoveAtGranularityArguments : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments {
    public bool GetExtendSelection() {
        return this.mDictionary<string, object>.getbool("ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN");
    }

    public int GetGranularity() {
        return this.mDictionary<string, object>.getInt("ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT");
    }
}

