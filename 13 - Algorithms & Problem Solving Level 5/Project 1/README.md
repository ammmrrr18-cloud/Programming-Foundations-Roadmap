# Doubly Linked List Generic Class

This project represents a complete engineering application to build a Doubly Linked List data structure from scratch. It falls under the category of **Functional Systems**, as it was designed as an independent and fully reusable programmatic tool for complex projects that require customized and flexible dynamic memory management.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a Generic Template Class built in C++, allowing developers to store and manage any type of data within a doubly linked list. Each element (Node) in the list maintains two pointers; one points to the next node and the other points to the previous node, granting the developer complete flexibility to navigate through memory in both directions with high efficiency and ultimate speed.

---

## 🛠️ System Features

The system contains a comprehensive package of operations and functions covering all data structure manipulation needs:

### 1. Insertion Operations
* **Insert at Beginning:** Inserts a new element to immediately become the head of the list via the function `InsertAtBeginning(T value)`.
* **Insert at End:** Smartly traverses to the end of the list and appends the final element via the function `InsertAtEnd(T value)`.
* **Custom Insertion After Node:** Allows adding a new element after a specific node pointer via the function `InsertAfter(Node* current, T value)`.
* **Custom Insertion After Index:** Allows adding a new element after a specific index number via the function `InsertAfter(int index, T Value)`.

### 2. Deletion & Cleanup
* **Delete Custom Node:** Passes a pointer to a specific node and safely deletes it while reconnecting the surrounding elements via the function `DeleteNode(Node*& NodeToDelete)`.
* **Delete First Node:** Removes the element from the beginning of the list and safely updates the head pointer via the function `DeleteFirstNode()`.
* **Delete Last Node:** Traverses to the end of the list, removes the last element, and updates the pointers via the function `DeleteLastNode()`.
* **Clear Entire List:** Completely deallocates all reserved memory using a mechanism that prevents any memory leaks via the function `Clear()`.

### 3. Search & Control
* **Smart Search:** Searches for a specific value within the list and returns its memory address pointer via the function `Find(T Value)`.
* **Access Node Pointer by Index:** Retrieves a specific node pointer based on the passed index number via the function `GetNode(int index)`.
* **Access Value by Index:** Retrieves the value of a specific element based on the passed index number via the function `GetItem(int Index)`.
* **Update and Modify:** Directly and safely modifies the value of an existing element based on its index via the function `UpdateItem(int index, T NewValue)`.
* **Reverse List:** An innovative mechanism to swap pointers and completely reverse the order of elements in memory via the function `Reverse()` with the assistance of the function `SwapPointers(Node* &Current, Node* &Temp)`.
* **Size Monitoring & Checking:** Immediate functions to determine the current number of elements via the function `Size()` and check if the list is empty via the function `IsEmpty()`.
* **Print List:** Sequentially displays all elements of the list on the screen via the function `PrintList()`.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** are divided into two main levels to ensure encapsulation and separation of concerns:

* **Private Node Struct:** Represents the micro-entity of data (the building block), containing the value and the twin pointers (Next / Prev) represented within the internal class `class Node`. It cannot be accessed or modified except through the main class to ensure data security (Encapsulation).
* **Public Interface:** Provides developers with the set of executive functions for full control over data movement and memory without having to worry about complex pointer details.

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **Low-Level Memory Management:** Direct handling of dynamic allocation and deallocation to prevent memory leaks (Memory Management).
* **Generic Programming:** Separating the data structure logic from the type of stored data to provide maximum reusability.
* **Clean Design Principles:** Organizing code and separating interfaces ensures easy tracking of programmatic operations and seamless error detection and correction.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Encapsulation & Architecture)**
* **C++ Templates (Generic Programming)**
* **Dynamic Memory Management (Pointers & Heap Allocation)**

================================================================================

# القائمة المتصلة المزدوجة الديناميكية | Doubly Linked List Generic Class

هذا المشروع يمثل تطبيقاً هندسياً متكاملاً لبناء هيكل بيانات القائمة المتصلة المزدوجة من الصفر، وهو يندرج تحت تصنيف **Functional Systems** حيث تم تصميمه كأداة برمجية مستقلة وقابلة وإعادة الاستخدام بالكامل في المشاريع المعقدة التي تتطلب إدارة مخصصة ومرنة للذاكرة الديناميكية.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن فئة قالب عامة (Generic Template Class) تم بناؤها بلغة C++، تتيح للمطورين تخزين وإدارة أي نوع من البيانات داخل قائمة متصلة مزدوجة. تتميز القائمة بأن كل عنصر فيها (Node) يحتفظ بمؤشرين؛ أحدهما يشير إلى العنصر التالي والآخر يشير إلى العنصر السابق، مما يمنح المطور مرونة كاملة في التحرك داخل الذاكرة في الاتجاهين بكفاءة عالية وسرعة فائقة.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يحتوي النظام على حزمة متكاملة من العمليات والوظائف التي تغطي كافة احتياجات التعامل مع هياكل البيانات:

