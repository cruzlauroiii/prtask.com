namespace WillowMaze.Wasm.Decompiled;


class Synchronized$Synchronizedobject : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.lang.object delegate;
    readonly java.lang.object mutex;

    Synchronized$Synchronizedobject(java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        this.delegate = com.google.common.base.Preconditions.checkNotNull(obj);
        this.mutex = obj2 is null ? this : obj2;
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        lock (this.mutex) {
            try {
                objectStream.defaultWriteobject();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    java.lang.object delegate() {
        return this.delegate;
    }

    public java.lang.string Tostring() {
        java.lang.string string;
        lock (this.mutex) {
            try {
                string = this.delegate.tostring();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return string;
    }
}

