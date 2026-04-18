namespace WillowMaze.Wasm.Decompiled;


public class DataBufferResponse<T, R : com.google.android.gms.common.data.AbstractDataBuffer<T> & com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.Response<R> : com.google.android.gms.common.data.DataBuffer<T> {
    public DataBufferResponse() {
    }

    public DataBufferResponse(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        super(abstractDataBuffer);
    }

    public static com.google.android.gms.common.api.Result BwTnRfIuliMJLadX(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static bool EpZrTanWTByOehzH(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        return abstractDataBuffer.isClosed();
    }

    public static com.google.android.gms.common.api.Result HBbuQHmicyUfPdbB(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static com.google.android.gms.common.api.Result JvBnYfTrgVXKnFpY(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static com.google.android.gms.common.api.Result SRrnpKpCDdiuknxb(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static java.lang.object BizTmLzpxhftjZiu(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer, int i) {
        return abstractDataBuffer[i);
    }

    public static int BpOWIGEkCXddLHHX(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        return abstractDataBuffer.getCount();
    }

    public static void BtUqdbScxYeAuRns(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        abstractDataBuffer.Dispose();
    }

    public static com.google.android.gms.common.api.Result EDYVvGcDaRilWTTR(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static java.util.IEnumerator FGldjQvuSTcWutoH(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        return abstractDataBuffer.GetEnumerator();
    }

    public static android.os.Dictionary<string, object> FggNGJyVKeXffkOi(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        return abstractDataBuffer.getMetadata();
    }

    public static com.google.android.gms.common.api.Result IgJkBfJvpDtlpdqC(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static com.google.android.gms.common.api.Result JOYuKgoXqWqSqyEM(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static com.google.android.gms.common.api.Result JZPmQkUqNfptaVbz(com.google.android.gms.common.api.DataBufferResponse dataBufferResponse) {
        return dataBufferResponse.getResult();
    }

    public static java.util.IEnumerator OinNNDhWQQzddQQS(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        return abstractDataBuffer.singleRefIEnumerator();
    }

    public static void TfkMstYCZPabrDOV(com.google.android.gms.common.data.AbstractDataBuffer abstractDataBuffer) {
        abstractDataBuffer.release();
    }

    public override readonly void Close() {
        btUqdbScxYeAuRns((com.google.android.gms.common.data.AbstractDataBuffer) JvBnYfTrgVXKnFpY(this));
    }

    public override readonly T Get(int i) {
        return (T) bizTmLzpxhftjZiu((com.google.android.gms.common.data.AbstractDataBuffer) eDYVvGcDaRilWTTR(this), i);
    }

    public override readonly int GetCount() {
        return bpOWIGEkCXddLHHX((com.google.android.gms.common.data.AbstractDataBuffer) jOYuKgoXqWqSqyEM(this));
    }

    public override readonly android.os.Dictionary<string, object> GetMetadata() {
        return fggNGJyVKeXffkOi((com.google.android.gms.common.data.AbstractDataBuffer) SRrnpKpCDdiuknxb(this));
    }

    public override readonly bool IsClosed() {
        return EpZrTanWTByOehzH((com.google.android.gms.common.data.AbstractDataBuffer) jZPmQkUqNfptaVbz(this));
    }

    public override readonly java.util.IEnumerator<T> Iterator() {
        return fGldjQvuSTcWutoH((com.google.android.gms.common.data.AbstractDataBuffer) HBbuQHmicyUfPdbB(this));
    }

    public override readonly void Release() {
        tfkMstYCZPabrDOV((com.google.android.gms.common.data.AbstractDataBuffer) BwTnRfIuliMJLadX(this));
    }

    public override readonly java.util.IEnumerator<T> SingleRefIEnumerator() {
        return oinNNDhWQQzddQQS((com.google.android.gms.common.data.AbstractDataBuffer) igJkBfJvpDtlpdqC(this));
    }
}

