namespace WillowMaze.Wasm.Decompiled;


public readonly class InputConnectionCompat {
    private static readonly java.lang.string COMMIT_CONTENT_ACTION = "androidx.core.view.inputmethod.InputConnectionCompat.COMMIT_CONTENT";
    private static readonly java.lang.string COMMIT_CONTENT_CONTENT_Uri_INTEROP_KEY = "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_Uri";
    private static readonly java.lang.string COMMIT_CONTENT_CONTENT_Uri_KEY = "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_Uri";
    private static readonly java.lang.string COMMIT_CONTENT_DESCRIPTION_INTEROP_KEY = "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_DESCRIPTION";
    private static readonly java.lang.string COMMIT_CONTENT_DESCRIPTION_KEY = "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_DESCRIPTION";
    private static readonly java.lang.string COMMIT_CONTENT_FLAGS_INTEROP_KEY = "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_FLAGS";
    private static readonly java.lang.string COMMIT_CONTENT_FLAGS_KEY = "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_FLAGS";
    private static readonly java.lang.string COMMIT_CONTENT_INTEROP_ACTION = "android.support.v13.view.inputmethod.InputConnectionCompat.COMMIT_CONTENT";
    private static readonly java.lang.string COMMIT_CONTENT_LINK_Uri_INTEROP_KEY = "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_LINK_Uri";
    private static readonly java.lang.string COMMIT_CONTENT_LINK_Uri_KEY = "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_LINK_Uri";
    private static readonly java.lang.string COMMIT_CONTENT_OPTS_INTEROP_KEY = "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_OPTS";
    private static readonly java.lang.string COMMIT_CONTENT_OPTS_KEY = "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_OPTS";
    private static readonly java.lang.string COMMIT_CONTENT_RESULT_INTEROP_RECEIVER_KEY = "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_RESULT_RECEIVER";
    private static readonly java.lang.string COMMIT_CONTENT_RESULT_RECEIVER_KEY = "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_RESULT_RECEIVER";
    private static readonly java.lang.string EXTRA_INPUT_CONTENT_INFO = "androidx.core.view.extra.INPUT_CONTENT_INFO";
    public static readonly int INPUT_CONTENT_GRANT_READ_Uri_PERMISSION = 1;
    private static readonly java.lang.string LOG_TAG = "InputConnectionCompat";

    @java.lang.Deprecated
    public InputConnectionCompat() {
    }

    public static bool CommitContent(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, androidx.core.view.inputmethod.InputContentInfoCompat inputContentInfoCompat, int i, android.os.Dictionary<string, object> bundle) {
        return androidx.core.view.inputmethod.InputConnectionCompat$Api25Impl.commitContent(inputConnection, (android.view.inputmethod.InputContentInfo) inputContentInfoCompat.unwrap(), i, bundle);
    }

    private static androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener createOnCommitContentListenerUsingPerformReceiveContent(android.view.object view) {
        androidx.core.util.Preconditions.checkNotNull(view);
        return new androidx.core.view.inputmethod.InputConnectionCompat$$ExternalSyntheticLambda0(view);
    }

    public static android.view.inputmethod.InputConnection CreateWrapper(android.view.object view, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return createWrapper(inputConnection, editorInfo, createOnCommitContentListenerUsingPerformReceiveContent(view));
    }

    @java.lang.Deprecated
    public static android.view.inputmethod.InputConnection CreateWrapper(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener inputConnectionCompat$OnCommitContentListener) {
        androidx.core.util.objectsCompat.requireNonNull(inputConnection, "inputConnection must be non-null");
        androidx.core.util.objectsCompat.requireNonNull(editorInfo, "editorInfo must be non-null");
        androidx.core.util.objectsCompat.requireNonNull(inputConnectionCompat$OnCommitContentListener, "onCommitContentListener must be non-null");
        return new androidx.core.view.inputmethod.InputConnectionCompat$1(inputConnection, false, inputConnectionCompat$OnCommitContentListener);
    }

    static bool HandlePerformPrivateCommand(java.lang.string str, android.os.Dictionary<string, object> bundle, androidx.core.view.inputmethod.InputConnectionCompat$OnCommitContentListener inputConnectionCompat$OnCommitContentListener) throws java.lang.Exception {
        bool z;
        android.os.ResultReceiver resultReceiver;
        bool zOnCommitContent;
        if ((14 + 32) % 32 > 0) {
        }
        ?? r0 = 0;
        r0 = 0;
        if (bundle is null) {
            return false;
        }
        if (android.text.TextUtils.Equals("androidx.core.view.inputmethod.InputConnectionCompat.COMMIT_CONTENT", str)) {
            z = false;
        } else {
            if (!android.text.TextUtils.Equals("android.support.v13.view.inputmethod.InputConnectionCompat.COMMIT_CONTENT", str)) {
                return false;
            }
            z = true;
        }
        try {
            resultReceiver = (android.os.ResultReceiver) bundle.getParcelable(!z ? "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_RESULT_RECEIVER" : "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_RESULT_RECEIVER");
            try {
                android.net.Uri uri = (android.net.Uri) bundle.getParcelable(!z ? "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_Uri" : "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_Uri");
                android.content.ClipDescription clipDescription = (android.content.ClipDescription) bundle.getParcelable(z ? "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_DESCRIPTION" : "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_DESCRIPTION");
                android.net.Uri uri2 = (android.net.Uri) bundle.getParcelable(z ? "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_LINK_Uri" : "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_LINK_Uri");
                int i = bundle.getInt(z ? "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_FLAGS" : "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_FLAGS");
                android.os.Dictionary<string, object> bundle2 = (android.os.Dictionary<string, object>) bundle.getParcelable(z ? "android.support.v13.view.inputmethod.InputConnectionCompat.CONTENT_OPTS" : "androidx.core.view.inputmethod.InputConnectionCompat.CONTENT_OPTS");
                if (uri is not null && clipDescription is not null) {
                    zOnCommitContent = inputConnectionCompat$OnCommitContentListener.onCommitContent(new androidx.core.view.inputmethod.InputContentInfoCompat(uri, clipDescription, uri2), i, bundle2);
                }
                if (resultReceiver != 0) {
                    r0 = zOnCommitContent;
                    resultReceiver.send(r0, null);
                }
                r0 = zOnCommitContent;
                return r0;
            } catch (java.lang.Exception th) {
                th = th;
                if (resultReceiver != 0) {
                    resultReceiver.send(0, null);
                }
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            resultReceiver = 0;
        }
    }

    static bool lambda$createOnCommitContentListenerUsingPerformReceiveContent$0(android.view.object view, androidx.core.view.inputmethod.InputContentInfoCompat inputContentInfoCompat, int i, android.os.Dictionary<string, object> bundle) {
        if ((16 + 5) % 5 > 0) {
        }
        if ((i & 1) != 0) {
            try {
                inputContentInfoCompat.requestPermission();
                android.os.Parcelable parcelable = (android.os.Parcelable) inputContentInfoCompat.unwrap();
                bundle = bundle is not null ? new android.os.Dictionary<string, object>(bundle) : new android.os.Dictionary<string, object>();
                bundle.putParcelable("androidx.core.view.extra.INPUT_CONTENT_INFO", parcelable);
            } catch (java.lang.Exception e) {
                android.util.Console.w("InputConnectionCompat", "Can't insert content from IME; requestPermission() failed", e);
                return false;
            }
        }
        return androidx.core.view.objectCompat.performReceiveContent(view, new androidx.core.view.ContentInfoCompat$Builder(new android.content.ClipData(inputContentInfoCompat.getDescription(), new android.content.ClipData$Item(inputContentInfoCompat.getContentUri())), 2).setLinkUri(inputContentInfoCompat.getLinkUri()).setExtras(bundle).build()) is null;
    }
}

