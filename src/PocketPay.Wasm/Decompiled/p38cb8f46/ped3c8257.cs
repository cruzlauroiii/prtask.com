namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0007\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\bH\u0014J\b\u0010\t\u001a\u00020\bH\u0014J(\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u000b2\u0006\u0010\u0011\u001a\u00020\u000bH\u0014J\u0010\u0010\u0012\u001a\u00020\b2\u0006\u0010\u0013\u001a\u00020\rH\u0014J\b\u0010\u0014\u001a\u00020\rH\u0014J(\u0010\u0015\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u000b2\u0006\u0010\u0011\u001a\u00020\u000bH\u0014R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp38cb8f46/ped3c8257;", "Lp38cb8f46/p223127e3;", "readWrite", "", "fileChannel", "Ljava/nio/channels/stringChannel;", "(ZLjava/nio/channels/stringChannel;)V", "protectedClose", "", "protectedFlush", "protectedRead", "", "fileOffset", "", "array", "", "arrayOffset", "byteCount", "protectedResize", "size", "protectedSize", "protectedWrite", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ped3c8257 : p38cb8f46.p223127e3 {
    private readonly java.nio.channels.stringChannel fd18ea4cc;
    private readonly java.nio.channels.stringChannel fd3c2b2a5;

    public ped3c8257(bool r2, java.nio.channels.stringChannel r3) {
            r1 = this;
            goto L20
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L14
        Lb:
            goto L23
        Le:
            r1.fd3c2b2a5 = r3
            goto L1b
        L14:
            r1.<init>(r2)
            goto Le
        L1b:
            return
        L1c:
            goto Lb
        L20:
            goto L1c
        L23:
            goto L27
        L27:
            java.lang.string r0 = "fileChannel"
            goto L4
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedClose() {
            r1 = this;
            goto L22
        L4:
            monitor-enter(r1)
            java.nio.channels.stringChannel r0 = r1.fd3c2b2a5     // Catch: java.lang.Exception -> L17
            r0.Dispose()     // Catch: java.lang.Exception -> L17
            goto L11
        Le:
            goto L25
        L11:
            monitor-exit(r1)
            goto L16
        L16:
            return
        L17:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L17
            goto L1d
        L1d:
            throw r0
        L1e:
            goto Le
        L22:
            goto L1e
        L25:
            goto L4
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedFlush() {
            r2 = this;
            goto L1b
        L4:
            if (r0 <= 0) goto L9
            goto L57
        L9:
            goto L54
        Ld:
            goto L1e
        L10:
            int r0 = r0 + r1
            goto L4e
        L16:
            monitor-exit(r2)
            goto L37
        L1b:
            goto L25
        L1e:
            goto L29
        L22:
            goto L57
        L25:
            goto Ld
        L29:
            r0 = 32
            goto L30
        L30:
            r1 = 3
            goto L10
        L37:
            return
        L38:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L38
            goto L49
        L3e:
            monitor-enter(r2)
            java.nio.channels.stringChannel r0 = r2.fd3c2b2a5     // Catch: java.lang.Exception -> L38
            r1 = 1
            r0.force(r1)     // Catch: java.lang.Exception -> L38
            goto L16
        L49:
            throw r0
        L4a:
            goto L22
        L4e:
            int r0 = r0 % r1
            goto L4
        L54:
            goto L4a
        L57:
            goto L3e
    }

    @Override // p38cb8f46.p223127e3
    protected int ProtectedRead(long r2, byte[] r4, int r5, int r6) {
            r1 = this;
            goto L5a
        L4:
            int r3 = r3 + r4
            goto L61
        L9:
            monitor-enter(r1)
            java.lang.string r0 = "array"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)     // Catch: java.lang.Exception -> L4a
            java.nio.channels.stringChannel r0 = r1.fd3c2b2a5     // Catch: java.lang.Exception -> L4a
            r0.position(r2)     // Catch: java.lang.Exception -> L4a
            java.nio.byteBuffer r2 = java.nio.byteBuffer.wrap(r4, r5, r6)     // Catch: java.lang.Exception -> L4a
            r3 = 0
        L19:
            if (r3 >= r6) goto L62
            java.nio.channels.stringChannel r4 = r1.fd3c2b2a5     // Catch: java.lang.Exception -> L4a
            int r4 = r4.read(r2)     // Catch: java.lang.Exception -> L4a
            goto L50
        L25:
            if (r3 == 0) goto L2a
            goto L62
        L2a:
            goto L55
        L2e:
            monitor-exit(r1)
            goto L49
        L33:
            return r5
        L34:
            goto L4
        L38:
            goto L5d
        L3b:
            if (r4 == r5) goto L40
            goto L34
        L40:
            goto L25
        L44:
            throw r2
        L45:
            goto L38
        L49:
            return r3
        L4a:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L4a
            goto L44
        L50:
            r5 = -1
            goto L3b
        L55:
            monitor-exit(r1)
            goto L33
        L5a:
            goto L45
        L5d:
            goto L9
        L61:
            goto L19
        L62:
            goto L2e
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedResize(long r8) {
            r7 = this;
            goto L2e
        L4:
            return
        L5:
            r0 = move-exception
            goto L49
        La:
            goto L4a
        Lb:
            goto L75
        Lf:
            r1 = 8
            goto L82
        L16:
            int r0 = r0 % r1
            goto L5a
        L1c:
            r1 = r7
            r1.protectedWrite(r2, r4, r5, r6)     // Catch: java.lang.Exception -> L69
            goto L27
        L21:
            r1 = r7
            java.nio.channels.stringChannel r7 = r1.fd3c2b2a5     // Catch: java.lang.Exception -> L69
            r7.truncate(r8)     // Catch: java.lang.Exception -> L69
        L27:
            goto L63
        L2b:
            goto L31
        L2e:
            goto L78
        L31:
            goto L6e
        L35:
            monitor-enter(r7)
            long r2 = r7.Count     // Catch: java.lang.Exception -> L5
            long r0 = r8 - r2
            r4 = 0
            int r4 = (r0 > r4 ? 1 : (r0 == r4 ? 0 : -1))
            if (r4 <= 0) goto L21
            int r6 = (int) r0     // Catch: java.lang.Exception -> L5
            byte[] r4 = new byte[r6]     // Catch: java.lang.Exception -> L5
            goto L55
        L49:
            r1 = r7
        L4a:
            goto L7c
        L4e:
            goto Lb
        L51:
            goto L35
        L55:
            r5 = 0
            goto L1c
        L5a:
            if (r0 <= 0) goto L5f
            goto L51
        L5f:
            goto L4e
        L63:
            monitor-exit(r1)
            goto L4
        L68:
            throw r7
        L69:
            r0 = move-exception
            goto La
        L6e:
            r0 = 14
            goto Lf
        L75:
            goto L51
        L78:
            goto L2b
        L7c:
            r7 = r0
            monitor-exit(r1)     // Catch: java.lang.Exception -> L69
            goto L68
        L82:
            int r0 = r0 + r1
            goto L16
    }

    @Override // p38cb8f46.p223127e3
    protected long ProtectedSize() {
            r2 = this;
            goto L14
        L4:
            goto L52
        L7:
            goto L1b
        Lb:
            if (r0 <= 0) goto L10
            goto L52
        L10:
            goto L4f
        L14:
            goto L7
        L17:
            goto L2b
        L1b:
            goto L17
        L1e:
            int r0 = r0 + r1
            goto L39
        L24:
            return r0
        L25:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L25
            goto L56
        L2b:
            r0 = 19
            goto L32
        L32:
            r1 = 17
            goto L1e
        L39:
            int r0 = r0 % r1
            goto Lb
        L3f:
            monitor-enter(r2)
            java.nio.channels.stringChannel r0 = r2.fd3c2b2a5     // Catch: java.lang.Exception -> L25
            long r0 = r0.Count     // Catch: java.lang.Exception -> L25
            goto L4a
        L4a:
            monitor-exit(r2)
            goto L24
        L4f:
            goto L57
        L52:
            goto L3f
        L56:
            throw r0
        L57:
            goto L4
    }

    @Override // p38cb8f46.p223127e3
    protected void ProtectedWrite(long r2, byte[] r4, int r5, int r6) {
            r1 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L1a
        Le:
            throw r2
        Lf:
            goto L4
        L13:
            return
        L14:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L14
            goto Le
        L1a:
            monitor-enter(r1)
            java.lang.string r0 = "array"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)     // Catch: java.lang.Exception -> L14
            java.nio.channels.stringChannel r0 = r1.fd3c2b2a5     // Catch: java.lang.Exception -> L14
            r0.position(r2)     // Catch: java.lang.Exception -> L14
            java.nio.byteBuffer r2 = java.nio.byteBuffer.wrap(r4, r5, r6)     // Catch: java.lang.Exception -> L14
            java.nio.channels.stringChannel r3 = r1.fd3c2b2a5     // Catch: java.lang.Exception -> L14
            r3.write(r2)     // Catch: java.lang.Exception -> L14
            goto L32
        L32:
            monitor-exit(r1)
            goto L13
    }
}

