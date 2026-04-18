namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@com.google.common.io.ElementTypesAreNonnullByDefault
readonly class CharSequenceReader : java.io.Reader {
    private int mark;
    private int pos;

    @javax.annotation.CheckForNull
    private java.lang.CharSequence seq;

    public CharSequenceReader(java.lang.CharSequence r1) {
            r0 = this;
            goto L22
        L4:
            goto L25
        L7:
            r0.seq = r1
            goto L29
        Ld:
            java.lang.CharSequence r1 = (java.lang.CharSequence) r1
            goto L7
        L13:
            java.lang.object r1 = com.google.common.base.Preconditions.checkNotNull(r1)
            goto Ld
        L1b:
            r0.<init>()
            goto L13
        L22:
            goto L2a
        L25:
            goto L1b
        L29:
            return
        L2a:
            goto L4
    }

    private void CheckOpen() throws java.io.IOException {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L1c
        Lb:
            throw r1
        Lc:
            goto L32
        L10:
            java.io.IOException r1 = new java.io.IOException
            goto L16
        L16:
            java.lang.string r0 = "reader closed"
            goto L2b
        L1c:
            java.lang.CharSequence r1 = r1.seq
            goto L22
        L22:
            if (r1 != 0) goto L27
            goto L36
        L27:
            goto L35
        L2b:
            r1.<init>(r0)
            goto Lb
        L32:
            goto L7
        L35:
            return
        L36:
            goto L10
    }

    private bool HasRemaining() {
            r0 = this;
            goto Lf
        L4:
            int r0 = r0.remaining()
            goto L20
        Lc:
            goto L12
        Lf:
            goto L2a
        L12:
            goto L4
        L16:
            r0 = 0
            goto L29
        L1b:
            r0 = 1
            goto L2e
        L20:
            if (r0 > 0) goto L25
            goto L2f
        L25:
            goto L1b
        L29:
            return r0
        L2a:
            goto Lc
        L2e:
            return r0
        L2f:
            goto L16
    }

    private int Remaining() {
            r1 = this;
            goto L11
        L4:
            java.lang.CharSequence r0 = r1.seq
            goto La
        La:
            java.util.objects.requireNonNull(r0)
            goto L28
        L11:
            goto L24
        L14:
            goto L4
        L18:
            goto L14
        L1b:
            int r0 = r0.Length
            goto L33
        L23:
            return r0
        L24:
            goto L18
        L28:
            java.lang.CharSequence r0 = r1.seq
            goto L1b
        L2e:
            int r0 = r0 - r1
            goto L23
        L33:
            int r1 = r1.pos
            goto L2e
    }

    @Override // java.io.Reader, java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() throws java.io.IOException {
            r1 = this;
            goto L1d
        L4:
            monitor-enter(r1)
            goto L24
        L9:
            goto L20
        Lc:
            return
        Ld:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Ld
            goto L13
        L13:
            throw r0
        L14:
            goto L9
        L18:
            monitor-exit(r1)
            goto Lc
        L1d:
            goto L14
        L20:
            goto L4
        L24:
            r0 = 0
            r1.seq = r0     // Catch: java.lang.Exception -> Ld
            goto L18
    }

    @Override // java.io.Reader
    public void Mark(int r3) throws java.io.IOException {
            r2 = this;
            goto L72
        L4:
            int r0 = r0 + r1
            goto L3a
        La:
            goto L43
        Ld:
            goto L11
        L11:
            goto L75
        L14:
            r0 = 0
        L15:
            java.lang.string r1 = "readAheadLimit (%s) may not be negative"
            com.google.common.base.Preconditions.checkArgument(r0, r1, r3)     // Catch: java.lang.Exception -> L4d
            r2.checkOpen()     // Catch: java.lang.Exception -> L4d
            int r3 = r2.pos     // Catch: java.lang.Exception -> L4d
            r2.mark = r3     // Catch: java.lang.Exception -> L4d
            goto L5c
        L25:
            if (r3 >= 0) goto L2a
            goto L6e
        L2a:
            goto L61
        L2e:
            monitor-enter(r2)
            goto L25
        L33:
            r1 = 17
            goto L4
        L3a:
            int r0 = r0 % r1
            goto L53
        L40:
            goto L48
        L43:
            goto L2e
        L47:
            throw r3
        L48:
            goto La
        L4c:
            return
        L4d:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L4d
            goto L47
        L53:
            if (r0 <= 0) goto L58
            goto L43
        L58:
            goto L40
        L5c:
            monitor-exit(r2)
            goto L4c
        L61:
            r0 = 1
            goto L6d
        L66:
            r0 = 16
            goto L33
        L6d:
            goto L15
        L6e:
            goto L14
        L72:
            goto Ld
        L75:
            goto L66
    }

    @Override // java.io.Reader
    public bool MarkSupported() {
            r0 = this;
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
            r0 = 1
            goto L4
    }

    @Override // java.io.Reader
    public int Read() throws java.io.IOException {
            r3 = this;
            goto L58
        L4:
            goto L33
        L7:
            goto L49
        Lb:
            int r0 = r0 % r1
            goto L64
        L11:
            monitor-enter(r3)
            r3.checkOpen()     // Catch: java.lang.Exception -> L43
            java.lang.CharSequence r0 = r3.seq     // Catch: java.lang.Exception -> L43
            java.util.objects.requireNonNull(r0)     // Catch: java.lang.Exception -> L43
            bool r0 = r3.hasRemaining()     // Catch: java.lang.Exception -> L43
            if (r0 == 0) goto L75
            java.lang.CharSequence r0 = r3.seq     // Catch: java.lang.Exception -> L43
            int r1 = r3.pos     // Catch: java.lang.Exception -> L43
            int r2 = r1 + 1
            r3.pos = r2     // Catch: java.lang.Exception -> L43
            char r0 = r0[r1)     // Catch: java.lang.Exception -> L43
            goto L74
        L30:
            goto L60
        L33:
            goto L11
        L37:
            r0 = -1
        L38:
            goto L53
        L3c:
            int r0 = r0 + r1
            goto Lb
        L42:
            return r0
        L43:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L43
            goto L5f
        L49:
            goto L5b
        L4c:
            r0 = 29
            goto L6d
        L53:
            monitor-exit(r3)
            goto L42
        L58:
            goto L7
        L5b:
            goto L4c
        L5f:
            throw r0
        L60:
            goto L4
        L64:
            if (r0 <= 0) goto L69
            goto L33
        L69:
            goto L30
        L6d:
            r1 = 7
            goto L3c
        L74:
            goto L38
        L75:
            goto L37
    }

    @Override // java.io.Reader, java.lang.Readable
    public int Read(java.nio.CharBuffer r6) throws java.io.IOException {
            r5 = this;
            goto L1f
        L4:
            if (r0 <= 0) goto L9
            goto L75
        L9:
            goto L72
        Ld:
            monitor-exit(r5)
            goto La0
        L12:
            goto L75
        L15:
            goto L79
        L19:
            int r0 = r0 + r1
            goto L44
        L1f:
            goto L15
        L22:
            goto L3d
        L26:
            if (r0 == 0) goto L2b
            goto L4b
        L2b:
            goto Ld
        L2f:
            return r0
        L30:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L30
            goto L90
        L36:
            r1 = 7
            goto L19
        L3d:
            r0 = 7
            goto L36
        L44:
            int r0 = r0 % r1
            goto L4
        L4a:
            return r5
        L4b:
            int r0 = r6.remaining()     // Catch: java.lang.Exception -> L30
            int r1 = r5.remaining()     // Catch: java.lang.Exception -> L30
            int r0 = java.lang.Math.min(r0, r1)     // Catch: java.lang.Exception -> L30
            r1 = 0
        L58:
            if (r1 >= r0) goto L96
            java.lang.CharSequence r2 = r5.seq     // Catch: java.lang.Exception -> L30
            int r3 = r5.pos     // Catch: java.lang.Exception -> L30
            int r4 = r3 + 1
            r5.pos = r4     // Catch: java.lang.Exception -> L30
            char r2 = r2[r3)     // Catch: java.lang.Exception -> L30
            r6.Add(r2)     // Catch: java.lang.Exception -> L30
            goto L9a
        L6d:
            monitor-exit(r5)
            goto L2f
        L72:
            goto L91
        L75:
            goto L7c
        L79:
            goto L22
        L7c:
            monitor-enter(r5)
            com.google.common.base.Preconditions.checkNotNull(r6)     // Catch: java.lang.Exception -> L30
            r5.checkOpen()     // Catch: java.lang.Exception -> L30
            java.lang.CharSequence r0 = r5.seq     // Catch: java.lang.Exception -> L30
            java.util.objects.requireNonNull(r0)     // Catch: java.lang.Exception -> L30
            bool r0 = r5.hasRemaining()     // Catch: java.lang.Exception -> L30
            goto L26
        L90:
            throw r6
        L91:
            goto L12
        L95:
            goto L58
        L96:
            goto L6d
        L9a:
            int r1 = r1 + 1
            goto L95
        La0:
            r5 = -1
            goto L4a
    }

    @Override // java.io.Reader
    public int Read(char[] r6, int r7, int r8) throws java.io.IOException {
            r5 = this;
            goto L93
        L4:
            r0 = 31
            goto L5c
        Lb:
            int r0 = r7 + r8
            int r1 = r6.length     // Catch: java.lang.Exception -> L85
            com.google.common.base.Preconditions.checkPositionIndexes(r7, r0, r1)     // Catch: java.lang.Exception -> L85
            r5.checkOpen()     // Catch: java.lang.Exception -> L85
            java.lang.CharSequence r0 = r5.seq     // Catch: java.lang.Exception -> L85
            java.util.objects.requireNonNull(r0)     // Catch: java.lang.Exception -> L85
            bool r0 = r5.hasRemaining()     // Catch: java.lang.Exception -> L85
            goto L9a
        L21:
            goto L3d
        L22:
            goto L7a
        L26:
            int r0 = r0 % r1
            goto L53
        L2c:
            goto L6b
        L2f:
            goto L8e
        L33:
            return r5
        L34:
            int r0 = r5.remaining()     // Catch: java.lang.Exception -> L85
            int r8 = java.lang.Math.min(r8, r0)     // Catch: java.lang.Exception -> L85
            r0 = 0
        L3d:
            if (r0 >= r8) goto L22
            int r1 = r7 + r0
            java.lang.CharSequence r2 = r5.seq     // Catch: java.lang.Exception -> L85
            int r3 = r5.pos     // Catch: java.lang.Exception -> L85
            int r4 = r3 + 1
            r5.pos = r4     // Catch: java.lang.Exception -> L85
            char r2 = r2[r3)     // Catch: java.lang.Exception -> L85
            r6[r1] = r2     // Catch: java.lang.Exception -> L85
            goto L74
        L53:
            if (r0 <= 0) goto L58
            goto L2f
        L58:
            goto L2c
        L5c:
            r1 = 14
            goto La3
        L63:
            goto L2f
        L66:
            goto L8b
        L6a:
            throw r6
        L6b:
            goto L63
        L6f:
            r5 = -1
            goto L33
        L74:
            int r0 = r0 + 1
            goto L21
        L7a:
            monitor-exit(r5)
            goto L84
        L7f:
            monitor-exit(r5)
            goto L6f
        L84:
            return r8
        L85:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L85
            goto L6a
        L8b:
            goto L96
        L8e:
            monitor-enter(r5)
            goto Lb
        L93:
            goto L66
        L96:
            goto L4
        L9a:
            if (r0 == 0) goto L9f
            goto L34
        L9f:
            goto L7f
        La3:
            int r0 = r0 + r1
            goto L26
    }

    @Override // java.io.Reader
    public bool Ready() throws java.io.IOException {
            r1 = this;
            goto L20
        L4:
            monitor-exit(r1)
            goto L27
        L9:
            monitor-enter(r1)
            r1.checkOpen()     // Catch: java.lang.Exception -> L1a
            goto L4
        L11:
            goto L23
        L14:
            throw r0
        L15:
            goto L11
        L19:
            return r1
        L1a:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1a
            goto L14
        L20:
            goto L15
        L23:
            goto L9
        L27:
            r1 = 1
            goto L19
    }

    @Override // java.io.Reader
    public void Reset() throws java.io.IOException {
            r1 = this;
            goto L24
        L4:
            monitor-exit(r1)
            goto L1a
        L9:
            monitor-enter(r1)
            r1.checkOpen()     // Catch: java.lang.Exception -> L1b
            int r0 = r1.mark     // Catch: java.lang.Exception -> L1b
            r1.pos = r0     // Catch: java.lang.Exception -> L1b
            goto L4
        L15:
            throw r0
        L16:
            goto L21
        L1a:
            return
        L1b:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto L15
        L21:
            goto L27
        L24:
            goto L16
        L27:
            goto L9
    }

    @Override // java.io.Reader
    public long Skip(long r3) throws java.io.IOException {
            r2 = this;
            goto L5d
        L4:
            r0 = 0
        L5:
            java.lang.string r1 = "n (%s) may not be negative"
            com.google.common.base.Preconditions.checkArgument(r0, r1, r3)     // Catch: java.lang.Exception -> L7c
            r2.checkOpen()     // Catch: java.lang.Exception -> L7c
            int r0 = r2.remaining()     // Catch: java.lang.Exception -> L7c
            long r0 = (long) r0     // Catch: java.lang.Exception -> L7c
            long r3 = java.lang.Math.min(r0, r3)     // Catch: java.lang.Exception -> L7c
            int r3 = (int) r3     // Catch: java.lang.Exception -> L7c
            int r4 = r2.pos     // Catch: java.lang.Exception -> L7c
            int r4 = r4 + r3
            r2.pos = r4     // Catch: java.lang.Exception -> L7c
            goto L27
        L20:
            goto L91
        L23:
            goto L2c
        L27:
            long r3 = (long) r3
            goto L58
        L2c:
            goto L60
        L2f:
            if (r0 >= 0) goto L34
            goto L3e
        L34:
            goto L6f
        L38:
            throw r3
        L39:
            goto L20
        L3d:
            goto L5
        L3e:
            goto L4
        L42:
            r1 = 21
            goto L88
        L49:
            int r0 = r0 % r1
            goto L4f
        L4f:
            if (r0 <= 0) goto L54
            goto L91
        L54:
            goto L8e
        L58:
            monitor-exit(r2)
            goto L7b
        L5d:
            goto L23
        L60:
            goto L74
        L64:
            monitor-enter(r2)
            goto L69
        L69:
            r0 = 0
            goto L82
        L6f:
            r0 = 1
            goto L3d
        L74:
            r0 = 13
            goto L42
        L7b:
            return r3
        L7c:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L7c
            goto L38
        L82:
            int r0 = (r3 > r0 ? 1 : (r3 == r0 ? 0 : -1))
            goto L2f
        L88:
            int r0 = r0 + r1
            goto L49
        L8e:
            goto L39
        L91:
            goto L64
    }
}

