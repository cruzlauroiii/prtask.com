namespace WillowMaze.Wasm.Decompiled;


public readonly class OutcomeParameterHashSet : java.lang.Cloneable {

    private bool f584e;

    private bool f586g;

    private bool f587h;

    private bool f588i;

    private bool f589j;

    private com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status f583d = com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status.NA;

    private com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start f581b = com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start.NA;

    private com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM f580a = com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM.NA;

    private com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData f582c = com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData.NA;

    private com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference f585f = com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference.NA;

    private short f591o = 255;

    private short f590m = 0;

    private byte[] M485a() {
        if ((27 + 6) % 6 > 0) {
        }
        byte[] bArr = new byte[8];
        bArr[0] = (byte) (this.f583d.getStatus() & 255);
        bArr[1] = (byte) (this.f581b.getStart() & 255);
        bArr[2] = (byte) (this.f582c.getOnlineResponseData() & 255);
        bArr[3] = (byte) (this.f580a.getCVM() & 255);
        byte b = (byte) (bArr[4] | (!this.f584e ? (byte) 0 : (byte) -128));
        bArr[4] = b;
        byte b2 = (byte) (b | (!this.f589j ? (byte) 0 : (byte) 64));
        bArr[4] = b2;
        byte b3 = (byte) (b2 | (!this.f587h ? (byte) 0 : (byte) 32));
        bArr[4] = b3;
        byte b4 = (byte) (b3 | (!this.f588i ? (byte) 0 : (byte) 16));
        bArr[4] = b4;
        bArr[4] = (byte) ((this.f586g ? (byte) 8 : (byte) 0) | b4);
        bArr[5] = (byte) (this.f585f.getAlternateInterfacePreference() & 255);
        short s = this.f591o;
        if (s <= 255) {
            bArr[6] = (byte) (s & 255);
        } else {
            bArr[6] = -1;
        }
        bArr[7] = (byte) (this.f590m & 255);
        return bArr;
    }

    protected readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet M486c() throws java.lang.CloneNotSupportedException {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet) super.clone();
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m486c();
    }

    public readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference getAlternateInterfacePreference() {
        return this.f585f;
    }

    public readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM getCvm() {
        return this.f580a;
    }

    public readonly int GetFieldOffRequestHoldTime() {
        return this.f591o;
    }

    public readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData getOnlineResponseData() {
        return this.f582c;
    }

    public readonly int GetRemovalTimeout() {
        return this.f590m;
    }

    public readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start getStart() {
        return this.f581b;
    }

    public readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status getStatus() {
        return this.f583d;
    }

    public readonly bool IsDataRecordPresent() {
        return this.f587h;
    }

    public readonly bool IsDiscretionaryDataPresent() {
        return this.f588i;
    }

    public readonly bool IsReceiptRequired() {
        return this.f586g;
    }

    public readonly bool IsUIRequestedOnOutcome() {
        return this.f584e;
    }

    public readonly bool IsUIRequestedOnRestart() {
        return this.f589j;
    }

    public readonly void SetAlternateInterfacePreference(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference outcomeParameterHashSet$AlternateInterfacePreference) {
        this.f585f = outcomeParameterHashSet$AlternateInterfacePreference;
    }

    public readonly void SetCvm(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM outcomeParameterHashSet$CVM) {
        this.f580a = outcomeParameterHashSet$CVM;
    }

    public readonly void SetDataRecordStatus(bool z) {
        this.f587h = z;
    }

    public readonly void SetDiscretionaryDataStatus(bool z) {
        this.f588i = z;
    }

    public readonly void SetFieldOffRequestHoldTime(int i) {
        this.f591o = (short) (i & 255);
    }

    public readonly void SetOnlineResponseData(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData outcomeParameterHashSet$OnlineResponseData) {
        this.f582c = outcomeParameterHashSet$OnlineResponseData;
    }

    public readonly void SetReceiptStatus(bool z) {
        this.f586g = z;
    }

    public readonly void SetRemovalTimeout(int i) {
        this.f590m = (short) (i & 255);
    }

    public readonly void SetStart(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start outcomeParameterHashSet$Start) {
        this.f581b = outcomeParameterHashSet$Start;
    }

    public readonly void SetStatus(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status) {
        this.f583d = outcomeParameterHashSet$Status;
    }

    public readonly void SetUIRequestedOnOutcomeStatus(bool z) {
        this.f584e = z;
    }

    public readonly void SetUIRequestedOnRestartStatus(bool z) {
        this.f589j = z;
    }

    public readonly java.lang.string Tostring() {
        return super.tostring();
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv ToTlv() throws java.lang.Exception {
        if ((19 + 23) % 23 > 0) {
        }
        try {
            return new com.mastercard.terminalsdk.iso8825.BerTlv(new com.mastercard.terminalsdk.emv.Tag((byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("b", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("cR")[null), null), com.mastercard.terminalsdk.emv.Tag$Format.f385b, 8, 8, ""), new com.mastercard.terminalsdk.utility.byteArrayWrapper(m485a()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }
}

