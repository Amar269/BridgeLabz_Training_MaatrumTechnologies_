# 🌿 Git & GitHub Fundamentals

<div align="center">

![Git](https://img.shields.io/badge/Git-Version%20Control-F05032?style=for-the-badge&logo=git&logoColor=white)

![GitHub](https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white)

![Learning](https://img.shields.io/badge/Status-Learning-success?style=for-the-badge)

</div>

---

## 📖 Overview

This repository documents my hands-on learning and practice of **Git** and **GitHub**.

Git is a distributed version control system used to track source code changes, maintain project history, and collaborate with development teams.

GitHub is a cloud-based platform that hosts Git repositories and enables collaborative software development.

---

# 🎯 Learning Objectives

Through this practice, I learned:

✅ Version Control Fundamentals

✅ Repository Management

✅ Branching & Merging

✅ Remote Repository Operations

✅ Commit History Management

✅ Stashing Changes

✅ Reset & Recovery Operations

✅ Collaboration Workflows

✅ Debugging with Git Tools

---

# 🏗 Git Workflow

```text
Working Directory
       │
       ▼
 git add
       │
       ▼
 Staging Area
       │
       ▼
 git commit
       │
       ▼
 Local Repository
       │
       ▼
 git push
       │
       ▼
 GitHub Repository
```

---

# 📂 Repository Setup

## Initialize Repository

```bash
git init
```

Creates a local Git repository and starts tracking changes.

---

## Configure Git

```bash
git config --global user.name "Your Name"

git config --global user.email "yourmail@example.com"
```

Verify configuration:

```bash
git config --list
```

---

## Clone Repository

```bash
git clone <repository-url>
```

Downloads an existing GitHub repository to the local machine.

---

# 📌 Staging & Committing

## Add Files

```bash
git add file.txt
```

Add specific file.

```bash
git add .
```

Add all modified files.

---

## Commit Changes

```bash
git commit -m "Added login feature"
```

Creates a snapshot of the staged changes.

---

## Check Repository Status

```bash
git status
```

Shows:

- Modified Files
- Staged Files
- Untracked Files

---

# 📜 Viewing History

## Commit History

```bash
git log
```

---

## Compact History

```bash
git log --oneline
```

---

## Visual Branch History

```bash
git log --graph --oneline --all
```

---

## View Specific Commit

```bash
git show <commit-id>
```

---

# 🔍 Compare Changes

## View Differences

```bash
git diff
```

Compare working directory and staging area.

```bash
git diff --name-only
```

Show only changed file names.

---

# 🌱 Branch Management

## Create Branch

```bash
git branch feature-1
```

---

## Switch Branch

```bash
git checkout feature-1
```

or

```bash
git switch feature-1
```

---

## Create & Switch

```bash
git checkout -b feature-1
```

---

## Rename Branch

```bash
git branch -m old-name new-name
```

---

## Delete Local Branch

```bash
git branch -d feature-1
```

---

## Delete Remote Branch

```bash
git push origin --delete feature-1
```

---

# 🔀 Merge Operations

## Merge Branch

```bash
git merge feature-1
```

Combines changes from another branch into the current branch.

---

# 🌍 Remote Repository Operations

## Add Remote Repository

```bash
git remote add origin <repository-url>
```

---

## View Remotes

```bash
git remote -v
```

---

## Push Changes

```bash
git push origin main
```

Set upstream branch:

```bash
git push -u origin main
```

---

## Fetch Updates

```bash
git fetch origin
```

Downloads remote changes without merging.

---

## Pull Updates

```bash
git pull origin main
```

Fetch + Merge.

---

## Rebase Pull

```bash
git pull --rebase origin main
```

Maintains a cleaner commit history.

---

# 🏷 Git Tags

Create release tags.

```bash
git tag v1.0
```

Examples:

```text
v1.0
v1.1
v2.0
```

---

# 📦 Git Stash

Temporarily save uncommitted changes.

## Create Stash

```bash
git stash
```

Named stash:

```bash
git stash push -m "Login Feature"
```

---

## View Stashes

```bash
git stash list
```

---

## Apply Stash

```bash
git stash apply stash@{0}
```

---

## Apply & Remove Stash

```bash
git stash pop
```

---

# 🗑 Remove Files

## Remove Tracked File

```bash
git rm file.txt
```

---

## Clean Untracked Files

```bash
git clean -f
```

Directories:

```bash
git clean -fd
```

Preview:

```bash
git clean -n
```

---

# ⏪ Undo Changes

## Unstage File

```bash
git reset file.txt
```

---

## Soft Reset

```bash
git reset --soft HEAD~1
```

Undo commit but keep changes staged.

---

## Mixed Reset

```bash
git reset --mixed HEAD~1
```

Undo commit and unstage changes.

---

## Hard Reset

```bash
git reset --hard HEAD~1
```

Delete commit and changes permanently.

---

# ✏ Amend Commit

Update latest commit.

```bash
git commit --amend
```

Change message:

```bash
git commit --amend -m "Updated login feature"
```

---

# 🔄 Revert Commit

```bash
git revert <commit-id>
```

Creates a new commit that reverses previous changes.

---

# 🍒 Cherry Pick

Apply a specific commit from another branch.

```bash
git cherry-pick <commit-id>
```

---

# 🐞 Git Bisect

Used to identify the commit that introduced a bug.

```bash
git bisect start
```

Performs a binary search through commit history.

---

# 🚀 Key Concepts Learned

- Local Repository
- Remote Repository
- Working Directory
- Staging Area
- Commit Lifecycle
- Branching Strategy
- Merge Workflow
- Rebase Workflow
- Stash Operations
- Commit Recovery
- Repository Synchronization
- Collaboration using GitHub

---

# 📈 Commands Practiced

| Category | Commands |
|-----------|-----------|
| Repository Setup | git init, git clone, git config |
| Tracking | git add, git status |
| Commits | git commit, git log, git show |
| Branching | git branch, git switch, git checkout |
| Collaboration | git fetch, git pull, git push |
| Merging | git merge |
| Stashing | git stash, git stash apply, git stash pop |
| Cleanup | git rm, git clean |
| Recovery | git reset, git revert |
| Advanced | git cherry-pick, git bisect |
| Releases | git tag |

---

## 👨‍💻 Author

**Amarnath Kolla**
-Learning Git, GitHub, Linux, Cloud Computing and .NEt .
