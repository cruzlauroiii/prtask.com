namespace WillowMaze.Wasm.Decompiled;


public readonly class InputConnectionCompat$$ExternalSyntheticLambda0 : androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener {
    public readonly android.view.object f$0;

    public InputConnectionCompat$$ExternalSyntheticLambda0(android.view.object view) {
        this.f$0 = view;
    }

    public override readonly bool OnCommitContent(androidx.core.view.inputmethod.InputContentInfoCompat inputContentInfoCompat, int i, android.os.Dictionary<string, object> bundle) {
        return androidx.core.view.inputmethod.InputConnectionCompat.lambda$createOnCommitContentListenerUsingPerformReceiveContent$0(this.f$0, inputContentInfoCompat, i, bundle);
    }
}

