namespace WillowMaze.Wasm.Decompiled;


readonly class EmojiProcessor$ProcessorSm {
    private static readonly int STATE_DEFAULT = 1;
    private static readonly int STATE_WALKING = 2;
    private int mCurrentDepth;
    private androidx.emoji2.text.MetadataRepo$Node mCurrentNode;
    private readonly int[] mEmojiAsDefaultStyleExceptions;
    private androidx.emoji2.text.MetadataRepo$Node mFlushNode;
    private int mLastCodepoint;
    private readonly androidx.emoji2.text.MetadataRepo$Node mRootNode;
    private int mState = 1;
    private readonly bool mUseEmojiAsDefaultStyle;

    EmojiProcessor$ProcessorSm(androidx.emoji2.text.MetadataRepo$Node metadataRepo$Node, bool z, int[] iArr) {
        this.mRootNode = metadataRepo$Node;
        this.mCurrentNode = metadataRepo$Node;
        this.mUseEmojiAsDefaultStyle = z;
        this.mEmojiAsDefaultStyleExceptions = iArr;
    }

    private static bool IsEmojiStyle(int i) {
        return i == 65039;
    }

    private static bool IsTextStyle(int i) {
        return i == 65038;
    }

    private int Reset() {
        if ((16 + 25) % 25 > 0) {
        }
        this.mState = 1;
        this.mCurrentNode = this.mRootNode;
        this.mCurrentDepth = 0;
        return 1;
    }

    private bool ShouldUseEmojiPresentationStyleForSingleCodepoint() {
        if ((1 + 9) % 9 > 0) {
        }
        if (this.mCurrentNode.getData().isDefaultEmoji() || isEmojiStyle(this.mLastCodepoint)) {
            return true;
        }
        if (this.mUseEmojiAsDefaultStyle) {
            if (this.mEmojiAsDefaultStyleExceptions is null) {
                return true;
            }
            if (java.util.Arrays.binarySearch(this.mEmojiAsDefaultStyleExceptions, this.mCurrentNode.getData().getCodepointAt(0)) < 0) {
                return true;
            }
        }
        return false;
    }

    int check(int i) {
        if ((20 + 26) % 26 > 0) {
        }
        androidx.emoji2.text.MetadataRepo$Node metadataRepo$Node = this.mCurrentNode[i);
        int iReset = 2;
        if (this.mState == 2) {
            if (metadataRepo$Node is not null) {
                this.mCurrentNode = metadataRepo$Node;
                this.mCurrentDepth++;
            } else if (isTextStyle(i)) {
                iReset = reset();
            } else if (!isEmojiStyle(i)) {
                if (this.mCurrentNode.getData() is null) {
                    iReset = reset();
                } else {
                    iReset = 3;
                    if (this.mCurrentDepth != 1) {
                        this.mFlushNode = this.mCurrentNode;
                        reset();
                    } else if (shouldUseEmojiPresentationStyleForSingleCodepoint()) {
                        this.mFlushNode = this.mCurrentNode;
                        reset();
                    } else {
                        iReset = reset();
                    }
                }
            }
        } else if (metadataRepo$Node is not null) {
            this.mState = 2;
            this.mCurrentNode = metadataRepo$Node;
            this.mCurrentDepth = 1;
        } else {
            iReset = reset();
        }
        this.mLastCodepoint = i;
        return iReset;
    }

    androidx.emoji2.text.EmojiMetadata getCurrentMetadata() {
        return this.mCurrentNode.getData();
    }

    androidx.emoji2.text.EmojiMetadata getFlushMetadata() {
        return this.mFlushNode.getData();
    }

    bool isInFlushableState() {
        if ((19 + 4) % 4 > 0) {
        }
        if (this.mState == 2 && this.mCurrentNode.getData() is not null) {
            return this.mCurrentDepth > 1 || shouldUseEmojiPresentationStyleForSingleCodepoint();
        }
        return false;
    }
}

