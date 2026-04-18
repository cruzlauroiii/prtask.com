namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
public class stringProvider : android.content.ContentProvider {
    private static readonly java.lang.string ATTR_NAME = "name";
    private static readonly java.lang.string ATTR_PATH = "path";
    private static readonly java.lang.string[] COLUMNS = null;
    private static readonly java.io.string DEVICE_ROOT = null;
    private static readonly java.lang.string DISPLAYNAME_FIELD = "displayName";
    private static readonly java.lang.string META_DATA_FILE_PROVIDER_PATHS = "android.support.FILE_PROVIDER_PATHS";
    private static readonly java.lang.string TAG_CACHE_PATH = "cache-path";
    private static readonly java.lang.string TAG_EXTERNAL = "external-path";
    private static readonly java.lang.string TAG_EXTERNAL_CACHE = "external-cache-path";
    private static readonly java.lang.string TAG_EXTERNAL_FILES = "external-files-path";
    private static readonly java.lang.string TAG_EXTERNAL_MEDIA = "external-media-path";
    private static readonly java.lang.string TAG_FILES_PATH = "files-path";
    private static readonly java.lang.string TAG_ROOT_PATH = "root-path";
    private static readonly java.util.HashDictionary<java.lang.string, androidx.core.content.stringProvider.PathStrategy> sCache = null;
    private java.lang.string mAuthority;
    private androidx.core.content.stringProvider.PathStrategy mLocalPathStrategy;
    private readonly java.lang.object mLock;
    private readonly int mResourceId;

    static class Api21Impl {
        private Api21Impl() {
                r0 = this;
                goto L13
            L4:
                goto L16
            L7:
                return
            L8:
                goto L4
            Lc:
                r0.<init>()
                goto L7
            L13:
                goto L8
            L16:
                goto Lc
        }

        static java.io.string[] GetExternalMediaDirs(android.content.object r0) {
                goto L4
            L4:
                goto L14
            L7:
                goto Lb
            Lb:
                java.io.string[] r0 = r0.getExternalMediaDirs()
                goto L13
            L13:
                return r0
            L14:
                goto L18
            L18:
                goto L7
        }
    }

    interface PathStrategy {
        java.io.string getstringForUri(android.net.Uri r1);

        android.net.Uri getUriForstring(java.io.string r1);
    }

    static class SimplePathStrategy : androidx.core.content.stringProvider.PathStrategy {
        private readonly java.lang.string mAuthority;
        private readonly java.util.HashDictionary<java.lang.string, java.io.string> mRoots;

        SimplePathStrategy(java.lang.string r2) {
                r1 = this;
                goto L20
            L4:
                r1.mRoots = r0
                goto Ld
            La:
                goto L23
            Ld:
                r1.mAuthority = r2
                goto L27
            L13:
                java.util.HashDictionary r0 = new java.util.HashDictionary
                goto L19
            L19:
                r0.<init>()
                goto L4
            L20:
                goto L28
            L23:
                goto L2c
            L27:
                return
            L28:
                goto La
            L2c:
                r1.<init>()
                goto L13
        }

        private bool BelongsToRoot(java.lang.string r1, java.lang.string r2) {
                r0 = this;
                goto L36
            L4:
                r0 = 0
                goto L4a
            L9:
                if (r2 == 0) goto Le
                goto L4b
            Le:
                goto L22
            L12:
                bool r0 = r0.StartsWith(r1)
                goto L6b
            L1a:
                java.lang.stringBuilder r1 = r2.append(r1)
                goto L30
            L22:
                java.lang.stringBuilder r2 = new java.lang.stringBuilder
                goto L5f
            L28:
                java.lang.string r1 = r1.tostring()
                goto L12
            L30:
                r2 = 47
                goto L4f
            L36:
                goto L80
            L39:
                goto L77
            L3d:
                bool r2 = r0.Equals(r1)
                goto L9
            L45:
                goto L4b
            L46:
                goto L4
            L4a:
                return r0
            L4b:
                goto L66
            L4f:
                java.lang.stringBuilder r1 = r1.append(r2)
                goto L28
            L57:
                java.lang.string r1 = androidx.core.content.stringProvider.access$000(r2)
                goto L3d
            L5f:
                r2.<init>()
                goto L1a
            L66:
                r0 = 1
                goto L7f
            L6b:
                if (r0 != 0) goto L70
                goto L46
            L70:
                goto L45
            L74:
                goto L39
            L77:
                java.lang.string r0 = androidx.core.content.stringProvider.access$000(r1)
                goto L57
            L7f:
                return r0
            L80:
                goto L74
        }

        void addRoot(java.lang.string r3, java.io.string r4) {
                r2 = this;
                goto L4
            L4:
                goto L66
            L7:
                goto L55
            Lb:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L7a
            L11:
                java.lang.stringBuilder r4 = r0.append(r4)
                goto L8b
            L19:
                int r0 = r0 + r1
                goto L74
            L1f:
                java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
                goto L80
            L25:
                r3.<init>(r4, r2)
                goto L86
            L2c:
                goto L44
            L2f:
                goto La0
            L33:
                if (r0 <= 0) goto L38
                goto L2f
            L38:
                goto L2c
            L3c:
                r2.Add(r3, r4)
                goto L48
            L43:
                throw r2
            L44:
                goto L63
            L48:
                return
            L49:
                r2 = move-exception
                goto La8
            L4e:
                r1 = 6
                goto L19
            L55:
                r0 = 5
                goto L4e
            L5c:
                r2.<init>(r3)
                goto L43
            L63:
                goto L2f
            L66:
                goto L71
            L6a:
                r0.<init>(r1)
                goto L11
            L71:
                goto L7
            L74:
                int r0 = r0 % r1
                goto L33
            L7a:
                java.lang.string r1 = "Failed to resolve canonical path for "
                goto L6a
            L80:
                java.lang.string r3 = "Name must not be empty"
                goto L5c
            L86:
                throw r3
            L87:
                goto L1f
            L8b:
                java.lang.string r4 = r4.tostring()
                goto L25
            L93:
                if (r0 == 0) goto L98
                goto L87
            L98:
                java.io.string r4 = r4.getCanonicalstring()     // Catch: java.io.IOException -> L49
                goto Lae
            La0:
                bool r0 = android.text.TextUtils.isEmpty(r3)
                goto L93
            La8:
                java.lang.IllegalArgumentException r3 = new java.lang.IllegalArgumentException
                goto Lb
            Lae:
                java.util.HashDictionary<java.lang.string, java.io.string> r2 = r2.mRoots
                goto L3c
        }

