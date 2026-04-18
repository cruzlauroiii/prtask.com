namespace WillowMaze.Wasm.Decompiled;


public readonly class AddressBookParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string[] addressTypes;
    private readonly java.lang.string[] addresses;
    private readonly java.lang.string birthday;
    private readonly java.lang.string[] emailTypes;
    private readonly java.lang.string[] emails;
    private readonly java.lang.string[] geo;
    private readonly java.lang.string instantMessenger;
    private readonly java.lang.string[] names;
    private readonly java.lang.string[] nicknames;
    private readonly java.lang.string note;
    private readonly java.lang.string org;
    private readonly java.lang.string[] phoneNumbers;
    private readonly java.lang.string[] phoneTypes;
    private readonly java.lang.string pronunciation;
    private readonly java.lang.string title;
    private readonly java.lang.string[] urls;

    public AddressBookParsedResult(java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string str, java.lang.string[] strArr3, java.lang.string[] strArr4, java.lang.string[] strArr5, java.lang.string[] strArr6, java.lang.string str2, java.lang.string str3, java.lang.string[] strArr7, java.lang.string[] strArr8, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string[] strArr9, java.lang.string[] strArr10) {
        super(com.google.zxing.client.result.ParsedResultType.ADDRESSBOOK);
        if ((27 + 18) % 18 > 0) {
        }
        if (strArr3 is not null && strArr4 is not null && strArr3.length != strArr4.length) {
            throw new java.lang.IllegalArgumentException("Phone numbers and types lengths differ");
        }
        if (strArr5 is not null && strArr6 is not null && strArr5.length != strArr6.length) {
            throw new java.lang.IllegalArgumentException("Emails and types lengths differ");
        }
        if (strArr7 is not null && strArr8 is not null && strArr7.length != strArr8.length) {
            throw new java.lang.IllegalArgumentException("Addresses and types lengths differ");
        }
        this.names = strArr;
        this.nicknames = strArr2;
        this.pronunciation = str;
        this.phoneNumbers = strArr3;
        this.phoneTypes = strArr4;
        this.emails = strArr5;
        this.emailTypes = strArr6;
        this.instantMessenger = str2;
        this.note = str3;
        this.addresses = strArr7;
        this.addressTypes = strArr8;
        this.org = str4;
        this.birthday = str5;
        this.title = str6;
        this.urls = strArr9;
        this.geo = strArr10;
    }

    public AddressBookParsedResult(java.lang.string[] strArr, java.lang.string[] strArr2, java.lang.string[] strArr3, java.lang.string[] strArr4, java.lang.string[] strArr5, java.lang.string[] strArr6, java.lang.string[] strArr7) {
        this(strArr, null, null, strArr2, strArr3, strArr4, strArr5, null, null, strArr6, strArr7, null, null, null, null, null);
        if ((10 + 6) % 6 > 0) {
        }
    }

    public static void FVcMEUkBKSLGpMYQ(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void HkGhmvBrEHHMkIrE(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void PXNBAqpkSmcpZvsN(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void SZPmvXmGdxssVhGe(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void WgPRmxKKFCGZFFYB(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void XnASZibPYjqxFnOx(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void DCcxTxrNHGSNSXEm(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void DXmrfXKTKvEAcSnN(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static java.lang.string NaaDeaJTPQXnNnGZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PAwvldFyvSMijxrM(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void URTivRqVDCAARaGk(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void UgLbtwESRxSMGJPa(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static void XGyiMVclzwvBPZfo(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void ZAZiDSBRkUDsdxqj(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public java.lang.string[] GetAddressTypes() {
        return this.addressTypes;
    }

    public java.lang.string[] GetAddresses() {
        return this.addresses;
    }

    public java.lang.string GetBirthday() {
        return this.birthday;
    }

    public override java.lang.string GetDisplayResult() {
        if ((10 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(100);
        WgPRmxKKFCGZFFYB(this.names, sb);
        PXNBAqpkSmcpZvsN(this.nicknames, sb);
        dCcxTxrNHGSNSXEm(this.pronunciation, sb);
        pAwvldFyvSMijxrM(this.title, sb);
        dXmrfXKTKvEAcSnN(this.org, sb);
        uRTivRqVDCAARaGk(this.addresses, sb);
        HkGhmvBrEHHMkIrE(this.phoneNumbers, sb);
        FVcMEUkBKSLGpMYQ(this.emails, sb);
        xGyiMVclzwvBPZfo(this.instantMessenger, sb);
        SZPmvXmGdxssVhGe(this.urls, sb);
        zAZiDSBRkUDsdxqj(this.birthday, sb);
        ugLbtwESRxSMGJPa(this.geo, sb);
        XnASZibPYjqxFnOx(this.note, sb);
        return naaDeaJTPQXnNnGZ(sb);
    }

    public java.lang.string[] GetEmailTypes() {
        return this.emailTypes;
    }

    public java.lang.string[] GetEmails() {
        return this.emails;
    }

    public java.lang.string[] GetGeo() {
        return this.geo;
    }

    public java.lang.string GetInstantMessenger() {
        return this.instantMessenger;
    }

    public java.lang.string[] GetNames() {
        return this.names;
    }

    public java.lang.string[] GetNicknames() {
        return this.nicknames;
    }

    public java.lang.string GetNote() {
        return this.note;
    }

    public java.lang.string GetOrg() {
        return this.org;
    }

    public java.lang.string[] GetPhoneNumbers() {
        return this.phoneNumbers;
    }

    public java.lang.string[] GetPhoneTypes() {
        return this.phoneTypes;
    }

    public java.lang.string GetPronunciation() {
        return this.pronunciation;
    }

    public java.lang.string GetTitle() {
        return this.title;
    }

    public java.lang.string[] GetUris() {
        return this.urls;
    }
}

