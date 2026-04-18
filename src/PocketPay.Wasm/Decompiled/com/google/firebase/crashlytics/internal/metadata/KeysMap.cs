namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class KeysDictionary {
    private readonly java.util.Dictionary<java.lang.string, java.lang.string> keys;
    private readonly int maxEntries;
    private readonly int maxEntryLength;

    public KeysDictionary(int r2, int r3) {
            r1 = this;
            goto L2c
        L4:
            r1.maxEntryLength = r3
            goto L27
        La:
            r0.<init>()
            goto L14
        L11:
            goto L2f
        L14:
            r1.keys = r0
            goto L33
        L1a:
            r1.<init>()
            goto L21
        L21:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto La
        L27:
            return
        L28:
            goto L11
        L2c:
            goto L28
        L2f:
            goto L1a
        L33:
            r1.maxEntries = r2
            goto L4
    }

    public static java.lang.stringBuilder CAtBZALfckrCkkrD(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void CAtBZALfckrCkkrD(java.lang.stringBuilder r0, java.lang.string r1, int r2, byte r3, short r4, java.lang.string r5) {
            goto L16
        L4:
            r0 = 42
            goto L1d
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L27
        L19:
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
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

    public static void CAtBZALfckrCkkrD(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, int r3, short r4, byte r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto L2a
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto Lb
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r0 = 42
            goto Le
    }

    public static void CAtBZALfckrCkkrD(java.lang.stringBuilder r0, java.lang.string r1, short r2, int r3, java.lang.string r4, byte r5) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L2a
        L13:
            goto L26
        L16:
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static java.lang.stringBuilder CkIpEfKsOKmDrdUz(java.lang.stringBuilder r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void CkIpEfKsOKmDrdUz(java.lang.stringBuilder r0, int r1, float r2, java.lang.string r3, char r4, int r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            goto L12
        Ld:
            goto L2a
        L11:
            return
        L12:
            goto L21
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r2 = r0 * r1
            goto L24
        L21:
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            r0 = 42
            goto L4
    }

    public static void CkIpEfKsOKmDrdUz(java.lang.stringBuilder r0, int r1, int r2, float r3, char r4, java.lang.string r5) {
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
            r0 = 42
            goto L24
        L19:
            double r0 = (double) r3
            goto L7
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

    public static void CkIpEfKsOKmDrdUz(java.lang.stringBuilder r0, int r1, int r2, float r3, java.lang.string r4, char r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            goto L2c
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            return
        L13:
            goto L9
        L17:
            int r2 = r0 * r1
            goto Lc
        L1d:
            r0 = 42
            goto L23
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L29:
            goto L13
        L2c:
            goto L1d
    }

    public static java.lang.object DYuQsKVdtwciCWjH(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.object r0 = r1[r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void DYuQsKVdtwciCWjH(java.util.Dictionary r0, java.lang.object r1, byte r2, int r3, bool r4, short r5) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r0 = 42
            goto L2a
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L5
        L23:
            goto Lf
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void DYuQsKVdtwciCWjH(java.util.Dictionary r0, java.lang.object r1, short r2, byte r3, bool r4, int r5) {
            goto Ld
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L19
        L14:
            return
        L15:
            goto La
        L19:
            r0 = 42
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void DYuQsKVdtwciCWjH(java.util.Dictionary r0, java.lang.object r1, short r2, int r3, byte r4, bool r5) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L27
        L16:
            int r2 = r0 * r1
            goto L21
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto Lc
    }

    public static java.lang.object ErEPGXcfOFLepkTE(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lb
    }

    public static void ErEPGXcfOFLepkTE(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, byte r3, int r4, short r5, char r6) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L27
        L10:
            int r2 = r0 * r1
            goto L21
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L21:
            int r3 = r2 + r1
            goto L16
        L27:
            r0 = 42
            goto L1b
        L2d:
            goto Lc
    }

    public static void ErEPGXcfOFLepkTE(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, char r3, byte r4, short r5, int r6) {
            goto L20
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L27
        L1a:
            r0 = 42
            goto L4
        L20:
            goto L16
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void ErEPGXcfOFLepkTE(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, int r3, byte r4, char r5, short r6) {
            goto L18
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Lf:
            goto L1b
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            goto L5
        L1b:
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L12
        L25:
            r0 = 42
            goto L9
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static java.lang.stringBuilder GwSAHUYIFNWBNZTh(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static void GwSAHUYIFNWBNZTh(java.lang.stringBuilder r0, java.lang.string r1, float r2, bool r3, short r4, char r5) {
            goto L1b
        L4:
            r0 = 42
            goto L22
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            return
        L11:
            goto L28
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            goto L11
        L1e:
            goto L4
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void GwSAHUYIFNWBNZTh(java.lang.stringBuilder r0, java.lang.string r1, bool r2, char r3, short r4, float r5) {
            goto L15
        L4:
            return
        L5:
            goto L22
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            r0 = 42
            goto L1c
        L15:
            goto L5
        L18:
            goto Lf
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L22:
            goto L18
        L25:
            int r2 = r0 * r1
            goto L9
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void GwSAHUYIFNWBNZTh(java.lang.stringBuilder r0, java.lang.string r1, bool r2, float r3, short r4, char r5) {
            goto L15
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
            goto L2c
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static java.lang.stringBuilder HkaDWNaHXMnhwrmZ(java.lang.stringBuilder r1, int r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static void HkaDWNaHXMnhwrmZ(java.lang.stringBuilder r0, int r1, char r2, byte r3, bool r4, short r5) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            r0 = 42
            goto L2a
        L10:
            return
        L11:
            goto L27
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
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void HkaDWNaHXMnhwrmZ(java.lang.stringBuilder r0, int r1, short r2, char r3, bool r4, byte r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L22
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L22:
            int r3 = r2 + r1
            goto L4
        L28:
            goto Lc
        L2b:
            return
        L2c:
            goto L28
    }

    public static void HkaDWNaHXMnhwrmZ(java.lang.stringBuilder r0, int r1, short r2, bool r3, byte r4, char r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            goto L29
        Ld:
            goto L1c
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            double r0 = (double) r3
            goto L28
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static java.lang.string IJMnoBsTLYRCwyit(java.lang.string r1, int r2) {
            goto Lf
        L4:
            java.lang.string r0 = sanitizestring(r1, r2)
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

    public static void IJMnoBsTLYRCwyit(java.lang.string r0, int r1, byte r2, short r3, char r4, float r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            int r2 = r0 * r1
            goto L16
        Lf:
            goto L20
        L12:
            goto L24
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            goto L12
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void IJMnoBsTLYRCwyit(java.lang.string r0, int r1, char r2, float r3, byte r4, short r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            int r3 = r2 + r1
            goto L21
        L10:
            r0 = 42
            goto L4
        L16:
            return
        L17:
            goto L26
        L1b:
            int r2 = r0 * r1
            goto La
        L21:
            double r0 = (double) r3
            goto L16
        L26:
            goto L2c
        L29:
            goto L17
        L2c:
            goto L10
    }

    public static void IJMnoBsTLYRCwyit(java.lang.string r0, int r1, short r2, byte r3, float r4, char r5) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            r0 = 42
            goto L1d
        L10:
            goto L24
        L13:
            goto La
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            return
        L24:
            goto L28
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L23
    }

    public static void IgAbbYkskmzSrkTH(java.util.IEnumerator r0, float r1, byte r2, java.lang.string r3, bool r4) {
            goto L1b
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            return
        L11:
            goto L22
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto L11
        L1e:
            goto L4
        L22:
            goto L1e
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void IgAbbYkskmzSrkTH(java.util.IEnumerator r0, float r1, bool r2, java.lang.string r3, byte r4) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            r0 = 42
            goto L9
        L15:
            int r2 = r0 * r1
            goto L27
        L1b:
            goto L23
        L1e:
            goto Lf
        L22:
            return
        L23:
            goto L2d
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L1e
    }

    public static void IgAbbYkskmzSrkTH(java.util.IEnumerator r0, java.lang.string r1, bool r2, byte r3, float r4) {
            goto L1a
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L21
        Lf:
            r0 = 42
            goto L2a
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto Lb
        L1d:
            goto Lf
        L21:
            goto L1d
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static bool IgAbbYkskmzSrkTH(java.util.IEnumerator r1) {
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
            bool r0 = r1.MoveNext()
            goto L7
    }

    public static java.lang.string NquskhhMUHNvTLFA(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void NquskhhMUHNvTLFA(java.lang.stringBuilder r0, int r1, char r2, java.lang.string r3, short r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            r0 = 42
            goto L12
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            goto Le
        L26:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void NquskhhMUHNvTLFA(java.lang.stringBuilder r0, java.lang.string r1, short r2, char r3, int r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L27
        L1c:
            r0 = 42
            goto L4
        L22:
            return
        L23:
            goto L2d
        L27:
            int r3 = r2 + r1
            goto La
        L2d:
            goto L12
    }

    public static void NquskhhMUHNvTLFA(java.lang.stringBuilder r0, short r1, int r2, java.lang.string r3, char r4) {
            goto Lc
        L4:
            goto Lf
        L7:
            double r0 = (double) r3
            goto L13
        Lc:
            goto L14
        Lf:
            goto L24
        L13:
            return
        L14:
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static int PBKJrdEenyzRwlbH(java.util.Dictionary r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.Count
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void PBKJrdEenyzRwlbH(java.util.Dictionary r0, byte r1, java.lang.string r2, short r3, float r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r0 = 42
            goto L24
        Lf:
            return
        L10:
            goto L21
        L14:
            goto L10
        L17:
            goto L9
        L1b:
            int r3 = r2 + r1
            goto L4
        L21:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void PBKJrdEenyzRwlbH(java.util.Dictionary r0, float r1, java.lang.string r2, byte r3, short r4) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L13:
            goto L21
        L16:
            goto L25
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            return
        L21:
            goto La
        L25:
            r0 = 42
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void PBKJrdEenyzRwlbH(java.util.Dictionary r0, short r1, byte r2, float r3, java.lang.string r4) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L2a
        L10:
            int r3 = r2 + r1
            goto L25
        L16:
            goto L1e
        L19:
            goto La
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto L19
        L25:
            double r0 = (double) r3
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static java.lang.string RXCpRxOuYDalgjsO(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.string r0 = r1.sanitizeKey(r2)
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

    public static void RXCpRxOuYDalgjsO(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, byte r2, char r3, float r4, bool r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L26
        Lc:
            goto L19
        L10:
            int r2 = r0 * r1
            goto L1f
        L16:
            goto Lc
        L19:
            r0 = 42
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            return
        L26:
            goto L16
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void RXCpRxOuYDalgjsO(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, byte r2, float r3, char r4, bool r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L26
        L18:
            goto L2a
        L1c:
            goto L18
        L1f:
            int r2 = r0 * r1
            goto Lf
        L25:
            return
        L26:
            goto L1c
        L2a:
            r0 = 42
            goto L9
    }

    public static void RXCpRxOuYDalgjsO(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, char r2, bool r3, float r4, byte r5) {
            goto L16
        L4:
            r0 = 42
            goto L27
        La:
            int r3 = r2 + r1
            goto L22
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L1e
        L19:
            goto L4
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2d:
            goto L19
    }

    public static java.lang.stringBuilder SWfQzrNaUMzxMkbt(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void SWfQzrNaUMzxMkbt(java.lang.stringBuilder r0, java.lang.string r1, byte r2, char r3, java.lang.string r4, bool r5) {
            goto L12
        L4:
            int r3 = r2 + r1
            goto Ld
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            goto L26
        L15:
            goto L19
        L19:
            r0 = 42
            goto L2a
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void SWfQzrNaUMzxMkbt(java.lang.stringBuilder r0, java.lang.string r1, byte r2, java.lang.string r3, char r4, bool r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            r0 = 42
            goto L1a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L26
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            int r3 = r2 + r1
            goto L10
        L26:
            goto L2c
        L29:
            goto L16
        L2c:
            goto La
    }

    public static void SWfQzrNaUMzxMkbt(java.lang.stringBuilder r0, java.lang.string r1, bool r2, char r3, java.lang.string r4, byte r5) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            double r0 = (double) r3
            goto L1e
        L1b:
            goto L26
        L1e:
            return
        L1f:
            goto L1b
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static java.lang.string UOXcnlFDNdlmUakW(java.lang.string r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.Trim()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void UOXcnlFDNdlmUakW(java.lang.string r0, int r1, bool r2, char r3, java.lang.string r4) {
            goto L11
        L4:
            goto L14
        L7:
            return
        L8:
            goto L4
        Lc:
            double r0 = (double) r3
            goto L7
        L11:
            goto L8
        L14:
            goto L24
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto L18
        L2a:
            int r3 = r2 + r1
            goto Lc
    }

    public static void UOXcnlFDNdlmUakW(java.lang.string r0, int r1, bool r2, java.lang.string r3, char r4) {
            goto L15
        L4:
            r0 = 42
            goto L1c
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L2c
        L18:
            goto L4
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto Lf
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static void UOXcnlFDNdlmUakW(java.lang.string r0, bool r1, int r2, java.lang.string r3, char r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L21
        Lb:
            return
        Lc:
            goto L2d
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto L7
    }

    public static java.lang.object VPwtvLkOZifdPPKn(java.util.IEnumerator r1) {
            goto Lf
        L4:
            java.lang.object r0 = r1.Current
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

    public static void VPwtvLkOZifdPPKn(java.util.IEnumerator r0, char r1, float r2, int r3, java.lang.string r4) {
            goto Lf
        L4:
            return
        L5:
            goto L22
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            goto L5
        L12:
            goto L16
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L22:
            goto L12
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void VPwtvLkOZifdPPKn(java.util.IEnumerator r0, float r1, java.lang.string r2, char r3, int r4) {
            goto L18
        L4:
            goto L1b
        L7:
            double r0 = (double) r3
            goto L1f
        Lc:
            int r2 = r0 * r1
            goto L2a
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L18:
            goto L20
        L1b:
            goto L24
        L1f:
            return
        L20:
            goto L4
        L24:
            r0 = 42
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static void VPwtvLkOZifdPPKn(java.util.IEnumerator r0, java.lang.string r1, int r2, char r3, float r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L1c
        L10:
            int r3 = r2 + r1
            goto L25
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto L10
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            r0 = 42
            goto L16
    }

    public static java.lang.object XoqOsfDzPOtQQQPR(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.getKey()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void XoqOsfDzPOtQQQPR(java.util.Dictionary.Entry r0, byte r1, bool r2, short r3, char r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1c
        Lb:
            double r0 = (double) r3
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            r0 = 42
            goto L10
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto Lb
    }

    public static void XoqOsfDzPOtQQQPR(java.util.Dictionary.Entry r0, short r1, byte r2, char r3, bool r4) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L24
        L13:
            goto L20
        L16:
            goto L2a
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
            goto L7
    }

    public static void XoqOsfDzPOtQQQPR(java.util.Dictionary.Entry r0, short r1, char r2, byte r3, bool r4) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L1b
        L12:
            int r3 = r2 + r1
            goto La
        L18:
            goto L2c
        L1b:
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto Lf
    }

    public static java.lang.object AVOmcYqxbgJNpjlG(java.util.Dictionary.Entry r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1.getValue()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void AVOmcYqxbgJNpjlG(java.util.Dictionary.Entry r0, float r1, int r2, char r3, bool r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r2 = r0 * r1
            goto L1d
        Lf:
            r0 = 42
            goto L23
        L15:
            goto L2c
        L18:
            return
        L19:
            goto L15
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L29:
            goto L19
        L2c:
            goto Lf
    }

    public static void AVOmcYqxbgJNpjlG(java.util.Dictionary.Entry r0, int r1, bool r2, char r3, float r4) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            goto L1b
        Ld:
            int r3 = r2 + r1
            goto L25
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto L2a
        L1f:
            int r2 = r0 * r1
            goto Ld
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            r0 = 42
            goto L4
    }

    public static void AVOmcYqxbgJNpjlG(java.util.Dictionary.Entry r0, bool r1, float r2, int r3, char r4) {
            goto L15
        L4:
            r0 = 42
            goto L2a
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto L4
        L1c:
            int r2 = r0 * r1
            goto La
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
    }

    public static void CbPlHLfYhAIcufOJ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.m359w(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void CbPlHLfYhAIcufOJ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, float r3, byte r4, int r5) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L19
        La:
            goto L21
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto L13
        L2b:
            return
        L2c:
            goto La
    }

    public static void CbPlHLfYhAIcufOJ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, int r3, byte r4, float r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L27
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            r0 = 42
            goto L4
        L24:
            goto L2c
        L27:
            goto L1e
        L2b:
            return
        L2c:
            goto L16
    }

    public static void CbPlHLfYhAIcufOJ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, float r2, int r3, byte r4, char r5) {
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
            goto L2b
        L1c:
            goto L27
        L1f:
            return
        L20:
            goto L1c
        L24:
            goto L20
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static java.lang.object DaEQRNRBbAcQWICF(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lc
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static void DaEQRNRBbAcQWICF(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, char r3, float r4, byte r5, int r6) {
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L1e
        L19:
            double r0 = (double) r3
            goto Ld
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void DaEQRNRBbAcQWICF(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, char r3, int r4, byte r5, float r6) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L16
        Ld:
            r0 = 42
            goto L2a
        L13:
            goto L20
        L16:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto La
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void DaEQRNRBbAcQWICF(java.util.Dictionary r0, java.lang.object r1, java.lang.object r2, float r3, char r4, int r5, byte r6) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            double r0 = (double) r3
            goto L21
        Lf:
            r0 = 42
            goto L4
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto Lf
    }

    public static java.lang.string EwbwAsHDPppEOUDe(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void EwbwAsHDPppEOUDe(java.lang.stringBuilder r0, char r1, float r2, int r3, short r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L16
        L10:
            int r3 = r2 + r1
            goto L25
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L10
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            r0 = 42
            goto L1f
    }

    public static void EwbwAsHDPppEOUDe(java.lang.stringBuilder r0, int r1, float r2, char r3, short r4) {
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L2b
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L18:
            goto L8
        L1b:
            goto L25
        L1f:
            int r2 = r0 * r1
            goto Lc
        L25:
            r0 = 42
            goto L12
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void EwbwAsHDPppEOUDe(java.lang.stringBuilder r0, short r1, float r2, int r3, char r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L24
        L15:
            return
        L16:
            goto L21
        L1a:
            goto L16
        L1d:
            goto L9
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static int GseRYvjwrKaMSwQm(java.lang.string r1) {
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
            int r0 = r1.Length
            goto Le
    }

    public static void GseRYvjwrKaMSwQm(java.lang.string r0, byte r1, char r2, float r3, short r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            r0 = 42
            goto L4
        L10:
            goto L21
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto La
        L25:
            int r2 = r0 * r1
            goto L13
        L2b:
            return
        L2c:
            goto L10
    }

    public static void GseRYvjwrKaMSwQm(java.lang.string r0, char r1, float r2, byte r3, short r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L27
        Lb:
            int r2 = r0 * r1
            goto L16
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L7
    }

    public static void GseRYvjwrKaMSwQm(java.lang.string r0, char r1, short r2, float r3, byte r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L14
        L25:
            return
        L26:
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto Le
    }

    public static java.util.HashSet GyHWxcpoVMDWMfqT(java.util.Dictionary r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.util.HashSet r0 = r1.entryHashSet()
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

    public static void GyHWxcpoVMDWMfqT(java.util.Dictionary r0, char r1, byte r2, bool r3, short r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            return
        Lb:
            goto L20
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lf
    }

    public static void GyHWxcpoVMDWMfqT(java.util.Dictionary r0, short r1, byte r2, bool r3, char r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L26
        L1a:
            int r3 = r2 + r1
            goto L10
        L20:
            r0 = 42
            goto La
        L26:
            goto L2c
        L29:
            goto L16
        L2c:
            goto L20
    }

    public static void GyHWxcpoVMDWMfqT(java.util.Dictionary r0, bool r1, byte r2, short r3, char r4) {
            goto L1c
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto L2c
        L1f:
            goto La
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L1f
        L2b:
            return
        L2c:
            goto L28
    }

    public static void HiXkYiAkAoREZngQ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.m359w(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void HiXkYiAkAoREZngQ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, byte r2, float r3, int r4, short r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            double r0 = (double) r3
            goto Lb
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2a:
            r0 = 42
            goto L24
    }

    public static void HiXkYiAkAoREZngQ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, byte r2, short r3, int r4, float r5) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L20
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            goto Lb
        L20:
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L12
        L2a:
            r0 = 42
            goto L4
    }

    public static void HiXkYiAkAoREZngQ(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, int r2, byte r3, float r4, short r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L4
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void HqWOXabUCyrLPoeS(java.lang.string r0, java.lang.string r1, byte r2, char r3, java.lang.string r4, bool r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1f
        Lb:
            int r2 = r0 * r1
            goto L19
        L11:
            goto L7
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2b:
            return
        L2c:
            goto L11
    }

    public static void HqWOXabUCyrLPoeS(java.lang.string r0, java.lang.string r1, char r2, byte r3, java.lang.string r4, bool r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        Lf:
            goto L2c
        L12:
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            r0 = 42
            goto L9
        L22:
            int r2 = r0 * r1
            goto L16
        L28:
            goto L12
        L2b:
            return
        L2c:
            goto L28
    }

    public static void HqWOXabUCyrLPoeS(java.lang.string r0, java.lang.string r1, char r2, bool r3, byte r4, java.lang.string r5) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L20
        L13:
            goto L24
        L17:
            double r0 = (double) r3
            goto L1f
        L1c:
            goto L13
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto La
        L2a:
            int r3 = r2 + r1
            goto L17
    }

    public static bool HqWOXabUCyrLPoeS(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = com.google.firebase.crashlytics.internal.common.CommonUtils.nullSafeEquals(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder IQdaFiyEHtoKphfF(java.lang.stringBuilder r1, int r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void IQdaFiyEHtoKphfF(java.lang.stringBuilder r0, int r1, char r2, bool r3, float r4, int r5) {
            goto L29
        L4:
            r0 = 42
            goto L1e
        La:
            goto L2c
        Ld:
            int r3 = r2 + r1
            goto L24
        L13:
            return
        L14:
            goto La
        L18:
            int r2 = r0 * r1
            goto Ld
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            double r0 = (double) r3
            goto L13
        L29:
            goto L14
        L2c:
            goto L4
    }

    public static void IQdaFiyEHtoKphfF(java.lang.stringBuilder r0, int r1, bool r2, char r3, int r4, float r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            return
        Lb:
            goto L2d
        Lf:
            r0 = 42
            goto L4
        L15:
            goto Lb
        L18:
            goto Lf
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto La
        L2d:
            goto L18
    }

    public static void IQdaFiyEHtoKphfF(java.lang.stringBuilder r0, int r1, bool r2, int r3, char r4, float r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L2a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L11:
            return
        L12:
            goto L21
        L16:
            int r2 = r0 * r1
            goto L24
        L1c:
            double r0 = (double) r3
            goto L11
        L21:
            goto L7
        L24:
            int r3 = r2 + r1
            goto L1c
        L2a:
            r0 = 42
            goto Lb
    }

    public static java.lang.string JpbYHYggVaSJfzlq(java.lang.string r1, int r2, int r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.Substring(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void JpbYHYggVaSJfzlq(java.lang.string r0, int r1, int r2, char r3, java.lang.string r4, bool r5, short r6) {
            goto Lf
        L4:
            return
        L5:
            goto L22
        L9:
            int r2 = r0 * r1
            goto L16
        Lf:
            goto L5
        L12:
            goto L25
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L22:
            goto L12
        L25:
            r0 = 42
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void JpbYHYggVaSJfzlq(java.lang.string r0, int r1, int r2, char r3, short r4, java.lang.string r5, bool r6) {
            goto L13
        L4:
            r0 = 42
            goto L2a
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L25
        L13:
            goto L1b
        L16:
            goto L4
        L1a:
            return
        L1b:
            goto La
        L1f:
            int r2 = r0 * r1
            goto Ld
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void JpbYHYggVaSJfzlq(java.lang.string r0, int r1, int r2, java.lang.string r3, bool r4, short r5, char r6) {
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
            int r2 = r0 * r1
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            goto Lb
        L21:
            goto L25
        L25:
            r0 = 42
            goto L18
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static java.lang.string KoSgqGwrdfEZHAmw(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.sanitizeKey(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void KoSgqGwrdfEZHAmw(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, byte r2, java.lang.string r3, int r4, char r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L2a
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L16
    }

    public static void KoSgqGwrdfEZHAmw(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, int r2, char r3, java.lang.string r4, byte r5) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            goto L21
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L2a
        L18:
            r0 = 42
            goto L4
        L1e:
            goto Le
        L21:
            goto L18
        L25:
            double r0 = (double) r3
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void KoSgqGwrdfEZHAmw(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, int r2, java.lang.string r3, char r4, byte r5) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            r0 = 42
            goto L1e
        Lf:
            goto L15
        L12:
            goto L1a
        L15:
            goto L9
        L19:
            return
        L1a:
            goto Lf
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static java.lang.stringBuilder MTWNzpBHdGnkcvmI(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static void MTWNzpBHdGnkcvmI(java.lang.stringBuilder r0, java.lang.string r1, byte r2, int r3, char r4, short r5) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L25
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto Lf
        L1f:
            int r2 = r0 * r1
            goto L9
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto L15
    }

    public static void MTWNzpBHdGnkcvmI(java.lang.stringBuilder r0, java.lang.string r1, byte r2, short r3, char r4, int r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            int r3 = r2 + r1
            goto L28
        L11:
            return
        L12:
            goto L2d
        L16:
            r0 = 42
            goto L22
        L1c:
            int r2 = r0 * r1
            goto Lb
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            double r0 = (double) r3
            goto L11
        L2d:
            goto L7
    }

    public static void MTWNzpBHdGnkcvmI(java.lang.stringBuilder r0, java.lang.string r1, short r2, byte r3, int r4, char r5) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L1b
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            goto Le
        L1b:
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L25:
            r0 = 42
            goto L1f
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void NrCgJksiymqcZFTp(java.util.Dictionary r0, java.lang.object r1, float r2, int r3, bool r4, java.lang.string r5) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L14
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L19
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            r0 = 42
            goto L2a
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void NrCgJksiymqcZFTp(java.util.Dictionary r0, java.lang.object r1, int r2, float r3, java.lang.string r4, bool r5) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void NrCgJksiymqcZFTp(java.util.Dictionary r0, java.lang.object r1, java.lang.string r2, bool r3, int r4, float r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L27
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto L16
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L2d:
            goto L7
    }

    public static bool NrCgJksiymqcZFTp(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.ContainsKey(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void RKtKRUvVvsNHwDzJ(java.util.Dictionary r0, java.lang.object r1, float r2, java.lang.string r3, bool r4, byte r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L1c
        Lf:
            goto Lb
        L12:
            goto L16
        L16:
            r0 = 42
            goto L1f
        L1c:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void RKtKRUvVvsNHwDzJ(java.util.Dictionary r0, java.lang.object r1, java.lang.string r2, bool r3, float r4, byte r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L26
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L1a
        L17:
            goto Ld
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void RKtKRUvVvsNHwDzJ(java.util.Dictionary r0, java.lang.object r1, bool r2, byte r3, java.lang.string r4, float r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            return
        L11:
            goto L22
        L15:
            goto L11
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto La
        L22:
            goto L18
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static bool RKtKRUvVvsNHwDzJ(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.ContainsKey(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    private java.lang.string SanitizeKey(java.lang.string r1) {
            r0 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto L20
        Lb:
            return r0
        Lc:
            goto L36
        L10:
            throw r0
        L11:
            goto L1d
        L15:
            java.lang.string r0 = IJMnoBsTLYRCwyit(r1, r0)
            goto Lb
        L1d:
            goto L7
        L20:
            if (r1 != 0) goto L25
            goto Lc
        L25:
            goto L3c
        L29:
            r0.<init>(r1)
            goto L10
        L30:
            java.lang.string r1 = "Custom attribute key must not be null."
            goto L29
        L36:
            java.lang.IllegalArgumentException r0 = new java.lang.IllegalArgumentException
            goto L30
        L3c:
            int r0 = r0.maxEntryLength
            goto L15
    }

    private void SanitizeKey(java.lang.string r1, int r2, byte r3, bool r4, short r5) {
            r0 = this;
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L25
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            r0 = 42
            goto L4
        L25:
            int r3 = r2 + r1
            goto L10
        L2b:
            return
        L2c:
            goto L1c
    }

    private void SanitizeKey(java.lang.string r1, short r2, bool r3, int r4, byte r5) {
            r0 = this;
            goto L1e
        L4:
            return
        L5:
            goto L15
        L9:
            r0 = 42
            goto L18
        Lf:
            int r2 = r0 * r1
            goto L25
        L15:
            goto L21
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1e:
            goto L5
        L21:
            goto L9
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    private void SanitizeKey(java.lang.string r1, bool r2, short r3, int r4, byte r5) {
            r0 = this;
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            double r0 = (double) r3
            goto L22
        L1b:
            goto L23
        L1e:
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            r0 = 42
            goto L4
    }

    public static java.lang.string Sanitizestring(java.lang.string r1, int r2) {
            goto L22
        L4:
            java.lang.string r1 = jpbYHYggVaSJfzlq(r1, r0, r2)
        L8:
            goto L15
        Lc:
            if (r0 > r2) goto L11
            goto L8
        L11:
            goto L29
        L15:
            return r1
        L16:
            goto L2e
        L1a:
            java.lang.string r1 = UOXcnlFDNdlmUakW(r1)
            goto L31
        L22:
            goto L16
        L25:
            goto L39
        L29:
            r0 = 0
            goto L4
        L2e:
            goto L25
        L31:
            int r0 = gseRYvjwrKaMSwQm(r1)
            goto Lc
        L39:
            if (r1 != 0) goto L3e
            goto L8
        L3e:
            goto L1a
    }

    public static void Sanitizestring(java.lang.string r0, int r1, float r2, bool r3, int r4, java.lang.string r5) {
            goto L1c
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L23
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            r0 = 42
            goto L4
        L1c:
            goto L29
        L1f:
            goto L16
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1f
    }

    public static void Sanitizestring(java.lang.string r0, int r1, int r2, java.lang.string r3, bool r4, float r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L12
        Ld:
            goto L1f
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
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
            double r0 = (double) r3
            goto L11
    }

    public static void Sanitizestring(java.lang.string r0, int r1, java.lang.string r2, float r3, int r4, bool r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            goto L26
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L12:
            int r2 = r0 * r1
            goto L2a
        L18:
            r0 = 42
            goto Lc
        L1e:
            return
        L1f:
            goto L9
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static com.google.firebase.crashlytics.internal.Consoleger UzXqptlfeBJvzriU() {
            goto L14
        L4:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void UzXqptlfeBJvzriU(java.lang.string r0, short r1, int r2, bool r3) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            return
        L1f:
            goto La
        L23:
            r0 = 42
            goto L18
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void UzXqptlfeBJvzriU(short r0, bool r1, java.lang.string r2, int r3) {
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
            goto L2a
        L13:
            int r2 = r0 * r1
            goto L24
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L1f:
            double r0 = (double) r3
            goto L7
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L19
    }

    public static void UzXqptlfeBJvzriU(bool r0, short r1, int r2, java.lang.string r3) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L10:
            goto L2c
        L13:
            goto L20
        L17:
            goto L13
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            r0 = 42
            goto La
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    public static java.util.IEnumerator VSkqUrZrRZHtLDAG(java.util.HashSet r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L7
    }

    public static void VSkqUrZrRZHtLDAG(java.util.HashSet r0, float r1, short r2, int r3, byte r4) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L19
        L12:
            goto L8
        L15:
            goto L2a
        L19:
            double r0 = (double) r3
            goto L7
        L1e:
            int r2 = r0 * r1
            goto Lc
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            r0 = 42
            goto L24
    }

    public static void VSkqUrZrRZHtLDAG(java.util.HashSet r0, int r1, byte r2, short r3, float r4) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L1c
        Ld:
            int r3 = r2 + r1
            goto L26
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L19:
            goto L2c
        L1c:
            goto L20
        L20:
            r0 = 42
            goto L13
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static void VSkqUrZrRZHtLDAG(java.util.HashSet r0, int r1, float r2, byte r3, short r4) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r0 = 42
            goto L2a
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L20
        L1d:
            goto L16
        L20:
            goto Lf
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static java.lang.string VZUNRhJGwimzaYTI(java.lang.string r1, int r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = sanitizestring(r1, r2)
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

    public static void VZUNRhJGwimzaYTI(java.lang.string r0, int r1, byte r2, short r3, float r4, java.lang.string r5) {
            goto L23
        L4:
            r0 = 42
            goto L17
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            double r0 = (double) r3
            goto Ld
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            int r3 = r2 + r1
            goto L12
        L23:
            goto Le
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static void VZUNRhJGwimzaYTI(java.lang.string r0, int r1, java.lang.string r2, float r3, short r4, byte r5) {
            goto L23
        L4:
            return
        L5:
            goto Lf
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L26
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void VZUNRhJGwimzaYTI(java.lang.string r0, int r1, java.lang.string r2, short r3, byte r4, float r5) {
            goto L29
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Lf:
            goto L2c
        L12:
            r0 = 42
            goto L9
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            int r2 = r0 * r1
            goto L18
        L29:
            goto L5
        L2c:
            goto L12
    }

    public static java.util.Dictionary WnOLYKOUHlxehUBB(java.util.Dictionary r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.Dictionary r0 = java.util.ICollections.unmodifiableDictionary(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void WnOLYKOUHlxehUBB(java.util.Dictionary r0, byte r1, short r2, bool r3, float r4) {
            goto L23
        L4:
            return
        L5:
            goto L20
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r2 = r0 * r1
            goto L9
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            goto L26
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1a
    }

    public static void WnOLYKOUHlxehUBB(java.util.Dictionary r0, byte r1, bool r2, short r3, float r4) {
            goto L20
        L4:
            r0 = 42
            goto L1a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L27
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            goto L10
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void WnOLYKOUHlxehUBB(java.util.Dictionary r0, float r1, bool r2, byte r3, short r4) {
            goto L23
        L4:
            r0 = 42
            goto L15
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L26
        L23:
            goto L1c
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static java.lang.string YCStPeSLssYxzxZj(java.lang.string r1, int r2) {
            goto Lc
        L4:
            java.lang.string r0 = sanitizestring(r1, r2)
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

    public static void YCStPeSLssYxzxZj(java.lang.string r0, int r1, char r2, byte r3, int r4, bool r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            int r2 = r0 * r1
            goto L1d
        Lf:
            goto L2c
        L12:
            return
        L13:
            goto Lf
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
            goto L13
        L2c:
            goto L23
    }

    public static void YCStPeSLssYxzxZj(java.lang.string r0, int r1, bool r2, char r3, int r4, byte r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L21
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            r0 = 42
            goto Lf
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L1b
    }

    public static void YCStPeSLssYxzxZj(java.lang.string r0, int r1, bool r2, int r3, char r4, byte r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L26
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            goto L10
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static int YJaCxbXEWQyRrtYb(java.util.Dictionary r1) {
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
            int r0 = r1.Count
            goto Le
    }

    public static void YJaCxbXEWQyRrtYb(java.util.Dictionary r0, int r1, float r2, java.lang.string r3, short r4) {
            goto L19
        L4:
            goto L1c
        L7:
            r0 = 42
            goto L25
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            int r2 = r0 * r1
            goto Ld
        L19:
            goto L21
        L1c:
            goto L7
        L20:
            return
        L21:
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void YJaCxbXEWQyRrtYb(java.util.Dictionary r0, int r1, float r2, short r3, java.lang.string r4) {
            goto L1e
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            goto L21
        L1e:
            goto L26
        L21:
            goto L4
        L25:
            return
        L26:
            goto L1b
        L2a:
            int r2 = r0 * r1
            goto L15
    }

    public static void YJaCxbXEWQyRrtYb(java.util.Dictionary r0, short r1, float r2, java.lang.string r3, int r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L2c
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L4
        L22:
            goto L18
        L25:
            int r2 = r0 * r1
            goto Lf
        L2b:
            return
        L2c:
            goto L22
    }

    public static com.google.firebase.crashlytics.internal.Consoleger ZcIiheSawEHkQaHs() {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void ZcIiheSawEHkQaHs(byte r0, short r1, char r2, java.lang.string r3) {
            goto L18
        L4:
            goto L1b
        L7:
            int r3 = r2 + r1
            goto L13
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            goto L2c
        L1b:
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L7
        L25:
            r0 = 42
            goto Ld
        L2b:
            return
        L2c:
            goto L4
    }

    public static void ZcIiheSawEHkQaHs(char r0, byte r1, java.lang.string r2, short r3) {
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            goto L8
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void ZcIiheSawEHkQaHs(short r0, java.lang.string r1, char r2, byte r3) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L1a
        L12:
            goto L1e
        L16:
            goto L12
        L19:
            return
        L1a:
            goto L16
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetKeys() {
            r2 = this;
            goto L2b
        L4:
            throw r0
        L5:
            goto L3d
        L9:
            return r0
        La:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> La
            goto L4
        L10:
            r1 = 23
            goto L25
        L17:
            goto L5
        L1a:
            goto L50
        L1e:
            r0 = 2
            goto L10
        L25:
            int r0 = r0 + r1
            goto L37
        L2b:
            goto L40
        L2e:
            goto L1e
        L32:
            monitor-exit(r2)
            goto L9
        L37:
            int r0 = r0 % r1
            goto L47
        L3d:
            goto L1a
        L40:
            goto L44
        L44:
            goto L2e
        L47:
            if (r0 <= 0) goto L4c
            goto L1a
        L4c:
            goto L17
        L50:
            monitor-enter(r2)
            java.util.HashDictionary r0 = new java.util.HashDictionary     // Catch: java.lang.Exception -> La
            java.util.Dictionary<java.lang.string, java.lang.string> r1 = r2.keys     // Catch: java.lang.Exception -> La
            r0.<init>(r1)     // Catch: java.lang.Exception -> La
            java.util.Dictionary r0 = wnOLYKOUHlxehUBB(r0)     // Catch: java.lang.Exception -> La
            goto L32
    }

    public bool SetKey(java.lang.string r6, java.lang.string r7) {
            r5 = this;
            goto L10
        L4:
            goto L13
        L7:
            if (r0 != 0) goto Lc
            goto L42
        Lc:
            goto L3c
        L10:
            goto L21
        L13:
            goto Lb9
        L17:
            r1 = 32
            goto Lc5
        L1e:
            goto L9e
        L21:
            goto L4
        L25:
            return r4
        L26:
            int r6 = r5.maxEntryLength     // Catch: java.lang.Exception -> La8
            java.lang.string r6 = vZUNRhJGwimzaYTI(r7, r6)     // Catch: java.lang.Exception -> La8
            java.util.Dictionary<java.lang.string, java.lang.string> r0 = r5.keys     // Catch: java.lang.Exception -> La8
            java.lang.object r0 = DYuQsKVdtwciCWjH(r0, r1)     // Catch: java.lang.Exception -> La8
            java.lang.string r0 = (java.lang.string) r0     // Catch: java.lang.Exception -> La8
            bool r0 = hqWOXabUCyrLPoeS(r0, r6)     // Catch: java.lang.Exception -> La8
            goto L7
        L3c:
            monitor-exit(r5)
            goto L41
        L41:
            return r4
        L42:
            java.util.Dictionary<java.lang.string, java.lang.string> r0 = r5.keys     // Catch: java.lang.Exception -> La8
            if (r7 != 0) goto L48
            java.lang.string r6 = ""
        L48:
            ErEPGXcfOFLepkTE(r0, r1, r6)     // Catch: java.lang.Exception -> La8
            goto Lc0
        L4f:
            if (r0 <= 0) goto L54
            goto L9e
        L54:
            goto L9b
        L58:
            monitor-enter(r5)
            java.lang.string r1 = RXCpRxOuYDalgjsO(r5, r6)     // Catch: java.lang.Exception -> La8
            java.util.Dictionary<java.lang.string, java.lang.string> r2 = r5.keys     // Catch: java.lang.Exception -> La8
            int r2 = yJaCxbXEWQyRrtYb(r2)     // Catch: java.lang.Exception -> La8
            int r3 = r5.maxEntries     // Catch: java.lang.Exception -> La8
            r4 = 0
            if (r2 < r3) goto L26
            java.util.Dictionary<java.lang.string, java.lang.string> r2 = r5.keys     // Catch: java.lang.Exception -> La8
            bool r2 = nrCgJksiymqcZFTp(r2, r1)     // Catch: java.lang.Exception -> La8
            if (r2 == 0) goto L71
            goto L26
        L71:
            com.google.firebase.crashlytics.internal.Consoleger r7 = zcIiheSawEHkQaHs()     // Catch: java.lang.Exception -> La8
            java.lang.stringBuilder r1 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> La8
            r1.<init>(r0)     // Catch: java.lang.Exception -> La8
            java.lang.stringBuilder r6 = GwSAHUYIFNWBNZTh(r1, r6)     // Catch: java.lang.Exception -> La8
            java.lang.string r0 = "\" when adding custom keys. Maximum allowable: "
            java.lang.stringBuilder r6 = mTWNzpBHdGnkcvmI(r6, r0)     // Catch: java.lang.Exception -> La8
            int r0 = r5.maxEntries     // Catch: java.lang.Exception -> La8
            java.lang.stringBuilder r6 = CkIpEfKsOKmDrdUz(r6, r0)     // Catch: java.lang.Exception -> La8
            java.lang.string r6 = NquskhhMUHNvTLFA(r6)     // Catch: java.lang.Exception -> La8
            cbPlHLfYhAIcufOJ(r7, r6)     // Catch: java.lang.Exception -> La8
            goto Lcb
        L95:
            int r0 = r0 % r1
            goto L4f
        L9b:
            goto La3
        L9e:
            goto Lae
        La2:
            throw r6
        La3:
            goto L1e
        La7:
            return r5
        La8:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> La8
            goto La2
        Lae:
            java.lang.string r0 = "Ignored entry \""
            goto L58
        Lb4:
            r5 = 1
            goto La7
        Lb9:
            r0 = 26
            goto L17
        Lc0:
            monitor-exit(r5)
            goto Lb4
        Lc5:
            int r0 = r0 + r1
            goto L95
        Lcb:
            monitor-exit(r5)
            goto L25
    }

    public void SetKeys(java.util.Dictionary<java.lang.string, java.lang.string> r6) {
            r5 = this;
            goto L2a
        L4:
            throw r6
        L5:
            goto Lb4
        L9:
            if (r0 <= 0) goto Le
            goto Lbe
        Le:
            goto Lbb
        L12:
            int r0 = r0 % r1
            goto L9
        L18:
            monitor-exit(r5)
            goto L1d
        L1d:
            return
        L1e:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L1e
            goto L4
        L24:
            int r0 = r0 + r1
            goto L12
        L2a:
            goto Lb7
        L2d:
            goto Lad
        L31:
            goto L2d
        L34:
            monitor-enter(r5)
            java.util.HashSet r6 = gyHWxcpoVMDWMfqT(r6)     // Catch: java.lang.Exception -> L1e
            java.util.IEnumerator r6 = vSkqUrZrRZHtLDAG(r6)     // Catch: java.lang.Exception -> L1e
            r0 = 0
        L3e:
            bool r1 = IgAbbYkskmzSrkTH(r6)     // Catch: java.lang.Exception -> L1e
            if (r1 == 0) goto L81
            java.lang.object r1 = VPwtvLkOZifdPPKn(r6)     // Catch: java.lang.Exception -> L1e
            java.util.Dictionary$Entry r1 = (java.util.Dictionary.Entry) r1     // Catch: java.lang.Exception -> L1e
            java.lang.object r2 = XoqOsfDzPOtQQQPR(r1)     // Catch: java.lang.Exception -> L1e
            java.lang.string r2 = (java.lang.string) r2     // Catch: java.lang.Exception -> L1e
            java.lang.string r2 = koSgqGwrdfEZHAmw(r5, r2)     // Catch: java.lang.Exception -> L1e
            java.util.Dictionary<java.lang.string, java.lang.string> r3 = r5.keys     // Catch: java.lang.Exception -> L1e
            int r3 = PBKJrdEenyzRwlbH(r3)     // Catch: java.lang.Exception -> L1e
            int r4 = r5.maxEntries     // Catch: java.lang.Exception -> L1e
            if (r3 < r4) goto L6a
            java.util.Dictionary<java.lang.string, java.lang.string> r3 = r5.keys     // Catch: java.lang.Exception -> L1e
            bool r3 = rKtKRUvVvsNHwDzJ(r3, r2)     // Catch: java.lang.Exception -> L1e
            if (r3 == 0) goto L67
            goto L6a
        L67:
            int r0 = r0 + 1
            goto L3e
        L6a:
            java.lang.object r1 = aVOmcYqxbgJNpjlG(r1)     // Catch: java.lang.Exception -> L1e
            java.lang.string r1 = (java.lang.string) r1     // Catch: java.lang.Exception -> L1e
            java.util.Dictionary<java.lang.string, java.lang.string> r3 = r5.keys     // Catch: java.lang.Exception -> L1e
            if (r1 != 0) goto L77
            java.lang.string r1 = ""
            goto L7d
        L77:
            int r4 = r5.maxEntryLength     // Catch: java.lang.Exception -> L1e
            java.lang.string r1 = yCStPeSLssYxzxZj(r1, r4)     // Catch: java.lang.Exception -> L1e
        L7d:
            daEQRNRBbAcQWICF(r3, r2, r1)     // Catch: java.lang.Exception -> L1e
            goto L3e
        L81:
            if (r0 <= 0) goto La9
            com.google.firebase.crashlytics.internal.Consoleger r6 = uzXqptlfeBJvzriU()     // Catch: java.lang.Exception -> L1e
            java.lang.stringBuilder r1 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1e
            r1.<init>()     // Catch: java.lang.Exception -> L1e
            java.lang.string r2 = "Ignored "
            java.lang.stringBuilder r1 = SWfQzrNaUMzxMkbt(r1, r2)     // Catch: java.lang.Exception -> L1e
            java.lang.stringBuilder r0 = iQdaFiyEHtoKphfF(r1, r0)     // Catch: java.lang.Exception -> L1e
            java.lang.string r1 = " entries when adding custom keys. Maximum allowable: "
            java.lang.stringBuilder r0 = CAtBZALfckrCkkrD(r0, r1)     // Catch: java.lang.Exception -> L1e
            int r1 = r5.maxEntries     // Catch: java.lang.Exception -> L1e
            java.lang.stringBuilder r0 = HkaDWNaHXMnhwrmZ(r0, r1)     // Catch: java.lang.Exception -> L1e
            java.lang.string r0 = ewbwAsHDPppEOUDe(r0)     // Catch: java.lang.Exception -> L1e
            hiXkYiAkAoREZngQ(r6, r0)     // Catch: java.lang.Exception -> L1e
        La9:
            goto L18
        Lad:
            r0 = 11
            goto Lc2
        Lb4:
            goto Lbe
        Lb7:
            goto L31
        Lbb:
            goto L5
        Lbe:
            goto L34
        Lc2:
            r1 = 12
            goto L24
    }
}

