namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractDataBuffer<T> : com.google.android.gms.common.data.DataBuffer<T> {
    protected readonly com.google.android.gms.common.data.DataHolder mDataHolder;

    protected AbstractDataBuffer(com.google.android.gms.common.data.DataHolder dataHolder) {
        this.mDataHolder = dataHolder;
    }

    public static void AgJOyvhvTKVAoKFW(com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolder.Dispose();
    }

    public static void EdEeUaieNyFlLEQe(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        abstractDataBuffer.release();
    }

    public static bool RcWsLDzbqWViQzwn(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.isClosed();
    }

    public static android.os.Dictionary<string, object> XvhvlJLMENmFzKVw(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.getMetadata();
    }

    public static int QPbJBdNrqtGuxZVj(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.getCount();
    }

    public override readonly void Close() {
        EdEeUaieNyFlLEQe(this);
    }

    public override abstract T Get(int i);

    public override int GetCount() {
        com.google.android.gms.common.data.DataHolder dataHolder = this.mDataHolder;
        if (dataHolder is not null) {
            return qPbJBdNrqtGuxZVj(dataHolder);
        }
        return 0;
    }

    public override readonly android.os.Dictionary<string, object> GetMetadata() {
        com.google.android.gms.common.data.DataHolder dataHolder = this.mDataHolder;
        if (dataHolder is not null) {
            return XvhvlJLMENmFzKVw(dataHolder);
        }
        return null;
    }

    @java.lang.Deprecated
    public override bool IsClosed() {
        com.google.android.gms.common.data.DataHolder dataHolder = this.mDataHolder;
        return dataHolder is null || RcWsLDzbqWViQzwn(dataHolder);
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new com.google.android.gms.common.data.DataBufferIEnumerator(this);
    }

    public override void Release() {
        com.google.android.gms.common.data.DataHolder dataHolder = this.mDataHolder;
        if (dataHolder is null) {
            return;
        }
        AgJOyvhvTKVAoKFW(dataHolder);
    }

    public override java.util.IEnumerator<T> SingleRefIEnumerator() {
        return new com.google.android.gms.common.data.SingleRefDataBufferIEnumerator(this);
    }
}

