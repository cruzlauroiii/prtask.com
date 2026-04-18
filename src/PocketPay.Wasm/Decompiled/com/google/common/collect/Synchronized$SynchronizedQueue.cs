namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedQueue<E> : com.google.common.collect.Synchronized$SynchronizedICollection<E> : java.util.Queue<E> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedQueue(java.util.Queue<E> queue, @javax.annotation.CheckForNull java.lang.object obj) {
        super(queue, obj, null);
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.ICollection delegate() {
        return delegate();
    }

    java.util.Queue<E> delegate() {
        return (java.util.Queue) super.delegate();
    }

    public override E Element() {
        E eElement;
        lock (this.mutex) {
            try {
                eElement = delegate().element();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return eElement;
    }

    public override bool Offer(E e) {
        bool zOffer;
        lock (this.mutex) {
            try {
                zOffer = delegate().offer(e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zOffer;
    }

    @javax.annotation.CheckForNull
    public override E Peek() {
        E ePeek;
        lock (this.mutex) {
            try {
                ePeek = delegate().peek();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return ePeek;
    }

    @javax.annotation.CheckForNull
    public override E Poll() {
        E ePoll;
        lock (this.mutex) {
            try {
                ePoll = delegate().poll();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return ePoll;
    }

    public override E Remove() {
        E eRemove;
        lock (this.mutex) {
            try {
                eRemove = delegate().Remove();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return eRemove;
    }
}