### 1. عمليات الإضافة والإدراج (Insertion Operations)
* ** can الإضافة في البداية:** إدراج عنصر جديد ليصبح رأس القائمة فوراً عبر الدالة `InsertAtBeginning(T value)`.
* **الإضافة في النهاية:** الانتقال الذكي لنهاية القائمة وإضافة العنصر الأخير عبر الدالة `InsertAtEnd(T value)`.
* **الإدراج المخصص بعد عنصر:** إمكانية إضافة عنصر جديد بعد مؤشر عنصر معين عبر الدالة `InsertAfter(Node* current, T value)`.
* **الإدراج المخصص بعد دليل:** إمكانية إضافة عنصر جديد بعد رقم دليل محدد عبر الدالة `InsertAfter(int index, T Value)`.

### 2. عمليات الحذف والتنظيف (Deletion & Cleanup)
* **حذف عنصر مخصص:** تمرير مؤشر لعنصر معين وحذفه بأمان مع إعادة ربط العناصر المحيطة به عبر الدالة `DeleteNode(Node*& NodeToDelete)`.
* **حذف العنصر الأول:** إزالة العنصر من بداية القائمة وتحديث مؤشر الرأس بأمان عبر الدالة `DeleteFirstNode()`.
* **حذف العنصر الأخير:** الانتقال لنهاية القائمة وإزالة العنصر الأخير وتحديث المؤشرات عبر الدالة `DeleteLastNode()`.
* **تنظيف القائمة كاملة:** تفريغ الذاكرة المحجوزة بالكامل بآلية تضمن عدم حدوث أي تسريب في الذاكرة عبر الدالة `Clear()`.

### 3. عمليات البحث والاستعلام والتحكم (Search & Control)
* **البحث الذكي:** البحث عن قيمة معينة داخل القائمة وإرجاع مؤشر عنوانها في الذاكرة عبر الدالة `Find(T Value)`.
* **الوصول للمؤشر بالدليل:** جلب مؤشر عنصر محدد بناءً على رقم الدليل الممرر عبر الدالة `GetNode(int index)`.
* **الوصول للقيمة بالدليل:** جلب قيمة عنصر محدد بناءً على رقم الدليل الممرر عبر الدالة `GetItem(int Index)`.
* **التحديث والتعديل:** تعديل قيمة عنصر موجود بالفعل بشكل مباشر وآمن بناءً على دليله عبر الدالة `UpdateItem(int index, T NewValue)`.
* **عكس القائمة:** آلية مبتكرة لتبديل المؤشرات وعكس ترتيب العناصر بالكامل في الذاكرة عبر الدالة `Reverse()` ومساعدة الدالة `SwapPointers(Node* &Current, Node* &Temp)`.
* **مراقبة الحجم والفحص:** دوال فورية لمعرفة عدد العناصر الحالية عبر الدالة `Size()` وفحص ما إذا كانت القائمة فارغة أم لا عبر الدالة `IsEmpty()`.
* **طباعة القائمة:** عرض جميع عناصر القائمة بشكل متسلسل في الشاشة عبر الدالة `PrintList()`.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم وتوزيع المسؤوليات داخل هذا الـ **Functional System** إلى مستويين رئيسيين لضمان الخصوصية وفصل المهام:

* **الهيكل الداخلي الخاص (Private Node Struct):** يمثل الكيان المصغر للبيانات (الطوبة الأساسية)، ويحتوي على القيمة وثنائي المؤشرات (Next / Prev) متمثلاً في كلاس `class Node` الداخلي، ولا يمكن الوصول إليه أو التعديل عليه إلا من خلال الفئة الرئيسية لضمان أمان البيانات (Encapsulation).
* **الواجهة العامة الفعالة (Public Interface):** توفر للمطورين مجموعة الدوال التنفيذية للتحكم التام في حركة البيانات والذاكرة دون الحاجة للانشغال بالتفاصيل المعقدة للمؤشرات.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **إدارة الذاكرة منخفضة المستوى:** التعامل المباشر مع الحجز الديناميكي وإلغائه لمنع تسريب الذاكرة (Memory Management).
* **البرمجة العامة (Generic Programming):** فصل منطق هيكل البيانات عن نوع المعطيات المخزنة لتوفير أقصى مرونة لإعادة الاستخدام.
* **مبادئ التصميم النظيف:** تنظيم الكود وفصل الواجهات يضمن سهولة تتبع سير العمليات البرمجية واكتشاف الأخطاء وتصحيحها بسلاسة.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Encapsulation & Architecture)**
* **C++ Templates (Generic Programming)**
* **Dynamic Memory Management (Pointers & Heap Allocation)**
