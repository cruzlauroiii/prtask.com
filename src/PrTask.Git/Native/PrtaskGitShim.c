#include "git-compat-util.h"
#include "builtin.h"
#include "repository.h"
#include "setup.h"
#include "strbuf.h"

/* Stub fork/exec/pipe — not available in WASM */
int fork(void) { return -1; }
int execve(const char *F, char *const A[], char *const E[]) { return -1; }
int pipe(int Fd[2]) { return -1; }

static void InitGitEnv(const char *Path) {
    setenv("GIT_DIR", Path, 1);
    setenv("GIT_WORK_TREE", Path, 1);
}

int PrtaskGitClone(const char *Url, const char *Path, int Depth) {
    char DepthStr[16];
    snprintf(DepthStr, sizeof(DepthStr), "%d", Depth);

    if (Depth > 0) {
        const char *Argv[] = { "clone", "--depth", DepthStr, Url, Path, NULL };
        return cmd_clone(5, Argv, NULL, the_repository);
    } else {
        const char *Argv[] = { "clone", Url, Path, NULL };
        return cmd_clone(3, Argv, NULL, the_repository);
    }
}

int PrtaskGitFetch(const char *Path, const char *Remote) {
    InitGitEnv(Path);
    const char *Argv[] = { "fetch", Remote, NULL };
    return cmd_fetch(2, Argv, Path, the_repository);
}

int PrtaskGitResetHard(const char *Path, const char *Ref) {
    InitGitEnv(Path);
    const char *Argv[] = { "reset", "--hard", Ref, NULL };
    return cmd_reset(3, Argv, Path, the_repository);
}

int PrtaskGitDiff(const char *Path, char *OutBuf, int BufSize) {
    InitGitEnv(Path);
    int SavedFd = dup(1);
    int Fds[2];
    if (pipe(Fds) == -1) {
        /* pipe stub returns -1 in WASM — fall back to direct call */
        const char *Argv[] = { "diff", NULL };
        int Ret = cmd_diff(1, Argv, Path, the_repository);
        if (OutBuf && BufSize > 0) OutBuf[0] = '\0';
        return Ret;
    }
    dup2(Fds[1], 1);
    close(Fds[1]);
    const char *Argv[] = { "diff", NULL };
    int Ret = cmd_diff(1, Argv, Path, the_repository);
    fflush(stdout);
    dup2(SavedFd, 1);
    close(SavedFd);
    if (OutBuf && BufSize > 0) {
        ssize_t N = read(Fds[0], OutBuf, BufSize - 1);
        OutBuf[N > 0 ? N : 0] = '\0';
    }
    close(Fds[0]);
    return Ret;
}

int PrtaskGitCommit(const char *Path, const char *Message) {
    InitGitEnv(Path);
    const char *Argv[] = { "commit", "-m", Message, NULL };
    return cmd_commit(3, Argv, Path, the_repository);
}

int PrtaskGitPush(const char *Path, const char *Remote, const char *Branch) {
    InitGitEnv(Path);
    const char *Argv[] = { "push", Remote, Branch, NULL };
    return cmd_push(3, Argv, Path, the_repository);
}

const char *PrtaskGitHeadSha(const char *Path) {
    static char ShaBuf[64];
    char HeadPath[1024];
    char RefPath[1024];
    char LineBuf[256];
    FILE *Fp;

    InitGitEnv(Path);

    snprintf(HeadPath, sizeof(HeadPath), "%s/.git/HEAD", Path);
    Fp = fopen(HeadPath, "r");
    if (!Fp) return NULL;

    if (!fgets(LineBuf, sizeof(LineBuf), Fp)) {
        fclose(Fp);
        return NULL;
    }
    fclose(Fp);

    /* Strip trailing newline */
    LineBuf[strcspn(LineBuf, "\r\n")] = '\0';

    /* If HEAD is a symbolic ref (e.g. "ref: refs/heads/main") */
    if (strncmp(LineBuf, "ref: ", 5) == 0) {
        snprintf(RefPath, sizeof(RefPath), "%s/.git/%s", Path, LineBuf + 5);
        Fp = fopen(RefPath, "r");
        if (!Fp) return NULL;
        if (!fgets(ShaBuf, sizeof(ShaBuf), Fp)) {
            fclose(Fp);
            return NULL;
        }
        fclose(Fp);
        ShaBuf[strcspn(ShaBuf, "\r\n")] = '\0';
    } else {
        /* Detached HEAD — LineBuf is the SHA directly */
        snprintf(ShaBuf, sizeof(ShaBuf), "%s", LineBuf);
    }

    return ShaBuf;
}

int PrtaskGitCheckout(const char *Path, const char *Branch) {
    InitGitEnv(Path);
    const char *Argv[] = { "checkout", Branch, NULL };
    return cmd_checkout(2, Argv, Path, the_repository);
}

int PrtaskGitStatus(const char *Path, char *OutBuf, int BufSize) {
    InitGitEnv(Path);
    int SavedFd = dup(1);
    int Fds[2];
    if (pipe(Fds) == -1) {
        /* pipe stub returns -1 in WASM — fall back to direct call */
        const char *Argv[] = { "status", "--porcelain", NULL };
        int Ret = cmd_status(2, Argv, Path, the_repository);
        if (OutBuf && BufSize > 0) OutBuf[0] = '\0';
        return Ret;
    }
    dup2(Fds[1], 1);
    close(Fds[1]);
    const char *Argv[] = { "status", "--porcelain", NULL };
    int Ret = cmd_status(2, Argv, Path, the_repository);
    fflush(stdout);
    dup2(SavedFd, 1);
    close(SavedFd);
    if (OutBuf && BufSize > 0) {
        ssize_t N = read(Fds[0], OutBuf, BufSize - 1);
        OutBuf[N > 0 ? N : 0] = '\0';
    }
    close(Fds[0]);
    return Ret;
}
