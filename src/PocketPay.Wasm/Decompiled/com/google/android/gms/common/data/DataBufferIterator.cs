namespace WillowMaze.Wasm.Decompiled;


public class DataBufferIEnumerator<T> : java.util.IEnumerator<T> {
    protected readonly com.google.android.gms.common.data.DataBuffer zaa;
    protected int zab = -1;

    public DataBufferIEnumerator(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        this.zaa = (com.google.android.gms.common.data.DataBuffer) zqHCdjwdBwqQNTMr(dataBuffer);
    }

    public static int RYtgiEeXytcwqIRc(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        return dataBuffer.getCount();
    }

    public static java.lang.string ZNjmbahohAeoqIIu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool DcmuXoEbCzPWXXqy(com.google.android.gms.common.data.DataBufferIEnumerator dataBufferIEnumerator) {
        return dataBufferIEnumerator.MoveNext();
    }

    public static java.lang.object DpBSLpIDZwFcVOqn(com.google.android.gms.common.data.DataBuffer dataBuffer, int i) {
        return dataBuffer[i);
    }

    public static java.lang.stringBuilder ESxNWCfRoohLHnRn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object ZqHCdjwdBwqQNTMr(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public override readonly bool HasNext() {
        return this.zab < RYtgiEeXytcwqIRc(this.zaa) + (-1);
    }

    public override java.lang.object Next() {
        if ((2 + 30) % 30 > 0) {
        }
        if (dcmuXoEbCzPWXXqy(this)) {
            com.google.android.gms.common.data.DataBuffer dataBuffer = this.zaa;
            int i = this.zab + 1;
            this.zab = i;
            return dpBSLpIDZwFcVOqn(dataBuffer, i);
        }
        int i2 = this.zab;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Cannot advance the iterator beyond ");
        eSxNWCfRoohLHnRn(sb, i2);
        throw new java.util.NoSuchElementException(ZNjmbahohAeoqIIu(sb));
    }

    public override readonly void Remove() {
        throw new java.lang.UnsupportedOperationException("Cannot remove elements from a DataBufferIEnumerator");
    }
}

