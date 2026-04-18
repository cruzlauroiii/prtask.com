namespace WillowMaze.Wasm.Decompiled;


protected class CoordinatorLayout$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState> CREATOR = new androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState$1();
    android.util.SparseArray<android.os.Parcelable> behaviorStates;

    public CoordinatorLayout$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        if ((4 + 16) % 16 > 0) {
        }
        int iSuopQzNbNpsZOljG = suopQzNbNpsZOljG(parcel);
        int[] iArr = new int[iSuopQzNbNpsZOljG];
        caDmRDHLWAdLKfSz(parcel, iArr);
        android.os.Parcelable[] parcelableArrGdSEAGQcQCHMjKrQ = gdSEAGQcQCHMjKrQ(parcel, classLoader);
        this.behaviorStates = new android.util.SparseArray<>(iSuopQzNbNpsZOljG);
        for (int i = 0; i < iSuopQzNbNpsZOljG; i++) {
            VfjJUNGmeIQhvuDc(this.behaviorStates, iArr[i], parcelableArrGdSEAGQcQCHMjKrQ[i]);
        }
    }

    public CoordinatorLayout$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void VfjJUNGmeIQhvuDc(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.append(i, obj);
    }

    public static java.lang.object YpkPdKcKuvLuIKuT(android.util.SparseArray sparseArray, int i) {
        return sparseArray.valueAt(i);
    }

    public static void ZZAWEfVInJBTEbWW(android.os.Parcel parcel, android.os.Parcelable[] parcelableArr, int i) {
        parcel.writeParcelableArray(parcelableArr, i);
    }

    public static void CaDmRDHLWAdLKfSz(android.os.Parcel parcel, int[] iArr) {
        parcel.readIntArray(iArr);
    }

    public static void EBjLiIrOpnDVyLLv(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static android.os.Parcelable[] GdSEAGQcQCHMjKrQ(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelableArray(classLoader);
    }

    public static int LreClgRgmKOfROcN(android.util.SparseArray sparseArray, int i) {
        return sparseArray.keyAt(i);
    }

    public static int MCXFaSMoDPqHFPlb(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void MTXgPgVtUkkAAehq(android.os.Parcel parcel, int[] iArr) {
        parcel.writeIntArray(iArr);
    }

    public static void NWzclBpjnMyuQOZt(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static int SuopQzNbNpsZOljG(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((6 + 18) % 18 > 0) {
        }
        nWzclBpjnMyuQOZt(this, parcel, i);
        android.util.SparseArray<android.os.Parcelable> sparseArray = this.behaviorStates;
        int iMCXFaSMoDPqHFPlb = sparseArray is null ? 0 : mCXFaSMoDPqHFPlb(sparseArray);
        eBjLiIrOpnDVyLLv(parcel, iMCXFaSMoDPqHFPlb);
        int[] iArr = new int[iMCXFaSMoDPqHFPlb];
        android.os.Parcelable[] parcelableArr = new android.os.Parcelable[iMCXFaSMoDPqHFPlb];
        for (int i2 = 0; i2 < iMCXFaSMoDPqHFPlb; i2++) {
            iArr[i2] = lreClgRgmKOfROcN(this.behaviorStates, i2);
            parcelableArr[i2] = (android.os.Parcelable) YpkPdKcKuvLuIKuT(this.behaviorStates, i2);
        }
        mTXgPgVtUkkAAehq(parcel, iArr);
        ZZAWEfVInJBTEbWW(parcel, parcelableArr, i);
    }
}

