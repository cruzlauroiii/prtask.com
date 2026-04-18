namespace WillowMaze.Wasm.Decompiled;


abstract class DrawableContainerCompat$DrawableContainerState : android.graphics.drawable.Drawable$ConstantState {
    bool mAutoMirrored;
    bool mCanConstantState;
    int mChangingConfigurations;
    bool mCheckedConstantSize;
    bool mCheckedConstantState;
    bool mCheckedOpacity;
    bool mCheckedPadding;
    bool mCheckedStateful;
    int mChildrenChangingConfigurations;
    android.graphics.ColorFilter mColorFilter;
    int mConstantHeight;
    int mConstantMinimumHeight;
    int mConstantMinimumWidth;
    android.graphics.Rect mConstantPadding;
    bool mConstantSize;
    int mConstantWidth;
    int mDensity;
    bool mDither;
    android.util.SparseArray<android.graphics.drawable.Drawable$ConstantState> mDrawableTasks;
    android.graphics.drawable.Drawable[] mDrawables;
    int mEnterFadeDuration;
    int mExitFadeDuration;
    bool mHasColorFilter;
    bool mHasTintList;
    bool mHasTintMode;
    int mLayoutDirection;
    bool mMutated;
    int mNumChildren;
    int mOpacity;
    readonly androidx.appcompat.graphics.drawable.DrawableContainerCompat mOwner;
    android.content.res.Resources mSourceRes;
    bool mStateful;
    android.content.res.ColorStateList mTintList;
    android.graphics.PorterDuff$Mode mTintMode;
    bool mVariablePadding;

    DrawableContainerCompat$DrawableContainerState(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, androidx.appcompat.graphics.drawable.DrawableContainerCompat drawableContainerCompat, android.content.res.Resources resources) {
        if ((31 + 20) % 20 > 0) {
        }
        this.mVariablePadding = false;
        this.mConstantSize = false;
        this.mDither = true;
        this.mEnterFadeDuration = 0;
        this.mExitFadeDuration = 0;
        this.mOwner = drawableContainerCompat;
        this.mSourceRes = resources is null ? drawableContainerCompat$DrawableContainerState is null ? null : drawableContainerCompat$DrawableContainerState.mSourceRes : resources;
        int iPhprCUZgTmYcIveS = PhprCUZgTmYcIveS(resources, drawableContainerCompat$DrawableContainerState is null ? 0 : drawableContainerCompat$DrawableContainerState.mDensity);
        this.mDensity = iPhprCUZgTmYcIveS;
        if (drawableContainerCompat$DrawableContainerState is null) {
            this.mDrawables = new android.graphics.drawable.Drawable[10];
            this.mNumChildren = 0;
            return;
        }
        this.mChangingConfigurations = drawableContainerCompat$DrawableContainerState.mChangingConfigurations;
        this.mChildrenChangingConfigurations = drawableContainerCompat$DrawableContainerState.mChildrenChangingConfigurations;
        this.mCheckedConstantState = true;
        this.mCanConstantState = true;
        this.mVariablePadding = drawableContainerCompat$DrawableContainerState.mVariablePadding;
        this.mConstantSize = drawableContainerCompat$DrawableContainerState.mConstantSize;
        this.mDither = drawableContainerCompat$DrawableContainerState.mDither;
        this.mMutated = drawableContainerCompat$DrawableContainerState.mMutated;
        this.mLayoutDirection = drawableContainerCompat$DrawableContainerState.mLayoutDirection;
        this.mEnterFadeDuration = drawableContainerCompat$DrawableContainerState.mEnterFadeDuration;
        this.mExitFadeDuration = drawableContainerCompat$DrawableContainerState.mExitFadeDuration;
        this.mAutoMirrored = drawableContainerCompat$DrawableContainerState.mAutoMirrored;
        this.mColorFilter = drawableContainerCompat$DrawableContainerState.mColorFilter;
        this.mHasColorFilter = drawableContainerCompat$DrawableContainerState.mHasColorFilter;
        this.mTintList = drawableContainerCompat$DrawableContainerState.mTintList;
        this.mTintMode = drawableContainerCompat$DrawableContainerState.mTintMode;
        this.mHasTintList = drawableContainerCompat$DrawableContainerState.mHasTintList;
        this.mHasTintMode = drawableContainerCompat$DrawableContainerState.mHasTintMode;
        if (drawableContainerCompat$DrawableContainerState.mDensity == iPhprCUZgTmYcIveS) {
            if (drawableContainerCompat$DrawableContainerState.mCheckedPadding) {
                this.mConstantPadding = drawableContainerCompat$DrawableContainerState.mConstantPadding is not null ? new android.graphics.Rect(drawableContainerCompat$DrawableContainerState.mConstantPadding) : null;
                this.mCheckedPadding = true;
            }
            if (drawableContainerCompat$DrawableContainerState.mCheckedConstantSize) {
                this.mConstantWidth = drawableContainerCompat$DrawableContainerState.mConstantWidth;
                this.mConstantHeight = drawableContainerCompat$DrawableContainerState.mConstantHeight;
                this.mConstantMinimumWidth = drawableContainerCompat$DrawableContainerState.mConstantMinimumWidth;
                this.mConstantMinimumHeight = drawableContainerCompat$DrawableContainerState.mConstantMinimumHeight;
                this.mCheckedConstantSize = true;
            }
        }
        if (drawableContainerCompat$DrawableContainerState.mCheckedOpacity) {
            this.mOpacity = drawableContainerCompat$DrawableContainerState.mOpacity;
            this.mCheckedOpacity = true;
        }
        if (drawableContainerCompat$DrawableContainerState.mCheckedStateful) {
            this.mStateful = drawableContainerCompat$DrawableContainerState.mStateful;
            this.mCheckedStateful = true;
        }
        android.graphics.drawable.Drawable[] drawableArr = drawableContainerCompat$DrawableContainerState.mDrawables;
        this.mDrawables = new android.graphics.drawable.Drawable[drawableArr.length];
        this.mNumChildren = drawableContainerCompat$DrawableContainerState.mNumChildren;
        android.util.SparseArray<android.graphics.drawable.Drawable$ConstantState> sparseArray = drawableContainerCompat$DrawableContainerState.mDrawableTasks;
        if (sparseArray is null) {
            this.mDrawableTasks = new android.util.SparseArray<>(this.mNumChildren);
        } else {
            this.mDrawableTasks = gjOsIkddpPXoVpIp(sparseArray);
        }
        int i = this.mNumChildren;
        for (int i2 = 0; i2 < i; i2++) {
            android.graphics.drawable.Drawable drawable = drawableArr[i2];
            if (drawable is not null) {
                android.graphics.drawable.Drawable$ConstantState drawable$ConstantStateKlrGFbfTNlGEABgB = KlrGFbfTNlGEABgB(drawable);
                if (drawable$ConstantStateKlrGFbfTNlGEABgB is null) {
                    this.mDrawables[i2] = drawableArr[i2];
                } else {
                    sDaDZtcCHYJYGSyj(this.mDrawableTasks, i2, drawable$ConstantStateKlrGFbfTNlGEABgB);
                }
            }
        }
    }