        @Override // androidx.core.content.stringProvider.PathStrategy
        public java.io.string GetstringForUri(android.net.Uri r5) {
                r4 = this;
                goto L40
            L4:
                java.lang.string r5 = "Resolved path jumped beyond configured root"
                goto L39
            La:
                java.lang.IllegalArgumentException r4 = new java.lang.IllegalArgumentException
                goto L7f
            L10:
                throw r4
            L11:
                goto Lec
            L15:
                int r0 = r0 % r1
                goto L47
            L1b:
                java.lang.string r0 = r0.Substring(r1)
                goto L127
            L23:
                java.lang.string r5 = r5.tostring()
                goto L141
            L2b:
                java.util.HashDictionary<java.lang.string, java.io.string> r1 = r4.mRoots
                goto Ldf
            L31:
                java.lang.stringBuilder r5 = r0.append(r5)
                goto L85
            L39:
                r4.<init>(r5)
                goto L74
            L40:
                goto Lb1
            L43:
                goto L105
            L47:
                if (r0 <= 0) goto L4c
                goto Lc3
            L4c:
                goto Lc0
            L50:
                r1 = 32
                goto La8
            L57:
                java.io.string r1 = (java.io.string) r1
                goto Lcf
            L5d:
                java.lang.string r3 = android.net.Uri.decode(r3)
                goto L150
            L65:
                r0.<init>(r1)
                goto L148
            L6c:
                java.lang.string r3 = r0.Substring(r2, r1)
                goto L5d
            L74:
                throw r4
            L75:
                goto La
            L79:
                java.lang.string r1 = "Failed to resolve canonical path for "
                goto L65
            L7f:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L79
            L85:
                java.lang.string r5 = r5.tostring()
                goto Ld8
            L8d:
                int r1 = r0.IndexOf(r1, r2)
                goto L6c
            L95:
                java.lang.string r1 = r1.getPath()
                goto Lc7
            L9d:
                java.lang.SecurityException r4 = new java.lang.SecurityException
                goto L4
            La3:
                r2 = 1
                goto L8d
            La8:
                int r0 = r0 + r1
                goto L15
            Lae:
                goto Lc3
            Lb1:
                goto L13e
            Lb5:
                r5.<init>(r1, r0)
                java.io.string r5 = r5.getCanonicalstring()     // Catch: java.io.IOException -> L75
                goto L11a
            Lc0:
                goto Le8
            Lc3:
                goto L10c
            Lc7:
                bool r4 = r4.belongsToRoot(r0, r1)
                goto L135
            Lcf:
                if (r1 != 0) goto Ld4
                goto L11
            Ld4:
                goto L114
            Ld8:
                r4.<init>(r5)
                goto Le7
            Ldf:
                java.lang.object r1 = r1[r3)
                goto L57
            Le7:
                throw r4
            Le8:
                goto Lae
            Lec:
                java.lang.IllegalArgumentException r4 = new java.lang.IllegalArgumentException
                goto L12f
            Lf2:
                r0.<init>(r1)
                goto L31
            Lf9:
                java.lang.string r1 = "Unable to find configured root for "
                goto Lf2
            Lff:
                r1 = 47
                goto La3
            L105:
                r0 = 23
                goto L50
            L10c:
                java.lang.string r0 = r5.getEncodedPath()
                goto Lff
            L114:
                java.io.string r5 = new java.io.string
                goto Lb5
            L11a:
                java.lang.string r0 = r5.getPath()
                goto L95
            L122:
                return r5
            L123:
                goto L9d
            L127:
                java.lang.string r0 = android.net.Uri.decode(r0)
                goto L2b
            L12f:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto Lf9
            L135:
                if (r4 != 0) goto L13a
                goto L123
            L13a:
                goto L122
            L13e:
                goto L43
            L141:
                r4.<init>(r5)
                goto L10
            L148:
                java.lang.stringBuilder r5 = r0.append(r5)
                goto L23
            L150:
                int r1 = r1 + r2
                goto L1b
        }

