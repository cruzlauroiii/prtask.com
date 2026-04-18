CREATE TABLE IF NOT EXISTS users (
  id TEXT PRIMARY KEY,
  github_id INTEGER,
  github_username TEXT DEFAULT '',
  display_name TEXT,
  avatar_url TEXT,
  email TEXT,
  role TEXT DEFAULT 'Developer',
  maya_customer_id TEXT,
  total_earned_cents INTEGER DEFAULT 0,
  total_spent_cents INTEGER DEFAULT 0,
  xp INTEGER DEFAULT 0,
  level INTEGER DEFAULT 1,
  streak_days INTEGER DEFAULT 0,
  created_at TEXT DEFAULT (datetime('now')),
  updated_at TEXT DEFAULT (datetime('now'))
);

CREATE TABLE IF NOT EXISTS tasks (
  id TEXT PRIMARY KEY,
  client_id TEXT NOT NULL,
  title TEXT NOT NULL,
  description TEXT DEFAULT '',
  repo_url TEXT DEFAULT '',
  status TEXT DEFAULT 'Open',
  complexity TEXT DEFAULT 'Medium',
  bounty_amount_cents INTEGER DEFAULT 0,
  claimed_by_developer_id TEXT,
  deadline TEXT,
  tags TEXT DEFAULT '[]',
  created_at TEXT DEFAULT (datetime('now')),
  updated_at TEXT DEFAULT (datetime('now')),
  FOREIGN KEY (client_id) REFERENCES users(id)
);

CREATE TABLE IF NOT EXISTS pull_requests (
  id TEXT PRIMARY KEY,
  task_id TEXT NOT NULL,
  developer_id TEXT NOT NULL,
  github_pr_url TEXT DEFAULT '',
  status TEXT DEFAULT 'Submitted',
  complexity_score INTEGER DEFAULT 0,
  review_notes TEXT,
  diff_storage_key TEXT,
  created_at TEXT DEFAULT (datetime('now')),
  updated_at TEXT DEFAULT (datetime('now')),
  FOREIGN KEY (task_id) REFERENCES tasks(id),
  FOREIGN KEY (developer_id) REFERENCES users(id)
);

CREATE TABLE IF NOT EXISTS payments (
  id TEXT PRIMARY KEY,
  task_id TEXT NOT NULL,
  payer_id TEXT NOT NULL,
  payee_id TEXT,
  amount_cents INTEGER NOT NULL,
  payment_type TEXT NOT NULL,
  status TEXT DEFAULT 'Pending',
  maya_checkout_id TEXT,
  maya_payment_id TEXT,
  created_at TEXT DEFAULT (datetime('now')),
  updated_at TEXT DEFAULT (datetime('now')),
  FOREIGN KEY (task_id) REFERENCES tasks(id),
  FOREIGN KEY (payer_id) REFERENCES users(id),
  FOREIGN KEY (payee_id) REFERENCES users(id)
);

CREATE TABLE IF NOT EXISTS achievements (
  id TEXT PRIMARY KEY,
  user_id TEXT NOT NULL,
  badge_type TEXT NOT NULL,
  earned_at TEXT DEFAULT (datetime('now')),
  FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE IF NOT EXISTS leaderboard (
  user_id TEXT PRIMARY KEY,
  username TEXT DEFAULT '',
  avatar_url TEXT,
  total_xp INTEGER DEFAULT 0,
  total_earned_cents INTEGER DEFAULT 0,
  tasks_completed INTEGER DEFAULT 0,
  rank INTEGER DEFAULT 0,
  FOREIGN KEY (user_id) REFERENCES users(id)
);
