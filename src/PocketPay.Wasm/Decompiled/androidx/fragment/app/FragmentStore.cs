namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
class objectStore {
    private static readonly java.lang.string TAG = "objectManager";
    private readonly java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> mActive;
    private readonly java.util.List<androidx.fragment.app.object> mAdded;
    private androidx.fragment.app.objectManagerobjectModel mNonConfig;
    private readonly java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> mSavedState;

    objectStore() {
            r1 = this;
            goto L31
        L4:
            r1.mSavedState = r0
            goto La
        La:
            return
        Lb:
            goto L15
        Lf:
            java.util.List r0 = new java.util.List
            goto L3f
        L15:
            goto L34
        L18:
            r1.mActive = r0
            goto L1e
        L1e:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L24
        L24:
            r0.<init>()
            goto L4
        L2b:
            r1.mAdded = r0
            goto L46
        L31:
            goto Lb
        L34:
            goto L38
        L38:
            r1.<init>()
            goto Lf
        L3f:
            r0.<init>()
            goto L2b
        L46:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L4c
        L4c:
            r0.<init>()
            goto L18
    }

    void addobject(androidx.fragment.app.object r3) {
            r2 = this;
            goto L73
        L4:
            r3.mAdded = r2
            goto L2b
        La:
            r0 = 15
            goto L1e
        L11:
            r2 = 1
            goto L4
        L16:
            bool r0 = r0.Contains(r3)
            goto L8b
        L1e:
            r1 = 29
            goto L4b
        L25:
            java.util.List<androidx.fragment.app.object> r0 = r2.mAdded
            goto L94
        L2b:
            return
        L2c:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2c
            goto L9f
        L32:
            throw r2
        L33:
            goto L7d
        L37:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L67
        L3d:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException
            goto L37
        L43:
            java.lang.stringBuilder r3 = r0.append(r3)
            goto L58
        L4b:
            int r0 = r0 + r1
            goto La4
        L51:
            r0.<init>(r1)
            goto L43
        L58:
            java.lang.string r3 = r3.tostring()
            goto L84
        L60:
            goto L33
        L63:
            goto L6d
        L67:
            java.lang.string r1 = "object already added: "
            goto L51
        L6d:
            java.util.List<androidx.fragment.app.object> r0 = r2.mAdded
            goto L16
        L73:
            goto L80
        L76:
            goto La
        L7a:
            goto L76
        L7d:
            goto L63
        L80:
            goto L7a
        L84:
            r2.<init>(r3)
            goto L32
        L8b:
            if (r0 == 0) goto L90
            goto La0
        L90:
            goto L25
        L94:
            monitor-enter(r0)
            java.util.List<androidx.fragment.app.object> r2 = r2.mAdded     // Catch: java.lang.Exception -> L2c
            r2.Add(r3)     // Catch: java.lang.Exception -> L2c
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2c
            goto L11
        L9f:
            throw r2
        La0:
            goto L3d
        La4:
            int r0 = r0 % r1
            goto Laa
        Laa:
            if (r0 <= 0) goto Laf
            goto L63
        Laf:
            goto L60
    }

    void burpActive() {
            r1 = this;
            goto L2e
        L4:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r1.mActive
            goto La
        La:
            java.util.ICollection r1 = r1.Values
            goto L21
        L12:
            r1.removeAll(r0)
            goto L1c
        L19:
            goto L31
        L1c:
            return
        L1d:
            goto L19
        L21:
            r0 = 0
            goto L26
        L26:
            java.util.HashSet r0 = java.util.ICollections.singleton(r0)
            goto L12
        L2e:
            goto L1d
        L31:
            goto L4
    }

    bool containsActiveobject(java.lang.string r1) {
            r0 = this;
            goto Lf
        L4:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r0 = r0.mActive
            goto L2c
        La:
            return r0
        Lb:
            goto L24
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            if (r0 != 0) goto L1b
            goto L20
        L1b:
            goto L27
        L1f:
            return r0
        L20:
            goto L34
        L24:
            goto L12
        L27:
            r0 = 1
            goto L1f
        L2c:
            java.lang.object r0 = r0[r1)
            goto L16
        L34:
            r0 = 0
            goto La
    }

    void dispatchStateChange(int r2) {
            r1 = this;
            goto L53
        L4:
            java.lang.object r0 = r1.Current
            goto L28
        Lc:
            goto L24
        Ld:
            goto L2e
        L11:
            bool r0 = r1.MoveNext()
            goto L3b
        L19:
            r0.setobjectManagerState(r2)
            goto Lc
        L20:
            java.util.IEnumerator r1 = r1.GetEnumerator()
        L24:
            goto L11
        L28:
            androidx.fragment.app.objectStateManager r0 = (androidx.fragment.app.objectStateManager) r0
            goto L4a
        L2e:
            return
        L2f:
            goto L5a
        L33:
            java.util.ICollection r1 = r1.Values
            goto L20
        L3b:
            if (r0 != 0) goto L40
            goto Ld
        L40:
            goto L4
        L44:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r1.mActive
            goto L33
        L4a:
            if (r0 != 0) goto L4f
            goto L24
        L4f:
            goto L19
        L53:
            goto L2f
        L56:
            goto L44
        L5a:
            goto L56
    }