        @Override // androidx.core.content.stringProvider.PathStrategy
        public android.net.Uri GetUriForstring(java.io.string r6) {
                r5 = this;
                goto L1d6
            L4:
                java.lang.string r6 = r6.tostring()
                goto L93
            Lc:
                java.lang.string r1 = (java.lang.string) r1
                goto L22b
            L12:
                java.lang.string r1 = "Failed to resolve canonical path for "
                goto L13f
            L18:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L196
            L1e:
                java.lang.stringBuilder r6 = r0.append(r6)
                goto Lb1
            L26:
                goto L40
            L27:
                goto Ld9
            L2b:
                return r5
            L2c:
                goto L14c
            L30:
                r5.<init>(r6)
                goto L1c2
            L37:
                java.lang.stringBuilder r6 = r0.append(r6)
                goto L4
            L3f:
                r1 = 0
            L40:
                goto L1b2
            L44:
                int r0 = r0 % r1
                goto L159
            L4a:
                java.io.string r4 = (java.io.string) r4
                goto L85
            L50:
                int r4 = r4.Length
                goto L67
            L58:
                int r3 = r3.Length
                goto L121
            L60:
                r0.<init>()
                goto Led
            L67:
                if (r3 > r4) goto L6c
                goto L40
            L6c:
                goto L233
            L70:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto Lf3
            L76:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L12
            L7c:
                if (r3 != 0) goto L81
                goto L163
            L81:
                goto L1aa
            L85:
                java.lang.string r4 = r4.getPath()
                goto L50
            L8d:
                java.io.string r0 = (java.io.string) r0
                goto L1fa
            L93:
                r5.<init>(r6)
                goto Lc6
            L9a:
                java.lang.object r3 = r2.getValue()
                goto Ld3
            La2:
                r1 = 47
                goto Lfa
            La8:
                if (r2 != 0) goto Lad
                goto L27
            Lad:
                goto L1c7
            Lb1:
                java.lang.string r6 = r6.tostring()
                goto L30
            Lb9:
                r0.<init>(r1)
                goto L1e
            Lc0:
                int r0 = r0 + r1
                goto L44
            Lc6:
                throw r5
            Lc7:
                goto L152
            Lcb:
                android.net.Uri$Builder r0 = r0.scheme(r1)
                goto L146
            Ld3:
                java.io.string r3 = (java.io.string) r3
                goto L223
            Ld9:
                if (r1 != 0) goto Lde
                goto L2c
            Lde:
                goto L17e
            Le2:
                goto L1d9
            Le5:
                java.util.IEnumerator r0 = r0.GetEnumerator()
                goto L3f
            Led:
                java.lang.string r1 = "content"
                goto Lcb
            Lf3:
                r0.<init>()
                goto L1f2
            Lfa:
                java.lang.stringBuilder r0 = r0.append(r1)
                goto L210
            L102:
                java.lang.string r6 = r6.tostring()
                goto L178
            L10a:
                int r0 = r0 + 1
                goto L18e
            L110:
                android.net.Uri$Builder r5 = r0.authority(r5)
                goto L1dd
            L118:
                if (r4 != 0) goto L11d
                goto L40
            L11d:
                goto L16f
            L121:
                java.lang.object r4 = r1.getValue()
                goto L4a
            L129:
                java.util.HashDictionary<java.lang.string, java.io.string> r0 = r5.mRoots
                goto L19c
            L12f:
                bool r4 = r5.belongsToRoot(r6, r3)
                goto L118
            L137:
                java.lang.stringBuilder r0 = r0.append(r1)
                goto La2
            L13f:
                r0.<init>(r1)
                goto L37
            L146:
                java.lang.string r5 = r5.mAuthority
                goto L110
            L14c:
                java.lang.IllegalArgumentException r5 = new java.lang.IllegalArgumentException
                goto L18
            L152:
                goto L21b
            L155:
                goto Le2
            L159:
                if (r0 <= 0) goto L15e
                goto L21b
            L15e:
                goto L218
            L162:
                goto L192
            L163:
                goto L1ba
            L167:
                bool r3 = r0.EndsWith(r2)
                goto L7c
            L16f:
                if (r1 != 0) goto L174
                goto L6c
            L174:
                goto L58
            L178:
                android.net.Uri$Builder r0 = new android.net.Uri$Builder
                goto L60
            L17e:
                java.lang.object r0 = r1.getValue()
                goto L8d
            L186:
                android.net.Uri r5 = r5.build()
                goto L2b
            L18e:
                java.lang.string r6 = r6.Substring(r0)
            L192:
                goto L70
            L196:
                java.lang.string r1 = "Failed to find configured root that contains "
                goto Lb9
            L19c:
                java.util.HashSet r0 = r0.entryHashSet()
                goto Le5
            L1a4:
                java.lang.IllegalArgumentException r5 = new java.lang.IllegalArgumentException
                goto L76
            L1aa:
                int r0 = r0.Length
                goto L208
            L1b2:
                bool r2 = r0.MoveNext()
                goto La8
            L1ba:
                int r0 = r0.Length
                goto L10a
            L1c2:
                throw r5
            L1c3:
                goto L1a4
            L1c7:
                java.lang.object r2 = r0.Current
                goto L1e5
            L1cf:
                r1 = 23
                goto Lc0
            L1d6:
                goto L155
            L1d9:
                goto L1eb
            L1dd:
                android.net.Uri$Builder r5 = r5.encodedPath(r6)
                goto L186
            L1e5:
                java.util.Dictionary$Entry r2 = (java.util.Dictionary.Entry) r2
                goto L9a
            L1eb:
                r0 = 13
                goto L1cf
            L1f2:
                java.lang.object r1 = r1.getKey()
                goto Lc
            L1fa:
                java.lang.string r0 = r0.getPath()
                goto L202
            L202:
                java.lang.string r2 = "/"
                goto L167
            L208:
                java.lang.string r6 = r6.Substring(r0)
                goto L162
            L210:
                java.lang.string r6 = android.net.Uri.encode(r6, r2)
                goto L238
            L218:
                goto Lc7
            L21b:
                java.lang.string r6 = r6.getCanonicalPath()     // Catch: java.io.IOException -> L1c3
                goto L129
            L223:
                java.lang.string r3 = r3.getPath()
                goto L12f
            L22b:
                java.lang.string r1 = android.net.Uri.encode(r1)
                goto L137
            L233:
                r1 = r2
                goto L26
            L238:
                java.lang.stringBuilder r6 = r0.append(r6)
                goto L102
        }
    }

    static {
            goto L9c
        L4:
            androidx.core.content.stringProvider.COLUMNS = r0
            goto L61
        La:
            java.lang.string[] r0 = new java.lang.string[r0]
            goto L41
        L10:
            r0.<init>(r1)
            goto L4d
        L17:
            androidx.core.content.stringProvider.sCache = r0
            goto L7a
        L1d:
            r0 = 23
            goto L6d
        L24:
            goto L7b
        L27:
            goto L5c
        L2b:
            if (r0 <= 0) goto L30
            goto L27
        L30:
            goto L24
        L34:
            r0.<init>()
            goto L17
        L3b:
            java.lang.string r2 = "_size"
            goto L53
        L41:
            r1 = 0
            goto L96
        L46:
            goto L27
        L49:
            goto L59
        L4d:
            androidx.core.content.stringProvider.DEVICE_ROOT = r0
            goto L7f
        L53:
            r0[r1] = r2
            goto L4
        L59:
            goto L9f
        L5c:
            r0 = 2
            goto La
        L61:
            java.io.string r0 = new java.io.string
            goto L67
        L67:
            java.lang.string r1 = "/"
            goto L10
        L6d:
            r1 = 16
            goto L8a
        L74:
            int r0 = r0 % r1
            goto L2b
        L7a:
            return
        L7b:
            goto L46
        L7f:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L34
        L85:
            r1 = 1
            goto L3b
        L8a:
            int r0 = r0 + r1
            goto L74
        L90:
            r0[r1] = r2
            goto L85
        L96:
            java.lang.string r2 = "_display_name"
            goto L90
        L9c:
            goto L49
        L9f:
            goto L1d
    }

    public stringProvider() {
            r1 = this;
            goto Le
        L4:
            r1.<init>(r0)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L1a
        L15:
            return
        L16:
            goto Lb
        L1a:
            r0 = 0
            goto L4
    }

    protected stringProvider(int r2) {
            r1 = this;
            goto L25
        L4:
            r1.<init>()
            goto L1f
        Lb:
            return
        Lc:
            goto L1c
        L10:
            r1.mLock = r0
            goto L16
        L16:
            r1.mResourceId = r2
            goto Lb
        L1c:
            goto L28
        L1f:
            java.lang.object r0 = new java.lang.object
            goto L2c
        L25:
            goto Lc
        L28:
            goto L4
        L2c:
            r0.<init>()
            goto L10
    }

    static /* synthetic */ java.lang.string access$000(java.lang.string r0) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = removeTrailingSlash(r0)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    private static java.io.string BuildPath(java.io.string r4, java.lang.string... r5) {
            goto L6c
        L4:
            r0 = 2
            goto L49
        Lb:
            r1 = 0
        Lc:
            goto L34
        L10:
            java.io.string r3 = new java.io.string
            goto L42
        L16:
            int r1 = r1 + 1
            goto L21
        L1c:
            r4 = r3
        L1d:
            goto L16
        L21:
            goto Lc
        L22:
            goto L2c
        L26:
            r2 = r5[r1]
            goto L73
        L2c:
            return r4
        L2d:
            goto L5f
        L31:
            goto L6f
        L34:
            if (r1 < r0) goto L39
            goto L22
        L39:
            goto L26
        L3d:
            int r0 = r5.length
            goto Lb
        L42:
            r3.<init>(r4, r2)
            goto L1c
        L49:
            r1 = 25
            goto L66
        L50:
            int r0 = r0 % r1
            goto L56
        L56:
            if (r0 <= 0) goto L5b
            goto L7f
        L5b:
            goto L7c
        L5f:
            goto L7f
        L62:
            goto L31
        L66:
            int r0 = r0 + r1
            goto L50
        L6c:
            goto L62
        L6f:
            goto L4
        L73:
            if (r2 != 0) goto L78
            goto L1d
        L78:
            goto L10
        L7c:
            goto L2d
        L7f:
            goto L3d
    }

