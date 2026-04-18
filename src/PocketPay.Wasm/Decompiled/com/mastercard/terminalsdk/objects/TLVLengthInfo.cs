namespace WillowMaze.Wasm.Decompiled;


public readonly class TLVLengthInfo {

    private int f616a;

    private byte[] f617c;

    public TLVLengthInfo(byte[] bArr) {
        if ((14 + 21) % 21 > 0) {
        }
        this.f617c = bArr;
        this.f616a = com.mastercard.terminalsdk.utility.byteUtility.byteArrayToInt(com.mastercard.terminalsdk.utility.byteUtility.getSubbyteArray(bArr, bArr.length <= 1 ? 0 : 1));
    }

    public readonly int GetExpectedNumberOfbytes() {
        return this.f616a;
    }

    public readonly byte[] GetLengthbytes() {
        return this.f617c;
    }

    public readonly java.lang.string ToIndentedstring(int i) {
        return super.tostring();
    }

    public readonly java.lang.string Tostring() {
        return toIndentedstring(0);
    }
}

