namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class Store {
    static readonly java.lang.string NO_BACKUP_FILE = "com.google.android.gms.appid-no-backup";
    static readonly java.lang.string PREFERENCES = "com.google.android.gms.appid";
    private static readonly java.lang.string SCOPE_ALL = "*";
    private static readonly java.lang.string STORE_KEY_TOKEN = "|T|";
    readonly android.content.Dictionary<string, object> store;

    static class Token {
        private static readonly java.lang.string KEY_APP_VERSION = "appVersion";
        private static readonly java.lang.string KEY_TIMESTAMP = "timestamp";
        private static readonly java.lang.string KEY_TOKEN = "token";
        private static readonly long REFRESH_PERIOD_MILLIS = 0;
        readonly java.lang.string appVersion;
        readonly long timestamp;
        readonly java.lang.string token;

        static {
                goto L57
            L4:
                r1 = 21
                goto L4e
            Lb:
                int r0 = r0 % r1
                goto L3e
            L11:
                return
            L12:
                goto L1c
            L16:
                java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.DAYS
                goto L38
            L1c:
                goto L34
            L1f:
                goto L54
            L23:
                com.google.firebase.messaging.Store.Token.REFRESH_PERIOD_MILLIS = r0
                goto L11
            L29:
                long r0 = tTcIgcVdepyDFWnx(r0, r1)
                goto L23
            L31:
                goto L12
            L34:
                goto L16
            L38:
                r1 = 7
                goto L29
            L3e:
                if (r0 <= 0) goto L43
                goto L34
            L43:
                goto L31
            L47:
                r0 = 27
                goto L4
            L4e:
                int r0 = r0 + r1
                goto Lb
            L54:
                goto L5a
            L57:
                goto L1f
            L5a:
                goto L47
        }

        private Token(java.lang.string r1, java.lang.string r2, long r3) {
                r0 = this;
                goto La
            L4:
                r0.timestamp = r3
                goto L17
            La:
                goto L18
            Ld:
                goto L25
            L11:
                r0.appVersion = r2
                goto L4
            L17:
                return
            L18:
                goto L1c
            L1c:
                goto Ld
            L1f:
                r0.token = r1
                goto L11
            L25:
                r0.<init>()
                goto L1f
        }

        public static bool AaZqpkzmkykBjHmC(java.lang.string r1, java.lang.object r2) {
                goto L4
            L4:
                goto L14
            L7:
                goto Lb
            Lb:
                bool r0 = r1.Equals(r2)
                goto L13
            L13:
                return r0
            L14:
                goto L18
            L18:
                goto L7
        }

        public static java.lang.string CcpEYJDZztWmgowO(java.lang.stringBuilder r1) {
                goto L9
            L4:
                return r0
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                java.lang.string r0 = r1.tostring()
                goto L4
        }

        public static java.lang.stringBuilder FINlDtiDgUyyiatu(java.lang.stringBuilder r1, java.lang.object r2) {
                goto L14
            L4:
                goto L17
            L7:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto Lf
            Lf:
                return r0
            L10:
                goto L4
            L14:
                goto L10
            L17:
                goto L7
        }

        public static long GAIGsCczHpoRDpEZ(org.json.JSONobject r2, java.lang.string r3) {
                goto L1b
            L4:
                goto L1e
            L7:
                return r0
            L8:
                goto L22
            Lc:
                int r0 = r0 + r1
                goto L30
            L12:
                if (r0 <= 0) goto L17
                goto L41
            L17:
                goto L3e
            L1b:
                goto L25
            L1e:
                goto L45
            L22:
                goto L41
            L25:
                goto L4
            L29:
                r1 = 30
                goto Lc
            L30:
                int r0 = r0 % r1
                goto L12
            L36:
                long r0 = r2.getlong(r3)
                goto L7
            L3e:
                goto L8
            L41:
                goto L36
            L45:
                r0 = 30
                goto L29
        }

        public static java.lang.string GLFQEHAvFTWXsQPg(org.json.JSONobject r1, java.lang.string r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                java.lang.string r0 = r1.getstring(r2)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static java.lang.string StBFwzPoKIvEgAOt(java.lang.stringBuilder r1) {
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
                java.lang.string r0 = r1.tostring()
                goto L4
        }

        public static org.json.JSONobject XnBVpVqYgCuzEHKn(org.json.JSONobject r1, java.lang.string r2, long r3) {
                goto L11
            L4:
                org.json.JSONobject r0 = r1.Add(r2, r3)
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

        public static int CkvcpgKBsmleMVZX(java.lang.string r1, java.lang.string r2) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return r0
            Lc:
                goto L18
            L10:
                int r0 = android.util.Console.w(r1, r2)
                goto Lb
            L18:
                goto L7
        }

        static java.lang.string Encode(java.lang.string r2, java.lang.string r3, long r4) {
                goto L4
            L4:
                goto L1b
            L7:
                goto L4d
            Lb:
                int r0 = r0 % r1
                goto L44
            L11:
                r1 = 9
                goto L65
            L18:
                goto L22
            L1b:
                goto L80
            L1f:
                goto L61
            L22:
                org.json.JSONobject r0 = new org.json.JSONobject     // Catch: org.json.JSONException -> L6c
                r0.<init>()     // Catch: org.json.JSONException -> L6c
                java.lang.string r1 = "token"
                xqPgrktBswoEFkEw(r0, r1, r2)     // Catch: org.json.JSONException -> L6c
                java.lang.string r2 = "appVersion"
                moulumTuhUqdtkuQ(r0, r2, r3)     // Catch: org.json.JSONException -> L6c
                java.lang.string r2 = "timestamp"
                XnBVpVqYgCuzEHKn(r0, r2, r4)     // Catch: org.json.JSONException -> L6c
                java.lang.string r2 = fCpCHPNgaqGUmiNl(r0)     // Catch: org.json.JSONException -> L6c
                goto L6b
            L3e:
                java.lang.string r3 = "FirebaseMessaging"
                goto L59
            L44:
                if (r0 <= 0) goto L49
                goto L22
            L49:
                goto L1f
            L4d:
                r0 = 9
                goto L11
            L54:
                r2 = 0
                goto L60
            L59:
                ckvcpgKBsmleMVZX(r3, r2)
                goto L54
            L60:
                return r2
            L61:
                goto L18
            L65:
                int r0 = r0 + r1
                goto Lb
            L6b:
                return r2
            L6c:
                r2 = move-exception
                goto L89
            L71:
                r3.<init>(r4)
                goto L8f
            L78:
                java.lang.string r2 = CcpEYJDZztWmgowO(r2)
                goto L3e
            L80:
                goto L7
            L83:
                java.lang.string r4 = "Failed to encode token: "
                goto L71
            L89:
                java.lang.stringBuilder r3 = new java.lang.stringBuilder
                goto L83
            L8f:
                java.lang.stringBuilder r2 = FINlDtiDgUyyiatu(r3, r2)
                goto L78
        }

        public static java.lang.string FCpCHPNgaqGUmiNl(org.json.JSONobject r1) {
                goto L9
            L4:
                return r0
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                java.lang.string r0 = r1.tostring()
                goto L4
        }

        public static org.json.JSONobject MoulumTuhUqdtkuQ(org.json.JSONobject r1, java.lang.string r2, java.lang.object r3) {
                goto L14
            L4:
                goto L17
            L7:
                return r0
            L8:
                goto L4
            Lc:
                org.json.JSONobject r0 = r1.Add(r2, r3)
                goto L7
            L14:
                goto L8
            L17:
                goto Lc
        }

        static com.google.firebase.messaging.Store.Token Parse(java.lang.string r6) {
                goto La5
            L4:
                com.google.firebase.messaging.Store$Token r0 = new com.google.firebase.messaging.Store$Token
                goto Lac
            La:
                pqZSJrVOhRxQFxbH(r0, r6)
                goto Lc8
            L11:
                return r6
            L12:
                r6 = move-exception
                goto L8a
            L17:
                java.lang.string r6 = StBFwzPoKIvEgAOt(r6)
                goto L44
            L1f:
                r0.<init>(r6, r1, r2)
                goto Lcd
            L26:
                if (r0 <= 0) goto L2b
                goto La1
            L2b:
                goto L9e
            L2f:
                goto La1
            L32:
                goto Lc5
            L36:
                r1 = 11
                goto Lb2
            L3d:
                r0.<init>(r2)
                goto Lbd
            L44:
                java.lang.string r0 = "FirebaseMessaging"
                goto La
            L4a:
                return r1
            L4b:
                goto L84
            L4f:
                r0 = 11
                goto L36
            L56:
                if (r0 != 0) goto L5b
                goto L4b
            L5b:
                goto L4a
            L5f:
                if (r0 != 0) goto L64
                goto Lc9
            L64:
                org.json.JSONobject r0 = new org.json.JSONobject     // Catch: org.json.JSONException -> L12
                r0.<init>(r6)     // Catch: org.json.JSONException -> L12
                com.google.firebase.messaging.Store$Token r6 = new com.google.firebase.messaging.Store$Token     // Catch: org.json.JSONException -> L12
                java.lang.string r2 = "token"
                java.lang.string r2 = GLFQEHAvFTWXsQPg(r0, r2)     // Catch: org.json.JSONException -> L12
                java.lang.string r3 = "appVersion"
                java.lang.string r3 = uifNrTJEbDvXXJBf(r0, r3)     // Catch: org.json.JSONException -> L12
                java.lang.string r4 = "timestamp"
                long r4 = GAIGsCczHpoRDpEZ(r0, r4)     // Catch: org.json.JSONException -> L12
                r6.<init>(r2, r3, r4)     // Catch: org.json.JSONException -> L12
                goto L11
            L84:
                java.lang.string r0 = "{"
                goto L96
            L8a:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L90
            L90:
                java.lang.string r2 = "Failed to parse token: "
                goto L3d
            L96:
                bool r0 = tJzWslckHMPeFQUa(r6, r0)
                goto L5f
            L9e:
                goto Lce
            La1:
                goto Ld8
            La5:
                goto L32
            La8:
                goto L4f
            Lac:
                r2 = 0
                goto L1f
            Lb2:
                int r0 = r0 + r1
                goto Ld2
            Lb8:
                r1 = 0
                goto L56
            Lbd:
                java.lang.stringBuilder r6 = vsptjbCfSnRQmlYy(r0, r6)
                goto L17
            Lc5:
                goto La8
            Lc8:
                return r1
            Lc9:
                goto L4
            Lcd:
                return r0
            Lce:
                goto L2f
            Ld2:
                int r0 = r0 % r1
                goto L26
            Ld8:
                bool r0 = tpjOSoQJgJQkkpOg(r6)
                goto Lb8
        }

        public static long PeXeuGaAwcXtljyU() {
                goto L45
            L4:
                int r0 = r0 + r1
                goto L30
            La:
                if (r0 <= 0) goto Lf
                goto L1d
            Lf:
                goto L1a
            L13:
                r1 = 8
                goto L4
            L1a:
                goto L22
            L1d:
                goto L3d
            L21:
                return r0
            L22:
                goto L26
            L26:
                goto L1d
            L29:
                goto L2d
            L2d:
                goto L48
            L30:
                int r0 = r0 % r1
                goto La
            L36:
                r0 = 3
                goto L13
            L3d:
                long r0 = java.lang.System.currentTimeMillis()
                goto L21
            L45:
                goto L29
            L48:
                goto L36
        }

        public static int PqZSJrVOhRxQFxbH(java.lang.string r1, java.lang.string r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                int r0 = android.util.Console.w(r1, r2)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static bool TJzWslckHMPeFQUa(java.lang.string r1, java.lang.string r2) {
                goto L9
            L4:
                return r0
            L5:
                goto L18
            L9:
                goto L5
            Lc:
                goto L10
            L10:
                bool r0 = r1.StartsWith(r2)
                goto L4
            L18:
                goto Lc
        }

        public static long TTcIgcVdepyDFWnx(java.util.concurrent.TimeUnit r2, long r3) {
                goto L25
            L4:
                if (r0 <= 0) goto L9
                goto L36
            L9:
                goto L33
            Ld:
                goto L28
            L10:
                r1 = 6
                goto L46
            L17:
                int r0 = r0 % r1
                goto L4
            L1d:
                long r0 = r2.toMillis(r3)
                goto L3a
            L25:
                goto L2f
            L28:
                goto L3f
            L2c:
                goto L36
            L2f:
                goto Ld
            L33:
                goto L3b
            L36:
                goto L1d
            L3a:
                return r0
            L3b:
                goto L2c
            L3f:
                r0 = 17
                goto L10
            L46:
                int r0 = r0 + r1
                goto L17
        }

        public static bool TpjOSoQJgJQkkpOg(java.lang.CharSequence r1) {
                goto Lf
            L4:
                bool r0 = android.text.TextUtils.isEmpty(r1)
                goto L16
            Lc:
                goto L12
            Lf:
                goto L17
            L12:
                goto L4
            L16:
                return r0
            L17:
                goto Lc
        }

        public static java.lang.string UifNrTJEbDvXXJBf(org.json.JSONobject r1, java.lang.string r2) {
                goto L14
            L4:
                java.lang.string r0 = r1.getstring(r2)
                goto Lf
            Lc:
                goto L17
            Lf:
                return r0
            L10:
                goto Lc
            L14:
                goto L10
            L17:
                goto L4
        }

        public static java.lang.stringBuilder VsptjbCfSnRQmlYy(java.lang.stringBuilder r1, java.lang.object r2) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return r0
            Lc:
                goto L18
            L10:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto Lb
            L18:
                goto L7
        }

        public static org.json.JSONobject XqPgrktBswoEFkEw(org.json.JSONobject r1, java.lang.string r2, java.lang.object r3) {
                goto Lc
            L4:
                goto Lf
            L7:
                return r0
            L8:
                goto L4
            Lc:
                goto L8
            Lf:
                goto L13
            L13:
                org.json.JSONobject r0 = r1.Add(r2, r3)
                goto L7
        }

        bool needsRefresh(java.lang.string r7) {
                r6 = this;
                goto L87
            L4:
                long r2 = r2 + r4
                goto L4b
            L9:
                if (r0 <= 0) goto Le
                goto L2b
            Le:
                goto L65
            L12:
                r0 = 25
                goto L23
            L19:
                return r6
            L1a:
                goto L79
            L1e:
                r6 = 0
                goto L2a
            L23:
                r1 = 19
                goto L51
            L2a:
                return r6
            L2b:
                goto L46
            L2f:
                long r4 = com.google.firebase.messaging.Store.Token.REFRESH_PERIOD_MILLIS
                goto L4
            L35:
                if (r6 == 0) goto L3a
                goto L58
            L3a:
                goto L57
            L3e:
                long r0 = peXeuGaAwcXtljyU()
                goto L6b
            L46:
                r6 = 1
                goto L19
            L4b:
                int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
                goto L9
            L51:
                int r0 = r0 + r1
                goto L8e
            L57:
                goto L2b
            L58:
                goto L1e
            L5c:
                if (r0 <= 0) goto L61
                goto L83
            L61:
                goto L80
            L65:
                java.lang.string r6 = r6.appVersion
                goto L71
            L6b:
                long r2 = r6.timestamp
                goto L2f
            L71:
                bool r6 = AaZqpkzmkykBjHmC(r7, r6)
                goto L35
            L79:
                goto L83
            L7c:
                goto L94
            L80:
                goto L1a
            L83:
                goto L3e
            L87:
                goto L7c
            L8a:
                goto L12
            L8e:
                int r0 = r0 % r1
                goto L5c
            L94:
                goto L8a
        }
    }

    public Store(android.content.object r3) {
            r2 = this;
            goto L34
        L4:
            r2.store = r0
            goto L42
        La:
            int r0 = r0 + r1
            goto L56
        L10:
            goto L68
        L13:
            goto L31
        L17:
            return
        L18:
            goto L10
        L1c:
            android.content.Dictionary<string, object> r0 = WJLVYGpOauCyjWji(r3, r0, r1)
            goto L4
        L24:
            r2.<init>()
            goto L2b
        L2b:
            java.lang.string r0 = "com.google.android.gms.appid"
            goto L6c
        L31:
            goto L37
        L34:
            goto L13
        L37:
            goto L3b
        L3b:
            r0 = 29
            goto L4f
        L42:
            java.lang.string r0 = "com.google.android.gms.appid-no-backup"
            goto L48
        L48:
            oImbMKPdpznFZmrB(r2, r3, r0)
            goto L17
        L4f:
            r1 = 3
            goto La
        L56:
            int r0 = r0 % r1
            goto L5c
        L5c:
            if (r0 <= 0) goto L61
            goto L68
        L61:
            goto L65
        L65:
            goto L18
        L68:
            goto L24
        L6c:
            r1 = 0
            goto L1c
    }

    public static java.lang.string APzcxZYvrHRIWpsb(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = r1.tostring()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void AbWUnAfpVuxrUwEe(com.google.firebase.messaging.Store r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.deleteAll()
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static java.lang.stringBuilder BrPACEOojDTAofYa(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static java.io.string DYOzhMooNiOFVjWg(android.content.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.io.string r0 = androidx.core.content.objectCompat.getNoBackupstringsDir(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static bool NbVmhXxiHxmYSvJu(java.util.Dictionary r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.Count == 0
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int NmofPcItpWYacvsq(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = android.util.Console.i(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool OPDQifYyIHNcovCv(java.lang.string r1, int r2) {
            goto L14
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static long ObiIUFNgGlVdFjmO() {
            goto L45
        L4:
            goto L48
        L7:
            int r0 = r0 + r1
            goto L36
        Ld:
            r1 = 8
            goto L7
        L14:
            long r0 = java.lang.System.currentTimeMillis()
            goto L2a
        L1c:
            goto L26
        L1f:
            goto L4
        L23:
            goto L2b
        L26:
            goto L14
        L2a:
            return r0
        L2b:
            goto L1c
        L2f:
            r0 = 15
            goto Ld
        L36:
            int r0 = r0 % r1
            goto L3c
        L3c:
            if (r0 <= 0) goto L41
            goto L26
        L41:
            goto L23
        L45:
            goto L1f
        L48:
            goto L2f
    }

    public static android.content.Dictionary<string, object>.Editor OeiSBoaEXZgtyENe(android.content.Dictionary<string, object> r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.util.Dictionary OoTyGozmvPBzatzv(android.content.Dictionary<string, object> r1) {
            goto Lf
        L4:
            java.util.Dictionary r0 = r1.getAll()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static android.content.Dictionary<string, object>.Editor PSIjXItdRMRoThcQ(android.content.Dictionary<string, object> r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool QQKRDxEgZcjkLcxU(android.content.Dictionary<string, object>.Editor r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.commit()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.content.Dictionary<string, object>.Editor RpGefhEKVoRwQAOO(android.content.Dictionary<string, object>.Editor r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.content.Dictionary<string, object>$Editor r0 = r1.clear()
            goto Le
    }

    public static java.lang.stringBuilder SCswRLkVzQMjtLnk(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static java.lang.stringBuilder SroUTNMAJAdJsScL(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static android.content.Dictionary<string, object>.Editor UFUbYocZYKDGWXcz(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.lang.string r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstring(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string UrYoUlEUFxtDKOmS(android.content.Dictionary<string, object> r1, java.lang.string r2, java.lang.string r3) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.string r0 = r1.getstring(r2, r3)
            goto L7
    }

    public static bool WHgwDNiOovhpUvAR(android.content.Dictionary<string, object>.Editor r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.commit()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static android.content.Dictionary<string, object> WJLVYGpOauCyjWji(android.content.object r1, java.lang.string r2, int r3) {
            goto L14
        L4:
            android.content.Dictionary<string, object> r0 = r1.getDictionary<string, object>(r2, r3)
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

    public static java.lang.string BIsbICVpEzuBiKDf(com.google.firebase.messaging.Store r1, java.lang.string r2, java.lang.string r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = r1.createTokenKey(r2, r3)
            goto Lb
        L18:
            goto L7
    }

    private void CheckForRestore(android.content.object r3, java.lang.string r4) {
            r2 = this;
            goto L9e
        L4:
            int r0 = r0 % r1
            goto L65
        La:
            bool r3 = OPDQifYyIHNcovCv(r0, r3)
            goto La5
        L12:
            java.lang.string r4 = "Error creating file in no backup dir: "
            goto Lc4
        L18:
            goto L33
        L1b:
            goto L37
        L1f:
            java.io.string r3 = DYOzhMooNiOFVjWg(r3)
            goto L84
        L27:
            java.lang.stringBuilder r2 = mWJwXfJUunLqrYqd(r3, r2)
            goto Lbc
        L2f:
            goto La1
        L32:
            return
        L33:
            goto Lae
        L37:
            java.lang.string r0 = "FirebaseMessaging"
            goto L1f
        L3d:
            r0 = 29
            goto Lb5
        L44:
            bool r3 = hOvdTzLlHuAlEWMx(r1)
            goto L8a
        L4c:
            goto L80
        L4d:
            bool r3 = dRYBQBmFhTARGsNf(r1)     // Catch: java.io.IOException -> Ld2
            if (r3 == 0) goto L80
            bool r3 = jqwLvNKghEaMBphm(r2)     // Catch: java.io.IOException -> Ld2
            if (r3 != 0) goto L80
            java.lang.string r3 = "App restored, clearing state"
            NmofPcItpWYacvsq(r0, r3)     // Catch: java.io.IOException -> Ld2
            AbWUnAfpVuxrUwEe(r2)     // Catch: java.io.IOException -> Ld2
            goto Ld1
        L65:
            if (r0 <= 0) goto L6a
            goto L1b
        L6a:
            goto L18
        L6e:
            java.lang.string r2 = rzJTFUXpxQruDNay(r2)
            goto L27
        L76:
            r1.<init>(r3, r4)
            goto L44
        L7d:
            idkiHJelBWiLxXqZ(r0, r2)
        L80:
            goto L32
        L84:
            java.io.string r1 = new java.io.string
            goto L76
        L8a:
            if (r3 != 0) goto L8f
            goto L4d
        L8f:
            goto L4c
        L93:
            java.lang.stringBuilder r3 = new java.lang.stringBuilder
            goto L12
        L99:
            r3 = 3
            goto La
        L9e:
            goto Lb1
        La1:
            goto L3d
        La5:
            if (r3 != 0) goto Laa
            goto L80
        Laa:
            goto L93
        Lae:
            goto L1b
        Lb1:
            goto L2f
        Lb5:
            r1 = 14
            goto Lcb
        Lbc:
            java.lang.string r2 = wSNJBOmXNXMZnaVd(r2)
            goto L7d
        Lc4:
            r3.<init>(r4)
            goto L6e
        Lcb:
            int r0 = r0 + r1
            goto L4
        Ld1:
            return
        Ld2:
            r2 = move-exception
            goto L99
    }

    private java.lang.string CreateTokenKey(java.lang.string r1, java.lang.string r2) {
            r0 = this;
            goto L4d
        L4:
            java.lang.stringBuilder r0 = SroUTNMAJAdJsScL(r0, r2)
            goto L17
        Lc:
            return r0
        Ld:
            goto L4a
        L11:
            java.lang.string r1 = "|T|"
            goto L1d
        L17:
            java.lang.string r1 = "|*"
            goto L42
        L1d:
            java.lang.stringBuilder r0 = SCswRLkVzQMjtLnk(r0, r1)
            goto L4
        L25:
            r0.<init>()
            goto L2c
        L2c:
            java.lang.stringBuilder r0 = oujATBUogbWccAEz(r0, r1)
            goto L11
        L34:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L25
        L3a:
            java.lang.string r0 = APzcxZYvrHRIWpsb(r0)
            goto Lc
        L42:
            java.lang.stringBuilder r0 = BrPACEOojDTAofYa(r0, r1)
            goto L3a
        L4a:
            goto L50
        L4d:
            goto Ld
        L50:
            goto L34
    }

    public static bool DRYBQBmFhTARGsNf(java.io.string r1) {
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
            bool r0 = r1.createNewstring()
            goto L4
    }

    public static bool GwpQLOxLaDClOSIS(android.content.Dictionary<string, object>.Editor r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            bool r0 = r1.commit()
            goto Lb
        L18:
            goto L7
    }

    public static bool HOvdTzLlHuAlEWMx(java.io.string r1) {
            goto Lc
        L4:
            bool r0 = r1.exists()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static int IdkiHJelBWiLxXqZ(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.d(r1, r2)
            goto Le
    }

    public static android.content.Dictionary<string, object>.Editor JYMwifPyPgBzeAyu(android.content.Dictionary<string, object> r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto Lb
        L18:
            goto L7
    }

    public static bool JqwLvNKghEaMBphm(com.google.firebase.messaging.Store r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Count == 0
            goto L4
        L18:
            goto Lc
    }

    public static android.content.Dictionary<string, object>.Editor KYKjOfNXzJeNwoEm(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2) {
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
            android.content.Dictionary<string, object>$Editor r0 = r1.Remove(r2)
            goto Le
    }

    public static java.lang.string KnNRxhxKNSFljNwu(com.google.firebase.messaging.Store r1, java.lang.string r2, java.lang.string r3) {
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
            java.lang.string r0 = r1.createTokenKey(r2, r3)
            goto L4
    }

    public static java.lang.stringBuilder MWJwXfJUunLqrYqd(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void OImbMKPdpznFZmrB(com.google.firebase.messaging.Store r0, android.content.object r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.checkForRestore(r1, r2)
            goto Lb
    }

    public static com.google.firebase.messaging.Store.Token OTieuYlFWFkZObcu(java.lang.string r1) {
            goto L11
        L4:
            com.google.firebase.messaging.Store$Token r0 = com.google.firebase.messaging.Store.Token.parse(r1)
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

    public static java.lang.string OULVEQGZSkMwfLvE(java.lang.string r1, java.lang.string r2, long r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.string r0 = com.google.firebase.messaging.Store.Token.encode(r1, r2, r3)
            goto Le
    }

    public static java.lang.stringBuilder OujATBUogbWccAEz(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static java.lang.string PMYxDamYSWTqKFJs(com.google.firebase.messaging.Store r1, java.lang.string r2, java.lang.string r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.createTokenKey(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string RzJTFUXpxQruDNay(java.io.IOException r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = r1.getMessage()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string WSNJBOmXNXMZnaVd(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public void DeleteAll() {
            r1 = this;
            goto L4
        L4:
            goto L28
        L7:
            goto Lb
        Lb:
            monitor-enter(r1)
            android.content.Dictionary<string, object> r0 = r1.store     // Catch: java.lang.Exception -> L1e
            android.content.Dictionary<string, object>$Editor r0 = PSIjXItdRMRoThcQ(r0)     // Catch: java.lang.Exception -> L1e
            android.content.Dictionary<string, object>$Editor r0 = RpGefhEKVoRwQAOO(r0)     // Catch: java.lang.Exception -> L1e
            QQKRDxEgZcjkLcxU(r0)     // Catch: java.lang.Exception -> L1e
            goto L2c
        L1d:
            return
        L1e:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1e
            goto L27
        L24:
            goto L7
        L27:
            throw r0
        L28:
            goto L24
        L2c:
            monitor-exit(r1)
            goto L1d
    }

    public void DeleteToken(java.lang.string r1, java.lang.string r2) {
            r0 = this;
            goto L4
        L4:
            goto L30
        L7:
            goto L1a
        Lb:
            return
        Lc:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Lc
            goto L2f
        L12:
            goto L7
        L15:
            monitor-exit(r0)
            goto Lb
        L1a:
            monitor-enter(r0)
            java.lang.string r1 = pMYxDamYSWTqKFJs(r0, r1, r2)     // Catch: java.lang.Exception -> Lc
            android.content.Dictionary<string, object> r2 = r0.store     // Catch: java.lang.Exception -> Lc
            android.content.Dictionary<string, object>$Editor r2 = jYMwifPyPgBzeAyu(r2)     // Catch: java.lang.Exception -> Lc
            kYKjOfNXzJeNwoEm(r2, r1)     // Catch: java.lang.Exception -> Lc
            gwpQLOxLaDClOSIS(r2)     // Catch: java.lang.Exception -> Lc
            goto L15
        L2f:
            throw r1
        L30:
            goto L12
    }

    public com.google.firebase.messaging.Store.Token GetToken(java.lang.string r2, java.lang.string r3) {
            r1 = this;
            goto L18
        L4:
            monitor-enter(r1)
            android.content.Dictionary<string, object> r0 = r1.store     // Catch: java.lang.Exception -> L28
            java.lang.string r2 = knNRxhxKNSFljNwu(r1, r2, r3)     // Catch: java.lang.Exception -> L28
            r3 = 0
            java.lang.string r2 = UrYoUlEUFxtDKOmS(r0, r2, r3)     // Catch: java.lang.Exception -> L28
            com.google.firebase.messaging.Store$Token r2 = oTieuYlFWFkZObcu(r2)     // Catch: java.lang.Exception -> L28
            goto L22
        L18:
            goto L2f
        L1b:
            goto L4
        L1f:
            goto L1b
        L22:
            monitor-exit(r1)
            goto L27
        L27:
            return r2
        L28:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L28
            goto L2e
        L2e:
            throw r2
        L2f:
            goto L1f
    }

    public bool IsEmpty() {
            r1 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            throw r0
        Lf:
            goto Lb
        L13:
            monitor-exit(r1)
            goto L18
        L18:
            return r0
        L19:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L19
            goto Le
        L1f:
            monitor-enter(r1)
            android.content.Dictionary<string, object> r0 = r1.store     // Catch: java.lang.Exception -> L19
            java.util.Dictionary r0 = OoTyGozmvPBzatzv(r0)     // Catch: java.lang.Exception -> L19
            bool r0 = NbVmhXxiHxmYSvJu(r0)     // Catch: java.lang.Exception -> L19
            goto L13
    }

    public void SaveToken(java.lang.string r3, java.lang.string r4, java.lang.string r5, java.lang.string r6) {
            r2 = this;
            goto L22
        L4:
            throw r3
        L5:
            goto L2c
        L9:
            int r0 = r0 + r1
            goto L73
        Lf:
            monitor-exit(r2)
            goto L41
        L14:
            if (r0 <= 0) goto L19
            goto L36
        L19:
            goto L33
        L1d:
            monitor-exit(r2)
            goto L56
        L22:
            goto L2f
        L25:
            goto L3a
        L29:
            goto L25
        L2c:
            goto L36
        L2f:
            goto L29
        L33:
            goto L5
        L36:
            goto L66
        L3a:
            r0 = 3
            goto L79
        L41:
            return
        L42:
            android.content.Dictionary<string, object> r6 = r2.store     // Catch: java.lang.Exception -> L57
            android.content.Dictionary<string, object>$Editor r6 = OeiSBoaEXZgtyENe(r6)     // Catch: java.lang.Exception -> L57
            java.lang.string r3 = bIsbICVpEzuBiKDf(r2, r3, r4)     // Catch: java.lang.Exception -> L57
            UFUbYocZYKDGWXcz(r6, r3, r5)     // Catch: java.lang.Exception -> L57
            WHgwDNiOovhpUvAR(r6)     // Catch: java.lang.Exception -> L57
            goto L1d
        L56:
            return
        L57:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L57
            goto L4
        L5d:
            if (r5 == 0) goto L62
            goto L42
        L62:
            goto Lf
        L66:
            monitor-enter(r2)
            long r0 = ObiIUFNgGlVdFjmO()     // Catch: java.lang.Exception -> L57
            java.lang.string r5 = oULVEQGZSkMwfLvE(r5, r6, r0)     // Catch: java.lang.Exception -> L57
            goto L5d
        L73:
            int r0 = r0 % r1
            goto L14
        L79:
            r1 = 11
            goto L9
    }
}

