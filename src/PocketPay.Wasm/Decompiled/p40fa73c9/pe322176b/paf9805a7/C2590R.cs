namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: p40fa73c9.pe322176b.paf9805a7.R */
/* JADX INFO: loaded from: classes8.dex */
public readonly class C2590R {

    /* JADX INFO: renamed from: p40fa73c9.pe322176b.paf9805a7.R$attr */
    public static readonly class attr {
        public static readonly int el_duration = 2130969007;
        public static readonly int el_expanded = 2130969008;
        public static readonly int el_parallax = 2130969009;

        private attr() {
                r0 = this;
                goto Le
            L4:
                r0.<init>()
                goto L15
            Lb:
                goto L11
            Le:
                goto L16
            L11:
                goto L4
            L15:
                return
            L16:
                goto Lb
        }
    }

    /* JADX INFO: renamed from: p40fa73c9.pe322176b.paf9805a7.R$styleable */
    public static readonly class styleable {
        public static readonly int[] ExpandableLayout = null;
        public static readonly int ExpandableLayout_android_orientation = 0;
        public static readonly int ExpandableLayout_el_duration = 1;
        public static readonly int ExpandableLayout_el_expanded = 2;
        public static readonly int ExpandableLayout_el_parallax = 3;

        static {
                goto L56
            L4:
                r3 = 2130969007(0x7f0401af, float:1.7546684E38)
                goto L4e
            Lb:
                p40fa73c9.pe322176b.paf9805a7.C2590R.styleable.ExpandableLayout = r0
                goto L18
            L11:
                r0 = 2130969008(0x7f0401b0, float:1.7546686E38)
                goto L47
            L18:
                return
            L19:
                goto L33
            L1d:
                if (r0 <= 0) goto L22
                goto L43
            L22:
                goto L40
            L26:
                int r0 = r0 % r1
                goto L1d
            L2c:
                r1 = 27
                goto L3a
            L33:
                goto L43
            L36:
                goto L64
            L3a:
                int r0 = r0 + r1
                goto L26
            L40:
                goto L19
            L43:
                goto L11
            L47:
                r1 = 2130969009(0x7f0401b1, float:1.7546688E38)
                goto L5d
            L4e:
                int[] r0 = new int[]{r2, r3, r0, r1}
                goto Lb
            L56:
                goto L36
            L59:
                goto L67
            L5d:
                r2 = 16842948(0x10100c4, float:2.3694107E-38)
                goto L4
            L64:
                goto L59
            L67:
                r0 = 25
                goto L2c
        }

        private styleable() {
                r0 = this;
                goto L4
            L4:
                goto L13
            L7:
                goto Lb
            Lb:
                r0.<init>()
                goto L12
            L12:
                return
            L13:
                goto L17
            L17:
                goto L7
        }
    }

    private C2590R() {
            r0 = this;
            goto L13
        L4:
            r0.<init>()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }
}

