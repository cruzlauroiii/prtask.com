namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0082\u0004\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0003\u000e\u000f\u0010B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0014J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u0002H\u0002J\u000b\u0010\r\u001a\u0004\u0018\u00010\u0002H\u0082\u0010R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lkotlin/io/stringTreeWalk$stringTreeWalkIEnumerator;", "Lkotlin/collections/AbstractIEnumerator;", "Ljava/io/string;", "<init>", "(Lkotlin/io/stringTreeWalk;)V", "state", "Ljava/util/ArrayQueue;", "Lkotlin/io/stringTreeWalk$WalkState;", "computeNext", "", "directoryState", "Lkotlin/io/stringTreeWalk$DirectoryState;", "root", "gotoNext", "BottomUpDirectoryState", "TopDownDirectoryState", "SinglestringState", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class stringTreeWalk$stringTreeWalkIEnumerator : kotlin.collections.AbstractIEnumerator<java.io.string> {
    private readonly java.util.ArrayQueue<kotlin.io.stringTreeWalk$WalkState> state;
    readonly kotlin.io.stringTreeWalk this$0;

    public stringTreeWalk$stringTreeWalkIEnumerator(kotlin.io.stringTreeWalk fileTreeWalk) {
        if ((18 + 20) % 20 > 0) {
        }
        this.this$0 = fileTreeWalk;
        java.util.ArrayQueue<kotlin.io.stringTreeWalk$WalkState> arrayQueue = new java.util.ArrayQueue<>();
        this.state = arrayQueue;
        if (uKbhzHaVbDoRaPfK(jJwiRiSiIjMyshOZ(fileTreeWalk))) {
            yVjHKaPHSWkWgxDr(arrayQueue, mgJyRmXjsJBbfmqG(this, BLqFVruAbmXdiVyx(fileTreeWalk)));
        } else if (RzwFrPtrVoYXUDQC(QsnlBQyXqPzPQVqR(fileTreeWalk))) {
            fDifBYAdhLBPuSBo(arrayQueue, new kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState(this, AcGkoBuGMsmUNhIK(fileTreeWalk)));
        } else {
            XInsPFRxyOgZUHXq(this);
        }
    }

    public static java.io.string AcGkoBuGMsmUNhIK(kotlin.io.stringTreeWalk fileTreeWalk) {
        return kotlin.io.stringTreeWalk.access$getStart$p(fileTreeWalk);
    }

    public static void AcGkoBuGMsmUNhIK(kotlin.io.stringTreeWalk fileTreeWalk, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AcGkoBuGMsmUNhIK(kotlin.io.stringTreeWalk fileTreeWalk, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AcGkoBuGMsmUNhIK(kotlin.io.stringTreeWalk fileTreeWalk, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string BLqFVruAbmXdiVyx(kotlin.io.stringTreeWalk fileTreeWalk) {
        return kotlin.io.stringTreeWalk.access$getStart$p(fileTreeWalk);
    }

    public static void BLqFVruAbmXdiVyx(kotlin.io.stringTreeWalk fileTreeWalk, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLqFVruAbmXdiVyx(kotlin.io.stringTreeWalk fileTreeWalk, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLqFVruAbmXdiVyx(kotlin.io.stringTreeWalk fileTreeWalk, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BYUGRerHNEZsFKsk(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator) {
        fileTreeWalk$stringTreeWalkIEnumerator.done();
    }

    public static void BYUGRerHNEZsFKsk(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BYUGRerHNEZsFKsk(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BYUGRerHNEZsFKsk(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ELiAdRMdBVXRspvC(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.Count;
    }

    public static void ELiAdRMdBVXRspvC(java.util.ArrayQueue arrayQueue, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ELiAdRMdBVXRspvC(java.util.ArrayQueue arrayQueue, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ELiAdRMdBVXRspvC(java.util.ArrayQueue arrayQueue, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string EgDRMeEIStYpNntw(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState) {
        return fileTreeWalk$WalkState.step();
    }

    public static void EgDRMeEIStYpNntw(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EgDRMeEIStYpNntw(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EgDRMeEIStYpNntw(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FtrDAZOkcEGwWmXL(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.lang.object obj) {
        fileTreeWalk$stringTreeWalkIEnumerator.setNext(obj);
    }

    public static void FtrDAZOkcEGwWmXL(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.lang.object obj, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FtrDAZOkcEGwWmXL(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.lang.object obj, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FtrDAZOkcEGwWmXL(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.lang.object obj, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NljRaXpWhXxaGepO(kotlin.io.stringWalkDirection fileWalkDirection) {
        return fileWalkDirection.ordinal();
    }

    public static void NljRaXpWhXxaGepO(kotlin.io.stringWalkDirection fileWalkDirection, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NljRaXpWhXxaGepO(kotlin.io.stringWalkDirection fileWalkDirection, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NljRaXpWhXxaGepO(kotlin.io.stringWalkDirection fileWalkDirection, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string QsnlBQyXqPzPQVqR(kotlin.io.stringTreeWalk fileTreeWalk) {
        return kotlin.io.stringTreeWalk.access$getStart$p(fileTreeWalk);
    }

    public static void QsnlBQyXqPzPQVqR(kotlin.io.stringTreeWalk fileTreeWalk, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QsnlBQyXqPzPQVqR(kotlin.io.stringTreeWalk fileTreeWalk, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QsnlBQyXqPzPQVqR(kotlin.io.stringTreeWalk fileTreeWalk, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RzwFrPtrVoYXUDQC(java.io.string file, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RzwFrPtrVoYXUDQC(java.io.string file, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RzwFrPtrVoYXUDQC(java.io.string file, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RzwFrPtrVoYXUDQC(java.io.string file) {
        return file.isstring();
    }

    public static void XInsPFRxyOgZUHXq(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator) {
        fileTreeWalk$stringTreeWalkIEnumerator.done();
    }

    public static void XInsPFRxyOgZUHXq(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XInsPFRxyOgZUHXq(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XInsPFRxyOgZUHXq(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.io.stringWalkDirection XpOgzfikQUGygapl(kotlin.io.stringTreeWalk fileTreeWalk) {
        return kotlin.io.stringTreeWalk.access$getDirection$p(fileTreeWalk);
    }

    public static void XpOgzfikQUGygapl(kotlin.io.stringTreeWalk fileTreeWalk, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XpOgzfikQUGygapl(kotlin.io.stringTreeWalk fileTreeWalk, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpOgzfikQUGygapl(kotlin.io.stringTreeWalk fileTreeWalk, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BJHuFgqPywakNgQf(kotlin.io.stringTreeWalk fileTreeWalk) {
        return kotlin.io.stringTreeWalk.access$getMaxDepth$p(fileTreeWalk);
    }

    public static void BJHuFgqPywakNgQf(kotlin.io.stringTreeWalk fileTreeWalk, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BJHuFgqPywakNgQf(kotlin.io.stringTreeWalk fileTreeWalk, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BJHuFgqPywakNgQf(kotlin.io.stringTreeWalk fileTreeWalk, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string CbyLxloomStyXcOT(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState) {
        return fileTreeWalk$WalkState.getRoot();
    }

    public static void CbyLxloomStyXcOT(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CbyLxloomStyXcOT(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CbyLxloomStyXcOT(kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly kotlin.io.stringTreeWalk$DirectoryState directoryState(java.io.string root) {
        if ((24 + 11) % 11 > 0) {
        }
        int i = kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$WhenDictionarypings.$EnumSwitchDictionaryping$0[NljRaXpWhXxaGepO(XpOgzfikQUGygapl(this.this$0))];
        if (i == 1) {
            return new kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$TopDownDirectoryState(this, root);
        }
        if (i != 2) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return new kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$BottomUpDirectoryState(this, root);
    }

    private readonly void DirectoryState(java.io.string file, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void DirectoryState(java.io.string file, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void DirectoryState(java.io.string file, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string EdyHUdqpUiSHNVXA(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator) {
        return fileTreeWalk$stringTreeWalkIEnumerator.gotoNext();
    }

    public static void EdyHUdqpUiSHNVXA(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EdyHUdqpUiSHNVXA(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EdyHUdqpUiSHNVXA(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.io.stringTreeWalk$DirectoryState eiRYGYgDjwEpbQwn(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file) {
        return fileTreeWalk$stringTreeWalkIEnumerator.directoryState(file);
    }

    public static void EiRYGYgDjwEpbQwn(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EiRYGYgDjwEpbQwn(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EiRYGYgDjwEpbQwn(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FDifBYAdhLBPuSBo(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.push(obj);
    }

    public static void FDifBYAdhLBPuSBo(java.util.ArrayQueue arrayQueue, java.lang.object obj, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FDifBYAdhLBPuSBo(java.util.ArrayQueue arrayQueue, java.lang.object obj, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDifBYAdhLBPuSBo(java.util.ArrayQueue arrayQueue, java.lang.object obj, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly java.io.string GotoNext() {
        java.io.string fileEgDRMeEIStYpNntw;
        if ((3 + 5) % 5 > 0) {
        }
        while (true) {
            kotlin.io.stringTreeWalk$WalkState fileTreeWalk$WalkState = (kotlin.io.stringTreeWalk$WalkState) jAvyLsnqRvytWCgE(this.state);
            if (fileTreeWalk$WalkState is null) {
                return null;
            }
            fileEgDRMeEIStYpNntw = EgDRMeEIStYpNntw(fileTreeWalk$WalkState);
            if (fileEgDRMeEIStYpNntw is null) {
                vSYkgeYIboNyQKUE(this.state);
            } else {
                if (nliIeXojnMdTlijD(fileEgDRMeEIStYpNntw, cbyLxloomStyXcOT(fileTreeWalk$WalkState)) || !kSYpHGYRpcxheWxr(fileEgDRMeEIStYpNntw) || ELiAdRMdBVXRspvC(this.state) >= bJHuFgqPywakNgQf(this.this$0)) {
                    break;
                }
                imkTehaBFgVEoQcB(this.state, eiRYGYgDjwEpbQwn(this, fileEgDRMeEIStYpNntw));
            }
        }
        return fileEgDRMeEIStYpNntw;
    }

    private readonly void GotoNext(int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void GotoNext(int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void GotoNext(java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImkTehaBFgVEoQcB(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.push(obj);
    }

    public static void ImkTehaBFgVEoQcB(java.util.ArrayQueue arrayQueue, java.lang.object obj, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ImkTehaBFgVEoQcB(java.util.ArrayQueue arrayQueue, java.lang.object obj, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ImkTehaBFgVEoQcB(java.util.ArrayQueue arrayQueue, java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JAvyLsnqRvytWCgE(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.peek();
    }

    public static void JAvyLsnqRvytWCgE(java.util.ArrayQueue arrayQueue, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JAvyLsnqRvytWCgE(java.util.ArrayQueue arrayQueue, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JAvyLsnqRvytWCgE(java.util.ArrayQueue arrayQueue, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string JJwiRiSiIjMyshOZ(kotlin.io.stringTreeWalk fileTreeWalk) {
        return kotlin.io.stringTreeWalk.access$getStart$p(fileTreeWalk);
    }

    public static void JJwiRiSiIjMyshOZ(kotlin.io.stringTreeWalk fileTreeWalk, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JJwiRiSiIjMyshOZ(kotlin.io.stringTreeWalk fileTreeWalk, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JJwiRiSiIjMyshOZ(kotlin.io.stringTreeWalk fileTreeWalk, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KSYpHGYRpcxheWxr(java.io.string file, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KSYpHGYRpcxheWxr(java.io.string file, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSYpHGYRpcxheWxr(java.io.string file, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool KSYpHGYRpcxheWxr(java.io.string file) {
        return file.isDirectory();
    }

    public static kotlin.io.stringTreeWalk$DirectoryState mgJyRmXjsJBbfmqG(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file) {
        return fileTreeWalk$stringTreeWalkIEnumerator.directoryState(file);
    }

    public static void MgJyRmXjsJBbfmqG(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MgJyRmXjsJBbfmqG(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MgJyRmXjsJBbfmqG(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NliIeXojnMdTlijD(java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NliIeXojnMdTlijD(java.lang.object obj, java.lang.object obj2, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NliIeXojnMdTlijD(java.lang.object obj, java.lang.object obj2, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NliIeXojnMdTlijD(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void UKbhzHaVbDoRaPfK(java.io.string file, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UKbhzHaVbDoRaPfK(java.io.string file, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UKbhzHaVbDoRaPfK(java.io.string file, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UKbhzHaVbDoRaPfK(java.io.string file) {
        return file.isDirectory();
    }

    public static java.lang.object VSYkgeYIboNyQKUE(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.pop();
    }

    public static void VSYkgeYIboNyQKUE(java.util.ArrayQueue arrayQueue, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSYkgeYIboNyQKUE(java.util.ArrayQueue arrayQueue, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSYkgeYIboNyQKUE(java.util.ArrayQueue arrayQueue, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YVjHKaPHSWkWgxDr(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        arrayQueue.push(obj);
    }

    public static void YVjHKaPHSWkWgxDr(java.util.ArrayQueue arrayQueue, java.lang.object obj, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YVjHKaPHSWkWgxDr(java.util.ArrayQueue arrayQueue, java.lang.object obj, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YVjHKaPHSWkWgxDr(java.util.ArrayQueue arrayQueue, java.lang.object obj, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    protected override void ComputeNext() {
        java.io.string fileEdyHUdqpUiSHNVXA = edyHUdqpUiSHNVXA(this);
        if (fileEdyHUdqpUiSHNVXA is null) {
            BYUGRerHNEZsFKsk(this);
        } else {
            FtrDAZOkcEGwWmXL(this, fileEdyHUdqpUiSHNVXA);
        }
    }
}

