import type { Env } from "./types";

const BaseUrl = (Env: Env) => `https://api.github.com/repos/${Env.GITHUB_REPO_OWNER}/${Env.GITHUB_REPO_NAME}/contents`;

const Headers = (Env: Env) => ({
  Authorization: `Bearer ${Env.GITHUB_PAT}`,
  Accept: "application/vnd.github.v3+json",
  "User-Agent": "PrTask",
  "Content-Type": "application/json",
});

export async function GitHubRead(
  Env: Env, Path: string,
): Promise<{ Content: string; Sha: string } | null> {
  const Res = await fetch(`${BaseUrl(Env)}/${Path}`, { headers: Headers(Env) });
  if (!Res.ok) return null;
  const Json = (await Res.json()) as { content: string; sha: string };
  const Decoded = decodeURIComponent(escape(atob(Json.content.replace(/\n/g, ""))));
  return { Content: Decoded, Sha: Json.sha };
}

export async function GitHubWrite(
  Env: Env, Path: string, Content: string, Message: string, Sha?: string,
): Promise<boolean> {
  const Body: Record<string, string> = {
    message: Message,
    content: btoa(unescape(encodeURIComponent(Content))),
  };
  if (Sha) Body.sha = Sha;
  const Res = await fetch(`${BaseUrl(Env)}/${Path}`, {
    method: "PUT",
    headers: Headers(Env),
    body: JSON.stringify(Body),
  });
  return Res.ok;
}

export async function GitHubDelete(
  Env: Env, Path: string, Sha: string, Message: string,
): Promise<boolean> {
  const Res = await fetch(`${BaseUrl(Env)}/${Path}`, {
    method: "DELETE",
    headers: Headers(Env),
    body: JSON.stringify({ message: Message, sha: Sha }),
  });
  return Res.ok;
}

export async function GitHubList(
  Env: Env, Dir: string,
): Promise<unknown[]> {
  const Res = await fetch(`${BaseUrl(Env)}/${Dir}`, { headers: Headers(Env) });
  if (!Res.ok) return [];
  const Files = (await Res.json()) as { name: string; path: string }[];
  const Results: unknown[] = [];
  for (const File of Files) {
    if (!File.name.endsWith(".json")) continue;
    const Item = await GitHubRead(Env, File.path);
    if (Item) Results.push(JSON.parse(Item.Content));
  }
  return Results;
}

export const Collections = [
  "data/achievement",
  "data/audit",
  "data/auth",
  "data/bills-payment",
  "data/board",
  "data/cloudflare-d1",
  "data/customer",
  "data/diff",
  "data/disbursement",
  "data/inference",
  "data/invoice",
  "data/kyc",
  "data/leaderboard",
  "data/maya-connect",
  "data/p3-payment",
  "data/payment",
  "data/payment-record",
  "data/plain-text-db",
  "data/pull-request",
  "data/qr-payment",
  "data/refund",
  "data/remittance",
  "data/repository",
  "data/review-comment",
  "data/source-code",
  "data/sprint",
  "data/subscription",
  "data/sync",
  "data/task",
  "data/transcription",
  "data/user",
  "data/vector-search",
  "data/void",
  "data/wallet-payment",
  "data/webhook",
] as const;
