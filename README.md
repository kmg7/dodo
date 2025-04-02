# dodo

A Todo system is used to manage tasks efficiently. Users create, organize, and track their tasks, ensuring productivity and prioritization.

## Subdomains & Bounded Contexts
---

### **1. Core Task Management (Core Subdomain)**  
💡 *Handles core task creation, updates, and organization.*  

**Bounded Context: Task Management**  
- **Task** (title, description, priority, due date, status)  
- **Task List** (grouping of tasks)  
- **User** (task owner)  
- **Task Lifecycle** (creation → progress → completion)  

✅ Key Features:  
- CRUD operations on tasks  
- Task prioritization & due dates  
- Task grouping into lists  
- Task progress tracking  

---

### **2. Collaboration (Supporting Subdomain)**  
💡 *Manages shared tasks and team collaboration.*  

**Bounded Context: Collaboration**  
- **Shared Task** (tasks assigned to multiple users)  
- **Permissions** (who can edit/complete a shared task)  
- **Task Comments** (user discussions on tasks)  

✅ Key Features:  
- Share tasks with others  
- Define user roles (owner, editor, viewer)  
- Commenting and discussions on tasks  

---

### **3. Notifications & Reminders (Supporting Subdomain)**  
💡 *Ensures users are notified about important tasks.*  

**Bounded Context: Notifications**  
- **Reminder** (scheduled alerts for tasks)  
- **Notification Channel** (email, push, SMS, etc.)  

✅ Key Features:  
- Task reminders at specific times  
- User-configurable notification preferences  
- Recurring reminders  

---

### **4. Tagging & Organization (Generic Subdomain)**  
💡 *Enhances task searchability and filtering.*  

**Bounded Context: Tagging**  
- **Tag** (labels for tasks)  
- **Search & Filtering** (find tasks by tags, priority, or due date)  

✅ Key Features:  
- Add and manage task tags  
- Search and filter tasks efficiently  

---

### **5. Reporting & Insights (Generic Subdomain)**  
💡 *Provides productivity analytics and task tracking.*  

**Bounded Context: Reporting**  
- **Task Completion Metrics**  
- **Overdue Task Reports**  
- **User Productivity Trends**  

✅ Key Features:  
- Generate reports on task completion rates  
- Identify overdue and pending tasks  
- Visualize productivity trends  

---

### **6. Identity & Access Management (IAM) (Core Subdomain)**  
💡 *Manages user authentication, roles, and permissions.*  

**Bounded Context: Identity & Access Management (IAM)**  
- **User Account** (username, email, password, profile info)  
- **Authentication** (login, logout, session management)  
- **Authorization** (roles and permissions)  
- **Access Control** (defining what actions users can perform)  

✅ Key Features:  
- Secure user authentication (OAuth, JWT, etc.)  
- Role-based access control (RBAC)  
- User account management (password reset, MFA, etc.)  
- Permission handling for shared tasks  

---
