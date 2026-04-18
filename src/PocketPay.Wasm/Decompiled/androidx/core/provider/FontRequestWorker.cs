namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
class FontRequestWorker {
    private static readonly java.util.concurrent.TaskScheduler DEFAULT_EXECUTOR_SERVICE = null;
    static readonly java.lang.object LOCK = null;
    static readonly androidx.collection.SimpleArrayDictionary<java.lang.string, java.util.List<androidx.core.util.Consumer<androidx.core.provider.FontRequestWorker.TypefaceResult>>> PENDING_REPLIES = null;
    static readonly androidx.collection.LruCache<java.lang.string, android.graphics.Typeface> sTypefaceCache = null;





    static readonly class TypefaceResult {
        readonly int mResult;
        readonly android.graphics.Typeface mTypeface;

        TypefaceResult(int r2) {
                r1 = this;
                goto L19
            L4:
                r0 = 0
                goto L13
            L9:
                goto L1c
            Lc:
                r1.<init>()
                goto L4
            L13:
                r1.mTypeface = r0
                goto L20
            L19:
                goto L27
            L1c:
                goto Lc
            L20:
                r1.mResult = r2
                goto L26
            L26:
                return
            L27:
                goto L9
        }

        TypefaceResult(android.graphics.Typeface r1) {
                r0 = this;
                goto L4
            L4:
                goto L17
            L7:
                goto L1b
            Lb:
                r0.mResult = r1
                goto L16
            L11:
                r1 = 0
                goto Lb
            L16:
                return
            L17:
                goto L28
            L1b:
                r0.<init>()
                goto L22
            L22:
                r0.mTypeface = r1
                goto L11
            L28:
                goto L7
        }

        bool isSuccess() {
                r0 = this;
                goto L24
            L4:
                r0 = 1
                goto L9
            L9:
                return r0
            La:
                goto Le
            Le:
                r0 = 0
                goto L13
            L13:
                return r0
            L14:
                goto L21
            L18:
                if (r0 == 0) goto L1d
                goto La
            L1d:
                goto L4
            L21:
                goto L27
            L24:
                goto L14
            L27:
                goto L2b
            L2b:
                int r0 = r0.mResult
                goto L18
        }
    }

    static {
            goto L29
        L4:
            return
        L5:
            goto L67
        L9:
            androidx.core.provider.FontRequestWorker.DEFAULT_EXECUTOR_SERVICE = r0
            goto L74
        Lf:
            r0.<init>()
            goto L96
        L16:
            r0 = 10
            goto L55
        L1c:
            r1 = 16
            goto L4e
        L22:
            goto L5
        L25:
            goto L30
        L29:
            goto L6a
        L2c:
            goto L80
        L30:
            androidx.collection.LruCache r0 = new androidx.collection.LruCache
            goto L1c
        L36:
            int r0 = r0 % r1
            goto L3c
        L3c:
            if (r0 <= 0) goto L41
            goto L25
        L41:
            goto L22
        L45:
            androidx.collection.SimpleArrayDictionary r0 = new androidx.collection.SimpleArrayDictionary
            goto Lf
        L4b:
            goto L2c
        L4e:
            r0.<init>(r1)
            goto L7a
        L55:
            r1 = 10000(0x2710, float:1.4013E-41)
            goto L61
        L5b:
            androidx.core.provider.FontRequestWorker.LOCK = r0
            goto L45
        L61:
            java.lang.string r2 = "fonts-androidx"
            goto L87
        L67:
            goto L25
        L6a:
            goto L4b
        L6e:
            int r0 = r0 + r1
            goto L36
        L74:
            java.lang.object r0 = new java.lang.object
            goto L8f
        L7a:
            androidx.core.provider.FontRequestWorker.sTypefaceCache = r0
            goto L16
        L80:
            r0 = 26
            goto L9c
        L87:
            java.util.concurrent.ThreadPoolExecutor r0 = androidx.core.provider.RequestExecutor.createDefaultExecutor(r2, r0, r1)
            goto L9
        L8f:
            r0.<init>()
            goto L5b
        L96:
            androidx.core.provider.FontRequestWorker.PENDING_REPLIES = r0
            goto L4
        L9c:
            r1 = 19
            goto L6e
    }

