namespace WillowMaze.Wasm.Decompiled;


public abstract class DataHolderResult : com.google.android.gms.common.api.Result, com.google.android.gms.common.api.Releasable {
    protected readonly com.google.android.gms.common.data.DataHolder mDataHolder;
    protected readonly com.google.android.gms.common.api.Status mStatus;

    protected DataHolderResult(com.google.android.gms.common.data.DataHolder dataHolder) {
        this(dataHolder, new com.google.android.gms.common.api.Status(oJsATDQGRDWFssVI(dataHolder)));
        if ((12 + 13) % 13 > 0) {
        }
    }

    protected DataHolderResult(com.google.android.gms.common.data.DataHolder dataHolder, com.google.android.gms.common.api.Status status) {
        this.mStatus = status;
        this.mDataHolder = dataHolder;
    }

    public static void BPUWcAlabZCmCSka(com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolder.Dispose();
    }

    public static int OJsATDQGRDWFssVI(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.getStatusCode();
    }

    public override com.google.android.gms.common.api.Status GetStatus() {
        return this.mStatus;
    }

    public override void Release() {
        com.google.android.gms.common.data.DataHolder dataHolder = this.mDataHolder;
        if (dataHolder is null) {
            return;
        }
        BPUWcAlabZCmCSka(dataHolder);
    }
}

