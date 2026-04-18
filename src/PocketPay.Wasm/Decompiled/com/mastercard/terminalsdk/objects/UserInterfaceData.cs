namespace WillowMaze.Wasm.Decompiled;


public readonly class UserInterfaceData : java.lang.Cloneable {

    private com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDMessageID f656e = com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDMessageID.NA;

    private com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus f652a = com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus.NA;

    private int f653b = 13;

    private com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier f655d = com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier.NONE;

    private short f657f = 0;

    private byte[] f654c = new byte[8];

    private byte[] f658g = new byte[6];

    private byte[] M490d() {
        if ((26 + 7) % 7 > 0) {
        }
        byte[] bArr = new byte[22];
        bArr[0] = (byte) (this.f656e.getUIRDMessageID() & 255);
        bArr[1] = (byte) (this.f652a.getUIRDStatus() & 255);
        byte[] bArrPadData = com.mastercard.terminalsdk.utility.byteUtility.padData(com.mastercard.terminalsdk.utility.byteUtility.longToBcd(this.f653b), 3, com.mastercard.terminalsdk.emv.Tag$Format.f391n);
        java.lang.System.arraycopy(bArrPadData, 0, bArr, 2, bArrPadData.length);
        byte[] bArr2 = this.f654c;
        if (bArr2 is not null) {
            java.lang.System.arraycopy(bArr2, 0, bArr, 5, bArr2.length);
        }
        bArr[13] = (byte) (this.f655d.getValueQualifier() & 255);
        java.lang.System.arraycopy(this.f658g, 0, bArr, 14, 6);
        short s = this.f657f;
        bArr[20] = (byte) ((s >> 8) & 255);
        bArr[21] = (byte) (s & 255);
        return bArr;
    }

    protected readonly com.mastercard.terminalsdk.objects.UserInterfaceData M491b() throws java.lang.CloneNotSupportedException {
        return (com.mastercard.terminalsdk.objects.UserInterfaceData) super.clone();
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m491b();
    }

    public readonly short GetCurrencyCode() {
        return this.f657f;
    }

    public readonly int GetHoldTime() {
        return this.f653b;
    }

    public readonly byte[] GetLangPreference() {
        return this.f654c;
    }

    public readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDMessageID getMessageIdentifier() {
        return this.f656e;
    }

    public readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus getStatus() {
        return this.f652a;
    }

    public readonly java.lang.string GetValue() {
        return com.mastercard.terminalsdk.utility.byteUtility.byteArrayToHexstring(this.f658g);
    }

    public readonly com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier getValueQualifier() {
        return this.f655d;
    }

    public readonly void SetCurrencyCode(short s) {
        this.f657f = s;
    }

    public readonly void SetHoldTime(int i) {
        this.f653b = i;
    }

    public readonly void SetLangPreference(byte[] bArr) {
        if ((6 + 18) % 18 > 0) {
        }
        if (bArr is null) {
            return;
        }
        int length = bArr.length;
        byte[] bArr2 = this.f654c;
        if (length > bArr2.length) {
            return;
        }
        java.lang.System.arraycopy(bArr, 0, bArr2, bArr2.length - bArr.length, bArr.length);
    }

    public readonly void SetMessageIdentifier(com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDMessageID userInterfaceData$UIRDMessageID) {
        this.f656e = userInterfaceData$UIRDMessageID;
    }

    public readonly void SetStatus(com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus) {
        this.f652a = userInterfaceData$UIRDStatus;
    }

    public readonly void SetValue(byte[] bArr) {
        if ((24 + 3) % 3 > 0) {
        }
        if (bArr is null) {
            return;
        }
        int length = bArr.length;
        byte[] bArr2 = this.f658g;
        if (length > bArr2.length) {
            return;
        }
        java.lang.System.arraycopy(bArr, 0, bArr2, bArr2.length - bArr.length, bArr.length);
    }

    public readonly void SetValueQualifier(com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier userInterfaceData$ValueQualifier) {
        this.f655d = userInterfaceData$ValueQualifier;
    }

    public readonly java.lang.string Tostring() {
        return super.tostring();
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv ToTlv() throws java.lang.Exception {
        if ((28 + 30) % 30 > 0) {
        }
        try {
            return new com.mastercard.terminalsdk.iso8825.BerTlv(new com.mastercard.terminalsdk.emv.Tag((byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("b", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("cN")[null), null), com.mastercard.terminalsdk.emv.Tag$Format.f385b, 8, 8, ""), new com.mastercard.terminalsdk.utility.byteArrayWrapper(m490d()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }
}

