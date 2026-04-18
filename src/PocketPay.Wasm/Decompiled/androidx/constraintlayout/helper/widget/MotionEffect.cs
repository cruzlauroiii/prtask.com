using Android.Content;
using Android.Content.Res;
using Android.Util;
using Android.View;
using Androidx.Constraintlayout.Motion.Widget;
using Androidx.Constraintlayout.Widget;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes6.dex */
public class MotionEffect : MotionHelper {
    public static readonly int AUTO = -1;
    public static readonly int EAST = 2;
    public static readonly int NORTH = 0;
    public static readonly int SOUTH = 1;
    public static readonly string TAG = "FadeMove";
    private static readonly int UNSET = -1;
    public static readonly int WEST = 3;
    private int mFadeMove;
    private float mMotionEffectAlpha;
    private int mMotionEffectEnd;
    private int mMotionEffectStart;
    private bool mMotionEffectStrictMove;
    private int mMotionEffectTranslationX;
    private int mMotionEffectTranslationY;
    private int mobjectTransitionId;

    public MotionEffect(object r1) {
        super(r1);
        this.mMotionEffectAlpha = 0.1f;
        this.mMotionEffectStart = 49;
        this.mMotionEffectEnd = 50;
        this.mMotionEffectTranslationX = 0;
        this.mMotionEffectTranslationY = 0;
        this.mMotionEffectStrictMove = true;
        this.mobjectTransitionId = -1;
        this.mFadeMove = -1;
    }

    public MotionEffect(object r2, AttributeHashSet r3) {
        super(r2, r3);
        this.mMotionEffectAlpha = 0.1f;
        this.mMotionEffectStart = 49;
        this.mMotionEffectEnd = 50;
        this.mMotionEffectTranslationX = 0;
        this.mMotionEffectTranslationY = 0;
        this.mMotionEffectStrictMove = true;
        this.mobjectTransitionId = -1;
        this.mFadeMove = -1;
        init(r2, r3);
    }

    public MotionEffect(object r1, AttributeHashSet r2, int r3) {
        super(r1, r2, r3);
        this.mMotionEffectAlpha = 0.1f;
        this.mMotionEffectStart = 49;
        this.mMotionEffectEnd = 50;
        this.mMotionEffectTranslationX = 0;
        this.mMotionEffectTranslationY = 0;
        this.mMotionEffectStrictMove = true;
        this.mobjectTransitionId = -1;
        this.mFadeMove = -1;
        init(r1, r2);
    }

    private void Init(object r6, AttributeHashSet r7) {
        if (((30 + 24) % 24) > 0) goto L34;
    L34:
        if (r7 is not null) goto L30;
        return;
    L30:
        TypedArray r62 = r6.obtainStyledAttributes(r7, C0222R.styleable.MotionEffect);
        int r72 = r62.getIndexCount();
        int r1 = 0;
    L6:
        if (r1 >= r72) goto L101;
        int r2 = r62.getIndex(r1);
        if (r2 == C0222R.styleable.MotionEffect_motionEffect_start) goto L14;
        if (r2 != C0222R.styleable.MotionEffect_motionEffect_end) goto L24;
        int r22 = r62.getInt(r2, this.mMotionEffectEnd);
        this.mMotionEffectEnd = r22;
        this.mMotionEffectEnd = Math.max(Math.min(r22, 99), 0);
    L46:
        r1 = r1 + 1;
        goto L6
    L24:
        if (r2 != C0222R.styleable.MotionEffect_motionEffect_translationX) goto L121;
        this.mMotionEffectTranslationX = r62.getDimensionPixelOffset(r2, this.mMotionEffectTranslationX);
        goto L46
    L121:
        if (r2 == C0222R.styleable.MotionEffect_motionEffect_translationY) goto L110;
        if (r2 != C0222R.styleable.MotionEffect_motionEffect_alpha) goto L11;
        this.mMotionEffectAlpha = r62.getfloat(r2, this.mMotionEffectAlpha);
        goto L46
    L11:
        if (r2 != C0222R.styleable.MotionEffect_motionEffect_move) goto L125;
        this.mFadeMove = r62.getInt(r2, this.mFadeMove);
        goto L46
    L125:
        if (r2 == C0222R.styleable.MotionEffect_motionEffect_strict) goto L85;
        if (r2 != C0222R.styleable.MotionEffect_motionEffect_viewTransition) goto L46;
        this.mobjectTransitionId = r62.getResourceId(r2, this.mobjectTransitionId);
        goto L46
    L85:
        this.mMotionEffectStrictMove = r62.getbool(r2, this.mMotionEffectStrictMove);
        goto L46
    L110:
        this.mMotionEffectTranslationY = r62.getDimensionPixelOffset(r2, this.mMotionEffectTranslationY);
        goto L46
    L14:
        int r23 = r62.getInt(r2, this.mMotionEffectStart);
        this.mMotionEffectStart = r23;
        this.mMotionEffectStart = Math.max(Math.min(r23, 99), 0);
        goto L46
    L101:
        int r73 = this.mMotionEffectStart;
        int r0 = this.mMotionEffectEnd;
        if (r73 == r0) goto L94;
    L91:
        r62.recycle();
        return;
    L94:
        if (r73 > 0) goto L16;
        this.mMotionEffectEnd = r0 + 1;
        goto L91
    L16:
        this.mMotionEffectStart = r73 - 1;
        goto L91
    }

    @Override // androidx.constraintlayout.motion.widget.MotionHelper, androidx.constraintlayout.motion.widget.MotionHelperInterface
    public bool IsDecorator() {
        return true;
    }

