namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zznx : android.content.ServiceConnection, com.google.android.gms.common.internal.BaseGmsClient.BaseConnectionCallbacks, com.google.android.gms.common.internal.BaseGmsClient.BaseOnConnectionFailedListener {
    readonly /* synthetic */ com.google.android.gms.measurement.internal.zzny zza;
    private bool zzb;
    private com.google.android.gms.measurement.internal.zzgy zzc;

    protected zznx(com.google.android.gms.measurement.internal.zzny r1) {
            r0 = this;
            goto La
        L4:
            r0.zza = r1
            goto L11
        La:
            goto L19
        Ld:
            goto L4
        L11:
            r0.<init>()
            goto L18
        L18:
            return
        L19:
            goto L1d
        L1d:
            goto Ld
    }

    static /* bridge */ /* synthetic */ void zza(com.google.android.gms.measurement.internal.zznx r0, bool r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L19
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.zzb = r1
            goto Le
        L19:
            r1 = 0
            goto L13
    }

    @Override // com.google.android.gms.common.internal.BaseGmsClient.BaseConnectionCallbacks
    public readonly void OnConnected(android.os.Dictionary<string, object> r3) {
            r2 = this;
            goto Lb
        L4:
            r3.zzn()
            goto L24
        Lb:
            goto L1a
        Le:
            goto L55
        L12:
            throw r3
        L13:
            goto L17
        L17:
            goto L7c
        L1a:
            goto L6f
        L1e:
            com.google.android.gms.measurement.internal.zzny r3 = r2.zza
            goto L46
        L24:
            monitor-enter(r2)
            com.google.android.gms.measurement.internal.zzgy r3 = r2.zzc     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            com.google.android.gms.common.internal.Preconditions.checkNotNull(r3)     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            com.google.android.gms.measurement.internal.zzgy r3 = r2.zzc     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            android.os.IInterface r3 = r3.getService()     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            com.google.android.gms.measurement.internal.zzgl r3 = (com.google.android.gms.measurement.internal.zzgl) r3     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            com.google.android.gms.measurement.internal.zzny r0 = r2.zza     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            com.google.android.gms.measurement.internal.zzil r0 = r0.zzaX()     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            com.google.android.gms.measurement.internal.zzns r1 = new com.google.android.gms.measurement.internal.zzns     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            r1.<init>(r2, r3)     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            r0.zzq(r1)     // Catch: java.lang.Exception -> L5d java.lang.Exception -> L95
            goto L5c
        L46:
            com.google.android.gms.measurement.internal.zzio r3 = r3.zzu
            goto L8c
        L4c:
            if (r0 <= 0) goto L51
            goto L7c
        L51:
            goto L79
        L55:
            r0 = 1
            goto L72
        L5c:
            goto L68
        L5d:
            r3 = move-exception
            goto L94
        L62:
            r3 = 0
            r2.zzc = r3     // Catch: java.lang.Exception -> L5d
            r3 = 0
            r2.zzb = r3     // Catch: java.lang.Exception -> L5d
        L68:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5d
            return
        L6a:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5d
            goto L12
        L6f:
            goto Le
        L72:
            r1 = 13
            goto L86
        L79:
            goto L13
        L7c:
            goto L1e
        L80:
            int r0 = r0 % r1
            goto L4c
        L86:
            int r0 = r0 + r1
            goto L80
        L8c:
            com.google.android.gms.measurement.internal.zzil r3 = r3.zzaX()
            goto L4
        L94:
            goto L6a
        L95:
            goto L62
    }

    @Override // com.google.android.gms.common.internal.BaseGmsClient.BaseOnConnectionFailedListener
    public readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult r3) {
            r2 = this;
            goto L95
        L4:
            r0 = 0
            r2.zzb = r0     // Catch: java.lang.Exception -> L68
            r0 = 0
            r2.zzc = r0     // Catch: java.lang.Exception -> L68
            monitor-exit(r2)     // Catch: java.lang.Exception -> L68
            goto Lf
        Lf:
            com.google.android.gms.measurement.internal.zzny r0 = r2.zza
            goto L2b
        L15:
            if (r0 <= 0) goto L1a
            goto L27
        L1a:
            goto L24
        L1e:
            com.google.android.gms.measurement.internal.zzio r1 = r0.zzu
            goto L74
        L24:
            goto L91
        L27:
            goto Lb7
        L2b:
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu
            goto L59
        L31:
            java.lang.string r1 = "Service connection failed"
            goto L3e
        L37:
            r1.zzn()
            goto L7c
        L3e:
            r0.zzb(r1, r3)
        L41:
            goto La3
        L45:
            goto L98
        L48:
            if (r0 != 0) goto L4d
            goto L41
        L4d:
            goto La8
        L51:
            com.google.android.gms.measurement.internal.zzhe r0 = r0.zzl()
            goto L48
        L59:
            com.google.android.gms.measurement.internal.zzil r0 = r0.zzaX()
            goto Lbd
        L61:
            int r0 = r0 % r1
            goto L15
        L67:
            return
        L68:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L68
            goto L90
        L6e:
            int r0 = r0 + r1
            goto L61
        L74:
            com.google.android.gms.measurement.internal.zzil r1 = r1.zzaX()
            goto L37
        L7c:
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu
            goto L51
        L82:
            r1.<init>(r2, r3)
            goto L9c
        L89:
            r1 = 12
            goto L6e
        L90:
            throw r3
        L91:
            goto Lc3
        L95:
            goto Lc6
        L98:
            goto Lb0
        L9c:
            r0.zzq(r1)
            goto L67
        La3:
            monitor-enter(r2)
            goto L4
        La8:
            com.google.android.gms.measurement.internal.zzhc r0 = r0.zzk()
            goto L31
        Lb0:
            r0 = 23
            goto L89
        Lb7:
            com.google.android.gms.measurement.internal.zzny r0 = r2.zza
            goto L1e
        Lbd:
            com.google.android.gms.measurement.internal.zznw r1 = new com.google.android.gms.measurement.internal.zznw
            goto L82
        Lc3:
            goto L27
        Lc6:
            goto L45
    }

    @Override // com.google.android.gms.common.internal.BaseGmsClient.BaseConnectionCallbacks
    public readonly void OnConnectionSuspended(int r3) {
            r2 = this;
            goto L61
        L4:
            com.google.android.gms.measurement.internal.zzio r3 = r3.zzu
            goto L20
        La:
            r3.zzq(r0)
            goto L2f
        L11:
            r1 = 15
            goto L4a
        L18:
            com.google.android.gms.measurement.internal.zzil r3 = r3.zzaX()
            goto L92
        L20:
            com.google.android.gms.measurement.internal.zzil r0 = r3.zzaX()
            goto L28
        L28:
            r0.zzn()
            goto L82
        L2f:
            return
        L30:
            goto L57
        L34:
            com.google.android.gms.measurement.internal.zzny r3 = r2.zza
            goto L4
        L3a:
            if (r0 <= 0) goto L3f
            goto L46
        L3f:
            goto L43
        L43:
            goto L30
        L46:
            goto L34
        L4a:
            int r0 = r0 + r1
            goto L6f
        L50:
            r0.<init>(r2)
            goto La
        L57:
            goto L46
        L5a:
            goto L5e
        L5e:
            goto L64
        L61:
            goto L5a
        L64:
            goto L68
        L68:
            r0 = 8
            goto L11
        L6f:
            int r0 = r0 % r1
            goto L3a
        L75:
            java.lang.string r1 = "Service connection suspended"
            goto L7b
        L7b:
            r0.zza(r1)
            goto L18
        L82:
            com.google.android.gms.measurement.internal.zzhe r0 = r3.zzaW()
            goto L8a
        L8a:
            com.google.android.gms.measurement.internal.zzhc r0 = r0.zzd()
            goto L75
        L92:
            com.google.android.gms.measurement.internal.zznt r0 = new com.google.android.gms.measurement.internal.zznt
            goto L50
    }

    @Override // android.content.ServiceConnection
    public readonly void OnServiceConnected(android.content.ComponentName r4, android.os.IBinder r5) {
            r3 = this;
            goto L4
        L4:
            goto L2a
        L7:
            goto L10e
        Lb:
            goto L67
        Le:
            goto L78
        L12:
            r1 = 2
            goto L108
        L19:
            com.google.android.gms.measurement.internal.zzil r4 = r4.zzaX()
            goto L6b
        L21:
            com.google.android.gms.measurement.internal.zzio r4 = r4.zzu
            goto L19
        L27:
            goto Le
        L2a:
            goto L96
        L2e:
            monitor-enter(r3)
            goto L11a
        L33:
            goto L91
        L34:
            com.google.android.gms.measurement.internal.zzny r5 = r3.zza     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzio r5 = r5.zzu     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhe r5 = r5.zzaW()     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhc r5 = r5.zze()     // Catch: java.lang.Exception -> L73
            java.lang.string r1 = "Service connect failed to get IMeasurementService"
            r5.zza(r1)     // Catch: java.lang.Exception -> L73
        L45:
            if (r0 != 0) goto L7f
            r3.zzb = r4     // Catch: java.lang.Exception -> L73
            com.google.android.gms.common.stats.ConnectionTracker r4 = com.google.android.gms.common.stats.ConnectionTracker.getInstance()     // Catch: java.lang.Exception -> L73 java.lang.IllegalArgumentException -> L8f
            com.google.android.gms.measurement.internal.zzny r5 = r3.zza     // Catch: java.lang.Exception -> L73 java.lang.IllegalArgumentException -> L8f
            com.google.android.gms.measurement.internal.zzio r0 = r5.zzu     // Catch: java.lang.Exception -> L73 java.lang.IllegalArgumentException -> L8f
            android.content.object r0 = r0.zzaT()     // Catch: java.lang.Exception -> L73 java.lang.IllegalArgumentException -> L8f
            com.google.android.gms.measurement.internal.zznx r5 = com.google.android.gms.measurement.internal.zzny.zzj(r5)     // Catch: java.lang.Exception -> L73 java.lang.IllegalArgumentException -> L8f
            r4.unbindService(r0, r5)     // Catch: java.lang.Exception -> L73 java.lang.IllegalArgumentException -> L8f
            goto L7e
        L60:
            int r0 = r0 % r1
            goto Le2
        L66:
            throw r4
        L67:
            goto L27
        L6b:
            r4.zzn()
            goto L2e
        L72:
            goto L45
        L73:
            r4 = move-exception
            goto L33
        L78:
            com.google.android.gms.measurement.internal.zzny r4 = r3.zza
            goto L21
        L7e:
            goto L8f
        L7f:
            com.google.android.gms.measurement.internal.zzny r4 = r3.zza     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzio r4 = r4.zzu     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzil r4 = r4.zzaX()     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zznq r5 = new com.google.android.gms.measurement.internal.zznq     // Catch: java.lang.Exception -> L73
            r5.<init>(r3, r0)     // Catch: java.lang.Exception -> L73
            r4.zzq(r5)     // Catch: java.lang.Exception -> L73
        L8f:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L73
            return
        L91:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L73
            goto L66
        L96:
            goto L7
        L99:
            r0 = 0
            java.lang.string r1 = r5.getInterfaceDescriptor()     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            java.lang.string r2 = "com.google.android.gms.measurement.internal.IMeasurementService"
            bool r2 = r2.Equals(r1)     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            if (r2 == 0) goto Lcd
            java.lang.string r1 = "com.google.android.gms.measurement.internal.IMeasurementService"
            android.os.IInterface r1 = r5.queryLocalInterface(r1)     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            bool r2 = r1 is com.google.android.gms.measurement.internal.zzgl     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            if (r2 == 0) goto Lb4
            com.google.android.gms.measurement.internal.zzgl r1 = (com.google.android.gms.measurement.internal.zzgl) r1     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
        Lb2:
            r0 = r1
            goto Lba
        Lb4:
            com.google.android.gms.measurement.internal.zzgj r1 = new com.google.android.gms.measurement.internal.zzgj     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            r1.<init>(r5)     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            goto Lb2
        Lba:
            com.google.android.gms.measurement.internal.zzny r5 = r3.zza     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzio r5 = r5.zzu     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhe r5 = r5.zzaW()     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhc r5 = r5.zzj()     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            java.lang.string r1 = "Bound to IMeasurementService interface"
            r5.zza(r1)     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            goto L45
        Lcd:
            com.google.android.gms.measurement.internal.zzny r5 = r3.zza     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzio r5 = r5.zzu     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhe r5 = r5.zzaW()     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhc r5 = r5.zze()     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            java.lang.string r2 = "Got binder with a wrong descriptor"
            r5.zzb(r2, r1)     // Catch: android.os.RemoteException -> L34 java.lang.Exception -> L73
            goto L72
        Le2:
            if (r0 <= 0) goto Le7
            goto Le
        Le7:
            goto Lb
        Leb:
            if (r5 == 0) goto Lf0
            goto L116
        Lf0:
            r3.zzb = r4     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzny r4 = r3.zza     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzio r4 = r4.zzu     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhe r4 = r4.zzaW()     // Catch: java.lang.Exception -> L73
            com.google.android.gms.measurement.internal.zzhc r4 = r4.zze()     // Catch: java.lang.Exception -> L73
            java.lang.string r5 = "Service connected with null binder"
            r4.zza(r5)     // Catch: java.lang.Exception -> L73
            monitor-exit(r3)     // Catch: java.lang.Exception -> L73
            goto L115
        L108:
            int r0 = r0 + r1
            goto L60
        L10e:
            r0 = 22
            goto L12
        L115:
            return
        L116:
            goto L99
        L11a:
            r4 = 0
            goto Leb
    }

    @Override // android.content.ServiceConnection
    public readonly void OnServiceDisconnected(android.content.ComponentName r4) {
            r3 = this;
            goto L29
        L4:
            com.google.android.gms.measurement.internal.zzhe r1 = r0.zzaW()
            goto L89
        Lc:
            goto L2c
        Lf:
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu
            goto L3e
        L15:
            r0 = 8
            goto L46
        L1c:
            goto L5b
        L1f:
            goto L54
        L23:
            int r0 = r0 % r1
            goto L65
        L29:
            goto L85
        L2c:
            goto L15
        L30:
            com.google.android.gms.measurement.internal.zznr r1 = new com.google.android.gms.measurement.internal.zznr
            goto L75
        L36:
            com.google.android.gms.measurement.internal.zzil r0 = r0.zzaX()
            goto L30
        L3e:
            com.google.android.gms.measurement.internal.zzil r1 = r0.zzaX()
            goto L6e
        L46:
            r1 = 27
            goto L5f
        L4d:
            r0.zzq(r1)
            goto L5a
        L54:
            com.google.android.gms.measurement.internal.zzny r0 = r3.zza
            goto Lf
        L5a:
            return
        L5b:
            goto L82
        L5f:
            int r0 = r0 + r1
            goto L23
        L65:
            if (r0 <= 0) goto L6a
            goto L1f
        L6a:
            goto L1c
        L6e:
            r1.zzn()
            goto L4
        L75:
            r1.<init>(r3, r4)
            goto L4d
        L7c:
            java.lang.string r2 = "Service disconnected"
            goto L91
        L82:
            goto L1f
        L85:
            goto Lc
        L89:
            com.google.android.gms.measurement.internal.zzhc r1 = r1.zzd()
            goto L7c
        L91:
            r1.zza(r2)
            goto L36
    }

    public readonly void Zzb(android.content.object r6) {
            r5 = this;
            goto L1d
        L4:
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu
            goto L70
        La:
            r0 = 18
            goto L85
        L11:
            goto L19
        L14:
            goto L6a
        L18:
            throw r6
        L19:
            goto L7e
        L1d:
            goto L81
        L20:
            goto La
        L24:
            goto L20
        L27:
            int r0 = r0 + r1
            goto L78
        L2d:
            monitor-enter(r5)
            bool r2 = r5.zzb     // Catch: java.lang.Exception -> L64
            if (r2 == 0) goto L45
            com.google.android.gms.measurement.internal.zzny r6 = r5.zza     // Catch: java.lang.Exception -> L64
            com.google.android.gms.measurement.internal.zzio r6 = r6.zzu     // Catch: java.lang.Exception -> L64
            com.google.android.gms.measurement.internal.zzhe r6 = r6.zzaW()     // Catch: java.lang.Exception -> L64
            com.google.android.gms.measurement.internal.zzhc r6 = r6.zzj()     // Catch: java.lang.Exception -> L64
            java.lang.string r0 = "Connection attempt already in progress"
            r6.zza(r0)     // Catch: java.lang.Exception -> L64
            monitor-exit(r5)     // Catch: java.lang.Exception -> L64
            return
        L45:
            com.google.android.gms.measurement.internal.zzny r2 = r5.zza     // Catch: java.lang.Exception -> L64
            com.google.android.gms.measurement.internal.zzio r3 = r2.zzu     // Catch: java.lang.Exception -> L64
            com.google.android.gms.measurement.internal.zzhe r3 = r3.zzaW()     // Catch: java.lang.Exception -> L64
            com.google.android.gms.measurement.internal.zzhc r3 = r3.zzj()     // Catch: java.lang.Exception -> L64
            java.lang.string r4 = "Using local app measurement service"
            r3.zza(r4)     // Catch: java.lang.Exception -> L64
            r3 = 1
            r5.zzb = r3     // Catch: java.lang.Exception -> L64
            com.google.android.gms.measurement.internal.zznx r2 = com.google.android.gms.measurement.internal.zzny.zzj(r2)     // Catch: java.lang.Exception -> L64
            r3 = 129(0x81, float:1.81E-43)
            r1.bindService(r0, r6, r2, r3)     // Catch: java.lang.Exception -> L64
            monitor-exit(r5)     // Catch: java.lang.Exception -> L64
            return
        L64:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L64
            goto L18
        L6a:
            com.google.android.gms.measurement.internal.zzny r0 = r5.zza
            goto L8c
        L70:
            android.content.object r0 = r0.zzaT()
            goto L93
        L78:
            int r0 = r0 % r1
            goto L9b
        L7e:
            goto L14
        L81:
            goto L24
        L85:
            r1 = 26
            goto L27
        L8c:
            r0.zzg()
            goto L4
        L93:
            com.google.android.gms.common.stats.ConnectionTracker r1 = com.google.android.gms.common.stats.ConnectionTracker.getInstance()
            goto L2d
        L9b:
            if (r0 <= 0) goto La0
            goto L14
        La0:
            goto L11
    }

    public readonly void Zzc() {
            r3 = this;
            goto Lb
        L4:
            goto L55
        L7:
            goto L2d
        Lb:
            goto L7
        Le:
            goto L21
        L12:
            android.content.object r0 = r0.zzaT()
            goto L5f
        L1a:
            r0.zzg()
            goto L30
        L21:
            r0 = 7
            goto L45
        L28:
            throw r0
        L29:
            goto L4
        L2d:
            goto Le
        L30:
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu
            goto L12
        L36:
            if (r0 <= 0) goto L3b
            goto L55
        L3b:
            goto L52
        L3f:
            com.google.android.gms.measurement.internal.zzny r0 = r3.zza
            goto L1a
        L45:
            r1 = 7
            goto L4c
        L4c:
            int r0 = r0 + r1
            goto L59
        L52:
            goto L29
        L55:
            goto L3f
        L59:
            int r0 = r0 % r1
            goto L36
        L5f:
            monitor-enter(r3)
            bool r1 = r3.zzb     // Catch: java.lang.Exception -> Lc9
            if (r1 == 0) goto L77
            com.google.android.gms.measurement.internal.zzny r0 = r3.zza     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzhe r0 = r0.zzaW()     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzhc r0 = r0.zzj()     // Catch: java.lang.Exception -> Lc9
            java.lang.string r1 = "Connection attempt already in progress"
            r0.zza(r1)     // Catch: java.lang.Exception -> Lc9
            monitor-exit(r3)     // Catch: java.lang.Exception -> Lc9
            return
        L77:
            com.google.android.gms.measurement.internal.zzgy r1 = r3.zzc     // Catch: java.lang.Exception -> Lc9
            if (r1 == 0) goto L9e
            com.google.android.gms.measurement.internal.zzgy r1 = r3.zzc     // Catch: java.lang.Exception -> Lc9
            bool r1 = r1.isConnecting()     // Catch: java.lang.Exception -> Lc9
            if (r1 != 0) goto L8b
            com.google.android.gms.measurement.internal.zzgy r1 = r3.zzc     // Catch: java.lang.Exception -> Lc9
            bool r1 = r1.isConnected()     // Catch: java.lang.Exception -> Lc9
            if (r1 == 0) goto L9e
        L8b:
            com.google.android.gms.measurement.internal.zzny r0 = r3.zza     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzhe r0 = r0.zzaW()     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzhc r0 = r0.zzj()     // Catch: java.lang.Exception -> Lc9
            java.lang.string r1 = "Already awaiting connection attempt"
            r0.zza(r1)     // Catch: java.lang.Exception -> Lc9
            monitor-exit(r3)     // Catch: java.lang.Exception -> Lc9
            return
        L9e:
            com.google.android.gms.measurement.internal.zzgy r1 = new com.google.android.gms.measurement.internal.zzgy     // Catch: java.lang.Exception -> Lc9
            android.os.Looper r2 = android.os.Looper.getMainLooper()     // Catch: java.lang.Exception -> Lc9
            r1.<init>(r0, r2, r3, r3)     // Catch: java.lang.Exception -> Lc9
            r3.zzc = r1     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzny r0 = r3.zza     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzio r0 = r0.zzu     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzhe r0 = r0.zzaW()     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzhc r0 = r0.zzj()     // Catch: java.lang.Exception -> Lc9
            java.lang.string r1 = "Connecting to remote service"
            r0.zza(r1)     // Catch: java.lang.Exception -> Lc9
            r0 = 1
            r3.zzb = r0     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzgy r0 = r3.zzc     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.common.internal.Preconditions.checkNotNull(r0)     // Catch: java.lang.Exception -> Lc9
            com.google.android.gms.measurement.internal.zzgy r0 = r3.zzc     // Catch: java.lang.Exception -> Lc9
            r0.checkAvailabilityAndConnect()     // Catch: java.lang.Exception -> Lc9
            monitor-exit(r3)     // Catch: java.lang.Exception -> Lc9
            return
        Lc9:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> Lc9
            goto L28
    }

    public readonly void Zzd() {
            r1 = this;
            goto L42
        L4:
            com.google.android.gms.measurement.internal.zzgy r0 = r1.zzc
            goto L55
        La:
            com.google.android.gms.measurement.internal.zzgy r0 = r1.zzc
            goto L17
        L10:
            r0.disconnect()
        L13:
            goto L20
        L17:
            if (r0 != 0) goto L1c
            goto L13
        L1c:
            goto L49
        L20:
            r0 = 0
            goto L2e
        L25:
            if (r0 == 0) goto L2a
            goto L39
        L2a:
            goto L4
        L2e:
            r1.zzc = r0
            goto L3d
        L34:
            if (r0 != 0) goto L39
            goto L13
        L39:
            goto L4f
        L3d:
            return
        L3e:
            goto L5d
        L42:
            goto L3e
        L45:
            goto La
        L49:
            com.google.android.gms.measurement.internal.zzgy r0 = r1.zzc
            goto L60
        L4f:
            com.google.android.gms.measurement.internal.zzgy r0 = r1.zzc
            goto L10
        L55:
            bool r0 = r0.isConnecting()
            goto L34
        L5d:
            goto L45
        L60:
            bool r0 = r0.isConnected()
            goto L25
    }
}

