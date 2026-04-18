namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.chauthai.swipereveallayout.R */
/* JADX INFO: loaded from: classes5.dex */
public readonly class C1107R {

    /* JADX INFO: renamed from: com.chauthai.swipereveallayout.R$attr */
    public static readonly class attr {
        public static readonly int dragEdge = 2130968983;
        public static readonly int flingVelocity = 2130969076;
        public static readonly int minDistRequestDisallowParent = 2130969423;
        public static readonly int mode = 2130969435;

        private attr() {
                r0 = this;
                goto Lb
            L4:
                r0.<init>()
                goto L12
            Lb:
                goto L13
            Le:
                goto L4
            L12:
                return
            L13:
                goto L17
            L17:
                goto Le
        }
    }

    /* JADX INFO: renamed from: com.chauthai.swipereveallayout.R$id */
    public static readonly class id {
        public static readonly int bottom = 2131361968;
        public static readonly int left = 2131362579;
        public static readonly int normal = 2131362700;
        public static readonly int right = 2131362935;
        public static readonly int same_level = 2131362954;
        public static readonly int top = 2131363213;

        private id() {
                r0 = this;
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
                r0.<init>()
                goto Le
        }
    }

    /* JADX INFO: renamed from: com.chauthai.swipereveallayout.R$styleable */
    public static readonly class styleable {
        public static readonly int[] SwipeRevealLayout = null;
        public static readonly int SwipeRevealLayout_dragEdge = 0;
        public static readonly int SwipeRevealLayout_flingVelocity = 1;
        public static readonly int SwipeRevealLayout_minDistRequestDisallowParent = 2;
        public static readonly int SwipeRevealLayout_mode = 3;

        static {
                goto L38
            L4:
                if (r0 <= 0) goto L9
                goto L10
            L9:
                goto Ld
            Ld:
                goto L2d
            L10:
                goto L67
            L14:
                int r0 = r0 + r1
                goto L5b
            L1a:
                r3 = 2130969076(0x7f0401f4, float:1.7546824E38)
                goto L24
            L21:
                goto L3b
            L24:
                int[] r0 = new int[]{r2, r3, r0, r1}
                goto L61
            L2c:
                return
            L2d:
                goto L54
            L31:
                r1 = 2130969435(0x7f04035b, float:1.7547552E38)
                goto L46
            L38:
                goto L57
            L3b:
                goto L4d
            L3f:
                r1 = 15
                goto L14
            L46:
                r2 = 2130968983(0x7f040197, float:1.7546635E38)
                goto L1a
            L4d:
                r0 = 10
                goto L3f
            L54:
                goto L10
            L57:
                goto L21
            L5b:
                int r0 = r0 % r1
                goto L4
            L61:
                com.chauthai.swipereveallayout.C1107R.styleable.SwipeRevealLayout = r0
                goto L2c
            L67:
                r0 = 2130969423(0x7f04034f, float:1.7547527E38)
                goto L31
        }

        private styleable() {
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
    }

    private C1107R() {
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

