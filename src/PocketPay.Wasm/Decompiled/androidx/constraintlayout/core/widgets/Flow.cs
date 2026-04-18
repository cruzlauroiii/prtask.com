namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
public class Flow : androidx.constraintlayout.core.widgets.VirtualLayout {
    public static readonly int HORIZONTAL_ALIGN_CENTER = 2;
    public static readonly int HORIZONTAL_ALIGN_END = 1;
    public static readonly int HORIZONTAL_ALIGN_START = 0;
    public static readonly int VERTICAL_ALIGN_BASELINE = 3;
    public static readonly int VERTICAL_ALIGN_BOTTOM = 1;
    public static readonly int VERTICAL_ALIGN_CENTER = 2;
    public static readonly int VERTICAL_ALIGN_TOP = 0;
    public static readonly int WRAP_ALIGNED = 2;
    public static readonly int WRAP_CHAIN = 1;
    public static readonly int WRAP_CHAIN_NEW = 3;
    public static readonly int WRAP_NONE = 0;
    private androidx.constraintlayout.core.widgets.ConstraintWidget[] mAlignedBiggestElementsInCols;
    private androidx.constraintlayout.core.widgets.ConstraintWidget[] mAlignedBiggestElementsInRows;
    private int[] mAlignedDimensions;
    private java.util.List<androidx.constraintlayout.core.widgets.Flow.WidgetsList> mChainList;
    private androidx.constraintlayout.core.widgets.ConstraintWidget[] mDisplayedWidgets;
    private int mDisplayedWidgetsCount;
    private float mFirstHorizontalBias;
    private int mFirstHorizontalStyle;
    private float mFirstVerticalBias;
    private int mFirstVerticalStyle;
    private int mHorizontalAlign;
    private float mHorizontalBias;
    private int mHorizontalGap;
    private int mHorizontalStyle;
    private float mLastHorizontalBias;
    private int mLastHorizontalStyle;
    private float mLastVerticalBias;
    private int mLastVerticalStyle;
    private int mMaxElementsWrap;
    private int mOrientation;
    private int mVerticalAlign;
    private float mVerticalBias;
    private int mVerticalGap;
    private int mVerticalStyle;
    private int mWrapMode;

    private class WidgetsList {
        private androidx.constraintlayout.core.widgets.ConstraintWidget mBiggest;
        int mBiggestDimension;
        private androidx.constraintlayout.core.widgets.ConstraintAnchor mBottom;
        private int mCount;
        private int mHeight;
        private androidx.constraintlayout.core.widgets.ConstraintAnchor mLeft;
        private int mMax;
        private int mNbMatchConstraintsWidgets;
        private int mOrientation;
        private int mPaddingBottom;
        private int mPaddingLeft;
        private int mPaddingRight;
        private int mPaddingTop;
        private androidx.constraintlayout.core.widgets.ConstraintAnchor mRight;
        private int mStartIndex;
        private androidx.constraintlayout.core.widgets.ConstraintAnchor mTop;
        private int mWidth;
        readonly /* synthetic */ androidx.constraintlayout.core.widgets.Flow this$0;

        WidgetsList(androidx.constraintlayout.core.widgets.Flow r2, int r3, androidx.constraintlayout.core.widgets.ConstraintAnchor r4, androidx.constraintlayout.core.widgets.ConstraintAnchor r5, androidx.constraintlayout.core.widgets.ConstraintAnchor r6, androidx.constraintlayout.core.widgets.ConstraintAnchor r7, int r8) {
                r1 = this;
                goto L9a
            L4:
                r1.mPaddingRight = r3
                goto L4f
            La:
                int r3 = r2.getPaddingTop()
                goto L3d
            L12:
                r1.mBottom = r7
                goto Lad
            L18:
                goto L9d
            L1b:
                r1.this$0 = r2
                goto Lc7
            L21:
                r1.mPaddingLeft = r0
                goto L5d
            L27:
                r1.mStartIndex = r0
                goto L57
            L2d:
                r1.mHeight = r0
                goto L27
            L33:
                r0 = 0
                goto L63
            L38:
                return
            L39:
                goto L18
            L3d:
                r1.mPaddingTop = r3
                goto L86
            L43:
                r1.mPaddingBottom = r0
                goto Lc1
            L49:
                r1.mNbMatchConstraintsWidgets = r0
                goto L7a
            L4f:
                int r2 = r2.getPaddingBottom()
                goto La7
            L57:
                r1.mCount = r0
                goto L49
            L5d:
                r1.mPaddingTop = r0
                goto L8e
            L63:
                r1.mBiggestDimension = r0
                goto L21
            L69:
                r0 = 0
                goto Lb5
            L6e:
                r1.mRight = r6
                goto L12
            L74:
                r1.mTop = r5
                goto L6e
            L7a:
                r1.mMax = r0
                goto La1
            L80:
                r1.mLeft = r4
                goto L74
            L86:
                int r3 = r2.getPaddingRight()
                goto L4
            L8e:
                r1.mPaddingRight = r0
                goto L43
            L94:
                r1.mPaddingLeft = r3
                goto La
            L9a:
                goto L39
            L9d:
                goto L1b
            La1:
                r1.mOrientation = r3
                goto L80
            La7:
                r1.mPaddingBottom = r2
                goto Lbb
            Lad:
                int r3 = r2.getPaddingLeft()
                goto L94
            Lb5:
                r1.mBiggest = r0
                goto L33
            Lbb:
                r1.mMax = r8
                goto L38
            Lc1:
                r1.mWidth = r0
                goto L2d
            Lc7:
                r1.<init>()
                goto L69
        }

        static /* synthetic */ androidx.constraintlayout.core.widgets.ConstraintWidget access$2000(androidx.constraintlayout.core.widgets.Flow.WidgetsList r0) {
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
                androidx.constraintlayout.core.widgets.ConstraintWidget r0 = r0.mBiggest
                goto L7
        }

        private void RecomputeDimensions() {
                r9 = this;
                goto L16f
            L4:
                r6 = r0
            L5:
                goto Lac
            L9:
                r9.mBiggest = r3
                goto L192
            Lf:
                if (r0 <= 0) goto L14
                goto L1b3
            L14:
                goto L1b0
            L18:
                int r5 = r5 + r4
                goto L28
            L1d:
                int r3 = r9.mStartIndex
                goto L23
            L23:
                int r3 = r3 + r2
                goto L81
            L28:
                r9.mWidth = r5
                goto L163
            L2e:
                r0 = 8
                goto L1c3
            L35:
                return
            L36:
                goto L40
            L3a:
                int r7 = r9.mMax
                goto L11a
            L40:
                goto L1b3
            L43:
                goto Lcb
            L47:
                r9.mBiggestDimension = r4
                goto L107
            L4d:
                int r2 = r2 + 1
                goto Ldc
            L53:
                androidx.constraintlayout.core.widgets.ConstraintWidget r5 = r9.mBiggest
                goto L198
            L59:
                int r4 = r3.getWidth()
                goto L169
            L61:
                r7 = r0
            L62:
                goto L1ed
            L66:
                int r6 = r9.mMax
                goto L87
            L6c:
                int r1 = r9.mCount
                goto L1df
            L72:
                int r0 = r0 % r1
                goto Lf
            L78:
                if (r5 < r4) goto L7d
                goto L15f
            L7d:
                goto L9
            L81:
                androidx.constraintlayout.core.widgets.Flow r4 = r9.this$0
                goto Lff
            L87:
                int r4 = androidx.constraintlayout.core.widgets.Flow.access$200(r4, r3, r6)
                goto L1d9
            L8f:
                int r5 = r9.mBiggestDimension
                goto L78
            L95:
                goto Lde
            L97:
                goto La1
            L9b:
                r9.mWidth = r0
                goto L181
            La1:
                androidx.constraintlayout.core.widgets.Flow r3 = r9.this$0
                goto Le2
            La7:
                r1 = 0
                goto L13c
            Lac:
                int r5 = r9.mWidth
                goto Ld7
            Lb2:
                int r4 = r4 + r2
                goto L1d3
            Lb7:
                int r4 = r9.mStartIndex
                goto Lb2
            Lbd:
                int r4 = r9.mOrientation
                goto L1bd
            Lc3:
                int r6 = androidx.constraintlayout.core.widgets.Flow.access$000(r6)
                goto L112
            Lcb:
                goto L172
            Lce:
                if (r7 == r5) goto Ld3
                goto L5
            Ld3:
                goto L4
            Ld7:
                int r4 = r4 + r6
                goto L18
            Ldc:
                goto L1e0
            Lde:
                goto L35
            Le2:
                androidx.constraintlayout.core.widgets.ConstraintWidget[] r3 = androidx.constraintlayout.core.widgets.Flow.access$500(r3)
                goto Lb7
            Lea:
                if (r5 != 0) goto Lef
                goto L7d
            Lef:
                goto L8f
            Lf3:
                r9.mBiggest = r3
                goto L47
            Lf9:
                androidx.constraintlayout.core.widgets.Flow r7 = r9.this$0
                goto L122
            Lff:
                int r4 = androidx.constraintlayout.core.widgets.Flow.access$400(r4)
                goto L1ca
            L107:
                r9.mHeight = r4
                goto L18d
            L10d:
                int r5 = r5 + r6
                goto L157
            L112:
                int r7 = r3.getVisibility()
                goto Lce
            L11a:
                int r6 = androidx.constraintlayout.core.widgets.Flow.access$300(r6, r3, r7)
                goto Lf9
            L122:
                int r7 = androidx.constraintlayout.core.widgets.Flow.access$100(r7)
                goto L142
            L12a:
                if (r5 < r4) goto L12f
                goto L15f
            L12f:
                goto Lf3
            L133:
                if (r4 == 0) goto L138
                goto L18e
            L138:
                goto L59
            L13c:
                r9.mBiggest = r1
                goto L1f3
            L142:
                int r8 = r3.getVisibility()
                goto L1e4
            L14a:
                int r4 = androidx.constraintlayout.core.widgets.Flow.access$300(r4, r3, r5)
                goto L53
            L152:
                int r6 = r6 + r7
                goto L10d
            L157:
                r9.mHeight = r5
                goto L1f9
            L15d:
                r9.mWidth = r4
            L15f:
                goto L4d
            L163:
                androidx.constraintlayout.core.widgets.Flow r4 = r9.this$0
                goto L1b7
            L169:
                androidx.constraintlayout.core.widgets.Flow r6 = r9.this$0
                goto Lc3
            L16f:
                goto L43
            L172:
                goto L2e
            L176:
                int r5 = r9.mBiggestDimension
                goto L12a
            L17c:
                r0 = 0
                goto L9b
            L181:
                r9.mHeight = r0
                goto La7
            L187:
                int r0 = r0 + r1
                goto L72
            L18d:
                goto L15f
            L18e:
                goto L1a1
            L192:
                r9.mBiggestDimension = r4
                goto L15d
            L198:
                if (r5 != 0) goto L19d
                goto L12f
            L19d:
                goto L176
            L1a1:
                androidx.constraintlayout.core.widgets.Flow r4 = r9.this$0
                goto L66
            L1a7:
                if (r2 < r1) goto L1ac
                goto Lde
            L1ac:
                goto L1d
            L1b0:
                goto L36
            L1b3:
                goto L17c
            L1b7:
                int r5 = r9.mMax
                goto L14a
            L1bd:
                r5 = 8
                goto L133
            L1c3:
                r1 = 32
                goto L187
            L1ca:
                if (r3 >= r4) goto L1cf
                goto L97
            L1cf:
                goto L95
            L1d3:
                r3 = r3[r4]
                goto Lbd
            L1d9:
                androidx.constraintlayout.core.widgets.Flow r6 = r9.this$0
                goto L3a
            L1df:
                r2 = r0
            L1e0:
                goto L1a7
            L1e4:
                if (r8 == r5) goto L1e9
                goto L62
            L1e9:
                goto L61
            L1ed:
                int r5 = r9.mHeight
                goto L152
            L1f3:
                r9.mBiggestDimension = r0
                goto L6c
            L1f9:
                androidx.constraintlayout.core.widgets.ConstraintWidget r5 = r9.mBiggest
                goto Lea
        }

        public void Add(androidx.constraintlayout.core.widgets.ConstraintWidget r7) {
                r6 = this;
                goto L191
            L4:
                goto La0
            L7:
                goto L39
            Lb:
                r6.mNbMatchConstraintsWidgets = r3
                goto L19d
            L11:
                int r1 = r6.mMax
                goto Lff
            L17:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r4 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
                goto L86
            L1d:
                int r1 = r6.mHeight
                goto L1ed
            L23:
                r0 = r2
            L24:
                goto L33
            L28:
                int r1 = r1 + r0
                goto L1b4
            L2d:
                androidx.constraintlayout.core.widgets.ConstraintWidget r1 = r6.mBiggest
                goto Ldc
            L33:
                androidx.constraintlayout.core.widgets.Flow r3 = r6.this$0
                goto Lb8
            L39:
                goto L194
            L3c:
                if (r4 == r1) goto L41
                goto Lc1
            L41:
                goto Lc0
            L45:
                r6.mCount = r7
                goto L11c
            L4b:
                if (r1 < r0) goto L50
                goto L131
            L50:
                goto L1ae
            L54:
                androidx.constraintlayout.core.widgets.Flow r3 = r6.this$0
                goto L10d
            L5a:
                r6.mNbMatchConstraintsWidgets = r0
                goto L23
            L60:
                int r3 = r6.mNbMatchConstraintsWidgets
                goto L97
            L66:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r5 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
                goto L158
            L6c:
                goto L131
            L6e:
                goto L1ba
            L72:
                int r0 = r0 + 1
                goto L5a
            L78:
                r2 = r4
            L79:
                goto L1d
            L7d:
                if (r1 < r0) goto L82
                goto L131
            L82:
                goto Lf9
            L86:
                if (r3 == r4) goto L8b
                goto L24
            L8b:
                goto L172
            L8f:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r4 = r7.getVerticalDimensionBehaviour()
                goto L66
            L97:
                int r3 = r3 + 1
                goto Lb
            L9d:
                goto L11d
            La0:
                goto L143
            La4:
                r6.mBiggestDimension = r0
                goto L12f
            Laa:
                goto L79
            Lab:
                goto L78
            Laf:
                if (r1 != 0) goto Lb4
                goto L82
            Lb4:
                goto Lf3
            Lb8:
                int r3 = androidx.constraintlayout.core.widgets.Flow.access$000(r3)
                goto L1d3
            Lc0:
                goto Lcc
            Lc1:
                goto Lcb
            Lc5:
                androidx.constraintlayout.core.widgets.ConstraintWidget r1 = r6.mBiggest
                goto Laf
            Lcb:
                r2 = r3
            Lcc:
                goto L1f2
            Ld0:
                int r0 = r0 % r1
                goto Le5
            Ld6:
                androidx.constraintlayout.core.widgets.Flow r4 = r6.this$0
                goto L127
            Ldc:
                if (r1 != 0) goto Le1
                goto L50
            Le1:
                goto L161
            Le5:
                if (r0 <= 0) goto Lea
                goto La0
            Lea:
                goto L9d
            Lee:
                r2 = 0
                goto L113
            Lf3:
                int r1 = r6.mBiggestDimension
                goto L7d
            Lf9:
                r6.mBiggest = r7
                goto La4
            Lff:
                int r0 = androidx.constraintlayout.core.widgets.Flow.access$300(r0, r7, r1)
                goto L2d
            L107:
                int r7 = r6.mCount
                goto L121
            L10d:
                int r4 = r6.mMax
                goto L150
            L113:
                if (r0 == 0) goto L118
                goto L6e
            L118:
                goto L1e1
            L11c:
                return
            L11d:
                goto L4
            L121:
                int r7 = r7 + 1
                goto L45
            L127:
                int r4 = androidx.constraintlayout.core.widgets.Flow.access$100(r4)
                goto L178
            L12f:
                r6.mWidth = r0
            L131:
                goto L107
            L135:
                r6.mHeight = r0
                goto L6c
            L13b:
                int r0 = androidx.constraintlayout.core.widgets.Flow.access$200(r0, r7, r3)
                goto L54
            L143:
                int r0 = r6.mOrientation
                goto L1e7
            L149:
                r0 = 25
                goto L1cc
            L150:
                int r3 = androidx.constraintlayout.core.widgets.Flow.access$300(r3, r7, r4)
                goto L8f
            L158:
                if (r4 == r5) goto L15d
                goto L19e
            L15d:
                goto L60
            L161:
                int r1 = r6.mBiggestDimension
                goto L4b
            L167:
                r6.mHeight = r1
                goto Lc5
            L16d:
                int r1 = r1 + r3
                goto L167
            L172:
                int r0 = r6.mNbMatchConstraintsWidgets
                goto L72
            L178:
                int r5 = r7.getVisibility()
                goto L180
            L180:
                if (r5 == r1) goto L185
                goto Lab
            L185:
                goto Laa
            L189:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r3 = r7.getHorizontalDimensionBehaviour()
                goto L17
            L191:
                goto L7
            L194:
                goto L149
            L198:
                int r0 = r0 + r2
                goto L28
            L19d:
                r3 = r2
            L19e:
                goto Ld6
            L1a2:
                int r3 = r6.mMax
                goto L1f8
            L1a8:
                androidx.constraintlayout.core.widgets.Flow r0 = r6.this$0
                goto L11
            L1ae:
                r6.mBiggest = r7
                goto L1db
            L1b4:
                r6.mWidth = r1
                goto L1a8
            L1ba:
                androidx.constraintlayout.core.widgets.Flow r0 = r6.this$0
                goto L1c0
            L1c0:
                int r3 = r6.mMax
                goto L13b
            L1c6:
                int r0 = r0 + r1
                goto Ld0
            L1cc:
                r1 = 26
                goto L1c6
            L1d3:
                int r4 = r7.getVisibility()
                goto L3c
            L1db:
                r6.mBiggestDimension = r0
                goto L135
            L1e1:
                androidx.constraintlayout.core.widgets.Flow r0 = r6.this$0
                goto L1a2
            L1e7:
                r1 = 8
                goto Lee
            L1ed:
                int r3 = r3 + r2
                goto L16d
            L1f2:
                int r1 = r6.mWidth
                goto L198
            L1f8:
                int r0 = androidx.constraintlayout.core.widgets.Flow.access$200(r0, r7, r3)
                goto L189
        }

        public void Clear() {
                r2 = this;
                goto L4
            L4:
                goto L55
            L7:
                goto L34
            Lb:
                r2.mNbMatchConstraintsWidgets = r0
                goto L4d
            L11:
                int r0 = r0 + r1
                goto L3b
            L17:
                if (r0 <= 0) goto L1c
                goto L61
            L1c:
                goto L5e
            L20:
                goto L7
            L23:
                r2.mHeight = r0
                goto L47
            L29:
                r1 = 0
                goto L2e
            L2e:
                r2.mBiggest = r1
                goto L72
            L34:
                r0 = 9
                goto L65
            L3b:
                int r0 = r0 % r1
                goto L17
            L41:
                r2.mCount = r0
                goto Lb
            L47:
                r2.mStartIndex = r0
                goto L41
            L4d:
                return
            L4e:
                goto L52
            L52:
                goto L61
            L55:
                goto L20
            L59:
                r0 = 0
                goto L6c
            L5e:
                goto L4e
            L61:
                goto L59
            L65:
                r1 = 6
                goto L11
            L6c:
                r2.mBiggestDimension = r0
                goto L29
            L72:
                r2.mWidth = r0
                goto L23
        }

