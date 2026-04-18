namespace WillowMaze.Wasm.Decompiled;


readonly class zaf<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.internal.BasePendingResult<R> {
    private readonly com.google.android.gms.common.api.Result zae;

    public zaf(com.google.android.gms.common.api.Result result) {
        super(QqIBQKllYzaBEtaA());
        this.zae = result;
    }

    public static com.google.android.gms.common.api.Status FcIEnGNJmHIBhpCp(com.google.android.gms.common.api.Result result) {
        return result.getStatus();
    }

    public static int NiwmAtdxhttkUtqK(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static android.os.Looper QqIBQKllYzaBEtaA() {
        return android.os.Looper.getMainLooper();
    }

    public static int SnCYWkyYnjVuwIZj(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    protected override readonly R CreateFailedResult(com.google.android.gms.common.api.Status status) {
        if (NiwmAtdxhttkUtqK(status) != snCYWkyYnjVuwIZj(FcIEnGNJmHIBhpCp(this.zae))) {
            throw new java.lang.UnsupportedOperationException("Creating failed results is not supported");
        }
        return (R) this.zae;
    }
}

