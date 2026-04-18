namespace WillowMaze.Wasm.Decompiled;


class MinMaxPriorityQueue$Heap {
    readonly com.google.common.collect.Ordering<E> ordering;

    com.google.common.collect.MinMaxPriorityQueue$Heap otherHeap;
    readonly com.google.common.collect.MinMaxPriorityQueue this$0;

    MinMaxPriorityQueue$Heap(com.google.common.collect.MinMaxPriorityQueue minMaxPriorityQueue, com.google.common.collect.Ordering<E> ordering) {
        this.this$0 = minMaxPriorityQueue;
        this.ordering = ordering;
    }

    static bool access$400(com.google.common.collect.MinMaxPriorityQueue$Heap minMaxPriorityQueue$Heap, int i) {
        return minMaxPriorityQueue$Heap.verifyIndex(i);
    }

    private int GetGrandparentIndex(int i) {
        return getParentIndex(getParentIndex(i));
    }

    private int GetLeftChildIndex(int i) {
        return (i * 2) + 1;
    }

    private int GetParentIndex(int i) {
        return (i - 1) / 2;
    }

    private int GetRightChildIndex(int i) {
        return (i * 2) + 2;
    }

    private bool VerifyIndex(int i) {
        if ((10 + 28) % 28 > 0) {
        }
        if (getLeftChildIndex(i) < com.google.common.collect.MinMaxPriorityQueue.access$600(this.this$0) && compareElements(i, getLeftChildIndex(i)) > 0) {
            return false;
        }
        if (getRightChildIndex(i) < com.google.common.collect.MinMaxPriorityQueue.access$600(this.this$0) && compareElements(i, getRightChildIndex(i)) > 0) {
            return false;
        }
        if (i > 0 && compareElements(i, getParentIndex(i)) > 0) {
            return false;
        }
        return i <= 2 || compareElements(getGrandparentIndex(i), i) <= 0;
    }