        public void CreateConstraints(bool r18, int r19, bool r20) {
                r17 = this;
                goto L91b
            L4:
                int r4 = r4 + r3
                goto L39c
            L9:
                goto L70d
            Lb:
                goto L505
            Lf:
                r10.setVerticalBiasPercent(r12)
            L12:
                goto Lab1
            L16:
                int r10 = r10 + 1
                goto L6c1
            L1c:
                int r12 = r1 + (-1)
                goto Lfb
            L22:
                r9 = r10
            L23:
                goto L8af
            L27:
                androidx.constraintlayout.core.widgets.ConstraintWidget r6 = r6.mOwner
                goto L1e8
            L2d:
                int r10 = r10 + r9
                goto L94a
            L32:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mLeft
                goto L51d
            L38:
                goto L377
            L3a:
                goto Lb47
            L3e:
                androidx.constraintlayout.core.widgets.Flow r10 = r0.this$0
                goto L45e
            L44:
                if (r13 != r5) goto L49
                goto L59a
            L49:
                goto L511
            L4d:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mRight
                goto L81a
            L53:
                if (r13 >= r14) goto L58
                goto L4a5
            L58:
                goto L4a4
            L5c:
                r10.connect(r11, r12)
            L5f:
                goto La84
            L63:
                androidx.constraintlayout.core.widgets.Flow r10 = r0.this$0
                goto L7b6
            L69:
                int r13 = r13 + r12
                goto L1ff
            L6e:
                r3.connect(r11, r2)
                goto L9d3
            L75:
                goto L879
            L77:
                goto L878
            L7b:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mLeft
                goto L32
            L81:
                int r11 = r0.mPaddingLeft
                goto Lad4
            L87:
                if (r10 == r3) goto L8c
                goto L4d1
            L8c:
                goto L607
            L90:
                int r13 = r0.mStartIndex
                goto L69
            L96:
                if (r1 != 0) goto L9b
                goto L629
            L9b:
                goto L677
            L9f:
                int r15 = androidx.constraintlayout.core.widgets.Flow.access$1000(r15)
                goto L956
            La7:
                int r11 = r11 + r6
                goto L7be
            Lac:
                if (r19 > 0) goto Lb1
                goto L70d
            Lb1:
                goto L4f9
            Lb5:
                r14 = r9
                goto L9bf
            Lba:
                int r6 = r6 + 1
                goto L199
            Lc0:
                int r3 = androidx.constraintlayout.core.widgets.Flow.access$1200(r3)
                goto L3fd
            Lc8:
                r6.connect(r10, r11)
            Lcb:
                goto Le0
            Lcf:
                int r13 = r0.mPaddingTop
                goto L1a5
            Ld5:
                int r5 = r5 + r3
                goto L2fa
            Lda:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r10.mBottom
                goto L38a
            Le0:
                if (r19 > 0) goto Le5
                goto L70d
            Le5:
                goto L9b9
            Le9:
                float r11 = r11 - r13
                goto L950
            Lee:
                r6.connect(r10, r2)
                goto L9
            Lf5:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L10f
            Lfb:
                int r12 = r12 - r10
                goto L88d
            L100:
                int r15 = r0.mStartIndex
                goto L1c6
            L106:
                if (r14 != r6) goto L10b
                goto L7b2
            L10b:
                goto L76e
            L10f:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$600(r11)
                goto L3bd
            L117:
                int r0 = r0 + r1
                goto La79
            L11d:
                r12 = 1
                goto L4e1
            L122:
                r10.connect(r11, r6)
                goto L59e
            L129:
                if (r15 == 0) goto L12e
                goto L9ef
            L12e:
                goto La6a
            L132:
                int r11 = r0.mStartIndex
                goto La7
            L138:
                androidx.constraintlayout.core.widgets.Flow r14 = r0.this$0
                goto L472
            L13e:
                int r13 = androidx.constraintlayout.core.widgets.Flow.access$1700(r13)
                goto L729
            L146:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L9ab
            L14c:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r0.mTop
                goto L384
            L152:
                int r13 = androidx.constraintlayout.core.widgets.Flow.access$1500(r13)
                goto L44
            L15a:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mRight
                goto La26
            L160:
                int r13 = r0.mPaddingBottom
                goto L64e
            L166:
                goto L2b1
            L168:
                goto L6bb
            L16c:
                int r15 = r0.mStartIndex
                goto L129
            L172:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mRight
                goto L984
            L178:
                if (r14 >= r15) goto L17d
                goto Labf
            L17d:
                goto Labd
            L181:
                goto L805
            L183:
                goto L804
            L187:
                r12 = r13[r14]
                goto L7ef
            L18d:
                r16 = 1
                goto L73a
            L193:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L640
            L199:
                goto Lb1b
            L19b:
                goto L797
            L19f:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L344
            L1a5:
                r3.connect(r11, r13)
                goto L635
            L1ac:
                bool r3 = r14.hasBaseline()
                goto L48c
            L1b4:
                if (r10 == 0) goto L1b9
                goto L445
            L1b9:
                goto L5bc
            L1bd:
                if (r10 == r11) goto L1c2
                goto L445
            L1c2:
                goto L231
            L1c6:
                int r15 = r15 + r13
                goto L556
            L1cb:
                int r6 = androidx.constraintlayout.core.widgets.Flow.access$800(r6)
                goto Laa3
            L1d3:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$400(r11)
                goto L9fa
            L1db:
                r6 = r2
                goto L8d2
            L1e0:
                float r13 = androidx.constraintlayout.core.widgets.Flow.access$1100(r13)
            L1e4:
                goto Le9
            L1e8:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r6.mLeft
                goto L929
            L1ee:
                androidx.constraintlayout.core.widgets.Flow r3 = r0.this$0
                goto La36
            L1f4:
                r12 = r6
            L1f5:
                goto L2b0
            L1f9:
                goto L44b
            L1fb:
                goto L9c4
            L1ff:
                androidx.constraintlayout.core.widgets.Flow r14 = r0.this$0
                goto L95f
            L205:
                androidx.constraintlayout.core.widgets.Flow r6 = r0.this$0
                goto L1cb
            L20b:
                goto L1e4
            L20c:
                goto L6e2
            L210:
                int r13 = r13 - r10
                goto L181
            L215:
                int r10 = androidx.constraintlayout.core.widgets.Flow.access$700(r10)
                goto L8e4
            L21d:
                androidx.constraintlayout.core.widgets.Flow r10 = r0.this$0
                goto L215
            L223:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L1e0
            L229:
                int r5 = androidx.constraintlayout.core.widgets.Flow.access$400(r5)
                goto L3d2
            L231:
                bool r10 = r6.hasBaseline()
                goto L1b4
            L239:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r0.mRight
                goto Lb5a
            L23f:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r12.mBaseline
                goto L96d
            L245:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mRight
                goto La4d
            L24b:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L86a
            L251:
                if (r14 != r12) goto L256
                goto L501
            L256:
                goto L1ac
            L25a:
                int r14 = r14 + r13
                goto L58c
            L25f:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r12 = r0.mTop
                goto L621
            L265:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r6.mTop
                goto L2ed
            L26b:
                if (r18 != 0) goto L270
                goto L183
            L270:
                goto L3db
            L274:
                r11.connect(r12, r10)
                goto L9ca
            L27b:
                if (r18 != 0) goto L280
                goto L88f
            L280:
                goto L1c
            L284:
                androidx.constraintlayout.core.widgets.Flow r3 = r0.this$0
                goto L62d
            L28a:
                r4 = r2
            L28b:
                goto La92
            L28f:
                goto L91e
            L292:
                int r3 = r3 + 1
                goto L517
            L298:
                goto L44b
            L29a:
                goto L50b
            L29e:
                if (r6 == r11) goto L2a3
                goto L925
            L2a3:
                goto L5ed
            L2a7:
                if (r10 < r1) goto L2ac
                goto L629
            L2ac:
                goto L26b
            L2b0:
                r10 = r2
            L2b1:
                goto L2a7
            L2b5:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r12 = r10.mTop
                goto L4d5
            L2bb:
                r6.connect(r10, r11)
            L2be:
                goto Lac
            L2c2:
                r16 = 1
                goto L390
            L2c8:
                int r11 = r0.mPaddingBottom
                goto L922
            L2ce:
                if (r10 == r7) goto L2d3
                goto Lad7
            L2d3:
                goto L6f8
            L2d7:
                goto L28b
            L2d8:
                goto L28a
            L2dc:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L33c
            L2e2:
                androidx.constraintlayout.core.widgets.Flow r12 = r0.this$0
                goto L82f
            L2e8:
                goto L340
            L2e9:
                goto L751
            L2ed:
                r3.connect(r11, r2)
                goto L7b0
            L2f4:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mRight
                goto L172
            L2fa:
                r4 = r4[r5]
                goto Lb0c
            L300:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r6.mTop
                goto L6e
            L306:
                int r13 = r0.mPaddingBottom
                goto L5d2
            L30c:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mBaseline
                goto L23f
            L312:
                if (r18 != 0) goto L317
                goto L1fb
            L317:
                goto L193
            L31b:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r3.mLeft
                goto L70a
            L321:
                if (r3 != r11) goto L326
                goto L3a
            L326:
                goto L5c9
            L32a:
                r16 = 1
            L32c:
                goto La58
            L330:
                androidx.constraintlayout.core.widgets.Flow r15 = r0.this$0
                goto L52a
            L336:
                goto La16
            L338:
                goto L7b
            L33c:
                float r11 = androidx.constraintlayout.core.widgets.Flow.access$1100(r11)
            L340:
                goto L661
            L344:
                androidx.constraintlayout.core.widgets.ConstraintWidget[] r13 = androidx.constraintlayout.core.widgets.Flow.access$500(r13)
                goto L7c4
            L34c:
                if (r0 <= 0) goto L351
                goto L35e
            L351:
                goto L35b
            L355:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r10.mTop
                goto L7d0
            L35b:
                goto Lb16
            L35e:
                goto L79d
            L362:
                androidx.constraintlayout.core.widgets.ConstraintWidget r6 = r6.mOwner
                goto L5b0
            L368:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mTop
                goto Lcf
            L36e:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$400(r11)
                goto Lb25
            L376:
                r9 = 3
            L377:
                goto L16
            L37b:
                if (r11 != r12) goto L380
                goto L969
            L380:
                goto L711
            L384:
                androidx.constraintlayout.core.widgets.ConstraintWidget r10 = r10.mOwner
                goto Lda
            L38a:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r6.mTop
                goto L784
            L390:
                int r11 = r8 + 1
                goto L29e
            L396:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r6.mBottom
                goto La0f
            L39c:
                androidx.constraintlayout.core.widgets.Flow r5 = r0.this$0
                goto L229
            L3a2:
                r11 = r16
                goto L321
            L3a8:
                if (r10 == 0) goto L3ad
                goto L594
            L3ad:
                goto L524
            L3b1:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r6.mTop
                goto La09
            L3b7:
                int r10 = r10 + 1
                goto L443
            L3bd:
                androidx.constraintlayout.core.widgets.Flow r12 = r0.this$0
                goto L413
            L3c3:
                float r13 = androidx.constraintlayout.core.widgets.Flow.access$900(r13)
                goto L8a6
            L3cb:
                r6.setVerticalChainStyle(r10)
                goto L758
            L3d2:
                if (r4 >= r5) goto L3d7
                goto L64a
            L3d7:
                goto L648
            L3db:
                int r13 = r1 + (-1)
                goto L210
            L3e1:
                if (r11 != r12) goto L3e6
                goto L488
            L3e6:
                goto Lac3
            L3ea:
                int r11 = r0.mStartIndex
                goto L63b
            L3f0:
                androidx.constraintlayout.core.widgets.Flow r3 = r0.this$0
                goto L732
            L3f6:
                r0 = 5
                goto Lb34
            L3fd:
                if (r18 != 0) goto L402
                goto L20c
            L402:
                goto L24b
            L406:
                r3.setGoneMargin(r9)
            L409:
                goto L106
            L40d:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mRight
                goto Lb65
            L413:
                float r12 = androidx.constraintlayout.core.widgets.Flow.access$1400(r12)
                goto L4ed
            L41b:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$1700(r11)
                goto L49e
            L423:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r10.mBottom
                goto L601
            L429:
                goto L1f5
            L42b:
                goto L3b7
            L42f:
                r4.resetAnchors()
            L432:
                goto L292
            L436:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r6.mBottom
                goto L5fa
            L43c:
                r10.connect(r11, r12, r13)
                goto Lf5
            L443:
                goto L5bd
            L445:
                goto L1f4
            L449:
                goto La16
            L44b:
                goto La15
            L44f:
                goto L629
            L451:
                goto L5d9
            L455:
                if (r13 == 0) goto L45a
                goto L59a
            L45a:
                goto L704
            L45e:
                int r10 = androidx.constraintlayout.core.widgets.Flow.access$600(r10)
                goto L3cb
            L466:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L41b
            L46c:
                int r3 = r1 + (-1)
                goto L87
            L472:
                androidx.constraintlayout.core.widgets.ConstraintWidget[] r14 = androidx.constraintlayout.core.widgets.Flow.access$500(r14)
                goto L100
            L47a:
                androidx.constraintlayout.core.widgets.Flow r10 = r0.this$0
                goto L6e8
            L480:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r9.mRight
                goto Lb41
            L486:
                goto La16
            L488:
                goto L9b3
            L48c:
                if (r3 != 0) goto L491
                goto L501
            L491:
                goto L30c
            L495:
                if (r9 != 0) goto L49a
                goto L409
            L49a:
                goto L92f
            L49e:
                androidx.constraintlayout.core.widgets.Flow r12 = r0.this$0
                goto L4a9
            L4a4:
                goto L445
            L4a5:
                goto L19f
            L4a9:
                float r12 = androidx.constraintlayout.core.widgets.Flow.access$1800(r12)
            L4ad:
                goto L6b4
            L4b1:
                int r10 = r0.mStartIndex
                goto L8b5
            L4b7:
                float r13 = r11 - r13
            L4b9:
                goto L16c
            L4bd:
                r10.connect(r11, r6)
                goto L5a7
            L4c4:
                int r10 = r10 + r11
            L4c5:
                goto L3b1
            L4c9:
                r2 = 0
                goto La53
            L4ce:
                r14.connect(r3, r11, r13)
            L4d1:
                goto L495
            L4d5:
                r11.connect(r12, r2)
                goto L2c2
            L4dc:
                r9 = 2
                goto L312
            L4e1:
                goto L23
            L4e3:
                goto La61
            L4e7:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r6.mBottom
                goto L6d5
            L4ed:
                int r13 = r0.mStartIndex
                goto L455
            L4f3:
                int r12 = r0.mPaddingTop
                goto Laaa
            L4f9:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r0.mRight
                goto L27
            L4ff:
                goto L377
            L501:
                goto L3f0
            L505:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r3.mLeft
                goto L820
            L50b:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mLeft
                goto L855
            L511:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L7fc
            L517:
                goto La54
            L519:
                goto L96
            L51d:
                r9.connect(r11, r2)
                goto L837
            L524:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r15 = r14.mLeft
                goto L18d
            L52a:
                int r15 = androidx.constraintlayout.core.widgets.Flow.access$1200(r15)
                goto L843
            L532:
                int r4 = r0.mStartIndex
                goto L4
            L538:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r3.mRight
                goto L5b6
            L53e:
                if (r3 != 0) goto L543
                goto L618
            L543:
                goto L3a2
            L547:
                if (r14 == 0) goto L54c
                goto L93d
            L54c:
                goto Lb5
            L550:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L13e
            L556:
                r14 = r14[r15]
                goto L547
            L55c:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mLeft
                goto Lb3b
            L562:
                if (r6 == r7) goto L567
                goto Laad
            L567:
                goto Lae1
            L56b:
                int r9 = r9.getVisibility()
                goto L826
            L573:
                r7 = r6
            L574:
                goto L5e8
            L578:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L3c3
            L57e:
                r6 = r2
            L57f:
                goto L6cc
            L583:
                if (r20 != 0) goto L588
                goto L2e9
            L588:
                goto L330
            L58c:
                androidx.constraintlayout.core.widgets.Flow r15 = r0.this$0
                goto L809
            L592:
                goto L32c
            L594:
                goto L32a
            L598:
                goto L4ad
            L59a:
                goto L884
            L59e:
                if (r20 != 0) goto L5a3
                goto L2be
            L5a3:
                goto L791
            L5a7:
                if (r20 != 0) goto L5ac
                goto Lcb
            L5ac:
                goto L893
            L5b0:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r6.mRight
                goto L31b
            L5b6:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mRight
                goto L122
            L5bc:
                r10 = r2
            L5bd:
                goto L9d9
            L5c1:
                bool r3 = r12.hasBaseline()
                goto L941
            L5c9:
                if (r4 != 0) goto L5ce
                goto Ladd
            L5ce:
                goto Laf0
            L5d2:
                r10.connect(r11, r12, r13)
            L5d5:
                goto L994
            L5d9:
                androidx.constraintlayout.core.widgets.Flow r10 = r0.this$0
                goto L71a
            L5df:
                if (r18 != 0) goto L5e4
                goto L952
            L5e4:
                goto L223
            L5e8:
                r8 = r6
            L5e9:
                goto Lba
            L5ed:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r9.mBottom
                goto L2c8
            L5f3:
                r3.connect(r11, r2)
                goto L6fe
            L5fa:
                r3.connect(r11, r2)
                goto L616
            L601:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r12 = r0.mBottom
                goto L306
            L607:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mRight
                goto L4d
            L60d:
                if (r4 != 0) goto L612
                goto L338
            L612:
                goto La1a
            L616:
                goto L377
            L618:
                goto La9d
            L61c:
                r12 = 1
                goto L37b
            L621:
                int r13 = r0.mPaddingTop
                goto L43c
            L627:
                goto L57f
            L629:
                goto Lb15
            L62d:
                int r3 = androidx.constraintlayout.core.widgets.Flow.access$1000(r3)
                goto L5df
            L635:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mBottom
                goto La97
            L63b:
                int r11 = r11 + r9
                goto L9e2
            L640:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$1900(r11)
                goto L75e
            L648:
                goto L519
            L64a:
                goto L8de
            L64e:
                r3.connect(r11, r13)
                goto Ladb
            L655:
                int r13 = r0.mPaddingRight
                goto L7a3
            L65b:
                androidx.constraintlayout.core.widgets.Flow r3 = r0.this$0
                goto Lc0
            L661:
                r13 = r11
                goto L9ed
            L666:
                if (r6 == r11) goto L66b
                goto L5d5
            L66b:
                goto L423
            L66f:
                float r11 = androidx.constraintlayout.core.widgets.Flow.access$1300(r11)
                goto L2e8
            L677:
                androidx.constraintlayout.core.widgets.ConstraintWidget r3 = r0.mBiggest
                goto L974
            L67d:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mLeft
                goto L7aa
            L683:
                r9.connect(r11, r13)
                goto L40d
            L68a:
                r14.connect(r15, r3, r11)
                goto L592
            L691:
                if (r10 == r3) goto L696
                goto L409
            L696:
                goto L480
            L69a:
                int r9 = r9 - r6
                goto L75
            L69f:
                if (r13 != 0) goto L6a4
                goto L42b
            L6a4:
                goto L429
            L6a8:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mLeft
                goto L915
            L6ae:
                goto L629
            L6b0:
                goto La3e
            L6b4:
                r10.setVerticalChainStyle(r11)
                goto Lf
            L6bb:
                androidx.constraintlayout.core.widgets.ConstraintWidget r3 = r0.mBiggest
                goto L205
            L6c1:
                r11 = r9
                goto Lb71
            L6c6:
                r11 = 1065353216(0x3f800000, float:1.0)
                goto L578
            L6cc:
                if (r6 < r1) goto L6d1
                goto L629
            L6d1:
                goto L4b1
            L6d5:
                r3.connect(r11, r2)
                goto L38
            L6dc:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r0.mLeft
                goto L85b
            L6e2:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L66f
            L6e8:
                int r10 = androidx.constraintlayout.core.widgets.Flow.access$000(r10)
                goto L7e1
            L6f0:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$1900(r11)
                goto La70
            L6f8:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mLeft
                goto L81
            L6fe:
                int r3 = r8 + 1
                goto L691
            L704:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L152
            L70a:
                r6.connect(r10, r2)
            L70d:
                goto L57e
            L711:
                if (r11 != r9) goto L716
                goto L29a
            L716:
                goto L298
            L71a:
                androidx.constraintlayout.core.widgets.ConstraintWidget[] r10 = androidx.constraintlayout.core.widgets.Flow.access$500(r10)
                goto L132
            L722:
                r11.connect(r12, r13)
                goto L562
            L729:
                if (r13 != r5) goto L72e
                goto L4ad
            L72e:
                goto L466
            L732:
                int r3 = androidx.constraintlayout.core.widgets.Flow.access$700(r3)
                goto L53e
            L73a:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r0.mLeft
                goto La47
            L740:
                if (r9 != 0) goto L745
                goto L5e9
            L745:
                goto L56b
            L749:
                int r13 = androidx.constraintlayout.core.widgets.Flow.access$000(r13)
                goto L767
            L751:
                r14.setHorizontalChainStyle(r3)
                goto L87d
            L758:
                int r10 = r0.mPaddingTop
                goto L8f4
            L75e:
                if (r11 != 0) goto L763
                goto La22
            L763:
                goto L61c
            L767:
                r3.connect(r11, r13)
                goto L2ce
            L76e:
                androidx.constraintlayout.core.widgets.Flow r3 = r0.this$0
                goto Lacc
            L774:
                r9.connect(r11, r2)
                goto L2f4
            L77b:
                if (r6 == 0) goto L780
                goto L168
            L780:
                goto L7db
            L784:
                r10.connect(r11, r2)
            L787:
                goto L21d
            L78b:
                int r14 = r0.mStartIndex
                goto L25a
            L791:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r3.mLeft
                goto L6dc
            L797:
                int r6 = r0.mOrientation
                goto La8d
            L79d:
                r0 = r17
                goto L7ca
            L7a3:
                r9.connect(r11, r13)
                goto L336
            L7aa:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mLeft
                goto L97d
            L7b0:
                goto L377
            L7b2:
                goto L376
            L7b6:
                androidx.constraintlayout.core.widgets.ConstraintWidget[] r10 = androidx.constraintlayout.core.widgets.Flow.access$500(r10)
                goto L3ea
            L7be:
                r10 = r10[r11]
                goto L811
            L7c4:
                int r14 = r0.mStartIndex
                goto Lb60
            L7ca:
                int r1 = r0.mCount
                goto L4c9
            L7d0:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r12 = r9.mBottom
                goto L146
            L7d6:
                r4 = 1
                goto L2d7
            L7db:
                androidx.constraintlayout.core.widgets.ConstraintWidget r6 = r0.mBiggest
                goto L3e
            L7e1:
                int r6 = r6 + r10
            L7e2:
                goto L903
            L7e6:
                if (r6 < r1) goto L7eb
                goto L19b
            L7eb:
                goto L90c
            L7ef:
                bool r13 = r12.hasBaseline()
                goto L69f
            L7f7:
                r12 = 1
                goto L3e1
            L7fc:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$1500(r11)
                goto L2e2
            L804:
                r13 = r10
            L805:
                goto L78b
            L809:
                int r15 = androidx.constraintlayout.core.widgets.Flow.access$400(r15)
                goto L178
            L811:
                if (r10 == 0) goto L816
                goto L4e3
            L816:
                goto L11d
            L81a:
                int r13 = r0.mPaddingRight
                goto L4ce
            L820:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mLeft
                goto L4bd
            L826:
                if (r9 == 0) goto L82b
                goto L5e9
            L82b:
                goto L861
            L82f:
                float r12 = androidx.constraintlayout.core.widgets.Flow.access$1600(r12)
                goto L598
            L837:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mRight
                goto L99d
            L83d:
                int r5 = r0.mStartIndex
                goto Ld5
            L843:
                if (r15 != r5) goto L848
                goto L2e9
            L848:
                goto L65b
            L84c:
                if (r10 != r3) goto L851
                goto L44b
            L851:
                goto L4dc
            L855:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mLeft
                goto L774
            L85b:
                int r11 = r0.mPaddingRight
                goto L2bb
            L861:
                if (r7 == r5) goto L866
                goto L574
            L866:
                goto L573
            L86a:
                float r13 = androidx.constraintlayout.core.widgets.Flow.access$1300(r13)
                goto L20b
            L872:
                goto L19b
            L874:
                goto L63
            L878:
                r9 = r6
            L879:
                goto Lb1f
            L87d:
                r14.setHorizontalBiasPercent(r13)
            L880:
                goto L46c
            L884:
                if (r20 != 0) goto L889
                goto L4ad
            L889:
                goto L550
            L88d:
                goto L9e9
            L88f:
                goto L9e8
            L893:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r3.mRight
                goto L239
            L899:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r9.mBottom
                goto L2b5
            L89f:
                goto L35e
            L8a2:
                goto L28f
            L8a6:
                if (r18 != 0) goto L8ab
                goto L4b9
            L8ab:
                goto L4b7
            L8af:
                int r6 = r6 + 1
                goto L627
            L8b5:
                int r10 = r10 + r6
                goto L8ba
            L8ba:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L1d3
            L8c0:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r9.mRight
                goto L935
            L8c6:
                int r6 = r0.mPaddingLeft
                goto Lb03
            L8cc:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r10.mTop
                goto L25f
            L8d2:
                r7 = r5
                goto Lb1a
            L8d7:
                r9.connect(r11, r2)
                goto L449
            L8de:
                androidx.constraintlayout.core.widgets.Flow r4 = r0.this$0
                goto L9a3
            L8e4:
                r11 = 3
                goto L1bd
            L8e9:
                r9 = 3
                goto La2d
            L8ee:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto Lafb
            L8f4:
                if (r19 > 0) goto L8f9
                goto L4c5
            L8f9:
                goto L8ee
            L8fd:
                goto La16
            L8ff:
                goto L60d
            L903:
                if (r18 != 0) goto L908
                goto Lb
            L908:
                goto L538
            L90c:
                if (r18 != 0) goto L911
                goto L77
            L911:
                goto Lb4d
            L915:
                int r13 = r0.mPaddingLeft
                goto L683
            L91b:
                goto L8a2
            L91e:
                goto L3f6
            L922:
                r9.setGoneMargin(r11)
            L925:
                goto L84c
            L929:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r3.mRight
                goto Lee
            L92f:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mLeft
                goto L8c0
            L935:
                androidx.constraintlayout.core.widgets.Flow r13 = r0.this$0
                goto L749
            L93b:
                goto L377
            L93d:
                goto L3a8
            L941:
                if (r3 != 0) goto L946
                goto L501
            L946:
                goto L251
            L94a:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L36e
            L950:
                goto L340
            L952:
                goto L2dc
            L956:
                if (r15 != r5) goto L95b
                goto L9ef
            L95b:
                goto L284
            L95f:
                int r14 = androidx.constraintlayout.core.widgets.Flow.access$400(r14)
                goto L53
            L967:
                goto L44b
            L969:
                goto L67d
            L96d:
                r3.connect(r11, r2)
                goto L4ff
            L974:
                if (r3 == 0) goto L979
                goto L6b0
            L979:
                goto L6ae
            L97d:
                r9.connect(r11, r2)
                goto La20
            L984:
                r9.connect(r11, r2)
                goto L967
            L98b:
                if (r19 == 0) goto L990
                goto L2d8
            L990:
                goto L7d6
            L994:
                if (r9 != 0) goto L999
                goto L925
            L999:
                goto L355
            L99d:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mRight
                goto L9f3
            L9a3:
                androidx.constraintlayout.core.widgets.ConstraintWidget[] r4 = androidx.constraintlayout.core.widgets.Flow.access$500(r4)
                goto L83d
            L9ab:
                int r13 = androidx.constraintlayout.core.widgets.Flow.access$100(r13)
                goto L722
            L9b3:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mRight
                goto L15a
            L9b9:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r0.mLeft
                goto L362
            L9bf:
                r9 = r11
                goto L93b
            L9c4:
                androidx.constraintlayout.core.widgets.Flow r11 = r0.this$0
                goto L6f0
            L9ca:
                if (r20 != 0) goto L9cf
                goto L5f
            L9cf:
                goto L396
            L9d3:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mBottom
                goto L4e7
            L9d9:
                if (r10 < r1) goto L9de
                goto L445
            L9de:
                goto L27b
            L9e2:
                r9 = r10[r11]
                goto L740
            L9e8:
                r12 = r10
            L9e9:
                goto L90
            L9ed:
                goto L2e9
            L9ef:
                goto L583
            L9f3:
                r9.connect(r11, r2)
                goto L486
            L9fa:
                if (r10 >= r11) goto L9ff
                goto L451
            L9ff:
                goto L44f
            La03:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mTop
                goto L300
            La09:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r12 = r0.mTop
                goto L274
            La0f:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mBottom
                goto Lab7
            La15:
                r12 = 1
            La16:
                goto L22
            La1a:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r10.mLeft
                goto L6a8
            La20:
                goto L44b
            La22:
                goto L245
            La26:
                r9.connect(r11, r2)
                goto La7f
            La2d:
                if (r3 == r9) goto La32
                goto L501
            La32:
                goto L5c1
            La36:
                int r3 = androidx.constraintlayout.core.widgets.Flow.access$800(r3)
                goto L6c6
            La3e:
                if (r20 != 0) goto La43
                goto L2d8
            La43:
                goto L98b
            La47:
                int r11 = r0.mPaddingLeft
                goto L68a
            La4d:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mRight
                goto Lb53
            La53:
                r3 = r2
            La54:
                goto Lae7
            La58:
                if (r13 == 0) goto La5d
                goto L880
            La5d:
                goto L1ee
            La61:
                if (r6 == 0) goto La66
                goto L12
            La66:
                goto L8cc
            La6a:
                androidx.constraintlayout.core.widgets.Flow r15 = r0.this$0
                goto L9f
            La70:
                if (r11 != 0) goto La75
                goto La80
            La75:
                goto L7f7
            La79:
                int r0 = r0 % r1
                goto L34c
            La7f:
                goto La16
            La80:
                goto Laf6
            La84:
                if (r19 > 0) goto La89
                goto L787
            La89:
                goto L14c
            La8d:
                r9 = 0
                goto L77b
            La92:
                r5 = -1
                goto L1db
            La97:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mBottom
                goto L160
            La9d:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mTop
                goto L265
            Laa3:
                r3.setHorizontalChainStyle(r6)
                goto L8c6
            Laaa:
                r11.setGoneMargin(r12)
            Laad:
                goto L899
            Lab1:
                int r11 = r1 + (-1)
                goto L666
            Lab7:
                int r12 = r0.mPaddingBottom
                goto L5c
            Labd:
                goto L629
            Labf:
                goto L138
            Lac3:
                if (r11 != r9) goto Lac8
                goto L8ff
            Lac8:
                goto L8fd
            Lacc:
                int r3 = androidx.constraintlayout.core.widgets.Flow.access$700(r3)
                goto L8e9
            Lad4:
                r3.setGoneMargin(r11)
            Lad7:
                goto Lb6b
            Ladb:
                goto L377
            Ladd:
                goto La03
            Lae1:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r10.mTop
                goto L4f3
            Lae7:
                if (r3 < r1) goto Laec
                goto L519
            Laec:
                goto L532
            Laf0:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mTop
                goto L368
            Laf6:
                r12 = 1
                goto L55c
            Lafb:
                int r11 = androidx.constraintlayout.core.widgets.Flow.access$100(r11)
                goto L4c4
            Lb03:
                if (r19 > 0) goto Lb08
                goto L7e2
            Lb08:
                goto L47a
            Lb0c:
                if (r4 != 0) goto Lb11
                goto L432
            Lb11:
                goto L42f
            Lb15:
                return
            Lb16:
                goto L89f
            Lb1a:
                r8 = r7
            Lb1b:
                goto L7e6
            Lb1f:
                int r10 = r0.mStartIndex
                goto L2d
            Lb25:
                if (r10 >= r11) goto Lb2a
                goto L874
            Lb2a:
                goto L872
            Lb2e:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r14.mLeft
                goto L5f3
            Lb34:
                r1 = 16
                goto L117
            Lb3b:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r3.mLeft
                goto L8d7
            Lb41:
                int r9 = r0.mPaddingRight
                goto L406
            Lb47:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r14.mBottom
                goto L436
            Lb4d:
                int r9 = r1 + (-1)
                goto L69a
            Lb53:
                r9.connect(r11, r2)
                goto L1f9
            Lb5a:
                int r11 = r0.mPaddingRight
                goto Lc8
            Lb60:
                int r14 = r14 + r12
                goto L187
            Lb65:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r0.mRight
                goto L655
            Lb6b:
                androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r9.mRight
                goto Lb2e
            Lb71:
                r9 = r14
                goto L166
        }

