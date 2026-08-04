# 🎓 Students Management System

An **educational project for practicing C# Windows Forms**.  
The main goal of this project is to apply what I have learned through building a small Student Management System, rather than creating a professional or Production Ready application.

## 📌 Project Idea

The application allows users to manage students through:

- ➕ Add a student.
- ✏️ Edit student information.
- 🗑️ Delete a student.
- 🪪 Display a Student ID Card.
- 🎲 Generate students automatically with sample data.
- 👀 Change the `ListView` display mode.
- 🔔 Show notifications using `NotifyIcon`.
- 🖼️ Display student images using `ImageList` and `PictureBox`.

## 🧠 Main Concepts Learned and Applied

### Windows Forms Controls

I practiced working with:

- `TextBox`
- `MaskedTextBox`
- `ComboBox`
- `RadioButton`
- `GroupBox`
- `Button`
- `ListView`
- `ListViewItem`
- `PictureBox`
- `ImageList`
- `NotifyIcon`

### Events

I worked with Events such as:

- `Click`
- `SelectedIndexChanged`
- `Load`

This helped me understand how Events are connected to user actions and how the application responds to them.

### Methods and Code Reusability

I divided the code into separate Methods, each responsible for a specific task, such as:

- `ClearInputs()`
- `UpdateStudentData()`
- `IsAnyGenderSelected()`
- `AreStudentInputsValid()`
- `FindFirstMissingStudentInput()`
- `ChangeControlColore()`
- `ShowNotify()`
- `HasStudentsInListView()`
- `HasSelectedStudent()`
- `CheckStudentListAndSelection()`
- `ShowMessage()`
- `AssignValues()`
- `GetStudentImageByGender()`

The main purpose was to reduce code duplication and practice code reuse.

### Validation

I implemented Validation to make sure that all required student information is entered before adding or updating a student:

- ID
- Name
- Email
- Phone
- Grade
- Gender

For the `MaskedTextBox`, I used:

`MaskCompleted`

to make sure that the phone number is completely entered.

I also created:

`FindFirstMissingStudentInput()`

to find the first missing input and return it as a `Control`.

The missing Control is then:

- Highlighted in red.
- Focused automatically.
- Reset to its normal color on the next attempt.

### Add / Update Mode

I used:

`bool isEditMode`

to make the same `Add` Button work in two different modes:

- `isEditMode = false` → Add
- `isEditMode = true` → Update

The Button text also changes between `Add` and `Update` depending on the current application mode.

This was practical training on using a **Boolean State** to make the same Event execute different logic depending on the current mode.

### ListView

I used `ListView` to display students and practiced working with:

- `ListViewItem`
- `SubItems`
- `SelectedItems`
- Adding data.
- Updating data.
- Deleting data.
- Selecting students.
- Changing the View.

The following View modes were implemented:

- `Details`
- `LargeIcon`
- `SmallIcon`
- `List`
- `Tile`

### ImageList

I used `ImageList` to store student images and connect them to the `ListView` using `ImageIndex`.

A different image is selected based on the student's Gender, and `PictureBox` is then used to display the student's image inside the ID Card.

I also created:

`GetStudentImageByGender()`

to select the appropriate student image.

### NotifyIcon

I used `NotifyIcon` to display notifications after important operations, such as:

- Student Added
- Student Updated
- Student Deleted
- Students Generated

I also created `ShowNotify()` to reuse the notification logic.

### MessageBox

I created `ShowMessage()` to reduce repeated `MessageBox.Show()` code.

I also practiced using **Default Parameters** with:

- `MessageBoxIcon`
- `MessageBoxButtons`

### CheckStudentListAndSelection

I created a general Method:

`CheckStudentListAndSelection(string Action)`

and used it with operations such as:

- Edit
- Delete
- Show Card

It checks:

1. Whether there are students in the `ListView`.
2. Whether a student is selected.

This helped reduce repeated validation logic across multiple Buttons.

### Multiple Forms

The project contains:

- `frmStudentsManagement` → Main Form and student management.
- `frmIdCard` → Displays the student's ID Card.
- `InputBox` → Allows the user to enter the number of students to generate.

I practiced working with:

- `Show()`
- `ShowDialog()`
- `Form.Load`

I also practiced sharing student data between Forms using `static` variables.

### Generate Students

I implemented a feature to automatically generate students using:

- `Random`
- `for`
- `ListViewItem`
- `ComboBox`
- `RadioButton`
- `ImageList`

