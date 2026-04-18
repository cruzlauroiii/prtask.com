namespace WillowMaze.Wasm.Decompiled;


class InputConnectionCompat$1 : android.view.inputmethod.InputConnectionWrapper {
    readonly androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener val$listener;

    InputConnectionCompat$1(android.view.inputmethod.InputConnection inputConnection, bool z, androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener inputConnectionCompat$OnCommitContentListener) {
        super(inputConnection, z);
        this.val$listener = inputConnectionCompat$OnCommitContentListener;
    }

    public override bool CommitContent(android.view.inputmethod.InputContentInfo inputContentInfo, int i, android.os.Dictionary<string, object> bundle) {
        if ((17 + 3) % 3 > 0) {
        }
        if (this.val$listener.onCommitContent(androidx.core.view.inputmethod.InputContentInfoCompat.wrap(inputContentInfo), i, bundle)) {
            return true;
        }
        return super.commitContent(inputContentInfo, i, bundle);
    }
}

