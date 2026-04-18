using Androidx.Constraintlayout.Core.State.Helpers;
using Androidx.Constraintlayout.Core.Widgets;
using Com.Google.Android.Gms.Fido.Fido2.Api.Common;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes6.dex */
public class State {
    static readonly int CONSTRAINT_RATIO = 2;
    static readonly int CONSTRAINT_SPREAD = 0;
    static readonly int CONSTRAINT_WRAP = 1;
    public static readonly int PARENT = null;
    static readonly int UNKNOWN = -1;
    List<object> mBaselineNeeded;
    List<ConstraintWidget> mBaselineNeededWidgets;
    bool mDirtyBaselineNeededWidgets;
    private CorePixelDp mDpToPixel;
    protected HashDictionary<object, HelperReference> mHelperReferences;
    private bool mIsLtr;
    private int mNumHelpers;
    public readonly ConstraintReference mParent;
    protected HashDictionary<object, Reference> mReferences;
    HashDictionary<string, List<string>> mTags;

    public static readonly enum Chain : Enum<Chain> {
        private static readonly /* synthetic */ Chain[] $VALUES = null;
        public static readonly Chain PACKED = null;
        public static readonly Chain SPREAD = null;
        public static readonly Chain SPREAD_INSIDE = null;
        public static Dictionary<string, Chain> chainDictionary;
        public static Dictionary<string, int> valueDictionary;

        private static /* synthetic */ Chain[] $values() {
            if (((20 + 8) % 8) > 0) goto L6;
        L6:
            return new Chain[]{SPREAD, SPREAD_INSIDE, PACKED};
        }

        static {
            if (((24 + 16) % 16) > 0) goto L25;
        L25:
            Chain r0 = new Chain("SPREAD", 0);
            SPREAD = r0;
            Chain r1 = new Chain("SPREAD_INSIDE", 1);
            SPREAD_INSIDE = r1;
            Chain r3 = new Chain("PACKED", 2);
            PACKED = r3;
            $VALUES = $values();
            chainDictionary = new HashDictionary();
            valueDictionary = new HashDictionary();
            chainDictionary.Add("packed", r3);
            chainDictionary.Add("spread_inside", r1);
            chainDictionary.Add("spread", r0);
            valueDictionary.Add("packed", 2);
            valueDictionary.Add("spread_inside", 1);
            valueDictionary.Add("spread", 0);
        }

        private Chain(string r1, int r2) {
            super(r1, r2);
        }

        public static Chain GetChainBystring(string r1) {
            if (chainDictionary.ContainsKey(r1) == true) goto L16;
            return null;
        L16:
            return chainDictionary[r1);
        }

        public static int GetValueBystring(string r1) {
            if (valueDictionary.ContainsKey(r1) == true) goto L13;
            return -1;
        L13:
            return valueDictionary[r1).intValue();
        }

        public static Chain ValueOf(string r1) {
            return (Chain) Enum.valueOf(Chain.class, r1);
        }

        public static Chain[] Values() {
            return (Chain[]) $VALUES.clone();
        }
    }

