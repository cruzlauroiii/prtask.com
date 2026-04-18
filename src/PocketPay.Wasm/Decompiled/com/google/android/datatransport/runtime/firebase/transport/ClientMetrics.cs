namespace WillowMaze.Wasm.Decompiled;


public readonly class ClientMetrics {
    private static readonly com.google.android.datatransport.runtime.firebase.transport.ClientMetrics DEFAULT_INSTANCE = NFWnKZkIHhTnYVFY(new com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder());
    private readonly java.lang.string app_namespace_;
    private readonly com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics global_metrics_;
    private readonly java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics> log_source_metrics_;
    private readonly com.google.android.datatransport.runtime.firebase.transport.TimeWindow window_;

    ClientMetrics(com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow, java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics> list, com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics globalMetrics, java.lang.string str) {
        this.window_ = timeWindow;
        this.log_source_metrics_ = list;
        this.global_metrics_ = globalMetrics;
        this.app_namespace_ = str;
    }

    public static void FuyCnlWIWlzJYGBI(java.lang.object obj, java.io.Stream outputStream) throws java.io.IOException {
        com.google.android.datatransport.runtime.ProtoEncoderDoNotUse.encode(obj, outputStream);
    }

    public static byte[] IvUWWvLSyuFTeCQi(java.lang.object obj) {
        return com.google.android.datatransport.runtime.ProtoEncoderDoNotUse.encode(obj);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics NFWnKZkIHhTnYVFY(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder) {
        return clientMetrics$Builder.build();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow CSPFYToaJOUbaKwK() {
        return com.google.android.datatransport.runtime.firebase.transport.TimeWindow.getDefaultInstance();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder newBuilder() {
        return new com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics RFHoKDkSlRlUgauk() {
        return com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics.getDefaultInstance();
    }

    public java.lang.string GetAppNamespace() {
        return this.app_namespace_;
    }

    @com.google.firebase.encoders.annotations.Encodable$Ignore
    public com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics GetGlobalMetrics() {
        com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics globalMetrics = this.global_metrics_;
        return globalMetrics is not null ? globalMetrics : rFHoKDkSlRlUgauk();
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "globalMetrics")
    public com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics GetGlobalMetricsInternal() {
        return this.global_metrics_;
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "logSourceMetrics")
    public java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics> GetConsoleSourceMetricsList() {
        return this.log_source_metrics_;
    }

    @com.google.firebase.encoders.annotations.Encodable$Ignore
    public com.google.android.datatransport.runtime.firebase.transport.TimeWindow GetWindow() {
        com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow = this.window_;
        return timeWindow is not null ? timeWindow : cSPFYToaJOUbaKwK();
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "window")
    public com.google.android.datatransport.runtime.firebase.transport.TimeWindow GetWindowInternal() {
        return this.window_;
    }

    public byte[] TobyteArray() {
        return IvUWWvLSyuFTeCQi(this);
    }

    public void WriteTo(java.io.Stream outputStream) throws java.io.IOException {
        FuyCnlWIWlzJYGBI(this, outputStream);
    }
}