        public int GetHeight() {
                r2 = this;
                goto L1a
            L4:
                int r2 = r2.mHeight
                goto L21
            La:
                r1 = 21
                goto L54
            L11:
                if (r0 == r1) goto L16
                goto L62
            L16:
                goto L4e
            L1a:
                goto L5d
            L1d:
                goto L66
            L21:
                return r2
            L22:
                goto L5a
            L26:
                int r0 = r0 % r1
                goto L6d
            L2c:
                int r0 = r2.mOrientation
                goto L3f
            L32:
                int r0 = r0 - r2
                goto L61
            L37:
                int r2 = androidx.constraintlayout.core.widgets.Flow.access$100(r2)
                goto L32
            L3f:
                r1 = 1
                goto L11
            L44:
                goto L22
            L47:
                goto L2c
            L4b:
                goto L1d
            L4e:
                int r0 = r2.mHeight
                goto L76
            L54:
                int r0 = r0 + r1
                goto L26
            L5a:
                goto L47
            L5d:
                goto L4b
            L61:
                return r0
            L62:
                goto L4
            L66:
                r0 = 3
                goto La
            L6d:
                if (r0 <= 0) goto L72
                goto L47
            L72:
                goto L44
            L76:
                androidx.constraintlayout.core.widgets.Flow r2 = r2.this$0
                goto L37
        }

        public int GetWidth() {
                r1 = this;
                goto L3f
            L4:
                int r0 = r0 - r1
                goto L9
            L9:
                return r0
            La:
                goto L1f
            Le:
                if (r0 == 0) goto L13
                goto La
            L13:
                goto L2b
            L17:
                int r1 = androidx.constraintlayout.core.widgets.Flow.access$000(r1)
                goto L4
            L1f:
                int r1 = r1.mWidth
                goto L37
            L25:
                int r0 = r1.mOrientation
                goto Le
            L2b:
                int r0 = r1.mWidth
                goto L31
            L31:
                androidx.constraintlayout.core.widgets.Flow r1 = r1.this$0
                goto L17
            L37:
                return r1
            L38:
                goto L3c
            L3c:
                goto L42
            L3f:
                goto L38
            L42:
                goto L25
        }

        public void MeasureMatchConstraints(int r9) {
                r8 = this;
                goto L37
            L4:
                if (r0 >= r2) goto L9
                goto L65
            L9:
                goto L63
            Ld:
                int r0 = r8.mOrientation
                goto Lac
            L13:
                if (r0 <= 0) goto L18
                goto Le3
            L18:
                goto Le0
            L1c:
                int r0 = r8.mStartIndex
                goto L10c
            L22:
                goto L3a
            L25:
                androidx.constraintlayout.core.widgets.Flow r2 = r8.this$0
                goto L186
            L2b:
                androidx.constraintlayout.core.widgets.Flow r0 = r8.this$0
                goto Lc5
            L31:
                int r0 = r0 + r1
                goto La6
            L37:
                goto L80
            L3a:
                goto Lbe
            L3e:
                int r1 = r8.mCount
                goto L77
            L44:
                if (r0 == r2) goto L49
                goto Ldc
            L49:
                goto L13b
            L4d:
                if (r0 == r2) goto L52
                goto Ldc
            L52:
                goto L17a
            L56:
                goto Ldc
            L58:
                goto L154
            L5c:
                r1 = 19
                goto L31
            L63:
                goto L12b
            L65:
                goto L2b
            L69:
                androidx.constraintlayout.core.widgets.Flow r2 = r8.this$0
                goto Le7
            L6f:
                int r7 = r3.getHeight()
                goto L105
            L77:
                int r5 = r9 / r0
                goto L146
            L7d:
                goto Le3
            L80:
                goto L22
            L84:
                int r2 = r8.mStartIndex
                goto L12f
            L8a:
                if (r3 != 0) goto L8f
                goto Ldc
            L8f:
                goto Lef
            L93:
                int r0 = r8.mNbMatchConstraintsWidgets
                goto L163
            L99:
                r7 = r5
                goto L9e
            L9e:
                int r5 = r3.getWidth()
                goto L180
            La6:
                int r0 = r0 % r1
                goto L13
            Lac:
                if (r0 == 0) goto Lb1
                goto L58
            Lb1:
                goto L8a
            Lb5:
                if (r0 == 0) goto Lba
                goto Ldc
            Lba:
                goto L69
            Lbe:
                r0 = 10
                goto L5c
            Lc5:
                androidx.constraintlayout.core.widgets.ConstraintWidget[] r0 = androidx.constraintlayout.core.widgets.Flow.access$500(r0)
                goto L84
            Lcd:
                androidx.constraintlayout.core.widgets.Flow r2 = r8.this$0
                goto L15d
            Ld3:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r6 = r3.getVerticalDimensionBehaviour()
                goto L6f
            Ldb:
                r5 = r7
            Ldc:
                goto L174
            Le0:
                goto L142
            Le3:
                goto L93
            Le7:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r4 = r3.getHorizontalDimensionBehaviour()
                goto L99
            Lef:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r0 = r3.getHorizontalDimensionBehaviour()
                goto L111
            Lf7:
                return
            Lf8:
                goto L3e
            Lfc:
                if (r0 == 0) goto L101
                goto Ldc
            L101:
                goto Lcd
            L105:
                r2.measure(r3, r4, r5, r6, r7)
                goto L56
            L10c:
                int r0 = r0 + r9
                goto L25
            L111:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r2 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
                goto L4d
            L117:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r2 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
                goto L44
            L11d:
                r3 = r0[r2]
                goto Ld
            L123:
                r8.recomputeDimensions()
                goto L141
            L12a:
                goto L147
            L12b:
                goto L123
            L12f:
                int r2 = r2 + r9
                goto L11d
            L134:
                r2.measure(r3, r4, r5, r6, r7)
                goto Ldb
            L13b:
                int r0 = r3.mMatchConstraintDefaultHeight
                goto Lb5
            L141:
                return
            L142:
                goto L7d
            L146:
                r9 = 0
            L147:
                goto L14b
            L14b:
                if (r9 < r1) goto L150
                goto L12b
            L150:
                goto L1c
            L154:
                if (r3 != 0) goto L159
                goto Ldc
            L159:
                goto L16c
            L15d:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r4 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.FIXED
                goto Ld3
            L163:
                if (r0 == 0) goto L168
                goto Lf8
            L168:
                goto Lf7
            L16c:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r0 = r3.getVerticalDimensionBehaviour()
                goto L117
            L174:
                int r9 = r9 + 1
                goto L12a
            L17a:
                int r0 = r3.mMatchConstraintDefaultWidth
                goto Lfc
            L180:
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r6 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.FIXED
                goto L134
            L186:
                int r2 = androidx.constraintlayout.core.widgets.Flow.access$400(r2)
                goto L4
        }

        public void SetStartIndex(int r1) {
                r0 = this;
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return
            Lc:
                goto L16
            L10:
                r0.mStartIndex = r1
                goto Lb
            L16:
                goto L7
        }

        public void Setup(int r1, androidx.constraintlayout.core.widgets.ConstraintAnchor r2, androidx.constraintlayout.core.widgets.ConstraintAnchor r3, androidx.constraintlayout.core.widgets.ConstraintAnchor r4, androidx.constraintlayout.core.widgets.ConstraintAnchor r5, int r6, int r7, int r8, int r9, int r10) {
                r0 = this;
                goto L3c
            L4:
                r0.mPaddingTop = r7
                goto L21
            La:
                return
            Lb:
                goto L2d
            Lf:
                r0.mOrientation = r1
                goto L1b
            L15:
                r0.mRight = r4
                goto L36
            L1b:
                r0.mLeft = r2
                goto L49
            L21:
                r0.mPaddingRight = r8
                goto L27
            L27:
                r0.mPaddingBottom = r9
                goto L43
            L2d:
                goto L3f
            L30:
                r0.mPaddingLeft = r6
                goto L4
            L36:
                r0.mBottom = r5
                goto L30
            L3c:
                goto Lb
            L3f:
                goto Lf
            L43:
                r0.mMax = r10
                goto La
            L49:
                r0.mTop = r3
                goto L15
        }
    }

