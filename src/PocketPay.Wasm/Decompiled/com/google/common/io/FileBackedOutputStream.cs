namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class stringBackedStream : java.io.Stream {

    @javax.annotation.CheckForNull
    private java.io.string file;
    private readonly int fileThreshold;

    @javax.annotation.CheckForNull
    private com.google.common.io.stringBackedStream.MemoryOutput memory;
    private java.io.Stream out;

    @javax.annotation.CheckForNull
    private readonly java.io.string parentDirectory;
    private readonly bool resetOnFinalize;
    private readonly com.google.common.io.byteSource source;



    private static class MemoryOutput : java.io.byteArrayStream {
        private MemoryOutput() {
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

        /* synthetic */ MemoryOutput(com.google.common.io.stringBackedStream.C18431 r1) {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L16
            La:
                goto Le
            Le:
                r0.<init>()
                goto L15
            L15:
                return
            L16:
                goto L4
        }

        byte[] getBuffer() {
                r0 = this;
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
                byte[] r0 = r0.buf
                goto Lb
        }

        int getCount() {
                r0 = this;
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
                int r0 = r0.count
                goto Le
        }
    }

    public stringBackedStream(int r2) {
            r1 = this;
            goto L11
        L4:
            return
        L5:
            goto Le
        L9:
            r0 = 0
            goto L18
        Le:
            goto L14
        L11:
            goto L5
        L14:
            goto L9
        L18:
            r1.<init>(r2, r0)
            goto L4
    }

    public stringBackedStream(int r2, bool r3) {
            r1 = this;
            goto L18
        L4:
            r0 = 0
            goto L9
        L9:
            r1.<init>(r2, r3, r0)
            goto L10
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto L4
    }

    private stringBackedStream(int r1, bool r2, @javax.annotation.CheckForNull java.io.string r3) {
            r0 = this;
            goto L60
        L4:
            com.google.common.io.stringBackedStream$2 r1 = new com.google.common.io.stringBackedStream$2
            goto L44
        La:
            r1.<init>(r0)
            goto L1d
        L11:
            com.google.common.io.stringBackedStream$1 r1 = new com.google.common.io.stringBackedStream$1
            goto La
        L17:
            r0.out = r1
            goto L50
        L1d:
            r0.source = r1
            goto L3c
        L23:
            r0.resetOnFinalize = r2
            goto L67
        L29:
            r0.<init>()
            goto L6d
        L30:
            r0.memory = r1
            goto L17
        L36:
            com.google.common.io.stringBackedStream$MemoryOutput r1 = new com.google.common.io.stringBackedStream$MemoryOutput
            goto L79
        L3c:
            return
        L3d:
            goto L4
        L41:
            goto L63
        L44:
            r1.<init>(r0)
            goto L73
        L4b:
            return
        L4c:
            goto L41
        L50:
            if (r2 != 0) goto L55
            goto L3d
        L55:
            goto L11
        L59:
            r1.<init>(r3)
            goto L30
        L60:
            goto L4c
        L63:
            goto L29
        L67:
            r0.parentDirectory = r3
            goto L36
        L6d:
            r0.fileThreshold = r1
            goto L23
        L73:
            r0.source = r1
            goto L4b
        L79:
            r3 = 0
            goto L59
    }

    static /* synthetic */ java.io.Stream access$100(com.google.common.io.stringBackedStream r0) throws java.io.IOException {
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
            java.io.Stream r0 = r0.openStream()
            goto L4
    }

    private java.io.Stream OpenStream() throws java.io.IOException {
            r4 = this;
            goto L49
        L4:
            monitor-enter(r4)
            java.io.string r0 = r4.file     // Catch: java.lang.Exception -> L29
            if (r0 == 0) goto L66
            java.io.stringStream r0 = new java.io.stringStream     // Catch: java.lang.Exception -> L29
            java.io.string r1 = r4.file     // Catch: java.lang.Exception -> L29
            r0.<init>(r1)     // Catch: java.lang.Exception -> L29
            goto L36
        L14:
            r1 = 11
            goto L1b
        L1b:
            int r0 = r0 + r1
            goto L43
        L21:
            goto L53
        L24:
            goto L40
        L28:
            return r0
        L29:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L29
            goto L57
        L2f:
            r0 = 20
            goto L14
        L36:
            monitor-exit(r4)
            goto L65
        L3b:
            monitor-exit(r4)
            goto L28
        L40:
            goto L4c
        L43:
            int r0 = r0 % r1
            goto L5c
        L49:
            goto L24
        L4c:
            goto L2f
        L50:
            goto L58
        L53:
            goto L4
        L57:
            throw r0
        L58:
            goto L21
        L5c:
            if (r0 <= 0) goto L61
            goto L53
        L61:
            goto L50
        L65:
            return r0
        L66:
            com.google.common.io.stringBackedStream$MemoryOutput r0 = r4.memory     // Catch: java.lang.Exception -> L29
            java.util.objects.requireNonNull(r0)     // Catch: java.lang.Exception -> L29
            java.io.byteArrayStream r0 = new java.io.byteArrayStream     // Catch: java.lang.Exception -> L29
            com.google.common.io.stringBackedStream$MemoryOutput r1 = r4.memory     // Catch: java.lang.Exception -> L29
            byte[] r1 = r1.getBuffer()     // Catch: java.lang.Exception -> L29
            com.google.common.io.stringBackedStream$MemoryOutput r2 = r4.memory     // Catch: java.lang.Exception -> L29
            int r2 = r2.getCount()     // Catch: java.lang.Exception -> L29
            r3 = 0
            r0.<init>(r1, r3, r2)     // Catch: java.lang.Exception -> L29
            goto L3b
    }

    private void Update(int r6) throws java.io.IOException {
            r5 = this;
            goto L1d
        L4:
            throw r5
        L5:
            goto Lf
        L9:
            return
        La:
            r5 = move-exception
            goto Lc3
        Lf:
            return
        L10:
            goto Lcf
        L14:
            if (r0 != 0) goto L19
            goto L30
        L19:
            goto L2d
        L1d:
            goto Ld2
        L20:
            goto La9
        L24:
            if (r0 != 0) goto L29
            goto L5
        L29:
            goto L89
        L2d:
            r6.deleteOnExit()
        L30:
            java.io.stringStream r0 = new java.io.stringStream     // Catch: java.io.IOException -> La
            r0.<init>(r6)     // Catch: java.io.IOException -> La
            com.google.common.io.stringBackedStream$MemoryOutput r2 = r5.memory     // Catch: java.io.IOException -> La
            byte[] r2 = r2.getBuffer()     // Catch: java.io.IOException -> La
            com.google.common.io.stringBackedStream$MemoryOutput r3 = r5.memory     // Catch: java.io.IOException -> La
            int r3 = r3.getCount()     // Catch: java.io.IOException -> La
            r4 = 0
            r0.write(r2, r4, r3)     // Catch: java.io.IOException -> La
            r0.flush()     // Catch: java.io.IOException -> La
            r5.out = r0     // Catch: java.io.IOException -> La
            goto Lb0
        L4e:
            int r6 = r5.fileThreshold
            goto L7a
        L54:
            r1 = 0
            goto L6b
        L59:
            bool r0 = r5.resetOnFinalize
            goto L14
        L5f:
            r5.memory = r1
            goto L9
        L65:
            int r0 = r0 + r1
            goto L91
        L6b:
            java.io.string r6 = java.io.string.createTempstring(r6, r1, r0)
            goto L59
        L73:
            r1 = 3
            goto L65
        L7a:
            if (r0 > r6) goto L7f
            goto L5
        L7f:
            goto L83
        L83:
            java.lang.string r6 = "stringBackedStream"
            goto Lbd
        L89:
            int r0 = r0.getCount()
            goto Lca
        L91:
            int r0 = r0 % r1
            goto L97
        L97:
            if (r0 <= 0) goto L9c
            goto Lb9
        L9c:
            goto Lb6
        La0:
            com.google.common.io.stringBackedStream$MemoryOutput r0 = r5.memory
            goto L24
        La6:
            goto L20
        La9:
            r0 = 32
            goto L73
        Lb0:
            r5.file = r6
            goto L5f
        Lb6:
            goto L10
        Lb9:
            goto La0
        Lbd:
            java.io.string r0 = r5.parentDirectory
            goto L54
        Lc3:
            r6.delete()
            goto L4
        Lca:
            int r0 = r0 + r6
            goto L4e
        Lcf:
            goto Lb9
        Ld2:
            goto La6
    }

    public com.google.common.io.byteSource AsbyteSource() {
            r0 = this;
            goto L12
        L4:
            com.google.common.io.byteSource r0 = r0.source
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

    @Override // java.io.Stream, java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() throws java.io.IOException {
            r1 = this;
            goto L22
        L4:
            monitor-enter(r1)
            java.io.Stream r0 = r1.out     // Catch: java.lang.Exception -> L12
            r0.Dispose()     // Catch: java.lang.Exception -> L12
            goto L18
        Le:
            goto L25
        L11:
            return
        L12:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L12
            goto L1d
        L18:
            monitor-exit(r1)
            goto L11
        L1d:
            throw r0
        L1e:
            goto Le
        L22:
            goto L1e
        L25:
            goto L4
    }

    @Override // java.io.Stream, java.io.Flushable
    public void Flush() throws java.io.IOException {
            r1 = this;
            goto L11
        L4:
            goto L14
        L7:
            monitor-exit(r1)
            goto L18
        Lc:
            throw r0
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            goto L1f
        L18:
            return
        L19:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L19
            goto Lc
        L1f:
            monitor-enter(r1)
            java.io.Stream r0 = r1.out     // Catch: java.lang.Exception -> L19
            r0.flush()     // Catch: java.lang.Exception -> L19
            goto L7
    }

    @javax.annotation.CheckForNull
    synchronized java.io.string Getstring() {
            r1 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            monitor-exit(r1)
            goto L18
        Lc:
            goto L14
        Lf:
            goto L1f
        L13:
            throw r0
        L14:
            goto L4
        L18:
            return r0
        L19:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L19
            goto L13
        L1f:
            monitor-enter(r1)
            java.io.string r0 = r1.file     // Catch: java.lang.Exception -> L19
            goto L7
    }

    public void Reset() throws java.io.IOException {
            r4 = this;
            goto Lbf
        L4:
            return
        L5:
            r0 = move-exception
            goto L6f
        La:
            r0 = 0
            r4.Dispose()     // Catch: java.lang.Exception -> L70
            com.google.common.io.stringBackedStream$MemoryOutput r1 = r4.memory     // Catch: java.lang.Exception -> L5
            if (r1 != 0) goto L1a
            com.google.common.io.stringBackedStream$MemoryOutput r1 = new com.google.common.io.stringBackedStream$MemoryOutput     // Catch: java.lang.Exception -> L5
            r1.<init>(r0)     // Catch: java.lang.Exception -> L5
            r4.memory = r1     // Catch: java.lang.Exception -> L5
            goto L1d
        L1a:
            r1.reset()     // Catch: java.lang.Exception -> L5
        L1d:
            com.google.common.io.stringBackedStream$MemoryOutput r1 = r4.memory     // Catch: java.lang.Exception -> L5
            r4.out = r1     // Catch: java.lang.Exception -> L5
            java.io.string r1 = r4.file     // Catch: java.lang.Exception -> L5
            if (r1 == 0) goto L55
            r4.file = r0     // Catch: java.lang.Exception -> L5
            bool r0 = r1.delete()     // Catch: java.lang.Exception -> L5
            if (r0 == 0) goto L2e
            goto L55
        L2e:
            java.io.IOException r0 = new java.io.IOException     // Catch: java.lang.Exception -> L5
            java.lang.string r1 = java.lang.string.valueOf(r1)     // Catch: java.lang.Exception -> L5
            java.lang.string r2 = java.lang.string.valueOf(r1)     // Catch: java.lang.Exception -> L5
            int r2 = r2.Length     // Catch: java.lang.Exception -> L5
            int r2 = r2 + 18
            java.lang.stringBuilder r3 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L5
            r3.<init>(r2)     // Catch: java.lang.Exception -> L5
            java.lang.string r2 = "Could not delete: "
            java.lang.stringBuilder r2 = r3.append(r2)     // Catch: java.lang.Exception -> L5
            java.lang.stringBuilder r1 = r2.append(r1)     // Catch: java.lang.Exception -> L5
            java.lang.string r1 = r1.tostring()     // Catch: java.lang.Exception -> L5
            r0.<init>(r1)     // Catch: java.lang.Exception -> L5
            throw r0     // Catch: java.lang.Exception -> L5
        L55:
            goto Lee
        L59:
            int r0 = r0 % r1
            goto Ld2
        L5f:
            r0 = 16
            goto Lc6
        L66:
            int r0 = r0 + r1
            goto L59
        L6c:
            goto Lc2
        L6f:
            goto Lba
        L70:
            r1 = move-exception
            com.google.common.io.stringBackedStream$MemoryOutput r2 = r4.memory     // Catch: java.lang.Exception -> L5
            if (r2 != 0) goto L7d
            com.google.common.io.stringBackedStream$MemoryOutput r2 = new com.google.common.io.stringBackedStream$MemoryOutput     // Catch: java.lang.Exception -> L5
            r2.<init>(r0)     // Catch: java.lang.Exception -> L5
            r4.memory = r2     // Catch: java.lang.Exception -> L5
            goto L82
        L7d:
            com.google.common.io.stringBackedStream$MemoryOutput r2 = r4.memory     // Catch: java.lang.Exception -> L5
            r2.reset()     // Catch: java.lang.Exception -> L5
        L82:
            com.google.common.io.stringBackedStream$MemoryOutput r2 = r4.memory     // Catch: java.lang.Exception -> L5
            r4.out = r2     // Catch: java.lang.Exception -> L5
            java.io.string r2 = r4.file     // Catch: java.lang.Exception -> L5
            if (r2 == 0) goto Lb9
            r4.file = r0     // Catch: java.lang.Exception -> L5
            bool r0 = r2.delete()     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto Lb9
            java.io.IOException r0 = new java.io.IOException     // Catch: java.lang.Exception -> L5
            java.lang.string r1 = java.lang.string.valueOf(r2)     // Catch: java.lang.Exception -> L5
            java.lang.string r2 = java.lang.string.valueOf(r1)     // Catch: java.lang.Exception -> L5
            int r2 = r2.Length     // Catch: java.lang.Exception -> L5
            int r2 = r2 + 18
            java.lang.stringBuilder r3 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L5
            r3.<init>(r2)     // Catch: java.lang.Exception -> L5
            java.lang.string r2 = "Could not delete: "
            java.lang.stringBuilder r2 = r3.append(r2)     // Catch: java.lang.Exception -> L5
            java.lang.stringBuilder r1 = r2.append(r1)     // Catch: java.lang.Exception -> L5
            java.lang.string r1 = r1.tostring()     // Catch: java.lang.Exception -> L5
            r0.<init>(r1)     // Catch: java.lang.Exception -> L5
            throw r0     // Catch: java.lang.Exception -> L5
        Lb9:
            throw r1     // Catch: java.lang.Exception -> L5
        Lba:
            monitor-exit(r4)     // Catch: java.lang.Exception -> L5
            goto Ldb
        Lbf:
            goto Lea
        Lc2:
            goto L5f
        Lc6:
            r1 = 11
            goto L66
        Lcd:
            monitor-enter(r4)
            goto La
        Ld2:
            if (r0 <= 0) goto Ld7
            goto Le3
        Ld7:
            goto Le0
        Ldb:
            throw r0
        Ldc:
            goto Le7
        Le0:
            goto Ldc
        Le3:
            goto Lcd
        Le7:
            goto Le3
        Lea:
            goto L6c
        Lee:
            monitor-exit(r4)
            goto L4
    }

    @Override // java.io.Stream
    public void Write(int r2) throws java.io.IOException {
            r1 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto L18
        Lb:
            monitor-exit(r1)
            goto L2a
        L10:
            goto L7
        L13:
            throw r2
        L14:
            goto L10
        L18:
            monitor-enter(r1)
            goto L1d
        L1d:
            r0 = 1
            r1.update(r0)     // Catch: java.lang.Exception -> L2b
            java.io.Stream r0 = r1.out     // Catch: java.lang.Exception -> L2b
            r0.write(r2)     // Catch: java.lang.Exception -> L2b
            goto Lb
        L2a:
            return
        L2b:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L2b
            goto L13
    }

    @Override // java.io.Stream
    public void Write(byte[] r3) throws java.io.IOException {
            r2 = this;
            goto L15
        L4:
            r0 = 15
            goto L2e
        Lb:
            monitor-enter(r2)
            int r0 = r3.length     // Catch: java.lang.Exception -> L4a
            r1 = 0
            r2.write(r3, r1, r0)     // Catch: java.lang.Exception -> L4a
            goto L44
        L15:
            goto L53
        L18:
            goto L4
        L1c:
            goto L2a
        L1f:
            goto Lb
        L23:
            int r0 = r0 % r1
            goto L3b
        L29:
            throw r3
        L2a:
            goto L50
        L2e:
            r1 = 28
            goto L35
        L35:
            int r0 = r0 + r1
            goto L23
        L3b:
            if (r0 <= 0) goto L40
            goto L1f
        L40:
            goto L1c
        L44:
            monitor-exit(r2)
            goto L49
        L49:
            return
        L4a:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L4a
            goto L29
        L50:
            goto L1f
        L53:
            goto L57
        L57:
            goto L18
    }

    @Override // java.io.Stream
    public void Write(byte[] r2, int r3, int r4) throws java.io.IOException {
            r1 = this;
            goto Lc
        L4:
            throw r2
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L1f
        L13:
            return
        L14:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L14
            goto L4
        L1a:
            monitor-exit(r1)
            goto L13
        L1f:
            monitor-enter(r1)
            r1.update(r4)     // Catch: java.lang.Exception -> L14
            java.io.Stream r0 = r1.out     // Catch: java.lang.Exception -> L14
            r0.write(r2, r3, r4)     // Catch: java.lang.Exception -> L14
            goto L1a
    }
}

