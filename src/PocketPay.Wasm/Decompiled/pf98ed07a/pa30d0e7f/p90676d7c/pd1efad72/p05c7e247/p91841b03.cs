namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes4.dex */
public readonly class p91841b03<T> : io.reactivex.rxjava3.functions.BiFunction<java.util.List<T>, java.util.List<T>, java.util.List<T>> {
    readonly java.util.Comparator f3b70c5be;
    readonly java.util.Comparator<T> f4092f21b;
    readonly java.util.Comparator fd3bde699;
    readonly java.util.Comparator fee8292f1;

    public p91841b03(java.util.Comparator<T> r1) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L1d
        L10:
            r0.f4092f21b = r1
            goto Lb
        L16:
            r0.<init>()
            goto L10
        L1d:
            goto L7
    }

    public static bool ELolWtKkfkLNmQCO(java.util.IEnumerator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.MoveNext()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int ElMjhounxUYUbzkF(java.util.Comparator r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.compare(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool FajUQYqiWUeWMyPh(java.util.IEnumerator r1) {
            goto L14
        L4:
            bool r0 = r1.MoveNext()
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

    public static java.lang.object FnbJYgLpBWCsNRZc(java.util.IEnumerator r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.Current
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

    public static bool FoJQWhjGPwGfdnnG(java.util.List r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Add(r2)
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

    public static java.util.IEnumerator JqjusLzbteahKLaZ(java.util.List r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.object KojBcTovXkeTkyey(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Current
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.util.List MPwWAEZjMpOnAdzb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p91841b03 r1, java.util.List r2, java.util.List r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.util.List r0 = r1.apply(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object NDlIIVNHZnPTQmHl(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto L7
    }

    public static bool NxAUuQvtxJalRHGo(java.util.List r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.Add(r2)
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

    public static bool OwgOtxXVzODSNzgS(java.util.List r1, java.lang.object r2) {
            goto L11
        L4:
            bool r0 = r1.Add(r2)
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

    public static bool SCpiyKozlpdtExbT(java.util.IEnumerator r1) {
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
            bool r0 = r1.MoveNext()
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.object XRIlxndWvSOkwPpg(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto L7
    }

    public static bool ZXBiQTsmWEwHaBQi(java.util.IEnumerator r1) {
            goto L11
        L4:
            bool r0 = r1.MoveNext()
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

    public static java.util.IEnumerator AxzZObRNfGSvVpDO(java.util.List r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool GzdrIdBsxsZxMVwV(java.util.IEnumerator r1) {
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

    public static bool HcRtScHRNUTnciGP(java.util.List r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.Add(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool KbYkgsFcDfQgBmvR(java.util.IEnumerator r1) {
            goto L14
        L4:
            bool r0 = r1.MoveNext()
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

    public static bool KxAbHUPYhYzKVlwG(java.util.List r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Lb
    }

    public static int NUCDraXAIMshhwdR(java.util.List r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.Count
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object OoiuNUVOxPAWIqaZ(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto L4
    }

    public static int UVPEFmCWpvHLgeZZ(java.util.List r1) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.Count
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

    public static bool UrGUWJpqtfluDIxZ(java.util.List r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Add(r2)
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

    public static java.lang.object WnaBeBHjEcFjySdG(java.util.IEnumerator r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1.Current
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

    public /* bridge */ /* synthetic */ java.lang.object apply(java.lang.object r1, java.lang.object r2) throws java.lang.Exception {
            r0 = this;
            goto L4
        L4:
            goto L18
        L7:
            goto L11
        Lb:
            java.util.List r2 = (java.util.List) r2
            goto L1c
        L11:
            java.util.List r1 = (java.util.List) r1
            goto Lb
        L17:
            return r0
        L18:
            goto L24
        L1c:
            java.util.List r0 = MPwWAEZjMpOnAdzb(r0, r1, r2)
            goto L17
        L24:
            goto L7
    }

    public java.util.List<T> Apply(java.util.List<T> r6, java.util.List<T> r7) {
            r5 = this;
            goto L1ab
        L4:
            OwgOtxXVzODSNzgS(r1, r0)
            goto Lbe
        Lb:
            goto L70
        Le:
            goto L130
        L12:
            NxAUuQvtxJalRHGo(r1, r0)
        L15:
            goto L128
        L19:
            goto L11b
        L1b:
            goto Le7
        L1f:
            bool r3 = FajUQYqiWUeWMyPh(r7)
            goto L138
        L27:
            hcRtScHRNUTnciGP(r1, r5)
            goto L74
        L2e:
            java.util.List r5 = new java.util.List
            goto L113
        L34:
            java.lang.object r0 = XRIlxndWvSOkwPpg(r6)
            goto L64
        L3c:
            int r0 = r0 + r1
            goto L1a2
        L41:
            if (r0 <= 0) goto L46
            goto Le
        L46:
            goto Lb
        L4a:
            if (r3 != 0) goto L4f
            goto Lac
        L4f:
            goto L18f
        L53:
            if (r5 != 0) goto L58
            goto L167
        L58:
            goto L79
        L5c:
            java.util.IEnumerator r6 = JqjusLzbteahKLaZ(r6)
            goto L181
        L64:
            goto Lda
        L65:
            goto Ld9
        L69:
            java.util.List r1 = new java.util.List
            goto L8d
        L6f:
            return r1
        L70:
            goto L105
        L74:
            goto L15
        L75:
            goto L10c
        L79:
            java.lang.object r5 = NDlIIVNHZnPTQmHl(r7)
            goto La4
        L81:
            return r5
        L82:
            goto L69
        L86:
            r1 = 15
            goto Lc6
        L8d:
            r1.<init>(r0)
            goto L5c
        L94:
            java.lang.object r0 = ooiuNUVOxPAWIqaZ(r6)
            goto L195
        L9c:
            int r4 = ElMjhounxUYUbzkF(r4, r0, r3)
            goto Lde
        La4:
            urGUWJpqtfluDIxZ(r1, r5)
            goto L166
        Lab:
            goto L11b
        Lac:
            goto L15d
        Lb0:
            if (r0 != 0) goto Lb5
            goto L196
        Lb5:
            goto L94
        Lb9:
            r0 = r2
            goto L19
        Lbe:
            bool r0 = gzdrIdBsxsZxMVwV(r6)
            goto Lb0
        Lc6:
            int r0 = r0 + r1
            goto L189
        Lcc:
            goto L11b
        Lcd:
            goto L11a
        Ld1:
            int r1 = nUCDraXAIMshhwdR(r7)
            goto L3c
        Ld9:
            r0 = r2
        Lda:
            goto L1f
        Lde:
            if (r4 < 0) goto Le3
            goto L1b
        Le3:
            goto L4
        Le7:
            kxAbHUPYhYzKVlwG(r1, r3)
            goto Lfd
        Lee:
            r0 = 6
            goto L86
        Lf5:
            java.lang.object r3 = KojBcTovXkeTkyey(r7)
            goto Lab
        Lfd:
            bool r3 = ELolWtKkfkLNmQCO(r7)
            goto L11f
        L105:
            goto Le
        L108:
            goto L15a
        L10c:
            FoJQWhjGPwGfdnnG(r1, r3)
        L10f:
            goto L174
        L113:
            r5.<init>()
            goto L81
        L11a:
            r3 = r2
        L11b:
            goto L16b
        L11f:
            if (r3 != 0) goto L124
            goto Lcd
        L124:
            goto Lf5
        L128:
            bool r5 = SCpiyKozlpdtExbT(r6)
            goto L151
        L130:
            int r0 = uVPEFmCWpvHLgeZZ(r6)
            goto Ld1
        L138:
            if (r3 != 0) goto L13d
            goto Lcd
        L13d:
            goto L19a
        L141:
            bool r0 = ZXBiQTsmWEwHaBQi(r6)
            goto L17c
        L149:
            java.lang.object r5 = wnaBeBHjEcFjySdG(r6)
            goto L27
        L151:
            if (r5 != 0) goto L156
            goto L167
        L156:
            goto L149
        L15a:
            goto L1ae
        L15d:
            if (r0 != 0) goto L162
            goto L75
        L162:
            goto L12
        L166:
            goto L10f
        L167:
            goto L6f
        L16b:
            if (r0 != 0) goto L170
            goto Lac
        L170:
            goto L4a
        L174:
            bool r5 = kbYkgsFcDfQgBmvR(r7)
            goto L53
        L17c:
            r2 = 0
            goto L1b2
        L181:
            java.util.IEnumerator r7 = axzZObRNfGSvVpDO(r7)
            goto L141
        L189:
            int r0 = r0 % r1
            goto L41
        L18f:
            java.util.Comparator<T> r4 = r5.f4092f21b
            goto L9c
        L195:
            goto L11b
        L196:
            goto Lb9
        L19a:
            java.lang.object r3 = FnbJYgLpBWCsNRZc(r7)
            goto Lcc
        L1a2:
            if (r0 == 0) goto L1a7
            goto L82
        L1a7:
            goto L2e
        L1ab:
            goto L108
        L1ae:
            goto Lee
        L1b2:
            if (r0 != 0) goto L1b7
            goto L65
        L1b7:
            goto L34
    }
}

