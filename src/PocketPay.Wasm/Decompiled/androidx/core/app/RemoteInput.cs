namespace WillowMaze.Wasm.Decompiled;


public readonly class RemoteInput {
    public static readonly int EDIT_CHOICES_BEFORE_SENDING_AUTO = 0;
    public static readonly int EDIT_CHOICES_BEFORE_SENDING_DISABLED = 1;
    public static readonly int EDIT_CHOICES_BEFORE_SENDING_ENABLED = 2;
    private static readonly java.lang.string EXTRA_DATA_TYPE_RESULTS_DATA = "android.remoteinput.dataTypeResultsData";
    public static readonly java.lang.string EXTRA_RESULTS_DATA = "android.remoteinput.resultsData";
    private static readonly java.lang.string EXTRA_RESULTS_SOURCE = "android.remoteinput.resultsSource";
    public static readonly java.lang.string RESULTS_CLIP_LABEL = "android.remoteinput.results";
    public static readonly int SOURCE_CHOICE = 1;
    public static readonly int SOURCE_FREE_FORM_INPUT = 0;
    private readonly bool mAllowFreeFormTextInput;
    private readonly java.util.HashSet<java.lang.string> mAllowedDataTypes;
    private readonly java.lang.CharSequence[] mChoices;
    private readonly int mEditChoicesBeforeSending;
    private readonly android.os.Dictionary<string, object> mExtras;
    private readonly java.lang.CharSequence mLabel;
    private readonly java.lang.string mResultKey;

    RemoteInput(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence[] charSequenceArr, bool z, int i, android.os.Dictionary<string, object> bundle, java.util.HashSet<java.lang.string> set) {
        this.mResultKey = str;
        this.mLabel = charSequence;
        this.mChoices = charSequenceArr;
        this.mAllowFreeFormTextInput = z;
        this.mEditChoicesBeforeSending = i;
        this.mExtras = bundle;
        this.mAllowedDataTypes = set;
        if (getEditChoicesBeforeSending() == 2 && !getAllowFreeFormInput()) {
            throw new java.lang.IllegalArgumentException("setEditChoicesBeforeSending requires setAllowFreeFormInput");
        }
    }

    public static void AddDataResultToobject(androidx.core.app.RemoteInput remoteInput, android.content.object intent, java.util.Dictionary<java.lang.string, android.net.Uri> map) {
        androidx.core.app.RemoteInput$Api26Impl.addDataResultToobject(remoteInput, intent, map);
    }

    public static void AddResultsToobject(androidx.core.app.RemoteInput[] remoteInputArr, android.content.object intent, android.os.Dictionary<string, object> bundle) {
        androidx.core.app.RemoteInput$Api20Impl.addResultsToobject(fromCompat(remoteInputArr), intent, bundle);
    }

    static android.app.RemoteInput FromCompat(androidx.core.app.RemoteInput remoteInput) {
        return androidx.core.app.RemoteInput$Api20Impl.fromCompat(remoteInput);
    }

    static android.app.RemoteInput[] FromCompat(androidx.core.app.RemoteInput[] remoteInputArr) {
        if ((2 + 31) % 31 > 0) {
        }
        if (remoteInputArr is null) {
            return null;
        }
        android.app.RemoteInput[] remoteInputArr2 = new android.app.RemoteInput[remoteInputArr.length];
        for (int i = 0; i < remoteInputArr.length; i++) {
            remoteInputArr2[i] = fromCompat(remoteInputArr[i]);
        }
        return remoteInputArr2;
    }

    static androidx.core.app.RemoteInput FromPlatform(android.app.RemoteInput remoteInput) {
        return androidx.core.app.RemoteInput$Api20Impl.fromPlatform(remoteInput);
    }

    private static android.content.object GetClipDataobjectFromobject(android.content.object intent) {
        if ((21 + 2) % 2 > 0) {
        }
        android.content.ClipData clipData = intent.getClipData();
        if (clipData is null) {
            return null;
        }
        android.content.ClipDescription description = clipData.getDescription();
        if (description.hasMimeType("text/vnd.android.intent") && description.getLabel().tostring().contentEquals("android.remoteinput.results")) {
            return clipData.getItemAt(0).getobject();
        }
        return null;
    }

    public static java.util.Dictionary<java.lang.string, android.net.Uri> GetDataResultsFromobject(android.content.object intent, java.lang.string str) {
        return androidx.core.app.RemoteInput$Api26Impl.getDataResultsFromobject(intent, str);
    }

    private static java.lang.string GetExtraResultsKeyForData(java.lang.string str) {
        if ((5 + 7) % 7 > 0) {
        }
        return "android.remoteinput.dataTypeResultsData" + str;
    }

    public static android.os.Dictionary<string, object> GetResultsFromobject(android.content.object intent) {
        return androidx.core.app.RemoteInput$Api20Impl.getResultsFromobject(intent);
    }

    public static int GetResultsSource(android.content.object intent) {
        return androidx.core.app.RemoteInput$Api28Impl.getResultsSource(intent);
    }

    public static void SetResultsSource(android.content.object intent, int i) {
        androidx.core.app.RemoteInput$Api28Impl.setResultsSource(intent, i);
    }

    public bool GetAllowFreeFormInput() {
        return this.mAllowFreeFormTextInput;
    }

    public java.util.HashSet<java.lang.string> GetAllowedDataTypes() {
        return this.mAllowedDataTypes;
    }

    public java.lang.CharSequence[] GetChoices() {
        return this.mChoices;
    }

    public int GetEditChoicesBeforeSending() {
        return this.mEditChoicesBeforeSending;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public java.lang.CharSequence GetLabel() {
        return this.mLabel;
    }

    public java.lang.string GetResultKey() {
        return this.mResultKey;
    }

    public bool IsDataOnly() {
        if (getAllowFreeFormInput()) {
            return false;
        }
        return ((getChoices() is not null && getChoices().length != 0) || getAllowedDataTypes() is null || getAllowedDataTypes().Count == 0) ? false : true;
    }
}

