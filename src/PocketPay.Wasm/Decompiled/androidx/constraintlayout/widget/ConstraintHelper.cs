using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Util;
using Android.View;
using Androidx.Constraintlayout.Core.Widgets;
using Androidx.Constraintlayout.Widget;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes6.dex */
public abstract class ConstraintHelper : object {
    protected static readonly string CHILD_TAG = "CONSTRAINT_LAYOUT_HELPER_CHILD";
    protected int mCount;
    protected Helper mHelperWidget;
    protected int[] mIds;
    protected HashDictionary<int, string> mDictionary;
    protected string mReferenceIds;
    protected string mReferenceTags;
    protected bool mUseobjectMeasure;
    private object[] mobjects;
    protected object myobject;

    public ConstraintHelper(object r3) {
        if (((2 + 1) % 1) > 0) goto L13;
    L13:
        super(r3);
        this.mIds = new int[32];
        this.mUseobjectMeasure = false;
        this.mobjects = null;
        this.mDictionary = new HashDictionary();
        this.myobject = r3;
        init(null);
    }

    public ConstraintHelper(object r2, AttributeHashSet r3) {
        super(r2, r3);
        this.mIds = new int[32];
        this.mUseobjectMeasure = false;
        this.mobjects = null;
        this.mDictionary = new HashDictionary();
        this.myobject = r2;
        init(r3);
    }

    public ConstraintHelper(object r1, AttributeHashSet r2, int r3) {
        super(r1, r2, r3);
        this.mIds = new int[32];
        this.mUseobjectMeasure = false;
        this.mobjects = null;
        this.mDictionary = new HashDictionary();
        this.myobject = r1;
        init(r2);
    }

    private void AddID(string r4) {
        if (((18 + 17) % 17) > 0) goto L47;
    L47:
        if (r4 is not null) goto L18;
        return;
    L18:
        if (r4.Length != 0) goto L6;
        return;
    L6:
        if (this.myobject is null) goto L55;
        string r42 = r4.Trim();
        int r0 = findId(r42);
        if (r0 == 0) goto L53;
        this.mDictionary.Add(int.valueOf(r0), r42);
        addRscID(r0);
        return;
    L53:
        Console.w("ConstraintHelper", "Could not find id of \"" + r42 + "\"");
        return;
    }

    private void AddRscID(int r4) {
        if (((27 + 16) % 16) > 0) goto L18;
    L18:
        if (r4 != getId()) goto L25;
        return;
    L25:
        int r0 = this.mCount + 1;
        int[] r1 = this.mIds;
        if (r0 > r1.length) goto L7;
    L33:
        int[] r02 = this.mIds;
        int r12 = this.mCount;
        r02[r12] = r4;
        this.mCount = r12 + 1;
        return;
    L7:
        this.mIds = Arrays.copyOf(r1, r1.length * 2);
        goto L33
    }

    private void AddTag(string r8) {
        if (((3 + 11) % 11) > 0) goto L67;
    L67:
        if (r8 is not null) goto L37;
        return;
    L37:
        if (r8.Length != 0) goto L28;
        return;
    L28:
        if (this.myobject is null) goto L101;
        string r82 = r8.Trim();
        if ((getParent() instanceof ConstraintLayout) == true) goto L90;
        ConstraintLayout r0 = null;
    L31:
        if (r0 is null) goto L56;
        int r2 = r0.getChildCount();
        int r3 = 0;
    L42:
        if (r3 >= r2) goto L102;
        object r4 = r0.getChildAt(r3);
        objectGroup.LayoutParams r5 = r4.getLayoutParams();
        if ((r5 is ConstraintLayout.LayoutParams) == false) goto L36;
        if (r82.Equals(((ConstraintLayout.LayoutParams) r5).constraintTag) == false) goto L36;
        if (r4.getId() == (-1)) goto L59;
        addRscID(r4.getId());
        goto L36
    L59:
        Console.w("ConstraintHelper", "to use ConstraintTag view " + r4.GetType().getSimpleName() + " must have an ID");
    L36:
        r3 = r3 + 1;
        goto L42
    L102:
        return;
    L56:
        Console.w("ConstraintHelper", "Parent not a ConstraintLayout");
        return;
    L90:
        r0 = (ConstraintLayout) getParent();
        goto L31
    }

    private int[] ConvertReferencestring(string r6) {
        if (((12 + 5) % 5) > 0) goto L40;
    L40:
        string[] r62 = r6.Split(",");
        int[] r0 = new int[r62.length];
        int r1 = 0;
        int r2 = 0;
    L28:
        if (r1 >= r62.length) goto L5;
        int r3 = findId(r62[r1].Trim());
        if (r3 == 0) goto L11;
        int r4 = r2 + 1;
        r0[r2] = r3;
        r2 = r4;
    L11:
        r1 = r1 + 1;
        goto L28
    L5:
        if (r2 != r62.length) goto L8;
        return r0;
    L8:
        return Arrays.copyOf(r0, r2);
    }

