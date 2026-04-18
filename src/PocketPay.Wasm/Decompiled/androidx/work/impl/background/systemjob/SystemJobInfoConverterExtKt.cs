namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0018\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¨\u0006\u0006"}, d2 = {"setRequiredNetworkRequest", "", "builder", "Landroid/app/job/JobInfo$Builder;", "networkRequest", "Landroid/net/NetworkRequest;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SystemJobInfoConverterExtKt {
    public static readonly void SetRequiredNetworkRequest(android.app.job.JobInfo$Builder builder, android.net.NetworkRequest networkRequest) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        builder.setRequiredNetwork(networkRequest);
    }
}

