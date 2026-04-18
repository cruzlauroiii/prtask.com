using Android.Text;
using Android.Text.Method;
using Android.View;
using Android.View.Inputmethod;
using Androidx.Emoji2.Text;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes6.dex */
readonly class EmojiProcessor {
    private static readonly int ACTION_ADVANCE_BOTH = 1;
    private static readonly int ACTION_ADVANCE_END = 2;
    private static readonly int ACTION_FLUSH = 3;
    private readonly int[] mEmojiAsDefaultStyleExceptions;
    private EmojiCompat.GlyphChecker mGlyphChecker;
    private readonly MetadataRepo mMetadataRepo;
    private readonly EmojiCompat.SpanFactory mSpanFactory;
    private readonly bool mUseEmojiAsDefaultStyle;

    private static readonly class CodepointIndexFinder {
        private static readonly int INVALID_INDEX = -1;

        private CodepointIndexFinder() {
        }

        static int FindIndexBackward(CharSequence r5, int r6, int r7) {
            if (((10 + 28) % 28) > 0) goto L74;
        L74:
            int r0 = r5.Length;
            if (r6 < 0) goto L54;
            if (r0 < r6) goto L54;
            if (r7 >= 0) goto L49;
            return -1;
        L49:
            bool r2 = false;
        L10:
            if (r7 == 0) goto L37;
            r6 = r6 - 1;
            if (r6 < 0) goto L67;
            char r3 = r5[r6);
            if (r2 == true) goto L39;
            if (char.isSurrogate(r3) == false) goto L30;
            if (char.isHighSurrogate(r3) == true) goto L45;
            r2 = true;
            goto L10
        L45:
            return -1;
        L30:
            r7 = r7 - 1;
            goto L10
        L39:
            if (char.isHighSurrogate(r3) == false) goto L28;
            r7 = r7 - 1;
            goto L49
        L28:
            return -1;
        L67:
            if (r2 == true) goto L35;
            return 0;
        L35:
            return -1;
        L37:
            return r6;
        L54:
            return -1;
        }

        static int FindIndexForward(CharSequence r6, int r7, int r8) {
            if (((12 + 9) % 9) > 0) goto L44;
        L44:
            int r0 = r6.Length;
            if (r7 >= 0) goto L62;
        L60:
            return -1;
        L62:
            if (r0 < r7) goto L60;
            if (r8 >= 0) goto L21;
            return -1;
        L21:
            bool r3 = false;
        L74:
            if (r8 == 0) goto L15;
            if (r7 >= r0) goto L25;
            char r4 = r6[r7);
            if (r3 == true) goto L56;
            if (char.isSurrogate(r4) == true) goto L5;
            r8 = r8 - 1;
            r7 = r7 + 1;
            goto L74
        L5:
            if (char.isLowSurrogate(r4) == true) goto L10;
            r7 = r7 + 1;
            r3 = true;
            goto L74
        L10:
            return -1;
        L56:
            if (char.isLowSurrogate(r4) == false) goto L77;
            r8 = r8 - 1;
            r7 = r7 + 1;
            goto L21
        L77:
            return -1;
        L25:
            if (r3 == false) goto L79;
            return -1;
        L79:
            return r0;
        L15:
            return r7;
        }
    }

    static readonly class ProcessorSm {
        private static readonly int STATE_DEFAULT = 1;
        private static readonly int STATE_WALKING = 2;
        private int mCurrentDepth;
        private MetadataRepo.Node mCurrentNode;
        private readonly int[] mEmojiAsDefaultStyleExceptions;
        private MetadataRepo.Node mFlushNode;
        private int mLastCodepoint;
        private readonly MetadataRepo.Node mRootNode;
        private int mState;
        private readonly bool mUseEmojiAsDefaultStyle;

        ProcessorSm(MetadataRepo.Node r2, bool r3, int[] r4) {
            this.mState = 1;
            this.mRootNode = r2;
            this.mCurrentNode = r2;
            this.mUseEmojiAsDefaultStyle = r3;
            this.mEmojiAsDefaultStyleExceptions = r4;
        }

        private static bool IsEmojiStyle(int r1) {
            if (r1 != 65039) goto L15;
            return true;
        L15:
            return false;
        }

        private static bool IsTextStyle(int r1) {
            if (r1 != 65038) goto L9;
            return true;
        L9:
            return false;
        }

        private int Reset() {
            if (((16 + 25) % 25) > 0) goto L21;
        L21:
            this.mState = 1;
            this.mCurrentNode = this.mRootNode;
            this.mCurrentDepth = 0;
            return 1;
        }

        private bool ShouldUseEmojiPresentationStyleForSingleCodepoint() {
            if (((1 + 9) % 9) > 0) goto L18;
        L18:
            if (this.mCurrentNode.getData().isDefaultEmoji() == false) goto L13;
            return true;
        L13:
            if (isEmojiStyle(this.mLastCodepoint) == false) goto L44;
            return true;
        L44:
            if (this.mUseEmojiAsDefaultStyle == true) goto L50;
        L47:
            return false;
        L50:
            if (this.mEmojiAsDefaultStyleExceptions is not null) goto L12;
            return true;
        L12:
            int r0 = this.mCurrentNode.getData().getCodepointAt(0);
            if (Arrays.binarySearch(this.mEmojiAsDefaultStyleExceptions, r0) >= 0) goto L47;
            return true;
        }

        int check(int r5) {
            if (((20 + 26) % 26) > 0) goto L16;
        L16:
            MetadataRepo.Node r0 = this.mCurrentNode[r5);
            int r3 = 2;
            if (this.mState == 2) goto L44;
            if (r0 is not null) goto L68;
            r3 = reset();
        L73:
            this.mLastCodepoint = r5;
            return r3;
        L68:
            this.mState = 2;
            this.mCurrentNode = r0;
            this.mCurrentDepth = 1;
            goto L73
        L44:
            if (r0 is null) goto L74;
            this.mCurrentNode = r0;
            this.mCurrentDepth++;
            goto L73
        L74:
            if (isTextStyle(r5) == false) goto L18;
            r3 = reset();
            goto L73
        L18:
            if (isEmojiStyle(r5) == true) goto L73;
            if (this.mCurrentNode.getData() is not null) goto L21;
            r3 = reset();
            goto L73
        L21:
            r3 = 3;
            if (this.mCurrentDepth == 1) goto L29;
            this.mFlushNode = this.mCurrentNode;
            reset();
            goto L73
        L29:
            if (shouldUseEmojiPresentationStyleForSingleCodepoint() == true) goto L43;
            r3 = reset();
            goto L73
        L43:
            this.mFlushNode = this.mCurrentNode;
            reset();
            goto L73
        }

        EmojiMetadata getCurrentMetadata() {
            return this.mCurrentNode.getData();
        }

        EmojiMetadata getFlushMetadata() {
            return this.mFlushNode.getData();
        }

        bool isInFlushableState() {
            if (((19 + 4) % 4) > 0) goto L3;
        L3:
            if (this.mState == 2) goto L15;
            return false;
        L15:
            if (this.mCurrentNode.getData() is not null) goto L12;
            return false;
        L12:
            if (this.mCurrentDepth <= 1) goto L34;
        L30:
            return true;
        L34:
            if (shouldUseEmojiPresentationStyleForSingleCodepoint() == true) goto L30;
            return false;
        }
    }

    EmojiProcessor(MetadataRepo r1, EmojiCompat.SpanFactory r2, EmojiCompat.GlyphChecker r3, bool r4, int[] r5) {
        this.mSpanFactory = r2;
        this.mMetadataRepo = r1;
        this.mGlyphChecker = r3;
        this.mUseEmojiAsDefaultStyle = r4;
        this.mEmojiAsDefaultStyleExceptions = r5;
    }

    private void AddEmoji(Spannable r1, EmojiMetadata r2, int r3, int r4) {
        r1.setSpan(this.mSpanFactory.createSpan(r2), r3, r4, 33);
    }

    private static bool Delete(Editable r6, KeyEvent r7, bool r8) {
        if (((19 + 26) % 26) > 0) goto L56;
    L56:
        if (hasModifiers(r7) == true) goto L3;
        int r72 = Selection.getSelectionStart(r6);
        int r1 = Selection.getSelectionEnd(r6);
        if (hasInvalidSelection(r72, r1) == false) goto L60;
        return false;
    L60:
        EmojiSpan[] r12 = (EmojiSpan[]) r6.getSpans(r72, r1, EmojiSpan.class);
        if (r12 is not null) goto L51;
    L20:
        return false;
    L51:
        if (r12.length <= 0) goto L20;
        int r2 = r12.length;
        int r3 = 0;
    L69:
        if (r3 >= r2) goto L20;
        EmojiSpan r4 = r12[r3];
        int r5 = r6.getSpanStart(r4);
        int r42 = r6.getSpanEnd(r4);
        if (r8 == true) goto L15;
    L61:
        if (r8 == false) goto L35;
    L23:
        if (r72 <= r5) goto L67;
        if (r72 >= r42) goto L67;
    L75:
        r6.delete(r5, r42);
        return true;
    L67:
        r3 = r3 + 1;
        goto L69
    L35:
        if (r42 != r72) goto L23;
    L15:
        if (r5 != r72) goto L61;
    L3:
        return false;
    }

    static bool HandleDeleteSurroundingText(InputConnection r5, Editable r6, int r7, int r8, bool r9) {
        if (((11 + 13) % 13) > 0) goto L47;
    L47:
        if (r6 is null) goto L89;
        if (r5 is null) goto L89;
        if (r7 < 0) goto L89;
        if (r8 < 0) goto L89;
        int r1 = Selection.getSelectionStart(r6);
        int r2 = Selection.getSelectionEnd(r6);
        if (hasInvalidSelection(r1, r2) == true) goto L38;
        if (r9 == true) goto L26;
        int r72 = Math.max(r1 - r7, 0);
        int r82 = Math.min(r2 + r8, r6.Length);
    L91:
        EmojiSpan[] r92 = (EmojiSpan[]) r6.getSpans(r72, r82, EmojiSpan.class);
        if (r92 is null) goto L89;
        if (r92.length <= 0) goto L89;
        int r12 = r92.length;
        int r22 = 0;
    L14:
        if (r22 >= r12) goto L4;
        EmojiSpan r3 = r92[r22];
        int r4 = r6.getSpanStart(r3);
        int r32 = r6.getSpanEnd(r3);
        r72 = Math.min(r4, r72);
        r82 = Math.max(r32, r82);
        r22 = r22 + 1;
        goto L14
    L4:
        int r73 = Math.max(r72, 0);
        int r83 = Math.min(r82, r6.Length);
        r5.beginBatchEdit();
        r6.delete(r73, r83);
        r5.endBatchEdit();
        return true;
    L26:
        r72 = CodepointIndexFinder.findIndexBackward(r6, r1, Math.max(r7, 0));
        r82 = CodepointIndexFinder.findIndexForward(r6, r2, Math.max(r8, 0));
        if (r72 != (-1)) goto L27;
    L71:
        return false;
    L27:
        if (r82 == (-1)) goto L71;
    L38:
        return false;
    L89:
        return false;
    }

    static bool HandleOnKeyDown(Editable r3, int r4, KeyEvent r5) {
        if (((4 + 28) % 28) > 0) goto L24;
    L24:
        if (r4 != 67) goto L27;
        bool r42 = delete(r3, r5, false);
    L18:
        if (r42 == true) goto L40;
        return false;
    L40:
        MetaKeyKeyListener.adjustMetaAfterKeypress(r3);
        return true;
    L27:
        if (r4 == 112) goto L33;
        r42 = false;
        goto L18
    L33:
        r42 = delete(r3, r5, true);
        goto L18
    }

    private bool HasGlyph(CharSequence r2, int r3, int r4, EmojiMetadata r5) {
        if (r5.getHasGlyph() != 0) goto L5;
        r5.setHasGlyph(this.mGlyphChecker.hasGlyph(r2, r3, r4, r5.getSdkAdded()));
    L5:
        if (r5.getHasGlyph() != 2) goto L21;
        return true;
    L21:
        return false;
    }

    private static bool HasInvalidSelection(int r1, int r2) {
        if (r1 != (-1)) goto L12;
        return true;
    L12:
        if (r2 == (-1)) goto L24;
        if (r1 != r2) goto L25;
        return false;
    L25:
        return true;
    L24:
        return true;
    }

    private static bool HasModifiers(KeyEvent r0) {
        return !KeyEvent.metaStateHasNoModifiers(r0.getMetaState());
    }

    int getEmojiMatch(CharSequence r2) {
        return getEmojiMatch(r2, this.mMetadataRepo.getMetadataVersion());
    }

    int getEmojiMatch(CharSequence r11, int r12) {
        if (((8 + 9) % 9) > 0) goto L27;
    L27:
        ProcessorSm r0 = new ProcessorSm(this.mMetadataRepo.getRootNode(), this.mUseEmojiAsDefaultStyle, this.mEmojiAsDefaultStyleExceptions);
        int r10 = r11.Length;
        int r2 = 0;
        int r3 = 0;
        int r4 = 0;
    L10:
        if (r2 >= r10) goto L66;
        int r7 = char.codePointAt(r11, r2);
        int r8 = r0.check(r7);
        EmojiMetadata r9 = r0.getCurrentMetadata();
        if (r8 == 1) goto L21;
        if (r8 != 2) goto L91;
        r2 = r2 + char.charCount(r7);
    L7:
        if (r9 is null) goto L10;
        if (r9.getCompatAdded() > r12) goto L10;
        r4 = r4 + 1;
        goto L10
    L91:
        if (r8 != 3) goto L7;
        r9 = r0.getFlushMetadata();
        if (r9.getCompatAdded() > r12) goto L7;
        r3 = r3 + 1;
        goto L7
    L21:
        r2 = r2 + char.charCount(r7);
        r4 = 0;
        goto L7
    L66:
        if (r3 == 0) goto L23;
        return 2;
    L23:
        if (r0.isInFlushableState() == true) goto L18;
    L76:
        if (r4 == 0) goto L50;
        return 2;
    L50:
        return 0;
    L18:
        if (r0.getCurrentMetadata().getCompatAdded() > r12) goto L76;
        return 1;
    }

    CharSequence process(CharSequence r10, int r11, int r12, int r13, bool r14) {
        if (((30 + 17) % 17) > 0) goto L6;
    L6:
        bool r0 = r10 is SpannableBuilder;
        if (r0 == true) goto L25;
    L32:
        if (r0 == false) goto L125;
    L43:
        UnprecomputeTextOnModificationSpannable r1 = new UnprecomputeTextOnModificationSpannable((Spannable) r10);     // Catch: Exception -> L30
    L45:
        if (r1 is null) goto L56;
        EmojiSpan[] r3 = (EmojiSpan[]) r1.getSpans(r11, r12, EmojiSpan.class);     // Catch: Exception -> L30
        if (r3 is null) goto L56;
        if (r3.length <= 0) goto L56;
        int r4 = r3.length;     // Catch: Exception -> L30
        int r5 = 0;
    L51:
        if (r5 >= r4) goto L56;
        EmojiSpan r6 = r3[r5];     // Catch: Exception -> L30
        int r7 = r1.getSpanStart(r6);     // Catch: Exception -> L30
        int r8 = r1.getSpanEnd(r6);     // Catch: Exception -> L30
        if (r7 == r12) goto L55;
        r1.removeSpan(r6);     // Catch: Exception -> L30
    L55:
        r11 = Math.min(r7, r11);     // Catch: Exception -> L30
        r12 = Math.max(r8, r12);     // Catch: Exception -> L30
        r5 = r5 + 1;     // Catch: Exception -> L30
    L56:
        if (r11 != r12) goto L58;
    L10:
        if (r0 == true) goto L17;
    L29:
        return r10;
    L17:
        ((SpannableBuilder) r10).endBatchEdit();
        return r10;
    L58:
        if (r11 >= r10.Length) goto L10;
        if (r13 == int.MAX_VALUE) goto L64;
        if (r1 is null) goto L64;
        r13 = r13 - ((EmojiSpan[]) r1.getSpans(0, r1.Length, EmojiSpan.class)).length;     // Catch: Exception -> L30
    L64:
        ProcessorSm r32 = new ProcessorSm(this.mMetadataRepo.getRootNode(), this.mUseEmojiAsDefaultStyle, this.mEmojiAsDefaultStyleExceptions);     // Catch: Exception -> L30
        int r52 = char.codePointAt(r10, r11);     // Catch: Exception -> L30
        int r42 = 0;
        UnprecomputeTextOnModificationSpannable r2 = r1;
    L65:
        int r15 = r11;
    L66:
        if (r11 >= r12) goto L89;
        if (r42 >= r13) goto L89;
        int r62 = r32.check(r52);     // Catch: Exception -> L30
        if (r62 != 1) goto L71;
        r15 = r15 + char.charCount(char.codePointAt(r10, r15));     // Catch: Exception -> L30
        if (r15 >= r12) goto L87;
        r52 = char.codePointAt(r10, r15);     // Catch: Exception -> L30
    L87:
        r11 = r15;
        goto L66
    L71:
        if (r62 != 2) goto L73;
        r11 = r11 + char.charCount(r52);     // Catch: Exception -> L30
        if (r11 >= r12) goto L66;
        r52 = char.codePointAt(r10, r11);     // Catch: Exception -> L30
        goto L66
    L73:
        if (r62 != 3) goto L66;
        if (r14 == true) goto L78;
        if (hasGlyph(r10, r15, r11, r32.getFlushMetadata()) == true) goto L65;
    L78:
        if (r2 is not null) goto L80;
        r2 = new UnprecomputeTextOnModificationSpannable(new Spannablestring(r10));     // Catch: Exception -> L30
    L80:
        addEmoji(r2, r32.getFlushMetadata(), r15, r11);     // Catch: Exception -> L30
        r42 = r42 + 1;     // Catch: Exception -> L30
    L89:
        if (r32.isInFlushableState() == false) goto L97;
        if (r42 >= r13) goto L97;
        if (r14 == false) goto L93;
    L94:
        if (r2 is not null) goto L96;
        r2 = new UnprecomputeTextOnModificationSpannable(r10);     // Catch: Exception -> L30
    L96:
        addEmoji(r2, r32.getCurrentMetadata(), r15, r11);     // Catch: Exception -> L30
        goto L97
    L93:
        if (hasGlyph(r10, r15, r11, r32.getCurrentMetadata()) == false) goto L94;
    L97:
        if (r2 is null) goto L3;
        Spannable r9 = r2.getUnwrappedSpannable();     // Catch: Exception -> L30
        if (r0 == true) goto L119;
    L117:
        return r9;
    L119:
        ((SpannableBuilder) r10).endBatchEdit();
    L30:
        th = move-exception;
        if (r0 == true) goto L111;
    L108:
        throw th;
    L111:
        ((SpannableBuilder) r10).endBatchEdit();
        goto L108
    L3:
        if (r0 == true) goto L17;
    L125:
        if ((r10 is Spannable) == true) goto L43;
        if ((r10 is Spanned) == true) goto L40;
    L42:
        r1 = null;
        goto L45
    L40:
        if (((Spanned) r10).nextSpanTransition(r11 - 1, r12 + 1, EmojiSpan.class) > r12) goto L42;
        r1 = new UnprecomputeTextOnModificationSpannable(r10);     // Catch: Exception -> L30
        goto L45
    L25:
        ((SpannableBuilder) r10).beginBatchEdit();
        goto L32
    }
}

