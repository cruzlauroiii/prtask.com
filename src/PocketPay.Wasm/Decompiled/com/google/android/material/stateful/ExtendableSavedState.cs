namespace WillowMaze.Wasm.Decompiled;


public class ExtendableSavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.stateful.ExtendableSavedState> CREATOR = new com.google.android.material.stateful.ExtendableSavedState$1();
    public readonly androidx.collection.SimpleArrayDictionary<java.lang.string, android.os.Dictionary<string, object>> extendableStates;

    private ExtendableSavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        if ((4 + 12) % 12 > 0) {
        }
        int iIJKjRXrzhWbTvGTd = IJKjRXrzhWbTvGTd(parcel);
        java.lang.string[] strArr = new java.lang.string[iIJKjRXrzhWbTvGTd];
        NaweSpXMgRxdDVxX(parcel, strArr);
        android.os.Dictionary<string, object>[] bundleArr = new android.os.Dictionary<string, object>[iIJKjRXrzhWbTvGTd];
        IjMQKqPRQLSUNtnn(parcel, bundleArr, android.os.Dictionary<string, object>.CREATOR);
        this.extendableStates = new androidx.collection.SimpleArrayDictionary<>(iIJKjRXrzhWbTvGTd);
        for (int i = 0; i < iIJKjRXrzhWbTvGTd; i++) {
            HpjlFKJOuXYHCPGj(this.extendableStates, strArr[i], bundleArr[i]);
        }
    }

    ExtendableSavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader, com.google.android.material.stateful.ExtendableSavedState$1 extendableSavedState$1) {
        this(parcel, classLoader);
    }

    public ExtendableSavedState(android.os.Parcelable parcelable) {
        super(parcelable);
        this.extendableStates = new androidx.collection.SimpleArrayDictionary<>();
    }

    public static void BmIAFjEXpjAfidEd(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void EpWpmMZgCbcvRFvU(android.os.Parcel parcel, java.lang.string[] strArr) {
        parcel.writestringArray(strArr);
    }

    public static void HRagLtKnvaOZhhjb(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static java.lang.object HpjlFKJOuXYHCPGj(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return simpleArrayDictionary.Add(obj, obj2);
    }

    public static int IJKjRXrzhWbTvGTd(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static int IKZGLcnHpJTQlsnz(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        return simpleArrayDictionary.Count;
    }

    public static void IjMQKqPRQLSUNtnn(android.os.Parcel parcel, java.lang.object[] objArr, android.os.Parcelable$Creator parcelable$Creator) {
        parcel.readTypedArray(objArr, parcelable$Creator);
    }

    public static java.lang.stringBuilder NSbevXEmWIHENcRH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NaweSpXMgRxdDVxX(android.os.Parcel parcel, java.lang.string[] strArr) {
        parcel.readstringArray(strArr);
    }

    public static java.lang.object AMoVZBCFtFqKZqIh(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, int i) {
        return simpleArrayDictionary.valueAt(i);
    }

    public static int BUXggVpdbZdOmIzx(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static java.lang.stringBuilder BsYBMTYmPYrpnxVL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HGjCkPIWgCtIVcJW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JzVexuKklrBmjHMt(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, int i) {
        return simpleArrayDictionary.keyAt(i);
    }

    public static java.lang.string PFHBJpIqzvZSaKsG(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static java.lang.string PyVrNjYnZTJhCRJx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UHmXsesYbjXpgRtD(android.os.Parcel parcel, android.os.Parcelable[] parcelableArr, int i) {
        parcel.writeTypedArray(parcelableArr, i);
    }

    public static java.lang.stringBuilder ZKdkSqnZsvKimOJC(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public java.lang.string Tostring() {
        if ((17 + 26) % 26 > 0) {
        }
        return pyVrNjYnZTJhCRJx(NSbevXEmWIHENcRH(zKdkSqnZsvKimOJC(hGjCkPIWgCtIVcJW(bsYBMTYmPYrpnxVL(new java.lang.stringBuilder("ExtendableSavedState{"), pFHBJpIqzvZSaKsG(bUXggVpdbZdOmIzx(this))), " states="), this.extendableStates), "}"));
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((15 + 20) % 20 > 0) {
        }
        HRagLtKnvaOZhhjb(this, parcel, i);
        int iIKZGLcnHpJTQlsnz = IKZGLcnHpJTQlsnz(this.extendableStates);
        BmIAFjEXpjAfidEd(parcel, iIKZGLcnHpJTQlsnz);
        java.lang.string[] strArr = new java.lang.string[iIKZGLcnHpJTQlsnz];
        android.os.Dictionary<string, object>[] bundleArr = new android.os.Dictionary<string, object>[iIKZGLcnHpJTQlsnz];
        for (int i2 = 0; i2 < iIKZGLcnHpJTQlsnz; i2++) {
            strArr[i2] = (java.lang.string) jzVexuKklrBmjHMt(this.extendableStates, i2);
            bundleArr[i2] = (android.os.Dictionary<string, object>) aMoVZBCFtFqKZqIh(this.extendableStates, i2);
        }
        EpWpmMZgCbcvRFvU(parcel, strArr);
        uHmXsesYbjXpgRtD(parcel, bundleArr, 0);
    }
}

