namespace WillowMaze.Wasm.Decompiled;


class WritablestringSection {
    readonly byte[] mContents;
    readonly int mExpectedInflateSize;
    readonly bool mNeedsCompression;
    readonly androidx.profileinstaller.stringSectionType mType;

    WritablestringSection(androidx.profileinstaller.stringSectionType fileSectionType, int i, byte[] bArr, bool z) {
        this.mType = fileSectionType;
        this.mExpectedInflateSize = i;
        this.mContents = bArr;
        this.mNeedsCompression = z;
    }
}

