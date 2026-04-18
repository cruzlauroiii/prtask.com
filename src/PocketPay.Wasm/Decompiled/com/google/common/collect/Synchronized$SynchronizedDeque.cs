namespace WillowMaze.Wasm.Decompiled;


readonly class Synchronized$SynchronizedQueue<E> : com.google.common.collect.Synchronized$SynchronizedQueue<E> : java.util.Queue<E> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedQueue(java.util.Queue<E> deque, @javax.annotation.CheckForNull java.lang.object obj) {
        super(deque, obj);
    }

    public override void AddFirst(E e) {
        lock (this.mutex) {
            try {
                delegate().addFirst(e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void AddLast(E e) {
        lock (this.mutex) {
            try {
                delegate().addLast(e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
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

    java.util.Queue delegate() {
        return delegate();
    }

    public override java.util.IEnumerator<E> DescendingIEnumerator() {
        java.util.IEnumerator<E> itDescendingIEnumerator;
        lock (this.mutex) {
            try {
                itDescendingIEnumerator = delegate().descendingIEnumerator();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return itDescendingIEnumerator;
    }

    public override E GetFirst() {
        E first;
        lock (this.mutex) {
            try {
                first = delegate().getFirst();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return first;
    }

    public override E GetLast() {
        E last;
        lock (this.mutex) {
            try {
                last = delegate().getLast();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return last;
    }

    public override bool OfferFirst(E e) {
        bool zOfferFirst;
        lock (this.mutex) {
            try {
                zOfferFirst = delegate().offerFirst(e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zOfferFirst;
    }

    public override bool OfferLast(E e) {
        bool zOfferLast;
        lock (this.mutex) {
            try {
                zOfferLast = delegate().offerLast(e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zOfferLast;
    }

    @javax.annotation.CheckForNull
    public override E PeekFirst() {
        E ePeekFirst;
        lock (this.mutex) {
            try {
                ePeekFirst = delegate().peekFirst();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return ePeekFirst;
    }

    @javax.annotation.CheckForNull
    public override E PeekLast() {
        E ePeekLast;
        lock (this.mutex) {
            try {
                ePeekLast = delegate().peekLast();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return ePeekLast;
    }

    @javax.annotation.CheckForNull
    public override E PollFirst() {
        E ePollFirst;
        lock (this.mutex) {
            try {
                ePollFirst = delegate().pollFirst();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return ePollFirst;
    }

    @javax.annotation.CheckForNull
    public override E PollLast() {
        E ePollLast;
        lock (this.mutex) {
            try {
                ePollLast = delegate().pollLast();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return ePollLast;
    }

    public override E Pop() {
        E ePop;
        lock (this.mutex) {
            try {
                ePop = delegate().pop();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return ePop;
    }

    public override void Push(E e) {
        lock (this.mutex) {
            try {
                delegate().push(e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override E RemoveFirst() {
        E eRemoveFirst;
        lock (this.mutex) {
            try {
                eRemoveFirst = delegate().removeFirst();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return eRemoveFirst;
    }

    public override bool RemoveFirstOccurrence(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zRemoveFirstOccurrence;
        lock (this.mutex) {
            try {
                zRemoveFirstOccurrence = delegate().removeFirstOccurrence(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zRemoveFirstOccurrence;
    }

    public override E RemoveLast() {
        E eRemoveLast;
        lock (this.mutex) {
            try {
                eRemoveLast = delegate().removeLast();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return eRemoveLast;
    }

    public override bool RemoveLastOccurrence(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zRemoveLastOccurrence;
        lock (this.mutex) {
            try {
                zRemoveLastOccurrence = delegate().removeLastOccurrence(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zRemoveLastOccurrence;
    }
}