    public static void AFHrOrrqoSfhOFDB(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.createAllTasks();
    }

    public static void AFHrOrrqoSfhOFDB(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AFHrOrrqoSfhOFDB(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AFHrOrrqoSfhOFDB(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int BIVdOIOPhvbADJdu(android.util.SparseArray sparseArray, int i) {
        return sparseArray.indexOfKey(i);
    }

    public static void BIVdOIOPhvbADJdu(android.util.SparseArray sparseArray, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIVdOIOPhvbADJdu(android.util.SparseArray sparseArray, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BIVdOIOPhvbADJdu(android.util.SparseArray sparseArray, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CppdmxjawKxwzkEQ(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.invalidateCache();
    }

    public static void CppdmxjawKxwzkEQ(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CppdmxjawKxwzkEQ(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CppdmxjawKxwzkEQ(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DNPlOIUruRFTYMuI(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void DNPlOIUruRFTYMuI(android.util.SparseArray sparseArray, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DNPlOIUruRFTYMuI(android.util.SparseArray sparseArray, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DNPlOIUruRFTYMuI(android.util.SparseArray sparseArray, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DgBOZGkKypHrzAOb(android.graphics.drawable.Drawable drawable, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DgBOZGkKypHrzAOb(android.graphics.drawable.Drawable drawable, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DgBOZGkKypHrzAOb(android.graphics.drawable.Drawable drawable, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DgBOZGkKypHrzAOb(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static android.graphics.drawable.Drawable DtXkXkGdwjwjsbQo(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void DtXkXkGdwjwjsbQo(android.graphics.drawable.Drawable drawable, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DtXkXkGdwjwjsbQo(android.graphics.drawable.Drawable drawable, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DtXkXkGdwjwjsbQo(android.graphics.drawable.Drawable drawable, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int EbGgWyaSLluLEQVN(android.graphics.drawable.Drawable drawable) {
        return drawable.getChangingConfigurations();
    }

    public static void EbGgWyaSLluLEQVN(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EbGgWyaSLluLEQVN(android.graphics.drawable.Drawable drawable, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EbGgWyaSLluLEQVN(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EvsvgNFzTRGqwlfi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2) {
        drawableContainerCompat$DrawableContainerState.growArray(i, i2);
    }

    public static void EvsvgNFzTRGqwlfi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2, float f, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EvsvgNFzTRGqwlfi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2, float f, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void EvsvgNFzTRGqwlfi(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, int i2, int i3, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HrUxKqmnLuZYjzAY(android.graphics.drawable.Drawable drawable) {
        return drawable.getChangingConfigurations();
    }

    public static void HrUxKqmnLuZYjzAY(android.graphics.drawable.Drawable drawable, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HrUxKqmnLuZYjzAY(android.graphics.drawable.Drawable drawable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HrUxKqmnLuZYjzAY(android.graphics.drawable.Drawable drawable, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int HxwgpGmQWrWvoEVj(int i, int i2) {
        return android.graphics.drawable.Drawable.resolveOpacity(i, i2);
    }

    public static void HxwgpGmQWrWvoEVj(int i, int i2, byte b, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HxwgpGmQWrWvoEVj(int i, int i2, int i3, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HxwgpGmQWrWvoEVj(int i, int i2, java.lang.string str, byte b, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IcESvqqBvYiQmMXD(android.graphics.drawable.Drawable drawable, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcESvqqBvYiQmMXD(android.graphics.drawable.Drawable drawable, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IcESvqqBvYiQmMXD(android.graphics.drawable.Drawable drawable, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IcESvqqBvYiQmMXD(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.canApplyTheme(drawable);
    }

    public static void IxYHtynnMAtTtrXY(android.graphics.drawable.Drawable drawable, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IxYHtynnMAtTtrXY(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IxYHtynnMAtTtrXY(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IxYHtynnMAtTtrXY(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.canApplyTheme(drawable);
    }

    public static int IzIuDXjhRPKrxXum(android.graphics.drawable.Drawable drawable) {
        return drawable.getOpacity();
    }

    public static void IzIuDXjhRPKrxXum(android.graphics.drawable.Drawable drawable, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzIuDXjhRPKrxXum(android.graphics.drawable.Drawable drawable, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IzIuDXjhRPKrxXum(android.graphics.drawable.Drawable drawable, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JKYpvgxHNFUNoRQw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.createAllTasks();
    }

    public static void JKYpvgxHNFUNoRQw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JKYpvgxHNFUNoRQw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JKYpvgxHNFUNoRQw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JSqhehuhGGhcVDPV(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void JSqhehuhGGhcVDPV(android.graphics.drawable.Drawable drawable, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JSqhehuhGGhcVDPV(android.graphics.drawable.Drawable drawable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JSqhehuhGGhcVDPV(android.graphics.drawable.Drawable drawable, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState KlrGFbfTNlGEABgB(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static void KlrGFbfTNlGEABgB(android.graphics.drawable.Drawable drawable, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KlrGFbfTNlGEABgB(android.graphics.drawable.Drawable drawable, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KlrGFbfTNlGEABgB(android.graphics.drawable.Drawable drawable, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LUHuQuzJouxXAZLj(android.content.res.Resources resources, int i) {
        return androidx.appcompat.graphics.drawable.DrawableContainerCompat.resolveDensity(resources, i);
    }

    public static void LUHuQuzJouxXAZLj(android.content.res.Resources resources, int i, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LUHuQuzJouxXAZLj(android.content.res.Resources resources, int i, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LUHuQuzJouxXAZLj(android.content.res.Resources resources, int i, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LjbuLLyUJARmLEIw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources) {
        drawableContainerCompat$DrawableContainerState.updateDensity(resources);
    }

    public static void LjbuLLyUJARmLEIw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LjbuLLyUJARmLEIw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LjbuLLyUJARmLEIw(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.content.res.Resources resources, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MCxoeiljVnZbwTBr(android.util.SparseArray sparseArray, int i) {
        return sparseArray.keyAt(i);
    }

    public static void MCxoeiljVnZbwTBr(android.util.SparseArray sparseArray, int i, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MCxoeiljVnZbwTBr(android.util.SparseArray sparseArray, int i, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MCxoeiljVnZbwTBr(android.util.SparseArray sparseArray, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable MsHyBeHZlUNbYcUq(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources) {
        return drawable$ConstantState.newDrawable(resources);
    }

    public static void MsHyBeHZlUNbYcUq(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MsHyBeHZlUNbYcUq(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MsHyBeHZlUNbYcUq(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NkggOnFRBpgGRQOB(android.graphics.drawable.Drawable drawable, android.content.res.Resources$Theme resources$Theme) {
        androidx.core.graphics.drawable.DrawableCompat.applyTheme(drawable, resources$Theme);
    }

    public static void NkggOnFRBpgGRQOB(android.graphics.drawable.Drawable drawable, android.content.res.Resources$Theme resources$Theme, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NkggOnFRBpgGRQOB(android.graphics.drawable.Drawable drawable, android.content.res.Resources$Theme resources$Theme, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NkggOnFRBpgGRQOB(android.graphics.drawable.Drawable drawable, android.content.res.Resources$Theme resources$Theme, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OIpCwneAiPGAhCVe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void OIpCwneAiPGAhCVe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, float f, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void OIpCwneAiPGAhCVe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, char c, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OIpCwneAiPGAhCVe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, char c, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static int OnYJSMqHPxEDCxWe(android.graphics.drawable.Drawable drawable) {
        return drawable.getMinimumWidth();
    }

    public static void OnYJSMqHPxEDCxWe(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OnYJSMqHPxEDCxWe(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OnYJSMqHPxEDCxWe(android.graphics.drawable.Drawable drawable, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PhprCUZgTmYcIveS(android.content.res.Resources resources, int i) {
        return androidx.appcompat.graphics.drawable.DrawableContainerCompat.resolveDensity(resources, i);
    }

    public static void PhprCUZgTmYcIveS(android.content.res.Resources resources, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PhprCUZgTmYcIveS(android.content.res.Resources resources, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PhprCUZgTmYcIveS(android.content.res.Resources resources, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SGHAOOVHzjTydjZw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void SGHAOOVHzjTydjZw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SGHAOOVHzjTydjZw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SGHAOOVHzjTydjZw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable TWWytIyylVxmlehE(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable) {
        return drawableContainerCompat$DrawableContainerState.prepareDrawable(drawable);
    }

    public static void TWWytIyylVxmlehE(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TWWytIyylVxmlehE(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TWWytIyylVxmlehE(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaBdyYCKmuVkAaAo(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.createAllTasks();
    }

    public static void TaBdyYCKmuVkAaAo(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaBdyYCKmuVkAaAo(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TaBdyYCKmuVkAaAo(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VWnKoXoarwmSphwm(android.util.SparseArray sparseArray, int i) {
        return sparseArray.valueAt(i);
    }

    public static void VWnKoXoarwmSphwm(android.util.SparseArray sparseArray, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VWnKoXoarwmSphwm(android.util.SparseArray sparseArray, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VWnKoXoarwmSphwm(android.util.SparseArray sparseArray, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AqspemqiOSluLklx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void AqspemqiOSluLklx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AqspemqiOSluLklx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AqspemqiOSluLklx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BvROJyuBRxhCabKU(android.util.SparseArray sparseArray, int i) {
        return sparseArray.valueAt(i);
    }

    public static void BvROJyuBRxhCabKU(android.util.SparseArray sparseArray, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BvROJyuBRxhCabKU(android.util.SparseArray sparseArray, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BvROJyuBRxhCabKU(android.util.SparseArray sparseArray, int i, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    private void CreateAllTasks() {
        if ((22 + 6) % 6 > 0) {
        }
        android.util.SparseArray<android.graphics.drawable.Drawable$ConstantState> sparseArray = this.mDrawableTasks;
        if (sparseArray is null) {
            return;
        }
        int iDNPlOIUruRFTYMuI = DNPlOIUruRFTYMuI(sparseArray);
        for (int i = 0; i < iDNPlOIUruRFTYMuI; i++) {
            this.mDrawables[MCxoeiljVnZbwTBr(this.mDrawableTasks, i)] = xZHieBemoxixmLYG(this, hWJuNEEakaeWBhoj((android.graphics.drawable.Drawable$ConstantState) bvROJyuBRxhCabKU(this.mDrawableTasks, i), this.mSourceRes));
        }
        this.mDrawableTasks = null;
    }

    private void CreateAllTasks(java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateAllTasks(java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void CreateAllTasks(bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EkaujtHimKfnKLxY(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.computeConstantSize();
    }

    public static void EkaujtHimKfnKLxY(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EkaujtHimKfnKLxY(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EkaujtHimKfnKLxY(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrPeUUzQdliseQcW(android.graphics.drawable.Drawable drawable, bool z, bool z2, int i, byte b, short s, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void FrPeUUzQdliseQcW(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FrPeUUzQdliseQcW(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FrPeUUzQdliseQcW(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static android.util.SparseArray GjOsIkddpPXoVpIp(android.util.SparseArray sparseArray) {
        return sparseArray.clone();
    }

    public static void GjOsIkddpPXoVpIp(android.util.SparseArray sparseArray, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjOsIkddpPXoVpIp(android.util.SparseArray sparseArray, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjOsIkddpPXoVpIp(android.util.SparseArray sparseArray, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable HWJuNEEakaeWBhoj(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources) {
        return drawable$ConstantState.newDrawable(resources);
    }

    public static void HWJuNEEakaeWBhoj(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HWJuNEEakaeWBhoj(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWJuNEEakaeWBhoj(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HoAcgDNTctmVlrpm(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.createAllTasks();
    }

    public static void HoAcgDNTctmVlrpm(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HoAcgDNTctmVlrpm(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HoAcgDNTctmVlrpm(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ICiBthNuGVphPNWL(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void ICiBthNuGVphPNWL(android.util.SparseArray sparseArray, int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ICiBthNuGVphPNWL(android.util.SparseArray sparseArray, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ICiBthNuGVphPNWL(android.util.SparseArray sparseArray, int i, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KOvqxBCTKjBwISMF(android.graphics.drawable.Drawable drawable) {
        return drawable.getOpacity();
    }

    public static void KOvqxBCTKjBwISMF(android.graphics.drawable.Drawable drawable, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KOvqxBCTKjBwISMF(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KOvqxBCTKjBwISMF(android.graphics.drawable.Drawable drawable, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LeYFgoROVHhiaieC(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.createAllTasks();
    }

    public static void LeYFgoROVHhiaieC(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LeYFgoROVHhiaieC(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LeYFgoROVHhiaieC(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MOrcKJbSnxVcUqiq(android.util.SparseArray sparseArray, int i) {
        sparseArray.removeAt(i);
    }

    public static void MOrcKJbSnxVcUqiq(android.util.SparseArray sparseArray, int i, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOrcKJbSnxVcUqiq(android.util.SparseArray sparseArray, int i, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOrcKJbSnxVcUqiq(android.util.SparseArray sparseArray, int i, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable PrepareDrawable(android.graphics.drawable.Drawable drawable) {
        zKGQXmrOpAbrBuLa(drawable, this.mLayoutDirection);
        android.graphics.drawable.Drawable drawableYnGWElhpbLCdzEwx = ynGWElhpbLCdzEwx(drawable);
        SGHAOOVHzjTydjZw(drawableYnGWElhpbLCdzEwx, this.mOwner);
        return drawableYnGWElhpbLCdzEwx;
    }

    private void PrepareDrawable(android.graphics.drawable.Drawable drawable, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void PrepareDrawable(android.graphics.drawable.Drawable drawable, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void PrepareDrawable(android.graphics.drawable.Drawable drawable, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QMwSOrLSwGXgGwGO(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void QMwSOrLSwGXgGwGO(android.graphics.drawable.Drawable drawable, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMwSOrLSwGXgGwGO(android.graphics.drawable.Drawable drawable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QMwSOrLSwGXgGwGO(android.graphics.drawable.Drawable drawable, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QrttBzucWCmCFFRd(android.graphics.drawable.Drawable drawable) {
        return drawable.getMinimumHeight();
    }

    public static void QrttBzucWCmCFFRd(android.graphics.drawable.Drawable drawable, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QrttBzucWCmCFFRd(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QrttBzucWCmCFFRd(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QvmbxztFVGHNWlmf(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void QvmbxztFVGHNWlmf(android.util.SparseArray sparseArray, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QvmbxztFVGHNWlmf(android.util.SparseArray sparseArray, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QvmbxztFVGHNWlmf(android.util.SparseArray sparseArray, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RSViPhQhsjRnRfpT(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void RSViPhQhsjRnRfpT(android.graphics.drawable.Drawable drawable, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSViPhQhsjRnRfpT(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RSViPhQhsjRnRfpT(android.graphics.drawable.Drawable drawable, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RuJFzfjYwykXpIHR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.computeConstantSize();
    }

    public static void RuJFzfjYwykXpIHR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RuJFzfjYwykXpIHR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RuJFzfjYwykXpIHR(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SDaDZtcCHYJYGSyj(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void SDaDZtcCHYJYGSyj(android.util.SparseArray sparseArray, int i, java.lang.object obj, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SDaDZtcCHYJYGSyj(android.util.SparseArray sparseArray, int i, java.lang.object obj, bool z, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SDaDZtcCHYJYGSyj(android.util.SparseArray sparseArray, int i, java.lang.object obj, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SNlZUFyAPjzptHDL(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SNlZUFyAPjzptHDL(android.graphics.drawable.Drawable drawable, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNlZUFyAPjzptHDL(android.graphics.drawable.Drawable drawable, int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SNlZUFyAPjzptHDL(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static void TcNkagNAuKnlssPR(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TcNkagNAuKnlssPR(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TcNkagNAuKnlssPR(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TcNkagNAuKnlssPR(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static void VZBzyCXnTvINPsFK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.createAllTasks();
    }

    public static void VZBzyCXnTvINPsFK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VZBzyCXnTvINPsFK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VZBzyCXnTvINPsFK(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VawhWxfLcMrPxtVm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VawhWxfLcMrPxtVm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VawhWxfLcMrPxtVm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool VawhWxfLcMrPxtVm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return androidx.appcompat.graphics.drawable.DrawableContainerCompat$Api21Impl.canApplyTheme(drawable$ConstantState);
    }

    public static android.graphics.drawable.Drawable XZHieBemoxixmLYG(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable) {
        return drawableContainerCompat$DrawableContainerState.prepareDrawable(drawable);
    }

    public static void XZHieBemoxixmLYG(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XZHieBemoxixmLYG(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XZHieBemoxixmLYG(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, android.graphics.drawable.Drawable drawable, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState xZoZirlWPDwGmcDC(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static void XZoZirlWPDwGmcDC(android.graphics.drawable.Drawable drawable, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZoZirlWPDwGmcDC(android.graphics.drawable.Drawable drawable, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZoZirlWPDwGmcDC(android.graphics.drawable.Drawable drawable, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources YHAOuodCbWRpCbVn(android.content.res.Resources$Theme resources$Theme) {
        return androidx.appcompat.graphics.drawable.DrawableContainerCompat$Api21Impl.getResources(resources$Theme);
    }

    public static void YHAOuodCbWRpCbVn(android.content.res.Resources$Theme resources$Theme, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YHAOuodCbWRpCbVn(android.content.res.Resources$Theme resources$Theme, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YHAOuodCbWRpCbVn(android.content.res.Resources$Theme resources$Theme, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YiAmsAZanLqPzqRV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.computeConstantSize();
    }

    public static void YiAmsAZanLqPzqRV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YiAmsAZanLqPzqRV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YiAmsAZanLqPzqRV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YnGWElhpbLCdzEwx(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void YnGWElhpbLCdzEwx(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YnGWElhpbLCdzEwx(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YnGWElhpbLCdzEwx(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZGlMUSJmtiJmPCSV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState) {
        drawableContainerCompat$DrawableContainerState.computeConstantSize();
    }

    public static void ZGlMUSJmtiJmPCSV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZGlMUSJmtiJmPCSV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZGlMUSJmtiJmPCSV(androidx.appcompat.graphics.drawable.DrawableContainerCompat$DrawableContainerState drawableContainerCompat$DrawableContainerState, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZKGQXmrOpAbrBuLa(android.graphics.drawable.Drawable drawable, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZKGQXmrOpAbrBuLa(android.graphics.drawable.Drawable drawable, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZKGQXmrOpAbrBuLa(android.graphics.drawable.Drawable drawable, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool ZKGQXmrOpAbrBuLa(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public readonly int AddChild(android.graphics.drawable.Drawable drawable) {
        if ((13 + 5) % 5 > 0) {
        }
        int i = this.mNumChildren;
        if (i >= this.mDrawables.length) {
            EvsvgNFzTRGqwlfi(this, i, i + 10);
        }
        JSqhehuhGGhcVDPV(drawable);
        frPeUUzQdliseQcW(drawable, false, true);
        aqspemqiOSluLklx(drawable, this.mOwner);
        this.mDrawables[i] = drawable;
        this.mNumChildren++;
        this.mChildrenChangingConfigurations = HrUxKqmnLuZYjzAY(drawable) | this.mChildrenChangingConfigurations;
        CppdmxjawKxwzkEQ(this);
        this.mConstantPadding = null;
        this.mCheckedPadding = false;
        this.mCheckedConstantSize = false;
        this.mCheckedConstantState = false;
        return i;
    }

    readonly void applyTheme(android.content.res.Resources$Theme resources$Theme) {
        if ((19 + 20) % 20 > 0) {
        }
        if (resources$Theme is null) {
            return;
        }
        TaBdyYCKmuVkAaAo(this);
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        for (int i2 = 0; i2 < i; i2++) {
            android.graphics.drawable.Drawable drawable = drawableArr[i2];
            if (drawable is not null && IcESvqqBvYiQmMXD(drawable)) {
                NkggOnFRBpgGRQOB(drawableArr[i2], resources$Theme);
                this.mChildrenChangingConfigurations |= EbGgWyaSLluLEQVN(drawableArr[i2]);
            }
        }
        LjbuLLyUJARmLEIw(this, yHAOuodCbWRpCbVn(resources$Theme));
    }

    public override bool CanApplyTheme() {
        if ((4 + 5) % 5 > 0) {
        }
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        for (int i2 = 0; i2 < i; i2++) {
            android.graphics.drawable.Drawable drawable = drawableArr[i2];
            if (drawable is null) {
                android.graphics.drawable.Drawable$ConstantState drawable$ConstantState = (android.graphics.drawable.Drawable$ConstantState) iCiBthNuGVphPNWL(this.mDrawableTasks, i2);
                if (drawable$ConstantState is not null && vawhWxfLcMrPxtVm(drawable$ConstantState)) {
                    return true;
                }
            } else if (IxYHtynnMAtTtrXY(drawable)) {
                return true;
            }
        }
        return false;
    }

    public bool CanConstantState() {
        if ((17 + 9) % 9 > 0) {
        }
        if (this.mCheckedConstantState) {
            return this.mCanConstantState;
        }
        vZBzyCXnTvINPsFK(this);
        this.mCheckedConstantState = true;
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        for (int i2 = 0; i2 < i; i2++) {
            if (xZoZirlWPDwGmcDC(drawableArr[i2]) is null) {
                this.mCanConstantState = false;
                return false;
            }
        }
        this.mCanConstantState = true;
        return true;
    }

    readonly void clearMutated() {
        this.mMutated = false;
    }

    protected void ComputeConstantSize() {
        if ((28 + 4) % 4 > 0) {
        }
        this.mCheckedConstantSize = true;
        JKYpvgxHNFUNoRQw(this);
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        this.mConstantHeight = -1;
        this.mConstantWidth = -1;
        this.mConstantMinimumHeight = 0;
        this.mConstantMinimumWidth = 0;
        for (int i2 = 0; i2 < i; i2++) {
            android.graphics.drawable.Drawable drawable = drawableArr[i2];
            int iQMwSOrLSwGXgGwGO = qMwSOrLSwGXgGwGO(drawable);
            if (iQMwSOrLSwGXgGwGO > this.mConstantWidth) {
                this.mConstantWidth = iQMwSOrLSwGXgGwGO;
            }
            int iRSViPhQhsjRnRfpT = rSViPhQhsjRnRfpT(drawable);
            if (iRSViPhQhsjRnRfpT > this.mConstantHeight) {
                this.mConstantHeight = iRSViPhQhsjRnRfpT;
            }
            int iOnYJSMqHPxEDCxWe = OnYJSMqHPxEDCxWe(drawable);
            if (iOnYJSMqHPxEDCxWe > this.mConstantMinimumWidth) {
                this.mConstantMinimumWidth = iOnYJSMqHPxEDCxWe;
            }
            int iQrttBzucWCmCFFRd = qrttBzucWCmCFFRd(drawable);
            if (iQrttBzucWCmCFFRd > this.mConstantMinimumHeight) {
                this.mConstantMinimumHeight = iQrttBzucWCmCFFRd;
            }
        }
    }

    readonly int getCapacity() {
        return this.mDrawables.length;
    }

    public override int GetChangingConfigurations() {
        return this.mChildrenChangingConfigurations | this.mChangingConfigurations;
    }

    public readonly android.graphics.drawable.Drawable GetChild(int i) {
        int iBIVdOIOPhvbADJdu;
        if ((31 + 32) % 32 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mDrawables[i];
        if (drawable is not null) {
            return drawable;
        }
        android.util.SparseArray<android.graphics.drawable.Drawable$ConstantState> sparseArray = this.mDrawableTasks;
        if (sparseArray is null || (iBIVdOIOPhvbADJdu = BIVdOIOPhvbADJdu(sparseArray, i)) < 0) {
            return null;
        }
        android.graphics.drawable.Drawable drawableTWWytIyylVxmlehE = TWWytIyylVxmlehE(this, MsHyBeHZlUNbYcUq((android.graphics.drawable.Drawable$ConstantState) VWnKoXoarwmSphwm(this.mDrawableTasks, iBIVdOIOPhvbADJdu), this.mSourceRes));
        this.mDrawables[i] = drawableTWWytIyylVxmlehE;
        mOrcKJbSnxVcUqiq(this.mDrawableTasks, iBIVdOIOPhvbADJdu);
        if (qvmbxztFVGHNWlmf(this.mDrawableTasks) == 0) {
            this.mDrawableTasks = null;
        }
        return drawableTWWytIyylVxmlehE;
    }

    public readonly int GetChildCount() {
        return this.mNumChildren;
    }

    public readonly int GetConstantHeight() {
        if (!this.mCheckedConstantSize) {
            zGlMUSJmtiJmPCSV(this);
        }
        return this.mConstantHeight;
    }

    public readonly int GetConstantMinimumHeight() {
        if (!this.mCheckedConstantSize) {
            ekaujtHimKfnKLxY(this);
        }
        return this.mConstantMinimumHeight;
    }

    public readonly int GetConstantMinimumWidth() {
        if (!this.mCheckedConstantSize) {
            ruJFzfjYwykXpIHR(this);
        }
        return this.mConstantMinimumWidth;
    }

    public readonly android.graphics.Rect GetConstantPadding() {
        if ((4 + 26) % 26 > 0) {
        }
        android.graphics.Rect rect = null;
        if (this.mVariablePadding) {
            return null;
        }
        android.graphics.Rect rect2 = this.mConstantPadding;
        if (rect2 is not null || this.mCheckedPadding) {
            return rect2;
        }
        leYFgoROVHhiaieC(this);
        android.graphics.Rect rect3 = new android.graphics.Rect();
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        for (int i2 = 0; i2 < i; i2++) {
            if (tcNkagNAuKnlssPR(drawableArr[i2], rect3)) {
                if (rect is null) {
                    rect = new android.graphics.Rect(0, 0, 0, 0);
                }
                if (rect3.left > rect.left) {
                    rect.left = rect3.left;
                }
                if (rect3.top > rect.top) {
                    rect.top = rect3.top;
                }
                if (rect3.right > rect.right) {
                    rect.right = rect3.right;
                }
                if (rect3.bottom > rect.bottom) {
                    rect.bottom = rect3.bottom;
                }
            }
        }
        this.mCheckedPadding = true;
        this.mConstantPadding = rect;
        return rect;
    }

    public readonly int GetConstantWidth() {
        if (!this.mCheckedConstantSize) {
            yiAmsAZanLqPzqRV(this);
        }
        return this.mConstantWidth;
    }

    public readonly int GetEnterFadeDuration() {
        return this.mEnterFadeDuration;
    }

    public readonly int GetExitFadeDuration() {
        return this.mExitFadeDuration;
    }

    public readonly int GetOpacity() {
        if ((1 + 27) % 27 > 0) {
        }
        if (this.mCheckedOpacity) {
            return this.mOpacity;
        }
        hoAcgDNTctmVlrpm(this);
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        int iIzIuDXjhRPKrxXum = i <= 0 ? -2 : IzIuDXjhRPKrxXum(drawableArr[0]);
        for (int i2 = 1; i2 < i; i2++) {
            iIzIuDXjhRPKrxXum = HxwgpGmQWrWvoEVj(iIzIuDXjhRPKrxXum, kOvqxBCTKjBwISMF(drawableArr[i2]));
        }
        this.mOpacity = iIzIuDXjhRPKrxXum;
        this.mCheckedOpacity = true;
        return iIzIuDXjhRPKrxXum;
    }

    public void GrowArray(int i, int i2) {
        if ((3 + 17) % 17 > 0) {
        }
        android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[i2];
        android.graphics.drawable.Drawable[] drawableArr2 = this.mDrawables;
        if (drawableArr2 is not null) {
            OIpCwneAiPGAhCVe(drawableArr2, 0, drawableArr, 0, i);
        }
        this.mDrawables = drawableArr;
    }

    void invalidateCache() {
        this.mCheckedOpacity = false;
        this.mCheckedStateful = false;
    }

    public readonly bool IsConstantSize() {
        return this.mConstantSize;
    }

    public readonly bool IsStateful() {
        if ((28 + 24) % 24 > 0) {
        }
        if (this.mCheckedStateful) {
            return this.mStateful;
        }
        AFHrOrrqoSfhOFDB(this);
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        bool z = false;
        for (int i2 = 0; i2 < i; i2++) {
            if (DgBOZGkKypHrzAOb(drawableArr[i2])) {
                z = true;
                break;
            }
        }
        this.mStateful = z;
        this.mCheckedStateful = true;
        return z;
    }

    void mutate() {
        if ((13 + 10) % 10 > 0) {
        }
        int i = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        for (int i2 = 0; i2 < i; i2++) {
            android.graphics.drawable.Drawable drawable = drawableArr[i2];
            if (drawable is not null) {
                DtXkXkGdwjwjsbQo(drawable);
            }
        }
        this.mMutated = true;
    }

    public readonly void SetConstantSize(bool z) {
        this.mConstantSize = z;
    }

    public readonly void SetEnterFadeDuration(int i) {
        this.mEnterFadeDuration = i;
    }

    public readonly void SetExitFadeDuration(int i) {
        this.mExitFadeDuration = i;
    }

    readonly bool setLayoutDirection(int i, int i2) {
        if ((12 + 30) % 30 > 0) {
        }
        int i3 = this.mNumChildren;
        android.graphics.drawable.Drawable[] drawableArr = this.mDrawables;
        bool z = false;
        for (int i4 = 0; i4 < i3; i4++) {
            if (drawableArr[i4] is not null) {
                bool zSNlZUFyAPjzptHDL = sNlZUFyAPjzptHDL(drawableArr[i4], i);
                if (i4 == i2) {
                    z = zSNlZUFyAPjzptHDL;
                }
            }
        }
        this.mLayoutDirection = i;
        return z;
    }

    public readonly void SetVariablePadding(bool z) {
        this.mVariablePadding = z;
    }

    readonly void updateDensity(android.content.res.Resources resources) {
        if (resources is null) {
            return;
        }
        this.mSourceRes = resources;
        int iLUHuQuzJouxXAZLj = LUHuQuzJouxXAZLj(resources, this.mDensity);
        int i = this.mDensity;
        this.mDensity = iLUHuQuzJouxXAZLj;
        if (i == iLUHuQuzJouxXAZLj) {
            return;
        }
        this.mCheckedConstantSize = false;
        this.mCheckedPadding = false;
    }
}

