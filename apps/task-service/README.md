## **📌 Ubiquitous Language – Task Management Core Subdomain**  

### **1️⃣ Core Entities & Value Objects**  

| Term | Definition |
|------|------------|
| **Task** | A work item that a user needs to complete. It has a title, description, status, priority, and due date. |
| **Task List** | A collection of tasks, used to organize related work items. |
| **User** | The person who owns tasks and task lists. |
| **Due Date** | A date and time by which a task should be completed. |
| **Priority** | The level of importance assigned to a task (e.g., Low, Medium, High). |
| **Status** | The current state of a task (e.g., Pending, In Progress, Completed). |
| **Task Note** | Additional information added to a task, separate from its description. |

---

### **2️⃣ Task Lifecycle & Behaviors**  

| Term | Definition |
|------|------------|
| **Create Task** | The process of defining a new task with a title, description, and optional details. |
| **Update Task** | The action of modifying task details such as title, description, due date, or priority. |
| **Complete Task** | Marking a task as finished, changing its status to "Completed." |
| **Delete Task** | Permanently removing a task from the system. |
| **Reopen Task** | Changing a completed task back to an active state (e.g., "Pending" or "In Progress"). |
| **Prioritize Task** | Assigning a priority level to indicate urgency or importance. |
| **Assign Due Date** | Setting a deadline for completing a task. |
| **Move Task** | Transferring a task from one task list to another. |
| **Archive Task** | Storing a task that is no longer active but may be referenced later. |

---

### **3️⃣ Task Relationships & Organization**  

| Term | Definition |
|------|------------|
| **Parent Task** | A higher-level task that consists of multiple subtasks. |
| **Subtask** | A smaller task that belongs to a parent task, breaking work into smaller steps. |
| **Dependency** | A relationship where one task must be completed before another can start. |
| **Recurring Task** | A task that automatically regenerates after a defined interval (e.g., daily, weekly). |

---

### **4️⃣ Constraints & Business Rules**  

| Rule | Description |
|------|------------|
| **A task must have a title.** | The system requires a title for each task. |
| **A completed task cannot be edited.** | Once a task is marked as "Completed," it cannot be modified (unless reopened). |
| **A task must belong to a user.** | Every task must have an assigned owner. |
| **Tasks can be moved between lists but cannot belong to multiple lists at the same time.** | A task is part of one list at a time. |
| **Tasks cannot have due dates in the past at the time of creation.** | Ensures valid scheduling of tasks. |

Great decision! **Domain events** are essential in DDD because they help model real-world changes explicitly and enable event-driven architecture. Let's define domain events for the **Task Management** core subdomain.

---

## **📌 Domain Events for Task Management Core Subdomain**  

### **1️⃣ Core Domain Events**  

| Event Name | Description | Trigger |
|------------|------------|---------|
| **TaskCreated** | A new task has been created. | When a user successfully adds a new task. |
| **TaskUpdated** | A task’s details (e.g., title, description, due date, priority) have changed. | When a user modifies an existing task. |
| **TaskCompleted** | A task has been marked as "Completed." | When a user marks a task as done. |
| **TaskDeleted** | A task has been removed permanently. | When a user deletes a task. |
| **TaskReopened** | A previously completed task is set back to an active state. | When a user decides to work on a completed task again. |
| **TaskPrioritized** | The priority of a task has changed. | When a user updates the task's priority level. |
| **TaskMoved** | A task has been transferred from one task list to another. | When a user moves a task. |
| **TaskArchived** | A task is no longer active but stored for future reference. | When a user archives a task. |

---

### **2️⃣ Extended Domain Events (Optional, Based on Business Needs)**  

| Event Name | Description | Trigger |
|------------|------------|---------|
| **TaskDueDateChanged** | The due date of a task has been updated. | When a user assigns or modifies a due date. |
| **TaskOverdue** | A task has not been completed by its due date. | When the current time surpasses a task’s due date. |
| **RecurringTaskGenerated** | A new instance of a recurring task has been created. | When a recurring task is scheduled to regenerate. |
| **TaskDependencyCompleted** | A dependent task has been completed. | When all prerequisite tasks for a dependent task are marked as done. |
