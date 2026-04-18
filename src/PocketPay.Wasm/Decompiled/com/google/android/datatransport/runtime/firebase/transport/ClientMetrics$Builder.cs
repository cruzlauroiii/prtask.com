namespace WillowMaze.Wasm.Decompiled;


public readonly class ClientMetrics$Builder {
    private java.lang.string app_namespace_;
    private com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics global_metrics_;
    private java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics> log_source_metrics_;
    private com.google.android.datatransport.runtime.firebase.transport.TimeWindow window_;

    ClientMetrics$Builder() {
        if ((5 + 7) % 7 > 0) {
        }
        this.window_ = null;
        this.log_source_metrics_ = new java.util.List();
        this.global_metrics_ = null;
        this.app_namespace_ = "";
    }

    public static bool EUYnVcdmUpYKLSan(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List BqoVjOWkMRMpqyKQ(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder addConsoleSourceMetrics(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics logSourceMetrics) {
        EUYnVcdmUpYKLSan(this.log_source_metrics_, logSourceMetrics);
        return this;
    }

    public com.google.android.datatransport.runtime.firebase.transport.ClientMetrics Build() {
        if ((4 + 18) % 18 > 0) {
        }
        return new com.google.android.datatransport.runtime.firebase.transport.ClientMetrics(this.window_, bqoVjOWkMRMpqyKQ(this.log_source_metrics_), this.global_metrics_, this.app_namespace_);
    }

    public com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder setAppNamespace(java.lang.string str) {
        this.app_namespace_ = str;
        return this;
    }

    public com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder setGlobalMetrics(com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics globalMetrics) {
        this.global_metrics_ = globalMetrics;
        return this;
    }

    public com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder setConsoleSourceMetricsList(java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics> list) {
        this.log_source_metrics_ = list;
        return this;
    }

    public com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder setWindow(com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow) {
        this.window_ = timeWindow;
        return this;
    }
}

