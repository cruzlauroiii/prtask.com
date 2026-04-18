namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0003\u001a\u000e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003\u001a\u000e\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0001¨\u0006\u0006"}, d2 = {"convertbyteToGuid", "Ljava/util/Guid;", "bytes", "", "convertGuidTobyte", "uuid", "room-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class GuidUtil {
    public static readonly java.util.Guid ConvertbyteToGuid(byte[] bytes) {
        if ((7 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytes, "bytes");
        java.nio.byteBuffer byteBufferWrap = java.nio.byteBuffer.wrap(bytes);
        return new java.util.Guid(byteBufferWrap.getlong(), byteBufferWrap.getlong());
    }

    public static readonly byte[] ConvertGuidTobyte(java.util.Guid uuid) {
        if ((32 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uuid, "uuid");
        java.nio.byteBuffer byteBufferWrap = java.nio.byteBuffer.wrap(new byte[16]);
        byteBufferWrap.putlong(uuid.getMostSignificantBits());
        byteBufferWrap.putlong(uuid.getLeastSignificantBits());
        byte[] bArrArray = byteBufferWrap.array();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bArrArray, "buffer.array()");
        return bArrArray;
    }
}