    public Flow() {
            r3 = this;
            goto L79
        L4:
            r3.mFirstHorizontalStyle = r0
            goto L73
        La:
            if (r0 <= 0) goto Lf
            goto Le8
        Lf:
            goto Le5
        L13:
            r3.mVerticalGap = r1
            goto L6e
        L19:
            r3.mDisplayedWidgetsCount = r1
            goto Lfd
        L1f:
            r3.mFirstVerticalBias = r1
            goto L3c
        L25:
            r3.mHorizontalBias = r1
            goto L80
        L2b:
            r3.mAlignedDimensions = r0
            goto L19
        L31:
            java.util.List r0 = new java.util.List
            goto Lbe
        L37:
            r0 = 0
            goto Ldf
        L3c:
            r3.mLastHorizontalBias = r1
            goto L92
        L42:
            r3.<init>()
            goto La4
        L49:
            r3.mHorizontalStyle = r0
            goto Laf
        L4f:
            r3.mHorizontalAlign = r2
            goto L5c
        L55:
            r0 = 14
            goto Lc5
        L5c:
            r3.mVerticalAlign = r2
            goto Lf1
        L62:
            r3.mHorizontalGap = r1
            goto L13
        L68:
            r3.mLastVerticalStyle = r0
            goto Lb8
        L6e:
            r2 = 2
            goto L4f
        L73:
            r3.mFirstVerticalStyle = r0
            goto La9
        L79:
            goto Lcf
        L7c:
            goto L55
        L80:
            r3.mVerticalBias = r1
            goto Ld9
        L86:
            r3.mOrientation = r1
            goto L31
        L8c:
            r3.mMaxElementsWrap = r0
            goto L86
        L92:
            r3.mLastVerticalBias = r1
            goto Lec
        L98:
            int r0 = r0 + r1
            goto L9e
        L9e:
            int r0 = r0 % r1
            goto La
        La4:
            r0 = -1
            goto L49
        La9:
            r3.mLastHorizontalStyle = r0
            goto L68
        Laf:
            r3.mVerticalStyle = r0
            goto L4
        Lb5:
            goto L7c
        Lb8:
            r1 = 1056964608(0x3f000000, float:0.5)
            goto L25
        Lbe:
            r0.<init>()
            goto Lf7
        Lc5:
            r1 = 11
            goto L98
        Lcc:
            goto Le8
        Lcf:
            goto Lb5
        Ld3:
            r3.mAlignedBiggestElementsInCols = r0
            goto L2b
        Ld9:
            r3.mFirstHorizontalBias = r1
            goto L1f
        Ldf:
            r3.mAlignedBiggestElementsInRows = r0
            goto Ld3
        Le5:
            goto Lfe
        Le8:
            goto L42
        Lec:
            r1 = 0
            goto L62
        Lf1:
            r3.mWrapMode = r1
            goto L8c
        Lf7:
            r3.mChainList = r0
            goto L37
        Lfd:
            return
        Lfe:
            goto Lcc
    }

    static /* synthetic */ int access$000(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            return r0
        L5:
            goto Lf
        L9:
            int r0 = r0.mHorizontalGap
            goto L4
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
    }

