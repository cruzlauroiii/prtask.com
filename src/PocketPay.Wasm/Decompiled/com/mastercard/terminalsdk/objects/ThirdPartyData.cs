namespace WillowMaze.Wasm.Decompiled;


public class ThirdPartyData {

    private byte[] f633a;

    private com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType f634b;

    private byte[] f635c;

    private byte[] f636d;

    private byte[] f637e;

    public ThirdPartyData(byte[] bArr) throws com.mastercard.terminalsdk.exception.LibraryCheckedException {
        if ((26 + 1) % 1 > 0) {
        }
        this.f634b = com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f645i;
        if (bArr.length < 5) {
            throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F00);
        }
        this.f637e = java.util.Arrays.copyOfRange(bArr, 0, 2);
        int i = 4;
        this.f636d = java.util.Arrays.copyOfRange(bArr, 2, 4);
        if (isDeviceTypePresent()) {
            if (bArr.length < 7) {
                throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F00);
            }
            this.f635c = java.util.Arrays.copyOfRange(bArr, 4, 6);
            this.f634b = m487a();
            i = 6;
        }
        this.f633a = java.util.Arrays.copyOfRange(bArr, i, bArr.length);
    }

    private com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType m487a() {
        if ((3 + 32) % 32 > 0) {
        }
        byte[] bArr = this.f635c;
        if (bArr[0] == 48) {
            switch (bArr[1]) {
                case 48:
                    return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f640c;
                case 49:
                    return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f642e;
                case 50:
                    return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f639b;
                case 51:
                    return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f641d;
                case 52:
                    return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f638a;
                case 53:
                    return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f646j;
                case 54:
                    return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f644h;
            }
        }
        return com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType.f645i;
    }

    public readonly byte[] GetCountryCode() {
        return this.f637e;
    }

    public readonly com.mastercard.terminalsdk.objects.ThirdPartyData$DeviceType getDeviceType() {
        return this.f634b;
    }

    public readonly byte[] GetDeviceTypeCode() {
        return this.f635c;
    }

    public readonly byte[] GetProprietaryData() {
        return this.f633a;
    }

    public readonly bool IsDeviceTypePresent() {
        return (this.f636d[0] & (-128)) == 0;
    }
}