The number of students is entered through the `InputBox`, then sample student data is generated and added to the `ListView`.

## 🏗️ Project Structure

```text
Students Management
│
├── frmStudentsManagement
│   ├── Add
│   ├── Update
│   ├── Edit
│   ├── Delete
│   ├── Generate Students
│   ├── Show Card
│   ├── Validation
│   ├── ListView
│   ├── ImageList
│   ├── PictureBox
│   └── NotifyIcon
│
├── frmIdCard
│   └── Displays student information and image
│
├── InputBox
│   └── Gets the number of students to generate
│
└── Resources
    └── Student Images


## 💡 What I Learned

This project was a practical experience that helped me apply what I have learned in C# and Windows Forms instead of focusing only on the theoretical side.

Through this project, I gained a better understanding of how to build a simple user interface, work with Controls and Events, organize code using Methods, validate user input, and work with multiple Forms within the same project.

The project also helped me understand how to break a problem into smaller parts, reuse code instead of repeating it, and handle different application states depending on the user's actions.

This project is educational and mainly focused on learning and practice. The goal is to apply the concepts I have learned practically, rather than creating a professional or Production Ready application.

The project can be improved in the future by adding a Database, improving the project structure, and organizing the application Architecture in a more advanced way.

> 🚀 Keep Learning, Keep Building





_____________________________________________________________________________________________________________________________________________________________________________






# 🎓 Students Management System

مشروع **تعليمي للتدريب على C# Windows Forms**، الهدف الأساسي منه هو تطبيق ما تم تعلمه عمليًا من خلال بناء برنامج صغير لإدارة الطلاب، وليس بناء مشروع احترافي أو Production Ready.

## 📌 فكرة المشروع

البرنامج يسمح بإدارة الطلاب من خلال:

- ➕ إضافة طالب.
- ✏️ تعديل بيانات طالب.
- 🗑️ حذف طالب.
- 🪪 عرض Student ID Card.
- 🎲 إنشاء طلاب تلقائيًا ببيانات تجريبية.
- 👀 تغيير طريقة عرض الـ `ListView`.
- 🔔 إظهار Notifications باستخدام `NotifyIcon`.
- 🖼️ عرض صور الطلاب باستخدام `ImageList` و `PictureBox`.

## 🧠 أهم ما تم تعلمه وتطبيقه

### Windows Forms Controls

تم التطبيق العملي على:

- `TextBox`
- `MaskedTextBox`
- `ComboBox`
- `RadioButton`
- `GroupBox`
- `Button`
- `ListView`
- `ListViewItem`
- `PictureBox`
- `ImageList`
- `NotifyIcon`

### Events

تم التعامل مع Events مثل:

- `Click`
- `SelectedIndexChanged`
- `Load`

وفهم فكرة ربط الـ Event بالـ Action الذي يقوم به المستخدم.

### Methods وإعادة استخدام الكود

تم تقسيم البرنامج إلى Functions مسؤولة عن مهام محددة، مثل:

- `ClearInputs()`
- `UpdateStudentData()`
- `IsAnyGenderSelected()`
- `AreStudentInputsValid()`
- `FindFirstMissingStudentInput()`
- `ChangeControlColore()`
- `ShowNotify()`
- `HasStudentsInListView()`
- `HasSelectedStudent()`
- `CheckStudentListAndSelection()`
- `ShowMessage()`
- `AssignValues()`
- `GetStudentImageByGender()`

والهدف من ذلك هو تقليل تكرار الكود وإعادة استخدام الـ Methods.

### Validation

تم عمل Validation للتأكد من اكتمال بيانات الطالب قبل الإضافة أو التعديل:

- ID
- Name
- Email
- Phone
- Grade
- Gender

وبالنسبة للـ `MaskedTextBox` تم استخدام:

`MaskCompleted`

للتأكد من أن رقم الهاتف مكتمل.

كما تم إنشاء:

`FindFirstMissingStudentInput()`

للبحث عن أول Control ناقص وإرجاعه كـ `Control`، ثم:

- تغييره إلى اللون الأحمر.
- إعطائه `Focus`.
- إعادة اللون للوضع الطبيعي عند المحاولة التالية.

### Add / Update Mode

تم استخدام:

`bool isEditMode`

لجعل نفس زرار `Add` يعمل في وضعين:

- `isEditMode = false` → Add
- `isEditMode = true` → Update

وبالتالي نفس الـ Button يتغير اسمه من `Add` إلى `Update` حسب حالة البرنامج.

وهذا كان تدريبًا عمليًا على استخدام الـ Boolean State لجعل نفس الـ Event ينفذ Logic مختلف حسب الـ Mode.

### ListView

تم استخدام `ListView` لعرض الطلاب، مع التدريب على:

- `ListViewItem`
- `SubItems`
- `SelectedItems`
- إضافة البيانات.
- تعديل البيانات.
- حذف البيانات.
- تحديد الطالب.
- تغيير View.

وتم تطبيق:

- `Details`
- `LargeIcon`
- `SmallIcon`
- `List`
- `Tile`

### ImageList

تم استخدام `ImageList` لتخزين صور الطلاب وربطها بالـ `ListView` باستخدام `ImageIndex`.

يتم اختيار صورة مختلفة حسب الـ Gender، ثم يتم استخدام `PictureBox` لعرض صورة الطالب في الـ ID Card.

كما تم إنشاء:

`GetStudentImageByGender()`

لاختيار صورة الطالب المناسبة.

### NotifyIcon

تم استخدام `NotifyIcon` لعرض إشعارات بعد العمليات المهمة، مثل:

- Student Added
- Student Updated
- Student Deleted
- Students Generated

وتم إنشاء `ShowNotify()` لإعادة استخدام كود الإشعار.

### MessageBox

تم إنشاء `ShowMessage()` لتقليل تكرار `MessageBox.Show()`، مع استخدام Default Parameters للـ `MessageBoxIcon` و `MessageBoxButtons`.

### CheckStudentListAndSelection

تم إنشاء Function عامة:

`CheckStudentListAndSelection(string Action)`

وتستخدم مع عمليات مثل:

- Edit
- Delete
- Show Card

وتتأكد من:

1. وجود طلاب في الـ `ListView`.
2. وجود طالب محدد.

وبذلك تم تقليل تكرار نفس الـ Validation في أكثر من Button.

### Multiple Forms

المشروع يحتوي على:

- `frmStudentsManagement` → الـ Main Form وإدارة الطلاب.
- `frmIdCard` → عرض بيانات الطالب في ID Card.
- `InputBox` → إدخال عدد الطلاب المطلوب إنشاؤهم.

تم التدريب على:

- `Show()`
- `ShowDialog()`
- `Form.Load`

كما تم مشاركة بيانات الطالب بين الـ Forms باستخدام `static` variables.

### Generate Students

تم إنشاء ميزة لتوليد طلاب تلقائيًا باستخدام:

- `Random`
- `for`
- `ListViewItem`
- `ComboBox`
- `RadioButton`
- `ImageList`

ويتم تحديد عدد الطلاب من خلال `InputBox` ثم إنشاء بيانات تجريبية وإضافتها إلى الـ `ListView`.

## 🏗️ Structure

```text
Students Management
│
├── frmStudentsManagement
│   ├── Add
│   ├── Update
│   ├── Edit
│   ├── Delete
│   ├── Generate Students
│   ├── Show Card
│   ├── Validation
│   ├── ListView
│   ├── ImageList
│   ├── PictureBox
│   └── NotifyIcon
│
├── frmIdCard
│   └── عرض بيانات الطالب وصورته
│
├── InputBox
│   └── إدخال عدد الطلاب
│
└── Resources
    └── Student Images


أ.
.## 💡 What I Learned

هذا المشروع كان تجربة عملية ساعدتني على تطبيق ما تعلمته في لغة C# وWindows Forms بدلًا من الاكتفاء بالجانب النظري.

ومن خلاله أصبحت أفهم بشكل أفضل كيفية بناء واجهة بسيطة، والتعامل مع عناصر التحكم والأحداث، وتنظيم الكود باستخدام الدوال، والتحقق من صحة البيانات، والتعامل مع أكثر من نافذة داخل نفس المشروع.

كما ساعدني المشروع على فهم فكرة تقسيم المشكلة إلى أجزاء صغيرة، وإعادة استخدام الكود بدلًا من تكراره، والتعامل مع حالات مختلفة للبرنامج حسب تصرف المستخدم.

هذا المشروع تعليمي بالدرجة الأولى، والهدف منه هو التعلم والتدريب وتطبيق المفاهيم التي تعلمتها عمليًا، وليس الوصول إلى مشروع احترافي أو جاهز للاستخدام الفعلي.

ويمكن تطوير المشروع مستقبلًا بإضافة قاعدة بيانات وتحسين هيكل المشروع وتنظيمه بشكل أكبر.

> 🚀 Keep Learning, Keep Building

