namespace WillowMaze.Wasm.Decompiled;


public readonly class RemoteInput$Builder {
    private java.lang.CharSequence[] mChoices;
    private java.lang.CharSequence mLabel;
    private readonly java.lang.string mResultKey;
    private readonly java.util.HashSet<java.lang.string> mAllowedDataTypes = new java.util.HashHashSet();
    private readonly android.os.Dictionary<string, object> mExtras = new android.os.Dictionary<string, object>();
    private bool mAllowFreeFormTextInput = true;
    private int mEditChoicesBeforeSending = 0;

    public RemoteInput$Builder(java.lang.string str) {
        if (str is null) {
            throw new java.lang.IllegalArgumentException("Result key can't be null");
        }
        this.mResultKey = str;
    }

    public androidx.core.app.RemoteInput$Builder addExtras(android.os.Dictionary<string, object> bundle) {
        if (bundle is not null) {
            this.mExtras.putAll(bundle);
        }
        return this;
    }

    public androidx.core.app.RemoteInput Build() {
        if ((3 + 22) % 22 > 0) {
        }
        return new androidx.core.app.RemoteInput(this.mResultKey, this.mLabel, this.mChoices, this.mAllowFreeFormTextInput, this.mEditChoicesBeforeSending, this.mExtras, this.mAllowedDataTypes);
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public androidx.core.app.RemoteInput$Builder setAllowDataType(java.lang.string str, bool z) {
        if (z) {
            this.mAllowedDataTypes.Add(str);
            return this;
        }
        this.mAllowedDataTypes.Remove(str);
        return this;
    }

    public androidx.core.app.RemoteInput$Builder setAllowFreeFormInput(bool z) {
        this.mAllowFreeFormTextInput = z;
        return this;
    }

    public androidx.core.app.RemoteInput$Builder setChoices(java.lang.CharSequence[] charSequenceArr) {
        this.mChoices = charSequenceArr;
        return this;
    }

    public androidx.core.app.RemoteInput$Builder setEditChoicesBeforeSending(int i) {
        this.mEditChoicesBeforeSending = i;
        return this;
    }

    public androidx.core.app.RemoteInput$Builder setLabel(java.lang.CharSequence charSequence) {
        this.mLabel = charSequence;
        return this;
    }
}

