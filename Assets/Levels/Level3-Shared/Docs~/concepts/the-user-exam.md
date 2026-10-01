## C# — The User Exam

**Goal:** you know what the **Unity Certified User: Programmer** exam covers, where in
this course you learned each part, how its questions are written, and how to work
through them without falling into their traps.

### Idea — the exam

The **Unity Certified User: Programmer** exam is Unity's first certificate for
programmers. You take it on a computer, at a test centre or online, in a set time.
Most questions give you some code, a Unity window or a description, and four answers
to choose from; some ask you to choose more than one, or to put things in order.

Unity's certification pages list the current number of questions, the time and the
pass mark, and they change from time to time: check them with your trainer before you
book. Unity also publishes an official practice test, to take before the real one.

### Idea — what it covers, and where you learned it

The exam's objectives come in four groups. Every one has a place in this course:

| | Objective | Where you learned it |
| --- | --- | --- |
| **1.1** | given a Console message, write the code that printed it | Levels 0 and 1: `Debug.Log`, string interpolation |
| **1.2** | given code and its error, find which object is `null` | Level 2: null and debugging |
| **1.3** | choose the right class member and syntax for a task | Level 2: the Unity docs, `GetComponent` |
| **2.1** | variables, modifiers, arrays, lists and dictionaries | Levels 1 and 2 |
| **2.2** | write a valid method declaration | Level 2: methods in depth |
| **2.3** | choose the call that makes a state play, Animator included | Level 3: {{ref:animcode}} |
| **2.4** | read the keyboard and touch | Levels 1 and 2: the Input System |
| **2.5** | logic and flow: `if`, `switch`, loops, `&&`, `\|\|`, `!` | Level 1 |
| **2.6** | respond when a UI element reports a change | Level 2: UI events |
| **3.1** | event functions, and when Unity calls each | Level 2: event functions |
| **3.2** | spot a wrongly declared data type | Level 3: {{ref:errors}} |
| **3.3** | spot `public`/`private` misuse, Animation Events included | Level 3: {{ref:errors}}, {{ref:animevents}} |
| **3.4** | tell an ECS class from the other kinds | Level 3: {{ref:classes}} |
| **3.5** | recognise Unity's naming conventions | Level 3: {{ref:naming}} |
| **3.6** | choose the comment that describes code accurately | Levels 0 and 3: {{ref:reading}} |
| **4.1** | the editor windows: what each is for | Level 0 |
| **4.2** | change the code editor Unity opens scripts in | Level 0 |
| **4.3** | build a state machine from clips and property settings | Level 3: {{ref:animwindow}}, {{ref:animator}} |
| **4.4** | program a state machine in the Animator Controller | Level 3: {{ref:animator}} |

The **Check Yourself** part at the end of this book has exam-style questions on every
one of them, a practice paper, and a cheat sheet.

### Idea — how the questions are written

| Question says… | It wants… |
| --- | --- |
| "What does this code print?" | trace it, on paper, line by line ({{ref:reading}}) |
| "Which line causes an error?" | the line that doesn't compile, not the one that would be bad style |
| "Which comment best describes…" | the option true word for word; the others are each slightly wrong |
| "Which code should replace `// TODO`…" | the option that compiles **and** does the task: two often compile |
| "Which call makes the X state play?" | follow the arrow into X, read its condition, match the parameter's type |
| "Which name follows the conventions?" | PascalCase or camelCase, by the table in {{ref:naming}} |
| a picture of the Animator or the Inspector | read every setting it shows: one of them is usually the point |

Watch for **NOT**, **BEST**, **FIRST** and **MOST** in the question: they turn it round.
"Which is NOT a valid declaration" wants the broken one.

### Idea — the traps, collected

| Trap | Remember |
| --- | --- |
| `3 / 5` | 0: `int` divided by `int` is an `int` |
| `update()`, `start()` | compile, and Unity never calls them |
| `"speed"` for a parameter called `Speed` | names are exact: a warning while playing, and nothing animates |
| **Has Exit Time** on | the transition waits for the clip to finish |
| a trigger set when no transition can use it | it stays set, and fires later |
| `if (x = 5)` | assignment, not comparison: a compile error in C# |
| `Awake` and `Start` | every `Awake` runs before any `Start` |
| `GetComponent<Rigidbody>()` on a 2D object | `null`: the 2D component is `Rigidbody2D` |
| `private` methods called from another script | `CS0122`: inaccessible |
| an Animation Event on a child's script | no receiver: the method must be beside the Animator |
| `float f = 1.5;` | `1.5` is a `double`: write `1.5f` |

### Idea — on the day

- **Read the code before the question's answers.** Work out what it does; then look
  for that answer.
- **Rule out.** Two answers are usually clearly wrong. Of the last two, find the word
  that makes one of them false.
- **Trace when it matters.** A small table on scrap paper beats a guess.
- **Don't get stuck.** Mark a hard question, answer the easy ones, and come back. An
  unanswered question can't score.
- **Check the units.** Seconds or frames? 0 to 1, or 0 to 100?

### Do it

1. For each objective in the table, write one line of code, or one sentence, that
   shows it. Where you can't, go back to the chapter it names.
2. Work through the Check Yourself questions at the end of this book, on paper, before
   reading the answers.
3. Take the practice paper with a timer, as if it were the real exam.

### Challenge

Write an exam question of your own for any objective: a stem, four answers and one
right one, with three wrong answers that are each *nearly* right. Swap with a partner,
answer each other's, and explain why each wrong answer is wrong.