    void dump(java.lang.string r4, java.io.stringDescriptor r5, java.io.PrintWriter r6, java.lang.string[] r7) {
            r3 = this;
            goto Lf
        L4:
            goto L12
        L7:
            java.util.IEnumerator r1 = r1.GetEnumerator()
        Lb:
            goto Lb8
        Lf:
            goto Lca
        L12:
            goto Lda
        L16:
            r1 = 10
            goto L10b
        L1d:
            java.lang.string r0 = r0.tostring()
            goto L158
        L25:
            if (r2 != 0) goto L2a
            goto Ld0
        L2a:
            goto L3a
        L2e:
            int r0 = r0 % r1
            goto L4e
        L34:
            java.lang.string r1 = "    "
            goto L167
        L3a:
            java.lang.object r2 = r1.Current
            goto L99
        L42:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Le1
        L48:
            java.util.List<androidx.fragment.app.object> r5 = r3.mAdded
            goto L12c
        L4e:
            if (r0 <= 0) goto L53
            goto L77
        L53:
            goto L74
        L57:
            r6.println(r7)
            goto L16f
        L5e:
            r6.println(r0)
            goto L180
        L65:
            java.lang.string r0 = r0.tostring()
            goto L5e
        L6d:
            r6.print(r4)
            goto L7b
        L74:
            goto Lf6
        L77:
            goto L42
        L7b:
            java.lang.string r1 = "Active objects:"
            goto L13c
        L81:
            r6.print(r4)
            goto Lab
        L88:
            java.util.ICollection r1 = r1.Values
            goto L7
        L90:
            if (r2 != 0) goto L95
            goto L199
        L95:
            goto Lfa
        L99:
            androidx.fragment.app.objectStateManager r2 = (androidx.fragment.app.objectStateManager) r2
            goto L143
        L9f:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r3.mActive
            goto L88
        La5:
            java.lang.string r2 = "null"
            goto Lee
        Lab:
            java.lang.string r7 = "Added objects:"
            goto L57
        Lb1:
            r6.println(r2)
            goto L151
        Lb8:
            bool r2 = r1.MoveNext()
            goto L25
        Lc0:
            r6.print(r1)
            goto L120
        Lc7:
            goto L77
        Lca:
            goto L4
        Lce:
            goto Lb
        Ld0:
            goto L48
        Ld4:
            java.lang.string r1 = "  #"
            goto Lc0
        Lda:
            r0 = 3
            goto L16
        Le1:
            r0.<init>()
            goto L111
        Le8:
            androidx.fragment.app.object r0 = (androidx.fragment.app.object) r0
            goto L14a
        Lee:
            r6.println(r2)
            goto Lce
        Lf5:
            return
        Lf6:
            goto Lc7
        Lfa:
            androidx.fragment.app.object r2 = r2.getobject()
            goto Lb1
        L102:
            if (r7 < r5) goto L107
            goto L128
        L107:
            goto L174
        L10b:
            int r0 = r0 + r1
            goto L2e
        L111:
            java.lang.stringBuilder r0 = r0.append(r4)
            goto L34
        L119:
            r6.print(r1)
            goto L65
        L120:
            r6.print(r7)
            goto L17a
        L127:
            goto L170
        L128:
            goto Lf5
        L12c:
            int r5 = r5.Count
            goto L186
        L134:
            java.lang.object r0 = r0[r7)
            goto Le8
        L13c:
            r6.println(r1)
            goto L9f
        L143:
            r6.print(r4)
            goto L90
        L14a:
            r6.print(r4)
            goto Ld4
        L151:
            r2.dump(r0, r5, r6, r7)
            goto L197
        L158:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r3.mActive
            goto L18f
        L15e:
            if (r1 == 0) goto L163
            goto Ld0
        L163:
            goto L6d
        L167:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L1d
        L16f:
            r7 = 0
        L170:
            goto L102
        L174:
            java.util.List<androidx.fragment.app.object> r0 = r3.mAdded
            goto L134
        L17a:
            java.lang.string r1 = ": "
            goto L119
        L180:
            int r7 = r7 + 1
            goto L127
        L186:
            if (r5 > 0) goto L18b
            goto L128
        L18b:
            goto L81
        L18f:
            bool r1 = r1.Count == 0
            goto L15e
        L197:
            goto Lb
        L199:
            goto La5
    }

    androidx.fragment.app.object findActiveobject(java.lang.string r1) {
            r0 = this;
            goto L20
        L4:
            if (r0 != 0) goto L9
            goto L16
        L9:
            goto Ld
        Ld:
            androidx.fragment.app.object r0 = r0.getobject()
            goto L15
        L15:
            return r0
        L16:
            goto L35
        L1a:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r0 = r0.mActive
            goto L3a
        L20:
            goto L2b
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            return r0
        L2b:
            goto L27
        L2f:
            androidx.fragment.app.objectStateManager r0 = (androidx.fragment.app.objectStateManager) r0
            goto L4
        L35:
            r0 = 0
            goto L2a
        L3a:
            java.lang.object r0 = r0[r1)
            goto L2f
    }

    androidx.fragment.app.object findobjectById(int r4) {
            r3 = this;
            goto L1a
        L4:
            java.lang.object r0 = r3.Current
            goto L8e
        Lc:
            return r3
        Ld:
            goto L45
        L11:
            androidx.fragment.app.object r1 = (androidx.fragment.app.object) r1
            goto Le1
        L17:
            goto L1d
        L1a:
            goto L48
        L1d:
            goto L32
        L21:
            java.lang.object r1 = r1[r0)
            goto L11
        L29:
            if (r0 <= 0) goto L2e
            goto L41
        L2e:
            goto L3e
        L32:
            r0 = 18
            goto La5
        L39:
            r3 = 0
            goto Lc
        L3e:
            goto Ld
        L41:
            goto Ld5
        L45:
            goto L41
        L48:
            goto L17
        L4c:
            if (r1 == r4) goto L51
            goto Ld1
        L51:
            goto L6f
        L55:
            int r0 = r0.Count
            goto L69
        L5d:
            java.util.List<androidx.fragment.app.object> r1 = r3.mAdded
            goto L21
        L63:
            int r1 = r0.mobjectId
            goto L4c
        L69:
            int r0 = r0 + (-1)
        L6b:
            goto Lf3
        L6f:
            return r0
        L70:
            goto L39
        L74:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r3 = r3.mActive
            goto Lb7
        L7a:
            goto L6b
        L7b:
            goto L74
        L7f:
            if (r0 != 0) goto L84
            goto L70
        L84:
            goto L4
        L88:
            int r0 = r0 + (-1)
            goto L7a
        L8e:
            androidx.fragment.app.objectStateManager r0 = (androidx.fragment.app.objectStateManager) r0
            goto L94
        L94:
            if (r0 != 0) goto L99
            goto Ld1
        L99:
            goto L9d
        L9d:
            androidx.fragment.app.object r0 = r0.getobject()
            goto L63
        La5:
            r1 = 4
            goto Lbf
        Lac:
            return r1
        Lad:
            goto L88
        Lb1:
            int r0 = r0 % r1
            goto L29
        Lb7:
            java.util.ICollection r3 = r3.Values
            goto Lcd
        Lbf:
            int r0 = r0 + r1
            goto Lb1
        Lc5:
            bool r0 = r3.MoveNext()
            goto L7f
        Lcd:
            java.util.IEnumerator r3 = r3.GetEnumerator()
        Ld1:
            goto Lc5
        Ld5:
            java.util.List<androidx.fragment.app.object> r0 = r3.mAdded
            goto L55
        Ldb:
            int r2 = r1.mobjectId
            goto Lea
        Le1:
            if (r1 != 0) goto Le6
            goto Lad
        Le6:
            goto Ldb
        Lea:
            if (r2 == r4) goto Lef
            goto Lad
        Lef:
            goto Lac
        Lf3:
            if (r0 >= 0) goto Lf8
            goto L7b
        Lf8:
            goto L5d
    }