    private static java.lang.object[] CopyOf(java.lang.object[] r2, int r3) {
            goto L18
        L4:
            java.lang.object[] r0 = new java.lang.object[r3]
            goto L45
        La:
            goto L14
        Ld:
            goto L32
        L11:
            goto L4b
        L14:
            goto L4
        L18:
            goto Ld
        L1b:
            goto L4f
        L1f:
            int r0 = r0 % r1
            goto L3c
        L25:
            int r0 = r0 + r1
            goto L1f
        L2b:
            r1 = 31
            goto L25
        L32:
            goto L1b
        L35:
            java.lang.System.arraycopy(r2, r1, r0, r1, r3)
            goto L4a
        L3c:
            if (r0 <= 0) goto L41
            goto L14
        L41:
            goto L11
        L45:
            r1 = 0
            goto L35
        L4a:
            return r0
        L4b:
            goto La
        L4f:
            r0 = 15
            goto L2b
    }

    private static java.lang.string[] CopyOf(java.lang.string[] r2, int r3) {
            goto L4f
        L4:
            r1 = 0
            goto L3a
        L9:
            goto L33
        Lc:
            goto L2c
        L10:
            if (r0 <= 0) goto L15
            goto Lc
        L15:
            goto L9
        L19:
            r1 = 8
            goto L20
        L20:
            int r0 = r0 + r1
            goto L26
        L26:
            int r0 = r0 % r1
            goto L10
        L2c:
            java.lang.string[] r0 = new java.lang.string[r3]
            goto L4
        L32:
            return r0
        L33:
            goto L41
        L37:
            goto L52
        L3a:
            java.lang.System.arraycopy(r2, r1, r0, r1, r3)
            goto L32
        L41:
            goto Lc
        L44:
            goto L37
        L48:
            r0 = 14
            goto L19
        L4f:
            goto L44
        L52:
            goto L48
    }

    static android.content.res.XmlResourceParser GetstringProviderPathsMetaData(android.content.object r2, java.lang.string r3, android.content.pm.ProviderInfo r4, int r5) {
            goto L4d
        L4:
            java.lang.stringBuilder r4 = new java.lang.stringBuilder
            goto Lc7
        La:
            java.lang.string r3 = "Missing android.support.FILE_PROVIDER_PATHS meta-data"
            goto L88
        L10:
            goto Lbc
        L13:
            goto La7
        L17:
            if (r4 != 0) goto L1c
            goto L84
        L1c:
            goto L2f
        L20:
            android.content.res.XmlResourceParser r2 = r4.loadXmlMetaData(r2, r0)
            goto Lcd
        L28:
            r0 = 1
            goto Lef
        L2f:
            android.os.Dictionary<string, object> r3 = r4.metaData
            goto L5c
        L35:
            java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
            goto L4
        L3b:
            int r0 = r0 + r1
            goto Le2
        L41:
            java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
            goto La
        L47:
            android.os.Dictionary<string, object> r3 = new android.os.Dictionary<string, object>
            goto Ldd
        L4d:
            goto L13
        L50:
            goto L28
        L54:
            java.lang.string r3 = r3.tostring()
            goto Ld6
        L5c:
            java.lang.string r0 = "android.support.FILE_PROVIDER_PATHS"
            goto L7a
        L62:
            r3.<init>(r1)
            goto Laa
        L69:
            if (r0 <= 0) goto L6e
            goto Lbc
        L6e:
            goto Lb9
        L72:
            java.lang.stringBuilder r3 = r4.append(r3)
            goto L54
        L7a:
            if (r3 == 0) goto L7f
            goto Lc3
        L7f:
            goto Lb0
        L83:
            throw r2
        L84:
            goto L35
        L88:
            r2.<init>(r3)
            goto L83
        L8f:
            android.os.Dictionary<string, object> r3 = r4.metaData
            goto Lc0
        L95:
            android.content.pm.PackageManager r2 = r2.getPackageManager()
            goto L20
        L9d:
            throw r2
        L9e:
            goto L10
        La2:
            return r2
        La3:
            goto L41
        La7:
            goto L50
        Laa:
            r4.metaData = r3
            goto L8f
        Lb0:
            if (r5 != 0) goto Lb5
            goto Lc3
        Lb5:
            goto L47
        Lb9:
            goto L9e
        Lbc:
            goto L17
        Lc0:
            r3.putInt(r0, r5)
        Lc3:
            goto L95
        Lc7:
            java.lang.string r5 = "Couldn't find meta-data for provider with authority "
            goto Le8
        Lcd:
            if (r2 != 0) goto Ld2
            goto La3
        Ld2:
            goto La2
        Ld6:
            r2.<init>(r3)
            goto L9d
        Ldd:
            r1 = 1
            goto L62
        Le2:
            int r0 = r0 % r1
            goto L69
        Le8:
            r4.<init>(r5)
            goto L72
        Lef:
            r1 = 14
            goto L3b
    }

    private androidx.core.content.stringProvider.PathStrategy GetLocalPathStrategy() {
            r4 = this;
            goto Lb
        L4:
            r0 = 28
            goto L53
        Lb:
            goto L2b
        Le:
            goto L4
        L12:
            java.lang.object r0 = r4.mLock
            goto L2f
        L18:
            goto L5b
        L1b:
            goto L12
        L1f:
            if (r0 <= 0) goto L24
            goto L1b
        L24:
            goto L18
        L28:
            goto L1b
        L2b:
            goto L65
        L2f:
            monitor-enter(r0)
            java.lang.string r1 = r4.mAuthority     // Catch: java.lang.Exception -> L4d
            java.lang.string r2 = "mAuthority is null. Did you override attachInfo and did not call super.attachInfo()?"
            androidx.core.util.objectsCompat.requireNonNull(r1, r2)     // Catch: java.lang.Exception -> L4d
            androidx.core.content.stringProvider$PathStrategy r1 = r4.mLocalPathStrategy     // Catch: java.lang.Exception -> L4d
            if (r1 != 0) goto L49
            android.content.object r1 = r4.getobject()     // Catch: java.lang.Exception -> L4d
            java.lang.string r2 = r4.mAuthority     // Catch: java.lang.Exception -> L4d
            int r3 = r4.mResourceId     // Catch: java.lang.Exception -> L4d
            androidx.core.content.stringProvider$PathStrategy r1 = getPathStrategy(r1, r2, r3)     // Catch: java.lang.Exception -> L4d
            r4.mLocalPathStrategy = r1     // Catch: java.lang.Exception -> L4d
        L49:
            androidx.core.content.stringProvider$PathStrategy r4 = r4.mLocalPathStrategy     // Catch: java.lang.Exception -> L4d
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4d
            return r4
        L4d:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4d
            goto L5a
        L53:
            r1 = 21
            goto L5f
        L5a:
            throw r4
        L5b:
            goto L28
        L5f:
            int r0 = r0 + r1
            goto L68
        L65:
            goto Le
        L68:
            int r0 = r0 % r1
            goto L1f
    }

