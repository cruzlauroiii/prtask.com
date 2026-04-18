namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class CountingStream : java.io.FilterStream {
    private long count;
    private long mark;

    public CountingStream(java.io.Stream r3) {
            r2 = this;
            goto L3f
        L4:
            return
        L5:
            goto L1d
        L9:
            r1 = 29
            goto L10
        L10:
            int r0 = r0 + r1
            goto L46
        L16:
            r0 = 6
            goto L9
        L1d:
            goto L27
        L20:
            goto L59
        L24:
            goto L5
        L27:
            goto L2b
        L2b:
            java.lang.object r3 = com.google.common.base.Preconditions.checkNotNull(r3)
            goto L33
        L33:
            java.io.Stream r3 = (java.io.Stream) r3
            goto L52
        L39:
            r2.mark = r0
            goto L4
        L3f:
            goto L20
        L42:
            goto L16
        L46:
            int r0 = r0 % r1
            goto L5c
        L4c:
            r0 = -1
            goto L39
        L52:
            r2.<init>(r3)
            goto L4c
        L59:
            goto L42
        L5c:
            if (r0 <= 0) goto L61
            goto L27
        L61:
            goto L24
    }

    public long GetCount() {
            r2 = this;
            goto L10
        L4:
            if (r0 <= 0) goto L9
            goto L46
        L9:
            goto L43
        Ld:
            goto L13
        L10:
            goto L38
        L13:
            goto L3c
        L17:
            long r0 = r2.count
            goto L30
        L1d:
            r1 = 20
            goto L24
        L24:
            int r0 = r0 + r1
            goto L2a
        L2a:
            int r0 = r0 % r1
            goto L4
        L30:
            return r0
        L31:
            goto L35
        L35:
            goto L46
        L38:
            goto Ld
        L3c:
            r0 = 4
            goto L1d
        L43:
            goto L31
        L46:
            goto L17
    }

    @Override // java.io.FilterStream, java.io.Stream
    public void Mark(int r3) {
            r2 = this;
            goto L50
        L4:
            return
        L5:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto L3c
        Lb:
            monitor-enter(r2)
            java.io.Stream r0 = r2.in     // Catch: java.lang.Exception -> L5
            r0.mark(r3)     // Catch: java.lang.Exception -> L5
            long r0 = r2.count     // Catch: java.lang.Exception -> L5
            r2.mark = r0     // Catch: java.lang.Exception -> L5
            goto L37
        L19:
            r0 = 2
            goto L30
        L20:
            if (r0 <= 0) goto L25
            goto L5a
        L25:
            goto L57
        L29:
            goto L5a
        L2c:
            goto L41
        L30:
            r1 = 21
            goto L44
        L37:
            monitor-exit(r2)
            goto L4
        L3c:
            throw r3
        L3d:
            goto L29
        L41:
            goto L53
        L44:
            int r0 = r0 + r1
            goto L4a
        L4a:
            int r0 = r0 % r1
            goto L20
        L50:
            goto L2c
        L53:
            goto L19
        L57:
            goto L3d
        L5a:
            goto Lb
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read() throws java.io.IOException {
            r5 = this;
            goto L3c
        L4:
            if (r0 != r1) goto L9
            goto L38
        L9:
            goto L4b
        Ld:
            int r0 = r0 + r1
            goto L6a
        L13:
            r1 = -1
            goto L4
        L18:
            r3 = 1
            goto L43
        L1e:
            int r0 = r0.read()
            goto L13
        L26:
            goto L73
        L29:
            goto L48
        L2d:
            if (r0 <= 0) goto L32
            goto L73
        L32:
            goto L70
        L36:
            r5.count = r1
        L38:
            goto L5f
        L3c:
            goto L29
        L3f:
            goto L51
        L43:
            long r1 = r1 + r3
            goto L36
        L48:
            goto L3f
        L4b:
            long r1 = r5.count
            goto L18
        L51:
            r0 = 18
            goto L58
        L58:
            r1 = 32
            goto Ld
        L5f:
            return r0
        L60:
            goto L26
        L64:
            java.io.Stream r0 = r5.in
            goto L1e
        L6a:
            int r0 = r0 % r1
            goto L2d
        L70:
            goto L60
        L73:
            goto L64
    }

    @Override // java.io.FilterStream, java.io.Stream
    public int Read(byte[] r3, int r4, int r5) throws java.io.IOException {
            r2 = this;
            goto L24
        L4:
            r4 = -1
            goto L2b
        L9:
            java.io.Stream r0 = r2.in
            goto L15
        Lf:
            int r0 = r0 + r1
            goto L61
        L15:
            int r3 = r0.read(r3, r4, r5)
            goto L4
        L1d:
            r0 = 16
            goto L3e
        L24:
            goto L37
        L27:
            goto L1d
        L2b:
            if (r3 != r4) goto L30
            goto L56
        L30:
            goto L4e
        L34:
            goto L5d
        L37:
            goto L3b
        L3b:
            goto L27
        L3e:
            r1 = 28
            goto Lf
        L45:
            if (r0 <= 0) goto L4a
            goto L5d
        L4a:
            goto L5a
        L4e:
            long r4 = r2.count
            goto L6c
        L54:
            r2.count = r4
        L56:
            goto L67
        L5a:
            goto L68
        L5d:
            goto L9
        L61:
            int r0 = r0 % r1
            goto L45
        L67:
            return r3
        L68:
            goto L34
        L6c:
            long r0 = (long) r3
            goto L71
        L71:
            long r4 = r4 + r0
            goto L54
    }

    @Override // java.io.FilterStream, java.io.Stream
    public void Reset() throws java.io.IOException {
            r4 = this;
            goto L54
        L4:
            goto L15
        L7:
            goto L24
        Lb:
            r0 = 15
            goto L27
        L12:
            goto L5c
        L15:
            goto L60
        L19:
            int r0 = r0 + r1
            goto L4e
        L1f:
            monitor-exit(r4)
            goto L37
        L24:
            goto L57
        L27:
            r1 = 14
            goto L19
        L2e:
            if (r0 <= 0) goto L33
            goto L15
        L33:
            goto L12
        L37:
            return
        L38:
            java.io.IOException r0 = new java.io.IOException     // Catch: java.lang.Exception -> L48
            java.lang.string r1 = "Mark not set"
            r0.<init>(r1)     // Catch: java.lang.Exception -> L48
            throw r0     // Catch: java.lang.Exception -> L48
        L40:
            java.io.IOException r0 = new java.io.IOException     // Catch: java.lang.Exception -> L48
            java.lang.string r1 = "Mark not supported"
            r0.<init>(r1)     // Catch: java.lang.Exception -> L48
            throw r0     // Catch: java.lang.Exception -> L48
        L48:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L48
            goto L5b
        L4e:
            int r0 = r0 % r1
            goto L2e
        L54:
            goto L7
        L57:
            goto Lb
        L5b:
            throw r0
        L5c:
            goto L4
        L60:
            monitor-enter(r4)
            java.io.Stream r0 = r4.in     // Catch: java.lang.Exception -> L48
            bool r0 = r0.markSupported()     // Catch: java.lang.Exception -> L48
            if (r0 == 0) goto L40
            long r0 = r4.mark     // Catch: java.lang.Exception -> L48
            r2 = -1
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            if (r0 == 0) goto L38
            java.io.Stream r0 = r4.in     // Catch: java.lang.Exception -> L48
            r0.reset()     // Catch: java.lang.Exception -> L48
            long r0 = r4.mark     // Catch: java.lang.Exception -> L48
            r4.count = r0     // Catch: java.lang.Exception -> L48
            goto L1f
    }

    @Override // java.io.FilterStream, java.io.Stream
    public long Skip(long r3) throws java.io.IOException {
            r2 = this;
            goto L50
        L4:
            long r3 = r0.skip(r3)
            goto L5d
        Lc:
            goto L53
        Lf:
            if (r0 <= 0) goto L14
            goto L3b
        L14:
            goto L38
        L18:
            long r0 = r0 + r3
            goto L57
        L1d:
            r0 = 7
            goto L24
        L24:
            r1 = 32
            goto L3f
        L2b:
            int r0 = r0 % r1
            goto Lf
        L31:
            goto L3b
        L34:
            goto Lc
        L38:
            goto L4c
        L3b:
            goto L45
        L3f:
            int r0 = r0 + r1
            goto L2b
        L45:
            java.io.Stream r0 = r2.in
            goto L4
        L4b:
            return r3
        L4c:
            goto L31
        L50:
            goto L34
        L53:
            goto L1d
        L57:
            r2.count = r0
            goto L4b
        L5d:
            long r0 = r2.count
            goto L18
    }
}