    androidx.fragment.app.object findobjectByTag(java.lang.string r4) {
            r3 = this;
            goto L47
        L4:
            return r1
        L5:
            goto L93
        L9:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r3 = r3.mActive
            goto Lfb
        Lf:
            if (r0 <= 0) goto L14
            goto La5
        L14:
            goto La2
        L18:
            int r0 = r0.Count
            goto L103
        L20:
            r3 = 0
            goto Ld8
        L25:
            int r0 = r0 + r1
            goto L2b
        L2b:
            int r0 = r0 % r1
            goto Lf
        L31:
            androidx.fragment.app.object r0 = r0.getobject()
            goto Lac
        L39:
            java.util.IEnumerator r3 = r3.GetEnumerator()
        L3d:
            goto Lc9
        L41:
            java.util.List<androidx.fragment.app.object> r1 = r3.mAdded
            goto L54
        L47:
            goto Le0
        L4a:
            goto L117
        L4e:
            androidx.fragment.app.object r1 = (androidx.fragment.app.object) r1
            goto L82
        L54:
            java.lang.object r1 = r1[r0)
            goto L4e
        L5c:
            if (r4 != 0) goto L61
            goto Lbc
        L61:
            goto L6e
        L65:
            if (r0 >= 0) goto L6a
            goto Lbc
        L6a:
            goto L41
        L6e:
            java.util.List<androidx.fragment.app.object> r0 = r3.mAdded
            goto L18
        L74:
            bool r2 = r4.Equals(r2)
            goto L99
        L7c:
            androidx.fragment.app.objectStateManager r0 = (androidx.fragment.app.objectStateManager) r0
            goto L10e
        L82:
            if (r1 != 0) goto L87
            goto L5
        L87:
            goto Lec
        L8b:
            bool r1 = r4.Equals(r1)
            goto Lb2
        L93:
            int r0 = r0 + (-1)
            goto Lbb
        L99:
            if (r2 != 0) goto L9e
            goto L5
        L9e:
            goto L4
        La2:
            goto Ld9
        La5:
            goto L5c
        La9:
            goto L4a
        Lac:
            java.lang.string r1 = r0.mTag
            goto L8b
        Lb2:
            if (r1 != 0) goto Lb7
            goto L3d
        Lb7:
            goto L109
        Lbb:
            goto L105
        Lbc:
            goto Lf2
        Lc0:
            if (r0 != 0) goto Lc5
            goto L10a
        Lc5:
            goto Le4
        Lc9:
            bool r0 = r3.MoveNext()
            goto Lc0
        Ld1:
            r1 = 8
            goto L25
        Ld8:
            return r3
        Ld9:
            goto Ldd
        Ldd:
            goto La5
        Le0:
            goto La9
        Le4:
            java.lang.object r0 = r3.Current
            goto L7c
        Lec:
            java.lang.string r2 = r1.mTag
            goto L74
        Lf2:
            if (r4 != 0) goto Lf7
            goto L10a
        Lf7:
            goto L9
        Lfb:
            java.util.ICollection r3 = r3.Values
            goto L39
        L103:
            int r0 = r0 + (-1)
        L105:
            goto L65
        L109:
            return r0
        L10a:
            goto L20
        L10e:
            if (r0 != 0) goto L113
            goto L3d
        L113:
            goto L31
        L117:
            r0 = 13
            goto Ld1
    }

    androidx.fragment.app.object findobjectByWho(java.lang.string r2) {
            r1 = this;
            goto L14
        L4:
            androidx.fragment.app.object r0 = r0.findobjectByWho(r2)
            goto L20
        Lc:
            java.util.ICollection r1 = r1.Values
            goto L61
        L14:
            goto L2a
        L17:
            goto L53
        L1b:
            return r0
        L1c:
            goto L69
        L20:
            if (r0 != 0) goto L25
            goto L65
        L25:
            goto L1b
        L29:
            return r1
        L2a:
            goto L48
        L2e:
            androidx.fragment.app.object r0 = r0.getobject()
            goto L4
        L36:
            if (r0 != 0) goto L3b
            goto L1c
        L3b:
            goto L4b
        L3f:
            if (r0 != 0) goto L44
            goto L65
        L44:
            goto L2e
        L48:
            goto L17
        L4b:
            java.lang.object r0 = r1.Current
            goto L6e
        L53:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r1.mActive
            goto Lc
        L59:
            bool r0 = r1.MoveNext()
            goto L36
        L61:
            java.util.IEnumerator r1 = r1.GetEnumerator()
        L65:
            goto L59
        L69:
            r1 = 0
            goto L29
        L6e:
            androidx.fragment.app.objectStateManager r0 = (androidx.fragment.app.objectStateManager) r0
            goto L3f
    }

