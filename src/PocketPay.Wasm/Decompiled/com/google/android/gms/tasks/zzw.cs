namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes19.dex */
readonly class zzw<TResult> : com.google.android.gms.tasks.Task<TResult> {
    private readonly java.lang.object zza;
    private readonly com.google.android.gms.tasks.zzr zzb;
    private bool zzc;
    private bool zzd;
    private java.lang.object zze;
    private java.lang.Exception zzf;

    zzw() {
            r1 = this;
            goto L4
        L4:
            goto L39
        L7:
            goto L25
        Lb:
            java.lang.object r0 = new java.lang.object
            goto L18
        L11:
            r0.<init>()
            goto L32
        L18:
            r0.<init>()
            goto L1f
        L1f:
            r1.zza = r0
            goto L2c
        L25:
            r1.<init>()
            goto Lb
        L2c:
            com.google.android.gms.tasks.zzr r0 = new com.google.android.gms.tasks.zzr
            goto L11
        L32:
            r1.zzb = r0
            goto L38
        L38:
            return
        L39:
            goto L3d
        L3d:
            goto L7
    }

    private readonly void Zzf() {
            r1 = this;
            goto L14
        L4:
            goto L17
        L7:
            bool r1 = r1.zzc
            goto L1b
        Ld:
            com.google.android.gms.common.internal.Preconditions.checkState(r1, r0)
            goto L21
        L14:
            goto L22
        L17:
            goto L7
        L1b:
            java.lang.string r0 = "Task is not yet complete"
            goto Ld
        L21:
            return
        L22:
            goto L4
    }

    private readonly void Zzg() {
            r1 = this;
            goto Lb
        L4:
            r1.<init>(r0)
            goto L12
        Lb:
            goto L13
        Le:
            goto L2e
        L12:
            throw r1
        L13:
            goto L17
        L17:
            goto Le
        L1a:
            if (r1 == 0) goto L1f
            goto L24
        L1f:
            goto L23
        L23:
            return
        L24:
            goto L34
        L28:
            java.lang.string r0 = "Task is already canceled."
            goto L4
        L2e:
            bool r1 = r1.zzd
            goto L1a
        L34:
            java.util.concurrent.CancellationException r1 = new java.util.concurrent.CancellationException
            goto L28
    }

    private readonly void Zzh() {
            r1 = this;
            goto L4
        L4:
            goto L2b
        L7:
            goto L24
        Lb:
            goto L7
        Le:
            java.lang.IllegalStateException r1 = com.google.android.gms.tasks.DuplicateTaskCompletionException.of(r1)
            goto L2a
        L16:
            if (r0 == 0) goto L1b
            goto L20
        L1b:
            goto L1f
        L1f:
            return
        L20:
            goto Le
        L24:
            bool r0 = r1.zzc
            goto L16
        L2a:
            throw r1
        L2b:
            goto Lb
    }

    private readonly void Zzi() {
            r2 = this;
            goto L12
        L4:
            r1 = 22
            goto L42
        Lb:
            goto L3e
        Le:
            goto L54
        L12:
            goto L33
        L15:
            goto L29
        L19:
            goto L15
        L1c:
            int r0 = r0 % r1
            goto L61
        L22:
            return
        L23:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L23
            goto L3d
        L29:
            r0 = 25
            goto L4
        L30:
            goto Le
        L33:
            goto L19
        L37:
            com.google.android.gms.tasks.zzr r0 = r2.zzb
            goto L5a
        L3d:
            throw r2
        L3e:
            goto L30
        L42:
            int r0 = r0 + r1
            goto L1c
        L48:
            monitor-enter(r0)
            bool r1 = r2.zzc     // Catch: java.lang.Exception -> L23
            if (r1 != 0) goto L4f
            monitor-exit(r0)     // Catch: java.lang.Exception -> L23
            return
        L4f:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L23
            goto L37
        L54:
            java.lang.object r0 = r2.zza
            goto L48
        L5a:
            r0.zzb(r2)
            goto L22
        L61:
            if (r0 <= 0) goto L66
            goto Le
        L66:
            goto Lb
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnCanceledListener(android.app.object r3, com.google.android.gms.tasks.OnCanceledListener r4) {
            r2 = this;
            goto L30
        L4:
            com.google.android.gms.tasks.zzh r0 = new com.google.android.gms.tasks.zzh
            goto L17
        La:
            int r0 = r0 + r1
            goto L2a
        L10:
            r0.<init>(r1, r4)
            goto L24
        L17:
            java.util.concurrent.Executor r1 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L10
        L1d:
            goto L54
        L20:
            goto L4
        L24:
            com.google.android.gms.tasks.zzr r4 = r2.zzb
            goto L45
        L2a:
            int r0 = r0 % r1
            goto L60
        L30:
            goto L76
        L33:
            goto L3e
        L37:
            r1 = 29
            goto La
        L3e:
            r0 = 1
            goto L37
        L45:
            r4.zza(r0)
            goto L58
        L4c:
            r3.zzb(r0)
            goto L69
        L53:
            return r2
        L54:
            goto L73
        L58:
            com.google.android.gms.tasks.zzv r3 = com.google.android.gms.tasks.zzv.zza(r3)
            goto L4c
        L60:
            if (r0 <= 0) goto L65
            goto L20
        L65:
            goto L1d
        L69:
            r2.zzi()
            goto L53
        L70:
            goto L33
        L73:
            goto L20
        L76:
            goto L70
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnCanceledListener(com.google.android.gms.tasks.OnCanceledListener r2) {
            r1 = this;
            goto L13
        L4:
            goto L16
        L7:
            r1.addOnCanceledListener(r0, r2)
            goto Le
        Le:
            return r1
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L1a
        L1a:
            java.util.concurrent.Executor r0 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L7
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnCanceledListener(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCanceledListener r3) {
            r1 = this;
            goto L11
        L4:
            r2.zza(r0)
            goto L26
        Lb:
            com.google.android.gms.tasks.zzr r2 = r1.zzb
            goto L4
        L11:
            goto L1f
        L14:
            goto L18
        L18:
            com.google.android.gms.tasks.zzh r0 = new com.google.android.gms.tasks.zzh
            goto L2d
        L1e:
            return r1
        L1f:
            goto L23
        L23:
            goto L14
        L26:
            r1.zzi()
            goto L1e
        L2d:
            r0.<init>(r2, r3)
            goto Lb
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnCompleteListener(android.app.object r3, com.google.android.gms.tasks.OnCompleteListener<TResult> r4) {
            r2 = this;
            goto L73
        L4:
            goto L76
        L7:
            r4.zza(r0)
            goto L45
        Le:
            r2.zzi()
            goto L4d
        L15:
            com.google.android.gms.tasks.zzr r4 = r2.zzb
            goto L7
        L1b:
            goto L35
        L1e:
            goto L4
        L22:
            if (r0 <= 0) goto L27
            goto L35
        L27:
            goto L32
        L2b:
            r0 = 9
            goto L58
        L32:
            goto L4e
        L35:
            goto L66
        L39:
            int r0 = r0 + r1
            goto L3f
        L3f:
            int r0 = r0 % r1
            goto L22
        L45:
            com.google.android.gms.tasks.zzv r3 = com.google.android.gms.tasks.zzv.zza(r3)
            goto L6c
        L4d:
            return r2
        L4e:
            goto L1b
        L52:
            java.util.concurrent.Executor r1 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L5f
        L58:
            r1 = 19
            goto L39
        L5f:
            r0.<init>(r1, r4)
            goto L15
        L66:
            com.google.android.gms.tasks.zzj r0 = new com.google.android.gms.tasks.zzj
            goto L52
        L6c:
            r3.zzb(r0)
            goto Le
        L73:
            goto L1e
        L76:
            goto L2b
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnCompleteListener(com.google.android.gms.tasks.OnCompleteListener<TResult> r3) {
            r2 = this;
            goto L5e
        L4:
            if (r0 <= 0) goto L9
            goto L3c
        L9:
            goto L39
        Ld:
            r1.<init>(r0, r3)
            goto L40
        L14:
            r3.zza(r1)
            goto L2c
        L1b:
            return r2
        L1c:
            goto L4d
        L20:
            int r0 = r0 + r1
            goto L26
        L26:
            int r0 = r0 % r1
            goto L4
        L2c:
            r2.zzi()
            goto L1b
        L33:
            java.util.concurrent.Executor r0 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L65
        L39:
            goto L1c
        L3c:
            goto L33
        L40:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L14
        L46:
            r0 = 3
            goto L54
        L4d:
            goto L3c
        L50:
            goto L5b
        L54:
            r1 = 30
            goto L20
        L5b:
            goto L61
        L5e:
            goto L50
        L61:
            goto L46
        L65:
            com.google.android.gms.tasks.zzj r1 = new com.google.android.gms.tasks.zzj
            goto Ld
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnCompleteListener(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCompleteListener<TResult> r3) {
            r1 = this;
            goto L18
        L4:
            r0.<init>(r2, r3)
            goto L12
        Lb:
            r1.zzi()
            goto L28
        L12:
            com.google.android.gms.tasks.zzr r2 = r1.zzb
            goto L2d
        L18:
            goto L29
        L1b:
            goto L22
        L1f:
            goto L1b
        L22:
            com.google.android.gms.tasks.zzj r0 = new com.google.android.gms.tasks.zzj
            goto L4
        L28:
            return r1
        L29:
            goto L1f
        L2d:
            r2.zza(r0)
            goto Lb
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnFailureListener(android.app.object r3, com.google.android.gms.tasks.OnFailureListener r4) {
            r2 = this;
            goto L44
        L4:
            goto L47
        L7:
            r3.zzb(r0)
            goto L14
        Le:
            com.google.android.gms.tasks.zzl r0 = new com.google.android.gms.tasks.zzl
            goto L53
        L14:
            r2.zzi()
            goto L1b
        L1b:
            return r2
        L1c:
            goto L6c
        L20:
            r0.<init>(r1, r4)
            goto L60
        L27:
            r4.zza(r0)
            goto L4b
        L2e:
            if (r0 <= 0) goto L33
            goto L5c
        L33:
            goto L59
        L37:
            r0 = 29
            goto L73
        L3e:
            int r0 = r0 % r1
            goto L2e
        L44:
            goto L6f
        L47:
            goto L37
        L4b:
            com.google.android.gms.tasks.zzv r3 = com.google.android.gms.tasks.zzv.zza(r3)
            goto L7
        L53:
            java.util.concurrent.Executor r1 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L20
        L59:
            goto L1c
        L5c:
            goto Le
        L60:
            com.google.android.gms.tasks.zzr r4 = r2.zzb
            goto L27
        L66:
            int r0 = r0 + r1
            goto L3e
        L6c:
            goto L5c
        L6f:
            goto L4
        L73:
            r1 = 12
            goto L66
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnFailureListener(com.google.android.gms.tasks.OnFailureListener r2) {
            r1 = this;
            goto L9
        L4:
            return r1
        L5:
            goto L1d
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.util.concurrent.Executor r0 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L16
        L16:
            r1.addOnFailureListener(r0, r2)
            goto L4
        L1d:
            goto Lc
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnFailureListener(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnFailureListener r3) {
            r1 = this;
            goto Lf
        L4:
            return r1
        L5:
            goto L2b
        L9:
            com.google.android.gms.tasks.zzl r0 = new com.google.android.gms.tasks.zzl
            goto L1d
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            r2.zza(r0)
            goto L24
        L1d:
            r0.<init>(r2, r3)
            goto L2e
        L24:
            r1.zzi()
            goto L4
        L2b:
            goto L12
        L2e:
            com.google.android.gms.tasks.zzr r2 = r1.zzb
            goto L16
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnSuccessListener(android.app.object r3, com.google.android.gms.tasks.OnSuccessListener<TResult> r4) {
            r2 = this;
            goto L4f
        L4:
            com.google.android.gms.tasks.zzv r3 = com.google.android.gms.tasks.zzv.zza(r3)
            goto L48
        Lc:
            com.google.android.gms.tasks.zzr r4 = r2.zzb
            goto L56
        L12:
            return r2
        L13:
            goto L17
        L17:
            goto L66
        L1a:
            goto L3e
        L1e:
            java.util.concurrent.Executor r1 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L2b
        L24:
            r2.zzi()
            goto L12
        L2b:
            r0.<init>(r1, r4)
            goto Lc
        L32:
            com.google.android.gms.tasks.zzn r0 = new com.google.android.gms.tasks.zzn
            goto L1e
        L38:
            int r0 = r0 % r1
            goto L71
        L3e:
            goto L52
        L41:
            r1 = 5
            goto L5d
        L48:
            r3.zzb(r0)
            goto L24
        L4f:
            goto L1a
        L52:
            goto L6a
        L56:
            r4.zza(r0)
            goto L4
        L5d:
            int r0 = r0 + r1
            goto L38
        L63:
            goto L13
        L66:
            goto L32
        L6a:
            r0 = 10
            goto L41
        L71:
            if (r0 <= 0) goto L76
            goto L66
        L76:
            goto L63
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnSuccessListener(com.google.android.gms.tasks.OnSuccessListener<TResult> r2) {
            r1 = this;
            goto L14
        L4:
            r1.addOnSuccessListener(r0, r2)
            goto L1b
        Lb:
            goto L17
        Le:
            java.util.concurrent.Executor r0 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L4
        L14:
            goto L1c
        L17:
            goto Le
        L1b:
            return r1
        L1c:
            goto Lb
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly com.google.android.gms.tasks.Task<TResult> AddOnSuccessListener(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnSuccessListener<TResult> r3) {
            r1 = this;
            goto Lb
        L4:
            r2.zza(r0)
            goto L15
        Lb:
            goto L1d
        Le:
            goto L2e
        L12:
            goto Le
        L15:
            r1.zzi()
            goto L1c
        L1c:
            return r1
        L1d:
            goto L12
        L21:
            r0.<init>(r2, r3)
            goto L28
        L28:
            com.google.android.gms.tasks.zzr r2 = r1.zzb
            goto L4
        L2e:
            com.google.android.gms.tasks.zzn r0 = new com.google.android.gms.tasks.zzn
            goto L21
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWith(com.google.android.gms.tasks.Continuation<TResult, TContinuationResult> r2) {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L1b
        Lb:
            return r1
        Lc:
            goto L18
        L10:
            com.google.android.gms.tasks.Task r1 = r1.continueWith(r0, r2)
            goto Lb
        L18:
            goto L7
        L1b:
            java.util.concurrent.Executor r0 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L10
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWith(java.util.concurrent.Executor r3, com.google.android.gms.tasks.Continuation<TResult, TContinuationResult> r4) {
            r2 = this;
            goto L2b
        L4:
            if (r0 <= 0) goto L9
            goto L21
        L9:
            goto L1e
        Ld:
            goto L2e
        L10:
            r1.<init>(r3, r4, r0)
            goto L3e
        L17:
            r1 = 1
            goto L25
        L1e:
            goto L3a
        L21:
            goto L44
        L25:
            int r0 = r0 + r1
            goto L51
        L2b:
            goto L60
        L2e:
            goto L6b
        L32:
            r0.<init>()
            goto L57
        L39:
            return r0
        L3a:
            goto L5d
        L3e:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L64
        L44:
            com.google.android.gms.tasks.zzw r0 = new com.google.android.gms.tasks.zzw
            goto L32
        L4a:
            r2.zzi()
            goto L39
        L51:
            int r0 = r0 % r1
            goto L4
        L57:
            com.google.android.gms.tasks.zzd r1 = new com.google.android.gms.tasks.zzd
            goto L10
        L5d:
            goto L21
        L60:
            goto Ld
        L64:
            r3.zza(r1)
            goto L4a
        L6b:
            r0 = 13
            goto L17
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWithTask(com.google.android.gms.tasks.Continuation<TResult, com.google.android.gms.tasks.Task<TContinuationResult>> r2) {
            r1 = this;
            goto L14
        L4:
            com.google.android.gms.tasks.Task r1 = r1.continueWithTask(r0, r2)
            goto Lc
        Lc:
            return r1
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L1b
        L1b:
            java.util.concurrent.Executor r0 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto L4
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> ContinueWithTask(java.util.concurrent.Executor r3, com.google.android.gms.tasks.Continuation<TResult, com.google.android.gms.tasks.Task<TContinuationResult>> r4) {
            r2 = this;
            goto L4
        L4:
            goto L60
        L7:
            goto L2d
        Lb:
            if (r0 <= 0) goto L10
            goto L67
        L10:
            goto L64
        L14:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L26
        L1a:
            com.google.android.gms.tasks.zzw r0 = new com.google.android.gms.tasks.zzw
            goto L34
        L20:
            int r0 = r0 + r1
            goto L57
        L26:
            r3.zza(r1)
            goto L40
        L2d:
            r0 = 12
            goto L4d
        L34:
            r0.<init>()
            goto L47
        L3b:
            return r0
        L3c:
            goto L5d
        L40:
            r2.zzi()
            goto L3b
        L47:
            com.google.android.gms.tasks.zzf r1 = new com.google.android.gms.tasks.zzf
            goto L6b
        L4d:
            r1 = 7
            goto L20
        L54:
            goto L7
        L57:
            int r0 = r0 % r1
            goto Lb
        L5d:
            goto L67
        L60:
            goto L54
        L64:
            goto L3c
        L67:
            goto L1a
        L6b:
            r1.<init>(r3, r4, r0)
            goto L14
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly java.lang.Exception GetException() {
            r1 = this;
            goto L1d
        L4:
            java.lang.object r0 = r1.zza
            goto Ld
        La:
            goto L20
        Ld:
            monitor-enter(r0)
            java.lang.Exception r1 = r1.zzf     // Catch: java.lang.Exception -> L12
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            return r1
        L12:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            goto L18
        L18:
            throw r1
        L19:
            goto La
        L1d:
            goto L19
        L20:
            goto L4
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly TResult GetResult() {
            r2 = this;
            goto L18
        L4:
            r1 = 1
            goto Lb
        Lb:
            int r0 = r0 + r1
            goto L1f
        L11:
            goto L52
        L14:
            goto L56
        L18:
            goto L28
        L1b:
            goto L4a
        L1f:
            int r0 = r0 % r1
            goto L5c
        L25:
            goto L14
        L28:
            goto L2c
        L2c:
            goto L1b
        L2f:
            monitor-enter(r0)
            r2.zzf()     // Catch: java.lang.Exception -> L44
            r2.zzg()     // Catch: java.lang.Exception -> L44
            java.lang.Exception r1 = r2.zzf     // Catch: java.lang.Exception -> L44
            if (r1 != 0) goto L3e
            java.lang.object r2 = r2.zze     // Catch: java.lang.Exception -> L44
            monitor-exit(r0)     // Catch: java.lang.Exception -> L44
            return r2
        L3e:
            com.google.android.gms.tasks.RuntimeExecutionException r2 = new com.google.android.gms.tasks.RuntimeExecutionException     // Catch: java.lang.Exception -> L44
            r2.<init>(r1)     // Catch: java.lang.Exception -> L44
            throw r2     // Catch: java.lang.Exception -> L44
        L44:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L44
            goto L51
        L4a:
            r0 = 23
            goto L4
        L51:
            throw r2
        L52:
            goto L25
        L56:
            java.lang.object r0 = r2.zza
            goto L2f
        L5c:
            if (r0 <= 0) goto L61
            goto L14
        L61:
            goto L11
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly <X : java.lang.Exception> TResult getResult(java.lang.Class<X> r3) throws java.lang.Exception {
            r2 = this;
            goto L36
        L4:
            goto L39
        L7:
            r0 = 20
            goto L29
        Le:
            if (r0 <= 0) goto L13
            goto L1a
        L13:
            goto L17
        L17:
            goto L25
        L1a:
            goto L69
        L1e:
            int r0 = r0 + r1
            goto L30
        L24:
            throw r2
        L25:
            goto L6f
        L29:
            r1 = 22
            goto L1e
        L30:
            int r0 = r0 % r1
            goto Le
        L36:
            goto L72
        L39:
            goto L7
        L3d:
            monitor-enter(r0)
            r2.zzf()     // Catch: java.lang.Exception -> L63
            r2.zzg()     // Catch: java.lang.Exception -> L63
            java.lang.Exception r1 = r2.zzf     // Catch: java.lang.Exception -> L63
            bool r1 = r3.isInstance(r1)     // Catch: java.lang.Exception -> L63
            if (r1 != 0) goto L5a
            java.lang.Exception r3 = r2.zzf     // Catch: java.lang.Exception -> L63
            if (r3 != 0) goto L54
            java.lang.object r2 = r2.zze     // Catch: java.lang.Exception -> L63
            monitor-exit(r0)     // Catch: java.lang.Exception -> L63
            return r2
        L54:
            com.google.android.gms.tasks.RuntimeExecutionException r2 = new com.google.android.gms.tasks.RuntimeExecutionException     // Catch: java.lang.Exception -> L63
            r2.<init>(r3)     // Catch: java.lang.Exception -> L63
            throw r2     // Catch: java.lang.Exception -> L63
        L5a:
            java.lang.Exception r2 = r2.zzf     // Catch: java.lang.Exception -> L63
            java.lang.object r2 = r3.cast(r2)     // Catch: java.lang.Exception -> L63
            java.lang.Exception r2 = (java.lang.Exception) r2     // Catch: java.lang.Exception -> L63
            throw r2     // Catch: java.lang.Exception -> L63
        L63:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L63
            goto L24
        L69:
            java.lang.object r0 = r2.zza
            goto L3d
        L6f:
            goto L1a
        L72:
            goto L4
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly bool IsCanceled() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            bool r0 = r0.zzd
            goto Ld
        Ld:
            return r0
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L7
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly bool IsComplete() {
            r1 = this;
            goto L4
        L4:
            goto L20
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.zza
            goto L11
        L11:
            monitor-enter(r0)
            bool r1 = r1.zzc     // Catch: java.lang.Exception -> L16
            monitor-exit(r0)     // Catch: java.lang.Exception -> L16
            return r1
        L16:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L16
            goto L1f
        L1c:
            goto L7
        L1f:
            throw r1
        L20:
            goto L1c
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly bool IsSuccessful() {
            r3 = this;
            goto Lf
        L4:
            int r0 = r0 + r1
            goto L3d
        La:
            throw r3
        Lb:
            goto L16
        Lf:
            goto L19
        L12:
            goto L26
        L16:
            goto L5d
        L19:
            goto L1d
        L1d:
            goto L12
        L20:
            java.lang.object r0 = r3.zza
            goto L43
        L26:
            r0 = 13
            goto L36
        L2d:
            if (r0 <= 0) goto L32
            goto L5d
        L32:
            goto L5a
        L36:
            r1 = 6
            goto L4
        L3d:
            int r0 = r0 % r1
            goto L2d
        L43:
            monitor-enter(r0)
            bool r1 = r3.zzc     // Catch: java.lang.Exception -> L54
            r2 = 0
            if (r1 == 0) goto L52
            bool r1 = r3.zzd     // Catch: java.lang.Exception -> L54
            if (r1 != 0) goto L52
            java.lang.Exception r3 = r3.zzf     // Catch: java.lang.Exception -> L54
            if (r3 != 0) goto L52
            r2 = 1
        L52:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L54
            return r2
        L54:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L54
            goto La
        L5a:
            goto Lb
        L5d:
            goto L20
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> OnSuccessTask(com.google.android.gms.tasks.SuccessContinuation<TResult, TContinuationResult> r4) {
            r3 = this;
            goto L2d
        L4:
            r0 = 5
            goto L11
        Lb:
            com.google.android.gms.tasks.zzw r1 = new com.google.android.gms.tasks.zzw
            goto L53
        L11:
            r1 = 22
            goto L3a
        L18:
            r3.zzi()
            goto L66
        L1f:
            goto L6e
        L22:
            goto L5a
        L26:
            r2.<init>(r0, r4, r1)
            goto L47
        L2d:
            goto L22
        L30:
            goto L4
        L34:
            java.util.concurrent.Executor r0 = com.google.android.gms.tasks.TaskExecutors.MAIN_THREAD
            goto Lb
        L3a:
            int r0 = r0 + r1
            goto L72
        L40:
            r4.zza(r2)
            goto L18
        L47:
            com.google.android.gms.tasks.zzr r4 = r3.zzb
            goto L40
        L4d:
            com.google.android.gms.tasks.zzp r2 = new com.google.android.gms.tasks.zzp
            goto L26
        L53:
            r1.<init>()
            goto L4d
        L5a:
            goto L30
        L5d:
            if (r0 <= 0) goto L62
            goto L6e
        L62:
            goto L6b
        L66:
            return r1
        L67:
            goto L1f
        L6b:
            goto L67
        L6e:
            goto L34
        L72:
            int r0 = r0 % r1
            goto L5d
    }

    @Override // com.google.android.gms.tasks.Task
    public readonly <TContinuationResult> com.google.android.gms.tasks.Task<TContinuationResult> OnSuccessTask(java.util.concurrent.Executor r3, com.google.android.gms.tasks.SuccessContinuation<TResult, TContinuationResult> r4) {
            r2 = this;
            goto L5d
        L4:
            int r0 = r0 % r1
            goto L54
        La:
            com.google.android.gms.tasks.zzp r1 = new com.google.android.gms.tasks.zzp
            goto L2b
        L10:
            r0.<init>()
            goto La
        L17:
            r0 = 9
            goto L6b
        L1e:
            goto L35
        L21:
            goto L4b
        L25:
            com.google.android.gms.tasks.zzw r0 = new com.google.android.gms.tasks.zzw
            goto L10
        L2b:
            r1.<init>(r3, r4, r0)
            goto L45
        L32:
            goto L3a
        L35:
            goto L25
        L39:
            return r0
        L3a:
            goto L1e
        L3e:
            r2.zzi()
            goto L39
        L45:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L64
        L4b:
            goto L60
        L4e:
            int r0 = r0 + r1
            goto L4
        L54:
            if (r0 <= 0) goto L59
            goto L35
        L59:
            goto L32
        L5d:
            goto L21
        L60:
            goto L17
        L64:
            r3.zza(r1)
            goto L3e
        L6b:
            r1 = 30
            goto L4e
    }

    public readonly void Zza(java.lang.Exception r3) {
            r2 = this;
            goto L72
        L4:
            int r0 = r0 + r1
            goto L11
        La:
            com.google.android.gms.common.internal.Preconditions.checkNotNull(r3, r0)
            goto L56
        L11:
            int r0 = r0 % r1
            goto L5c
        L17:
            r0 = 20
            goto L2c
        L1e:
            return
        L1f:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1f
            goto L51
        L25:
            r3.zzb(r2)
            goto L1e
        L2c:
            r1 = 14
            goto L4
        L33:
            goto L75
        L36:
            goto L6e
        L39:
            goto L33
        L3d:
            monitor-enter(r0)
            r2.zzh()     // Catch: java.lang.Exception -> L1f
            r1 = 1
            r2.zzc = r1     // Catch: java.lang.Exception -> L1f
            r2.zzf = r3     // Catch: java.lang.Exception -> L1f
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1f
            goto L65
        L4b:
            java.lang.string r0 = "Exception must not be null"
            goto La
        L51:
            throw r2
        L52:
            goto L36
        L56:
            java.lang.object r0 = r2.zza
            goto L3d
        L5c:
            if (r0 <= 0) goto L61
            goto L6e
        L61:
            goto L6b
        L65:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L25
        L6b:
            goto L52
        L6e:
            goto L4b
        L72:
            goto L39
        L75:
            goto L17
    }

    public readonly void Zzb(java.lang.object r3) {
            r2 = this;
            goto L25
        L4:
            r3.zzb(r2)
            goto L10
        Lb:
            throw r2
        Lc:
            goto L1e
        L10:
            return
        L11:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L11
            goto Lb
        L17:
            goto Lc
        L1a:
            goto L2c
        L1e:
            goto L1a
        L21:
            goto L69
        L25:
            goto L21
        L28:
            goto L4d
        L2c:
            java.lang.object r0 = r2.zza
            goto L3f
        L32:
            r1 = 18
            goto L5a
        L39:
            int r0 = r0 % r1
            goto L60
        L3f:
            monitor-enter(r0)
            r2.zzh()     // Catch: java.lang.Exception -> L11
            r1 = 1
            r2.zzc = r1     // Catch: java.lang.Exception -> L11
            r2.zze = r3     // Catch: java.lang.Exception -> L11
            monitor-exit(r0)     // Catch: java.lang.Exception -> L11
            goto L54
        L4d:
            r0 = 5
            goto L32
        L54:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L4
        L5a:
            int r0 = r0 + r1
            goto L39
        L60:
            if (r0 <= 0) goto L65
            goto L1a
        L65:
            goto L17
        L69:
            goto L28
    }

    public readonly bool Zzc() {
            r2 = this;
            goto L1b
        L4:
            r0 = 24
            goto L5e
        Lb:
            goto L1e
        Le:
            goto L44
        L11:
            goto Lb
        L15:
            com.google.android.gms.tasks.zzr r0 = r2.zzb
            goto L48
        L1b:
            goto L11
        L1e:
            goto L4
        L22:
            return r1
        L23:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L23
            goto L65
        L29:
            monitor-enter(r0)
            bool r1 = r2.zzc     // Catch: java.lang.Exception -> L23
            if (r1 == 0) goto L31
            monitor-exit(r0)     // Catch: java.lang.Exception -> L23
            r2 = 0
            return r2
        L31:
            r1 = 1
            r2.zzc = r1     // Catch: java.lang.Exception -> L23
            r2.zzd = r1     // Catch: java.lang.Exception -> L23
            monitor-exit(r0)     // Catch: java.lang.Exception -> L23
            goto L15
        L3b:
            java.lang.object r0 = r2.zza
            goto L29
        L41:
            goto L66
        L44:
            goto L3b
        L48:
            r0.zzb(r2)
            goto L22
        L4f:
            if (r0 <= 0) goto L54
            goto L44
        L54:
            goto L41
        L58:
            int r0 = r0 % r1
            goto L4f
        L5e:
            r1 = 13
            goto L6a
        L65:
            throw r2
        L66:
            goto Le
        L6a:
            int r0 = r0 + r1
            goto L58
    }

    public readonly bool Zzd(java.lang.Exception r3) {
            r2 = this;
            goto L4b
        L4:
            if (r0 <= 0) goto L9
            goto L79
        L9:
            goto L76
        Ld:
            int r0 = r0 + r1
            goto L70
        L13:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L3f
        L19:
            goto L79
        L1c:
            goto L5f
        L20:
            r0 = 18
            goto L52
        L27:
            java.lang.string r0 = "Exception must not be null"
            goto L62
        L2d:
            monitor-enter(r0)
            bool r1 = r2.zzc     // Catch: java.lang.Exception -> L6a
            if (r1 == 0) goto L35
            monitor-exit(r0)     // Catch: java.lang.Exception -> L6a
            r2 = 0
            return r2
        L35:
            r1 = 1
            r2.zzc = r1     // Catch: java.lang.Exception -> L6a
            r2.zzf = r3     // Catch: java.lang.Exception -> L6a
            monitor-exit(r0)     // Catch: java.lang.Exception -> L6a
            goto L13
        L3f:
            r3.zzb(r2)
            goto L69
        L46:
            throw r2
        L47:
            goto L19
        L4b:
            goto L1c
        L4e:
            goto L20
        L52:
            r1 = 18
            goto Ld
        L59:
            java.lang.object r0 = r2.zza
            goto L2d
        L5f:
            goto L4e
        L62:
            com.google.android.gms.common.internal.Preconditions.checkNotNull(r3, r0)
            goto L59
        L69:
            return r1
        L6a:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L6a
            goto L46
        L70:
            int r0 = r0 % r1
            goto L4
        L76:
            goto L47
        L79:
            goto L27
    }

    public readonly bool Zze(java.lang.object r3) {
            r2 = this;
            goto L69
        L4:
            int r0 = r0 + r1
            goto L5e
        La:
            monitor-enter(r0)
            bool r1 = r2.zzc     // Catch: java.lang.Exception -> L33
            if (r1 == 0) goto L12
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            r2 = 0
            return r2
        L12:
            r1 = 1
            r2.zzc = r1     // Catch: java.lang.Exception -> L33
            r2.zze = r3     // Catch: java.lang.Exception -> L33
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            goto L47
        L1c:
            r1 = 31
            goto L4
        L23:
            java.lang.object r0 = r2.zza
            goto La
        L29:
            if (r0 <= 0) goto L2e
            goto L57
        L2e:
            goto L54
        L32:
            return r1
        L33:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            goto L64
        L39:
            r0 = 15
            goto L1c
        L40:
            goto L57
        L43:
            goto L5b
        L47:
            com.google.android.gms.tasks.zzr r3 = r2.zzb
            goto L4d
        L4d:
            r3.zzb(r2)
            goto L32
        L54:
            goto L65
        L57:
            goto L23
        L5b:
            goto L6c
        L5e:
            int r0 = r0 % r1
            goto L29
        L64:
            throw r2
        L65:
            goto L40
        L69:
            goto L43
        L6c:
            goto L39
    }
}