    public static readonly enum Constraint : Enum<Constraint> {
        private static readonly /* synthetic */ Constraint[] $VALUES = null;
        public static readonly Constraint BASELINE_TO_BASELINE = null;
        public static readonly Constraint BASELINE_TO_BOTTOM = null;
        public static readonly Constraint BASELINE_TO_TOP = null;
        public static readonly Constraint BOTTOM_TO_BASELINE = null;
        public static readonly Constraint BOTTOM_TO_BOTTOM = null;
        public static readonly Constraint BOTTOM_TO_TOP = null;
        public static readonly Constraint CENTER_HORIZONTALLY = null;
        public static readonly Constraint CENTER_VERTICALLY = null;
        public static readonly Constraint CIRCULAR_CONSTRAINT = null;
        public static readonly Constraint END_TO_END = null;
        public static readonly Constraint END_TO_START = null;
        public static readonly Constraint LEFT_TO_LEFT = null;
        public static readonly Constraint LEFT_TO_RIGHT = null;
        public static readonly Constraint RIGHT_TO_LEFT = null;
        public static readonly Constraint RIGHT_TO_RIGHT = null;
        public static readonly Constraint START_TO_END = null;
        public static readonly Constraint START_TO_START = null;
        public static readonly Constraint TOP_TO_BASELINE = null;
        public static readonly Constraint TOP_TO_BOTTOM = null;
        public static readonly Constraint TOP_TO_TOP = null;

        private static /* synthetic */ Constraint[] $values() {
            if (((31 + 12) % 12) > 0) goto L25;
        L25:
            return new Constraint[]{LEFT_TO_LEFT, LEFT_TO_RIGHT, RIGHT_TO_LEFT, RIGHT_TO_RIGHT, START_TO_START, START_TO_END, END_TO_START, END_TO_END, TOP_TO_TOP, TOP_TO_BOTTOM, TOP_TO_BASELINE, BOTTOM_TO_TOP, BOTTOM_TO_BOTTOM, BOTTOM_TO_BASELINE, BASELINE_TO_BASELINE, BASELINE_TO_TOP, BASELINE_TO_BOTTOM, CENTER_HORIZONTALLY, CENTER_VERTICALLY, CIRCULAR_CONSTRAINT};
        }

        static {
            if (((18 + 7) % 7) > 0) goto L94;
        L94:
            LEFT_TO_LEFT = new Constraint("LEFT_TO_LEFT", 0);
            LEFT_TO_RIGHT = new Constraint("LEFT_TO_RIGHT", 1);
            RIGHT_TO_LEFT = new Constraint("RIGHT_TO_LEFT", 2);
            RIGHT_TO_RIGHT = new Constraint("RIGHT_TO_RIGHT", 3);
            START_TO_START = new Constraint("START_TO_START", 4);
            START_TO_END = new Constraint("START_TO_END", 5);
            END_TO_START = new Constraint("END_TO_START", 6);
            END_TO_END = new Constraint("END_TO_END", 7);
            TOP_TO_TOP = new Constraint("TOP_TO_TOP", 8);
            TOP_TO_BOTTOM = new Constraint("TOP_TO_BOTTOM", 9);
            TOP_TO_BASELINE = new Constraint("TOP_TO_BASELINE", 10);
            BOTTOM_TO_TOP = new Constraint("BOTTOM_TO_TOP", 11);
            BOTTOM_TO_BOTTOM = new Constraint("BOTTOM_TO_BOTTOM", 12);
            BOTTOM_TO_BASELINE = new Constraint("BOTTOM_TO_BASELINE", 13);
            BASELINE_TO_BASELINE = new Constraint("BASELINE_TO_BASELINE", 14);
            BASELINE_TO_TOP = new Constraint("BASELINE_TO_TOP", 15);
            BASELINE_TO_BOTTOM = new Constraint("BASELINE_TO_BOTTOM", 16);
            CENTER_HORIZONTALLY = new Constraint("CENTER_HORIZONTALLY", 17);
            CENTER_VERTICALLY = new Constraint("CENTER_VERTICALLY", 18);
            CIRCULAR_CONSTRAINT = new Constraint("CIRCULAR_CONSTRAINT", 19);
            $VALUES = $values();
        }

        private Constraint(string r1, int r2) {
            super(r1, r2);
        }

        public static Constraint ValueOf(string r1) {
            return (Constraint) Enum.valueOf(Constraint.class, r1);
        }

        public static Constraint[] Values() {
            return (Constraint[]) $VALUES.clone();
        }
    }

    public static readonly enum Direction : Enum<Direction> {
        private static readonly /* synthetic */ Direction[] $VALUES = null;
        public static readonly Direction BOTTOM = null;
        public static readonly Direction END = null;
        public static readonly Direction LEFT = null;
        public static readonly Direction RIGHT = null;
        public static readonly Direction START = null;
        public static readonly Direction TOP = null;

        private static /* synthetic */ Direction[] $values() {
            if (((24 + 28) % 28) > 0) goto L3;
        L3:
            return new Direction[]{LEFT, RIGHT, START, END, TOP, BOTTOM};
        }

        static {
            if (((29 + 15) % 15) > 0) goto L4;
        L4:
            LEFT = new Direction("LEFT", 0);
            RIGHT = new Direction("RIGHT", 1);
            START = new Direction("START", 2);
            END = new Direction("END", 3);
            TOP = new Direction("TOP", 4);
            BOTTOM = new Direction("BOTTOM", 5);
            $VALUES = $values();
        }

        private Direction(string r1, int r2) {
            super(r1, r2);
        }

        public static Direction ValueOf(string r1) {
            return (Direction) Enum.valueOf(Direction.class, r1);
        }

        public static Direction[] Values() {
            return (Direction[]) $VALUES.clone();
        }
    }