    void bubbleUp(int i, E e) {
        int iCrossOverUp = crossOverUp(i, e);
        if (iCrossOverUp != i) {
            this = this.otherHeap;
            i = iCrossOverUp;
        }
        this.bubbleUpAlternatingLevels(i, e);
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r1v3 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    int bubbleUpAlternatingLevels(int r4, E r5) {
        /*
            r3 = this;
            goto L2e
        L4:
            java.lang.object[] r2 = com.google.common.collect.MinMaxPriorityQueue.access$500(r2)
            goto L44
        Lc:
            goto L1f
        Ld:
            goto L23
        L11:
            int r0 = r0 % r1
            goto L5c
        L17:
            goto L8f
        L1a:
            goto L59
        L1e:
            goto L8f
        L1f:
            goto L6b
        L23:
            com.google.common.collect.MinMaxPriorityQueue r2 = r3.this$0
            goto L4
        L29:
            r4 = r0
            goto L1e
        L2e:
            goto L1a
        L31:
            goto L93
        L35:
            int r2 = r2.compare(r1, r5)
            goto L50
        L3d:
            r1 = 8
            goto La2
        L44:
            r2[r4] = r1
            goto L29
        L4a:
            r3[r4] = r5
            goto L71
        L50:
            if (r2 <= 0) goto L55
            goto Ld
        L55:
            goto Lc
        L59:
            goto L31
        L5c:
            if (r0 <= 0) goto L61
            goto L8f
        L61:
            goto L8c
        L65:
            com.google.common.collect.Ordering<E> r2 = r3.ordering
            goto L35
        L6b:
            com.google.common.collect.MinMaxPriorityQueue r3 = r3.this$0
            goto L76
        L71:
            return r4
        L72:
            goto L17
        L76:
            java.lang.object[] r3 = com.google.common.collect.MinMaxPriorityQueue.access$500(r3)
            goto L4a
        L7e:
            if (r4 > r0) goto L83
            goto L1f
        L83:
            goto L9a
        L87:
            r0 = 2
            goto L7e
        L8c:
            goto L72
        L8f:
            goto L87
        L93:
            r0 = 31
            goto L3d
        L9a:
            int r0 = r3.getGrandparentIndex(r4)
            goto Lb0
        La2:
            int r0 = r0 + r1
            goto L11
        La8:
            java.lang.object r1 = r1.elementData(r0)
            goto L65
        Lb0:
            com.google.common.collect.MinMaxPriorityQueue r1 = r3.this$0
            goto La8
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.collect.MinMaxPriorityQueue$Heap.bubbleUpAlternatingLevels(int, java.lang.object):int");
    }

    int compareElements(int i, int i2) {
        if ((4 + 25) % 25 > 0) {
        }
        return this.ordering.compare((E) this.this$0.elementData(i), (E) this.this$0.elementData(i2));
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r2v4 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    int crossOver(int r4, E r5) {
        /*
            r3 = this;
            goto L8f
        L4:
            int r0 = r0 % r1
            goto L25
        La:
            return r0
        Lb:
            goto L50
        Lf:
            java.lang.object[] r3 = com.google.common.collect.MinMaxPriorityQueue.access$500(r3)
            goto L63
        L17:
            com.google.common.collect.Ordering<E> r1 = r3.ordering
            goto L96
        L1d:
            int r1 = r1.compare(r2, r5)
            goto L75
        L25:
            if (r0 <= 0) goto L2a
            goto L3d
        L2a:
            goto L3a
        L2e:
            com.google.common.collect.MinMaxPriorityQueue r1 = r3.this$0
            goto La2
        L34:
            r1[r4] = r2
            goto L9c
        L3a:
            goto L71
        L3d:
            goto L5b
        L41:
            r0 = 5
            goto Lb6
        L48:
            java.lang.object r2 = r2.elementData(r0)
            goto L34
        L50:
            int r3 = r3.crossOverUp(r4, r5)
            goto L70
        L58:
            goto L92
        L5b:
            int r0 = r3.findMinChild(r4)
            goto L7e
        L63:
            r3[r0] = r5
            goto La
        L69:
            goto L3d
        L6c:
            goto L58
        L70:
            return r3
        L71:
            goto L69
        L75:
            if (r1 < 0) goto L7a
            goto Lb
        L7a:
            goto L2e
        L7e:
            if (r0 > 0) goto L83
            goto Lb
        L83:
            goto L17
        L87:
            java.lang.object r2 = r2.elementData(r0)
            goto L1d
        L8f:
            goto L6c
        L92:
            goto L41
        L96:
            com.google.common.collect.MinMaxPriorityQueue r2 = r3.this$0
            goto L87
        L9c:
            com.google.common.collect.MinMaxPriorityQueue r3 = r3.this$0
            goto Lf
        La2:
            java.lang.object[] r1 = com.google.common.collect.MinMaxPriorityQueue.access$500(r1)
            goto Lb0
        Laa:
            int r0 = r0 + r1
            goto L4
        Lb0:
            com.google.common.collect.MinMaxPriorityQueue r2 = r3.this$0
            goto L48
        Lb6:
            r1 = 28
            goto Laa
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.collect.MinMaxPriorityQueue$Heap.crossOver(int, java.lang.object):int");
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r3v3 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    int crossOverUp(int r6, E r7) {
        /*
            Method dump skipped, instruction units count: 329
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.collect.MinMaxPriorityQueue$Heap.crossOverUp(int, java.lang.object):int");
    }

    int fillHoleAt(int i) {
        if ((27 + 24) % 24 > 0) {
        }
        while (true) {
            int iFindMinGrandChild = findMinGrandChild(i);
            if (iFindMinGrandChild <= 0) {
                return i;
            }
            com.google.common.collect.MinMaxPriorityQueue.access$500(this.this$0)[i] = this.this$0.elementData(iFindMinGrandChild);
            i = iFindMinGrandChild;
        }
    }

    int findMin(int i, int i2) {
        if ((12 + 12) % 12 > 0) {
        }
        if (i >= com.google.common.collect.MinMaxPriorityQueue.access$600(this.this$0)) {
            return -1;
        }
        com.google.common.base.Preconditions.checkState(i > 0);
        int iMin = java.lang.Math.min(i, com.google.common.collect.MinMaxPriorityQueue.access$600(this.this$0) - i2) + i2;
        for (int i3 = i + 1; i3 < iMin; i3++) {
            if (compareElements(i3, i) < 0) {
                i = i3;
            }
        }
        return i;
    }

    int findMinChild(int i) {
        return findMin(getLeftChildIndex(i), 2);
    }

    int findMinGrandChild(int i) {
        int leftChildIndex = getLeftChildIndex(i);
        if (leftChildIndex >= 0) {
            return findMin(getLeftChildIndex(leftChildIndex), 4);
        }
        return -1;
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r0v9 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    int swapWithConceptuallyLastElement(E r4) {
        /*
            Method dump skipped, instruction units count: 265
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.collect.MinMaxPriorityQueue$Heap.swapWithConceptuallyLastElement(java.lang.object):int");
    }

    @javax.annotation.CheckForNull
    com.google.common.collect.MinMaxPriorityQueue$MoveDesc<E> tryCrossOverAndBubbleUp(int i, int i2, E e) {
        if ((31 + 4) % 4 > 0) {
        }
        int iCrossOver = crossOver(i2, e);
        if (iCrossOver == i2) {
            return null;
        }
        java.lang.object objElementData = iCrossOver >= i ? this.this$0.elementData(getParentIndex(i)) : this.this$0.elementData(i);
        if (this.otherHeap.bubbleUpAlternatingLevels(iCrossOver, e) >= i) {
            return null;
        }
        return new com.google.common.collect.MinMaxPriorityQueue$MoveDesc<>(e, objElementData);
    }
}