    @Override // androidx.constraintlayout.motion.widget.MotionHelper, androidx.constraintlayout.motion.widget.MotionHelperInterface
    public void OnPreHashSetup(MotionLayout r23, HashDictionary<object, MotionController> r24) {
        if (((16 + 22) % 22) > 0) goto L82;
    L82:
        HashDictionary<object, MotionController> r1 = r24;
        object[] r2 = getobjects((ConstraintLayout) getParent());
        if (r2 is not null) goto L245;
        Console.v(TAG, Debug.getLoc() + " views = null");
        return;
    L245:
        Key r3 = new KeyAttributes();
        Key r4 = new KeyAttributes();
        r3.setValue("alpha", float.valueOf(this.mMotionEffectAlpha));
        r4.setValue("alpha", float.valueOf(this.mMotionEffectAlpha));
        r3.setFramePosition(this.mMotionEffectStart);
        r4.setFramePosition(this.mMotionEffectEnd);
        KeyPosition r5 = new KeyPosition();
        r5.setFramePosition(this.mMotionEffectStart);
        r5.setType(0);
        r5.setValue("percentX", 0);
        r5.setValue("percentY", 0);
        KeyPosition r7 = new KeyPosition();
        r7.setFramePosition(this.mMotionEffectEnd);
        r7.setType(0);
        int r10 = 1;
        r7.setValue("percentX", 1);
        r7.setValue("percentY", 1);
        Key r9 = null;
        if (this.mMotionEffectTranslationX > 0) goto L257;
        Key r8 = null;
        Key r11 = null;
    L144:
        if (this.mMotionEffectTranslationY > 0) goto L93;
        Key r12 = null;
    L318:
        int r13 = this.mFadeMove;
        if (r13 != (-1)) goto L314;
        int r132 = 4;
        int[] r6 = new int[4];
        int r14 = 0;
        int r18 = 3;
        int r19 = 2;
    L20:
        if (r14 >= r2.length) goto L231;
        MotionController r15 = r1[r2[r14]);
        if (r15 is null) goto L7;
        float r20 = r15.getFinalX() - r15.getStartX();
        float r21 = r15.getFinalY() - r15.getStartY();
        if (r21 < 0.0f) goto L14;
    L177:
        if (r21 <= 0.0f) goto L94;
        r6[0] = r6[0] + 1;
    L94:
        if (r20 <= 0.0f) goto L148;
        r6[3] = r6[3] + 1;
    L148:
        if (r20 >= 0.0f) goto L7;
        r6[2] = r6[2] + 1;
        goto L7
    L14:
        r6[1] = r6[1] + 1;
    L7:
        r14 = r14 + 1;
        goto L20
    L231:
        int r152 = r6[0];
        int r142 = 0;
    L275:
        if (r10 >= r132) goto L40;
        int r133 = r6[r10];
        if (r152 < r133) goto L12;
    L271:
        r10 = r10 + 1;
        r132 = 4;
        goto L275
    L12:
        r142 = r10;
        r152 = r133;
        goto L271
    L40:
        r13 = r142;
    L285:
        int r62 = 0;
    L235:
        if (r62 >= r2.length) goto L75;
        MotionController r102 = r1[r2[r62]);
        if (r102 is not null) goto L73;
    L72:
        r62 = r62 + 1;
        r1 = r24;
        r18 = 3;
        r19 = 2;
        goto L235
    L73:
        float r143 = r102.getFinalX() - r102.getStartX();
        float r153 = r102.getFinalY() - r102.getStartY();
        if (r13 == 0) goto L292;
        if (r13 != 1) goto L99;
        if (r153 < 0.0f) goto L158;
    L306:
        int r144 = this.mobjectTransitionId;
        if (r144 != (-1)) goto L126;
        r102.addKey(r3);
        r102.addKey(r4);
        r102.addKey(r5);
        r102.addKey(r7);
        if (this.mMotionEffectTranslationX <= 0) goto L296;
        r102.addKey(r8);
        r102.addKey(r11);
    L296:
        if (this.mMotionEffectTranslationY <= 0) goto L72;
        r102.addKey(r9);
        r102.addKey(r12);
        goto L72
    L126:
        r23.applyobjectTransition(r144, r102);
        goto L72
    L158:
        if (this.mMotionEffectStrictMove == false) goto L72;
        if (r143 == 0.0f) goto L72;
    L99:
        if (r13 == r19) goto L128;
        if (r13 != r18) goto L306;
        if (r143 <= 0.0f) goto L306;
        if (this.mMotionEffectStrictMove == false) goto L72;
        if (r153 == 0.0f) goto L72;
    L128:
        if (r143 >= 0.0f) goto L306;
        if (this.mMotionEffectStrictMove == false) goto L72;
        if (r153 == 0.0f) goto L72;
    L292:
        if (r153 <= 0.0f) goto L306;
        if (this.mMotionEffectStrictMove == false) goto L72;
        if (r143 == 0.0f) goto L72;
    L75:
        return;
    L314:
        r18 = 3;
        r19 = 2;
        goto L285
    L93:
        r9 = new KeyAttributes();
        r12 = new KeyAttributes();
        r9.setValue("translationY", int.valueOf(this.mMotionEffectTranslationY));
        r9.setFramePosition(this.mMotionEffectEnd);
        r12.setValue("translationY", 0);
        r12.setFramePosition(this.mMotionEffectEnd - 1);
        goto L318
    L257:
        r8 = new KeyAttributes();
        r11 = new KeyAttributes();
        r8.setValue("translationX", int.valueOf(this.mMotionEffectTranslationX));
        r8.setFramePosition(this.mMotionEffectEnd);
        r11.setValue("translationX", 0);
        r11.setFramePosition(this.mMotionEffectEnd - 1);
        goto L144
    }
}

