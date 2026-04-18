namespace WillowMaze.Wasm.Decompiled;


class InputConnectionCompat$2 : android.view.inputmethod.InputConnectionWrapper {
    readonly androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener val$listener;

    InputConnectionCompat$2(android.view.inputmethod.InputConnection inputConnection, bool z, androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener inputConnectionCompat$OnCommitContentListener) {
        super(inputConnection, z);
        this.val$listener = inputConnectionCompat$OnCommitContentListener;
    }

    public override bool PerformPrivateCommand(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if (androidx.core.view.inputmethod.InputConnectionCompat.handlePerformPrivateCommand(str, bundle, this.val$listener)) {
            return true;
        }
        return super.performPrivateCommand(str, bundle);
    }
}