    static /* synthetic */ int access$100(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            goto L15
        L7:
            int r0 = r0.mVerticalGap
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

    static /* synthetic */ int access$1000(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            return r0
        L5:
            goto Lf
        L9:
            int r0 = r0.mFirstHorizontalStyle
            goto L4
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
    }

    static /* synthetic */ float access$1100(androidx.constraintlayout.core.widgets.Flow r0) {
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
            float r0 = r0.mFirstHorizontalBias
            goto Lb
    }

    static /* synthetic */ int access$1200(androidx.constraintlayout.core.widgets.Flow r0) {
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
            int r0 = r0.mLastHorizontalStyle
            goto L7
    }

    static /* synthetic */ float access$1300(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            float r0 = r0.mLastHorizontalBias
            goto L14
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
    }

    static /* synthetic */ float access$1400(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            float r0 = r0.mVerticalBias
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

    static /* synthetic */ int access$1500(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            goto L15
        L7:
            int r0 = r0.mFirstVerticalStyle
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

    static /* synthetic */ float access$1600(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            goto L15
        L7:
            float r0 = r0.mFirstVerticalBias
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

    static /* synthetic */ int access$1700(androidx.constraintlayout.core.widgets.Flow r0) {
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
            int r0 = r0.mLastVerticalStyle
            goto L4
        L16:
            goto Lc
    }

    static /* synthetic */ float access$1800(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            goto L15
        L7:
            float r0 = r0.mLastVerticalBias
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

    static /* synthetic */ int access$1900(androidx.constraintlayout.core.widgets.Flow r0) {
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
            int r0 = r0.mHorizontalAlign
            goto L7
    }

    static /* synthetic */ int access$200(androidx.constraintlayout.core.widgets.Flow r0, androidx.constraintlayout.core.widgets.ConstraintWidget r1, int r2) {
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
            int r0 = r0.getWidgetWidth(r1, r2)
            goto Lb
    }

    static /* synthetic */ int access$300(androidx.constraintlayout.core.widgets.Flow r0, androidx.constraintlayout.core.widgets.ConstraintWidget r1, int r2) {
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
            int r0 = r0.getWidgetHeight(r1, r2)
            goto Le
    }

    static /* synthetic */ int access$400(androidx.constraintlayout.core.widgets.Flow r0) {
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
            int r0 = r0.mDisplayedWidgetsCount
            goto L7
    }

    static /* synthetic */ androidx.constraintlayout.core.widgets.ConstraintWidget[] access$500(androidx.constraintlayout.core.widgets.Flow r0) {
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
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r0 = r0.mDisplayedWidgets
            goto L4
        L16:
            goto Lc
    }

    static /* synthetic */ int access$600(androidx.constraintlayout.core.widgets.Flow r0) {
            goto L12
        L4:
            int r0 = r0.mVerticalStyle
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

    static /* synthetic */ int access$700(androidx.constraintlayout.core.widgets.Flow r0) {
            goto La
        L4:
            int r0 = r0.mVerticalAlign
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
    }

    static /* synthetic */ int access$800(androidx.constraintlayout.core.widgets.Flow r0) {
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
            int r0 = r0.mHorizontalStyle
            goto Le
    }

    static /* synthetic */ float access$900(androidx.constraintlayout.core.widgets.Flow r0) {
            goto La
        L4:
            float r0 = r0.mHorizontalBias
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
    }

    private void CreateAlignedConstraints(bool r12) {
            r11 = this;
            goto L97
        L4:
            r5 = r4
        L5:
            goto L7d
        L9:
            r8 = r4
            goto L83
        Le:
            if (r12 > 0) goto L13
            goto L392
        L13:
            goto L5c
        L17:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r8 = r5.mBottom
            goto L11e
        L1d:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r8 = r11.mAlignedBiggestElementsInRows
            goto L25c
        L23:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r5.mRight
            goto L306
        L29:
            r4.connect(r6, r8, r9)
            goto L383
        L30:
            r4.connect(r6, r8, r9)
        L33:
            goto Le
        L37:
            r4 = r9[r4]
            goto L233
        L3d:
            float r8 = r8 - r9
            goto L2a2
        L42:
            r6 = r6[r12]
            goto L1d
        L48:
            r2.resetAnchors()
            goto L366
        L4f:
            r4.setVerticalChainStyle(r6)
            goto L36c
        L56:
            int r7 = r2 + (-1)
            goto L34e
        L5c:
            if (r5 != 0) goto L61
            goto L392
        L61:
            goto L13e
        L65:
            if (r1 < r2) goto L6a
            goto L13a
        L6a:
            goto L1a8
        L6e:
            if (r12 < r1) goto L73
            goto L125
        L73:
            goto L21f
        L77:
            int r7 = r11.mHorizontalStyle
            goto L2de
        L7d:
            int r12 = r12 + 1
            goto L124
        L83:
            r4 = r6
        L84:
            goto La3
        L88:
            int r10 = r11.getPaddingLeft()
            goto L396
        L90:
            r5.connect(r9, r6, r0)
        L93:
            goto L2c1
        L97:
            goto L337
        L9a:
            goto L347
        L9e:
            int r5 = r5 + r4
        L9f:
            goto L33b
        La3:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r9 = r11.mAlignedBiggestElementsInCols
            goto L37
        La9:
            if (r6 > 0) goto Lae
            goto L20c
        Lae:
            goto L210
        Lb2:
            goto L1bd
        Lb4:
            goto L282
        Lb8:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r4.mBottom
            goto L27c
        Lbe:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r8 = r11.mTop
            goto L315
        Lc4:
            goto L1d1
        Lc6:
            goto L2d3
        Lca:
            int r9 = r11.getPaddingBottom()
            goto L30
        Ld2:
            if (r6 < r2) goto Ld7
            goto L1ec
        Ld7:
            goto L30c
        Ldb:
            int r4 = r4 + 1
            goto L389
        Le1:
            if (r6 == r3) goto Le6
            goto L9f
        Le6:
            goto L3d5
        Lea:
            if (r12 < r2) goto Lef
            goto L1bd
        Lef:
            goto L129
        Lf3:
            if (r6 == 0) goto Lf8
            goto L1fb
        Lf8:
            goto L14a
        Lfc:
            int r0 = r0 % r1
            goto L2ca
        L102:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r0 = r11.mAlignedBiggestElementsInRows
            goto L3db
        L108:
            if (r4 < r1) goto L10d
            goto L38b
        L10d:
            goto L3c4
        L111:
            r2 = r2[r1]
            goto L48
        L117:
            r4.setVerticalBiasPercent(r6)
        L11a:
            goto L2f4
        L11e:
            int r9 = r11.mVerticalGap
            goto L29
        L124:
            goto L135
        L125:
            goto L277
        L129:
            r4 = r0
        L12a:
            goto L108
        L12e:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r7 = r5.mRight
            goto L295
        L134:
            r12 = r0
        L135:
            goto L6e
        L139:
            goto L1a4
        L13a:
            goto L16d
        L13e:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r4.mTop
            goto L17
        L144:
            goto L5
        L146:
            goto L3b2
        L14a:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r7 = r4.mLeft
            goto L262
        L150:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r5.mRight
            goto L173
        L156:
            r5 = r6[r5]
            goto L3bb
        L15c:
            int r0 = r0 + r1
            goto Lfc
        L162:
            r6 = r0
        L163:
            goto L24a
        L167:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r7 = r4.mRight
            goto L378
        L16d:
            int[] r1 = r11.mAlignedDimensions
            goto L322
        L173:
            int r10 = r11.mHorizontalGap
            goto L29b
        L179:
            if (r5 >= r8) goto L17e
            goto L2f0
        L17e:
            goto L2ee
        L182:
            int r6 = r5.getVisibility()
            goto L3e4
        L18a:
            int r12 = r12 + 1
            goto L1bb
        L190:
            r5.connect(r6, r9, r0)
            goto L1de
        L197:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r8 = r4.mTop
            goto L38f
        L19d:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r5.mTop
            goto L341
        L1a3:
            r1 = r0
        L1a4:
            goto L2bb
        L1a8:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r2 = r11.mDisplayedWidgets
            goto L111
        L1ae:
            r4.connect(r7, r9, r10)
        L1b1:
            goto La9
        L1b5:
            float r4 = r11.mHorizontalBias
            goto L37e
        L1bb:
            goto L278
        L1bd:
            goto L3d0
        L1c1:
            r5 = r4
        L1c2:
            goto L328
        L1c6:
            int r9 = r4.getVisibility()
            goto L357
        L1ce:
            r5.connect(r6, r8, r0)
        L1d1:
            goto Ldb
        L1d5:
            if (r4 != 0) goto L1da
            goto L5
        L1da:
            goto L23c
        L1de:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r5.mBottom
            goto L2fa
        L1e4:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r0 = r11.mAlignedBiggestElementsInCols
            goto L225
        L1ea:
            goto L163
        L1ec:
            goto L134
        L1f0:
            int r10 = r11.getPaddingRight()
            goto L1ae
        L1f8:
            r4.setHorizontalBiasPercent(r8)
        L1fb:
            goto L56
        L1ff:
            goto L9a
        L202:
            r4.connect(r6, r8, r9)
            goto L3ed
        L209:
            r5.connect(r7, r9, r0)
        L20c:
            goto L1c1
        L210:
            if (r5 != 0) goto L215
            goto L20c
        L215:
            goto L32e
        L219:
            r1 = r1[r3]
            goto L1b5
        L21f:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r4 = r11.mAlignedBiggestElementsInRows
            goto L256
        L225:
            if (r0 != 0) goto L22a
            goto L1bd
        L22a:
            goto L102
        L22e:
            int r4 = r4 - r3
            goto L372
        L233:
            if (r4 != 0) goto L238
            goto L1c2
        L238:
            goto L1c6
        L23c:
            int r6 = r4.getVisibility()
            goto L287
        L244:
            int r6 = r11.mOrientation
            goto Le1
        L24a:
            r7 = 8
            goto Ld2
        L250:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r5.mLeft
            goto L300
        L256:
            r4 = r4[r12]
            goto L1d5
        L25c:
            r8 = r8[r4]
            goto L2e5
        L262:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r11.mLeft
            goto L88
        L268:
            if (r0 != 0) goto L26d
            goto L1bd
        L26d:
            goto L1e4
        L271:
            int[] r0 = r11.mAlignedDimensions
            goto L268
        L277:
            r12 = r0
        L278:
            goto Lea
        L27c:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r8 = r11.mBottom
            goto Lca
        L282:
            r0 = 0
            goto L1a3
        L287:
            if (r6 == r7) goto L28c
            goto L146
        L28c:
            goto L144
        L290:
            int r5 = r5 + r12
            goto L244
        L295:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r4.mLeft
            goto L209
        L29b:
            r4.connect(r7, r9, r10)
            goto L12e
        L2a2:
            goto L84
        L2a4:
            goto L9
        L2a8:
            goto L1c2
        L2aa:
            goto Lf3
        L2ae:
            int r4 = r2 - r6
            goto L22e
        L2b4:
            goto L3d1
        L2b7:
            goto L271
        L2bb:
            int r2 = r11.mDisplayedWidgetsCount
            goto L65
        L2c1:
            if (r5 != r8) goto L2c6
            goto L1d1
        L2c6:
            goto L19d
        L2ca:
            if (r0 <= 0) goto L2cf
            goto L2b7
        L2cf:
            goto L2b4
        L2d3:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r6 = r11.mAlignedBiggestElementsInCols
            goto L42
        L2d9:
            int r8 = r6.length
            goto L179
        L2de:
            r4.setHorizontalChainStyle(r7)
            goto L1f8
        L2e5:
            if (r5 != r6) goto L2ea
            goto L93
        L2ea:
            goto L250
        L2ee:
            goto L1d1
        L2f0:
            goto L156
        L2f4:
            int r6 = r1 + (-1)
            goto L3a2
        L2fa:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r8 = r8.mBottom
            goto L1ce
        L300:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r10 = r6.mLeft
            goto L3f3
        L306:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r6.mRight
            goto L90
        L30c:
            if (r12 != 0) goto L311
            goto L2a4
        L311:
            goto L2ae
        L315:
            int r9 = r11.getPaddingTop()
            goto L202
        L31d:
            r4 = r8
            goto L1ea
        L322:
            r2 = r1[r0]
            goto L39d
        L328:
            int r6 = r6 + 1
            goto L31d
        L32e:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r7 = r4.mLeft
            goto L150
        L334:
            goto L2b7
        L337:
            goto L1ff
        L33b:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r6 = r11.mDisplayedWidgets
            goto L2d9
        L341:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r8.mTop
            goto L190
        L347:
            r0 = 13
            goto L3ab
        L34e:
            if (r6 == r7) goto L353
            goto L1b1
        L353:
            goto L167
        L357:
            if (r9 == r7) goto L35c
            goto L2aa
        L35c:
            goto L2a8
        L360:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r4.mTop
            goto Lbe
        L366:
            int r1 = r1 + 1
            goto L139
        L36c:
            float r6 = r11.mVerticalBias
            goto L117
        L372:
            r8 = 1065353216(0x3f800000, float:1.0)
            goto L3ca
        L378:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r9 = r11.mRight
            goto L1f0
        L37e:
            r5 = 0
            goto L162
        L383:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r5.mBottom
            goto L197
        L389:
            goto L12a
        L38b:
            goto L18a
        L38f:
            r5.connect(r6, r8, r0)
        L392:
            goto L4
        L396:
            r4.connect(r7, r9, r10)
            goto L77
        L39d:
            r3 = 1
            goto L219
        L3a2:
            if (r12 == r6) goto L3a7
            goto L33
        L3a7:
            goto Lb8
        L3ab:
            r1 = 19
            goto L15c
        L3b2:
            if (r12 == 0) goto L3b7
            goto L11a
        L3b7:
            goto L360
        L3bb:
            if (r5 != 0) goto L3c0
            goto L1d1
        L3c0:
            goto L182
        L3c4:
            int r5 = r4 * r2
            goto L290
        L3ca:
            float r9 = r11.mHorizontalBias
            goto L3d
        L3d0:
            return
        L3d1:
            goto L334
        L3d5:
            int r5 = r12 * r1
            goto L9e
        L3db:
            if (r0 == 0) goto L3e0
            goto Lb4
        L3e0:
            goto Lb2
        L3e4:
            if (r6 == r7) goto L3e9
            goto Lc6
        L3e9:
            goto Lc4
        L3ed:
            int r6 = r11.mVerticalStyle
            goto L4f
        L3f3:
            r5.connect(r9, r10, r0)
            goto L23
    }

    private int GetWidgetHeight(androidx.constraintlayout.core.widgets.ConstraintWidget r10, int r11) {
            r9 = this;
            goto L1a
        L4:
            return r0
        L5:
            goto L156
        L9:
            if (r9 == r2) goto Le
            goto L48
        Le:
            goto L129
        L12:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r5 = r10.getHorizontalDimensionBehaviour()
            goto Lc0
        L1a:
            goto L107
        L1d:
            goto Lf4
        L21:
            if (r0 <= 0) goto L26
            goto L59
        L26:
            goto L56
        L2a:
            if (r1 == r2) goto L2f
            goto L4d
        L2f:
            goto Le3
        L33:
            r4 = r10
            goto Lb4
        L38:
            r3 = r9
            goto L111
        L3d:
            return r9
        L3e:
            goto L104
        L42:
            r4 = r10
        L43:
            goto Lce
        L47:
            return r9
        L48:
            goto Lc8
        L4c:
            return r9
        L4d:
            goto L42
        L51:
            float r9 = r9 * r10
            goto L148
        L56:
            goto L3e
        L59:
            goto L116
        L5d:
            return r0
        L5e:
            goto Ldb
        L62:
            r1 = 2
            goto Laa
        L67:
            int r8 = (int) r0
            goto L14e
        L6c:
            r10 = 3
            goto L9b
        L71:
            float r11 = (float) r11
            goto L11b
        L76:
            if (r0 == r1) goto L7b
            goto L13e
        L7b:
            goto L137
        L7f:
            float r9 = r9 + r10
            goto Ld6
        L84:
            if (r10 == 0) goto L89
            goto L5e
        L89:
            goto L5d
        L8d:
            r1 = 17
            goto Lba
        L94:
            r10.setMeasureRequested(r2)
            goto L12
        L9b:
            if (r9 == r10) goto La0
            goto L43
        La0:
            goto Le9
        La4:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r7 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.FIXED
            goto L38
        Laa:
            r2 = 1
            goto L76
        Laf:
            float r9 = (float) r9
            goto L10b
        Lb4:
            int r9 = r4.mMatchConstraintDefaultHeight
            goto L9
        Lba:
            int r0 = r0 + r1
            goto L142
        Lc0:
            int r6 = r10.getWidth()
            goto La4
        Lc8:
            int r9 = r4.mMatchConstraintDefaultHeight
            goto L6c
        Lce:
            int r9 = r4.getHeight()
            goto L3d
        Ld6:
            int r9 = (int) r9
            goto L4c
        Ldb:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r1 = r10.getVerticalDimensionBehaviour()
            goto L131
        Le3:
            int r1 = r10.mMatchConstraintDefaultHeight
            goto Lfb
        Le9:
            int r9 = r4.getWidth()
            goto Laf
        Lf1:
            goto L1d
        Lf4:
            r0 = 27
            goto L8d
        Lfb:
            if (r1 == 0) goto L100
            goto L5
        L100:
            goto L4
        L104:
            goto L59
        L107:
            goto Lf1
        L10b:
            float r10 = r4.mDimensionRatio
            goto L51
        L111:
            r4 = r10
            goto L15c
        L116:
            r0 = 0
            goto L84
        L11b:
            float r0 = r0 * r11
            goto L67
        L120:
            if (r8 != r11) goto L125
            goto L15f
        L125:
            goto L94
        L129:
            int r9 = r4.getHeight()
            goto L47
        L131:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r2 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
            goto L2a
        L137:
            float r0 = r10.mMatchConstraintPercentHeight
            goto L71
        L13d:
            return r8
        L13e:
            goto L33
        L142:
            int r0 = r0 % r1
            goto L21
        L148:
            r10 = 1056964608(0x3f000000, float:0.5)
            goto L7f
        L14e:
            int r11 = r10.getHeight()
            goto L120
        L156:
            int r0 = r10.mMatchConstraintDefaultHeight
            goto L62
        L15c:
            r3.measure(r4, r5, r6, r7, r8)
        L15f:
            goto L13d
    }

    private int GetWidgetWidth(androidx.constraintlayout.core.widgets.ConstraintWidget r10, int r11) {
            r9 = this;
            goto Lc3
        L4:
            r4 = r10
        L5:
            goto L14a
        L9:
            r10 = 1056964608(0x3f000000, float:0.5)
            goto L5b
        Lf:
            float r0 = r0 * r11
            goto L50
        L14:
            return r0
        L15:
            goto L117
        L19:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r7 = r10.getVerticalDimensionBehaviour()
            goto L11f
        L21:
            float r11 = (float) r11
            goto Lf
        L26:
            goto Lc6
        L29:
            int r9 = r4.getWidth()
            goto Lf6
        L31:
            float r10 = r4.mDimensionRatio
            goto Lb2
        L37:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r5 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.FIXED
            goto L19
        L3d:
            if (r1 == 0) goto L42
            goto L13f
        L42:
            goto L13e
        L46:
            r0 = 0
            goto Lde
        L4b:
            r4 = r10
            goto Lbc
        L50:
            int r6 = (int) r0
            goto L69
        L55:
            int r9 = r4.mMatchConstraintDefaultWidth
            goto Lb7
        L5b:
            float r9 = r9 + r10
            goto L12e
        L60:
            if (r0 <= 0) goto L65
            goto L88
        L65:
            goto L85
        L69:
            int r11 = r10.getWidth()
            goto L105
        L71:
            if (r1 == r2) goto L76
            goto Lae
        L76:
            goto Lca
        L7a:
            int r0 = r0 + r1
            goto L8c
        L80:
            return r6
        L81:
            goto L100
        L85:
            goto Lfc
        L88:
            goto L46
        L8c:
            int r0 = r0 % r1
            goto L60
        L92:
            r2 = 1
            goto L15a
        L97:
            r1 = 2
            goto L92
        L9c:
            int r0 = r10.mMatchConstraintDefaultWidth
            goto L97
        La2:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r2 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
            goto L71
        La8:
            r3 = r9
            goto L4b
        Lad:
            return r9
        Lae:
            goto L4
        Lb2:
            float r9 = r9 * r10
            goto L9
        Lb7:
            r10 = 3
            goto Led
        Lbc:
            r3.measure(r4, r5, r6, r7, r8)
        Lbf:
            goto L80
        Lc3:
            goto Lda
        Lc6:
            goto L127
        Lca:
            int r1 = r10.mMatchConstraintDefaultWidth
            goto L3d
        Ld0:
            r10.setMeasureRequested(r2)
            goto L37
        Ld7:
            goto L88
        Lda:
            goto L26
        Lde:
            if (r10 == 0) goto Le3
            goto L15
        Le3:
            goto L14
        Le7:
            int r9 = r4.mMatchConstraintDefaultWidth
            goto L10e
        Led:
            if (r9 == r10) goto Lf2
            goto L5
        Lf2:
            goto L152
        Lf6:
            return r9
        Lf7:
            goto L55
        Lfb:
            return r9
        Lfc:
            goto Ld7
        L100:
            r4 = r10
            goto Le7
        L105:
            if (r6 != r11) goto L10a
            goto Lbf
        L10a:
            goto Ld0
        L10e:
            if (r9 == r2) goto L113
            goto Lf7
        L113:
            goto L29
        L117:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r1 = r10.getHorizontalDimensionBehaviour()
            goto La2
        L11f:
            int r8 = r10.getHeight()
            goto La8
        L127:
            r0 = 29
            goto L143
        L12e:
            int r9 = (int) r9
            goto Lad
        L133:
            float r9 = (float) r9
            goto L31
        L138:
            float r0 = r10.mMatchConstraintPercentWidth
            goto L21
        L13e:
            return r0
        L13f:
            goto L9c
        L143:
            r1 = 20
            goto L7a
        L14a:
            int r9 = r4.getWidth()
            goto Lfb
        L152:
            int r9 = r4.getHeight()
            goto L133
        L15a:
            if (r0 == r1) goto L15f
            goto L81
        L15f:
            goto L138
    }

    private void MeasureAligned(androidx.constraintlayout.core.widgets.ConstraintWidget[] r11, int r12, int r13, int r14, int[] r15) {
            r10 = this;
            goto L1e2
        L4:
            float r1 = r1 / r5
            goto Lb2
        L9:
            if (r6 > r14) goto Le
            goto L1ee
        Le:
            goto L3b4
        L12:
            r1 = r0
            goto L245
        L17:
            if (r0 <= 0) goto L1c
            goto L353
        L1c:
            goto L350
        L20:
            if (r7 != 0) goto L25
            goto L2e4
        L25:
            goto L33e
        L29:
            r9 = r9[r6]
            goto L3f8
        L2f:
            goto L1e5
        L32:
            r15[r0] = r6
            goto L45f
        L38:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r5 = r10.mAlignedBiggestElementsInCols
            goto L29a
        L3e:
            r2 = r1
            goto L228
        L43:
            double r5 = java.lang.Math.ceil(r5)
            goto L416
        L4b:
            int r4 = r10.mVerticalGap
            goto L474
        L51:
            double r5 = java.lang.Math.ceil(r5)
            goto Lf4
        L59:
            int r0 = r0 % r1
            goto L17
        L5f:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r8 = r10.mAlignedBiggestElementsInRows
            goto L207
        L65:
            r5 = r0
            goto L427
        L6a:
            if (r5 < r2) goto L6f
            goto L120
        L6f:
            goto Lee
        L73:
            if (r13 == 0) goto L78
            goto L11a
        L78:
            goto L421
        L7c:
            if (r8 != 0) goto L81
            goto L3cc
        L81:
            goto L16d
        L85:
            r6 = r0
        L86:
            goto L1a1
        L8a:
            double r5 = (double) r2
            goto L51
        L8f:
            goto L1d0
        L91:
            goto Lcd
        L95:
            r10[r0] = r2
            goto L41b
        L9b:
            if (r1 > r3) goto La0
            goto L1ee
        La0:
            goto L42c
        La4:
            if (r5 < r1) goto La9
            goto L163
        La9:
            goto L38e
        Lad:
            r5 = r0
            goto L3a0
        Lb2:
            double r5 = (double) r1
            goto L43
        Lb7:
            goto L488
        Lb9:
            goto Lad
        Lbd:
            r0 = 0
            goto L73
        Lc2:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r9 = r10.mAlignedBiggestElementsInRows
            goto L29
        Lc8:
            goto L86
        Lc9:
            goto Lff
        Lcd:
            int[] r10 = r10.mAlignedDimensions
            goto L95
        Ld3:
            int r7 = r6 * r2
            goto L446
        Ld9:
            int r6 = r6 + 1
            goto Lc8
        Ldf:
            r4 = r11[r2]
            goto L2ab
        Le5:
            if (r13 != r3) goto Lea
            goto L1ee
        Lea:
            goto L110
        Lee:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r7 = r10.mAlignedBiggestElementsInCols
            goto L1f2
        Lf4:
            int r2 = (int) r5
        Lf5:
            goto L38
        Lf9:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r5 = new androidx.constraintlayout.core.widgets.ConstraintWidget[r1]
            goto L18a
        Lff:
            int r5 = r5 + 1
            goto Lb7
        L105:
            r2 = r0
        L106:
            goto L136
        L10a:
            int r2 = r2 + (-1)
            goto L195
        L110:
            if (r2 == 0) goto L115
            goto L43a
        L115:
            goto L1e9
        L119:
            goto L106
        L11a:
            goto L3f2
        L11e:
            goto L3a1
        L120:
            goto L65
        L124:
            int r4 = r10.mHorizontalGap
            goto L3bd
        L12a:
            int r1 = r1 + 1
        L12c:
            goto L222
        L130:
            int r1 = r1 + 1
        L132:
            goto L1b3
        L136:
            int[] r3 = r10.mAlignedDimensions
            goto L30f
        L13c:
            int r6 = r6 + r8
        L13d:
            goto L1b9
        L141:
            goto L209
        L143:
            goto L1c7
        L147:
            goto L18c
        L148:
            goto Lf9
        L14c:
            r1 = 22
            goto L256
        L153:
            if (r5 != 0) goto L158
            goto L169
        L158:
            goto L232
        L15c:
            r4 = r3
            goto L438
        L161:
            goto L428
        L163:
            goto L32
        L167:
            goto L3ee
        L169:
            goto L28c
        L16d:
            if (r5 > 0) goto L172
            goto L22e
        L172:
            goto L44b
        L176:
            r1 = r0
            goto L3e
        L17b:
            goto L330
        L17d:
            goto L12a
        L181:
            if (r13 == 0) goto L186
            goto L2a1
        L186:
            goto L281
        L18a:
            r10.mAlignedBiggestElementsInRows = r5
        L18c:
            goto L487
        L190:
            goto L209
        L191:
            goto L46e
        L195:
            goto L1d0
        L197:
            goto L40d
        L19b:
            r8[r5] = r7
        L19d:
            goto L3e4
        L1a1:
            if (r6 < r1) goto L1a6
            goto Lc9
        L1a6:
            goto Ld3
        L1aa:
            if (r9 < r8) goto L1af
            goto L209
        L1af:
            goto L5f
        L1b3:
            int r2 = r2 + 1
            goto L262
        L1b9:
            int r7 = r10.getWidgetWidth(r7, r14)
            goto L2e3
        L1c1:
            goto L264
        L1c3:
            goto L130
        L1c7:
            int r8 = r10.getWidgetWidth(r7, r14)
            goto L25c
        L1cf:
            r4 = r0
        L1d0:
            goto L26d
        L1d4:
            if (r5 < r2) goto L1d9
            goto Lb9
        L1d9:
            goto L85
        L1dd:
            return
        L1de:
            goto L24f
        L1e2:
            goto L252
        L1e5:
            goto L216
        L1e9:
            if (r13 == 0) goto L1ee
            goto L43a
        L1ee:
            goto L15c
        L1f2:
            r7 = r7[r5]
            goto L20
        L1f8:
            if (r7 == 0) goto L1fd
            goto L143
        L1fd:
            goto L141
        L201:
            int r5 = r5 + 1
            goto L161
        L207:
            r8[r6] = r7
        L209:
            goto Ld9
        L20d:
            if (r1 <= 0) goto L212
            goto L330
        L212:
            goto L176
        L216:
            r0 = 4
            goto L14c
        L21d:
            r3 = 2
            goto L3ae
        L222:
            int r2 = r2 + 1
            goto L32e
        L228:
            r3 = r2
        L229:
            goto L451
        L22d:
            int r7 = r7 + r9
        L22e:
            goto L23d
        L232:
            int r7 = r5.length
            goto L3db
        L237:
            goto L169
        L239:
            goto L321
        L23d:
            int r8 = r10.getWidgetHeight(r8, r14)
            goto L3cb
        L245:
            r2 = r1
            goto L30a
        L24a:
            float r5 = (float) r1
            goto L36f
        L24f:
            goto L353
        L252:
            goto L2f
        L256:
            int r0 = r0 + r1
            goto L59
        L25c:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r9 = r10.mAlignedBiggestElementsInCols
            goto L2d4
        L262:
            goto L30b
        L264:
            goto L268
        L268:
            r2 = r1
            goto L2e8
        L26d:
            if (r4 == 0) goto L272
            goto L91
        L272:
            goto L181
        L276:
            r3 = 1
            goto L3a5
        L27b:
            int r8 = r10.mHorizontalGap
            goto L13c
        L281:
            float r1 = (float) r12
            goto L408
        L286:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r5 = r10.mAlignedBiggestElementsInRows
            goto L2da
        L28c:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r5 = new androidx.constraintlayout.core.widgets.ConstraintWidget[r2]
            goto L3ec
        L292:
            int r9 = r9.getWidth()
            goto L357
        L29a:
            r6 = 0
            goto L153
        L29f:
            goto Lf5
        L2a1:
            goto L334
        L2a5:
            goto L148
        L2a7:
            goto L401
        L2ab:
            if (r4 == 0) goto L2b0
            goto L483
        L2b0:
            goto L481
        L2b4:
            int r8 = r11.length
            goto L3c2
        L2b9:
            if (r2 < r12) goto L2be
            goto L264
        L2be:
            goto L347
        L2c2:
            if (r2 > 0) goto L2c7
            goto L475
        L2c7:
            goto L4b
        L2cb:
            if (r7 < r1) goto L2d0
            goto L2a7
        L2d0:
            goto L2a5
        L2d4:
            r9 = r9[r5]
            goto L318
        L2da:
            if (r5 != 0) goto L2df
            goto L148
        L2df:
            goto L3d0
        L2e3:
            int r6 = r6 + r7
        L2e4:
            goto L360
        L2e8:
            r1 = r0
            goto L119
        L2ed:
            int r3 = r3 + r4
            goto L2f2
        L2f2:
            if (r3 > r14) goto L2f7
            goto L1c3
        L2f7:
            goto L1c1
        L2fb:
            if (r4 == 0) goto L300
            goto L39c
        L300:
            goto L39a
        L304:
            int r7 = r5 * r1
            goto L339
        L30a:
            r3 = r2
        L30b:
            goto L2b9
        L30f:
            if (r3 == 0) goto L314
            goto L32a
        L314:
            goto L21d
        L318:
            if (r9 != 0) goto L31d
            goto L35c
        L31d:
            goto L292
        L321:
            java.util.Arrays.fill(r5, r6)
            goto L167
        L328:
            r10.mAlignedDimensions = r3
        L32a:
            goto L276
        L32e:
            goto L229
        L330:
            goto L105
        L334:
            float r2 = (float) r12
            goto L24a
        L339:
            int r7 = r7 + r6
        L33a:
            goto L2b4
        L33e:
            if (r5 > 0) goto L343
            goto L13d
        L343:
            goto L27b
        L347:
            if (r2 > 0) goto L34c
            goto L3be
        L34c:
            goto L124
        L350:
            goto L1de
        L353:
            goto Lbd
        L357:
            if (r9 < r8) goto L35c
            goto L19d
        L35c:
            goto L394
        L360:
            int r5 = r5 + 1
            goto L11e
        L366:
            if (r1 <= 0) goto L36b
            goto L264
        L36b:
            goto L12
        L36f:
            float r2 = r2 / r5
            goto L8a
        L374:
            int r4 = r10.getWidgetWidth(r4, r14)
            goto L2ed
        L37c:
            if (r13 == r3) goto L381
            goto L33a
        L381:
            goto L304
        L385:
            if (r13 == 0) goto L38a
            goto L197
        L38a:
            goto L9
        L38e:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r8 = r10.mAlignedBiggestElementsInRows
            goto L3d5
        L394:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r8 = r10.mAlignedBiggestElementsInCols
            goto L19b
        L39a:
            goto L12c
        L39c:
            goto L43e
        L3a0:
            r6 = r5
        L3a1:
            goto L6a
        L3a5:
            if (r1 == 0) goto L3aa
            goto Lea
        L3aa:
            goto Le5
        L3ae:
            int[] r3 = new int[r3]
            goto L328
        L3b4:
            if (r2 > r3) goto L3b9
            goto L1ee
        L3b9:
            goto L10a
        L3bd:
            int r3 = r3 + r4
        L3be:
            goto Ldf
        L3c2:
            if (r7 >= r8) goto L3c7
            goto L191
        L3c7:
            goto L190
        L3cb:
            int r7 = r7 + r8
        L3cc:
            goto L201
        L3d0:
            int r7 = r5.length
            goto L2cb
        L3d5:
            r8 = r8[r5]
            goto L7c
        L3db:
            if (r7 < r2) goto L3e0
            goto L239
        L3e0:
            goto L237
        L3e4:
            int r8 = r10.getWidgetHeight(r7, r14)
            goto Lc2
        L3ec:
            r10.mAlignedBiggestElementsInCols = r5
        L3ee:
            goto L286
        L3f2:
            int r1 = r10.mMaxElementsWrap
            goto L20d
        L3f8:
            if (r9 != 0) goto L3fd
            goto L1af
        L3fd:
            goto L479
        L401:
            java.util.Arrays.fill(r5, r6)
            goto L147
        L408:
            float r5 = (float) r2
            goto L4
        L40d:
            if (r7 > r14) goto L412
            goto L1ee
        L412:
            goto L9b
        L416:
            int r1 = (int) r5
            goto L29f
        L41b:
            r10[r3] = r1
            goto L1dd
        L421:
            int r1 = r10.mMaxElementsWrap
            goto L366
        L427:
            r7 = r5
        L428:
            goto La4
        L42c:
            int r1 = r1 + (-1)
            goto L8f
        L432:
            r4 = r11[r2]
            goto L2fb
        L438:
            goto L1d0
        L43a:
            goto L1cf
        L43e:
            int r4 = r10.getWidgetHeight(r4, r14)
            goto L45a
        L446:
            int r7 = r7 + r5
            goto L37c
        L44b:
            int r9 = r10.mVerticalGap
            goto L22d
        L451:
            if (r2 < r12) goto L456
            goto L330
        L456:
            goto L2c2
        L45a:
            int r3 = r3 + r4
            goto L465
        L45f:
            r15[r3] = r7
            goto L385
        L465:
            if (r3 > r14) goto L46a
            goto L17d
        L46a:
            goto L17b
        L46e:
            r7 = r11[r7]
            goto L1f8
        L474:
            int r3 = r3 + r4
        L475:
            goto L432
        L479:
            int r9 = r9.getHeight()
            goto L1aa
        L481:
            goto L132
        L483:
            goto L374
        L487:
            r5 = r0
        L488:
            goto L1d4
    }

    private void MeasureChainWrap(androidx.constraintlayout.core.widgets.ConstraintWidget[] r20, int r21, int r22, int r23, int[] r24) {
            r19 = this;
            goto L1cf
        L4:
            if (r9 > 0) goto L9
            goto L59f
        L9:
            goto L4de
        Ld:
            r1 = r0
            goto L2f
        L12:
            if (r14 > 0) goto L17
            goto L15a
        L17:
            goto L1c9
        L1b:
            int r1 = r0.getWidth()
            goto L25d
        L23:
            goto L15f
        L25:
            goto L4f2
        L29:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r15.mBottom
            goto L496
        L2f:
            r0 = r3
            goto L692
        L34:
            r7 = r23
            goto L324
        L3a:
            r9 = 0
            goto L1fb
        L3f:
            if (r9 == r10) goto L44
            goto L312
        L44:
            goto L310
        L48:
            int r2 = r2 + r13
            goto L275
        L4d:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r15.mRight
            goto L53a
        L53:
            r12 = r0
            goto L42f
        L58:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r10 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.WRAP_CONTENT
            goto L3f
        L5e:
            int r2 = r1.mHorizontalGap
            goto Lda
        L64:
            return
        L65:
            goto L45b
        L69:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r15.mRight
            goto L29
        L6f:
            r0 = 12
            goto L591
        L76:
            int r10 = r23 - r10
            goto L603
        L7c:
            androidx.constraintlayout.core.widgets.ConstraintWidget r2 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r0)
            goto L67e
        L84:
            int r2 = r2 + 1
        L86:
            goto L1a3
        L8a:
            r1 = r22
            goto L5df
        L90:
            if (r14 > 0) goto L95
            goto L43b
        L95:
            goto L329
        L99:
            int r9 = r14 + 1
            goto L186
        L9f:
            if (r2 == 0) goto La4
            goto L652
        La4:
            goto L11e
        La8:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r2 = r1.mChainList
            goto L620
        Lae:
            r0 = r10
            goto L43f
        Lb3:
            goto L57d
        Lb5:
            goto L3ad
        Lb9:
            int r2 = r2 + r13
            goto L27a
        Lbe:
            if (r4 == 0) goto Lc3
            goto L652
        Lc3:
            goto L651
        Lc7:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r1.mRight
            goto L4f7
        Lcd:
            androidx.constraintlayout.core.widgets.ConstraintWidget r1 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r1)
            goto L4bc
        Ld5:
            r9 = r8
            goto L258
        Lda:
            int r2 = r2 + r3
            goto Lb9
        Ldf:
            r14 = r2
            goto L515
        Le4:
            goto L30c
        Le7:
            goto L458
        Leb:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r1.mRight
            goto L2de
        Lf1:
            if (r9 != r10) goto Lf6
            goto L1fd
        Lf6:
            goto L55f
        Lfa:
            r12 = r0
            goto L62d
        Lff:
            r0 = r2
            goto L2b6
        L104:
            int r1 = r0.getWidth()
            goto L2ac
        L10c:
            r7 = r6
            goto L679
        L111:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r4 = r10.getVerticalDimensionBehaviour()
            goto L56e
        L119:
            r9 = 1
        L11a:
            goto L352
        L11e:
            if (r9 > 0) goto L123
            goto L652
        L123:
            goto L632
        L127:
            int r0 = r0 + r11
            goto L12
        L12c:
            r2 = 0
        L12d:
            goto L41a
        L131:
            r16 = 1
            goto L283
        L137:
            return
        L138:
            goto Le4
        L13c:
            if (r4 == r5) goto L141
            goto L2d3
        L141:
            goto L2d1
        L145:
            int r13 = r0.Count
            goto L502
        L14d:
            int r0 = r0 + r1
            goto L47f
        L153:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r1.mLeft
            goto L23e
        L159:
            int r0 = r0 + r3
        L15a:
            goto L18e
        L15e:
            r9 = 0
        L15f:
            goto L2c8
        L163:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto L467
        L16a:
            if (r14 < r5) goto L16f
            goto Lb5
        L16f:
            goto L2a1
        L173:
            r0.clear()
            goto L1e9
        L17a:
            r2 = r0
            goto Ld5
        L17f:
            r0.Add(r10)
            goto L3f0
        L186:
            java.lang.object r5 = r5[r9)
            goto L193
        L18e:
            r3 = r1
            goto Ld
        L193:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r5 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r5
            goto L201
        L199:
            r3 = 0
            goto L2b1
        L19e:
            r0 = r10
            goto L423
        L1a3:
            r14 = r2
            goto L5ba
        L1a8:
            int r9 = r9 + 1
            goto L34
        L1ae:
            r10 = r20[r9]
            goto L49e
        L1b4:
            r10 = r23
            goto L296
        L1ba:
            if (r14 < r1) goto L1bf
            goto L23a
        L1bf:
            goto L382
        L1c3:
            r7 = r17
            goto L2e4
        L1c9:
            int r3 = r15.mVerticalGap
            goto L159
        L1cf:
            goto Le7
        L1d2:
            goto L6f
        L1d6:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r2 = r1.mChainList
            goto L567
        L1dc:
            r1 = r0
            goto Lff
        L1e1:
            int r10 = r9.getHeight()
            goto L76
        L1e9:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r0 = new androidx.constraintlayout.core.widgets.Flow$WidgetsList
            goto L29b
        L1ef:
            r16 = 1
            goto L434
        L1f5:
            r8 = r17
            goto L238
        L1fb:
            goto L11a
        L1fd:
            goto L119
        L201:
            androidx.constraintlayout.core.widgets.ConstraintWidget r5 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r5)
            goto L252
        L209:
            if (r9 > 0) goto L20e
            goto L56a
        L20e:
            goto L414
        L212:
            r2 = r18
        L214:
            goto L3b3
        L218:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r0 = new androidx.constraintlayout.core.widgets.Flow$WidgetsList
            goto L388
        L21e:
            if (r2 != 0) goto L223
            goto L5d2
        L223:
            goto L218
        L227:
            r1 = 0
        L228:
            goto L2ea
        L22c:
            r1 = r19
            goto L638
        L232:
            goto L368
        L234:
            goto L367
        L238:
            goto L68e
        L23a:
            goto L4d
        L23e:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r1.mTop
            goto Leb
        L244:
            java.lang.object r10 = r10[r14)
            goto L598
        L24c:
            goto L486
        L24e:
            goto L17a
        L252:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r5.mTop
            goto L55a
        L258:
            r0 = 0
            goto L3e5
        L25d:
            int r1 = java.lang.Math.max(r12, r1)
            goto L4d6
        L265:
            r0.setStartIndex(r9)
            goto L5fd
        L26c:
            if (r4 > 0) goto L271
            goto L59f
        L271:
            goto L44a
        L275:
            int r3 = r3 + r2
        L276:
            goto L17f
        L27a:
            if (r2 > r7) goto L27f
            goto L234
        L27f:
            goto L450
        L283:
            androidx.constraintlayout.core.widgets.ConstraintWidget r11 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r10)
            goto L474
        L28b:
            r2 = r22
            goto L3cc
        L291:
            int r1 = r1 + r13
            goto L5ac
        L296:
            r11 = r1
            goto L8a
        L29b:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r1.mLeft
            goto L6a3
        L2a1:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r5 = r15.mChainList
            goto L99
        L2a7:
            r4 = r3
            goto L63e
        L2ac:
            int r1 = r1 + r12
            goto L51e
        L2b1:
            r9 = 0
        L2b2:
            goto L338
        L2b6:
            r6 = r17
            goto L212
        L2bc:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r9 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r9
            goto L5ec
        L2c2:
            int r1 = r15.mVerticalGap
            goto L291
        L2c8:
            if (r9 < r8) goto L2cd
            goto L48c
        L2cd:
            goto L1ae
        L2d1:
            int r2 = r2 + 1
        L2d3:
            goto Ldf
        L2d7:
            r0.Add(r10)
            goto L1a8
        L2de:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r1.mBottom
            goto L371
        L2e4:
            goto L214
        L2e6:
            goto Lfa
        L2ea:
            if (r14 < r13) goto L2ef
            goto L379
        L2ef:
            goto L666
        L2f3:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r1 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r1
            goto Lcd
        L2f9:
            androidx.constraintlayout.core.widgets.ConstraintWidget r1 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r0)
            goto Lc7
        L301:
            java.lang.object r9 = r9[r2)
            goto L2bc
        L309:
            goto L138
        L30c:
            goto L22c
        L310:
            goto L1fd
        L312:
            goto L3a
        L316:
            r1 = r15
            goto L48a
        L31b:
            if (r2 != 0) goto L320
            goto L34e
        L320:
            goto L64b
        L324:
            r2 = r14
            goto L316
        L329:
            int r2 = r15.mHorizontalGap
            goto L43a
        L32f:
            if (r2 > r7) goto L334
            goto L463
        L334:
            goto L7c
        L338:
            if (r9 < r8) goto L33d
            goto L48c
        L33d:
            goto L5e6
        L341:
            int r1 = r13 + (-1)
            goto L1ba
        L347:
            r8 = r7
            goto L10c
        L34c:
            goto L5ad
        L34e:
            goto L3e0
        L352:
            if (r2 > 0) goto L357
            goto L24e
        L357:
            goto L39f
        L35b:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r1.mTop
            goto L429
        L361:
            int r10 = r23 - r10
            goto L5c3
        L367:
            r2 = 0
        L368:
            goto L9f
        L36c:
            r15 = r1
            goto L3da
        L371:
            r2 = r22
            goto L163
        L377:
            goto L228
        L379:
            goto L53
        L37d:
            r3 = r13
            goto L34c
        L382:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r15.mChainList
            goto L52f
        L388:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r1.mLeft
            goto L35b
        L38e:
            r17 = 0
            goto L1b4
        L394:
            r5 = r4
            goto L2a7
        L399:
            r2 = r22
            goto L5ca
        L39f:
            if (r9 != 0) goto L3a4
            goto L24e
        L3a4:
            goto L485
        L3a8:
            r2 = r14
            goto L23
        L3ad:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r15.mBottom
            goto L579
        L3b3:
            int r14 = r14 + 1
            goto L377
        L3b9:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r1.mRight
            goto L3ea
        L3bf:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r1.mBottom
            goto L28b
        L3c5:
            r0.setStartIndex(r9)
            goto L1d6
        L3cc:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto L3c5
        L3d3:
            r0.setup(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10)
            goto L104
        L3da:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r0 = r15.mChainList
            goto L145
        L3e0:
            r15 = r1
            goto L551
        L3e5:
            r14 = 0
            goto L347
        L3ea:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r1.mBottom
            goto L399
        L3f0:
            int r9 = r9 + 1
            goto L3a8
        L3f6:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r15.mTop
            goto L69
        L3fc:
            if (r22 == 0) goto L401
            goto L25
        L401:
            goto L510
        L405:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r9 = r15.mChainList
            goto L301
        L40b:
            if (r22 == 0) goto L410
            goto L2e6
        L410:
            goto L4d0
        L414:
            int r2 = r1.mHorizontalGap
            goto L48
        L41a:
            if (r2 == 0) goto L41f
            goto L59f
        L41f:
            goto L4
        L423:
            r20 = r11
            goto L38e
        L429:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r1.mRight
            goto L3bf
        L42f:
            r11 = r1
            goto L1ef
        L434:
            r17 = 0
            goto L542
        L43a:
            int r1 = r1 + r2
        L43b:
            goto L69e
        L43f:
            r16 = 1
            goto L615
        L445:
            r3 = 0
            goto L15e
        L44a:
            int r4 = r9 % r4
            goto L5a3
        L450:
            androidx.constraintlayout.core.widgets.ConstraintWidget r2 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r0)
            goto L5d6
        L458:
            goto L1d2
        L45b:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r0 = r1.mChainList
            goto L173
        L461:
            goto L12d
        L463:
            goto L12c
        L467:
            r15 = r1
            goto L265
        L46c:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r9 = r15.getHorizontalDimensionBehaviour()
            goto L4b6
        L474:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r11.mBottom
            goto L574
        L47a:
            r2 = 1
            goto L461
        L47f:
            int r0 = r0 % r1
            goto L65d
        L485:
            r2 = 0
        L486:
            goto L4e9
        L48a:
            goto L2b2
        L48c:
            goto L36c
        L490:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r5 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
            goto L13c
        L496:
            int r5 = r15.getPaddingLeft()
            goto L508
        L49e:
            int r13 = r1.getWidgetWidth(r10, r7)
            goto L4ae
        L4a6:
            int r13 = r1.getWidgetHeight(r10, r7)
            goto L111
        L4ae:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r4 = r10.getHorizontalDimensionBehaviour()
            goto L490
        L4b6:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r10 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.WRAP_CONTENT
            goto Lf1
        L4bc:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r1.mLeft
            goto L1f5
        L4c2:
            int r10 = r9.getWidth()
            goto L361
        L4ca:
            r24[r16] = r11
            goto L137
        L4d0:
            int r5 = r13 + (-1)
            goto L16a
        L4d6:
            int r0 = r0.getHeight()
            goto L127
        L4de:
            int r4 = r1.mMaxElementsWrap
            goto L26c
        L4e4:
            int r2 = r2 + r3
            goto L535
        L4e9:
            if (r2 < r13) goto L4ee
            goto L24e
        L4ee:
            goto L405
        L4f2:
            r2 = 0
            goto L199
        L4f7:
            r10 = r23
            goto L60f
        L4fd:
            r3 = r13
            goto L5d0
        L502:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r0 = r15.mLeft
            goto L3f6
        L508:
            int r6 = r15.getPaddingTop()
            goto L643
        L510:
            r2 = 0
            goto L445
        L515:
            if (r3 != r7) goto L51a
            goto L27f
        L51a:
            goto L5e
        L51e:
            int r0 = r0.getHeight()
            goto L589
        L526:
            if (r8 == 0) goto L52b
            goto L65
        L52b:
            goto L64
        L52f:
            int r4 = r14 + 1
            goto L581
        L535:
            int r2 = r2 + r13
            goto L32f
        L53a:
            int r4 = r15.getPaddingRight()
            goto L68d
        L542:
            r24[r17] = r12
            goto L4ca
        L548:
            if (r4 > 0) goto L54d
            goto L652
        L54d:
            goto L627
        L551:
            if (r9 > 0) goto L556
            goto L659
        L556:
            goto L2c2
        L55a:
            r9 = 0
            goto Lb3
        L55f:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r9 = r15.getVerticalDimensionBehaviour()
            goto L58
        L567:
            r2.Add(r0)
        L56a:
            goto L4fd
        L56e:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r5 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
            goto L5b1
        L574:
            r12 = r0
            goto L19e
        L579:
            int r9 = r15.getPaddingBottom()
        L57d:
            goto L131
        L581:
            java.lang.object r1 = r1[r4)
            goto L2f3
        L589:
            int r0 = java.lang.Math.max(r11, r0)
            goto L90
        L591:
            r1 = 4
            goto L14d
        L598:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r10 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r10
            goto L40b
        L59e:
            r2 = 1
        L59f:
            goto L31b
        L5a3:
            if (r4 == 0) goto L5a8
            goto L59f
        L5a8:
            goto L59e
        L5ac:
            int r3 = r3 + r1
        L5ad:
            goto L2d7
        L5b1:
            if (r4 == r5) goto L5b6
            goto L86
        L5b6:
            goto L84
        L5ba:
            if (r3 != r7) goto L5bf
            goto L334
        L5bf:
            goto L66c
        L5c3:
            r9.measureMatchConstraints(r10)
            goto L6a9
        L5ca:
            r7 = r23
            goto L672
        L5d0:
            goto L276
        L5d2:
            goto L209
        L5d6:
            if (r2 != 0) goto L5db
            goto L234
        L5db:
            goto L61b
        L5df:
            r0.setup(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10)
            goto L1b
        L5e6:
            r10 = r20[r9]
            goto L4a6
        L5ec:
            if (r22 == 0) goto L5f1
            goto L6ab
        L5f1:
            goto L4c2
        L5f5:
            int r8 = r15.getPaddingBottom()
            goto L46c
        L5fd:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r15.mChainList
            goto L656
        L603:
            r9.measureMatchConstraints(r10)
        L606:
            goto L687
        L60a:
            r4 = r1
            goto L2f9
        L60f:
            r18 = r1
            goto L698
        L615:
            r17 = 0
            goto L341
        L61b:
            r2 = 1
            goto L232
        L620:
            r2.Add(r0)
            goto L3fc
        L627:
            int r4 = r9 % r4
            goto Lbe
        L62d:
            r11 = r1
            goto Lae
        L632:
            int r4 = r1.mMaxElementsWrap
            goto L548
        L638:
            r8 = r21
            goto L526
        L63e:
            r3 = r1
            goto L227
        L643:
            int r7 = r15.getPaddingRight()
            goto L5f5
        L64b:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r0 = new androidx.constraintlayout.core.widgets.Flow$WidgetsList
            goto L153
        L651:
            r2 = 1
        L652:
            goto L21e
        L656:
            r1.Add(r0)
        L659:
            goto L37d
        L65d:
            if (r0 <= 0) goto L662
            goto L30c
        L662:
            goto L309
        L666:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r10 = r15.mChainList
            goto L244
        L66c:
            int r2 = r1.mVerticalGap
            goto L4e4
        L672:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto La8
        L679:
            r6 = r5
            goto L394
        L67e:
            if (r2 != 0) goto L683
            goto L463
        L683:
            goto L47a
        L687:
            int r2 = r2 + 1
            goto L24c
        L68d:
            r8 = r4
        L68e:
            goto L60a
        L692:
            r3 = r20
            goto L1c3
        L698:
            r1 = r22
            goto L3d3
        L69e:
            r2 = r1
            goto L1dc
        L6a3:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r1.mTop
            goto L3b9
        L6a9:
            goto L606
        L6ab:
            goto L1e1
    }