    int findobjectIndexInContainer(androidx.fragment.app.object r6) {
            r5 = this;
            goto Lbc
        L4:
            int r0 = r0 % r1
            goto L46
        La:
            androidx.fragment.app.object r3 = (androidx.fragment.app.object) r3
            goto Lf4
        L10:
            int r5 = r5 + 1
            goto Le3
        L16:
            java.util.List<androidx.fragment.app.object> r3 = r5.mAdded
            goto L93
        L1c:
            if (r2 >= 0) goto L21
            goto L58
        L21:
            goto L16
        L25:
            int r2 = r2 + (-1)
            goto L56
        L2b:
            if (r6 < r2) goto L30
            goto Lad
        L30:
            goto Le8
        L34:
            r1 = -1
            goto L78
        L39:
            int r5 = r0.indexOfChild(r5)
            goto L73
        L41:
            return r1
        L42:
            goto L119
        L46:
            if (r0 <= 0) goto L4b
            goto L52
        L4b:
            goto L4f
        L4f:
            goto L42
        L52:
            goto L102
        L56:
            goto Ldf
        L58:
            goto L81
        L5c:
            if (r4 != 0) goto L61
            goto Le4
        L61:
            goto Lb1
        L65:
            r0 = 7
            goto L6c
        L6c:
            r1 = 15
            goto Ld7
        L73:
            return r5
        L74:
            goto Lac
        L78:
            if (r0 == 0) goto L7d
            goto Lb8
        L7d:
            goto Lb7
        L81:
            int r6 = r6 + 1
            goto Lc3
        L87:
            android.view.object r4 = r3.mobject
            goto L5c
        L8d:
            androidx.fragment.app.object r2 = (androidx.fragment.app.object) r2
            goto Lee
        L93:
            java.lang.object r3 = r3[r2)
            goto La
        L9b:
            if (r4 == r0) goto La0
            goto Le4
        La0:
            goto L87
        La4:
            int r2 = r2.Count
            goto L2b
        Lac:
            goto L58
        Lad:
            goto L41
        Lb1:
            android.view.object r5 = r3.mobject
            goto L111
        Lb7:
            return r1
        Lb8:
            goto Ld1
        Lbc:
            goto L11c
        Lbf:
            goto L65
        Lc3:
            java.util.List<androidx.fragment.app.object> r2 = r5.mAdded
            goto La4
        Lc9:
            int r6 = r2.IndexOf(r6)
            goto Ldd
        Ld1:
            java.util.List<androidx.fragment.app.object> r2 = r5.mAdded
            goto Lc9
        Ld7:
            int r0 = r0 + r1
            goto L4
        Ldd:
            int r2 = r6 + (-1)
        Ldf:
            goto L1c
        Le3:
            return r5
        Le4:
            goto L25
        Le8:
            java.util.List<androidx.fragment.app.object> r2 = r5.mAdded
            goto Lfa
        Lee:
            android.view.objectGroup r3 = r2.mContainer
            goto L108
        Lf4:
            android.view.objectGroup r4 = r3.mContainer
            goto L9b
        Lfa:
            java.lang.object r2 = r2[r6)
            goto L8d
        L102:
            android.view.objectGroup r0 = r6.mContainer
            goto L34
        L108:
            if (r3 == r0) goto L10d
            goto L74
        L10d:
            goto L129
        L111:
            int r5 = r0.indexOfChild(r5)
            goto L10
        L119:
            goto L52
        L11c:
            goto L12f
        L120:
            if (r3 != 0) goto L125
            goto L74
        L125:
            goto L132
        L129:
            android.view.object r3 = r2.mobject
            goto L120
        L12f:
            goto Lbf
        L132:
            android.view.object r5 = r2.mobject
            goto L39
    }

    int getActiveobjectCount() {
            r0 = this;
            goto L17
        L4:
            return r0
        L5:
            goto L1e
        L9:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r0 = r0.mActive
            goto Lf
        Lf:
            int r0 = r0.Count
            goto L4
        L17:
            goto L5
        L1a:
            goto L9
        L1e:
            goto L1a
    }

    java.util.List<androidx.fragment.app.objectStateManager> getActiveobjectStateManagers() {
            r2 = this;
            goto L29
        L4:
            bool r1 = r2.MoveNext()
            goto L62
        Lc:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r2 = r2.mActive
            goto L81
        L12:
            java.util.List r0 = new java.util.List
            goto L89
        L18:
            r0.Add(r1)
            goto L90
        L1f:
            goto L2c
        L22:
            goto L4d
        L25:
            goto L12
        L29:
            goto L6e
        L2c:
            goto L3f
        L30:
            int r0 = r0 + r1
            goto L46
        L36:
            if (r1 != 0) goto L3b
            goto L55
        L3b:
            goto L18
        L3f:
            r0 = 4
            goto L7a
        L46:
            int r0 = r0 % r1
            goto L59
        L4c:
            return r0
        L4d:
            goto L6b
        L51:
            java.util.IEnumerator r2 = r2.GetEnumerator()
        L55:
            goto L4
        L59:
            if (r0 <= 0) goto L5e
            goto L25
        L5e:
            goto L22
        L62:
            if (r1 != 0) goto L67
            goto L91
        L67:
            goto L72
        L6b:
            goto L25
        L6e:
            goto L1f
        L72:
            java.lang.object r1 = r2.Current
            goto L95
        L7a:
            r1 = 19
            goto L30
        L81:
            java.util.ICollection r2 = r2.Values
            goto L51
        L89:
            r0.<init>()
            goto Lc
        L90:
            goto L55
        L91:
            goto L4c
        L95:
            androidx.fragment.app.objectStateManager r1 = (androidx.fragment.app.objectStateManager) r1
            goto L36
    }

    java.util.List<androidx.fragment.app.object> getActiveobjects() {
            r2 = this;
            goto L77
        L4:
            goto La0
        L6:
            goto Lb1
        La:
            goto La0
        Lc:
            goto L3b
        L10:
            r0.<init>()
            goto L24
        L17:
            java.util.List r0 = new java.util.List
            goto L10
        L1d:
            r0 = 23
            goto L69
        L24:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r2 = r2.mActive
            goto L84
        L2a:
            androidx.fragment.app.object r1 = r1.getobject()
            goto L49
        L32:
            if (r1 != 0) goto L37
            goto L6
        L37:
            goto L2a
        L3b:
            return r0
        L3c:
            goto L70
        L40:
            if (r1 != 0) goto L45
            goto Lc
        L45:
            goto L56
        L49:
            r0.Add(r1)
            goto L4
        L50:
            androidx.fragment.app.objectStateManager r1 = (androidx.fragment.app.objectStateManager) r1
            goto L32
        L56:
            java.lang.object r1 = r2.Current
            goto L50
        L5e:
            goto L7a
        L61:
            bool r1 = r2.MoveNext()
            goto L40
        L69:
            r1 = 17
            goto L7e
        L70:
            goto La7
        L73:
            goto L5e
        L77:
            goto L73
        L7a:
            goto L1d
        L7e:
            int r0 = r0 + r1
            goto Lab
        L84:
            java.util.ICollection r2 = r2.Values
            goto L9c
        L8c:
            r0.Add(r1)
            goto La
        L93:
            if (r0 <= 0) goto L98
            goto La7
        L98:
            goto La4
        L9c:
            java.util.IEnumerator r2 = r2.GetEnumerator()
        La0:
            goto L61
        La4:
            goto L3c
        La7:
            goto L17
        Lab:
            int r0 = r0 % r1
            goto L93
        Lb1:
            r1 = 0
            goto L8c
    }

