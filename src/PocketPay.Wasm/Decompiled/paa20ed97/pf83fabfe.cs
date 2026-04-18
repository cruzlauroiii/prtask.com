namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes21.dex */
readonly class pf83fabfe<T> : retrofit2.Call<T> {
    private readonly p7ddcfee1.pc3755e61.p1c6e980e f0bd66785;
    private readonly paa20ed97.p60ad5b1d f0e8b170c;
    private java.lang.Exception f18ac595a;
    private readonly paa20ed97.pc7611810 f22c692d6;
    private readonly paa20ed97.p60ad5b1d f319395c2;
    private readonly paa20ed97.pc7611810 f3998e075;

    @javax.annotation.Nullable
    private java.lang.Exception f4c61baa6;
    private readonly retrofit2.Converter<p7ddcfee1.p42c567ea, T> f5237a940;
    private bool f55d6b793;

    @javax.annotation.Nullable
    private p7ddcfee1.pc3755e61 f66279646;
    private bool f6757a2cb;
    private bool f75157d05;
    private readonly paa20ed97.p60ad5b1d f8a26362c;
    private bool f8ce7926b;
    private readonly java.lang.object[] f92e5f554;
    private bool fa6a909b5;
    private readonly java.lang.object[] fa956af09;
    private p7ddcfee1.pc3755e61 fb675a7a4;
    private readonly p7ddcfee1.pc3755e61.p1c6e980e fc9e298d7;
    private p7ddcfee1.pc3755e61 fd0b7e09e;
    private bool fd5c39a1d;
    private readonly paa20ed97.pc7611810 fd75e7dc3;
    private readonly p7ddcfee1.pc3755e61.p1c6e980e fe625afb0;
    private readonly paa20ed97.p60ad5b1d fe7a96269;


    static readonly class p16890fbe : p7ddcfee1.p42c567ea {
        private readonly long f30e868ef;
        private readonly p7ddcfee1.pba07c23c f539c48fc;
        private readonly long fc22384f3;

        @javax.annotation.Nullable
        private readonly p7ddcfee1.pba07c23c fdf5feafa;

        p16890fbe(@javax.annotation.Nullable p7ddcfee1.pba07c23c r1, long r2) {
                r0 = this;
                goto L4
            L4:
                goto L22
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                r0.<init>()
                goto L15
            L15:
                r0.fdf5feafa = r1
                goto L1b
            L1b:
                r0.fc22384f3 = r2
                goto L21
            L21:
                return
            L22:
                goto Lb
        }

        @Override // p7ddcfee1.p42c567ea
        public long ContentLength() {
                r2 = this;
                goto L1b
            L4:
                int r0 = r0 + r1
                goto L36
            La:
                return r0
            Lb:
                goto L43
            Lf:
                goto L1e
            L12:
                if (r0 <= 0) goto L17
                goto L25
            L17:
                goto L22
            L1b:
                goto L46
            L1e:
                goto L29
            L22:
                goto Lb
            L25:
                goto L30
            L29:
                r0 = 19
                goto L3c
            L30:
                long r0 = r2.fc22384f3
                goto La
            L36:
                int r0 = r0 % r1
                goto L12
            L3c:
                r1 = 3
                goto L4
            L43:
                goto L25
            L46:
                goto Lf
        }

        @Override // p7ddcfee1.p42c567ea
        public p7ddcfee1.pba07c23c ContentType() {
                r0 = this;
                goto L12
            L4:
                p7ddcfee1.pba07c23c r0 = r0.fdf5feafa
                goto La
            La:
                return r0
            Lb:
                goto Lf
            Lf:
                goto L15
            L12:
                goto Lb
            L15:
                goto L4
        }

        @Override // p7ddcfee1.p42c567ea
        public p38cb8f46.pcc81e3f6 Source() {
                r1 = this;
                goto L1f
            L4:
                throw r1
            L5:
                goto L15
            L9:
                java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
                goto Lf
            Lf:
                java.lang.string r0 = "Cannot read raw response body of a converted body."
                goto L18
            L15:
                goto L22
            L18:
                r1.<init>(r0)
                goto L4
            L1f:
                goto L5
            L22:
                goto L9
        }
    }

    static readonly class p45cf3335 : p7ddcfee1.p42c567ea {
        private readonly p7ddcfee1.p42c567ea f0b555d61;
        private readonly p7ddcfee1.p42c567ea f1e6c3bde;
        private readonly p38cb8f46.pcc81e3f6 f44529432;
        java.io.IOException f4702c114;
        private readonly p38cb8f46.pcc81e3f6 f525ccbe6;

        @javax.annotation.Nullable
        java.io.IOException f5883c2a0;
        java.io.IOException f63e1a3ce;
        private readonly p7ddcfee1.p42c567ea f7f19110c;
        private readonly p7ddcfee1.p42c567ea f7f662005;
        java.io.IOException f9df792d4;
        private readonly p7ddcfee1.p42c567ea ffd3a750f;


        p45cf3335(p7ddcfee1.p42c567ea r2) {
                r1 = this;
                goto L4
            L4:
                goto Lc
            L7:
                goto L27
            Lb:
                return
            Lc:
                goto L24
            L10:
                p38cb8f46.pcc81e3f6 r2 = p38cb8f46.p0af9afa4.m7f2db423(r0)
                goto L1e
            L18:
                paa20ed97.pf83fabfe$p45cf3335$1 r0 = new paa20ed97.pf83fabfe$p45cf3335$1
                goto L3b
            L1e:
                r1.f44529432 = r2
                goto Lb
            L24:
                goto L7
            L27:
                r1.<init>()
                goto L35
            L2e:
                r0.<init>(r1, r2)
                goto L10
            L35:
                r1.f7f662005 = r2
                goto L18
            L3b:
                p38cb8f46.pcc81e3f6 r2 = r2.source()
                goto L2e
        }

        @Override // p7ddcfee1.p42c567ea, java.io.IDisposable, java.lang.AutoIDisposable
        public void Close() {
                r0 = this;
                goto L4
            L4:
                goto L19
            L7:
                goto L12
            Lb:
                r0.Dispose()
                goto L18
            L12:
                p7ddcfee1.p42c567ea r0 = r0.f7f662005
                goto Lb
            L18:
                return
            L19:
                goto L1d
            L1d:
                goto L7
        }

        @Override // p7ddcfee1.p42c567ea
        public long ContentLength() {
                r2 = this;
                goto L1e
            L4:
                r0 = 16
                goto L2e
            Lb:
                goto L4b
            Le:
                goto L4f
            L12:
                int r0 = r0 % r1
                goto L25
            L18:
                int r0 = r0 + r1
                goto L12
            L1e:
                goto Le
            L21:
                goto L4
            L25:
                if (r0 <= 0) goto L2a
                goto L4b
            L2a:
                goto L48
            L2e:
                r1 = 13
                goto L18
            L35:
                return r0
            L36:
                goto Lb
            L3a:
                p7ddcfee1.p42c567ea r2 = r2.f7f662005
                goto L40
            L40:
                long r0 = r2.contentLength()
                goto L35
            L48:
                goto L36
            L4b:
                goto L3a
            L4f:
                goto L21
        }

        @Override // p7ddcfee1.p42c567ea
        public p7ddcfee1.pba07c23c ContentType() {
                r0 = this;
                goto L17
            L4:
                p7ddcfee1.pba07c23c r0 = r0.contentType()
                goto L12
            Lc:
                p7ddcfee1.p42c567ea r0 = r0.f7f662005
                goto L4
            L12:
                return r0
            L13:
                goto L1e
            L17:
                goto L13
            L1a:
                goto Lc
            L1e:
                goto L1a
        }

        @Override // p7ddcfee1.p42c567ea
        public p38cb8f46.pcc81e3f6 Source() {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L15
            Lc:
                p38cb8f46.pcc81e3f6 r0 = r0.f44529432
                goto L4
            L12:
                goto L5
            L15:
                goto Lc
        }

        void throwIfCaught() throws java.io.IOException {
                r0 = this;
                goto L4
            L4:
                goto L1a
            L7:
                goto L1e
            Lb:
                if (r0 == 0) goto L10
                goto L15
            L10:
                goto L14
            L14:
                return
            L15:
                goto L19
            L19:
                throw r0
            L1a:
                goto L24
            L1e:
                java.io.IOException r0 = r0.f5883c2a0
                goto Lb
            L24:
                goto L7
        }
    }

    pf83fabfe(paa20ed97.pc7611810 r1, java.lang.object[] r2, p7ddcfee1.pc3755e61.p1c6e980e r3, retrofit2.Converter<p7ddcfee1.p42c567ea, T> r4) {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.<init>()
            goto L26
        L13:
            goto L8
        L16:
            goto Lc
        L1a:
            r0.f5237a940 = r4
            goto L7
        L20:
            r0.fc9e298d7 = r3
            goto L1a
        L26:
            r0.f22c692d6 = r1
            goto L2c
        L2c:
            r0.fa956af09 = r2
            goto L20
    }

    private p7ddcfee1.pc3755e61 CreateRawCall() throws java.io.IOException {
            r2 = this;
            goto L38
        L4:
            r1 = 16
            goto L19
        Lb:
            p7ddcfee1.pc3755e61 r2 = r0.newCall(r2)
            goto L2f
        L13:
            java.lang.NullPointerException r2 = new java.lang.NullPointerException
            goto L7a
        L19:
            int r0 = r0 + r1
            goto L3f
        L1f:
            r0 = 10
            goto L4
        L26:
            goto L3b
        L29:
            paa20ed97.pc7611810 r1 = r2.f22c692d6
            goto L74
        L2f:
            if (r2 != 0) goto L34
            goto L65
        L34:
            goto L64
        L38:
            goto L4f
        L3b:
            goto L1f
        L3f:
            int r0 = r0 % r1
            goto L53
        L45:
            r2.<init>(r0)
            goto L69
        L4c:
            goto L83
        L4f:
            goto L26
        L53:
            if (r0 <= 0) goto L58
            goto L83
        L58:
            goto L80
        L5c:
            p7ddcfee1.p15c2d85f r2 = r1.create(r2)
            goto Lb
        L64:
            return r2
        L65:
            goto L13
        L69:
            throw r2
        L6a:
            goto L4c
        L6e:
            p7ddcfee1.pc3755e61$p1c6e980e r0 = r2.fc9e298d7
            goto L29
        L74:
            java.lang.object[] r2 = r2.fa956af09
            goto L5c
        L7a:
            java.lang.string r0 = "Call.Factory returned null."
            goto L45
        L80:
            goto L6a
        L83:
            goto L6e
    }

    private p7ddcfee1.pc3755e61 GetRawCall() throws java.io.IOException {
            r1 = this;
            goto Lf
        L4:
            throw r0
        L5:
            goto L42
        L9:
            java.lang.Exception r0 = (java.lang.Exception) r0
            goto L4a
        Lf:
            goto L5
        L12:
            goto L54
        L16:
            bool r1 = r0 is java.io.IOException
            goto L1c
        L1c:
            if (r1 == 0) goto L21
            goto L46
        L21:
            goto L72
        L25:
            throw r0
        L26:
            p7ddcfee1.pc3755e61 r0 = r1.createRawCall()     // Catch: java.lang.Exception -> L61
            r1.f66279646 = r0     // Catch: java.lang.Exception -> L61
            goto L60
        L30:
            if (r0 != 0) goto L35
            goto L26
        L35:
            goto L16
        L39:
            if (r0 != 0) goto L3e
            goto L50
        L3e:
            goto L4f
        L42:
            goto L12
        L45:
            throw r0
        L46:
            goto L66
        L4a:
            throw r0
        L4b:
            goto L5a
        L4f:
            return r0
        L50:
            goto L6c
        L54:
            p7ddcfee1.pc3755e61 r0 = r1.f66279646
            goto L39
        L5a:
            java.lang.Error r0 = (java.lang.Error) r0
            goto L45
        L60:
            return r0
        L61:
            r0 = move-exception
            goto L87
        L66:
            java.io.IOException r0 = (java.io.IOException) r0
            goto L25
        L6c:
            java.lang.Exception r0 = r1.f4c61baa6
            goto L30
        L72:
            bool r1 = r0 is java.lang.Exception
            goto L78
        L78:
            if (r1 != 0) goto L7d
            goto L4b
        L7d:
            goto L9
        L81:
            r1.f4c61baa6 = r0
            goto L4
        L87:
            paa20ed97.pa470a233.throwIfFatal(r0)
            goto L81
    }

    public void Cancel() {
            r1 = this;
            goto L30
        L4:
            monitor-enter(r1)
            p7ddcfee1.pc3755e61 r0 = r1.f66279646     // Catch: java.lang.Exception -> L2a
            monitor-exit(r1)     // Catch: java.lang.Exception -> L2a
            goto L1b
        Lc:
            goto L33
        Lf:
            r0.cancel()
        L12:
            goto L29
        L16:
            r0 = 1
            goto L37
        L1b:
            if (r0 != 0) goto L20
            goto L12
        L20:
            goto Lf
        L24:
            throw r0
        L25:
            goto Lc
        L29:
            return
        L2a:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L2a
            goto L24
        L30:
            goto L25
        L33:
            goto L16
        L37:
            r1.fd5c39a1d = r0
            goto L4
    }

    public /* bridge */ /* synthetic */ java.lang.object clone() throws java.lang.CloneNotSupportedException {
            r0 = this;
            goto L14
        L4:
            paa20ed97.pf83fabfe r0 = r0.m3902clone()
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

    /* JADX INFO: renamed from: clone, reason: collision with other method in class */
    public /* bridge */ /* synthetic */ paa20ed97.pc3755e61 m3901clone() {
            r0 = this;
            goto L11
        L4:
            paa20ed97.pf83fabfe r0 = r0.m3902clone()
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

    /* JADX INFO: renamed from: clone, reason: collision with other method in class */
    public retrofit2.OkHttpCall<T> M3902clone() {
            r4 = this;
            goto L11
        L4:
            r1 = 31
            goto L63
        Lb:
            java.lang.object[] r2 = r4.fa956af09
            goto L28
        L11:
            goto L24
        L14:
            goto L41
        L18:
            goto L14
        L1b:
            retrofit2.Converter<p7ddcfee1.p42c567ea, T> r4 = r4.f5237a940
            goto L34
        L21:
            goto L4b
        L24:
            goto L18
        L28:
            p7ddcfee1.pc3755e61$p1c6e980e r3 = r4.fc9e298d7
            goto L1b
        L2e:
            int r0 = r0 % r1
            goto L55
        L34:
            r0.<init>(r1, r2, r3, r4)
            goto L5e
        L3b:
            paa20ed97.pf83fabfe r0 = new paa20ed97.pf83fabfe
            goto L4f
        L41:
            r0 = 31
            goto L4
        L48:
            goto L5f
        L4b:
            goto L3b
        L4f:
            paa20ed97.pc7611810 r1 = r4.f22c692d6
            goto Lb
        L55:
            if (r0 <= 0) goto L5a
            goto L4b
        L5a:
            goto L48
        L5e:
            return r0
        L5f:
            goto L21
        L63:
            int r0 = r0 + r1
            goto L2e
    }

    public void Enqueue(retrofit2.Callback<T> r4) {
            r3 = this;
            goto L77
        L4:
            r0.cancel()
        L7:
            goto L10
        Lb:
            throw r4
        Lc:
            goto L28
        L10:
            paa20ed97.pf83fabfe$1 r1 = new paa20ed97.pf83fabfe$1
            goto La1
        L16:
            r0.enqueue(r1)
            goto L3f
        L1d:
            return
        L1e:
            goto L22
        L22:
            bool r1 = r3.fd5c39a1d
            goto L2f
        L28:
            goto L3b
        L2b:
            goto L74
        L2f:
            if (r1 != 0) goto L34
            goto L7
        L34:
            goto L4
        L38:
            goto Lc
        L3b:
            goto L9b
        L3f:
            return
        L40:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> L48
            java.lang.string r0 = "Already executed."
            r4.<init>(r0)     // Catch: java.lang.Exception -> L48
            throw r4     // Catch: java.lang.Exception -> L48
        L48:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L48
            goto Lb
        L4e:
            java.util.objects.requireNonNull(r4, r0)
            goto L5b
        L55:
            int r0 = r0 + r1
            goto La8
        L5b:
            monitor-enter(r3)
            bool r0 = r3.fa6a909b5     // Catch: java.lang.Exception -> L48
            if (r0 != 0) goto L40
            r0 = 1
            r3.fa6a909b5 = r0     // Catch: java.lang.Exception -> L48
            p7ddcfee1.pc3755e61 r0 = r3.f66279646     // Catch: java.lang.Exception -> L48
            java.lang.Exception r1 = r3.f4c61baa6     // Catch: java.lang.Exception -> L48
            goto Lcf
        L6b:
            if (r1 != 0) goto L70
            goto L1e
        L70:
            goto Lba
        L74:
            goto L7a
        L77:
            goto L2b
        L7a:
            goto L85
        L7e:
            r1 = 25
            goto L55
        L85:
            r0 = 24
            goto L7e
        L8c:
            if (r1 == 0) goto L91
            goto Lb5
        L91:
            p7ddcfee1.pc3755e61 r2 = r3.createRawCall()     // Catch: java.lang.Exception -> Laf
            r3.f66279646 = r2     // Catch: java.lang.Exception -> Laf
            goto Lc1
        L9b:
            java.lang.string r0 = "callback is null"
            goto L4e
        La1:
            r1.<init>(r3, r4)
            goto L16
        La8:
            int r0 = r0 % r1
            goto Lc6
        Lae:
            goto Lb5
        Laf:
            r1 = move-exception
            paa20ed97.pa470a233.throwIfFatal(r1)     // Catch: java.lang.Exception -> L48
            r3.f4c61baa6 = r1     // Catch: java.lang.Exception -> L48
        Lb5:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L48
            goto L6b
        Lba:
            r4.onFailure(r3, r1)
            goto L1d
        Lc1:
            r0 = r2
            goto Lae
        Lc6:
            if (r0 <= 0) goto Lcb
            goto L3b
        Lcb:
            goto L38
        Lcf:
            if (r0 == 0) goto Ld4
            goto Lb5
        Ld4:
            goto L8c
    }

    public retrofit2.Response<T> Execute() throws java.io.IOException {
            r2 = this;
            goto L19
        L4:
            goto L48
        L7:
            goto L66
        Lb:
            goto L7
        Le:
            goto L63
        L12:
            r0.cancel()
        L15:
            goto L5b
        L19:
            goto Le
        L1c:
            goto L54
        L20:
            if (r1 != 0) goto L25
            goto L15
        L25:
            goto L12
        L29:
            return r2
        L2a:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> L32
            java.lang.string r1 = "Already executed."
            r0.<init>(r1)     // Catch: java.lang.Exception -> L32
            throw r0     // Catch: java.lang.Exception -> L32
        L32:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L32
            goto L47
        L38:
            bool r1 = r2.fd5c39a1d
            goto L20
        L3e:
            if (r0 <= 0) goto L43
            goto L7
        L43:
            goto L4
        L47:
            throw r0
        L48:
            goto Lb
        L4c:
            retrofit2.Response r2 = r2.parseResponse(r0)
            goto L29
        L54:
            r0 = 12
            goto L83
        L5b:
            p7ddcfee1.pd64ed3e9 r0 = r0.execute()
            goto L4c
        L63:
            goto L1c
        L66:
            monitor-enter(r2)
            bool r0 = r2.fa6a909b5     // Catch: java.lang.Exception -> L32
            if (r0 != 0) goto L2a
            r0 = 1
            r2.fa6a909b5 = r0     // Catch: java.lang.Exception -> L32
            p7ddcfee1.pc3755e61 r0 = r2.getRawCall()     // Catch: java.lang.Exception -> L32
            monitor-exit(r2)     // Catch: java.lang.Exception -> L32
            goto L38
        L77:
            int r0 = r0 + r1
            goto L7d
        L7d:
            int r0 = r0 % r1
            goto L3e
        L83:
            r1 = 7
            goto L77
    }

    public bool IsCanceled() {
            r2 = this;
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r2.fd5c39a1d
            goto L27
        Ld:
            r0 = 11
            goto L3a
        L14:
            goto L4d
        L17:
            goto Ld
        L1b:
            int r0 = r0 % r1
            goto L41
        L21:
            int r0 = r0 + r1
            goto L1b
        L27:
            r1 = 1
            goto L2c
        L2c:
            if (r0 != 0) goto L31
            goto L36
        L31:
            goto L35
        L35:
            return r1
        L36:
            goto L51
        L3a:
            r1 = 21
            goto L21
        L41:
            if (r0 <= 0) goto L46
            goto L69
        L46:
            goto L66
        L4a:
            goto L69
        L4d:
            goto L4
        L51:
            monitor-enter(r2)
            p7ddcfee1.pc3755e61 r0 = r2.f66279646     // Catch: java.lang.Exception -> L60
            if (r0 == 0) goto L5d
            bool r0 = r0.isCanceled()     // Catch: java.lang.Exception -> L60
            if (r0 == 0) goto L5d
            goto L5e
        L5d:
            r1 = 0
        L5e:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L60
            return r1
        L60:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L60
            goto L6d
        L66:
            goto L6e
        L69:
            goto L7
        L6d:
            throw r0
        L6e:
            goto L4a
    }

    public bool IsExecuted() {
            r1 = this;
            goto L4
        L4:
            goto L16
        L7:
            goto L1a
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lf
            goto L15
        L15:
            throw r0
        L16:
            goto Lb
        L1a:
            monitor-enter(r1)
            bool r0 = r1.fa6a909b5     // Catch: java.lang.Exception -> Lf
            goto L21
        L21:
            monitor-exit(r1)
            goto Le
    }

    retrofit2.Response<T> parseResponse(p7ddcfee1.pd64ed3e9 r6) throws java.io.IOException {
            r5 = this;
            goto L115
        L4:
            p7ddcfee1.pd64ed3e9 r6 = r6.build()
            goto L125
        Lc:
            r0.Dispose()
            goto L82
        L13:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r6 = r6.newBuilder()
            goto L10f
        L1b:
            paa20ed97.pf83fabfe$p45cf3335 r1 = new paa20ed97.pf83fabfe$p45cf3335
            goto Lf6
        L21:
            r1.<init>(r2, r3)
            goto Ldc
        L28:
            goto L118
        L2b:
            return r5
        L2c:
            p7ddcfee1.p42c567ea r5 = paa20ed97.pa470a233.buffer(r0)     // Catch: java.lang.Exception -> L47
            retrofit2.Response r5 = retrofit2.Response.error(r5, r6)     // Catch: java.lang.Exception -> L47
            goto L93
        L38:
            p7ddcfee1.pba07c23c r2 = r0.contentType()
            goto L52
        L40:
            return r5
        L41:
            r5 = move-exception
            goto Lb4
        L46:
            return r5
        L47:
            r5 = move-exception
            goto L8c
        L4c:
            r2 = 300(0x12c, float:4.2E-43)
            goto L11c
        L52:
            long r3 = r0.contentLength()
            goto L21
        L5a:
            r2 = 205(0xcd, float:2.87E-43)
            goto L72
        L60:
            if (r1 != r2) goto L65
            goto Le5
        L65:
            goto L5a
        L69:
            if (r1 >= r2) goto L6e
            goto L2c
        L6e:
            goto L4c
        L72:
            if (r1 == r2) goto L77
            goto Lc3
        L77:
            goto Lc2
        L7b:
            r1 = 17
            goto Ld6
        L82:
            r5 = 0
            goto Lac
        L87:
            goto L2c
        L88:
            goto L9a
        L8c:
            r0.Dispose()
            goto La0
        L93:
            r0.Dispose()
            goto L46
        L9a:
            r2 = 204(0xcc, float:2.86E-43)
            goto L60
        La0:
            throw r5
        La1:
            goto Lbb
        La5:
            r0 = 27
            goto L7b
        Lac:
            retrofit2.Response r5 = retrofit2.Response.success(r5, r6)
            goto L2b
        Lb4:
            r1.throwIfCaught()
            goto Le4
        Lbb:
            goto Lf2
        Lbe:
            goto L28
        Lc2:
            goto Le5
        Lc3:
            goto L1b
        Lc7:
            if (r0 <= 0) goto Lcc
            goto Lf2
        Lcc:
            goto Lef
        Ld0:
            r2 = 200(0xc8, float:2.8E-43)
            goto L69
        Ld6:
            int r0 = r0 + r1
            goto Le9
        Ldc:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r6 = r6.body(r1)
            goto L4
        Le4:
            throw r5
        Le5:
            goto Lc
        Le9:
            int r0 = r0 % r1
            goto Lc7
        Lef:
            goto La1
        Lf2:
            goto L107
        Lf6:
            r1.<init>(r0)
            retrofit2.Converter<p7ddcfee1.p42c567ea, T> r5 = r5.f5237a940     // Catch: java.lang.Exception -> L41
            java.lang.object r5 = r5.convert(r1)     // Catch: java.lang.Exception -> L41
            retrofit2.Response r5 = retrofit2.Response.success(r5, r6)     // Catch: java.lang.Exception -> L41
            goto L40
        L107:
            p7ddcfee1.p42c567ea r0 = r6.body()
            goto L13
        L10f:
            paa20ed97.pf83fabfe$p16890fbe r1 = new paa20ed97.pf83fabfe$p16890fbe
            goto L38
        L115:
            goto Lbe
        L118:
            goto La5
        L11c:
            if (r1 >= r2) goto L121
            goto L88
        L121:
            goto L87
        L125:
            int r1 = r6.code()
            goto Ld0
    }

    public p7ddcfee1.p15c2d85f Request() {
            r3 = this;
            goto Lf
        L4:
            monitor-exit(r3)
            goto L28
        L9:
            int r0 = r0 + r1
            goto L22
        Lf:
            goto L67
        L12:
            goto L16
        L16:
            r0 = 24
            goto L4e
        L1d:
            throw r0
        L1e:
            goto L64
        L22:
            int r0 = r0 % r1
            goto L3b
        L28:
            return r0
        L29:
            r0 = move-exception
            goto L55
        L2e:
            monitor-enter(r3)
            p7ddcfee1.pc3755e61 r0 = r3.getRawCall()     // Catch: java.lang.Exception -> L29 java.io.IOException -> L56
            p7ddcfee1.p15c2d85f r0 = r0.request()     // Catch: java.lang.Exception -> L29 java.io.IOException -> L56
            goto L4
        L3b:
            if (r0 <= 0) goto L40
            goto L47
        L40:
            goto L44
        L44:
            goto L1e
        L47:
            goto L2e
        L4b:
            goto L12
        L4e:
            r1 = 29
            goto L9
        L55:
            goto L5f
        L56:
            r0 = move-exception
            java.lang.Exception r1 = new java.lang.Exception     // Catch: java.lang.Exception -> L29
            java.lang.string r2 = "Unable to create request."
            r1.<init>(r2, r0)     // Catch: java.lang.Exception -> L29
            throw r1     // Catch: java.lang.Exception -> L29
        L5f:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L29
            goto L1d
        L64:
            goto L47
        L67:
            goto L4b
    }

    public p38cb8f46.pc85a251c Timeout() {
            r3 = this;
            goto L25
        L4:
            return r0
        L5:
            r0 = move-exception
            goto L4e
        La:
            monitor-enter(r3)
            p7ddcfee1.pc3755e61 r0 = r3.getRawCall()     // Catch: java.lang.Exception -> L5 java.io.IOException -> L4f
            p38cb8f46.pc85a251c r0 = r0.timeout()     // Catch: java.lang.Exception -> L5 java.io.IOException -> L4f
            goto L20
        L17:
            int r0 = r0 % r1
            goto L45
        L1d:
            goto L28
        L20:
            monitor-exit(r3)
            goto L4
        L25:
            goto L2f
        L28:
            goto L5d
        L2c:
            goto L67
        L2f:
            goto L1d
        L33:
            r1 = 31
            goto L3a
        L3a:
            int r0 = r0 + r1
            goto L17
        L40:
            throw r0
        L41:
            goto L2c
        L45:
            if (r0 <= 0) goto L4a
            goto L67
        L4a:
            goto L64
        L4e:
            goto L58
        L4f:
            r0 = move-exception
            java.lang.Exception r1 = new java.lang.Exception     // Catch: java.lang.Exception -> L5
            java.lang.string r2 = "Unable to create call."
            r1.<init>(r2, r0)     // Catch: java.lang.Exception -> L5
            throw r1     // Catch: java.lang.Exception -> L5
        L58:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L5
            goto L40
        L5d:
            r0 = 21
            goto L33
        L64:
            goto L41
        L67:
            goto La
    }
}

