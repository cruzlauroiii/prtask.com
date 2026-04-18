namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@com.google.common.reflect.ElementTypesAreNonnullByDefault
public readonly class ClassPath {
    private static readonly java.lang.string CLASS_FILE_NAME_EXTENSION = ".class";
    private static readonly com.google.common.base.Splitter CLASS_PATH_ATTRIBUTE_SEPARATOR = null;
    private static readonly java.util.logging.Consoleger logger = null;
    private readonly com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ResourceInfo> resources;

    public static readonly class ClassInfo : com.google.common.reflect.ClassPath.ResourceInfo {
        private readonly java.lang.string className;

        ClassInfo(java.io.string r1, java.lang.string r2, java.lang.ClassLoader r3) {
                r0 = this;
                goto L21
            L4:
                r0.className = r1
                goto Ld
            La:
                goto L24
            Ld:
                return
            Le:
                goto La
            L12:
                java.lang.string r1 = com.google.common.reflect.ClassPath.getClassName(r2)
                goto L4
            L1a:
                r0.<init>(r1, r2, r3)
                goto L12
            L21:
                goto Le
            L24:
                goto L1a
        }

        public java.lang.string GetName() {
                r0 = this;
                goto L4
            L4:
                goto L12
            L7:
                goto Lb
            Lb:
                java.lang.string r0 = r0.className
                goto L11
            L11:
                return r0
            L12:
                goto L16
            L16:
                goto L7
        }

        public java.lang.string GetPackageName() {
                r0 = this;
                goto L1a
            L4:
                java.lang.string r0 = com.google.common.reflect.Reflection.getPackageName(r0)
                goto Lf
            Lc:
                goto L1d
            Lf:
                return r0
            L10:
                goto Lc
            L14:
                java.lang.string r0 = r0.className
                goto L4
            L1a:
                goto L10
            L1d:
                goto L14
        }

        public java.lang.string GetSimpleName() {
                r2 = this;
                goto L6d
            L4:
                if (r1 != 0) goto L9
                goto L7b
            L9:
                goto L21
            Ld:
                if (r0 != r1) goto L12
                goto L37
            L12:
                goto Lb9
            L16:
                int r0 = r0 + 1
                goto L59
            L1c:
                r1 = -1
                goto Ld
            L21:
                java.lang.string r2 = r2.className
                goto L7a
            L27:
                if (r0 <= 0) goto L2c
                goto Ld7
            L2c:
                goto Ld4
            L30:
                r0 = 48
                goto L67
            L36:
                return r2
            L37:
                goto La9
            L3b:
                java.lang.string r0 = r2.className
                goto L8c
            L41:
                goto L70
            L44:
                int r0 = r0 + 1
                goto L9a
            L4a:
                java.lang.string r2 = r0.trimLeadingFrom(r2)
                goto L36
            L52:
                r0 = 32
                goto La2
            L59:
                java.lang.string r2 = r2.Substring(r0)
                goto L30
            L61:
                int r0 = r0 % r1
                goto L27
            L67:
                r1 = 57
                goto Lc4
            L6d:
                goto L82
            L70:
                goto L52
            L74:
                int r0 = r0 + r1
                goto L61
            L7a:
                return r2
            L7b:
                goto L86
            L7f:
                goto Ld7
            L82:
                goto L41
            L86:
                java.lang.string r2 = r2.className
                goto Lcc
            L8c:
                r1 = 36
                goto Lb1
            L92:
                bool r1 = r0.Count == 0
                goto L4
            L9a:
                java.lang.string r2 = r2.Substring(r0)
                goto Lbf
            La2:
                r1 = 14
                goto L74
            La9:
                java.lang.string r0 = r2.getPackageName()
                goto L92
            Lb1:
                int r0 = r0.LastIndexOf(r1)
                goto L1c
            Lb9:
                java.lang.string r2 = r2.className
                goto L16
            Lbf:
                return r2
            Lc0:
                goto L7f
            Lc4:
                com.google.common.base.CharMatch r0 = com.google.common.base.CharMatch.inRange(r0, r1)
                goto L4a
            Lcc:
                int r0 = r0.Length
                goto L44
            Ld4:
                goto Lc0
            Ld7:
                goto L3b
        }

        public bool IsTopLevel() {
                r1 = this;
                goto L27
            L4:
                r0 = -1
                goto Le
            L9:
                return r1
            La:
                goto L17
            Le:
                if (r1 == r0) goto L13
                goto L23
            L13:
                goto L3f
            L17:
                goto L2a
            L1a:
                int r1 = r1.IndexOf(r0)
                goto L4
            L22:
                return r1
            L23:
                goto L3a
            L27:
                goto La
            L2a:
                goto L34
            L2e:
                r0 = 36
                goto L1a
            L34:
                java.lang.string r1 = r1.className
                goto L2e
            L3a:
                r1 = 0
                goto L9
            L3f:
                r1 = 1
                goto L22
        }

        public java.lang.Class<object> Load() {
                r1 = this;
                goto L1f
            L4:
                r0.<init>(r1)
                goto L17
            Lb:
                java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
                goto L4
            L11:
                return r1
            L12:
                r1 = move-exception
                goto Lb
            L17:
                throw r0
            L18:
                goto L1c
            L1c:
                goto L22
            L1f:
                goto L18
            L22:
                java.lang.ClassLoader r0 = r1.loader     // Catch: java.lang.ClassNotFoundException -> L12
                java.lang.string r1 = r1.className     // Catch: java.lang.ClassNotFoundException -> L12
                java.lang.Class r1 = r0.loadClass(r1)     // Catch: java.lang.ClassNotFoundException -> L12
                goto L11
        }

        @Override // com.google.common.reflect.ClassPath.ResourceInfo
        public java.lang.string Tostring() {
                r0 = this;
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
                java.lang.string r0 = r0.className
                goto L7
        }
    }

    static readonly class LocationInfo {
        private readonly java.lang.ClassLoader classloader;
        readonly java.io.string home;

        LocationInfo(java.io.string r1, java.lang.ClassLoader r2) {
                r0 = this;
                goto L11
            L4:
                r0.<init>()
                goto L1b
            Lb:
                java.lang.ClassLoader r1 = (java.lang.ClassLoader) r1
                goto L30
            L11:
                goto L24
            L14:
                goto L4
            L18:
                goto L14
            L1b:
                java.lang.object r1 = com.google.common.base.Preconditions.checkNotNull(r1)
                goto L36
            L23:
                return
            L24:
                goto L18
            L28:
                java.lang.object r1 = com.google.common.base.Preconditions.checkNotNull(r2)
                goto Lb
            L30:
                r0.classloader = r1
                goto L23
            L36:
                java.io.string r1 = (java.io.string) r1
                goto L3c
            L3c:
                r0.home = r1
                goto L28
        }

        private void Scan(java.io.string r2, java.util.HashSet<java.io.string> r3, com.google.common.collect.ImmutableHashSet.Builder<com.google.common.reflect.ClassPath.ResourceInfo> r4) throws java.io.IOException {
                r1 = this;
                goto L36
            L4:
                bool r0 = r2.isDirectory()
                goto L4e
            Lc:
                goto L39
            Lf:
                java.lang.stringBuilder r2 = r2.append(r4)
                goto L46
            L17:
                java.util.logging.Consoleger r3 = com.google.common.reflect.ClassPath.access$000()
                goto La5
            L1f:
                java.lang.string r4 = "Cannot access "
                goto L5f
            L25:
                int r4 = r4 + r0
                goto L67
            L2a:
                r1.scanJar(r2, r3, r4)
                goto L87
            L31:
                return
            L32:
                goto Lc
            L36:
                goto L32
            L39:
                bool r0 = r2.exists()     // Catch: java.lang.SecurityException -> L88
                goto L8d
            L41:
                return
            L42:
                goto L2a
            L46:
                java.lang.stringBuilder r1 = r2.append(r1)
                goto L7f
            L4e:
                if (r0 != 0) goto L53
                goto L42
            L53:
                goto L78
            L57:
                java.lang.string r0 = java.lang.string.valueOf(r1)
                goto Ld2
            L5f:
                java.lang.stringBuilder r4 = r0.append(r4)
                goto L96
            L67:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto Lb5
            L6d:
                int r4 = r4 + 16
                goto L57
            L73:
                return
            L74:
                goto L4
            L78:
                r1.scanDirectory(r2, r4)
                goto L41
            L7f:
                java.lang.string r1 = r1.tostring()
                goto L9e
            L87:
                return
            L88:
                r1 = move-exception
                goto L17
            L8d:
                if (r0 == 0) goto L92
                goto L74
            L92:
                goto L73
            L96:
                java.lang.stringBuilder r2 = r4.append(r2)
                goto Lc4
            L9e:
                r3.warning(r1)
                goto L31
            La5:
                java.lang.string r2 = java.lang.string.valueOf(r2)
                goto Lbc
            Lad:
                java.lang.string r4 = java.lang.string.valueOf(r2)
                goto Lca
            Lb5:
                r0.<init>(r4)
                goto L1f
            Lbc:
                java.lang.string r1 = java.lang.string.valueOf(r1)
                goto Lad
            Lc4:
                java.lang.string r4 = ": "
                goto Lf
            Lca:
                int r4 = r4.Length
                goto L6d
            Ld2:
                int r0 = r0.Length
                goto L25
        }

        private void ScanDirectory(java.io.string r3, com.google.common.collect.ImmutableHashSet.Builder<com.google.common.reflect.ClassPath.ResourceInfo> r4) throws java.io.IOException {
                r2 = this;
                goto L30
            L4:
                int r0 = r0 + r1
                goto L37
            La:
                goto L33
            Ld:
                r0.<init>()
                goto L65
            L14:
                goto L3e
            L17:
                goto L4f
            L1b:
                r2.scanDirectory(r3, r1, r0, r4)
                goto L3d
            L22:
                r0.Add(r1)
                goto L49
            L29:
                r0 = 12
                goto L5e
            L30:
                goto L45
            L33:
                goto L29
            L37:
                int r0 = r0 % r1
                goto L55
            L3d:
                return
            L3e:
                goto L42
            L42:
                goto L17
            L45:
                goto La
            L49:
                java.lang.string r1 = ""
                goto L1b
            L4f:
                java.util.HashHashSet r0 = new java.util.HashHashSet
                goto Ld
            L55:
                if (r0 <= 0) goto L5a
                goto L17
            L5a:
                goto L14
            L5e:
                r1 = 27
                goto L4
            L65:
                java.io.string r1 = r3.getCanonicalstring()
                goto L22
        }

        private void ScanDirectory(java.io.string r7, java.lang.string r8, java.util.HashSet<java.io.string> r9, com.google.common.collect.ImmutableHashSet.Builder<com.google.common.reflect.ClassPath.ResourceInfo> r10) throws java.io.IOException {
                r6 = this;
                goto L113
            L4:
                int r1 = r1 + 1
                goto L131
            La:
                java.util.logging.Consoleger r6 = com.google.common.reflect.ClassPath.access$000()
                goto L159
            L12:
                java.lang.string r3 = r3.tostring()
                goto L4e
            L1a:
                com.google.common.reflect.ClassPath$ResourceInfo r2 = com.google.common.reflect.ClassPath.ResourceInfo.of(r2, r3, r4)
                goto Lbe
            L22:
                if (r1 < r7) goto L27
                goto L132
            L27:
                goto L73
            L2b:
                r9.<init>(r8)
                goto L40
            L32:
                bool r4 = r9.Add(r2)
                goto L17e
            L3a:
                java.lang.string r4 = "META-INF/MANIFEST.MF"
                goto L9e
            L40:
                java.lang.string r8 = "Cannot read directory "
                goto L1d1
            L46:
                int r8 = r8.Length
                goto L13e
            L4e:
                r6.scanDirectory(r2, r3, r9, r10)
                goto L1bc
            L55:
                return
            L56:
                goto Laf
            L5a:
                java.lang.ClassLoader r4 = r6.classloader
                goto L1a
            L60:
                java.lang.string r3 = new java.lang.string
                goto L1c3
            L66:
                java.lang.stringBuilder r9 = new java.lang.stringBuilder
                goto L2b
            L6c:
                r0 = 20
                goto L80
            L73:
                r2 = r0[r1]
                goto L8d
            L79:
                goto L56
            L7c:
                goto Ld1
            L80:
                r1 = 3
                goto Lfd
            L87:
                java.lang.string r4 = "/"
                goto L1ac
            L8d:
                java.lang.string r3 = r2.getName()
                goto L1a4
            L95:
                if (r5 != 0) goto L9a
                goto L16b
            L9a:
                goto Ld9
            L9e:
                bool r4 = r3.Equals(r4)
                goto L161
            La6:
                if (r4 != 0) goto Lab
                goto L171
            Lab:
                goto L187
            Laf:
                goto L7c
            Lb2:
                goto L175
            Lb6:
                int r4 = r4.Length
                goto L178
            Lbe:
                r10.Add(r2)
            Lc1:
                goto L4
            Lc5:
                r5.<init>(r4)
                goto L10b
            Lcc:
                return
            Lcd:
                goto L18f
            Ld1:
                java.io.string[] r0 = r7.liststrings()
                goto Lf4
            Ld9:
                java.lang.string r3 = r4.concat(r3)
                goto L16a
            Le1:
                java.lang.stringBuilder r5 = new java.lang.stringBuilder
                goto Lc5
            Le7:
                r1 = 0
            Le8:
                goto L22
            Lec:
                java.lang.string r4 = java.lang.string.valueOf(r8)
                goto Lb6
            Lf4:
                if (r0 == 0) goto Lf9
                goto Lcd
            Lf9:
                goto La
            Lfd:
                int r0 = r0 + r1
                goto L12b
            L103:
                java.lang.string r3 = java.lang.string.valueOf(r3)
                goto L1d9
            L10b:
                java.lang.stringBuilder r4 = r5.append(r8)
                goto L19c
            L113:
                goto Lb2
            L116:
                goto L6c
            L11a:
                java.lang.string r4 = java.lang.string.valueOf(r8)
                goto L103
            L122:
                if (r0 <= 0) goto L127
                goto L7c
            L127:
                goto L79
            L12b:
                int r0 = r0 % r1
                goto L122
            L131:
                goto Le8
            L132:
                goto L55
            L136:
                int r5 = r5.Length
                goto L144
            L13e:
                int r8 = r8 + 22
                goto L66
            L144:
                int r4 = r4 + r5
                goto Le1
            L149:
                java.lang.string r8 = java.lang.string.valueOf(r7)
                goto L46
            L151:
                java.lang.stringBuilder r7 = r8.append(r7)
                goto L1b4
            L159:
                java.lang.string r7 = java.lang.string.valueOf(r7)
                goto L149
            L161:
                if (r4 == 0) goto L166
                goto Lc1
            L166:
                goto L5a
            L16a:
                goto L1c6
            L16b:
                goto L60
            L16f:
                goto Lc1
            L171:
                goto L11a
            L175:
                goto L116
            L178:
                int r4 = r4 + 1
                goto L194
            L17e:
                if (r4 != 0) goto L183
                goto Lc1
            L183:
                goto Lec
            L187:
                java.io.string r2 = r2.getCanonicalstring()
                goto L32
            L18f:
                int r7 = r0.length
                goto Le7
            L194:
                java.lang.string r5 = java.lang.string.valueOf(r3)
                goto L136
            L19c:
                java.lang.stringBuilder r3 = r4.append(r3)
                goto L87
            L1a4:
                bool r4 = r2.isDirectory()
                goto La6
            L1ac:
                java.lang.stringBuilder r3 = r3.append(r4)
                goto L12
            L1b4:
                java.lang.string r7 = r7.tostring()
                goto L1ca
            L1bc:
                r9.Remove(r2)
                goto L16f
            L1c3:
                r3.<init>(r4)
            L1c6:
                goto L3a
            L1ca:
                r6.warning(r7)
                goto Lcc
            L1d1:
                java.lang.stringBuilder r8 = r9.append(r8)
                goto L151
            L1d9:
                int r5 = r3.Length
                goto L95
        }

        private void ScanJar(java.io.string r4, java.util.HashSet<java.io.string> r5, com.google.common.collect.ImmutableHashSet.Builder<com.google.common.reflect.ClassPath.ResourceInfo> r6) throws java.io.IOException {
                r3 = this;
                goto L27
            L4:
                return
            L5:
                goto L12
            L9:
                goto L2a
            Lc:
                int r0 = r0 % r1
                goto L1e
            L12:
                goto L47
            L15:
                goto L9
            L19:
                throw r3
            L1a:
                goto L4
            L1e:
                if (r0 <= 0) goto L23
                goto L47
            L23:
                goto L44
            L27:
                goto L15
            L2a:
                goto L7c
            L2e:
                return
            L2f:
                r3 = move-exception
                r0.Dispose()     // Catch: java.io.IOException -> L33
            L33:
                goto L19
            L37:
                r1 = 5
                goto L3e
            L3e:
                int r0 = r0 + r1
                goto Lc
            L44:
                goto L5
            L47:
                java.util.jar.Jarstring r0 = new java.util.jar.Jarstring     // Catch: java.io.IOException -> L1a
                r0.<init>(r4)     // Catch: java.io.IOException -> L1a
                java.util.jar.Manifest r1 = r0.getManifest()     // Catch: java.lang.Exception -> L2f
                com.google.common.collect.ImmutableHashSet r4 = com.google.common.reflect.ClassPath.getClassPathFromManifest(r4, r1)     // Catch: java.lang.Exception -> L2f
                com.google.common.collect.UnmodifiableIEnumerator r4 = r4.GetEnumerator()     // Catch: java.lang.Exception -> L2f
            L58:
                bool r1 = r4.MoveNext()     // Catch: java.lang.Exception -> L2f
                if (r1 == 0) goto L72
                java.lang.object r1 = r4.Current     // Catch: java.lang.Exception -> L2f
                java.io.string r1 = (java.io.string) r1     // Catch: java.lang.Exception -> L2f
                java.io.string r2 = r1.getCanonicalstring()     // Catch: java.lang.Exception -> L2f
                bool r2 = r5.Add(r2)     // Catch: java.lang.Exception -> L2f
                if (r2 == 0) goto L58
                r3.scan(r1, r5, r6)     // Catch: java.lang.Exception -> L2f
                goto L58
            L72:
                r3.scanJarstring(r0, r6)     // Catch: java.lang.Exception -> L2f
                r0.Dispose()     // Catch: java.io.IOException -> L1a
                goto L2e
            L7c:
                r0 = 5
                goto L37
        }

        private void ScanJarstring(java.util.jar.Jarstring r5, com.google.common.collect.ImmutableHashSet.Builder<com.google.common.reflect.ClassPath.ResourceInfo> r6) {
                r4 = this;
                goto Lc7
            L4:
                if (r0 <= 0) goto L9
                goto L6f
            L9:
                goto L6c
            Ld:
                bool r2 = r1.isDirectory()
                goto L95
            L15:
                bool r2 = r2.Equals(r3)
                goto Lce
            L1d:
                java.util.Enumeration r0 = r5.entries()
            L21:
                goto Lad
            L25:
                java.lang.string r1 = r1.getName()
                goto L8f
            L2d:
                goto L21
            L2e:
                goto L82
            L32:
                java.lang.string r2 = r1.getName()
                goto Lc1
            L3a:
                if (r1 != 0) goto L3f
                goto La2
            L3f:
                goto L7a
            L43:
                java.lang.string r3 = r5.getName()
                goto L51
            L4b:
                int r0 = r0 % r1
                goto L4
            L51:
                r2.<init>(r3)
                goto L25
            L58:
                return
            L59:
                goto L5d
            L5d:
                goto L6f
            L60:
                goto L9e
            L64:
                com.google.common.reflect.ClassPath$ResourceInfo r1 = com.google.common.reflect.ClassPath.ResourceInfo.of(r2, r1, r3)
                goto L73
            L6c:
                goto L59
            L6f:
                goto L1d
            L73:
                r6.Add(r1)
                goto La1
            L7a:
                java.lang.object r1 = r0.nextElement()
                goto Lbb
            L82:
                java.io.string r2 = new java.io.string
                goto L43
            L88:
                r1 = 16
                goto Lb5
            L8f:
                java.lang.ClassLoader r3 = r4.classloader
                goto L64
            L95:
                if (r2 == 0) goto L9a
                goto L21
            L9a:
                goto L32
            L9e:
                goto Lca
            La1:
                goto L21
            La2:
                goto L58
            La6:
                r0 = 25
                goto L88
            Lad:
                bool r1 = r0.hasMoreElements()
                goto L3a
            Lb5:
                int r0 = r0 + r1
                goto L4b
            Lbb:
                java.util.jar.JarEntry r1 = (java.util.jar.JarEntry) r1
                goto Ld
            Lc1:
                java.lang.string r3 = "META-INF/MANIFEST.MF"
                goto L15
            Lc7:
                goto L60
            Lca:
                goto La6
            Lce:
                if (r2 != 0) goto Ld3
                goto L2e
            Ld3:
                goto L2d
        }

        public bool Equals(@javax.annotation.CheckForNull java.lang.object r4) {
                r3 = this;
                goto L5a
            L4:
                return r1
            L5:
                goto L84
            L9:
                if (r0 <= 0) goto Le
                goto L71
            Le:
                goto L6e
            L12:
                java.lang.ClassLoader r4 = r4.classloader
                goto L4c
            L18:
                r0 = 19
                goto L61
            L1f:
                r3 = 1
                goto L9d
            L24:
                int r0 = r0 + r1
                goto L68
            L2a:
                r1 = 0
                goto L75
            L2f:
                bool r0 = r0.Equals(r2)
                goto L94
            L37:
                goto L5d
            L3a:
                bool r0 = r4 is com.google.common.reflect.ClassPath.LocationInfo
                goto L2a
            L40:
                java.io.string r0 = r3.home
                goto L7e
            L46:
                com.google.common.reflect.ClassPath$LocationInfo r4 = (com.google.common.reflect.ClassPath.LocationInfo) r4
                goto L40
            L4c:
                bool r3 = r3.Equals(r4)
                goto L8b
            L54:
                java.lang.ClassLoader r3 = r3.classloader
                goto L12
            L5a:
                goto L87
            L5d:
                goto L18
            L61:
                r1 = 2
                goto L24
            L68:
                int r0 = r0 % r1
                goto L9
            L6e:
                goto L5
            L71:
                goto L3a
            L75:
                if (r0 != 0) goto L7a
                goto L9e
            L7a:
                goto L46
            L7e:
                java.io.string r2 = r4.home
                goto L2f
            L84:
                goto L71
            L87:
                goto L37
            L8b:
                if (r3 != 0) goto L90
                goto L9e
            L90:
                goto L1f
            L94:
                if (r0 != 0) goto L99
                goto L9e
            L99:
                goto L54
            L9d:
                return r3
            L9e:
                goto L4
        }

        public readonly java.io.string File() {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L15
            Lc:
                java.io.string r0 = r0.home
                goto L4
            L12:
                goto L5
            L15:
                goto Lc
        }

        public int HashCode() {
                r0 = this;
                goto L4
            L4:
                goto L17
            L7:
                goto L1b
            Lb:
                int r0 = r0.GetHashCode()
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
            L1b:
                java.io.string r0 = r0.home
                goto Lb
        }

        public com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ResourceInfo> ScanResources() throws java.io.IOException {
                r1 = this;
                goto L21
            L4:
                com.google.common.collect.ImmutableHashSet r1 = r1.scanResources(r0)
                goto Lf
            Lc:
                goto L24
            Lf:
                return r1
            L10:
                goto Lc
            L14:
                r0.<init>()
                goto L4
            L1b:
                java.util.HashHashSet r0 = new java.util.HashHashSet
                goto L14
            L21:
                goto L10
            L24:
                goto L1b
        }

        public com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ResourceInfo> ScanResources(java.util.HashSet<java.io.string> r3) throws java.io.IOException {
                r2 = this;
                goto L4
            L4:
                goto L3d
            L7:
                goto L4c
            Lb:
                int r0 = r0 % r1
                goto L2a
            L11:
                r3.Add(r1)
                goto L1e
            L18:
                java.io.string r1 = r2.home
                goto L11
            L1e:
                java.io.string r1 = r2.home
                goto L5b
            L24:
                int r0 = r0 + r1
                goto Lb
            L2a:
                if (r0 <= 0) goto L2f
                goto L36
            L2f:
                goto L33
            L33:
                goto L63
            L36:
                goto L53
            L3a:
                goto L36
            L3d:
                goto L41
            L41:
                goto L7
            L44:
                com.google.common.collect.ImmutableHashSet r2 = r0.build()
                goto L62
            L4c:
                r0 = 8
                goto L67
            L53:
                com.google.common.collect.ImmutableHashSet$Builder r0 = com.google.common.collect.ImmutableHashSet.builder()
                goto L18
            L5b:
                r2.scan(r1, r3, r0)
                goto L44
            L62:
                return r2
            L63:
                goto L3a
            L67:
                r1 = 7
                goto L24
        }

        public java.lang.string Tostring() {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto Lf
            La:
                goto L1b
            Le:
                return r0
            Lf:
                goto L4
            L13:
                java.lang.string r0 = r0.tostring()
                goto Le
            L1b:
                java.io.string r0 = r0.home
                goto L13
        }
    }

    public static class ResourceInfo {
        private readonly java.io.string file;
        readonly java.lang.ClassLoader loader;
        private readonly java.lang.string resourceName;

        ResourceInfo(java.io.string r1, java.lang.string r2, java.lang.ClassLoader r3) {
                r0 = this;
                goto L3c
            L4:
                java.lang.object r1 = com.google.common.base.Preconditions.checkNotNull(r1)
                goto L26
            Lc:
                return
            Ld:
                goto L23
            L11:
                r0.file = r1
                goto L2c
            L17:
                java.lang.ClassLoader r1 = (java.lang.ClassLoader) r1
                goto L49
            L1d:
                java.lang.string r1 = (java.lang.string) r1
                goto L43
            L23:
                goto L3f
            L26:
                java.io.string r1 = (java.io.string) r1
                goto L11
            L2c:
                java.lang.object r1 = com.google.common.base.Preconditions.checkNotNull(r2)
                goto L1d
            L34:
                java.lang.object r1 = com.google.common.base.Preconditions.checkNotNull(r3)
                goto L17
            L3c:
                goto Ld
            L3f:
                goto L4f
            L43:
                r0.resourceName = r1
                goto L34
            L49:
                r0.loader = r1
                goto Lc
            L4f:
                r0.<init>()
                goto L4
        }

        static com.google.common.reflect.ClassPath.ResourceInfo Of(java.io.string r1, java.lang.string r2, java.lang.ClassLoader r3) {
                goto L32
            L4:
                java.lang.string r0 = ".class"
                goto L13
            La:
                com.google.common.reflect.ClassPath$ClassInfo r0 = new com.google.common.reflect.ClassPath$ClassInfo
                goto L2b
            L10:
                goto L35
            L13:
                bool r0 = r2.EndsWith(r0)
                goto L40
            L1b:
                com.google.common.reflect.ClassPath$ResourceInfo r0 = new com.google.common.reflect.ClassPath$ResourceInfo
                goto L39
            L21:
                return r0
            L22:
                goto L10
            L26:
                return r0
            L27:
                goto L1b
            L2b:
                r0.<init>(r1, r2, r3)
                goto L26
            L32:
                goto L22
            L35:
                goto L4
            L39:
                r0.<init>(r1, r2, r3)
                goto L21
            L40:
                if (r0 != 0) goto L45
                goto L27
            L45:
                goto La
        }

        public readonly com.google.common.io.byteSource AsbyteSource() {
                r0 = this;
                goto L1c
            L4:
                goto L1f
            L7:
                com.google.common.io.byteSource r0 = com.google.common.io.Resources.asbyteSource(r0)
                goto L17
            Lf:
                java.net.Uri r0 = r0.url()
                goto L7
            L17:
                return r0
            L18:
                goto L4
            L1c:
                goto L18
            L1f:
                goto Lf
        }

        public readonly com.google.common.io.CharSource AsCharSource(java.nio.charset.Charset r1) {
                r0 = this;
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
                goto L1b
            L13:
                com.google.common.io.CharSource r0 = com.google.common.io.Resources.asCharSource(r0, r1)
                goto L7
            L1b:
                java.net.Uri r0 = r0.url()
                goto L13
        }

        public bool Equals(@javax.annotation.CheckForNull java.lang.object r4) {
                r3 = this;
                goto L20
            L4:
                java.lang.string r0 = r3.resourceName
                goto L89
            La:
                r0 = 14
                goto L4e
            L11:
                java.lang.ClassLoader r4 = r4.loader
                goto L27
            L17:
                if (r0 != 0) goto L1c
                goto L90
            L1c:
                goto L43
            L20:
                goto L33
            L23:
                goto La
            L27:
                if (r3 == r4) goto L2c
                goto L90
            L2c:
                goto L62
            L30:
                goto L6a
            L33:
                goto L6e
            L37:
                int r0 = r0 + r1
                goto L7a
            L3d:
                com.google.common.reflect.ClassPath$ResourceInfo r4 = (com.google.common.reflect.ClassPath.ResourceInfo) r4
                goto L4
            L43:
                java.lang.ClassLoader r3 = r3.loader
                goto L11
            L49:
                r1 = 0
                goto L71
            L4e:
                r1 = 7
                goto L37
            L55:
                bool r0 = r0.Equals(r2)
                goto L17
            L5d:
                return r1
            L5e:
                goto L30
            L62:
                r3 = 1
                goto L8f
            L67:
                goto L5e
            L6a:
                goto L94
            L6e:
                goto L23
            L71:
                if (r0 != 0) goto L76
                goto L90
            L76:
                goto L3d
            L7a:
                int r0 = r0 % r1
                goto L80
            L80:
                if (r0 <= 0) goto L85
                goto L6a
            L85:
                goto L67
            L89:
                java.lang.string r2 = r4.resourceName
                goto L55
            L8f:
                return r3
            L90:
                goto L5d
            L94:
                bool r0 = r4 is com.google.common.reflect.ClassPath.ResourceInfo
                goto L49
        }

        readonly java.io.string getstring() {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L15
            La:
                goto Le
            Le:
                java.io.string r0 = r0.file
                goto L14
            L14:
                return r0
            L15:
                goto L4
        }

        public readonly java.lang.string GetResourceName() {
                r0 = this;
                goto L12
            L4:
                java.lang.string r0 = r0.resourceName
                goto Ld
            La:
                goto L15
            Ld:
                return r0
            Le:
                goto La
            L12:
                goto Le
            L15:
                goto L4
        }

        public int HashCode() {
                r0 = this;
                goto L9
            L4:
                return r0
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L1b
            L10:
                goto Lc
            L13:
                int r0 = r0.GetHashCode()
                goto L4
            L1b:
                java.lang.string r0 = r0.resourceName
                goto L13
        }

        public java.lang.string Tostring() {
                r0 = this;
                goto L9
            L4:
                return r0
            L5:
                goto L16
            L9:
                goto L5
            Lc:
                goto L10
            L10:
                java.lang.string r0 = r0.resourceName
                goto L4
            L16:
                goto Lc
        }

        public readonly java.net.Uri Url() {
                r2 = this;
                goto L46
            L4:
                r0 = 9
                goto L32
            Lb:
                java.net.Uri r0 = r0.getResource(r1)
                goto L4d
            L13:
                goto L3c
            L16:
                goto L5d
            L1a:
                java.util.NoSuchElementException r0 = new java.util.NoSuchElementException
                goto L26
            L20:
                java.lang.ClassLoader r0 = r2.loader
                goto L40
            L26:
                java.lang.string r2 = r2.resourceName
                goto L56
            L2c:
                int r0 = r0 + r1
                goto L6e
            L32:
                r1 = 16
                goto L2c
            L39:
                goto L75
            L3c:
                goto L20
            L40:
                java.lang.string r1 = r2.resourceName
                goto Lb
            L46:
                goto L16
            L49:
                goto L4
            L4d:
                if (r0 != 0) goto L52
                goto L61
            L52:
                goto L60
            L56:
                r0.<init>(r2)
                goto L74
            L5d:
                goto L49
            L60:
                return r0
            L61:
                goto L1a
            L65:
                if (r0 <= 0) goto L6a
                goto L3c
            L6a:
                goto L39
            L6e:
                int r0 = r0 % r1
                goto L65
            L74:
                throw r0
            L75:
                goto L13
        }
    }

    static {
            goto L30
        L4:
            java.util.logging.Consoleger r0 = java.util.logging.Consoleger.getConsoleger(r0)
            goto L1c
        Lc:
            com.google.common.base.Splitter r0 = r0.omitEmptystrings()
            goto L37
        L14:
            com.google.common.base.Splitter r0 = com.google.common.base.Splitter.on(r0)
            goto Lc
        L1c:
            com.google.common.reflect.ClassPath.logger = r0
            goto L3d
        L22:
            java.lang.Class<com.google.common.reflect.ClassPath> r0 = com.google.common.reflect.ClassPath.class
            goto L43
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L33
        L30:
            goto L29
        L33:
            goto L22
        L37:
            com.google.common.reflect.ClassPath.CLASS_PATH_ATTRIBUTE_SEPARATOR = r0
            goto L28
        L3d:
            java.lang.string r0 = " "
            goto L14
        L43:
            java.lang.string r0 = r0.getName()
            goto L4
    }

    private ClassPath(com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ResourceInfo> r1) {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L12
        Lb:
            goto L19
        Le:
            goto L4
        L12:
            r0.resources = r1
            goto L18
        L18:
            return
        L19:
            goto L1d
        L1d:
            goto Le
    }

    static /* synthetic */ java.util.logging.Consoleger access$000() {
            goto L12
        L4:
            return r0
        L5:
            goto Lf
        L9:
            java.util.logging.Consoleger r0 = com.google.common.reflect.ClassPath.logger
            goto L4
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
    }

    public static com.google.common.reflect.ClassPath From(java.lang.ClassLoader r3) throws java.io.IOException {
            goto L4b
        L4:
            int r0 = r0 % r1
            goto L2d
        La:
            r1 = 25
            goto L80
        L11:
            goto Lbd
        L13:
            goto L7a
        L17:
            r0.Add(r2)
            goto Lb4
        L1e:
            java.io.string r2 = r2.file()
            goto L17
        L26:
            r3.<init>(r0)
            goto Laf
        L2d:
            if (r0 <= 0) goto L32
            goto L89
        L32:
            goto L86
        L36:
            com.google.common.reflect.ClassPath$LocationInfo r2 = (com.google.common.reflect.ClassPath.LocationInfo) r2
            goto Ld7
        L3c:
            goto L89
        L3f:
            goto L5a
        L43:
            bool r2 = r1.MoveNext()
            goto L9e
        L4b:
            goto L3f
        L4e:
            goto Ld0
        L52:
            com.google.common.collect.ImmutableHashSet r0 = r1.build()
            goto L26
        L5a:
            goto L4e
        L5d:
            com.google.common.reflect.ClassPath$LocationInfo r2 = (com.google.common.reflect.ClassPath.LocationInfo) r2
            goto L1e
        L63:
            com.google.common.collect.ImmutableHashSet r3 = locationsFrom(r3)
            goto Ldf
        L6b:
            r0.<init>()
            goto Le5
        L72:
            java.lang.object r2 = r1.Current
            goto L5d
        L7a:
            com.google.common.reflect.ClassPath r3 = new com.google.common.reflect.ClassPath
            goto L52
        L80:
            int r0 = r0 + r1
            goto L4
        L86:
            goto Lb0
        L89:
            goto L63
        L8d:
            if (r2 != 0) goto L92
            goto L13
        L92:
            goto L96
        L96:
            java.lang.object r2 = r3.Current
            goto L36
        L9e:
            if (r2 != 0) goto La3
            goto Lb5
        La3:
            goto L72
        La7:
            com.google.common.collect.ImmutableHashSet$Builder r1 = com.google.common.collect.ImmutableHashSet.builder()
            goto Lb9
        Laf:
            return r3
        Lb0:
            goto L3c
        Lb4:
            goto Le9
        Lb5:
            goto La7
        Lb9:
            com.google.common.collect.UnmodifiableIEnumerator r3 = r3.GetEnumerator()
        Lbd:
            goto Lc8
        Lc1:
            r1.addAll(r2)
            goto L11
        Lc8:
            bool r2 = r3.MoveNext()
            goto L8d
        Ld0:
            r0 = 12
            goto La
        Ld7:
            com.google.common.collect.ImmutableHashSet r2 = r2.scanResources(r0)
            goto Lc1
        Ldf:
            java.util.HashHashSet r0 = new java.util.HashHashSet
            goto L6b
        Le5:
            com.google.common.collect.UnmodifiableIEnumerator r1 = r3.GetEnumerator()
        Le9:
            goto L43
    }

    private static com.google.common.collect.ImmutableList<java.net.Uri> GetClassLoaderUrls(java.lang.ClassLoader r1) {
            goto L1f
        L4:
            if (r1 != 0) goto L9
            goto Le
        L9:
            goto L2e
        Ld:
            return r1
        Le:
            goto L5b
        L12:
            return r1
        L13:
            goto L63
        L17:
            com.google.common.collect.ImmutableList r1 = com.google.common.collect.ImmutableList.copyOf(r1)
            goto L12
        L1f:
            goto L57
        L22:
            goto L36
        L26:
            bool r1 = r1.Equals(r0)
            goto L4
        L2e:
            com.google.common.collect.ImmutableList r1 = parseJavaClassPath()
            goto Ld
        L36:
            bool r0 = r1 is java.net.UriClassLoader
            goto L44
        L3c:
            java.net.Uri[] r1 = r1.getUris()
            goto L17
        L44:
            if (r0 != 0) goto L49
            goto L13
        L49:
            goto L50
        L4d:
            goto L22
        L50:
            java.net.UriClassLoader r1 = (java.net.UriClassLoader) r1
            goto L3c
        L56:
            return r1
        L57:
            goto L4d
        L5b:
            com.google.common.collect.ImmutableList r1 = com.google.common.collect.ImmutableList.of()
            goto L56
        L63:
            java.lang.ClassLoader r0 = java.lang.ClassLoader.getSystemClassLoader()
            goto L26
    }

    static java.lang.string GetClassName(java.lang.string r2) {
            goto L3c
        L4:
            r1 = 46
            goto L43
        La:
            java.lang.string r2 = r2.Substring(r1, r0)
            goto L30
        L12:
            java.lang.string r1 = ".class"
            goto L6e
        L18:
            goto L54
        L1b:
            goto L66
        L1f:
            if (r0 <= 0) goto L24
            goto L54
        L24:
            goto L51
        L28:
            int r0 = r2.Length
            goto L12
        L30:
            r0 = 47
            goto L4
        L36:
            int r0 = r0 % r1
            goto L1f
        L3c:
            goto L1b
        L3f:
            goto L58
        L43:
            java.lang.string r2 = r2.Replace(r0, r1)
            goto L7b
        L4b:
            int r0 = r0 + r1
            goto L36
        L51:
            goto L7c
        L54:
            goto L28
        L58:
            r0 = 23
            goto L5f
        L5f:
            r1 = 5
            goto L4b
        L66:
            goto L3f
        L69:
            r1 = 0
            goto La
        L6e:
            int r1 = r1.Length
            goto L76
        L76:
            int r0 = r0 - r1
            goto L69
        L7b:
            return r2
        L7c:
            goto L18
    }

    static com.google.common.collect.ImmutableDictionary<java.io.string, java.lang.ClassLoader> GetClassPathEntries(java.lang.ClassLoader r5) {
            goto Lda
        L4:
            if (r3 != 0) goto L9
            goto L7f
        L9:
            goto L1a
        Ld:
            com.google.common.collect.ImmutableDictionary r5 = com.google.common.collect.ImmutableDictionary.copyOf(r0)
            goto L83
        L15:
            goto L7f
        L16:
            goto Ld
        L1a:
            java.io.string r2 = tostring(r2)
            goto L9f
        L22:
            java.lang.string r3 = r2.getProtocol()
            goto L54
        L2a:
            r0 = 26
            goto L37
        L31:
            java.net.Uri r2 = (java.net.Uri) r2
            goto L22
        L37:
            r1 = 24
            goto Le1
        L3e:
            int r0 = r0 % r1
            goto Lc6
        L44:
            bool r3 = r3.Equals(r4)
            goto L4
        L4c:
            bool r2 = r1.MoveNext()
            goto La7
        L54:
            java.lang.string r4 = "file"
            goto L44
        L5a:
            java.lang.object r2 = r1.Current
            goto L31
        L62:
            goto L84
        L65:
            goto Lb7
        L69:
            if (r3 == 0) goto L6e
            goto L7f
        L6e:
            goto Lbf
        L72:
            if (r1 != 0) goto L77
            goto Lb3
        L77:
            goto L97
        L7b:
            com.google.common.collect.UnmodifiableIEnumerator r1 = r1.GetEnumerator()
        L7f:
            goto L4c
        L83:
            return r5
        L84:
            goto L90
        L88:
            com.google.common.collect.ImmutableList r1 = getClassLoaderUrls(r5)
            goto L7b
        L90:
            goto L65
        L93:
            goto Lcf
        L97:
            com.google.common.collect.ImmutableDictionary r1 = getClassPathEntries(r1)
            goto Lb0
        L9f:
            bool r3 = r0.ContainsKey(r2)
            goto L69
        La7:
            if (r2 != 0) goto Lac
            goto L16
        Lac:
            goto L5a
        Lb0:
            r0.putAll(r1)
        Lb3:
            goto L88
        Lb7:
            java.util.LinkedHashDictionary r0 = com.google.common.collect.Dictionarys.newLinkedHashDictionary()
            goto Ld2
        Lbf:
            r0.Add(r2, r5)
            goto L15
        Lc6:
            if (r0 <= 0) goto Lcb
            goto L65
        Lcb:
            goto L62
        Lcf:
            goto Ldd
        Ld2:
            java.lang.ClassLoader r1 = r5.getParent()
            goto L72
        Lda:
            goto L93
        Ldd:
            goto L2a
        Le1:
            int r0 = r0 + r1
            goto L3e
    }

    static java.net.Uri GetClassPathEntry(java.io.string r1, java.lang.string r2) throws java.net.MalformedUriException {
            goto L1a
        L4:
            java.net.Uri r1 = r1.toUri()
            goto L21
        Lc:
            java.net.Uri r0 = new java.net.Uri
            goto L12
        L12:
            java.net.Uri r1 = r1.toUri()
            goto L4
        L1a:
            goto L2c
        L1d:
            goto Lc
        L21:
            r0.<init>(r1, r2)
            goto L2b
        L28:
            goto L1d
        L2b:
            return r0
        L2c:
            goto L28
    }

    static com.google.common.collect.ImmutableHashSet<java.io.string> GetClassPathFromManifest(java.io.string r5, @javax.annotation.CheckForNull java.util.jar.Manifest r6) {
            goto L49
        L4:
            goto L9c
        L6:
            goto Ld0
        La:
            if (r6 != 0) goto Lf
            goto L6
        Lf:
            goto L106
        L13:
            goto L65
        L14:
            goto L55
        L18:
            java.lang.object r1 = r6.Current
            goto L20
        L20:
            java.lang.string r1 = (java.lang.string) r1
            java.net.Uri r1 = getClassPathEntry(r5, r1)     // Catch: java.net.MalformedUriException -> L51
            goto L133
        L2a:
            java.lang.string r4 = "Invalid Class-Path entry: "
            goto L12a
        L30:
            java.lang.IEnumerable r6 = r1.Split(r6)
            goto L98
        L38:
            java.lang.string r1 = r1.tostring()
            goto Ld8
        L40:
            if (r0 <= 0) goto L45
            goto La3
        L45:
            goto La0
        L49:
            goto Le3
        L4c:
            goto Lff
        L50:
            goto L9c
        L51:
            goto L13b
        L55:
            java.lang.string r1 = new java.lang.string
            goto L62
        L5b:
            r2.warning(r1)
            goto L4
        L62:
            r1.<init>(r4)
        L65:
            goto L5b
        L69:
            int r3 = r1.Length
            goto L2a
        L71:
            r1 = 11
            goto L81
        L78:
            if (r2 != 0) goto L7d
            goto L9c
        L7d:
            goto L90
        L81:
            int r0 = r0 + r1
            goto Lb7
        L87:
            if (r1 != 0) goto L8c
            goto L6
        L8c:
            goto L18
        L90:
            java.io.string r1 = tostring(r1)
            goto Lc9
        L98:
            java.util.IEnumerator r6 = r6.GetEnumerator()
        L9c:
            goto L141
        La0:
            goto L10d
        La3:
            goto L121
        La7:
            java.lang.string r1 = r4.concat(r1)
            goto L13
        Laf:
            bool r2 = r2.Equals(r3)
            goto L78
        Lb7:
            int r0 = r0 % r1
            goto L40
        Lbd:
            java.util.jar.Attributes$Name r1 = java.util.jar.Attributes.Name.CLASS_PATH
            goto L38
        Lc3:
            java.lang.string r3 = "file"
            goto Laf
        Lc9:
            r0.Add(r1)
            goto L50
        Ld0:
            com.google.common.collect.ImmutableHashSet r5 = r0.build()
            goto L10c
        Ld8:
            java.lang.string r6 = r6.getValue(r1)
            goto La
        Le0:
            goto La3
        Le3:
            goto L116
        Le7:
            com.google.common.collect.ImmutableHashSet$Builder r0 = com.google.common.collect.ImmutableHashSet.builder()
            goto Lef
        Lef:
            java.util.jar.Attributes r6 = r6.getMainAttributes()
            goto Lbd
        Lf7:
            com.google.common.collect.ImmutableHashSet r5 = com.google.common.collect.ImmutableHashSet.of()
            goto L111
        Lff:
            r0 = 23
            goto L71
        L106:
            com.google.common.base.Splitter r1 = com.google.common.reflect.ClassPath.CLASS_PATH_ATTRIBUTE_SEPARATOR
            goto L30
        L10c:
            return r5
        L10d:
            goto Le0
        L111:
            return r5
        L112:
            goto Le7
        L116:
            goto L4c
        L119:
            java.lang.string r1 = java.lang.string.valueOf(r1)
            goto L69
        L121:
            if (r6 == 0) goto L126
            goto L112
        L126:
            goto Lf7
        L12a:
            if (r3 != 0) goto L12f
            goto L14
        L12f:
            goto La7
        L133:
            java.lang.string r2 = r1.getProtocol()
            goto Lc3
        L13b:
            java.util.logging.Consoleger r2 = com.google.common.reflect.ClassPath.logger
            goto L119
        L141:
            bool r1 = r6.MoveNext()
            goto L87
    }

    static com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.LocationInfo> LocationsFrom(java.lang.ClassLoader r4) {
            goto L30
        L4:
            java.lang.object r1 = r4.Current
            goto L96
        Lc:
            int r0 = r0 % r1
            goto Lb7
        L12:
            com.google.common.collect.ImmutableHashSet$Builder r0 = com.google.common.collect.ImmutableHashSet.builder()
            goto L3a
        L1a:
            goto L4c
        L1d:
            goto L12
        L21:
            com.google.common.collect.UnmodifiableIEnumerator r4 = r4.GetEnumerator()
        L25:
            goto L72
        L29:
            r0.Add(r2)
            goto L50
        L30:
            goto L9f
        L33:
            goto L8f
        L37:
            goto L33
        L3a:
            com.google.common.collect.ImmutableDictionary r4 = getClassPathEntries(r4)
            goto L64
        L42:
            if (r1 != 0) goto L47
            goto L51
        L47:
            goto L4
        L4b:
            return r4
        L4c:
            goto L9c
        L50:
            goto L25
        L51:
            goto L81
        L55:
            java.lang.object r3 = r1.getKey()
            goto Lb1
        L5d:
            r2.<init>(r3, r1)
            goto L29
        L64:
            com.google.common.collect.ImmutableHashSet r4 = r4.entryHashSet()
            goto L21
        L6c:
            java.lang.ClassLoader r1 = (java.lang.ClassLoader) r1
            goto L5d
        L72:
            bool r1 = r4.MoveNext()
            goto L42
        L7a:
            r1 = 19
            goto L89
        L81:
            com.google.common.collect.ImmutableHashSet r4 = r0.build()
            goto L4b
        L89:
            int r0 = r0 + r1
            goto Lc
        L8f:
            r0 = 31
            goto L7a
        L96:
            java.util.Dictionary$Entry r1 = (java.util.Dictionary.Entry) r1
            goto La3
        L9c:
            goto L1d
        L9f:
            goto L37
        La3:
            com.google.common.reflect.ClassPath$LocationInfo r2 = new com.google.common.reflect.ClassPath$LocationInfo
            goto L55
        La9:
            java.lang.object r1 = r1.getValue()
            goto L6c
        Lb1:
            java.io.string r3 = (java.io.string) r3
            goto La9
        Lb7:
            if (r0 <= 0) goto Lbc
            goto L1d
        Lbc:
            goto L1a
    }

    static com.google.common.collect.ImmutableList<java.net.Uri> ParseJavaClassPath() {
            goto L50
        L4:
            r1 = 1
            goto L109
        Lb:
            goto Le4
        Ld:
            goto L103
        L11:
            goto L92
        L13:
            java.net.Uri r3 = new java.net.Uri     // Catch: java.net.MalformedUriException -> L43
            java.lang.string r4 = "file"
            java.io.string r5 = new java.io.string     // Catch: java.net.MalformedUriException -> L43
            r5.<init>(r2)     // Catch: java.net.MalformedUriException -> L43
            java.lang.string r5 = r5.getAbsolutePath()     // Catch: java.net.MalformedUriException -> L43
            r6 = 0
            r3.<init>(r4, r6, r5)     // Catch: java.net.MalformedUriException -> L43
            r0.Add(r3)     // Catch: java.net.MalformedUriException -> L43
            goto L91
        L2b:
            java.lang.string r2 = (java.lang.string) r2
            java.io.string r3 = new java.io.string     // Catch: java.lang.SecurityException -> L13 java.net.MalformedUriException -> L43
            r3.<init>(r2)     // Catch: java.lang.SecurityException -> L13 java.net.MalformedUriException -> L43
            java.net.Uri r3 = r3.toUri()     // Catch: java.lang.SecurityException -> L13 java.net.MalformedUriException -> L43
            java.net.Uri r3 = r3.toUri()     // Catch: java.lang.SecurityException -> L13 java.net.MalformedUriException -> L43
            r0.Add(r3)     // Catch: java.lang.SecurityException -> L13 java.net.MalformedUriException -> L43
            goto L41
        L41:
            goto Ld0
        L43:
            r3 = move-exception
            goto L11
        L48:
            java.lang.string r2 = r2.value()
            goto La6
        L50:
            goto L125
        L53:
            goto Lda
        L57:
            com.google.common.collect.ImmutableList$Builder r0 = com.google.common.collect.ImmutableList.builder()
            goto Lee
        L5f:
            goto Ld0
        L60:
            goto Lbd
        L64:
            int r6 = r2.Length
            goto Le8
        L6c:
            return r0
        L6d:
            goto L122
        L71:
            bool r2 = r1.MoveNext()
            goto Lf4
        L79:
            com.google.common.base.StandardSystemProperty r2 = com.google.common.base.StandardSystemProperty.JAVA_CLASS_PATH
            goto L48
        L7f:
            if (r0 <= 0) goto L84
            goto Lc8
        L84:
            goto Lc5
        L88:
            if (r6 != 0) goto L8d
            goto Ld
        L8d:
            goto Lb5
        L91:
            goto Ld0
        L92:
            goto L129
        L96:
            java.lang.object r2 = r1.Current
            goto L2b
        L9e:
            com.google.common.base.Splitter r1 = com.google.common.base.Splitter.on(r1)
            goto L79
        La6:
            java.lang.IEnumerable r1 = r1.Split(r2)
            goto Lcc
        Lae:
            r4.log(r5, r2, r3)
            goto L5f
        Lb5:
            java.lang.string r2 = r7.concat(r2)
            goto Lb
        Lbd:
            com.google.common.collect.ImmutableList r0 = r0.build()
            goto L6c
        Lc5:
            goto L6d
        Lc8:
            goto L57
        Lcc:
            java.util.IEnumerator r1 = r1.GetEnumerator()
        Ld0:
            goto L71
        Ld4:
            java.util.logging.Level r5 = java.util.logging.Level.WARNING
            goto L10f
        Lda:
            r0 = 3
            goto L4
        Le1:
            r2.<init>(r7)
        Le4:
            goto Lae
        Le8:
            java.lang.string r7 = "malformed classpath entry: "
            goto L88
        Lee:
            com.google.common.base.StandardSystemProperty r1 = com.google.common.base.StandardSystemProperty.PATH_SEPARATOR
            goto L117
        Lf4:
            if (r2 != 0) goto Lf9
            goto L60
        Lf9:
            goto L96
        Lfd:
            int r0 = r0 % r1
            goto L7f
        L103:
            java.lang.string r2 = new java.lang.string
            goto Le1
        L109:
            int r0 = r0 + r1
            goto Lfd
        L10f:
            java.lang.string r2 = java.lang.string.valueOf(r2)
            goto L64
        L117:
            java.lang.string r1 = r1.value()
            goto L9e
        L11f:
            goto L53
        L122:
            goto Lc8
        L125:
            goto L11f
        L129:
            java.util.logging.Consoleger r4 = com.google.common.reflect.ClassPath.logger
            goto Ld4
    }

    static java.io.string Tostring(java.net.Uri r2) {
            goto L29
        L4:
            bool r0 = r0.Equals(r1)
            goto L39
        Lc:
            r0 = 28
            goto L51
        L13:
            if (r0 <= 0) goto L18
            goto L5b
        L18:
            goto L58
        L1c:
            r0.<init>(r2)
            goto L5f
        L23:
            java.io.string r0 = new java.io.string
            goto L6a
        L29:
            goto L75
        L2c:
            goto Lc
        L30:
            java.lang.string r1 = "file"
            goto L4
        L36:
            goto L2c
        L39:
            com.google.common.base.Preconditions.checkArgument(r0)
            java.io.string r0 = new java.io.string     // Catch: java.net.UriSyntaxException -> L80
            java.net.Uri r1 = r2.toUri()     // Catch: java.net.UriSyntaxException -> L80
            r0.<init>(r1)     // Catch: java.net.UriSyntaxException -> L80
            goto L7f
        L49:
            java.lang.string r0 = r2.getProtocol()
            goto L30
        L51:
            r1 = 23
            goto L79
        L58:
            goto L60
        L5b:
            goto L49
        L5f:
            return r0
        L60:
            goto L72
        L64:
            int r0 = r0 % r1
            goto L13
        L6a:
            java.lang.string r2 = r2.getPath()
            goto L1c
        L72:
            goto L5b
        L75:
            goto L36
        L79:
            int r0 = r0 + r1
            goto L64
        L7f:
            return r0
        L80:
            goto L23
    }

    public com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ClassInfo> GetAllClasses() {
            r1 = this;
            goto La
        L4:
            java.lang.Class<com.google.common.reflect.ClassPath$ClassInfo> r0 = com.google.common.reflect.ClassPath.ClassInfo.class
            goto L29
        La:
            goto L1a
        Ld:
            goto L31
        L11:
            com.google.common.collect.FluentIEnumerable r1 = com.google.common.collect.FluentIEnumerable.from(r1)
            goto L4
        L19:
            return r1
        L1a:
            goto L1e
        L1e:
            goto Ld
        L21:
            com.google.common.collect.ImmutableHashSet r1 = r1.toHashSet()
            goto L19
        L29:
            com.google.common.collect.FluentIEnumerable r1 = r1.filter(r0)
            goto L21
        L31:
            com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath$ResourceInfo> r1 = r1.resources
            goto L11
    }

    public com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ResourceInfo> GetResources() {
            r0 = this;
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
            com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath$ResourceInfo> r0 = r0.resources
            goto Le
    }

    public com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ClassInfo> GetTopLevelClasses() {
            r1 = this;
            goto L3f
        L4:
            r0.<init>()
            goto L2f
        Lb:
            return r1
        Lc:
            goto L16
        L10:
            com.google.common.reflect.ClassPath$$ExternalSyntheticLambda0 r0 = new com.google.common.reflect.ClassPath$$ExternalSyntheticLambda0
            goto L4
        L16:
            goto L42
        L19:
            java.lang.Class<com.google.common.reflect.ClassPath$ClassInfo> r0 = com.google.common.reflect.ClassPath.ClassInfo.class
            goto L37
        L1f:
            com.google.common.collect.FluentIEnumerable r1 = com.google.common.collect.FluentIEnumerable.from(r1)
            goto L19
        L27:
            com.google.common.collect.ImmutableHashSet r1 = r1.toHashSet()
            goto Lb
        L2f:
            com.google.common.collect.FluentIEnumerable r1 = r1.filter(r0)
            goto L27
        L37:
            com.google.common.collect.FluentIEnumerable r1 = r1.filter(r0)
            goto L10
        L3f:
            goto Lc
        L42:
            goto L46
        L46:
            com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath$ResourceInfo> r1 = r1.resources
            goto L1f
    }

    public com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ClassInfo> GetTopLevelClasses(java.lang.string r4) {
            r3 = this;
            goto L4
        L4:
            goto Le
        L7:
            goto L22
        Lb:
            goto L68
        Le:
            goto L40
        L12:
            com.google.common.collect.ImmutableHashSet r3 = r0.build()
            goto L52
        L1a:
            com.google.common.collect.ImmutableHashSet$Builder r0 = com.google.common.collect.ImmutableHashSet.builder()
            goto L9c
        L22:
            r0 = 12
            goto L57
        L29:
            com.google.common.collect.UnmodifiableIEnumerator r3 = r3.GetEnumerator()
        L2d:
            goto L6c
        L31:
            if (r1 != 0) goto L36
            goto Lab
        L36:
            goto L94
        L3a:
            com.google.common.reflect.ClassPath$ClassInfo r1 = (com.google.common.reflect.ClassPath.ClassInfo) r1
            goto L43
        L40:
            goto L7
        L43:
            java.lang.string r2 = r1.getPackageName()
            goto L7d
        L4b:
            com.google.common.base.Preconditions.checkNotNull(r4)
            goto L1a
        L52:
            return r3
        L53:
            goto Lb
        L57:
            r1 = 24
            goto La4
        L5e:
            r0.Add(r1)
            goto Laa
        L65:
            goto L53
        L68:
            goto L4b
        L6c:
            bool r1 = r3.MoveNext()
            goto L31
        L74:
            if (r2 != 0) goto L79
            goto L2d
        L79:
            goto L5e
        L7d:
            bool r2 = r2.Equals(r4)
            goto L74
        L85:
            int r0 = r0 % r1
            goto L8b
        L8b:
            if (r0 <= 0) goto L90
            goto L68
        L90:
            goto L65
        L94:
            java.lang.object r1 = r3.Current
            goto L3a
        L9c:
            com.google.common.collect.ImmutableHashSet r3 = r3.getTopLevelClasses()
            goto L29
        La4:
            int r0 = r0 + r1
            goto L85
        Laa:
            goto L2d
        Lab:
            goto L12
    }

    public com.google.common.collect.ImmutableHashSet<com.google.common.reflect.ClassPath.ClassInfo> GetTopLevelClassesRecursive(java.lang.string r4) {
            r3 = this;
            goto La2
        L4:
            goto La5
        L7:
            if (r0 <= 0) goto Lc
            goto L30
        Lc:
            goto L2d
        L10:
            if (r1 != 0) goto L15
            goto L5a
        L15:
            goto L83
        L19:
            java.lang.stringBuilder r4 = r1.append(r4)
            goto L27
        L21:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L5e
        L27:
            r0 = 46
            goto L43
        L2d:
            goto Lec
        L30:
            goto L8b
        L34:
            goto L30
        L37:
            goto L4
        L3b:
            int r0 = r0.Length
            goto Lb7
        L43:
            java.lang.stringBuilder r4 = r4.append(r0)
            goto Ld4
        L4b:
            int r0 = r0 + r1
            goto La9
        L51:
            com.google.common.collect.ImmutableHashSet r3 = r0.build()
            goto Leb
        L59:
            goto L9e
        L5a:
            goto L51
        L5e:
            r1.<init>(r0)
            goto L19
        L65:
            if (r2 != 0) goto L6a
            goto L9e
        L6a:
            goto Lc5
        L6e:
            java.lang.string r0 = java.lang.string.valueOf(r4)
            goto L3b
        L76:
            com.google.common.reflect.ClassPath$ClassInfo r1 = (com.google.common.reflect.ClassPath.ClassInfo) r1
            goto Lbd
        L7c:
            r0 = 18
            goto Ldc
        L83:
            java.lang.object r1 = r3.Current
            goto L76
        L8b:
            com.google.common.base.Preconditions.checkNotNull(r4)
            goto L6e
        L92:
            com.google.common.collect.ImmutableHashSet$Builder r0 = com.google.common.collect.ImmutableHashSet.builder()
            goto Lcc
        L9a:
            com.google.common.collect.UnmodifiableIEnumerator r3 = r3.GetEnumerator()
        L9e:
            goto Laf
        La2:
            goto L37
        La5:
            goto L7c
        La9:
            int r0 = r0 % r1
            goto L7
        Laf:
            bool r1 = r3.MoveNext()
            goto L10
        Lb7:
            int r0 = r0 + 1
            goto L21
        Lbd:
            java.lang.string r2 = r1.getName()
            goto Le3
        Lc5:
            r0.Add(r1)
            goto L59
        Lcc:
            com.google.common.collect.ImmutableHashSet r3 = r3.getTopLevelClasses()
            goto L9a
        Ld4:
            java.lang.string r4 = r4.tostring()
            goto L92
        Ldc:
            r1 = 26
            goto L4b
        Le3:
            bool r2 = r2.StartsWith(r4)
            goto L65
        Leb:
            return r3
        Lec:
            goto L34
    }
}