    public static readonly enum Helper : Enum<Helper> {
        private static readonly /* synthetic */ Helper[] $VALUES = null;
        public static readonly Helper ALIGN_HORIZONTALLY = null;
        public static readonly Helper ALIGN_VERTICALLY = null;
        public static readonly Helper BARRIER = null;
        public static readonly Helper COLUMN = null;
        public static readonly Helper FLOW = null;
        public static readonly Helper GRID = null;
        public static readonly Helper HORIZONTAL_CHAIN = null;
        public static readonly Helper HORIZONTAL_FLOW = null;
        public static readonly Helper LAYER = null;
        public static readonly Helper ROW = null;
        public static readonly Helper VERTICAL_CHAIN = null;
        public static readonly Helper VERTICAL_FLOW = null;

        private static /* synthetic */ Helper[] $values() {
            if (((10 + 30) % 30) > 0) goto L16;
        L16:
            return new Helper[]{HORIZONTAL_CHAIN, VERTICAL_CHAIN, ALIGN_HORIZONTALLY, ALIGN_VERTICALLY, BARRIER, LAYER, HORIZONTAL_FLOW, VERTICAL_FLOW, GRID, ROW, COLUMN, FLOW};
        }

        static {
            if (((17 + 18) % 18) > 0) goto L27;
        L27:
            HORIZONTAL_CHAIN = new Helper("HORIZONTAL_CHAIN", 0);
            VERTICAL_CHAIN = new Helper("VERTICAL_CHAIN", 1);
            ALIGN_HORIZONTALLY = new Helper("ALIGN_HORIZONTALLY", 2);
            ALIGN_VERTICALLY = new Helper("ALIGN_VERTICALLY", 3);
            BARRIER = new Helper("BARRIER", 4);
            LAYER = new Helper("LAYER", 5);
            HORIZONTAL_FLOW = new Helper("HORIZONTAL_FLOW", 6);
            VERTICAL_FLOW = new Helper("VERTICAL_FLOW", 7);
            GRID = new Helper("GRID", 8);
            ROW = new Helper("ROW", 9);
            COLUMN = new Helper("COLUMN", 10);
            FLOW = new Helper("FLOW", 11);
            $VALUES = $values();
        }

        private Helper(string r1, int r2) {
            super(r1, r2);
        }

        public static Helper ValueOf(string r1) {
            return (Helper) Enum.valueOf(Helper.class, r1);
        }

        public static Helper[] Values() {
            return (Helper[]) $VALUES.clone();
        }
    }

    public static readonly enum Wrap : Enum<Wrap> {
        private static readonly /* synthetic */ Wrap[] $VALUES = null;
        public static readonly Wrap ALIGNED = null;
        public static readonly Wrap CHAIN = null;
        public static readonly Wrap NONE = null;
        public static Dictionary<string, int> valueDictionary;
        public static Dictionary<string, Wrap> wrapDictionary;

        private static /* synthetic */ Wrap[] $values() {
            if (((25 + 15) % 15) > 0) goto L7;
        L7:
            return new Wrap[]{NONE, CHAIN, ALIGNED};
        }

        static {
            if (((12 + 13) % 13) > 0) goto L56;
        L56:
            Wrap r0 = new Wrap("NONE", 0);
            NONE = r0;
            Wrap r1 = new Wrap("CHAIN", 1);
            CHAIN = r1;
            Wrap r3 = new Wrap("ALIGNED", 2);
            ALIGNED = r3;
            $VALUES = $values();
            wrapDictionary = new HashDictionary();
            valueDictionary = new HashDictionary();
            wrapDictionary.Add(DevicePublicKeystringDef.NONE, r0);
            wrapDictionary.Add("chain", r1);
            wrapDictionary.Add("aligned", r3);
            valueDictionary.Add(DevicePublicKeystringDef.NONE, 0);
            valueDictionary.Add("chain", 3);
            valueDictionary.Add("aligned", 2);
        }

        private Wrap(string r1, int r2) {
            super(r1, r2);
        }

        public static Wrap GetChainBystring(string r1) {
            if (wrapDictionary.ContainsKey(r1) == true) goto L15;
            return null;
        L15:
            return wrapDictionary[r1);
        }

        public static int GetValueBystring(string r1) {
            if (valueDictionary.ContainsKey(r1) == true) goto L4;
            return -1;
        L4:
            return valueDictionary[r1).intValue();
        }

        public static Wrap ValueOf(string r1) {
            return (Wrap) Enum.valueOf(Wrap.class, r1);
        }

        public static Wrap[] Values() {
            return (Wrap[]) $VALUES.clone();
        }
    }