    private void MeasureChainWrapNew(androidx.constraintlayout.core.widgets.ConstraintWidget[] r20, int r21, int r22, int r23, int[] r24) {
            r19 = this;
            goto L62a
        L4:
            int r3 = r3 + r13
            goto L4de
        L9:
            r0.Add(r10)
            goto L5eb
        L10:
            goto L46a
        L13:
            goto L60a
        L17:
            r3 = 0
            goto L57
        L1c:
            int r5 = r1.mMaxElementsWrap
            goto L49b
        L22:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r0 = new androidx.constraintlayout.core.widgets.Flow$WidgetsList
            goto L2a3
        L28:
            r9 = 0
            goto L477
        L2d:
            if (r9 != r10) goto L32
            goto L373
        L32:
            goto L1f3
        L36:
            androidx.constraintlayout.core.widgets.ConstraintWidget r3 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r0)
            goto L68f
        L3e:
            int r9 = r15.getPaddingBottom()
        L42:
            goto L5ca
        L46:
            return
        L47:
            goto L10
        L4b:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r1 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r1
            goto L17c
        L51:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r15.mRight
            goto L4cd
        L57:
            r4 = 0
            goto L34e
        L5c:
            r16 = 0
            goto L674
        L62:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r6 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
            goto L35c
        L68:
            int r9 = r14 + 1
            goto L37c
        L6e:
            r0.setup(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10)
            goto L1ac
        L75:
            r0.setup(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10)
            goto L653
        L7c:
            r10 = r20[r9]
            goto L1d8
        L82:
            r2 = r22
            goto L510
        L88:
            if (r3 == 0) goto L8d
            goto L2ce
        L8d:
            goto L452
        L91:
            r18 = r1
            goto L1cc
        L97:
            if (r14 < r1) goto L9c
            goto L4c9
        L9c:
            goto L566
        La0:
            r14 = r3
            goto L144
        La5:
            r0 = r10
            goto L624
        Laa:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r1.mLeft
            goto L1ed
        Lb0:
            int r3 = r3 + 1
        Lb2:
            goto L229
        Lb6:
            if (r9 > 0) goto Lbb
            goto L3a4
        Lbb:
            goto L489
        Lbf:
            r16 = 0
            goto L3de
        Lc5:
            r6 = r5
            goto L4f1
        Lca:
            if (r3 > 0) goto Lcf
            goto L294
        Lcf:
            goto L1be
        Ld3:
            r3 = r1
            goto L51c
        Ld8:
            goto L4e4
        Lda:
            goto L4e3
        Lde:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r2 = r15.mRight
            goto L29d
        Le4:
            int r10 = r9.getHeight()
            goto L45b
        Lec:
            int r0 = r0 + r1
            goto L1d2
        Lf2:
            r14 = 0
            goto L1b4
        Lf7:
            androidx.constraintlayout.core.widgets.ConstraintWidget r1 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r0)
            goto L4a9
        Lff:
            if (r14 > 0) goto L104
            goto L620
        L104:
            goto L60d
        L108:
            androidx.constraintlayout.core.widgets.ConstraintWidget r3 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r0)
            goto L205
        L110:
            if (r9 < r8) goto L115
            goto L318
        L115:
            goto L3d9
        L119:
            r0 = r10
            goto L138
        L11e:
            r0.Add(r10)
            goto L282
        L125:
            r2 = 0
            goto L17
        L12a:
            int r5 = r15.getPaddingLeft()
            goto L58d
        L132:
            r10 = r23
            goto L91
        L138:
            r1 = r22
            goto L430
        L13e:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r1.mBottom
            goto L689
        L144:
            if (r4 != r7) goto L149
            goto L3b5
        L149:
            goto L483
        L14d:
            goto L492
        L14f:
            goto Le4
        L153:
            r24[r17] = r11
            goto L46
        L159:
            r2.Add(r0)
            goto L377
        L160:
            r24[r16] = r12
            goto L153
        L166:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r9 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r9
            goto L584
        L16c:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r15.mChainList
            goto L6a9
        L172:
            r9 = r12
        L173:
            goto Lca
        L177:
            r2 = r1
            goto L6c3
        L17c:
            androidx.constraintlayout.core.widgets.ConstraintWidget r1 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r1)
            goto L3fa
        L184:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r10 = r15.mChainList
            goto L1a4
        L18a:
            int r4 = r4 + r1
        L18b:
            goto L9
        L18f:
            if (r22 == 0) goto L194
            goto L40d
        L194:
            goto L2fe
        L198:
            int r10 = r23 - r10
            goto L5a1
        L19e:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r1.mRight
            goto L13e
        L1a4:
            java.lang.object r10 = r10[r14)
            goto L5dc
        L1ac:
            int r1 = r0.getWidth()
            goto L55e
        L1b4:
            r8 = r7
            goto L1c7
        L1b9:
            r3 = r14
            goto L3ed
        L1be:
            if (r9 != 0) goto L1c3
            goto L294
        L1c3:
            goto L52d
        L1c7:
            r7 = r6
            goto Lc5
        L1cc:
            r1 = r22
            goto L75
        L1d2:
            int r0 = r0 % r1
            goto L631
        L1d8:
            int r13 = r1.getWidgetHeight(r10, r7)
            goto L25f
        L1e0:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto L42a
        L1e7:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r1.mLeft
            goto L461
        L1ed:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r1.mTop
            goto L19e
        L1f3:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r9 = r15.getVerticalDimensionBehaviour()
            goto L22e
        L1fb:
            r15 = r1
            goto L333
        L200:
            r15 = r1
            goto L549
        L205:
            if (r3 != 0) goto L20a
            goto Lda
        L20a:
            goto L649
        L20e:
            if (r9 < r8) goto L213
            goto L318
        L213:
            goto L3b9
        L217:
            r3 = r14
            goto L613
        L21c:
            r4 = r1
            goto Lf7
        L221:
            java.lang.object r1 = r1[r4)
            goto L4b
        L229:
            r14 = r3
            goto L680
        L22e:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r10 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.WRAP_CONTENT
            goto L279
        L234:
            int r7 = r15.getPaddingRight()
            goto L65b
        L23c:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r0 = r15.mLeft
            goto L604
        L242:
            int r3 = r1.mHorizontalGap
            goto L4
        L248:
            r4 = r13
            goto L53e
        L24d:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto L272
        L254:
            r11 = r1
            goto L502
        L259:
            r2 = r18
        L25b:
            goto L41f
        L25f:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r5 = r10.getVerticalDimensionBehaviour()
            goto L62
        L267:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r10 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.WRAP_CONTENT
            goto L2d
        L26d:
            r4 = 0
            goto L425
        L272:
            r0.setStartIndex(r9)
            goto L2af
        L279:
            if (r9 == r10) goto L27e
            goto L578
        L27e:
            goto L576
        L282:
            int r9 = r9 + 1
            goto L217
        L288:
            r2 = r0
            goto L644
        L28d:
            r0 = r2
            goto L2a9
        L292:
            goto L52e
        L294:
            goto Ld3
        L298:
            r3 = 0
            goto L26d
        L29d:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r15.mBottom
            goto L12a
        L2a3:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r1.mLeft
            goto L2bb
        L2a9:
            r6 = r16
            goto L259
        L2af:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r2 = r1.mChainList
            goto L365
        L2b5:
            r2 = r22
            goto L24d
        L2bb:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r1.mTop
            goto L543
        L2c1:
            r7 = r23
            goto L1b9
        L2c7:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r6 = androidx.constraintlayout.core.widgets.ConstraintWidget.DimensionBehaviour.MATCH_CONSTRAINT
            goto L5e2
        L2cd:
            r3 = r12
        L2ce:
            goto L324
        L2d2:
            if (r3 > r7) goto L2d7
            goto Lda
        L2d7:
            goto L108
        L2db:
            if (r8 == 0) goto L2e0
            goto L43c
        L2e0:
            goto L43b
        L2e4:
            int r13 = r0.Count
            goto L23c
        L2ec:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r1.mRight
            goto L3d3
        L2f2:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r11 = r11.mBottom
            goto L527
        L2f8:
            r17 = r12
            goto L38f
        L2fe:
            int r5 = r13 + (-1)
            goto L353
        L304:
            goto L18b
        L306:
            goto L200
        L30a:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r9 = r15.getHorizontalDimensionBehaviour()
            goto L267
        L312:
            r3 = r1
            goto L63f
        L317:
            goto L34f
        L318:
            goto L1fb
        L31c:
            java.lang.object r9 = r9[r3)
            goto L166
        L324:
            if (r3 != 0) goto L329
            goto L306
        L329:
            goto L348
        L32d:
            int r3 = r3 + 1
        L32f:
            goto La0
        L333:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r0 = r15.mChainList
            goto L2e4
        L339:
            if (r3 == 0) goto L33e
            goto L3a4
        L33e:
            goto Lb6
        L342:
            int r3 = r1.mVerticalGap
            goto L406
        L348:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r0 = new androidx.constraintlayout.core.widgets.Flow$WidgetsList
            goto L1e7
        L34e:
            r9 = 0
        L34f:
            goto L20e
        L353:
            if (r14 < r5) goto L358
            goto L479
        L358:
            goto L538
        L35c:
            if (r5 == r6) goto L361
            goto Lb2
        L361:
            goto Lb0
        L365:
            r2.Add(r0)
            goto L411
        L36c:
            r2 = 0
            goto L298
        L371:
            goto L173
        L373:
            goto L172
        L377:
            r12 = 1
            goto L4d5
        L37c:
            java.lang.object r5 = r5[r9)
            goto L5c4
        L384:
            r3 = r12
            goto L5d7
        L389:
            r17 = r12
            goto Lbf
        L38f:
            r12 = r0
            goto L3c6
        L394:
            if (r14 < r13) goto L399
            goto L534
        L399:
            goto L184
        L39d:
            r7 = r16
            goto L40b
        L3a3:
            r3 = r12
        L3a4:
            goto L5b0
        L3a8:
            int r13 = r1.getWidgetWidth(r10, r7)
            goto L5f1
        L3b0:
            if (r3 > r7) goto L3b5
            goto L5d8
        L3b5:
            goto L36
        L3b9:
            int r2 = r2 + r12
            goto L7c
        L3be:
            androidx.constraintlayout.core.widgets.ConstraintWidget r5 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r5)
            goto L400
        L3c6:
            r11 = r1
            goto L119
        L3cb:
            int r0 = r0.getHeight()
            goto L571
        L3d3:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r1.mBottom
            goto L82
        L3d9:
            int r2 = r2 + r12
            goto L521
        L3de:
            r12 = r0
            goto La5
        L3e3:
            int r3 = r3 + r4
            goto L63a
        L3e8:
            int r1 = r1 + r13
            goto L18a
        L3ed:
            r1 = r15
            goto L317
        L3f2:
            androidx.constraintlayout.core.widgets.ConstraintWidget r11 = androidx.constraintlayout.core.widgets.Flow.WidgetsList.access$2000(r10)
            goto L2f2
        L3fa:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r1.mLeft
            goto L6bd
        L400:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r5.mTop
            goto L28
        L406:
            int r3 = r3 + r4
            goto L69e
        L40b:
            goto L25b
        L40d:
            goto L64e
        L411:
            r2 = r12
        L412:
            goto L248
        L416:
            if (r5 > 0) goto L41b
            goto L3a4
        L41b:
            goto L46e
        L41f:
            int r14 = r14 + 1
            goto L59b
        L425:
            r9 = 0
        L426:
            goto L110
        L42a:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r2 = r1.mChainList
            goto L159
        L430:
            r10 = r23
            goto L6e
        L436:
            r9 = 0
            goto L371
        L43b:
            return
        L43c:
            goto L4c2
        L440:
            if (r14 > 0) goto L445
            goto L600
        L445:
            goto L698
        L449:
            if (r2 > r5) goto L44e
            goto L2ce
        L44e:
            goto L2cd
        L452:
            if (r9 > 0) goto L457
            goto L2ce
        L457:
            goto L1c
        L45b:
            int r10 = r23 - r10
            goto L48f
        L461:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r1.mTop
            goto L2ec
        L467:
            goto L47
        L46a:
            goto L552
        L46e:
            if (r2 > r5) goto L473
            goto L3a4
        L473:
            goto L3a3
        L477:
            goto L42
        L479:
            goto L595
        L47d:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r1.mBottom
            goto L2b5
        L483:
            int r3 = r1.mHorizontalGap
            goto L3e3
        L489:
            int r5 = r1.mMaxElementsWrap
            goto L416
        L48f:
            r9.measureMatchConstraints(r10)
        L492:
            goto L4f6
        L496:
            r15 = r1
            goto L6b6
        L49b:
            if (r5 > 0) goto L4a0
            goto L2ce
        L4a0:
            goto L449
        L4a4:
            r1 = 0
            goto Lf2
        L4a9:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r1.mRight
            goto L132
        L4af:
            r8 = r4
        L4b0:
            goto L21c
        L4b4:
            r4 = r2
            goto L288
        L4b9:
            if (r3 < r13) goto L4be
            goto L294
        L4be:
            goto L6b0
        L4c2:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r0 = r1.mChainList
            goto L679
        L4c8:
            goto L4b0
        L4c9:
            goto L51
        L4cd:
            int r4 = r15.getPaddingRight()
            goto L4af
        L4d5:
            if (r22 == 0) goto L4da
            goto L615
        L4da:
            goto L36c
        L4de:
            int r4 = r4 + r3
        L4df:
            goto L11e
        L4e3:
            r3 = 0
        L4e4:
            goto L88
        L4e8:
            if (r9 > 0) goto L4ed
            goto L412
        L4ed:
            goto L242
        L4f1:
            r5 = r4
            goto L4b4
        L4f6:
            int r3 = r3 + 1
            goto L292
        L4fc:
            r7 = r23
            goto L1e0
        L502:
            r17 = r12
            goto L5c
        L508:
            int r0 = java.lang.Math.max(r11, r0)
            goto Lff
        L510:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto L496
        L517:
            r0 = r3
            goto L619
        L51c:
            r9 = r8
            goto L4a4
        L521:
            r10 = r20[r9]
            goto L3a8
        L527:
            r20 = r11
            goto L2f8
        L52d:
            r3 = 0
        L52e:
            goto L4b9
        L532:
            goto L645
        L534:
            goto L254
        L538:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r5 = r15.mChainList
            goto L68
        L53e:
            goto L4df
        L53f:
            goto L4e8
        L543:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r1.mRight
            goto L47d
        L549:
            if (r9 > 0) goto L54e
            goto L664
        L54e:
            goto L558
        L552:
            r1 = r19
            goto L6a3
        L558:
            int r1 = r15.mVerticalGap
            goto L3e8
        L55e:
            int r1 = java.lang.Math.max(r12, r1)
            goto L3cb
        L566:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r15.mChainList
            goto L5f9
        L56c:
            r3 = 0
        L56d:
            goto L339
        L571:
            int r0 = r0 + r11
            goto L440
        L576:
            goto L373
        L578:
            goto L436
        L57c:
            int r10 = r9.getWidth()
            goto L198
        L584:
            if (r22 == 0) goto L589
            goto L14f
        L589:
            goto L57c
        L58d:
            int r6 = r15.getPaddingTop()
            goto L234
        L595:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r15.mBottom
            goto L3e
        L59b:
            r12 = r17
            goto L532
        L5a1:
            r9.measureMatchConstraints(r10)
            goto L14d
        L5a8:
            int r0 = r0.getHeight()
            goto L508
        L5b0:
            if (r3 != 0) goto L5b5
            goto L53f
        L5b5:
            goto L22
        L5b9:
            int r1 = r1 + r12
            goto L5a8
        L5be:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r0 = new androidx.constraintlayout.core.widgets.Flow$WidgetsList
            goto Laa
        L5c4:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r5 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r5
            goto L3be
        L5ca:
            r16 = 0
            goto L3f2
        L5d0:
            r1 = 16
            goto Lec
        L5d7:
            goto L56d
        L5d8:
            goto L56c
        L5dc:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r10 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r10
            goto L18f
        L5e2:
            if (r5 == r6) goto L5e7
            goto L32f
        L5e7:
            goto L32d
        L5eb:
            int r9 = r9 + 1
            goto L2c1
        L5f1:
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour r5 = r10.getHorizontalDimensionBehaviour()
            goto L2c7
        L5f9:
            int r4 = r14 + 1
            goto L221
        L5ff:
            int r0 = r0 + r3
        L600:
            goto L312
        L604:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r1 = r15.mTop
            goto Lde
        L60a:
            goto L62d
        L60d:
            int r2 = r15.mHorizontalGap
            goto L61f
        L613:
            goto L426
        L615:
            goto L125
        L619:
            r3 = r20
            goto L39d
        L61f:
            int r1 = r1 + r2
        L620:
            goto L177
        L624:
            int r1 = r13 + (-1)
            goto L97
        L62a:
            goto L13
        L62d:
            goto L668
        L631:
            if (r0 <= 0) goto L636
            goto L46a
        L636:
            goto L467
        L63a:
            int r3 = r3 + r13
            goto L3b0
        L63f:
            r1 = r0
            goto L517
        L644:
            r0 = 0
        L645:
            goto L394
        L649:
            r3 = r12
            goto Ld8
        L64e:
            r11 = r1
            goto L389
        L653:
            int r1 = r0.getWidth()
            goto L5b9
        L65b:
            int r8 = r15.getPaddingBottom()
            goto L30a
        L663:
            r2 = r12
        L664:
            goto L66f
        L668:
            r0 = 9
            goto L5d0
        L66f:
            r4 = r13
            goto L304
        L674:
            r12 = r0
            goto L160
        L679:
            r0.clear()
            goto L5be
        L680:
            if (r4 != r7) goto L685
            goto L2d7
        L685:
            goto L342
        L689:
            r2 = r22
            goto L4fc
        L68f:
            if (r3 != 0) goto L694
            goto L5d8
        L694:
            goto L384
        L698:
            int r3 = r15.mVerticalGap
            goto L5ff
        L69e:
            int r3 = r3 + r13
            goto L2d2
        L6a3:
            r8 = r21
            goto L2db
        L6a9:
            r1.Add(r0)
            goto L663
        L6b0:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r9 = r15.mChainList
            goto L31c
        L6b6:
            r0.setStartIndex(r9)
            goto L16c
        L6bd:
            r8 = r16
            goto L4c8
        L6c3:
            r1 = r0
            goto L28d
    }

    private void MeasureNoWrap(androidx.constraintlayout.core.widgets.ConstraintWidget[] r22, int r23, int r24, int r25, int[] r26) {
            r21 = this;
            goto L50
        L4:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r5 = r1.mRight
            goto L73
        La:
            goto Le6
        Lc:
            goto L119
        L10:
            r0 = 9
            goto L166
        L17:
            java.lang.object r0 = r0[r9)
            goto Lea
        L1f:
            int r19 = r1.getPaddingBottom()
            goto L121
        L27:
            goto La2
        L2a:
            goto L5d
        L2e:
            r1.Add(r0)
            goto L6e
        L35:
            r26[r9] = r1
            goto L15e
        L3b:
            int r16 = r1.getPaddingLeft()
            goto L60
        L43:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto L68
        L4a:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r0 = new androidx.constraintlayout.core.widgets.Flow$WidgetsList
            goto Lc7
        L50:
            goto L2a
        L53:
            goto L10
        L57:
            r20 = r25
            goto Lcd
        L5d:
            goto L53
        L60:
            int r17 = r1.getPaddingTop()
            goto L16d
        L68:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r1.mChainList
            goto L2e
        L6e:
            goto Ld5
        L6f:
            goto Lb2
        L73:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r6 = r1.mBottom
            goto Lac
        L79:
            return
        L7a:
            goto L27
        L7e:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r0 = r1.mChainList
            goto L104
        L84:
            if (r8 == 0) goto L89
            goto L143
        L89:
            goto L142
        L8d:
            int r0 = r0 + r1
            goto L10c
        L93:
            r2 = r22[r1]
            goto L12d
        L99:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r10 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r10
            goto L112
        L9f:
            goto L7a
        La2:
            goto L147
        La6:
            r8 = r23
            goto L84
        Lac:
            r2 = r24
            goto L153
        Lb2:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r0 = r1.mChainList
            goto L17
        Lb8:
            if (r1 < r8) goto Lbd
            goto Lc
        Lbd:
            goto L93
        Lc1:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r15 = r1.mBottom
            goto L3b
        Lc7:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r3 = r1.mLeft
            goto Lfe
        Lcd:
            r10.setup(r11, r12, r13, r14, r15, r16, r17, r18, r19, r20)
            goto Ld4
        Ld4:
            r0 = r10
        Ld5:
            goto Le5
        Ld9:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r12 = r1.mLeft
            goto L14d
        Ldf:
            int r1 = r1 + 1
            goto La
        Le5:
            r1 = r9
        Le6:
            goto Lb8
        Lea:
            r10 = r0
            goto L99
        Lef:
            r26[r1] = r0
            goto L79
        Lf5:
            if (r0 <= 0) goto Lfa
            goto La2
        Lfa:
            goto L9f
        Lfe:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r4 = r1.mTop
            goto L4
        L104:
            int r0 = r0.Count
            goto L13d
        L10c:
            int r0 = r0 % r1
            goto Lf5
        L112:
            r10.clear()
            goto Ld9
        L119:
            int r1 = r0.getWidth()
            goto L35
        L121:
            r11 = r24
            goto L57
        L127:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r14 = r1.mRight
            goto Lc1
        L12d:
            r0.Add(r2)
            goto Ldf
        L134:
            if (r0 == 0) goto L139
            goto L6f
        L139:
            goto L4a
        L13d:
            r9 = 0
            goto L134
        L142:
            return
        L143:
            goto L7e
        L147:
            r1 = r21
            goto La6
        L14d:
            androidx.constraintlayout.core.widgets.ConstraintAnchor r13 = r1.mTop
            goto L127
        L153:
            r7 = r25
            goto L43
        L159:
            r1 = 1
            goto Lef
        L15e:
            int r0 = r0.getHeight()
            goto L159
        L166:
            r1 = 32
            goto L8d
        L16d:
            int r18 = r1.getPaddingRight()
            goto L1f
    }

    @Override // androidx.constraintlayout.core.widgets.ConstraintWidget
    public void AddToSolver(androidx.constraintlayout.core.LinearSystem r6, bool r7) {
            r5 = this;
            goto L51
        L4:
            if (r6 != 0) goto L9
            goto L109
        L9:
            goto Lc4
        Ld:
            r3.createConstraints(r6, r2, r4)
            goto L16b
        L14:
            if (r2 < r1) goto L19
            goto L20
        L19:
            goto L165
        L1d:
            r1.createConstraints(r6, r7, r0)
        L20:
            goto L19b
        L24:
            java.lang.object r1 = r1[r7)
            goto L1ac
        L2c:
            r5.createAlignedConstraints(r6)
            goto L9b
        L33:
            java.lang.object r3 = r3[r2)
            goto L90
        L3b:
            int r1 = r1.Count
            goto L58
        L43:
            if (r2 < r1) goto L48
            goto L20
        L48:
            goto L1d0
        L4c:
            goto L20
        L4d:
            goto L125
        L51:
            goto L15b
        L54:
            goto L1b8
        L58:
            r2 = r7
        L59:
            goto L14
        L5d:
            goto L54
        L60:
            r2 = 3
            goto L75
        L65:
            int r1 = r1.Count
            goto Lc9
        L6d:
            androidx.constraintlayout.core.widgets.ConstraintWidget r6 = r5.getParent()
            goto L10d
        L75:
            if (r1 != r2) goto L7a
            goto L4d
        L7a:
            goto L4c
        L7e:
            r1 = 11
            goto Led
        L85:
            r4 = r0
            goto Lce
        L8a:
            androidx.constraintlayout.core.widgets.ConstraintWidgetContainer r6 = (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) r6
            goto Ldc
        L90:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r3 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r3
            goto Lbe
        L96:
            return
        L97:
            goto L158
        L9b:
            goto L20
        L9c:
            goto L134
        La0:
            if (r0 <= 0) goto La5
            goto L154
        La5:
            goto L151
        La9:
            r3.createConstraints(r6, r2, r4)
            goto L195
        Lb0:
            if (r1 > 0) goto Lb5
            goto L20
        Lb5:
            goto L1bf
        Lb9:
            r4 = r7
        Lba:
            goto Ld
        Lbe:
            int r4 = r1 + (-1)
            goto L12b
        Lc4:
            r6 = r0
            goto L107
        Lc9:
            r2 = r7
        Lca:
            goto L43
        Lce:
            goto L14d
        Lcf:
            goto L14c
        Ld3:
            if (r1 != r0) goto Ld8
            goto L9c
        Ld8:
            goto L1c5
        Ldc:
            bool r6 = r6.isRtl()
            goto L4
        Le4:
            if (r1 != 0) goto Le9
            goto L161
        Le9:
            goto Ld3
        Led:
            int r0 = r0 + r1
            goto L119
        Lf3:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r3 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r3
            goto L1ca
        Lf9:
            if (r1 != r2) goto Lfe
            goto L191
        Lfe:
            goto L60
        L102:
            r4 = r0
            goto L179
        L107:
            goto L1a8
        L109:
            goto L1a7
        L10d:
            r7 = 0
            goto L1a2
        L112:
            super.addToSolver(r6, r7)
            goto L6d
        L119:
            int r0 = r0 % r1
            goto La0
        L11f:
            int r1 = r5.mWrapMode
            goto Le4
        L125:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r5.mChainList
            goto L3b
        L12b:
            if (r2 == r4) goto L130
            goto Lcf
        L130:
            goto L85
        L134:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r5.mChainList
            goto L65
        L13a:
            if (r6 != 0) goto L13f
            goto L109
        L13f:
            goto L187
        L143:
            if (r2 == r4) goto L148
            goto L17b
        L148:
            goto L102
        L14c:
            r4 = r7
        L14d:
            goto La9
        L151:
            goto L97
        L154:
            goto L112
        L158:
            goto L154
        L15b:
            goto L5d
        L15f:
            goto Lca
        L161:
            goto L1b2
        L165:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r3 = r5.mChainList
            goto L33
        L16b:
            int r2 = r2 + 1
            goto L15f
        L171:
            java.lang.object r3 = r3[r2)
            goto Lf3
        L179:
            goto Lba
        L17b:
            goto Lb9
        L17f:
            int r1 = r1.Count
            goto Lb0
        L187:
            androidx.constraintlayout.core.widgets.ConstraintWidget r6 = r5.getParent()
            goto L8a
        L18f:
            goto L59
        L191:
            goto L2c
        L195:
            int r2 = r2 + 1
            goto L18f
        L19b:
            r5.needsCallbackFromSolver(r7)
            goto L96
        L1a2:
            r0 = 1
            goto L13a
        L1a7:
            r6 = r7
        L1a8:
            goto L11f
        L1ac:
            androidx.constraintlayout.core.widgets.Flow$WidgetsList r1 = (androidx.constraintlayout.core.widgets.Flow.WidgetsList) r1
            goto L1d
        L1b2:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r5.mChainList
            goto L17f
        L1b8:
            r0 = 15
            goto L7e
        L1bf:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r1 = r5.mChainList
            goto L24
        L1c5:
            r2 = 2
            goto Lf9
        L1ca:
            int r4 = r1 + (-1)
            goto L143
        L1d0:
            java.util.List<androidx.constraintlayout.core.widgets.Flow$WidgetsList> r3 = r5.mChainList
            goto L171
    }

    @Override // androidx.constraintlayout.core.widgets.HelperWidget, androidx.constraintlayout.core.widgets.ConstraintWidget
    public void Copy(androidx.constraintlayout.core.widgets.ConstraintWidget r1, java.util.HashDictionary<androidx.constraintlayout.core.widgets.ConstraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget> r2) {
            r0 = this;
            goto L1c
        L4:
            r0.mMaxElementsWrap = r2
            goto Ld4
        La:
            r0.mFirstVerticalStyle = r2
            goto L5f
        L10:
            r0.mHorizontalGap = r2
            goto L99
        L16:
            r0.mLastVerticalBias = r2
            goto La5
        L1c:
            goto Lb2
        L1f:
            goto L77
        L23:
            r0.mLastHorizontalStyle = r2
            goto Lf8
        L29:
            r0.mWrapMode = r2
            goto Le6
        L2f:
            r0.mFirstVerticalBias = r2
            goto L6b
        L35:
            r0.mHorizontalAlign = r2
            goto L59
        L3b:
            r0.mLastHorizontalBias = r2
            goto Lb6
        L41:
            float r2 = r1.mHorizontalBias
            goto Lc2
        L47:
            r0.mLastVerticalStyle = r2
            goto L41
        L4d:
            int r2 = r1.mFirstHorizontalStyle
            goto Le0
        L53:
            androidx.constraintlayout.core.widgets.Flow r1 = (androidx.constraintlayout.core.widgets.Flow) r1
            goto L65
        L59:
            int r2 = r1.mVerticalAlign
            goto L9f
        L5f:
            int r2 = r1.mLastHorizontalStyle
            goto L23
        L65:
            int r2 = r1.mHorizontalStyle
            goto Lbc
        L6b:
            float r2 = r1.mLastHorizontalBias
            goto L3b
        L71:
            float r2 = r1.mVerticalBias
            goto L93
        L77:
            super.copy(r1, r2)
            goto L53
        L7e:
            goto L1f
        L81:
            float r2 = r1.mFirstVerticalBias
            goto L2f
        L87:
            r0.mVerticalGap = r2
            goto Lc8
        L8d:
            int r2 = r1.mWrapMode
            goto L29
        L93:
            r0.mVerticalBias = r2
            goto Lfe
        L99:
            int r2 = r1.mVerticalGap
            goto L87
        L9f:
            r0.mVerticalAlign = r2
            goto L8d
        La5:
            int r2 = r1.mHorizontalGap
            goto L10
        Lab:
            r0.mVerticalStyle = r2
            goto L4d
        Lb1:
            return
        Lb2:
            goto L7e
        Lb6:
            float r2 = r1.mLastVerticalBias
            goto L16
        Lbc:
            r0.mHorizontalStyle = r2
            goto Lda
        Lc2:
            r0.mHorizontalBias = r2
            goto L71
        Lc8:
            int r2 = r1.mHorizontalAlign
            goto L35
        Lce:
            r0.mOrientation = r1
            goto Lb1
        Ld4:
            int r1 = r1.mOrientation
            goto Lce
        Lda:
            int r2 = r1.mVerticalStyle
            goto Lab
        Le0:
            r0.mFirstHorizontalStyle = r2
            goto Lf2
        Le6:
            int r2 = r1.mMaxElementsWrap
            goto L4
        Lec:
            r0.mFirstHorizontalBias = r2
            goto L81
        Lf2:
            int r2 = r1.mFirstVerticalStyle
            goto La
        Lf8:
            int r2 = r1.mLastVerticalStyle
            goto L47
        Lfe:
            float r2 = r1.mFirstHorizontalBias
            goto Lec
    }

    public float GetMaxElementsWrap() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            float r0 = (float) r0
            goto L19
        Lc:
            int r0 = r0.mMaxElementsWrap
            goto L7
        L12:
            goto L1a
        L15:
            goto Lc
        L19:
            return r0
        L1a:
            goto L4
    }

    @Override // androidx.constraintlayout.core.widgets.VirtualLayout
    public void Measure(int r20, int r21, int r22, int r23) {
            r19 = this;
            goto L1e2
        L4:
            r2 = r5[r16]
            goto L285
        La:
            int r3 = r0.mOrientation
            goto L1f5
        L10:
            r1 = 1
            goto L1e9
        L17:
            r9 = r23
            goto L2b9
        L1d:
            int r3 = r0.mWrapMode
            goto L28a
        L23:
            if (r1 > 0) goto L28
            goto L184
        L28:
            goto L366
        L2c:
            r1 = 2
            goto L11f
        L31:
            int r10 = r10 + 1
            goto L3a4
        L37:
            r0.setWidth(r1)
            goto L246
        L3e:
            r3 = r17
            goto Le4
        L44:
            int r13 = r0.getPaddingTop()
            goto L154
        L4c:
            goto L1f8
        L4e:
            goto L1b2
        L52:
            r10 = 3
            goto Lcf
        L57:
            if (r0 <= 0) goto L5c
            goto L397
        L5c:
            goto L394
        L60:
            if (r8 == r4) goto L65
            goto L384
        L65:
            goto L2fa
        L69:
            r1 = r2
        L6a:
            goto L299
        L6e:
            r0 = r19
            goto L316
        L74:
            r1 = r7
            goto L31c
        L79:
            r16 = 1
            goto L4
        L7f:
            r1 = r5[r17]
            goto L24d
        L85:
            goto Le5
        L86:
            goto L203
        L8a:
            r10 = r16
            goto L93
        L90:
            goto L1e5
        L93:
            goto L3b8
        L95:
            goto L3b6
        L99:
            if (r2 != r1) goto L9e
            goto L198
        L9e:
            goto Le9
        La2:
            int r2 = r7 - r11
            goto L191
        La8:
            r0.needsCallbackFromSolver(r10)
            goto L258
        Laf:
            if (r3 == r2) goto Lb4
            goto L237
        Lb4:
            goto L235
        Lb8:
            goto Lcb
        Lb9:
            goto L1be
        Lbd:
            int r3 = r0.mHorizontalStyle
            goto Laf
        Lc3:
            goto L1f8
        Lc5:
            goto L22f
        Lc9:
            r2 = r17
        Lcb:
            goto L1fc
        Lcf:
            if (r3 != r10) goto Ld4
            goto L273
        Ld4:
            goto L272
        Ld8:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r15 = r0.mWidgets
            goto L119
        Lde:
            r0.mDisplayedWidgets = r1
            goto L304
        Le4:
            r10 = r3
        Le5:
            goto Lef
        Le9:
            r18[r3] = r15
            goto L196
        Lef:
            int r15 = r0.mWidgetsCount
            goto L321
        Lf5:
            if (r3 != r10) goto Lfa
            goto L4e
        Lfa:
            goto L162
        Lfe:
            if (r8 == r3) goto L103
            goto Lb9
        L103:
            goto L21e
        L107:
            r3 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L19c
        L10d:
            int r2 = r9 - r13
            goto L167
        L113:
            int r3 = r0.mVerticalStyle
            goto L262
        L119:
            r15 = r15[r10]
            goto L1c7
        L11f:
            int[] r5 = new int[r1]
            goto La2
        L125:
            if (r3 == r15) goto L12a
            goto L168
        L12a:
            goto L10d
        L12e:
            r15 = 1
            goto L125
        L133:
            int r3 = r0.mHorizontalStyle
            goto L143
        L139:
            r10 = 0
            goto L23
        L13e:
            r3 = r10
            goto L2d7
        L143:
            if (r3 == r2) goto L148
            goto L2ce
        L148:
            goto L2cc
        L14c:
            int r10 = r10.getVisibility()
            goto L1d3
        L154:
            int r14 = r0.getPaddingBottom()
            goto L2c
        L15c:
            r10 = r10[r3]
            goto L14c
        L162:
            r10 = 2
            goto L188
        L167:
            int r2 = r2 - r14
        L168:
            goto L172
        L16c:
            r8 = r22
            goto L17
        L172:
            r4 = r2
            goto L280
        L177:
            int r0 = r0 % r1
            goto L57
        L17d:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r2 = r0.mWidgets
            goto L13e
        L183:
            return
        L184:
            goto L3c5
        L188:
            if (r3 != r10) goto L18d
            goto Lc5
        L18d:
            goto L52
        L191:
            int r2 = r2 - r12
            goto L2a6
        L196:
            int r3 = r3 + 1
        L198:
            goto L31
        L19c:
            r4 = 1073741824(0x40000000, float:2.0)
            goto L32a
        L1a2:
            int r12 = r0.getPaddingRight()
            goto L44
        L1aa:
            int r1 = java.lang.Math.min(r1, r7)
            goto L2ff
        L1b2:
            int r3 = r0.mOrientation
            goto L212
        L1b8:
            goto L3ac
        L1ba:
            goto L133
        L1be:
            if (r8 == 0) goto L1c3
            goto L254
        L1c3:
            goto L252
        L1c7:
            r18 = r2
            goto L29e
        L1cd:
            int r10 = r0.mWidgetsCount
            goto L293
        L1d3:
            if (r10 == r1) goto L1d8
            goto L38a
        L1d8:
            goto L388
        L1dc:
            int r3 = r0.mOrientation
            goto L375
        L1e2:
            goto L2c2
        L1e5:
            goto L26b
        L1e9:
            int r0 = r0 + r1
            goto L177
        L1ef:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r2 = new androidx.constraintlayout.core.widgets.ConstraintWidget[r2]
            goto L3e
        L1f5:
            r0.measureNoWrap(r1, r2, r3, r4, r5)
        L1f8:
            goto L7f
        L1fc:
            r0.setMeasure(r1, r2)
            goto L37
        L203:
            r18 = r2
            goto L2c6
        L209:
            if (r6 == r3) goto L20e
            goto L300
        L20e:
            goto L1aa
        L212:
            r0.measureChainWrap(r1, r2, r3, r4, r5)
            goto L25d
        L219:
            r10 = 1
            goto Lf5
        L21e:
            int r2 = java.lang.Math.min(r2, r9)
            goto Lb8
        L226:
            if (r1 > 0) goto L22b
            goto L95
        L22b:
            goto L8a
        L22f:
            int r3 = r0.mOrientation
            goto L2b2
        L235:
            r0.mHorizontalStyle = r10
        L237:
            goto L2dd
        L23b:
            int r1 = r1 + r12
            goto L79
        L240:
            int r2 = r2 - r16
            goto L1ef
        L246:
            r0.setHeight(r2)
            goto L2f4
        L24d:
            int r1 = r1 + r11
            goto L23b
        L252:
            goto Lcb
        L254:
            goto Lc9
        L258:
            return
        L259:
            goto L2bf
        L25d:
            goto L1f8
        L25e:
            goto La
        L262:
            if (r3 == r2) goto L267
            goto L3ac
        L267:
            goto L3aa
        L26b:
            r0 = 22
            goto L10
        L272:
            goto L1f8
        L273:
            goto L1dc
        L277:
            if (r3 == r2) goto L27c
            goto L3ac
        L27c:
            goto L35a
        L280:
            r2 = -1
            goto L333
        L285:
            int r2 = r2 + r13
            goto L2e9
        L28a:
            if (r3 != 0) goto L28f
            goto L25e
        L28f:
            goto L219
        L293:
            r1 = 8
            goto L33c
        L299:
            r2 = r3
            goto Lde
        L29e:
            int r2 = r15.getVisibility()
            goto L99
        L2a6:
            int r3 = r0.mOrientation
            goto L12e
        L2ac:
            r1 = r17
        L2ae:
            goto L60
        L2b2:
            r0.measureAligned(r1, r2, r3, r4, r5)
            goto L4c
        L2b9:
            int r1 = r0.mWidgetsCount
            goto L139
        L2bf:
            goto L397
        L2c2:
            goto L90
        L2c6:
            r1 = r18
            goto L38e
        L2cc:
            r0.mHorizontalStyle = r10
        L2ce:
            goto L113
        L2d2:
            goto L2ae
        L2d3:
            goto L2ac
        L2d7:
            r16 = r3
            goto L2ee
        L2dd:
            int r3 = r0.mVerticalStyle
            goto L277
        L2e3:
            int r2 = r0.mWidgetsCount
            goto L240
        L2e9:
            int r2 = r2 + r14
            goto L107
        L2ee:
            r17 = r16
        L2f0:
            goto L1cd
        L2f4:
            int r1 = r0.mWidgetsCount
            goto L226
        L2fa:
            r2 = r9
            goto L382
        L2ff:
            goto L2ae
        L300:
            goto L3bc
        L304:
            r0.mDisplayedWidgetsCount = r2
            goto L1d
        L30a:
            r1 = 2
            goto L37c
        L30f:
            r0.needsCallbackFromSolver(r10)
            goto L183
        L316:
            r6 = r20
            goto L3b0
        L31c:
            goto L2ae
        L31d:
            goto L209
        L321:
            if (r10 < r15) goto L326
            goto L86
        L326:
            goto Ld8
        L32a:
            if (r6 == r4) goto L32f
            goto L31d
        L32f:
            goto L74
        L333:
            if (r3 == 0) goto L338
            goto L1ba
        L338:
            goto Lbd
        L33c:
            if (r3 < r10) goto L341
            goto L37e
        L341:
            goto L360
        L345:
            if (r1 == 0) goto L34a
            goto L184
        L34a:
            goto L36e
        L34e:
            int r3 = r0.mWidgetsCount
            goto L39b
        L354:
            int r3 = r3 + 1
            goto L30a
        L35a:
            r0.mVerticalStyle = r10
            goto L1b8
        L360:
            androidx.constraintlayout.core.widgets.ConstraintWidget[] r10 = r0.mWidgets
            goto L15c
        L366:
            bool r1 = r0.measureChildren()
            goto L345
        L36e:
            r0.setMeasure(r10, r10)
            goto L30f
        L375:
            r0.measureChainWrap_new(r1, r2, r3, r4, r5)
            goto Lc3
        L37c:
            goto L2f0
        L37e:
            goto L34e
        L382:
            goto Lcb
        L384:
            goto Lfe
        L388:
            int r16 = r16 + 1
        L38a:
            goto L354
        L38e:
            goto L6a
        L390:
            goto L69
        L394:
            goto L259
        L397:
            goto L6e
        L39b:
            if (r16 > 0) goto L3a0
            goto L390
        L3a0:
            goto L2e3
        L3a4:
            r2 = r18
            goto L85
        L3aa:
            r0.mVerticalStyle = r10
        L3ac:
            goto L17d
        L3b0:
            r7 = r21
            goto L16c
        L3b6:
            r10 = r17
        L3b8:
            goto La8
        L3bc:
            if (r6 == 0) goto L3c1
            goto L2d3
        L3c1:
            goto L2d2
        L3c5:
            int r11 = r0.getPaddingLeft()
            goto L1a2
    }

    public void SetFirstHorizontalBias(float r1) {
            r0 = this;
            goto L12
        L4:
            r0.mFirstHorizontalBias = r1
            goto La
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
    }

    public void SetFirstHorizontalStyle(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0.mFirstHorizontalStyle = r1
            goto L11
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
    }

    public void SetFirstVerticalBias(float r1) {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.mFirstVerticalBias = r1
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    public void SetFirstVerticalStyle(int r1) {
            r0 = this;
            goto L12
        L4:
            r0.mFirstVerticalStyle = r1
            goto Ld
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    public void SetHorizontalAlign(int r1) {
            r0 = this;
            goto L12
        L4:
            r0.mHorizontalAlign = r1
            goto Ld
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    public void SetHorizontalBias(float r1) {
            r0 = this;
            goto La
        L4:
            r0.mHorizontalBias = r1
            goto L11
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
    }

    public void SetHorizontalGap(int r1) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.mHorizontalGap = r1
            goto L7
    }

    public void SetHorizontalStyle(int r1) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.mHorizontalStyle = r1
            goto L4
    }

    public void SetLastHorizontalBias(float r1) {
            r0 = this;
            goto Ld
        L4:
            r0.mLastHorizontalBias = r1
            goto L14
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return
        L15:
            goto La
    }

    public void SetLastHorizontalStyle(int r1) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.mLastHorizontalStyle = r1
            goto L7
    }

    public void SetLastVerticalBias(float r1) {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            r0.mLastVerticalBias = r1
            goto L14
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return
        L15:
            goto L4
    }

    public void SetLastVerticalStyle(int r1) {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            r0.mLastVerticalStyle = r1
            goto Ld
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L7
    }

    public void SetMaxElementsWrap(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            r0.mMaxElementsWrap = r1
            goto L14
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
    }

    public void SetOrientation(int r1) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.mOrientation = r1
            goto L4
    }

    public void SetVerticalAlign(int r1) {
            r0 = this;
            goto La
        L4:
            r0.mVerticalAlign = r1
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
    }

    public void SetVerticalBias(float r1) {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.mVerticalBias = r1
            goto L14
        L14:
            return
        L15:
            goto Lb
    }

    public void SetVerticalGap(int r1) {
            r0 = this;
            goto L12
        L4:
            r0.mVerticalGap = r1
            goto Ld
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    public void SetVerticalStyle(int r1) {
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
            r0.mVerticalStyle = r1
            goto Le
    }

    public void SetWrapMode(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.mWrapMode = r1
            goto L14
        L14:
            return
        L15:
            goto Lb
    }
}