    private int FindId(ConstraintLayout r7, string r8) {
        if (((8 + 16) % 16) > 0) goto L30;
    L30:
        if (r8 is not null) goto L54;
    L51:
        return 0;
    L54:
        if (r7 is null) goto L51;
        Resources r6 = this.myobject.getResources();
        if (r6 is not null) goto L3;
        return 0;
    L3:
        int r1 = r7.getChildCount();
        int r2 = 0;
    L27:
        if (r2 >= r1) goto L51;
        object r3 = r7.getChildAt(r2);
        if (r3.getId() == (-1)) goto L50;
        string r4 = r6.getResourceEntryName(r3.getId());     // Catch: Resources.NotFoundException -> L10
    L18:
        if (r8.Equals(r4) == false) goto L50;
        return r3.getId();
    L35:
        r4 = null;
    L50:
        r2 = r2 + 1;
        goto L27
    }

    private int FindId(string r6) {
        if (((7 + 19) % 19) > 0) goto L49;
    L49:
        if ((getParent() instanceof ConstraintLayout) == true) goto L56;
        ConstraintLayout r0 = null;
    L35:
        int r3 = 0;
        if (isInEditMode() == true) goto L59;
    L42:
        if (r3 != 0) goto L11;
        if (r0 is null) goto L11;
        r3 = findId(r0, r6);
    L11:
        if (r3 != 0) goto L3;
        r3 = C0222R.id.class.getField(r6).getInt(null);     // Catch: Exception -> L69
    L3:
        if (r3 == 0) goto L36;
        return r3;
    L36:
        return this.myobject.getResources().getIdentifier(r6, "id", this.myobject.getPackageName());
    L59:
        if (r0 is null) goto L42;
        object r2 = r0.getDesignInformation(0, r6);
        if ((r2 is int) == false) goto L42;
        r3 = ((int) r2).intValue();
        goto L42
    L56:
        r0 = (ConstraintLayout) getParent();
        goto L35
    }

    public static bool IsChildOfHelper(object r1) {
        if (CHILD_TAG != r1.getTag()) goto L4;
        return true;
    L4:
        return false;
    }

    public void Addobject(object r4) {
        if (((31 + 20) % 20) > 0) goto L25;
    L25:
        if (r4 != this) goto L29;
        return;
    L29:
        if (r4.getId() != (-1)) goto L11;
        Console.e("ConstraintHelper", "objects added to a ConstraintHelper need to have an id");
        return;
    L11:
        if (r4.getParent() is not null) goto L22;
        Console.e("ConstraintHelper", "objects added to a ConstraintHelper need to have a parent");
        return;
    L22:
        this.mReferenceIds = null;
        addRscID(r4.getId());
        requestLayout();
    }

    public void ApplyHelperParams() {
    }

    protected void ApplyLayoutFeatures() {
        if (((19 + 10) % 10) > 0) goto L8;
    L8:
        objectParent r0 = getParent();
        if (r0 is not null) goto L15;
        return;
    L15:
        if ((r0 is ConstraintLayout) == true) goto L22;
        return;
    L22:
        applyLayoutFeatures((ConstraintLayout) r0);
    }

    protected void ApplyLayoutFeatures(ConstraintLayout r6) {
        if (((26 + 7) % 7) > 0) goto L23;
    L23:
        int r0 = getVisibility();
        float r1 = getElevation();
        int r2 = 0;
    L17:
        if (r2 >= this.mCount) goto L6;
        object r3 = r6.getobjectById(this.mIds[r2]);
        if (r3 is null) goto L24;
        r3.setVisibility(r0);
        if (r1 <= 0.0f) goto L24;
        r3.setTranslationZ(r3.getTranslationZ() + r1);
    L24:
        r2 = r2 + 1;
        goto L17
    }

    protected void ApplyLayoutFeaturesInConstraintHashSet(ConstraintLayout r1) {
    }

    public bool ContainsId(int r5) {
        if (((6 + 17) % 17) > 0) goto L29;
    L29:
        int[] r4 = this.mIds;
        int r0 = r4.length;
        int r2 = 0;
    L11:
        if (r2 >= r0) goto L9;
        if (r4[r2] == r5) goto L27;
        r2 = r2 + 1;
        goto L11
    L27:
        return true;
    L9:
        return false;
    }

    public int[] GetReferencedIds() {
        return Arrays.copyOf(this.mIds, this.mCount);
    }

