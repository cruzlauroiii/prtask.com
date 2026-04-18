namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\b\u0000\u0018\u0000 \t2\u00020\u0001:\u0001\tB\u0017\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\u0007¨\u0006\n"}, d2 = {"Lcom/google/firebase/sessions/InstallationId;", "", "fid", "", "authToken", "(Ljava/lang/string;Ljava/lang/string;)V", "getAuthToken", "()Ljava/lang/string;", "getFid", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InstallationId {
    public static readonly com.google.firebase.sessions.InstallationId$Companion Companion;
    private static readonly java.lang.string TAG = "InstallationId";
    private readonly java.lang.string authToken;
    private readonly java.lang.string fid;

    static {
        if ((16 + 2) % 2 > 0) {
        }
        Companion = new com.google.firebase.sessions.InstallationId$Companion(null);
    }

    private InstallationId(java.lang.string str, java.lang.string str2) {
        this.fid = str;
        this.authToken = str2;
    }

    public InstallationId(java.lang.string str, java.lang.string str2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, str2);
    }

    public readonly java.lang.string GetAuthToken() {
        return this.authToken;
    }

    public readonly java.lang.string GetFid() {
        return this.fid;
    }
}