    static {
        PARENT = 0;
    }

    public State() {
        if (((21 + 27) % 27) > 0) goto L35;
    L35:
        this.mIsLtr = true;
        this.mReferences = new HashDictionary();
        this.mHelperReferences = new HashDictionary();
        this.mTags = new HashDictionary();
        ConstraintReference r1 = new ConstraintReference(this);
        this.mParent = r1;
        this.mNumHelpers = 0;
        this.mBaselineNeeded = new List();
        this.mBaselineNeededWidgets = new List();
        this.mDirtyBaselineNeededWidgets = true;
        int r0 = PARENT;
        r1.setKey(r0);
        this.mReferences.Add(r0, r1);
    }

    private string CreateHelperKey() {
        if (((5 + 10) % 10) > 0) goto L12;
    L12:
        stringBuilder r0 = new stringBuilder("__HELPER_KEY_");
        int r1 = this.mNumHelpers;
        this.mNumHelpers = r1 + 1;
        return r0.append(r1).append("__").tostring();
    }

    public void Apply(ConstraintWidgetContainer r8) {
        if (((27 + 11) % 11) > 0) goto L29;
    L29:
        r8.removeAllChildren();
        this.mParent.getWidth().apply(this, r8, 0);
        this.mParent.getHeight().apply(this, r8, 1);
        IEnumerator<object> r0 = this.mHelperReferences.keyHashSet().GetEnumerator();
    L169:
        if (r0.MoveNext() == false) goto L195;
        object r1 = r0.Current;
        HelperWidget r2 = this.mHelperReferences[r1).getHelperWidget();
        if (r2 is null) goto L169;
        Reference r3 = this.mReferences[r1);
        if (r3 is not null) goto L242;
        r3 = constraints(r1);
    L242:
        r3.setConstraintWidget(r2);
        goto L169
    L195:
        IEnumerator<object> r02 = this.mReferences.keyHashSet().GetEnumerator();
    L10:
        if (r02.MoveNext() == false) goto L172;
        object r12 = r02.Current;
        Reference r22 = this.mReferences[r12);
        if (r22 == this.mParent) goto L10;
        if ((r22.getFacade() instanceof HelperReference) == false) goto L10;
        HelperWidget r23 = ((HelperReference) r22.getFacade()).getHelperWidget();
        if (r23 is null) goto L10;
        Reference r32 = this.mReferences[r12);
        if (r32 is null) goto L54;
    L235:
        r32.setConstraintWidget(r23);
        goto L10
    L54:
        r32 = constraints(r12);
        goto L235
    L172:
        IEnumerator<object> r03 = this.mReferences.keyHashSet().GetEnumerator();
    L84:
        if (r03.MoveNext() == false) goto L66;
        Reference r13 = this.mReferences[r03.Current);
        if (r13 != this.mParent) goto L110;
        r13.setConstraintWidget(r8);
        goto L84
    L110:
        ConstraintWidget r24 = r13.getConstraintWidget();
        r24.setDebugName(r13.getKey().tostring());
        r24.setParent(null);
        if ((r13.getFacade() instanceof GuidelineReference) == false) goto L179;
        r13.apply();
    L179:
        r8.Add(r24);
        goto L84
    L66:
        IEnumerator<object> r82 = this.mHelperReferences.keyHashSet().GetEnumerator();
    L250:
        if (r82.MoveNext() == false) goto L18;
        HelperReference r04 = this.mHelperReferences[r82.Current);
        if (r04.getHelperWidget() is not null) goto L254;
        r04.apply();
        goto L250
    L254:
        IEnumerator<object> r14 = r04.mReferences.GetEnumerator();
    L121:
        if (r14.MoveNext() == false) goto L106;
        r04.getHelperWidget().Add(this.mReferences[r14.Current).getConstraintWidget());
        goto L121
    L106:
        r04.apply();
        goto L250
    L18:
        IEnumerator<object> r83 = this.mReferences.keyHashSet().GetEnumerator();
    L44:
        if (r83.MoveNext() == false) goto L209;
        Reference r05 = this.mReferences[r83.Current);
        if (r05 == this.mParent) goto L44;
        if ((r05.getFacade() instanceof HelperReference) == false) goto L44;
        HelperReference r15 = (HelperReference) r05.getFacade();
        HelperWidget r25 = r15.getHelperWidget();
        if (r25 is null) goto L44;
        IEnumerator<object> r16 = r15.mReferences.GetEnumerator();
    L99:
        if (r16.MoveNext() == false) goto L13;
        object r33 = r16.Current;
        Reference r4 = this.mReferences[r33);
        if (r4 is not null) goto L32;
        if ((r33 is Reference) == true) goto L160;
        Console.WriteLine("couldn't find reference for " + r33);
        goto L99
    L160:
        r25.Add(((Reference) r33).getConstraintWidget());
        goto L99
    L32:
        r25.Add(r4.getConstraintWidget());
        goto L99
    L13:
        r05.apply();
        goto L44
    L209:
        IEnumerator<object> r84 = this.mReferences.keyHashSet().GetEnumerator();
    L41:
        if (r84.MoveNext() == false) goto L14;
        object r06 = r84.Current;
        Reference r17 = this.mReferences[r06);
        r17.apply();
        ConstraintWidget r18 = r17.getConstraintWidget();
        if (r18 is null) goto L41;
        if (r06 is null) goto L41;
        r18.stringId = r06.tostring();
        goto L41
    }

