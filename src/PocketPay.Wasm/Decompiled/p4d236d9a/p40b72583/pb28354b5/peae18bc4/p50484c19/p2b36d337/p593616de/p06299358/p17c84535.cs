namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes3.dex */
@kotlin.Metadata(d1 = {"\u0000Z\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0000\u0018\u0000 +2\u00020\u0001:\u0001+B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010 \u001a\u00020\u0011J\u0006\u0010!\u001a\u00020\u0011J\u0010\u0010\"\u001a\u00020#2\u0006\u0010$\u001a\u00020%H\u0016J\u0006\u0010&\u001a\u00020\u0011J\u0006\u0010'\u001a\u00020\u0011J\u000e\u0010(\u001a\u00020\u00152\u0006\u0010)\u001a\u00020\u0015J\u000e\u0010*\u001a\u00020#2\u0006\u0010\u001e\u001a\u00020\u001fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\f\u0010\r\"\u0004\b\u000e\u0010\u000fR\u000e\u0010\u0010\u001a\u00020\u0011X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u0012\u001a\u000e\u0012\u0004\u0012\u00020\u0014\u0012\u0004\u0012\u00020\u00150\u0013X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0016\u001a\u00020\u0011X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0017\u001a\u00020\u0011X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u0018\u001a\u00020\u0019X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u001a\u0010\u001b\"\u0004\b\u001c\u0010\u001dR\u0010\u0010\u001e\u001a\u0004\u0018\u00010\u001fX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006,"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/p06299358/p17c84535;", "Landroid/nfc/NfcAdapter$ReaderCallback;", "activityProvider", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p80c2998c/pbf8c78df;", "transactionProcessConsoleger", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/pe804aacd;", "emvInterceptor", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/pea9f91b2/p86658a49;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p80c2998c/pbf8c78df;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/pe804aacd;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/pea9f91b2/p86658a49;)V", "isoDep", "Landroid/nfc/tech/IsoDep;", "getIsoDep", "()Landroid/nfc/tech/IsoDep;", "setIsoDep", "(Landroid/nfc/tech/IsoDep;)V", "isCardTapped", "", "cachedResponses", "Ljava/util/HashDictionary;", "", "", "isCardConnected", "isDataExchangeInterrupted", "commandExecTime", "", "getCommandExecTime", "()J", "setCommandExecTime", "(J)V", "nfcCardCommunicationManager", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p4c6bf409;", "connectReader", "disconnectReader", "onTagDiscovered", "", "tag", "Landroid/nfc/Tag;", "connectCard", "disconnectCard", "sendReceiveData", "bytes", "setNfcCardCommunicationManager", "Companion", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p17c84535 : android.nfc.NfcAdapter.ReaderCallback {
    public static readonly java.lang.string f010594ca = null;
    public static readonly java.lang.string f0638c9f2 = null;
    public static readonly java.lang.string f0e5d9f4c = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535.p910eef8c f7414ee31 = null;
    public static readonly java.lang.string f812efaa6 = null;
    public static readonly java.lang.string f8bb5d30a = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535.p910eef8c f910eef8c = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535.p910eef8c f9357193c = null;
    public static readonly java.lang.string fddac0b9e = null;
    public static readonly java.lang.string fdfa979ac = null;
    public static readonly java.lang.string ff0a317b7 = null;
    private android.nfc.tech.IsoDep f01cf561c;
    private bool f07fca804;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd f1948bbc1;
    private readonly java.util.HashDictionary f1c5b6c11;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd f2a2da94f;
    private android.nfc.tech.IsoDep f31598ff7;
    private android.nfc.tech.IsoDep f394b560a;
    private bool f3fbcb820;
    private readonly java.util.HashDictionary<java.lang.string, byte[]> f43e0bb9b;
    private bool f4bd1cc9e;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 f4fde095c;
    private long f5ae54793;
    private bool f5f732cf3;
    private bool f6833a4fa;
    private bool f69677c3e;
    private android.nfc.tech.IsoDep f6a5ffc62;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd f73f59260;
    private bool f83569cbf;
    private bool f84dbbfcc;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 f9fb78a72;
    private long fa541bed7;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 fad917c0b;
    private long fafe441e7;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 fb265a432;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df fb740abd6;
    private long fb7a046cd;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 fb9c41faf;
    private readonly java.util.HashDictionary fbcbd4590;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 fbf8e61bf;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df fc330c74c;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df fc5deb860;
    private long fc7e0e5ea;
    private android.nfc.tech.IsoDep fccfb6782;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 fce448ca9;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd fd5dde881;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 ff4acb35e;
    private bool ff550554f;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 ff6bcd522;

    @kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003R\u000e\u0010\u0004\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u0007"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/p06299358/p17c84535$p910eef8c;", "", "<init>", "()V", "PPS_MCHIP", "", "NFC_READER_DESCRIPTION", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
    public static readonly class p910eef8c {
        private p910eef8c() {
                r0 = this;
                goto L13
            L4:
                return
            L5:
                goto L10
            L9:
                r0.<init>()
                goto L4
            L10:
                goto L16
            L13:
                goto L5
            L16:
                goto L9
        }

        public /* synthetic */ p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker r1) {
                r0 = this;
                goto L9
            L4:
                return
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                r0.<init>()
                goto L4
        }
    }

    static {
            goto L56
        L4:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535.f910eef8c = r0
            goto L26
        La:
            goto L59
        Ld:
            java.lang.string r0 = "238b973e9632652a39914571e04578afcc2df4d1a58da9faa644c32b4af2c2ea94d9e9d30af4aee4b99af7cd8b617603"
            goto L3e
        L14:
            int r0 = r0 + r1
            goto L5d
        L1a:
            goto L27
        L1d:
            goto Ld
        L21:
            r1 = 0
            goto L4f
        L26:
            return
        L27:
            goto L6a
        L2b:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535.f8bb5d30a = r0
            goto L80
        L31:
            r1 = 3
            goto L14
        L38:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535.fddac0b9e = r0
            goto L79
        L3e:
            java.lang.string r0 = ckRdphUssefkWJJw(r0)
            goto L38
        L46:
            if (r0 <= 0) goto L4b
            goto L1d
        L4b:
            goto L1a
        L4f:
            r0.<init>(r1)
            goto L4
        L56:
            goto L6d
        L59:
            goto L63
        L5d:
            int r0 = r0 % r1
            goto L46
        L63:
            r0 = 5
            goto L31
        L6a:
            goto L1d
        L6d:
            goto La
        L71:
            java.lang.string r0 = iyUOHbmKDSBpXuTh(r0)
            goto L2b
        L79:
            java.lang.string r0 = "3f3dba1db51167e6145361c2b464d7a965ece0dc202c643a932158ab35aa3c50"
            goto L71
        L80:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535$p910eef8c r0 = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p17c84535$p910eef8c
            goto L21
    }

    public p17c84535(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r2, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r3, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 r4) {
            r1 = this;
            goto La
        L4:
            r1.f1948bbc1 = r3
            goto L24
        La:
            goto L32
        Ld:
            goto L57
        L11:
            java.lang.string r0 = "transactionProcessConsoleger"
            goto L49
        L17:
            java.lang.string r0 = "emvInterceptor"
            goto L2a
        L1d:
            r2.<init>()
            goto L3d
        L24:
            r1.fad917c0b = r4
            goto L43
        L2a:
            lKJacqKLzhcSoFLN(r4, r0)
            goto L36
        L31:
            return
        L32:
            goto L5d
        L36:
            r1.<init>()
            goto L60
        L3d:
            r1.f43e0bb9b = r2
            goto L31
        L43:
            java.util.HashDictionary r2 = new java.util.HashDictionary
            goto L1d
        L49:
            SpDfmPAvAdzFzEvJ(r3, r0)
            goto L17
        L50:
            lLplCQDcvehXbwOD(r2, r0)
            goto L11
        L57:
            java.lang.string r0 = "activityProvider"
            goto L50
        L5d:
            goto Ld
        L60:
            r1.fc5deb860 = r2
            goto L4
    }

    public static java.lang.string BqoXHkFeEUkvxccJ(java.lang.stringBuilder r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.tostring()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void BqoXHkFeEUkvxccJ(java.lang.stringBuilder r0, float r1, int r2, short r3, bool r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            goto L27
        Ld:
            r0 = 42
            goto L4
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            goto L2c
        L27:
            goto Ld
        L2b:
            return
        L2c:
            goto La
    }

    public static void BqoXHkFeEUkvxccJ(java.lang.stringBuilder r0, int r1, float r2, short r3, bool r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto L25
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            goto L18
        L25:
            r0 = 42
            goto L1c
        L2b:
            return
        L2c:
            goto L22
    }

    public static void BqoXHkFeEUkvxccJ(java.lang.stringBuilder r0, bool r1, float r2, short r3, int r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            return
        Lb:
            goto L1a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L26
        L1d:
            int r3 = r2 + r1
            goto L15
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lf
    }

    public static void CxHVosJVAcMxJXPg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1) {
            goto Lb
        L4:
            r0.updateNfcStatus(r1)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void CxHVosJVAcMxJXPg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1, int r2, float r3, short r4, java.lang.string r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            int r3 = r2 + r1
            goto L15
        L10:
            return
        L11:
            goto L26
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            int r2 = r0 * r1
            goto La
        L20:
            r0 = 42
            goto L4
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto L20
    }

    public static void CxHVosJVAcMxJXPg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1, int r2, java.lang.string r3, short r4, float r5) {
            goto L1f
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            r0 = 42
            goto L4
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto L26
        L1c:
            goto L22
        L1f:
            goto L2c
        L22:
            goto La
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void CxHVosJVAcMxJXPg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1, short r2, float r3, int r4, java.lang.string r5) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L24
        L15:
            goto L20
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            goto Lb
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L18
        L2a:
            r0 = 42
            goto L4
    }

    public static java.lang.string EAAUsqXZMszTUlok(java.lang.string r1) {
            goto L14
        L4:
            java.lang.string r0 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void EAAUsqXZMszTUlok(java.lang.string r0, int r1, char r2, bool r3, short r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0 = 42
            goto L2a
        L19:
            double r0 = (double) r3
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void EAAUsqXZMszTUlok(java.lang.string r0, int r1, bool r2, short r3, char r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L14
        Ld:
            goto L2c
        L10:
            goto L25
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r2 = r0 * r1
            goto L7
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void EAAUsqXZMszTUlok(java.lang.string r0, bool r1, char r2, int r3, short r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r2 = r0 * r1
            goto L16
        Lf:
            goto L1d
        L12:
            goto L27
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L12
    }

    public static void FBgxoqLNmrYRLjSr(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            goto L16
        L7:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void FBgxoqLNmrYRLjSr(java.lang.object r0, java.lang.string r1, char r2, float r3, java.lang.string r4, bool r5) {
            goto L1d
        L4:
            r0 = 42
            goto L17
        La:
            goto L20
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L13
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void FBgxoqLNmrYRLjSr(java.lang.object r0, java.lang.string r1, float r2, java.lang.string r3, char r4, bool r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto L24
        Lb:
            double r0 = (double) r3
            goto L16
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            return
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L10
        L21:
            goto L7
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void FBgxoqLNmrYRLjSr(java.lang.object r0, java.lang.string r1, java.lang.string r2, char r3, bool r4, float r5) {
            goto Lf
        L4:
            return
        L5:
            goto L1c
        L9:
            r0 = 42
            goto L16
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto L12
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static android.nfc.tech.IsoDep FPUizRlyzNPbWLIW(android.nfc.Tag r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.nfc.tech.IsoDep r0 = android.nfc.tech.IsoDep[r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void FPUizRlyzNPbWLIW(android.nfc.Tag r0, char r1, java.lang.string r2, short r3, bool r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L24
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto Lc
        L24:
            r0 = 42
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void FPUizRlyzNPbWLIW(android.nfc.Tag r0, java.lang.string r1, char r2, bool r3, short r4) {
            goto L20
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Lf:
            return
        L10:
            goto L2d
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto L4
        L20:
            goto L10
        L23:
            goto L27
        L27:
            r0 = 42
            goto L9
        L2d:
            goto L23
    }

    public static void FPUizRlyzNPbWLIW(android.nfc.Tag r0, java.lang.string r1, short r2, bool r3, char r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L7
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto L18
        L29:
            goto Le
        L2c:
            goto L12
    }

    public static int FfgxpSEJmkYxxoNU(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = android.util.Console.e(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void FfgxpSEJmkYxxoNU(java.lang.string r0, java.lang.string r1, float r2, java.lang.string r3, int r4, short r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L1a
        Ld:
            goto L1e
        L11:
            double r0 = (double) r3
            goto L19
        L16:
            goto Ld
        L19:
            return
        L1a:
            goto L16
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void FfgxpSEJmkYxxoNU(java.lang.string r0, java.lang.string r1, float r2, short r3, int r4, java.lang.string r5) {
            goto L13
        L4:
            r0 = 42
            goto L25
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L1f
        L13:
            goto L2c
        L16:
            goto L4
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L2b:
            return
        L2c:
            goto La
    }

    public static void FfgxpSEJmkYxxoNU(java.lang.string r0, java.lang.string r1, int r2, float r3, java.lang.string r4, short r5) {
            goto L4
        L4:
            goto L1a
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L2a
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto Lb
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static long GKLameztBqRWyrCG() {
            goto L4
        L4:
            goto Le
        L7:
            goto L27
        Lb:
            goto L31
        Le:
            goto L3d
        L12:
            int r0 = r0 + r1
            goto L21
        L18:
            if (r0 <= 0) goto L1d
            goto L31
        L1d:
            goto L2e
        L21:
            int r0 = r0 % r1
            goto L18
        L27:
            r0 = 14
            goto L40
        L2e:
            goto L48
        L31:
            goto L35
        L35:
            long r0 = android.os.SystemClock.elapsedRealtimeNanos()
            goto L47
        L3d:
            goto L7
        L40:
            r1 = 13
            goto L12
        L47:
            return r0
        L48:
            goto Lb
    }

    public static void GKLameztBqRWyrCG(byte r0, bool r1, java.lang.string r2, int r3) {
            goto Lf
        L4:
            r0 = 42
            goto L16
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L20
        L12:
            goto L4
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            goto L12
        L1f:
            return
        L20:
            goto L1c
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void GKLameztBqRWyrCG(java.lang.string r0, int r1, byte r2, bool r3) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            goto Lb
        L23:
            goto L27
        L27:
            r0 = 42
            goto L1a
        L2d:
            goto L23
    }

    public static void GKLameztBqRWyrCG(bool r0, java.lang.string r1, byte r2, int r3) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto L16
        Lf:
            goto L2c
        L12:
            goto L9
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1c:
            goto L12
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void HQXNsoVhqFeLWvYD(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void HQXNsoVhqFeLWvYD(java.lang.object r0, java.lang.string r1, int r2, char r3, byte r4, java.lang.string r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            goto L2c
        L19:
            return
        L1a:
            goto L16
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto L1a
        L2c:
            goto L10
    }

    public static void HQXNsoVhqFeLWvYD(java.lang.object r0, java.lang.string r1, int r2, char r3, java.lang.string r4, byte r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1a
        Lb:
            int r3 = r2 + r1
            goto L20
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            goto L7
        L1a:
            r0 = 42
            goto L11
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static void HQXNsoVhqFeLWvYD(java.lang.object r0, java.lang.string r1, java.lang.string r2, char r3, byte r4, int r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L11:
            return
        L12:
            goto L27
        L16:
            r0 = 42
            goto Lb
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void HnPhHydQcwnHGJvg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(r0, r1, r2, r3, r4, r5, r6, r7)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void HnPhHydQcwnHGJvg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, byte r8, java.lang.string r9, bool r10, float r11) {
            goto L26
        L4:
            r0 = 42
            goto L20
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L26:
            goto Lb
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static void HnPhHydQcwnHGJvg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, float r8, byte r9, java.lang.string r10, bool r11) {
            goto L12
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L15
        L12:
            goto L20
        L15:
            goto L2a
        L19:
            int r3 = r2 + r1
            goto La
        L1f:
            return
        L20:
            goto Lf
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r0 = 42
            goto L4
    }

    public static void HnPhHydQcwnHGJvg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, java.lang.string r8, byte r9, bool r10, float r11) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L19
        Lb:
            return
        Lc:
            goto L16
        L10:
            int r3 = r2 + r1
            goto L1f
        L16:
            goto L7
        L19:
            r0 = 42
            goto L24
        L1f:
            double r0 = (double) r3
            goto Lb
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static androidx.fragment.app.objectobject HpXdqSPdNwplYNYs(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            androidx.fragment.app.objectobject r0 = r1.getTransactionobject()
            goto L4
        L18:
            goto Lc
    }

    public static void HpXdqSPdNwplYNYs(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, float r1, int r2, byte r3, short r4) {
            goto L14
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L27
        L14:
            goto L10
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            r0 = 42
            goto L4
        L27:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void HpXdqSPdNwplYNYs(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, short r1, float r2, byte r3, int r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            goto L29
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L22
        L17:
            double r0 = (double) r3
            goto L28
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void HpXdqSPdNwplYNYs(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, short r1, int r2, byte r3, float r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L1d
        L11:
            int r3 = r2 + r1
            goto L23
        L17:
            int r2 = r0 * r1
            goto L11
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L7
        L2b:
            return
        L2c:
            goto L28
    }

    public static java.lang.stringBuilder IguisrnFYytGDRWD(java.lang.stringBuilder r1, long r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void IguisrnFYytGDRWD(java.lang.stringBuilder r0, long r1, char r3, short r4, java.lang.string r5, float r6) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            double r0 = (double) r3
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            r0 = 42
            goto L17
        L23:
            goto Lb
        L26:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L12
    }

    public static void IguisrnFYytGDRWD(java.lang.stringBuilder r0, long r1, java.lang.string r3, char r4, float r5, short r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1f
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L1f:
            r0 = 42
            goto L19
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void IguisrnFYytGDRWD(java.lang.stringBuilder r0, long r1, short r3, float r4, java.lang.string r5, char r6) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            goto L26
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1c:
            r0 = 42
            goto L16
        L22:
            goto L12
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void JGdzJIUKtXgJCDys(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5) {
            goto L10
        L4:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(r0, r1, r2, r3, r4, r5)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void JGdzJIUKtXgJCDys(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, byte r6, int r7, char r8, short r9) {
            goto L15
        L4:
            r0 = 42
            goto L1c
        La:
            return
        Lb:
            goto L27
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            goto Lb
        L18:
            goto L4
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L22:
            double r0 = (double) r3
            goto La
        L27:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void JGdzJIUKtXgJCDys(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, char r6, short r7, int r8, byte r9) {
            goto L19
        L4:
            goto L1c
        L7:
            int r3 = r2 + r1
            goto L26
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L13:
            r0 = 42
            goto Ld
        L19:
            goto L2c
        L1c:
            goto L13
        L20:
            int r2 = r0 * r1
            goto L7
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static void JGdzJIUKtXgJCDys(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, short r6, byte r7, char r8, int r9) {
            goto L15
        L4:
            return
        L5:
            goto L22
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L1c
        L15:
            goto L5
        L18:
            goto L2a
        L1c:
            int r3 = r2 + r1
            goto L25
        L22:
            goto L18
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L9
    }

    public static void LPjdmEyofNGjoboa(android.nfc.NfcAdapter r0, android.app.object r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.disableForegroundDispatch(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void LPjdmEyofNGjoboa(android.nfc.NfcAdapter r0, android.app.object r1, byte r2, java.lang.string r3, char r4, bool r5) {
            goto L18
        L4:
            r0 = 42
            goto L12
        La:
            goto L1b
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            goto Le
        L1b:
            goto L4
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void LPjdmEyofNGjoboa(android.nfc.NfcAdapter r0, android.app.object r1, char r2, java.lang.string r3, bool r4, byte r5) {
            goto L18
        L4:
            goto L1b
        L7:
            double r0 = (double) r3
            goto L1f
        Lc:
            int r2 = r0 * r1
            goto L24
        L12:
            r0 = 42
            goto L2a
        L18:
            goto L20
        L1b:
            goto L12
        L1f:
            return
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
    }

    public static void LPjdmEyofNGjoboa(android.nfc.NfcAdapter r0, android.app.object r1, bool r2, char r3, java.lang.string r4, byte r5) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L1e
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L2a
        L19:
            double r0 = (double) r3
            goto La
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static androidx.fragment.app.objectobject MtMxbYArrZXhLUhb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r1) {
            goto Lc
        L4:
            androidx.fragment.app.objectobject r0 = r1.getTransactionobject()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void MtMxbYArrZXhLUhb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, float r1, int r2, bool r3, java.lang.string r4) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            r0 = 42
            goto L4
        L1b:
            goto L26
        L1e:
            goto L15
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void MtMxbYArrZXhLUhb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, java.lang.string r1, float r2, int r3, bool r4) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            r0 = 42
            goto L27
        L10:
            return
        L11:
            goto L2d
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L11
        L1d:
            goto La
        L21:
            int r3 = r2 + r1
            goto L15
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2d:
            goto L1d
    }

    public static void MtMxbYArrZXhLUhb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, java.lang.string r1, float r2, bool r3, int r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            return
        Lb:
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            int r3 = r2 + r1
            goto L24
        L1b:
            goto L2c
        L1e:
            r0 = 42
            goto Lf
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto L1e
    }

    public static androidx.fragment.app.objectobject OZTxWumfPntOBeXQ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            androidx.fragment.app.objectobject r0 = r1.getTransactionobject()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void OZTxWumfPntOBeXQ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, byte r1, java.lang.string r2, int r3, float r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L13
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L10:
            goto L21
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L10
        L2a:
            r0 = 42
            goto La
    }

    public static void OZTxWumfPntOBeXQ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, float r1, int r2, byte r3, java.lang.string r4) {
            goto L23
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L20
        L1a:
            int r3 = r2 + r1
            goto L10
        L20:
            goto L26
        L23:
            goto L16
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static void OZTxWumfPntOBeXQ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, float r1, java.lang.string r2, byte r3, int r4) {
            goto L17
        L4:
            goto L1a
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto L1e
        L1e:
            r0 = 42
            goto L7
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void PEnXExhCDUhhkOLT(android.nfc.tech.IsoDep r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.connect()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void PEnXExhCDUhhkOLT(android.nfc.tech.IsoDep r0, char r1, java.lang.string r2, float r3, byte r4) {
            goto Lf
        L4:
            r0 = 42
            goto L16
        La:
            return
        Lb:
            goto L21
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            goto L12
        L24:
            int r3 = r2 + r1
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void PEnXExhCDUhhkOLT(android.nfc.tech.IsoDep r0, float r1, char r2, java.lang.string r3, byte r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L2a
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto Le
        L26:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void PEnXExhCDUhhkOLT(android.nfc.tech.IsoDep r0, float r1, java.lang.string r2, char r3, byte r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            r0 = 42
            goto L22
        L10:
            goto L2c
        L13:
            goto La
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            goto L13
        L2b:
            return
        L2c:
            goto L28
    }

    public static void PitCokZNWYVJmzrL(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(r0, r1, r2, r3, r4, r5, r6, r7)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void PitCokZNWYVJmzrL(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, byte r8, java.lang.string r9, char r10, short r11) {
            goto L4
        L4:
            goto L11
        L7:
            goto L24
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L15
        L15:
            goto L7
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            int r3 = r2 + r1
            goto Lb
        L24:
            r0 = 42
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void PitCokZNWYVJmzrL(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, java.lang.string r8, byte r9, char r10, short r11) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        Lf:
            goto L5
        L12:
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L28
        L1c:
            r0 = 42
            goto L9
        L22:
            int r2 = r0 * r1
            goto L16
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L12
    }

    public static void PitCokZNWYVJmzrL(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, short r8, char r9, byte r10, java.lang.string r11) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L24
        L16:
            r0 = 42
            goto La
        L1c:
            goto L2c
        L1f:
            return
        L20:
            goto L1c
        L24:
            double r0 = (double) r3
            goto L1f
        L29:
            goto L20
        L2c:
            goto L16
    }

    public static java.lang.string PjKeousGOZDGbyaD(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = r1.tostring()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void PjKeousGOZDGbyaD(java.lang.stringBuilder r0, byte r1, java.lang.string r2, int r3, bool r4) {
            goto L1b
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L27
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L5
        L1e:
            goto L15
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L1e
    }

    public static void PjKeousGOZDGbyaD(java.lang.stringBuilder r0, int r1, byte r2, java.lang.string r3, bool r4) {
            goto La
        L4:
            r0 = 42
            goto L2a
        La:
            goto L20
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            return
        L20:
            goto L11
        L24:
            int r3 = r2 + r1
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void PjKeousGOZDGbyaD(java.lang.stringBuilder r0, java.lang.string r1, byte r2, int r3, bool r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L22
        L10:
            goto L18
        L13:
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto L13
        L2a:
            r0 = 42
            goto L1c
    }

    public static java.lang.string QPjVgUWIZSbmILti(java.lang.stringBuilder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.tostring()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void QPjVgUWIZSbmILti(java.lang.stringBuilder r0, float r1, bool r2, short r3, byte r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L1e
        Ld:
            goto L17
        L11:
            int r3 = r2 + r1
            goto L22
        L17:
            r0 = 42
            goto L27
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2d:
            goto Ld
    }

    public static void QPjVgUWIZSbmILti(java.lang.stringBuilder r0, bool r1, float r2, byte r3, short r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L12
        Ld:
            goto L1c
        L11:
            return
        L12:
            goto L22
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            r0 = 42
            goto L25
        L22:
            goto Ld
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void QPjVgUWIZSbmILti(java.lang.stringBuilder r0, bool r1, float r2, short r3, byte r4) {
            goto L4
        L4:
            goto L23
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L22
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            return
        L23:
            goto L27
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L10
    }

    public static java.lang.string QbHEJDZLusXicTGU(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r0 = r1.tostring()
            goto Le
    }

    public static void QbHEJDZLusXicTGU(java.lang.stringBuilder r0, float r1, java.lang.string r2, bool r3, short r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L27
        Ld:
            goto L1a
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            goto Ld
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            return
        L27:
            goto L17
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void QbHEJDZLusXicTGU(java.lang.stringBuilder r0, float r1, short r2, java.lang.string r3, bool r4) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L14
        L14:
            r0 = 42
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static void QbHEJDZLusXicTGU(java.lang.stringBuilder r0, java.lang.string r1, bool r2, short r3, float r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            return
        L16:
            goto L27
        L1a:
            goto L16
        L1d:
            goto L9
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static void RMkPqqYGRZmZtbhK(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(r0, r1, r2, r3, r4, r5, r6, r7)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void RMkPqqYGRZmZtbhK(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, byte r8, int r9, bool r10, java.lang.string r11) {
            goto L29
        L4:
            r0 = 42
            goto L10
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L16:
            double r0 = (double) r3
            goto L24
        L1b:
            goto L2c
        L1e:
            int r2 = r0 * r1
            goto La
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void RMkPqqYGRZmZtbhK(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, int r8, bool r9, java.lang.string r10, byte r11) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L18
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L13:
            return
        L14:
            goto L4
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r2 = r0 * r1
            goto L7
        L23:
            r0 = 42
            goto Ld
        L29:
            goto L14
        L2c:
            goto L23
    }

    public static void RMkPqqYGRZmZtbhK(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, java.lang.object r7, bool r8, int r9, java.lang.string r10, byte r11) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L24
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto Lc
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L10
    }

    public static void SArtrUHHTdNcBxcu(android.nfc.NfcAdapter r0, char r1, byte r2, int r3, short r4) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L26
        L1e:
            goto Lf
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void SArtrUHHTdNcBxcu(android.nfc.NfcAdapter r0, int r1, short r2, byte r3, char r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto L19
        Lb:
            int r3 = r2 + r1
            goto L2b
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
        L19:
            r0 = 42
            goto L25
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static void SArtrUHHTdNcBxcu(android.nfc.NfcAdapter r0, short r1, byte r2, char r3, int r4) {
            goto L9
        L4:
            return
        L5:
            goto L15
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            goto Lc
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static bool SArtrUHHTdNcBxcu(android.nfc.NfcAdapter r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.isEnabled()
            goto L4
    }

    public static java.lang.string SDRVctjpcpdpUZfL(java.lang.Exception r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.string r0 = r1.getMessage()
            goto L4
        L18:
            goto Lc
    }

    public static void SDRVctjpcpdpUZfL(java.lang.Exception r0, char r1, float r2, java.lang.string r3, bool r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L14
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L26
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto Lb
    }

    public static void SDRVctjpcpdpUZfL(java.lang.Exception r0, java.lang.string r1, char r2, float r3, bool r4) {
            goto La
        L4:
            r0 = 42
            goto L2a
        La:
            goto L1d
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L21
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto L17
        L27:
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void SDRVctjpcpdpUZfL(java.lang.Exception r0, java.lang.string r1, float r2, char r3, bool r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            goto L1b
        L13:
            goto L1f
        L17:
            goto L13
        L1a:
            return
        L1b:
            goto L17
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void SlgAIaAmLSceCWdH(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1) {
            goto Le
        L4:
            r0.logApduExchange(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void SlgAIaAmLSceCWdH(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, java.lang.string r2, byte r3, bool r4, short r5) {
            goto L14
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1b
        L14:
            goto L10
        L17:
            goto L24
        L1b:
            goto L17
        L1e:
            int r2 = r0 * r1
            goto L4
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void SlgAIaAmLSceCWdH(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, java.lang.string r2, short r3, byte r4, bool r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            double r0 = (double) r3
            goto L12
        Lf:
            goto L2c
        L12:
            return
        L13:
            goto Lf
        L17:
            r0 = 42
            goto L4
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto La
        L29:
            goto L13
        L2c:
            goto L17
    }

    public static void SlgAIaAmLSceCWdH(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, bool r2, byte r3, java.lang.string r4, short r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L16
        L10:
            r0 = 42
            goto L24
        L16:
            goto L7
        L19:
            double r0 = (double) r3
            goto Lb
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void SpDfmPAvAdzFzEvJ(java.lang.object r0, java.lang.string r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto L4
        L17:
            goto Lc
    }

    public static void SpDfmPAvAdzFzEvJ(java.lang.object r0, java.lang.string r1, int r2, char r3, bool r4, java.lang.string r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L23
        L15:
            r0 = 42
            goto L4
        L1b:
            goto L2c
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto Lb
        L2c:
            goto L15
    }

    public static void SpDfmPAvAdzFzEvJ(java.lang.object r0, java.lang.string r1, int r2, bool r3, java.lang.string r4, char r5) {
            goto L4
        L4:
            goto L11
        L7:
            goto L21
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L27
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto Lb
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
    }

    public static void SpDfmPAvAdzFzEvJ(java.lang.object r0, java.lang.string r1, bool r2, char r3, int r4, java.lang.string r5) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L20
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L27
        L19:
            goto La
        L1d:
            goto L19
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void SsveBoOjByzEiMFI(android.nfc.tech.IsoDep r0) {
            goto Lb
        L4:
            r0.Dispose()
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void SsveBoOjByzEiMFI(android.nfc.tech.IsoDep r0, float r1, byte r2, short r3, bool r4) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            int r3 = r2 + r1
            goto L1a
        L10:
            goto L16
        L13:
            goto L20
        L16:
            goto L24
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L10
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void SsveBoOjByzEiMFI(android.nfc.tech.IsoDep r0, short r1, byte r2, float r3, bool r4) {
            goto L4
        L4:
            goto L21
        L7:
            goto L17
        Lb:
            int r3 = r2 + r1
            goto L25
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L7
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void SsveBoOjByzEiMFI(android.nfc.tech.IsoDep r0, bool r1, short r2, byte r3, float r4) {
            goto L4
        L4:
            goto L18
        L7:
            goto L25
        Lb:
            int r3 = r2 + r1
            goto L2b
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            return
        L18:
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L22:
            goto L7
        L25:
            r0 = 42
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static java.lang.stringBuilder SxXlRtlYjmdeqzGS(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void SxXlRtlYjmdeqzGS(java.lang.stringBuilder r0, java.lang.string r1, char r2, float r3, short r4, java.lang.string r5) {
            goto L1b
        L4:
            return
        L5:
            goto L28
        L9:
            r0 = 42
            goto L22
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            goto L5
        L1e:
            goto L9
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void SxXlRtlYjmdeqzGS(java.lang.stringBuilder r0, java.lang.string r1, short r2, char r3, float r4, java.lang.string r5) {
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L12:
            goto L5
        L15:
            goto L2a
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r0 = 42
            goto Lc
    }

    public static void SxXlRtlYjmdeqzGS(java.lang.stringBuilder r0, java.lang.string r1, short r2, char r3, java.lang.string r4, float r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1e
        Lb:
            return
        Lc:
            goto L15
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            goto L7
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void UEMcPjsbEutUYCUN(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(r0, r1, r2, r3, r4, r5)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void UEMcPjsbEutUYCUN(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, char r6, bool r7, int r8, java.lang.string r9) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L24
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto Lc
        L24:
            r0 = 42
            goto L16
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void UEMcPjsbEutUYCUN(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, int r6, char r7, bool r8, java.lang.string r9) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            return
        Lb:
            goto L21
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            goto Lb
        L1d:
            goto L2a
        L21:
            goto L1d
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static void UEMcPjsbEutUYCUN(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.p910eef8c r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, bool r6, char r7, int r8, java.lang.string r9) {
            goto L4
        L4:
            goto L15
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L19
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2a:
            r0 = 42
            goto L24
    }

    public static java.lang.stringBuilder VYdNHtjRGmeSQTLd(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void VYdNHtjRGmeSQTLd(java.lang.stringBuilder r0, java.lang.string r1, byte r2, int r3, short r4, bool r5) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L11:
            r0 = 42
            goto Lb
        L17:
            goto L7
        L1a:
            return
        L1b:
            goto L17
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void VYdNHtjRGmeSQTLd(java.lang.stringBuilder r0, java.lang.string r1, int r2, bool r3, short r4, byte r5) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            goto L20
        L10:
            goto L2a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1a
        L2a:
            r0 = 42
            goto L14
    }

    public static void VYdNHtjRGmeSQTLd(java.lang.stringBuilder r0, java.lang.string r1, short r2, bool r3, int r4, byte r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static java.lang.string WGMANUcbqHsdKSiO(byte[] r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r0 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p2ac737d2.p1ceded00.m81519f2a(r1)
            goto Le
    }

    public static void WGMANUcbqHsdKSiO(byte[] r0, float r1, short r2, java.lang.string r3, bool r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L11:
            return
        L12:
            goto L2d
        L16:
            r0 = 42
            goto Lb
        L1c:
            int r2 = r0 * r1
            goto L27
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L7
    }

    public static void WGMANUcbqHsdKSiO(byte[] r0, java.lang.string r1, float r2, bool r3, short r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r0 = 42
            goto L1f
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto Lf
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L15
    }

    public static void WGMANUcbqHsdKSiO(byte[] r0, bool r1, short r2, float r3, java.lang.string r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L1f
        L15:
            goto L26
        L18:
            goto Lf
        L1c:
            goto L18
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void XEKxKBZMZasMIKOQ(android.nfc.NfcAdapter r0, android.app.object r1) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.disableForegroundDispatch(r1)
            goto L4
    }

    public static void XEKxKBZMZasMIKOQ(android.nfc.NfcAdapter r0, android.app.object r1, int r2, byte r3, bool r4, java.lang.string r5) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            int r2 = r0 * r1
            goto L1d
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            r0 = 42
            goto L7
        L29:
            goto Le
        L2c:
            goto L23
    }

    public static void XEKxKBZMZasMIKOQ(android.nfc.NfcAdapter r0, android.app.object r1, java.lang.string r2, bool r3, int r4, byte r5) {
            goto L24
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto L2b
        L21:
            goto L27
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto L21
    }

    public static void XEKxKBZMZasMIKOQ(android.nfc.NfcAdapter r0, android.app.object r1, bool r2, byte r3, java.lang.string r4, int r5) {
            goto L29
        L4:
            return
        L5:
            goto L26
        L9:
            int r2 = r0 * r1
            goto L20
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            r0 = 42
            goto Lf
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            int r3 = r2 + r1
            goto L1b
        L26:
            goto L2c
        L29:
            goto L5
        L2c:
            goto L15
    }

    public static java.lang.stringBuilder XrCZzhbXMPWBgCGJ(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static void XrCZzhbXMPWBgCGJ(java.lang.stringBuilder r0, java.lang.string r1, int r2, java.lang.string r3, bool r4, float r5) {
            goto L12
        L4:
            goto L15
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L19
        L19:
            r0 = 42
            goto L7
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void XrCZzhbXMPWBgCGJ(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, float r3, bool r4, int r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1a
        L14:
            r0 = 42
            goto L23
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto La
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L10
        L2c:
            goto L14
    }

    public static void XrCZzhbXMPWBgCGJ(java.lang.stringBuilder r0, java.lang.string r1, bool r2, float r3, int r4, java.lang.string r5) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L13
        La:
            goto L21
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            r0 = 42
            goto L2a
        L1e:
            goto L26
        L21:
            goto L18
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static java.lang.string YAyYhbcLhgDPqJlk(java.lang.stringBuilder r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.tostring()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void YAyYhbcLhgDPqJlk(java.lang.stringBuilder r0, char r1, byte r2, short r3, float r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L19
        Lb:
            int r2 = r0 * r1
            goto L25
        L11:
            goto L7
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L25:
            int r3 = r2 + r1
            goto L14
        L2b:
            return
        L2c:
            goto L11
    }

    public static void YAyYhbcLhgDPqJlk(java.lang.stringBuilder r0, char r1, float r2, short r3, byte r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L27
        Lb:
            int r2 = r0 * r1
            goto L1b
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L7
    }

    public static void YAyYhbcLhgDPqJlk(java.lang.stringBuilder r0, float r1, short r2, char r3, byte r4) {
            goto L1f
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L22
        L19:
            r0 = 42
            goto La
        L1f:
            goto L27
        L22:
            goto L19
        L26:
            return
        L27:
            goto L16
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static long YESVtFWRDMWBONiI() {
            goto L17
        L4:
            int r0 = r0 + r1
            goto L11
        La:
            r0 = 21
            goto L45
        L11:
            int r0 = r0 % r1
            goto L3c
        L17:
            goto L21
        L1a:
            goto La
        L1e:
            goto L38
        L21:
            goto L25
        L25:
            goto L1a
        L28:
            long r0 = android.os.SystemClock.elapsedRealtimeNanos()
            goto L30
        L30:
            return r0
        L31:
            goto L1e
        L35:
            goto L31
        L38:
            goto L28
        L3c:
            if (r0 <= 0) goto L41
            goto L38
        L41:
            goto L35
        L45:
            r1 = 25
            goto L4
    }

    public static void YESVtFWRDMWBONiI(byte r0, short r1, float r2, int r3) {
            goto L29
        L4:
            return
        L5:
            goto L26
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r0 = 42
            goto L1a
        L14:
            int r3 = r2 + r1
            goto L9
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto L14
        L26:
            goto L2c
        L29:
            goto L5
        L2c:
            goto Le
    }

    public static void YESVtFWRDMWBONiI(int r0, byte r1, short r2, float r3) {
            goto L1b
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L2d
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L15:
            int r3 = r2 + r1
            goto L22
        L1b:
            goto Lb
        L1e:
            goto L4
        L22:
            double r0 = (double) r3
            goto La
        L27:
            int r2 = r0 * r1
            goto L15
        L2d:
            goto L1e
    }

    public static void YESVtFWRDMWBONiI(int r0, short r1, float r2, byte r3) {
            goto L13
        L4:
            r0 = 42
            goto L1f
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L2a
        L13:
            goto L26
        L16:
            goto L4
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L25:
            return
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static void ZZcUIvSIWIDEkZSd(android.nfc.NfcAdapter r0, short r1, bool r2, java.lang.string r3, char r4) {
            goto L1e
        L4:
            r0 = 42
            goto L12
        La:
            goto L21
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto Le
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto L18
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void ZZcUIvSIWIDEkZSd(android.nfc.NfcAdapter r0, bool r1, java.lang.string r2, char r3, short r4) {
            goto L23
        L4:
            return
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L2a
        L1d:
            r0 = 42
            goto L11
        L23:
            goto L5
        L26:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto Lc
    }

    public static void ZZcUIvSIWIDEkZSd(android.nfc.NfcAdapter r0, bool r1, java.lang.string r2, short r3, char r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L2c
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L17:
            r0 = 42
            goto L11
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto La
        L2c:
            goto L17
    }

    public static bool ZZcUIvSIWIDEkZSd(android.nfc.NfcAdapter r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.isEnabled()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void ZvdUOWkrkgiXqdqM(java.lang.object r0, java.lang.string r1) {
            goto L10
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void ZvdUOWkrkgiXqdqM(java.lang.object r0, java.lang.string r1, byte r2, java.lang.string r3, int r4, bool r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L1e
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L22
        L17:
            int r2 = r0 * r1
            goto L4
        L1d:
            return
        L1e:
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L28:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L1d
    }

    public static void ZvdUOWkrkgiXqdqM(java.lang.object r0, java.lang.string r1, int r2, bool r3, java.lang.string r4, byte r5) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            double r0 = (double) r3
            goto L28
        L1b:
            r0 = 42
            goto La
        L21:
            goto L29
        L24:
            goto L1b
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static void ZvdUOWkrkgiXqdqM(java.lang.object r0, java.lang.string r1, bool r2, int r3, byte r4, java.lang.string r5) {
            goto L23
        L4:
            return
        L5:
            goto L20
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L14:
            int r3 = r2 + r1
            goto L9
        L1a:
            r0 = 42
            goto Le
        L20:
            goto L26
        L23:
            goto L5
        L26:
            goto L1a
        L2a:
            int r2 = r0 * r1
            goto L14
    }

    public static java.lang.string ATAkIiOqJUDYHlmD(java.lang.string r1, java.util.Locale r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r0 = r1.toLowerCase(r2)
            goto Le
    }

    public static void ATAkIiOqJUDYHlmD(java.lang.string r0, java.util.Locale r1, char r2, short r3, float r4, bool r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L18
        L12:
            r0 = 42
            goto L1d
        L18:
            return
        L19:
            goto La
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            int r3 = r2 + r1
            goto Ld
        L29:
            goto L19
        L2c:
            goto L12
    }

    public static void ATAkIiOqJUDYHlmD(java.lang.string r0, java.util.Locale r1, short r2, float r3, char r4, bool r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L27
        L13:
            goto L17
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L23:
            goto L13
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void ATAkIiOqJUDYHlmD(java.lang.string r0, java.util.Locale r1, short r2, bool r3, char r4, float r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L1b
        Ld:
            goto L2a
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            goto Ld
        L1a:
            return
        L1b:
            goto L17
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L11
    }

    public static java.lang.string AZRGKrsXhZpxOJyd(byte[] r1) {
            goto L14
        L4:
            java.lang.string r0 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p2ac737d2.p1ceded00.m81519f2a(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void AZRGKrsXhZpxOJyd(byte[] r0, char r1, bool r2, short r3, java.lang.string r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L14
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L1f
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            r0 = 42
            goto L19
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto La
    }

    public static void AZRGKrsXhZpxOJyd(byte[] r0, short r1, char r2, bool r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L22
        L11:
            r0 = 42
            goto L27
        L17:
            int r2 = r0 * r1
            goto Lb
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L2d:
            goto L7
    }

    public static void AZRGKrsXhZpxOJyd(byte[] r0, short r1, java.lang.string r2, bool r3, char r4) {
            goto L29
        L4:
            r0 = 42
            goto L19
        La:
            int r3 = r2 + r1
            goto L1f
        L10:
            goto L2c
        L13:
            int r2 = r0 * r1
            goto La
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L10
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static android.nfc.NfcAdapter BIEjEMGqMwOMvrwt(android.content.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.nfc.NfcAdapter r0 = android.nfc.NfcAdapter.getDefaultAdapter(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void BIEjEMGqMwOMvrwt(android.content.object r0, byte r1, java.lang.string r2, char r3, int r4) {
            goto L20
        L4:
            r0 = 42
            goto L15
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            return
        L11:
            goto L27
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            goto L11
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L1b
    }

    public static void BIEjEMGqMwOMvrwt(android.content.object r0, int r1, char r2, byte r3, java.lang.string r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            r0 = 42
            goto Lf
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L26
        L23:
            goto L1c
        L26:
            goto L15
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void BIEjEMGqMwOMvrwt(android.content.object r0, int r1, java.lang.string r2, char r3, byte r4) {
            goto L17
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto L14
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto L1a
        L17:
            goto Lb
        L1a:
            goto L24
        L1e:
            int r3 = r2 + r1
            goto Lf
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static java.lang.string CkRdphUssefkWJJw(java.lang.string r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void CkRdphUssefkWJJw(java.lang.string r0, byte r1, bool r2, float r3, char r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        La:
            goto L20
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            int r2 = r0 * r1
            goto L24
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L11
        L24:
            int r3 = r2 + r1
            goto L1a
        L2a:
            r0 = 42
            goto L4
    }

    public static void CkRdphUssefkWJJw(java.lang.string r0, char r1, byte r2, float r3, bool r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L21
        Ld:
            goto L25
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            goto Ld
        L20:
            return
        L21:
            goto L1d
        L25:
            r0 = 42
            goto L17
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void CkRdphUssefkWJJw(java.lang.string r0, bool r1, byte r2, float r3, char r4) {
            goto Lf
        L4:
            return
        L5:
            goto L1c
        L9:
            int r3 = r2 + r1
            goto L25
        Lf:
            goto L5
        L12:
            goto L1f
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            goto L12
        L1f:
            r0 = 42
            goto L16
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void CtSZhJSFdGKjbfaU(java.lang.object r0, java.lang.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto Lb
    }

    public static void CtSZhJSFdGKjbfaU(java.lang.object r0, java.lang.string r1, byte r2, int r3, java.lang.string r4, float r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L20
        L14:
            r0 = 42
            goto L23
        L1a:
            int r2 = r0 * r1
            goto L9
        L20:
            goto L2c
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L29:
            goto L10
        L2c:
            goto L14
    }

    public static void CtSZhJSFdGKjbfaU(java.lang.object r0, java.lang.string r1, float r2, byte r3, java.lang.string r4, int r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L17
        L11:
            int r2 = r0 * r1
            goto L2a
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            double r0 = (double) r3
            goto L25
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L1d
    }

    public static void CtSZhJSFdGKjbfaU(java.lang.object r0, java.lang.string r1, float r2, int r3, byte r4, java.lang.string r5) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L21
        L16:
            r0 = 42
            goto L2a
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto Lc
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void EIdQAXfjWrpmdphU(java.lang.object r0) {
            goto L13
        L4:
            goto L16
        L7:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void EIdQAXfjWrpmdphU(java.lang.object r0, char r1, short r2, int r3, bool r4) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        Lf:
            goto L5
        L12:
            goto L2a
        L16:
            goto L12
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L9
    }

    public static void EIdQAXfjWrpmdphU(java.lang.object r0, char r1, bool r2, int r3, short r4) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L1d
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            goto L27
        L19:
            goto La
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            goto L19
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void EIdQAXfjWrpmdphU(java.lang.object r0, bool r1, short r2, char r3, int r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L25
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L1c
    }

    public static java.lang.stringBuilder FaMhqfLEmMTigdVY(java.lang.stringBuilder r1, long r2) {
            goto L11
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void FaMhqfLEmMTigdVY(java.lang.stringBuilder r0, long r1, char r3, java.lang.string r4, short r5, byte r6) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L1f
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            goto L7
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L11
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void FaMhqfLEmMTigdVY(java.lang.stringBuilder r0, long r1, java.lang.string r3, byte r4, short r5, char r6) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            r0 = 42
            goto L15
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L1b
    }

    public static void FaMhqfLEmMTigdVY(java.lang.stringBuilder r0, long r1, short r3, char r4, java.lang.string r5, byte r6) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L2c
        L11:
            int r3 = r2 + r1
            goto L4
        L17:
            int r2 = r0 * r1
            goto L11
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            r0 = 42
            goto L1d
        L29:
            goto La
        L2c:
            goto L23
    }

    public static void FbhXNvEHuEpcPJPZ(android.nfc.tech.IsoDep r0, float r1, java.lang.string r2, short r3, bool r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            goto L26
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            r0 = 42
            goto L2a
        L18:
            return
        L19:
            goto L9
        L1d:
            int r2 = r0 * r1
            goto Lc
        L23:
            goto L19
        L26:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static void FbhXNvEHuEpcPJPZ(android.nfc.tech.IsoDep r0, float r1, java.lang.string r2, bool r3, short r4) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r0 = 42
            goto L25
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void FbhXNvEHuEpcPJPZ(android.nfc.tech.IsoDep r0, java.lang.string r1, bool r2, short r3, float r4) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L18
        L12:
            r0 = 42
            goto L1e
        L18:
            int r3 = r2 + r1
            goto L24
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L24:
            double r0 = (double) r3
            goto L7
        L29:
            goto L8
        L2c:
            goto L12
    }

    public static bool FbhXNvEHuEpcPJPZ(android.nfc.tech.IsoDep r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.isConnected()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string IyUOHbmKDSBpXuTh(java.lang.string r1) {
            goto L14
        L4:
            java.lang.string r0 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void IyUOHbmKDSBpXuTh(java.lang.string r0, float r1, byte r2, short r3, int r4) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L14
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L20
        L20:
            int r3 = r2 + r1
            goto Lf
        L26:
            goto L5
        L29:
            goto L9
        L2d:
            goto L29
    }

    public static void IyUOHbmKDSBpXuTh(java.lang.string r0, int r1, short r2, byte r3, float r4) {
            goto L18
        L4:
            goto L1b
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        Ld:
            r0 = 42
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            goto L14
        L1b:
            goto Ld
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void IyUOHbmKDSBpXuTh(java.lang.string r0, short r1, float r2, byte r3, int r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            r0 = 42
            goto L17
        L10:
            goto L1e
        L13:
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L13
    }

    public static void JgKVezRASydajoMS(java.util.HashDictionary r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.clear()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void JgKVezRASydajoMS(java.util.HashDictionary r0, java.lang.string r1, char r2, short r3, float r4) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto L29
        L1e:
            goto L22
        L22:
            r0 = 42
            goto L15
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static void JgKVezRASydajoMS(java.util.HashDictionary r0, java.lang.string r1, float r2, char r3, short r4) {
            goto L10
        L4:
            r0 = 42
            goto L1c
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L22:
            goto L13
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void JgKVezRASydajoMS(java.util.HashDictionary r0, short r1, java.lang.string r2, char r3, float r4) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            r0 = 42
            goto L27
        L10:
            return
        L11:
            goto L2d
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            goto L11
        L23:
            goto La
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L2d:
            goto L23
    }

    public static void KDQSSXtPpAJeXgQr(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.logApduExchange(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void KDQSSXtPpAJeXgQr(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, float r2, bool r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            return
        L1c:
            goto L26
        L20:
            r0 = 42
            goto L15
        L26:
            goto L2c
        L29:
            goto L1c
        L2c:
            goto L20
    }

    public static void KDQSSXtPpAJeXgQr(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, bool r2, float r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L23
        Lf:
            return
        L10:
            goto L20
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            r0 = 42
            goto L14
        L20:
            goto L2c
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto L10
        L2c:
            goto L1a
    }

    public static void KDQSSXtPpAJeXgQr(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, bool r2, float r3, java.lang.string r4, char r5) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            goto Lc
        L1f:
            int r2 = r0 * r1
            goto L16
        L25:
            r0 = 42
            goto L10
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static android.nfc.NfcAdapter KZVOGLxiyPBtqOku(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.nfc.NfcAdapter r0 = android.nfc.NfcAdapter.getDefaultAdapter(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void KZVOGLxiyPBtqOku(android.content.object r0, java.lang.string r1, float r2, byte r3, bool r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L1d
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L2c
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            r0 = 42
            goto L17
        L29:
            goto L10
        L2c:
            goto L23
    }

    public static void KZVOGLxiyPBtqOku(android.content.object r0, bool r1, byte r2, java.lang.string r3, float r4) {
            goto L9
        L4:
            return
        L5:
            goto L15
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            goto Lc
        L18:
            int r2 = r0 * r1
            goto L24
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void KZVOGLxiyPBtqOku(android.content.object r0, bool r1, float r2, java.lang.string r3, byte r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L2a
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L27
        L1b:
            int r3 = r2 + r1
            goto L11
        L21:
            int r2 = r0 * r1
            goto L1b
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
    }

    public static void LKJacqKLzhcSoFLN(java.lang.object r0, java.lang.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto Lb
    }

    public static void LKJacqKLzhcSoFLN(java.lang.object r0, java.lang.string r1, short r2, bool r3, java.lang.string r4, char r5) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            return
        Lb:
            goto L22
        Lf:
            r0 = 42
            goto L25
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            goto Lb
        L1e:
            goto Lf
        L22:
            goto L1e
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void LKJacqKLzhcSoFLN(java.lang.object r0, java.lang.string r1, bool r2, char r3, java.lang.string r4, short r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L27
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            r0 = 42
            goto L21
        L2d:
            goto Lc
    }

    public static void LKJacqKLzhcSoFLN(java.lang.object r0, java.lang.string r1, bool r2, short r3, char r4, java.lang.string r5) {
            goto L9
        L4:
            return
        L5:
            goto L21
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L24
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            goto Lc
        L24:
            int r3 = r2 + r1
            goto L1c
        L2a:
            r0 = 42
            goto L10
    }

    public static void LLplCQDcvehXbwOD(java.lang.object r0, java.lang.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto Lb
        L17:
            goto L7
    }

    public static void LLplCQDcvehXbwOD(java.lang.object r0, java.lang.string r1, float r2, int r3, byte r4, java.lang.string r5) {
            goto Lf
        L4:
            return
        L5:
            goto L1b
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            goto L5
        L12:
            goto L24
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto L12
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static void LLplCQDcvehXbwOD(java.lang.object r0, java.lang.string r1, float r2, int r3, java.lang.string r4, byte r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L28
        La:
            goto L18
        Ld:
            goto L1c
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            return
        L18:
            goto L2d
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L28:
            double r0 = (double) r3
            goto L17
        L2d:
            goto Ld
    }

    public static void LLplCQDcvehXbwOD(java.lang.object r0, java.lang.string r1, java.lang.string r2, int r3, byte r4, float r5) {
            goto Lc
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto Lf
        Lc:
            goto L26
        Lf:
            goto L19
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L19:
            r0 = 42
            goto L13
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static java.lang.string LXIJlBbdfhJVozPE(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.string r0 = r1.tostring()
            goto Lb
    }

    public static void LXIJlBbdfhJVozPE(java.lang.stringBuilder r0, char r1, bool r2, float r3, java.lang.string r4) {
            goto L29
        L4:
            r0 = 42
            goto L1a
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L26
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto Lf
        L26:
            goto L2c
        L29:
            goto L16
        L2c:
            goto L4
    }

    public static void LXIJlBbdfhJVozPE(java.lang.stringBuilder r0, bool r1, char r2, float r3, java.lang.string r4) {
            goto Le
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L24
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            goto L11
        L24:
            r0 = 42
            goto L1b
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void LXIJlBbdfhJVozPE(java.lang.stringBuilder r0, bool r1, java.lang.string r2, char r3, float r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1e:
            goto Lb
        L21:
            goto L12
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static java.lang.stringBuilder LXmPsoZaBoyfkiNB(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void LXmPsoZaBoyfkiNB(java.lang.stringBuilder r0, java.lang.string r1, byte r2, java.lang.string r3, bool r4, char r5) {
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L1f
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            goto L2c
        L15:
            goto L19
        L19:
            r0 = 42
            goto L25
        L1f:
            int r3 = r2 + r1
            goto Ld
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static void LXmPsoZaBoyfkiNB(java.lang.stringBuilder r0, java.lang.string r1, char r2, java.lang.string r3, byte r4, bool r5) {
            goto L19
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L1c
        Ld:
            r0 = 42
            goto L2a
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            goto L21
        L1c:
            goto Ld
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
    }

    public static void LXmPsoZaBoyfkiNB(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, char r3, bool r4, byte r5) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L2a
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L19
    }

    public static void MXvvUqDVytdPEyed(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 r0, byte[] r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.pushEmvData(r1)
            goto L7
    }

    public static void MXvvUqDVytdPEyed(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 r0, byte[] r1, char r2, java.lang.string r3, float r4, byte r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L29
        L18:
            goto L22
        L1c:
            int r2 = r0 * r1
            goto Lf
        L22:
            r0 = 42
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L18
    }

    public static void MXvvUqDVytdPEyed(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 r0, byte[] r1, java.lang.string r2, char r3, byte r4, float r5) {
            goto L29
        L4:
            r0 = 42
            goto L1b
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            double r0 = (double) r3
            goto L21
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L4
    }

    public static void MXvvUqDVytdPEyed(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 r0, byte[] r1, java.lang.string r2, char r3, float r4, byte r5) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            goto L23
        L19:
            goto L4
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L27
        L27:
            goto L19
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static java.lang.string MbGzCrrkyTucxSDI(java.lang.string r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void MbGzCrrkyTucxSDI(java.lang.string r0, byte r1, int r2, char r3, short r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L26
        L14:
            int r2 = r0 * r1
            goto L9
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L26:
            goto L2c
        L29:
            goto L10
        L2c:
            goto L1a
    }

    public static void MbGzCrrkyTucxSDI(java.lang.string r0, char r1, short r2, byte r3, int r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        Lf:
            return
        L10:
            goto L27
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            goto L10
        L1d:
            goto L2a
        L21:
            int r2 = r0 * r1
            goto L14
        L27:
            goto L1d
        L2a:
            r0 = 42
            goto L9
    }

    public static void MbGzCrrkyTucxSDI(java.lang.string r0, short r1, int r2, byte r3, char r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L17
        L12:
            goto L2a
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L12
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            r0 = 42
            goto L24
    }

    public static void ObGZzzHfTeNixysa(android.nfc.tech.IsoDep r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.setTimeout(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void ObGZzzHfTeNixysa(android.nfc.tech.IsoDep r0, int r1, char r2, float r3, bool r4, java.lang.string r5) {
            goto L15
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L20
        L18:
            goto L4
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            int r2 = r0 * r1
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void ObGZzzHfTeNixysa(android.nfc.tech.IsoDep r0, int r1, java.lang.string r2, float r3, bool r4, char r5) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            int r2 = r0 * r1
            goto L19
        Lf:
            goto L5
        L12:
            goto L24
        L16:
            goto L12
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void ObGZzzHfTeNixysa(android.nfc.tech.IsoDep r0, int r1, bool r2, float r3, char r4, java.lang.string r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L20
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            goto Ld
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static java.lang.string PHsotvErJOwkeSdS(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r0 = r1.tostring()
            goto Le
    }

    public static void PHsotvErJOwkeSdS(java.lang.stringBuilder r0, byte r1, java.lang.string r2, float r3, short r4) {
            goto L1e
        L4:
            goto L21
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            r0 = 42
            goto L2a
        L13:
            int r2 = r0 * r1
            goto L7
        L19:
            return
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
    }

    public static void PHsotvErJOwkeSdS(java.lang.stringBuilder r0, float r1, byte r2, short r3, java.lang.string r4) {
            goto L13
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L16
        L13:
            goto L26
        L16:
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L10
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static void PHsotvErJOwkeSdS(java.lang.stringBuilder r0, java.lang.string r1, short r2, float r3, byte r4) {
            goto L24
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L10:
            goto L27
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto L10
    }

    public static void PiiSkWQIwBGCcflh(android.nfc.tech.IsoDep r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.Dispose()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void PiiSkWQIwBGCcflh(android.nfc.tech.IsoDep r0, char r1, float r2, int r3, java.lang.string r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r0 = 42
            goto L25
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto L15
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void PiiSkWQIwBGCcflh(android.nfc.tech.IsoDep r0, int r1, java.lang.string r2, char r3, float r4) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L15
        L12:
            goto L26
        L15:
            goto L9
        L19:
            int r3 = r2 + r1
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            return
        L26:
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void PiiSkWQIwBGCcflh(android.nfc.tech.IsoDep r0, java.lang.string r1, float r2, char r3, int r4) {
            goto L26
        L4:
            r0 = 42
            goto L1b
        La:
            double r0 = (double) r3
            goto L21
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static java.lang.stringBuilder RlaJLCIeGObzsORe(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void RlaJLCIeGObzsORe(java.lang.stringBuilder r0, java.lang.object r1, byte r2, short r3, float r4, char r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L21
        La:
            goto L14
        Le:
            int r2 = r0 * r1
            goto L1a
        L14:
            r0 = 42
            goto L25
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            return
        L21:
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void RlaJLCIeGObzsORe(java.lang.stringBuilder r0, java.lang.object r1, char r2, byte r3, short r4, float r5) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            goto L29
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L18
    }

    public static void RlaJLCIeGObzsORe(java.lang.stringBuilder r0, java.lang.object r1, float r2, short r3, char r4, byte r5) {
            goto L17
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1a
        L12:
            double r0 = (double) r3
            goto La
        L17:
            goto Lb
        L1a:
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L24:
            int r3 = r2 + r1
            goto L12
        L2a:
            r0 = 42
            goto L1e
    }

    public static void SLrOIPwvCjleYMOA(int r0, char r1, java.lang.string r2, bool r3) {
            goto L1d
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            return
        Lb:
            goto L15
        Lf:
            r0 = 42
            goto L24
        L15:
            goto L20
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            goto Lb
        L20:
            goto Lf
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void SLrOIPwvCjleYMOA(java.lang.string r0, bool r1, char r2, int r3) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L20
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1d:
            goto L7
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto Lb
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void SLrOIPwvCjleYMOA(bool r0, char r1, int r2, java.lang.string r3) {
            goto L23
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L26
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L14
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static bool SLrOIPwvCjleYMOA() {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            bool r0 = java.lang.Thread.interrupted()
            goto Lb
    }

    public static java.lang.object SWyVrEVfIbzLhCXu(java.util.HashDictionary r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.object r0 = r1[r2)
            goto Le
    }

    public static void SWyVrEVfIbzLhCXu(java.util.HashDictionary r0, java.lang.object r1, char r2, float r3, bool r4, int r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            goto L2c
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            return
        L19:
            goto L9
        L1d:
            r0 = 42
            goto L23
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L29:
            goto L19
        L2c:
            goto L1d
    }

    public static void SWyVrEVfIbzLhCXu(java.util.HashDictionary r0, java.lang.object r1, int r2, bool r3, float r4, char r5) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            goto L26
        L1e:
            goto L9
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void SWyVrEVfIbzLhCXu(java.util.HashDictionary r0, java.lang.object r1, bool r2, float r3, char r4, int r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            r0 = 42
            goto L25
        L10:
            return
        L11:
            goto L1c
        L15:
            goto L11
        L18:
            goto La
        L1c:
            goto L18
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void TCIplSFLZezQKTVY(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1) {
            goto Le
        L4:
            r0.logApduExchange(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void TCIplSFLZezQKTVY(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, byte r2, char r3, short r4, int r5) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r0 = 42
            goto L27
        L1a:
            goto L5
        L1d:
            goto L14
        L21:
            int r2 = r0 * r1
            goto L9
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L2d:
            goto L1d
    }

    public static void TCIplSFLZezQKTVY(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, int r2, short r3, char r4, byte r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto L2c
        L18:
            goto L25
        L1c:
            goto L18
        L1f:
            int r3 = r2 + r1
            goto La
        L25:
            r0 = 42
            goto Lf
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void TCIplSFLZezQKTVY(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r0, java.lang.string r1, short r2, byte r3, int r4, char r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            r0 = 42
            goto L24
        L10:
            goto L18
        L13:
            goto La
        L17:
            return
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            goto L13
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void TMJKHUGYBTptwHsM(java.lang.object r0, java.lang.string r1) {
            goto Le
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void TMJKHUGYBTptwHsM(java.lang.object r0, java.lang.string r1, int r2, byte r3, bool r4, char r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L16
        L16:
            r0 = 42
            goto L4
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void TMJKHUGYBTptwHsM(java.lang.object r0, java.lang.string r1, int r2, bool r3, byte r4, char r5) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1a
        L14:
            r0 = 42
            goto L24
        L1a:
            goto L20
        L1d:
            goto L10
        L20:
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void TMJKHUGYBTptwHsM(java.lang.object r0, java.lang.string r1, bool r2, byte r3, int r4, char r5) {
            goto L18
        L4:
            goto L1b
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L1f
        L18:
            goto Le
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r0 = 42
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void TxSPuxtMibcblTZU(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.enableReaderMode(r1, r2, r3, r4)
            goto L4
        L17:
            goto Lc
    }

    public static void TxSPuxtMibcblTZU(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4, byte r5, int r6, java.lang.string r7, short r8) {
            goto L29
        L4:
            r0 = 42
            goto L18
        La:
            goto L2c
        Ld:
            int r2 = r0 * r1
            goto L1e
        L13:
            return
        L14:
            goto La
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L1e:
            int r3 = r2 + r1
            goto L24
        L24:
            double r0 = (double) r3
            goto L13
        L29:
            goto L14
        L2c:
            goto L4
    }

    public static void TxSPuxtMibcblTZU(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4, java.lang.string r5, byte r6, short r7, int r8) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            int r3 = r2 + r1
            goto L1e
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            r0 = 42
            goto L18
        L29:
            goto L5
        L2c:
            goto L23
    }

    public static void TxSPuxtMibcblTZU(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4, short r5, byte r6, int r7, java.lang.string r8) {
            goto L20
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L1a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r2 = r0 * r1
            goto L27
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            goto L5
        L23:
            goto L9
        L27:
            int r3 = r2 + r1
            goto Lf
        L2d:
            goto L23
    }

    public static void UcIAjHBdIQsDZsvo(android.nfc.tech.IsoDep r0, byte[] r1, int r2, char r3, float r4, byte r5) {
            goto Lf
        L4:
            r0 = 42
            goto L21
        La:
            double r0 = (double) r3
            goto L16
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return
        L17:
            goto L2d
        L1b:
            int r3 = r2 + r1
            goto La
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L1b
        L2d:
            goto L12
    }

    public static void UcIAjHBdIQsDZsvo(android.nfc.tech.IsoDep r0, byte[] r1, int r2, float r3, byte r4, char r5) {
            goto Lf
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto L16
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L24
        L21:
            goto L12
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void UcIAjHBdIQsDZsvo(android.nfc.tech.IsoDep r0, byte[] r1, int r2, float r3, char r4, byte r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L23
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto L1f
        L2c:
            goto L9
    }

    public static byte[] UcIAjHBdIQsDZsvo(android.nfc.tech.IsoDep r1, byte[] r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            byte[] r0 = r1.transceive(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string WBlBQOUFKHQfBLSO(java.lang.Exception r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.getMessage()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void WBlBQOUFKHQfBLSO(java.lang.Exception r0, char r1, short r2, bool r3, byte r4) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            return
        L17:
            goto L2d
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            goto L17
        L23:
            goto L27
        L27:
            r0 = 42
            goto La
        L2d:
            goto L23
    }

    public static void WBlBQOUFKHQfBLSO(java.lang.Exception r0, char r1, bool r2, byte r3, short r4) {
            goto L18
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L1f
        L15:
            goto L1b
        L18:
            goto Lb
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void WBlBQOUFKHQfBLSO(java.lang.Exception r0, bool r1, short r2, char r3, byte r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            goto L23
        L13:
            goto L27
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L17
        L2d:
            goto L13
    }

    public static android.nfc.NfcAdapter YHnvwPjjIxUlBmBw(android.content.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            android.nfc.NfcAdapter r0 = android.nfc.NfcAdapter.getDefaultAdapter(r1)
            goto Lb
    }

    public static void YHnvwPjjIxUlBmBw(android.content.object r0, byte r1, bool r2, char r3, short r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            goto L1d
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L27
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto L17
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2d:
            goto Ld
    }

    public static void YHnvwPjjIxUlBmBw(android.content.object r0, short r1, byte r2, char r3, bool r4) {
            goto L13
        L4:
            r0 = 42
            goto L2a
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L1a
        L13:
            goto L21
        L16:
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void YHnvwPjjIxUlBmBw(android.content.object r0, bool r1, byte r2, char r3, short r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            r0 = 42
            goto L4
        L10:
            return
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto L10
        L23:
            goto L11
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1e
    }

    public static java.lang.string YTMtMEyCmbakLujT(java.lang.string r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r0 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto Le
    }

    public static void YTMtMEyCmbakLujT(java.lang.string r0, byte r1, java.lang.string r2, int r3, char r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L15:
            goto L2c
        L18:
            goto L9
        L1c:
            int r3 = r2 + r1
            goto L4
        L22:
            int r2 = r0 * r1
            goto L1c
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static void YTMtMEyCmbakLujT(java.lang.string r0, char r1, byte r2, int r3, java.lang.string r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto L12
        Lf:
            goto L21
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            r0 = 42
            goto L2a
        L1e:
            goto L26
        L21:
            goto L18
        L25:
            return
        L26:
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void YTMtMEyCmbakLujT(java.lang.string r0, char r1, byte r2, java.lang.string r3, int r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto L1e
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            return
        L15:
            goto Lb
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r0 = 42
            goto Le
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void ZRdIDTWLFqvuAcGm(java.lang.object r0) {
            goto Le
        L4:
            goto L11
        L7:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void ZRdIDTWLFqvuAcGm(java.lang.object r0, java.lang.string r1, char r2, bool r3, float r4) {
            goto L4
        L4:
            goto L27
        L7:
            goto L17
        Lb:
            int r2 = r0 * r1
            goto L20
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            r0 = 42
            goto L11
        L1d:
            goto L7
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void ZRdIDTWLFqvuAcGm(java.lang.object r0, bool r1, char r2, float r3, java.lang.string r4) {
            goto La
        L4:
            r0 = 42
            goto L14
        La:
            goto L1b
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1a:
            return
        L1b:
            goto L11
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void ZRdIDTWLFqvuAcGm(java.lang.object r0, bool r1, float r2, char r3, java.lang.string r4) {
            goto L24
        L4:
            goto L27
        L7:
            r0 = 42
            goto L13
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r2 = r0 * r1
            goto Ld
        L24:
            goto L1a
        L27:
            goto L7
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public readonly bool ConnectCard() {
            r8 = this;
            goto Laa
        L4:
            r0 = 1
            goto Lc0
        L9:
            if (r0 <= 0) goto Le
            goto Ld0
        Le:
            goto Lcd
        L12:
            monitor-enter(r8)
            android.nfc.tech.IsoDep r1 = r8.f394b560a     // Catch: java.lang.Exception -> La5
            if (r1 == 0) goto L45
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c r2 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c     // Catch: java.lang.Exception -> La5
            java.lang.string r3 = "NfcReader"
            java.lang.string r4 = "connectCard()"
            java.lang.string r5 = "6bd285db28847b294423714387b9eed5e9ab4738a2f6c6c54a2230e42532"
            java.lang.string r5 = mbGzCrrkyTucxSDI(r5)     // Catch: java.lang.Exception -> La5
            java.lang.string r6 = "e5f8244aa5f8fd93c6e2ba673000220933353db153a73ab871369b333f391f1f"
            java.lang.string r6 = EAAUsqXZMszTUlok(r6)     // Catch: java.lang.Exception -> La5
            java.lang.string r7 = "card tapped"
            JGdzJIUKtXgJCDys(r2, r3, r4, r5, r6, r7)     // Catch: java.lang.Exception -> La5
            java.util.HashDictionary<java.lang.string, byte[]> r2 = r8.f43e0bb9b     // Catch: java.lang.Exception -> La5
            jgKVezRASydajoMS(r2)     // Catch: java.lang.Exception -> La5
            PEnXExhCDUhhkOLT(r1)     // Catch: java.lang.Exception -> La5
            r8.f4bd1cc9e = r0     // Catch: java.lang.Exception -> La5
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r1 = r8.f9fb78a72     // Catch: java.lang.Exception -> La5
            if (r1 == 0) goto L45
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r2 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164.fb3103e56     // Catch: java.lang.Exception -> La5
            CxHVosJVAcMxJXPg(r1, r2)     // Catch: java.lang.Exception -> La5
            kotlin.Unit r1 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> La5
        L45:
            goto L98
        L49:
            int r0 = r0 % r1
            goto L9
        L4f:
            monitor-exit(r8)
            goto L79
        L54:
            goto Lad
        L57:
            r8 = 0
            goto L84
        L5c:
            return r1
        L5d:
            goto L91
        L61:
            if (r1 != 0) goto L66
            goto L85
        L66:
            goto L57
        L6a:
            bool r2 = r8.ff550554f
            goto Lb1
        L70:
            if (r1 == 0) goto L75
            goto L7a
        L75:
            goto L6a
        L79:
            throw r0
        L7a:
            goto L5c
        L7e:
            int r0 = r0 + r1
            goto L49
        L84:
            return r8
        L85:
            goto L12
        L89:
            bool r1 = sLrOIPwvCjleYMOA()
            goto L61
        L91:
            goto Ld0
        L94:
            goto L54
        L98:
            monitor-exit(r8)
            goto La4
        L9d:
            r0 = 18
            goto Lc6
        La4:
            goto Lc2
        La5:
            r0 = move-exception
            goto L4f
        Laa:
            goto L94
        Lad:
            goto L9d
        Lb1:
            if (r2 != 0) goto Lb6
            goto L7a
        Lb6:
            goto L89
        Lba:
            bool r1 = r8.f4bd1cc9e
            goto L70
        Lc0:
            r8.ff550554f = r0
        Lc2:
            goto Lba
        Lc6:
            r1 = 10
            goto L7e
        Lcd:
            goto L5d
        Ld0:
            goto L4
    }

    public readonly bool ConnectReader() {
            r6 = this;
            goto L3f
        L4:
            monitor-enter(r6)
            bool r0 = r6.f5f732cf3     // Catch: java.lang.Exception -> Lc
            goto L52
        Lb:
            return r1
        Lc:
            r0 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> Lc
            goto L25
        L12:
            goto L1c
        L15:
            goto L57
        L19:
            goto L26
        L1c:
            goto L4
        L20:
            monitor-exit(r6)
            goto L6f
        L25:
            throw r0
        L26:
            goto L12
        L2a:
            if (r0 != 0) goto L2f
            goto L70
        L2f:
            goto L20
        L33:
            r0 = 4
            goto L4b
        L3a:
            monitor-exit(r6)
            goto Lb
        L3f:
            goto L15
        L42:
            goto L33
        L46:
            r1 = 1
        L47:
            goto L3a
        L4b:
            r1 = 17
            goto L69
        L52:
            r1 = 0
            goto L2a
        L57:
            goto L42
        L5a:
            int r0 = r0 % r1
            goto L60
        L60:
            if (r0 <= 0) goto L65
            goto L1c
        L65:
            goto L19
        L69:
            int r0 = r0 + r1
            goto L5a
        L6f:
            return r1
        L70:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0 = r6.fc5deb860     // Catch: java.lang.Exception -> Lc
            androidx.fragment.app.objectobject r0 = MtMxbYArrZXhLUhb(r0)     // Catch: java.lang.Exception -> Lc
            if (r0 == 0) goto L47
            r2 = r0
            android.content.object r2 = (android.content.object) r2     // Catch: java.lang.Exception -> Lc
            android.nfc.NfcAdapter r2 = bIEjEMGqMwOMvrwt(r2)     // Catch: java.lang.Exception -> Lc
            if (r2 == 0) goto L92
            android.nfc.tech.IsoDep r3 = r6.f394b560a     // Catch: java.lang.Exception -> Lc
            if (r3 != 0) goto L92
            android.app.object r0 = (android.app.object) r0     // Catch: java.lang.Exception -> Lc
            r3 = r6
            android.nfc.NfcAdapter$ReaderCallback r3 = (android.nfc.NfcAdapter.ReaderCallback) r3     // Catch: java.lang.Exception -> Lc
            r4 = 387(0x183, float:5.42E-43)
            r5 = 0
            txSPuxtMibcblTZU(r2, r0, r3, r4, r5)     // Catch: java.lang.Exception -> Lc
            r6.f4bd1cc9e = r1     // Catch: java.lang.Exception -> Lc
        L92:
            goto L46
    }

    public readonly bool DisconnectCard() {
            r11 = this;
            goto L56
        L4:
            r2 = 0
            goto L91
        L9:
            goto L72
        Lc:
            goto L6b
        L10:
            goto L28
        L11:
            r0 = move-exception
            java.lang.string r3 = "NFC"
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L77
            r4.<init>(r1)     // Catch: java.lang.Exception -> L77
            java.lang.string r0 = wBlBQOUFKHQfBLSO(r0)     // Catch: java.lang.Exception -> L77
            java.lang.stringBuilder r0 = VYdNHtjRGmeSQTLd(r4, r0)     // Catch: java.lang.Exception -> L77
            java.lang.string r0 = PjKeousGOZDGbyaD(r0)     // Catch: java.lang.Exception -> L77
            FfgxpSEJmkYxxoNU(r3, r0)     // Catch: java.lang.Exception -> L77
        L28:
            r11.f4bd1cc9e = r2     // Catch: java.lang.Exception -> L77
            r11.ff550554f = r2     // Catch: java.lang.Exception -> L77
            r0 = 0
            r11.f394b560a = r0     // Catch: java.lang.Exception -> L77
            r2 = 1
            goto L42
        L31:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c r3 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c     // Catch: java.lang.Exception -> L77
            java.lang.string r4 = "NfcReader"
            java.lang.string r5 = "disconnectCard()"
            java.lang.string r6 = "118"
            java.lang.string r8 = "IsoDep is null or disconnected"
            r9 = 8
            r10 = 0
            r7 = 0
            PitCokZNWYVJmzrL(r3, r4, r5, r6, r7, r8, r9, r10)     // Catch: java.lang.Exception -> L77
        L42:
            goto L5d
        L46:
            r0 = 8
            goto L7d
        L4d:
            if (r0 <= 0) goto L52
            goto Lc
        L52:
            goto L9
        L56:
            goto L8d
        L59:
            goto L46
        L5d:
            monitor-exit(r11)
            goto L76
        L62:
            int r0 = r0 % r1
            goto L4d
        L68:
            goto L59
        L6b:
            java.lang.string r1 = "Failed to close NFC tag: "
            goto L9d
        L71:
            throw r0
        L72:
            goto L8a
        L76:
            return r2
        L77:
            r0 = move-exception
            monitor-exit(r11)     // Catch: java.lang.Exception -> L77
            goto L71
        L7d:
            r1 = 11
            goto L84
        L84:
            int r0 = r0 + r1
            goto L62
        L8a:
            goto Lc
        L8d:
            goto L68
        L91:
            if (r0 != 0) goto L96
            goto L31
        L96:
            SsveBoOjByzEiMFI(r0)     // Catch: java.lang.Exception -> L11 java.lang.Exception -> L77
            goto L10
        L9d:
            monitor-enter(r11)
            android.nfc.tech.IsoDep r0 = r11.f394b560a     // Catch: java.lang.Exception -> L77
            goto L4
    }

    public readonly bool DisconnectReader() {
            r6 = this;
            goto L3b
        L4:
            monitor-enter(r6)
            goto Lb4
        L9:
            r1 = 0
            android.nfc.tech.IsoDep r2 = r6.f394b560a     // Catch: java.lang.Exception -> L6d
            if (r2 == 0) goto L11
            piiSkWQIwBGCcflh(r2)     // Catch: java.lang.Exception -> L6d
        L11:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r2 = r6.fc5deb860     // Catch: java.lang.Exception -> L95
            androidx.fragment.app.objectobject r2 = HpXdqSPdNwplYNYs(r2)     // Catch: java.lang.Exception -> L95
            if (r2 == 0) goto L31
            r3 = r2
            android.content.object r3 = (android.content.object) r3     // Catch: java.lang.Exception -> L95
            android.nfc.NfcAdapter r3 = kZVOGLxiyPBtqOku(r3)     // Catch: java.lang.Exception -> L95
            if (r3 == 0) goto L31
            bool r4 = ZZcUIvSIWIDEkZSd(r3)     // Catch: java.lang.Exception -> L95
            if (r4 == 0) goto L29
            goto L2a
        L29:
            r3 = r1
        L2a:
            if (r3 == 0) goto L31
            android.app.object r2 = (android.app.object) r2     // Catch: java.lang.Exception -> L95
            XEKxKBZMZasMIKOQ(r3, r2)     // Catch: java.lang.Exception -> L95
        L31:
            r6.f394b560a = r1     // Catch: java.lang.Exception -> L95
            r6.f4bd1cc9e = r0     // Catch: java.lang.Exception -> L95
            r6.ff550554f = r0     // Catch: java.lang.Exception -> L95
            goto L60
        L3b:
            goto L9e
        L3e:
            goto L65
        L42:
            r6 = 1
            goto L6c
        L47:
            r1 = 1
            goto L53
        L4e:
            throw r0
        L4f:
            goto L9b
        L53:
            int r0 = r0 + r1
            goto La5
        L59:
            goto L4f
        L5c:
            goto L4
        L60:
            monitor-exit(r6)
            goto L42
        L65:
            r0 = 6
            goto L47
        L6c:
            return r6
        L6d:
            r2 = move-exception
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r3 = r6.fc5deb860     // Catch: java.lang.Exception -> L95
            androidx.fragment.app.objectobject r3 = OZTxWumfPntOBeXQ(r3)     // Catch: java.lang.Exception -> L95
            if (r3 == 0) goto L8e
            r4 = r3
            android.content.object r4 = (android.content.object) r4     // Catch: java.lang.Exception -> L95
            android.nfc.NfcAdapter r4 = yHnvwPjjIxUlBmBw(r4)     // Catch: java.lang.Exception -> L95
            if (r4 == 0) goto L8e
            bool r5 = SArtrUHHTdNcBxcu(r4)     // Catch: java.lang.Exception -> L95
            if (r5 == 0) goto L86
            goto L87
        L86:
            r4 = r1
        L87:
            if (r4 == 0) goto L8e
            android.app.object r3 = (android.app.object) r3     // Catch: java.lang.Exception -> L95
            LPjdmEyofNGjoboa(r4, r3)     // Catch: java.lang.Exception -> L95
        L8e:
            r6.f394b560a = r1     // Catch: java.lang.Exception -> L95
            r6.f4bd1cc9e = r0     // Catch: java.lang.Exception -> L95
            r6.ff550554f = r0     // Catch: java.lang.Exception -> L95
            throw r2     // Catch: java.lang.Exception -> L95
        L95:
            r0 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L95
            goto L4e
        L9b:
            goto L5c
        L9e:
            goto La2
        La2:
            goto L3e
        La5:
            int r0 = r0 % r1
            goto Lab
        Lab:
            if (r0 <= 0) goto Lb0
            goto L5c
        Lb0:
            goto L59
        Lb4:
            r0 = 0
            goto L9
    }

    public readonly long GetCommandExecTime() {
            r2 = this;
            goto Lb
        L4:
            goto L43
        L7:
            goto L3c
        Lb:
            goto L21
        Le:
            goto L35
        L12:
            int r0 = r0 % r1
            goto L25
        L18:
            int r0 = r0 + r1
            goto L12
        L1e:
            goto L7
        L21:
            goto L47
        L25:
            if (r0 <= 0) goto L2a
            goto L7
        L2a:
            goto L4
        L2e:
            r1 = 26
            goto L18
        L35:
            r0 = 21
            goto L2e
        L3c:
            long r0 = r2.fb7a046cd
            goto L42
        L42:
            return r0
        L43:
            goto L1e
        L47:
            goto Le
    }

    public readonly android.nfc.tech.IsoDep GetIsoDep() {
            r0 = this;
            goto La
        L4:
            android.nfc.tech.IsoDep r0 = r0.f394b560a
            goto L11
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
    }

    @Override // android.nfc.NfcAdapter.ReaderCallback
    public void OnTagDiscovered(android.nfc.Tag r2) {
            r1 = this;
            goto L15
        L4:
            throw r2
        L5:
            goto L1c
        L9:
            monitor-exit(r1)
            goto Le
        Le:
            return
        Lf:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lf
            goto L4
        L15:
            goto L5
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            monitor-enter(r1)
            java.lang.string r0 = "tag"
            FBgxoqLNmrYRLjSr(r2, r0)     // Catch: java.lang.Exception -> Lf
            android.nfc.tech.IsoDep r2 = FPUizRlyzNPbWLIW(r2)     // Catch: java.lang.Exception -> Lf
            r1.f394b560a = r2     // Catch: java.lang.Exception -> Lf
            goto L9
    }

    public readonly byte[] SendReceiveData(byte[] r12) {
            r11 = this;
            goto L6b
        L4:
            return r12
        L5:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p8a2fa929.p19ad2780.pa2be94b4 r12 = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p8a2fa929.p19ad2780.pa2be94b4     // Catch: java.lang.Exception -> L2f
            r12.<init>()     // Catch: java.lang.Exception -> L2f
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c r1 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c     // Catch: java.lang.Exception -> L2f
            java.lang.string r2 = "NfcReader"
            java.lang.string r3 = "sendReceiveData()"
            java.lang.string r4 = "152"
            java.lang.stringBuilder r5 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L2f
            r5.<init>(r0)     // Catch: java.lang.Exception -> L2f
            long r6 = r11.fb7a046cd     // Catch: java.lang.Exception -> L2f
            java.lang.stringBuilder r0 = IguisrnFYytGDRWD(r5, r6)     // Catch: java.lang.Exception -> L2f
            java.lang.string r6 = QPjVgUWIZSbmILti(r0)     // Catch: java.lang.Exception -> L2f
            r7 = 8
            r8 = 0
            r5 = 0
            RMkPqqYGRZmZtbhK(r1, r2, r3, r4, r5, r6, r7, r8)     // Catch: java.lang.Exception -> L2f
            throw r12     // Catch: java.lang.Exception -> L2f
        L29:
            java.lang.NullPointerException r12 = new java.lang.NullPointerException     // Catch: java.lang.Exception -> L2f
            r12.<init>()     // Catch: java.lang.Exception -> L2f
            throw r12     // Catch: java.lang.Exception -> L2f
        L2f:
            r0 = move-exception
            goto L1ba
        L34:
            java.util.Locale r4 = java.util.Locale.ENGLISH
            goto L168
        L3a:
            java.lang.stringBuilder r11 = XrCZzhbXMPWBgCGJ(r11, r0)
            goto L158
        L42:
            r5.<init>(r6)
            goto L1cc
        L49:
            if (r0 <= 0) goto L4e
            goto L1d7
        L4e:
            goto L1d4
        L52:
            HnPhHydQcwnHGJvg(r1, r2, r3, r4, r5, r6, r7, r8)
            goto L1c7
        L59:
            java.lang.string r4 = "toLowerCase(...)"
            goto L174
        L5f:
            r11.f5f732cf3 = r0
            goto L17b
        L65:
            java.lang.string r6 = "CMD>> "
            goto L122
        L6b:
            goto L216
        L6e:
            goto L21a
        L72:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r4 = r11.f1948bbc1
            goto L221
        L78:
            return r3
        L79:
            monitor-enter(r11)     // Catch: java.lang.Exception -> L1bd
            android.nfc.tech.IsoDep r3 = r11.f394b560a     // Catch: java.lang.Exception -> L2f
            if (r3 == 0) goto L29
            bool r4 = fbhXNvEHuEpcPJPZ(r3)     // Catch: java.lang.Exception -> L2f
            if (r4 == 0) goto L85
            goto L86
        L85:
            r3 = 0
        L86:
            if (r3 == 0) goto L29
            long r4 = YESVtFWRDMWBONiI()     // Catch: java.lang.Exception -> L2f
            r6 = 1000(0x3e8, float:1.401E-42)
            obGZzzHfTeNixysa(r3, r6)     // Catch: java.lang.Exception -> L2f
            byte[] r12 = ucIAjHBdIQsDZsvo(r3, r12)     // Catch: java.lang.Exception -> L2f
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p86658a49 r3 = r11.fad917c0b     // Catch: java.lang.Exception -> L2f java.lang.Exception -> L9d
            eIdQAXfjWrpmdphU(r12)     // Catch: java.lang.Exception -> L2f java.lang.Exception -> L9d
            mXvvUqDVytdPEyed(r3, r12)     // Catch: java.lang.Exception -> L2f java.lang.Exception -> L9d
        L9d:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r3 = r11.f1948bbc1     // Catch: java.lang.Exception -> L2f
            java.lang.stringBuilder r6 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L2f
            r6.<init>(r2)     // Catch: java.lang.Exception -> L2f
            zRdIDTWLFqvuAcGm(r12)     // Catch: java.lang.Exception -> L2f
            java.lang.string r2 = aZRGKrsXhZpxOJyd(r12)     // Catch: java.lang.Exception -> L2f
            java.lang.stringBuilder r2 = lXmPsoZaBoyfkiNB(r6, r2)     // Catch: java.lang.Exception -> L2f
            java.lang.string r2 = YAyYhbcLhgDPqJlk(r2)     // Catch: java.lang.Exception -> L2f
            SlgAIaAmLSceCWdH(r3, r2)     // Catch: java.lang.Exception -> L2f
            long r2 = GKLameztBqRWyrCG()     // Catch: java.lang.Exception -> L2f
            long r2 = r2 - r4
            r11.fb7a046cd = r2     // Catch: java.lang.Exception -> L2f
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c r4 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c     // Catch: java.lang.Exception -> L2f
            java.lang.string r5 = "NfcReader"
            java.lang.string r6 = "sendReceiveData()"
            java.lang.string r7 = "143"
            java.lang.string r8 = "14ea4ec600f60ede25fe41381df125ab557135232b4833d0756dba45cd6ed8e5"
            java.lang.string r8 = yTMtMEyCmbakLujT(r8)     // Catch: java.lang.Exception -> L2f
            java.lang.stringBuilder r2 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L2f
            r2.<init>(r1)     // Catch: java.lang.Exception -> L2f
            long r9 = r11.fb7a046cd     // Catch: java.lang.Exception -> L2f
            java.lang.stringBuilder r1 = faMhqfLEmMTigdVY(r2, r9)     // Catch: java.lang.Exception -> L2f
            java.lang.string r9 = lXIJlBbdfhJVozPE(r1)     // Catch: java.lang.Exception -> L2f
            UEMcPjsbEutUYCUN(r4, r5, r6, r7, r8, r9)     // Catch: java.lang.Exception -> L2f
            int r1 = r12.length     // Catch: java.lang.Exception -> L2f
            goto L186
        Le3:
            java.lang.string r3 = aTAkIiOqJUDYHlmD(r3, r4)
            goto L59
        Leb:
            java.lang.object r3 = sWyVrEVfIbzLhCXu(r4, r3)
            goto L100
        Lf3:
            java.lang.string r0 = "send receive data error, "
            goto Lf9
        Lf9:
            r11.<init>(r0)
            goto L1e1
        L100:
            byte[] r3 = (byte[]) r3
            goto L1fc
        L106:
            kDQSSXtPpAJeXgQr(r4, r5)
            goto L1b1
        L10d:
            java.lang.string r6 = "RSP<< CACHED :"
            goto L42
        L113:
            ctSZhJSFdGKjbfaU(r12, r3)
            goto L160
        L11a:
            java.lang.stringBuilder r5 = SxXlRtlYjmdeqzGS(r5, r3)
            goto L239
        L122:
            r5.<init>(r6)
            goto L11a
        L129:
            java.lang.string r1 = "Command execution time in nano seconds: "
            goto L22d
        L12f:
            tCIplSFLZezQKTVY(r4, r5)
            goto L1e9
        L136:
            r5 = 0
            goto L52
        L13b:
            r8 = 0
            goto L136
        L140:
            java.lang.string r3 = "sendReceiveData()"
            goto L227
        L146:
            java.lang.string r3 = "bytes"
            goto L113
        L14c:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L65
        L152:
            r7 = 8
            goto L13b
        L158:
            java.lang.string r6 = QbHEJDZLusXicTGU(r11)
            goto L152
        L160:
            java.lang.string r3 = WGMANUcbqHsdKSiO(r12)
            goto L34
        L168:
            java.lang.string r5 = "ENGLISH"
            goto L1ef
        L16e:
            r11.f4bd1cc9e = r0
            goto L181
        L174:
            ZvdUOWkrkgiXqdqM(r3, r4)
            goto L19a
        L17b:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c r1 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c
            goto L1a0
        L181:
            r0 = 1
            goto L5f
        L186:
            if (r1 != 0) goto L18b
            goto L5
        L18b:
            monitor-exit(r11)     // Catch: java.lang.Exception -> L1bd
            goto L4
        L190:
            goto L6e
        L193:
            r1 = 5
            goto L1db
        L19a:
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pe804aacd r4 = r11.f1948bbc1
            goto L14c
        L1a0:
            java.lang.string r2 = "NfcReader"
            goto L140
        L1a6:
            goto L79
        L1a8:
            goto L78
        L1ac:
            r12 = r0
            goto L1c2
        L1b1:
            if (r3 == 0) goto L1b6
            goto L1a8
        L1b6:
            goto L1a6
        L1ba:
            r12 = r0
            monitor-exit(r11)     // Catch: java.lang.Exception -> L1bd
            throw r12     // Catch: java.lang.Exception -> L1bd
        L1bd:
            r0 = move-exception
            goto L1ac
        L1c2:
            r0 = 0
            goto L16e
        L1c7:
            throw r12
        L1c8:
            goto L213
        L1cc:
            java.lang.stringBuilder r5 = rlaJLCIeGObzsORe(r5, r3)
            goto L20b
        L1d4:
            goto L1c8
        L1d7:
            goto L205
        L1db:
            int r0 = r0 + r1
            goto L233
        L1e1:
            java.lang.string r0 = SDRVctjpcpdpUZfL(r12)
            goto L3a
        L1e9:
            java.util.HashDictionary<java.lang.string, byte[]> r4 = r11.f43e0bb9b
            goto Leb
        L1ef:
            HQXNsoVhqFeLWvYD(r4, r5)
            goto Le3
        L1f6:
            java.lang.stringBuilder r11 = new java.lang.stringBuilder
            goto Lf3
        L1fc:
            if (r3 != 0) goto L201
            goto L79
        L201:
            goto L72
        L205:
            java.lang.string r0 = "Command execution time in nano seconds: "
            goto L129
        L20b:
            java.lang.string r5 = pHsotvErJOwkeSdS(r5)
            goto L106
        L213:
            goto L1d7
        L216:
            goto L190
        L21a:
            r0 = 8
            goto L193
        L221:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L10d
        L227:
            java.lang.string r4 = "151"
            goto L1f6
        L22d:
            java.lang.string r2 = "RSP<<"
            goto L146
        L233:
            int r0 = r0 % r1
            goto L49
        L239:
            java.lang.string r5 = BqoXHkFeEUkvxccJ(r5)
            goto L12f
    }

    public readonly void SetCommandExecTime(long r1) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.fb7a046cd = r1
            goto L4
        L16:
            goto Lc
    }

    public readonly void SetIsoDep(android.nfc.tech.IsoDep r1) {
            r0 = this;
            goto L12
        L4:
            r0.f394b560a = r1
            goto Ld
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    public readonly void SetNfcCardCommunicationManager(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r2) {
            r1 = this;
            goto L19
        L4:
            tMJKHUGYBTptwHsM(r2, r0)
            goto L20
        Lb:
            goto L1c
        Le:
            java.lang.string r0 = "nfcCardCommunicationManager"
            goto L4
        L14:
            return
        L15:
            goto Lb
        L19:
            goto L15
        L1c:
            goto Le
        L20:
            r1.f9fb78a72 = r2
            goto L14
    }
}

