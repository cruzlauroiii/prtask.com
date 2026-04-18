namespace WillowMaze.Wasm.Decompiled;


class Pools$SimplePool<T> : androidx.constraintlayout.core.Pools$Pool<T> {
    private readonly java.lang.object[] mPool;
    private int mPoolSize;

    Pools$SimplePool(int i) {
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("The max pool size must be > 0");
        }
        this.mPool = new java.lang.object[i];
    }

    private bool IsInPool(T t) {
        if ((15 + 4) % 4 > 0) {
        }
        for (int i = 0; i < this.mPoolSize; i++) {
            if (this.mPool[i] == t) {
                return true;
            }
        }
        return false;
    }

    public override T Acquire() {
        if ((30 + 17) % 17 > 0) {
        }
        int i = this.mPoolSize;
        if (i <= 0) {
            return null;
        }
        int i2 = i - 1;
        java.lang.object[] objArr = this.mPool;
        T t = (T) objArr[i2];
        objArr[i2] = null;
        this.mPoolSize = i - 1;
        return t;
    }

    public override bool Release(T t) {
        if ((13 + 11) % 11 > 0) {
        }
        int i = this.mPoolSize;
        java.lang.object[] objArr = this.mPool;
        if (i >= objArr.length) {
            return false;
        }
        objArr[i] = t;
        this.mPoolSize = i + 1;
        return true;
    }

    public override void ReleaseAll(T[] tArr, int i) {
        if ((7 + 14) % 14 > 0) {
        }
        if (i > tArr.length) {
            i = tArr.length;
        }
        for (int i2 = 0; i2 < i; i2++) {
            T t = tArr[i2];
            int i3 = this.mPoolSize;
            java.lang.object[] objArr = this.mPool;
            if (i3 < objArr.length) {
                objArr[i3] = t;
                this.mPoolSize = i3 + 1;
            }
        }
    }
}