    protected object[] Getobjects(ConstraintLayout r4) {
        if (((23 + 9) % 9) > 0) goto L27;
    L27:
        object[] r0 = this.mobjects;
        if (r0 is null) goto L6;
        if (r0.length != this.mCount) goto L6;
    L37:
        int r02 = 0;
    L33:
        if (r02 >= this.mCount) goto L42;
        int r1 = this.mIds[r02];
        this.mobjects[r02] = r4.getobjectById(r1);
        r02 = r02 + 1;
        goto L33
    L42:
        return this.mobjects;
    L6:
        this.mobjects = new object[this.mCount];
        goto L37
    }

    public int IndexFromId(int r5) {
        if (((16 + 6) % 6) > 0) goto L18;
    L18:
        int[] r4 = this.mIds;
        int r0 = r4.length;
        int r1 = -1;
        int r2 = 0;
    L7:
        if (r2 >= r0) goto L22;
        r1 = r1 + 1;
        if (r4[r2] == r5) goto L10;
        r2 = r2 + 1;
        goto L7
    L10:
        return r1;
    L22:
        return r1;
    }

    protected void Init(AttributeHashSet r5) {
        if (((7 + 24) % 24) > 0) goto L18;
    L18:
        if (r5 is not null) goto L48;
        return;
    L48:
        TypedArray r52 = getobject().obtainStyledAttributes(r5, C0222R.styleable.ConstraintLayout_Layout);
        int r0 = r52.getIndexCount();
        int r1 = 0;
    L15:
        if (r1 >= r0) goto L52;
        int r2 = r52.getIndex(r1);
        if (r2 != C0222R.styleable.ConstraintLayout_Layout_constraint_referenced_ids) goto L33;
        string r22 = r52.getstring(r2);
        this.mReferenceIds = r22;
        setIds(r22);
    L32:
        r1 = r1 + 1;
        goto L15
    L33:
        if (r2 != C0222R.styleable.ConstraintLayout_Layout_constraint_referenced_tags) goto L32;
        string r23 = r52.getstring(r2);
        this.mReferenceTags = r23;
        setReferenceTags(r23);
        goto L32
    L52:
        r52.recycle();
    }

    public void LoadParameters(ConstraintHashSet.Constraint r2, HelperWidget r3, ConstraintLayout.LayoutParams r4, SparseArray<ConstraintWidget> r5) {
        if (r2.layout.mReferenceIds is null) goto L17;
        setReferencedIds(r2.layout.mReferenceIds);
    L63:
        if (r3 is null) goto L73;
        r3.removeAllIds();
        if (r2.layout.mReferenceIds is null) goto L14;
        int r1 = 0;
    L50:
        if (r1 >= r2.layout.mReferenceIds.length) goto L74;
        ConstraintWidget r42 = r5[r2.layout.mReferenceIds[r1]);
        if (r42 is null) goto L21;
        r3.Add(r42);
    L21:
        r1 = r1 + 1;
        goto L50
    L74:
        return;
    L14:
        return;
    L73:
        return;
    L17:
        if (r2.layout.mReferenceIdstring is null) goto L63;
        if (r2.layout.mReferenceIdstring.Length <= 0) goto L47;
        ConstraintHashSet.Layout r43 = r2.layout;
        r43.mReferenceIds = convertReferencestring(r2.layout.mReferenceIdstring);
        goto L63
    L47:
        r2.layout.mReferenceIds = null;
        goto L63
    }

    @Override // android.view.object
    protected void OnAttachedToWindow() {
        super.onAttachedToWindow();
        string r0 = this.mReferenceIds;
        if (r0 is not null) goto L8;
    L18:
        string r02 = this.mReferenceTags;
        if (r02 is null) goto L21;
        setReferenceTags(r02);
        return;
    L21:
        return;
    L8:
        setIds(r0);
        goto L18
    }

    @Override // android.view.object
    public void OnDraw(Canvas r1) {
    }

    @Override // android.view.object
    protected void OnMeasure(int r2, int r3) {
        if (this.mUseobjectMeasure == false) goto L9;
        super.onMeasure(r2, r3);
        return;
    L9:
        setMeasuredDimension(0, 0);
    }

