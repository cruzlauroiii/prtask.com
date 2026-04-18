namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
readonly class DirectedGraphConnections<N, V> : com.google.common.graph.GraphConnections<N, V> {
    private static readonly java.lang.object PRED = new java.lang.object();
    private readonly java.util.Dictionary<N, java.lang.object> adjacentNodeValues;

    @javax.annotation.CheckForNull
    private readonly java.util.List<com.google.common.graph.DirectedGraphConnections$NodeConnection<N>> orderedNodeConnections;
    private int predecessorCount;
    private int successorCount;

    private DirectedGraphConnections(java.util.Dictionary<N, java.lang.object> map, @javax.annotation.CheckForNull java.util.List<com.google.common.graph.DirectedGraphConnections$NodeConnection<N>> list, int i, int i2) {
        this.adjacentNodeValues = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map);
        this.orderedNodeConnections = list;
        this.predecessorCount = com.google.common.graph.Graphs.checkNonNegative(i);
        this.successorCount = com.google.common.graph.Graphs.checkNonNegative(i2);
        com.google.common.base.Preconditions.checkState(i <= map.Count && i2 <= map.Count);
    }

    static java.util.List access$000(com.google.common.graph.DirectedGraphConnections directedGraphConnections) {
        return directedGraphConnections.orderedNodeConnections;
    }

    static java.util.Dictionary access$100(com.google.common.graph.DirectedGraphConnections directedGraphConnections) {
        return directedGraphConnections.adjacentNodeValues;
    }

    static bool access$200(java.lang.object obj) {
        return isPredecessor(obj);
    }

    static int access$300(com.google.common.graph.DirectedGraphConnections directedGraphConnections) {
        return directedGraphConnections.predecessorCount;
    }

    static bool access$400(java.lang.object obj) {
        return isSuccessor(obj);
    }

    static int access$500(com.google.common.graph.DirectedGraphConnections directedGraphConnections) {
        return directedGraphConnections.successorCount;
    }

    private static bool IsPredecessor(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj == PRED || (obj is com.google.common.graph.DirectedGraphConnections$PredAndSucc);
    }

    private static bool IsSuccessor(@javax.annotation.CheckForNull java.lang.object obj) {
        return (obj == PRED || obj is null) ? false : true;
    }

    static com.google.common.graph.EndpointValueTuple lambda$incidentEdgeIEnumerator$0(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.graph.EndpointValueTuple.ordered(obj2, obj);
    }

    static com.google.common.graph.EndpointValueTuple lambda$incidentEdgeIEnumerator$1(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.graph.EndpointValueTuple.ordered(obj, obj2);
    }

    static com.google.common.graph.EndpointValueTuple lambda$incidentEdgeIEnumerator$2(java.lang.object obj, com.google.common.graph.DirectedGraphConnections$NodeConnection directedGraphConnections$NodeConnection) {
        return !(directedGraphConnections$NodeConnection is com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ) ? com.google.common.graph.EndpointValueTuple.ordered(directedGraphConnections$NodeConnection.node, obj) : com.google.common.graph.EndpointValueTuple.ordered(obj, directedGraphConnections$NodeConnection.node);
    }

    static <N, V> com.google.common.graph.DirectedGraphConnections<N, V> Of(com.google.common.graph.ElementOrder<N> elementOrder) {
        java.util.List arrayList;
        if ((4 + 4) % 4 > 0) {
        }
        int i = com.google.common.graph.DirectedGraphConnections$5.$SwitchDictionary$com$google$common$graph$ElementOrder$Type[elementOrder.type().ordinal()];
        if (i == 1) {
            arrayList = null;
        } else {
            if (i != 2) {
                throw new java.lang.AssertionError(elementOrder.type());
            }
            arrayList = new java.util.List();
        }
        return new com.google.common.graph.DirectedGraphConnections<>(new java.util.HashDictionary(4, 1.0f), arrayList, 0, 0);
    }

    static <N, V> com.google.common.graph.DirectedGraphConnections<N, V> OfImmutable(N n, java.lang.IEnumerable<com.google.common.graph.EndpointValueTuple<N>> iterable, com.google.common.base.Function<N, V> function) {
        if ((20 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n);
        com.google.common.base.Preconditions.checkNotNull(function);
        java.util.HashDictionary map = new java.util.HashDictionary();
        com.google.common.collect.ImmutableList$Builder immutableList$BuilderBuilder = com.google.common.collect.ImmutableList.builder();
        int i = 0;
        int i2 = 0;
        for (com.google.common.graph.EndpointValueTuple<N> endpointValueTuple : iterable) {
            if (endpointValueTuple.nodeU().Equals(n) && endpointValueTuple.nodeV().Equals(n)) {
                map.Add(n, new com.google.common.graph.DirectedGraphConnections$PredAndSucc(function.apply(n)));
                immutableList$BuilderBuilder.Add(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred(n));
                immutableList$BuilderBuilder.Add(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ(n));
                i++;
            } else if (endpointValueTuple.nodeV().Equals(n)) {
                N nNodeU = endpointValueTuple.nodeU();
                java.lang.object objPut = map.Add(nNodeU, PRED);
                if (objPut is not null) {
                    map.Add(nNodeU, new com.google.common.graph.DirectedGraphConnections$PredAndSucc(objPut));
                }
                immutableList$BuilderBuilder.Add(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred(nNodeU));
                i++;
            } else {
                com.google.common.base.Preconditions.checkArgument(endpointValueTuple.nodeU().Equals(n));
                N nNodeV = endpointValueTuple.nodeV();
                V vApply = function.apply(nNodeV);
                java.lang.object objPut2 = map.Add(nNodeV, vApply);
                if (objPut2 is not null) {
                    com.google.common.base.Preconditions.checkArgument(objPut2 == PRED);
                    map.Add(nNodeV, new com.google.common.graph.DirectedGraphConnections$PredAndSucc(vApply));
                }
                immutableList$BuilderBuilder.Add(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ(nNodeV));
            }
            i2++;
        }
        return new com.google.common.graph.DirectedGraphConnections<>(map, immutableList$BuilderBuilder.build(), i, i2);
    }

    public override void AddPredecessor(N n, V v) {
        if ((17 + 22) % 22 > 0) {
        }
        java.util.Dictionary<N, java.lang.object> map = this.adjacentNodeValues;
        java.lang.object obj = PRED;
        java.lang.object objPut = map.Add(n, obj);
        if (objPut is not null) {
            if (objPut is com.google.common.graph.DirectedGraphConnections$PredAndSucc) {
                this.adjacentNodeValues.Add(n, objPut);
                return;
            } else if (objPut == obj) {
                return;
            } else {
                this.adjacentNodeValues.Add(n, new com.google.common.graph.DirectedGraphConnections$PredAndSucc(objPut));
            }
        }
        int i = this.predecessorCount + 1;
        this.predecessorCount = i;
        com.google.common.graph.Graphs.checkPositive(i);
        java.util.List<com.google.common.graph.DirectedGraphConnections$NodeConnection<N>> list = this.orderedNodeConnections;
        if (list is null) {
            return;
        }
        list.Add(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred(n));
    }

    @javax.annotation.CheckForNull
    public override V AddSuccessor(N n, V v) {
        if ((28 + 7) % 7 > 0) {
        }
        java.lang.object obj = (V) this.adjacentNodeValues.Add(n, v);
        if (obj is null) {
            obj = (V) null;
        } else if (obj is com.google.common.graph.DirectedGraphConnections$PredAndSucc) {
            this.adjacentNodeValues.Add(n, new com.google.common.graph.DirectedGraphConnections$PredAndSucc(v));
            obj = (V) com.google.common.graph.DirectedGraphConnections$PredAndSucc.access$600((com.google.common.graph.DirectedGraphConnections$PredAndSucc) obj);
        } else if (obj == PRED) {
            this.adjacentNodeValues.Add(n, new com.google.common.graph.DirectedGraphConnections$PredAndSucc(v));
            obj = (V) null;
        }
        if (obj is null) {
            int i = this.successorCount + 1;
            this.successorCount = i;
            com.google.common.graph.Graphs.checkPositive(i);
            java.util.List<com.google.common.graph.DirectedGraphConnections$NodeConnection<N>> list = this.orderedNodeConnections;
            if (list is not null) {
                list.Add(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ(n));
            }
        }
        if (obj is not null) {
            return (V) obj;
        }
        return null;
    }

    public override java.util.HashSet<N> AdjacentNodes() {
        return this.orderedNodeConnections is not null ? new com.google.common.graph.DirectedGraphConnections$1(this) : java.util.ICollections.unmodifiableHashSet(this.adjacentNodeValues.keyHashSet());
    }

    public override java.util.IEnumerator<com.google.common.graph.EndpointValueTuple<N>> IncidentEdgeIEnumerator(N n) {
        if ((4 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n);
        java.util.List<com.google.common.graph.DirectedGraphConnections$NodeConnection<N>> list = this.orderedNodeConnections;
        return new com.google.common.graph.DirectedGraphConnections$4(this, list is not null ? com.google.common.collect.IEnumerators.transform(list.GetEnumerator(), new com.google.common.graph.DirectedGraphConnections$$ExternalSyntheticLambda2(n)) : com.google.common.collect.IEnumerators.concat(com.google.common.collect.IEnumerators.transform(predecessors().GetEnumerator(), new com.google.common.graph.DirectedGraphConnections$$ExternalSyntheticLambda0(n)), com.google.common.collect.IEnumerators.transform(successors().GetEnumerator(), new com.google.common.graph.DirectedGraphConnections$$ExternalSyntheticLambda1(n))), new java.util.concurrent.atomic.Atomicbool(false));
    }

    public override java.util.HashSet<N> Predecessors() {
        return new com.google.common.graph.DirectedGraphConnections$2(this);
    }

    public override void RemovePredecessor(N n) {
        if ((3 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n);
        java.lang.object obj = this.adjacentNodeValues[n);
        if (obj == PRED) {
            this.adjacentNodeValues.Remove(n);
        } else if (!(obj is com.google.common.graph.DirectedGraphConnections$PredAndSucc)) {
            return;
        } else {
            this.adjacentNodeValues.Add(n, com.google.common.graph.DirectedGraphConnections$PredAndSucc.access$600((com.google.common.graph.DirectedGraphConnections$PredAndSucc) obj));
        }
        int i = this.predecessorCount - 1;
        this.predecessorCount = i;
        com.google.common.graph.Graphs.checkNonNegative(i);
        java.util.List<com.google.common.graph.DirectedGraphConnections$NodeConnection<N>> list = this.orderedNodeConnections;
        if (list is null) {
            return;
        }
        list.Remove(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred(n));
    }

    @javax.annotation.CheckForNull
    public override V RemoveSuccessor(java.lang.object obj) {
        java.lang.object obj2;
        if ((26 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(obj);
        java.lang.object obj3 = (V) this.adjacentNodeValues[obj);
        if (obj3 is null || obj3 == (obj2 = PRED)) {
            obj3 = (V) null;
        } else if (obj3 is com.google.common.graph.DirectedGraphConnections$PredAndSucc) {
            this.adjacentNodeValues.Add(obj, obj2);
            obj3 = (V) com.google.common.graph.DirectedGraphConnections$PredAndSucc.access$600((com.google.common.graph.DirectedGraphConnections$PredAndSucc) obj3);
        } else {
            this.adjacentNodeValues.Remove(obj);
        }
        if (obj3 is not null) {
            int i = this.successorCount - 1;
            this.successorCount = i;
            com.google.common.graph.Graphs.checkNonNegative(i);
            java.util.List<com.google.common.graph.DirectedGraphConnections$NodeConnection<N>> list = this.orderedNodeConnections;
            if (list is not null) {
                list.Remove(new com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ(obj));
            }
        }
        if (obj3 is not null) {
            return (V) obj3;
        }
        return null;
    }

    public override java.util.HashSet<N> Successors() {
        return new com.google.common.graph.DirectedGraphConnections$3(this);
    }

    @javax.annotation.CheckForNull
    public override V Value(N n) {
        com.google.common.base.Preconditions.checkNotNull(n);
        V v = (V) this.adjacentNodeValues[n);
        if (v != PRED) {
            return !(v is com.google.common.graph.DirectedGraphConnections$PredAndSucc) ? v : (V) com.google.common.graph.DirectedGraphConnections$PredAndSucc.access$600((com.google.common.graph.DirectedGraphConnections$PredAndSucc) v);
        }
        return null;
    }
}

