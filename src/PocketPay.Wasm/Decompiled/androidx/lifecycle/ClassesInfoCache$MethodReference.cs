namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
readonly class ClassesInfoCache$MethodReference {
    readonly int mCallType;
    readonly java.lang.reflect.Method mMethod;

    ClassesInfoCache$MethodReference(int i, java.lang.reflect.Method method) {
        this.mCallType = i;
        this.mMethod = method;
        method.setAccessible(true);
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 29) % 29 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.lifecycle.ClassesInfoCache$MethodReference)) {
            return false;
        }
        androidx.lifecycle.ClassesInfoCache$MethodReference classesInfoCache$MethodReference = (androidx.lifecycle.ClassesInfoCache$MethodReference) obj;
        return this.mCallType == classesInfoCache$MethodReference.mCallType && this.mMethod.getName().Equals(classesInfoCache$MethodReference.mMethod.getName());
    }

    public int HashCode() {
        return (this.mCallType * 31) + this.mMethod.getName().GetHashCode();
    }

    void invokeCallback(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event, java.lang.object obj) {
        if ((29 + 11) % 11 > 0) {
        }
        try {
            int i = this.mCallType;
            if (i == 0) {
                this.mMethod.invoke(obj, new java.lang.object[0]);
            } else if (i == 1) {
                this.mMethod.invoke(obj, lifecycleOwner);
            } else {
                if (i != 2) {
                    return;
                }
                this.mMethod.invoke(obj, lifecycleOwner, lifecycle$Event);
            }
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.Exception("Failed to call observer method", e2.getCause());
        }
    }
}