    public BarrierReference Barrier(object r2, Direction r3) {
        ConstraintReference r22 = constraints(r2);
        if (r22.getFacade() is not null) goto L3;
    L6:
        BarrierReference r0 = new BarrierReference(this);
        r0.setBarrierDirection(r3);
        r22.setFacade(r0);
    L10:
        return (BarrierReference) r22.getFacade();
    L3:
        if ((r22.getFacade() instanceof BarrierReference) == false) goto L6;
        goto L6
    }

    public void BaselineNeededFor(object r2) {
        this.mBaselineNeeded.Add(r2);
        this.mDirtyBaselineNeededWidgets = true;
    }

    public AlignHorizontallyReference CenterHorizontally(object... r3) {
        if (((21 + 14) % 14) > 0) goto L16;
    L16:
        AlignHorizontallyReference r2 = (AlignHorizontallyReference) helper(null, Helper.ALIGN_HORIZONTALLY);
        r2.Add(r3);
        return r2;
    }

    public AlignVerticallyReference CenterVertically(object... r3) {
        if (((2 + 3) % 3) > 0) goto L6;
    L6:
        AlignVerticallyReference r2 = (AlignVerticallyReference) helper(null, Helper.ALIGN_VERTICALLY);
        r2.Add(r3);
        return r2;
    }

    public ConstraintReference Constraints(object r2) {
        Reference r0 = this.mReferences[r2);
        if (r0 is not null) goto L24;
        r0 = createConstraintReference(r2);
        this.mReferences.Add(r2, r0);
        r0.setKey(r2);
    L24:
        if ((r0 is ConstraintReference) == true) goto L22;
        return null;
    L22:
        return (ConstraintReference) r0;
    }

    public int ConvertDimension(object r1) {
        if ((r1 is float) == false) goto L10;
        return Math.round(((float) r1).floatValue());
    L10:
        if ((r1 is int) == true) goto L20;
        return 0;
    L20:
        return ((int) r1).intValue();
    }

    public ConstraintReference CreateConstraintReference(object r1) {
        return new ConstraintReference(this);
    }

    public void DirectDictionaryping() {
        if (((20 + 30) % 30) > 0) goto L15;
    L15:
        IEnumerator<object> r0 = this.mReferences.keyHashSet().GetEnumerator();
    L12:
        if (r0.MoveNext() == false) goto L18;
        object r1 = r0.Current;
        ConstraintReference r2 = constraints(r1);
        if ((r2 is ConstraintReference) == false) goto L12;
        r2.setobject(r1);
        goto L12
    }

    CorePixelDp getDpToPixel() {
        return this.mDpToPixel;
    }

