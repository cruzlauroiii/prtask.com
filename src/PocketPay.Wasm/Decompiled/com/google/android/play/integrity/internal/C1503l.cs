namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.l */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1503l : com.google.android.play.integrity.internal.C1492a : com.google.android.play.integrity.internal.InterfaceC1505n {
    C1503l(android.os.IBinder r2) {
            r1 = this;
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r1.<init>(r2, r0)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L1a
        L1a:
            java.lang.string r0 = "com.google.android.play.core.integrity.protocol.IIntegrityService"
            goto L9
    }

    public static void JtHZMAKxvNZZbwIb(android.os.Parcel r0, android.os.Parcelable r1) {
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
            com.google.android.play.integrity.internal.C1494c.m312c(r0, r1)
            goto Lb
        L17:
            goto L7
    }

    public static android.os.Parcel MGQbRvMpuNNGKTzy(com.google.android.play.integrity.internal.C1492a r1) {
            goto L11
        L4:
            android.os.Parcel r0 = r1.m257a()
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

    public static android.os.Parcel QbCmdvSIfbZAiiLB(com.google.android.play.integrity.internal.C1492a r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.os.Parcel r0 = r1.m257a()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void VQpjHDTrxIGemGlw(android.os.Parcel r0, android.os.IBinder r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.writeStrongBinder(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void IYjUJMTceJyFUqnC(com.google.android.play.integrity.internal.C1492a r0, int r1, android.os.Parcel r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.m258b(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void NdpqFbGcduKwStfu(android.os.Parcel r0, android.os.Parcelable r1) {
            goto Lb
        L4:
            com.google.android.play.integrity.internal.C1494c.m312c(r0, r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void QBQEeKejqtukbAyS(android.os.Parcel r0, android.os.IBinder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.writeStrongBinder(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void SYlUsFySFTlOWEgN(com.google.android.play.integrity.internal.C1492a r0, int r1, android.os.Parcel r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.m258b(r1, r2)
            goto Le
    }

    @Override // com.google.android.play.integrity.internal.InterfaceC1505n
    /* JADX INFO: renamed from: c */
    public readonly void Mo322c(android.os.Dictionary<string, object> r2, com.google.android.play.integrity.internal.InterfaceC1509r r3) throws android.os.RemoteException {
            r1 = this;
            goto L2e
        L4:
            android.os.Parcel r0 = MGQbRvMpuNNGKTzy(r1)
            goto Lc
        Lc:
            JtHZMAKxvNZZbwIb(r0, r2)
            goto L18
        L13:
            return
        L14:
            goto L2b
        L18:
            VQpjHDTrxIGemGlw(r0, r3)
            goto L26
        L1f:
            iYjUJMTceJyFUqnC(r1, r2, r0)
            goto L13
        L26:
            r2 = 3
            goto L1f
        L2b:
            goto L31
        L2e:
            goto L14
        L31:
            goto L4
    }

    @Override // com.google.android.play.integrity.internal.InterfaceC1505n
    /* JADX INFO: renamed from: d */
    public readonly void Mo323d(android.os.Dictionary<string, object> r2, com.google.android.play.integrity.internal.InterfaceC1507p r3) throws android.os.RemoteException {
            r1 = this;
            goto L9
        L4:
            r2 = 2
            goto L27
        L9:
            goto L23
        Lc:
            goto L1a
        L10:
            goto Lc
        L13:
            qBQEeKejqtukbAyS(r0, r3)
            goto L4
        L1a:
            android.os.Parcel r0 = QbCmdvSIfbZAiiLB(r1)
            goto L2e
        L22:
            return
        L23:
            goto L10
        L27:
            sYlUsFySFTlOWEgN(r1, r2, r0)
            goto L22
        L2e:
            ndpqFbGcduKwStfu(r0, r2)
            goto L13
    }
}