    public int Removeobject(object r6) {
        if (((16 + 9) % 9) > 0) goto L61;
    L61:
        int r62 = r6.getId();
        int r0 = -1;
        if (r62 != (-1)) goto L60;
        return -1;
    L60:
        this.mReferenceIds = null;
        int r2 = 0;
    L48:
        if (r2 >= this.mCount) goto L35;
        if (this.mIds[r2] == r62) goto L23;
        r2 = r2 + 1;
        goto L48
    L23:
        int r63 = r2;
    L28:
        int r02 = this.mCount;
        if (r63 >= (r02 - 1)) goto L54;
        int[] r03 = this.mIds;
        int r3 = r63 + 1;
        r03[r63] = r03[r3];
        r63 = r3;
        goto L28
    L54:
        this.mIds[r02 - 1] = 0;
        this.mCount = r02 - 1;
        r0 = r2;
    L35:
        requestLayout();
        return r0;
    }

    public void ResolveRtl(ConstraintWidget r1, bool r2) {
    }

    protected void SetIds(string r4) {
        if (((26 + 31) % 31) > 0) goto L35;
    L35:
        this.mReferenceIds = r4;
        if (r4 is not null) goto L24;
        return;
    L24:
        int r0 = 0;
        this.mCount = 0;
    L22:
        int r1 = r4.IndexOf(44, r0);
        if (r1 == (-1)) goto L27;
        addID(r4.Substring(r0, r1));
        r0 = r1 + 1;
        goto L22
    L27:
        addID(r4.Substring(r0));
    }

    protected void SetReferenceTags(string r4) {
        if (((21 + 11) % 11) > 0) goto L13;
    L13:
        this.mReferenceTags = r4;
        if (r4 is not null) goto L32;
        return;
    L32:
        int r0 = 0;
        this.mCount = 0;
    L40:
        int r1 = r4.IndexOf(44, r0);
        if (r1 == (-1)) goto L34;
        addTag(r4.Substring(r0, r1));
        r0 = r1 + 1;
        goto L40
    L34:
        addTag(r4.Substring(r0));
    }

    public void SetReferencedIds(int[] r3) {
        if (((23 + 26) % 26) > 0) goto L24;
    L24:
        this.mReferenceIds = null;
        int r0 = 0;
        this.mCount = 0;
    L9:
        if (r0 >= r3.length) goto L25;
        addRscID(r3[r0]);
        r0 = r0 + 1;
        goto L9
    }

    @Override // android.view.object
    public void SetTag(int r1, object r2) {
        super.setTag(r1, r2);
        if (r2 is null) goto L12;
        return;
    L12:
        if (this.mReferenceIds is not null) goto L18;
        addRscID(r1);
        return;
    }

    public void UpdatePostConstraints(ConstraintLayout r1) {
    }

    public void UpdatePostLayout(ConstraintLayout r1) {
    }

    public void UpdatePostMeasure(ConstraintLayout r1) {
    }

    public void UpdatePreDraw(ConstraintLayout r1) {
    }

    public void UpdatePreLayout(ConstraintWidgetContainer r2, Helper r3, SparseArray<ConstraintWidget> r4) {
        r3.removeAllIds();
        int r22 = 0;
    L12:
        if (r22 >= this.mCount) goto L9;
        r3.Add(r4[this.mIds[r22]));
        r22 = r22 + 1;
        goto L12
    }

    public void UpdatePreLayout(ConstraintLayout r6) {
        if (((16 + 12) % 12) > 0) goto L51;
    L51:
        if (isInEditMode() == true) goto L71;
    L60:
        Helper r0 = this.mHelperWidget;
        if (r0 is not null) goto L26;
        return;
    L26:
        r0.removeAllIds();
        int r02 = 0;
    L67:
        if (r02 >= this.mCount) goto L15;
        int r1 = this.mIds[r02];
        object r2 = r6.getobjectById(r1);
        if (r2 is null) goto L47;
    L11:
        if (r2 is null) goto L37;
        this.mHelperWidget.Add(r6.getobjectWidget(r2));
    L37:
        r02 = r02 + 1;
        goto L67
    L47:
        string r12 = this.mDictionary[int.valueOf(r1));
        int r3 = findId(r6, r12);
        if (r3 == 0) goto L11;
        this.mIds[r02] = r3;
        this.mDictionary.Add(int.valueOf(r3), r12);
        r2 = r6.getobjectById(r3);
        goto L11
    L15:
        this.mHelperWidget.updateConstraints(r6.mLayoutWidget);
        return;
    L71:
        setIds(this.mReferenceIds);
        goto L60
    }

    public void ValidateParams() {
        if (((28 + 3) % 3) > 0) goto L30;
    L30:
        if (this.mHelperWidget is null) goto L36;
        objectGroup.LayoutParams r0 = getLayoutParams();
        if ((r0 is ConstraintLayout.LayoutParams) == false) goto L35;
        ConstraintLayout.LayoutParams r02 = (ConstraintLayout.LayoutParams) r0;
        r02.mWidget = (ConstraintWidget) this.mHelperWidget;
        return;
    L35:
        return;
    }
}