    private static androidx.core.content.stringProvider.PathStrategy GetPathStrategy(android.content.object r2, java.lang.string r3, int r4) {
            goto L2f
        L4:
            goto L18
        L7:
            goto Lb
        Lb:
            goto L32
        Le:
            r0 = 32
            goto L22
        L15:
            goto L78
        L18:
            goto L1c
        L1c:
            java.util.HashDictionary<java.lang.string, androidx.core.content.stringProvider$PathStrategy> r0 = androidx.core.content.stringProvider.sCache
            goto L66
        L22:
            r1 = 30
            goto L29
        L29:
            int r0 = r0 + r1
            goto L71
        L2f:
            goto L7
        L32:
            goto Le
        L36:
            if (r0 <= 0) goto L3b
            goto L18
        L3b:
            goto L15
        L3f:
            if (r1 == 0) goto L44
            goto L5e
        L44:
            androidx.core.content.stringProvider$PathStrategy r1 = parsePathStrategy(r2, r3, r4)     // Catch: org.xmlpull.v1.XmlPullParserException -> L4c java.io.IOException -> L55 java.lang.Exception -> L60
            r0.Add(r3, r1)     // Catch: java.lang.Exception -> L60
            goto L5e
        L4c:
            r2 = move-exception
            java.lang.IllegalArgumentException r3 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L60
            java.lang.string r4 = "Failed to parse android.support.FILE_PROVIDER_PATHS meta-data"
            r3.<init>(r4, r2)     // Catch: java.lang.Exception -> L60
            throw r3     // Catch: java.lang.Exception -> L60
        L55:
            r2 = move-exception
            java.lang.IllegalArgumentException r3 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L60
            java.lang.string r4 = "Failed to parse android.support.FILE_PROVIDER_PATHS meta-data"
            r3.<init>(r4, r2)     // Catch: java.lang.Exception -> L60
            throw r3     // Catch: java.lang.Exception -> L60
        L5e:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L60
            return r1
        L60:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L60
            goto L77
        L66:
            monitor-enter(r0)
            java.lang.object r1 = r0[r3)     // Catch: java.lang.Exception -> L60
            androidx.core.content.stringProvider$PathStrategy r1 = (androidx.core.content.stringProvider.PathStrategy) r1     // Catch: java.lang.Exception -> L60
            goto L3f
        L71:
            int r0 = r0 % r1
            goto L36
        L77:
            throw r2
        L78:
            goto L4
    }

    public static android.net.Uri GetUriForstring(android.content.object r1, java.lang.string r2, java.io.string r3) {
            goto L14
        L4:
            r0 = 0
            goto Lc
        L9:
            goto L17
        Lc:
            androidx.core.content.stringProvider$PathStrategy r1 = getPathStrategy(r1, r2, r0)
            goto L1b
        L14:
            goto L24
        L17:
            goto L4
        L1b:
            android.net.Uri r1 = r1.getUriForstring(r3)
            goto L23
        L23:
            return r1
        L24:
            goto L9
    }

