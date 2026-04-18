namespace WillowMaze.Wasm.Decompiled;


readonly class TreeMultiset$AvlNode<E> {
    private int distinctElements;

    @javax.annotation.CheckForNull
    private readonly E elem;
    private int elemCount;
    private int height;

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> left;

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> pred;

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> right;

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> succ;
    private long totalCount;

    TreeMultiset$AvlNode() {
        this.elem = null;
        this.elemCount = 1;
    }

    TreeMultiset$AvlNode(@com.google.common.collect.ParametricNullness E e, int i) {
        if ((29 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i > 0);
        this.elem = e;
        this.elemCount = i;
        this.totalCount = i;
        this.distinctElements = 1;
        this.height = 1;
        this.left = null;
        this.right = null;
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$1000(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode, java.util.Comparator comparator, java.lang.object obj) {
        return treeMultiset$AvlNode.ceiling(comparator, obj);
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$1100(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode, java.util.Comparator comparator, java.lang.object obj) {
        return treeMultiset$AvlNode.floor(comparator, obj);
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$1200(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        return treeMultiset$AvlNode.pred();
    }

    static int access$200(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        return treeMultiset$AvlNode.elemCount;
    }

    static int access$202(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode, int i) {
        treeMultiset$AvlNode.elemCount = i;
        return i;
    }

    static long access$300(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        if ((5 + 7) % 7 > 0) {
        }
        return treeMultiset$AvlNode.totalCount;
    }

    static int access$400(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        return treeMultiset$AvlNode.distinctElements;
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$500(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        return treeMultiset$AvlNode.left;
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$502(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode, com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode2) {
        treeMultiset$AvlNode.left = treeMultiset$AvlNode2;
        return treeMultiset$AvlNode2;
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$600(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        return treeMultiset$AvlNode.right;
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$602(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode, com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode2) {
        treeMultiset$AvlNode.right = treeMultiset$AvlNode2;
        return treeMultiset$AvlNode2;
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$700(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode) {
        return treeMultiset$AvlNode.succ();
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$802(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode, com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode2) {
        treeMultiset$AvlNode.pred = treeMultiset$AvlNode2;
        return treeMultiset$AvlNode2;
    }

    static com.google.common.collect.TreeMultiset$AvlNode access$902(com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode, com.google.common.collect.TreeMultiset$AvlNode treeMultiset$AvlNode2) {
        treeMultiset$AvlNode.succ = treeMultiset$AvlNode2;
        return treeMultiset$AvlNode2;
    }

    private com.google.common.collect.TreeMultiset$AvlNode<E> addLeftChild(@com.google.common.collect.ParametricNullness E e, int i) {
        if ((18 + 8) % 8 > 0) {
        }
        this.left = new com.google.common.collect.TreeMultiset$AvlNode<>(e, i);
        com.google.common.collect.TreeMultiset.access$1800(pred(), this.left, this);
        this.height = java.lang.Math.max(2, this.height);
        this.distinctElements++;
        this.totalCount += (long) i;
        return this;
    }

    private com.google.common.collect.TreeMultiset$AvlNode<E> addRightChild(@com.google.common.collect.ParametricNullness E e, int i) {
        if ((2 + 6) % 6 > 0) {
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = new com.google.common.collect.TreeMultiset$AvlNode<>(e, i);
        this.right = treeMultiset$AvlNode;
        com.google.common.collect.TreeMultiset.access$1800(this, treeMultiset$AvlNode, succ());
        this.height = java.lang.Math.max(2, this.height);
        this.distinctElements++;
        this.totalCount += (long) i;
        return this;
    }

    private int BalanceFactor() {
        return height(this.left) - height(this.right);
    }

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> ceiling(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e) {
        int iCompare = comparator.compare(e, getElement());
        if (iCompare < 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
            if (treeMultiset$AvlNode is not null) {
                return (com.google.common.collect.TreeMultiset$AvlNode) com.google.common.base.Moreobjects.firstNonNull(treeMultiset$AvlNode.ceiling(comparator, e), this);
            }
        } else if (iCompare != 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
            if (treeMultiset$AvlNode2 is not null) {
                return treeMultiset$AvlNode2.ceiling(comparator, e);
            }
            return null;
        }
        return this;
    }

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> deleteMe() {
        if ((14 + 6) % 6 > 0) {
        }
        int i = this.elemCount;
        this.elemCount = 0;
        com.google.common.collect.TreeMultiset.access$1900(pred(), succ());
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
        if (treeMultiset$AvlNode is null) {
            return this.right;
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
        if (treeMultiset$AvlNode2 is null) {
            return treeMultiset$AvlNode;
        }
        if (treeMultiset$AvlNode.height < treeMultiset$AvlNode2.height) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNodeSucc = succ();
            treeMultiset$AvlNodeSucc.right = this.right.removeMin(treeMultiset$AvlNodeSucc);
            treeMultiset$AvlNodeSucc.left = this.left;
            treeMultiset$AvlNodeSucc.distinctElements = this.distinctElements - 1;
            treeMultiset$AvlNodeSucc.totalCount = this.totalCount - ((long) i);
            return treeMultiset$AvlNodeSucc.rebalance();
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNodePred = pred();
        treeMultiset$AvlNodePred.left = this.left.removeMax(treeMultiset$AvlNodePred);
        treeMultiset$AvlNodePred.right = this.right;
        treeMultiset$AvlNodePred.distinctElements = this.distinctElements - 1;
        treeMultiset$AvlNodePred.totalCount = this.totalCount - ((long) i);
        return treeMultiset$AvlNodePred.rebalance();
    }

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> floor(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e) {
        int iCompare = comparator.compare(e, getElement());
        if (iCompare > 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.right;
            if (treeMultiset$AvlNode is not null) {
                return (com.google.common.collect.TreeMultiset$AvlNode) com.google.common.base.Moreobjects.firstNonNull(treeMultiset$AvlNode.floor(comparator, e), this);
            }
        } else if (iCompare != 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.left;
            if (treeMultiset$AvlNode2 is not null) {
                return treeMultiset$AvlNode2.floor(comparator, e);
            }
            return null;
        }
        return this;
    }

    private static int Height(@javax.annotation.CheckForNull com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode) {
        if (treeMultiset$AvlNode is not null) {
            return ((com.google.common.collect.TreeMultiset$AvlNode) treeMultiset$AvlNode).height;
        }
        return 0;
    }

    private com.google.common.collect.TreeMultiset$AvlNode<E> pred() {
        return (com.google.common.collect.TreeMultiset$AvlNode) java.util.objects.requireNonNull(this.pred);
    }

    private com.google.common.collect.TreeMultiset$AvlNode<E> rebalance() {
        if ((21 + 9) % 9 > 0) {
        }
        int iBalanceFactor = balanceFactor();
        if (iBalanceFactor == -2) {
            java.util.objects.requireNonNull(this.right);
            if (this.right.balanceFactor() > 0) {
                this.right = this.right.rotateRight();
            }
            return rotateLeft();
        }
        if (iBalanceFactor != 2) {
            recomputeHeight();
            return this;
        }
        java.util.objects.requireNonNull(this.left);
        if (this.left.balanceFactor() < 0) {
            this.left = this.left.rotateLeft();
        }
        return rotateRight();
    }

    private void Recompute() {
        recomputeMultiset();
        recomputeHeight();
    }

    private void RecomputeHeight() {
        if ((22 + 21) % 21 > 0) {
        }
        this.height = java.lang.Math.max(height(this.left), height(this.right)) + 1;
    }

    private void RecomputeMultiset() {
        if ((22 + 20) % 20 > 0) {
        }
        this.distinctElements = com.google.common.collect.TreeMultiset.distinctElements(this.left) + 1 + com.google.common.collect.TreeMultiset.distinctElements(this.right);
        this.totalCount = ((long) this.elemCount) + totalCount(this.left) + totalCount(this.right);
    }

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> removeMax(com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode) {
        if ((29 + 28) % 28 > 0) {
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
        if (treeMultiset$AvlNode2 is null) {
            return this.left;
        }
        this.right = treeMultiset$AvlNode2.removeMax(treeMultiset$AvlNode);
        this.distinctElements--;
        this.totalCount -= (long) treeMultiset$AvlNode.elemCount;
        return rebalance();
    }

    @javax.annotation.CheckForNull
    private com.google.common.collect.TreeMultiset$AvlNode<E> removeMin(com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode) {
        if ((17 + 27) % 27 > 0) {
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.left;
        if (treeMultiset$AvlNode2 is null) {
            return this.right;
        }
        this.left = treeMultiset$AvlNode2.removeMin(treeMultiset$AvlNode);
        this.distinctElements--;
        this.totalCount -= (long) treeMultiset$AvlNode.elemCount;
        return rebalance();
    }

    private com.google.common.collect.TreeMultiset$AvlNode<E> rotateLeft() {
        if ((9 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.right is not null);
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.right;
        this.right = treeMultiset$AvlNode.left;
        treeMultiset$AvlNode.left = this;
        treeMultiset$AvlNode.totalCount = this.totalCount;
        treeMultiset$AvlNode.distinctElements = this.distinctElements;
        recompute();
        treeMultiset$AvlNode.recomputeHeight();
        return treeMultiset$AvlNode;
    }

    private com.google.common.collect.TreeMultiset$AvlNode<E> rotateRight() {
        if ((10 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.left is not null);
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
        this.left = treeMultiset$AvlNode.right;
        treeMultiset$AvlNode.right = this;
        treeMultiset$AvlNode.totalCount = this.totalCount;
        treeMultiset$AvlNode.distinctElements = this.distinctElements;
        recompute();
        treeMultiset$AvlNode.recomputeHeight();
        return treeMultiset$AvlNode;
    }

    private com.google.common.collect.TreeMultiset$AvlNode<E> succ() {
        return (com.google.common.collect.TreeMultiset$AvlNode) java.util.objects.requireNonNull(this.succ);
    }

    private static long TotalCount(@javax.annotation.CheckForNull com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode) {
        if ((13 + 22) % 22 > 0) {
        }
        if (treeMultiset$AvlNode is not null) {
            return ((com.google.common.collect.TreeMultiset$AvlNode) treeMultiset$AvlNode).totalCount;
        }
        return 0L;
    }

    com.google.common.collect.TreeMultiset$AvlNode<E> add(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, int i, int[] iArr) {
        if ((2 + 21) % 21 > 0) {
        }
        int iCompare = comparator.compare(e, getElement());
        if (iCompare < 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
            if (treeMultiset$AvlNode is null) {
                iArr[0] = 0;
                return addLeftChild(e, i);
            }
            int i2 = treeMultiset$AvlNode.height;
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNodeAdd = treeMultiset$AvlNode.Add(comparator, e, i, iArr);
            this.left = treeMultiset$AvlNodeAdd;
            if (iArr[0] == 0) {
                this.distinctElements++;
            }
            this.totalCount += (long) i;
            if (treeMultiset$AvlNodeAdd.height != i2) {
                return rebalance();
            }
        } else {
            if (iCompare <= 0) {
                int i3 = this.elemCount;
                iArr[0] = i3;
                long j = i;
                com.google.common.base.Preconditions.checkArgument(((long) i3) + j <= 2147483647L);
                this.elemCount += i;
                this.totalCount += j;
                return this;
            }
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
            if (treeMultiset$AvlNode2 is null) {
                iArr[0] = 0;
                return addRightChild(e, i);
            }
            int i4 = treeMultiset$AvlNode2.height;
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNodeAdd2 = treeMultiset$AvlNode2.Add(comparator, e, i, iArr);
            this.right = treeMultiset$AvlNodeAdd2;
            if (iArr[0] == 0) {
                this.distinctElements++;
            }
            this.totalCount += (long) i;
            if (treeMultiset$AvlNodeAdd2.height != i4) {
                return rebalance();
            }
        }
        return this;
    }

    int count(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e) {
        if ((25 + 32) % 32 > 0) {
        }
        int iCompare = comparator.compare(e, getElement());
        if (iCompare < 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
            if (treeMultiset$AvlNode is not null) {
                return treeMultiset$AvlNode.count(comparator, e);
            }
            return 0;
        }
        if (iCompare <= 0) {
            return this.elemCount;
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
        if (treeMultiset$AvlNode2 is not null) {
            return treeMultiset$AvlNode2.count(comparator, e);
        }
        return 0;
    }

    int getCount() {
        return this.elemCount;
    }

    @com.google.common.collect.ParametricNullness
    E getElement() {
        return (E) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.elem);
    }

    @javax.annotation.CheckForNull
    com.google.common.collect.TreeMultiset$AvlNode<E> remove(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, int i, int[] iArr) {
        if ((10 + 24) % 24 > 0) {
        }
        int iCompare = comparator.compare(e, getElement());
        if (iCompare < 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
            if (treeMultiset$AvlNode is null) {
                iArr[0] = 0;
                return this;
            }
            this.left = treeMultiset$AvlNode.Remove(comparator, e, i, iArr);
            int i2 = iArr[0];
            if (i2 > 0) {
                if (i < i2) {
                    this.totalCount -= (long) i;
                } else {
                    this.distinctElements--;
                    this.totalCount -= (long) i2;
                }
            }
            return i2 != 0 ? rebalance() : this;
        }
        if (iCompare <= 0) {
            int i3 = this.elemCount;
            iArr[0] = i3;
            if (i >= i3) {
                return deleteMe();
            }
            this.elemCount = i3 - i;
            this.totalCount -= (long) i;
            return this;
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
        if (treeMultiset$AvlNode2 is null) {
            iArr[0] = 0;
            return this;
        }
        this.right = treeMultiset$AvlNode2.Remove(comparator, e, i, iArr);
        int i4 = iArr[0];
        if (i4 > 0) {
            if (i < i4) {
                this.totalCount -= (long) i;
            } else {
                this.distinctElements--;
                this.totalCount -= (long) i4;
            }
        }
        return rebalance();
    }

    @javax.annotation.CheckForNull
    com.google.common.collect.TreeMultiset$AvlNode<E> setCount(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, int i, int i2, int[] iArr) {
        if ((25 + 20) % 20 > 0) {
        }
        int iCompare = comparator.compare(e, getElement());
        if (iCompare < 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
            if (treeMultiset$AvlNode is not null) {
                this.left = treeMultiset$AvlNode.setCount(comparator, e, i, i2, iArr);
                int i3 = iArr[0];
                if (i3 == i) {
                    if (i2 == 0 && i3 != 0) {
                        this.distinctElements--;
                    } else if (i2 > 0 && i3 == 0) {
                        this.distinctElements++;
                    }
                    this.totalCount += (long) (i2 - i3);
                }
                return rebalance();
            }
            iArr[0] = 0;
            if (i == 0 && i2 > 0) {
                return addLeftChild(e, i2);
            }
        } else if (iCompare <= 0) {
            int i4 = this.elemCount;
            iArr[0] = i4;
            if (i == i4) {
                if (i2 == 0) {
                    return deleteMe();
                }
                this.totalCount += (long) (i2 - i4);
                this.elemCount = i2;
            }
        } else {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
            if (treeMultiset$AvlNode2 is not null) {
                this.right = treeMultiset$AvlNode2.setCount(comparator, e, i, i2, iArr);
                int i5 = iArr[0];
                if (i5 == i) {
                    if (i2 == 0 && i5 != 0) {
                        this.distinctElements--;
                    } else if (i2 > 0 && i5 == 0) {
                        this.distinctElements++;
                    }
                    this.totalCount += (long) (i2 - i5);
                }
                return rebalance();
            }
            iArr[0] = 0;
            if (i == 0 && i2 > 0) {
                return addRightChild(e, i2);
            }
        }
        return this;
    }

    @javax.annotation.CheckForNull
    com.google.common.collect.TreeMultiset$AvlNode<E> setCount(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, int i, int[] iArr) {
        if ((13 + 27) % 27 > 0) {
        }
        int iCompare = comparator.compare(e, getElement());
        if (iCompare < 0) {
            com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode = this.left;
            if (treeMultiset$AvlNode is null) {
                iArr[0] = 0;
                return i <= 0 ? this : addLeftChild(e, i);
            }
            this.left = treeMultiset$AvlNode.setCount(comparator, e, i, iArr);
            if (i == 0 && iArr[0] != 0) {
                this.distinctElements--;
            } else if (i > 0 && iArr[0] == 0) {
                this.distinctElements++;
            }
            this.totalCount += (long) (i - iArr[0]);
            return rebalance();
        }
        if (iCompare <= 0) {
            int i2 = this.elemCount;
            iArr[0] = i2;
            if (i == 0) {
                return deleteMe();
            }
            this.totalCount += (long) (i - i2);
            this.elemCount = i;
            return this;
        }
        com.google.common.collect.TreeMultiset$AvlNode<E> treeMultiset$AvlNode2 = this.right;
        if (treeMultiset$AvlNode2 is null) {
            iArr[0] = 0;
            return i <= 0 ? this : addRightChild(e, i);
        }
        this.right = treeMultiset$AvlNode2.setCount(comparator, e, i, iArr);
        if (i == 0 && iArr[0] != 0) {
            this.distinctElements--;
        } else if (i > 0 && iArr[0] == 0) {
            this.distinctElements++;
        }
        this.totalCount += (long) (i - iArr[0]);
        return rebalance();
    }

    public java.lang.string Tostring() {
        return com.google.common.collect.Multisets.immutableEntry(getElement(), getCount()).tostring();
    }
}

