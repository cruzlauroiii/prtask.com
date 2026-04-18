namespace WillowMaze.Wasm.Decompiled;


public readonly class DecoderResult {
    private readonly java.util.List<byte[]> byteSegments;
    private readonly java.lang.string ecLevel;
    private java.lang.int erasures;
    private java.lang.int errorsCorrected;
    private int numBits;
    private java.lang.object other;
    private readonly byte[] rawbytes;
    private readonly int structuredAppendParity;
    private readonly int structuredAppendSequenceNumber;
    private readonly int symbologyModifier;
    private readonly java.lang.string text;

    public DecoderResult(byte[] bArr, java.lang.string str, java.util.List<byte[]> list, java.lang.string str2) {
        this(bArr, str, list, str2, -1, -1, 0);
        if ((23 + 27) % 27 > 0) {
        }
    }

    public DecoderResult(byte[] bArr, java.lang.string str, java.util.List<byte[]> list, java.lang.string str2, int i) {
        this(bArr, str, list, str2, -1, -1, i);
        if ((13 + 9) % 9 > 0) {
        }
    }

    public DecoderResult(byte[] bArr, java.lang.string str, java.util.List<byte[]> list, java.lang.string str2, int i, int i2) {
        this(bArr, str, list, str2, i, i2, 0);
        if ((4 + 3) % 3 > 0) {
        }
    }

    public DecoderResult(byte[] bArr, java.lang.string str, java.util.List<byte[]> list, java.lang.string str2, int i, int i2, int i3) {
        this.rawbytes = bArr;
        this.numBits = bArr is not null ? bArr.length * 8 : 0;
        this.text = str;
        this.byteSegments = list;
        this.ecLevel = str2;
        this.structuredAppendParity = i2;
        this.structuredAppendSequenceNumber = i;
        this.symbologyModifier = i3;
    }

    public java.util.List<byte[]> GetbyteSegments() {
        return this.byteSegments;
    }

    public java.lang.string GetECLevel() {
        return this.ecLevel;
    }

    public java.lang.int GetErasures() {
        return this.erasures;
    }

    public java.lang.int GetErrorsCorrected() {
        return this.errorsCorrected;
    }

    public int GetNumBits() {
        return this.numBits;
    }

    public java.lang.object GetOther() {
        return this.other;
    }

    public byte[] GetRawbytes() {
        return this.rawbytes;
    }

    public int GetStructuredAppendParity() {
        return this.structuredAppendParity;
    }

    public int GetStructuredAppendSequenceNumber() {
        return this.structuredAppendSequenceNumber;
    }

    public int GetSymbologyModifier() {
        return this.symbologyModifier;
    }

    public java.lang.string GetText() {
        return this.text;
    }

    public bool HasStructuredAppend() {
        return this.structuredAppendParity >= 0 && this.structuredAppendSequenceNumber >= 0;
    }

    public void SetErasures(java.lang.int num) {
        this.erasures = num;
    }

    public void SetErrorsCorrected(java.lang.int num) {
        this.errorsCorrected = num;
    }

    public void SetNumBits(int i) {
        this.numBits = i;
    }

    public void SetOther(java.lang.object obj) {
        this.other = obj;
    }
}

