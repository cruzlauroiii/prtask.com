namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application_ProcessDetails */
/* JADX INFO: loaded from: classes2.dex */
readonly class C2022x94fa915f : com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails {
    private readonly bool defaultProcess;
    private readonly int importance;
    private readonly int pid;
    private readonly java.lang.string processName;

    /* JADX INFO: renamed from: com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application_ProcessDetails$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {
    }

    /* JADX INFO: renamed from: com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application_ProcessDetails$Builder */
    static readonly class Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder {
        private bool defaultProcess;
        private int importance;
        private int pid;
        private java.lang.string processName;
        private byte set$0;

        Builder() {
                r0 = this;
                goto L4
            L4:
                goto L16
            L7:
                goto Lb
            Lb:
                r0.<init>()
                goto L15
            L12:
                goto L7
            L15:
                return
            L16:
                goto L12
        }

        public static java.lang.stringBuilder BmnvZShGezRfPgqp(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static void BmnvZShGezRfPgqp(java.lang.stringBuilder r0, java.lang.string r1, byte r2, short r3, int r4, java.lang.string r5) {
                goto L13
            L4:
                r0 = 42
                goto La
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L10:
                goto L16
            L13:
                goto L1b
            L16:
                goto L4
            L1a:
                return
            L1b:
                goto L10
            L1f:
                int r2 = r0 * r1
                goto L25
            L25:
                int r3 = r2 + r1
                goto L2b
            L2b:
                double r0 = (double) r3
                goto L1a
        }

        public static void BmnvZShGezRfPgqp(java.lang.stringBuilder r0, java.lang.string r1, int r2, byte r3, java.lang.string r4, short r5) {
                goto L1e
            L4:
                goto L21
            L7:
                r0 = 42
                goto Ld
            Ld:
                r1 = 210(0xd2, float:2.94E-43)
                goto L18
            L13:
                double r0 = (double) r3
                goto L25
            L18:
                int r2 = r0 * r1
                goto L2a
            L1e:
                goto L26
            L21:
                goto L7
            L25:
                return
            L26:
                goto L4
            L2a:
                int r3 = r2 + r1
                goto L13
        }

        public static void BmnvZShGezRfPgqp(java.lang.stringBuilder r0, java.lang.string r1, int r2, short r3, byte r4, java.lang.string r5) {
                goto L20
            L4:
                return
            L5:
                goto L2d
            L9:
                int r2 = r0 * r1
                goto Lf
            Lf:
                int r3 = r2 + r1
                goto L1b
            L15:
                r1 = 210(0xd2, float:2.94E-43)
                goto L9
            L1b:
                double r0 = (double) r3
                goto L4
            L20:
                goto L5
            L23:
                goto L27
            L27:
                r0 = 42
                goto L15
            L2d:
                goto L23
        }

        public static java.lang.stringBuilder IMxoPFdjXZpcZjNb(java.lang.stringBuilder r1, java.lang.string r2) {
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

        public static void IMxoPFdjXZpcZjNb(java.lang.stringBuilder r0, java.lang.string r1, int r2, java.lang.string r3, byte r4, bool r5) {
                goto L15
            L4:
                r0 = 42
                goto L22
            La:
                return
            Lb:
                goto L2d
            Lf:
                int r2 = r0 * r1
                goto L1c
            L15:
                goto Lb
            L18:
                goto L4
            L1c:
                int r3 = r2 + r1
                goto L28
            L22:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            L28:
                double r0 = (double) r3
                goto La
            L2d:
                goto L18
        }

        public static void IMxoPFdjXZpcZjNb(java.lang.stringBuilder r0, java.lang.string r1, int r2, bool r3, byte r4, java.lang.string r5) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L16
            Lb:
                return
            Lc:
                goto L1c
            L10:
                int r3 = r2 + r1
                goto L2b
            L16:
                r0 = 42
                goto L25
            L1c:
                goto L7
            L1f:
                int r2 = r0 * r1
                goto L10
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L2b:
                double r0 = (double) r3
                goto Lb
        }

        public static void IMxoPFdjXZpcZjNb(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, byte r3, bool r4, int r5) {
                goto L12
            L4:
                return
            L5:
                goto L9
            L9:
                goto L15
            Lc:
                r0 = 42
                goto L2a
            L12:
                goto L5
            L15:
                goto Lc
            L19:
                double r0 = (double) r3
                goto L4
            L1e:
                int r3 = r2 + r1
                goto L19
            L24:
                int r2 = r0 * r1
                goto L1e
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L24
        }

        public static java.lang.stringBuilder OluqWgWfGZrDwFKq(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static void OluqWgWfGZrDwFKq(java.lang.stringBuilder r0, java.lang.string r1, byte r2, short r3, java.lang.string r4, int r5) {
                goto L10
            L4:
                r0 = 42
                goto L1c
            La:
                int r3 = r2 + r1
                goto L17
            L10:
                goto L29
            L13:
                goto L4
            L17:
                double r0 = (double) r3
                goto L28
            L1c:
                r1 = 210(0xd2, float:2.94E-43)
                goto L22
            L22:
                int r2 = r0 * r1
                goto La
            L28:
                return
            L29:
                goto L2d
            L2d:
                goto L13
        }

        public static void OluqWgWfGZrDwFKq(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, short r3, byte r4, int r5) {
                goto L24
            L4:
                int r3 = r2 + r1
                goto Ld
            La:
                goto L27
            Ld:
                double r0 = (double) r3
                goto L2b
            L12:
                r1 = 210(0xd2, float:2.94E-43)
                goto L18
            L18:
                int r2 = r0 * r1
                goto L4
            L1e:
                r0 = 42
                goto L12
            L24:
                goto L2c
            L27:
                goto L1e
            L2b:
                return
            L2c:
                goto La
        }

        public static void OluqWgWfGZrDwFKq(java.lang.stringBuilder r0, java.lang.string r1, short r2, java.lang.string r3, byte r4, int r5) {
                goto L18
            L4:
                int r2 = r0 * r1
                goto L24
            La:
                r0 = 42
                goto L2a
            L10:
                double r0 = (double) r3
                goto L1f
            L15:
                goto L1b
            L18:
                goto L20
            L1b:
                goto La
            L1f:
                return
            L20:
                goto L15
            L24:
                int r3 = r2 + r1
                goto L10
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
        }

        public static java.lang.stringBuilder YksDQYDDzyQvIwAw(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static void YksDQYDDzyQvIwAw(java.lang.stringBuilder r0, java.lang.string r1, byte r2, java.lang.string r3, short r4, float r5) {
                goto L12
            L4:
                int r2 = r0 * r1
                goto L2a
            La:
                goto L15
            Ld:
                double r0 = (double) r3
                goto L25
            L12:
                goto L26
            L15:
                goto L19
            L19:
                r0 = 42
                goto L1f
            L1f:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L25:
                return
            L26:
                goto La
            L2a:
                int r3 = r2 + r1
                goto Ld
        }

        public static void YksDQYDDzyQvIwAw(java.lang.stringBuilder r0, java.lang.string r1, short r2, byte r3, java.lang.string r4, float r5) {
                goto L4
            L4:
                goto L17
            L7:
                goto L21
            Lb:
                double r0 = (double) r3
                goto L16
            L10:
                int r2 = r0 * r1
                goto L1b
            L16:
                return
            L17:
                goto L2d
            L1b:
                int r3 = r2 + r1
                goto Lb
            L21:
                r0 = 42
                goto L27
            L27:
                r1 = 210(0xd2, float:2.94E-43)
                goto L10
            L2d:
                goto L7
        }

        public static void YksDQYDDzyQvIwAw(java.lang.stringBuilder r0, java.lang.string r1, short r2, float r3, java.lang.string r4, byte r5) {
                goto L1d
            L4:
                goto L20
            L7:
                double r0 = (double) r3
                goto L12
            Lc:
                int r2 = r0 * r1
                goto L2a
            L12:
                return
            L13:
                goto L4
            L17:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lc
            L1d:
                goto L13
            L20:
                goto L24
            L24:
                r0 = 42
                goto L17
            L2a:
                int r3 = r2 + r1
                goto L7
        }

        public static java.lang.string BdeqfiOCQMYotoAr(java.lang.stringBuilder r1) {
                goto L14
            L4:
                goto L17
            L7:
                java.lang.string r0 = r1.tostring()
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

        public static void BdeqfiOCQMYotoAr(java.lang.stringBuilder r0, byte r1, float r2, short r3, char r4) {
                goto L29
            L4:
                double r0 = (double) r3
                goto L24
            L9:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            Lf:
                int r2 = r0 * r1
                goto L1e
            L15:
                goto L2c
            L18:
                r0 = 42
                goto L9
            L1e:
                int r3 = r2 + r1
                goto L4
            L24:
                return
            L25:
                goto L15
            L29:
                goto L25
            L2c:
                goto L18
        }

        public static void BdeqfiOCQMYotoAr(java.lang.stringBuilder r0, char r1, byte r2, float r3, short r4) {
                goto L23
            L4:
                goto L26
            L7:
                return
            L8:
                goto L4
            Lc:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1d
            L12:
                double r0 = (double) r3
                goto L7
            L17:
                r0 = 42
                goto Lc
            L1d:
                int r2 = r0 * r1
                goto L2a
            L23:
                goto L8
            L26:
                goto L17
            L2a:
                int r3 = r2 + r1
                goto L12
        }

        public static void BdeqfiOCQMYotoAr(java.lang.stringBuilder r0, float r1, byte r2, char r3, short r4) {
                goto L1e
            L4:
                r0 = 42
                goto L25
            La:
                double r0 = (double) r3
                goto L2b
            Lf:
                goto L21
            L12:
                int r3 = r2 + r1
                goto La
            L18:
                int r2 = r0 * r1
                goto L12
            L1e:
                goto L2c
            L21:
                goto L4
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L18
            L2b:
                return
            L2c:
                goto Lf
        }

        public static java.lang.stringBuilder FgIwuHLZsJkRanAR(java.lang.stringBuilder r1, java.lang.object r2) {
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
                java.lang.stringBuilder r0 = r1.append(r2)
                goto Le
        }

        public static void FgIwuHLZsJkRanAR(java.lang.stringBuilder r0, java.lang.object r1, char r2, int r3, java.lang.string r4, bool r5) {
                goto L29
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L15
            La:
                return
            Lb:
                goto L26
            Lf:
                r0 = 42
                goto L4
            L15:
                int r2 = r0 * r1
                goto L1b
            L1b:
                int r3 = r2 + r1
                goto L21
            L21:
                double r0 = (double) r3
                goto La
            L26:
                goto L2c
            L29:
                goto Lb
            L2c:
                goto Lf
        }

        public static void FgIwuHLZsJkRanAR(java.lang.stringBuilder r0, java.lang.object r1, char r2, bool r3, java.lang.string r4, int r5) {
                goto La
            L4:
                int r3 = r2 + r1
                goto L28
            La:
                goto L12
            Ld:
                goto L16
            L11:
                return
            L12:
                goto L2d
            L16:
                r0 = 42
                goto L22
            L1c:
                int r2 = r0 * r1
                goto L4
            L22:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1c
            L28:
                double r0 = (double) r3
                goto L11
            L2d:
                goto Ld
        }

        public static void FgIwuHLZsJkRanAR(java.lang.stringBuilder r0, java.lang.object r1, bool r2, char r3, int r4, java.lang.string r5) {
                goto L14
            L4:
                r0 = 42
                goto L27
            La:
                double r0 = (double) r3
                goto Lf
            Lf:
                return
            L10:
                goto L2d
            L14:
                goto L10
            L17:
                goto L4
            L1b:
                int r3 = r2 + r1
                goto La
            L21:
                int r2 = r0 * r1
                goto L1b
            L27:
                r1 = 210(0xd2, float:2.94E-43)
                goto L21
            L2d:
                goto L17
        }

        @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder
        public com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails Build() {
                r7 = this;
                goto L63
            L4:
                byte r1 = r7.set$0
                goto Lfb
            La:
                java.lang.string r1 = " processName"
                goto Lc0
            L10:
                return r1
            L11:
                goto L4e
            L15:
                java.lang.stringBuilder r1 = new java.lang.stringBuilder
                goto La0
            L1b:
                IMxoPFdjXZpcZjNb(r0, r1)
            L1e:
                goto L80
            L22:
                throw r7
            L23:
                goto Lac
            L27:
                r1 = r1 & 1
                goto L107
            L2d:
                r7 = r7 & 4
                goto Ldd
            L33:
                if (r0 <= 0) goto L38
                goto L157
            L38:
                goto L154
            L3c:
                int r0 = r0 % r1
                goto L33
            L42:
                java.lang.string r1 = " importance"
                goto L1b
            L48:
                int r3 = r7.pid
                goto L92
            L4e:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto Le6
            L54:
                if (r1 == 0) goto L59
                goto L1e
            L59:
                goto L42
            L5d:
                java.lang.string r0 = r7.processName
                goto Ld4
            L63:
                goto Laf
            L66:
                goto L6a
            L6a:
                r0 = 27
                goto L147
            L71:
                java.lang.string r2 = r7.processName
                goto L48
            L77:
                java.lang.string r1 = r7.processName
                goto L13e
            L7d:
                goto L66
            L80:
                byte r7 = r7.set$0
                goto L2d
            L86:
                com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application_ProcessDetails r1 = new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application_ProcessDetails
                goto L71
            L8c:
                java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
                goto L15
            L92:
                int r4 = r7.importance
                goto L14e
            L98:
                java.lang.string r0 = bdeqfiOCQMYotoAr(r0)
                goto Lcd
            La0:
                java.lang.string r2 = "Missing required properties:"
                goto Lb3
            La6:
                java.lang.string r1 = " pid"
                goto L126
            Lac:
                goto L157
            Laf:
                goto L7d
            Lb3:
                r1.<init>(r2)
                goto L117
            Lba:
                byte r1 = r7.set$0
                goto L27
            Lc0:
                YksDQYDDzyQvIwAw(r0, r1)
            Lc3:
                goto Lba
            Lc7:
                int r0 = r0 + r1
                goto L3c
            Lcd:
                r7.<init>(r0)
                goto L22
            Ld4:
                if (r0 == 0) goto Ld9
                goto L103
            Ld9:
                goto L101
            Ldd:
                if (r7 == 0) goto Le2
                goto L113
            Le2:
                goto L12d
            Le6:
                r0.<init>()
                goto L77
            Led:
                if (r0 == r1) goto Lf2
                goto L11
            Lf2:
                goto L5d
            Lf6:
                r6 = 0
                goto L11f
            Lfb:
                r1 = r1 & 2
                goto L54
            L101:
                goto L11
            L103:
                goto L86
            L107:
                if (r1 == 0) goto L10c
                goto L129
            L10c:
                goto La6
            L110:
                OluqWgWfGZrDwFKq(r0, r7)
            L113:
                goto L8c
            L117:
                java.lang.stringBuilder r0 = fgIwuHLZsJkRanAR(r1, r0)
                goto L98
            L11f:
                r1.<init>(r2, r3, r4, r5, r6)
                goto L10
            L126:
                BmnvZShGezRfPgqp(r0, r1)
            L129:
                goto L4
            L12d:
                java.lang.string r7 = " defaultProcess"
                goto L110
            L133:
                byte r0 = r7.set$0
                goto L139
            L139:
                r1 = 7
                goto Led
            L13e:
                if (r1 == 0) goto L143
                goto Lc3
            L143:
                goto La
            L147:
                r1 = 19
                goto Lc7
            L14e:
                bool r5 = r7.defaultProcess
                goto Lf6
            L154:
                goto L23
            L157:
                goto L133
        }

        @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder
        public com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder SetDefaultProcess(bool r1) {
                r0 = this;
                goto L20
            L4:
                r0.defaultProcess = r1
                goto L1a
            La:
                return r0
            Lb:
                goto L27
            Lf:
                byte r1 = (byte) r1
                goto L14
            L14:
                r0.set$0 = r1
                goto La
            L1a:
                byte r1 = r0.set$0
                goto L2a
            L20:
                goto Lb
            L23:
                goto L4
            L27:
                goto L23
            L2a:
                r1 = r1 | 4
                goto Lf
        }

        @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder
        public com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder SetImportance(int r1) {
                r0 = this;
                goto Lf
            L4:
                return r0
            L5:
                goto L16
            L9:
                r0.set$0 = r1
                goto L4
            Lf:
                goto L5
            L12:
                goto L2a
            L16:
                goto L12
            L19:
                byte r1 = r0.set$0
                goto L24
            L1f:
                byte r1 = (byte) r1
                goto L9
            L24:
                r1 = r1 | 2
                goto L1f
            L2a:
                r0.importance = r1
                goto L19
        }

        @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder
        public com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder SetPid(int r1) {
                r0 = this;
                goto L10
            L4:
                r0.pid = r1
                goto La
            La:
                byte r1 = r0.set$0
                goto L1f
            L10:
                goto L1b
            L13:
                goto L4
            L17:
                goto L13
            L1a:
                return r0
            L1b:
                goto L17
            L1f:
                r1 = r1 | 1
                goto L2b
            L25:
                r0.set$0 = r1
                goto L1a
            L2b:
                byte r1 = (byte) r1
                goto L25
        }

        @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder
        public com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails.Builder SetProcessName(java.lang.string r1) {
                r0 = this;
                goto L16
            L4:
                r0.processName = r1
                goto L30
            La:
                goto L19
            Ld:
                if (r1 != 0) goto L12
                goto L31
            L12:
                goto L4
            L16:
                goto L36
            L19:
                goto Ld
            L1d:
                java.lang.NullPointerException r0 = new java.lang.NullPointerException
                goto L23
            L23:
                java.lang.string r1 = "Null processName"
                goto L29
            L29:
                r0.<init>(r1)
                goto L35
            L30:
                return r0
            L31:
                goto L1d
            L35:
                throw r0
            L36:
                goto La
        }
    }

    private C2022x94fa915f(java.lang.string r1, int r2, int r3, bool r4) {
            r0 = this;
            goto L11
        L4:
            r0.<init>()
            goto L1e
        Lb:
            r0.pid = r2
            goto L24
        L11:
            goto L2e
        L14:
            goto L4
        L18:
            r0.defaultProcess = r4
            goto L2d
        L1e:
            r0.processName = r1
            goto Lb
        L24:
            r0.importance = r3
            goto L18
        L2a:
            goto L14
        L2d:
            return
        L2e:
            goto L2a
    }

    /* synthetic */ C2022x94fa915f(java.lang.string r1, int r2, int r3, bool r4, com.google.firebase.crashlytics.internal.model.C2022x94fa915f.AnonymousClass1 r5) {
            r0 = this;
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.<init>(r1, r2, r3, r4)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static int BtZpQjynNwXjqpAu(java.lang.string r1) {
            goto Lc
        L4:
            int r0 = r1.GetHashCode()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void BtZpQjynNwXjqpAu(java.lang.string r0, byte r1, char r2, bool r3, short r4) {
            goto L1f
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r0 = 42
            goto L4
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            goto L22
        L1f:
            goto L27
        L22:
            goto L10
        L26:
            return
        L27:
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void BtZpQjynNwXjqpAu(java.lang.string r0, short r1, byte r2, bool r3, char r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L1c
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r0 = 42
            goto L24
        L1c:
            goto L7
        L1f:
            double r0 = (double) r3
            goto Lb
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void BtZpQjynNwXjqpAu(java.lang.string r0, bool r1, byte r2, char r3, short r4) {
            goto L29
        L4:
            return
        L5:
            goto L21
        L9:
            int r3 = r2 + r1
            goto L24
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto L9
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto L4
        L29:
            goto L5
        L2c:
            goto Lf
    }

    public static void JdxlMPqMgjYSwkkc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, int r1, short r2, float r3, bool r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L21
        Ld:
            r0 = 42
            goto L13
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L19:
            double r0 = (double) r3
            goto L25
        L1e:
            goto L26
        L21:
            goto Ld
        L25:
            return
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void JdxlMPqMgjYSwkkc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, int r1, bool r2, float r3, short r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            goto L26
        Ld:
            int r3 = r2 + r1
            goto L18
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r2 = r0 * r1
            goto Ld
        L23:
            goto L14
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static void JdxlMPqMgjYSwkkc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, bool r1, int r2, short r3, float r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            int r3 = r2 + r1
            goto L20
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            goto L7
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r0 = 42
            goto L17
        L2b:
            return
        L2c:
            goto L1d
    }

    public static bool JdxlMPqMgjYSwkkc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r1) {
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
            bool r0 = r1.isDefaultProcess()
            goto Le
    }

    public static java.lang.stringBuilder JsgfHTnuDdNfNXHB(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void JsgfHTnuDdNfNXHB(java.lang.stringBuilder r0, java.lang.string r1, char r2, short r3, bool r4, int r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto Lb
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void JsgfHTnuDdNfNXHB(java.lang.stringBuilder r0, java.lang.string r1, char r2, bool r3, short r4, int r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L1d
        L12:
            goto L2a
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L21
    }

    public static void JsgfHTnuDdNfNXHB(java.lang.stringBuilder r0, java.lang.string r1, bool r2, short r3, int r4, char r5) {
            goto L29
        L4:
            return
        L5:
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L1e
        L15:
            r0 = 42
            goto L9
        L1b:
            goto L2c
        L1e:
            int r3 = r2 + r1
            goto L24
        L24:
            double r0 = (double) r3
            goto L4
        L29:
            goto L5
        L2c:
            goto L15
    }

    public static java.lang.stringBuilder NvdArslWtDpEpXdA(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void NvdArslWtDpEpXdA(java.lang.stringBuilder r0, java.lang.string r1, byte r2, int r3, char r4, short r5) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            int r2 = r0 * r1
            goto L22
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L29
        L1e:
            goto Lf
        L22:
            int r3 = r2 + r1
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static void NvdArslWtDpEpXdA(java.lang.stringBuilder r0, java.lang.string r1, int r2, byte r3, char r4, short r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            return
        Lb:
            goto L15
        Lf:
            r0 = 42
            goto L18
        L15:
            goto L2c
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L4
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto Lf
    }

    public static void NvdArslWtDpEpXdA(java.lang.stringBuilder r0, java.lang.string r1, int r2, short r3, char r4, byte r5) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            goto L21
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto L2a
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static java.lang.stringBuilder VdfHxomLtOjVkVQJ(java.lang.stringBuilder r1, bool r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void VdfHxomLtOjVkVQJ(java.lang.stringBuilder r0, bool r1, int r2, short r3, bool r4, java.lang.string r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L14
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            int r2 = r0 * r1
            goto Le
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            return
        L26:
            goto Lb
        L2a:
            r0 = 42
            goto L1f
    }

    public static void VdfHxomLtOjVkVQJ(java.lang.stringBuilder r0, bool r1, bool r2, int r3, short r4, java.lang.string r5) {
            goto L15
        L4:
            return
        L5:
            goto L22
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            r0 = 42
            goto L25
        L15:
            goto L5
        L18:
            goto Lf
        L1c:
            int r2 = r0 * r1
            goto L9
        L22:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void VdfHxomLtOjVkVQJ(java.lang.stringBuilder r0, bool r1, bool r2, java.lang.string r3, int r4, short r5) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r0 = 42
            goto L19
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static int FYOcPXdGYEhZzycm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.getPid()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void FYOcPXdGYEhZzycm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, char r1, bool r2, int r3, short r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            int r2 = r0 * r1
            goto L27
        L11:
            return
        L12:
            goto L2d
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L7
    }

    public static void FYOcPXdGYEhZzycm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, bool r1, int r2, short r3, char r4) {
            goto L13
        L4:
            goto L16
        L7:
            r0 = 42
            goto L2a
        Ld:
            int r3 = r2 + r1
            goto L20
        L13:
            goto L26
        L16:
            goto L7
        L1a:
            int r2 = r0 * r1
            goto Ld
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void FYOcPXdGYEhZzycm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, bool r1, short r2, char r3, int r4) {
            goto L18
        L4:
            r0 = 42
            goto L12
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L1b
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L18:
            goto L2c
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto La
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto Lf
    }

    public static java.lang.stringBuilder GwqKHmbEfehjyvtv(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void GwqKHmbEfehjyvtv(java.lang.stringBuilder r0, java.lang.string r1, byte r2, java.lang.string r3, char r4, bool r5) {
            goto L19
        L4:
            goto L1c
        L7:
            int r2 = r0 * r1
            goto L13
        Ld:
            r0 = 42
            goto L25
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            goto L21
        L1c:
            goto Ld
        L20:
            return
        L21:
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void GwqKHmbEfehjyvtv(java.lang.stringBuilder r0, java.lang.string r1, char r2, java.lang.string r3, byte r4, bool r5) {
            goto L4
        L4:
            goto L14
        L7:
            goto L24
        Lb:
            double r0 = (double) r3
            goto L13
        L10:
            goto L7
        L13:
            return
        L14:
            goto L10
        L18:
            int r3 = r2 + r1
            goto Lb
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static void GwqKHmbEfehjyvtv(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, bool r3, char r4, byte r5) {
            goto L20
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L27
        Lf:
            return
        L10:
            goto L2d
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            r0 = 42
            goto L14
        L20:
            goto L10
        L23:
            goto L1a
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L23
    }

    public static java.lang.stringBuilder LpDCRopcDGhMrrci(java.lang.stringBuilder r1, int r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void LpDCRopcDGhMrrci(java.lang.stringBuilder r0, int r1, byte r2, short r3, java.lang.string r4, bool r5) {
            goto L1d
        L4:
            r0 = 42
            goto L17
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L20
        L12:
            double r0 = (double) r3
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto Lb
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void LpDCRopcDGhMrrci(java.lang.stringBuilder r0, int r1, byte r2, short r3, bool r4, java.lang.string r5) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L1e
        L10:
            return
        L11:
            goto L15
        L15:
            goto L27
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            goto L11
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void LpDCRopcDGhMrrci(java.lang.stringBuilder r0, int r1, java.lang.string r2, byte r3, bool r4, short r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto L1c
        Lf:
            goto L2c
        L12:
            goto L25
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1c:
            int r3 = r2 + r1
            goto L4
        L22:
            goto L12
        L25:
            r0 = 42
            goto L16
        L2b:
            return
        L2c:
            goto L22
    }

    public static java.lang.string MQUaEWvGTirwNGiT(java.lang.stringBuilder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.tostring()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void MQUaEWvGTirwNGiT(java.lang.stringBuilder r0, byte r1, bool r2, int r3, short r4) {
            goto L4
        L4:
            goto L23
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L1c
        L11:
            double r0 = (double) r3
            goto L22
        L16:
            int r2 = r0 * r1
            goto L27
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            return
        L23:
            goto L2d
        L27:
            int r3 = r2 + r1
            goto L11
        L2d:
            goto L7
    }

    public static void MQUaEWvGTirwNGiT(java.lang.stringBuilder r0, short r1, int r2, bool r3, byte r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L21
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            r0 = 42
            goto L13
    }

    public static void MQUaEWvGTirwNGiT(java.lang.stringBuilder r0, bool r1, byte r2, int r3, short r4) {
            goto L14
        L4:
            r0 = 42
            goto L24
        La:
            return
        Lb:
            goto L1b
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L4
        L1b:
            goto L17
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static java.lang.string NMqNUZVadyOtulsW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r1) {
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
            java.lang.string r0 = r1.getProcessName()
            goto Lb
    }

    public static void NMqNUZVadyOtulsW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, short r1, float r2, char r3, bool r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            r0 = 42
            goto L25
        L1b:
            goto L2c
        L1e:
            goto L15
        L22:
            goto L1e
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2b:
            return
        L2c:
            goto L22
    }

    public static void NMqNUZVadyOtulsW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, short r1, bool r2, char r3, float r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L17
        Ld:
            goto L1b
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L27
        L1b:
            r0 = 42
            goto L4
        L21:
            int r3 = r2 + r1
            goto L11
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static void NMqNUZVadyOtulsW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, bool r1, char r2, short r3, float r4) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            r0 = 42
            goto L4
        L1c:
            double r0 = (double) r3
            goto L21
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L16
        L2d:
            goto L29
    }

    public static java.lang.stringBuilder PCvJsvNJAUQfLmxz(java.lang.stringBuilder r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void PCvJsvNJAUQfLmxz(java.lang.stringBuilder r0, int r1, char r2, float r3, short r4, bool r5) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            int r3 = r2 + r1
            goto L1e
        L13:
            return
        L14:
            goto L4
        L18:
            int r2 = r0 * r1
            goto Ld
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            r0 = 42
            goto L7
        L29:
            goto L14
        L2c:
            goto L23
    }

    public static void PCvJsvNJAUQfLmxz(java.lang.stringBuilder r0, int r1, char r2, float r3, bool r4, short r5) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L18
        L15:
            goto L21
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto Lb
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r0 = 42
            goto L4
    }

    public static void PCvJsvNJAUQfLmxz(java.lang.stringBuilder r0, int r1, bool r2, float r3, char r4, short r5) {
            goto L4
        L4:
            goto L23
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L11:
            r0 = 42
            goto Lb
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            int r3 = r2 + r1
            goto L17
        L2d:
            goto L7
    }

    public static int PQVMSkHmYBnwwbMl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r1) {
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
            int r0 = r1.getImportance()
            goto L4
        L18:
            goto Lc
    }

    public static void PQVMSkHmYBnwwbMl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, byte r1, float r2, int r3, java.lang.string r4) {
            goto La
        L4:
            r0 = 42
            goto L17
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            int r3 = r2 + r1
            goto L20
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1d:
            goto Ld
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L11
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void PQVMSkHmYBnwwbMl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, float r1, java.lang.string r2, byte r3, int r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            r0 = 42
            goto L4
        L10:
            goto L26
        L13:
            goto La
        L17:
            int r2 = r0 * r1
            goto L2a
        L1d:
            double r0 = (double) r3
            goto L25
        L22:
            goto L13
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L1d
    }

    public static void PQVMSkHmYBnwwbMl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, int r1, java.lang.string r2, byte r3, float r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1d
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L26
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1d:
            r0 = 42
            goto L17
        L23:
            goto L7
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static java.lang.stringBuilder QPflMwURFSWdaaiD(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void QPflMwURFSWdaaiD(java.lang.stringBuilder r0, java.lang.string r1, byte r2, bool r3, char r4, int r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            goto L12
        Ld:
            goto L2a
        L11:
            return
        L12:
            goto L27
        L16:
            int r3 = r2 + r1
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            goto Ld
        L2a:
            r0 = 42
            goto L4
    }

    public static void QPflMwURFSWdaaiD(java.lang.stringBuilder r0, java.lang.string r1, char r2, int r3, bool r4, byte r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L2a
        L15:
            goto L26
        L18:
            int r2 = r0 * r1
            goto L9
        L1e:
            return
        L1f:
            goto L15
        L23:
            goto L1f
        L26:
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void QPflMwURFSWdaaiD(java.lang.stringBuilder r0, java.lang.string r1, bool r2, byte r3, int r4, char r5) {
            goto L1d
        L4:
            goto L20
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L12
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L8
        L20:
            goto L24
        L24:
            r0 = 42
            goto L17
        L2a:
            int r2 = r0 * r1
            goto Lc
    }

    public static void RbliaEoKaTvkUnif(java.lang.string r0, java.lang.object r1, char r2, byte r3, int r4, java.lang.string r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L25
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto Lb
    }

    public static void RbliaEoKaTvkUnif(java.lang.string r0, java.lang.object r1, char r2, java.lang.string r3, byte r4, int r5) {
            goto L23
        L4:
            return
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L17:
            int r3 = r2 + r1
            goto Lc
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L11
    }

    public static void RbliaEoKaTvkUnif(java.lang.string r0, java.lang.object r1, int r2, byte r3, java.lang.string r4, char r5) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L1c
        L16:
            r0 = 42
            goto L2a
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto Lc
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static bool RbliaEoKaTvkUnif(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.Equals(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder YLShzcwMbzGKuNdB(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static void YLShzcwMbzGKuNdB(java.lang.stringBuilder r0, java.lang.string r1, char r2, byte r3, java.lang.string r4, float r5) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            int r2 = r0 * r1
            goto L27
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L23
        L1e:
            goto L15
        L22:
            return
        L23:
            goto L2d
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L1e
    }

    public static void YLShzcwMbzGKuNdB(java.lang.stringBuilder r0, java.lang.string r1, float r2, java.lang.string r3, char r4, byte r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            goto L21
        Ld:
            goto L1a
        L11:
            goto Ld
        L14:
            int r3 = r2 + r1
            goto L2b
        L1a:
            r0 = 42
            goto L25
        L20:
            return
        L21:
            goto L11
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void YLShzcwMbzGKuNdB(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, byte r3, float r4, char r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L17
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L21:
            goto Ld
        L24:
            r0 = 42
            goto L1b
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public bool Equals(java.lang.object r5) {
            r4 = this;
            goto L91
        L4:
            goto L2f
        L7:
            goto Ld7
        Lb:
            com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails r5 = (com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails) r5
            goto Laa
        L11:
            int r3 = fYOcPXdGYEhZzycm(r5)
            goto L7c
        L19:
            r2 = 0
            goto La1
        L1e:
            return r2
        L1f:
            goto L4
        L23:
            if (r1 == r3) goto L28
            goto L6f
        L28:
            goto L85
        L2c:
            goto L1f
        L2f:
            goto Lc7
        L33:
            bool r1 = rbliaEoKaTvkUnif(r1, r3)
            goto L41
        L3b:
            bool r1 = r5 is com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails
            goto L19
        L41:
            if (r1 != 0) goto L46
            goto L6f
        L46:
            goto Lb0
        L4a:
            int r3 = pQVMSkHmYBnwwbMl(r5)
            goto L23
        L52:
            r0 = 24
            goto L67
        L59:
            java.lang.string r3 = nMqNUZVadyOtulsW(r5)
            goto L33
        L61:
            int r1 = r4.importance
            goto L4a
        L67:
            r1 = 17
            goto Ld1
        L6e:
            return r0
        L6f:
            goto L1e
        L73:
            if (r4 == r5) goto L78
            goto L6f
        L78:
            goto L6e
        L7c:
            if (r1 == r3) goto L81
            goto L6f
        L81:
            goto L61
        L85:
            bool r4 = r4.defaultProcess
            goto Lbf
        L8b:
            int r0 = r0 % r1
            goto L98
        L91:
            goto L7
        L94:
            goto L52
        L98:
            if (r0 <= 0) goto L9d
            goto L2f
        L9d:
            goto L2c
        La1:
            if (r1 != 0) goto La6
            goto L6f
        La6:
            goto Lb
        Laa:
            java.lang.string r1 = r4.processName
            goto L59
        Lb0:
            int r1 = r4.pid
            goto L11
        Lb6:
            if (r5 == r4) goto Lbb
            goto Lcd
        Lbb:
            goto Lcc
        Lbf:
            bool r5 = JdxlMPqMgjYSwkkc(r5)
            goto L73
        Lc7:
            r0 = 1
            goto Lb6
        Lcc:
            return r0
        Lcd:
            goto L3b
        Ld1:
            int r0 = r0 + r1
            goto L8b
        Ld7:
            goto L94
    }

    @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails
    public int GetImportance() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r0.importance
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails
    public int GetPid() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            int r0 = r0.pid
            goto L14
        L14:
            return r0
        L15:
            goto L4
    }

    @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails
    public java.lang.string GetProcessName() {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto Lf
        L9:
            java.lang.string r0 = r0.processName
            goto L4
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
    }

    public int HashCode() {
            r3 = this;
            goto L4
        L4:
            goto L77
        L7:
            goto L39
        Lb:
            int r0 = r0 * r1
            goto L6e
        L10:
            goto L95
        L13:
            goto L28
        L17:
            r0 = r0 ^ r2
            goto L9e
        L1c:
            r3 = 1237(0x4d5, float:1.733E-42)
        L1e:
            goto L99
        L22:
            r3 = 1231(0x4cf, float:1.725E-42)
            goto L69
        L28:
            java.lang.string r0 = r3.processName
            goto L31
        L2e:
            goto L7
        L31:
            int r0 = BtZpQjynNwXjqpAu(r0)
            goto L7b
        L39:
            r0 = 28
            goto L88
        L40:
            int r2 = r3.importance
            goto L52
        L46:
            int r0 = r0 + r1
            goto L4c
        L4c:
            int r0 = r0 % r1
            goto L57
        L52:
            r0 = r0 ^ r2
            goto Lb
        L57:
            if (r0 <= 0) goto L5c
            goto L13
        L5c:
            goto L10
        L60:
            if (r3 != 0) goto L65
            goto L6a
        L65:
            goto L22
        L69:
            goto L1e
        L6a:
            goto L1c
        L6e:
            bool r3 = r3.defaultProcess
            goto L60
        L74:
            goto L13
        L77:
            goto L2e
        L7b:
            r1 = 1000003(0xf4243, float:1.401303E-39)
            goto La3
        L82:
            int r2 = r3.pid
            goto L17
        L88:
            r1 = 8
            goto L46
        L8f:
            int r0 = r0 * r1
            goto L82
        L94:
            return r3
        L95:
            goto L74
        L99:
            r3 = r3 ^ r0
            goto L94
        L9e:
            int r0 = r0 * r1
            goto L40
        La3:
            r0 = r0 ^ r1
            goto L8f
    }

    @Override // com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails
    public bool IsDefaultProcess() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            bool r0 = r0.defaultProcess
            goto L14
        L14:
            return r0
        L15:
            goto L4
    }

    public java.lang.string Tostring() {
            r2 = this;
            goto L70
        L4:
            bool r2 = r2.defaultProcess
            goto L15
        La:
            java.lang.stringBuilder r0 = lpDCRopcDGhMrrci(r0, r1)
            goto L53
        L12:
            goto L73
        L15:
            java.lang.stringBuilder r2 = VdfHxomLtOjVkVQJ(r0, r2)
            goto L77
        L1d:
            java.lang.string r1 = ", pid="
            goto L2b
        L23:
            java.lang.stringBuilder r0 = pCvJsvNJAUQfLmxz(r0, r1)
            goto L85
        L2b:
            java.lang.stringBuilder r0 = yLShzcwMbzGKuNdB(r0, r1)
            goto L6a
        L33:
            int r1 = r2.importance
            goto L23
        L39:
            java.lang.string r1 = "ProcessDetails{processName="
            goto L8b
        L3f:
            goto L4f
        L42:
            goto L12
        L46:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L39
        L4c:
            goto L93
        L4f:
            goto L46
        L53:
            java.lang.string r1 = ", importance="
            goto Lc7
        L59:
            if (r0 <= 0) goto L5e
            goto L4f
        L5e:
            goto L4c
        L62:
            java.lang.stringBuilder r0 = JsgfHTnuDdNfNXHB(r0, r1)
            goto L1d
        L6a:
            int r1 = r2.pid
            goto La
        L70:
            goto L42
        L73:
            goto Lc0
        L77:
            java.lang.string r0 = "}"
            goto L7d
        L7d:
            java.lang.stringBuilder r2 = gwqKHmbEfehjyvtv(r2, r0)
            goto Lb2
        L85:
            java.lang.string r1 = ", defaultProcess="
            goto Laa
        L8b:
            r0.<init>(r1)
            goto L9d
        L92:
            return r2
        L93:
            goto L3f
        L97:
            int r0 = r0 % r1
            goto L59
        L9d:
            java.lang.string r1 = r2.processName
            goto L62
        La3:
            r1 = 11
            goto Lba
        Laa:
            java.lang.stringBuilder r0 = NvdArslWtDpEpXdA(r0, r1)
            goto L4
        Lb2:
            java.lang.string r2 = mQUaEWvGTirwNGiT(r2)
            goto L92
        Lba:
            int r0 = r0 + r1
            goto L97
        Lc0:
            r0 = 25
            goto La3
        Lc7:
            java.lang.stringBuilder r0 = qPflMwURFSWdaaiD(r0, r1)
            goto L33
    }
}

