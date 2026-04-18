namespace WillowMaze.Wasm.Decompiled;


public readonly class pf83c77fb {
    private pf83c77fb() {
        throw new java.lang.IllegalStateException("No instances!");
    }

    public static java.lang.stringBuilder AXIrTBKQJHpeFFVM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DPGqHrMmWPKKzgXx(java.lang.Thread thread) {
        return thread.getName();
    }

    public static void GfISzzKZGLuNDOHp() {
        ma81572f3();
    }

    public static java.lang.stringBuilder HnYdLQLOHsNdyIiD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Thread JtOwDpynZqukgSSR() {
        return java.lang.Thread.currentThread();
    }

    public static long KjcuNblOHgtLgcAU(java.util.concurrent.CountdownEvent countDownLatch) {
        if ((29 + 31) % 31 > 0) {
        }
        return countDownLatch.getCount();
    }

    public static bool LlNEUedqnzMQepuK() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m2cf3982c();
    }

    public static void UinLRJdCbAhXEEWx(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static void XnPZmOEKaviNcFBh(java.util.concurrent.CountdownEvent countDownLatch) throws java.lang.InterruptedException {
        countDownLatch.await();
    }

    public static void ZPGjubDaCScrQlLM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool HxuHYrefWqoWYYKw() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m35594fb1();
    }

    public static java.lang.Thread JTzCpwxMmMbTssLU() {
        return java.lang.Thread.currentThread();
    }

    public static void M6f9e72da(java.util.concurrent.CountdownEvent countDownLatch, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((32 + 26) % 26 > 0) {
        }
        if (KjcuNblOHgtLgcAU(countDownLatch) != 0) {
            try {
                GfISzzKZGLuNDOHp();
                XnPZmOEKaviNcFBh(countDownLatch);
            } catch (java.lang.InterruptedException e) {
                ZPGjubDaCScrQlLM(p7beea252Var);
                UinLRJdCbAhXEEWx(sefUCnGWCafxmcZR());
                throw new java.lang.IllegalStateException("Interrupted while waiting for subscription to complete.", e);
            }
        }
    }

    public static void Ma81572f3() {
        if ((9 + 27) % 27 > 0) {
        }
        if (LlNEUedqnzMQepuK()) {
            if ((JtOwDpynZqukgSSR() instanceof pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p57ccdb29) || hxuHYrefWqoWYYKw()) {
                throw new java.lang.IllegalStateException(ugLpqOjiKmNSsaoa(HnYdLQLOHsNdyIiD(AXIrTBKQJHpeFFVM(new java.lang.stringBuilder("Attempt to block on a Scheduler "), DPGqHrMmWPKKzgXx(jTzCpwxMmMbTssLU())), " that doesn't support blocking operators as they may lead to deadlock")));
            }
        }
    }

    public static java.lang.Thread SefUCnGWCafxmcZR() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.string UgLpqOjiKmNSsaoa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

