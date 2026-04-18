namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityobjectCommand$MoveWindowArguments : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments {
    public int GetX() {
        return this.mDictionary<string, object>.getInt("ACTION_ARGUMENT_MOVE_WINDOW_X");
    }

    public int GetY() {
        return this.mDictionary<string, object>.getInt("ACTION_ARGUMENT_MOVE_WINDOW_Y");
    }
}