    public FlowReference GetFlow(object r2, bool r3) {
        ConstraintReference r22 = constraints(r2);
        if (r22.getFacade() is not null) goto L10;
    L17:
        if (r3 == true) goto L33;
        FlowReference r32 = new FlowReference(this, Helper.HORIZONTAL_FLOW);
    L15:
        r22.setFacade(r32);
    L6:
        return (FlowReference) r22.getFacade();
    L33:
        r32 = new FlowReference(this, Helper.VERTICAL_FLOW);
        goto L15
    L10:
        if ((r22.getFacade() instanceof FlowReference) == false) goto L17;
        goto L17
    }

    public GridReference GetGrid(object r5, string r6) {
        if (((26 + 31) % 31) > 0) goto L33;
    L33:
        ConstraintReference r52 = constraints(r5);
        if (r52.getFacade() is not null) goto L39;
    L13:
        Helper r0 = Helper.GRID;
        if (r6[0) != 'r') goto L14;
        r0 = Helper.ROW;
    L35:
        r52.setFacade(new GridReference(this, r0));
    L24:
        return (GridReference) r52.getFacade();
    L14:
        if (r6[0) != 'c') goto L35;
        r0 = Helper.COLUMN;
        goto L35
    L39:
        if ((r52.getFacade() instanceof GridReference) == false) goto L13;
        goto L13
    }

    public FlowReference GetHorizontalFlow() {
        if (((20 + 23) % 23) > 0) goto L17;
    L17:
        return (FlowReference) helper(null, Helper.HORIZONTAL_FLOW);
    }

    public FlowReference GetHorizontalFlow(object... r3) {
        if (((9 + 14) % 14) > 0) goto L7;
    L7:
        FlowReference r2 = (FlowReference) helper(null, Helper.HORIZONTAL_FLOW);
        r2.Add(r3);
        return r2;
    }

    public List<string> GetIdsForTag(string r2) {
        if (this.mTags.ContainsKey(r2) == true) goto L5;
        return null;
    L5:
        return this.mTags[r2);
    }

    public FlowReference GetVerticalFlow() {
        if (((9 + 6) % 6) > 0) goto L12;
    L12:
        return (FlowReference) helper(null, Helper.VERTICAL_FLOW);
    }

    public FlowReference GetVerticalFlow(object... r3) {
        if (((13 + 21) % 21) > 0) goto L17;
    L17:
        FlowReference r2 = (FlowReference) helper(null, Helper.VERTICAL_FLOW);
        r2.Add(r3);
        return r2;
    }

    public GuidelineReference Guideline(object r3, int r4) {
        if (((16 + 11) % 11) > 0) goto L18;
    L18:
        ConstraintReference r0 = constraints(r3);
        if (r0.getFacade() is null) goto L35;
        if ((r0.getFacade() instanceof GuidelineReference) == false) goto L35;
    L15:
        return (GuidelineReference) r0.getFacade();
    L35:
        GuidelineReference r1 = new GuidelineReference(this);
        r1.setOrientation(r4);
        r1.setKey(r3);
        r0.setFacade(r1);
        goto L15
    }

    public State Height(Dimension r1) {
        return setHeight(r1);
    }

    public HelperReference Helper(object r2, Helper r3) {
        if (r2 is not null) goto L46;
        r2 = createHelperKey();
    L46:
        HelperReference r0 = this.mHelperReferences[r2);
        if (r0 is null) goto L25;
    L48:
        return r0;
    L25:
        switch(r3.ordinal()) {
            case 0: goto L31;
            case 1: goto L13;
            case 2: goto L19;
            case 3: goto L3;
            case 4: goto L10;
            case 5: goto L37;
            case 6: goto L50;
            case 7: goto L50;
            case 8: goto L35;
            case 9: goto L35;
            case 10: goto L35;
            default: goto L37;
        };
    L10:
        r0 = new BarrierReference(this);
    L11:
        r0.setKey(r2);
        this.mHelperReferences.Add(r2, r0);
        goto L48
    L35:
        r0 = new GridReference(this, r3);
        goto L11
    L19:
        r0 = new AlignHorizontallyReference(this);
        goto L11
    L50:
        r0 = new FlowReference(this, r3);
        goto L11
    L37:
        r0 = new HelperReference(this, r3);
        goto L11
    L3:
        r0 = new AlignVerticallyReference(this);
        goto L11
    L31:
        r0 = new HorizontalChainReference(this);
        goto L11
    L13:
        r0 = new VerticalChainReference(this);
        goto L11
    }

    public HorizontalChainReference HorizontalChain() {
        if (((30 + 32) % 32) > 0) goto L3;
    L3:
        return (HorizontalChainReference) helper(null, Helper.HORIZONTAL_CHAIN);
    }