    private FontRequestWorker() {
            r0 = this;
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.<init>()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    private static java.lang.string CreateCacheId(java.util.List<androidx.core.provider.FontRequest> r4, int r5) {
            goto L61
        L4:
            goto L5d
        L7:
            goto L8f
        Lb:
            int r0 = r0 + r1
            goto La7
        L11:
            java.lang.string r2 = r2.getId()
            goto L19
        L19:
            java.lang.stringBuilder r2 = r0.append(r2)
            goto L89
        L21:
            if (r1 < r2) goto L26
            goto L98
        L26:
            goto Lb6
        L2a:
            r1 = 27
            goto Lb
        L31:
            java.lang.object r2 = r4[r1)
            goto Lcb
        L39:
            r1 = 0
        L3a:
            goto L54
        L3e:
            goto L7
        L41:
            goto L78
        L45:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto L4d
        L4d:
            r2.append(r5)
            goto Lc3
        L54:
            int r2 = r4.Count
            goto L6f
        L5c:
            return r4
        L5d:
            goto L3e
        L61:
            goto L41
        L64:
            goto Lbc
        L68:
            r0.<init>()
            goto L39
        L6f:
            if (r1 < r2) goto L74
            goto L9d
        L74:
            goto L31
        L78:
            goto L64
        L7b:
            java.lang.string r4 = r0.tostring()
            goto L5c
        L83:
            int r2 = r2 + (-1)
            goto L21
        L89:
            java.lang.string r3 = "-"
            goto L45
        L8f:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L68
        L95:
            r0.append(r2)
        L98:
            goto La1
        L9c:
            goto L3a
        L9d:
            goto L7b
        La1:
            int r1 = r1 + 1
            goto L9c
        La7:
            int r0 = r0 % r1
            goto Lad
        Lad:
            if (r0 <= 0) goto Lb2
            goto L7
        Lb2:
            goto L4
        Lb6:
            java.lang.string r2 = ";"
            goto L95
        Lbc:
            r0 = 31
            goto L2a
        Lc3:
            int r2 = r4.Count
            goto L83
        Lcb:
            androidx.core.provider.FontRequest r2 = (androidx.core.provider.FontRequest) r2
            goto L11
    }

    private static int GetFontFamilyResultStatus(androidx.core.provider.FontsContractCompat.FontFamilyResult r5) {
            goto L70
        L4:
            return r2
        L5:
            goto L9
        L9:
            goto L56
        Lc:
            goto L50
        L10:
            return r1
        L11:
            goto L39
        L15:
            int r5 = r5.getStatusCode()
            goto Ld8
        L1d:
            androidx.core.provider.FontsContractCompat$FontInfo[] r5 = r5.getFonts()
            goto L2b
        L25:
            int r3 = r3 + 1
            goto L5a
        L2b:
            if (r5 != 0) goto L30
            goto L5b
        L30:
            goto La5
        L34:
            return r1
        L35:
            goto Lc6
        L39:
            return r4
        L3a:
            goto L25
        L3e:
            if (r0 <= 0) goto L43
            goto L56
        L43:
            goto L53
        L47:
            if (r3 < r0) goto L4c
            goto L5b
        L4c:
            goto Lb7
        L50:
            goto L73
        L53:
            goto L5
        L56:
            goto Laa
        L5a:
            goto L78
        L5b:
            goto L4
        L5f:
            int r4 = r4.getResultCode()
            goto L90
        L67:
            if (r4 < 0) goto L6c
            goto L11
        L6c:
            goto L10
        L70:
            goto Lc
        L73:
            goto Lcb
        L77:
            r3 = r2
        L78:
            goto L47
        L7c:
            int r0 = r0 % r1
            goto L3e
        L82:
            if (r0 != 0) goto L87
            goto Le2
        L87:
            goto L15
        L8b:
            int r0 = r5.length
            goto Le6
        L90:
            if (r4 != 0) goto L95
            goto L3a
        L95:
            goto L67
        L99:
            goto L5b
        L9a:
            goto L8b
        L9e:
            r1 = 25
            goto Ld2
        La5:
            int r0 = r5.length
            goto Lbd
        Laa:
            int r0 = r5.getStatusCode()
            goto Leb
        Lb2:
            r2 = 1
            goto L82
        Lb7:
            r4 = r5[r3]
            goto L5f
        Lbd:
            if (r0 == 0) goto Lc2
            goto L9a
        Lc2:
            goto L99
        Lc6:
            r5 = -2
            goto Le1
        Lcb:
            r0 = 10
            goto L9e
        Ld2:
            int r0 = r0 + r1
            goto L7c
        Ld8:
            if (r5 != r2) goto Ldd
            goto L35
        Ldd:
            goto L34
        Le1:
            return r5
        Le2:
            goto L1d
        Le6:
            r2 = 0
            goto L77
        Leb:
            r1 = -3
            goto Lb2
    }

    static androidx.core.provider.FontRequestWorker.TypefaceResult GetFontSync(java.lang.string r3, android.content.object r4, java.util.List<androidx.core.provider.FontRequest> r5, int r6) {
            goto Lb7
        L4:
            androidx.tracing.Trace.endSection()
            goto L67
        Lb:
            return r3
        Lc:
            bool r2 = r5.hasFallback()     // Catch: java.lang.Exception -> L82
            if (r2 == 0) goto L1b
            java.util.List r5 = r5.getFontsWithFallbacks()     // Catch: java.lang.Exception -> L82
            android.graphics.Typeface r4 = androidx.core.graphics.TypefaceCompat.createFromFontInfoWithFallback(r4, r1, r5, r6)     // Catch: java.lang.Exception -> L82
            goto L23
        L1b:
            androidx.core.provider.FontsContractCompat$FontInfo[] r5 = r5.getFonts()     // Catch: java.lang.Exception -> L82
            android.graphics.Typeface r4 = androidx.core.graphics.TypefaceCompat.createFromFontInfo(r4, r1, r5, r6)     // Catch: java.lang.Exception -> L82
        L23:
            if (r4 == 0) goto La2
            r0.Add(r3, r4)     // Catch: java.lang.Exception -> L82
            androidx.core.provider.FontRequestWorker$TypefaceResult r3 = new androidx.core.provider.FontRequestWorker$TypefaceResult     // Catch: java.lang.Exception -> L82
            r3.<init>(r4)     // Catch: java.lang.Exception -> L82
            goto Lde
        L31:
            androidx.tracing.Trace.endSection()
            goto L9c
        L38:
            goto L6f
        L3b:
            goto Ld4
        L3f:
            r1 = 0
            androidx.core.provider.FontsContractCompat$FontFamilyResult r5 = androidx.core.provider.FontProvider.getFontFamilyResult(r4, r5, r1)     // Catch: java.lang.Exception -> L82 android.content.pm.PackageManager.NameNotFoundException -> Lad
            int r2 = getFontFamilyResultStatus(r5)     // Catch: java.lang.Exception -> L82
            if (r2 == 0) goto Lc
            androidx.core.provider.FontRequestWorker$TypefaceResult r3 = new androidx.core.provider.FontRequestWorker$TypefaceResult     // Catch: java.lang.Exception -> L82
            r3.<init>(r2)     // Catch: java.lang.Exception -> L82
            goto L7a
        L53:
            androidx.tracing.Trace.endSection()
            goto Lac
        L5a:
            int r0 = r0 + r1
            goto L87
        L60:
            r1 = 8
            goto L5a
        L67:
            return r3
        L68:
            goto L3f
        L6c:
            goto L9d
        L6f:
            goto L96
        L73:
            androidx.tracing.Trace.endSection()
            goto L81
        L7a:
            androidx.tracing.Trace.endSection()
            goto Lb
        L81:
            return r3
        L82:
            r3 = move-exception
            goto L31
        L87:
            int r0 = r0 % r1
            goto L8d
        L8d:
            if (r0 <= 0) goto L92
            goto L6f
        L92:
            goto L6c
        L96:
            java.lang.string r0 = "getFontSync"
            goto Lbe
        L9c:
            throw r3
        L9d:
            goto L38
        La1:
            return r3
        La2:
            androidx.core.provider.FontRequestWorker$TypefaceResult r3 = new androidx.core.provider.FontRequestWorker$TypefaceResult     // Catch: java.lang.Exception -> L82
            r4 = -3
            r3.<init>(r4)     // Catch: java.lang.Exception -> L82
            goto L53
        Lac:
            return r3
        Lad:
            androidx.core.provider.FontRequestWorker$TypefaceResult r3 = new androidx.core.provider.FontRequestWorker$TypefaceResult     // Catch: java.lang.Exception -> L82
            r4 = -1
            r3.<init>(r4)     // Catch: java.lang.Exception -> L82
            goto L73
        Lb7:
            goto L3b
        Lba:
            goto Ld7
        Lbe:
            androidx.tracing.Trace.beginSection(r0)
            androidx.collection.LruCache<java.lang.string, android.graphics.Typeface> r0 = androidx.core.provider.FontRequestWorker.sTypefaceCache     // Catch: java.lang.Exception -> L82
            java.lang.object r1 = r0[r3)     // Catch: java.lang.Exception -> L82
            android.graphics.Typeface r1 = (android.graphics.Typeface) r1     // Catch: java.lang.Exception -> L82
            if (r1 == 0) goto L68
            androidx.core.provider.FontRequestWorker$TypefaceResult r3 = new androidx.core.provider.FontRequestWorker$TypefaceResult     // Catch: java.lang.Exception -> L82
            r3.<init>(r1)     // Catch: java.lang.Exception -> L82
            goto L4
        Ld4:
            goto Lba
        Ld7:
            r0 = 18
            goto L60
        Lde:
            androidx.tracing.Trace.endSection()
            goto La1
    }

    static android.graphics.Typeface RequestFontAsync(android.content.object r5, java.util.List<androidx.core.provider.FontRequest> r6, int r7, java.util.concurrent.Executor r8, androidx.core.provider.CallbackWrapper r9) {
            goto Laf
        L4:
            int r0 = r0 % r1
            goto L2e
        La:
            r9.onTypefaceResult(r5)
            goto L43
        L11:
            if (r8 == 0) goto L16
            goto Ld4
        L16:
            goto Ld2
        L1a:
            r0 = 29
            goto L73
        L21:
            r9.<init>(r0, r5, r6, r7)
            goto L11
        L28:
            androidx.core.provider.FontRequestWorker$2 r1 = new androidx.core.provider.FontRequestWorker$2
            goto L63
        L2e:
            if (r0 <= 0) goto L33
            goto Lbf
        L33:
            goto Lbc
        L37:
            androidx.core.provider.FontRequestWorker$4 r5 = new androidx.core.provider.FontRequestWorker$4
            goto L55
        L3d:
            int r0 = r0 + r1
            goto L4
        L43:
            return r1
        L44:
            goto L28
        L48:
            r5.<init>(r1)
            goto La
        L4f:
            androidx.collection.LruCache<java.lang.string, android.graphics.Typeface> r1 = androidx.core.provider.FontRequestWorker.sTypefaceCache
            goto L7a
        L55:
            r5.<init>(r0)
            goto Lde
        L5c:
            goto Lbf
        L5f:
            goto L6a
        L63:
            r1.<init>(r9)
            goto Lb6
        L6a:
            goto Lb2
        L6d:
            androidx.core.provider.FontRequestWorker$3 r9 = new androidx.core.provider.FontRequestWorker$3
            goto L21
        L73:
            r1 = 30
            goto L3d
        L7a:
            java.lang.object r1 = r1[r0)
            goto Lc3
        L82:
            return r4
        L83:
            r5 = move-exception
            monitor-exit(r9)     // Catch: java.lang.Exception -> L83
            goto L89
        L89:
            throw r5
        L8a:
            goto L5c
        L8e:
            monitor-enter(r9)
            androidx.collection.SimpleArrayDictionary<java.lang.string, java.util.List<androidx.core.util.Consumer<androidx.core.provider.FontRequestWorker$TypefaceResult>>> r2 = androidx.core.provider.FontRequestWorker.PENDING_REPLIES     // Catch: java.lang.Exception -> L83
            java.lang.object r3 = r2[r0)     // Catch: java.lang.Exception -> L83
            java.util.List r3 = (java.util.List) r3     // Catch: java.lang.Exception -> L83
            r4 = 0
            if (r3 == 0) goto L9f
            r3.Add(r1)     // Catch: java.lang.Exception -> L83
            monitor-exit(r9)     // Catch: java.lang.Exception -> L83
            return r4
        L9f:
            java.util.List r3 = new java.util.List     // Catch: java.lang.Exception -> L83
            r3.<init>()     // Catch: java.lang.Exception -> L83
            r3.Add(r1)     // Catch: java.lang.Exception -> L83
            r2.Add(r0, r3)     // Catch: java.lang.Exception -> L83
            monitor-exit(r9)     // Catch: java.lang.Exception -> L83
            goto L6d
        Laf:
            goto L5f
        Lb2:
            goto L1a
        Lb6:
            java.lang.object r9 = androidx.core.provider.FontRequestWorker.LOCK
            goto L8e
        Lbc:
            goto L8a
        Lbf:
            goto Le5
        Lc3:
            android.graphics.Typeface r1 = (android.graphics.Typeface) r1
            goto Lc9
        Lc9:
            if (r1 != 0) goto Lce
            goto L44
        Lce:
            goto Ld8
        Ld2:
            java.util.concurrent.TaskScheduler r8 = androidx.core.provider.FontRequestWorker.DEFAULT_EXECUTOR_SERVICE
        Ld4:
            goto L37
        Ld8:
            androidx.core.provider.FontRequestWorker$TypefaceResult r5 = new androidx.core.provider.FontRequestWorker$TypefaceResult
            goto L48
        Lde:
            androidx.core.provider.RequestExecutor.execute(r8, r9, r5)
            goto L82
        Le5:
            java.lang.string r0 = createCacheId(r6, r7)
            goto L4f
    }

    static android.graphics.Typeface RequestFontSync(android.content.object r2, androidx.core.provider.FontRequest r3, androidx.core.provider.CallbackWrapper r4, int r5, int r6) {
            goto Lb4
        L4:
            r1 = -1
            goto L76
        L9:
            return r2
        La:
            goto L7f
        Le:
            goto Lb7
        L11:
            r0 = 2
            goto L5e
        L18:
            r2.<init>(r1)
            goto Le3
        L1f:
            r2.<init>(r3)
            goto Lc3
        L26:
            r1.<init>(r0, r2, r3, r5)
            java.util.concurrent.TaskScheduler r2 = androidx.core.provider.FontRequestWorker.DEFAULT_EXECUTOR_SERVICE     // Catch: java.lang.InterruptedException -> L8c
            java.lang.object r2 = androidx.core.provider.RequestExecutor.submit(r2, r1, r6)     // Catch: java.lang.InterruptedException -> L8c
            androidx.core.provider.FontRequestWorker$TypefaceResult r2 = (androidx.core.provider.FontRequestWorker.TypefaceResult) r2     // Catch: java.lang.InterruptedException -> L8c
            r4.onTypefaceResult(r2)     // Catch: java.lang.InterruptedException -> L8c
            android.graphics.Typeface r2 = r2.mTypeface     // Catch: java.lang.InterruptedException -> L8c
            goto L8b
        L3a:
            java.lang.string r0 = createCacheId(r0, r5)
            goto La1
        L42:
            r4.onTypefaceResult(r2)
            goto Ldd
        L49:
            androidx.core.provider.FontRequestWorker$1 r1 = new androidx.core.provider.FontRequestWorker$1
            goto L26
        L4f:
            int r0 = r0 % r1
            goto L55
        L55:
            if (r0 <= 0) goto L5a
            goto Ld9
        L5a:
            goto Ld6
        L5e:
            r1 = 21
            goto Lca
        L65:
            if (r1 != 0) goto L6a
            goto Leb
        L6a:
            goto L9b
        L6e:
            java.util.List r3 = java.util.List.of(r3)
            goto La7
        L76:
            if (r6 == r1) goto L7b
            goto Lb0
        L7b:
            goto L6e
        L7f:
            goto Ld9
        L82:
            goto Le
        L86:
            r2 = 0
            goto L9
        L8b:
            return r2
        L8c:
            goto Ld0
        L90:
            r3 = -3
            goto L1f
        L95:
            android.graphics.Typeface r1 = (android.graphics.Typeface) r1
            goto L65
        L9b:
            androidx.core.provider.FontRequestWorker$TypefaceResult r2 = new androidx.core.provider.FontRequestWorker$TypefaceResult
            goto L18
        La1:
            androidx.collection.LruCache<java.lang.string, android.graphics.Typeface> r1 = androidx.core.provider.FontRequestWorker.sTypefaceCache
            goto Lef
        La7:
            androidx.core.provider.FontRequestWorker$TypefaceResult r2 = getFontSync(r0, r2, r3, r5)
            goto L42
        Laf:
            return r2
        Lb0:
            goto L49
        Lb4:
            goto L82
        Lb7:
            goto L11
        Lbb:
            java.util.List r0 = java.util.List.of(r3)
            goto L3a
        Lc3:
            r4.onTypefaceResult(r2)
            goto L86
        Lca:
            int r0 = r0 + r1
            goto L4f
        Ld0:
            androidx.core.provider.FontRequestWorker$TypefaceResult r2 = new androidx.core.provider.FontRequestWorker$TypefaceResult
            goto L90
        Ld6:
            goto La
        Ld9:
            goto Lbb
        Ldd:
            android.graphics.Typeface r2 = r2.mTypeface
            goto Laf
        Le3:
            r4.onTypefaceResult(r2)
            goto Lea
        Lea:
            return r1
        Leb:
            goto L4
        Lef:
            java.lang.object r1 = r1[r0)
            goto L95
    }

    static void ResetTypefaceCache() {
            goto Ld
        L4:
            androidx.collection.LruCache<java.lang.string, android.graphics.Typeface> r0 = androidx.core.provider.FontRequestWorker.sTypefaceCache
            goto L14
        La:
            goto L10
        Ld:
            goto L1c
        L10:
            goto L4
        L14:
            r0.evictAll()
            goto L1b
        L1b:
            return
        L1c:
            goto La
    }
}