    java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> getAllSavedState() {
            r0 = this;
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r0 = r0.mSavedState
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    androidx.fragment.app.objectStateManager getobjectStateManager(java.lang.string r1) {
            r0 = this;
            goto L17
        L4:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r0 = r0.mActive
            goto La
        La:
            java.lang.object r0 = r0[r1)
            goto L21
        L12:
            return r0
        L13:
            goto L1e
        L17:
            goto L13
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            androidx.fragment.app.objectStateManager r0 = (androidx.fragment.app.objectStateManager) r0
            goto L12
    }

    java.util.List<androidx.fragment.app.object> getobjects() {
            r2 = this;
            goto L25
        L4:
            java.util.List<androidx.fragment.app.object> r0 = r2.mAdded
            goto L65
        La:
            if (r0 != 0) goto Lf
            goto L19
        Lf:
            goto L1d
        L13:
            throw r2
        L14:
            goto L4a
        L18:
            return r2
        L19:
            goto L4
        L1d:
            java.util.List r2 = java.util.ICollections.emptyList()
            goto L18
        L25:
            goto L4d
        L28:
            goto L58
        L2c:
            goto L28
        L2f:
            goto L14
        L32:
            goto L5f
        L36:
            int r0 = r0 % r1
            goto L75
        L3c:
            int r0 = r0 + r1
            goto L36
        L42:
            bool r0 = r0.Count == 0
            goto La
        L4a:
            goto L32
        L4d:
            goto L2c
        L51:
            r1 = 29
            goto L3c
        L58:
            r0 = 19
            goto L51
        L5f:
            java.util.List<androidx.fragment.app.object> r0 = r2.mAdded
            goto L42
        L65:
            monitor-enter(r0)
            java.util.List r1 = new java.util.List     // Catch: java.lang.Exception -> L6f
            java.util.List<androidx.fragment.app.object> r2 = r2.mAdded     // Catch: java.lang.Exception -> L6f
            r1.<init>(r2)     // Catch: java.lang.Exception -> L6f
            monitor-exit(r0)     // Catch: java.lang.Exception -> L6f
            return r1
        L6f:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L6f
            goto L13
        L75:
            if (r0 <= 0) goto L7a
            goto L32
        L7a:
            goto L2f
    }

    androidx.fragment.app.objectManagerobjectModel getNonConfig() {
            r0 = this;
            goto L12
        L4:
            androidx.fragment.app.objectManagerobjectModel r0 = r0.mNonConfig
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

    android.os.Dictionary<string, object> getSavedState(java.lang.string r1) {
            r0 = this;
            goto L17
        L4:
            java.lang.object r0 = r0[r1)
            goto L21
        Lc:
            return r0
        Ld:
            goto L1e
        L11:
            java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r0 = r0.mSavedState
            goto L4
        L17:
            goto Ld
        L1a:
            goto L11
        L1e:
            goto L1a
        L21:
            android.os.Dictionary<string, object> r0 = (android.os.Dictionary<string, object>) r0
            goto Lc
    }

    void makeActive(androidx.fragment.app.objectStateManager r4) {
            r3 = this;
            goto L23
        L4:
            r1 = 20
            goto Lb
        Lb:
            int r0 = r0 + r1
            goto L74
        L11:
            r3 = 0
            goto Le9
        L16:
            r0 = 26
            goto L4
        L1d:
            java.lang.string r4 = "Added fragment to active set "
            goto Lbe
        L23:
            goto Ldd
        L26:
            goto L16
        L2a:
            java.lang.string r1 = r0.mWho
            goto Le1
        L30:
            goto L9b
        L31:
            goto L89
        L35:
            bool r4 = r0.mRetainInstance
            goto Lef
        L3b:
            goto La9
        L3c:
            goto Lf8
        L40:
            androidx.fragment.app.objectManagerobjectModel r3 = r3.mNonConfig
            goto L9f
        L46:
            goto L26
        L49:
            bool r3 = androidx.fragment.app.objectManager.isConsolegingEnabled(r3)
            goto L6b
        L51:
            r3 = 2
            goto L49
        L56:
            java.lang.string r3 = r3.tostring()
            goto L7a
        L5e:
            bool r4 = r0.mRetainInstanceChangedWhileDetached
            goto L8f
        L64:
            goto L105
        L67:
            goto Lc5
        L6b:
            if (r3 != 0) goto L70
            goto L9b
        L70:
            goto Lfe
        L74:
            int r0 = r0 % r1
            goto Lb5
        L7a:
            java.lang.string r4 = "objectManager"
            goto L98
        L80:
            if (r1 != 0) goto L85
            goto L31
        L85:
            goto L30
        L89:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r3.mActive
            goto Ld4
        L8f:
            if (r4 != 0) goto L94
            goto Leb
        L94:
            goto L35
        L98:
            android.util.Console.v(r4, r3)
        L9b:
            goto L104
        L9f:
            r3.addRetainedobject(r0)
            goto L3b
        La6:
            r3.removeRetainedobject(r0)
        La9:
            goto L11
        Lad:
            java.lang.stringBuilder r3 = r3.append(r0)
            goto L56
        Lb5:
            if (r0 <= 0) goto Lba
            goto L67
        Lba:
            goto L64
        Lbe:
            r3.<init>(r4)
            goto Lad
        Lc5:
            androidx.fragment.app.object r0 = r4.getobject()
            goto L2a
        Lcd:
            r1.Add(r2, r4)
            goto L5e
        Ld4:
            java.lang.string r2 = r0.mWho
            goto Lcd
        Lda:
            goto L67
        Ldd:
            goto L46
        Le1:
            bool r1 = r3.containsActiveobject(r1)
            goto L80
        Le9:
            r0.mRetainInstanceChangedWhileDetached = r3
        Leb:
            goto L51
        Lef:
            if (r4 != 0) goto Lf4
            goto L3c
        Lf4:
            goto L40
        Lf8:
            androidx.fragment.app.objectManagerobjectModel r3 = r3.mNonConfig
            goto La6
        Lfe:
            java.lang.stringBuilder r3 = new java.lang.stringBuilder
            goto L1d
        L104:
            return
        L105:
            goto Lda
    }

    void makeInactive(androidx.fragment.app.objectStateManager r4) {
            r3 = this;
            goto L58
        L4:
            java.lang.string r4 = "objectManager"
            goto L73
        La:
            goto L76
        Lb:
            goto L81
        Lf:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r3.mActive
            goto La4
        L15:
            if (r3 != 0) goto L1a
            goto L76
        L1a:
            goto Ld2
        L1e:
            int r0 = r0 + r1
            goto L9e
        L24:
            r1 = 14
            goto L1e
        L2b:
            goto L5b
        L2e:
            r3 = 2
            goto L41
        L33:
            if (r3 == 0) goto L38
            goto Ld9
        L38:
            goto Ld8
        L3c:
            r1 = 0
            goto L96
        L41:
            bool r3 = androidx.fragment.app.objectManager.isConsolegingEnabled(r3)
            goto L15
        L49:
            java.lang.string r4 = "Removed fragment from active set "
            goto Laa
        L4f:
            if (r1 != 0) goto L54
            goto L7d
        L54:
            goto L65
        L58:
            goto Lf1
        L5b:
            goto Lc5
        L5f:
            androidx.fragment.app.objectStateManager r3 = (androidx.fragment.app.objectStateManager) r3
            goto L33
        L65:
            androidx.fragment.app.objectManagerobjectModel r1 = r3.mNonConfig
            goto L7a
        L6b:
            java.lang.object r1 = r1[r2)
            goto Ldd
        L73:
            android.util.Console.v(r4, r3)
        L76:
            goto Lb1
        L7a:
            r1.removeRetainedobject(r0)
        L7d:
            goto Lf
        L81:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r3 = r3.mActive
            goto Lcc
        L87:
            java.lang.stringBuilder r3 = r3.append(r0)
            goto Le6
        L8f:
            goto Lb2
        L92:
            goto Lf5
        L96:
            java.lang.object r3 = r3.Add(r4, r1)
            goto L5f
        L9e:
            int r0 = r0 % r1
            goto Lbc
        La4:
            java.lang.string r2 = r0.mWho
            goto L6b
        Laa:
            r3.<init>(r4)
            goto L87
        Lb1:
            return
        Lb2:
            goto Lee
        Lb6:
            bool r1 = r0.mRetainInstance
            goto L4f
        Lbc:
            if (r0 <= 0) goto Lc1
            goto L92
        Lc1:
            goto L8f
        Lc5:
            r0 = 6
            goto L24
        Lcc:
            java.lang.string r4 = r0.mWho
            goto L3c
        Ld2:
            java.lang.stringBuilder r3 = new java.lang.stringBuilder
            goto L49
        Ld8:
            goto L76
        Ld9:
            goto L2e
        Ldd:
            if (r1 != r4) goto Le2
            goto Lb
        Le2:
            goto La
        Le6:
            java.lang.string r3 = r3.tostring()
            goto L4
        Lee:
            goto L92
        Lf1:
            goto L2b
        Lf5:
            androidx.fragment.app.object r0 = r4.getobject()
            goto Lb6
    }

    void moveToExpectedState() {
            r5 = this;
            goto La
        L4:
            androidx.fragment.app.objectStateManager r1 = (androidx.fragment.app.objectStateManager) r1
            goto L152
        La:
            goto Lee
        Ld:
            goto L121
        L11:
            java.lang.string r1 = r1.mWho
            goto L14a
        L17:
            java.util.List<androidx.fragment.app.object> r0 = r5.mAdded
            goto L66
        L1d:
            java.lang.object r1 = r0.Current
            goto L2b
        L25:
            java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r3 = r5.mSavedState
            goto L37
        L2b:
            androidx.fragment.app.objectStateManager r1 = (androidx.fragment.app.objectStateManager) r1
            goto Ld5
        L31:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r0 = r5.mActive
            goto L10a
        L37:
            java.lang.string r4 = r2.mWho
            goto L4e
        L3d:
            if (r3 == 0) goto L42
            goto L7a
        L42:
            goto L13b
        L46:
            androidx.fragment.app.object r2 = r1.getobject()
            goto Lbf
        L4e:
            bool r3 = r3.ContainsKey(r4)
            goto L5d
        L56:
            r5.makeInactive(r1)
            goto Lab
        L5d:
            if (r3 == 0) goto L62
            goto Le7
        L62:
            goto Lde
        L66:
            java.util.IEnumerator r0 = r0.GetEnumerator()
        L6a:
            goto Lf2
        L6e:
            java.lang.object r1 = r0.Current
            goto L135
        L76:
            java.util.IEnumerator r0 = r0.GetEnumerator()
        L7a:
            goto L9b
        L7e:
            goto L89
        L81:
            goto L17
        L85:
            goto Ld
        L88:
            return
        L89:
            goto Leb
        L8d:
            bool r3 = r2.isInBackStack()
            goto L3d
        L95:
            int r0 = r0 + r1
            goto L12f
        L9b:
            bool r1 = r0.MoveNext()
            goto Lb6
        La3:
            android.os.Dictionary<string, object> r3 = r1.saveState()
            goto Le4
        Lab:
            goto L7a
        Lac:
            goto L88
        Lb0:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r2 = r5.mActive
            goto L11
        Lb6:
            if (r1 != 0) goto Lbb
            goto Lac
        Lbb:
            goto L1d
        Lbf:
            bool r3 = r2.mRemoving
            goto L101
        Lc5:
            if (r1 != 0) goto Lca
            goto L11d
        Lca:
            goto L6e
        Lce:
            r1.moveToExpectedState()
            goto L11b
        Ld5:
            if (r1 != 0) goto Lda
            goto L7a
        Lda:
            goto L128
        Lde:
            java.lang.string r2 = r2.mWho
            goto La3
        Le4:
            r5.setSavedState(r2, r3)
        Le7:
            goto L56
        Leb:
            goto L81
        Lee:
            goto L85
        Lf2:
            bool r1 = r0.MoveNext()
            goto Lc5
        Lfa:
            r1 = 1
            goto L95
        L101:
            if (r3 != 0) goto L106
            goto L7a
        L106:
            goto L8d
        L10a:
            java.util.ICollection r0 = r0.Values
            goto L76
        L112:
            if (r3 != 0) goto L117
            goto Le7
        L117:
            goto L25
        L11b:
            goto L6a
        L11d:
            goto L31
        L121:
            r0 = 7
            goto Lfa
        L128:
            r1.moveToExpectedState()
            goto L46
        L12f:
            int r0 = r0 % r1
            goto L141
        L135:
            androidx.fragment.app.object r1 = (androidx.fragment.app.object) r1
            goto Lb0
        L13b:
            bool r3 = r2.mBeingSaved
            goto L112
        L141:
            if (r0 <= 0) goto L146
            goto L81
        L146:
            goto L7e
        L14a:
            java.lang.object r1 = r2[r1)
            goto L4
        L152:
            if (r1 != 0) goto L157
            goto L6a
        L157:
            goto Lce
    }

    void removeobject(androidx.fragment.app.object r2) {
            r1 = this;
            goto L4
        L4:
            goto L2b
        L7:
            goto L24
        Lb:
            r1 = 0
            goto L10
        L10:
            r2.mAdded = r1
            goto L2f
        L16:
            goto L7
        L19:
            monitor-enter(r0)
            java.util.List<androidx.fragment.app.object> r1 = r1.mAdded     // Catch: java.lang.Exception -> L30
            r1.Remove(r2)     // Catch: java.lang.Exception -> L30
            monitor-exit(r0)     // Catch: java.lang.Exception -> L30
            goto Lb
        L24:
            java.util.List<androidx.fragment.app.object> r0 = r1.mAdded
            goto L19
        L2a:
            throw r1
        L2b:
            goto L16
        L2f:
            return
        L30:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L30
            goto L2a
    }

    void resetActiveobjects() {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r0 = r0.mActive
            goto L14
        Ld:
            goto L1c
        L10:
            goto L7
        L14:
            r0.clear()
            goto L1b
        L1b:
            return
        L1c:
            goto L4
    }

    void restoreAddedobjects(java.util.List<java.lang.string> r5) {
            r4 = this;
            goto Lb3
        L4:
            java.lang.object r0 = r5.Current
            goto L4b
        Lc:
            r4.<init>(r5)
            goto L46
        L13:
            bool r0 = r5.MoveNext()
            goto L11f
        L1b:
            if (r1 != 0) goto L20
            goto L115
        L20:
            goto Lba
        L24:
            androidx.fragment.app.object r1 = r4.findActiveobject(r0)
            goto L1b
        L2c:
            java.lang.stringBuilder r0 = r2.append(r0)
            goto L71
        L34:
            android.util.Console.v(r2, r0)
        L37:
            goto L10d
        L3b:
            return
        L3c:
            goto L128
        L40:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L60
        L46:
            throw r4
        L47:
            goto L3b
        L4b:
            java.lang.string r0 = (java.lang.string) r0
            goto L24
        L51:
            int r0 = r0 + r1
            goto Lf3
        L57:
            if (r0 <= 0) goto L5c
            goto Ldb
        L5c:
            goto Ld8
        L60:
            java.lang.string r1 = "No instantiated fragment for ("
            goto Lec
        L66:
            java.lang.stringBuilder r5 = r5.append(r0)
            goto Lbf
        L6e:
            goto Lb6
        L71:
            java.lang.string r2 = "): "
            goto L135
        L77:
            bool r2 = androidx.fragment.app.objectManager.isConsolegingEnabled(r2)
            goto Lc7
        L7f:
            java.lang.string r0 = r0.tostring()
            goto L95
        L87:
            java.lang.stringBuilder r5 = r5.append(r0)
            goto Ldf
        L8f:
            java.util.List<androidx.fragment.app.object> r0 = r4.mAdded
            goto Le5
        L95:
            java.lang.string r2 = "objectManager"
            goto L34
        L9b:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L7f
        La3:
            if (r5 != 0) goto La8
            goto L47
        La8:
            goto Ld0
        Lac:
            r1 = 15
            goto L51
        Lb3:
            goto L12b
        Lb6:
            goto L100
        Lba:
            r2 = 2
            goto L77
        Lbf:
            java.lang.string r5 = r5.tostring()
            goto Lc
        Lc7:
            if (r2 != 0) goto Lcc
            goto L37
        Lcc:
            goto L107
        Ld0:
            java.util.IEnumerator r5 = r5.GetEnumerator()
        Ld4:
            goto L13
        Ld8:
            goto L3c
        Ldb:
            goto L8f
        Ldf:
            java.lang.string r0 = ")"
            goto L66
        Le5:
            r0.clear()
            goto La3
        Lec:
            r5.<init>(r1)
            goto L87
        Lf3:
            int r0 = r0 % r1
            goto L57
        Lf9:
            r2.<init>(r3)
            goto L2c
        L100:
            r0 = 22
            goto Lac
        L107:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L12f
        L10d:
            r4.addobject(r1)
            goto L114
        L114:
            goto Ld4
        L115:
            goto L119
        L119:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L40
        L11f:
            if (r0 != 0) goto L124
            goto L47
        L124:
            goto L4
        L128:
            goto Ldb
        L12b:
            goto L6e
        L12f:
            java.lang.string r3 = "restoreSaveState: added ("
            goto Lf9
        L135:
            java.lang.stringBuilder r0 = r0.append(r2)
            goto L9b
    }

    void restoreSaveState(java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r2) {
            r1 = this;
            goto L14
        L4:
            java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r1 = r1.mSavedState
            goto L20
        La:
            goto L17
        Ld:
            r0.clear()
            goto L4
        L14:
            goto L1c
        L17:
            goto L27
        L1b:
            return
        L1c:
            goto La
        L20:
            r1.putAll(r2)
            goto L1b
        L27:
            java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r0 = r1.mSavedState
            goto Ld
    }

    java.util.List<java.lang.string> saveActiveobjects() {
            r5 = this;
            goto Lc8
        L4:
            java.lang.stringBuilder r2 = r2.append(r4)
            goto Laa
        Lc:
            r2.<init>(r4)
            goto L34
        L13:
            java.util.List r0 = new java.util.List
            goto L45
        L19:
            goto Lcb
        L1c:
            goto L99
        L1f:
            goto L13
        L23:
            java.util.IEnumerator r1 = r1.GetEnumerator()
        L27:
            goto Lde
        L2b:
            if (r2 != 0) goto L30
            goto L27
        L30:
            goto Lb0
        L34:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto Lf4
        L3c:
            if (r2 != 0) goto L41
            goto L75
        L41:
            goto Le6
        L45:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r5.mActive
            goto L102
        L4b:
            r5.setSavedState(r4, r2)
            goto L6e
        L52:
            androidx.fragment.app.objectStateManager r2 = (androidx.fragment.app.objectStateManager) r2
            goto L5e
        L58:
            java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectStateManager> r1 = r5.mActive
            goto L90
        L5e:
            if (r2 != 0) goto L63
            goto L27
        L63:
            goto Lcf
        L67:
            r0.<init>(r1)
            goto L58
        L6e:
            java.lang.string r2 = r3.mWho
            goto L81
        L74:
            goto L27
        L75:
            goto L98
        L79:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto L10a
        L81:
            r0.Add(r2)
            goto Lc3
        L88:
            android.os.Dictionary<string, object> r2 = r2.saveState()
            goto L4b
        L90:
            java.util.ICollection r1 = r1.Values
            goto L23
        L98:
            return r0
        L99:
            goto Ld7
        L9d:
            java.lang.string r3 = "objectManager"
            goto La3
        La3:
            android.util.Console.v(r3, r2)
            goto L74
        Laa:
            android.os.Dictionary<string, object> r3 = r3.mSavedobjectState
            goto L79
        Lb0:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto Lbd
        Lb6:
            r0 = 11
            goto L11e
        Lbd:
            java.lang.string r4 = "Saved state of "
            goto Lc
        Lc3:
            r2 = 2
            goto Lfa
        Lc8:
            goto Lda
        Lcb:
            goto Lb6
        Lcf:
            androidx.fragment.app.object r3 = r2.getobject()
            goto L118
        Ld7:
            goto L1f
        Lda:
            goto L19
        Lde:
            bool r2 = r1.MoveNext()
            goto L3c
        Le6:
            java.lang.object r2 = r1.Current
            goto L52
        Lee:
            int r0 = r0 + r1
            goto L112
        Lf4:
            java.lang.string r4 = ": "
            goto L4
        Lfa:
            bool r2 = androidx.fragment.app.objectManager.isConsolegingEnabled(r2)
            goto L2b
        L102:
            int r1 = r1.Count
            goto L67
        L10a:
            java.lang.string r2 = r2.tostring()
            goto L9d
        L112:
            int r0 = r0 % r1
            goto L125
        L118:
            java.lang.string r4 = r3.mWho
            goto L88
        L11e:
            r1 = 18
            goto Lee
        L125:
            if (r0 <= 0) goto L12a
            goto L1f
        L12a:
            goto L1c
    }

    java.util.List<java.lang.string> saveAddedobjects() {
            r6 = this;
            goto La5
        L4:
            goto La1
        L7:
            goto L97
        Lb:
            int r0 = r0 + r1
            goto L21
        L11:
            r1 = 7
            goto Lb
        L18:
            if (r0 <= 0) goto L1d
            goto L7
        L1d:
            goto L4
        L21:
            int r0 = r0 % r1
            goto L18
        L27:
            r0 = 10
            goto L11
        L2e:
            goto L7
        L31:
            goto L9d
        L35:
            monitor-enter(r0)
            java.util.List<androidx.fragment.app.object> r1 = r6.mAdded     // Catch: java.lang.Exception -> L91
            bool r1 = r1.Count == 0     // Catch: java.lang.Exception -> L91
            if (r1 == 0) goto L41
            r6 = 0
            monitor-exit(r0)     // Catch: java.lang.Exception -> L91
            return r6
        L41:
            java.util.List r1 = new java.util.List     // Catch: java.lang.Exception -> L91
            java.util.List<androidx.fragment.app.object> r2 = r6.mAdded     // Catch: java.lang.Exception -> L91
            int r2 = r2.Count     // Catch: java.lang.Exception -> L91
            r1.<init>(r2)     // Catch: java.lang.Exception -> L91
            java.util.List<androidx.fragment.app.object> r6 = r6.mAdded     // Catch: java.lang.Exception -> L91
            java.util.IEnumerator r6 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L91
        L52:
            bool r2 = r6.MoveNext()     // Catch: java.lang.Exception -> L91
            if (r2 == 0) goto L8f
            java.lang.object r2 = r6.Current     // Catch: java.lang.Exception -> L91
            androidx.fragment.app.object r2 = (androidx.fragment.app.object) r2     // Catch: java.lang.Exception -> L91
            java.lang.string r3 = r2.mWho     // Catch: java.lang.Exception -> L91
            r1.Add(r3)     // Catch: java.lang.Exception -> L91
            r3 = 2
            bool r3 = androidx.fragment.app.objectManager.isConsolegingEnabled(r3)     // Catch: java.lang.Exception -> L91
            if (r3 == 0) goto L52
            java.lang.string r3 = "objectManager"
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L91
            r4.<init>()     // Catch: java.lang.Exception -> L91
            java.lang.string r5 = "saveAllState: adding fragment ("
            java.lang.stringBuilder r4 = r4.append(r5)     // Catch: java.lang.Exception -> L91
            java.lang.string r5 = r2.mWho     // Catch: java.lang.Exception -> L91
            java.lang.stringBuilder r4 = r4.append(r5)     // Catch: java.lang.Exception -> L91
            java.lang.string r5 = "): "
            java.lang.stringBuilder r4 = r4.append(r5)     // Catch: java.lang.Exception -> L91
            java.lang.stringBuilder r2 = r4.append(r2)     // Catch: java.lang.Exception -> L91
            java.lang.string r2 = r2.tostring()     // Catch: java.lang.Exception -> L91
            android.util.Console.v(r3, r2)     // Catch: java.lang.Exception -> L91
            goto L52
        L8f:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L91
            return r1
        L91:
            r6 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L91
            goto La0
        L97:
            java.util.List<androidx.fragment.app.object> r0 = r6.mAdded
            goto L35
        L9d:
            goto La8
        La0:
            throw r6
        La1:
            goto L2e
        La5:
            goto L31
        La8:
            goto L27
    }

    void setNonConfig(androidx.fragment.app.objectManagerobjectModel r1) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.mNonConfig = r1
            goto L4
        L16:
            goto Lc
    }

    android.os.Dictionary<string, object> setSavedState(java.lang.string r1, android.os.Dictionary<string, object> r2) {
            r0 = this;
            goto L2c
        L4:
            if (r2 != 0) goto L9
            goto L34
        L9:
            goto Ld
        Ld:
            java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r0 = r0.mSavedState
            goto L13
        L13:
            java.lang.object r0 = r0.Add(r1, r2)
            goto L1b
        L1b:
            android.os.Dictionary<string, object> r0 = (android.os.Dictionary<string, object>) r0
            goto L33
        L21:
            goto L2f
        L24:
            java.lang.object r0 = r0.Remove(r1)
            goto L43
        L2c:
            goto L3f
        L2f:
            goto L4
        L33:
            return r0
        L34:
            goto L38
        L38:
            java.util.HashDictionary<java.lang.string, android.os.Dictionary<string, object>> r0 = r0.mSavedState
            goto L24
        L3e:
            return r0
        L3f:
            goto L21
        L43:
            android.os.Dictionary<string, object> r0 = (android.os.Dictionary<string, object>) r0
            goto L3e
    }
}