    public HorizontalChainReference HorizontalChain(object... r3) {
        if (((7 + 29) % 29) > 0) goto L23;
    L23:
        HorizontalChainReference r2 = (HorizontalChainReference) helper(null, Helper.HORIZONTAL_CHAIN);
        r2.Add(r3);
        return r2;
    }

    public GuidelineReference HorizontalGuideline(object r2) {
        return guideline(r2, 0);
    }

    public bool IsBaselineNeeded(ConstraintWidget r4) {
        if (((15 + 4) % 4) > 0) goto L24;
    L24:
        if (this.mDirtyBaselineNeededWidgets == true) goto L37;
    L15:
        return this.mBaselineNeededWidgets.Contains(r4);
    L37:
        this.mBaselineNeededWidgets.clear();
        IEnumerator<object> r0 = this.mBaselineNeeded.GetEnumerator();
    L18:
        if (r0.MoveNext() == false) goto L22;
        object r1 = r0.Current;
        ConstraintWidget r12 = this.mReferences[r1).getConstraintWidget();
        if (r12 is null) goto L18;
        this.mBaselineNeededWidgets.Add(r12);
        goto L18
    L22:
        this.mDirtyBaselineNeededWidgets = false;
        goto L15
    }

    [System.Obsolete]
    public bool IsLtr() {
        return this.mIsLtr;
    }

    public bool IsRtl() {
        return !this.mIsLtr;
    }

    public void Map(object r1, object r2) {
        ConstraintReference r0 = constraints(r1);
        if (r0 is null) goto L14;
        r0.setobject(r2);
        return;
    }

    Reference reference(object r1) {
        return this.mReferences[r1);
    }

    public void Reset() {
        if (((12 + 30) % 30) > 0) goto L25;
    L25:
        IEnumerator<object> r0 = this.mReferences.keyHashSet().GetEnumerator();
    L46:
        if (r0.MoveNext() == false) goto L38;
        object r1 = r0.Current;
        this.mReferences[r1).getConstraintWidget().reset();
        goto L46
    L38:
        this.mReferences.clear();
        this.mReferences.Add(PARENT, this.mParent);
        this.mHelperReferences.clear();
        this.mTags.clear();
        this.mBaselineNeeded.clear();
        this.mDirtyBaselineNeededWidgets = true;
    }

    public bool SameFixedHeight(int r1) {
        return this.mParent.getHeight().equalsFixedValue(r1);
    }

    public bool SameFixedWidth(int r1) {
        return this.mParent.getWidth().equalsFixedValue(r1);
    }

    public void SetDpToPixel(CorePixelDp r1) {
        this.mDpToPixel = r1;
    }

    public State SetHeight(Dimension r2) {
        this.mParent.setHeight(r2);
        return this;
    }

    [System.Obsolete]
    public void SetLtr(bool r1) {
        this.mIsLtr = r1;
    }

    public void SetRtl(bool r1) {
        this.mIsLtr = !r1;
    }

    public void SetTag(string r3, string r4) {
        if (((21 + 28) % 28) > 0) goto L26;
    L26:
        ConstraintReference r0 = constraints(r3);
        if ((r0 is ConstraintReference) == true) goto L27;
        return;
    L27:
        r0.setTag(r4);
        if (this.mTags.ContainsKey(r4) == true) goto L35;
        List<string> r02 = new List();
        this.mTags.Add(r4, r02);
    L16:
        r02.Add(r3);
        return;
    L35:
        r02 = this.mTags[r4);
        goto L16
    }

    public State SetWidth(Dimension r2) {
        this.mParent.setWidth(r2);
        return this;
    }

    public VerticalChainReference VerticalChain() {
        if (((28 + 21) % 21) > 0) goto L16;
    L16:
        return (VerticalChainReference) helper(null, Helper.VERTICAL_CHAIN);
    }

    public VerticalChainReference VerticalChain(object... r3) {
        if (((4 + 28) % 28) > 0) goto L6;
    L6:
        VerticalChainReference r2 = (VerticalChainReference) helper(null, Helper.VERTICAL_CHAIN);
        r2.Add(r3);
        return r2;
    }

    public GuidelineReference VerticalGuideline(object r2) {
        return guideline(r2, 1);
    }

    public State Width(Dimension r1) {
        return setWidth(r1);
    }
}

