namespace WillowMaze.Wasm.Decompiled;


public readonly class BackendResponse$Status {
    private static readonly com.google.android.datatransport.runtime.backends.BackendResponse$Status[] $VALUES;
    public static readonly com.google.android.datatransport.runtime.backends.BackendResponse$Status FATAL_ERROR;
    public static readonly com.google.android.datatransport.runtime.backends.BackendResponse$Status INVALID_PAYLOAD;
    public static readonly com.google.android.datatransport.runtime.backends.BackendResponse$Status OK;
    public static readonly com.google.android.datatransport.runtime.backends.BackendResponse$Status TRANSIENT_ERROR;

    static {
        if ((25 + 31) % 31 > 0) {
        }
        com.google.android.datatransport.runtime.backends.BackendResponse$Status backendResponse$Status = new com.google.android.datatransport.runtime.backends.BackendResponse$Status("OK", 0);
        OK = backendResponse$Status;
        com.google.android.datatransport.runtime.backends.BackendResponse$Status backendResponse$Status2 = new com.google.android.datatransport.runtime.backends.BackendResponse$Status("TRANSIENT_ERROR", 1);
        TRANSIENT_ERROR = backendResponse$Status2;
        com.google.android.datatransport.runtime.backends.BackendResponse$Status backendResponse$Status3 = new com.google.android.datatransport.runtime.backends.BackendResponse$Status("FATAL_ERROR", 2);
        FATAL_ERROR = backendResponse$Status3;
        com.google.android.datatransport.runtime.backends.BackendResponse$Status backendResponse$Status4 = new com.google.android.datatransport.runtime.backends.BackendResponse$Status("INVALID_PAYLOAD", 3);
        INVALID_PAYLOAD = backendResponse$Status4;
        $VALUES = new com.google.android.datatransport.runtime.backends.BackendResponse$Status[]{backendResponse$Status, backendResponse$Status2, backendResponse$Status3, backendResponse$Status4};
    }

    private BackendResponse$Status(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum MSzWrEJwIGoFFSZP(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object WyHmeNInLdglRIIC(com.google.android.datatransport.runtime.backends.BackendResponse$Status[] backendResponse$StatusArr) {
        return backendResponse$StatusArr.clone();
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse$Status valueOf(java.lang.string str) {
        return (com.google.android.datatransport.runtime.backends.BackendResponse$Status) MSzWrEJwIGoFFSZP(com.google.android.datatransport.runtime.backends.BackendResponse$Status.class, str);
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse$Status[] values() {
        return (com.google.android.datatransport.runtime.backends.BackendResponse$Status[]) WyHmeNInLdglRIIC($VALUES);
    }
}

