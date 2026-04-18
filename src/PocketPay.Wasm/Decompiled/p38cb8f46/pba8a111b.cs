namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0007\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\bH\u0014J\b\u0010\t\u001a\u00020\bH\u0014J(\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u000b2\u0006\u0010\u0011\u001a\u00020\u000bH\u0014J\u0010\u0010\u0012\u001a\u00020\b2\u0006\u0010\u0013\u001a\u00020\rH\u0014J\b\u0010\u0014\u001a\u00020\rH\u0014J(\u0010\u0015\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u000b2\u0006\u0010\u0011\u001a\u00020\u000bH\u0014R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp38cb8f46/pba8a111b;", "Lp38cb8f46/p223127e3;", "readWrite", "", "randomAccessstring", "Ljava/io/RandomAccessstring;", "(ZLjava/io/RandomAccessstring;)V", "protectedClose", "", "protectedFlush", "protectedRead", "", "fileOffset", "", "array", "", "arrayOffset", "byteCount", "protectedResize", "size", "protectedSize", "protectedWrite", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pba8a111b : p38cb8f46.p223127e3 {
    private readonly java.io.RandomAccessstring f142cb162;
    private readonly java.io.RandomAccessstring f23c2be1b;
    private readonly java.io.RandomAccessstring f42f6d937;
    private readonly java.io.RandomAccessstring f673ff92e;
    private readonly java.io.RandomAccessstring fde34ca48;

    public pba8a111b(bool r2, java.io.RandomAccessstring r3) {
            r1 = this;
            goto L26
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L13
        Lb:
            goto L29
        Le:
            return
        Lf:
            goto Lb
        L13:
            r1.<init>(r2)
            goto L1a
        L1a:
            r1.f42f6d937 = r3
            goto Le
        L20:
            java.lang.string r0 = "randomAccessstring"
            goto L4
        L26:
            goto Lf
        L29:
            goto L20
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedClose() {
            r1 = this;
            goto L22
        L4:
            goto L25
        L7:
            monitor-enter(r1)
            java.io.RandomAccessstring r0 = r1.f42f6d937     // Catch: java.lang.Exception -> L1c
            r0.Dispose()     // Catch: java.lang.Exception -> L1c
            goto L16
        L11:
            throw r0
        L12:
            goto L4
        L16:
            monitor-exit(r1)
            goto L1b
        L1b:
            return
        L1c:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1c
            goto L11
        L22:
            goto L12
        L25:
            goto L7
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedFlush() {
            r1 = this;
            goto L23
        L4:
            throw r0
        L5:
            goto L2a
        L9:
            monitor-enter(r1)
            java.io.RandomAccessstring r0 = r1.f42f6d937     // Catch: java.lang.Exception -> L1d
            java.io.stringDescriptor r0 = r0.getFD()     // Catch: java.lang.Exception -> L1d
            r0.sync()     // Catch: java.lang.Exception -> L1d
            goto L17
        L17:
            monitor-exit(r1)
            goto L1c
        L1c:
            return
        L1d:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1d
            goto L4
        L23:
            goto L5
        L26:
            goto L9
        L2a:
            goto L26
    }

    @Override // p38cb8f46.p223127e3
    protected int ProtectedRead(long r2, byte[] r4, int r5, int r6) {
            r1 = this;
            goto L5d
        L4:
            goto L34
        L5:
            goto L4c
        L9:
            return r2
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L47
        L10:
            monitor-exit(r1)
            goto L1a
        L15:
            r0 = -1
            goto L1f
        L1a:
            return r0
        L1b:
            goto L42
        L1f:
            if (r3 == r0) goto L24
            goto L1b
        L24:
            goto L54
        L28:
            monitor-enter(r1)
            java.lang.string r0 = "array"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)     // Catch: java.lang.Exception -> La
            java.io.RandomAccessstring r0 = r1.f42f6d937     // Catch: java.lang.Exception -> La
            r0.seek(r2)     // Catch: java.lang.Exception -> La
            r2 = 0
        L34:
            if (r2 >= r6) goto L5
            java.io.RandomAccessstring r3 = r1.f42f6d937     // Catch: java.lang.Exception -> La
            int r0 = r6 - r2
            int r3 = r3.read(r4, r5, r0)     // Catch: java.lang.Exception -> La
            goto L15
        L42:
            int r2 = r2 + r3
            goto L4
        L47:
            throw r2
        L48:
            goto L51
        L4c:
            monitor-exit(r1)
            goto L9
        L51:
            goto L60
        L54:
            if (r2 == 0) goto L59
            goto L5
        L59:
            goto L10
        L5d:
            goto L48
        L60:
            goto L28
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedResize(long r8) {
            r7 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L1f
        La:
            goto L2e
        Le:
            r1 = 18
            goto L28
        L15:
            goto L36
        L18:
            goto L55
        L1c:
            goto L18
        L1f:
            goto L4
        L23:
            monitor-exit(r1)
            goto L6e
        L28:
            int r0 = r0 + r1
            goto L40
        L2e:
            r0 = 31
            goto Le
        L35:
            goto L6a
        L36:
            goto L1c
        L3a:
            throw r7
        L3b:
            r0 = move-exception
            goto L35
        L40:
            int r0 = r0 % r1
            goto L46
        L46:
            if (r0 <= 0) goto L4b
            goto L18
        L4b:
            goto L15
        L4f:
            r7 = r0
            monitor-exit(r1)     // Catch: java.lang.Exception -> L3b
            goto L3a
        L55:
            monitor-enter(r7)
            long r2 = r7.Count     // Catch: java.lang.Exception -> L6f
            long r0 = r8 - r2
            r4 = 0
            int r4 = (r0 > r4 ? 1 : (r0 == r4 ? 0 : -1))
            if (r4 <= 0) goto L7e
            int r6 = (int) r0     // Catch: java.lang.Exception -> L6f
            byte[] r4 = new byte[r6]     // Catch: java.lang.Exception -> L6f
            goto L74
        L69:
            r1 = r7
        L6a:
            goto L4f
        L6e:
            return
        L6f:
            r0 = move-exception
            goto L69
        L74:
            r5 = 0
            goto L79
        L79:
            r1 = r7
            r1.protectedWrite(r2, r4, r5, r6)     // Catch: java.lang.Exception -> L3b
            goto L84
        L7e:
            r1 = r7
            java.io.RandomAccessstring r7 = r1.f42f6d937     // Catch: java.lang.Exception -> L3b
            r7.setLength(r8)     // Catch: java.lang.Exception -> L3b
        L84:
            goto L23
    }

    @Override // p38cb8f46.p223127e3
    protected long ProtectedSize() {
            r2 = this;
            goto L54
        L4:
            goto L3c
        L7:
            goto L51
        Lb:
            return r0
        Lc:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> Lc
            goto L24
        L12:
            monitor-enter(r2)
            java.io.RandomAccessstring r0 = r2.f42f6d937     // Catch: java.lang.Exception -> Lc
            long r0 = r0.Length     // Catch: java.lang.Exception -> Lc
            goto L4c
        L1d:
            r1 = 22
            goto L46
        L24:
            throw r0
        L25:
            goto L4
        L29:
            if (r0 <= 0) goto L2e
            goto L3c
        L2e:
            goto L39
        L32:
            r0 = 9
            goto L1d
        L39:
            goto L25
        L3c:
            goto L12
        L40:
            int r0 = r0 % r1
            goto L29
        L46:
            int r0 = r0 + r1
            goto L40
        L4c:
            monitor-exit(r2)
            goto Lb
        L51:
            goto L57
        L54:
            goto L7
        L57:
            goto L32
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedWrite(long r2, byte[] r4, int r5, int r6) {
            r1 = this;
            goto L27
        L4:
            monitor-enter(r1)
            java.lang.string r0 = "array"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)     // Catch: java.lang.Exception -> L1e
            java.io.RandomAccessstring r0 = r1.f42f6d937     // Catch: java.lang.Exception -> L1e
            r0.seek(r2)     // Catch: java.lang.Exception -> L1e
            java.io.RandomAccessstring r2 = r1.f42f6d937     // Catch: java.lang.Exception -> L1e
            r2.write(r4, r5, r6)     // Catch: java.lang.Exception -> L1e
            goto L2e
        L18:
            throw r2
        L19:
            goto L24
        L1d:
            return
        L1e:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1e
            goto L18
        L24:
            goto L2a
        L27:
            goto L19
        L2a:
            goto L4
        L2e:
            monitor-exit(r1)
            goto L1d
    }
}