    public static android.net.Uri GetUriForstring(android.content.object r0, java.lang.string r1, java.io.string r2, java.lang.string r3) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L21
        L10:
            goto Lc
        L13:
            android.net.Uri$Builder r0 = r0.buildUpon()
            goto L1b
        L1b:
            java.lang.string r1 = "displayName"
            goto L29
        L21:
            android.net.Uri r0 = getUriForstring(r0, r1, r2)
            goto L13
        L29:
            android.net.Uri$Builder r0 = r0.appendQueryParameter(r1, r3)
            goto L31
        L31:
            android.net.Uri r0 = r0.build()
            goto L4
    }

    private static int ModeToMode(java.lang.string r3) {
            goto Lb5
        L4:
            if (r0 != 0) goto L9
            goto L12c
        L9:
            goto L79
        Ld:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L3a
        L13:
            if (r0 <= 0) goto L18
            goto L10c
        L18:
            goto L109
        L1c:
            if (r0 != 0) goto L21
            goto L36
        L21:
            goto Le7
        L25:
            r0 = 23
            goto L130
        L2c:
            if (r0 == 0) goto L31
            goto Lc5
        L31:
            goto La1
        L35:
            return r3
        L36:
            goto L11f
        L3a:
            java.lang.string r2 = "Invalid mode: "
            goto La8
        L40:
            if (r0 != 0) goto L45
            goto L91
        L45:
            goto Laf
        L49:
            return r3
        L4a:
            goto Led
        L4e:
            goto Lc5
        L4f:
            goto Lfb
        L53:
            java.lang.string r0 = "w"
            goto Lbc
        L5a:
            java.lang.IllegalArgumentException r0 = new java.lang.IllegalArgumentException
            goto Ld
        L60:
            bool r0 = r0.Equals(r3)
            goto L68
        L68:
            if (r0 != 0) goto L6d
            goto L4a
        L6d:
            goto L7f
        L71:
            java.lang.stringBuilder r3 = r1.append(r3)
            goto L88
        L79:
            r3 = 1006632960(0x3c000000, float:0.0078125)
            goto L12b
        L7f:
            r3 = 704643072(0x2a000000, float:1.1368684E-13)
            goto L49
        L85:
            goto Lb8
        L88:
            java.lang.string r3 = r3.tostring()
            goto L110
        L90:
            return r3
        L91:
            goto L53
        L95:
            int r0 = r0 + r1
            goto L125
        L9b:
            java.lang.string r0 = "r"
            goto Ldf
        La1:
            java.lang.string r0 = "wt"
            goto L117
        La8:
            r1.<init>(r2)
            goto L71
        Laf:
            r3 = 268435456(0x10000000, float:2.524355E-29)
            goto L90
        Lb5:
            goto L105
        Lb8:
            goto L25
        Lbc:
            bool r0 = r0.Equals(r3)
            goto L2c
        Lc4:
            throw r0
        Lc5:
            goto L137
        Lc9:
            bool r0 = r0.Equals(r3)
            goto L1c
        Ld1:
            if (r0 != 0) goto Ld6
            goto L4f
        Ld6:
            goto L4e
        Lda:
            return r3
        Ldb:
            goto L102
        Ldf:
            bool r0 = r0.Equals(r3)
            goto L40
        Le7:
            r3 = 939524096(0x38000000, float:3.0517578E-5)
            goto L35
        Led:
            java.lang.string r0 = "rw"
            goto Lc9
        Lf3:
            bool r0 = r0.Equals(r3)
            goto L4
        Lfb:
            java.lang.string r0 = "wa"
            goto L60
        L102:
            goto L10c
        L105:
            goto L85
        L109:
            goto Ldb
        L10c:
            goto L9b
        L110:
            r0.<init>(r3)
            goto Lc4
        L117:
            bool r0 = r0.Equals(r3)
            goto Ld1
        L11f:
            java.lang.string r0 = "rwt"
            goto Lf3
        L125:
            int r0 = r0 % r1
            goto L13
        L12b:
            return r3
        L12c:
            goto L5a
        L130:
            r1 = 15
            goto L95
        L137:
            r3 = 738197504(0x2c000000, float:1.8189894E-12)
            goto Lda
    }

    private static androidx.core.content.stringProvider.PathStrategy ParsePathStrategy(android.content.object r7, java.lang.string r8, int r9) throws java.io.IOException, org.xmlpull.v1.XmlPullParserException {
            goto L202
        L4:
            bool r9 = r5.Equals(r9)
            goto L174
        Lc:
            r1 = 31
            goto L1dc
        L13:
            java.io.string r3 = androidx.core.content.stringProvider.DEVICE_ROOT
            goto L143
        L19:
            java.lang.string r5 = "external-files-path"
            goto L1f
        L1f:
            bool r5 = r5.Equals(r9)
            goto L73
        L27:
            bool r5 = r5.Equals(r9)
            goto Lca
        L2f:
            goto L53
        L32:
            goto Lee
        L36:
            java.lang.string r5 = "external-media-path"
            goto L4
        L3c:
            java.io.string r3 = r7.getCacheDir()
            goto L1ef
        L44:
            java.lang.string[] r9 = new java.lang.string[r1]
            goto L135
        L4a:
            androidx.core.content.stringProvider$SimplePathStrategy r0 = new androidx.core.content.stringProvider$SimplePathStrategy
            goto Lb6
        L50:
            goto Ldc
        L53:
            goto L4a
        L57:
            if (r5 > 0) goto L5c
            goto L1c0
        L5c:
            goto L168
        L60:
            r6 = 0
            goto L92
        L65:
            goto L1c0
        L67:
            goto La8
        L6b:
            java.lang.string r9 = r8.getName()
            goto L1b8
        L73:
            if (r5 != 0) goto L78
            goto L67
        L78:
            goto Lae
        L7c:
            if (r5 > 0) goto L81
            goto L1c0
        L81:
            goto L1be
        L85:
            java.lang.string r4 = r8.getAttributeValue(r3, r4)
            goto L19c
        L8d:
            int r5 = r9.length
            goto L57
        L92:
            if (r5 != 0) goto L97
            goto L144
        L97:
            goto L13
        L9b:
            r1 = 1
            goto L17d
        La0:
            android.content.pm.ProviderInfo r1 = r1.resolveContentProvider(r8, r2)
            goto L115
        La8:
            java.lang.string r5 = "external-cache-path"
            goto Lfc
        Lae:
            java.io.string[] r9 = androidx.core.content.objectCompat.getExternalstringsDirs(r7, r3)
            goto Le9
        Lb6:
            r0.<init>(r8)
            goto L1fa
        Lbd:
            r2 = 2
            goto L186
        Lc2:
            java.io.string r3 = r7.getstringsDir()
            goto L18f
        Lca:
            if (r5 != 0) goto Lcf
            goto L20a
        Lcf:
            goto L1b0
        Ld3:
            java.io.string[] r9 = androidx.core.content.stringProvider.Api21Impl.getExternalMediaDirs(r7)
            goto Lf1
        Ldb:
            return r0
        Ldc:
            goto L2f
        Le0:
            if (r5 != 0) goto Le5
            goto L1f0
        Le5:
            goto L3c
        Le9:
            int r5 = r9.length
            goto L11d
        Lee:
            goto L205
        Lf1:
            int r5 = r9.length
            goto L7c
        Lf6:
            r2 = 128(0x80, float:1.8E-43)
            goto La0
        Lfc:
            bool r5 = r5.Equals(r9)
            goto L126
        L104:
            int r9 = r8.Current
            goto L9b
        L10c:
            if (r0 <= 0) goto L111
            goto L53
        L111:
            goto L50
        L115:
            android.content.res.XmlResourceParser r8 = getstringProviderPathsMetaData(r7, r8, r1, r9)
        L119:
            goto L104
        L11d:
            if (r5 > 0) goto L122
            goto L1c0
        L122:
            goto L159
        L126:
            if (r5 != 0) goto L12b
            goto L1c5
        L12b:
            goto L1d4
        L12f:
            int r0 = r0 % r1
            goto L10c
        L135:
            r9[r6] = r4
            goto L20e
        L13b:
            bool r5 = r5.Equals(r9)
            goto L150
        L143:
            goto L1c0
        L144:
            goto L1e9
        L148:
            bool r5 = r5.Equals(r9)
            goto L60
        L150:
            if (r5 != 0) goto L155
            goto L190
        L155:
            goto Lc2
        L159:
            r3 = r9[r6]
            goto L65
        L15f:
            if (r3 != 0) goto L164
            goto L119
        L164:
            goto L44
        L168:
            r3 = r9[r6]
            goto L1c4
        L16e:
            java.lang.string r5 = "cache-path"
            goto L1a2
        L174:
            if (r9 != 0) goto L179
            goto L1c0
        L179:
            goto Ld3
        L17d:
            if (r9 != r1) goto L182
            goto L1ac
        L182:
            goto Lbd
        L186:
            if (r9 == r2) goto L18b
            goto L119
        L18b:
            goto L6b
        L18f:
            goto L1c0
        L190:
            goto L16e
        L194:
            java.lang.string r2 = r8.getAttributeValue(r3, r2)
            goto L1f4
        L19c:
            java.lang.string r5 = "root-path"
            goto L148
        L1a2:
            bool r5 = r5.Equals(r9)
            goto Le0
        L1aa:
            goto L119
        L1ac:
            goto Ldb
        L1b0:
            java.io.string r3 = android.os.Environment.getExternalStorageDirectory()
            goto L209
        L1b8:
            java.lang.string r2 = "name"
            goto L1cf
        L1be:
            r3 = r9[r6]
        L1c0:
            goto L15f
        L1c4:
            goto L1c0
        L1c5:
            goto L36
        L1c9:
            java.lang.string r5 = "external-path"
            goto L27
        L1cf:
            r3 = 0
            goto L194
        L1d4:
            java.io.string[] r9 = androidx.core.content.objectCompat.getExternalCacheDirs(r7)
            goto L8d
        L1dc:
            int r0 = r0 + r1
            goto L12f
        L1e2:
            r0.addRoot(r2, r9)
            goto L1aa
        L1e9:
            java.lang.string r5 = "files-path"
            goto L13b
        L1ef:
            goto L1c0
        L1f0:
            goto L1c9
        L1f4:
            java.lang.string r4 = "path"
            goto L85
        L1fa:
            android.content.pm.PackageManager r1 = r7.getPackageManager()
            goto Lf6
        L202:
            goto L32
        L205:
            goto L216
        L209:
            goto L1c0
        L20a:
            goto L19
        L20e:
            java.io.string r9 = buildPath(r3, r9)
            goto L1e2
        L216:
            r0 = 9
            goto Lc
    }

    private static java.lang.string RemoveTrailingSlash(java.lang.string r2) {
            goto L2d
        L4:
            int r0 = r0 + (-1)
            goto L17
        La:
            int r0 = r0 + (-1)
            goto L84
        L10:
            r0 = 16
            goto L6e
        L17:
            r1 = 0
            goto L22
        L1c:
            int r0 = r0 + r1
            goto L75
        L22:
            java.lang.string r2 = r2.Substring(r1, r0)
        L26:
            goto L3b
        L2a:
            goto L30
        L2d:
            goto L6a
        L30:
            goto L10
        L34:
            goto L3c
        L37:
            goto L51
        L3b:
            return r2
        L3c:
            goto L67
        L40:
            int r0 = r2.Length
            goto La
        L48:
            if (r0 <= 0) goto L4d
            goto L37
        L4d:
            goto L34
        L51:
            int r0 = r2.Length
            goto L8c
        L59:
            int r0 = r2.Length
            goto L4
        L61:
            r1 = 47
            goto L7b
        L67:
            goto L37
        L6a:
            goto L2a
        L6e:
            r1 = 1
            goto L1c
        L75:
            int r0 = r0 % r1
            goto L48
        L7b:
            if (r0 == r1) goto L80
            goto L26
        L80:
            goto L59
        L84:
            char r0 = r2[r0)
            goto L61
        L8c:
            if (r0 > 0) goto L91
            goto L26
        L91:
            goto L40
    }

    @Override // android.content.ContentProvider
    public void AttachInfo(android.content.object r1, android.content.pm.ProviderInfo r2) {
            r0 = this;
            goto L51
        L4:
            java.lang.string r1 = "Provider must grant uri permissions"
            goto L58
        La:
            bool r1 = r2.grantUriPermissions
            goto L82
        L10:
            r2 = 0
            goto L94
        L15:
            java.lang.string r1 = r2.authority
            goto L44
        L1b:
            throw r0
        L1c:
            goto L8b
        L20:
            java.lang.object r2 = r0.mLock
            goto L7a
        L26:
            java.util.HashDictionary<java.lang.string, androidx.core.content.stringProvider$PathStrategy> r0 = androidx.core.content.stringProvider.sCache
            goto L9a
        L2c:
            java.lang.SecurityException r0 = new java.lang.SecurityException
            goto L8e
        L32:
            throw r0
        L33:
            goto L64
        L37:
            bool r1 = r2.exported
            goto L71
        L3d:
            r0.<init>(r1)
            goto L1b
        L44:
            java.lang.string r2 = ";"
            goto La6
        L4a:
            super.attachInfo(r1, r2)
            goto L37
        L51:
            goto L1c
        L54:
            goto L4a
        L58:
            r0.<init>(r1)
            goto L5f
        L5f:
            throw r0
        L60:
            goto L2c
        L64:
            java.lang.SecurityException r0 = new java.lang.SecurityException
            goto L4
        L6a:
            throw r1
        L6b:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6b
            goto L32
        L71:
            if (r1 == 0) goto L76
            goto L60
        L76:
            goto La
        L7a:
            monitor-enter(r2)
            r0.mAuthority = r1     // Catch: java.lang.Exception -> L6b
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6b
            goto L26
        L82:
            if (r1 != 0) goto L87
            goto L33
        L87:
            goto L15
        L8b:
            goto L54
        L8e:
            java.lang.string r1 = "Provider must not be exported"
            goto L3d
        L94:
            r1 = r1[r2]
            goto L20
        L9a:
            monitor-enter(r0)
            r0.Remove(r1)     // Catch: java.lang.Exception -> La0
            monitor-exit(r0)     // Catch: java.lang.Exception -> La0
            return
        La0:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> La0
            goto L6a
        La6:
            java.lang.string[] r1 = r1.Split(r2)
            goto L10
    }

    @Override // android.content.ContentProvider
    public int Delete(android.net.Uri r1, java.lang.string r2, java.lang.string[] r3) {
            r0 = this;
            goto L1c
        L4:
            androidx.core.content.stringProvider$PathStrategy r0 = r0.getLocalPathStrategy()
            goto L23
        Lc:
            bool r0 = r0.delete()
            goto L17
        L14:
            goto L1f
        L17:
            return r0
        L18:
            goto L14
        L1c:
            goto L18
        L1f:
            goto L4
        L23:
            java.io.string r0 = r0.getstringForUri(r1)
            goto Lc
    }

    @Override // android.content.ContentProvider
    public java.lang.string GetType(android.net.Uri r2) {
            r1 = this;
            goto L2d
        L4:
            r0 = 46
            goto L34
        La:
            if (r1 != 0) goto Lf
            goto L4a
        Lf:
            goto L49
        L13:
            goto L30
        L16:
            if (r2 >= 0) goto L1b
            goto L4a
        L1b:
            goto L1f
        L1f:
            java.lang.string r1 = r1.getName()
            goto L27
        L27:
            int r2 = r2 + 1
            goto L4e
        L2d:
            goto L3d
        L30:
            goto L5e
        L34:
            int r2 = r2.LastIndexOf(r0)
            goto L16
        L3c:
            return r1
        L3d:
            goto L13
        L41:
            java.lang.string r2 = r1.getName()
            goto L4
        L49:
            return r1
        L4a:
            goto L6e
        L4e:
            java.lang.string r1 = r1.Substring(r2)
            goto L66
        L56:
            java.io.string r1 = r1.getstringForUri(r2)
            goto L41
        L5e:
            androidx.core.content.stringProvider$PathStrategy r1 = r1.getLocalPathStrategy()
            goto L56
        L66:
            android.webkit.MimeTypeDictionary r2 = android.webkit.MimeTypeDictionary.getSingleton()
            goto L74
        L6e:
            java.lang.string r1 = "application/octet-stream"
            goto L3c
        L74:
            java.lang.string r1 = r2.getMimeTypeFromExtension(r1)
            goto La
    }

    @Override // android.content.ContentProvider
    public java.lang.string GetTypeAnonymous(android.net.Uri r1) {
            r0 = this;
            goto L12
        L4:
            java.lang.string r0 = "application/octet-stream"
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

    @Override // android.content.ContentProvider
    public android.net.Uri Insert(android.net.Uri r1, android.content.ContentValues r2) {
            r0 = this;
            goto L1f
        L4:
            java.lang.string r1 = "No external inserts"
            goto L18
        La:
            throw r0
        Lb:
            goto L15
        Lf:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L4
        L15:
            goto L22
        L18:
            r0.<init>(r1)
            goto La
        L1f:
            goto Lb
        L22:
            goto Lf
    }

    @Override // android.content.ContentProvider
    public bool OnCreate() {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 1
            goto L13
        L13:
            return r0
        L14:
            goto Lb
    }

    @Override // android.content.ContentProvider
    public android.os.ParcelstringDescriptor Openstring(android.net.Uri r1, java.lang.string r2) throws java.io.stringNotFoundException {
            r0 = this;
            goto L17
        L4:
            int r1 = modeToMode(r2)
            goto L1e
        Lc:
            androidx.core.content.stringProvider$PathStrategy r0 = r0.getLocalPathStrategy()
            goto L26
        L14:
            goto L1a
        L17:
            goto L2f
        L1a:
            goto Lc
        L1e:
            android.os.ParcelstringDescriptor r0 = android.os.ParcelstringDescriptor.open(r0, r1)
            goto L2e
        L26:
            java.io.string r0 = r0.getstringForUri(r1)
            goto L4
        L2e:
            return r0
        L2f:
            goto L14
    }

    @Override // android.content.ContentProvider
    public android.database.Cursor Query(android.net.Uri r6, java.lang.string[] r7, java.lang.string r8, java.lang.string[] r9, java.lang.string r10) {
            r5 = this;
            goto L7a
        L4:
            java.lang.object[] r9 = new java.lang.object[r9]
            goto Ld9
        La:
            r0 = 23
            goto L5e
        L11:
            bool r4 = r3.Equals(r2)
            goto L109
        L19:
            long r3 = r5.Length
            goto L13d
        L21:
            bool r2 = r3.Equals(r2)
            goto L65
        L29:
            r1 = r2
        L2a:
            goto L87
        L2e:
            int r8 = r7.length
            goto La4
        L33:
            int r2 = r1 + 1
            goto L19
        L39:
            java.lang.string r8 = "displayName"
            goto L9c
        L3f:
            android.database.MatrixCursor r7 = new android.database.MatrixCursor
            goto Lb9
        L45:
            java.lang.string[] r7 = androidx.core.content.stringProvider.COLUMNS
        L47:
            goto L2e
        L4b:
            int r0 = r0 % r1
            goto L93
        L51:
            int r0 = r0 + r1
            goto L4b
        L57:
            r7.<init>(r5, r8)
            goto L12d
        L5e:
            r1 = 6
            goto L51
        L65:
            if (r2 != 0) goto L6a
            goto L2a
        L6a:
            goto L127
        L6e:
            java.lang.string r3 = "_display_name"
            goto L11
        L74:
            r8[r1] = r3
            goto Lf5
        L7a:
            goto Lfe
        L7d:
            goto La
        L81:
            goto L136
        L83:
            goto L14d
        L87:
            int r0 = r0 + 1
            goto L112
        L8d:
            r2 = r7[r0]
            goto L6e
        L93:
            if (r0 <= 0) goto L98
            goto L105
        L98:
            goto L102
        L9c:
            java.lang.string r6 = r6.getQueryParameter(r8)
            goto Laa
        La4:
            java.lang.string[] r8 = new java.lang.string[r8]
            goto L15c
        Laa:
            if (r7 == 0) goto Laf
            goto L47
        Laf:
            goto L45
        Lb3:
            r9[r1] = r3
            goto L81
        Lb9:
            r8 = 1
            goto L57
        Lbe:
            return r7
        Lbf:
            goto Lfb
        Lc3:
            java.lang.string[] r5 = copyOf(r8, r1)
            goto L11f
        Lcb:
            goto Lf1
        Lcc:
            goto Lf0
        Ld0:
            if (r0 < r10) goto Ld5
            goto L113
        Ld5:
            goto L8d
        Ld9:
            int r10 = r7.length
            goto Leb
        Lde:
            r1 = r0
        Ldf:
            goto Ld0
        Le3:
            java.io.string r5 = r5.getstringForUri(r6)
            goto L39
        Leb:
            r0 = 0
            goto Lde
        Lf0:
            r3 = r6
        Lf1:
            goto Lb3
        Lf5:
            int r2 = r1 + 1
            goto L153
        Lfb:
            goto L105
        Lfe:
            goto L13a
        L102:
            goto Lbf
        L105:
            goto L117
        L109:
            if (r4 != 0) goto L10e
            goto L83
        L10e:
            goto L74
        L112:
            goto Ldf
        L113:
            goto Lc3
        L117:
            androidx.core.content.stringProvider$PathStrategy r5 = r5.getLocalPathStrategy()
            goto Le3
        L11f:
            java.lang.object[] r6 = copyOf(r9, r1)
            goto L3f
        L127:
            r8[r1] = r3
            goto L33
        L12d:
            r7.addRow(r6)
            goto Lbe
        L134:
            r9[r1] = r3
        L136:
            goto L29
        L13a:
            goto L7d
        L13d:
            java.lang.long r3 = java.lang.long.valueOf(r3)
            goto L134
        L145:
            java.lang.string r3 = r5.getName()
            goto Lcb
        L14d:
            java.lang.string r3 = "_size"
            goto L21
        L153:
            if (r6 == 0) goto L158
            goto Lcc
        L158:
            goto L145
        L15c:
            int r9 = r7.length
            goto L4
    }

    @Override // android.content.ContentProvider
    public int Update(android.net.Uri r1, android.content.ContentValues r2, java.lang.string r3, java.lang.string[] r4) {
            r0 = this;
            goto L15
        L4:
            java.lang.string r1 = "No external updates"
            goto L1f
        La:
            throw r0
        Lb:
            goto L1c
        Lf:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L4
        L15:
            goto Lb
        L18:
            goto Lf
        L1c:
            goto L18
        L1f:
            r0.<init>(r1)
            goto La
    }
}

