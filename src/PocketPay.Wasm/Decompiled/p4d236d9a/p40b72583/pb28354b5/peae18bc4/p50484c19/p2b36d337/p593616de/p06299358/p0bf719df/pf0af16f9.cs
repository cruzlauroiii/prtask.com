namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes3.dex */
@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0006\u0010\f\u001a\u00020\u0007J\u0006\u0010\r\u001a\u00020\u0007J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0006\u0010\u0012\u001a\u00020\u0007J\u0006\u0010\u0013\u001a\u00020\u0007J\u000e\u0010\u0014\u001a\u00020\u000f2\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/p06299358/p0bf719df/pf0af16f9;", "Landroid/nfc/NfcAdapter$ReaderCallback;", "activityProvider", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p80c2998c/pbf8c78df;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p80c2998c/pbf8c78df;)V", "isNfcRead", "", "isCardTapped", "isCardConnected", "nfcCardCommunicationManager", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p4c6bf409;", "connectReader", "disconnectReader", "onTagDiscovered", "", "tag", "Landroid/nfc/Tag;", "connectCard", "disconnectCard", "setNfcCardCommunicationManager", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf0af16f9 : android.nfc.NfcAdapter.ReaderCallback {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df f08dfcfc4;
    private bool f34d9327b;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 f35c87de1;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 f39ac626a;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df f41e5a7ae;
    private bool f4bd1cc9e;
    private bool f6fd3417b;
    private bool f7d65e2d2;
    private bool f9b64586b;
    private bool f9e50309e;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 f9fb78a72;
    private bool fb356e763;
    private bool fb6da0a96;
    private bool fb6e0c1a8;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 fc420fa20;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df fc5deb860;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 fc68d0518;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df fcf8e7f9e;
    private bool fda49531f;
    private bool feb16a4ed;
    private bool fedf2d164;
    private bool ff550554f;

    public pf0af16f9(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r2) {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L17
        Lb:
            return
        Lc:
            goto L1d
        L10:
            DnaujVmMfqMuFJZl(r2, r0)
            goto L20
        L17:
            java.lang.string r0 = "activityProvider"
            goto L10
        L1d:
            goto L7
        L20:
            r1.<init>()
            goto L27
        L27:
            r1.fc5deb860 = r2
            goto Lb
    }

    public static androidx.fragment.app.objectobject CjiWfgRDyeVCbKHD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r1) {
            goto L14
        L4:
            goto L17
        L7:
            androidx.fragment.app.objectobject r0 = r1.getTransactionobject()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void CjiWfgRDyeVCbKHD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, java.lang.string r1, int r2, char r3, short r4) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L15
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            goto L20
        L15:
            goto L2a
        L19:
            int r2 = r0 * r1
            goto Lc
        L1f:
            return
        L20:
            goto L9
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2a:
            r0 = 42
            goto L24
    }

    public static void CjiWfgRDyeVCbKHD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, java.lang.string r1, short r2, char r3, int r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L18
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L17:
            return
        L18:
            goto L27
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void CjiWfgRDyeVCbKHD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, short r1, int r2, java.lang.string r3, char r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L27
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L10
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L15
    }

    public static void DnaujVmMfqMuFJZl(java.lang.object r0, java.lang.string r1) {
            goto Lb
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
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

    public static void DnaujVmMfqMuFJZl(java.lang.object r0, java.lang.string r1, byte r2, int r3, bool r4, short r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L21
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void DnaujVmMfqMuFJZl(java.lang.object r0, java.lang.string r1, short r2, byte r3, int r4, bool r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L2d
        L16:
            r0 = 42
            goto L4
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            int r2 = r0 * r1
            goto L1c
        L2d:
            goto Ld
    }

    public static void DnaujVmMfqMuFJZl(java.lang.object r0, java.lang.string r1, short r2, bool r3, byte r4, int r5) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L24
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto Lc
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static void EerIFJEkIyyyYwRd(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void EerIFJEkIyyyYwRd(java.lang.object r0, java.lang.string r1, float r2, short r3, java.lang.string r4, byte r5) {
            goto L1f
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L22
        Ld:
            r0 = 42
            goto L13
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L19:
            int r3 = r2 + r1
            goto L26
        L1f:
            goto L2c
        L22:
            goto Ld
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static void EerIFJEkIyyyYwRd(java.lang.object r0, java.lang.string r1, java.lang.string r2, float r3, byte r4, short r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            return
        Lb:
            goto L27
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L2a
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto L18
        L2a:
            r0 = 42
            goto Lf
    }

    public static void EerIFJEkIyyyYwRd(java.lang.object r0, java.lang.string r1, short r2, byte r3, float r4, java.lang.string r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        Lf:
            goto L2c
        L12:
            goto L16
        L16:
            r0 = 42
            goto L9
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L4
        L28:
            goto L12
        L2b:
            return
        L2c:
            goto L28
    }

    public static void KehCJpsIsUgMZLet(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void KehCJpsIsUgMZLet(java.lang.object r0, java.lang.string r1, float r2, byte r3, int r4, short r5) {
            goto L23
        L4:
            goto L26
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            int r3 = r2 + r1
            goto L7
        L12:
            return
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto Lc
        L23:
            goto L13
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L17
    }

    public static void KehCJpsIsUgMZLet(java.lang.object r0, java.lang.string r1, short r2, byte r3, float r4, int r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L16
        L10:
            int r2 = r0 * r1
            goto L1b
        L16:
            return
        L17:
            goto L27
        L1b:
            int r3 = r2 + r1
            goto Lb
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L21
    }

    public static void KehCJpsIsUgMZLet(java.lang.object r0, java.lang.string r1, short r2, int r3, float r4, byte r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L25
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto Lb
    }

    public static void PhxOttvOofrIYyHj(android.nfc.NfcAdapter r0, byte r1, char r2, bool r3, int r4) {
            goto La
        L4:
            r0 = 42
            goto L1c
        La:
            goto L29
        Ld:
            goto L4
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L28
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L11
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void PhxOttvOofrIYyHj(android.nfc.NfcAdapter r0, char r1, byte r2, int r3, bool r4) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L22
        Lf:
            goto L5
        L12:
            goto L27
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            r0 = 42
            goto L1c
        L2d:
            goto L12
    }

    public static void PhxOttvOofrIYyHj(android.nfc.NfcAdapter r0, int r1, byte r2, char r3, bool r4) {
            goto L1e
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            int r2 = r0 * r1
            goto L25
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto L4
        L25:
            int r3 = r2 + r1
            goto L10
        L2b:
            return
        L2c:
            goto L1b
    }

    public static bool PhxOttvOofrIYyHj(android.nfc.NfcAdapter r1) {
            goto L11
        L4:
            bool r0 = r1.isEnabled()
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

    public static void TiCxajaQEuanEKyy(byte r0, float r1, int r2, bool r3) {
            goto L1e
        L4:
            r0 = 42
            goto L25
        La:
            return
        Lb:
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L18
        L15:
            goto L21
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto Lb
        L21:
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void TiCxajaQEuanEKyy(float r0, byte r1, bool r2, int r3) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L22
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto L10
        L22:
            r0 = 42
            goto L16
        L28:
            goto L7
        L2b:
            return
        L2c:
            goto L28
    }

    public static void TiCxajaQEuanEKyy(bool r0, float r1, int r2, byte r3) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            r0 = 42
            goto L4
        L15:
            int r2 = r0 * r1
            goto L22
        L1b:
            goto L29
        L1e:
            goto Lf
        L22:
            int r3 = r2 + r1
            goto La
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static bool TiCxajaQEuanEKyy() {
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
            bool r0 = java.lang.Thread.interrupted()
            goto Le
    }

    public static android.nfc.NfcAdapter BylvYUjTsHjdirKe(android.content.object r1) {
            goto L11
        L4:
            android.nfc.NfcAdapter r0 = android.nfc.NfcAdapter.getDefaultAdapter(r1)
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

    public static void BylvYUjTsHjdirKe(android.content.object r0, char r1, int r2, float r3, java.lang.string r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1c
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            r0 = 42
            goto Lb
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static void BylvYUjTsHjdirKe(android.content.object r0, java.lang.string r1, int r2, char r3, float r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L24
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L24:
            double r0 = (double) r3
            goto L13
        L29:
            goto L14
        L2c:
            goto L18
    }

    public static void BylvYUjTsHjdirKe(android.content.object r0, java.lang.string r1, int r2, float r3, char r4) {
            goto L1a
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L1d
    }

    public static void IagkNFMCdXPVmhnb(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.enableReaderMode(r1, r2, r3, r4)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void IagkNFMCdXPVmhnb(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4, short r5, char r6, float r7, java.lang.string r8) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L24
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L5
        L1d:
            goto L9
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void IagkNFMCdXPVmhnb(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4, short r5, float r6, char r7, java.lang.string r8) {
            goto L4
        L4:
            goto L20
        L7:
            goto L19
        Lb:
            double r0 = (double) r3
            goto L1f
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            goto L7
        L19:
            r0 = 42
            goto L24
        L1f:
            return
        L20:
            goto L16
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static void IagkNFMCdXPVmhnb(android.nfc.NfcAdapter r0, android.app.object r1, android.nfc.NfcAdapter.ReaderCallback r2, int r3, android.os.Dictionary<string, object> r4, short r5, float r6, java.lang.string r7, char r8) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            goto L27
        Ld:
            return
        Le:
            goto La
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r0 = 42
            goto L4
        L24:
            goto Le
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static android.app.object LZEYYZHZfeCeCMCd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r1) {
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
            android.app.object r0 = r1.getOtherobject()
            goto L7
    }

    public static void LZEYYZHZfeCeCMCd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, char r1, float r2, java.lang.string r3, bool r4) {
            goto Le
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L21
        Le:
            goto La
        L11:
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            r0 = 42
            goto L24
        L21:
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L15
    }

    public static void LZEYYZHZfeCeCMCd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, float r1, bool r2, char r3, java.lang.string r4) {
            goto L1f
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L22
        L13:
            r0 = 42
            goto L4
        L19:
            int r2 = r0 * r1
            goto La
        L1f:
            goto L27
        L22:
            goto L13
        L26:
            return
        L27:
            goto L10
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void LZEYYZHZfeCeCMCd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, bool r1, char r2, float r3, java.lang.string r4) {
            goto L1a
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L21
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto Lb
        L1d:
            goto L2a
        L21:
            goto L1d
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r0 = 42
            goto Lf
    }

    public static void LjrNmPAlcWzpHtIc(android.nfc.NfcAdapter r0, android.app.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.disableForegroundDispatch(r1)
            goto Le
    }

    public static void LjrNmPAlcWzpHtIc(android.nfc.NfcAdapter r0, android.app.object r1, int r2, java.lang.string r3, short r4, bool r5) {
            goto Ld
        L4:
            r0 = 42
            goto L19
        La:
            goto L10
        Ld:
            goto L20
        L10:
            goto L4
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            return
        L20:
            goto La
        L24:
            int r3 = r2 + r1
            goto L14
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void LjrNmPAlcWzpHtIc(android.nfc.NfcAdapter r0, android.app.object r1, short r2, int r3, java.lang.string r4, bool r5) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L2c
        L1e:
            goto La
        L22:
            int r3 = r2 + r1
            goto L16
        L28:
            goto L1e
        L2b:
            return
        L2c:
            goto L28
    }

    public static void LjrNmPAlcWzpHtIc(android.nfc.NfcAdapter r0, android.app.object r1, bool r2, int r3, java.lang.string r4, short r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L1a
        La:
            goto L13
        Le:
            double r0 = (double) r3
            goto L19
        L13:
            r0 = 42
            goto L1e
        L19:
            return
        L1a:
            goto L4
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto Le
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static androidx.fragment.app.objectobject PpaPhZxskdTGCPob(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r1) {
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
            androidx.fragment.app.objectobject r0 = r1.getTransactionobject()
            goto Le
    }

    public static void PpaPhZxskdTGCPob(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, byte r1, bool r2, float r3, java.lang.string r4) {
            goto L18
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L1b
        L18:
            goto L26
        L1b:
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L15
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void PpaPhZxskdTGCPob(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, float r1, byte r2, bool r3, java.lang.string r4) {
            goto L19
        L4:
            goto L1c
        L7:
            r0 = 42
            goto L13
        Ld:
            int r2 = r0 * r1
            goto L2a
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L19:
            goto L26
        L1c:
            goto L7
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void PpaPhZxskdTGCPob(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, bool r1, java.lang.string r2, float r3, byte r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L2c
        Ld:
            goto L1a
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            r0 = 42
            goto L14
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L11
    }

    public static void PtkgeNOtQKeALHzX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.updateNfcStatus(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void PtkgeNOtQKeALHzX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1, float r2, short r3, byte r4, java.lang.string r5) {
            goto L29
        L4:
            r0 = 42
            goto L10
        La:
            int r3 = r2 + r1
            goto L1b
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L16:
            return
        L17:
            goto L26
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            int r2 = r0 * r1
            goto La
        L26:
            goto L2c
        L29:
            goto L17
        L2c:
            goto L4
    }

    public static void PtkgeNOtQKeALHzX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1, short r2, float r3, byte r4, java.lang.string r5) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r0 = 42
            goto L27
        L1b:
            goto L23
        L1e:
            goto L15
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2d:
            goto L1e
    }

    public static void PtkgeNOtQKeALHzX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r1, short r2, java.lang.string r3, float r4, byte r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            return
        L11:
            goto L1c
        L15:
            goto L11
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            r0 = 42
            goto L4
        L25:
            int r2 = r0 * r1
            goto La
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static android.app.object SriylZlvMATymMlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.app.object r0 = r1.getOtherobject()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void SriylZlvMATymMlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, char r1, bool r2, float r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1b
        La:
            goto L17
        Ld:
            goto L21
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L2d
        L1b:
            int r3 = r2 + r1
            goto L11
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2d:
            goto Ld
    }

    public static void SriylZlvMATymMlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, float r1, char r2, bool r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L2c
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L11
    }

    public static void SriylZlvMATymMlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0, java.lang.string r1, char r2, bool r3, float r4) {
            goto Ld
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L1f
        L14:
            return
        L15:
            goto La
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static android.nfc.NfcAdapter UHydhXTrPoItzwQM(android.content.object r1) {
            goto Lc
        L4:
            android.nfc.NfcAdapter r0 = android.nfc.NfcAdapter.getDefaultAdapter(r1)
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

    public static void UHydhXTrPoItzwQM(android.content.object r0, char r1, int r2, float r3, java.lang.string r4) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L22
        L15:
            goto L5
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L2a
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void UHydhXTrPoItzwQM(android.content.object r0, int r1, float r2, java.lang.string r3, char r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L15:
            goto L2c
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            r0 = 42
            goto Lf
        L25:
            int r2 = r0 * r1
            goto L9
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void UHydhXTrPoItzwQM(android.content.object r0, java.lang.string r1, float r2, char r3, int r4) {
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
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            r0 = 42
            goto L14
        L29:
            goto L10
        L2c:
            goto L23
    }

    public readonly bool ConnectCard() {
            r3 = this;
            goto L2f
        L4:
            bool r1 = r3.f4bd1cc9e
            goto L75
        La:
            throw r0
        Lb:
            goto L84
        Lf:
            bool r2 = r3.ff550554f
            goto L90
        L15:
            goto La8
        L17:
            r0 = move-exception
            goto L9c
        L1c:
            monitor-exit(r3)
            goto L15
        L21:
            return r3
        L22:
            goto L3d
        L26:
            if (r0 <= 0) goto L2b
            goto L56
        L2b:
            goto L53
        L2f:
            goto L6c
        L32:
            goto L36
        L36:
            r0 = 22
            goto L89
        L3d:
            monitor-enter(r3)
            bool r1 = r3.fb356e763     // Catch: java.lang.Exception -> L17
            if (r1 == 0) goto L4d
            r3.f4bd1cc9e = r0     // Catch: java.lang.Exception -> L17
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r1 = r3.f9fb78a72     // Catch: java.lang.Exception -> L17
            if (r1 == 0) goto L4d
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 r2 = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164.fb3103e56     // Catch: java.lang.Exception -> L17
            ptkgeNOtQKeALHzX(r1, r2)     // Catch: java.lang.Exception -> L17
        L4d:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L17
            goto L1c
        L53:
            goto L85
        L56:
            goto La1
        L5a:
            int r0 = r0 % r1
            goto L26
        L60:
            if (r1 != 0) goto L65
            goto L22
        L65:
            goto L70
        L69:
            goto L56
        L6c:
            goto L99
        L70:
            r3 = 0
            goto L21
        L75:
            if (r1 == 0) goto L7a
            goto Lb
        L7a:
            goto Lf
        L7e:
            int r0 = r0 + r1
            goto L5a
        L84:
            return r1
        L85:
            goto L69
        L89:
            r1 = 2
            goto L7e
        L90:
            if (r2 != 0) goto L95
            goto Lb
        L95:
            goto Lac
        L99:
            goto L32
        L9c:
            monitor-exit(r3)
            goto La
        La1:
            r0 = 1
            goto La6
        La6:
            r3.ff550554f = r0
        La8:
            goto L4
        Lac:
            bool r1 = TiCxajaQEuanEKyy()
            goto L60
    }

    public readonly bool ConnectReader() {
            r6 = this;
            goto L44
        L4:
            int r0 = r0 + r1
            goto L16
        La:
            throw r0
        Lb:
            goto L1c
        Lf:
            return r6
        L10:
            r0 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L10
            goto La
        L16:
            int r0 = r0 % r1
            goto L2d
        L1c:
            goto L73
        L1f:
            goto L4b
        L23:
            r6 = 1
            goto Lf
        L28:
            goto L4f
        L29:
            goto L8f
        L2d:
            if (r0 <= 0) goto L32
            goto L73
        L32:
            goto L70
        L36:
            r1 = 15
            goto L4
        L3d:
            r0 = 30
            goto L36
        L44:
            goto L1f
        L47:
            goto L3d
        L4b:
            goto L47
        L4e:
            return r1
        L4f:
            r2 = r0
            android.content.object r2 = (android.content.object) r2     // Catch: java.lang.Exception -> L10
            android.nfc.NfcAdapter r2 = bylvYUjTsHjdirKe(r2)     // Catch: java.lang.Exception -> L10
            if (r2 == 0) goto L67
            bool r3 = r6.fb356e763     // Catch: java.lang.Exception -> L10
            if (r3 != 0) goto L67
            r3 = r6
            android.nfc.NfcAdapter$ReaderCallback r3 = (android.nfc.NfcAdapter.ReaderCallback) r3     // Catch: java.lang.Exception -> L10
            r4 = 387(0x183, float:5.42E-43)
            r5 = 0
            iagkNFMCdXPVmhnb(r2, r0, r3, r4, r5)     // Catch: java.lang.Exception -> L10
            r6.f4bd1cc9e = r1     // Catch: java.lang.Exception -> L10
        L67:
            goto L6b
        L6b:
            monitor-exit(r6)
            goto L23
        L70:
            goto Lb
        L73:
            goto L77
        L77:
            monitor-enter(r6)
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0 = r6.fc5deb860     // Catch: java.lang.Exception -> L10
            android.app.object r0 = lZEYYZHZfeCeCMCd(r0)     // Catch: java.lang.Exception -> L10
            r1 = 0
            if (r0 != 0) goto L4f
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0 = r6.fc5deb860     // Catch: java.lang.Exception -> L10
            androidx.fragment.app.objectobject r0 = ppaPhZxskdTGCPob(r0)     // Catch: java.lang.Exception -> L10
            if (r0 == 0) goto L29
            android.app.object r0 = (android.app.object) r0     // Catch: java.lang.Exception -> L10
            goto L28
        L8f:
            monitor-exit(r6)
            goto L4e
    }

    public readonly bool DisconnectCard() {
            r1 = this;
            goto L1e
        L4:
            goto L21
        L7:
            monitor-enter(r1)
            goto Lc
        Lc:
            r0 = 0
            r1.f4bd1cc9e = r0     // Catch: java.lang.Exception -> L18
            r1.ff550554f = r0     // Catch: java.lang.Exception -> L18
            r1.fb356e763 = r0     // Catch: java.lang.Exception -> L18
            goto L2f
        L17:
            return r1
        L18:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L18
            goto L2a
        L1e:
            goto L2b
        L21:
            goto L7
        L25:
            r1 = 1
            goto L17
        L2a:
            throw r0
        L2b:
            goto L4
        L2f:
            monitor-exit(r1)
            goto L25
    }

    public readonly bool DisconnectReader() {
            r3 = this;
            goto L1b
        L4:
            int r0 = r0 % r1
            goto L72
        La:
            throw r0
        Lb:
            goto L82
        Lf:
            r0 = 13
            goto L2b
        L16:
            monitor-exit(r3)
            goto L32
        L1b:
            goto L85
        L1e:
            goto Lf
        L22:
            int r0 = r0 + r1
            goto L4
        L28:
            goto L1e
        L2b:
            r1 = 1
            goto L22
        L32:
            r3 = 1
            goto L6b
        L37:
            monitor-enter(r3)
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0 = r3.fc5deb860     // Catch: java.lang.Exception -> L6c
            android.app.object r0 = sriylZlvMATymMlv(r0)     // Catch: java.lang.Exception -> L6c
            if (r0 != 0) goto L48
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.pbf8c78df r0 = r3.fc5deb860     // Catch: java.lang.Exception -> L6c
            androidx.fragment.app.objectobject r0 = CjiWfgRDyeVCbKHD(r0)     // Catch: java.lang.Exception -> L6c
            android.app.object r0 = (android.app.object) r0     // Catch: java.lang.Exception -> L6c
        L48:
            if (r0 == 0) goto L60
            r1 = r0
            android.content.object r1 = (android.content.object) r1     // Catch: java.lang.Exception -> L6c
            android.nfc.NfcAdapter r1 = uHydhXTrPoItzwQM(r1)     // Catch: java.lang.Exception -> L6c
            if (r1 == 0) goto L60
            bool r2 = PhxOttvOofrIYyHj(r1)     // Catch: java.lang.Exception -> L6c
            if (r2 == 0) goto L5a
            goto L5b
        L5a:
            r1 = 0
        L5b:
            if (r1 == 0) goto L60
            ljrNmPAlcWzpHtIc(r1, r0)     // Catch: java.lang.Exception -> L6c
        L60:
            r0 = 0
            r3.fb356e763 = r0     // Catch: java.lang.Exception -> L6c
            r3.f4bd1cc9e = r0     // Catch: java.lang.Exception -> L6c
            r3.ff550554f = r0     // Catch: java.lang.Exception -> L6c
            goto L16
        L6b:
            return r3
        L6c:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L6c
            goto La
        L72:
            if (r0 <= 0) goto L77
            goto L7e
        L77:
            goto L7b
        L7b:
            goto Lb
        L7e:
            goto L37
        L82:
            goto L7e
        L85:
            goto L28
    }

    @Override // android.nfc.NfcAdapter.ReaderCallback
    public void OnTagDiscovered(android.nfc.Tag r2) {
            r1 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            throw r2
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            monitor-enter(r1)
            java.lang.string r0 = "tag"
            KehCJpsIsUgMZLet(r2, r0)     // Catch: java.lang.Exception -> L21
            r2 = 1
            r1.fb356e763 = r2     // Catch: java.lang.Exception -> L21
            goto L27
        L20:
            return
        L21:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L21
            goto L7
        L27:
            monitor-exit(r1)
            goto L20
    }

    public readonly void SetNfcCardCommunicationManager(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 r2) {
            r1 = this;
            goto L16
        L4:
            java.lang.string r0 = "nfcCardCommunicationManager"
            goto Lf
        La:
            return
        Lb:
            goto L23
        Lf:
            EerIFJEkIyyyYwRd(r2, r0)
            goto L1d
        L16:
            goto Lb
        L19:
            goto L4
        L1d:
            r1.f9fb78a72 = r2
            goto La
        L23:
            goto L19
    }
}

