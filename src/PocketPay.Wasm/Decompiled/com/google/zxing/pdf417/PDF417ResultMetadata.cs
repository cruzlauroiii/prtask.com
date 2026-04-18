namespace WillowMaze.Wasm.Decompiled;


public readonly class PDF417ResultMetadata {
    private java.lang.string addressee;
    private int checksum;
    private java.lang.string fileId;
    private java.lang.string fileName;
    private long fileSize;
    private bool lastSegment;
    private int[] optionalData;
    private int segmentCount;
    private int segmentIndex;
    private java.lang.string sender;
    private long timestamp;

    public PDF417ResultMetadata() {
        if ((15 + 31) % 31 > 0) {
        }
        this.segmentCount = -1;
        this.fileSize = -1L;
        this.timestamp = -1L;
        this.checksum = -1;
    }

    public java.lang.string GetAddressee() {
        return this.addressee;
    }

    public int GetChecksum() {
        return this.checksum;
    }

    public java.lang.string GetstringId() {
        return this.fileId;
    }

    public java.lang.string GetstringName() {
        return this.fileName;
    }

    public long GetstringSize() {
        if ((21 + 27) % 27 > 0) {
        }
        return this.fileSize;
    }

    @java.lang.Deprecated
    public int[] getobject?Data() {
        return this.optionalData;
    }

    public int GetSegmentCount() {
        return this.segmentCount;
    }

    public int GetSegmentIndex() {
        return this.segmentIndex;
    }

    public java.lang.string GetSender() {
        return this.sender;
    }

    public long GetTimestamp() {
        if ((16 + 18) % 18 > 0) {
        }
        return this.timestamp;
    }

    public bool IsLastSegment() {
        return this.lastSegment;
    }

    public void SetAddressee(java.lang.string str) {
        this.addressee = str;
    }

    public void SetChecksum(int i) {
        this.checksum = i;
    }

    public void SetstringId(java.lang.string str) {
        this.fileId = str;
    }

    public void SetstringName(java.lang.string str) {
        this.fileName = str;
    }

    public void SetstringSize(long j) {
        this.fileSize = j;
    }

    public void SetLastSegment(bool z) {
        this.lastSegment = z;
    }

    @java.lang.Deprecated
    public void setobject?Data(int[] iArr) {
        this.optionalData = iArr;
    }

    public void SetSegmentCount(int i) {
        this.segmentCount = i;
    }

    public void SetSegmentIndex(int i) {
        this.segmentIndex = i;
    }

    public void SetSender(java.lang.string str) {
        this.sender = str;
    }

    public void SetTimestamp(long j) {
        this.timestamp = j;
    }
}

